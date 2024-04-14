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
        HomeBtn = New ToolStripButton()
        ToolStripSeparator1 = New ToolStripSeparator()
        TransactionBtn = New ToolStripDropDownButton()
        LoansBtn = New ToolStripDropDownButton()
        ShareBtn = New ToolStripDropDownButton()
        MembersBtn = New ToolStripDropDownButton()
        StaffsBtn = New ToolStripDropDownButton()
        Main_panel = New Panel()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.BackColor = SystemColors.ControlLight
        ToolStrip1.Items.AddRange(New ToolStripItem() {HomeBtn, ToolStripSeparator1, TransactionBtn, LoansBtn, ShareBtn, MembersBtn, StaffsBtn})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(868, 25)
        ToolStrip1.TabIndex = 0
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' HomeBtn
        ' 
        HomeBtn.DisplayStyle = ToolStripItemDisplayStyle.Image
        HomeBtn.Image = My.Resources.Resources.fluent__home_24_filled
        HomeBtn.ImageTransparentColor = Color.Magenta
        HomeBtn.Name = "HomeBtn"
        HomeBtn.Size = New Size(23, 22)
        HomeBtn.Text = "ToolStripButton1"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(6, 25)
        ' 
        ' TransactionBtn
        ' 
        TransactionBtn.AccessibleDescription = "Here it is"
        TransactionBtn.AccessibleName = "Staffs"
        TransactionBtn.Name = "TransactionBtn"
        TransactionBtn.ShowDropDownArrow = False
        TransactionBtn.Size = New Size(76, 22)
        TransactionBtn.Text = "Transactions"
        ' 
        ' LoansBtn
        ' 
        LoansBtn.Name = "LoansBtn"
        LoansBtn.ShowDropDownArrow = False
        LoansBtn.Size = New Size(42, 22)
        LoansBtn.Text = "Loans"
        ' 
        ' ShareBtn
        ' 
        ShareBtn.Name = "ShareBtn"
        ShareBtn.ShowDropDownArrow = False
        ShareBtn.Size = New Size(80, 22)
        ShareBtn.Text = "Share Capital"
        ' 
        ' MembersBtn
        ' 
        MembersBtn.Name = "MembersBtn"
        MembersBtn.ShowDropDownArrow = False
        MembersBtn.Size = New Size(61, 22)
        MembersBtn.Text = "Members"
        ' 
        ' StaffsBtn
        ' 
        StaffsBtn.Name = "StaffsBtn"
        StaffsBtn.ShowDropDownArrow = False
        StaffsBtn.Size = New Size(40, 22)
        StaffsBtn.Text = "Staffs"
        ' 
        ' Main_panel
        ' 
        Main_panel.BackColor = SystemColors.Control
        Main_panel.Dock = DockStyle.Fill
        Main_panel.Location = New Point(0, 25)
        Main_panel.Name = "Main_panel"
        Main_panel.Size = New Size(868, 432)
        Main_panel.TabIndex = 1
        ' 
        ' Main_form
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(868, 457)
        Controls.Add(Main_panel)
        Controls.Add(ToolStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(868, 432)
        Name = "Main_form"
        Text = "KKMKK-TMS"
        WindowState = FormWindowState.Maximized
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents LoansBtn As ToolStripDropDownButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ShareBtn As ToolStripDropDownButton
    Friend WithEvents MembersBtn As ToolStripDropDownButton
    Friend WithEvents TransactionBtn As ToolStripDropDownButton
    Friend WithEvents StaffsBtn As ToolStripDropDownButton
    Friend WithEvents Main_panel As Panel
    Friend WithEvents HomeBtn As ToolStripButton

End Class
