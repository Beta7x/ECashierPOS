Imports ECashierPOS.Controllers

Public Class CustomerCard
    Public Property CustomerId As String
    Private ReadOnly controller As CustomerController

    Public Event OnDeleteRequested(customerId As String)
    Public Event OnUpdateCustomer As EventHandler

    Public Property CustomerName As String
        Get
            Return lableCustomerName.Text
        End Get
        Set(value As String)
            lableCustomerName.Text = value
        End Set
    End Property
    Public Property CustomerPhone As String
        Get
            Return lablePhoneNumber.Text
        End Get
        Set(value As String)
            lablePhoneNumber.Text = value
        End Set
    End Property
    Public Property CustomerAddress As String
        Get
            Return labelCustomerAddress.Text
        End Get
        Set(value As String)
            labelCustomerAddress.Text = value
        End Set
    End Property

    Public Sub New(customerController As CustomerController)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.controller = customerController
    End Sub

    Private Sub HandleReloadCustomers(sender As Object, e As EventArgs)
        RaiseEvent OnUpdateCustomer(Me, EventArgs.Empty)
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim formUpdate = New FormAddOrUpdateCustomer(controller, CustomerId)

        AddHandler formUpdate.OnReloadCustomers, AddressOf HandleReloadCustomers

        formUpdate.StartPosition = FormStartPosition.CenterScreen
        formUpdate.ShowDialog()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Yakin mau hapus pelanggan?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            RaiseEvent OnDeleteRequested(CustomerId)
        End If
    End Sub
End Class
