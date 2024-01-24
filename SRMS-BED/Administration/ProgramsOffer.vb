Imports MySql.Data.MySqlClient
Public Class frmProgramsOffer
    Dim str As String
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Public Sub getDepartment()
        Try
            Str = "select * from course_table order by CourseCode"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(Str, conn)
            Dim ds As New Data.DataSet
            mysda.Fill(ds, "course_table")
            dg1.DataSource = ds.Tables("course_table")
            conn.Close()
            dg1.Columns(0).Visible = False
            dg1.Columns(1).Width = 150
            dg1.Columns(1).HeaderText = "Dept. Code"
            dg1.Columns(2).Width = 380
            dg1.Columns(2).HeaderText = "Department"
            dg1.Columns(3).HeaderText = "Grade Level"
            dg1.Columns(3).Width = 200
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub frmProgramsOffer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formLoad()
    End Sub

    Public Sub formLoad()
        txtCourseCode.Focus()
        txtCourseCode.Clear()
        txtDepartment.Clear()
        txtYearLevel.Clear()

        btnDelete.Visible = False
        btnCancel.Visible = False
        btnSave.Enabled = True
        btnSave.Text = "SAVE"

        getDepartment()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Save()
    End Sub

    Public Sub Save()
        Try
            If txtCourseCode.Text = "" Then
                MsgBox("Course code is required.", MsgBoxStyle.Exclamation)
                txtCourseCode.Focus()
                Exit Sub
            End If

            If txtDepartment.Text = "" Then
                MsgBox("Department is required.", MsgBoxStyle.Exclamation)
                txtDepartment.Focus()
                Exit Sub
            End If

            If txtYearLevel.Text = "" Then
                MsgBox("Year level is required.", MsgBoxStyle.Exclamation)
                txtYearLevel.Focus()
                Exit Sub
            End If

            If btnSave.Text = "SAVE" Then
                str = "insert into course_table (CourseCode, CourseDescription, Major) values('" & txtCourseCode.Text & "','" & txtDepartment.Text & "','" & txtYearLevel.Text & "')"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()
                MsgBox("Added successfully!", MsgBoxStyle.Information)
                formLoad()
            Else
                str = "update course_table set CourseCode='" & txtCourseCode.Text & "',CourseDescription='" & txtDepartment.Text & "', Major='" & txtYearLevel.Text & "' where courseid='" & lblID.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()
                MsgBox("Updated successfully!", MsgBoxStyle.Information)
                formLoad()
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub dg1_DoubleClick(sender As Object, e As EventArgs) Handles dg1.DoubleClick
        Try
            Dim i As Integer
            i = dg1.CurrentRow.Index
            lblID.Text = dg1.Item(0, i).Value
            txtCourseCode.Text = dg1.Item(1, i).Value
            txtDepartment.Text = dg1.Item(2, i).Value
            txtYearLevel.Text = dg1.Item(3, i).Value

            btnCancel.Visible = True
            btnDelete.Visible = True
            btnSave.Text = "Update"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        formLoad()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from course_table where courseid='" & lblID.Text & "'"
                conn.Open()
                Dim mysC As New MySqlCommand(str, conn)
                mysC.ExecuteNonQuery()
                MsgBox("Data successfully deleted!", MsgBoxStyle.Information, "Prompt")
                conn.Close()
                formLoad()

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
End Class