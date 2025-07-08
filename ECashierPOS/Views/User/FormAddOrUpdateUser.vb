Imports ECashierPOS.Controllers
Imports ECashierPOS.Models.DTO

Public Class FormAddOrUpdateUser
    Private ReadOnly controller As UserController
    Private userId As String = Nothing
    Public Event OnReloadUsers As EventHandler

    Public Sub New(userController As UserController)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.controller = userController
    End Sub

    Public Sub New(userController As UserController, userId As String)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.controller = userController
        Me.userId = userId
    End Sub

    Private Sub FormAddOrUpdateUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim roles As New List(Of String) From {"kasir", "admin"}
        cbRole.DataSource = roles

        If Not String.IsNullOrEmpty(userId) Then
            ' Edit mode
            Dim user = controller.GetUserById(userId)
            If user.Success AndAlso user.Data IsNot Nothing Then
                txtUsername.Text = user.Data.Username
                txtFullName.Text = user.Data.FullName
                cbRole.SelectedItem = user.Data.Role
                btnSave.Text = "Perbarui"
            End If
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(userId) Then
            ' Insert mode
            Dim createUserRequest As New UserDTO With {
                .Username = txtUsername.Text.Trim(),
                .FullName = txtFullName.Text.Trim(),
                .Role = cbRole.SelectedItem.ToString(),
                .Password = labelPassword.Text.Trim()
            }
            Dim createResult = controller.AddUser(createUserRequest)

            If createResult.Success Then
                MessageBox.Show("User berhasil ditambahkan")
            Else
                MessageBox.Show("Gagal menambahkan user: " & createResult.Message)
            End If
        Else
            ' Update mode
            Dim updateUserRequest As New UserDTO With {
                .Id = userId,
                .Username = txtUsername.Text.Trim(),
                .FullName = txtFullName.Text.Trim(),
                .Role = cbRole.SelectedItem.ToString()
            }
            If Not String.IsNullOrEmpty(txtPassword.Text.Trim()) Then
                updateUserRequest.Password = txtPassword.Text.Trim()
            End If

            MessageBox.Show($"Isi txtPassword: {txtPassword.Text.Trim()}")

            Dim updateResult = controller.UpdateUser(updateUserRequest)
            If updateResult.Success Then
                MessageBox.Show("User berhasil diperbarui")
            Else
                MessageBox.Show("Gagal memperbarui user: " & updateResult.Message)
            End If
        End If

        RaiseEvent OnReloadUsers(Me, EventArgs.Empty)
        Me.Close()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class