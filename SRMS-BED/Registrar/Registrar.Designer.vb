<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistrar
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistrar))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.crViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.stDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stSemester = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stSY = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblSettingsID = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ENCODEGRADESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StGradingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NdGradingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RdGradingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThGradingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MODIFYGRADESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.MASTERLISTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BYSUBJECTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BYDEPARTMENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BYSECTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BYSPECIALIZATIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GRADINGSHEETSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSOLIDATEDGRADESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RECEIVEGRADINGSHEETSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SWITCHSEMESTERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnrollmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubjectEnlistmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 813)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1337, 10)
        Me.Panel1.TabIndex = 13
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
        Me.Label2.Size = New System.Drawing.Size(174, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "REGISTRAR MODULE"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnClose)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(1137, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(200, 86)
        Me.Panel6.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.crViewer)
        Me.Panel2.Controls.Add(Me.StatusStrip1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.ToolStrip1)
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 96)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1337, 727)
        Me.Panel2.TabIndex = 15
        '
        'crViewer
        '
        Me.crViewer.ActiveViewIndex = -1
        Me.crViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.crViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crViewer.Location = New System.Drawing.Point(0, 55)
        Me.crViewer.Name = "crViewer"
        Me.crViewer.Size = New System.Drawing.Size(1337, 640)
        Me.crViewer.TabIndex = 3
        Me.crViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stDate, Me.stTime, Me.stUser, Me.stSemester, Me.stSY, Me.lblSettingsID})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 695)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1337, 22)
        Me.StatusStrip1.TabIndex = 2
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
        '
        'stUser
        '
        Me.stUser.BackColor = System.Drawing.Color.Transparent
        Me.stUser.Name = "stUser"
        Me.stUser.Size = New System.Drawing.Size(34, 17)
        Me.stUser.Text = "User"
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
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 717)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1337, 10)
        Me.Panel3.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton6, Me.ToolStripButton7, Me.ToolStripButton5, Me.ToolStripButton8})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1337, 55)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.Image = Global.SRMS_BED.My.Resources.Resources.Client_Management
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(163, 52)
        Me.ToolStripButton1.Text = "STUDENTS' PROFILE"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton2.Image = Global.SRMS_BED.My.Resources.Resources.Contacts2
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(130, 52)
        Me.ToolStripButton2.Text = "ENROLLMENT"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton3.Image = Global.SRMS_BED.My.Resources.Resources.Syllabus
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(178, 52)
        Me.ToolStripButton3.Text = "SUBJECTS ENLISTMENT"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ENCODEGRADESToolStripMenuItem, Me.MODIFYGRADESToolStripMenuItem})
        Me.ToolStripButton4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton4.Image = Global.SRMS_BED.My.Resources.Resources.Grades
        Me.ToolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(110, 52)
        Me.ToolStripButton4.Text = "GRADES"
        '
        'ENCODEGRADESToolStripMenuItem
        '
        Me.ENCODEGRADESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StGradingToolStripMenuItem, Me.NdGradingToolStripMenuItem, Me.RdGradingToolStripMenuItem, Me.ThGradingToolStripMenuItem})
        Me.ENCODEGRADESToolStripMenuItem.Name = "ENCODEGRADESToolStripMenuItem"
        Me.ENCODEGRADESToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ENCODEGRADESToolStripMenuItem.Text = "ENCODE GRADES"
        '
        'StGradingToolStripMenuItem
        '
        Me.StGradingToolStripMenuItem.Name = "StGradingToolStripMenuItem"
        Me.StGradingToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.StGradingToolStripMenuItem.Text = "1ST GRADING"
        '
        'NdGradingToolStripMenuItem
        '
        Me.NdGradingToolStripMenuItem.Name = "NdGradingToolStripMenuItem"
        Me.NdGradingToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.NdGradingToolStripMenuItem.Text = "2ND GRADING"
        '
        'RdGradingToolStripMenuItem
        '
        Me.RdGradingToolStripMenuItem.Name = "RdGradingToolStripMenuItem"
        Me.RdGradingToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.RdGradingToolStripMenuItem.Text = "3RD GRADING"
        '
        'ThGradingToolStripMenuItem
        '
        Me.ThGradingToolStripMenuItem.Name = "ThGradingToolStripMenuItem"
        Me.ThGradingToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ThGradingToolStripMenuItem.Text = "4TH GRADING"
        '
        'MODIFYGRADESToolStripMenuItem
        '
        Me.MODIFYGRADESToolStripMenuItem.Name = "MODIFYGRADESToolStripMenuItem"
        Me.MODIFYGRADESToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.MODIFYGRADESToolStripMenuItem.Text = "MODIFY GRADES"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton6.Image = Global.SRMS_BED.My.Resources.Resources.Data_Transfer
        Me.ToolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(119, 52)
        Me.ToolStripButton6.Text = "RECIEVE GS"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton7.Image = Global.SRMS_BED.My.Resources.Resources.Lock
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(153, 52)
        Me.ToolStripButton7.Text = "LOCK/UNLOCK GRADES"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MASTERLISTToolStripMenuItem, Me.GRADINGSHEETSToolStripMenuItem, Me.CONSOLIDATEDGRADESToolStripMenuItem, Me.RECEIVEGRADINGSHEETSToolStripMenuItem})
        Me.ToolStripButton5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton5.Image = Global.SRMS_BED.My.Resources.Resources.Graph_Report
        Me.ToolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(116, 52)
        Me.ToolStripButton5.Text = "REPORTS"
        '
        'MASTERLISTToolStripMenuItem
        '
        Me.MASTERLISTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BYSUBJECTToolStripMenuItem, Me.BYDEPARTMENTToolStripMenuItem, Me.BYSECTIONToolStripMenuItem, Me.BYSPECIALIZATIONToolStripMenuItem})
        Me.MASTERLISTToolStripMenuItem.Name = "MASTERLISTToolStripMenuItem"
        Me.MASTERLISTToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.MASTERLISTToolStripMenuItem.Text = "MASTERLIST"
        '
        'BYSUBJECTToolStripMenuItem
        '
        Me.BYSUBJECTToolStripMenuItem.Name = "BYSUBJECTToolStripMenuItem"
        Me.BYSUBJECTToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.BYSUBJECTToolStripMenuItem.Text = "BY SUBJECT"
        '
        'BYDEPARTMENTToolStripMenuItem
        '
        Me.BYDEPARTMENTToolStripMenuItem.Name = "BYDEPARTMENTToolStripMenuItem"
        Me.BYDEPARTMENTToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.BYDEPARTMENTToolStripMenuItem.Text = "BY DEPARTMENT"
        '
        'BYSECTIONToolStripMenuItem
        '
        Me.BYSECTIONToolStripMenuItem.Name = "BYSECTIONToolStripMenuItem"
        Me.BYSECTIONToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.BYSECTIONToolStripMenuItem.Text = "BY SECTION"
        '
        'BYSPECIALIZATIONToolStripMenuItem
        '
        Me.BYSPECIALIZATIONToolStripMenuItem.Name = "BYSPECIALIZATIONToolStripMenuItem"
        Me.BYSPECIALIZATIONToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.BYSPECIALIZATIONToolStripMenuItem.Text = "BY SPECIALIZATION"
        '
        'GRADINGSHEETSToolStripMenuItem
        '
        Me.GRADINGSHEETSToolStripMenuItem.Name = "GRADINGSHEETSToolStripMenuItem"
        Me.GRADINGSHEETSToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.GRADINGSHEETSToolStripMenuItem.Text = "GRADING SHEETS"
        '
        'CONSOLIDATEDGRADESToolStripMenuItem
        '
        Me.CONSOLIDATEDGRADESToolStripMenuItem.Name = "CONSOLIDATEDGRADESToolStripMenuItem"
        Me.CONSOLIDATEDGRADESToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.CONSOLIDATEDGRADESToolStripMenuItem.Text = "CONSOLIDATED GRADES"
        '
        'RECEIVEGRADINGSHEETSToolStripMenuItem
        '
        Me.RECEIVEGRADINGSHEETSToolStripMenuItem.Name = "RECEIVEGRADINGSHEETSToolStripMenuItem"
        Me.RECEIVEGRADINGSHEETSToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.RECEIVEGRADINGSHEETSToolStripMenuItem.Text = "RECEIVE GRADING SHEETS"
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
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1337, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReloadToolStripMenuItem, Me.StudentProfileToolStripMenuItem, Me.EnrollmentToolStripMenuItem, Me.SubjectEnlistmentToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'ReloadToolStripMenuItem
        '
        Me.ReloadToolStripMenuItem.Name = "ReloadToolStripMenuItem"
        Me.ReloadToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ReloadToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.ReloadToolStripMenuItem.Text = "Reload"
        '
        'StudentProfileToolStripMenuItem
        '
        Me.StudentProfileToolStripMenuItem.Name = "StudentProfileToolStripMenuItem"
        Me.StudentProfileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.StudentProfileToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.StudentProfileToolStripMenuItem.Text = "Student Profile"
        '
        'EnrollmentToolStripMenuItem
        '
        Me.EnrollmentToolStripMenuItem.Name = "EnrollmentToolStripMenuItem"
        Me.EnrollmentToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EnrollmentToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.EnrollmentToolStripMenuItem.Text = "Enrollment"
        '
        'SubjectEnlistmentToolStripMenuItem
        '
        Me.SubjectEnlistmentToolStripMenuItem.Name = "SubjectEnlistmentToolStripMenuItem"
        Me.SubjectEnlistmentToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SubjectEnlistmentToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.SubjectEnlistmentToolStripMenuItem.Text = "Subject Enlistment"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 86)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1337, 10)
        Me.Panel7.TabIndex = 12
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
        Me.Panel5.TabIndex = 11
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
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'frmRegistrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1337, 823)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel5)
        Me.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmRegistrar"
        Me.Text = "::"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel6.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents stDate As ToolStripStatusLabel
    Friend WithEvents stUser As ToolStripStatusLabel
    Friend WithEvents stTime As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents stSemester As ToolStripStatusLabel
    Friend WithEvents stSY As ToolStripStatusLabel
    Friend WithEvents lblSettingsID As ToolStripStatusLabel
    Friend WithEvents ToolStripButton5 As ToolStripDropDownButton
    Friend WithEvents MASTERLISTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BYSUBJECTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BYDEPARTMENTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BYSECTIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BYSPECIALIZATIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GRADINGSHEETSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONSOLIDATEDGRADESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RECEIVEGRADINGSHEETSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripDropDownButton
    Friend WithEvents ENCODEGRADESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MODIFYGRADESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents crViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents StGradingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NdGradingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RdGradingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThGradingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton8 As ToolStripDropDownButton
    Friend WithEvents SWITCHSEMESTERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReloadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnrollmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubjectEnlistmentToolStripMenuItem As ToolStripMenuItem
End Class
