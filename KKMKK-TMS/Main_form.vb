Imports System.Text.RegularExpressions
Imports Google.Protobuf.WellKnownTypes
Imports Org.BouncyCastle.Asn1.Cms

Public Class Main_form

    Private Sub Main_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.ItemSize = New Size(0, 1)
        TabControl1.SelectedTab = Home_tab
    End Sub

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        TabControl1.SelectedTab = Home_tab
    End Sub

    Private Sub TransactionBtn_Click(sender As Object, e As EventArgs) Handles TransactionBtn.Click
        TabControl1.SelectedTab = Transaction_tab
    End Sub

    Private Sub LoansToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoansToolStripMenuItem.Click
        TabControl1.SelectedTab = Loans_tab
    End Sub

    Private Sub ShareCapitalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShareCapitalToolStripMenuItem.Click
        TabControl1.SelectedTab = ShareCapital_tab
    End Sub

    Private Sub SavingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SavingsToolStripMenuItem.Click
        TabControl1.SelectedTab = Savings_tab
    End Sub

    Private Sub MembersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MembersToolStripMenuItem.Click
        TabControl1.SelectedTab = Members_tab
    End Sub

    Private Sub StaffsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffsToolStripMenuItem.Click
        TabControl1.SelectedTab = Staffs_tab
    End Sub

    Private Sub LoanTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoanTypeToolStripMenuItem.Click
        TabControl1.SelectedTab = LoanType_tab
    End Sub


    ' ################################################# LOAN TAB ################################################################################################################################

    Dim isSelectAll As Boolean = False
    Dim isSidePanelOpen As Boolean = False

    ' Tooltips
    Private Sub refreshBtn_MouseHover(sender As Object, e As EventArgs) Handles refreshBtn.MouseHover
        ToolTip1.SetToolTip(refreshBtn, "Refresh")
    End Sub

    Private Sub createBtn_MouseHover(sender As Object, e As EventArgs) Handles createBtn.MouseHover
        ToolTip1.SetToolTip(createBtn, "Add Data")
    End Sub

    Private Sub updateBtn_MouseHover(sender As Object, e As EventArgs) Handles updateBtn.MouseHover
        ToolTip1.SetToolTip(updateBtn, "Update Data")
    End Sub

    Private Sub deleteBtn_MouseHover(sender As Object, e As EventArgs) Handles deleteBtn.MouseHover
        ToolTip1.SetToolTip(deleteBtn, "Delete Data")
    End Sub

    Private Sub BulkDeleteBtn_MouseHover(sender As Object, e As EventArgs) Handles BulkDeleteBtn.MouseHover
        ToolTip1.SetToolTip(BulkDeleteBtn, "Bulk Delete")
    End Sub

    Private Sub BulkUpdateBtn_MouseHover(sender As Object, e As EventArgs) Handles BulkUpdateBtn.MouseHover
        ToolTip1.SetToolTip(BulkUpdateBtn, "Bulk Update")
    End Sub

    Private Sub ExportBtn_MouseHover(sender As Object, e As EventArgs) Handles ExportBtn.MouseHover
        ToolTip1.SetToolTip(ExportBtn, "Export")
    End Sub


    ' Navigation and Layout Controls
    Private Sub loans_tab_Enter(sender As Object, e As EventArgs) Handles Loans_tab.Enter
        Side_panel.Visible = False
        ResetForm()
    End Sub

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
        isSidePanelOpen = False
        LoanIdText.Clear()
        TransacTypeCbbox.Text = Nothing
        AmountText.Clear()
        StatusCbbox.Text = Nothing

        TransacType_cbbox.Text = Nothing
        Amount_txt2.Clear()
        Status_cbbox2.Text = Nothing

        Side_panel.Visible = False
    End Sub

    Private Sub ClearSearchInputs()
        id_txt.Clear()
        type_cbbox.Text = Nothing
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
        If Not isSidePanelOpen Then
            SideCreateMode()
            isSidePanelOpen = True
        End If
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

    Private Sub LoanDg_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles LoanDg.CellDoubleClick
        LoanDg.ClearSelection()
        updateBtn.Enabled = False
        deleteBtn.Enabled = False
        BulkDeleteBtn.Enabled = False
        BulkUpdateBtn.Enabled = False
        ExportBtn.Enabled = False
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
            ClearSideInputs()
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
        If timefrom_dtp.Checked AndAlso timefrom_dtp.IsHandleCreated Then
            Debug.WriteLine("timefrom_dtp_ValueChanged")
            LoanSearchQuery()
        End If
    End Sub

    Private Sub timeto_dtp_ValueChanged(sender As Object, e As EventArgs) Handles timeto_dtp.ValueChanged
        If timeto_dtp.Checked AndAlso timeto_dtp.IsHandleCreated Then
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
        Dim num = Generate7Id("loans", "Loan_ID")
        LoanIdText.Text = num
    End Sub


    ' CRUD Search Methods
    Private Sub DBInsertBtn_Click(sender As Object, e As EventArgs) Handles DBInsertBtn.Click
        Dim transacType = TransacTypeCbbox.Text.Trim
        Dim amount = AmountText.Text.Trim
        Dim id = LoanIdText.Text

        If id.Length = 0 Then
            id = Generate7Id("loans", "Loan_ID").ToString
        End If

        If transacType.Length > 0 And amount.Length > 0 Then
            Dim data = {id, TransacTypeCbbox.Text, AmountText.Text}
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
        Dim transacType = TransacTypeCbbox.Text.Trim
        Dim amount = AmountText.Text.Trim
        Dim status = StatusCbbox.Text.Trim
        If transacType.Length > 0 Or amount.Length > 0 Or status.Length > 0 Then
            Dim setClause = String.Empty
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

            Dim strQuery = "UPDATE loans SET" & setClause & " WHERE Loan_ID= '" & LoanIdText.Text & "'"

            Dim queryResult As Integer = ReadQuery(strQuery)
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
        Dim id = LoanDg.SelectedRows(0).Cells(0).Value.ToString
        Dim result = MessageBox.Show("Delete Record for ID:" & id & "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            Dim str = "DELETE FROM loans WHERE Loan_ID = '" & id & "'"
            ReadQuery(str)
            ResetForm()
            MessageBox.Show("Record " & id & " Deleted :)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
        End If
    End Sub

    Private Sub BulkDeleteBtn_Click(sender As Object, e As EventArgs) Handles BulkDeleteBtn.Click
        Dim endCount = LoanDg.SelectedRows.Count
        Dim result = MessageBox.Show("Are you sure you want to delete in bulk " & endCount & " loan data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            Dim a As Byte
            ' For loop delete execution 
            For a = 0 To endCount - 1D
                Dim id = LoanDg.SelectedRows(a).Cells(0).Value.ToString
                Dim str = "DELETE FROM loans WHERE Loan_ID = '" & id & "'"
                ReadQuery(str)
            Next
            ResetForm()
            MessageBox.Show("Sucessfully deleted " & endCount & " loan data :)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
        End If
    End Sub

    Private Sub UpdateBulk_btn_Click(sender As Object, e As EventArgs) Handles UpdateBulk_btn.Click
        Dim endCount = LoanDg.SelectedRows.Count
        Dim transacType = TransacType_cbbox.Text.Trim
        Dim amount = Amount_txt2.Text.Trim
        Dim status = Status_cbbox2.Text.Trim
        If transacType.Length > 0 Or amount.Length > 0 Or status.Length > 0 Then
            Dim result = MessageBox.Show("Are you sure you want to update in bulk " & endCount & " loan data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            If result = DialogResult.Yes Then
                Dim a As Byte
                Debug.WriteLine("endCount: " & endCount)
                Debug.WriteLine("LoanDg.SelectedRows(a).Cells(0).Value.ToString(): " & LoanDg.SelectedRows(a).Cells(0).Value.ToString)

                ' For loop update execution 
                For a = 0 To endCount - 1
                    Dim id = LoanDg.SelectedRows(a).Cells(0).Value.ToString
                    Dim setClause = String.Empty
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

                    Dim strQuery = "UPDATE loans SET" & setClause & " WHERE Loan_ID= '" & id & "'"
                    Debug.WriteLine(strQuery)
                    ReadQuery(strQuery)
                Next
                ResetForm()
                MessageBox.Show("Sucessfully updated " & endCount & " loan data :)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
            End If
        Else
            MessageBox.Show("Missing inputs: Update Failed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        End If
    End Sub

    ' ################################################# LOANS TAB END ################################################################################################################################



    ' ################################################# LOAN TYPE TAB ################################################################################################################################

    Dim isSelectAll1 As Boolean = False
    Dim isSidePanelOpen1 As Boolean = False

    ' Tooltips
    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        ToolTip1.SetToolTip(Button1, "Refresh")
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        ToolTip1.SetToolTip(Button2, "Add Data")
    End Sub

    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles Button3.MouseHover
        ToolTip1.SetToolTip(Button3, "Update Data")
    End Sub

    Private Sub Button4_MouseHover(sender As Object, e As EventArgs) Handles Button4.MouseHover
        ToolTip1.SetToolTip(Button4, "Delete Data")
    End Sub

    Private Sub Button6_MouseHover(sender As Object, e As EventArgs) Handles Button6.MouseHover
        ToolTip1.SetToolTip(Button5, "Bulk Delete")
    End Sub

    Private Sub Button5_MouseHover(sender As Object, e As EventArgs) Handles Button5.MouseHover
        ToolTip1.SetToolTip(Button5, "Bulk Update")
    End Sub

    Private Sub Button7_MouseHover(sender As Object, e As EventArgs) Handles Button7.MouseHover
        ToolTip1.SetToolTip(Button7, "Export")
    End Sub


    ' Navigation and Layout Controls
    Private Sub LoanType_tab_Enter(sender As Object, e As EventArgs) Handles LoanType_tab.Enter
        FlowLayoutPanel3.Visible = False
        ResetForm1()
    End Sub

    Private Sub ResetForm1()
        ResetFormMenu1()
        ClearSearchInputs1()
        ClearSideInputs1()
        FlowLayoutPanel3.Visible = False
        Panel3.Visible = True
        Label23.Text = "Create Loan Type"
        Button10.Enabled = True
        Button8.Visible = True
        Panel4.Visible = False
        LoadDatagrid1("SELECT * FROM loan_type")
    End Sub

    Private Sub ResetFormMenu1()
        Button3.Enabled = False
        Button4.Enabled = False
        Button6.Enabled = False
        Button5.Enabled = False
        Button7.Enabled = False
    End Sub

    Private Sub ClearSideInputs1()
        isSidePanelOpen1 = False
        TextBox2.Clear()
        TextBox1.Clear()
        DateTimePicker1.CustomFormat = " "
        DateTimePicker2.CustomFormat = " "

        TextBox3.Clear()
        DateTimePicker2.CustomFormat = " "

        FlowLayoutPanel3.Visible = False
    End Sub

    Private Sub ClearSearchInputs1()
        TextBox4.Clear()
        TextBox5.Clear()
        DateTimePicker4.CustomFormat = " "  'An empty SPACE
        DateTimePicker3.CustomFormat = " "
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        ClearSearchInputs1()
        ClearSideInputs1()
        Panel3.Visible = True
        Panel4.Visible = False
        FlowLayoutPanel3.Visible = False
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        ClearSearchInputs1()
        ClearSideInputs1()
        Panel3.Visible = False
        Panel4.Visible = True
        FlowLayoutPanel3.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not isSidePanelOpen1 Then
            SideCreateMode1()
            isSidePanelOpen1 = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ResetForm1()
    End Sub

    Sub SideUpdateMode1()
        Label23.Text = "Update Loan Transaction"
        Panel3.Visible = True
        FlowLayoutPanel3.Visible = True
        Button10.Enabled = False
        Button8.Visible = False
        Panel4.Visible = False
        DateTimePicker1.CustomFormat = "HH:mm:ss"

        ' Set the selected data as default
        TextBox2.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
        TextBox1.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString()
        Dim time1 As DateTime = CType(DataGridView1.SelectedRows(0).Cells(2).Value, DateTime)
        Dim timeValue As TimeSpan = time1.TimeOfDay
        DateTimePicker1.Value = DateTimePicker1.Value.Date.Add(timeValue)
    End Sub

    Sub SideCreateMode1()
        ResetForm1()
        FlowLayoutPanel3.Visible = True
        Panel3.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SideUpdateMode1()
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Dim num = DataGridView1.SelectedRows.Count
        UpdateRowCounter1()

        If num >= 2 Then
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = True
            Button6.Enabled = True
            Button7.Enabled = True
        ElseIf num = 1 Then
            Button3.Enabled = True
            Button4.Enabled = True
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = True
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        DataGridView1.ClearSelection()
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If isSelectAll1 Then
            ' if already selected all, unselect all
            DataGridView1.ClearSelection()
            UpdateRowCounter1()
        Else
            DataGridView1.SelectAll()
            UpdateRowCounter1()
        End If
    End Sub

    Private Sub UpdateRowCounter1()
        Dim curRow As Integer = DataGridView1.RowCount
        Dim selectedRow As Integer = DataGridView1.SelectedRows.Count
        If curRow = selectedRow Then
            Label38.Text = "Selected Row: " & selectedRow & "*"
            Button14.Image = My.Resources.fluent__select_all_on_20_filled
            isSelectAll1 = True
        Else
            Label38.Text = "Selected Row: " & selectedRow
            Button14.Image = My.Resources.fluent__select_all_off_20_filled
            ResetFormMenu1()
            ClearSideInputs1()
            isSelectAll1 = False
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Debug.WriteLine("TextBox4_TextChanged")
        SearchQuery1()
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        Debug.WriteLine("TextBox5_TextChanged")
        SearchQuery1()
    End Sub

    Private Sub DateTimePicker4_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker4.ValueChanged
        If DateTimePicker4.Checked AndAlso DateTimePicker4.IsHandleCreated Then
            Debug.WriteLine("DateTimePicker4_ValueChanged")
            SearchQuery1()
        End If
    End Sub

    Private Sub DateTimePicker3_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker3.ValueChanged
        Debug.WriteLine("DateTimePicker3_ValueChanged")
        If DateTimePicker3.Checked AndAlso DateTimePicker3.IsHandleCreated Then
            Debug.WriteLine("DateTimePicker3_ValueChanged")
            SearchQuery1()
        End If
    End Sub

    Private Sub DateTimePicker3_Enter(sender As Object, e As EventArgs) Handles DateTimePicker3.Enter
        DateTimePicker4.CustomFormat = "HH:mm:ss"
        DateTimePicker3.CustomFormat = "HH:mm:ss"
    End Sub

    Private Sub DateTimePicker4_Enter(sender As Object, e As EventArgs) Handles DateTimePicker4.Enter
        DateTimePicker4.CustomFormat = "HH:mm:ss"
        DateTimePicker3.CustomFormat = "HH:mm:ss"
    End Sub

    Private Sub DateTimePicker1_Enter(sender As Object, e As EventArgs) Handles DateTimePicker1.Enter
        DateTimePicker1.CustomFormat = "HH:mm:ss"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FlowLayoutPanel3.Visible = True
        Panel3.Visible = False
        Panel4.Visible = True
    End Sub


    ' Error prevention
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim num = Generate5Id("loan_type", "Loan_Type_ID")
        TextBox2.Text = num
    End Sub


    ' CRUDS Methods
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim name = TextBox1.Text.Trim
        Dim id = TextBox2.Text
        Dim time1 = DateTimePicker1.Value.ToString("HH:mm:ss")

        If id.Length = 0 Then
            id = Generate5Id("loan_type", "Loan_Type_ID").ToString
        End If

        If name.Length > 0 And time1 <> " " Then
            Dim data = {id, TextBox1.Text, time1}
            InsertLoanType(data)
            ClearSearchInputs1()
            ClearSideInputs1()
            LoadDatagrid1("SELECT * FROM loan_type")
        Else
            MessageBox.Show("Missing inputs: Action Failed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        End If
    End Sub

    Private Sub LoadDatagrid1(str As String)
        Try
            ReadQuery(str)
            DataGridView1.Rows.Clear()
            With cmdread
                While .Read
                    Dim time1 As DateTime = .GetValue(2).ToString()
                    DataGridView1.Rows.Add(.GetValue(0), .GetValue(1), time1)
                End While
            End With
            DataGridView1.ClearSelection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        End Try
    End Sub

    Private Sub SearchQuery1()
        Dim loantypeId As String = TextBox4.Text.Trim()
        Dim loanName As String = TextBox5.Text.Trim()
        Dim timetoDtp As String = DateTimePicker3.Value.ToString("HH:mm:ss")
        Dim timefromDtp As String = DateTimePicker4.Value.ToString("HH:mm:ss")

        Dim whereClause As String = String.Empty
        If loantypeId.Length > 0 Then
            If whereClause.Length > 0 Then
                whereClause &= " AND "
            End If
            whereClause &= " Loan_Type_ID LIKE '%" & loantypeId & "%'"
        End If

        If loanName.Length > 0 Then
            If whereClause.Length > 0 Then
                whereClause &= " AND "
            End If
            whereClause &= " Name LIKE '%" & loanName & "%'"
        End If

        If DateTimePicker3.CustomFormat.ToString() <> " " Then
            If timefromDtp < timetoDtp Then
                If whereClause.Length > 0 Then
                    whereClause &= " And "
                End If
                whereClause &= " Processing_Time BETWEEN '" & timefromDtp & "' AND '" & timetoDtp & "'"
            Else
                DateTimePicker4.Value = New DateTime(DateTimePicker4.MinDate.Year, DateTimePicker4.MinDate.Month, DateTime.Now.Day, 0, 0, 0)
                DateTimePicker3.Value = New DateTime(DateTimePicker3.MinDate.Year, DateTimePicker3.MinDate.Month, DateTime.Now.Day, 23, 59, 0)
                MessageBox.Show("Invalid time range input!" & vbCrLf & "Check your time range value", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
        End If

        Dim strQuery As String = "SELECT * FROM loan_type"
        If whereClause.Length > 0 Then
            strQuery &= " WHERE " & whereClause
        End If
        Debug.WriteLine(strQuery)
        LoadDatagrid1(strQuery)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim name = TextBox1.Text.Trim
        Dim time1 = DateTimePicker1.Value.ToString("HH:mm:ss")
        If name.Length > 0 Or time1 = " " Then
            Dim setClause = String.Empty
            If name.Length > 0 Or DateTimePicker3.CustomFormat.ToString <> " " Then
                If setClause.Length > 0 Then
                    setClause &= ","
                End If
                setClause &= " Name = '" & name & "'"
            End If

            If DateTimePicker3.CustomFormat.ToString <> " " Then
                If setClause.Length > 0 Then
                    setClause &= ","
                End If
                setClause &= " Processing_Time = '" & time1 & "'"
            End If

            Dim strQuery = "UPDATE loan_type SET" & setClause & " WHERE Loan_Type_ID= '" & TextBox2.Text & "'"

            Dim queryResult As Integer = ReadQuery(strQuery)
            ClearSearchInputs1()
            ClearSideInputs1()
            LoadDatagrid1("SELECT * FROM loan_type")
            If queryResult = 1 Then
                MessageBox.Show("Record " & TextBox2.Text & "Updated :)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
            End If
        Else
            MessageBox.Show("Missing inputs: Update Failed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim id = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
        Dim result = MessageBox.Show("Delete Record for ID:" & id & "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            Dim str = "DELETE FROM loan_type WHERE Loan_Type_ID = '" & id & "'"
            ReadQuery(str)
            ResetForm1()
            MessageBox.Show("Record " & id & " Deleted :)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim endCount = DataGridView1.SelectedRows.Count
        Dim result = MessageBox.Show("Are you sure you want to delete in bulk " & endCount & " loan data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            Dim a As Byte
            ' For loop delete execution 
            For a = 0 To endCount - 1
                Dim id = DataGridView1.SelectedRows(a).Cells(0).Value.ToString
                Dim str = "DELETE FROM loan_type WHERE Loan_Type_ID = '" & id & "'"
                ReadQuery(str)
            Next
            ResetForm1()
            MessageBox.Show("Sucessfully deleted " & endCount & " loan data :)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim endCount = DataGridView1.SelectedRows.Count
        Dim loanName = TextBox3.Text.Trim
        Dim time1 = DateTimePicker2.Value.ToString("HH:mm:ss")
        If loanName.Length > 0 Or DateTimePicker3.CustomFormat.ToString <> " " Then
            Dim result = MessageBox.Show("Are you sure you want to update in bulk " & endCount & " loan data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            If result = DialogResult.Yes Then
                Dim a As Byte
                Debug.WriteLine("endCount: " & endCount)
                Debug.WriteLine("DataGridView1.SelectedRows(a).Cells(0).Value.ToString(): " & DataGridView1.SelectedRows(a).Cells(0).Value.ToString)

                ' For loop update execution 
                For a = 0 To endCount - 1
                    Dim id = DataGridView1.SelectedRows(a).Cells(0).Value.ToString
                    Dim setClause = String.Empty

                    If loanName.Length > 0 Then
                        If setClause.Length > 0 Then
                            setClause &= ","
                        End If
                        setClause &= " Name = '" & loanName & "'"
                    End If

                    If DateTimePicker3.CustomFormat.ToString <> " " Then
                        If setClause.Length > 0 Then
                            setClause &= ","
                        End If
                        setClause &= " Processing_Time = '" & time1 & "'"
                    End If

                    Dim strQuery = "UPDATE loan_type SET" & setClause & " WHERE Loan_Type_ID= '" & id & "'"
                    Debug.WriteLine(strQuery)
                    ReadQuery(strQuery)
                Next
                ResetForm1()
                MessageBox.Show("Sucessfully updated " & endCount & " loan type data :)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
            End If
        Else
            MessageBox.Show("Missing inputs: Update Failed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        End If
    End Sub

    Private Sub Menu_fpanel_Paint(sender As Object, e As PaintEventArgs) Handles Menu_fpanel.Paint

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    ' ################################################# LOAN TYPE TAB END ################################################################################################################################


    ' ################################################# SHARE CAPITAL TAB ################################################################################################################################

    Dim isSelectAll2 As Boolean = False
    Dim isSidePanelOpen2 As Boolean = False

    ' Tooltips
    Private Sub Button15_MouseHover(sender As Object, e As EventArgs) Handles Button15.MouseHover
        ToolTip1.SetToolTip(Button15, "Refresh")
    End Sub

    Private Sub Button16_MouseHover(sender As Object, e As EventArgs) Handles Button16.MouseHover
        ToolTip1.SetToolTip(Button16, "Add Data")
    End Sub

    Private Sub Button17_MouseHover(sender As Object, e As EventArgs) Handles Button17.MouseHover
        ToolTip1.SetToolTip(Button17, "Update Data")
    End Sub

    Private Sub Button18_MouseHover(sender As Object, e As EventArgs) Handles Button18.MouseHover
        ToolTip1.SetToolTip(Button18, "Delete Data")
    End Sub

    Private Sub Button20_MouseHover(sender As Object, e As EventArgs) Handles Button20.MouseHover
        ToolTip1.SetToolTip(Button20, "Bulk Delete")
    End Sub

    Private Sub Button19_MouseHover(sender As Object, e As EventArgs) Handles Button19.MouseHover
        ToolTip1.SetToolTip(Button19, "Bulk Update")
    End Sub

    Private Sub Button21_MouseHover(sender As Object, e As EventArgs) Handles Button21.MouseHover
        ToolTip1.SetToolTip(Button21, "Export")
    End Sub


    ' Navigation and Layout Control
    Private Sub ShareCapital_tab_Enter(sender As Object, e As EventArgs) Handles ShareCapital_tab.Enter
        FlowLayoutPanel7.Visible = False
        ResetForm2()
    End Sub

    Private Sub ResetForm2()
        ResetFormMenu2()
        ClearSearchInputs2()
        ClearSideInputs2()
        FlowLayoutPanel7.Visible = False
        Panel6.Visible = True
        Label33.Text = "Create Share Capital Transaction"
        Button24.Enabled = True
        Button22.Visible = True
        Panel9.Visible = False
        Label26.Visible = False
        ComboBox1.Visible = False
        LoadDatagrid2("SELECT * FROM capital_and_savings WHERE Transaction_Type LIKE '%Capital%'")
    End Sub

    Private Sub ResetFormMenu2()
        Button17.Enabled = False
        Button18.Enabled = False
        Button20.Enabled = False
        Button19.Enabled = False
        Button21.Enabled = False
    End Sub

    Private Sub ClearSideInputs2()
        isSidePanelOpen2 = False
        TextBox7.Clear()
        ComboBox2.Text = Nothing
        TextBox6.Clear()
        ComboBox1.Text = Nothing

        ComboBox3.Text = Nothing
        TextBox8.Clear()
        ComboBox4.Text = Nothing

        FlowLayoutPanel7.Visible = False
    End Sub

    Private Sub ClearSearchInputs2()
        Debug.WriteLine("ClearSearchInputs2!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!")
        TextBox9.Clear()
        ComboBox5.Text = Nothing
        TextBox10.Clear()
        ComboBox6.Text = Nothing
        DateTimePicker5.MaxDate = DateTime.Now
        DateTimePicker6.CustomFormat = " "  'An empty SPACE
        DateTimePicker5.CustomFormat = " "
        DateTimePicker8.CustomFormat = " "
        DateTimePicker7.CustomFormat = " "
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        ClearSearchInputs2()
        ClearSideInputs2()
        Panel6.Visible = True
        Panel9.Visible = False
        FlowLayoutPanel7.Visible = False
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        ClearSearchInputs2()
        ClearSideInputs2()
        Panel6.Visible = False
        Panel9.Visible = True
        FlowLayoutPanel7.Visible = False
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If Not isSidePanelOpen2 Then
            SideCreateMode2()
            isSidePanelOpen2 = True
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        ResetForm2()
    End Sub

    Sub SideUpdateMode2()
        Label26.Visible = True
        ComboBox1.Visible = True
        Label33.Text = "Update Share Capital Transaction"
        Panel6.Visible = True
        FlowLayoutPanel7.Visible = True
        Button24.Enabled = False
        Button22.Visible = False
        Panel9.Visible = False

        ' Set the selected data as default
        ComboBox1.Text = DataGridView2.SelectedRows(0).Cells(5).Value.ToString()
        TextBox7.Text = DataGridView2.SelectedRows(0).Cells(0).Value.ToString()
        ComboBox2.Text = DataGridView2.SelectedRows(0).Cells(1).Value.ToString()
        TextBox6.Text = DataGridView2.SelectedRows(0).Cells(2).Value.ToString()
    End Sub

    Sub SideCreateMode2()
        ResetForm2()
        FlowLayoutPanel7.Visible = True
        Panel6.Visible = True
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        SideUpdateMode2()
    End Sub

    Private Sub DataGridView2_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView2.SelectionChanged
        Dim num = DataGridView2.SelectedRows.Count
        UpdateRowCounter2()

        If num >= 2 Then
            Button17.Enabled = False
            Button18.Enabled = False
            Button20.Enabled = True
            Button19.Enabled = True
            Button21.Enabled = True
        ElseIf num = 1 Then
            Button17.Enabled = True
            Button18.Enabled = True
            Button20.Enabled = False
            Button19.Enabled = False
            Button21.Enabled = True
        End If
    End Sub

    Private Sub DataGridView2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        DataGridView2.ClearSelection()
        Button17.Enabled = False
        Button18.Enabled = False
        Button20.Enabled = False
        Button19.Enabled = False
        Button21.Enabled = False
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        If isSelectAll2 Then
            ' if already selected all, unselect all
            DataGridView2.ClearSelection()
            UpdateRowCounter2()
        Else
            DataGridView2.SelectAll()
            UpdateRowCounter2()
        End If
    End Sub

    Private Sub UpdateRowCounter2()
        Dim curRow As Integer = DataGridView2.RowCount
        Dim selectedRow As Integer = DataGridView2.SelectedRows.Count
        If curRow = selectedRow Then
            Label52.Text = "Selected Row: " & selectedRow & "*"
            Button28.Image = My.Resources.fluent__select_all_on_20_filled
            isSelectAll2 = True
        Else
            Label52.Text = "Selected Row: " & selectedRow
            Button28.Image = My.Resources.fluent__select_all_off_20_filled
            ResetFormMenu2()
            ClearSideInputs2()
            isSelectAll2 = False
        End If
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        Debug.WriteLine("TextBox9_TextChanged")
        SearchQuery2()
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        Debug.WriteLine("TextBox10_TextChanged")
        SearchQuery2()
    End Sub

    Private Sub ComboBox5_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedValueChanged
        Debug.WriteLine("ComboBox5_SelectedValueChanged")
        SearchQuery2()
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged
        Debug.WriteLine("ComboBox6_SelectedIndexChanged")
        SearchQuery2()
    End Sub

    Private Sub DateTimePicker6_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker6.ValueChanged
        If DateTimePicker6.Checked AndAlso DateTimePicker6.IsHandleCreated Then
            Debug.WriteLine("DateTimePicker6_ValueChanged")
            SearchQuery2()
        End If
    End Sub

    Private Sub DateTimePicker5_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker5.ValueChanged
        If DateTimePicker5.Checked AndAlso DateTimePicker5.IsHandleCreated Then
            Debug.WriteLine("DateTimePicker5_ValueChanged")
            SearchQuery2()
        End If
    End Sub

    Private Sub DateTimePicker8_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker8.ValueChanged
        If DateTimePicker8.Checked AndAlso DateTimePicker8.IsHandleCreated Then
            Debug.WriteLine("DateTimePicker8_ValueChanged")
            SearchQuery2()
        End If
    End Sub

    Private Sub DateTimePicker7_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker7.ValueChanged
        If DateTimePicker7.Checked AndAlso DateTimePicker7.IsHandleCreated Then
            Debug.WriteLine("DateTimePicker7_ValueChanged")
            SearchQuery2()
        End If
    End Sub

    Private Sub DateTimePicker6_Enter(sender As Object, e As EventArgs) Handles DateTimePicker6.Enter
        DateTimePicker6.CustomFormat = "yyyy/MM/dd"
        DateTimePicker5.CustomFormat = "yyyy/MM/dd"
        DateTimePicker5.Value = DateTimePicker5.MaxDate
    End Sub

    Private Sub DateTimePicker5_Enter(sender As Object, e As EventArgs) Handles DateTimePicker5.Enter
        DateTimePicker6.CustomFormat = "yyyy/MM/dd"
        DateTimePicker5.CustomFormat = "yyyy/MM/dd"
        DateTimePicker5.Value = DateTimePicker5.MaxDate
    End Sub

    Private Sub DateTimePicker8_Enter(sender As Object, e As EventArgs) Handles DateTimePicker8.Enter
        DateTimePicker8.CustomFormat = "hh:mm:ss tt"
        DateTimePicker7.CustomFormat = "hh:mm:ss tt"
    End Sub

    Private Sub DateTimePicker7_Enter(sender As Object, e As EventArgs) Handles DateTimePicker7.Enter
        DateTimePicker8.CustomFormat = "hh:mm:ss tt"
        DateTimePicker7.CustomFormat = "hh:mm:ss tt"
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        FlowLayoutPanel7.Visible = True
        Panel6.Visible = False
        Panel9.Visible = True
    End Sub


    ' Error prevention
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        Dim digitsOnly As New Regex("[^\d\.]")
        TextBox6.Text = digitsOnly.Replace(TextBox6.Text, "")
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Dim num = Generate7Id("capital_and_savings", "Capital_Savings_ID")
        TextBox7.Text = num
    End Sub


    ' CRUD Search Methods
    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Dim transacType = ComboBox2.Text.Trim
        Dim amount = TextBox6.Text.Trim
        Dim id = TextBox7.Text

        If id.Length = 0 Then
            id = Generate7Id("capital_and_savings", "Capital_Savings_ID").ToString
        End If

        If transacType.Length > 0 And amount.Length > 0 Then
            Dim data = {id, ComboBox2.Text, TextBox6.Text}
            InsertCapitalSavings(data)
            ClearSearchInputs2()
            ClearSideInputs2()
            LoadDatagrid2("SELECT * FROM capital_and_savings WHERE Transaction_Type LIKE '%Capital%'")
        Else
            MessageBox.Show("Missing inputs: Action Failed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        End If
    End Sub

    Private Sub LoadDatagrid2(str As String)
        Try
            ReadQuery(str)
            DataGridView2.Rows.Clear()
            With cmdread
                While .Read
                    Dim time1 As DateTime = .GetValue(4).ToString()
                    DataGridView2.Rows.Add(.GetValue(0), .GetValue(1), .GetValue(2), .GetValue(3), time1, .GetValue(5))
                End While
            End With
            DataGridView2.ClearSelection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        End Try
    End Sub

    Private Sub SearchQuery2()
        Dim loanId As String = TextBox9.Text.Trim()
        Dim transacType As String = ComboBox5.Text.Trim()
        Dim amount As String = TextBox10.Text.Trim()
        Dim datetoDtp As String = DateTimePicker5.Value.ToString("yyyy/MM/dd")
        Dim datefromDtp As String = DateTimePicker6.Value.ToString("yyyy/MM/dd")
        Dim timetoDtp As String = DateTimePicker7.Value.ToString("HH:mm:ss")
        Dim timefromDtp As String = DateTimePicker8.Value.ToString("HH:mm:ss")
        Dim status As String = ComboBox6.Text

        Dim whereClause As String = String.Empty
        If loanId.Length > 0 Then
            If whereClause.Length > 0 Then
                whereClause &= " AND "
            End If
            whereClause &= " Capital_Savings_ID LIKE '%" & loanId & "%'"
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

        If DateTimePicker5.CustomFormat.ToString() <> " " Then
            If datefromDtp < datetoDtp Then
                If whereClause.Length > 0 Then
                    whereClause &= " And "
                End If
                whereClause &= " Date BETWEEN '" & datefromDtp & "' AND '" & datetoDtp & "'"
            Else
                DateTimePicker5.Value = DateTimePicker5.MaxDate
                MessageBox.Show("Invalid date range input!" & vbCrLf & "Check your time range value", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
        End If

        If DateTimePicker7.CustomFormat.ToString() <> " " Then
            If timefromDtp < timetoDtp Then
                If whereClause.Length > 0 Then
                    whereClause &= " And "
                End If
                whereClause &= " Time BETWEEN '" & timefromDtp & "' AND '" & timetoDtp & "'"
            Else
                DateTimePicker8.Value = New DateTime(DateTimePicker8.MinDate.Year, DateTimePicker8.MinDate.Month, DateTime.Now.Day, 0, 0, 0)
                DateTimePicker7.Value = New DateTime(DateTimePicker7.MinDate.Year, DateTimePicker7.MinDate.Month, DateTime.Now.Day, 23, 59, 0)
                MessageBox.Show("Invalid time range input!" & vbCrLf & "Check your time range value", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
        End If

        If status.Length > 0 Then
            If whereClause.Length > 0 Then
                whereClause &= " AND "
            End If
            whereClause &= " Status = '" & status & "'"
        End If

        Dim strQuery As String = "SELECT * FROM capital_and_savings"
        If whereClause.Length > 0 Then
            strQuery &= " WHERE " & whereClause & " AND Transaction_Type LIKE '%Capital%'"
        Else
            strQuery &= " WHERE Transaction_Type LIKE '%Capital%'"
        End If
        Debug.WriteLine(strQuery)
        LoadDatagrid2(strQuery)
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Dim transacType = ComboBox2.Text.Trim
        Dim amount = TextBox6.Text.Trim
        Dim status = ComboBox1.Text.Trim
        If transacType.Length > 0 Or amount.Length > 0 Or status.Length > 0 Then
            Dim setClause = String.Empty
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

            Dim strQuery = "UPDATE capital_and_savings SET" & setClause & " WHERE Capital_Savings_ID= '" & TextBox7.Text & "'"

            Dim queryResult As Integer = ReadQuery(strQuery)
            ClearSearchInputs2()
            ClearSideInputs2()
            LoadDatagrid2("SELECT * FROM capital_and_savings WHERE Transaction_Type LIKE '%Capital%'")
            If queryResult = 1 Then
                MessageBox.Show("Record " & TextBox7.Text & "Updated :)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
            End If
        Else
            MessageBox.Show("Missing inputs: Update Failed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim id = DataGridView2.SelectedRows(0).Cells(0).Value.ToString
        Dim result = MessageBox.Show("Delete Record for ID:" & id & "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            Dim str = "DELETE FROM capital_and_savings WHERE Capital_Savings_ID = '" & id & "'"
            ReadQuery(str)
            ResetForm2()
            MessageBox.Show("Record " & id & " Deleted :)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Dim endCount = DataGridView2.SelectedRows.Count
        Dim result = MessageBox.Show("Are you sure you want to delete in bulk " & endCount & " loan data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            Dim a As Byte
            ' For loop delete execution 
            For a = 0 To endCount - 1
                Dim id = DataGridView2.SelectedRows(a).Cells(0).Value.ToString
                Dim str = "DELETE FROM capital_and_savings WHERE Capital_Savings_ID = '" & id & "'"
                ReadQuery(str)
            Next
            ResetForm2()
            MessageBox.Show("Sucessfully deleted " & endCount & " share capital data :)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
        End If
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Dim endCount = DataGridView2.SelectedRows.Count
        Dim transacType = ComboBox4.Text.Trim
        Dim amount = TextBox8.Text.Trim
        Dim status = ComboBox3.Text.Trim
        If transacType.Length > 0 Or amount.Length > 0 Or status.Length > 0 Then
            Dim result = MessageBox.Show("Are you sure you want to update in bulk " & endCount & " loan data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            If result = DialogResult.Yes Then
                Dim a As Byte
                Debug.WriteLine("endCount: " & endCount)
                Debug.WriteLine("DataGridView2.SelectedRows(a).Cells(0).Value.ToString(): " & DataGridView2.SelectedRows(a).Cells(0).Value.ToString)

                ' For loop update execution 
                For a = 0 To endCount - 1
                    Dim id = DataGridView2.SelectedRows(a).Cells(0).Value.ToString
                    Dim setClause = String.Empty
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

                    Dim strQuery = "UPDATE capital_and_savings SET" & setClause & " WHERE Capital_Savings_ID= '" & id & "'"
                    Debug.WriteLine(strQuery)
                    ReadQuery(strQuery)
                Next
                ResetForm2()
                MessageBox.Show("Sucessfully updated " & endCount & " share capital data :)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
            End If
        Else
            MessageBox.Show("Missing inputs: Update Failed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        End If
    End Sub

    ' ################################################# SHARE CAPITAL TAB END ################################################################################################################################


    ' ################################################# SAVINGS TAB ################################################################################################################################

    Dim isSelectAll3 As Boolean = False
    Dim isSidePanelOpen3 As Boolean = False

    ' Tooltips
    Private Sub Button36_MouseHover(sender As Object, e As EventArgs) Handles Button36.MouseHover
        ToolTip1.SetToolTip(Button36, "Refresh")
    End Sub

    Private Sub Button37_MouseHover(sender As Object, e As EventArgs) Handles Button37.MouseHover
        ToolTip1.SetToolTip(Button37, "Add Data")
    End Sub

    Private Sub Button38_MouseHover(sender As Object, e As EventArgs) Handles Button38.MouseHover
        ToolTip1.SetToolTip(Button38, "Update Data")
    End Sub

    Private Sub Button39_MouseHover(sender As Object, e As EventArgs) Handles Button39.MouseHover
        ToolTip1.SetToolTip(Button39, "Delete Data")
    End Sub

    Private Sub Button41_MouseHover(sender As Object, e As EventArgs) Handles Button41.MouseHover
        ToolTip1.SetToolTip(Button41, "Bulk Delete")
    End Sub

    Private Sub Button40_MouseHover(sender As Object, e As EventArgs) Handles Button40.MouseHover
        ToolTip1.SetToolTip(Button40, "Bulk Update")
    End Sub

    Private Sub Button42_MouseHover(sender As Object, e As EventArgs) Handles Button42.MouseHover
        ToolTip1.SetToolTip(Button42, "Export")
    End Sub


    ' Navigation and Layout Control
    Private Sub Savings_tab_Enter(sender As Object, e As EventArgs) Handles Savings_tab.Enter
        FlowLayoutPanel11.Visible = False
        ResetForm3()
    End Sub

    Private Sub ResetForm3()
        ResetFormMenu3()
        ClearSearchInputs3()
        ClearSideInputs3()
        FlowLayoutPanel11.Visible = False
        Panel18.Visible = True
        Label68.Text = "Create Savings Transaction"
        Button32.Enabled = True
        Button30.Visible = True
        Panel19.Visible = False
        Label64.Visible = False
        ComboBox9.Visible = False
        LoadDatagrid3("SELECT * FROM capital_and_savings WHERE Transaction_Type LIKE '%Savings%'")
    End Sub

    Private Sub ResetFormMenu3()
        Button38.Enabled = False
        Button39.Enabled = False
        Button41.Enabled = False
        Button40.Enabled = False
        Button42.Enabled = False
    End Sub

    Private Sub ClearSideInputs3()
        isSidePanelOpen3 = False
        TextBox14.Clear()
        ComboBox10.Text = Nothing
        TextBox13.Clear()
        ComboBox9.Text = Nothing

        ComboBox11.Text = Nothing
        TextBox15.Clear()
        ComboBox12.Text = Nothing

        FlowLayoutPanel11.Visible = False
    End Sub

    Private Sub ClearSearchInputs3()
        TextBox11.Clear()
        ComboBox7.Text = Nothing
        TextBox12.Clear()
        ComboBox8.Text = Nothing
        DateTimePicker9.MaxDate = DateTime.Now
        DateTimePicker10.CustomFormat = " "  'An empty SPACE
        DateTimePicker9.CustomFormat = " "
        DateTimePicker12.CustomFormat = " "
        DateTimePicker11.CustomFormat = " "
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        ClearSearchInputs3()
        ClearSideInputs3()
        Panel18.Visible = True
        Panel19.Visible = False
        FlowLayoutPanel11.Visible = False
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        ClearSearchInputs3()
        ClearSideInputs3()
        Panel18.Visible = False
        Panel19.Visible = True
        FlowLayoutPanel11.Visible = False
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        If Not isSidePanelOpen3 Then
            SideCreateMode3()
            isSidePanelOpen3 = True
        End If
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        ResetForm3()
    End Sub

    Sub SideUpdateMode3()
        Label64.Visible = True
        ComboBox9.Visible = True
        Label68.Text = "Update Savings Transaction"
        Panel18.Visible = True
        FlowLayoutPanel11.Visible = True
        Button32.Enabled = False
        Button30.Visible = False
        Panel19.Visible = False

        ' Set the selected data as default
        ComboBox9.Text = DataGridView3.SelectedRows(0).Cells(5).Value.ToString()
        TextBox14.Text = DataGridView3.SelectedRows(0).Cells(0).Value.ToString()
        ComboBox10.Text = DataGridView3.SelectedRows(0).Cells(1).Value.ToString()
        TextBox13.Text = DataGridView3.SelectedRows(0).Cells(2).Value.ToString()
    End Sub

    Sub SideCreateMode3()
        ResetForm3()
        FlowLayoutPanel11.Visible = True
        Panel18.Visible = True
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        SideUpdateMode3()
    End Sub

    Private Sub DataGridView3_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView3.SelectionChanged
        Dim num = DataGridView3.SelectedRows.Count
        UpdateRowCounter3()

        If num >= 2 Then
            Button38.Enabled = False
            Button39.Enabled = False
            Button41.Enabled = True
            Button40.Enabled = True
            Button42.Enabled = True
        ElseIf num = 1 Then
            Button38.Enabled = True
            Button39.Enabled = True
            Button41.Enabled = False
            Button40.Enabled = False
            Button42.Enabled = True
        End If
    End Sub

    Private Sub DataGridView3_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellDoubleClick
        DataGridView3.ClearSelection()
        Button38.Enabled = False
        Button39.Enabled = False
        Button41.Enabled = False
        Button40.Enabled = False
        Button42.Enabled = False
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        If isSelectAll3 Then
            ' if already selected all, unselect all
            DataGridView3.ClearSelection()
            UpdateRowCounter3()
        Else
            DataGridView3.SelectAll()
            UpdateRowCounter3()
        End If
    End Sub

    Private Sub UpdateRowCounter3()
        Dim curRow As Integer = DataGridView3.RowCount
        Dim selectedRow As Integer = DataGridView3.SelectedRows.Count
        If curRow = selectedRow Then
            Label53.Text = "Selected Row: " & selectedRow & "*"
            Button29.Image = My.Resources.fluent__select_all_on_20_filled
            isSelectAll3 = True
        Else
            Label53.Text = "Selected Row: " & selectedRow
            Button29.Image = My.Resources.fluent__select_all_off_20_filled
            ResetFormMenu3()
            ClearSideInputs3()
            isSelectAll3 = False
        End If
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged
        Debug.WriteLine("TextBox11_TextChanged")
        SearchQuery3()
    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged
        Debug.WriteLine("TextBox12_TextChanged")
        SearchQuery3()
    End Sub

    Private Sub ComboBox7_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox7.SelectedValueChanged
        Debug.WriteLine("ComboBox7_SelectedValueChanged")
        SearchQuery3()
    End Sub

    Private Sub ComboBox8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox8.SelectedIndexChanged
        Debug.WriteLine("ComboBox8_SelectedIndexChanged")
        SearchQuery3()
    End Sub

    Private Sub DateTimePicker10_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker10.ValueChanged
        If DateTimePicker10.Checked AndAlso DateTimePicker10.IsHandleCreated Then
            Debug.WriteLine("DateTimePicker10_ValueChanged")
            SearchQuery3()
        End If
    End Sub

    Private Sub DateTimePicker9_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker9.ValueChanged
        If DateTimePicker9.Checked AndAlso DateTimePicker9.IsHandleCreated Then
            Debug.WriteLine("DateTimePicker9_ValueChanged")
            SearchQuery3()
        End If
    End Sub

    Private Sub DateTimePicker12_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker12.ValueChanged
        If DateTimePicker12.Checked AndAlso DateTimePicker12.IsHandleCreated Then
            Debug.WriteLine("DateTimePicker12_ValueChanged")
            SearchQuery3()
        End If
    End Sub

    Private Sub DateTimePicker11_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker11.ValueChanged
        If DateTimePicker11.Checked AndAlso DateTimePicker11.IsHandleCreated Then
            Debug.WriteLine("DateTimePicker11_ValueChanged")
            SearchQuery3()
        End If
    End Sub

    Private Sub DateTimePicker10_Enter(sender As Object, e As EventArgs) Handles DateTimePicker10.Enter
        DateTimePicker10.CustomFormat = "yyyy/MM/dd"
        DateTimePicker9.CustomFormat = "yyyy/MM/dd"
        DateTimePicker9.Value = DateTimePicker9.MaxDate
    End Sub

    Private Sub DateTimePicker9_Enter(sender As Object, e As EventArgs) Handles DateTimePicker9.Enter
        DateTimePicker10.CustomFormat = "yyyy/MM/dd"
        DateTimePicker9.CustomFormat = "yyyy/MM/dd"
        DateTimePicker9.Value = DateTimePicker9.MaxDate
    End Sub

    Private Sub DateTimePicker12_Enter(sender As Object, e As EventArgs) Handles DateTimePicker12.Enter
        DateTimePicker12.CustomFormat = "hh:mm:ss tt"
        DateTimePicker11.CustomFormat = "hh:mm:ss tt"
    End Sub

    Private Sub DateTimePicker11_Enter(sender As Object, e As EventArgs) Handles DateTimePicker11.Enter
        DateTimePicker12.CustomFormat = "hh:mm:ss tt"
        DateTimePicker11.CustomFormat = "hh:mm:ss tt"
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        FlowLayoutPanel11.Visible = True
        Panel18.Visible = False
        Panel19.Visible = True
    End Sub


    ' Error prevention
    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged
        Dim digitsOnly As New Regex("[^\d\.]")
        TextBox13.Text = digitsOnly.Replace(TextBox13.Text, "")
    End Sub

    Private Sub TextBox13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox13.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        Dim num = Generate7Id("capital_and_savings", "Capital_Savings_ID")
        TextBox14.Text = num
    End Sub


    ' CRUD Search Methods
    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Dim transacType = ComboBox10.Text.Trim
        Dim amount = TextBox13.Text.Trim
        Dim id = TextBox14.Text

        If id.Length = 0 Then
            id = Generate7Id("capital_and_savings", "Capital_Savings_ID").ToString
        End If

        If transacType.Length > 0 And amount.Length > 0 Then
            Dim data = {id, ComboBox10.Text, TextBox13.Text}
            InsertCapitalSavings(data)
            ClearSearchInputs3()
            ClearSideInputs3()
            LoadDatagrid3("SELECT * FROM capital_and_savings WHERE Transaction_Type LIKE '%Savings%'")
        Else
            MessageBox.Show("Missing inputs: Action Failed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        End If
    End Sub

    Private Sub LoadDatagrid3(str As String)
        Try
            ReadQuery(str)
            DataGridView3.Rows.Clear()
            With cmdread
                While .Read
                    Dim time1 As DateTime = .GetValue(4).ToString()
                    DataGridView3.Rows.Add(.GetValue(0), .GetValue(1), .GetValue(2), .GetValue(3), time1, .GetValue(5))
                End While
            End With
            DataGridView3.ClearSelection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        End Try
    End Sub

    Private Sub SearchQuery3()
        Dim loanId As String = TextBox11.Text.Trim()
        Dim transacType As String = ComboBox7.Text.Trim()
        Dim amount As String = TextBox12.Text.Trim()
        Dim datetoDtp As String = DateTimePicker9.Value.ToString("yyyy/MM/dd")
        Dim datefromDtp As String = DateTimePicker10.Value.ToString("yyyy/MM/dd")
        Dim timetoDtp As String = DateTimePicker11.Value.ToString("HH:mm:ss")
        Dim timefromDtp As String = DateTimePicker12.Value.ToString("HH:mm:ss")
        Dim status As String = ComboBox8.Text

        Dim whereClause As String = String.Empty
        If loanId.Length > 0 Then
            If whereClause.Length > 0 Then
                whereClause &= " AND "
            End If
            whereClause &= " Capital_Savings_ID LIKE '%" & loanId & "%'"
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

        If DateTimePicker9.CustomFormat.ToString() <> " " Then
            If datefromDtp < datetoDtp Then
                If whereClause.Length > 0 Then
                    whereClause &= " And "
                End If
                whereClause &= " Date BETWEEN '" & datefromDtp & "' AND '" & datetoDtp & "'"
            Else
                DateTimePicker9.Value = DateTimePicker9.MaxDate
                MessageBox.Show("Invalid date range input!" & vbCrLf & "Check your time range value", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
        End If

        If DateTimePicker11.CustomFormat.ToString() <> " " Then
            If timefromDtp < timetoDtp Then
                If whereClause.Length > 0 Then
                    whereClause &= " And "
                End If
                whereClause &= " Time BETWEEN '" & timefromDtp & "' AND '" & timetoDtp & "'"
            Else
                DateTimePicker12.Value = New DateTime(DateTimePicker12.MinDate.Year, DateTimePicker12.MinDate.Month, DateTime.Now.Day, 0, 0, 0)
                DateTimePicker11.Value = New DateTime(DateTimePicker11.MinDate.Year, DateTimePicker11.MinDate.Month, DateTime.Now.Day, 23, 59, 0)
                MessageBox.Show("Invalid time range input!" & vbCrLf & "Check your time range value", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
        End If

        If status.Length > 0 Then
            If whereClause.Length > 0 Then
                whereClause &= " AND "
            End If
            whereClause &= " Status = '" & status & "'"
        End If

        Dim strQuery As String = "SELECT * FROM capital_and_savings"
        If whereClause.Length > 0 Then
            strQuery &= " WHERE " & whereClause & " AND Transaction_Type LIKE '%Savings%'"
        Else
            strQuery &= " WHERE Transaction_Type LIKE '%Savings%'"
        End If
        Debug.WriteLine(strQuery)
        LoadDatagrid3(strQuery)
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        Dim transacType = ComboBox10.Text.Trim
        Dim amount = TextBox13.Text.Trim
        Dim status = ComboBox9.Text.Trim
        If transacType.Length > 0 Or amount.Length > 0 Or status.Length > 0 Then
            Dim setClause = String.Empty
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

            Dim strQuery = "UPDATE capital_and_savings SET" & setClause & " WHERE Capital_Savings_ID= '" & TextBox14.Text & "'"

            Dim queryResult As Integer = ReadQuery(strQuery)
            ClearSearchInputs3()
            ClearSideInputs3()
            LoadDatagrid3("SELECT * FROM capital_and_savings WHERE Transaction_Type LIKE '%Savings%'")
            If queryResult = 1 Then
                MessageBox.Show("Record " & TextBox14.Text & "Updated :)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
            End If
        Else
            MessageBox.Show("Missing inputs: Update Failed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        End If
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        Dim id = DataGridView3.SelectedRows(0).Cells(0).Value.ToString
        Dim result = MessageBox.Show("Delete Record for ID:" & id & "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            Dim str = "DELETE FROM capital_and_savings WHERE Capital_Savings_ID = '" & id & "'"
            ReadQuery(str)
            ResetForm3()
            MessageBox.Show("Record " & id & " Deleted :)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
        End If
    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        Dim endCount = DataGridView3.SelectedRows.Count
        Dim result = MessageBox.Show("Are you sure you want to delete in bulk " & endCount & " loan data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            Dim a As Byte
            ' For loop delete execution 
            For a = 0 To endCount - 1
                Dim id = DataGridView3.SelectedRows(a).Cells(0).Value.ToString
                Dim str = "DELETE FROM capital_and_savings WHERE Capital_Savings_ID = '" & id & "'"
                ReadQuery(str)
            Next
            ResetForm3()
            MessageBox.Show("Sucessfully deleted " & endCount & " savings data :)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
        End If
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        Dim endCount = DataGridView3.SelectedRows.Count
        Dim transacType = ComboBox12.Text.Trim
        Dim amount = TextBox15.Text.Trim
        Dim status = ComboBox11.Text.Trim
        If transacType.Length > 0 Or amount.Length > 0 Or status.Length > 0 Then
            Dim result = MessageBox.Show("Are you sure you want to update in bulk " & endCount & " loan data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            If result = DialogResult.Yes Then
                Dim a As Byte
                Debug.WriteLine("endCount: " & endCount)
                Debug.WriteLine("DataGridView3.SelectedRows(a).Cells(0).Value.ToString(): " & DataGridView3.SelectedRows(a).Cells(0).Value.ToString)

                ' For loop update execution 
                For a = 0 To endCount - 1
                    Dim id = DataGridView3.SelectedRows(a).Cells(0).Value.ToString
                    Dim setClause = String.Empty
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

                    Dim strQuery = "UPDATE capital_and_savings SET" & setClause & " WHERE Capital_Savings_ID= '" & id & "'"
                    Debug.WriteLine(strQuery)
                    ReadQuery(strQuery)
                Next
                ResetForm3()
                MessageBox.Show("Sucessfully updated " & endCount & " savings data :)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
            End If
        Else
            MessageBox.Show("Missing inputs: Update Failed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        End If
    End Sub

    ' ################################################# SAVINGS TAB END ################################################################################################################################


    ' ################################################# MEMBERS TAB ################################################################################################################################

    Dim isSelectAll4 As Boolean = False
    Dim isSidePanelOpen4 As Boolean = False

    ' Tooltips
    Private Sub Button50_MouseHover(sender As Object, e As EventArgs) Handles Button50.MouseHover
        ToolTip1.SetToolTip(Button50, "Refresh")
    End Sub

    Private Sub Button51_MouseHover(sender As Object, e As EventArgs) Handles Button51.MouseHover
        ToolTip1.SetToolTip(Button51, "Add Data")
    End Sub

    Private Sub Button52_MouseHover(sender As Object, e As EventArgs) Handles Button52.MouseHover
        ToolTip1.SetToolTip(Button52, "Update Data")
    End Sub

    Private Sub Button53_MouseHover(sender As Object, e As EventArgs) Handles Button53.MouseHover
        ToolTip1.SetToolTip(Button53, "Delete Data")
    End Sub

    Private Sub Button55_MouseHover(sender As Object, e As EventArgs) Handles Button55.MouseHover
        ToolTip1.SetToolTip(Button55, "Bulk Delete")
    End Sub

    Private Sub Button54_MouseHover(sender As Object, e As EventArgs) Handles Button54.MouseHover
        ToolTip1.SetToolTip(Button54, "Bulk Update")
    End Sub

    Private Sub Button56_MouseHover(sender As Object, e As EventArgs) Handles Button56.MouseHover
        ToolTip1.SetToolTip(Button56, "Export")
    End Sub


    ' Navigation and Layout Controls
    Private Sub Members_tab_Enter(sender As Object, e As EventArgs) Handles Members_tab.Enter
        ResetForm4()
    End Sub

    Private Sub ResetForm4()
        ResetFormMenu4()
        ClearSearchInputs4()
        ClearSideInputs4()
        FlowLayoutPanel15.Visible = False
        Label89.Text = "Create New Member"
        Label85.Visible = False
        ComboBox15.Visible = False
        LoadDatagrid4("SELECT * FROM members")
    End Sub

    Private Sub ResetFormMenu4()
        Button52.Enabled = False
        Button53.Enabled = False
        Button55.Enabled = False
        Button54.Enabled = False
        Button56.Enabled = False
    End Sub

    Private Sub ClearSideInputs4()
        Button46.Enabled = True
        isSidePanelOpen4 = False

        Button48.Visible = False
        Button45.Visible = False
        Button44.Visible = True
        FlowLayoutPanel15.Visible = False

        TextBox19.Clear()
        TextBox20.Clear()
        TextBox18.Clear()
        TextBox31.Clear()
        DateTimePicker15.Value = DateTimePicker15.MaxDate
        ComboBox16.Text = Nothing
        TextBox17.Clear()
        TextBox21.Clear()
        TextBox22.Clear()
        TextBox23.Clear()
        ComboBox15.Text = Nothing
    End Sub

    Private Sub ClearSearchInputs4()
        TextBox16.Clear()
        TextBox24.Clear()
        TextBox25.Clear()
        TextBox26.Clear()
        ComboBox14.Text = Nothing
        TextBox27.Clear()
        TextBox28.Clear()
        TextBox29.Clear()
        TextBox30.Clear()
        ComboBox13.Text = Nothing
        DateTimePicker13.MaxDate = DateTime.Now
        DateTimePicker14.CustomFormat = " "  'An empty SPACE
        DateTimePicker13.CustomFormat = " "
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        ClearSearchInputs4()
        ClearSideInputs4()
        FlowLayoutPanel15.Visible = False
    End Sub

    Private Sub Button51_Click(sender As Object, e As EventArgs) Handles Button51.Click
        If Not isSidePanelOpen4 Then
            SideCreateMode4()
            isSidePanelOpen = True
        End If
    End Sub

    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles Button50.Click
        ResetForm4()
    End Sub

    Sub SideUpdateMode4()
        Label85.Visible = True
        ComboBox15.Visible = True
        Label89.Text = "Update Member Data"
        FlowLayoutPanel15.Visible = True
        Button46.Enabled = False
        Button48.Visible = False
        Button45.Visible = True
        Button44.Visible = False

        ' Set the selected data as default
        TextBox19.Text = DataGridView4.SelectedRows(0).Cells(0).Value.ToString()
        TextBox20.Text = DataGridView4.SelectedRows(0).Cells(1).Value.ToString()
        TextBox18.Text = DataGridView4.SelectedRows(0).Cells(2).Value.ToString()
        TextBox31.Text = DataGridView4.SelectedRows(0).Cells(3).Value.ToString()
        DateTimePicker15.Text = DataGridView4.SelectedRows(0).Cells(4).Value.ToString()
        ComboBox16.Text = DataGridView4.SelectedRows(0).Cells(5).Value.ToString()
        TextBox17.Text = DataGridView4.SelectedRows(0).Cells(6).Value.ToString()
        TextBox21.Text = DataGridView4.SelectedRows(0).Cells(7).Value.ToString()
        TextBox22.Text = DataGridView4.SelectedRows(0).Cells(8).Value.ToString()
        TextBox23.Text = DataGridView4.SelectedRows(0).Cells(9).Value.ToString()
        ComboBox15.Text = DataGridView4.SelectedRows(0).Cells(10).Value.ToString()

    End Sub

    Sub SideCreateMode4()
        ResetForm4()
        FlowLayoutPanel15.Visible = True
    End Sub

    Private Sub Button52_Click(sender As Object, e As EventArgs) Handles Button52.Click
        SideUpdateMode4()
    End Sub

    Private Sub Button54_Click(sender As Object, e As EventArgs) Handles Button54.Click
        FlowLayoutPanel15.Visible = True
        Label89.Text = "Bulk Update Member Data"
        Button46.Enabled = False
        Button48.Visible = True
        Button45.Visible = False
        Button44.Visible = False
        Label85.Visible = True
        ComboBox15.Visible = True
    End Sub

    Private Sub DataGridView4_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView4.SelectionChanged
        Dim num = DataGridView4.SelectedRows.Count
        UpdateRowCounter4()

        If num >= 2 Then
            Button52.Enabled = False
            Button53.Enabled = False
            Button55.Enabled = True
            Button54.Enabled = True
            Button56.Enabled = True
        ElseIf num = 1 Then
            Button52.Enabled = True
            Button53.Enabled = True
            Button55.Enabled = False
            Button54.Enabled = False
            Button56.Enabled = True
        End If
    End Sub

    Private Sub DataGridView4_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellDoubleClick
        DataGridView4.ClearSelection()
        Button52.Enabled = False
        Button53.Enabled = False
        Button55.Enabled = False
        Button54.Enabled = False
        Button56.Enabled = False
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        If isSelectAll4 Then
            ' if already selected all, unselect all
            DataGridView4.ClearSelection()
            UpdateRowCounter4()
        Else
            DataGridView4.SelectAll()
            UpdateRowCounter4()
        End If
    End Sub

    Private Sub UpdateRowCounter4()
        Dim curRow As Integer = DataGridView4.RowCount
        Dim selectedRow As Integer = DataGridView4.SelectedRows.Count
        If curRow = selectedRow Then
            Label24.Text = "Selected Row: " & selectedRow & "*"
            Button43.Image = My.Resources.fluent__select_all_on_20_filled
            isSelectAll4 = True
        Else
            Label24.Text = "Selected Row: " & selectedRow
            Button43.Image = My.Resources.fluent__select_all_off_20_filled
            ResetFormMenu4()
            ClearSideInputs4()
            isSelectAll4 = False
        End If
    End Sub

    Private Sub TextBox16_TextChanged(sender As Object, e As EventArgs) Handles TextBox16.TextChanged
        SearchQuery4()
    End Sub

    Private Sub TextBox24_TextChanged(sender As Object, e As EventArgs) Handles TextBox24.TextChanged
        SearchQuery4()
    End Sub

    Private Sub TextBox25_TextChanged(sender As Object, e As EventArgs) Handles TextBox25.TextChanged
        SearchQuery4()
    End Sub

    Private Sub TextBox26_TextChanged(sender As Object, e As EventArgs) Handles TextBox26.TextChanged
        SearchQuery4()
    End Sub

    Private Sub ComboBox14_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox14.SelectedIndexChanged
        SearchQuery4()
    End Sub

    Private Sub TextBox27_TextChanged(sender As Object, e As EventArgs) Handles TextBox27.TextChanged
        SearchQuery4()
    End Sub

    Private Sub TextBox28_TextChanged(sender As Object, e As EventArgs) Handles TextBox28.TextChanged
        SearchQuery4()
    End Sub

    Private Sub TextBox29_TextChanged(sender As Object, e As EventArgs) Handles TextBox29.TextChanged
        SearchQuery4()
    End Sub

    Private Sub TextBox30_TextChanged(sender As Object, e As EventArgs) Handles TextBox30.TextChanged
        SearchQuery4()
    End Sub

    Private Sub ComboBox13_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox13.SelectedIndexChanged
        SearchQuery4()
    End Sub

    Private Sub DateTimePicker14_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker14.ValueChanged
        If DateTimePicker14.Checked AndAlso DateTimePicker14.IsHandleCreated Then
            Debug.WriteLine("DateTimePicker14_ValueChanged")
            SearchQuery4()
        End If
    End Sub

    Private Sub DateTimePicker13_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker13.ValueChanged
        If DateTimePicker13.Checked AndAlso DateTimePicker13.IsHandleCreated Then
            Debug.WriteLine("DateTimePicker13_ValueChanged")
            SearchQuery4()
        End If
    End Sub

    Private Sub DateTimePicker14_Enter(sender As Object, e As EventArgs) Handles DateTimePicker14.Enter
        DateTimePicker14.CustomFormat = "yyyy/MM/dd"
        DateTimePicker13.CustomFormat = "yyyy/MM/dd"
        DateTimePicker13.Value = DateTimePicker13.MaxDate
    End Sub

    Private Sub DateTimePicker13_Enter(sender As Object, e As EventArgs) Handles DateTimePicker13.Enter
        DateTimePicker14.CustomFormat = "yyyy/MM/dd"
        DateTimePicker13.CustomFormat = "yyyy/MM/dd"
        DateTimePicker13.Value = DateTimePicker13.MaxDate
    End Sub

    ' Error prevention
    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        Dim num = Generate7Id("members", "Member_ID")
        TextBox19.Text = num
    End Sub


    ' CRUDS Methods
    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        Dim id = TextBox19.Text.Trim
        Dim fname = TextBox20.Text.Trim
        Dim mname = TextBox18.Text.Trim
        Dim lname = TextBox31.Text.Trim
        Dim dob = DateTimePicker15.Value.ToString("yyyy/MM/dd")
        Dim sex = ComboBox16.Text
        Dim address = TextBox17.Text.Trim
        Dim phonenum = TextBox21.Text.Trim
        Dim occupation = TextBox22.Text.Trim
        Dim annual_inc = TextBox23.Text.Trim

        If id.Length = 0 Then
            id = Generate7Id("members", "Member_ID").ToString
            TextBox19.Text = id
        End If

        If fname.Length > 0 And mname.Length > 0 And lname.Length > 0 And sex.Length > 0 And address.Length > 0 And phonenum.Length > 0 And occupation.Length > 0 And annual_inc.Length > 0 Then
            Dim data = {id, fname, mname, lname, dob, sex, address, phonenum, occupation, annual_inc}
            InsertMembers(data)
            ClearSearchInputs4()
            ClearSideInputs4()
            LoadDatagrid4("SELECT * FROM members")
        Else
            MessageBox.Show("Missing inputs: Action Failed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        End If
    End Sub

    Private Sub LoadDatagrid4(str As String)
        Try
            ReadQuery(str)
            DataGridView4.Rows.Clear()
            With cmdread
                While .Read
                    DataGridView4.Rows.Add(.GetValue(0), .GetValue(1), .GetValue(2), .GetValue(3), .GetValue(4), .GetValue(5), .GetValue(6), .GetValue(7), .GetValue(8), .GetValue(9), .GetValue(10))
                End While
            End With
            DataGridView4.ClearSelection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        End Try
    End Sub

    Private Sub SearchQuery4()
        Dim id As String = TextBox16.Text.Trim()
        Dim fname As String = TextBox24.Text.Trim()
        Dim mname As String = TextBox25.Text.Trim()
        Dim lname As String = TextBox26.Text.Trim()
        Dim datetoDtp As String = DateTimePicker13.Value.ToString("yyyy/MM/dd")
        Dim datefromDtp As String = DateTimePicker14.Value.ToString("yyyy/MM/dd")
        Dim sex As String = ComboBox14.Text
        Dim address As String = TextBox27.Text.Trim()
        Dim phonenum As String = TextBox28.Text.Trim()
        Dim occupation As String = TextBox29.Text.Trim()
        Dim annual_inc As String = TextBox30.Text.Trim()
        Dim status As String = ComboBox13.Text

        Dim whereClause As String = String.Empty
        If id.Length > 0 Then
            If whereClause.Length > 0 Then
                whereClause &= " AND "
            End If
            whereClause &= " Member_ID LIKE '%" & id & "%'"
        End If
        If fname.Length > 0 Then
            If whereClause.Length > 0 Then
                whereClause &= " AND "
            End If
            whereClause &= " Fname LIKE '%" & fname & "%'"
        End If
        If mname.Length > 0 Then
            If whereClause.Length > 0 Then
                whereClause &= " AND "
            End If
            whereClause &= " Mname LIKE '%" & mname & "%'"
        End If
        If lname.Length > 0 Then
            If whereClause.Length > 0 Then
                whereClause &= " AND "
            End If
            whereClause &= " Lname LIKE '%" & lname & "%'"
        End If
        If DateTimePicker13.CustomFormat.ToString() <> " " Then
            If datefromDtp < datetoDtp Then
                If whereClause.Length > 0 Then
                    whereClause &= " And "
                End If
                whereClause &= " Dob BETWEEN '" & datefromDtp & "' AND '" & datetoDtp & "'"
            Else
                DateTimePicker13.Value = DateTimePicker13.MaxDate
                MessageBox.Show("Invalid date range input!" & vbCrLf & "Check your time range value", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
        End If
        If sex.Length > 0 Then
            If whereClause.Length > 0 Then
                whereClause &= " AND "
            End If
            whereClause &= " sex= '" & sex & "'"
        End If
        If address.Length > 0 Then
            If whereClause.Length > 0 Then
                whereClause &= " AND "
            End If
            whereClause &= " Address LIKE '%" & address & "%'"
        End If
        If phonenum.Length > 0 Then
            If whereClause.Length > 0 Then
                whereClause &= " AND "
            End If
            whereClause &= " Phone_Num LIKE '%" & phonenum & "%'"
        End If
        If occupation.Length > 0 Then
            If whereClause.Length > 0 Then
                whereClause &= " AND "
            End If
            whereClause &= " Occupation LIKE '%" & occupation & "%'"
        End If
        If annual_inc.Length > 0 Then
            If whereClause.Length > 0 Then
                whereClause &= " AND "
            End If
            whereClause &= " Annual_Income LIKE '%" & annual_inc & "%'"
        End If
        If status.Length > 0 Then
            If whereClause.Length > 0 Then
                whereClause &= " AND "
            End If
            whereClause &= " Status = '" & status & "'"
        End If

        Dim strQuery As String = "SELECT * FROM members"
        If whereClause.Length > 0 Then
            strQuery &= " WHERE " & whereClause
        End If
        Debug.WriteLine(strQuery)
        LoadDatagrid4(strQuery)
    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        Dim id = TextBox19.Text.Trim
        Dim fname = TextBox20.Text.Trim
        Dim mname = TextBox18.Text.Trim
        Dim lname = TextBox31.Text.Trim
        Dim dob = DateTimePicker15.Value.ToString("yyyy/MM/dd")
        Dim sex = ComboBox16.Text
        Dim address = TextBox17.Text.Trim
        Dim phonenum = TextBox21.Text.Trim
        Dim occupation = TextBox22.Text.Trim
        Dim annual_inc = TextBox23.Text.Trim
        Dim status = ComboBox15.Text

        If fname.Length > 0 Or mname.Length > 0 Or mname.Length > 0 Or lname.Length > 0 Or sex.Length > 0 Or address.Length > 0 Or phonenum.Length > 0 Or occupation.Length > 0 Or annual_inc.Length > 0 Or status.Length > 0 Then
            Dim setClause = String.Empty
            If fname.Length > 0 Then
                If setClause.Length > 0 Then
                    setClause &= ","
                End If
                setClause &= " Fname = '" & fname & "'"
            End If
            If mname.Length > 0 Then
                If setClause.Length > 0 Then
                    setClause &= ","
                End If
                setClause &= " Mname = '" & mname & "'"
            End If
            If lname.Length > 0 Then
                If setClause.Length > 0 Then
                    setClause &= ","
                End If
                setClause &= " Lname = '" & lname & "'"
            End If
            If setClause.Length > 0 Then
                setClause &= ", Dob = '" & dob & "'"
            Else
                setClause &= " Dob = '" & dob & "'"
            End If
            If sex.Length > 0 Then
                If setClause.Length > 0 Then
                    setClause &= ","
                End If
                setClause &= " Sex = '" & sex & "'"
            End If
            If address.Length > 0 Then
                If setClause.Length > 0 Then
                    setClause &= ","
                End If
                setClause &= " Address = '" & address & "'"
            End If
            If phonenum.Length > 0 Then
                If setClause.Length > 0 Then
                    setClause &= ","
                End If
                setClause &= " Phone_Num = '" & phonenum & "'"
            End If
            If occupation.Length > 0 Then
                If setClause.Length > 0 Then
                    setClause &= ","
                End If
                setClause &= " Occupation = '" & occupation & "'"
            End If
            If annual_inc.Length > 0 Then
                If setClause.Length > 0 Then
                    setClause &= ","
                End If
                setClause &= " Annual_Income = '" & annual_inc & "'"
            End If
            If status.Length > 0 Then
                If setClause.Length > 0 Then
                    setClause &= ","
                End If
                setClause &= " Status = '" & status & "'"
            End If

            Dim strQuery = "UPDATE members SET" & setClause & " WHERE Member_ID= '" & id & "'"

            Dim queryResult As Integer = ReadQuery(strQuery)
            ClearSearchInputs4()
            ClearSideInputs4()
            LoadDatagrid4("SELECT * FROM members")
            If queryResult = 1 Then
                MessageBox.Show("Record " & LoanIdText.Text & "Updated :)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
            End If
        Else
            MessageBox.Show("Missing inputs: Update Failed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        End If
    End Sub

    Private Sub Button53_Click(sender As Object, e As EventArgs) Handles Button53.Click
        Dim id = DataGridView4.SelectedRows(0).Cells(0).Value.ToString
        Dim result = MessageBox.Show("Delete Record for ID:" & id & "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            Dim str = "DELETE FROM members WHERE Member_ID = '" & id & "'"
            ReadQuery(str)
            ResetForm4()
            MessageBox.Show("Record " & id & " Deleted :)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
        End If
    End Sub

    Private Sub Button55_Click(sender As Object, e As EventArgs) Handles Button55.Click
        Dim endCount = DataGridView4.SelectedRows.Count
        Dim result = MessageBox.Show("Are you sure you want to delete in bulk " & endCount & " member data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            Dim a As Byte
            ' For loop delete execution 
            For a = 0 To endCount - 1D
                Dim id = DataGridView4.SelectedRows(a).Cells(0).Value.ToString
                Dim str = "DELETE FROM members WHERE Member_ID = '" & id & "'"
                ReadQuery(str)
            Next
            ResetForm4()
            MessageBox.Show("Sucessfully deleted " & endCount & " member data :)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
        End If
    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        Dim endCount = DataGridView4.SelectedRows.Count
        Dim fname = TextBox20.Text.Trim
        Dim mname = TextBox18.Text.Trim
        Dim lname = TextBox31.Text.Trim
        Dim dob = DateTimePicker15.Value.ToString("yyyy/MM/dd")
        Dim sex = ComboBox16.Text
        Dim address = TextBox17.Text.Trim
        Dim phonenum = TextBox21.Text.Trim
        Dim occupation = TextBox22.Text.Trim
        Dim annual_inc = TextBox23.Text.Trim
        Dim status = ComboBox15.Text

        If fname.Length > 0 Or mname.Length > 0 Or mname.Length > 0 Or lname.Length > 0 Or sex.Length > 0 Or address.Length > 0 Or phonenum.Length > 0 Or occupation.Length > 0 Or annual_inc.Length > 0 Or status.Length > 0 Then
            Dim result = MessageBox.Show("Are you sure you want to update in bulk " & endCount & " member data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            If result = DialogResult.Yes Then
                Dim a As Byte

                ' For loop update execution 
                For a = 0 To endCount - 1
                    Dim id = DataGridView4.SelectedRows(a).Cells(0).Value.ToString
                    Dim setClause = String.Empty
                    If fname.Length > 0 Then
                        If setClause.Length > 0 Then
                            setClause &= ","
                        End If
                        setClause &= " Fname = '" & fname & "'"
                    End If
                    If mname.Length > 0 Then
                        If setClause.Length > 0 Then
                            setClause &= ","
                        End If
                        setClause &= " Mname = '" & mname & "'"
                    End If
                    If lname.Length > 0 Then
                        If setClause.Length > 0 Then
                            setClause &= ","
                        End If
                        setClause &= " Lname = '" & lname & "'"
                    End If
                    If setClause.Length > 0 Then
                        setClause &= ", Dob = '" & dob & "'"
                    Else
                        setClause &= " Dob = '" & dob & "'"
                    End If
                    If sex.Length > 0 Then
                        If setClause.Length > 0 Then
                            setClause &= ","
                        End If
                        setClause &= " Sex = '" & sex & "'"
                    End If
                    If address.Length > 0 Then
                        If setClause.Length > 0 Then
                            setClause &= ","
                        End If
                        setClause &= " Address = '" & address & "'"
                    End If
                    If phonenum.Length > 0 Then
                        If setClause.Length > 0 Then
                            setClause &= ","
                        End If
                        setClause &= " Phone_Num = '" & phonenum & "'"
                    End If
                    If occupation.Length > 0 Then
                        If setClause.Length > 0 Then
                            setClause &= ","
                        End If
                        setClause &= " Occupation = '" & occupation & "'"
                    End If
                    If annual_inc.Length > 0 Then
                        If setClause.Length > 0 Then
                            setClause &= ","
                        End If
                        setClause &= " Annual_Income = '" & annual_inc & "'"
                    End If
                    If status.Length > 0 Then
                        If setClause.Length > 0 Then
                            setClause &= ","
                        End If
                        setClause &= " Status = '" & status & "'"
                    End If

                    Dim strQuery = "UPDATE members SET" & setClause & " WHERE Member_ID= '" & id & "'"
                    Debug.WriteLine(strQuery)
                    ReadQuery(strQuery)
                Next
                ResetForm4()
                MessageBox.Show("Sucessfully updated " & endCount & " member data :)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
            End If
        Else
            MessageBox.Show("Missing inputs: Update Failed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        End If
    End Sub

    ' ################################################# MEMBERS TAB END ################################################################################################################################


    ' ################################################# STAFFS TAB ################################################################################################################################

    Dim isSelectAll5 As Boolean = False
    Dim isSidePanelOpen5 As Boolean = False

    ' Tooltips
    Private Sub Button62_MouseHover(sender As Object, e As EventArgs) Handles Button62.MouseHover
        ToolTip1.SetToolTip(Button62, "Refresh")
    End Sub

    Private Sub Button63_MouseHover(sender As Object, e As EventArgs) Handles Button63.MouseHover
        ToolTip1.SetToolTip(Button63, "Add Data")
    End Sub

    Private Sub Button64_MouseHover(sender As Object, e As EventArgs) Handles Button64.MouseHover
        ToolTip1.SetToolTip(Button64, "Update Data")
    End Sub

    Private Sub Button65_MouseHover(sender As Object, e As EventArgs) Handles Button65.MouseHover
        ToolTip1.SetToolTip(Button65, "Delete Data")
    End Sub

    Private Sub Button67_MouseHover(sender As Object, e As EventArgs) Handles Button67.MouseHover
        ToolTip1.SetToolTip(Button67, "Bulk Delete")
    End Sub

    Private Sub Button66_MouseHover(sender As Object, e As EventArgs) Handles Button66.MouseHover
        ToolTip1.SetToolTip(Button66, "Bulk Update")
    End Sub

    Private Sub Button68_MouseHover(sender As Object, e As EventArgs) Handles Button68.MouseHover
        ToolTip1.SetToolTip(Button68, "Export")
    End Sub


    ' Navigation and Layout Controls
    Private Sub Staffs_tab_Enter(sender As Object, e As EventArgs) Handles Staffs_tab.Enter
        ResetForm5()
    End Sub

    Private Sub ResetForm5()
        ResetFormMenu5()
        ClearSearchInputs5()
        ClearSideInputs5()
        FlowLayoutPanel19.Visible = False
        Label126.Text = "Create New Staff"
        LoadDatagrid5("SELECT * FROM staffs")
    End Sub

    Private Sub ResetFormMenu5()
        Button64.Enabled = False
        Button65.Enabled = False
        Button67.Enabled = False
        Button66.Enabled = False
        Button68.Enabled = False
    End Sub

    Private Sub ClearSideInputs5()
        Button60.Enabled = True
        isSidePanelOpen5 = False

        Button59.Visible = False ' Bulk 59
        Button58.Visible = False ' Update 58
        Button57.Visible = True  ' Create57
        FlowLayoutPanel19.Visible = False

        TextBox47.Clear()
        TextBox45.Clear()
        TextBox46.Clear()
        TextBox40.Clear()
        TextBox43.Clear()
        TextBox44.Clear()
        TextBox42.Clear()
    End Sub

    Private Sub ClearSearchInputs5()
        TextBox32.Clear()
        TextBox33.Clear()
        TextBox34.Clear()
        TextBox35.Clear()
        TextBox37.Clear()
        TextBox39.Clear()
        TextBox38.Clear()
    End Sub

    Private Sub Button61_Click(sender As Object, e As EventArgs) Handles Button61.Click
        ClearSearchInputs5()
        ClearSideInputs5()
        FlowLayoutPanel19.Visible = False
    End Sub

    Private Sub Button63_Click(sender As Object, e As EventArgs) Handles Button63.Click
        If Not isSidePanelOpen5 Then
            SideCreateMode5()
            isSidePanelOpen = True
        End If
    End Sub

    Private Sub Button62_Click(sender As Object, e As EventArgs) Handles Button62.Click
        ResetForm5()
    End Sub

    Sub SideUpdateMode5()
        Label126.Text = "Update Staff Data"
        FlowLayoutPanel19.Visible = True
        Button60.Enabled = False
        Button59.Visible = False
        Button58.Visible = True
        Button57.Visible = False

        ' Set the selected data as default
        TextBox47.Text = DataGridView5.SelectedRows(0).Cells(0).Value.ToString()
        TextBox45.Text = DataGridView5.SelectedRows(0).Cells(1).Value.ToString()
        TextBox46.Text = DataGridView5.SelectedRows(0).Cells(2).Value.ToString()
        TextBox40.Text = DataGridView5.SelectedRows(0).Cells(3).Value.ToString()
        TextBox43.Text = DataGridView5.SelectedRows(0).Cells(6).Value.ToString()
        TextBox44.Text = DataGridView5.SelectedRows(0).Cells(7).Value.ToString()
        TextBox42.Text = DataGridView5.SelectedRows(0).Cells(8).Value.ToString()
    End Sub

    Sub SideCreateMode5()
        ResetForm5()
        FlowLayoutPanel19.Visible = True
    End Sub

    Private Sub Button64_Click(sender As Object, e As EventArgs) Handles Button64.Click
        SideUpdateMode5()
    End Sub

    Private Sub Button66_Click(sender As Object, e As EventArgs) Handles Button66.Click
        FlowLayoutPanel19.Visible = True
        Label126.Text = "Bulk Update Staff Data"
        Button60.Enabled = False
        Button59.Visible = True
        Button58.Visible = False
        Button57.Visible = False
    End Sub

    Private Sub DataGridView5_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView5.SelectionChanged
        Dim num = DataGridView5.SelectedRows.Count
        UpdateRowCounter5()

        If num >= 2 Then
            Button64.Enabled = False
            Button65.Enabled = False
            Button67.Enabled = True
            Button66.Enabled = True
            Button68.Enabled = True
        ElseIf num = 1 Then
            Button64.Enabled = True
            Button65.Enabled = True
            Button67.Enabled = False
            Button66.Enabled = False
            Button68.Enabled = True
        End If
    End Sub

    Private Sub DataGridView5_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView5.CellDoubleClick
        DataGridView5.ClearSelection()
        Button64.Enabled = False
        Button65.Enabled = False
        Button67.Enabled = False
        Button66.Enabled = False
        Button68.Enabled = False
    End Sub

    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Button49.Click
        If isSelectAll5 Then
            ' if already selected all, unselect all
            DataGridView5.ClearSelection()
            UpdateRowCounter5()
        Else
            DataGridView5.SelectAll()
            UpdateRowCounter5()
        End If
    End Sub

    Private Sub UpdateRowCounter5()
        Dim curRow As Integer = DataGridView5.RowCount
        Dim selectedRow As Integer = DataGridView5.SelectedRows.Count
        If curRow = selectedRow Then
            Label101.Text = "Selected Row: " & selectedRow & "*"
            Button49.Image = My.Resources.fluent__select_all_on_20_filled
            isSelectAll5 = True
        Else
            Label101.Text = "Selected Row: " & selectedRow
            Button49.Image = My.Resources.fluent__select_all_off_20_filled
            ResetFormMenu5()
            ClearSideInputs5()
            isSelectAll5 = False
        End If
    End Sub

    Private Sub TextBox32_TextChanged(sender As Object, e As EventArgs) Handles TextBox32.TextChanged
        SearchQuery5()
    End Sub

    Private Sub TextBox33_TextChanged(sender As Object, e As EventArgs) Handles TextBox33.TextChanged
        SearchQuery5()
    End Sub

    Private Sub TextBox34_TextChanged(sender As Object, e As EventArgs) Handles TextBox34.TextChanged
        SearchQuery5()
    End Sub

    Private Sub TextBox35_TextChanged(sender As Object, e As EventArgs) Handles TextBox35.TextChanged
        SearchQuery5()
    End Sub

    Private Sub TextBox37_TextChanged(sender As Object, e As EventArgs) Handles TextBox37.TextChanged
        SearchQuery5()
    End Sub

    Private Sub TextBox39_TextChanged(sender As Object, e As EventArgs) Handles TextBox39.TextChanged
        SearchQuery5()
    End Sub

    Private Sub TextBox38_TextChanged(sender As Object, e As EventArgs) Handles TextBox38.TextChanged
        SearchQuery5()
    End Sub

    ' Error prevention
    Private Sub Button60_Click(sender As Object, e As EventArgs) Handles Button60.Click
        Dim num = Generate7Id("staffs", "Staff_ID")
        TextBox47.Text = num
    End Sub


    ' CRUDS Methods
    Private Sub Button57_Click(sender As Object, e As EventArgs) Handles Button57.Click
        Dim id = TextBox47.Text.Trim
        Dim fname = TextBox45.Text.Trim
        Dim mname = TextBox46.Text.Trim
        Dim lname = TextBox40.Text.Trim
        Dim address = TextBox43.Text.Trim
        Dim phonenum = TextBox44.Text.Trim
        Dim position = TextBox42.Text.Trim

        If id.Length = 0 Then
            id = Generate7Id("staffs", "Staff_ID").ToString
            TextBox47.Text = id
        End If

        If fname.Length > 0 And mname.Length > 0 And lname.Length > 0 And address.Length > 0 And phonenum.Length > 0 And position.Length > 0 Then
            Dim data = {id, fname, mname, lname, address, phonenum, position}
            InsertMembers(data)
            ClearSearchInputs5()
            ClearSideInputs5()
            LoadDatagrid5("SELECT * FROM staffs")
        Else
            MessageBox.Show("Missing inputs: Action Failed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        End If
    End Sub

    Private Sub LoadDatagrid5(str As String)
        Try
            ReadQuery(str)
            DataGridView5.Rows.Clear()
            With cmdread
                While .Read
                    DataGridView5.Rows.Add(.GetValue(0), .GetValue(1), .GetValue(2), .GetValue(3), .GetValue(4), .GetValue(5), .GetValue(6))
                End While
            End With
            DataGridView5.ClearSelection()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        End Try
    End Sub

    Private Sub SearchQuery5()
        Dim id As String = TextBox32.Text.Trim()
        Dim fname As String = TextBox33.Text.Trim()
        Dim mname As String = TextBox34.Text.Trim()
        Dim lname As String = TextBox35.Text.Trim()
        Dim address As String = TextBox37.Text.Trim()
        Dim phonenum As String = TextBox39.Text.Trim()
        Dim position As String = TextBox38.Text.Trim()

        Dim whereClause As String = String.Empty
        If id.Length > 0 Then
            If whereClause.Length > 0 Then
                whereClause &= " AND "
            End If
            whereClause &= " Staff_ID LIKE '%" & id & "%'"
        End If
        If fname.Length > 0 Then
            If whereClause.Length > 0 Then
                whereClause &= " AND "
            End If
            whereClause &= " Fname LIKE '%" & fname & "%'"
        End If
        If mname.Length > 0 Then
            If whereClause.Length > 0 Then
                whereClause &= " AND "
            End If
            whereClause &= " Mname LIKE '%" & mname & "%'"
        End If
        If lname.Length > 0 Then
            If whereClause.Length > 0 Then
                whereClause &= " AND "
            End If
            whereClause &= " Lname LIKE '%" & lname & "%'"
        End If
        If address.Length > 0 Then
            If whereClause.Length > 0 Then
                whereClause &= " AND "
            End If
            whereClause &= " Address LIKE '%" & address & "%'"
        End If
        If phonenum.Length > 0 Then
            If whereClause.Length > 0 Then
                whereClause &= " AND "
            End If
            whereClause &= " Phone_Num LIKE '%" & phonenum & "%'"
        End If
        If position.Length > 0 Then
            If whereClause.Length > 0 Then
                whereClause &= " AND "
            End If
            whereClause &= " Position LIKE '%" & position & "%'"
        End If

        Dim strQuery As String = "SELECT * FROM staffs"
        If whereClause.Length > 0 Then
            strQuery &= " WHERE " & whereClause
        End If
        Debug.WriteLine(strQuery)
        LoadDatagrid5(strQuery)
    End Sub

    Private Sub Button58_Click(sender As Object, e As EventArgs) Handles Button58.Click
        Dim id = TextBox47.Text.Trim
        Dim fname = TextBox45.Text.Trim
        Dim mname = TextBox46.Text.Trim
        Dim lname = TextBox40.Text.Trim
        Dim address = TextBox43.Text.Trim
        Dim phonenum = TextBox44.Text.Trim
        Dim position = TextBox42.Text.Trim

        If fname.Length > 0 Or mname.Length > 0 Or mname.Length > 0 Or lname.Length > 0 Or address.Length > 0 Or phonenum.Length > 0 Or position.Length > 0 Then
            Dim setClause = String.Empty
            If fname.Length > 0 Then
                If setClause.Length > 0 Then
                    setClause &= ","
                End If
                setClause &= " Fname = '" & fname & "'"
            End If
            If mname.Length > 0 Then
                If setClause.Length > 0 Then
                    setClause &= ","
                End If
                setClause &= " Mname = '" & mname & "'"
            End If
            If lname.Length > 0 Then
                If setClause.Length > 0 Then
                    setClause &= ","
                End If
                setClause &= " Lname = '" & lname & "'"
            End If
            If address.Length > 0 Then
                If setClause.Length > 0 Then
                    setClause &= ","
                End If
                setClause &= " Address = '" & address & "'"
            End If
            If phonenum.Length > 0 Then
                If setClause.Length > 0 Then
                    setClause &= ","
                End If
                setClause &= " Phone_Num = '" & phonenum & "'"
            End If
            If position.Length > 0 Then
                If setClause.Length > 0 Then
                    setClause &= ","
                End If
                setClause &= " Position = '" & position & "'"
            End If

            Dim strQuery = "UPDATE staffs SET" & setClause & " WHERE Staff_ID= '" & id & "'"

            Dim queryResult As Integer = ReadQuery(strQuery)
            ClearSearchInputs5()
            ClearSideInputs5()
            LoadDatagrid5("SELECT * FROM staffs")
            If queryResult = 1 Then
                MessageBox.Show("Record " & LoanIdText.Text & "Updated :)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
            End If
        Else
            MessageBox.Show("Missing inputs: Update Failed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        End If
    End Sub

    Private Sub Button65_Click(sender As Object, e As EventArgs) Handles Button65.Click
        Dim id = DataGridView5.SelectedRows(0).Cells(0).Value.ToString
        Dim result = MessageBox.Show("Delete Record for ID:" & id & "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            Dim str = "DELETE FROM staffs WHERE Staff_ID = '" & id & "'"
            ReadQuery(str)
            ResetForm5()
            MessageBox.Show("Record " & id & " Deleted :)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
        End If
    End Sub

    Private Sub Button67_Click(sender As Object, e As EventArgs) Handles Button67.Click
        Dim endCount = DataGridView5.SelectedRows.Count
        Dim result = MessageBox.Show("Are you sure you want to delete in bulk " & endCount & " staff data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If result = DialogResult.Yes Then
            Dim a As Byte
            ' For loop delete execution 
            For a = 0 To endCount - 1D
                Dim id = DataGridView5.SelectedRows(a).Cells(0).Value.ToString
                Dim str = "DELETE FROM staffs WHERE Staff_ID = '" & id & "'"
                ReadQuery(str)
            Next
            ResetForm5()
            MessageBox.Show("Sucessfully deleted " & endCount & " staff data :)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
        End If
    End Sub

    Private Sub Button59_Click(sender As Object, e As EventArgs) Handles Button59.Click
        Dim endCount = DataGridView5.SelectedRows.Count
        Dim fname = TextBox45.Text.Trim
        Dim mname = TextBox46.Text.Trim
        Dim lname = TextBox40.Text.Trim
        Dim address = TextBox43.Text.Trim
        Dim phonenum = TextBox44.Text.Trim
        Dim position = TextBox42.Text.Trim

        If fname.Length > 0 Or mname.Length > 0 Or mname.Length > 0 Or lname.Length > 0 Or address.Length > 0 Or phonenum.Length > 0 Or position.Length > 0 Then
            Dim result = MessageBox.Show("Are you sure you want to update in bulk " & endCount & " staff data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
            If result = DialogResult.Yes Then
                Dim a As Byte

                ' For loop update execution 
                For a = 0 To endCount - 1
                    Dim id = DataGridView5.SelectedRows(a).Cells(0).Value.ToString
                    Dim setClause = String.Empty
                    If fname.Length > 0 Then
                        If setClause.Length > 0 Then
                            setClause &= ","
                        End If
                        setClause &= " Fname = '" & fname & "'"
                    End If
                    If mname.Length > 0 Then
                        If setClause.Length > 0 Then
                            setClause &= ","
                        End If
                        setClause &= " Mname = '" & mname & "'"
                    End If
                    If lname.Length > 0 Then
                        If setClause.Length > 0 Then
                            setClause &= ","
                        End If
                        setClause &= " Lname = '" & lname & "'"
                    End If
                    If address.Length > 0 Then
                        If setClause.Length > 0 Then
                            setClause &= ","
                        End If
                        setClause &= " Address = '" & address & "'"
                    End If
                    If phonenum.Length > 0 Then
                        If setClause.Length > 0 Then
                            setClause &= ","
                        End If
                        setClause &= " Phone_Num = '" & phonenum & "'"
                    End If
                    If position.Length > 0 Then
                        If setClause.Length > 0 Then
                            setClause &= ","
                        End If
                        setClause &= " Position = '" & position & "'"
                    End If

                    Dim strQuery = "UPDATE staffs SET" & setClause & " WHERE Staff_ID= '" & id & "'"
                    Debug.WriteLine(strQuery)
                    ReadQuery(strQuery)
                Next
                ResetForm5()
                MessageBox.Show("Sucessfully updated " & endCount & " staff data :)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
            End If
        Else
            MessageBox.Show("Missing inputs: Update Failed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        End If
    End Sub

    ' ################################################# STAFFS TAB END ################################################################################################################################


End Class
