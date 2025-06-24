Imports ECashierPOS.Controllers
Imports ECashierPOS.Models.DTO

Public Class FormAddOrUpdateCustomer
    Private ReadOnly controller As CustomerController
    Private customerId As String = Nothing ' Default nothing mean add mode
    Public Event OnReloadCustomers As EventHandler

    Public Sub New(customerController As CustomerController)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.controller = customerController
    End Sub

    Public Sub New(customerController As CustomerController, customerId As String)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.controller = customerController
        Me.customerId = customerId
    End Sub

    Private Sub FormAddOrUpdateCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not String.IsNullOrEmpty(customerId) Then
            ' Edit mode
            Dim customer = controller.GetCustomerById(customerId)
            If customer.Success AndAlso customer.Data IsNot Nothing Then
                txtCustomerName.Text = customer.Data.Name
                txtCustomerPhone.Text = customer.Data.Phone
                txtCustomerAddress.Text = customer.Data.Address
                btnSave.Text = "Perbarui"
            End If
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(customerId) Then
            ' Add mode
            Dim createCustomerRequest As New CustomerDTO With {
                .Name = txtCustomerName.Text,
                .Phone = txtCustomerPhone.Text,
                .Address = txtCustomerAddress.Text
            }
            Dim createResult = controller.AddCustomer(createCustomerRequest)

            If createResult.Success Then
                MessageBox.Show("Berhasil tambah pelanggan")
            Else
                MessageBox.Show($"Gagal saat tambah pelanggan: {createResult.Message}")
            End If
        Else
            ' Edit mode
            Dim updateCustomerRequest As New CustomerDTO With {
                .Id = customerId,
                .Name = txtCustomerName.Text,
                .Phone = txtCustomerPhone.Text,
                .Address = txtCustomerAddress.Text
            }
            Dim updateResult = controller.UpdateCustomer(updateCustomerRequest)
            If updateResult.Success Then
                MessageBox.Show("Pelanggan berhasil diperbarui")
            Else
                MessageBox.Show($"Pelanggan gagal diperbarui: {updateResult.Message}")
            End If
        End If

        RaiseEvent OnReloadCustomers(Me, EventArgs.Empty)
        Me.Close()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class