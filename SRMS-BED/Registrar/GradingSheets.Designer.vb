<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGradingSheets
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
        Me.cboPeriod = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblIDNumber = New System.Windows.Forms.Label()
        Me.btnSelectSubject = New System.Windows.Forms.Button()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtInstructor = New System.Windows.Forms.TextBox()
        Me.txtSection = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtsubjectcode = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.cboSubComp = New System.Windows.Forms.ComboBox()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboPeriod
        '
        Me.cboPeriod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPeriod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriod.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPeriod.FormattingEnabled = True
        Me.cboPeriod.Items.AddRange(New Object() {"1st Grading", "2nd Grading", "3rd Grading", "4th Grading"})
        Me.cboPeriod.Location = New System.Drawing.Point(124, 225)
        Me.cboPeriod.Name = "cboPeriod"
        Me.cboPeriod.Size = New System.Drawing.Size(390, 23)
        Me.cboPeriod.TabIndex = 48
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(72, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 15)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "PERIOD"
        '
        'lblIDNumber
        '
        Me.lblIDNumber.AutoSize = True
        Me.lblIDNumber.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDNumber.Location = New System.Drawing.Point(452, 95)
        Me.lblIDNumber.Name = "lblIDNumber"
        Me.lblIDNumber.Size = New System.Drawing.Size(62, 15)
        Me.lblIDNumber.TabIndex = 45
        Me.lblIDNumber.Text = "IDNumber"
        Me.lblIDNumber.Visible = False
        '
        'btnSelectSubject
        '
        Me.btnSelectSubject.BackColor = System.Drawing.Color.Transparent
        Me.btnSelectSubject.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSelectSubject.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectSubject.ForeColor = System.Drawing.Color.Black
        Me.btnSelectSubject.Location = New System.Drawing.Point(260, 95)
        Me.btnSelectSubject.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnSelectSubject.Name = "btnSelectSubject"
        Me.btnSelectSubject.Size = New System.Drawing.Size(87, 26)
        Me.btnSelectSubject.TabIndex = 43
        Me.btnSelectSubject.Text = "Select"
        Me.btnSelectSubject.UseVisualStyleBackColor = False
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.ForeColor = System.Drawing.Color.Black
        Me.txtDescription.Location = New System.Drawing.Point(126, 128)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(251, 23)
        Me.txtDescription.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(41, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 15)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "DESCRIPTION"
        '
        'txtInstructor
        '
        Me.txtInstructor.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInstructor.ForeColor = System.Drawing.Color.Black
        Me.txtInstructor.Location = New System.Drawing.Point(124, 194)
        Me.txtInstructor.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtInstructor.Name = "txtInstructor"
        Me.txtInstructor.ReadOnly = True
        Me.txtInstructor.Size = New System.Drawing.Size(390, 23)
        Me.txtInstructor.TabIndex = 4
        '
        'txtSection
        '
        Me.txtSection.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSection.ForeColor = System.Drawing.Color.Black
        Me.txtSection.Location = New System.Drawing.Point(124, 161)
        Me.txtSection.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.ReadOnly = True
        Me.txtSection.Size = New System.Drawing.Size(390, 23)
        Me.txtSection.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(66, 197)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 15)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "TEACHER"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(67, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 15)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "SECTION"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(36, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 15)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "SUBJECT CODE"
        '
        'txtsubjectcode
        '
        Me.txtsubjectcode.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsubjectcode.ForeColor = System.Drawing.Color.Black
        Me.txtsubjectcode.Location = New System.Drawing.Point(124, 95)
        Me.txtsubjectcode.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtsubjectcode.Name = "txtsubjectcode"
        Me.txtsubjectcode.ReadOnly = True
        Me.txtsubjectcode.Size = New System.Drawing.Size(130, 23)
        Me.txtsubjectcode.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(284, 197)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(33, 15)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'cboSubComp
        '
        Me.cboSubComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSubComp.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSubComp.FormattingEnabled = True
        Me.cboSubComp.Items.AddRange(New Object() {"", "Music", "Arts", "Physical Education", "Health"})
        Me.cboSubComp.Location = New System.Drawing.Point(383, 128)
        Me.cboSubComp.Name = "cboSubComp"
        Me.cboSubComp.Size = New System.Drawing.Size(131, 23)
        Me.cboSubComp.TabIndex = 54
        '
        'btnPreview
        '
        Me.btnPreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnPreview.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreview.ForeColor = System.Drawing.Color.Black
        Me.btnPreview.Image = Global.SRMS_BED.My.Resources.Resources.View_30px
        Me.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPreview.Location = New System.Drawing.Point(404, 256)
        Me.btnPreview.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(110, 39)
        Me.btnPreview.TabIndex = 5
        Me.btnPreview.Text = "&PREVIEW"
        Me.btnPreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPreview.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(567, 66)
        Me.Panel1.TabIndex = 55
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SRMS_BED.My.Resources.Resources.Statistic_Document_60px
        Me.PictureBox1.Location = New System.Drawing.Point(12, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(54, 62)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(85, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 23)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "GRADING SHEET"
        '
        'frmGradingSheets
        '
        Me.AcceptButton = Me.btnPreview
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(567, 314)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cboSubComp)
        Me.Controls.Add(Me.cboPeriod)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.lblIDNumber)
        Me.Controls.Add(Me.txtsubjectcode)
        Me.Controls.Add(Me.btnSelectSubject)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtSection)
        Me.Controls.Add(Me.txtInstructor)
        Me.Controls.Add(Me.btnCancel)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGradingSheets"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "::"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSelectSubject As System.Windows.Forms.Button
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents txtInstructor As System.Windows.Forms.TextBox
    Friend WithEvents txtSection As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtsubjectcode As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblIDNumber As System.Windows.Forms.Label
    Friend WithEvents cboPeriod As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboSubComp As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
End Class
