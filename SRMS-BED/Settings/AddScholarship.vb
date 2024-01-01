Imports MySql.Data.MySqlClient
Public Class frmAddScholarship
    Dim str As String
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            If btnAdd.Text = "+ ADD" Then
                str = "insert into scholarships (Scholarship, Amount) values('" & txtScholarship.Text & "','0')"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()
                txtScholarship.Clear()

                ' frmSemStudent.getScholarship()
                frmStudeProfile.getScholarship()
                MsgBox("New data added.", MsgBoxStyle.Information)
                formLoad()
            Else
                str = "update scholarships set Scholarship='" & txtScholarship.Text & "' where scholarshipID ='" & lblID.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()
                txtScholarship.Clear()

                ' frmSemStudent.getScholarship()
                frmStudeProfile.getScholarship()
                MsgBox("New data added.", MsgBoxStyle.Information)
                formLoad()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub frmAddScholarship_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formLoad()
    End Sub
    Public Sub formLoad()
        Try
            str = "select * from scholarships order by Scholarship"
            conn.Open()
            Dim Search As New MySqlDataAdapter(Str, conn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "scholarships")
            dg1.DataSource = ds.Tables("scholarships")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).HeaderText = "Scholarship"
            dg1.Columns(1).Width = 470
            dg1.Columns(2).Visible = False


            txtScholarship.Clear()

            btnDelete.Enabled = False
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
        txtScholarship.Text = dg1.Item(1, i).Value

        btnAdd.Enabled = True
        btnAdd.Text = "UPDATE"
        btnDelete.Enabled = True
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            str = "delete from scholarships where scholarshipID='" & lblID.Text & "'"
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

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class