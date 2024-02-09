Imports MySql.Data.MySqlClient
Public Class frmAddCounselling
    Dim str As String
    Public Sub Formload()
        txtStudenNumber.Clear()
        txtFname.Clear()
        txtMname.Clear()
        txtLname.Clear()
        txtCounsellingNo.Clear()
        dtpDate.Text = Date.Now
        txtDetails.Clear()
        txtActionTaken.Clear()
     

        tsSave.Enabled = True
        tsUpdate.Enabled = False
        tsDelete.Enabled = False
        Button1.Enabled = True
    End Sub
    Private Sub frmAddCounselling_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Formload()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmCompleteList.lblSource.Text = "Counselling"
        frmCompleteList.ShowDialog()
    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try

            If txtStudenNumber.Text = "" Then
                MsgBox("Student number is required. Please fill-up the form completely!", MsgBoxStyle.Exclamation)
                txtStudenNumber.Focus()
                Exit Sub
            End If

            If txtCounsellingNo.Text = "" Then
                MsgBox("Counseling number is required.", MsgBoxStyle.Exclamation)
                txtCounsellingNo.Focus()
                Exit Sub
            End If

            conn.Close()
            'end


            str = "insert into guidance_counselling (recordNo, recordDate, StudentNumber, details, actionPlan, returnSchedule, sem, sy) values('" & txtCounsellingNo.Text & "','" & Convert.ToDateTime(dtpDate.Text).ToString("yyyy-MM-dd") & "','" & txtStudenNumber.Text & "','" & txtDetails.Text & "','" & txtActionTaken.Text & "','','" & frmGuidance.stSemester.Text & "','" & frmGuidance.stSemester.Text & "')"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.ExecuteNonQuery()
            conn.Close()


            MsgBox("Data successfully saved!", MsgBoxStyle.Information)
            Formload()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub tsUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsUpdate.Click
        Try

            str = "update guidance_counselling set recordNo='" & txtCounsellingNo.Text & "', recordDate='" & Convert.ToDateTime(dtpDate.Text).ToString("yyyy-MM-dd") & "', details='" & txtDetails.Text & "', actionPlan='" & txtActionTaken.Text & "' where id='" & lblID.Text & "'"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.ExecuteNonQuery()
            conn.Close()

            MsgBox("The selected counselling record has been successfully updated.", MsgBoxStyle.Information, "Updated Successfully")
            Formload()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub tsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDelete.Click
        Try

            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from guidance_counselling where id='" & lblID.Text & "'"
                conn.Open()
                Dim mysC As New MySqlCommand(str, conn)
                mysC.ExecuteNonQuery()
                conn.Close()


                MsgBox("The selected counselling record has been deleted successfully!", MsgBoxStyle.Exclamation, "Deleted Successfully")
                Formload()

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        frmSearchCounselling.ShowDialog()
    End Sub
End Class