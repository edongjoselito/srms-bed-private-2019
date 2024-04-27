<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGradesBatchPrinting
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dg1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnView = New System.Windows.Forms.Button()
        Me.cboCourse = New System.Windows.Forms.ComboBox()
        Me.cboYearLevel = New System.Windows.Forms.ComboBox()
        Me.cboSection = New System.Windows.Forms.ComboBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnPrintRC = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Panel2.SuspendLayout()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(951, 50)
        Me.Panel2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(353, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "BATCH PRINTING"
        '
        'dg1
        '
        Me.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg1.Location = New System.Drawing.Point(0, 124)
        Me.dg1.Name = "dg1"
        Me.dg1.Size = New System.Drawing.Size(767, 383)
        Me.dg1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "DEPARTMENT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "GRADE LEVEL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(274, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "SECTION"
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(570, 95)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(75, 23)
        Me.btnView.TabIndex = 7
        Me.btnView.Text = "VIEW"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'cboCourse
        '
        Me.cboCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCourse.FormattingEnabled = True
        Me.cboCourse.Location = New System.Drawing.Point(96, 66)
        Me.cboCourse.Name = "cboCourse"
        Me.cboCourse.Size = New System.Drawing.Size(459, 23)
        Me.cboCourse.TabIndex = 8
        '
        'cboYearLevel
        '
        Me.cboYearLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYearLevel.FormattingEnabled = True
        Me.cboYearLevel.Location = New System.Drawing.Point(96, 95)
        Me.cboYearLevel.Name = "cboYearLevel"
        Me.cboYearLevel.Size = New System.Drawing.Size(162, 23)
        Me.cboYearLevel.TabIndex = 9
        '
        'cboSection
        '
        Me.cboSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSection.FormattingEnabled = True
        Me.cboSection.Location = New System.Drawing.Point(333, 95)
        Me.cboSection.Name = "cboSection"
        Me.cboSection.Size = New System.Drawing.Size(222, 23)
        Me.cboSection.TabIndex = 10
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPrint.Location = New System.Drawing.Point(773, 174)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(141, 44)
        Me.btnPrint.TabIndex = 11
        Me.btnPrint.Text = "PRINT REPORT OF GRADES"
        Me.btnPrint.UseVisualStyleBackColor = False
        Me.btnPrint.Visible = False
        '
        'btnPrintRC
        '
        Me.btnPrintRC.BackColor = System.Drawing.Color.Teal
        Me.btnPrintRC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintRC.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPrintRC.Location = New System.Drawing.Point(773, 124)
        Me.btnPrintRC.Name = "btnPrintRC"
        Me.btnPrintRC.Size = New System.Drawing.Size(141, 44)
        Me.btnPrintRC.TabIndex = 12
        Me.btnPrintRC.Text = "PRINT REPORT CARD"
        Me.btnPrintRC.UseVisualStyleBackColor = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'frmGradesBatchPrinting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 509)
        Me.Controls.Add(Me.btnPrintRC)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.cboSection)
        Me.Controls.Add(Me.cboYearLevel)
        Me.Controls.Add(Me.cboCourse)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dg1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGradesBatchPrinting"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "::"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents dg1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnView As Button
    Friend WithEvents cboCourse As ComboBox
    Friend WithEvents cboYearLevel As ComboBox
    Friend WithEvents cboSection As ComboBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnPrintRC As Button
    Friend WithEvents PrintDialog1 As PrintDialog
End Class
