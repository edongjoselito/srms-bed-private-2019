<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudeReport_Accounting
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
        Me.btnStudeReport = New System.Windows.Forms.Button()
        Me.specialReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblDP = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mskStudentNumber = New System.Windows.Forms.MaskedTextBox()
        Me.cboStudeReport = New System.Windows.Forms.ComboBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStudeReport
        '
        Me.btnStudeReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnStudeReport.FlatAppearance.BorderSize = 0
        Me.btnStudeReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudeReport.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudeReport.ForeColor = System.Drawing.Color.Black
        Me.btnStudeReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudeReport.Location = New System.Drawing.Point(510, 17)
        Me.btnStudeReport.Name = "btnStudeReport"
        Me.btnStudeReport.Size = New System.Drawing.Size(88, 23)
        Me.btnStudeReport.TabIndex = 3
        Me.btnStudeReport.Text = "&PREVIEW"
        Me.btnStudeReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStudeReport.UseVisualStyleBackColor = False
        '
        'specialReportViewer
        '
        Me.specialReportViewer.ActiveViewIndex = -1
        Me.specialReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.specialReportViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.specialReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.specialReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.specialReportViewer.Name = "specialReportViewer"
        Me.specialReportViewer.SelectionFormula = ""
        Me.specialReportViewer.Size = New System.Drawing.Size(866, 495)
        Me.specialReportViewer.TabIndex = 7
        Me.specialReportViewer.TabStop = False
        Me.specialReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.specialReportViewer.ViewTimeSelectionFormula = ""
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblDP)
        Me.Panel2.Controls.Add(Me.btnStudeReport)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.mskStudentNumber)
        Me.Panel2.Controls.Add(Me.cboStudeReport)
        Me.Panel2.Controls.Add(Me.btnClose)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(866, 56)
        Me.Panel2.TabIndex = 6
        '
        'lblDP
        '
        Me.lblDP.AutoSize = True
        Me.lblDP.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDP.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDP.Location = New System.Drawing.Point(655, 24)
        Me.lblDP.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDP.Name = "lblDP"
        Me.lblDP.Size = New System.Drawing.Size(85, 15)
        Me.lblDP.TabIndex = 35
        Me.lblDP.Text = "FIRSTPAYMENT"
        Me.lblDP.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(26, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "STUDENT NO."
        '
        'mskStudentNumber
        '
        Me.mskStudentNumber.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskStudentNumber.ForeColor = System.Drawing.Color.Black
        Me.mskStudentNumber.Location = New System.Drawing.Point(109, 16)
        Me.mskStudentNumber.Name = "mskStudentNumber"
        Me.mskStudentNumber.ReadOnly = True
        Me.mskStudentNumber.Size = New System.Drawing.Size(191, 23)
        Me.mskStudentNumber.TabIndex = 1
        Me.mskStudentNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboStudeReport
        '
        Me.cboStudeReport.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboStudeReport.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStudeReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStudeReport.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStudeReport.ForeColor = System.Drawing.Color.Black
        Me.cboStudeReport.FormattingEnabled = True
        Me.cboStudeReport.Items.AddRange(New Object() {"Account Tracking", "Ledger (Student's Accounts)", "Ledger (Other Fees and Services)", "Statement of Accounts", "Statement of Accounts V2"})
        Me.cboStudeReport.Location = New System.Drawing.Point(306, 16)
        Me.cboStudeReport.Name = "cboStudeReport"
        Me.cboStudeReport.Size = New System.Drawing.Size(198, 23)
        Me.cboStudeReport.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(319, 19)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(45, 18)
        Me.btnClose.TabIndex = 34
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.specialReportViewer)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(866, 495)
        Me.Panel1.TabIndex = 7
        '
        'frmStudeReport_Accounting
        '
        Me.AcceptButton = Me.btnStudeReport
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 551)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmStudeReport_Accounting"
        Me.ShowIcon = False
        Me.Text = "::"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnStudeReport As System.Windows.Forms.Button
    Friend WithEvents specialReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboStudeReport As System.Windows.Forms.ComboBox
    Friend WithEvents mskStudentNumber As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblDP As System.Windows.Forms.Label
End Class
