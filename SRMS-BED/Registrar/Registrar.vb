Imports MySql.Data.MySqlClient
Public Class frmRegistrar
    Dim str As String
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        frmStudeProfile.ShowDialog()
    End Sub

    Private Sub frmRegistrar_Load(sender As Object, e As EventArgs) Handles Me.Load
        formLoad()
    End Sub
    Public Sub schoolInfo()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select * from srms_settings limit 1"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lblSettingsID.Text = dtReader(0)
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        stTime.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        frmSemStudent.ShowDialog()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        frmCOR.Show()
    End Sub

    Private Sub BYSUBJECTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BYSUBJECTToolStripMenuItem.Click
        frmMasterList.Show()
    End Sub

    Private Sub BYDEPARTMENTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BYDEPARTMENTToolStripMenuItem.Click
        frmMasterlistDashboardbyCourse.ShowDialog()
    End Sub

    Private Sub BYSECTIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BYSECTIONToolStripMenuItem.Click
        frmReportPerSection.ShowDialog()
    End Sub

    Private Sub BYSPECIALIZATIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BYSPECIALIZATIONToolStripMenuItem.Click
        frmPerSpecialization.Show()
    End Sub

    Private Sub StGradingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StGradingToolStripMenuItem.Click
        frmFirstGrading.Show()
    End Sub

    Private Sub SWITCHSEMESTERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SWITCHSEMESTERToolStripMenuItem.Click
        frmSemChoiceV2.ShowDialog()
    End Sub

    Private Sub MODIFYGRADESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MODIFYGRADESToolStripMenuItem.Click
        frmModifyGrades.ShowDialog()
    End Sub

    Public Sub formLoad()
        stDate.Text = Today
        'stTime.Text = TimeOfDay.ToString("h:mm:ss tt")
        Timer1.Enabled = True
        schoolInfo()

        crViewer.Visible = False
    End Sub

    Private Sub ReloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadToolStripMenuItem.Click
        formLoad
    End Sub

    Private Sub SubjectEnlistmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubjectEnlistmentToolStripMenuItem.Click
        frmCOR.Show()
    End Sub

    Private Sub EnrollmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnrollmentToolStripMenuItem.Click
        frmSemStudent.ShowDialog()
    End Sub

    Private Sub StudentProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentProfileToolStripMenuItem.Click
        frmStudeProfile.ShowDialog()
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        formLoad()
    End Sub
End Class