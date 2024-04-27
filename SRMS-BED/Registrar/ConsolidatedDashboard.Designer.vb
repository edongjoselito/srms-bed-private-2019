<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsolidatedDashboard
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.rdoFemale = New System.Windows.Forms.RadioButton
        Me.rdoMale = New System.Windows.Forms.RadioButton
        Me.cboPeriod = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboSection = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboYearLevelAccount = New System.Windows.Forms.ComboBox
        Me.btnStudeAccount = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(230, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 15)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "SECTION"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.rdoFemale)
        Me.Panel1.Controls.Add(Me.rdoMale)
        Me.Panel1.Controls.Add(Me.cboPeriod)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cboSection)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cboYearLevelAccount)
        Me.Panel1.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(486, 122)
        Me.Panel1.TabIndex = 20
        '
        'rdoFemale
        '
        Me.rdoFemale.AutoSize = True
        Me.rdoFemale.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoFemale.Location = New System.Drawing.Point(192, 83)
        Me.rdoFemale.Name = "rdoFemale"
        Me.rdoFemale.Size = New System.Drawing.Size(64, 19)
        Me.rdoFemale.TabIndex = 52
        Me.rdoFemale.TabStop = True
        Me.rdoFemale.Text = "Female"
        Me.rdoFemale.UseVisualStyleBackColor = True
        '
        'rdoMale
        '
        Me.rdoMale.AutoSize = True
        Me.rdoMale.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoMale.Location = New System.Drawing.Point(106, 83)
        Me.rdoMale.Name = "rdoMale"
        Me.rdoMale.Size = New System.Drawing.Size(53, 19)
        Me.rdoMale.TabIndex = 51
        Me.rdoMale.TabStop = True
        Me.rdoMale.Text = "Male"
        Me.rdoMale.UseVisualStyleBackColor = True
        '
        'cboPeriod
        '
        Me.cboPeriod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPeriod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriod.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPeriod.FormattingEnabled = True
        Me.cboPeriod.Items.AddRange(New Object() {"1st Grading", "2nd Grading", "3rd Grading", "4th Grading"})
        Me.cboPeriod.Location = New System.Drawing.Point(106, 50)
        Me.cboPeriod.Name = "cboPeriod"
        Me.cboPeriod.Size = New System.Drawing.Size(358, 23)
        Me.cboPeriod.TabIndex = 50
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(52, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 15)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "PERIOD"
        '
        'cboSection
        '
        Me.cboSection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSection.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSection.ForeColor = System.Drawing.Color.Black
        Me.cboSection.FormattingEnabled = True
        Me.cboSection.Location = New System.Drawing.Point(289, 17)
        Me.cboSection.Name = "cboSection"
        Me.cboSection.Size = New System.Drawing.Size(175, 23)
        Me.cboSection.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(25, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 15)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "GRADE LEVEL"
        '
        'cboYearLevelAccount
        '
        Me.cboYearLevelAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboYearLevelAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboYearLevelAccount.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYearLevelAccount.ForeColor = System.Drawing.Color.Black
        Me.cboYearLevelAccount.FormattingEnabled = True
        Me.cboYearLevelAccount.Location = New System.Drawing.Point(106, 17)
        Me.cboYearLevelAccount.Name = "cboYearLevelAccount"
        Me.cboYearLevelAccount.Size = New System.Drawing.Size(109, 23)
        Me.cboYearLevelAccount.TabIndex = 18
        '
        'btnStudeAccount
        '
        Me.btnStudeAccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnStudeAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudeAccount.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudeAccount.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnStudeAccount.Location = New System.Drawing.Point(372, 176)
        Me.btnStudeAccount.Name = "btnStudeAccount"
        Me.btnStudeAccount.Size = New System.Drawing.Size(92, 35)
        Me.btnStudeAccount.TabIndex = 21
        Me.btnStudeAccount.Text = "PREVIEW"
        Me.btnStudeAccount.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(67, 176)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 35)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "PREVIEW v2"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(486, 42)
        Me.Panel2.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(126, 8)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(223, 26)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "CONSOLIDATED GRADES"
        '
        'frmConsolidatedDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(486, 233)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnStudeAccount)
        Me.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsolidatedDashboard"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "::"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cboSection As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboYearLevelAccount As System.Windows.Forms.ComboBox
    Friend WithEvents btnStudeAccount As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboPeriod As System.Windows.Forms.ComboBox
    Friend WithEvents rdoFemale As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMale As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
