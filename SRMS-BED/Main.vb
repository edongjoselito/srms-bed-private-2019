Imports MySql.Data.MySqlClient
Public Class frmMain
    Dim str As String

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        End
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

        countStaff()
        countStudents()
        schoolInfo()

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
                lblSchoolName.Text = dtReader(5)
                lblSchoolAddress.Text = dtReader(6)
                conn.Close()
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Public Sub countStaff()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            Str = "select count(IDNumber) as TotalEmployee from staff"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(Str, conn)
            dtReader = objCmd.ExecuteReader()

            If dtReader.Read Then
                lblStaff.Text = Format(dtReader(0), "#,###")
            End If

            If lblStaff.Text = "" Then
                lblStaff.Text = 0
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

    End Sub

    Public Sub countStudents()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            Str = "select count(StudentNumber) as TotalStudents from studeprofile"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(Str, conn)
            dtReader = objCmd.ExecuteReader()

            If dtReader.Read Then
                lblStudents.Text = Format(dtReader(0), "#,###")
            End If

            If lblStudents.Text = "" Then
                lblStudents.Text = 0
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

    End Sub

    Private Sub stDate_Click(sender As Object, e As EventArgs) Handles stDate.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        stDate.Text = Now
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        frmAdmin.stSemester.Text = stSemester.Text
        frmAdmin.stSY.Text = stSY.Text
        frmAdmin.stUser.Text = stUser.Text
        frmAdmin.ShowDialog()
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        frmRegistrar.stSemester.Text = stSemester.Text
        frmRegistrar.stSY.Text = stSY.Text
        frmRegistrar.stUser.Text = stUser.Text
        frmRegistrar.ShowDialog()
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        frmAccounting.stSemester.Text = stSemester.Text
        frmAccounting.stSY.Text = stSY.Text
        frmAccounting.stUser.Text = stUser.Text
        frmAccounting.ShowDialog()
    End Sub

    Private Sub IconButton6_Click(sender As Object, e As EventArgs) Handles IconButton6.Click
        frmReportsDashboard.stSemester.Text = stSemester.Text
        frmReportsDashboard.stSY.Text = stSY.Text
        frmReportsDashboard.stUser.Text = stUser.Text
        frmReportsDashboard.ShowDialog()
    End Sub

    Private Sub IconButton9_Click(sender As Object, e As EventArgs) Handles IconButton9.Click
        frmHR.stSemester.Text = stSemester.Text
        frmHR.stSY.Text = stSY.Text
        frmHR.stUser.Text = stUser.Text
        frmHR.ShowDialog()
    End Sub
    Private Sub IconButton10_Click(sender As Object, e As EventArgs) Handles IconButton10.Click
        frmMedical.stSemester.Text = stSemester.Text
        frmMedical.stSY.Text = stSY.Text
        frmMedical.stUser.Text = stUser.Text
        frmMedical.ShowDialog()
    End Sub

    Private Sub IconButton11_Click(sender As Object, e As EventArgs) Handles IconButton11.Click
        frmGuidance.stSemester.Text = stSemester.Text
        frmGuidance.stSY.Text = stSY.Text
        frmGuidance.stUser.Text = stUser.Text
        frmGuidance.ShowDialog()
    End Sub

    Private Sub IconButton7_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        frmSettings.ShowDialog()
    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub IconButton12_Click(sender As Object, e As EventArgs)
        frmBackup.ShowDialog()
    End Sub

    Private Sub IconButton12_Click_1(sender As Object, e As EventArgs) Handles IconButton12.Click
        frmSemChoiceV2.ShowDialog()
    End Sub
End Class
