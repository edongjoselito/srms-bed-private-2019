Imports MySql.Data.MySqlClient
Public Class frmSelectSubjects
    Dim str As String
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try

            str = " select SubjectCode, Description, Section, ff.IDNumber, concat(FIrstName,' ',LastName) as Teacher from semsubjects s join staff ff on s.IDNumber=ff.IDNumber where SubjectCode like '%" & txtSearch.Text & "%' and Semester='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "' order by SubjectCode"
            conn.Open()
            Dim Search As New MySqlDataAdapter(str, conn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "semsubjects, staff")
            dg1.DataSource = ds.Tables("semsubjects, staff")
            conn.Close()
            dg1.Columns(0).HeaderText = "SUBJECT CODE"
            dg1.Columns(1).Width = 80
            dg1.Columns(1).HeaderText = "DESCRIPTION"
            dg1.Columns(1).Width = 250
            dg1.Columns(2).HeaderText = "SECTION"
            dg1.Columns(3).HeaderText = "TEACHER'S ID"
            dg1.Columns(4).HeaderText = "TEACHER"
            dg1.Columns(4).Width = 250

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub SelectSubjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            str = "select SubjectCode, Description, Section, ff.IDNumber, concat(FIrstName,' ',LastName) as Teacher from semsubjects s join staff ff on s.IDNumber=ff.IDNumber where Semester='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "' order by SubjectCode"
            conn.Open()
            Dim mysC As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet

            mysC.Fill(ds, "semsubjects")
            dg1.DataSource = ds.Tables("semsubjects")
            conn.Close()
            dg1.Columns(0).HeaderText = "SUBJECT CODE"
            dg1.Columns(1).Width = 80
            dg1.Columns(1).HeaderText = "DESCRIPTION"
            dg1.Columns(1).Width = 250
            dg1.Columns(2).HeaderText = "SECTION"
            dg1.Columns(3).HeaderText = "TEACHER'S ID"
            dg1.Columns(4).HeaderText = "TEACHER"
            dg1.Columns(4).Width = 250


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
                frmGradesEncodingNew.txtSubjectcode.Text = dg1(0, i).Value
                frmGradesEncodingNew.txtDescription.Text = dg1(1, i).Value
                frmGradesEncodingNew.txtSection.Text = dg1(2, i).Value
                frmGradesEncodingNew.lblInstructorID.Text = dg1(3, i).Value
                frmGradesEncodingNew.txtInstructor.Text = dg1(4, i).Value

                frmMapehComponent.ShowDialog()

            Else
                frmGradesEncodingNew.txtSubjectcode.Text = dg1(0, i).Value
                frmGradesEncodingNew.txtDescription.Text = dg1(1, i).Value
                frmGradesEncodingNew.txtSection.Text = dg1(2, i).Value
                frmGradesEncodingNew.lblInstructorID.Text = dg1(3, i).Value
                frmGradesEncodingNew.txtInstructor.Text = dg1(4, i).Value

                frmGradesEncodingNew.Grades()
                frmGradesEncodingNew.getStatus()
                frmGradesEncodingNew.btnCancel.Visible = True
                frmGradesEncodingNew.btnDelete.Visible = True
            End If

            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class