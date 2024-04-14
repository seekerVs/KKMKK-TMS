Public Class Main_form

    Sub ChildForm(ByVal panel As Form)
        Main_panel.Controls.Clear()
        panel.TopLevel = False
        panel.Dock = DockStyle.Fill
        Main_panel.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Main_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChildForm(Home_form)
    End Sub

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        ChildForm(Home_form)
    End Sub

    Private Sub TransactionBtn_Click(sender As Object, e As EventArgs) Handles TransactionBtn.Click
        ChildForm(Transactions_form)
    End Sub

    Private Sub LoansBtn_Click(sender As Object, e As EventArgs) Handles LoansBtn.Click
        ChildForm(Loans_form)
    End Sub

    Private Sub ShareBtn_Click(sender As Object, e As EventArgs) Handles ShareBtn.Click
        ChildForm(ShareCapital_form)
    End Sub

    Private Sub MembersBtn_Click(sender As Object, e As EventArgs) Handles MembersBtn.Click
        ChildForm(Members_form)
    End Sub

    Private Sub StaffsBtn_Click(sender As Object, e As EventArgs) Handles StaffsBtn.Click
        ChildForm(Staffs_form)
    End Sub
End Class
