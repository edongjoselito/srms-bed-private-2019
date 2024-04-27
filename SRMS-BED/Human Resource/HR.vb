Imports MySql.Data.MySqlClient
Public Class frmHR
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

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frmStaff.ShowDialog()
    End Sub

    Private Sub ACCOUNTSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACCOUNTSToolStripMenuItem.Click
        Try
            Str = "SELECT * FROM staff s join srms_settings st on s.settingsID=st.settingsID order by s.LastName"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(Str, conn)
            Dim mysds As New Data.DataSet
            mysDA.Fill(mysds, "staff, srms_settings")
            Dim obj As New PersonnelList
            obj.SetDataSource(mysds.Tables("staff, srms_settings"))
            crViewer.ReportSource = obj
            crViewer.Refresh()
            conn.Close()
            crViewer.Visible = True


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub crViewer_Load(sender As Object, e As EventArgs) Handles crViewer.Load

    End Sub

    Private Sub OTHERSERVICESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OTHERSERVICESToolStripMenuItem.Click
        frmByDepartment.Show()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        frmLoading.Show()
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub frmHR_Load(sender As Object, e As EventArgs) Handles Me.Load
        formLoad()
    End Sub

    Public Sub formLoad()
        crViewer.Visible = False

    End Sub

    Private Sub FormloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormloadToolStripMenuItem.Click
        formLoad()
    End Sub
End Class