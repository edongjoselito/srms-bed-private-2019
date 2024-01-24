Imports MySql.Data.MySqlClient
Public Class frmAddEmpStat
    Dim str As String
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            str = "insert into settings_empstat (empStat) values('" & txtEmpStat.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(Str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()
            txtEmpStat.Clear()

            frmStaff.getEmpStat()

            MsgBox("New data added.", MsgBoxStyle.Information)
            formLoad()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Public Sub formLoad()
        Try
            str = "select * from settings_empstat order by empStat"
            conn.Open()
            Dim Search As New MySqlDataAdapter(Str, conn)
            Dim ds As Data.DataSet = New Data.DataSet
            Search.Fill(ds, "settings_empstat")
            dg1.DataSource = ds.Tables("settings_empstat")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).HeaderText = "Employment Status"
            dg1.Columns(1).Width = 550


            txtEmpStat.Clear()
            btnAdd.Enabled = True
            btnDelete.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Dim i As Integer
        i = dg1.CurrentRow.Index
        lblID.Text = dg1.Item(0, i).Value
        txtEmpStat.Text = dg1.Item(1, i).Value

        btnAdd.Enabled = False
        btnDelete.Enabled = True
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            str = "delete from settings_empstat where id='" & lblID.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()

            formLoad()
            frmStaff.getEmpStat()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub frmAddEmpStat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formLoad()
    End Sub
End Class