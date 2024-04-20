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
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Menu_fpanel = New FlowLayoutPanel()
        refreshBtn = New Button()
        Label2 = New Label()
        createBtn = New Button()
        updateBtn = New Button()
        deleteBtn = New Button()
        BulkUpdateBtn = New Button()
        BulkDeleteBtn = New Button()
        ExportBtn = New Button()
        ToolTip1 = New ToolTip(components)
        Side_panel = New FlowLayoutPanel()
        SideInnerPanel1 = New Panel()
        StatusCbbox = New ComboBox()
        status_lbl = New Label()
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
        sideheader_lbl = New Label()
        SideInnerPanel2 = New Panel()
        SideBackBtn2 = New Button()
        Label3 = New Label()
        Search_mainpanel = New Panel()
        search_pic = New PictureBox()
        Search_panel = New FlowLayoutPanel()
        Label1 = New Label()
        id_txt = New TextBox()
        Label6 = New Label()
        type_cbbox = New ComboBox()
        Label7 = New Label()
        amount_txt = New TextBox()
        Label8 = New Label()
        Panel1 = New Panel()
        dateto_dtp = New DateTimePicker()
        Label10 = New Label()
        datefrom_dtp = New DateTimePicker()
        Label9 = New Label()
        Label11 = New Label()
        Panel2 = New Panel()
        timeto_dtp = New DateTimePicker()
        Label12 = New Label()
        timefrom_dtp = New DateTimePicker()
        Label13 = New Label()
        Label14 = New Label()
        status_cbbox = New ComboBox()
        Main_panel = New Panel()
        SelectAllBtn = New Button()
        select_lbl = New Label()
        LoanDg = New DataGridView()
        col_loanid = New DataGridViewTextBoxColumn()
        col_transactype = New DataGridViewTextBoxColumn()
        col_amount = New DataGridViewTextBoxColumn()
        col_date = New DataGridViewTextBoxColumn()
        col_time = New DataGridViewTextBoxColumn()
        col_status = New DataGridViewTextBoxColumn()
        col_loanids = New DataGridViewTextBoxColumn()
        col_types = New DataGridViewTextBoxColumn()
        Menu_fpanel.SuspendLayout()
        Side_panel.SuspendLayout()
        SideInnerPanel1.SuspendLayout()
        FlowLayoutPanel2.SuspendLayout()
        SideInnerPanel2.SuspendLayout()
        Search_mainpanel.SuspendLayout()
        CType(search_pic, ComponentModel.ISupportInitialize).BeginInit()
        Search_panel.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Main_panel.SuspendLayout()
        CType(LoanDg, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Menu_fpanel
        ' 
        Menu_fpanel.BackColor = SystemColors.ActiveBorder
        Menu_fpanel.Controls.Add(refreshBtn)
        Menu_fpanel.Controls.Add(Label2)
        Menu_fpanel.Controls.Add(createBtn)
        Menu_fpanel.Controls.Add(updateBtn)
        Menu_fpanel.Controls.Add(deleteBtn)
        Menu_fpanel.Controls.Add(BulkUpdateBtn)
        Menu_fpanel.Controls.Add(BulkDeleteBtn)
        Menu_fpanel.Controls.Add(ExportBtn)
        Menu_fpanel.Dock = DockStyle.Top
        Menu_fpanel.Location = New Point(0, 0)
        Menu_fpanel.Name = "Menu_fpanel"
        Menu_fpanel.Padding = New Padding(20, 10, 20, 10)
        Menu_fpanel.Size = New Size(1465, 68)
        Menu_fpanel.TabIndex = 1
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
        ' ExportBtn
        ' 
        ExportBtn.BackColor = SystemColors.ButtonFace
        ExportBtn.Enabled = False
        ExportBtn.Image = My.Resources.Resources.fluent__arrow_export_ltr_32_filled
        ExportBtn.Location = New Point(401, 10)
        ExportBtn.Margin = New Padding(10, 0, 0, 0)
        ExportBtn.Name = "ExportBtn"
        ExportBtn.Size = New Size(48, 48)
        ExportBtn.TabIndex = 7
        ExportBtn.UseVisualStyleBackColor = False
        ' 
        ' Side_panel
        ' 
        Side_panel.AutoScroll = True
        Side_panel.AutoScrollMargin = New Size(20, 0)
        Side_panel.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Side_panel.BackColor = SystemColors.ControlDark
        Side_panel.Controls.Add(SideInnerPanel1)
        Side_panel.Controls.Add(SideInnerPanel2)
        Side_panel.Dock = DockStyle.Left
        Side_panel.Location = New Point(0, 68)
        Side_panel.Margin = New Padding(0)
        Side_panel.Name = "Side_panel"
        Side_panel.Size = New Size(294, 634)
        Side_panel.TabIndex = 2
        ' 
        ' SideInnerPanel1
        ' 
        SideInnerPanel1.AutoScroll = True
        SideInnerPanel1.BackColor = SystemColors.ControlDark
        SideInnerPanel1.Controls.Add(StatusCbbox)
        SideInnerPanel1.Controls.Add(status_lbl)
        SideInnerPanel1.Controls.Add(FlowLayoutPanel2)
        SideInnerPanel1.Controls.Add(label199)
        SideInnerPanel1.Controls.Add(AmountText)
        SideInnerPanel1.Controls.Add(TransacTypeCbbox)
        SideInnerPanel1.Controls.Add(Label5)
        SideInnerPanel1.Controls.Add(LoadIdBtn)
        SideInnerPanel1.Controls.Add(LoanIdText)
        SideInnerPanel1.Controls.Add(Label4)
        SideInnerPanel1.Controls.Add(SideBackBtn)
        SideInnerPanel1.Controls.Add(sideheader_lbl)
        SideInnerPanel1.Location = New Point(0, 0)
        SideInnerPanel1.Margin = New Padding(0)
        SideInnerPanel1.Name = "SideInnerPanel1"
        SideInnerPanel1.Size = New Size(294, 370)
        SideInnerPanel1.TabIndex = 0
        ' 
        ' StatusCbbox
        ' 
        StatusCbbox.DropDownStyle = ComboBoxStyle.DropDownList
        StatusCbbox.Items.AddRange(New Object() {"", "Pending", "Processing", "Approved", "Denied"})
        StatusCbbox.Location = New Point(20, 283)
        StatusCbbox.Name = "StatusCbbox"
        StatusCbbox.Size = New Size(155, 23)
        StatusCbbox.TabIndex = 6
        StatusCbbox.Visible = False
        ' 
        ' status_lbl
        ' 
        status_lbl.AutoSize = True
        status_lbl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        status_lbl.Location = New Point(20, 259)
        status_lbl.Name = "status_lbl"
        status_lbl.Size = New Size(52, 21)
        status_lbl.TabIndex = 11
        status_lbl.Text = "Status"
        status_lbl.Visible = False
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        FlowLayoutPanel2.Controls.Add(DBInsertBtn)
        FlowLayoutPanel2.Controls.Add(DBUpdateBtn)
        FlowLayoutPanel2.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel2.Location = New Point(158, 328)
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
        label199.Location = New Point(21, 197)
        label199.Name = "label199"
        label199.Size = New Size(66, 21)
        label199.TabIndex = 8
        label199.Text = "Amount"
        ' 
        ' AmountText
        ' 
        AmountText.Location = New Point(21, 221)
        AmountText.MaxLength = 10
        AmountText.Name = "AmountText"
        AmountText.Size = New Size(138, 23)
        AmountText.TabIndex = 7
        ' 
        ' TransacTypeCbbox
        ' 
        TransacTypeCbbox.DropDownStyle = ComboBoxStyle.DropDownList
        TransacTypeCbbox.Items.AddRange(New Object() {"", "Payment", "Loan Application", "Early Payment", "Disbursement", "Late Fee", "Ineterest Payment"})
        TransacTypeCbbox.Location = New Point(20, 155)
        TransacTypeCbbox.Name = "TransacTypeCbbox"
        TransacTypeCbbox.Size = New Size(155, 23)
        TransacTypeCbbox.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(20, 131)
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
        ' sideheader_lbl
        ' 
        sideheader_lbl.AutoSize = True
        sideheader_lbl.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        sideheader_lbl.Location = New Point(20, 13)
        sideheader_lbl.Name = "sideheader_lbl"
        sideheader_lbl.Size = New Size(184, 21)
        sideheader_lbl.TabIndex = 0
        sideheader_lbl.Text = "Create Loan Transaction"
        ' 
        ' SideInnerPanel2
        ' 
        SideInnerPanel2.BackColor = SystemColors.ControlDark
        SideInnerPanel2.Controls.Add(SideBackBtn2)
        SideInnerPanel2.Controls.Add(Label3)
        SideInnerPanel2.Location = New Point(0, 370)
        SideInnerPanel2.Margin = New Padding(0)
        SideInnerPanel2.Name = "SideInnerPanel2"
        SideInnerPanel2.Size = New Size(294, 370)
        SideInnerPanel2.TabIndex = 1
        ' 
        ' SideBackBtn2
        ' 
        SideBackBtn2.BackColor = SystemColors.ControlDark
        SideBackBtn2.FlatAppearance.BorderSize = 0
        SideBackBtn2.FlatStyle = FlatStyle.Flat
        SideBackBtn2.Image = My.Resources.Resources.fluent__arrow_left_12_filled
        SideBackBtn2.Location = New Point(256, 14)
        SideBackBtn2.Margin = New Padding(0)
        SideBackBtn2.Name = "SideBackBtn2"
        SideBackBtn2.Size = New Size(23, 24)
        SideBackBtn2.TabIndex = 1
        SideBackBtn2.UseVisualStyleBackColor = False
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
        ' Search_mainpanel
        ' 
        Search_mainpanel.AutoScroll = True
        Search_mainpanel.Controls.Add(search_pic)
        Search_mainpanel.Controls.Add(Search_panel)
        Search_mainpanel.Dock = DockStyle.Top
        Search_mainpanel.Location = New Point(294, 68)
        Search_mainpanel.Margin = New Padding(0)
        Search_mainpanel.Name = "Search_mainpanel"
        Search_mainpanel.Padding = New Padding(0, 20, 0, 0)
        Search_mainpanel.Size = New Size(1171, 71)
        Search_mainpanel.TabIndex = 8
        ' 
        ' search_pic
        ' 
        search_pic.Anchor = AnchorStyles.Right
        search_pic.Image = My.Resources.Resources.fluent__search_24_regular
        search_pic.Location = New Point(1121, 23)
        search_pic.Name = "search_pic"
        search_pic.Size = New Size(24, 24)
        search_pic.SizeMode = PictureBoxSizeMode.AutoSize
        search_pic.TabIndex = 25
        search_pic.TabStop = False
        ' 
        ' Search_panel
        ' 
        Search_panel.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Search_panel.AutoScroll = True
        Search_panel.Controls.Add(Label1)
        Search_panel.Controls.Add(id_txt)
        Search_panel.Controls.Add(Label6)
        Search_panel.Controls.Add(type_cbbox)
        Search_panel.Controls.Add(Label7)
        Search_panel.Controls.Add(amount_txt)
        Search_panel.Controls.Add(Label8)
        Search_panel.Controls.Add(Panel1)
        Search_panel.Controls.Add(Label11)
        Search_panel.Controls.Add(Panel2)
        Search_panel.Controls.Add(Label14)
        Search_panel.Controls.Add(status_cbbox)
        Search_panel.Location = New Point(0, 3)
        Search_panel.Margin = New Padding(0)
        Search_panel.Name = "Search_panel"
        Search_panel.Padding = New Padding(20, 0, 20, 0)
        Search_panel.Size = New Size(1118, 71)
        Search_panel.TabIndex = 24
        Search_panel.WrapContents = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label1.Location = New Point(20, 25)
        Label1.Margin = New Padding(0, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 17)
        Label1.TabIndex = 0
        Label1.Text = "Loan Id"
        ' 
        ' id_txt
        ' 
        id_txt.Anchor = AnchorStyles.Left
        id_txt.Location = New Point(78, 22)
        id_txt.Margin = New Padding(0, 0, 20, 0)
        id_txt.Name = "id_txt"
        id_txt.Size = New Size(100, 23)
        id_txt.TabIndex = 1
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Left
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label6.Location = New Point(198, 25)
        Label6.Margin = New Padding(0, 0, 5, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(109, 17)
        Label6.TabIndex = 2
        Label6.Text = "Transaction Type"
        ' 
        ' type_cbbox
        ' 
        type_cbbox.Anchor = AnchorStyles.Left
        type_cbbox.DropDownStyle = ComboBoxStyle.DropDownList
        type_cbbox.FormattingEnabled = True
        type_cbbox.Items.AddRange(New Object() {"", "Payment", "Loan Application", "Late Fee", "Ineterest Payment", "Early Payment", "Disbursement"})
        type_cbbox.Location = New Point(312, 22)
        type_cbbox.Margin = New Padding(0, 0, 20, 0)
        type_cbbox.Name = "type_cbbox"
        type_cbbox.Size = New Size(107, 23)
        type_cbbox.TabIndex = 3
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Left
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(439, 25)
        Label7.Margin = New Padding(0, 0, 5, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(58, 17)
        Label7.TabIndex = 4
        Label7.Text = "Amount"
        ' 
        ' amount_txt
        ' 
        amount_txt.Anchor = AnchorStyles.Left
        amount_txt.Location = New Point(502, 22)
        amount_txt.Margin = New Padding(0, 0, 20, 0)
        amount_txt.Name = "amount_txt"
        amount_txt.Size = New Size(100, 23)
        amount_txt.TabIndex = 5
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Left
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label8.Location = New Point(622, 25)
        Label8.Margin = New Padding(0, 0, 5, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(36, 17)
        Label8.TabIndex = 8
        Label8.Text = "Date"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(dateto_dtp)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(datefrom_dtp)
        Panel1.Controls.Add(Label9)
        Panel1.Location = New Point(663, 0)
        Panel1.Margin = New Padding(0, 0, 20, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(138, 68)
        Panel1.TabIndex = 7
        ' 
        ' dateto_dtp
        ' 
        dateto_dtp.CustomFormat = "yyyy/MM/dd"
        dateto_dtp.Format = DateTimePickerFormat.Custom
        dateto_dtp.Location = New Point(45, 38)
        dateto_dtp.MaxDate = New Date(2024, 4, 20, 0, 0, 0, 0)
        dateto_dtp.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        dateto_dtp.Name = "dateto_dtp"
        dateto_dtp.Size = New Size(89, 23)
        dateto_dtp.TabIndex = 3
        dateto_dtp.Value = New Date(2024, 4, 20, 0, 0, 0, 0)
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(4, 41)
        Label10.Name = "Label10"
        Label10.Size = New Size(22, 15)
        Label10.TabIndex = 2
        Label10.Text = "To:"
        ' 
        ' datefrom_dtp
        ' 
        datefrom_dtp.CustomFormat = "yyyy/MM/dd"
        datefrom_dtp.Format = DateTimePickerFormat.Custom
        datefrom_dtp.Location = New Point(45, 9)
        datefrom_dtp.MaxDate = New Date(2024, 4, 20, 0, 0, 0, 0)
        datefrom_dtp.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        datefrom_dtp.Name = "datefrom_dtp"
        datefrom_dtp.Size = New Size(89, 23)
        datefrom_dtp.TabIndex = 1
        datefrom_dtp.Value = New Date(2000, 12, 31, 0, 0, 0, 0)
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(4, 12)
        Label9.Name = "Label9"
        Label9.Size = New Size(38, 15)
        Label9.TabIndex = 0
        Label9.Text = "From:"
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Left
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label11.Location = New Point(821, 25)
        Label11.Margin = New Padding(0, 0, 5, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(37, 17)
        Label11.TabIndex = 9
        Label11.Text = "Time"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(timeto_dtp)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(timefrom_dtp)
        Panel2.Controls.Add(Label13)
        Panel2.Location = New Point(863, 0)
        Panel2.Margin = New Padding(0, 0, 20, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(138, 68)
        Panel2.TabIndex = 10
        ' 
        ' timeto_dtp
        ' 
        timeto_dtp.CustomFormat = "hh:mm:ss"
        timeto_dtp.Format = DateTimePickerFormat.Time
        timeto_dtp.Location = New Point(45, 38)
        timeto_dtp.Name = "timeto_dtp"
        timeto_dtp.ShowUpDown = True
        timeto_dtp.Size = New Size(89, 23)
        timeto_dtp.TabIndex = 3
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Left
        Label12.AutoSize = True
        Label12.Location = New Point(4, 41)
        Label12.Name = "Label12"
        Label12.Size = New Size(22, 15)
        Label12.TabIndex = 2
        Label12.Text = "To:"
        ' 
        ' timefrom_dtp
        ' 
        timefrom_dtp.CustomFormat = "hh:mm:ss"
        timefrom_dtp.Format = DateTimePickerFormat.Time
        timefrom_dtp.Location = New Point(45, 9)
        timefrom_dtp.MaxDate = New Date(2024, 4, 20, 15, 22, 37, 0)
        timefrom_dtp.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        timefrom_dtp.Name = "timefrom_dtp"
        timefrom_dtp.ShowUpDown = True
        timefrom_dtp.Size = New Size(89, 23)
        timefrom_dtp.TabIndex = 1
        timefrom_dtp.Value = New Date(2024, 4, 20, 0, 0, 0, 0)
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(4, 12)
        Label13.Name = "Label13"
        Label13.Size = New Size(38, 15)
        Label13.TabIndex = 0
        Label13.Text = "From:"
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.Left
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(1021, 25)
        Label14.Margin = New Padding(0, 0, 5, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(46, 17)
        Label14.TabIndex = 11
        Label14.Text = "Status"
        ' 
        ' status_cbbox
        ' 
        status_cbbox.Anchor = AnchorStyles.Left
        status_cbbox.DropDownStyle = ComboBoxStyle.DropDownList
        status_cbbox.FormattingEnabled = True
        status_cbbox.Items.AddRange(New Object() {"", "Processing", "Pending", "Denied", "Approved"})
        status_cbbox.Location = New Point(1072, 22)
        status_cbbox.Margin = New Padding(0, 0, 20, 0)
        status_cbbox.Name = "status_cbbox"
        status_cbbox.Size = New Size(107, 23)
        status_cbbox.TabIndex = 12
        ' 
        ' Main_panel
        ' 
        Main_panel.Controls.Add(SelectAllBtn)
        Main_panel.Controls.Add(select_lbl)
        Main_panel.Controls.Add(LoanDg)
        Main_panel.Dock = DockStyle.Fill
        Main_panel.Location = New Point(294, 139)
        Main_panel.Name = "Main_panel"
        Main_panel.Size = New Size(1171, 563)
        Main_panel.TabIndex = 9
        ' 
        ' SelectAllBtn
        ' 
        SelectAllBtn.FlatAppearance.BorderSize = 0
        SelectAllBtn.FlatStyle = FlatStyle.Flat
        SelectAllBtn.Image = My.Resources.Resources.fluent__select_all_off_20_filled
        SelectAllBtn.Location = New Point(22, 0)
        SelectAllBtn.Name = "SelectAllBtn"
        SelectAllBtn.Size = New Size(24, 24)
        SelectAllBtn.TabIndex = 2
        SelectAllBtn.UseVisualStyleBackColor = True
        ' 
        ' select_lbl
        ' 
        select_lbl.AutoSize = True
        select_lbl.Location = New Point(49, 5)
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
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        LoanDg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        LoanDg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        LoanDg.Columns.AddRange(New DataGridViewColumn() {col_loanid, col_transactype, col_amount, col_date, col_time, col_status, col_loanids, col_types})
        LoanDg.Location = New Point(22, 30)
        LoanDg.Name = "LoanDg"
        LoanDg.ReadOnly = True
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.ButtonShadow
        DataGridViewCellStyle6.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(11), CByte(231), CByte(251))
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        LoanDg.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        LoanDg.RowHeadersVisible = False
        DataGridViewCellStyle7.BackColor = SystemColors.ControlLightLight
        DataGridViewCellStyle7.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle7.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(CByte(11), CByte(231), CByte(251))
        DataGridViewCellStyle7.SelectionForeColor = SystemColors.ControlText
        LoanDg.RowsDefaultCellStyle = DataGridViewCellStyle7
        LoanDg.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        LoanDg.Size = New Size(1124, 509)
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
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        col_amount.DefaultCellStyle = DataGridViewCellStyle4
        col_amount.HeaderText = "Amount"
        col_amount.MaxInputLength = 20
        col_amount.Name = "col_amount"
        col_amount.ReadOnly = True
        ' 
        ' col_date
        ' 
        DataGridViewCellStyle5.Format = "yyyy-MM-dd"
        DataGridViewCellStyle5.NullValue = Nothing
        col_date.DefaultCellStyle = DataGridViewCellStyle5
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
        ' col_loanids
        ' 
        col_loanids.HeaderText = "Loan ID"
        col_loanids.Name = "col_loanids"
        col_loanids.ReadOnly = True
        ' 
        ' col_types
        ' 
        col_types.HeaderText = "Transaction Type"
        col_types.Name = "col_types"
        col_types.ReadOnly = True
        ' 
        ' Loans_form
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1465, 702)
        Controls.Add(Main_panel)
        Controls.Add(Search_mainpanel)
        Controls.Add(Side_panel)
        Controls.Add(Menu_fpanel)
        FormBorderStyle = FormBorderStyle.None
        Name = "Loans_form"
        Text = "Loans_form"
        Menu_fpanel.ResumeLayout(False)
        Side_panel.ResumeLayout(False)
        SideInnerPanel1.ResumeLayout(False)
        SideInnerPanel1.PerformLayout()
        FlowLayoutPanel2.ResumeLayout(False)
        SideInnerPanel2.ResumeLayout(False)
        SideInnerPanel2.PerformLayout()
        Search_mainpanel.ResumeLayout(False)
        Search_mainpanel.PerformLayout()
        CType(search_pic, ComponentModel.ISupportInitialize).EndInit()
        Search_panel.ResumeLayout(False)
        Search_panel.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Main_panel.ResumeLayout(False)
        Main_panel.PerformLayout()
        CType(LoanDg, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Menu_fpanel As FlowLayoutPanel
    Friend WithEvents refreshBtn As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents createBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents updateBtn As Button
    Friend WithEvents deleteBtn As Button
    Friend WithEvents Side_panel As FlowLayoutPanel
    Friend WithEvents SideInnerPanel1 As Panel
    Friend WithEvents BulkUpdateBtn As Button
    Friend WithEvents sideheader_lbl As Label
    Friend WithEvents SideBackBtn As Button
    Friend WithEvents SideInnerPanel2 As Panel
    Friend WithEvents SideBackBtn2 As Button
    Friend WithEvents Label3 As Label
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
    Friend WithEvents status_lbl As Label
    Friend WithEvents Search_mainpanel As Panel
    Friend WithEvents Main_panel As Panel
    Friend WithEvents SelectAllBtn As Button
    Friend WithEvents select_lbl As Label
    Friend WithEvents LoanDg As DataGridView
    Friend WithEvents status_txt As TextBox
    Friend WithEvents StatusCbbox As ComboBox
    Friend WithEvents ExportBtn As Button
    Friend WithEvents col_loanid As DataGridViewTextBoxColumn
    Friend WithEvents col_transactype As DataGridViewTextBoxColumn
    Friend WithEvents col_amount As DataGridViewTextBoxColumn
    Friend WithEvents col_date As DataGridViewTextBoxColumn
    Friend WithEvents col_time As DataGridViewTextBoxColumn
    Friend WithEvents col_status As DataGridViewTextBoxColumn
    Friend WithEvents Search_panel As FlowLayoutPanel
    Friend WithEvents search_pic As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents id_txt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents type_cbbox As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents amount_txt As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents datefrom_dtp As DateTimePicker
    Friend WithEvents dateto_dtp As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents timeto_dtp As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents timefrom_dtp As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents status_cbbox As ComboBox
    Friend WithEvents col_loanids As DataGridViewTextBoxColumn
    Friend WithEvents col_types As DataGridViewTextBoxColumn
End Class
