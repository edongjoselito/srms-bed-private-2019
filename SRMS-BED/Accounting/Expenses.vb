Imports MySql.Data.MySqlClient
Public Class frmExpenses
    Dim str As String
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If btnSave.Text = "SAVE" Then
                If txtDescription.Text = "" Then
                    MsgBox("Please input description!", MsgBoxStyle.Information)
                    txtDescription.Focus()
                    Exit Sub
                End If
                str = "insert into expenses values('0','" & txtDescription.Text & "','" & txtAmount.Text & "','" & txtResponsible.Text & "','" & Convert.ToDateTime(dtpDate.Text).ToString("yyyy-MM-dd H:mm:ss") & "','" & cboCategory.Text & "','" & frmAccounting.lblSettingsID.Text & "')"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                MsgBox("One record added!", MsgBoxStyle.Information)
                conn.Close()
                formLoad()
            Else
                str = "update expenses Set Description='" & txtDescription.Text & "',Amount='" & txtAmount.Text & "',Responsible='" & txtResponsible.Text & "',ExpenseDate='" & Convert.ToDateTime(dtpDate.Text).ToString("yyyy-MM-dd") & "',Category='" & cboCategory.Text & "' where expensesid='" & lblID.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                MsgBox("The selected data successfully updated!", MsgBoxStyle.Information)
                conn.Close()
                formLoad()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Public Sub formLoad()
        btnSave.Text = "SAVE"
        btnDelete.Visible = False

        'dtpDate.Text = Convert.ToDateTime(Today).ToString("yyyy-MM-dd")
        dtpDate.Text = Today
        txtDescription.Clear()
        cboCategory.ResetText()
        txtAmount.Text = "0.00"
        txtResponsible.Clear()
        txtDescription.Focus()

        getExpenses()

    End Sub

    Private Sub frmExpenses_Load(sender As Object, e As EventArgs) Handles Me.Load
        formLoad()
    End Sub

    Public Sub getExpenses()
        Try
            str = "select * from expenses where ExpenseDate='" & Convert.ToDateTime(frmAccounting.stDate.Text).ToString("yyyy-MM-dd") & "' order by ExpenseDate Desc"
            'str = "select * from expenses  order by ExpenseDate Desc"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "expenses")
            dg1.DataSource = ds.Tables("expenses")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).Width = 200
            dg1.Columns(1).HeaderText = "DESCRIPTION"
            dg1.Columns(2).Width = 75
            dg1.Columns(2).HeaderText = "AMOUNT"
            dg1.Columns(3).Width = 150
            dg1.Columns(3).HeaderText = "RESPONSIBLE"
            dg1.Columns(4).HeaderText = "EXPENSE DATE"
            dg1.Columns(5).HeaderText = "CATEGORY"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        'getExpensePerDay()
    End Sub

    Private Sub dg1_DoubleClick(sender As Object, e As EventArgs) Handles dg1.DoubleClick
        Dim i As Integer
        i = dg1.CurrentRow.Index
        lblID.Text = dg1.Item(0, i).Value
        txtDescription.Text = dg1.Item(1, i).Value
        txtAmount.Text = dg1.Item(2, i).Value
        txtResponsible.Text = dg1.Item(3, i).Value
        dtpDate.Text = dg1.Item(4, i).Value
        cboCategory.Text = dg1.Item(5, i).Value

        btnSave.Text = "UPDATE"
        btnDelete.Visible = True
        btnDelete.Enabled = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        formLoad()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from expenses where expensesid='" & lblID.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                MsgBox("The selected record has been deleted!", MsgBoxStyle.Information)
                conn.Close()
                formLoad()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select * from expenses where Description like '%" & txtSearch.Text & "%' or Responsible like '%" & txtSearch.Text & "%' order by ExpenseDate Desc"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "expenses")
            dg1.DataSource = ds.Tables("expenses")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).Width = 200
            dg1.Columns(1).HeaderText = "DESCRIPTION"
            dg1.Columns(2).Width = 75
            dg1.Columns(2).HeaderText = "AMOUNT"
            dg1.Columns(3).Width = 150
            dg1.Columns(3).HeaderText = "RESPONSIBLE"
            dg1.Columns(4).HeaderText = "EXPENSE DATE"
            dg1.Columns(5).HeaderText = "CATEGORY"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class