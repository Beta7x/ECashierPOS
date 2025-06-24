Imports ECashierPOS.Controllers

Public Class FormDashboard
    Private activeButton As Guna.UI2.WinForms.Guna2Button = Nothing
    Private ReadOnly productController As ProductController
    Private ReadOnly categoryController As CategoryController
    Private ReadOnly customerController As CustomerController

    Public Sub New(
        productController As ProductController,
        categoryController As CategoryController,
        customerController As CustomerController)

        Me.productController = productController
        Me.categoryController = categoryController
        Me.customerController = customerController

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActivateButton(btnDashboard)
        LoadFormToPanel(New FormDashboardChild())
    End Sub

    Private Sub ActivateButton(senderBtn As Guna.UI2.WinForms.Guna2Button)
        If senderBtn IsNot Nothing Then
            ' Reset semua button
            If activeButton IsNot Nothing Then
                activeButton.FillColor = Color.Transparent ' Warna default
                activeButton.ForeColor = Color.White
            End If

            ' Set active button baru
            activeButton = senderBtn
            activeButton.FillColor = Color.FromArgb(241, 137, 8) ' Warna aktif
            activeButton.ForeColor = Color.White
        End If
    End Sub

    Private Sub LoadFormToPanel(childForm As Form)
        ContentPanel.Controls.Clear()
        childForm.TopLevel = False
        childForm.FormBorderStyle = BorderStyle.None
        childForm.Dock = DockStyle.Fill
        ContentPanel.Padding = New Padding(20)
        ContentPanel.Controls.Add(childForm)

        If ContentPanel.Controls.OfType(Of FormCategory)().Any() Then
            searchBox.Visible = False
        Else
            searchBox.Visible = True
        End If

        childForm.Show()
    End Sub

    Private Sub BtnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ActivateButton(btnDashboard)
        LoadFormToPanel(New FormDashboardChild())
    End Sub

    Private Sub BtnProduct_Click(sender As Object, e As EventArgs) Handles btnProduct.Click
        ActivateButton(btnProduct)
        LoadFormToPanel(New FormProduct(productController))
    End Sub

    Private Sub BtnCategory_Click(sender As Object, e As EventArgs) Handles btnCategory.Click
        ActivateButton(btnCategory)
        LoadFormToPanel(New FormCategory(categoryController))
    End Sub

    Private Sub BtnTransaction_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click
        ActivateButton(btnTransaction)
        LoadFormToPanel(New FormTransaction())
    End Sub

    Private Sub BtnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        ActivateButton(btnCustomer)
        LoadFormToPanel(New FormCustomer(CustomerController))
    End Sub

    Private Sub BtnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        ActivateButton(btnReport)
        LoadFormToPanel(New FormReport())
    End Sub

    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
    End Sub
End Class