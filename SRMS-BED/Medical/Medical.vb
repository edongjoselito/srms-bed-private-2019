Imports MySql.Data.MySqlClient
Public Class frmMedical
    Dim str As String
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If lblAccountLevel.Text = "Super Admin" Then
            Me.Close()
        ElseIf lblAccountLevel.Text = "Admin" Then
            Me.Close()
        Else
            End
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        frmAddMedicalInfo.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frmAddMedicalRecords.ShowDialog()
    End Sub
End Class