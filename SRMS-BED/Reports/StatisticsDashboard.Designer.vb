<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatisticsDashboard
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
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.lblSource = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dtpFrom
        '
        Me.dtpFrom.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(52, 42)
        Me.dtpFrom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(183, 23)
        Me.dtpFrom.TabIndex = 0
        '
        'dtpTo
        '
        Me.dtpTo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.Location = New System.Drawing.Point(261, 42)
        Me.dtpTo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(183, 23)
        Me.dtpTo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(241, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "-"
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(334, 80)
        Me.btnPreview.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(110, 33)
        Me.btnPreview.TabIndex = 3
        Me.btnPreview.Text = "PREVIEW"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'lblSource
        '
        Me.lblSource.AutoSize = True
        Me.lblSource.Location = New System.Drawing.Point(60, 98)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Size = New System.Drawing.Size(44, 15)
        Me.lblSource.TabIndex = 4
        Me.lblSource.Text = "Source"
        Me.lblSource.Visible = False
        '
        'frmStatisticsDashboard
        '
        Me.AcceptButton = Me.btnPreview
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(489, 143)
        Me.Controls.Add(Me.lblSource)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpTo)
        Me.Controls.Add(Me.dtpFrom)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStatisticsDashboard"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "::"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents lblSource As Label
End Class
