Imports MySql.Data.MySqlClient
Public Class frmRegistrar
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

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frmStudeProfile.ShowDialog()
    End Sub

    Private Sub frmRegistrar_Load(sender As Object, e As EventArgs) Handles Me.Load
        formLoad()
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        stTime.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        frmSemStudent.ShowDialog()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        frmCOR.Show()
    End Sub

    Private Sub BYSUBJECTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BYSUBJECTToolStripMenuItem.Click
        frmMasterList.Show()
    End Sub

    Private Sub BYDEPARTMENTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BYDEPARTMENTToolStripMenuItem.Click
        frmMasterlistDashboardbyCourse.ShowDialog()
    End Sub

    Private Sub BYSECTIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BYSECTIONToolStripMenuItem.Click
        frmReportPerSection.ShowDialog()
    End Sub

    Private Sub BYSPECIALIZATIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BYSPECIALIZATIONToolStripMenuItem.Click
        frmPerSpecialization.Show()
    End Sub



    Private Sub SWITCHSEMESTERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SWITCHSEMESTERToolStripMenuItem.Click
        frmSemChoiceV2.ShowDialog()
    End Sub

    Private Sub MODIFYGRADESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MODIFYGRADESToolStripMenuItem.Click
        frmModifyGrades.ShowDialog()
    End Sub

    Public Sub formLoad()
        stDate.Text = Today
        'stTime.Text = TimeOfDay.ToString("h:mm:ss tt")
        Timer1.Enabled = True
        schoolInfo()

        crViewer.Hide()
        Panel3.Hide()

    End Sub

    Private Sub ReloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadToolStripMenuItem.Click
        formLoad
    End Sub

    Private Sub SubjectEnlistmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubjectEnlistmentToolStripMenuItem.Click
        frmCOR.Show()
    End Sub

    Private Sub EnrollmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnrollmentToolStripMenuItem.Click
        frmSemStudent.ShowDialog()
    End Sub

    Private Sub StudentProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentProfileToolStripMenuItem.Click
        frmStudeProfile.ShowDialog()
    End Sub


    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        formLoad()
    End Sub

    Private Sub crViewer_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        frmReceiveGradeSheets.Show()
    End Sub

    Private Sub UPDATEAVERGAEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UPDATEAVERGAEToolStripMenuItem.Click
        Try
            str = "UPDATE grades SET average = (PGrade + MGrade + PFinalGrade + FGrade) / 4 where SY='" & stSY.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()
            MsgBox("Successfully updated", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub CLASSDAYSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CLASSDAYSToolStripMenuItem.Click
        frmClassDays.ShowDialog()
    End Sub

    Private Sub ENCODEGRADESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ENCODEGRADESToolStripMenuItem.Click
        frmGradesEncodingNew.ShowDialog()
    End Sub

    Private Sub LOCKGRADESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOCKGRADESToolStripMenuItem.Click
        frmLockUnlock.ShowDialog()
    End Sub

    Private Sub STUDENTSREPORTSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles STUDENTSREPORTSToolStripMenuItem.Click
        frmStudeReports.ShowDialog()
    End Sub

    Private Sub GRADINGSHEETSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GRADINGSHEETSToolStripMenuItem.Click
        frmGradingSheets.Show()
    End Sub

    Private Sub CONSOLIDATEDGRADESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSOLIDATEDGRADESToolStripMenuItem.Click
        frmConsolidatedDashboard.Show()
    End Sub

    Private Sub VERSION1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VERSION1ToolStripMenuItem.Click
        Try
            str = "select ss.YearLevel, p.sex, count(p.sex) as sexCount, p.classification, ss.Course, ss.Semester, ss.SY, ss.Section, st.Region, st.division, st.SchoolName, st.SchoolAddress, st.letterHead, st.depedlogo, st.schoolLogo, st.telNo,st.RegistrarJHS, st.RegistrarSHS, st.SchoolHead, st.sHeadPosition from semesterstude ss join srms_settings st on ss.settingsID=st.settingsID join studeprofile p on p.StudentNumber=ss.StudentNumber where ss.SY='" & stSY.Text & "' and ss.Semester!='Second Semester' and ss.Status='Enrolled' group by ss.YearLevel, p.classification, p.Sex"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeprofile, semesterstude")
            Dim obj As New EnrollmentSummaryV2
            obj.SetDataSource(mysds.Tables("studeprofile, semesterstude"))
            crViewer.ReportSource = obj
            conn.Close()
            crViewer.Visible = True
            Panel3.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub VERSION2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VERSION2ToolStripMenuItem.Click
        Try
            str = "select ss.YearLevel, p.sex, count(p.sex) as sexCount, ss.Course, ss.Semester, ss.SY, ss.Section, st.Region, st.division, st.SchoolName, st.SchoolAddress, st.letterHead, st.depedlogo, st.schoolLogo, st.telNo,st.RegistrarJHS, st.RegistrarSHS, st.SchoolHead, st.sHeadPosition from semesterstude ss join srms_settings st on ss.settingsID=st.settingsID join studeprofile p on p.StudentNumber=ss.StudentNumber where ss.SY='" & stSY.Text & "' and ss.Semester!='Second Semester' and ss.Status='Enrolled' group by ss.YearLevel,ss.Section, p.Sex"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeprofile, semesterstude")
            Dim obj As New EnrollmentSummaryV3
            obj.SetDataSource(mysds.Tables("studeprofile, semesterstude"))
            crViewer.ReportSource = obj
            conn.Close()
            crViewer.Visible = True
            Panel3.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub VERSION3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VERSION3ToolStripMenuItem.Click
        frmStatisticsDashboard.lblSource.Text = "Registrar"
        frmStatisticsDashboard.Show()
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub crViewer_Load_1(sender As Object, e As EventArgs) Handles crViewer.Load

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        frmStudentAttendance.Show()
    End Sub

    Private Sub BATCHPRINTINGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BATCHPRINTINGToolStripMenuItem.Click
        frmGradesBatchPrinting.Show()
    End Sub
End Class