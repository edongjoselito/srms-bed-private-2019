Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frmBackup
    Dim str As String
    Dim SqlConnection As MySqlConnection
    Dim dt As New DataTable
    Dim dtseCt As Integer
    Dim da As MySqlDataAdapter
    Private Sub frmBackup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getDatabasename()
    End Sub
    Public Sub getDatabasename()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select dbName from srms_settings limit 1"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                cboDatabase.Text = dtReader(0)
               
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Public Sub connect()
        Try

            SqlConnection = New MySqlConnection("Server=" & txtServer.Text & ";user id=" & txtUserID.Text & ";password=" & txtPassword.Text & ";charset='utf8'")
            If SqlConnection.State = ConnectionState.Closed Then
                SqlConnection.Open()

            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Connection not found!")
            conn.Close()
        End Try
    End Sub

    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        Try
            connect()
            str = "SELECT DISTINCT TABLE_SCHEMA FROM information_schema.TABLES"
            da = New MySqlDataAdapter(str, SqlConnection)
            da.Fill(dt)
            dtseCt = 0


            cboDatabase.Enabled = True
            cboDatabase.Items.Clear()
            cboDatabase.Items.Add("--Select Database--")

            While dtseCt < dt.Rows.Count

                cboDatabase.Items.Add(dt.Rows(dtseCt)(0).ToString())
                dtseCt = dtseCt + 1


            End While
            cboDatabase.SelectedIndex = 0
            btnConnect.Enabled = False
            btnBackup.Enabled = True
            btnRestore.Enabled = True

            SqlConnection.Clone()
            dt.Dispose()
            da.Dispose()




        Catch ex As Exception
            MsgBox("Connection Failed")
        End Try
    End Sub

    Private Sub btnBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackup.Click
        Dim dbFile As String
        Try
            SaveFileDialog1.Filter = "SQL Dump File (*.sql)|*.sql|All files (*.*)|*.*"
            SaveFileDialog1.FileName = "Database Backup" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".sql"

            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                connect()
                dbFile = SaveFileDialog1.FileName

                Dim BackupProcess As New Process
                BackupProcess.StartInfo.FileName = "cmd.exe"
                BackupProcess.StartInfo.UseShellExecute = False
                BackupProcess.StartInfo.WorkingDirectory = "C:\Program Files (x86)\MySQL\MySQL Server 5.4\bin\"
                BackupProcess.StartInfo.RedirectStandardInput = True
                BackupProcess.StartInfo.RedirectStandardOutput = True
                BackupProcess.Start()

                Dim BackupStream As StreamWriter = BackupProcess.StandardInput
                Dim myStreamReader As StreamReader = BackupProcess.StandardOutput
                BackupStream.WriteLine("mysqldump --routines --user=" & txtUserID.Text & " --password=" & txtPassword.Text & " -h " & txtServer.Text & " " & cboDatabase.Text & " > """ + dbFile + """")

                BackupStream.Close()
                BackupProcess.WaitForExit()
                BackupProcess.Close()
                conn.Close()

                MsgBox("Database backup created successfully!", MsgBoxStyle.Information, "Backup Database")





            End If

        Catch ex As Exception
            MsgBox("Nothing to do!")
        End Try
    End Sub

    Private Sub btnRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestore.Click
        Dim dbFile As String
        Try
            OpenFileDialog1.Filter = "SQL Dump File (*.sql)|*.sql|All files (*.*)|*.*"
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                connect()
                dbFile = OpenFileDialog1.FileName

                Dim BackupProcess As New Process
                BackupProcess.StartInfo.FileName = "cmd.exe"
                BackupProcess.StartInfo.UseShellExecute = False
                BackupProcess.StartInfo.WorkingDirectory = "C:\Program Files (x86)\MySQL\MySQL Server 5.4\bin\"
                BackupProcess.StartInfo.RedirectStandardInput = True
                BackupProcess.StartInfo.RedirectStandardOutput = True
                BackupProcess.StartInfo.CreateNoWindow = True
                BackupProcess.Start()

                Dim BackupStream As StreamWriter = BackupProcess.StandardInput
                Dim myStreamReader As StreamReader = BackupProcess.StandardOutput
                BackupStream.WriteLine("mysql --user=" & txtUserID.Text & " --password=" & txtPassword.Text & " -h " & txtServer.Text & " " & cboDatabase.Text & " < """ + dbFile + """")

                BackupStream.Close()
                BackupProcess.WaitForExit()
                BackupProcess.Close()
                SqlConnection.Close()

                MsgBox("Database successfully restored!", MsgBoxStyle.Information, "Restore Database")


            End If

        Catch ex As Exception
            MsgBox("Nothing to do!")
            conn.Close()
        End Try
    End Sub
End Class