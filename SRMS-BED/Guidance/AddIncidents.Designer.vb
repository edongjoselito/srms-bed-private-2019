<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddIncidents
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
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtActionTaken = New System.Windows.Forms.TextBox()
        Me.txtSanction = New System.Windows.Forms.TextBox()
        Me.txtOffense = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPlace = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCaseNo = New System.Windows.Forms.TextBox()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.txtMname = New System.Windows.Forms.TextBox()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtStudenNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblincID = New System.Windows.Forms.Label()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mainProfTS = New System.Windows.Forms.ToolStrip()
        Me.tsUpdate = New System.Windows.Forms.ToolStripButton()
        Me.tsDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.cboOffenseLevel = New System.Windows.Forms.ComboBox()
        Me.tsSave = New System.Windows.Forms.ToolStripButton()
        Me.mainProfTS.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpDate
        '
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(195, 203)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(172, 23)
        Me.dtpDate.TabIndex = 121
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(239, 102)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 119
        Me.Button1.Text = "SELECT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtActionTaken
        '
        Me.txtActionTaken.Location = New System.Drawing.Point(16, 356)
        Me.txtActionTaken.Name = "txtActionTaken"
        Me.txtActionTaken.Size = New System.Drawing.Size(696, 23)
        Me.txtActionTaken.TabIndex = 118
        '
        'txtSanction
        '
        Me.txtSanction.Location = New System.Drawing.Point(16, 305)
        Me.txtSanction.Name = "txtSanction"
        Me.txtSanction.Size = New System.Drawing.Size(696, 23)
        Me.txtSanction.TabIndex = 117
        '
        'txtOffense
        '
        Me.txtOffense.Location = New System.Drawing.Point(195, 254)
        Me.txtOffense.Name = "txtOffense"
        Me.txtOffense.Size = New System.Drawing.Size(517, 23)
        Me.txtOffense.TabIndex = 116
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 338)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 15)
        Me.Label13.TabIndex = 112
        Me.Label13.Text = "ACTION TAKEN"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 287)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 15)
        Me.Label11.TabIndex = 111
        Me.Label11.Text = "SANCTION"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(192, 236)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 15)
        Me.Label10.TabIndex = 110
        Me.Label10.Text = "OFFENSE"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 236)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 15)
        Me.Label9.TabIndex = 109
        Me.Label9.Text = "OFFENSE LEVEL"
        '
        'txtPlace
        '
        Me.txtPlace.Location = New System.Drawing.Point(373, 203)
        Me.txtPlace.Name = "txtPlace"
        Me.txtPlace.Size = New System.Drawing.Size(339, 23)
        Me.txtPlace.TabIndex = 107
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(370, 185)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 15)
        Me.Label7.TabIndex = 105
        Me.Label7.Text = "PLACE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(192, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 15)
        Me.Label6.TabIndex = 104
        Me.Label6.Text = "DATE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 15)
        Me.Label5.TabIndex = 103
        Me.Label5.Text = "CASE NO."
        '
        'txtCaseNo
        '
        Me.txtCaseNo.Location = New System.Drawing.Point(16, 203)
        Me.txtCaseNo.Name = "txtCaseNo"
        Me.txtCaseNo.Size = New System.Drawing.Size(173, 23)
        Me.txtCaseNo.TabIndex = 102
        '
        'txtLname
        '
        Me.txtLname.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtLname.ForeColor = System.Drawing.SystemColors.Window
        Me.txtLname.Location = New System.Drawing.Point(463, 153)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(249, 23)
        Me.txtLname.TabIndex = 101
        '
        'txtMname
        '
        Me.txtMname.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtMname.ForeColor = System.Drawing.SystemColors.Window
        Me.txtMname.Location = New System.Drawing.Point(242, 153)
        Me.txtMname.Name = "txtMname"
        Me.txtMname.Size = New System.Drawing.Size(215, 23)
        Me.txtMname.TabIndex = 100
        '
        'txtFname
        '
        Me.txtFname.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtFname.ForeColor = System.Drawing.SystemColors.Window
        Me.txtFname.Location = New System.Drawing.Point(15, 153)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(221, 23)
        Me.txtFname.TabIndex = 99
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 37)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(460, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 15)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "LAST NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(239, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "MIDDLE NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 15)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "FIRST NAME"
        '
        'txtStudenNumber
        '
        Me.txtStudenNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtStudenNumber.ForeColor = System.Drawing.SystemColors.Window
        Me.txtStudenNumber.Location = New System.Drawing.Point(15, 103)
        Me.txtStudenNumber.Name = "txtStudenNumber"
        Me.txtStudenNumber.Size = New System.Drawing.Size(221, 23)
        Me.txtStudenNumber.TabIndex = 95
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 15)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "STUDENT NUMBER"
        '
        'lblincID
        '
        Me.lblincID.AutoSize = True
        Me.lblincID.Location = New System.Drawing.Point(131, 106)
        Me.lblincID.Name = "lblincID"
        Me.lblincID.Size = New System.Drawing.Size(19, 15)
        Me.lblincID.TabIndex = 120
        Me.lblincID.Text = "ID"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 37)
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
        Me.mainProfTS.TabIndex = 93
        Me.mainProfTS.Text = "ts"
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
        'cboOffenseLevel
        '
        Me.cboOffenseLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOffenseLevel.FormattingEnabled = True
        Me.cboOffenseLevel.Items.AddRange(New Object() {"", "Minor Offense", "Major Offense"})
        Me.cboOffenseLevel.Location = New System.Drawing.Point(15, 254)
        Me.cboOffenseLevel.Name = "cboOffenseLevel"
        Me.cboOffenseLevel.Size = New System.Drawing.Size(174, 23)
        Me.cboOffenseLevel.TabIndex = 122
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
        'frmAddIncidents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 409)
        Me.Controls.Add(Me.cboOffenseLevel)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtActionTaken)
        Me.Controls.Add(Me.txtSanction)
        Me.Controls.Add(Me.txtOffense)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPlace)
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
        Me.Controls.Add(Me.lblincID)
        Me.Controls.Add(Me.mainProfTS)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddIncidents"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INCIDENTS"
        Me.mainProfTS.ResumeLayout(False)
        Me.mainProfTS.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtActionTaken As System.Windows.Forms.TextBox
    Friend WithEvents txtSanction As System.Windows.Forms.TextBox
    Friend WithEvents txtOffense As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPlace As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCaseNo As System.Windows.Forms.TextBox
    Friend WithEvents txtLname As System.Windows.Forms.TextBox
    Friend WithEvents txtMname As System.Windows.Forms.TextBox
    Friend WithEvents txtFname As System.Windows.Forms.TextBox
    Friend WithEvents tsDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtStudenNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblincID As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mainProfTS As System.Windows.Forms.ToolStrip
    Friend WithEvents tsSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cboOffenseLevel As System.Windows.Forms.ComboBox
End Class
