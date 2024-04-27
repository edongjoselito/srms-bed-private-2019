<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentAttendance
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
        Me.dg1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboYear = New System.Windows.Forms.ComboBox()
        Me.cboSection = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblAdviserID = New System.Windows.Forms.Label()
        Me.lblAdviser = New System.Windows.Forms.Label()
        Me.cboDepartment = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboMonth = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dg1
        '
        Me.dg1.AllowUserToAddRows = False
        Me.dg1.AllowUserToDeleteRows = False
        Me.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg1.Location = New System.Drawing.Point(0, 98)
        Me.dg1.Name = "dg1"
        Me.dg1.Size = New System.Drawing.Size(691, 313)
        Me.dg1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(465, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "YEAR LEVEL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "SECTION"
        '
        'cboYear
        '
        Me.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Location = New System.Drawing.Point(536, 7)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(143, 23)
        Me.cboYear.TabIndex = 6
        '
        'cboSection
        '
        Me.cboSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSection.FormattingEnabled = True
        Me.cboSection.Location = New System.Drawing.Point(96, 36)
        Me.cboSection.Name = "cboSection"
        Me.cboSection.Size = New System.Drawing.Size(148, 23)
        Me.cboSection.TabIndex = 8
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(570, 417)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(109, 44)
        Me.btnSave.TabIndex = 26
        Me.btnSave.Text = "SAVE"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblAdviserID)
        Me.Panel1.Controls.Add(Me.lblAdviser)
        Me.Panel1.Controls.Add(Me.cboDepartment)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cboMonth)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cboYear)
        Me.Panel1.Controls.Add(Me.cboSection)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(691, 68)
        Me.Panel1.TabIndex = 27
        '
        'lblAdviserID
        '
        Me.lblAdviserID.AutoSize = True
        Me.lblAdviserID.Location = New System.Drawing.Point(588, 44)
        Me.lblAdviserID.Name = "lblAdviserID"
        Me.lblAdviserID.Size = New System.Drawing.Size(60, 15)
        Me.lblAdviserID.TabIndex = 14
        Me.lblAdviserID.Text = "AdviserID"
        Me.lblAdviserID.Visible = False
        '
        'lblAdviser
        '
        Me.lblAdviser.AutoSize = True
        Me.lblAdviser.Location = New System.Drawing.Point(534, 44)
        Me.lblAdviser.Name = "lblAdviser"
        Me.lblAdviser.Size = New System.Drawing.Size(48, 15)
        Me.lblAdviser.TabIndex = 13
        Me.lblAdviser.Text = "Adviser"
        Me.lblAdviser.Visible = False
        '
        'cboDepartment
        '
        Me.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepartment.FormattingEnabled = True
        Me.cboDepartment.Location = New System.Drawing.Point(96, 7)
        Me.cboDepartment.Name = "cboDepartment"
        Me.cboDepartment.Size = New System.Drawing.Size(359, 23)
        Me.cboDepartment.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "DEPARTMENT"
        '
        'cboMonth
        '
        Me.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.Items.AddRange(New Object() {"JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"})
        Me.cboMonth.Location = New System.Drawing.Point(307, 36)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(148, 23)
        Me.cboMonth.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(252, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "MONTH"
        '
        'frmStudentAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 464)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dg1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStudentAttendance"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ":: STUDENT ATTENDACE"
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dg1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboYear As System.Windows.Forms.ComboBox
    Friend WithEvents cboSection As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cboMonth As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblAdviser As System.Windows.Forms.Label
    Friend WithEvents lblAdviserID As System.Windows.Forms.Label
End Class
