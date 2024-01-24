Imports MySql.Data.MySqlClient
Public Class frmSelectSubject_Masterlist
    Dim str As String
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmSelectSubject_Masterlist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select SubjectCode, Description, Section, concat(FirstName,' ',MiddleName,' ',LastName) as Teacher from semsubjects s join staff ff on s.IDNumber=ff.IDNumber where SY='" & frmRegistrar.stSY.Text & "' and Semester='" & frmRegistrar.stSemester.Text & "' order by SubjectCode"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "semsubjects, staff")
            dg1.DataSource = ds.Tables("semsubjects, staff")
            conn.Close()
            dg1.Columns(0).HeaderText = "SUBJECT CODE"
            dg1.Columns(1).HeaderText = "DESCRIPTION"
            dg1.Columns(1).Width = 150
            dg1.Columns(2).HeaderText = "SECTION"
            dg1.Columns(3).HeaderText = "TEACHER"
            dg1.Columns(3).Width = 150

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Try
            Dim i As Integer
            i = dg1.CurrentRow.Index
            frmMasterList.txtsubjectcode.Text = dg1.Item(0, i).Value
            frmMasterList.txtDescription.Text = dg1.Item(1, i).Value
            frmMasterList.txtSection.Text = dg1.Item(2, i).Value
            frmMasterList.txtInstructor.Text = dg1.Item(3, i).Value
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select SubjectCode, Description, Section, concat(FirstName,' ',MiddleName,' ',LastName) as Teacher from semsubjects s join staff ff on s.IDNumber=ff.IDNumber where SubjectCode like '%" & txtSearch.Text & "%' or Description like '%" & txtSearch.Text & "%' and  SY='" & frmRegistrar.stSY.Text & "' and Semester='" & frmRegistrar.stSemester.Text & "' order by SubjectCode"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "semsubjects, staff")
            dg1.DataSource = ds.Tables("semsubjects, staff")
            conn.Close()
            dg1.Columns(0).HeaderText = "SUBJECT CODE"
            dg1.Columns(1).HeaderText = "DESCRIPTION"
            dg1.Columns(1).Width = 150
            dg1.Columns(2).HeaderText = "SECTION"
            dg1.Columns(3).HeaderText = "TEACHER"
            dg1.Columns(3).Width = 150


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class