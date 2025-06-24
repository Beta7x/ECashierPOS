Imports ECashierPOS.Controllers

Public Class CategoryCard
    Public Property CategoryId As String
    Private ReadOnly controller As CategoryController

    Public Event OnDeleteRequested(categoryId As String)
    Public Event OnUpdateCategory As EventHandler

    Public Property Title As String
        Get
            Return lblTitle.Text
        End Get
        Set(value As String)
            lblTitle.Text = value
        End Set
    End Property

    Public Property Content As String
        Get
            Return lblContent.Text
        End Get
        Set(value As String)
            lblContent.Text = value
        End Set
    End Property

    Public Property CountItem As String
        Get
            Return btnItem.Text
        End Get
        Set(value As String)
            btnItem.Text = $"Item {value}"
        End Set
    End Property

    Public Property CreatedAt As String
        Get
            Return lblCreatedAt.Text
        End Get
        Set(value As String)
            lblCreatedAt.Text = value
        End Set
    End Property

    Public Sub New(categoryController As CategoryController)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.controller = categoryController
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim formUpdate = New FormAddOrUpdateCategory(controller, CategoryId)

        AddHandler formUpdate.OnReloadCategory, AddressOf HandleReloadCategory

        formUpdate.StartPosition = FormStartPosition.CenterScreen
        formUpdate.ShowDialog()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Yakin mau hapus kategori?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            RaiseEvent OnDeleteRequested(CategoryId)
        End If
    End Sub

    Private Sub HandleReloadCategory(sender As Object, e As EventArgs)
        RaiseEvent OnUpdateCategory(Me, EventArgs.Empty)
    End Sub
End Class
