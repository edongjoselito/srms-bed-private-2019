Imports MySql.Data.MySqlClient
Public Class frmTeacherSelectsubjects
    Dim str As String
    Private Sub frmTeacherSelectsubjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            str = "select SubjectCode, Description, Section, ff.IDNumber, concat(FIrstName,' ',MiddleName,' ',LastName) as Teacher from semsubjects s join staff ff on s.IDNumber=ff.IDNumber where Semester='" & frmTeacher.stSemester.Text & "' and SY='" & frmTeacher.stSY.Text & "' and ff.IDNumber='" & frmTeacher.stUser.Text & "' order by SubjectCode"
            conn.Open()
            Dim mysC As New MySqlDataAdapter(Str, conn)
            Dim ds As New DataSet

            mysC.Fill(ds, "semsubjects")
            dg1.DataSource = ds.Tables("semsubjects")
            conn.Close()
            dg1.Columns(0).HeaderText = "SUBJECT CODE"
            dg1.Columns(1).Width = 80
            dg1.Columns(1).HeaderText = "DESCRIPTION"
            dg1.Columns(1).Width = 430
            dg1.Columns(2).HeaderText = "SECTION"
            dg1.Columns(3).HeaderText = "TEACHER'S ID"
            dg1.Columns(3).Visible = False
            dg1.Columns(4).HeaderText = "TEACHER"
            dg1.Columns(4).Width = 250
            dg1.Columns(4).Visible = False


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub dg1_DoubleClick(sender As Object, e As EventArgs) Handles dg1.DoubleClick
        Try

            Dim i As Integer
            i = dg1.CurrentRow.Index

            If dg1(2, i).Value.Contains("MAPEH") OrElse dg1(2, i).Value.Contains("Mapeh") OrElse dg1(2, i).Value.Contains("Music Arts Physical Education Health") Then
                TeacherGradesEncoding.txtSubjectcode.Text = dg1(0, i).Value
                TeacherGradesEncoding.txtDescription.Text = dg1(1, i).Value
                TeacherGradesEncoding.txtSection.Text = dg1(2, i).Value


                frmMapehComponent.ShowDialog()

            Else
                TeacherGradesEncoding.txtSubjectcode.Text = dg1(0, i).Value
                TeacherGradesEncoding.txtDescription.Text = dg1(1, i).Value
                TeacherGradesEncoding.txtSection.Text = dg1(2, i).Value

                TeacherGradesEncoding.Grades()

            End If

            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class