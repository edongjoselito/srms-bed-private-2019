Imports MySql.Data.MySqlClient
Public Class frmExpReportDashobard
    Dim str As String
    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        Try
            Str = "SELECT Description, Amount, Responsible, ExpenseDate, Category FROM expenses where ExpenseDate>= '" & Format(dtpFrom.Value.Date, "yyyy-MM-dd") & "' and ExpenseDate <= '" & Format(dtpTo.Value.Date, "yyyy-MM-dd") & "' order by ExpenseDate Desc"
            conn.Open()
            Dim mysDa As New MySqlDataAdapter(Str, conn)
            Dim mysds As New DataSet
            mysDa.Fill(mysds, "expenses")
            Dim obj As New ReportDetailedExp
            obj.SetDataSource(mysds.Tables("expenses"))
            frmAccounting.crViewer.ReportSource = obj
            conn.Close()
            frmAccounting.crViewer.Visible = True
            Me.Hide()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class