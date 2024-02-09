Imports MySql.Data.MySqlClient
Public Class frmBilling
    Dim str As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFees.Click
        frmAddFees.ShowDialog()
    End Sub

    Private Sub frmBilling_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lvAccts.Columns.Add("Description", 400)
        lvAccts.Columns.Add("Amount", 100)
        Me.lvAccts.View = View.Details
        Me.lvAccts.GridLines = True


        tsSave.Enabled = False
        tsUpdate.Enabled = False

        Formload()

     
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveFees.Click
        Try
            Dim i As Integer

            lvAccts.Select()

            If lvAccts.Items.Count = 0 Then
                MsgBox("Cannot find any data to remove", MsgBoxStyle.Information)
                Exit Sub

            Else
                i = lvAccts.FocusedItem.Index
                lvAccts.Items.RemoveAt(i)
            End If

            btnCompute.PerformClick()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

    End Sub

    Public Sub getSubTotals()
        Dim SubTotal As Double
        For x As Integer = 0 To lvAccts.Items.Count - 1
            SubTotal += Val(lvAccts.Items(x).SubItems(1).Text)
        Next

        txtTotalFees.Text = Format(SubTotal, "0.00")

    End Sub

    Public Sub getTotalAccount()
        Dim TotalAccount As Double
        TotalAccount = (Val(txtTotalFees.Text) + Val(txtRegFee.Text) + Val(txtInstallmentFee.Text))
        txtTotalAcct.Text = Format(TotalAccount, "0.00")

    End Sub

    Public Sub getBalance()
        Dim Balance As Double
        Balance = (Val(txtTotalAcct.Text) + Val(txtOldAccount.Text)) - (Val(txtPayments.Text) + Val(txtDiscount.Text))
        txtBalance.Text = Format(Balance, "0.00")
    End Sub

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click
        getSubTotals()
        'getTuition()
        'getDiscount()
        getTotalAccount()
        getBalance()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SearchAccounts.ShowDialog()
    End Sub

    Private Sub mskStudentNumber_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        SearchAccounts.ShowDialog()
    End Sub

    Private Sub txtDiscountPerecentage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        getBalance()
    End Sub

    Public Sub Formload()
        lvAccts.Items.Clear()
        mskStudentNumber.Clear()
        txtFname.Clear()
        txtMName.Clear()
        txtLastName.Clear()
        cboCourse.ResetText()
        cboYear.ResetText()
        cboStatus.ResetText()

        txtInstallmentFee.Text = 0
        txtRegFee.Text = 0
        txtTotalAcct.Text = 0
        txtPayments.Text = 0
        txtOldAccount.Text = 0

        txtBalance.Text = 0
        txtOldAccount.Text = 0
        txtTotalFees.Text = 0
        txtTotalAcct.Text = 0
        txtBalance.Text = 0

        tsNew.Enabled = True
        tsSave.Enabled = False
        tsUpdate.Enabled = False
        tsDelete.Enabled = False


        btnCompute.PerformClick()


    End Sub

    Private Sub btnPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmPayment.ShowDialog()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSearchBilling.ShowDialog()
    End Sub

    Private Sub NewAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SearchAccounts.ShowDialog()
    End Sub
    Private Sub txtTuition_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        getTotalAccount()
    End Sub

    Private Sub txtLab_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        getTotalAccount()
    End Sub

    Private Sub txtTotalAcct_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotalAcct.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtTotalAcct_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalAcct.TextChanged
        getBalance()
    End Sub

    Private Sub txtDiscount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        getBalance()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOldAcct.Click
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select CurrentBalance from studeaccount where StudentNumber='" & mskStudentNumber.Text & "' order by AccountID desc limit 1"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                txtOldAccount.Text = Format(dtReader.Item(0), "0.0")
            End If
            conn.Close()

            btnCompute.PerformClick()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lvAccts.Clear()
    End Sub
    Private Sub txtRegFee_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRegFee.TextChanged
        getTotalAccount()
    End Sub
    Private Sub tsNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsNew.Click
        lvAccts.Items.Clear()
        Formload()
        SearchAccounts.ShowDialog()
    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try

            If mskStudentNumber.Text = "" Then
                MsgBox("Student No. is missing!", MsgBoxStyle.Information)
                mskStudentNumber.Focus()
                Exit Sub
            End If

            str = "select * from studeaccount where StudentNumber ='" & mskStudentNumber.Text & "' and Sem='" & frmAccounting.stSemester.Text & "' and SY='" & frmAccounting.stSY.Text & "'"
            conn.Open()
            Dim mysDA1 As New MySqlDataAdapter(str, conn)
            Dim ds1 As New DataSet

            mysDA1.Fill(ds1, "studeaccount")

            If ds1.Tables("studeaccount").Rows.Count > 0 Then

                MsgBox("Cannot save this account.  Student number already exist!", MsgBoxStyle.Critical)
                conn.Close()
                Exit Sub

            End If

            conn.Close()

            If lvAccts.Items.Count = 0 Then
                MsgBox("No Fees Added!", MsgBoxStyle.Critical)
                Exit Sub
            End If

            For i As Integer = 0 To lvAccts.Items.Count - 1
                str = "insert into studeaccount values('0','" & mskStudentNumber.Text & "','" & cboCourse.Text & "','" & cboYear.Text & "','" & cboStatus.Text & "','" & txtOldAccount.Text & "','" & lvAccts.Items(i).SubItems(0).Text.Replace("'", "''") & "','" & lvAccts.Items(i).SubItems(1).Text & "','" & txtTotalFees.Text & "','" & txtDiscount.Text & "','" & txtTotalAcct.Text & "','" & txtPayments.Text & "','" & txtBalance.Text & "','" & frmAccounting.stSemester.Text & "','" & frmAccounting.stSY.Text & "','" & txtSection.Text & "','" & frmAccounting.lblSettingsID.Text & "')"
                conn.Open()
                Dim mysC As New MySqlCommand(str, conn)
                mysC.ExecuteNonQuery()
                conn.Close()
            Next

            MsgBox("Record Saved!!", MsgBoxStyle.Information)

            Formload()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
    Private Sub tsUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsUpdate.Click
        Try
            str = "delete from studeaccount where StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmAccounting.stSemester.Text & "' and SY='" & frmAccounting.stSY.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()

            str = "select * from studeaccount where StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmAccounting.stSemester.Text & "' and SY='" & frmAccounting.stSY.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeaccount")

            If ds.Tables("studeaccount").Rows.Count = 1 Then
                MsgBox("Student Number already exist!", MsgBoxStyle.Information)
                conn.Close()
                mskStudentNumber.Focus()
                Exit Sub
            End If
            conn.Close()

            If mskStudentNumber.Text = "" Then
                MsgBox("Student No. is missing!", MsgBoxStyle.Information)
                mskStudentNumber.Focus()
                Exit Sub
            End If

            For i As Integer = 0 To lvAccts.Items.Count - 1
                str = "insert into studeaccount values('0','" & mskStudentNumber.Text & "','" & cboCourse.Text & "','" & cboYear.Text & "','" & cboStatus.Text & "','" & txtOldAccount.Text & "','" & lvAccts.Items(i).SubItems(0).Text.Replace("'", "''") & "','" & lvAccts.Items(i).SubItems(1).Text & "','" & txtTotalFees.Text & "','" & txtDiscount.Text & "','" & txtTotalAcct.Text & "','" & txtPayments.Text & "','" & txtBalance.Text & "','" & frmAccounting.stSemester.Text & "','" & frmAccounting.stSY.Text & "','" & txtSection.Text & "','" & frmAccounting.lblSettingsID.Text & "')"
                conn.Open()
                Dim mysC1 As New MySqlCommand(str, conn)
                mysC1.ExecuteNonQuery()
                conn.Close()
            Next
            MsgBox("Record Saved!!", MsgBoxStyle.Information)
            Formload()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub tsViewAccounts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsViewAccounts.Click
        Try
            Formload()
            lvAccts.Items.Clear()
            frmSearchBilling.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        tsNew.PerformClick()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        tsSave.PerformClick()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateToolStripMenuItem.Click
        tsUpdate.PerformClick()
    End Sub

    Private Sub ViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewToolStripMenuItem.Click
        tsViewAccounts.PerformClick()
    End Sub
    Public Sub LoadFees()
        Try
            Dim dt As New DataTable
            str = "SELECT * FROM fees where Course='" & cboCourse.Text & "' and YearLevel='" & cboYear.Text & "' and SY='" & frmAccounting.stSY.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            mysda.Fill(dt)
            Dim newrow As DataRow
            For Each newrow In dt.Rows
                lvAccts.Items.Add(newrow.Item(1)) '
                lvAccts.Items(lvAccts.Items.Count - 1).SubItems.Add(newrow.Item(2))
            Next
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Public Sub LoadAcct()
        Try

            Dim dt As New DataTable
            str = "SELECT * FROM studeaccount where StudentNumber='" & mskStudentNumber.Text & "' and SY='" & frmAccounting.stSY.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            mysda.Fill(dt)
            Dim newrow As DataRow
            For Each newrow In dt.Rows
                lvAccts.Items.Add(newrow.Item(6)) '
                lvAccts.Items(lvAccts.Items.Count - 1).SubItems.Add(newrow.Item(7))
            Next
            conn.Close()
            btnCompute.PerformClick()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub tsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this account?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from studeaccount where StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmAccounting.stSemester.Text & "' and SY='" & frmAccounting.stSY.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()

                MsgBox("Selected account has been deleted!", MsgBoxStyle.Information)
                conn.Close()
                Formload()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub cboPaymentMode_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'Dim plan As Double
            '  str = "select * from installmentfee where Course='" & cboCourse.Text & "' and YearLevel='" & cboYear.Text & "' and Plan='" & cboPaymentMode.Text & "'"
            ' conn.Open()
            ' Dim mysC As New MySqlCommand(str, conn)
            ' Dim mysDR As MySqlDataReader = mysC.ExecuteReader

            '  While mysDR.Read
            'totalpayment += Val(mysDR(7))
            'plan = Val(mysDR(4))
            '  End While
            '  txtInstallmentFee.Text = Format(plan, "00.00")

            ' mysDR.Close()
            ' conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub txtInstallmentFee_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInstallmentFee.TextChanged
        getTotalAccount()
    End Sub

    Private Sub txtDiscount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiscount.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtDiscount_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiscount.TextChanged
        getTotalAccount()
        getBalance()
    End Sub


    Private Sub txtTotalFees_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotalFees.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtOldAccount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOldAccount.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub

End Class