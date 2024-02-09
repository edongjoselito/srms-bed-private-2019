<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddMedicalRecords
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
        Me.mainProfTS = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsUpdate = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtOtherDetails = New System.Windows.Forms.TextBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.txtMedication = New System.Windows.Forms.TextBox()
        Me.txtPainTolerance = New System.Windows.Forms.TextBox()
        Me.txtMajorComplaint = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBP = New System.Windows.Forms.TextBox()
        Me.txtTemperature = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCaseNo = New System.Windows.Forms.TextBox()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.txtMname = New System.Windows.Forms.TextBox()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtStudenNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMedID = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.tsSave = New System.Windows.Forms.ToolStripButton()
        Me.mainProfTS.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainProfTS
        '
        Me.mainProfTS.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mainProfTS.Font = New System.Drawing.Font("Segoe Condensed", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainProfTS.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.mainProfTS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSave, Me.ToolStripSeparator3, Me.tsUpdate, Me.ToolStripSeparator4, Me.tsDelete, Me.ToolStripSeparator2, Me.btnSearch})
        Me.mainProfTS.Location = New System.Drawing.Point(0, 0)
        Me.mainProfTS.Margin = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.mainProfTS.Name = "mainProfTS"
        Me.mainProfTS.Padding = New System.Windows.Forms.Padding(13, 14, 13, 14)
        Me.mainProfTS.Size = New System.Drawing.Size(726, 65)
        Me.mainProfTS.TabIndex = 58
        Me.mainProfTS.Text = "ts"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 37)
        '
        'tsUpdate
        '
        Me.tsUpdate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsUpdate.Image = Global.SRMS_BED.My.Resources.Resources.Save_as_30px
        Me.tsUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsUpdate.Name = "tsUpdate"
        Me.tsUpdate.Size = New System.Drawing.Size(82, 34)
        Me.tsUpdate.Text = "&UPDATE"
        Me.tsUpdate.ToolTipText = "Ctrl + U"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 37)
        '
        'tsDelete
        '
        Me.tsDelete.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsDelete.Image = Global.SRMS_BED.My.Resources.Resources.Delete_Document_30px
        Me.tsDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDelete.Name = "tsDelete"
        Me.tsDelete.Size = New System.Drawing.Size(78, 34)
        Me.tsDelete.Text = "&DELETE"
        Me.tsDelete.ToolTipText = "Del"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 37)
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = Global.SRMS_BED.My.Resources.Resources.View_30px
        Me.btnSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(82, 34)
        Me.btnSearch.Text = "SEARCH"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(239, 103)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 90
        Me.Button1.Text = "SELECT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtOtherDetails
        '
        Me.txtOtherDetails.Location = New System.Drawing.Point(16, 357)
        Me.txtOtherDetails.Name = "txtOtherDetails"
        Me.txtOtherDetails.Size = New System.Drawing.Size(696, 23)
        Me.txtOtherDetails.TabIndex = 88
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(15, 409)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(698, 23)
        Me.txtNotes.TabIndex = 87
        '
        'txtMedication
        '
        Me.txtMedication.Location = New System.Drawing.Point(15, 306)
        Me.txtMedication.Name = "txtMedication"
        Me.txtMedication.Size = New System.Drawing.Size(697, 23)
        Me.txtMedication.TabIndex = 85
        '
        'txtPainTolerance
        '
        Me.txtPainTolerance.Location = New System.Drawing.Point(373, 255)
        Me.txtPainTolerance.Name = "txtPainTolerance"
        Me.txtPainTolerance.Size = New System.Drawing.Size(340, 23)
        Me.txtPainTolerance.TabIndex = 84
        '
        'txtMajorComplaint
        '
        Me.txtMajorComplaint.Location = New System.Drawing.Point(16, 255)
        Me.txtMajorComplaint.Name = "txtMajorComplaint"
        Me.txtMajorComplaint.Size = New System.Drawing.Size(351, 23)
        Me.txtMajorComplaint.TabIndex = 83
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(13, 391)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 15)
        Me.Label15.TabIndex = 82
        Me.Label15.Text = "NOTES"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 339)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 15)
        Me.Label13.TabIndex = 80
        Me.Label13.Text = "OTHER DETAILS"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 288)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 15)
        Me.Label11.TabIndex = 78
        Me.Label11.Text = "MEDICATION"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(370, 237)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(149, 15)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "PAIN TOLERANCE (1 TO 10)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 237)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 15)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "MAJOR COMPLAINT"
        '
        'txtBP
        '
        Me.txtBP.Location = New System.Drawing.Point(551, 204)
        Me.txtBP.Name = "txtBP"
        Me.txtBP.Size = New System.Drawing.Size(162, 23)
        Me.txtBP.TabIndex = 75
        '
        'txtTemperature
        '
        Me.txtTemperature.Location = New System.Drawing.Point(373, 204)
        Me.txtTemperature.Name = "txtTemperature"
        Me.txtTemperature.Size = New System.Drawing.Size(172, 23)
        Me.txtTemperature.TabIndex = 74
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(548, 186)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 15)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "BLOOD PRESSURE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(370, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 15)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "TEMPERATURE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(192, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 15)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "DATE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 15)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "CASE NO."
        '
        'txtCaseNo
        '
        Me.txtCaseNo.Location = New System.Drawing.Point(16, 204)
        Me.txtCaseNo.Name = "txtCaseNo"
        Me.txtCaseNo.Size = New System.Drawing.Size(173, 23)
        Me.txtCaseNo.TabIndex = 68
        '
        'txtLname
        '
        Me.txtLname.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtLname.ForeColor = System.Drawing.SystemColors.Window
        Me.txtLname.Location = New System.Drawing.Point(463, 154)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(249, 23)
        Me.txtLname.TabIndex = 67
        '
        'txtMname
        '
        Me.txtMname.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtMname.ForeColor = System.Drawing.SystemColors.Window
        Me.txtMname.Location = New System.Drawing.Point(242, 154)
        Me.txtMname.Name = "txtMname"
        Me.txtMname.Size = New System.Drawing.Size(215, 23)
        Me.txtMname.TabIndex = 66
        '
        'txtFname
        '
        Me.txtFname.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtFname.ForeColor = System.Drawing.SystemColors.Window
        Me.txtFname.Location = New System.Drawing.Point(15, 154)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(221, 23)
        Me.txtFname.TabIndex = 65
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(460, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 15)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "LAST NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(239, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "MIDDLE NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 15)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "FIRST NAME"
        '
        'txtStudenNumber
        '
        Me.txtStudenNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtStudenNumber.ForeColor = System.Drawing.SystemColors.Window
        Me.txtStudenNumber.Location = New System.Drawing.Point(15, 104)
        Me.txtStudenNumber.Name = "txtStudenNumber"
        Me.txtStudenNumber.Size = New System.Drawing.Size(218, 23)
        Me.txtStudenNumber.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 15)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "STUDENT NUMBER"
        '
        'lblMedID
        '
        Me.lblMedID.AutoSize = True
        Me.lblMedID.Location = New System.Drawing.Point(131, 107)
        Me.lblMedID.Name = "lblMedID"
        Me.lblMedID.Size = New System.Drawing.Size(42, 15)
        Me.lblMedID.TabIndex = 91
        Me.lblMedID.Text = "medID"
        '
        'dtpDate
        '
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(195, 204)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(172, 23)
        Me.dtpDate.TabIndex = 92
        '
        'tsSave
        '
        Me.tsSave.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsSave.Image = Global.SRMS_BED.My.Resources.Resources.Save
        Me.tsSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSave.Name = "tsSave"
        Me.tsSave.Size = New System.Drawing.Size(66, 34)
        Me.tsSave.Text = "&SAVE"
        Me.tsSave.ToolTipText = "Ctrl + S"
        '
        'frmAddMedicalRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 445)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtOtherDetails)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.txtMedication)
        Me.Controls.Add(Me.txtPainTolerance)
        Me.Controls.Add(Me.txtMajorComplaint)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtBP)
        Me.Controls.Add(Me.txtTemperature)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCaseNo)
        Me.Controls.Add(Me.txtLname)
        Me.Controls.Add(Me.txtMname)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtStudenNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblMedID)
        Me.Controls.Add(Me.mainProfTS)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddMedicalRecords"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MEDICAL RECOREDS"
        Me.mainProfTS.ResumeLayout(False)
        Me.mainProfTS.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mainProfTS As System.Windows.Forms.ToolStrip
    Friend WithEvents tsSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtOtherDetails As System.Windows.Forms.TextBox
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents txtMedication As System.Windows.Forms.TextBox
    Friend WithEvents txtPainTolerance As System.Windows.Forms.TextBox
    Friend WithEvents txtMajorComplaint As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtBP As System.Windows.Forms.TextBox
    Friend WithEvents txtTemperature As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCaseNo As System.Windows.Forms.TextBox
    Friend WithEvents txtLname As System.Windows.Forms.TextBox
    Friend WithEvents txtMname As System.Windows.Forms.TextBox
    Friend WithEvents txtFname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtStudenNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblMedID As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
End Class
