Imports MySql.Data.MySqlClient
Public Class frmSearchSemSubjects
    Dim str As String

    Private Sub frmSearchSemSubjects_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chkSubjectCode.Checked = True
        Try
            str = "SELECT s.SubjectCode, s.Description, s.SchedTime, s.Room, s.Section, s.IDNumber, concat(FirstName, MiddleName, LastName) as Teacher FROM semsubjects s join staff ff on s.IDNumber=ff.IDNumber where SY='" & frmRegistrar.stSY.Text & "' and Semester='" & frmRegistrar.stSemester.Text & "' order by SubjectCode"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New Data.DataSet
            mysda.Fill(ds, "semsubjects, staff")
            dgsubjects.DataSource = ds.Tables("semsubjects, staff")
            conn.Close()

            dgsubjects.Columns(0).HeaderText = "SUBJECT CODE"
            dgsubjects.Columns(1).HeaderText = "DESCRIPTION"
            dgsubjects.Columns(1).Width = 200
            dgsubjects.Columns(2).HeaderText = "CLASS SCHEDULE"
            dgsubjects.Columns(2).Width = 200
            dgsubjects.Columns(3).HeaderText = "ROOM"
            dgsubjects.Columns(4).HeaderText = "SECTION"
            dgsubjects.Columns(5).HeaderText = "ID NUMBER"
            dgsubjects.Columns(6).HeaderText = "TEACHER"
            dgsubjects.Columns(6).Width = 200


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            If chkSubjectCode.Checked = True Then
                str = "SELECT s.SubjectCode, s.Description, s.SchedTime, s.Room, s.Section, s.IDNumber, concat(FirstName, MiddleName, LastName) as Teacher FROM semsubjects s join staff ff on s.IDNumber=ff.IDNumber where SubjectCode like '%" & txtSearch.Text & "%' and SY='" & frmRegistrar.stSY.Text & "' and Semester='" & frmRegistrar.stSemester.Text & "' order by Description"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New Data.DataSet
                mysda.Fill(ds, "semsubjects, staff")
                dgsubjects.DataSource = ds.Tables("semsubjects, staff")
                conn.Close()

                dgsubjects.Columns(0).HeaderText = "SUBJECT CODE"
                dgsubjects.Columns(1).HeaderText = "DESCRIPTION"
                dgsubjects.Columns(1).Width = 200
                dgsubjects.Columns(2).HeaderText = "CLASS SCHEDULE"
                dgsubjects.Columns(2).Width = 200
                dgsubjects.Columns(3).HeaderText = "ROOM"
                dgsubjects.Columns(4).HeaderText = "SECTION"
                dgsubjects.Columns(5).HeaderText = "ID NUMBER"
                dgsubjects.Columns(6).HeaderText = "TEACHER"
                dgsubjects.Columns(6).Width = 200

            End If

            If chkDescription.Checked = True Then
                str = "SELECT s.SubjectCode, s.Description, s.SchedTime, s.Room, s.Section, s.IDNumber, concat(FirstName, MiddleName, LastName) as Teacher FROM semsubjects s join staff ff on s.IDNumber=ff.IDNumber where Description like '%" & txtSearch.Text & "%' and SY='" & frmRegistrar.stSY.Text & "' and Semester='" & frmRegistrar.stSemester.Text & "' order by Description"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New Data.DataSet
                mysda.Fill(ds, "semsubjects, staff")
                dgsubjects.DataSource = ds.Tables("semsubjects, staff")
                conn.Close()

                dgsubjects.Columns(0).HeaderText = "SUBJECT CODE"
                dgsubjects.Columns(1).HeaderText = "DESCRIPTION"
                dgsubjects.Columns(1).Width = 200
                dgsubjects.Columns(2).HeaderText = "CLASS SCHEDULE"
                dgsubjects.Columns(2).Width = 200
                dgsubjects.Columns(3).HeaderText = "ROOM"
                dgsubjects.Columns(4).HeaderText = "SECTION"
                dgsubjects.Columns(5).HeaderText = "ID NUMBER"
                dgsubjects.Columns(6).HeaderText = "TEACHER"
                dgsubjects.Columns(6).Width = 200

            End If

            If chkSection.Checked = True Then
                str = "SELECT s.SubjectCode, s.Description, s.SchedTime, s.Room, s.Section, s.IDNumber, concat(FirstName, MiddleName, LastName) as Teacher FROM semsubjects s join staff ff on s.IDNumber=ff.IDNumber where Section like '%" & txtSearch.Text & "%' and SY='" & frmRegistrar.stSY.Text & "' and Semester='" & frmRegistrar.stSemester.Text & "'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New Data.DataSet
                mysda.Fill(ds, "semsubjects, staff")
                dgsubjects.DataSource = ds.Tables("semsubjects, staff")
                conn.Close()

                dgsubjects.Columns(0).HeaderText = "SUBJECT CODE"
                dgsubjects.Columns(1).HeaderText = "DESCRIPTION"
                dgsubjects.Columns(1).Width = 200
                dgsubjects.Columns(2).HeaderText = "CLASS SCHEDULE"
                dgsubjects.Columns(2).Width = 200
                dgsubjects.Columns(3).HeaderText = "ROOM"
                dgsubjects.Columns(4).HeaderText = "SECTION"
                dgsubjects.Columns(5).HeaderText = "ID NUMBER"
                dgsubjects.Columns(6).HeaderText = "TEACHER"
                dgsubjects.Columns(6).Width = 200
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub dgsubjects_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgsubjects.DoubleClick
        Try
            Dim i As Integer
            i = dgsubjects.CurrentRow.Index

            For x As Integer = 0 To frmCOR.lvCOR.Items.Count - 1
                If dgsubjects.Item(0, i).Value = frmCOR.lvCOR.Items(x).SubItems(0).Text Then
                    MsgBox("Adding the same subject to the same student is not allowed!", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
            Next
            AddSemSubjects(frmCOR.lvCOR, dgsubjects.Item(0, i).Value, dgsubjects.Item(1, i).Value, dgsubjects.Item(2, i).Value, dgsubjects.Item(3, i).Value, dgsubjects.Item(4, i).Value, dgsubjects.Item(5, i).Value)

            frmCOR.tsSave.Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

    End Sub

End Class