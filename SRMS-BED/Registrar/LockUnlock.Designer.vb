<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLockUnlock
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
        Me.btnStatus = New System.Windows.Forms.Button()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnSecond = New System.Windows.Forms.Button()
        Me.btnThird = New System.Windows.Forms.Button()
        Me.btnFourth = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnStatus
        '
        Me.btnStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnStatus.FlatAppearance.BorderSize = 0
        Me.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStatus.ForeColor = System.Drawing.Color.White
        Me.btnStatus.Location = New System.Drawing.Point(214, 133)
        Me.btnStatus.Name = "btnStatus"
        Me.btnStatus.Size = New System.Drawing.Size(248, 38)
        Me.btnStatus.TabIndex = 0
        Me.btnStatus.Text = "LOCK ALL GRADES"
        Me.btnStatus.UseVisualStyleBackColor = False
        '
        'cboStatus
        '
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Location = New System.Drawing.Point(32, 25)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(121, 27)
        Me.cboStatus.TabIndex = 5
        Me.cboStatus.Visible = False
        '
        'btnFirst
        '
        Me.btnFirst.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnFirst.FlatAppearance.BorderSize = 0
        Me.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFirst.ForeColor = System.Drawing.Color.White
        Me.btnFirst.Location = New System.Drawing.Point(125, 45)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(210, 38)
        Me.btnFirst.TabIndex = 6
        Me.btnFirst.Text = "LOCK FIRST GRADING"
        Me.btnFirst.UseVisualStyleBackColor = False
        '
        'btnSecond
        '
        Me.btnSecond.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnSecond.FlatAppearance.BorderSize = 0
        Me.btnSecond.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSecond.ForeColor = System.Drawing.Color.White
        Me.btnSecond.Location = New System.Drawing.Point(341, 45)
        Me.btnSecond.Name = "btnSecond"
        Me.btnSecond.Size = New System.Drawing.Size(210, 38)
        Me.btnSecond.TabIndex = 7
        Me.btnSecond.Text = "LOCK SECOND GRADING"
        Me.btnSecond.UseVisualStyleBackColor = False
        '
        'btnThird
        '
        Me.btnThird.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnThird.FlatAppearance.BorderSize = 0
        Me.btnThird.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnThird.ForeColor = System.Drawing.Color.White
        Me.btnThird.Location = New System.Drawing.Point(125, 89)
        Me.btnThird.Name = "btnThird"
        Me.btnThird.Size = New System.Drawing.Size(210, 38)
        Me.btnThird.TabIndex = 8
        Me.btnThird.Text = "LOCK THIRD GRADING"
        Me.btnThird.UseVisualStyleBackColor = False
        '
        'btnFourth
        '
        Me.btnFourth.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnFourth.FlatAppearance.BorderSize = 0
        Me.btnFourth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFourth.ForeColor = System.Drawing.Color.White
        Me.btnFourth.Location = New System.Drawing.Point(341, 89)
        Me.btnFourth.Name = "btnFourth"
        Me.btnFourth.Size = New System.Drawing.Size(210, 38)
        Me.btnFourth.TabIndex = 9
        Me.btnFourth.Text = "LOCK FOURTH GRADING"
        Me.btnFourth.UseVisualStyleBackColor = False
        '
        'frmLockUnlock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 216)
        Me.Controls.Add(Me.btnFourth)
        Me.Controls.Add(Me.btnThird)
        Me.Controls.Add(Me.btnSecond)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.btnStatus)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLockUnlock"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "::"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnStatus As Button
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnSecond As Button
    Friend WithEvents btnThird As Button
    Friend WithEvents btnFourth As Button
End Class
