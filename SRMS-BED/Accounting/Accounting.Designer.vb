<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccounting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccounting))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblAccountLevel = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsAcccounts = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ACCOUNTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OTHERSERVICESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSchoolExpenses = New System.Windows.Forms.ToolStripDropDownButton()
        Me.EXPENSESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXPENSESREPORTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsOR = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SEARCHORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VOIDORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsReports = New System.Windows.Forms.ToolStripDropDownButton()
        Me.REPORTAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BYCASHIERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BYDATEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BYDESCRIPTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.STUDENTSACCOUNTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.STUDENTSWITHBALANCEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LISTOFVOIDRECEIPTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsFeesDescription = New System.Windows.Forms.ToolStripMenuItem()
        Me.SWITCHSEMESTERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.stDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stSemester = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stSY = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblSettingsID = New System.Windows.Forms.ToolStripStatusLabel()
        Me.crViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnrollmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubjectEnlistmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OTHERFEESDESCRIPTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.FileContract
        Me.IconButton1.IconColor = System.Drawing.Color.Black
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
        Me.Label2.Size = New System.Drawing.Size(194, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ACCOUNTING MODULE"
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
        Me.lblAccountLevel.Location = New System.Drawing.Point(20, 61)
        Me.lblAccountLevel.Name = "lblAccountLevel"
        Me.lblAccountLevel.Size = New System.Drawing.Size(86, 17)
        Me.lblAccountLevel.TabIndex = 8
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
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsAcccounts, Me.ToolStripButton3, Me.tsSchoolExpenses, Me.tsOR, Me.tsReports, Me.ToolStripButton2, Me.ToolStripButton7})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 96)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1337, 55)
        Me.ToolStrip1.TabIndex = 19
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsAcccounts
        '
        Me.tsAcccounts.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsAcccounts.Image = Global.SRMS_BED.My.Resources.Resources.Invoice
        Me.tsAcccounts.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsAcccounts.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsAcccounts.Name = "tsAcccounts"
        Me.tsAcccounts.Size = New System.Drawing.Size(177, 52)
        Me.tsAcccounts.Text = "STUDENTS' ACCOUNTS"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ACCOUNTSToolStripMenuItem, Me.OTHERSERVICESToolStripMenuItem, Me.OTHERFEESDESCRIPTIONToolStripMenuItem})
        Me.ToolStripButton3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton3.Image = Global.SRMS_BED.My.Resources.Resources.Online_Money_Transfer
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(123, 52)
        Me.ToolStripButton3.Text = "PAYMENTS"
        '
        'ACCOUNTSToolStripMenuItem
        '
        Me.ACCOUNTSToolStripMenuItem.Name = "ACCOUNTSToolStripMenuItem"
        Me.ACCOUNTSToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.ACCOUNTSToolStripMenuItem.Text = "ACCOUNTS"
        '
        'OTHERSERVICESToolStripMenuItem
        '
        Me.OTHERSERVICESToolStripMenuItem.Name = "OTHERSERVICESToolStripMenuItem"
        Me.OTHERSERVICESToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.OTHERSERVICESToolStripMenuItem.Text = "OTHER SERVICES"
        '
        'tsSchoolExpenses
        '
        Me.tsSchoolExpenses.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EXPENSESToolStripMenuItem, Me.EXPENSESREPORTToolStripMenuItem})
        Me.tsSchoolExpenses.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsSchoolExpenses.Image = Global.SRMS_BED.My.Resources.Resources.Cash_Register_Euro_48px
        Me.tsSchoolExpenses.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsSchoolExpenses.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSchoolExpenses.Name = "tsSchoolExpenses"
        Me.tsSchoolExpenses.Size = New System.Drawing.Size(167, 52)
        Me.tsSchoolExpenses.Text = "SCHOOL EXPENSES"
        '
        'EXPENSESToolStripMenuItem
        '
        Me.EXPENSESToolStripMenuItem.Name = "EXPENSESToolStripMenuItem"
        Me.EXPENSESToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.EXPENSESToolStripMenuItem.Text = "EXPENSES"
        '
        'EXPENSESREPORTToolStripMenuItem
        '
        Me.EXPENSESREPORTToolStripMenuItem.Name = "EXPENSESREPORTToolStripMenuItem"
        Me.EXPENSESREPORTToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.EXPENSESREPORTToolStripMenuItem.Text = "EXPENSES REPORT"
        '
        'tsOR
        '
        Me.tsOR.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SEARCHORToolStripMenuItem, Me.VOIDORToolStripMenuItem})
        Me.tsOR.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsOR.Image = Global.SRMS_BED.My.Resources.Resources.Stack_of_Coins
        Me.tsOR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsOR.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsOR.Name = "tsOR"
        Me.tsOR.Size = New System.Drawing.Size(168, 52)
        Me.tsOR.Text = "OFFICIAL RECEIPTS"
        '
        'SEARCHORToolStripMenuItem
        '
        Me.SEARCHORToolStripMenuItem.Name = "SEARCHORToolStripMenuItem"
        Me.SEARCHORToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.SEARCHORToolStripMenuItem.Text = "SEARCH O.R."
        '
        'VOIDORToolStripMenuItem
        '
        Me.VOIDORToolStripMenuItem.Name = "VOIDORToolStripMenuItem"
        Me.VOIDORToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.VOIDORToolStripMenuItem.Text = "VOID O.R."
        '
        'tsReports
        '
        Me.tsReports.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REPORTAToolStripMenuItem, Me.REPORTBToolStripMenuItem, Me.STUDENTSACCOUNTSToolStripMenuItem, Me.STUDENTSWITHBALANCEToolStripMenuItem, Me.LISTOFVOIDRECEIPTSToolStripMenuItem})
        Me.tsReports.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsReports.Image = Global.SRMS_BED.My.Resources.Resources.Business_Report
        Me.tsReports.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsReports.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsReports.Name = "tsReports"
        Me.tsReports.Size = New System.Drawing.Size(116, 52)
        Me.tsReports.Text = "REPORTS"
        '
        'REPORTAToolStripMenuItem
        '
        Me.REPORTAToolStripMenuItem.Name = "REPORTAToolStripMenuItem"
        Me.REPORTAToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.REPORTAToolStripMenuItem.Text = "STUDENTS' FINANCIAL REPORTS"
        '
        'REPORTBToolStripMenuItem
        '
        Me.REPORTBToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BYCASHIERToolStripMenuItem, Me.BYDATEToolStripMenuItem, Me.BYDESCRIPTIONToolStripMenuItem})
        Me.REPORTBToolStripMenuItem.Name = "REPORTBToolStripMenuItem"
        Me.REPORTBToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.REPORTBToolStripMenuItem.Text = "COLLECTION REPORTS"
        '
        'BYCASHIERToolStripMenuItem
        '
        Me.BYCASHIERToolStripMenuItem.Name = "BYCASHIERToolStripMenuItem"
        Me.BYCASHIERToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.BYCASHIERToolStripMenuItem.Text = "BY CASHIER"
        '
        'BYDATEToolStripMenuItem
        '
        Me.BYDATEToolStripMenuItem.Name = "BYDATEToolStripMenuItem"
        Me.BYDATEToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.BYDATEToolStripMenuItem.Text = "BY DATE"
        '
        'BYDESCRIPTIONToolStripMenuItem
        '
        Me.BYDESCRIPTIONToolStripMenuItem.Name = "BYDESCRIPTIONToolStripMenuItem"
        Me.BYDESCRIPTIONToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.BYDESCRIPTIONToolStripMenuItem.Text = "BY DESCRIPTION"
        '
        'STUDENTSACCOUNTSToolStripMenuItem
        '
        Me.STUDENTSACCOUNTSToolStripMenuItem.Name = "STUDENTSACCOUNTSToolStripMenuItem"
        Me.STUDENTSACCOUNTSToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.STUDENTSACCOUNTSToolStripMenuItem.Text = "STUDENTS ACCOUNTS"
        '
        'STUDENTSWITHBALANCEToolStripMenuItem
        '
        Me.STUDENTSWITHBALANCEToolStripMenuItem.Name = "STUDENTSWITHBALANCEToolStripMenuItem"
        Me.STUDENTSWITHBALANCEToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.STUDENTSWITHBALANCEToolStripMenuItem.Text = "STUDENTS WITH ACCTS. PAYABLE"
        '
        'LISTOFVOIDRECEIPTSToolStripMenuItem
        '
        Me.LISTOFVOIDRECEIPTSToolStripMenuItem.Name = "LISTOFVOIDRECEIPTSToolStripMenuItem"
        Me.LISTOFVOIDRECEIPTSToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.LISTOFVOIDRECEIPTSToolStripMenuItem.Text = "LIST OF VOID RECEIPTS"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsFeesDescription, Me.SWITCHSEMESTERToolStripMenuItem})
        Me.ToolStripButton2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton2.Image = Global.SRMS_BED.My.Resources.Resources.Laptop_Settings
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(118, 52)
        Me.ToolStripButton2.Text = "SETTINGS"
        '
        'tsFeesDescription
        '
        Me.tsFeesDescription.Name = "tsFeesDescription"
        Me.tsFeesDescription.Size = New System.Drawing.Size(180, 22)
        Me.tsFeesDescription.Text = "FEES DESCRIPTION"
        '
        'SWITCHSEMESTERToolStripMenuItem
        '
        Me.SWITCHSEMESTERToolStripMenuItem.Name = "SWITCHSEMESTERToolStripMenuItem"
        Me.SWITCHSEMESTERToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SWITCHSEMESTERToolStripMenuItem.Text = "SWITCH SEMESTER"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton7.Image = Global.SRMS_BED.My.Resources.Resources.Refresh_48px
        Me.ToolStripButton7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(162, 52)
        Me.ToolStripButton7.Text = "RELOAD [ CTRL + R ]"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stDate, Me.stUser, Me.stSemester, Me.stSY, Me.lblSettingsID})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 791)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1337, 22)
        Me.StatusStrip1.TabIndex = 20
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'stDate
        '
        Me.stDate.BackColor = System.Drawing.Color.Transparent
        Me.stDate.Name = "stDate"
        Me.stDate.Size = New System.Drawing.Size(36, 17)
        Me.stDate.Text = "Date"
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
        'crViewer
        '
        Me.crViewer.ActiveViewIndex = -1
        Me.crViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.crViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crViewer.Location = New System.Drawing.Point(0, 151)
        Me.crViewer.Name = "crViewer"
        Me.crViewer.Size = New System.Drawing.Size(1337, 640)
        Me.crViewer.TabIndex = 21
        Me.crViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 151)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1337, 24)
        Me.MenuStrip1.TabIndex = 22
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
        'OTHERFEESDESCRIPTIONToolStripMenuItem
        '
        Me.OTHERFEESDESCRIPTIONToolStripMenuItem.Name = "OTHERFEESDESCRIPTIONToolStripMenuItem"
        Me.OTHERFEESDESCRIPTIONToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.OTHERFEESDESCRIPTIONToolStripMenuItem.Text = "OTHER SERVICES DESCRIPTION"
        '
        'frmAccounting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.BackgroundImage = Global.SRMS_BED.My.Resources.Resources.bg3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1337, 823)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.crViewer)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel5)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmAccounting"
        Me.ShowIcon = False
        Me.Text = "Accounting"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsAcccounts As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripDropDownButton
    Friend WithEvents ACCOUNTSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OTHERSERVICESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsOR As ToolStripDropDownButton
    Friend WithEvents SEARCHORToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VOIDORToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsReports As ToolStripDropDownButton
    Friend WithEvents REPORTAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REPORTBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton2 As ToolStripDropDownButton
    Friend WithEvents tsFeesDescription As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents stDate As ToolStripStatusLabel
    Friend WithEvents stUser As ToolStripStatusLabel
    Friend WithEvents stSemester As ToolStripStatusLabel
    Friend WithEvents stSY As ToolStripStatusLabel
    Friend WithEvents lblSettingsID As ToolStripStatusLabel
    Friend WithEvents crViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReloadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnrollmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubjectEnlistmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents SWITCHSEMESTERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BYCASHIERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BYDATEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BYDESCRIPTIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents STUDENTSACCOUNTSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents STUDENTSWITHBALANCEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LISTOFVOIDRECEIPTSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsSchoolExpenses As ToolStripDropDownButton
    Friend WithEvents EXPENSESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EXPENSESREPORTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblAccountLevel As Label
    Friend WithEvents OTHERFEESDESCRIPTIONToolStripMenuItem As ToolStripMenuItem
End Class
