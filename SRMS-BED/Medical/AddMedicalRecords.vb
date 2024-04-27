Imports MySql.Data.MySqlClient
Public Class frmAddMedicalRecords
    Dim str As String
    Public Sub formload()
        txtStudenNumber.Clear()
        txtFname.Clear()
        txtMname.Clear()
        txtLname.Clear()
        txtTemperature.Clear()
        txtBP.Clear()
        dtpDate.Text = Date.Now
        txtMajorComplaint.Clear()
        txtPainTolerance.Clear()
        txtMedication.Clear()
        txtOtherDetails.Clear()
        txtNotes.Clear()


        tsSave.Enabled = True
        tsUpdate.Enabled = False
        tsDelete.Enabled = False
        Button1.Enabled = True

        getCaseNo()

    End Sub
    Public Sub getCaseNo()
        Try
            Dim objCmd As New MySql.Data.MySqlClient.MySqlCommand
            Dim str As String = "SELECT caseNO FROM medical_records ORDER BY caseNo DESC LIMIT 1"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read() Then
                Dim currentCaseNo As String = dtReader.GetString(0)
                Dim nextCaseNo As Integer
                If Integer.TryParse(currentCaseNo, nextCaseNo) Then
                    txtCaseNo.Text = (nextCaseNo + 1).ToString()
                Else

                    txtCaseNo.Text = "Invalid Case Number"
                End If
            Else

                txtCaseNo.Text = "1"
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try

            If txtStudenNumber.Text = "" Then
                MsgBox("Student number is required. Please fill-up the form completely!", MsgBoxStyle.Exclamation)
                txtStudenNumber.Focus()
                Exit Sub
            End If
            conn.Close()

            Dim safemedication As String = txtMedication.Text.Replace("'", "''")

            str = "insert into medical_records (StudentNumber, caseNo, incidentDate, complaint, temperature, bp, painTolerance, otherDetails, medication, otherNotes, sem, sy) values('" & txtStudenNumber.Text & "','" & txtCaseNo.Text & "','" & Convert.ToDateTime(dtpDate.Text).ToString("yyyy-MM-dd") & "','" & txtMajorComplaint.Text & "','" & txtTemperature.Text & "','" & txtBP.Text & "','" & txtPainTolerance.Text & "','" & txtOtherDetails.Text & "','" & safemedication & "','" & txtNotes.Text & "','" & frmMedical.stSemester.Text & "','" & frmMedical.stSY.Text & "')"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.ExecuteNonQuery()
            conn.Close()


            MsgBox("Data successfully saved!", MsgBoxStyle.Information)
            formload()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmCompleteList.lblSource.Text = "Medical Records"
        frmCompleteList.ShowDialog()
    End Sub

    Private Sub frmAddMedicalRecords_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formload()

    End Sub

    Private Sub tsUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsUpdate.Click
        Try


            Dim safemedication As String = txtMedication.Text.Replace("'", "''")

            str = "update medical_records set caseNo='" & txtCaseNo.Text & "', incidentDate='" & Convert.ToDateTime(dtpDate.Text).ToString("yyyy-MM-dd") & "', complaint='" & txtMajorComplaint.Text & "', temperature='" & txtTemperature.Text & "', bp='" & txtBP.Text & "', painTolerance='" & txtPainTolerance.Text & "', otherDetails='" & txtOtherDetails.Text & "', medication='" & safemedication & "', otherNotes='" & txtNotes.Text & "', sem='" & frmMedical.stSemester.Text & "', sy='" & frmMedical.stSY.Text & "' where mrID='" & lblMedID.Text & "'"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.ExecuteNonQuery()
            conn.Close()

            MsgBox("The medical record has been successfully updated.", MsgBoxStyle.Information, "Updated Successfully")
            formload()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub tsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDelete.Click
        Try

            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from medical_records where mrID='" & lblMedID.Text & "'"
                conn.Open()
                Dim mysC As New MySqlCommand(str, conn)
                mysC.ExecuteNonQuery()
                conn.Close()


                MsgBox("The medical record has been deleted successfully!", MsgBoxStyle.Exclamation, "Deleted Successfully")
                formload()

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub txtPainTolerance_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPainTolerance.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPainTolerance_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPainTolerance.Leave
        Dim value As Integer

        If Integer.TryParse(txtPainTolerance.Text, value) Then
            If value < 1 OrElse value > 10 Then
                MsgBox("Please enter a number between 1 and 10.", MsgBoxStyle.Exclamation, "Pain Tolerance")
                'MessageBox.Show("Please enter a number between 1 and 10.")
                txtPainTolerance.Focus()
            End If
        Else
            MessageBox.Show("Please enter a valid number.")
            txtPainTolerance.Focus()
        End If
    End Sub

    Private Sub txtPainTolerance_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPainTolerance.TextChanged

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        frmSearchMedicalRecords.ShowDialog()
    End Sub
End Class