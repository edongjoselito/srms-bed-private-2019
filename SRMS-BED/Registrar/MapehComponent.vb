Public Class frmMapehComponent

    Private Sub frmMapehComponent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cboComp.Text = "" Then
            MsgBox("Please select subject component!", MsgBoxStyle.Exclamation)
            Exit Sub
        Else

            TeacherGradesEncoding.cboSubSubject.Text = cboComp.Text
            ' frmSecondGrading.cboSubSubject.Text = cboComp.Text
            '   frmThirdGrading.cboSubSubject.Text = cboComp.Text
            '   frmFouthGrading.cboSubSubject.Text = cboComp.Text
            '   frmEncodeGrades.txtSubComp.Text = cboComp.Text

        End If
        Me.Close()

    End Sub
End Class