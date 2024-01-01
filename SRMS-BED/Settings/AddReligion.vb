Imports MySql.Data.MySqlClient
Public Class AddReligion
    Dim str As String
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            If btnAdd.Text = "+ ADD" Then
                str = "insert into settings_religion (religion) values('" & txtReligion.Text & "')"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()
                txtReligion.Clear()

                frmStudeProfile.getReligion()

                MsgBox("New data added.", MsgBoxStyle.Information)
                formLoad()
            Else
                str = "update settings_religion set religion='" & txtReligion.Text & "' where id='" & lblID.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()
                txtReligion.Clear()

                frmStudeProfile.getReligion()

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
            str = "select * from settings_religion order by religion"
            conn.Open()
            Dim Search As New MySqlDataAdapter(Str, conn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "settings_religion")
            dg1.DataSource = ds.Tables("settings_religion")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).HeaderText = "Religion"
            dg1.Columns(1).Width = 550


            txtReligion.Clear()

            btnDelete.Enabled = False
            btnAdd.Enabled = True
            btnAdd.Text = "+ ADD"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub AddReligion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formLoad()
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim i As Integer
        i = dg1.CurrentRow.Index
        lblID.Text = dg1.Item(0, i).Value
        txtReligion.Text = dg1.Item(1, i).Value

        btnAdd.Enabled = True
        btnAdd.Text = "UPDATE"
        btnDelete.Enabled = True
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            str = "delete from settings_religion where id='" & lblID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()

            formLoad()
            frmStudeProfile.getReligion()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class