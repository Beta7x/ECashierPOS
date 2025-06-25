Imports ECashierPOS.Controllers
Imports ECashierPOS.Helpers.FormLoader

Public Class FormDashboard
    Private activeButton As Guna.UI2.WinForms.Guna2Button = Nothing
    Private ReadOnly serviceProvider As IServiceProvider
    Private ReadOnly productController As ProductController
    Private ReadOnly categoryController As CategoryController
    Private ReadOnly customerController As CustomerController

    Public Event LogoutRequested As EventHandler

    Public Sub New(
        provider As IServiceProvider,
        productController As ProductController,
        categoryController As CategoryController,
        customerController As CustomerController)

        Me.serviceProvider = provider
        Me.productController = productController
        Me.categoryController = categoryController
        Me.customerController = customerController

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Session.CurrentUser.Role = "admin" Then
            btnReport.Visible = True
        Else
            btnReport.Visible = False
        End If

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
        'LoadFormToPanel(New FormDashboardChild())
        LoadFormToPanel(ResolveForm(Of FormDashboardChild)(serviceProvider))
    End Sub

    Private Sub BtnProduct_Click(sender As Object, e As EventArgs) Handles btnProduct.Click
        ActivateButton(btnProduct)
        LoadFormToPanel(ResolveForm(Of FormProduct)(serviceProvider))
    End Sub

    Private Sub BtnCategory_Click(sender As Object, e As EventArgs) Handles btnCategory.Click
        ActivateButton(btnCategory)
        LoadFormToPanel(ResolveForm(Of FormCategory)(serviceProvider))
    End Sub

    Private Sub BtnTransaction_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click
        ActivateButton(btnTransaction)
        'LoadFormToPanel(New FormTransaction())
        LoadFormToPanel(ResolveForm(Of FormTransaction)(serviceProvider))
    End Sub

    Private Sub BtnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        ActivateButton(btnCustomer)
        LoadFormToPanel(ResolveForm(Of FormCustomer)(serviceProvider))
    End Sub

    Private Sub BtnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        ActivateButton(btnReport)
        LoadFormToPanel(ResolveForm(Of FormReport)(serviceProvider))
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result = MessageBox.Show("Yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Session.CurrentUser = Nothing
            RaiseEvent LogoutRequested(Me, EventArgs.Empty)
        End If
    End Sub
End Class