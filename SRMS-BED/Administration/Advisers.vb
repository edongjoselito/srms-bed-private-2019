Imports MySql.Data.MySqlClient
Public Class frmAdvisers
    Dim str As String
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        frmSearchPersonnel.ShowDialog()
    End Sub

    Public Sub getCourse()
        Try
            str = "select * from course_table group by CourseDescription order by CourseDescription"
            conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New Data.DataSet
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
    Public Sub getCourseMajor()
        Try
            str = "select * from course_table where CourseDescription='" & cboDepartment.Text & "' order by Major"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New Data.DataSet
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

    Private Sub frmAdvisers_Load(sender As Object, e As EventArgs) Handles Me.Load
        formLoad()
    End Sub

    Private Sub cboDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDepartment.SelectedIndexChanged
        getCourseMajor()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If btnSave.Text = "SAVE" Then
                str = "insert into sections (Section, YearLevel, Adviser) values('" & txtSection.Text & "','" & cboYearLevel.Text & "','" & txtAdviser.Text & "')"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()
                MsgBox("Added successfully!", MsgBoxStyle.Information)
                formLoad
            Else
                str = "update sections set Section='" & txtSection.Text & "', YearLevel='" & cboYearLevel.Text & "', Adviser='" & txtAdviser.Text & "' where sectionID='" & lblID.Text & "'"
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
    Public Sub formLoad()
        getCourse()

        btnSave.Text = "SAVE"
        btnDelete.Visible = False
        txtSection.Clear()
        txtAdviser.Clear()

        Try
            str = "select * from sections  order by YearLevel, Section"
            conn.Open()
            Dim Search As New MySqlDataAdapter(str, conn)
            Dim ds As Data.DataSet = New Data.DataSet
            Search.Fill(ds, "sections")
            dg1.DataSource = ds.Tables("sections")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).HeaderText = "SECTION"
            dg1.Columns(1).Width = 150
            dg1.Columns(2).HeaderText = "YEAR LEVEL"
            dg1.Columns(3).HeaderText = "ADVISER"
            dg1.Columns(3).Width = 330
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select * from sections where Section like '%" & txtSearch.Text & "%' or Adviser like '%" & txtSearch.Text & "%' order by YearLevel, Section"
            conn.Open()
            Dim Search As New MySqlDataAdapter(str, conn)
            Dim ds As Data.DataSet = New Data.DataSet
            Search.Fill(ds, "sections")
            dg1.DataSource = ds.Tables("sections")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).HeaderText = "SECTION"
            dg1.Columns(1).Width = 150
            dg1.Columns(2).HeaderText = "YEAR LEVEL"
            dg1.Columns(2).Width = 150
            dg1.Columns(3).HeaderText = "ADVISER"
            dg1.Columns(3).Width = 330
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
            txtSection.Text = dg1.Item(1, i).Value
            cboYearLevel.Text = dg1.Item(2, i).Value
            txtAdviser.Text = dg1.Item(3, i).Value

            btnSave.Text = "UPDATE"
            btnDelete.Visible = True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            str = "delete from sections where sectionID='" & lblID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()
            MsgBox("Successfully deleted", MsgBoxStyle.Information)
            formLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class