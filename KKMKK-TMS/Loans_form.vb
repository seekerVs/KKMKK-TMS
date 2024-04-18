Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Google.Protobuf.WellKnownTypes

Public Class Loans_form

    Dim isSelectAll As Boolean = False

    Private Sub Loans_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setLoanCbboxItem()
        Side_panel.Visible = False
        LoadDatagrid("SELECT * FROM loans")
        ResetForm()
    End Sub

    ' Tooltips
    Private Sub refreshBtn_MouseHover(sender As Object, e As EventArgs) Handles refreshBtn.MouseHover
        ToolTip1.SetToolTip(refreshBtn, "Refresh Table Data")
    End Sub

    Private Sub createBtn_MouseHover(sender As Object, e As EventArgs) Handles createBtn.MouseHover
        ToolTip1.SetToolTip(createBtn, "Add employee data")
    End Sub

    Private Sub updateBtn_MouseHover(sender As Object, e As EventArgs) Handles updateBtn.MouseHover
        ToolTip1.SetToolTip(updateBtn, "Update employee data")
    End Sub

    Private Sub deleteBtn_MouseHover(sender As Object, e As EventArgs) Handles deleteBtn.MouseHover
        ToolTip1.SetToolTip(deleteBtn, "Delete employee data")
    End Sub

    Private Sub BulkDeleteBtn_MouseHover(sender As Object, e As EventArgs) Handles BulkDeleteBtn.MouseHover
        ToolTip1.SetToolTip(BulkDeleteBtn, "Bulk delete employee data")
    End Sub

    Private Sub BulkUpdateBtn_MouseHover(sender As Object, e As EventArgs) Handles BulkUpdateBtn.MouseHover
        ToolTip1.SetToolTip(BulkUpdateBtn, "Bulk update employee data")
    End Sub

    Private Sub ExportBtn_MouseHover(sender As Object, e As EventArgs) Handles ExportBtn.MouseHover
        ToolTip1.SetToolTip(ExportBtn, "Export to PDF")
    End Sub


    ' Toolstrip buttons function
    Private Sub createBtn_Click(sender As Object, e As EventArgs) Handles createBtn.Click
        SideCreateMode()
    End Sub

    Private Sub refreshBtn_Click(sender As Object, e As EventArgs) Handles refreshBtn.Click
        ResetForm()
    End Sub

    ' Key Events Methods *Except the Click event
    Private Sub AmountText_TextChanged(sender As Object, e As EventArgs) Handles AmountText.TextChanged
        Dim digitsOnly As New Regex("[^\d\.]")
        AmountText.Text = digitsOnly.Replace(AmountText.Text, "")
    End Sub

    Private Sub AmountText_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AmountText.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub


    'Main Methods
    Private Sub ResetForm()
        ClearSearchInputs()
        ClearSideInputs()
        ResetFormMenu()
        Side_panel.Visible = False
        SideInnerPanel1.Visible = True
        sideheader_lbl.Text = "Create Loan Transaction"
        LoadIdBtn.Enabled = True
        DBInsertBtn.Visible = True
        SideInnerPanel2.Visible = False
        status_lbl.Visible = False
        StatusCbbox.Visible = False
        LoadDatagrid("SELECT * FROM loans")
    End Sub

    Private Sub ResetFormMenu()
        updateBtn.Enabled = False
        deleteBtn.Enabled = False
        BulkDeleteBtn.Enabled = False
        BulkUpdateBtn.Enabled = False
        ExportBtn.Enabled = False
    End Sub

    Private Sub ClearSideInputs()
        LoanIdText.Clear()
        TransacTypeCbbox.Items.Remove(TransacTypeCbbox.SelectedItem)
        TransacTypeCbbox.Update()
        AmountText.Clear()
        StatusCbbox.Text = Nothing
    End Sub

    Private Sub ClearSearchInputs()
        id_txt.Clear()
        type_cbbox.Items.Remove(type_cbbox.SelectedItem)
        type_cbbox.Update()
        amount_txt.Clear()
        status_cbbox.Text = Nothing
        time_dtp.CustomFormat = " "  'An empty SPACE
        time_dtp.Format = DateTimePickerFormat.Custom
        date_cbbox.Text = Nothing
    End Sub

    Private Sub SideBackBtn_Click(sender As Object, e As EventArgs) Handles SideBackBtn.Click
        ClearSearchInputs()
        ClearSideInputs()
        SideInnerPanel1.Visible = True
        SideInnerPanel2.Visible = False
        Side_panel.Visible = False
    End Sub

    Private Sub SideBackBtn2_Click(sender As Object, e As EventArgs) Handles SideBackBtn2.Click
        ClearSearchInputs()
        ClearSideInputs()
        SideInnerPanel1.Visible = False
        SideInnerPanel2.Visible = True
        Side_panel.Visible = False
    End Sub

    Private Sub LoadIdBtn_Click(sender As Object, e As EventArgs) Handles LoadIdBtn.Click
        Dim num As Integer = Generate7Id()
        LoanIdText.Text = num
    End Sub

    Private Sub DBInsertBtn_Click(sender As Object, e As EventArgs) Handles DBInsertBtn.Click
        Dim data As String() = {LoanIdText.Text, TransacTypeCbbox.Text, AmountText.Text}
        InsertLoan(data)
        ClearSearchInputs()
        ClearSideInputs()
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
            LoanDg.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub setLoanCbboxItem()
        Try

            date_cbbox.Items.Clear()
            'time_cbbox.Items.Clear()
            date_cbbox.Items.Add("")
            'time_cbbox.Items.Add("")
            Dim queryStr As String = "SELECT * FROM LOANS"
            ReadQuery(queryStr)
            With cmdread
                Dim uniqueDates As New HashSet(Of String)()
                Dim uniqueTimes As New HashSet(Of String)()
                While .Read
                    Dim date1 As Date = .GetValue(3)
                    Dim dateStr As String = date1.ToString("yyyy-MM-dd")
                    Dim time1 As TimeSpan = .GetValue(4)
                    Dim timeStr As String = time1.ToString()

                    ' Add items to the HashSet
                    uniqueDates.Add(dateStr)
                    uniqueTimes.Add(timeStr)
                End While

                ' Add item to combobox
                For Each item In uniqueDates
                    date_cbbox.Items.Add(item)
                Next
                For Each item In uniqueTimes
                    'time_cbbox.Items.Add(item)
                Next
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Sub SideCreateMode()
        ResetForm()
        Side_panel.Visible = True
        SideInnerPanel1.Visible = True
    End Sub

    Sub SideUpdateMode()
        status_lbl.Visible = True
        StatusCbbox.Visible = True
        sideheader_lbl.Text = "Update Loan Transaction"
        SideInnerPanel1.Visible = True
        Side_panel.Visible = True
        LoadIdBtn.Enabled = False
        DBInsertBtn.Visible = False
        SideInnerPanel2.Visible = False

        ' Set the selected data as default
        'Debug.WriteLine("LoanDg.SelectedRows(0).Cells(5).Value.ToString()" & LoanDg.SelectedRows(0).Cells(5).Value.ToString())
        StatusCbbox.Text = LoanDg.SelectedRows(0).Cells(5).Value.ToString()
        LoanIdText.Text = LoanDg.SelectedRows(0).Cells(0).Value.ToString()
        TransacTypeCbbox.Text = LoanDg.SelectedRows(0).Cells(1).Value.ToString()
        AmountText.Text = LoanDg.SelectedRows(0).Cells(2).Value.ToString()
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        SideUpdateMode()
    End Sub

    Private Sub LoanDg_SelectionChanged(sender As Object, e As EventArgs) Handles LoanDg.SelectionChanged
        Dim num = LoanDg.SelectedRows.Count
        UpdateRowCounter()

        If num >= 2 Then
            updateBtn.Enabled = False
            deleteBtn.Enabled = False
            BulkDeleteBtn.Enabled = True
            BulkUpdateBtn.Enabled = True
            ExportBtn.Enabled = True
        ElseIf num = 1 Then
            updateBtn.Enabled = True
            deleteBtn.Enabled = True
            BulkDeleteBtn.Enabled = False
            BulkUpdateBtn.Enabled = False
            ExportBtn.Enabled = True
        End If
    End Sub

    Private Sub LoanDg_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles LoanDg.CellContentDoubleClick
        LoanDg.ClearSelection()
        updateBtn.Enabled = False
        deleteBtn.Enabled = False
        BulkDeleteBtn.Enabled = False
        BulkUpdateBtn.Enabled = False
        ExportBtn.Enabled = False
    End Sub

    Private Sub Loans_form_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        ResetForm()
    End Sub

    Private Sub SelectAllBtn_Click(sender As Object, e As EventArgs) Handles SelectAllBtn.Click
        If isSelectAll Then
            ' if already selected all, unselect all
            LoanDg.ClearSelection()
            UpdateRowCounter()
        Else
            LoanDg.SelectAll()
            UpdateRowCounter()
        End If
    End Sub

    Private Sub UpdateRowCounter()
        Dim curRow As Integer = LoanDg.RowCount
        Dim selectedRow As Integer = LoanDg.SelectedRows.Count
        If curRow = selectedRow Then
            select_lbl.Text = "Selected Row: " & selectedRow & "*"
            SelectAllBtn.Image = My.Resources.fluent__select_all_on_20_filled
            isSelectAll = True
        Else
            select_lbl.Text = "Selected Row: " & selectedRow
            SelectAllBtn.Image = My.Resources.fluent__select_all_off_20_filled
            ResetFormMenu()
            Side_panel.Visible = False
            isSelectAll = False
        End If
    End Sub

    Private Sub LoanSearchQuery()
        Dim loanId As String = id_txt.Text.Trim()
        Dim transacType As String = type_cbbox.Text.Trim()
        Dim amount As String = amount_txt.Text.Trim()
        Dim datedtp As String = date_cbbox.Text
        Dim timedtp As String = time_dtp.Text
        Dim status As String = status_cbbox.Text

        Dim whereClause As String = String.Empty
        Debug.WriteLine(loanId.Length)
        If loanId.Length > 0 Then
            If whereClause.Length > 0 Then
                whereClause &= " AND "
            End If
            whereClause &= " Loan_ID LIKE '%" & loanId & "%'"
        End If

        Debug.WriteLine(transacType.Length)
        If transacType.Length > 0 Then
            If whereClause.Length > 0 Then
                whereClause &= " AND "
            End If
            whereClause &= " Transaction_Type= '" & transacType & "'"
        End If

        Debug.WriteLine(amount.Length)
        If amount.Length > 0 Then
            If whereClause.Length > 0 Then
                whereClause &= " AND "
            End If
            whereClause &= " Amount LIKE '%" & amount & "%'"
        End If

        Debug.WriteLine(datedtp.Length)
        If datedtp.Length > 0 Then
            If whereClause.Length > 0 Then
                whereClause &= " AND "
            End If
            whereClause &= " Date = '" & datedtp & "'"
        End If

        Debug.WriteLine(timedtp.Length)
        Debug.WriteLine(timedtp.GetType())
        If timedtp.Length > 1 Then
            If whereClause.Length > 0 Then
                whereClause &= " AND "
            End If
            whereClause &= " Time LIKE '%" & timedtp & "%'"
        End If

        Debug.WriteLine(status.Length)
        If status.Length > 0 Then
            If whereClause.Length > 0 Then
                whereClause &= " AND "
            End If
            whereClause &= " Status = '" & status & "'"
        End If

        Dim strQuery As String = "SELECT * FROM loans"
        If whereClause.Length > 0 Then
            strQuery &= " WHERE " & whereClause
        End If
        LoadDatagrid(strQuery)
    End Sub

    Private Sub id_txt_TextChanged(sender As Object, e As EventArgs) Handles id_txt.TextChanged
        LoanSearchQuery()
    End Sub

    Private Sub amount_txt_TextChanged(sender As Object, e As EventArgs) Handles amount_txt.TextChanged
        LoanSearchQuery()
    End Sub

    Private Sub type_cbbox_SelectedValueChanged(sender As Object, e As EventArgs) Handles type_cbbox.SelectedIndexChanged
        LoanSearchQuery()
    End Sub

    Private Sub status_cbbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles status_cbbox.SelectedIndexChanged
        LoanSearchQuery()
    End Sub

    Private Sub date_cbbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles date_cbbox.SelectedIndexChanged
        LoanSearchQuery()
    End Sub

    Private Sub time_cbbox_SelectedIndexChanged(sender As Object, e As EventArgs)
        LoanSearchQuery()
    End Sub

    Private Sub time_dtp_ValueChanged(sender As Object, e As EventArgs) Handles time_dtp.ValueChanged
        time_dtp.CustomFormat = "hh:mm:ss"
    End Sub

    Private Sub DBUpdateBtn_Click(sender As Object, e As EventArgs) Handles DBUpdateBtn.Click
        ReadQuery("UPDATE loans SET Transaction_Type = '" & TransacTypeCbbox.Text & "', Amount='" & AmountText.Text & "', Status='" & StatusCbbox.Text & "' WHERE Loan_ID='" & LoanIdText.Text & "'")
        ClearSearchInputs()
        ClearSideInputs()
        LoadDatagrid("SELECT * FROM loans")
        MsgBox("Record " & LoanIdText.Text & "Updated :)", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        Dim id As String = LoanDg.SelectedRows(0).Cells(0).Value.ToString()
        Dim result As DialogResult = MessageBox.Show("Delete Record for ID:" & id & "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            Dim str As String = "DELETE FROM loans WHERE Loan_ID = '" & id & "'"
            ReadQuery(str)
            ResetForm()
            MessageBox.Show("Record " & id & " Deleted :)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub BulkDeleteBtn_Click(sender As Object, e As EventArgs) Handles BulkDeleteBtn.Click
        Dim endCount As Integer = LoanDg.SelectedRows.Count
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete " & endCount & " loan data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            Dim a As Byte
            ' for loop execution 
            For a = 0 To endCount - 1
                Debug.WriteLine("endCount: " & endCount)
                Debug.WriteLine("LoanDg.SelectedRows(a).Cells(0).Value.ToString(): " & LoanDg.SelectedRows(a).Cells(0).Value.ToString())
                Dim id As String = LoanDg.SelectedRows(a).Cells(0).Value.ToString()
                Dim str As String = "DELETE FROM loans WHERE Loan_ID = '" & id & "'"
                Debug.WriteLine(str)
                ReadQuery(str)
            Next
            ResetForm()
            MessageBox.Show("Sucessfully deleted " & endCount & " loan data :)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub BulkUpdateBtn_Click(sender As Object, e As EventArgs) Handles BulkUpdateBtn.Click
        Side_panel.Visible = True
        SideInnerPanel1.Visible = False
        SideInnerPanel2.Visible = True
    End Sub

End Class