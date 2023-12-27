<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccounting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccounting))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripSplitButton()
        Me.ACCOUNTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OTHERSERVICESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripSplitButton()
        Me.SEARCHORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VOIDORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripSplitButton()
        Me.FEESDESCRIPTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PAYMENTDESCRIPTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripSplitButton()
        Me.REPORTAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 813)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1337, 10)
        Me.Panel1.TabIndex = 18
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 86)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1337, 10)
        Me.Panel7.TabIndex = 17
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.IconButton1)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1337, 86)
        Me.Panel5.TabIndex = 16
        '
        'IconButton1
        '
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.FileContract
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.Location = New System.Drawing.Point(24, 6)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(75, 72)
        Me.IconButton1.TabIndex = 7
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(105, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(194, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ACCOUNTING MODULE"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnClose)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(1137, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(200, 86)
        Me.Panel6.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClose.Location = New System.Drawing.Point(157, 6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(40, 37)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "x"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton5, Me.ToolStripButton6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 96)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1337, 55)
        Me.ToolStrip1.TabIndex = 19
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.Image = Global.SRMS_BED.My.Resources.Resources.Invoice
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(188, 52)
        Me.ToolStripButton1.Text = "STUDENTS' ACCOUNTS"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ACCOUNTSToolStripMenuItem, Me.OTHERSERVICESToolStripMenuItem})
        Me.ToolStripButton3.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton3.Image = Global.SRMS_BED.My.Resources.Resources.Online_Money_Transfer
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(133, 52)
        Me.ToolStripButton3.Text = "PAYMENTS"
        '
        'ACCOUNTSToolStripMenuItem
        '
        Me.ACCOUNTSToolStripMenuItem.Name = "ACCOUNTSToolStripMenuItem"
        Me.ACCOUNTSToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ACCOUNTSToolStripMenuItem.Text = "ACCOUNTS"
        '
        'OTHERSERVICESToolStripMenuItem
        '
        Me.OTHERSERVICESToolStripMenuItem.Name = "OTHERSERVICESToolStripMenuItem"
        Me.OTHERSERVICESToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.OTHERSERVICESToolStripMenuItem.Text = "OTHER SERVICES"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SEARCHORToolStripMenuItem, Me.VOIDORToolStripMenuItem})
        Me.ToolStripButton4.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton4.Image = Global.SRMS_BED.My.Resources.Resources.Stack_of_Coins
        Me.ToolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(178, 52)
        Me.ToolStripButton4.Text = "OFFICIAL RECEIPTS"
        '
        'SEARCHORToolStripMenuItem
        '
        Me.SEARCHORToolStripMenuItem.Name = "SEARCHORToolStripMenuItem"
        Me.SEARCHORToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.SEARCHORToolStripMenuItem.Text = "SEARCH O.R."
        '
        'VOIDORToolStripMenuItem
        '
        Me.VOIDORToolStripMenuItem.Name = "VOIDORToolStripMenuItem"
        Me.VOIDORToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.VOIDORToolStripMenuItem.Text = "VOID O.R."
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FEESDESCRIPTIONToolStripMenuItem, Me.PAYMENTDESCRIPTIONToolStripMenuItem})
        Me.ToolStripButton5.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton5.Image = Global.SRMS_BED.My.Resources.Resources.Laptop_Settings
        Me.ToolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(127, 52)
        Me.ToolStripButton5.Text = "SETTINGS"
        '
        'FEESDESCRIPTIONToolStripMenuItem
        '
        Me.FEESDESCRIPTIONToolStripMenuItem.Name = "FEESDESCRIPTIONToolStripMenuItem"
        Me.FEESDESCRIPTIONToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.FEESDESCRIPTIONToolStripMenuItem.Text = "FEES DESCRIPTION"
        '
        'PAYMENTDESCRIPTIONToolStripMenuItem
        '
        Me.PAYMENTDESCRIPTIONToolStripMenuItem.Name = "PAYMENTDESCRIPTIONToolStripMenuItem"
        Me.PAYMENTDESCRIPTIONToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.PAYMENTDESCRIPTIONToolStripMenuItem.Text = "PAYMENT DESCRIPTION"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REPORTAToolStripMenuItem, Me.REPORTBToolStripMenuItem})
        Me.ToolStripButton6.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton6.Image = Global.SRMS_BED.My.Resources.Resources.Business_Report
        Me.ToolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(124, 52)
        Me.ToolStripButton6.Text = "REPORTS"
        '
        'REPORTAToolStripMenuItem
        '
        Me.REPORTAToolStripMenuItem.Name = "REPORTAToolStripMenuItem"
        Me.REPORTAToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.REPORTAToolStripMenuItem.Text = "REPORT A"
        '
        'REPORTBToolStripMenuItem
        '
        Me.REPORTBToolStripMenuItem.Name = "REPORTBToolStripMenuItem"
        Me.REPORTBToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.REPORTBToolStripMenuItem.Text = "REPORT B"
        '
        'frmAccounting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1337, 823)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel5)
        Me.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmAccounting"
        Me.ShowIcon = False
        Me.Text = "Accounting"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripSplitButton
    Friend WithEvents ACCOUNTSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OTHERSERVICESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton4 As ToolStripSplitButton
    Friend WithEvents SEARCHORToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VOIDORToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton5 As ToolStripSplitButton
    Friend WithEvents FEESDESCRIPTIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PAYMENTDESCRIPTIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton6 As ToolStripSplitButton
    Friend WithEvents REPORTAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REPORTBToolStripMenuItem As ToolStripMenuItem
End Class
