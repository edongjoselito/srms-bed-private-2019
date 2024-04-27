<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTeacher
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblAccountLevel = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ADVISORYCLASSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RECEIVEGRADINGSHEETSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSOLIDATEDGRADESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GRADINGSHEETSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SWITCHSEMESTERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.crViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.stDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stSemester = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stSY = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblSettingsID = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblInstructor = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 86)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1337, 10)
        Me.Panel7.TabIndex = 17
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.IconButton1)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1337, 86)
        Me.Panel5.TabIndex = 16
        '
        'IconButton1
        '
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.GraduationCap
        Me.IconButton1.IconColor = System.Drawing.Color.DeepSkyBlue
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.Location = New System.Drawing.Point(24, 6)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(75, 72)
        Me.IconButton1.TabIndex = 7
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(105, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "TEACHER'S MODULE"
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
        Me.lblAccountLevel.Location = New System.Drawing.Point(12, 61)
        Me.lblAccountLevel.Name = "lblAccountLevel"
        Me.lblAccountLevel.Size = New System.Drawing.Size(81, 15)
        Me.lblAccountLevel.TabIndex = 9
        Me.lblAccountLevel.Text = "Account Level"
        Me.lblAccountLevel.Visible = False
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
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 813)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1337, 10)
        Me.Panel1.TabIndex = 18
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton5, Me.ToolStripButton3, Me.ToolStripButton8, Me.ToolStripButton9})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 96)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1337, 55)
        Me.ToolStrip1.TabIndex = 19
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.Image = Global.SRMS_BED.My.Resources.Resources.Grades
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(101, 52)
        Me.ToolStripButton1.Text = "GRADES"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADVISORYCLASSToolStripMenuItem, Me.RECEIVEGRADINGSHEETSToolStripMenuItem, Me.CONSOLIDATEDGRADESToolStripMenuItem, Me.GRADINGSHEETSToolStripMenuItem})
        Me.ToolStripButton5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton5.Image = Global.SRMS_BED.My.Resources.Resources.Graph_Report
        Me.ToolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(116, 52)
        Me.ToolStripButton5.Text = "REPORTS"
        '
        'ADVISORYCLASSToolStripMenuItem
        '
        Me.ADVISORYCLASSToolStripMenuItem.Name = "ADVISORYCLASSToolStripMenuItem"
        Me.ADVISORYCLASSToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ADVISORYCLASSToolStripMenuItem.Text = "ADVISORY CLASS"
        Me.ADVISORYCLASSToolStripMenuItem.Visible = False
        '
        'RECEIVEGRADINGSHEETSToolStripMenuItem
        '
        Me.RECEIVEGRADINGSHEETSToolStripMenuItem.Name = "RECEIVEGRADINGSHEETSToolStripMenuItem"
        Me.RECEIVEGRADINGSHEETSToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.RECEIVEGRADINGSHEETSToolStripMenuItem.Text = "CLASS LIST"
        '
        'CONSOLIDATEDGRADESToolStripMenuItem
        '
        Me.CONSOLIDATEDGRADESToolStripMenuItem.Name = "CONSOLIDATEDGRADESToolStripMenuItem"
        Me.CONSOLIDATEDGRADESToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.CONSOLIDATEDGRADESToolStripMenuItem.Text = "FACULTY WORKLOAD"
        '
        'GRADINGSHEETSToolStripMenuItem
        '
        Me.GRADINGSHEETSToolStripMenuItem.Name = "GRADINGSHEETSToolStripMenuItem"
        Me.GRADINGSHEETSToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.GRADINGSHEETSToolStripMenuItem.Text = "GRADING SHEETS"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton3.Image = Global.SRMS_BED.My.Resources.Resources.Access
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(167, 52)
        Me.ToolStripButton3.Text = "CHANGE PASSWORD"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SWITCHSEMESTERToolStripMenuItem})
        Me.ToolStripButton8.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton8.Image = Global.SRMS_BED.My.Resources.Resources.Laptop_Settings
        Me.ToolStripButton8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(118, 52)
        Me.ToolStripButton8.Text = "SETTINGS"
        '
        'SWITCHSEMESTERToolStripMenuItem
        '
        Me.SWITCHSEMESTERToolStripMenuItem.Name = "SWITCHSEMESTERToolStripMenuItem"
        Me.SWITCHSEMESTERToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.SWITCHSEMESTERToolStripMenuItem.Text = "SWITCH SEMESTER"
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.Image = Global.SRMS_BED.My.Resources.Resources.Refresh_48px
        Me.ToolStripButton9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.Size = New System.Drawing.Size(168, 52)
        Me.ToolStripButton9.Text = "RELOAD [ CTRL + R ]"
        '
        'crViewer
        '
        Me.crViewer.ActiveViewIndex = -1
        Me.crViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.crViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crViewer.Location = New System.Drawing.Point(0, 151)
        Me.crViewer.Name = "crViewer"
        Me.crViewer.Size = New System.Drawing.Size(1337, 662)
        Me.crViewer.TabIndex = 20
        Me.crViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stDate, Me.stTime, Me.stUser, Me.stSemester, Me.stSY, Me.lblSettingsID, Me.lblInstructor})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 791)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1337, 22)
        Me.StatusStrip1.TabIndex = 21
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'stDate
        '
        Me.stDate.BackColor = System.Drawing.Color.Transparent
        Me.stDate.Name = "stDate"
        Me.stDate.Size = New System.Drawing.Size(36, 17)
        Me.stDate.Text = "Date"
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
        '
        'lblSettingsID
        '
        Me.lblSettingsID.Name = "lblSettingsID"
        Me.lblSettingsID.Size = New System.Drawing.Size(65, 17)
        Me.lblSettingsID.Text = "SettingsID"
        Me.lblSettingsID.Visible = False
        '
        'lblInstructor
        '
        Me.lblInstructor.Name = "lblInstructor"
        Me.lblInstructor.Size = New System.Drawing.Size(64, 17)
        Me.lblInstructor.Text = "Instructor"
        Me.lblInstructor.Visible = False
        '
        'frmTeacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SRMS_BED.My.Resources.Resources.bg3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1337, 823)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.crViewer)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTeacher"
        Me.ShowIcon = False
        Me.Text = "::"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lblAccountLevel As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton8 As ToolStripDropDownButton
    Friend WithEvents SWITCHSEMESTERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton9 As ToolStripButton
    Friend WithEvents crViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents stDate As ToolStripStatusLabel
    Friend WithEvents stTime As ToolStripStatusLabel
    Friend WithEvents stUser As ToolStripStatusLabel
    Friend WithEvents stSemester As ToolStripStatusLabel
    Friend WithEvents stSY As ToolStripStatusLabel
    Friend WithEvents lblSettingsID As ToolStripStatusLabel
    Friend WithEvents ToolStripButton5 As ToolStripDropDownButton
    Friend WithEvents ADVISORYCLASSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RECEIVEGRADINGSHEETSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONSOLIDATEDGRADESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GRADINGSHEETSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblInstructor As ToolStripStatusLabel
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class
