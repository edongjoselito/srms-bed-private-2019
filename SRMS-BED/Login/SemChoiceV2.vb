Public Class frmSemChoiceV2
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        frmAdmin.stSemester.Text = cboSem.Text
        frmAdmin.stSY.Text = txtSYfrom.Text + "-" + txtSYto.Text

        frmRegistrar.stSemester.Text = cboSem.Text
        frmRegistrar.stSY.Text = txtSYfrom.Text + "-" + txtSYto.Text

        frmAccounting.stSemester.Text = cboSem.Text
        frmAccounting.stSY.Text = txtSYfrom.Text + "-" + txtSYto.Text

        frmMain.stSemester.Text = cboSem.Text
        frmMain.stSY.Text = txtSYfrom.Text + "-" + txtSYto.Text

        frmTeacher.stSemester.Text = cboSem.Text
        frmTeacher.stSY.Text = txtSYfrom.Text + "-" + txtSYto.Text

        Me.Close()
    End Sub

    Private Sub txtSYfrom_TextChanged(sender As Object, e As EventArgs) Handles txtSYfrom.TextChanged
        txtSYto.Text = Val(txtSYfrom.Text) + 1
    End Sub
End Class