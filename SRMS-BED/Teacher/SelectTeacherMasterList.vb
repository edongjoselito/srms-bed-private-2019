Imports MySql.Data.MySqlClient
Public Class frmSelectTeacherMasterList
    Dim str As String
    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select * from semsubjects where SubjectCode like '%" & txtSearch.Text & "%' and  SY='" & frmTeacher.stSY.Text & "' and Semester='" & frmTeacher.stSemester.Text & "' and IDNumber='" & frmTeacher.stUser.Text & "' order by SubjectCode"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(Str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "semsubjects")
            dg1.DataSource = ds.Tables("semsubjects")
            conn.Close()
            dg1.Columns(0).HeaderText = "SUBJECT CODE"
            dg1.Columns(0).Width = 150
            dg1.Columns(1).HeaderText = "DESCRIPTION"
            dg1.Columns(1).Width = 300
            dg1.Columns(2).HeaderText = "SECTION"
            dg1.Columns(3).HeaderText = "SCHED TIME"
            dg1.Columns(3).Width = 300

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Try
            Dim i As Integer
            i = dg1.CurrentRow.Index
            frmTeacherMasterList.txtsubjectcode.Text = dg1.Item(0, i).Value
            frmTeacherMasterList.txtDescription.Text = dg1.Item(1, i).Value
            frmTeacherMasterList.txtSection.Text = dg1.Item(2, i).Value
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub frmSelectTeacherMasterList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select SubjectCode, Description, Section, SchedTime from semsubjects where SY='" & frmTeacher.stSY.Text & "' and Semester='" & frmTeacher.stSemester.Text & "' and IDNumber='" & frmTeacher.stUser.Text & "' order by SubjectCode"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "semsubjects")
            dg1.DataSource = ds.Tables("semsubjects")
            conn.Close()

            dg1.Columns(0).HeaderText = "SUBJECT CODE"
            dg1.Columns(0).Width = 150
            dg1.Columns(1).HeaderText = "DESCRIPTION"
            dg1.Columns(1).Width = 300
            dg1.Columns(2).HeaderText = "SECTION"
            dg1.Columns(3).HeaderText = "SCHED TIME"
            dg1.Columns(3).Width = 300


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class