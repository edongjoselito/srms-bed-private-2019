Imports MySql.Data.MySqlClient
Public Class frmSchoolSettings
    Dim str As String
    Private Sub frmSchoolSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        schoolInfo()
    End Sub

    Public Sub schoolInfo()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            Str = "select * from srms_settings limit 1"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(Str, conn)
            dtReader = objCmd.ExecuteReader()

            If dtReader.Read Then
                txtSchoolHead.Text = dtReader(3)
                txtSchoolHeadPosition.Text = dtReader(4)
                txtRegistrar.Text = dtReader(5)
                txtRegistrarPosition.Text = dtReader(6)
                txtAccountant.Text = dtReader(16)
                txtAccountantPosition.Text = dtReader(37)
                txtCashier.Text = dtReader(11)
                txtCashierPosition.Text = dtReader(12)

                ' txtVP.Text = dtReader(33)
                'txtVPPosition.Text = dtReader(34)
                'txtDeanAssistant.Text = dtReader(39)
                'txtDeanAssistantPosition.Text = dtReader(40)

                conn.Close()
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            str = "update srms_settings set SchoolHead='" & txtSchoolHead.Text & "',sHeadPosition='" & txtSchoolHeadPosition.Text & "',Registrar='" & txtRegistrar.Text & "',registrarPosition='" & txtRegistrarPosition.Text & "',cashier='" & txtCashier.Text & "',cashierPosition='" & txtCashierPosition.Text & "',accountant='" & txtAccountant.Text & "',AccountantPosition='" & txtAccountantPosition.Text & "',vp='" & txtVP.Text & "',vpPosition='" & txtVPPosition.Text & "',deanAssist='" & txtDeanAssistant.Text & "',deanAssistPosition='" & txtDeanAssistantPosition.Text & "'"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()
            MsgBox("Updated successfully!", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class