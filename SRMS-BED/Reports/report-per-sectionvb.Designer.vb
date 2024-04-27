<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReportPerSection
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
        Me.cboSection = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboCourse = New System.Windows.Forms.ComboBox()
        Me.cboYearLevel = New System.Windows.Forms.ComboBox()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboSection
        '
        Me.cboSection.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSection.FormattingEnabled = True
        Me.cboSection.Location = New System.Drawing.Point(277, 56)
        Me.cboSection.Name = "cboSection"
        Me.cboSection.Size = New System.Drawing.Size(172, 23)
        Me.cboSection.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(9, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 15)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "GRADE LEVEL"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(218, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 15)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "SECTION"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(9, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 15)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "DEPARTMENT"
        '
        'cboCourse
        '
        Me.cboCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboCourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCourse.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCourse.ForeColor = System.Drawing.Color.Black
        Me.cboCourse.FormattingEnabled = True
        Me.cboCourse.Location = New System.Drawing.Point(92, 27)
        Me.cboCourse.Name = "cboCourse"
        Me.cboCourse.Size = New System.Drawing.Size(357, 23)
        Me.cboCourse.TabIndex = 15
        '
        'cboYearLevel
        '
        Me.cboYearLevel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboYearLevel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboYearLevel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYearLevel.ForeColor = System.Drawing.Color.Black
        Me.cboYearLevel.FormattingEnabled = True
        Me.cboYearLevel.Location = New System.Drawing.Point(92, 56)
        Me.cboYearLevel.Name = "cboYearLevel"
        Me.cboYearLevel.Size = New System.Drawing.Size(116, 23)
        Me.cboYearLevel.TabIndex = 17
        '
        'btnPreview
        '
        Me.btnPreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.btnPreview.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreview.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPreview.Image = Global.SRMS_BED.My.Resources.Resources.Preview_File_30px
        Me.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPreview.Location = New System.Drawing.Point(350, 122)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(95, 40)
        Me.btnPreview.TabIndex = 16
        Me.btnPreview.Text = "PREVIEW"
        Me.btnPreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPreview.UseVisualStyleBackColor = False
        '
        'frmReportPerSection
        '
        Me.AcceptButton = Me.btnPreview
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(457, 174)
        Me.Controls.Add(Me.cboSection)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cboYearLevel)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboCourse)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReportPerSection"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "::"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboSection As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboCourse As System.Windows.Forms.ComboBox
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents cboYearLevel As System.Windows.Forms.ComboBox
End Class
