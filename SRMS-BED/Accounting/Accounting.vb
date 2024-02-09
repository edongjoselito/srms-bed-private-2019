Imports MySql.Data.MySqlClient
Public Class frmAccounting
    Dim str As String
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If lblAccountLevel.Text = "Super Admin" Then
            Me.Close()
        ElseIf lblAccountLevel.Text = "Admin" Then
            Me.Close()
        Else
            End
        End If
    End Sub

    Private Sub FEESDESCRIPTIONToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmFees.ShowDialog()
    End Sub

    Private Sub FEESDESCRIPTIONToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles tsFeesDescription.Click
        frmFees.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles tsAcccounts.Click
        frmBilling.ShowDialog()
    End Sub

    Private Sub ACCOUNTSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACCOUNTSToolStripMenuItem.Click
        frmPayment.Show()
    End Sub

    Private Sub OTHERSERVICESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OTHERSERVICESToolStripMenuItem.Click
        frmOtherIncome.Show()
    End Sub

    Public Sub formLoad()
        stDate.Text = Today
        crViewer.Visible = False
        schoolInfo()
    End Sub
    Public Sub schoolInfo()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select * from srms_settings limit 1"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lblSettingsID.Text = dtReader(0)
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub ReloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadToolStripMenuItem.Click
        formLoad()
    End Sub


    Private Sub frmAccounting_Load(sender As Object, e As EventArgs) Handles Me.Load
        formLoad()
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        formLoad()
    End Sub

    Private Sub VOIDORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VOIDORToolStripMenuItem.Click
        frmVoidOR.ShowDialog()
    End Sub

    Private Sub SEARCHORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SEARCHORToolStripMenuItem.Click
        frmSearchOR.ShowDialog()
    End Sub

    Private Sub REPORTAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REPORTAToolStripMenuItem.Click
        frmStudeReport_Accounting.ShowDialog()
    End Sub

    Private Sub SWITCHSEMESTERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SWITCHSEMESTERToolStripMenuItem.Click
        frmSemChoiceV2.ShowDialog()
    End Sub

    Private Sub BYCASHIERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BYCASHIERToolStripMenuItem.Click
        frmCollectionSummaryDashboard.Show()
    End Sub

    Private Sub BYDATEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BYDATEToolStripMenuItem.Click
        frmCollectionDashboard.ShowDialog()
    End Sub

    Private Sub BYDESCRIPTIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BYDESCRIPTIONToolStripMenuItem.Click
        frmByDescription.Show()
    End Sub

    Private Sub STUDENTSWITHBALANCEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles STUDENTSWITHBALANCEToolStripMenuItem.Click
        Try
            str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName) as Fullname, b.AcctTotal, b.TotalPayments, b.Discount, b.CurrentBalance, b.Course, b.YearLevel, b.Section, b.SY, st.letterHead, p.MobileNumber  from studeprofile p join studeaccount b on p.StudentNumber=b.StudentNumber join srms_settings st on p.settingsID=st.settingsID where b.Sem='" & stSemester.Text & "' and b.SY='" & stSY.Text & "' and b.CurrentBalance>'0' group by b.YearLevel, p.LastName order by Fullname"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysda.Fill(mysds, "b.studeaccount, p.studeprofile")
            Dim obj As New StudeAccountsBalances
            obj.SetDataSource(mysds.Tables("b.studeaccount, p.studeprofile"))
            crViewer.ReportSource = obj
            conn.Close()
            crViewer.Visible = True

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub LISTOFVOIDRECEIPTSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LISTOFVOIDRECEIPTSToolStripMenuItem.Click
        frmVoidReport.ShowDialog()
    End Sub

    Private Sub STUDENTSACCOUNTSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles STUDENTSACCOUNTSToolStripMenuItem.Click
        frmStudeAccount.Show()
    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub EXPENSESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXPENSESToolStripMenuItem.Click
        frmExpenses.ShowDialog()
    End Sub

    Private Sub EXPENSESREPORTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXPENSESREPORTToolStripMenuItem.Click
        frmExpReportDashobard.ShowDialog()
    End Sub
End Class