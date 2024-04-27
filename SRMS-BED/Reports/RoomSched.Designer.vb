<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoomSched
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRoomSched))
        Me.cboRoom = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboRoom
        '
        Me.cboRoom.DisplayMember = "Room"
        Me.cboRoom.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRoom.FormattingEnabled = True
        Me.cboRoom.Location = New System.Drawing.Point(130, 57)
        Me.cboRoom.Name = "cboRoom"
        Me.cboRoom.Size = New System.Drawing.Size(206, 23)
        Me.cboRoom.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(75, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ROOM"
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(287, 60)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(49, 21)
        Me.btnClose.TabIndex = 22
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnPreview
        '
        Me.btnPreview.BackColor = System.Drawing.Color.Transparent
        Me.btnPreview.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreview.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPreview.Image = CType(resources.GetObject("btnPreview.Image"), System.Drawing.Image)
        Me.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPreview.Location = New System.Drawing.Point(355, 56)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(95, 28)
        Me.btnPreview.TabIndex = 6
        Me.btnPreview.Text = "&PREVIEW"
        Me.btnPreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPreview.UseVisualStyleBackColor = False
        '
        'frmRoomSched
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 152)
        Me.Controls.Add(Me.cboRoom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnClose)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRoomSched"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "::"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPreview As Button
    Friend WithEvents cboRoom As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As Button
End Class
