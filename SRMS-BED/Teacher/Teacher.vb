Imports MySql.Data.MySqlClient
Public Class frmTeacher
    Dim str As String
    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        If lblAccountLevel.Text = "Super Admin" Then
            Me.Close()
        ElseIf lblAccountLevel.Text = "Admin" Then
            Me.Close()
        Else
            End
        End If
    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub frmTeacher_Load(sender As Object, e As EventArgs) Handles Me.Load


        formLoad()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        frmChangePassword.ShowDialog()
    End Sub

    Private Sub SWITCHSEMESTERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SWITCHSEMESTERToolStripMenuItem.Click
        frmSemChoiceV2.ShowDialog()
    End Sub

    Public Sub formLoad()

        Try

            crViewer.Visible = False
            stDate.Text = Today

            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select concat(FirstName,' ',LastName) as Name from staff where IDNumber='" & stUser.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lblInstructor.Text = dtReader.Item(0)
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try

    End Sub

    Private Sub CONSOLIDATEDGRADESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSOLIDATEDGRADESToolStripMenuItem.Click
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select concat(FirstName,' ',MiddleName,' ',LastName) as Name from staff where IDNumber='" & stUser.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lblInstructor.Text = dtReader.Item(0)
            End If
            conn.Close()

            str = "select s.SubjectCode, s.Description, s.Section, s.SchedTime, s.Room, s.SY, s.Semester, i.IDNumber, concat(i.FirstName,' ',i.LastName) as Name from semsubjects s join staff i on s.IDNumber=i.IDNumber where i.IDNumber='" & stUser.Text & "' and s.Semester='" & stSemester.Text & "' and s.SY='" & stSY.Text & "' group by s.SubjectCode, s.SchedTime, s.Room order by s.SubjectCode"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "i.staff, s.semsubjects")
            Dim obj As New WorkLoad
            obj.SetDataSource(ds.Tables("i.staff, s.semsubjects"))
            crViewer.ReportSource = obj

            conn.Close()
            crViewer.Visible = True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        formLoad()
    End Sub

    Private Sub ADVISORYCLASSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADVISORYCLASSToolStripMenuItem.Click
        Try

            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select concat(FirstName,' ',MiddleName,' ',LastName) as Name from staff where IDNumber='" & stUser.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()

            If dtReader.Read Then
                lblInstructor.Text = dtReader.Item(0)
            End If
            conn.Close()

            str = "Select s.StudentNumber, concat(s.LName,', ',s.FName,' ',s.MName) as Fullname, s.Course, s.YearLevel, s.Status, s.Scholarship, s.Semester, s.SY, s.Term, s.Section, s.semstudentid, p.Sex, s.Adviser, s.Track, s.Qualification, sr.SchoolName, sr.SchoolAddress, sr.letterHead from semesterstude s join studeprofile p on s.StudentNumber=p.StudentNumber join srms_settings sr on s.settingsID=sr.settingsID where s.Semester='" & stSemester.Text & "' and s.SY='" & stSY.Text & "' and s.Adviser='" & lblInstructor.Text & "' order by p.Sex, Fullname"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim mysds As New DataSet
            mysDA.Fill(mysds, "semesterstude")
            Dim obj As New ListPerSection
            obj.SetDataSource(mysds.Tables("semesterstude"))
            crViewer.ReportSource = obj

            conn.Close()
            crViewer.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub RECEIVEGRADINGSHEETSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RECEIVEGRADINGSHEETSToolStripMenuItem.Click
        frmTeacherMasterList.txtInstructor.Text = lblInstructor.Text
        frmTeacherMasterList.Show()
    End Sub

    Private Sub FIRSTGRADINGToolStripMenuItem_Click(sender As Object, e As EventArgs)
        TeacherGradesEncoding.Show()
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        TeacherGradesEncoding.ShowDialog()
    End Sub

    Private Sub GRADINGSHEETSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GRADINGSHEETSToolStripMenuItem.Click
        frmPrintGradingSheet.Show()
    End Sub
End Class