Public Class frmSemChoiceV2
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        frmAdmin.stSemester.Text = cboSem.Text
        frmAdmin.stSY.Text = txtSYfrom.Text + "-" + txtSYto.Text

        frmRegistrar.stSemester.Text = cboSem.Text
        frmRegistrar.stSY.Text = txtSYfrom.Text + "-" + txtSYto.Text

        ' frmAccountingForm.lblSem.Text = cboSem.Text
        ' frmAccountingForm.lblSY.Text = txtSYfrom.Text + "-" + txtSYto.Text

        ' frmAdmissionForm.lblSem.Text = cboSem.Text
        ' frmAdmissionForm.lblSY.Text = txtSYfrom.Text + "-" + txtSYto.Text

        Me.Close()
    End Sub

    Private Sub txtSYfrom_TextChanged(sender As Object, e As EventArgs) Handles txtSYfrom.TextChanged
        txtSYto.Text = Val(txtSYfrom.Text) + 1
    End Sub
End Class