<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBilling
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
        Me.components = New System.ComponentModel.Container()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtOldAccount = New System.Windows.Forms.TextBox()
        Me.txtPayments = New System.Windows.Forms.TextBox()
        Me.txtTotalAcct = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.cboYear = New System.Windows.Forms.ComboBox()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.cboCourse = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.txtMName = New System.Windows.Forms.TextBox()
        Me.txtTotalFees = New System.Windows.Forms.TextBox()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.lvAccts = New System.Windows.Forms.ListView()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnRemoveFees = New System.Windows.Forms.Button()
        Me.btnAddFees = New System.Windows.Forms.Button()
        Me.mskStudentNumber = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.btnOldAcct = New System.Windows.Forms.Button()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtSection = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblMajor = New System.Windows.Forms.Label()
        Me.lblEnrolled = New System.Windows.Forms.Label()
        Me.txtInstallmentFee = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRegFee = New System.Windows.Forms.TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsNew = New System.Windows.Forms.ToolStripButton()
        Me.tsSave = New System.Windows.Forms.ToolStripButton()
        Me.tsUpdate = New System.Windows.Forms.ToolStripButton()
        Me.tsDelete = New System.Windows.Forms.ToolStripButton()
        Me.tsViewAccounts = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BillingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel6.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.Color.Black
        Me.lblID.Location = New System.Drawing.Point(321, 28)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(22, 19)
        Me.lblID.TabIndex = 17
        Me.lblID.Text = "ID"
        Me.lblID.Visible = False
        '
        'txtOldAccount
        '
        Me.txtOldAccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOldAccount.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldAccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtOldAccount.Location = New System.Drawing.Point(218, 0)
        Me.txtOldAccount.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtOldAccount.Multiline = True
        Me.txtOldAccount.Name = "txtOldAccount"
        Me.txtOldAccount.Size = New System.Drawing.Size(134, 31)
        Me.txtOldAccount.TabIndex = 32
        Me.txtOldAccount.TabStop = False
        Me.txtOldAccount.Text = "0"
        Me.txtOldAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPayments
        '
        Me.txtPayments.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.txtPayments.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayments.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtPayments.Location = New System.Drawing.Point(218, 1)
        Me.txtPayments.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPayments.Name = "txtPayments"
        Me.txtPayments.ReadOnly = True
        Me.txtPayments.Size = New System.Drawing.Size(134, 23)
        Me.txtPayments.TabIndex = 19
        Me.txtPayments.TabStop = False
        Me.txtPayments.Text = "0"
        Me.txtPayments.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTotalAcct
        '
        Me.txtTotalAcct.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.txtTotalAcct.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAcct.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtTotalAcct.Location = New System.Drawing.Point(218, 1)
        Me.txtTotalAcct.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTotalAcct.Name = "txtTotalAcct"
        Me.txtTotalAcct.Size = New System.Drawing.Size(134, 23)
        Me.txtTotalAcct.TabIndex = 18
        Me.txtTotalAcct.TabStop = False
        Me.txtTotalAcct.Text = "0"
        Me.txtTotalAcct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCompute
        '
        Me.btnCompute.BackColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnCompute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompute.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCompute.Location = New System.Drawing.Point(464, 3)
        Me.btnCompute.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(139, 42)
        Me.btnCompute.TabIndex = 21
        Me.btnCompute.Text = "COMPUTE"
        Me.btnCompute.UseVisualStyleBackColor = False
        '
        'cboYear
        '
        Me.cboYear.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.cboYear.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYear.ForeColor = System.Drawing.Color.Black
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Location = New System.Drawing.Point(113, 3)
        Me.cboYear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(158, 23)
        Me.cboYear.TabIndex = 6
        Me.cboYear.TabStop = False
        '
        'cboStatus
        '
        Me.cboStatus.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.cboStatus.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.ForeColor = System.Drawing.Color.Black
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Paying", "Scholar"})
        Me.cboStatus.Location = New System.Drawing.Point(75, 98)
        Me.cboStatus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(69, 27)
        Me.cboStatus.TabIndex = 7
        Me.cboStatus.TabStop = False
        '
        'cboCourse
        '
        Me.cboCourse.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.cboCourse.DisplayMember = "coursedescription"
        Me.cboCourse.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCourse.ForeColor = System.Drawing.Color.Black
        Me.cboCourse.FormattingEnabled = True
        Me.cboCourse.Location = New System.Drawing.Point(113, 4)
        Me.cboCourse.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboCourse.Name = "cboCourse"
        Me.cboCourse.Size = New System.Drawing.Size(490, 23)
        Me.cboCourse.TabIndex = 5
        Me.cboCourse.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(9, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 19)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Status"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(19, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "STUDENT NO."
        '
        'txtLastName
        '
        Me.txtLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLastName.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.Color.Black
        Me.txtLastName.Location = New System.Drawing.Point(445, 4)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.ReadOnly = True
        Me.txtLastName.Size = New System.Drawing.Size(158, 23)
        Me.txtLastName.TabIndex = 4
        Me.txtLastName.TabStop = False
        '
        'txtFname
        '
        Me.txtFname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFname.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFname.ForeColor = System.Drawing.Color.Black
        Me.txtFname.Location = New System.Drawing.Point(113, 4)
        Me.txtFname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.ReadOnly = True
        Me.txtFname.Size = New System.Drawing.Size(158, 23)
        Me.txtFname.TabIndex = 2
        Me.txtFname.TabStop = False
        '
        'txtMName
        '
        Me.txtMName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMName.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMName.ForeColor = System.Drawing.Color.Black
        Me.txtMName.Location = New System.Drawing.Point(279, 4)
        Me.txtMName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMName.Name = "txtMName"
        Me.txtMName.ReadOnly = True
        Me.txtMName.Size = New System.Drawing.Size(158, 23)
        Me.txtMName.TabIndex = 3
        Me.txtMName.TabStop = False
        '
        'txtTotalFees
        '
        Me.txtTotalFees.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTotalFees.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalFees.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtTotalFees.Location = New System.Drawing.Point(218, 3)
        Me.txtTotalFees.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTotalFees.Name = "txtTotalFees"
        Me.txtTotalFees.Size = New System.Drawing.Size(134, 27)
        Me.txtTotalFees.TabIndex = 23
        Me.txtTotalFees.TabStop = False
        Me.txtTotalFees.Text = "0"
        Me.txtTotalFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBalance
        '
        Me.txtBalance.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.txtBalance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalance.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtBalance.Location = New System.Drawing.Point(218, 1)
        Me.txtBalance.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.Size = New System.Drawing.Size(134, 23)
        Me.txtBalance.TabIndex = 39
        Me.txtBalance.TabStop = False
        Me.txtBalance.Text = "0"
        Me.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lvAccts
        '
        Me.lvAccts.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvAccts.ForeColor = System.Drawing.Color.Black
        Me.lvAccts.HideSelection = False
        Me.lvAccts.Location = New System.Drawing.Point(0, 228)
        Me.lvAccts.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lvAccts.Name = "lvAccts"
        Me.lvAccts.Size = New System.Drawing.Size(607, 267)
        Me.lvAccts.TabIndex = 20
        Me.lvAccts.TabStop = False
        Me.lvAccts.UseCompatibleStateImageBehavior = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Panel6.Controls.Add(Me.btnRemoveFees)
        Me.Panel6.Controls.Add(Me.btnAddFees)
        Me.Panel6.Controls.Add(Me.btnCompute)
        Me.Panel6.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.ForeColor = System.Drawing.Color.Black
        Me.Panel6.Location = New System.Drawing.Point(0, 177)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(608, 47)
        Me.Panel6.TabIndex = 19
        '
        'btnRemoveFees
        '
        Me.btnRemoveFees.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnRemoveFees.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveFees.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveFees.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRemoveFees.Location = New System.Drawing.Point(318, 3)
        Me.btnRemoveFees.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRemoveFees.Name = "btnRemoveFees"
        Me.btnRemoveFees.Size = New System.Drawing.Size(139, 42)
        Me.btnRemoveFees.TabIndex = 2
        Me.btnRemoveFees.Text = "REMOVE FEES"
        Me.btnRemoveFees.UseVisualStyleBackColor = False
        '
        'btnAddFees
        '
        Me.btnAddFees.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnAddFees.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddFees.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddFees.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAddFees.Location = New System.Drawing.Point(171, 3)
        Me.btnAddFees.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAddFees.Name = "btnAddFees"
        Me.btnAddFees.Size = New System.Drawing.Size(139, 42)
        Me.btnAddFees.TabIndex = 1
        Me.btnAddFees.Text = "ADD FEES"
        Me.btnAddFees.UseVisualStyleBackColor = False
        '
        'mskStudentNumber
        '
        Me.mskStudentNumber.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskStudentNumber.Location = New System.Drawing.Point(113, 3)
        Me.mskStudentNumber.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.mskStudentNumber.Name = "mskStudentNumber"
        Me.mskStudentNumber.ReadOnly = True
        Me.mskStudentNumber.Size = New System.Drawing.Size(158, 23)
        Me.mskStudentNumber.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(2, 65)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(998, 532)
        Me.TabControl1.TabIndex = 22
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.Panel9)
        Me.TabPage1.Controls.Add(Me.Panel5)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.Panel8)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.lblID)
        Me.TabPage1.Controls.Add(Me.lvAccts)
        Me.TabPage1.Controls.Add(Me.Panel6)
        Me.TabPage1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Size = New System.Drawing.Size(990, 504)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ACCOUNT DETAILS"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Panel20)
        Me.GroupBox3.Controls.Add(Me.Panel15)
        Me.GroupBox3.Controls.Add(Me.Panel14)
        Me.GroupBox3.Controls.Add(Me.Panel13)
        Me.GroupBox3.Controls.Add(Me.Panel12)
        Me.GroupBox3.Controls.Add(Me.Panel11)
        Me.GroupBox3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(615, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(367, 478)
        Me.GroupBox3.TabIndex = 61
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ACCOUNT SUMMARY"
        '
        'Panel20
        '
        Me.Panel20.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel20.Controls.Add(Me.Label28)
        Me.Panel20.Controls.Add(Me.txtTotalFees)
        Me.Panel20.Location = New System.Drawing.Point(10, 80)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(357, 33)
        Me.Panel20.TabIndex = 58
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(16, 8)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(66, 15)
        Me.Label28.TabIndex = 1
        Me.Label28.Text = "TOTAL FEES"
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel15.Controls.Add(Me.txtOldAccount)
        Me.Panel15.Controls.Add(Me.btnOldAcct)
        Me.Panel15.Location = New System.Drawing.Point(10, 43)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(357, 33)
        Me.Panel15.TabIndex = 58
        '
        'btnOldAcct
        '
        Me.btnOldAcct.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOldAcct.ForeColor = System.Drawing.Color.Black
        Me.btnOldAcct.Location = New System.Drawing.Point(112, 0)
        Me.btnOldAcct.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnOldAcct.Name = "btnOldAcct"
        Me.btnOldAcct.Size = New System.Drawing.Size(99, 30)
        Me.btnOldAcct.TabIndex = 22
        Me.btnOldAcct.TabStop = False
        Me.btnOldAcct.Text = "View Old Acct."
        Me.ToolTip1.SetToolTip(Me.btnOldAcct, "Old Account")
        Me.btnOldAcct.UseVisualStyleBackColor = True
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel14.Controls.Add(Me.Label15)
        Me.Panel14.Controls.Add(Me.txtBalance)
        Me.Panel14.Location = New System.Drawing.Point(7, 441)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(357, 33)
        Me.Panel14.TabIndex = 61
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(16, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(106, 15)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "CURRENT BALANCE"
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel13.Controls.Add(Me.Label12)
        Me.Panel13.Controls.Add(Me.txtPayments)
        Me.Panel13.Location = New System.Drawing.Point(7, 403)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(357, 33)
        Me.Panel13.TabIndex = 60
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(16, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 15)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "TOTAL PAYMENTS"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel12.Controls.Add(Me.Label19)
        Me.Panel12.Controls.Add(Me.txtTotalAcct)
        Me.Panel12.Location = New System.Drawing.Point(7, 326)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(357, 33)
        Me.Panel12.TabIndex = 59
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(16, 8)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(94, 15)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "TOTAL ACCOUNT"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel11.Controls.Add(Me.Label22)
        Me.Panel11.Controls.Add(Me.txtDiscount)
        Me.Panel11.Location = New System.Drawing.Point(7, 364)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(357, 33)
        Me.Panel11.TabIndex = 58
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(16, 8)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(63, 15)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "DISCOUNT"
        '
        'txtDiscount
        '
        Me.txtDiscount.BackColor = System.Drawing.Color.White
        Me.txtDiscount.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.ForeColor = System.Drawing.Color.Black
        Me.txtDiscount.Location = New System.Drawing.Point(218, 1)
        Me.txtDiscount.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(134, 23)
        Me.txtDiscount.TabIndex = 40
        Me.txtDiscount.TabStop = False
        Me.txtDiscount.Text = "0"
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel9.Controls.Add(Me.Label6)
        Me.Panel9.Controls.Add(Me.cboYear)
        Me.Panel9.Controls.Add(Me.Label34)
        Me.Panel9.Controls.Add(Me.txtSection)
        Me.Panel9.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel9.Location = New System.Drawing.Point(0, 137)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(608, 33)
        Me.Panel9.TabIndex = 59
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(19, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 15)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "GRADE LEVEL"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(381, 8)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(53, 15)
        Me.Label34.TabIndex = 42
        Me.Label34.Text = "SECTION"
        '
        'txtSection
        '
        Me.txtSection.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSection.Location = New System.Drawing.Point(445, 4)
        Me.txtSection.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.ReadOnly = True
        Me.txtSection.Size = New System.Drawing.Size(158, 23)
        Me.txtSection.TabIndex = 43
        Me.txtSection.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.cboCourse)
        Me.Panel5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(0, 99)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(608, 33)
        Me.Panel5.TabIndex = 60
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(19, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DEPARTMENT"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblMajor)
        Me.GroupBox2.Controls.Add(Me.lblEnrolled)
        Me.GroupBox2.Controls.Add(Me.txtInstallmentFee)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Panel10)
        Me.GroupBox2.Controls.Add(Me.cboStatus)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(385, 8)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(138, 40)
        Me.GroupBox2.TabIndex = 55
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Hidden Controls"
        Me.GroupBox2.Visible = False
        '
        'lblMajor
        '
        Me.lblMajor.AutoSize = True
        Me.lblMajor.Location = New System.Drawing.Point(33, 53)
        Me.lblMajor.Name = "lblMajor"
        Me.lblMajor.Size = New System.Drawing.Size(41, 15)
        Me.lblMajor.TabIndex = 56
        Me.lblMajor.Text = "Major"
        '
        'lblEnrolled
        '
        Me.lblEnrolled.AutoSize = True
        Me.lblEnrolled.Location = New System.Drawing.Point(33, 80)
        Me.lblEnrolled.Name = "lblEnrolled"
        Me.lblEnrolled.Size = New System.Drawing.Size(53, 15)
        Me.lblEnrolled.TabIndex = 50
        Me.lblEnrolled.Text = "Enrolled"
        Me.lblEnrolled.Visible = False
        '
        'txtInstallmentFee
        '
        Me.txtInstallmentFee.BackColor = System.Drawing.Color.Chartreuse
        Me.txtInstallmentFee.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInstallmentFee.Location = New System.Drawing.Point(8, 253)
        Me.txtInstallmentFee.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtInstallmentFee.Name = "txtInstallmentFee"
        Me.txtInstallmentFee.Size = New System.Drawing.Size(162, 30)
        Me.txtInstallmentFee.TabIndex = 54
        Me.txtInstallmentFee.TabStop = False
        Me.txtInstallmentFee.Text = "0.00"
        Me.txtInstallmentFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(8, 219)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(96, 19)
        Me.Label17.TabIndex = 53
        Me.Label17.Text = "Installment Fee"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel10.Controls.Add(Me.Label2)
        Me.Panel10.Controls.Add(Me.txtRegFee)
        Me.Panel10.Location = New System.Drawing.Point(13, 304)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(199, 33)
        Me.Panel10.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Registration Fee"
        '
        'txtRegFee
        '
        Me.txtRegFee.BackColor = System.Drawing.Color.White
        Me.txtRegFee.Font = New System.Drawing.Font("Segoe Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegFee.ForeColor = System.Drawing.Color.Black
        Me.txtRegFee.Location = New System.Drawing.Point(218, 1)
        Me.txtRegFee.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRegFee.Name = "txtRegFee"
        Me.txtRegFee.Size = New System.Drawing.Size(134, 30)
        Me.txtRegFee.TabIndex = 45
        Me.txtRegFee.TabStop = False
        Me.txtRegFee.Text = "00.00"
        Me.txtRegFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel8.Controls.Add(Me.Label11)
        Me.Panel8.Controls.Add(Me.txtFname)
        Me.Panel8.Controls.Add(Me.txtMName)
        Me.Panel8.Controls.Add(Me.txtLastName)
        Me.Panel8.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel8.Location = New System.Drawing.Point(0, 60)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(608, 33)
        Me.Panel8.TabIndex = 59
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(19, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 15)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "STUDENT NAME"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.mskStudentNumber)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 22)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(277, 33)
        Me.Panel2.TabIndex = 58
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsNew, Me.tsSave, Me.tsUpdate, Me.tsDelete, Me.tsViewAccounts})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1000, 52)
        Me.ToolStrip1.TabIndex = 42
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsNew
        '
        Me.tsNew.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsNew.Image = Global.SRMS_BED.My.Resources.Resources.New_Copy
        Me.tsNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsNew.Name = "tsNew"
        Me.tsNew.Size = New System.Drawing.Size(37, 49)
        Me.tsNew.Text = "NEW"
        Me.tsNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsNew.ToolTipText = "New (Ctrl + N)"
        '
        'tsSave
        '
        Me.tsSave.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsSave.Image = Global.SRMS_BED.My.Resources.Resources.Save
        Me.tsSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSave.Name = "tsSave"
        Me.tsSave.Size = New System.Drawing.Size(36, 49)
        Me.tsSave.Text = "SAVE"
        Me.tsSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsSave.ToolTipText = "Save (Ctrl + S)"
        '
        'tsUpdate
        '
        Me.tsUpdate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsUpdate.Image = Global.SRMS_BED.My.Resources.Resources.Save_as_30px
        Me.tsUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsUpdate.Name = "tsUpdate"
        Me.tsUpdate.Size = New System.Drawing.Size(52, 49)
        Me.tsUpdate.Text = "UPDATE"
        Me.tsUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsUpdate.ToolTipText = "Update (Ctrl + U)"
        '
        'tsDelete
        '
        Me.tsDelete.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsDelete.Image = Global.SRMS_BED.My.Resources.Resources.Delete_Document_30px
        Me.tsDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDelete.Name = "tsDelete"
        Me.tsDelete.Size = New System.Drawing.Size(48, 49)
        Me.tsDelete.Text = "DELETE"
        Me.tsDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsViewAccounts
        '
        Me.tsViewAccounts.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsViewAccounts.Image = Global.SRMS_BED.My.Resources.Resources.View_30px
        Me.tsViewAccounts.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsViewAccounts.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsViewAccounts.Name = "tsViewAccounts"
        Me.tsViewAccounts.Size = New System.Drawing.Size(101, 49)
        Me.tsViewAccounts.Text = "VIEW ACCOUNTS"
        Me.tsViewAccounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsViewAccounts.ToolTipText = "View Accounts (Ctrl + F)"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BillingToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1307, 35)
        Me.MenuStrip1.TabIndex = 43
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'BillingToolStripMenuItem
        '
        Me.BillingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.SaveToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.BillingToolStripMenuItem.Name = "BillingToolStripMenuItem"
        Me.BillingToolStripMenuItem.Size = New System.Drawing.Size(52, 29)
        Me.BillingToolStripMenuItem.Text = "Billing"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'frmBilling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1000, 598)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmBilling"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "::"
        Me.Panel6.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.Panel20.ResumeLayout(False)
        Me.Panel20.PerformLayout()
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents cboYear As System.Windows.Forms.ComboBox
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cboCourse As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFname As System.Windows.Forms.TextBox
    Friend WithEvents txtMName As System.Windows.Forms.TextBox
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents txtPayments As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalAcct As System.Windows.Forms.TextBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents lvAccts As System.Windows.Forms.ListView
    Friend WithEvents btnAddFees As System.Windows.Forms.Button
    Friend WithEvents btnRemoveFees As System.Windows.Forms.Button
    Friend WithEvents txtTotalFees As System.Windows.Forms.TextBox
    Friend WithEvents txtOldAccount As System.Windows.Forms.TextBox
    Friend WithEvents txtBalance As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnOldAcct As System.Windows.Forms.Button
    Friend WithEvents txtSection As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtRegFee As System.Windows.Forms.TextBox
    Friend WithEvents mskStudentNumber As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsUpdate As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsViewAccounts As System.Windows.Forms.ToolStripButton
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BillingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblEnrolled As System.Windows.Forms.Label
    Friend WithEvents tsDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtInstallmentFee As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblMajor As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Panel20 As System.Windows.Forms.Panel
    Friend WithEvents Label28 As System.Windows.Forms.Label
End Class
