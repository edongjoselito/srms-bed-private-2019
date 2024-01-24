Imports MySql.Data.MySqlClient
Public Class frmAddSection
    Dim str As String
    Private Sub frmAddSection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formLoad()
    End Sub
    Public Sub formLoad()
        Try
            str = "select * from sections where YearLevel='" & lblYearLevel.Text & "' order by Section"
            conn.Open()
            Dim Search As New MySqlDataAdapter(Str, conn)
            Dim ds As Data.DataSet = New Data.DataSet
            Search.Fill(ds, "sections")
            dg1.DataSource = ds.Tables("sections")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).HeaderText = "Section"
            dg1.Columns(1).Width = 500
            dg1.Columns(2).HeaderText = "Year Level"


            txtSection.Clear()
            'cboYearLevel.ResetText()
            txtSection.Focus()
            btnAdd.Enabled = True
            btnAdd.Text = "+ ADD"
            btnDelete.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try

            If btnAdd.Text = "+ ADD" Then
                str = "insert into sections values(0,'" & txtSection.Text & "','" & lblYearLevel.Text & "','" & txtAdviser.Text & "')"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()
                MsgBox("Successfully saved!", MsgBoxStyle.Information)
                formLoad()

                frmSemStudent.getSection()
                frmSemSubjects.getSections()
            Else
                str = "UPDATE sections set Section='" & txtSection.Text & "',YearLevel='" & lblYearLevel.Text & "',Adviser='" & txtAdviser.Text & "' where sectionID='" & lblID.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()
                MsgBox("Updated successfully!", MsgBoxStyle.Information)

                formLoad()

                frmSemStudent.getSection()
                frmSemSubjects.getSections()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim i As Integer
        i = dg1.CurrentRow.Index
        lblID.Text = dg1.Item(0, i).Value
        txtSection.Text = dg1.Item(1, i).Value
        txtAdviser.Text = dg1.Item(3, i).Value
        'cboYearLevel.Text = dg1.Item(2, i).Value
        btnAdd.Enabled = True
        btnAdd.Text = "UPDATE"
        btnDelete.Visible = True
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            str = "delete from sections where sectionID='" & lblID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()

            formLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmSearchPersonnel.ShowDialog()
    End Sub
End Class