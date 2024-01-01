Imports MySql.Data.MySqlClient
Public Class frmRegistrar
    Dim str As String
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frmStudeProfile.ShowDialog()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub frmRegistrar_Load(sender As Object, e As EventArgs) Handles Me.Load
        stDate.Text = Today
        'stTime.Text = TimeOfDay.ToString("h:mm:ss tt")
        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        stTime.Text = Date.Now.ToString("hh:mm:ss")
    End Sub
End Class