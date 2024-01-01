Imports MySql.Data.MySqlClient
Public Class frmSubjects
    Dim str As String


    Public Sub formLoad()
        txtCode.Focus()
        txtCode.Clear()
        txtDescription.Clear()
        cboYearLevel.ResetText()
        cboDepartment.ResetText()
        cboSem.ResetText()
        cboCategory.ResetText()

        btnDelete.Visible = False
        btnCancel.Visible = False
        btnSave.Enabled = True
        btnSave.Text = "SAVE"


        getDepatment()
        getSubjects()
    End Sub

    Public Sub GetSubjects()
        str = "select * from subjects order by subjectCode"
        conn.Open()
        Dim Search As New MySqlDataAdapter(str, conn)
        Dim ds As DataSet = New DataSet
        Search.Fill(ds, "subjects")
        dg1.DataSource = ds.Tables("subjects")
        conn.Close()

        dg1.Columns(0).Visible = False
        dg1.Columns(1).HeaderText = "Subject Code"
        dg1.Columns(2).Width = 350
        dg1.Columns(2).HeaderText = "Subject Description"
        dg1.Columns(3).HeaderText = "Year Level"
        dg1.Columns(4).Width = 150
        dg1.Columns(4).HeaderText = "Department"
        dg1.Columns(5).HeaderText = "Sem."
        dg1.Columns(6).HeaderText = "Category"

    End Sub
    Public Sub getDepatment()
        Try
            str = "select * from course_table group by CourseDescription order by CourseDescription"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "course_table")
            conn.Close()
            cboDepartment.ValueMember = "course_table"
            cboDepartment.DisplayMember = "CourseDescription"
            cboDepartment.DataSource = ds.Tables("course_table")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Public Sub getYearLevel()
        Try
            str = "select * from course_table where CourseDescription='" & cboDepartment.Text & "' order by Major"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "course_table")
            conn.Close()
            cboYearLevel.ValueMember = "course_table"
            cboYearLevel.DisplayMember = "Major"
            cboYearLevel.DataSource = ds.Tables("course_table")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub frmSubjects_Load(sender As Object, e As EventArgs) Handles Me.Load
        formLoad()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Save()
    End Sub
    Public Sub Save()
        Try
            If txtCode.Text = "" Then
                MsgBox("Subject code is required.", MsgBoxStyle.Exclamation)
                txtCode.Focus()
                Exit Sub
            End If

            If txtDescription.Text = "" Then
                MsgBox("Description is required.", MsgBoxStyle.Exclamation)
                txtDescription.Focus()
                Exit Sub
            End If


            If btnSave.Text = "SAVE" Then
                str = "insert into subjects  (subjectCode, description, yearLevel, course, sem, subCategory) values('" & txtCode.Text & "','" & txtDescription.Text & "','" & cboYearLevel.Text & "','" & cboDepartment.Text & "','" & frmAdmin.stSemester.Text & "','" & cboCategory.Text & "')"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()
                MsgBox("Added successfully!", MsgBoxStyle.Information)
                formLoad()
            Else
                str = "update subjects  set subjectCode='" & txtCode.Text & "', description='" & txtDescription.Text & "', yearLevel='" & cboYearLevel.Text & "', course='" & cboDepartment.Text & "', sem='" & cboSem.Text & "', subCategory='" & cboCategory.Text & "' where id='" & lblID.Text & "'"
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

    Private Sub cboDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDepartment.SelectedIndexChanged
        getYearLevel()
    End Sub

    Private Sub dg1_DoubleClick(sender As Object, e As EventArgs) Handles dg1.DoubleClick
        Try
            Dim i As Integer
            i = dg1.CurrentRow.Index
            lblID.Text = dg1.Item(0, i).Value
            txtCode.Text = dg1.Item(1, i).Value
            txtDescription.Text = dg1.Item(2, i).Value
            cboYearLevel.Text = dg1.Item(3, i).Value
            cboDepartment.Text = dg1.Item(4, i).Value
            cboSem.Text = dg1.Item(5, i).Value
            cboCategory.Text = dg1.Item(6, i).Value

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
                str = "delete from subjects where id='" & lblID.Text & "'"
                conn.Open()
                Dim mysC As New MySqlCommand(str, conn)
                mysC.ExecuteNonQuery()
                MsgBox("Data successfully deleted!", MsgBoxStyle.Information, "Prompt")
                conn.Close()
                formLoad()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select * from subjects where subjectCode like '%" & txtSearch.Text & "%' or description like '%" & txtSearch.Text & "%' order by subjectCode"
            conn.Open()
            Dim Search As New MySqlDataAdapter(str, conn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "subjects")
            dg1.DataSource = ds.Tables("subjects")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).HeaderText = "Subject Code"
            dg1.Columns(2).Width = 350
            dg1.Columns(2).HeaderText = "Subject Description"
            dg1.Columns(3).HeaderText = "Year Level"
            dg1.Columns(4).Width = 150
            dg1.Columns(4).HeaderText = "Department"
            dg1.Columns(5).HeaderText = "Sem."
            dg1.Columns(6).HeaderText = "Category"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class