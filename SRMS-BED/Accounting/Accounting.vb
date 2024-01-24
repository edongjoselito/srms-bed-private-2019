Imports MySql.Data.MySqlClient
Public Class frmAccounting
    Dim str As String
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub FEESDESCRIPTIONToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmFees.ShowDialog()
    End Sub

    Private Sub FEESDESCRIPTIONToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FEESDESCRIPTIONToolStripMenuItem1.Click
        frmFees.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frmBilling.ShowDialog()
    End Sub

    Private Sub ACCOUNTSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACCOUNTSToolStripMenuItem.Click
        frmPayment.Show()
    End Sub

    Private Sub OTHERSERVICESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OTHERSERVICESToolStripMenuItem.Click
        frmOtherIncome.Show()
    End Sub

    Public Sub formLoad()
        stDate.Text = Today
        crViewer.Visible = False
    End Sub

    Private Sub ReloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadToolStripMenuItem.Click
        formLoad()
    End Sub


    Private Sub frmAccounting_Load(sender As Object, e As EventArgs) Handles Me.Load
        formLoad()
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        formLoad()
    End Sub


End Class