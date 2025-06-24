Imports ECashierPOS.Controllers
Imports ECashierPOS.Models.Entities
Imports ECashierPOS.Models.Interfaces

Public Class FormCustomer
    Private controller As CustomerController
    Private repository As ICustomerRepository

    Public Sub New(customerController As CustomerController)
        Me.controller = customerController
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub FormCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomers()
    End Sub

    Private Sub LoadCustomers()
        Dim keyword As String = textSearch.Text.Trim()
        Dim customers As New List(Of Customer)

        If String.IsNullOrWhiteSpace(keyword) Then
            Dim getAllResult = controller.GetAllCustomers()
            If getAllResult.Success AndAlso getAllResult.Data IsNot Nothing Then
                customers = getAllResult.Data
            End If
        Else
            Dim searchResult = controller.SearchCustomer(keyword)
            If searchResult.Success AndAlso searchResult.Data IsNot Nothing Then
                customers = searchResult.Data
            End If
        End If

        ' Clear all component or items in ContentPanel
        ContentPanel.Controls.Clear()

        For Each customer In customers
            Dim customerCard As New CustomerCard(controller) With {
                .CustomerId = customer.Id,
                .CustomerName = customer.Name,
                .CustomerPhone = customer.Phone,
                .CustomerAddress = customer.Address
            }
            AddHandler customerCard.OnDeleteRequested, AddressOf HandleDeleteCustomer
            AddHandler customerCard.OnUpdateCustomer, AddressOf LoadCustomers

            ContentPanel.Controls.Add(customerCard)
        Next
    End Sub

    Private Sub TextSearch_TextChanged(sender As Object, e As EventArgs) Handles textSearch.TextChanged
        LoadCustomers()
    End Sub

    Private Sub HandleDeleteCustomer(customerId As String)
        Dim deleteResult = controller.DeleteCustomer(customerId)

        If deleteResult.Success Then
            MessageBox.Show("Pelanggan berhasil dihapus")
            LoadCustomers()
        Else
            MessageBox.Show("Gagal hapus pelanggan: " & deleteResult.Message)
        End If
    End Sub

    Private Sub BtnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim formAddCustomer As New FormAddOrUpdateCustomer(controller)

        AddHandler formAddCustomer.OnReloadCustomers, AddressOf LoadCustomers

        formAddCustomer.StartPosition = FormStartPosition.CenterScreen
        formAddCustomer.ShowDialog()
    End Sub
End Class