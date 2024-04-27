<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStudeReports
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
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblMFourth = New System.Windows.Forms.Label()
        Me.lblMThird = New System.Windows.Forms.Label()
        Me.lblMSecond = New System.Windows.Forms.Label()
        Me.lblMFirst = New System.Windows.Forms.Label()
        Me.lblFourthAve = New System.Windows.Forms.Label()
        Me.lblThirdAve = New System.Windows.Forms.Label()
        Me.lblSecondAve = New System.Windows.Forms.Label()
        Me.lblFirstAve = New System.Windows.Forms.Label()
        Me.lblFourth = New System.Windows.Forms.Label()
        Me.lblThird = New System.Windows.Forms.Label()
        Me.lblSecond = New System.Windows.Forms.Label()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.lblSubjCount = New System.Windows.Forms.Label()
        Me.lblSubjAve = New System.Windows.Forms.Label()
        Me.lblMapehAve = New System.Windows.Forms.Label()
        Me.lblStudeType = New System.Windows.Forms.Label()
        Me.lblGenAve = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.cboStudeReport = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mskStudentNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.specialReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1167, 4)
        Me.Panel7.TabIndex = 21
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.MenuStrip1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1167, 95)
        Me.Panel5.TabIndex = 22
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SRMS_BED.My.Resources.Resources.Student_Registration
        Me.PictureBox1.Location = New System.Drawing.Point(27, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(58, 54)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(91, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "STUDENTS' REPORTS"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnClose)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(942, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(225, 95)
        Me.Panel6.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClose.Location = New System.Drawing.Point(177, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(45, 41)
        Me.btnClose.TabIndex = 5
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "x"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1154, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.ReloadToolStripMenuItem, Me.SaveToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'ReloadToolStripMenuItem
        '
        Me.ReloadToolStripMenuItem.Name = "ReloadToolStripMenuItem"
        Me.ReloadToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ReloadToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.ReloadToolStripMenuItem.Text = "Reload"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblMFourth)
        Me.Panel1.Controls.Add(Me.lblMThird)
        Me.Panel1.Controls.Add(Me.lblMSecond)
        Me.Panel1.Controls.Add(Me.lblMFirst)
        Me.Panel1.Controls.Add(Me.lblFourthAve)
        Me.Panel1.Controls.Add(Me.lblThirdAve)
        Me.Panel1.Controls.Add(Me.lblSecondAve)
        Me.Panel1.Controls.Add(Me.lblFirstAve)
        Me.Panel1.Controls.Add(Me.lblFourth)
        Me.Panel1.Controls.Add(Me.lblThird)
        Me.Panel1.Controls.Add(Me.lblSecond)
        Me.Panel1.Controls.Add(Me.lblFirst)
        Me.Panel1.Controls.Add(Me.lblSubjCount)
        Me.Panel1.Controls.Add(Me.lblSubjAve)
        Me.Panel1.Controls.Add(Me.lblMapehAve)
        Me.Panel1.Controls.Add(Me.lblStudeType)
        Me.Panel1.Controls.Add(Me.lblGenAve)
        Me.Panel1.Controls.Add(Me.lblDepartment)
        Me.Panel1.Controls.Add(Me.cboStudeReport)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnPreview)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.mskStudentNumber)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 99)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1167, 66)
        Me.Panel1.TabIndex = 23
        '
        'lblMFourth
        '
        Me.lblMFourth.AutoSize = True
        Me.lblMFourth.Location = New System.Drawing.Point(1070, 43)
        Me.lblMFourth.Name = "lblMFourth"
        Me.lblMFourth.Size = New System.Drawing.Size(14, 15)
        Me.lblMFourth.TabIndex = 24
        Me.lblMFourth.Text = "0"
        Me.lblMFourth.Visible = False
        '
        'lblMThird
        '
        Me.lblMThird.AutoSize = True
        Me.lblMThird.Location = New System.Drawing.Point(1050, 43)
        Me.lblMThird.Name = "lblMThird"
        Me.lblMThird.Size = New System.Drawing.Size(14, 15)
        Me.lblMThird.TabIndex = 23
        Me.lblMThird.Text = "0"
        Me.lblMThird.Visible = False
        '
        'lblMSecond
        '
        Me.lblMSecond.AutoSize = True
        Me.lblMSecond.Location = New System.Drawing.Point(1030, 43)
        Me.lblMSecond.Name = "lblMSecond"
        Me.lblMSecond.Size = New System.Drawing.Size(14, 15)
        Me.lblMSecond.TabIndex = 22
        Me.lblMSecond.Text = "0"
        Me.lblMSecond.Visible = False
        '
        'lblMFirst
        '
        Me.lblMFirst.AutoSize = True
        Me.lblMFirst.Location = New System.Drawing.Point(1010, 43)
        Me.lblMFirst.Name = "lblMFirst"
        Me.lblMFirst.Size = New System.Drawing.Size(14, 15)
        Me.lblMFirst.TabIndex = 21
        Me.lblMFirst.Text = "0"
        Me.lblMFirst.Visible = False
        '
        'lblFourthAve
        '
        Me.lblFourthAve.AutoSize = True
        Me.lblFourthAve.Location = New System.Drawing.Point(1070, 28)
        Me.lblFourthAve.Name = "lblFourthAve"
        Me.lblFourthAve.Size = New System.Drawing.Size(14, 15)
        Me.lblFourthAve.TabIndex = 20
        Me.lblFourthAve.Text = "0"
        Me.lblFourthAve.Visible = False
        '
        'lblThirdAve
        '
        Me.lblThirdAve.AutoSize = True
        Me.lblThirdAve.Location = New System.Drawing.Point(1050, 28)
        Me.lblThirdAve.Name = "lblThirdAve"
        Me.lblThirdAve.Size = New System.Drawing.Size(14, 15)
        Me.lblThirdAve.TabIndex = 19
        Me.lblThirdAve.Text = "0"
        Me.lblThirdAve.Visible = False
        '
        'lblSecondAve
        '
        Me.lblSecondAve.AutoSize = True
        Me.lblSecondAve.Location = New System.Drawing.Point(1030, 28)
        Me.lblSecondAve.Name = "lblSecondAve"
        Me.lblSecondAve.Size = New System.Drawing.Size(14, 15)
        Me.lblSecondAve.TabIndex = 18
        Me.lblSecondAve.Text = "0"
        Me.lblSecondAve.Visible = False
        '
        'lblFirstAve
        '
        Me.lblFirstAve.AutoSize = True
        Me.lblFirstAve.Location = New System.Drawing.Point(1010, 28)
        Me.lblFirstAve.Name = "lblFirstAve"
        Me.lblFirstAve.Size = New System.Drawing.Size(14, 15)
        Me.lblFirstAve.TabIndex = 17
        Me.lblFirstAve.Text = "0"
        Me.lblFirstAve.Visible = False
        '
        'lblFourth
        '
        Me.lblFourth.AutoSize = True
        Me.lblFourth.Location = New System.Drawing.Point(1070, 13)
        Me.lblFourth.Name = "lblFourth"
        Me.lblFourth.Size = New System.Drawing.Size(14, 15)
        Me.lblFourth.TabIndex = 16
        Me.lblFourth.Text = "0"
        Me.lblFourth.Visible = False
        '
        'lblThird
        '
        Me.lblThird.AutoSize = True
        Me.lblThird.Location = New System.Drawing.Point(1050, 13)
        Me.lblThird.Name = "lblThird"
        Me.lblThird.Size = New System.Drawing.Size(14, 15)
        Me.lblThird.TabIndex = 15
        Me.lblThird.Text = "0"
        Me.lblThird.Visible = False
        '
        'lblSecond
        '
        Me.lblSecond.AutoSize = True
        Me.lblSecond.Location = New System.Drawing.Point(1030, 13)
        Me.lblSecond.Name = "lblSecond"
        Me.lblSecond.Size = New System.Drawing.Size(14, 15)
        Me.lblSecond.TabIndex = 14
        Me.lblSecond.Text = "0"
        Me.lblSecond.Visible = False
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Location = New System.Drawing.Point(1010, 13)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(14, 15)
        Me.lblFirst.TabIndex = 13
        Me.lblFirst.Text = "0"
        Me.lblFirst.Visible = False
        '
        'lblSubjCount
        '
        Me.lblSubjCount.AutoSize = True
        Me.lblSubjCount.Location = New System.Drawing.Point(762, 41)
        Me.lblSubjCount.Name = "lblSubjCount"
        Me.lblSubjCount.Size = New System.Drawing.Size(14, 15)
        Me.lblSubjCount.TabIndex = 12
        Me.lblSubjCount.Text = "0"
        Me.lblSubjCount.Visible = False
        '
        'lblSubjAve
        '
        Me.lblSubjAve.AutoSize = True
        Me.lblSubjAve.Location = New System.Drawing.Point(733, 41)
        Me.lblSubjAve.Name = "lblSubjAve"
        Me.lblSubjAve.Size = New System.Drawing.Size(14, 15)
        Me.lblSubjAve.TabIndex = 11
        Me.lblSubjAve.Text = "0"
        Me.lblSubjAve.Visible = False
        '
        'lblMapehAve
        '
        Me.lblMapehAve.AutoSize = True
        Me.lblMapehAve.Location = New System.Drawing.Point(701, 41)
        Me.lblMapehAve.Name = "lblMapehAve"
        Me.lblMapehAve.Size = New System.Drawing.Size(14, 15)
        Me.lblMapehAve.TabIndex = 10
        Me.lblMapehAve.Text = "0"
        Me.lblMapehAve.Visible = False
        '
        'lblStudeType
        '
        Me.lblStudeType.AutoSize = True
        Me.lblStudeType.Location = New System.Drawing.Point(917, 19)
        Me.lblStudeType.Name = "lblStudeType"
        Me.lblStudeType.Size = New System.Drawing.Size(63, 15)
        Me.lblStudeType.TabIndex = 9
        Me.lblStudeType.Text = "stude type"
        Me.lblStudeType.Visible = False
        '
        'lblGenAve
        '
        Me.lblGenAve.AutoSize = True
        Me.lblGenAve.Location = New System.Drawing.Point(787, 41)
        Me.lblGenAve.Name = "lblGenAve"
        Me.lblGenAve.Size = New System.Drawing.Size(14, 15)
        Me.lblGenAve.TabIndex = 8
        Me.lblGenAve.Text = "0"
        Me.lblGenAve.Visible = False
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Location = New System.Drawing.Point(787, 20)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(71, 15)
        Me.lblDepartment.TabIndex = 7
        Me.lblDepartment.Text = "Department"
        Me.lblDepartment.Visible = False
        '
        'cboStudeReport
        '
        Me.cboStudeReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStudeReport.FormattingEnabled = True
        Me.cboStudeReport.Items.AddRange(New Object() {"Certificate of Enrollment", "Certificate of Enrollment (v2)", "Certificate of GMC", "Certificate of Clearance", "Clearance", "Report of Grades", "Report of Grades (v2)", "Report Card", "Scholastic Record", "Student's Profile", "Registration Form"})
        Me.cboStudeReport.Location = New System.Drawing.Point(120, 37)
        Me.cboStudeReport.Name = "cboStudeReport"
        Me.cboStudeReport.Size = New System.Drawing.Size(445, 23)
        Me.cboStudeReport.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(24, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "REPORT"
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(571, 37)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(75, 23)
        Me.btnPreview.TabIndex = 4
        Me.btnPreview.Text = "PREVIEW"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(320, 10)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(245, 23)
        Me.txtName.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(224, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "STUDENT NAME"
        '
        'mskStudentNumber
        '
        Me.mskStudentNumber.Location = New System.Drawing.Point(120, 10)
        Me.mskStudentNumber.Name = "mskStudentNumber"
        Me.mskStudentNumber.ReadOnly = True
        Me.mskStudentNumber.Size = New System.Drawing.Size(98, 23)
        Me.mskStudentNumber.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(24, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "STUDENT NO."
        '
        'specialReportViewer
        '
        Me.specialReportViewer.ActiveViewIndex = -1
        Me.specialReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.specialReportViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.specialReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.specialReportViewer.Location = New System.Drawing.Point(0, 165)
        Me.specialReportViewer.Name = "specialReportViewer"
        Me.specialReportViewer.Size = New System.Drawing.Size(1167, 519)
        Me.specialReportViewer.TabIndex = 24
        Me.specialReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmStudeReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1167, 684)
        Me.Controls.Add(Me.specialReportViewer)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel7)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStudeReports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "+"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReloadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents specialReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents mskStudentNumber As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPreview As Button
    Friend WithEvents cboStudeReport As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblDepartment As Label
    Friend WithEvents lblGenAve As Label
    Friend WithEvents lblStudeType As Label
    Friend WithEvents lblMFourth As Label
    Friend WithEvents lblMThird As Label
    Friend WithEvents lblMSecond As Label
    Friend WithEvents lblMFirst As Label
    Friend WithEvents lblFourthAve As Label
    Friend WithEvents lblThirdAve As Label
    Friend WithEvents lblSecondAve As Label
    Friend WithEvents lblFirstAve As Label
    Friend WithEvents lblFourth As Label
    Friend WithEvents lblThird As Label
    Friend WithEvents lblSecond As Label
    Friend WithEvents lblFirst As Label
    Friend WithEvents lblSubjCount As Label
    Friend WithEvents lblSubjAve As Label
    Friend WithEvents lblMapehAve As Label
End Class
