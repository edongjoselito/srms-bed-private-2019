Imports MySql.Data.MySqlClient
Public Class frmTeacherMasterList
    Dim str As String
    Private Sub btnMasterlist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMasterlist.Click
        Try
            If txtsubjectcode.Text = "" Or txtSection.Text = "" Then
                MsgBox("All fields are required.  Please fill it up completely!", MsgBoxStyle.Information)
                txtsubjectcode.Focus()
                Exit Sub
            End If


            str = "select p.StudentNumber, p.LastName, p.FirstName, p.MiddleName, p.Sex, r.Course, r.YearLevel, r.SubjectCode, r.Description, r.SchedTime, r.Instructor, r.SY, r.Sem, r.Section, r.Room, sr.SchoolName, sr.SchoolAddress, sr.letterHead from studeprofile p join registration r on p.StudentNumber=r.StudentNumber join srms_settings sr on r.settingsID=sr.settingsID where SubjectCode='" & txtsubjectcode.Text & "' and Description='" & txtDescription.Text & "' and Instructor='" & txtInstructor.Text & "' and Section='" & txtSection.Text & "' and Sem='" & frmTeacher.stSemester.Text & "' and SY='" & frmTeacher.stSY.Text & "' order by LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(Str, conn)
            Dim mysds As New DataSet
            mysda.Fill(mysds, "registration, srms_settings")
            Dim obj As New Class_List
            obj.SetDataSource(mysds.Tables("registration, srms_settings"))
            frmTeacher.crViewer.ReportSource = obj
            conn.Close()
            frmTeacher.crViewer.Visible = True

            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnSelectSubject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectSubject.Click
        frmSelectTeacherMasterList.Show()
    End Sub

    Private Sub frmTeacherMasterList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class