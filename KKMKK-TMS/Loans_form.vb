Imports System.Net
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports Google.Protobuf.WellKnownTypes

Public Class Loans_form

    Dim isSelectAll As Boolean = False
    Dim isSideBarOpen As Boolean = False

    Private Sub Loans_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Side_panel.Visible = False
        ResetForm()
    End Sub

    ' Tooltips
    Private Sub refreshBtn_MouseHover(sender As Object, e As EventArgs) Handles refreshBtn.MouseHover
        ToolTip1.SetToolTip(refreshBtn, "Refresh")
    End Sub

    Private Sub createBtn_MouseHover(sender As Object, e As EventArgs) Handles createBtn.MouseHover
        ToolTip1.SetToolTip(createBtn, "Add data")
    End Sub

    Private Sub updateBtn_MouseHover(sender As Object, e As EventArgs) Handles updateBtn.MouseHover
        ToolTip1.SetToolTip(updateBtn, "Update data")
    End Sub

    Private Sub deleteBtn_MouseHover(sender As Object, e As EventArgs) Handles deleteBtn.MouseHover
        ToolTip1.SetToolTip(deleteBtn, "Delete data")
    End Sub

    Private Sub BulkDeleteBtn_MouseHover(sender As Object, e As EventArgs) Handles BulkDeleteBtn.MouseHover
        ToolTip1.SetToolTip(BulkDeleteBtn, "Bulk delete")
    End Sub

    Private Sub BulkUpdateBtn_MouseHover(sender As Object, e As EventArgs) Handles BulkUpdateBtn.MouseHover
        ToolTip1.SetToolTip(BulkUpdateBtn, "Bulk update")
    End Sub

    Private Sub ExportBtn_MouseHover(sender As Object, e As EventArgs) Handles ExportBtn.MouseHover
        ToolTip1.SetToolTip(ExportBtn, "Export to PDF")
    End Sub


    ' Navigation and Layout Controls
    Private Sub ResetForm()
        ResetFormMenu()
        ClearSearchInputs()
        ClearSideInputs()
        Side_panel.Visible = False
        SideInnerPanel1.Visible = True
        sideheader_lbl.Text = "Create Loan Transaction"
        LoadIdBtn.Enabled = True
        DBInsertBtn.Visible = True
        SideInnerPanel2.Visible = False
        status_lbl.Visible = False
        StatusCbbox.Visible = False
        LoadLoanDatagrid("SELECT * FROM loans")
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
        dateto_dtp.MaxDate = DateTime.Now
        datefrom_dtp.CustomFormat = " "  'An empty SPACE
        dateto_dtp.CustomFormat = " "
        timefrom_dtp.CustomFormat = " "
        timeto_dtp.CustomFormat = " "
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

    Private Sub createBtn_Click(sender As Object, e As EventArgs) Handles createBtn.Click
        SideCreateMode()
    End Sub

    Private Sub refreshBtn_Click(sender As Object, e As EventArgs) Handles refreshBtn.Click
        ResetForm()
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
        StatusCbbox.Text = LoanDg.SelectedRows(0).Cells(5).Value.ToString()
        LoanIdText.Text = LoanDg.SelectedRows(0).Cells(0).Value.ToString()
        TransacTypeCbbox.Text = LoanDg.SelectedRows(0).Cells(1).Value.ToString()
        AmountText.Text = LoanDg.SelectedRows(0).Cells(2).Value.ToString()
    End Sub

    Sub SideCreateMode()
        ResetForm()
        Side_panel.Visible = True
        SideInnerPanel1.Visible = True
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

    Private Sub id_txt_TextChanged(sender As Object, e As EventArgs) Handles id_txt.TextChanged
        Debug.WriteLine("id_txt_TextChanged")
        LoanSearchQuery()
    End Sub

    Private Sub amount_txt_TextChanged(sender As Object, e As EventArgs) Handles amount_txt.TextChanged
        Debug.WriteLine("amount_txt_TextChanged")
        LoanSearchQuery()
    End Sub

    Private Sub type_cbbox_SelectedValueChanged(sender As Object, e As EventArgs) Handles type_cbbox.SelectedValueChanged
        Debug.WriteLine("type_cbbox_SelectedValueChanged")
        LoanSearchQuery()
    End Sub

    Private Sub status_cbbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles status_cbbox.SelectedIndexChanged
        Debug.WriteLine("status_cbbox_SelectedIndexChanged")
        LoanSearchQuery()
    End Sub

    Private Sub datefrom_dtp_ValueChanged(sender As Object, e As EventArgs) Handles datefrom_dtp.ValueChanged
        If datefrom_dtp.Checked AndAlso datefrom_dtp.IsHandleCreated Then
            Debug.WriteLine("datefrom_dtp_ValueChanged")
            LoanSearchQuery()
        End If
    End Sub

    Private Sub dateto_dtp_ValueChanged(sender As Object, e As EventArgs) Handles dateto_dtp.ValueChanged
        If dateto_dtp.Checked AndAlso dateto_dtp.IsHandleCreated Then
            Debug.WriteLine("dateto_dtp_ValueChanged")
            LoanSearchQuery()
        End If
    End Sub

    Private Sub timefrom_dtp_ValueChanged(sender As Object, e As EventArgs) Handles timefrom_dtp.ValueChanged
        If timefrom_dtp.Checked AndAlso dateto_dtp.IsHandleCreated Then
            Debug.WriteLine("timefrom_dtp_ValueChanged")
            LoanSearchQuery()
        End If
    End Sub

    Private Sub timeto_dtp_ValueChanged(sender As Object, e As EventArgs) Handles timeto_dtp.ValueChanged
        If timeto_dtp.Checked AndAlso dateto_dtp.IsHandleCreated Then
            Debug.WriteLine("timeto_dtp_ValueChanged")
            LoanSearchQuery()
        End If
    End Sub

    Private Sub datefrom_dtp_Enter(sender As Object, e As EventArgs) Handles datefrom_dtp.Enter
        datefrom_dtp.CustomFormat = "yyyy/MM/dd"
        dateto_dtp.CustomFormat = "yyyy/MM/dd"
        dateto_dtp.Value = dateto_dtp.MaxDate
    End Sub

    Private Sub dateto_dtp_Enter(sender As Object, e As EventArgs) Handles dateto_dtp.Enter
        datefrom_dtp.CustomFormat = "yyyy/MM/dd"
        dateto_dtp.CustomFormat = "yyyy/MM/dd"
        dateto_dtp.Value = dateto_dtp.MaxDate
    End Sub

    Private Sub timefrom_dtp_Enter(sender As Object, e As EventArgs) Handles timefrom_dtp.Enter
        timefrom_dtp.CustomFormat = "hh:mm:ss tt"
        timeto_dtp.CustomFormat = "hh:mm:ss tt"
    End Sub

    Private Sub timeto_dtp_Enter(sender As Object, e As EventArgs) Handles timeto_dtp.Enter
        timefrom_dtp.CustomFormat = "hh:mm:ss tt"
        timeto_dtp.CustomFormat = "hh:mm:ss tt"
    End Sub

    Private Sub BulkUpdateBtn_Click(sender As Object, e As EventArgs) Handles BulkUpdateBtn.Click
        Side_panel.Visible = True
        SideInnerPanel1.Visible = False
        SideInnerPanel2.Visible = True
    End Sub


    ' Error prevention
    Private Sub AmountText_TextChanged(sender As Object, e As EventArgs) Handles AmountText.TextChanged
        Dim digitsOnly As New Regex("[^\d\.]")
        AmountText.Text = digitsOnly.Replace(AmountText.Text, "")
    End Sub

    Private Sub AmountText_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AmountText.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub LoadIdBtn_Click(sender As Object, e As EventArgs) Handles LoadIdBtn.Click
        Dim num As Integer = Generate7Id()
        LoanIdText.Text = num
    End Sub


    ' CRUD Search Methods
    Private Sub DBInsertBtn_Click(sender As Object, e As EventArgs) Handles DBInsertBtn.Click
        Dim transacType As String = TransacTypeCbbox.Text.Trim()
        Dim amount As String = AmountText.Text.Trim()
        Dim id As String = LoanIdText.Text

        If id.Length = 0 Then
            id = Generate7Id().ToString()
        End If

        If transacType.Length > 0 And amount.Length > 0 Then
            Dim data As String() = {LoanIdText.Text, TransacTypeCbbox.Text, AmountText.Text}
            InsertLoan(data)
            ClearSearchInputs()
            ClearSideInputs()
            LoadLoanDatagrid("SELECT * FROM loans")
        Else
            MessageBox.Show("Missing inputs: Action Failed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        End If
    End Sub

    Private Sub LoadLoanDatagrid(str As String)
        Try
            ReadQuery(str)
            LoanDg.Rows.Clear()
            With cmdread
                While .Read
                    Dim time1 As DateTime = .GetValue(4).ToString()
                    LoanDg.Rows.Add(.GetValue(0), .GetValue(1), .GetValue(2), .GetValue(3), time1, .GetValue(5))
                End While
            End With
            LoanDg.ClearSelection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        End Try
    End Sub

    Private Sub LoanSearchQuery()
        Dim loanId As String = id_txt.Text.Trim()
        Dim transacType As String = type_cbbox.Text.Trim()
        Dim amount As String = amount_txt.Text.Trim()
        Dim datetoDtp As String = dateto_dtp.Value.ToString("yyyy/MM/dd")
        Dim datefromDtp As String = datefrom_dtp.Value.ToString("yyyy/MM/dd")
        Dim timetoDtp As String = timeto_dtp.Value.ToString("HH:mm:ss")
        Dim timefromDtp As String = timefrom_dtp.Value.ToString("HH:mm:ss")
        Dim status As String = status_cbbox.Text

        Dim whereClause As String = String.Empty
        If loanId.Length > 0 Then
            If whereClause.Length > 0 Then
                whereClause &= " AND "
            End If
            whereClause &= " Loan_ID LIKE '%" & loanId & "%'"
        End If

        If transacType.Length > 0 Then
            If whereClause.Length > 0 Then
                whereClause &= " AND "
            End If
            whereClause &= " Transaction_Type= '" & transacType & "'"
        End If

        If amount.Length > 0 Then
            If whereClause.Length > 0 Then
                whereClause &= " AND "
            End If
            whereClause &= " Amount LIKE '%" & amount & "%'"
        End If

        If dateto_dtp.CustomFormat.ToString() <> " " Then
            If datefromDtp < datetoDtp Then
                If whereClause.Length > 0 Then
                    whereClause &= " And "
                End If
                whereClause &= " Date BETWEEN '" & datefromDtp & "' AND '" & datetoDtp & "'"
            Else
                dateto_dtp.Value = dateto_dtp.MaxDate
                MessageBox.Show("Invalid date range input!" & vbCrLf & "Check your time range value", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
        End If

        If timeto_dtp.CustomFormat.ToString() <> " " Then
            If timefromDtp < timetoDtp Then
                If whereClause.Length > 0 Then
                    whereClause &= " And "
                End If
                whereClause &= " Time BETWEEN '" & timefromDtp & "' AND '" & timetoDtp & "'"
            Else
                timefrom_dtp.Value = New DateTime(timefrom_dtp.MinDate.Year, timefrom_dtp.MinDate.Month, DateTime.Now.Day, 0, 0, 0)
                timeto_dtp.Value = New DateTime(timeto_dtp.MinDate.Year, timeto_dtp.MinDate.Month, DateTime.Now.Day, 23, 59, 0)
                MessageBox.Show("Invalid time range input!" & vbCrLf & "Check your time range value", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
        End If

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
        Debug.WriteLine(strQuery)
        LoadLoanDatagrid(strQuery)
    End Sub

    Private Sub DBUpdateBtn_Click(sender As Object, e As EventArgs) Handles DBUpdateBtn.Click
        Dim transacType As String = TransacTypeCbbox.Text.Trim()
        Dim amount As String = AmountText.Text.Trim()
        Dim status As String = StatusCbbox.Text.Trim()
        If transacType.Length > 0 Or amount.Length > 0 Or status.Length > 0 Then
            Dim queryResult As Integer = ReadQuery("UPDATE loans SET Transaction_Type = '" & transacType & "', Amount='" & amount & "', Status='" & status & "' WHERE Loan_ID='" & LoanIdText.Text & "'")
            ClearSearchInputs()
            ClearSideInputs()
            LoadLoanDatagrid("SELECT * FROM loans")
            If queryResult = 1 Then
                MessageBox.Show("Record " & LoanIdText.Text & "Updated :)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
            End If
        Else
            MessageBox.Show("Missing inputs: Update Failed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        End If
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        Dim id As String = LoanDg.SelectedRows(0).Cells(0).Value.ToString()
        Dim result As DialogResult = MessageBox.Show("Delete Record for ID:" & id & "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            Dim str As String = "DELETE FROM loans WHERE Loan_ID = '" & id & "'"
            ReadQuery(str)
            ResetForm()
            MessageBox.Show("Record " & id & " Deleted :)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
        End If
    End Sub

    Private Sub BulkDeleteBtn_Click(sender As Object, e As EventArgs) Handles BulkDeleteBtn.Click
        Dim endCount As Integer = LoanDg.SelectedRows.Count
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete in bulk " & endCount & " loan data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            Dim a As Byte
            ' For loop delete execution 
            For a = 0 To endCount - 1
                Dim id As String = LoanDg.SelectedRows(a).Cells(0).Value.ToString()
                Dim str As String = "DELETE FROM loans WHERE Loan_ID = '" & id & "'"
                ReadQuery(str)
            Next
            ResetForm()
            MessageBox.Show("Sucessfully deleted " & endCount & " loan data :)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
        End If
    End Sub

    Private Sub UpdateBulk_btn_Click(sender As Object, e As EventArgs) Handles UpdateBulk_btn.Click
        Dim endCount As Integer = LoanDg.SelectedRows.Count
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to update in bulk " & endCount & " loan data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            Dim a As Byte
            Debug.WriteLine("endCount: " & endCount)
            Debug.WriteLine("LoanDg.SelectedRows(a).Cells(0).Value.ToString(): " & LoanDg.SelectedRows(a).Cells(0).Value.ToString())
            Dim transacType As String = TransacType_cbbox.Text.Trim()
            Dim amount As String = Amount_txt2.Text.Trim()
            Dim status As String = Status_cbbox2.Text.Trim()
            Dim id As String = LoanDg.SelectedRows(a).Cells(0).Value.ToString()

            If transacType.Length > 0 Or amount.Length > 0 Or status.Length > 0 Then
                ' For loop update execution 
                For a = 0 To endCount - 1
                    Dim setClause As String = String.Empty
                    If transacType.Length > 0 Then
                        If setClause.Length > 0 Then
                            setClause &= ","
                        End If
                        setClause &= " Transaction_Type = '" & transacType & "'"
                    End If

                    If amount.Length > 0 Then
                        If setClause.Length > 0 Then
                            setClause &= ","
                        End If
                        setClause &= " Amount = '" & amount & "'"
                    End If

                    If status.Length > 0 Then
                        If setClause.Length > 0 Then
                            setClause &= ","
                        End If
                        setClause &= " Status = '" & status & "'"
                    End If

                    Dim strQuery As String = "UPDATE loans SET" & setClause & " WHERE Loan_ID= '" & id & "'"
                    Debug.WriteLine(strQuery)
                    ReadQuery(strQuery)
                Next
                ResetForm()
                MessageBox.Show("Sucessfully updated " & endCount & " loan data :)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
            Else
                MessageBox.Show("Missing inputs: Update Failed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            End If

        End If
    End Sub

End Class