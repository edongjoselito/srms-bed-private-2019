Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Public Class frmBulkUploadFees
    Dim str As String
    Dim conn1 As OleDbConnection
    Dim dtr As OleDbDataReader
    Dim dta As OleDbDataAdapter
    Dim cmd As OleDbCommand
    Dim dts As DataSet
    Dim excel As String
    Dim OpenFileDialog As New OpenFileDialog
    Private Sub btnLoadData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadData.Click
        Try
            OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            OpenFileDialog.Filter = "All Files (*.*)|*.*|Excel files (*.xlsx)|*.xlsx|CSV Files (*.csv)|*.csv|XLS Files (*.xls)|*xls"

            If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then

                Dim fi As New IO.FileInfo(OpenFileDialog.FileName)
                Dim FileName As String = OpenFileDialog.FileName

                excel = fi.FullName
                conn1 = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excel + ";Extended Properties=Excel 12.0;")
                dta = New OleDbDataAdapter("Select * From [Sheet1$]", conn1)
                dts = New DataSet
                dta.Fill(dts, "[Sheet1$]")
                dg1.DataSource = dts
                dg1.DataMember = "[Sheet1$]"
                conn.Close()
                dg1.Columns(0).Width = 450
                dg1.Columns(0).ReadOnly = True
                dg1.Columns(1).Width = 150
                dg1.Columns(1).ReadOnly = True
                'dg1.Columns(2).Width = 200
                'dg1.Columns(2).ReadOnly = True
                'dg1.Columns(3).Width = 150
                'dg1.Columns(3).ReadOnly = True
                'dg1.Columns(4).Width = 150
                'dg1.Columns(4).ReadOnly = True
               

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            For x As Integer = 0 To dg1.Rows.Count - 1
                Dim description As String
                description = dg1.Item(0, x).Value.Replace("'", "''")

                str = "insert into fees (Description, Amount, Course, Major, YearLevel, Sy) values('" & description & "','" & dg1.Item(1, x).Value & "','" & frmFees.cboCourse.Text & "','','" & frmFees.cboYearLevel.Text & "','" & frmFees.txtSY.Text & "')"
                conn.Open()
                Dim mysC As New MySqlCommand(str, conn)
                mysC.ExecuteNonQuery()
                conn.Close()
            Next

            MsgBox("Uploaded successfully!", MsgBoxStyle.Information)
            frmFees.btnViewFees.PerformClick()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class