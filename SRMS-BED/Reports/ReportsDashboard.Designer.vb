<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReportsDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportsDashboard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.stDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stSemester = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stSY = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblSettingsID = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.VERSION2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VERSION3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VERSION4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.BYDEPARTMENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BYSTRANDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BYETHNICITYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BYGENDERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BYMUNICIPALITYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BYRELIGIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COUNTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.CLASSROOMSCHEDULESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.crViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
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
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(62, Byte), Integer))
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
        Me.Label2.Size = New System.Drawing.Size(82, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "REPORTS"
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
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stDate, Me.stTime, Me.stUser, Me.stSemester, Me.stSY, Me.lblSettingsID})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 791)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1337, 22)
        Me.StatusStrip1.TabIndex = 26
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
        '
        'lblSettingsID
        '
        Me.lblSettingsID.Name = "lblSettingsID"
        Me.lblSettingsID.Size = New System.Drawing.Size(65, 17)
        Me.lblSettingsID.Text = "SettingsID"
        Me.lblSettingsID.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton4, Me.ToolStripButton2, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 96)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1337, 55)
        Me.ToolStrip1.TabIndex = 27
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VERSION2ToolStripMenuItem, Me.VERSION3ToolStripMenuItem, Me.VERSION4ToolStripMenuItem})
        Me.ToolStripButton1.Image = Global.SRMS_BED.My.Resources.Resources.Summary_List
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(204, 52)
        Me.ToolStripButton1.Text = "ENROLLMENT SUMMARY"
        '
        'VERSION2ToolStripMenuItem
        '
        Me.VERSION2ToolStripMenuItem.Name = "VERSION2ToolStripMenuItem"
        Me.VERSION2ToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.VERSION2ToolStripMenuItem.Text = "VERSION 1"
        '
        'VERSION3ToolStripMenuItem
        '
        Me.VERSION3ToolStripMenuItem.Name = "VERSION3ToolStripMenuItem"
        Me.VERSION3ToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.VERSION3ToolStripMenuItem.Text = "VERSION 2"
        '
        'VERSION4ToolStripMenuItem
        '
        Me.VERSION4ToolStripMenuItem.Name = "VERSION4ToolStripMenuItem"
        Me.VERSION4ToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.VERSION4ToolStripMenuItem.Text = "VERSION 3"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BYDEPARTMENTToolStripMenuItem, Me.BYSTRANDToolStripMenuItem, Me.BYETHNICITYToolStripMenuItem, Me.BYGENDERToolStripMenuItem, Me.BYMUNICIPALITYToolStripMenuItem, Me.BYRELIGIONToolStripMenuItem, Me.COUNTSToolStripMenuItem})
        Me.ToolStripButton4.Image = Global.SRMS_BED.My.Resources.Resources.Bar_Chart
        Me.ToolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(187, 52)
        Me.ToolStripButton4.Text = "ENROLLMENT REPORT"
        '
        'BYDEPARTMENTToolStripMenuItem
        '
        Me.BYDEPARTMENTToolStripMenuItem.Name = "BYDEPARTMENTToolStripMenuItem"
        Me.BYDEPARTMENTToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.BYDEPARTMENTToolStripMenuItem.Text = "BY DEPARTMENT"
        '
        'BYSTRANDToolStripMenuItem
        '
        Me.BYSTRANDToolStripMenuItem.Name = "BYSTRANDToolStripMenuItem"
        Me.BYSTRANDToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.BYSTRANDToolStripMenuItem.Text = "BY STRAND"
        '
        'BYETHNICITYToolStripMenuItem
        '
        Me.BYETHNICITYToolStripMenuItem.Name = "BYETHNICITYToolStripMenuItem"
        Me.BYETHNICITYToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.BYETHNICITYToolStripMenuItem.Text = "BY ETHNICITY"
        '
        'BYGENDERToolStripMenuItem
        '
        Me.BYGENDERToolStripMenuItem.Name = "BYGENDERToolStripMenuItem"
        Me.BYGENDERToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.BYGENDERToolStripMenuItem.Text = "BY GENDER"
        '
        'BYMUNICIPALITYToolStripMenuItem
        '
        Me.BYMUNICIPALITYToolStripMenuItem.Name = "BYMUNICIPALITYToolStripMenuItem"
        Me.BYMUNICIPALITYToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.BYMUNICIPALITYToolStripMenuItem.Text = "BY MUNICIPALITY"
        '
        'BYRELIGIONToolStripMenuItem
        '
        Me.BYRELIGIONToolStripMenuItem.Name = "BYRELIGIONToolStripMenuItem"
        Me.BYRELIGIONToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.BYRELIGIONToolStripMenuItem.Text = "BY RELIGION"
        '
        'COUNTSToolStripMenuItem
        '
        Me.COUNTSToolStripMenuItem.Name = "COUNTSToolStripMenuItem"
        Me.COUNTSToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.COUNTSToolStripMenuItem.Text = "COUNTS"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CLASSROOMSCHEDULESToolStripMenuItem})
        Me.ToolStripButton2.Image = Global.SRMS_BED.My.Resources.Resources.Timetable
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(168, 52)
        Me.ToolStripButton2.Text = "CLASS SCHEDULES"
        '
        'CLASSROOMSCHEDULESToolStripMenuItem
        '
        Me.CLASSROOMSCHEDULESToolStripMenuItem.Name = "CLASSROOMSCHEDULESToolStripMenuItem"
        Me.CLASSROOMSCHEDULESToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.CLASSROOMSCHEDULESToolStripMenuItem.Text = "CLASS ROOM SCHEDULES"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = Global.SRMS_BED.My.Resources.Resources.In_Inventory
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(145, 52)
        Me.ToolStripButton3.Text = "CLASS REGISTER"
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
        Me.crViewer.TabIndex = 28
        Me.crViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmReportsDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1337, 823)
        Me.Controls.Add(Me.crViewer)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel5)
        Me.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmReportsDashboard"
        Me.ShowIcon = False
        Me.Text = "::"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
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
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents stDate As ToolStripStatusLabel
    Friend WithEvents stTime As ToolStripStatusLabel
    Friend WithEvents stUser As ToolStripStatusLabel
    Friend WithEvents stSemester As ToolStripStatusLabel
    Friend WithEvents stSY As ToolStripStatusLabel
    Friend WithEvents lblSettingsID As ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripDropDownButton
    Friend WithEvents VERSION2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VERSION3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VERSION4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton2 As ToolStripDropDownButton
    Friend WithEvents CLASSROOMSCHEDULESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents crViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ToolStripButton4 As ToolStripDropDownButton
    Friend WithEvents BYDEPARTMENTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BYSTRANDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BYETHNICITYToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BYGENDERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BYMUNICIPALITYToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BYRELIGIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents COUNTSToolStripMenuItem As ToolStripMenuItem
End Class
