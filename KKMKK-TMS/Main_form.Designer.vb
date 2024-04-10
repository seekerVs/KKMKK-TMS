<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_form))
        ToolStrip1 = New ToolStrip()
        ToolStripButton1 = New ToolStripButton()
        ToolStripSeparator1 = New ToolStripSeparator()
        ToolStripLabel4 = New ToolStripDropDownButton()
        PendingToolStripMenuItem = New ToolStripMenuItem()
        ProcessingToolStripMenuItem = New ToolStripMenuItem()
        CompletedToolStripMenuItem = New ToolStripMenuItem()
        DeniedToolStripMenuItem = New ToolStripMenuItem()
        ToolStripLabel1 = New ToolStripDropDownButton()
        CreateLoanApplicationToolStripMenuItem = New ToolStripMenuItem()
        ViewLoansToolStripMenuItem = New ToolStripMenuItem()
        ToolStripLabel2 = New ToolStripDropDownButton()
        CreateShareCapitalTransacToolStripMenuItem = New ToolStripMenuItem()
        ViewShareCapitalToolStripMenuItem = New ToolStripMenuItem()
        ToolStripLabel3 = New ToolStripDropDownButton()
        ViewMemberApplicantionToolStripMenuItem = New ToolStripMenuItem()
        ViewMembersToolStripMenuItem = New ToolStripMenuItem()
        ToolStripLabel5 = New ToolStripDropDownButton()
        AllToolStripMenuItem = New ToolStripMenuItem()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripButton1, ToolStripSeparator1, ToolStripLabel4, ToolStripLabel1, ToolStripLabel2, ToolStripLabel3, ToolStripLabel5})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(868, 25)
        ToolStrip1.TabIndex = 0
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' ToolStripButton1
        ' 
        ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton1.Image = My.Resources.Resources.fluent__home_12_filled
        ToolStripButton1.ImageTransparentColor = Color.Magenta
        ToolStripButton1.Name = "ToolStripButton1"
        ToolStripButton1.Size = New Size(23, 22)
        ToolStripButton1.Text = "ToolStripButton1"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(6, 25)
        ' 
        ' ToolStripLabel4
        ' 
        ToolStripLabel4.DropDownItems.AddRange(New ToolStripItem() {AllToolStripMenuItem, PendingToolStripMenuItem, ProcessingToolStripMenuItem, CompletedToolStripMenuItem, DeniedToolStripMenuItem})
        ToolStripLabel4.Name = "ToolStripLabel4"
        ToolStripLabel4.ShowDropDownArrow = False
        ToolStripLabel4.Size = New Size(76, 22)
        ToolStripLabel4.Text = "Transactions"
        ' 
        ' PendingToolStripMenuItem
        ' 
        PendingToolStripMenuItem.Name = "PendingToolStripMenuItem"
        PendingToolStripMenuItem.Size = New Size(180, 22)
        PendingToolStripMenuItem.Text = "Pending"
        ' 
        ' ProcessingToolStripMenuItem
        ' 
        ProcessingToolStripMenuItem.Name = "ProcessingToolStripMenuItem"
        ProcessingToolStripMenuItem.Size = New Size(180, 22)
        ProcessingToolStripMenuItem.Text = "Processing"
        ' 
        ' CompletedToolStripMenuItem
        ' 
        CompletedToolStripMenuItem.Name = "CompletedToolStripMenuItem"
        CompletedToolStripMenuItem.Size = New Size(180, 22)
        CompletedToolStripMenuItem.Text = "Completed"
        ' 
        ' DeniedToolStripMenuItem
        ' 
        DeniedToolStripMenuItem.Name = "DeniedToolStripMenuItem"
        DeniedToolStripMenuItem.Size = New Size(180, 22)
        DeniedToolStripMenuItem.Text = "Denied"
        ' 
        ' ToolStripLabel1
        ' 
        ToolStripLabel1.DropDownItems.AddRange(New ToolStripItem() {CreateLoanApplicationToolStripMenuItem, ViewLoansToolStripMenuItem})
        ToolStripLabel1.Name = "ToolStripLabel1"
        ToolStripLabel1.ShowDropDownArrow = False
        ToolStripLabel1.Size = New Size(42, 22)
        ToolStripLabel1.Text = "Loans"
        ' 
        ' CreateLoanApplicationToolStripMenuItem
        ' 
        CreateLoanApplicationToolStripMenuItem.Name = "CreateLoanApplicationToolStripMenuItem"
        CreateLoanApplicationToolStripMenuItem.Size = New Size(200, 22)
        CreateLoanApplicationToolStripMenuItem.Text = "Create Loan Transaction"
        ' 
        ' ViewLoansToolStripMenuItem
        ' 
        ViewLoansToolStripMenuItem.Name = "ViewLoansToolStripMenuItem"
        ViewLoansToolStripMenuItem.Size = New Size(200, 22)
        ViewLoansToolStripMenuItem.Text = "View Loans"
        ' 
        ' ToolStripLabel2
        ' 
        ToolStripLabel2.DropDownItems.AddRange(New ToolStripItem() {CreateShareCapitalTransacToolStripMenuItem, ViewShareCapitalToolStripMenuItem})
        ToolStripLabel2.Name = "ToolStripLabel2"
        ToolStripLabel2.ShowDropDownArrow = False
        ToolStripLabel2.Size = New Size(80, 22)
        ToolStripLabel2.Text = "Share Capital"
        ' 
        ' CreateShareCapitalTransacToolStripMenuItem
        ' 
        CreateShareCapitalTransacToolStripMenuItem.Name = "CreateShareCapitalTransacToolStripMenuItem"
        CreateShareCapitalTransacToolStripMenuItem.Size = New Size(243, 22)
        CreateShareCapitalTransacToolStripMenuItem.Text = "Create Share Capital Transaction"
        ' 
        ' ViewShareCapitalToolStripMenuItem
        ' 
        ViewShareCapitalToolStripMenuItem.Name = "ViewShareCapitalToolStripMenuItem"
        ViewShareCapitalToolStripMenuItem.Size = New Size(243, 22)
        ViewShareCapitalToolStripMenuItem.Text = "View Share Capital"
        ' 
        ' ToolStripLabel3
        ' 
        ToolStripLabel3.DropDownItems.AddRange(New ToolStripItem() {ViewMemberApplicantionToolStripMenuItem, ViewMembersToolStripMenuItem})
        ToolStripLabel3.Name = "ToolStripLabel3"
        ToolStripLabel3.ShowDropDownArrow = False
        ToolStripLabel3.Size = New Size(61, 22)
        ToolStripLabel3.Text = "Members"
        ' 
        ' ViewMemberApplicantionToolStripMenuItem
        ' 
        ViewMemberApplicantionToolStripMenuItem.Name = "ViewMemberApplicantionToolStripMenuItem"
        ViewMemberApplicantionToolStripMenuItem.Size = New Size(227, 22)
        ViewMemberApplicantionToolStripMenuItem.Text = "Create Member Applicantion"
        ' 
        ' ViewMembersToolStripMenuItem
        ' 
        ViewMembersToolStripMenuItem.Name = "ViewMembersToolStripMenuItem"
        ViewMembersToolStripMenuItem.Size = New Size(227, 22)
        ViewMembersToolStripMenuItem.Text = "View Members"
        ' 
        ' ToolStripLabel5
        ' 
        ToolStripLabel5.Name = "ToolStripLabel5"
        ToolStripLabel5.ShowDropDownArrow = False
        ToolStripLabel5.Size = New Size(40, 22)
        ToolStripLabel5.Text = "Staffs"
        ' 
        ' AllToolStripMenuItem
        ' 
        AllToolStripMenuItem.Name = "AllToolStripMenuItem"
        AllToolStripMenuItem.Size = New Size(180, 22)
        AllToolStripMenuItem.Text = "All"
        ' 
        ' Main_form
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(868, 457)
        Controls.Add(ToolStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Main_form"
        Text = "KKMKK-TMS"
        WindowState = FormWindowState.Maximized
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripDropDownButton
    Friend WithEvents CreateLoanApplicationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewLoansToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripDropDownButton
    Friend WithEvents CreateShareCapitalTransacToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewShareCapitalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripLabel3 As ToolStripDropDownButton
    Friend WithEvents ViewMemberApplicantionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewMembersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripLabel4 As ToolStripDropDownButton
    Friend WithEvents PendingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProcessingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompletedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeniedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripLabel5 As ToolStripDropDownButton
    Friend WithEvents AllToolStripMenuItem As ToolStripMenuItem

End Class
