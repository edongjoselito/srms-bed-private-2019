Imports MySql.Data.MySqlClient
Public Class frmLoginForm
    Dim str As String
    Private Sub frmLoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtUserName.Focus()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Dim level As String
            Dim pass As String

            pass = getSHA1Hash(txtpassword.Text)

            str = "select * from users where username='" & txtUserName.Text & "' and password='" & pass & "' and acctStat='active'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "users")

            If ds.Tables("users").Rows.Count = 1 Then
                level = ds.Tables("users").Rows(0).Item(2)

                txtpassword.Clear()
                Me.Hide()
                frmSemesterChoice.lblLevel.Text = level
                frmSemesterChoice.Show()
                frmSemesterChoice.TopMost = True
                frmSemesterChoice.lblUser.Text = txtUserName.Text
                conn.Close()

            Else
                MsgBox("Incorrect username or password!", MsgBoxStyle.Exclamation)
                formload()
                conn.Close()
                Exit Sub
            End If
            conn.Close()
            'frmParent.getAcctLevel()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub formLoad()
        txtUserName.Clear()
        txtpassword.Clear()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        End
    End Sub
End Class