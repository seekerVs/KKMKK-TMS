Imports System.Text.RegularExpressions

Public Class Loans_form
    Private Sub Loans_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Side_panel.Visible = False
        LoadDatagrid("SELECT * FROM loans")
        LoanDg.ClearSelection()
    End Sub

    ' Tooltips
    Private Sub refreshBtn_MouseHover(sender As Object, e As EventArgs) Handles refreshBtn.MouseHover
        ToolTip1.SetToolTip(refreshBtn, "Refresh")
    End Sub

    Private Sub createBtn_MouseHover(sender As Object, e As EventArgs) Handles createBtn.MouseHover
        ToolTip1.SetToolTip(createBtn, "Add employee data")
    End Sub

    Private Sub updateBtn_MouseHover(sender As Object, e As EventArgs) Handles updateBtn.MouseHover
        ToolTip1.SetToolTip(createBtn, "Update employee data")
    End Sub

    Private Sub deleteBtn_MouseHover(sender As Object, e As EventArgs) Handles deleteBtn.MouseHover
        ToolTip1.SetToolTip(createBtn, "Delete employee data")
    End Sub

    Private Sub BulkDeleteBtn_MouseHover(sender As Object, e As EventArgs) Handles BulkDeleteBtn.MouseHover
        ToolTip1.SetToolTip(createBtn, "Bulk delete employee data")
    End Sub

    Private Sub BulkUpdateBtn_MouseHover(sender As Object, e As EventArgs) Handles BulkUpdateBtn.MouseHover
        ToolTip1.SetToolTip(createBtn, "Delete employee data")
    End Sub


    ' Toolstrip buttons function
    Private Sub createBtn_Click(sender As Object, e As EventArgs) Handles createBtn.Click
        SideCreateMode()
    End Sub

    Private Sub refreshBtn_Click(sender As Object, e As EventArgs) Handles refreshBtn.Click
        ClearInputs()
        LoadDatagrid("SELECT * FROM loans")
    End Sub

    ' Key Events Methods *Except the Click event
    Private Sub AmountText_TextChanged(sender As Object, e As EventArgs) Handles AmountText.TextChanged
        Dim digitsOnly = New Regex("[^\d]")
        AmountText.Text = digitsOnly.Replace(AmountText.Text, "")
    End Sub

    Private Sub AmountText_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AmountText.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not e.KeyChar = "-" Then
            e.Handled = True
        End If
    End Sub


    'Main Methods
    Private Sub SideBackBtn_Click(sender As Object, e As EventArgs) Handles SideBackBtn.Click
        ClearInputs()
        SideInnerPanel1.Visible = False
        SideInnerPanel2.Visible = False
        Side_panel.Visible = False
    End Sub

    Private Sub LoadIdBtn_Click(sender As Object, e As EventArgs) Handles LoadIdBtn.Click
        Dim num As Integer = Generate7Id()
        LoanIdText.Text = num
    End Sub

    Private Sub DBInsertBtn_Click(sender As Object, e As EventArgs) Handles DBInsertBtn.Click
        Dim data As String() = {LoanIdText.Text, TransacTypeCbbox.Text, AmountText.Text}
        InsertLoan(data)
        ClearInputs()
        LoadDatagrid("SELECT * FROM loans")
    End Sub

    Private Sub LoadDatagrid(str As String)
        Try
            ReadQuery(str)
            LoanDg.Rows.Clear()
            With cmdread
                While .Read
                    LoanDg.Rows.Add(.GetValue(0), .GetValue(1), .GetValue(2), .GetValue(3), .GetValue(4), .GetValue(5))
                End While
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ClearInputs()
        LoanIdText.Clear()
        TransacTypeCbbox.Items.Remove(TransacTypeCbbox.SelectedItem)
        TransacTypeCbbox.Update()
        AmountText.Clear()
        id_txt.Clear()
        type_cbbox.Items.Remove(type_cbbox.SelectedItem)
        type_cbbox.Update()
        amount_txt.Clear()
    End Sub

    Sub SideCreateMode()
        LoanDg.ClearSelection()
        updateBtn.Enabled = False
        deleteBtn.Enabled = False
        BulkDeleteBtn.Enabled = False
        BulkUpdateBtn.Enabled = False
        SideInnerPanel1.Visible = True
        Side_panel.Visible = True
        LoadIdBtn.Enabled = True
        DBInsertBtn.Visible = True
        SideInnerPanel2.Visible = False
    End Sub

    Sub SideUpdateMode()
        SideInnerPanel1.Visible = True
        Side_panel.Visible = True
        LoadIdBtn.Enabled = True
        DBInsertBtn.Visible = True
        SideInnerPanel2.Visible = False
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        SideUpdateMode()
    End Sub

    Private Sub LoanDg_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.ColumnIndex >= 2 Then
            updateBtn.Enabled = False
            deleteBtn.Enabled = False
            BulkDeleteBtn.Enabled = True
            BulkUpdateBtn.Enabled = True
        ElseIf e.ColumnIndex = 1 Then
            updateBtn.Enabled = True
            deleteBtn.Enabled = True
            BulkDeleteBtn.Enabled = False
            BulkUpdateBtn.Enabled = False
        Else
            LoanDg.ClearSelection()
            updateBtn.Enabled = False
            deleteBtn.Enabled = False
            BulkDeleteBtn.Enabled = False
            BulkUpdateBtn.Enabled = False
        End If

    End Sub

    Private Sub LoanDg_SelectionChanged(sender As Object, e As EventArgs) Handles LoanDg.SelectionChanged
        Dim num As Integer = LoanDg.SelectedRows.Count
        select_lbl.Text = "Selected Row: " & num
        If num >= 2 Then
            updateBtn.Enabled = False
            deleteBtn.Enabled = False
            BulkDeleteBtn.Enabled = True
            BulkUpdateBtn.Enabled = True
        ElseIf num = 1 Then
            updateBtn.Enabled = True
            deleteBtn.Enabled = True
            BulkDeleteBtn.Enabled = False
            BulkUpdateBtn.Enabled = False
        Else
            'LoanDg.ClearSelection()
            updateBtn.Enabled = False
            deleteBtn.Enabled = False
            BulkDeleteBtn.Enabled = False
            BulkUpdateBtn.Enabled = False
        End If
    End Sub
End Class