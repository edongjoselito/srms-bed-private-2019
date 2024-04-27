Imports MySql.Data.MySqlClient
Public Class frmSearchSemesterStudent
    Dim str As String
    Private Sub frmSearchSemesterStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            str = "select semstudentid, p.StudentNumber, FirstName, MiddleName, LastName, ss.Course, YearLevel, Section from semesterstude ss join studeprofile p on ss.Studentnumber=p.studentNumber where Semester='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "'"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(Str, conn)
            Dim ds As New Data.DataSet
            mysDA.Fill(ds, "semesterstude, studeprofile")
            dgsemstudent.DataSource = ds.Tables("semesterstude, studeprofile")
            conn.Close()

            dgsemstudent.Columns(0).Visible = False
            dgsemstudent.Columns(1).Visible = True
            dgsemstudent.Columns(1).HeaderText = "STUDENT NUMBER"
            dgsemstudent.Columns(2).Visible = True
            dgsemstudent.Columns(2).HeaderText = "FIRST NAME"
            dgsemstudent.Columns(2).Width = 200
            dgsemstudent.Columns(3).Visible = True
            dgsemstudent.Columns(3).HeaderText = "MIDDLE NAME"
            dgsemstudent.Columns(3).Width = 200
            dgsemstudent.Columns(4).Visible = True
            dgsemstudent.Columns(4).HeaderText = "LAST NAME"
            dgsemstudent.Columns(4).Width = 200
            dgsemstudent.Columns(5).Visible = True
            dgsemstudent.Columns(5).HeaderText = "DEPARTMENT"
            dgsemstudent.Columns(5).Width = 150
            dgsemstudent.Columns(6).Visible = True
            dgsemstudent.Columns(6).HeaderText = "GRADE LEVEL"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select semstudentid, p.StudentNumber, FirstName, MiddleName, LastName, ss.Course, YearLevel, Section from semesterstude ss join studeprofile p on ss.Studentnumber=p.studentNumber where LastName like '%" & txtSearch.Text & "%' and Semester='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "'"
            conn.Open()
            Dim Search As New MySqlDataAdapter(str, conn)
            Dim ds As Data.DataSet = New Data.DataSet
            Search.Fill(ds, "semesterstude, studeprofile")
            dgsemstudent.DataSource = ds.Tables("semesterstude, studeprofile")
            conn.Close()
            dgsemstudent.Columns(0).Visible = False
            dgsemstudent.Columns(1).Visible = True
            dgsemstudent.Columns(1).HeaderText = "STUDENT NUMBER"
            dgsemstudent.Columns(2).Visible = True
            dgsemstudent.Columns(2).HeaderText = "FIRST NAME"
            dgsemstudent.Columns(2).Width = 200
            dgsemstudent.Columns(3).Visible = True
            dgsemstudent.Columns(3).HeaderText = "MIDDLE NAME"
            dgsemstudent.Columns(3).Width = 200
            dgsemstudent.Columns(4).Visible = True
            dgsemstudent.Columns(4).HeaderText = "LAST NAME"
            dgsemstudent.Columns(4).Width = 200
            dgsemstudent.Columns(5).Visible = True
            dgsemstudent.Columns(5).HeaderText = "DEPARTMENT"
            dgsemstudent.Columns(5).Width = 150
            dgsemstudent.Columns(6).Visible = True
            dgsemstudent.Columns(6).HeaderText = "GRADE LEVEL"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub dgsemstudent_DoubleClick(sender As Object, e As EventArgs) Handles dgsemstudent.DoubleClick
        Try
            Dim i As Integer
            i = dgsemstudent.CurrentRow.Index
            frmCOR.mskStudentNumber.Text = dgsemstudent(1, i).Value
            frmCOR.txtFirstName.Text = dgsemstudent(2, i).Value
            frmCOR.txtMiddleName.Text = dgsemstudent(3, i).Value
            frmCOR.txtLastName.Text = dgsemstudent(4, i).Value
            frmCOR.txtCourse.Text = dgsemstudent(5, i).Value
            frmCOR.txtYearLevel.Text = dgsemstudent(6, i).Value
            frmCOR.lblSection.Text = dgsemstudent(7, i).Value

            frmCOR.btnAddSubject.Enabled = True
            frmCOR.tsSave.Enabled = True
            frmCOR.btnAddSubject.Enabled = True
            frmCOR.btnRemoveSubjects.Enabled = True

            frmCOR.LoadSubjects()

            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class