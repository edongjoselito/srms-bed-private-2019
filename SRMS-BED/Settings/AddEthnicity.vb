Imports MySql.Data.MySqlClient
Public Class AddEthnicity
    Dim str As String
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            If btnAdd.Text = "+ ADD" Then
                str = "insert into settings_ethnicity (ethnicity) values('" & txtEthnicity.Text & "')"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()
                txtEthnicity.Clear()

                frmStudeProfile.getEthnicity()

                MsgBox("New data added.", MsgBoxStyle.Information)
                formLoad()
            Else
                str = "update settings_ethnicity set ethnicity='" & txtEthnicity.Text & "' where id='" & lblID.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()
                txtEthnicity.Clear()

                frmStudeProfile.getEthnicity()

                MsgBox("Updated successfully.", MsgBoxStyle.Information)
                formLoad()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Public Sub formLoad()
        Try
            str = "select * from settings_ethnicity order by ethnicity"
            conn.Open()
            Dim Search As New MySqlDataAdapter(Str, conn)
            Dim ds As Data.DataSet = New Data.DataSet
            Search.Fill(ds, "settings_ethnicity")
            dg1.DataSource = ds.Tables("settings_ethnicity")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).HeaderText = "Ethnicity"
            dg1.Columns(1).Width = 550


            txtEthnicity.Clear()

            btnDelete.Enabled = False
            btnAdd.Enabled = True
            btnAdd.Text = "+ ADD"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim i As Integer
        i = dg1.CurrentRow.Index
        lblID.Text = dg1.Item(0, i).Value
        txtEthnicity.Text = dg1.Item(1, i).Value

        btnDelete.Enabled = True
        btnAdd.Text = "UPDATE"
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            str = "delete from settings_ethnicity where id='" & lblID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()

            formLoad()
            frmStudeProfile.getEthnicity()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub AddEthnicity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formLoad()
    End Sub
End Class