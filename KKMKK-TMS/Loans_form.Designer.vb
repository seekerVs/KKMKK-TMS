<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loans_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        refreshBtn = New Button()
        Label2 = New Label()
        createBtn = New Button()
        updateBtn = New Button()
        deleteBtn = New Button()
        BulkUpdateBtn = New Button()
        BulkDeleteBtn = New Button()
        ToolTip1 = New ToolTip(components)
        Side_panel = New FlowLayoutPanel()
        SideInnerPanel1 = New Panel()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        DBInsertBtn = New Button()
        DBUpdateBtn = New Button()
        label199 = New Label()
        AmountText = New TextBox()
        TransacTypeCbbox = New ComboBox()
        Label5 = New Label()
        LoadIdBtn = New Button()
        LoanIdText = New TextBox()
        Label4 = New Label()
        SideBackBtn = New Button()
        Label1 = New Label()
        SideInnerPanel2 = New Panel()
        Button1 = New Button()
        Label3 = New Label()
        Search_panel = New Panel()
        search_pic = New PictureBox()
        amount_txt = New TextBox()
        amount_lbl = New Label()
        type_lbl = New Label()
        type_cbbox = New ComboBox()
        id_lbl = New Label()
        id_txt = New TextBox()
        Main_panel = New Panel()
        select_lbl = New Label()
        LoanDg = New DataGridView()
        col_loanid = New DataGridViewTextBoxColumn()
        col_transactype = New DataGridViewTextBoxColumn()
        col_amount = New DataGridViewTextBoxColumn()
        col_date = New DataGridViewTextBoxColumn()
        col_time = New DataGridViewTextBoxColumn()
        col_status = New DataGridViewTextBoxColumn()
        FlowLayoutPanel1.SuspendLayout()
        Side_panel.SuspendLayout()
        SideInnerPanel1.SuspendLayout()
        FlowLayoutPanel2.SuspendLayout()
        SideInnerPanel2.SuspendLayout()
        Search_panel.SuspendLayout()
        CType(search_pic, ComponentModel.ISupportInitialize).BeginInit()
        Main_panel.SuspendLayout()
        CType(LoanDg, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoSize = True
        FlowLayoutPanel1.BackColor = SystemColors.ActiveBorder
        FlowLayoutPanel1.Controls.Add(refreshBtn)
        FlowLayoutPanel1.Controls.Add(Label2)
        FlowLayoutPanel1.Controls.Add(createBtn)
        FlowLayoutPanel1.Controls.Add(updateBtn)
        FlowLayoutPanel1.Controls.Add(deleteBtn)
        FlowLayoutPanel1.Controls.Add(BulkUpdateBtn)
        FlowLayoutPanel1.Controls.Add(BulkDeleteBtn)
        FlowLayoutPanel1.Dock = DockStyle.Top
        FlowLayoutPanel1.Location = New Point(0, 0)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Padding = New Padding(20, 10, 20, 10)
        FlowLayoutPanel1.Size = New Size(1143, 68)
        FlowLayoutPanel1.TabIndex = 1
        ' 
        ' refreshBtn
        ' 
        refreshBtn.BackColor = SystemColors.ButtonFace
        refreshBtn.FlatStyle = FlatStyle.Flat
        refreshBtn.Image = My.Resources.Resources.fluent__arrow_clockwise_32_filled
        refreshBtn.Location = New Point(20, 10)
        refreshBtn.Margin = New Padding(0)
        refreshBtn.Name = "refreshBtn"
        refreshBtn.Size = New Size(48, 48)
        refreshBtn.TabIndex = 0
        refreshBtn.TextImageRelation = TextImageRelation.TextAboveImage
        refreshBtn.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.Location = New Point(78, 10)
        Label2.Margin = New Padding(10, 0, 20, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(3, 48)
        Label2.TabIndex = 2
        Label2.Text = "Label2"
        ' 
        ' createBtn
        ' 
        createBtn.BackColor = SystemColors.ButtonFace
        createBtn.FlatStyle = FlatStyle.Flat
        createBtn.Image = My.Resources.Resources.fluent__add_32_filled
        createBtn.Location = New Point(111, 10)
        createBtn.Margin = New Padding(10, 0, 0, 0)
        createBtn.Name = "createBtn"
        createBtn.Size = New Size(48, 48)
        createBtn.TabIndex = 1
        createBtn.UseVisualStyleBackColor = False
        ' 
        ' updateBtn
        ' 
        updateBtn.BackColor = SystemColors.ButtonFace
        updateBtn.Enabled = False
        updateBtn.FlatStyle = FlatStyle.Flat
        updateBtn.Image = My.Resources.Resources.fluent__arrow_up_32_filled
        updateBtn.Location = New Point(169, 10)
        updateBtn.Margin = New Padding(10, 0, 0, 0)
        updateBtn.Name = "updateBtn"
        updateBtn.Size = New Size(48, 48)
        updateBtn.TabIndex = 3
        updateBtn.UseVisualStyleBackColor = False
        ' 
        ' deleteBtn
        ' 
        deleteBtn.BackColor = SystemColors.ButtonFace
        deleteBtn.Enabled = False
        deleteBtn.FlatStyle = FlatStyle.Flat
        deleteBtn.Image = My.Resources.Resources.fluent__delete_32_filled
        deleteBtn.Location = New Point(227, 10)
        deleteBtn.Margin = New Padding(10, 0, 0, 0)
        deleteBtn.Name = "deleteBtn"
        deleteBtn.Size = New Size(48, 48)
        deleteBtn.TabIndex = 4
        deleteBtn.UseVisualStyleBackColor = False
        ' 
        ' BulkUpdateBtn
        ' 
        BulkUpdateBtn.BackColor = SystemColors.ButtonFace
        BulkUpdateBtn.Enabled = False
        BulkUpdateBtn.FlatStyle = FlatStyle.Flat
        BulkUpdateBtn.Image = My.Resources.Resources.fluent__table_arrow_up_24_filled
        BulkUpdateBtn.Location = New Point(285, 10)
        BulkUpdateBtn.Margin = New Padding(10, 0, 0, 0)
        BulkUpdateBtn.Name = "BulkUpdateBtn"
        BulkUpdateBtn.Size = New Size(48, 48)
        BulkUpdateBtn.TabIndex = 5
        BulkUpdateBtn.UseVisualStyleBackColor = False
        ' 
        ' BulkDeleteBtn
        ' 
        BulkDeleteBtn.BackColor = SystemColors.ButtonFace
        BulkDeleteBtn.Enabled = False
        BulkDeleteBtn.FlatStyle = FlatStyle.Flat
        BulkDeleteBtn.Image = My.Resources.Resources.fluent__table_delete_row_20_filled
        BulkDeleteBtn.Location = New Point(343, 10)
        BulkDeleteBtn.Margin = New Padding(10, 0, 0, 0)
        BulkDeleteBtn.Name = "BulkDeleteBtn"
        BulkDeleteBtn.Size = New Size(48, 48)
        BulkDeleteBtn.TabIndex = 6
        BulkDeleteBtn.UseVisualStyleBackColor = False
        ' 
        ' Side_panel
        ' 
        Side_panel.AutoScroll = True
        Side_panel.AutoScrollMargin = New Size(20, 0)
        Side_panel.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Side_panel.BackColor = Color.Salmon
        Side_panel.Controls.Add(SideInnerPanel1)
        Side_panel.Controls.Add(SideInnerPanel2)
        Side_panel.Dock = DockStyle.Left
        Side_panel.Location = New Point(0, 68)
        Side_panel.Margin = New Padding(0)
        Side_panel.Name = "Side_panel"
        Side_panel.Size = New Size(294, 519)
        Side_panel.TabIndex = 2
        ' 
        ' SideInnerPanel1
        ' 
        SideInnerPanel1.AutoScroll = True
        SideInnerPanel1.BackColor = SystemColors.ControlDark
        SideInnerPanel1.Controls.Add(FlowLayoutPanel2)
        SideInnerPanel1.Controls.Add(label199)
        SideInnerPanel1.Controls.Add(AmountText)
        SideInnerPanel1.Controls.Add(TransacTypeCbbox)
        SideInnerPanel1.Controls.Add(Label5)
        SideInnerPanel1.Controls.Add(LoadIdBtn)
        SideInnerPanel1.Controls.Add(LoanIdText)
        SideInnerPanel1.Controls.Add(Label4)
        SideInnerPanel1.Controls.Add(SideBackBtn)
        SideInnerPanel1.Controls.Add(Label1)
        SideInnerPanel1.Location = New Point(0, 0)
        SideInnerPanel1.Margin = New Padding(0)
        SideInnerPanel1.Name = "SideInnerPanel1"
        SideInnerPanel1.Size = New Size(294, 434)
        SideInnerPanel1.TabIndex = 0
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        FlowLayoutPanel2.Controls.Add(DBInsertBtn)
        FlowLayoutPanel2.Controls.Add(DBUpdateBtn)
        FlowLayoutPanel2.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel2.Location = New Point(99, 312)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(94, 32)
        FlowLayoutPanel2.TabIndex = 9
        FlowLayoutPanel2.WrapContents = False
        ' 
        ' DBInsertBtn
        ' 
        DBInsertBtn.Anchor = AnchorStyles.Top
        DBInsertBtn.BackColor = SystemColors.ButtonHighlight
        DBInsertBtn.FlatStyle = FlatStyle.Flat
        DBInsertBtn.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DBInsertBtn.Location = New Point(3, 0)
        DBInsertBtn.Margin = New Padding(0, 0, 0, 2)
        DBInsertBtn.Name = "DBInsertBtn"
        DBInsertBtn.Size = New Size(75, 30)
        DBInsertBtn.TabIndex = 0
        DBInsertBtn.Text = "CREATE"
        DBInsertBtn.UseVisualStyleBackColor = False
        ' 
        ' DBUpdateBtn
        ' 
        DBUpdateBtn.Anchor = AnchorStyles.Top
        DBUpdateBtn.BackColor = SystemColors.ButtonHighlight
        DBUpdateBtn.FlatStyle = FlatStyle.Flat
        DBUpdateBtn.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DBUpdateBtn.Location = New Point(0, 32)
        DBUpdateBtn.Margin = New Padding(0, 0, 0, 2)
        DBUpdateBtn.Name = "DBUpdateBtn"
        DBUpdateBtn.Size = New Size(82, 30)
        DBUpdateBtn.TabIndex = 1
        DBUpdateBtn.Text = "UPDATE"
        DBUpdateBtn.UseVisualStyleBackColor = False
        ' 
        ' label199
        ' 
        label199.AutoSize = True
        label199.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        label199.Location = New Point(21, 202)
        label199.Name = "label199"
        label199.Size = New Size(66, 21)
        label199.TabIndex = 8
        label199.Text = "Amount"
        ' 
        ' AmountText
        ' 
        AmountText.Location = New Point(21, 226)
        AmountText.MaxLength = 10
        AmountText.Name = "AmountText"
        AmountText.Size = New Size(138, 23)
        AmountText.TabIndex = 7
        ' 
        ' TransacTypeCbbox
        ' 
        TransacTypeCbbox.DropDownStyle = ComboBoxStyle.DropDownList
        TransacTypeCbbox.Items.AddRange(New Object() {"Payment", "Loan Application", "Early Payment", "Disbursement", "Late Fee", "Ineterest Payment"})
        TransacTypeCbbox.Location = New Point(20, 158)
        TransacTypeCbbox.Name = "TransacTypeCbbox"
        TransacTypeCbbox.Size = New Size(180, 23)
        TransacTypeCbbox.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(20, 134)
        Label5.Name = "Label5"
        Label5.Size = New Size(125, 21)
        Label5.TabIndex = 5
        Label5.Text = "Transaction Type"
        ' 
        ' LoadIdBtn
        ' 
        LoadIdBtn.BackColor = SystemColors.ControlDark
        LoadIdBtn.FlatAppearance.BorderSize = 0
        LoadIdBtn.FlatStyle = FlatStyle.Flat
        LoadIdBtn.Image = My.Resources.Resources.fluent__arrow_clockwise_24_filled
        LoadIdBtn.Location = New Point(131, 87)
        LoadIdBtn.Margin = New Padding(0)
        LoadIdBtn.Name = "LoadIdBtn"
        LoadIdBtn.Size = New Size(24, 24)
        LoadIdBtn.TabIndex = 4
        LoadIdBtn.UseVisualStyleBackColor = False
        ' 
        ' LoanIdText
        ' 
        LoanIdText.Enabled = False
        LoanIdText.Location = New Point(21, 88)
        LoanIdText.Name = "LoanIdText"
        LoanIdText.Size = New Size(105, 23)
        LoanIdText.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(21, 64)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 21)
        Label4.TabIndex = 2
        Label4.Text = "Loan ID"
        ' 
        ' SideBackBtn
        ' 
        SideBackBtn.BackColor = SystemColors.ControlDark
        SideBackBtn.FlatAppearance.BorderSize = 0
        SideBackBtn.FlatStyle = FlatStyle.Flat
        SideBackBtn.Image = My.Resources.Resources.fluent__arrow_left_12_filled
        SideBackBtn.Location = New Point(256, 14)
        SideBackBtn.Margin = New Padding(0)
        SideBackBtn.Name = "SideBackBtn"
        SideBackBtn.Size = New Size(23, 24)
        SideBackBtn.TabIndex = 1
        SideBackBtn.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(20, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(184, 21)
        Label1.TabIndex = 0
        Label1.Text = "Create Loan Transaction"
        ' 
        ' SideInnerPanel2
        ' 
        SideInnerPanel2.BackColor = SystemColors.ControlDark
        SideInnerPanel2.Controls.Add(Button1)
        SideInnerPanel2.Controls.Add(Label3)
        SideInnerPanel2.Location = New Point(0, 434)
        SideInnerPanel2.Margin = New Padding(0)
        SideInnerPanel2.Name = "SideInnerPanel2"
        SideInnerPanel2.Size = New Size(294, 434)
        SideInnerPanel2.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ControlDark
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Image = My.Resources.Resources.fluent__arrow_left_12_filled
        Button1.Location = New Point(256, 14)
        Button1.Margin = New Padding(0)
        Button1.Name = "Button1"
        Button1.Size = New Size(23, 24)
        Button1.TabIndex = 1
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(20, 13)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 21)
        Label3.TabIndex = 0
        Label3.Text = "Bulk Update"
        ' 
        ' Search_panel
        ' 
        Search_panel.Controls.Add(search_pic)
        Search_panel.Controls.Add(amount_txt)
        Search_panel.Controls.Add(amount_lbl)
        Search_panel.Controls.Add(type_lbl)
        Search_panel.Controls.Add(type_cbbox)
        Search_panel.Controls.Add(id_lbl)
        Search_panel.Controls.Add(id_txt)
        Search_panel.Dock = DockStyle.Top
        Search_panel.Location = New Point(294, 68)
        Search_panel.Name = "Search_panel"
        Search_panel.Size = New Size(849, 52)
        Search_panel.TabIndex = 4
        ' 
        ' search_pic
        ' 
        search_pic.Anchor = AnchorStyles.Right
        search_pic.Image = My.Resources.Resources.fluent__search_24_regular
        search_pic.Location = New Point(803, 12)
        search_pic.Name = "search_pic"
        search_pic.Size = New Size(24, 24)
        search_pic.SizeMode = PictureBoxSizeMode.AutoSize
        search_pic.TabIndex = 15
        search_pic.TabStop = False
        ' 
        ' amount_txt
        ' 
        amount_txt.Anchor = AnchorStyles.Left
        amount_txt.Location = New Point(625, 15)
        amount_txt.MaxLength = 10
        amount_txt.Name = "amount_txt"
        amount_txt.Size = New Size(138, 23)
        amount_txt.TabIndex = 14
        ' 
        ' amount_lbl
        ' 
        amount_lbl.Anchor = AnchorStyles.Left
        amount_lbl.AutoSize = True
        amount_lbl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        amount_lbl.Location = New Point(553, 16)
        amount_lbl.Name = "amount_lbl"
        amount_lbl.Size = New Size(66, 21)
        amount_lbl.TabIndex = 13
        amount_lbl.Text = "Amount"
        ' 
        ' type_lbl
        ' 
        type_lbl.Anchor = AnchorStyles.Left
        type_lbl.AutoSize = True
        type_lbl.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        type_lbl.Location = New Point(217, 16)
        type_lbl.Name = "type_lbl"
        type_lbl.Size = New Size(119, 20)
        type_lbl.TabIndex = 12
        type_lbl.Text = "Transaction Type"
        ' 
        ' type_cbbox
        ' 
        type_cbbox.Anchor = AnchorStyles.Left
        type_cbbox.DropDownStyle = ComboBoxStyle.DropDownList
        type_cbbox.Items.AddRange(New Object() {"Payment", "Loan Application", "Early Payment", "Disbursement", "Late Fee", "Ineterest Payment"})
        type_cbbox.Location = New Point(342, 15)
        type_cbbox.Name = "type_cbbox"
        type_cbbox.Size = New Size(180, 23)
        type_cbbox.TabIndex = 11
        ' 
        ' id_lbl
        ' 
        id_lbl.Anchor = AnchorStyles.Left
        id_lbl.AutoSize = True
        id_lbl.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        id_lbl.Location = New Point(24, 16)
        id_lbl.Name = "id_lbl"
        id_lbl.Size = New Size(60, 20)
        id_lbl.TabIndex = 10
        id_lbl.Text = "Loan ID"
        ' 
        ' id_txt
        ' 
        id_txt.Anchor = AnchorStyles.Left
        id_txt.Location = New Point(84, 15)
        id_txt.Name = "id_txt"
        id_txt.Size = New Size(105, 23)
        id_txt.TabIndex = 9
        ' 
        ' Main_panel
        ' 
        Main_panel.Controls.Add(select_lbl)
        Main_panel.Controls.Add(LoanDg)
        Main_panel.Dock = DockStyle.Fill
        Main_panel.Location = New Point(294, 120)
        Main_panel.Name = "Main_panel"
        Main_panel.Size = New Size(849, 467)
        Main_panel.TabIndex = 5
        ' 
        ' select_lbl
        ' 
        select_lbl.AutoSize = True
        select_lbl.Location = New Point(21, 3)
        select_lbl.Name = "select_lbl"
        select_lbl.Size = New Size(89, 15)
        select_lbl.TabIndex = 1
        select_lbl.Text = "Selected Row: 0"
        ' 
        ' LoanDg
        ' 
        LoanDg.AllowUserToAddRows = False
        LoanDg.AllowUserToDeleteRows = False
        LoanDg.AllowUserToOrderColumns = True
        LoanDg.AllowUserToResizeColumns = False
        LoanDg.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = SystemColors.ControlLight
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(11), CByte(231), CByte(251))
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText
        LoanDg.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        LoanDg.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LoanDg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        LoanDg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        LoanDg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        LoanDg.Columns.AddRange(New DataGridViewColumn() {col_loanid, col_transactype, col_amount, col_date, col_time, col_status})
        LoanDg.Location = New Point(21, 27)
        LoanDg.Name = "LoanDg"
        LoanDg.ReadOnly = True
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.ButtonShadow
        DataGridViewCellStyle4.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(11), CByte(231), CByte(251))
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        LoanDg.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        LoanDg.RowHeadersVisible = False
        DataGridViewCellStyle5.BackColor = SystemColors.ControlLightLight
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(11), CByte(231), CByte(251))
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.ControlText
        LoanDg.RowsDefaultCellStyle = DataGridViewCellStyle5
        LoanDg.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        LoanDg.Size = New Size(806, 417)
        LoanDg.TabIndex = 0
        ' 
        ' col_loanid
        ' 
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        col_loanid.DefaultCellStyle = DataGridViewCellStyle3
        col_loanid.HeaderText = "Loan ID"
        col_loanid.Name = "col_loanid"
        col_loanid.ReadOnly = True
        ' 
        ' col_transactype
        ' 
        col_transactype.HeaderText = "Transaction Type"
        col_transactype.Name = "col_transactype"
        col_transactype.ReadOnly = True
        ' 
        ' col_amount
        ' 
        col_amount.HeaderText = "Amount"
        col_amount.Name = "col_amount"
        col_amount.ReadOnly = True
        ' 
        ' col_date
        ' 
        col_date.HeaderText = "Date"
        col_date.Name = "col_date"
        col_date.ReadOnly = True
        ' 
        ' col_time
        ' 
        col_time.HeaderText = "Time"
        col_time.Name = "col_time"
        col_time.ReadOnly = True
        ' 
        ' col_status
        ' 
        col_status.HeaderText = "Status"
        col_status.Name = "col_status"
        col_status.ReadOnly = True
        ' 
        ' Loans_form
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1143, 587)
        Controls.Add(Main_panel)
        Controls.Add(Search_panel)
        Controls.Add(Side_panel)
        Controls.Add(FlowLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Loans_form"
        Text = "Loans_form"
        FlowLayoutPanel1.ResumeLayout(False)
        Side_panel.ResumeLayout(False)
        SideInnerPanel1.ResumeLayout(False)
        SideInnerPanel1.PerformLayout()
        FlowLayoutPanel2.ResumeLayout(False)
        SideInnerPanel2.ResumeLayout(False)
        SideInnerPanel2.PerformLayout()
        Search_panel.ResumeLayout(False)
        Search_panel.PerformLayout()
        CType(search_pic, ComponentModel.ISupportInitialize).EndInit()
        Main_panel.ResumeLayout(False)
        Main_panel.PerformLayout()
        CType(LoanDg, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents refreshBtn As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents createBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents updateBtn As Button
    Friend WithEvents deleteBtn As Button
    Friend WithEvents Side_panel As FlowLayoutPanel
    Friend WithEvents SideInnerPanel1 As Panel
    Friend WithEvents BulkUpdateBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents SideBackBtn As Button
    Friend WithEvents SideInnerPanel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Search_panel As Panel
    Friend WithEvents Main_panel As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents LoadIdBtn As Button
    Friend WithEvents LoanIdText As TextBox
    Friend WithEvents BulkDeleteBtn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TransacTypeCbbox As ComboBox
    Friend WithEvents label199 As Label
    Friend WithEvents AmountText As TextBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents DBInsertBtn As Button
    Friend WithEvents DBUpdateBtn As Button
    Friend WithEvents LoanDg As DataGridView
    Friend WithEvents col_loanid As DataGridViewTextBoxColumn
    Friend WithEvents col_transactype As DataGridViewTextBoxColumn
    Friend WithEvents col_amount As DataGridViewTextBoxColumn
    Friend WithEvents col_date As DataGridViewTextBoxColumn
    Friend WithEvents col_time As DataGridViewTextBoxColumn
    Friend WithEvents col_status As DataGridViewTextBoxColumn
    Friend WithEvents type_lbl As Label
    Friend WithEvents type_cbbox As ComboBox
    Friend WithEvents id_lbl As Label
    Friend WithEvents id_txt As TextBox
    Friend WithEvents amount_txt As TextBox
    Friend WithEvents amount_lbl As Label
    Friend WithEvents search_pic As PictureBox
    Friend WithEvents select_lbl As Label
End Class
