Imports MySql.Data.MySqlClient
Public Class frmSearchBilling
    Dim str As String

    Private Sub frmSearchBilling_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad()
    End Sub
    Public Sub FormLoad()
        Try
            str = "SELECT AccountID, p.StudentNumber, FirstName, MiddleName, LastName, s.Course, YearLevel, Status, OldAccount, FeesDesc, FeesAmount, TotalFees, Discount, AcctTotal, TotalPayments, CurrentBalance, Sem, SY, Section FROM studeaccount s join studeprofile p on s.StudentNumber=p.StudentNumber where SY='" & frmAccounting.stSY.Text & "' and Sem='" & frmAccounting.stSemester.Text & "' group by StudentNumber"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeaccount, studeprofile")
            dg1.DataSource = ds.Tables("studeaccount, studeprofile")
            conn.Close()
            dg1.Columns(0).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "SELECT AccountID, p.StudentNumber, FirstName, MiddleName, LastName, s.Course, YearLevel, Status, OldAccount, FeesDesc, FeesAmount, TotalFees, Discount, AcctTotal, TotalPayments, CurrentBalance, Sem, SY, Section FROM studeaccount s join studeprofile p on s.StudentNumber=p.StudentNumber where (p.StudentNumber like '%" & txtSearch.Text & "%' or p.LastName like '%" & txtSearch.Text & "%') and SY='" & frmAccounting.stSY.Text & "' and Sem='" & frmAccounting.stSemester.Text & "' group by p.StudentNumber"
            conn.Open()
            Dim Search As New MySqlDataAdapter(str, conn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "studeaccount, studeprofile")
            dg1.DataSource = ds.Tables("studeaccount, studeprofile")
            conn.Close()
            dg1.Columns(0).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        txtSearch.Clear()
        Me.Close()
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Try
           
            Dim n As Integer
            n = dg1.CurrentRow.Index

            frmBilling.lblID.Text = dg1.Item(0, n).Value
            frmBilling.mskStudentNumber.Text = dg1.Item(1, n).Value
            frmBilling.txtFname.Text = dg1.Item(2, n).Value
            frmBilling.txtMName.Text = dg1.Item(3, n).Value
            frmBilling.txtLastName.Text = dg1.Item(4, n).Value
            frmBilling.cboCourse.Text = dg1.Item(5, n).Value
            frmBilling.cboYear.Text = dg1.Item(6, n).Value
            frmBilling.cboStatus.Text = dg1.Item(7, n).Value
            frmBilling.txtOldAccount.Text = dg1.Item(8, n).Value
            frmBilling.txtTotalFees.Text = dg1.Item(11, n).Value
            frmBilling.txtDiscount.Text = dg1.Item(12, n).Value
            frmBilling.txtTotalAcct.Text = dg1.Item(13, n).Value
            frmBilling.txtPayments.Text = dg1.Item(14, n).Value
            frmBilling.txtBalance.Text = dg1.Item(15, n).Value

            Dim totalpayment As Double

            str = "select Amount from paymentsaccounts where StudentNumber='" & frmBilling.mskStudentNumber.Text & "' and SY='" & frmAccounting.stSY.Text & "' and ORStatus='Valid' and CollectionSource!='Services'"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            Dim mysDR As MySqlDataReader = mysC.ExecuteReader

            While mysDR.Read
                totalpayment += Val(mysDR(0))
            End While

            frmBilling.txtPayments.Text = Format(totalpayment, "00.00")
            mysDR.Close()
            conn.Close()

            frmBilling.btnCompute.PerformClick()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

        frmBilling.tsSave.Enabled = False
        frmBilling.tsUpdate.Enabled = True
        frmBilling.tsDelete.Enabled = True
        frmBilling.tsNew.Enabled = True
        frmBilling.btnOldAcct.Enabled = True
        frmBilling.LoadAcct()
        txtSearch.Clear()

        frmBilling.btnOldAcct.Enabled = False

        Me.Close()
    End Sub

End Class