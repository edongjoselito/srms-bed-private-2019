<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHR))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ACCOUNTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OTHERSERVICESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblAccountLevel = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.stDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stSemester = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stSY = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblSettingsID = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.crViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton3, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 96)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1337, 55)
        Me.ToolStrip1.TabIndex = 23
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.Image = Global.SRMS_BED.My.Resources.Resources.Update_User
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(128, 52)
        Me.ToolStripButton1.Text = "PERSONNEL"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ACCOUNTSToolStripMenuItem, Me.OTHERSERVICESToolStripMenuItem})
        Me.ToolStripButton3.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton3.Image = Global.SRMS_BED.My.Resources.Resources.Popular_Man
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(181, 52)
        Me.ToolStripButton3.Text = "LIST OF PERSONNEL"
        '
        'ACCOUNTSToolStripMenuItem
        '
        Me.ACCOUNTSToolStripMenuItem.Name = "ACCOUNTSToolStripMenuItem"
        Me.ACCOUNTSToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ACCOUNTSToolStripMenuItem.Text = "ALL"
        '
        'OTHERSERVICESToolStripMenuItem
        '
        Me.OTHERSERVICESToolStripMenuItem.Name = "OTHERSERVICESToolStripMenuItem"
        Me.OTHERSERVICESToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OTHERSERVICESToolStripMenuItem.Text = "BY DEPARTMENT"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton2.Image = Global.SRMS_BED.My.Resources.Resources.List_View
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(171, 52)
        Me.ToolStripButton2.Text = "FACULTY LOADING"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClose.Location = New System.Drawing.Point(157, 6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(40, 37)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "x"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(105, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "HUMAN RESOURCE MODULE"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.lblAccountLevel)
        Me.Panel6.Controls.Add(Me.btnClose)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(1137, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(200, 86)
        Me.Panel6.TabIndex = 0
        '
        'lblAccountLevel
        '
        Me.lblAccountLevel.AutoSize = True
        Me.lblAccountLevel.Location = New System.Drawing.Point(22, 61)
        Me.lblAccountLevel.Name = "lblAccountLevel"
        Me.lblAccountLevel.Size = New System.Drawing.Size(86, 17)
        Me.lblAccountLevel.TabIndex = 9
        Me.lblAccountLevel.Text = "Account Level"
        Me.lblAccountLevel.Visible = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 86)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1337, 10)
        Me.Panel7.TabIndex = 21
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.IconButton1)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.MenuStrip1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1337, 86)
        Me.Panel5.TabIndex = 20
        '
        'IconButton1
        '
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.FileContract
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.Location = New System.Drawing.Point(24, 6)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(75, 72)
        Me.IconButton1.TabIndex = 7
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1337, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormloadToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'FormloadToolStripMenuItem
        '
        Me.FormloadToolStripMenuItem.Name = "FormloadToolStripMenuItem"
        Me.FormloadToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.FormloadToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.FormloadToolStripMenuItem.Text = "Formload"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 813)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1337, 10)
        Me.Panel1.TabIndex = 22
        '
        'Panel2
        '
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.crViewer)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 151)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1337, 662)
        Me.Panel2.TabIndex = 24
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stDate, Me.stTime, Me.stUser, Me.stSemester, Me.stSY, Me.lblSettingsID, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 791)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1337, 22)
        Me.StatusStrip1.TabIndex = 25
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'stDate
        '
        Me.stDate.BackColor = System.Drawing.Color.Transparent
        Me.stDate.Name = "stDate"
        Me.stDate.Size = New System.Drawing.Size(36, 17)
        Me.stDate.Text = "Date"
        Me.stDate.Visible = False
        '
        'stTime
        '
        Me.stTime.BackColor = System.Drawing.Color.Transparent
        Me.stTime.Name = "stTime"
        Me.stTime.Size = New System.Drawing.Size(36, 17)
        Me.stTime.Text = "Time"
        Me.stTime.Visible = False
        '
        'stUser
        '
        Me.stUser.BackColor = System.Drawing.Color.Transparent
        Me.stUser.Name = "stUser"
        Me.stUser.Size = New System.Drawing.Size(34, 17)
        Me.stUser.Text = "User"
        Me.stUser.Visible = False
        '
        'stSemester
        '
        Me.stSemester.BackColor = System.Drawing.Color.Transparent
        Me.stSemester.Name = "stSemester"
        Me.stSemester.Size = New System.Drawing.Size(88, 17)
        Me.stSemester.Text = "First Semester"
        '
        'stSY
        '
        Me.stSY.BackColor = System.Drawing.Color.Transparent
        Me.stSY.Name = "stSY"
        Me.stSY.Size = New System.Drawing.Size(68, 17)
        Me.stSY.Text = "2023-2024"
        Me.stSY.Visible = False
        '
        'lblSettingsID
        '
        Me.lblSettingsID.Name = "lblSettingsID"
        Me.lblSettingsID.Size = New System.Drawing.Size(65, 17)
        Me.lblSettingsID.Text = "SettingsID"
        Me.lblSettingsID.Visible = False
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(171, 17)
        Me.ToolStripStatusLabel1.Text = "CTRL + W [ Reload the Form ]"
        '
        'crViewer
        '
        Me.crViewer.ActiveViewIndex = -1
        Me.crViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.crViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crViewer.Location = New System.Drawing.Point(0, 0)
        Me.crViewer.Name = "crViewer"
        Me.crViewer.Size = New System.Drawing.Size(1337, 662)
        Me.crViewer.TabIndex = 0
        Me.crViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmHR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1337, 823)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmHR"
        Me.Text = "::"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnClose As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents stDate As ToolStripStatusLabel
    Friend WithEvents stTime As ToolStripStatusLabel
    Friend WithEvents stUser As ToolStripStatusLabel
    Friend WithEvents stSemester As ToolStripStatusLabel
    Friend WithEvents stSY As ToolStripStatusLabel
    Friend WithEvents lblSettingsID As ToolStripStatusLabel
    Friend WithEvents ToolStripButton3 As ToolStripDropDownButton
    Friend WithEvents ACCOUNTSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OTHERSERVICESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblAccountLevel As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormloadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents crViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
