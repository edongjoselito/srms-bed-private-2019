Imports MySql.Data.MySqlClient
Public Class frmManageUsers
    Dim str As String
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Public Sub FormLoad()
        Try
            str = "select * from users where position!='Super Admin'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "users")
            dgUser.DataSource = ds.Tables("users")
            conn.Close()

            dgUser.Columns(0).HeaderText = "USERNAME"
            dgUser.Columns(1).HeaderText = "PASSWORD"
            dgUser.Columns(1).Width = 200
            dgUser.Columns(1).Visible = False
            dgUser.Columns(2).HeaderText = "SYSTEM ACCESS"
            dgUser.Columns(3).HeaderText = "FIRST NAME"
            dgUser.Columns(3).Width = 100
            dgUser.Columns(4).HeaderText = "MIDDLE NAME"
            dgUser.Columns(4).Width = 100
            dgUser.Columns(5).HeaderText = "LAST NAME"
            dgUser.Columns(5).Width = 100
            dgUser.Columns(6).HeaderText = "E-MAIL"
            dgUser.Columns(7).Visible = False
            dgUser.Columns(8).HeaderText = "ACCT. STATUS"
            dgUser.Columns(9).HeaderText = "DATE CREATED"
            dgUser.Columns(10).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

        btnSave.Text = "SAVE"
        btnDelete.Visible = False
        btnResetPassword.Visible = False

        txtFName.Clear()
        txtMName.Clear()
        txtLName.Clear()
        txtUsername.Clear()
        txtpassword1.Clear()
        txtConfirm.Clear()
        cboposition.ResetText()
        txtEmail.Clear()

        txtFName.Focus()

    End Sub

    Private Sub frmManageUsers_Load(sender As Object, e As EventArgs) Handles Me.Load
        FormLoad()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select * from users where username like '%" & txtSearch.Text & "%' or lName like '%" & txtSearch.Text & "%'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "users")
            dgUser.DataSource = ds.Tables("users")
            conn.Close()

            dgUser.Columns(0).HeaderText = "USERNAME"
            dgUser.Columns(1).HeaderText = "PASSWORD"
            dgUser.Columns(1).Width = 200
            dgUser.Columns(1).Visible = False
            dgUser.Columns(2).HeaderText = "SYSTEM ACCESS"
            dgUser.Columns(3).HeaderText = "FIRST NAME"
            dgUser.Columns(3).Width = 100
            dgUser.Columns(4).HeaderText = "MIDDLE NAME"
            dgUser.Columns(4).Width = 100
            dgUser.Columns(5).HeaderText = "LAST NAME"
            dgUser.Columns(5).Width = 100
            dgUser.Columns(6).HeaderText = "E-MAIL"
            dgUser.Columns(7).Visible = False
            dgUser.Columns(8).HeaderText = "ACCT. STATUS"
            dgUser.Columns(9).HeaderText = "DATE CREATED"
            dgUser.Columns(10).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub dgUser_DoubleClick(sender As Object, e As EventArgs) Handles dgUser.DoubleClick
        Try
            Dim dclick As Integer
            dclick = dgUser.CurrentRow.Index

            txtUsername.Text = dgUser.Item(0, dclick).Value
            lblOldUsername.Text = dgUser.Item(0, dclick).Value
            cboposition.Text = dgUser.Item(2, dclick).Value
            txtFName.Text = dgUser.Item(3, dclick).Value
            txtMName.Text = dgUser.Item(4, dclick).Value
            txtLName.Text = dgUser.Item(5, dclick).Value
            'txtpassword1.Text = getSHA1Hash(dgUser.Item(1, dclick).Value)
            'txtConfirm.Text = getSHA1Hash(dgUser.Item(1, dclick).Value)

            txtEmail.Text = dgUser.Item(6, dclick).Value

            txtFName.ReadOnly = True
            txtpassword1.ReadOnly = True
            txtConfirm.ReadOnly = True

            txtpassword1.Enabled = False
            txtConfirm.Enabled = False

            btnSave.Text = "UPDATE"
            btnDelete.Visible = True
            btnResetPassword.Visible = True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If btnSave.Text = "SAVE" Then
                If txtFName.Text = "" Then
                    MsgBox("Username is required!", MsgBoxStyle.Exclamation)
                    txtFName.Focus()
                    Exit Sub
                End If

                If txtpassword1.Text = "" Then
                    MsgBox("Please enter your password!", MsgBoxStyle.Information)
                    txtpassword1.Focus()
                    Exit Sub
                End If
                Dim pass As String

                If txtpassword1.Text <> txtConfirm.Text Then
                    MsgBox("Password not matched!", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If

                pass = getSHA1Hash(txtConfirm.Text)


                str = "select * from users where username='" & txtFName.Text & "'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "users")
                conn.Close()
                If ds.Tables("users").Rows.Count = 1 Then
                    MsgBox("username already in used! please try again.", MsgBoxStyle.Information)
                    conn.Close()
                    txtFName.Focus()
                    Exit Sub
                End If
                Dim Name As String
                Name = txtFName.Text + txtMName.Text + txtLName.Text

                str = "insert into users values('" & txtUsername.Text & "','" & pass & "','" & cboposition.Text & "','" & txtFName.Text & "','" & txtMName.Text & "','" & txtLName.Text & "','" & txtEmail.Text & "','avatar.png','active','" & Convert.ToDateTime(frmAdmin.stDate.Text).ToString("yyyy-MM-dd") & "','" & Name & "')"
                conn.Open()
                Dim mysC As New MySqlCommand(str, conn)
                mysC.ExecuteNonQuery()
                MsgBox("One (1) record added successfully!", MsgBoxStyle.Information)
                'Save()
                conn.Close()
                FormLoad()

            Else
                str = "update users set username='" & txtUsername.Text & "',position='" & cboposition.Text & "',email='" & txtEmail.Text & "' where username='" & lblOldUsername.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                MsgBox("The selected account has been updated!", MsgBoxStyle.Information)
                conn.Close()
                FormLoad()

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try



    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from users where username='" & lblOldUsername.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                'Delete()
                conn.Close()
                FormLoad()

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnResetPassword.Click
        frmResetPass.ShowDialog()
    End Sub

    Private Sub btnaddstude_Click(sender As Object, e As EventArgs) Handles btnaddstude.Click
        frmCompleteList.lblSource.Text = "Users"
        frmCompleteList.ShowDialog()
    End Sub

    Private Sub btnaddemployee_Click(sender As Object, e As EventArgs) Handles btnaddemployee.Click
        frmSearchPersonnel.lblSource.Text = "Users"
        frmSearchPersonnel.ShowDialog()

    End Sub
End Class