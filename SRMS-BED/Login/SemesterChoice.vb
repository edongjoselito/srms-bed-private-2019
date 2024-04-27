Imports MySql.Data.MySqlClient
Public Class frmSemesterChoice
    Dim str As String
    Private Sub txtSYfrom_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSYfrom.KeyDown
        If e.KeyCode = Keys.Enter Then
            changesem()
            conn.Close()
        End If
    End Sub
  
    Public Sub changesem()
        Try
            If txtSYfrom.Text = "" Then
                MsgBox("Please enter valid SCHOOL YEAR!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Select Case lblLevel.Text

                Case "Super Admin"
                    frmMain.stSemester.Text = cboSem.Text
                    frmMain.stSY.Text = txtSYfrom.Text + "-" + txtSYto.Text
                    frmMain.stUser.Text = lblUser.Text
                    frmMain.lblAccountLevel.Text = lblLevel.Text
                    frmAccounting.lblAccountLevel.Text = lblLevel.Text
                    frmRegistrar.lblAccountLevel.Text = lblLevel.Text
                    frmHR.lblAccountLevel.Text = lblLevel.Text
                    frmMedical.lblAccountLevel.Text = lblLevel.Text
                    frmGuidance.lblAccountLevel.Text = lblLevel.Text
                    Me.Hide()
                    frmMain.schoolInfo()
                    frmMain.ShowDialog()

                Case "Admin"
                    frmMain.stSemester.Text = cboSem.Text
                    frmMain.stSY.Text = txtSYfrom.Text + "-" + txtSYto.Text
                    frmMain.stUser.Text = lblUser.Text
                    frmMain.btnSettings.Visible = False
                    frmMain.lblAccountLevel.Text = lblLevel.Text
                    frmAccounting.lblAccountLevel.Text = lblLevel.Text
                    frmRegistrar.lblAccountLevel.Text = lblLevel.Text
                    frmHR.lblAccountLevel.Text = lblLevel.Text
                    frmMedical.lblAccountLevel.Text = lblLevel.Text
                    frmGuidance.lblAccountLevel.Text = lblLevel.Text
                    Me.Hide()
                    frmMain.schoolInfo()
                    frmMain.ShowDialog()

                Case "Principal", "Registrar", "Academic Officer"
                    frmRegistrar.stSemester.Text = cboSem.Text
                    frmRegistrar.stSY.Text = txtSYfrom.Text + "-" + txtSYto.Text
                    frmRegistrar.stUser.Text = lblUser.Text
                    frmRegistrar.lblAccountLevel.Text = lblLevel.Text
                    Me.Hide()
                    frmRegistrar.schoolInfo()
                    frmRegistrar.ShowDialog()


                Case "Accounting"
                    frmAccounting.stSemester.Text = cboSem.Text
                    frmAccounting.stSY.Text = txtSYfrom.Text + "-" + txtSYto.Text
                    frmAccounting.stUser.Text = lblUser.Text
                    frmAccounting.lblAccountLevel.Text = lblLevel.Text
                    Me.Hide()
                    frmAccounting.schoolInfo()
                    frmAccounting.ShowDialog()

                Case "Cashier"
                    frmAccounting.stSemester.Text = cboSem.Text
                    frmAccounting.stSY.Text = txtSYfrom.Text + "-" + txtSYto.Text
                    frmAccounting.stUser.Text = lblUser.Text
                    frmAccounting.tsAcccounts.Enabled = False
                    frmAccounting.tsSchoolExpenses.Enabled = False
                    frmAccounting.tsOR.Enabled = False
                    frmAccounting.tsReports.Enabled = False
                    frmAccounting.tsFeesDescription.Enabled = False
                    frmAccounting.lblAccountLevel.Text = lblLevel.Text

                    Me.Hide()
                    frmAccounting.schoolInfo()
                    frmAccounting.ShowDialog()

                Case "Guidance"
                    frmGuidance.stSemester.Text = cboSem.Text
                    frmGuidance.stSY.Text = txtSYfrom.Text + "-" + txtSYto.Text
                    frmGuidance.stUser.Text = lblUser.Text
                    frmGuidance.lblAccountLevel.Text = lblLevel.Text

                    Me.Hide()
                    frmGuidance.ShowDialog()

                Case "School Nurse"
                    frmMedical.stSemester.Text = cboSem.Text
                    frmMedical.stSY.Text = txtSYfrom.Text + "-" + txtSYto.Text
                    frmMedical.stUser.Text = lblUser.Text
                    frmMedical.lblAccountLevel.Text = lblLevel.Text
                    Me.Hide()
                    frmMedical.ShowDialog()

                Case "Human Resource"
                    frmHR.stSemester.Text = cboSem.Text
                    frmHR.stSY.Text = txtSYfrom.Text + "-" + txtSYto.Text
                    frmHR.stUser.Text = lblUser.Text
                    frmHR.lblAccountLevel.Text = lblLevel.Text
                    Me.Hide()
                    frmHR.ShowDialog()

                Case "Teacher"
                    frmTeacher.stSemester.Text = cboSem.Text
                    frmTeacher.stSY.Text = txtSYfrom.Text + "-" + txtSYto.Text
                    frmTeacher.stUser.Text = lblUser.Text
                    frmTeacher.lblAccountLevel.Text = lblLevel.Text
                    Me.Hide()
                    frmTeacher.ShowDialog()

                Case "Encoder"

                Case "Student"
                    MsgBox("Access Denied.  Your account is intended for online access only.", MsgBoxStyle.Exclamation)
                    End


            End Select
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
    Private Sub txtSYfrom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSYfrom.TextChanged
        txtSYto.Text = Val(txtSYfrom.Text) + 1
    End Sub
    Private Sub txtSYto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSYto.KeyDown
        If e.KeyCode = Keys.Enter Then
            changesem()
            conn.Close()
        End If
    End Sub

    Private Sub GroupBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            changesem()
            conn.Close()
        End If
    End Sub

    Private Sub cboSem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSem.KeyDown
        If e.KeyCode = Keys.Enter Then
            changesem()
            conn.Close()
        End If
    End Sub

    Private Sub frmSemesterChoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        changesem()
        conn.Close()
    End Sub
End Class