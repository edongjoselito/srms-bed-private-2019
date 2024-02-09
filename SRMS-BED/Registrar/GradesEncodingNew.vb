Imports MySql.Data.MySqlClient
Public Class frmGradesEncodingNew
    Dim str As String
    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        frmSelectSubjects.ShowDialog()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        formLoad()
        Me.Close()
    End Sub

    Public Sub Grades()
        Try
            Dim subcom As String
            If lblMapehStat.Text = 1 Then
                subcom = cboSubSubject.Text

            Else
                subcom = ""
            End If

            str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName) as StudentName, g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Section, p.Sex, g.YearLevel, g.track, g.strand, g.adviser from studeprofile p join grades g on p.StudentNumber=g.StudentNumber where g.subjectcode='" & txtSubjectcode.Text & "' and g.Description='" & txtDescription.Text & "' and g.subComponent='" & subcom & "' and g.Sem ='" & frmRegistrar.stSemester.Text & "' and g.SY='" & frmRegistrar.stSY.Text & "' and g.Section='" & txtSection.Text & "' group by p.Sex, p.StudentNumber order by  StudentName asc, p.Sex desc "
            conn.Open()
            Dim mysC As New MySqlDataAdapter(Str, conn)
            Dim ds As New DataSet
            mysC.Fill(ds, "registration, semsubjects, grades")
            conn.Close()

            dg1.Columns.Clear()
            If ds.Tables("registration, semsubjects, grades").Rows.Count >= 1 Then


                'dg1.Columns(0).Visible = False
                dg1.DataSource = ds.Tables("registration, semsubjects, grades")

                conn.Close()
                dg1.Columns(0).HeaderText = "Student No."
                dg1.Columns(0).ReadOnly = True
                dg1.Columns(0).Width = 110
                dg1.Columns(1).HeaderText = "Student Name"
                dg1.Columns(1).ReadOnly = True
                dg1.Columns(1).Width = 230
                dg1.Columns(2).HeaderText = "1st Grading"
                dg1.Columns(2).Width = 110
                'dg1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                dg1.Columns(3).HeaderText = "2nd Grading"
                dg1.Columns(3).Width = 90
                dg1.Columns(3).Visible = True
                dg1.Columns(4).HeaderText = "3rd Grading"
                dg1.Columns(4).Width = 90
                dg1.Columns(4).Visible = True
                dg1.Columns(5).HeaderText = "4th Grading"
                dg1.Columns(5).Width = 90
                dg1.Columns(5).Visible = True
                dg1.Columns(6).Visible = False

                dg1.Columns(7).Visible = False
                dg1.Columns(8).Visible = False
                dg1.Columns(9).Visible = False
                dg1.Columns(10).Visible = False
                dg1.Columns(11).Visible = False
                conn.Close()

            Else
                ' kung wala pay grades
                str = "select r.StudentNumber, concat(p.LastName,', ',p.FirstName) as Fullname, s.YearLevel, s.Track, s.Qualification from registration r join semesterstude s on s.studentnumber=r.studentnumber join studeprofile p on p.StudentNumber=s.StudentNumber where r.subjectcode='" & txtSubjectcode.Text & "' and r.Description='" & txtDescription.Text & "' and r.Sem='" & frmRegistrar.stSemester.Text & "' and r.SY='" & frmRegistrar.stSY.Text & "' and r.Section='" & txtSection.Text & "' group by StudentNumber order by Fullname asc, p.Sex desc "
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(Str, conn)
                Dim ds1 As New DataSet
                mysDA.Fill(ds1, "registration, semesterstude, studeprofile")
                dg1.DataSource = ds1.Tables("registration, semesterstude, studeprofile")
                dg1.Columns(1).Width = 200
                dg1.Columns(1).HeaderText = "Student Name"
                dg1.Columns(0).ReadOnly = True
                dg1.Columns(1).ReadOnly = True
                dg1.Columns(2).Visible = True
                dg1.Columns(3).Visible = False
                dg1.Columns(4).Visible = False

                dg1.Columns.Add("PGrade", "1st Grading")
                dg1.Columns.Add("MGrade", "2nd Grading")
                dg1.Columns(5).Visible = True
                dg1.Columns.Add("PFinalGrade", "3rd Grading")
                dg1.Columns(6).Visible = True
                dg1.Columns.Add("FGrade", "4th Grading")
                dg1.Columns(7).Visible = True
                dg1.Columns(8).Visible = True


                conn.Close()

            End If
            conn.Close()

            'getNames()
            'getGrades()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            If txtSubjectcode.Text = "" Then
                MsgBox("Select subject first before saving!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If


            If lblMapehStat.Text = 1 Then
                If cboSubSubject.Text = "" Then
                    MessageBox.Show("Please select a subject component before saving.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                    cboSubSubject.DroppedDown = True

                End If
            End If

            'dili ma save if some cells are empty
            '   For i As Integer = 0 To dg1.RowCount - 1
            '   If dg1.Rows(i).Cells.Item(6).Value Is Nothing Then
            '  MsgBox("Grades cannot be saved because some cells are empty!", MsgBoxStyle.Exclamation)
            '  Exit Sub
            '  End If
            '  Next

            Dim subcom As String
            If lblMapehStat.Text = 1 Then
                subcom = cboSubSubject.Text

            Else
                subcom = ""
            End If

            str = "select * from grades where SubjectCode='" & txtSubjectcode.Text & "' and Description='" & txtDescription.Text & "' and subComponent='" & subcom & "' and Instructor='" & txtInstructor.Text & "' and SY='" & frmRegistrar.stSY.Text & "' and Sem='" & frmRegistrar.stSemester.Text & "' and Section='" & txtSection.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "grades")
            If ds.Tables("grades").Rows.Count >= 1 Then
                conn.Close()

                'code kung nag exist
                For x As Integer = 0 To dg1.Rows.Count - 1

                    str = "update grades set PGrade='" & dg1.Item(2, x).Value & "',MGrade='" & dg1.Item(3, x).Value & "',PFinalGrade='" & dg1.Item(4, x).Value & "',FGrade='" & dg1.Item(5, x).Value & "' where StudentNumber='" & dg1.Item(0, x).Value & "' and SubjectCode='" & txtSubjectcode.Text & "' and Description='" & txtDescription.Text & "' and subComponent='" & subcom & "' and Section='" & txtSection.Text & "' and Sem='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "'"
                    conn.Open()
                    Dim mysC1 As New MySqlCommand(str, conn)
                    mysC1.ExecuteNonQuery()
                    conn.Close()
                Next
                MsgBox("Grades successfully saved!", MsgBoxStyle.Information)
                conn.Close()
                formLoad()
                'kung wala nag exist
            Else
                For x As Integer = 0 To dg1.Rows.Count - 1
                    conn.Close()

                    str = "insert into grades values('0','" & dg1.Item(0, x).Value & "','" & txtSubjectcode.Text & "','" & txtDescription.Text & "','" & txtInstructor.Text & "','" & txtSection.Text & "','" & dg1.Item(5, x).Value & "','" & dg1.Item(6, x).Value & "','" & dg1.Item(7, x).Value & "','" & dg1.Item(8, x).Value & "','0','" & frmRegistrar.stSemester.Text & "','" & frmRegistrar.stSY.Text & "','Open','Open','Open','Open','" & dg1.Item(2, x).Value & "','" & dg1.Item(3, x).Value & "','" & dg1.Item(4, x).Value & "','adviser here','" & subcom & "')"
                    conn.Open()
                    Dim mysC2 As New MySqlCommand(str, conn)
                    mysC2.ExecuteNonQuery()
                    conn.Close()
                Next
                conn.Close()

                MsgBox("Grades successfully saved!", MsgBoxStyle.Information)
                formLoad()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try



    End Sub
    Public Sub formLoad()
        txtSubjectcode.Clear()
        txtDescription.Clear()
        txtInstructor.Clear()
        txtSection.Clear()

    End Sub

    Private Sub txtSubjectcode_TextChanged(sender As Object, e As EventArgs) Handles txtSubjectcode.TextChanged
        Grades()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        formLoad()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        formLoad()
    End Sub

    Private Sub frmGradesEncodingNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtDescription_TextChanged(sender As Object, e As EventArgs) Handles txtDescription.TextChanged

    End Sub

    Private Sub txtSection_TextChanged(sender As Object, e As EventArgs) Handles txtSection.TextChanged

    End Sub

    Private Sub cboSubSubject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSubSubject.SelectedIndexChanged

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If (MsgBox("You are about to delete grades for this subject.  Do you want to continue?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                Dim subcom As String
                If lblMapehStat.Text = 1 Then
                    subcom = cboSubSubject.Text

                Else
                    subcom = ""
                End If
                str = "delete from grades where SubjectCode='" & txtSubjectcode.Text & "' and Description='" & txtDescription.Text & "' and subComponent='" & subcom & "' and Instructor='" & txtInstructor.Text & "' and Section='" & txtSection.Text & "' and Sem='" & frmRegistrar.stSY.Text & "' and SY='" & frmRegistrar.stSY.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()
                MsgBox("Grades successfully deleted", MsgBoxStyle.Information)
                formLoad()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class