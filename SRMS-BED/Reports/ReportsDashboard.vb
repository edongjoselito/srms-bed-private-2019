Imports MySql.Data.MySqlClient
Public Class frmReportsDashboard
    Dim str As String
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub VERSION4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VERSION4ToolStripMenuItem.Click
        frmStatisticsDashboard.ShowDialog()
    End Sub

    Private Sub VERSION3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VERSION3ToolStripMenuItem.Click
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

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub VERSION2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VERSION2ToolStripMenuItem.Click
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

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub BYDEPARTMENTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BYDEPARTMENTToolStripMenuItem.Click
        Try
            str = "select ss.YearLevel, p.sex, count(p.sex) as sexCount, ss.Course, ss.Semester, ss.SY, st.Region, st.division, st.SchoolName, st.SchoolAddress, st.letterHead, st.depedlogo, st.schoolLogo, st.telNo from semesterstude ss join srms_settings st on ss.settingsID=st.settingsID join studeprofile p on p.StudentNumber=ss.StudentNumber where ss.SY='" & stSY.Text & "' and ss.Semester!='2nd Sem.' and ss.Status='Enrolled' group by ss.YearLevel, p.Sex"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeprofile, semesterstude")
            Dim obj As New EnrollmentSummaryReport
            obj.SetDataSource(mysds.Tables("studeprofile, semesterstude"))
            crViewer.ReportSource = obj
            conn.Close()
            crViewer.Visible = True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub BYSTRANDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BYSTRANDToolStripMenuItem.Click
        Try

            str = "select ss.YearLevel, mid(p.sex,1,1) as Sex, count(p.sex) as sexCount, ss.Course, ss.Track, ss.Qualification, ss.Semester, ss.SY, st.SchoolName, st.SchoolAddress, st.telNo, st.depedlogo, st.schoollogo, st.region, st.division, st.letterHead from semesterstude ss join srms_settings st on ss.settingsID=st.settingsID join studeprofile p on p.StudentNumber=ss.StudentNumber where ss.SY='" & stSY.Text & "' and ss.Semester!='2nd Sem.' and ss.Status='Enrolled' and ss.Course='Senior High School' group by ss.YearLevel, ss.Track, ss.Qualification, p.Sex"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "studeprofile, semesterstude")
            Dim obj As New countPerTrack
            obj.SetDataSource(mysds.Tables("studeprofile, semesterstude"))
            crViewer.ReportSource = obj
            conn.Close()
            crViewer.Visible = True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub BYETHNICITYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BYETHNICITYToolStripMenuItem.Click
        Try
            frmSummary.Show()
            frmSummary.lblTitle.Text = "By Ethnicity"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub BYGENDERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BYGENDERToolStripMenuItem.Click
        Try
            frmSummary.Show()
            frmSummary.lblTitle.Text = "By Gender"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub BYMUNICIPALITYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BYMUNICIPALITYToolStripMenuItem.Click
        Try
            Try
                frmSummary.Show()
                frmSummary.lblTitle.Text = "By Municipality"
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                conn.Close()
            End Try
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub BYRELIGIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BYRELIGIONToolStripMenuItem.Click
        Try
            frmSummary.Show()
            frmSummary.lblTitle.Text = "By Religion"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub COUNTSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COUNTSToolStripMenuItem.Click
        frmStatSummary.Show()
    End Sub

    Private Sub CLASSROOMSCHEDULESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CLASSROOMSCHEDULESToolStripMenuItem.Click
        frmRoomSched.ShowDialog()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        frmSchoolRegisterForm.Show()
    End Sub
End Class