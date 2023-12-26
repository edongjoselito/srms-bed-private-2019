Imports MySql.Data.MySqlClient
Public Class frmAdmin
    Dim str As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'getDepartment()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        frmProgramsOffer.ShowDialog()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)
        frmTrack.ShowDialog()
    End Sub
    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs)
        frmSubjects.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frmProgramsOffer.ShowDialog()
    End Sub

    Private Sub ToolStripButton2_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        frmTrack.ShowDialog()
    End Sub

    Private Sub ToolStripButton4_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        frmSubjects.ShowDialog()
    End Sub
End Class