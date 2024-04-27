<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdvisers
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dg1 = New System.Windows.Forms.DataGridView()
        Me.cboYearLevel = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.txtAdviser = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnDelete = New FontAwesome.Sharp.IconButton()
        Me.btnSave = New FontAwesome.Sharp.IconButton()
        Me.txtSection = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblIDNumber = New System.Windows.Forms.Label()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'dg1
        '
        Me.dg1.AllowUserToAddRows = False
        Me.dg1.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray
        Me.dg1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg1.Location = New System.Drawing.Point(492, 162)
        Me.dg1.Name = "dg1"
        Me.dg1.ReadOnly = True
        Me.dg1.RowHeadersWidth = 51
        Me.dg1.RowTemplate.Height = 24
        Me.dg1.Size = New System.Drawing.Size(649, 500)
        Me.dg1.TabIndex = 22
        Me.dg1.TabStop = False
        '
        'cboYearLevel
        '
        Me.cboYearLevel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboYearLevel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboYearLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYearLevel.FormattingEnabled = True
        Me.cboYearLevel.Items.AddRange(New Object() {"", "Elementary", "Junior High School", "Senior High School"})
        Me.cboYearLevel.Location = New System.Drawing.Point(119, 75)
        Me.cboYearLevel.Name = "cboYearLevel"
        Me.cboYearLevel.Size = New System.Drawing.Size(352, 25)
        Me.cboYearLevel.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblIDNumber)
        Me.GroupBox1.Controls.Add(Me.btnSelect)
        Me.GroupBox1.Controls.Add(Me.txtAdviser)
        Me.GroupBox1.Controls.Add(Me.cboYearLevel)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblID)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.txtSection)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 162)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(477, 500)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATA ENTRY"
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnSelect.FlatAppearance.BorderSize = 0
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelect.Location = New System.Drawing.Point(426, 112)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(45, 24)
        Me.btnSelect.TabIndex = 18
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'txtAdviser
        '
        Me.txtAdviser.Location = New System.Drawing.Point(119, 110)
        Me.txtAdviser.Name = "txtAdviser"
        Me.txtAdviser.ReadOnly = True
        Me.txtAdviser.Size = New System.Drawing.Size(301, 24)
        Me.txtAdviser.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "ADVISER"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "YEAR LEVEL"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(23, 304)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(21, 17)
        Me.lblID.TabIndex = 6
        Me.lblID.Text = "ID"
        Me.lblID.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnDelete.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnDelete.IconColor = System.Drawing.Color.Black
        Me.btnDelete.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDelete.Location = New System.Drawing.Point(261, 349)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(102, 37)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.TabStop = False
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnSave.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnSave.IconColor = System.Drawing.Color.Black
        Me.btnSave.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(369, 349)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(102, 37)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtSection
        '
        Me.txtSection.Location = New System.Drawing.Point(119, 45)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.Size = New System.Drawing.Size(352, 24)
        Me.txtSection.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "SECTION"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 146)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1147, 10)
        Me.Panel7.TabIndex = 19
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SRMS_BED.My.Resources.Resources.Search_Contacts
        Me.PictureBox1.Location = New System.Drawing.Point(24, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 49)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 86)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1147, 60)
        Me.Panel1.TabIndex = 21
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(910, 19)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(225, 24)
        Me.txtSearch.TabIndex = 1
        Me.txtSearch.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(839, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "SEARCH"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1147, 86)
        Me.Panel5.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(82, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ADVISERS"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnClose)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(947, 0)
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
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "x"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblIDNumber
        '
        Me.lblIDNumber.AutoSize = True
        Me.lblIDNumber.Location = New System.Drawing.Point(23, 190)
        Me.lblIDNumber.Name = "lblIDNumber"
        Me.lblIDNumber.Size = New System.Drawing.Size(70, 17)
        Me.lblIDNumber.TabIndex = 19
        Me.lblIDNumber.Text = "ID Number"
        Me.lblIDNumber.Visible = False
        '
        'frmAdvisers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1147, 665)
        Me.Controls.Add(Me.dg1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel5)
        Me.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmAdvisers"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "::"
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dg1 As DataGridView
    Friend WithEvents cboYearLevel As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblID As Label
    Friend WithEvents btnDelete As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSave As FontAwesome.Sharp.IconButton
    Friend WithEvents txtSection As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents txtAdviser As TextBox
    Friend WithEvents btnSelect As Button
    Friend WithEvents lblIDNumber As Label
End Class
