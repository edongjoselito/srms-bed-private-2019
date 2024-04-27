Imports MySql.Data.MySqlClient
Public Class frmStudeReport_Accounting
    Dim str As String
    Private Sub btnStudeReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudeReport.Click
        If mskStudentNumber.Text = "" Then
            MsgBox("Please enter Student Number!", MsgBoxStyle.Information)
            Exit Sub
            mskStudentNumber.Focus()
        End If

        Try

            'Account Tracking
            If cboStudeReport.SelectedIndex = 0 Then
                str = "Select p.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as StudentName, p.Course, s.SY, s.AcctTotal, s.TotalPayments, s.CurrentBalance, s.Discount, st.letterHead from studeprofile p join studeaccount s on p.StudentNumber=s.StudentNumber join srms_settings st on p.settingsID=st.settingsID where s.StudentNumber='" & mskStudentNumber.Text & "' and s.SY='" & frmAccounting.stSY.Text & "' group by s.StudentNumber, s.SY"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(Str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "studeprofile, studeaccount")
                Dim obj As New AcctTracking
                obj.SetDataSource(ds.Tables("studeprofile, studeaccount"))
                specialReportViewer.ReportSource = obj
                specialReportViewer.Refresh()
                conn.Close()

            End If


            'payment history
            If cboStudeReport.SelectedIndex = 1 Then
                str = "select s.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as StudentName, s.AcctTotal, s.CurrentBalance, s.Discount, s.Sem, s.SY, pa.PDate, pa.ORNumber, pa.Amount, pa.description, pa.PaymentType, pa.ORStatus, pa.Sem, pa.SY, st.letterHead, st.LedgerPreparedBy, st.LedgerPrepByPosition, st.Notes, st.financeOfficer, st.financeOfficerPosition from studeaccount s join paymentsaccounts pa on s.StudentNumber=pa.StudentNumber join studeprofile p on s.StudentNumber=p.StudentNumber join srms_settings st on s.settingsID=st.settingsID where s.StudentNumber='" & mskStudentNumber.Text & "' and pa.SY='" & frmAccounting.stSY.Text & "' and pa.ORStatus='Valid' and pa.CollectionSource!='Services' group by pa.ORNumber"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(Str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeprofile, paymentsaccounts, studeaccount")
                Dim obj As New PaymentHistory
                obj.SetDataSource(mysds.Tables("studeprofile, paymentsaccounts, studeaccount"))
                specialReportViewer.ReportSource = obj
                specialReportViewer.Refresh()
                conn.Close()

            End If

            'ledger (other servicesss)
            If cboStudeReport.SelectedIndex = 2 Then
                str = "select pa.StudentNumber, concat(FirstName,' ',MiddleName,' ',LastName) as StudentName, PDate, ORNumber, Amount, PaymentType, description, letterHead from studeprofile s join paymentsaccounts pa on s.StudentNumber=pa.StudentNumber join srms_settings st on s.settingsID=st.settingsID where pa.StudentNumber='" & mskStudentNumber.Text & "' and pa.SY='" & frmAccounting.stSY.Text & "' and pa.ORStatus='Valid' and pa.CollectionSource='Services' group by pa.ORNumber"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeprofile, paymentsaccounts")
                Dim obj As New PaymentHistoryServices
                obj.SetDataSource(mysds.Tables("studeprofile, paymentsaccounts"))
                specialReportViewer.ReportSource = obj
                specialReportViewer.Refresh()
                conn.Close()

            End If


            'Statement of Account
            If cboStudeReport.SelectedIndex = 3 Then
                str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudentName, b.OldAccount, b.FeesDesc, b.FeesAmount, b.TotalFees, b.AcctTotal, b.Discount, b.CurrentBalance, b.TotalPayments, b.Sem, b.SY from studeprofile p join studeaccount b on p.StudentNumber=b.StudentNumber where p.StudentNumber='" & mskStudentNumber.Text & "' and b.SY='" & frmAccounting.stSY.Text & "' order by b.FeesDesc"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeprofile, studeaccount, paymentsaccounts")
                Dim obj As New SOA
                obj.SetDataSource(mysds.Tables("studeprofile, studeaccount, paymentsaccounts"))
                specialReportViewer.ReportSource = obj
                specialReportViewer.Refresh()
                conn.Close()
            End If



            'Statement of Account Version 2
            If cboStudeReport.SelectedIndex = 4 Then
                str = "SELECT * FROM studeaccount s join srms_settings st on s.settingsID=st.settingsID where StudentNumber='" & mskStudentNumber.Text & "' and SY='" & frmAccounting.stSY.Text & "' order by FeesDesc"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeaccount")
                Dim obj As New DetailedAssessment
                obj.SetDataSource(mysds.Tables("studeaccount"))
                obj.SetParameterValue("DownPayment", lblDP.Text)
                specialReportViewer.ReportSource = obj
                specialReportViewer.Refresh()
                conn.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub mskStudentNumber_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskStudentNumber.Click
        frmQSearch.ShowDialog()
    End Sub
    Public Sub formload()
        lblDP.Text = 0
    End Sub
    Private Sub frmStudeReport_Accounting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formload()
        getDP()
    End Sub
    Public Sub getDP()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "SELECT Amount FROM paymentsaccounts where StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmAccounting.stSemester.Text & "' and SY='" & frmAccounting.stSY.Text & "' and ORStatus !='Void' order by ID limit 1"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lblDP.Text = dtReader.Item(0)
            Else
                lblDP.Text = 0
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub mskStudentNumber_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles mskStudentNumber.MaskInputRejected

    End Sub

    Private Sub mskStudentNumber_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles mskStudentNumber.MouseClick

    End Sub

    Private Sub mskStudentNumber_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskStudentNumber.TextChanged
        getDP()
    End Sub
End Class