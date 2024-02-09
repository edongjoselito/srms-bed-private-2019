Imports MySql.Data.MySqlClient
Public Class frmChangePassword
    Dim str As String
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim pass As String

        If txtNewPassword.Text <> txtConfirm.Text Then
            MsgBox("Password not matched!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        pass = getSHA1Hash(txtConfirm.Text)

        Str = "update users set password='" & pass & "' where username='" & frmTeacher.stUser.Text & "'"
        conn.Open()
        Dim mysc As New MySqlCommand(Str, conn)
        mysc.ExecuteNonQuery()
        conn.Close()
        MsgBox("Your password has been updated!", MsgBoxStyle.Information)

        Me.Close()
    End Sub
End Class