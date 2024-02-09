Imports MySql.Data.MySqlClient
Public Class frmAddIncidents
    Dim str As String
    Public Sub Formload()
        txtStudenNumber.Clear()
        txtFname.Clear()
        txtMname.Clear()
        txtLname.Clear()
        txtCaseNo.Clear()
        dtpDate.Text = Date.Now
        txtPlace.Clear()
        txtOffense.Clear()
        txtSanction.Clear()
        txtActionTaken.Clear()
       

        tsSave.Enabled = True
        tsUpdate.Enabled = False
        tsDelete.Enabled = False
        Button1.Enabled = True
    End Sub

    Private Sub frmAddIncidents_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmCompleteList.lblSource.Text = "Incidents"
        frmCompleteList.ShowDialog()
    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try


            If txtStudenNumber.Text = "" Then
                MsgBox("Student number is required. Please fill-up the form completely!", MsgBoxStyle.Exclamation)
                txtStudenNumber.Focus()
                Exit Sub
            End If

            If txtCaseNo.Text = "" Then
                MsgBox("Case number is required.", MsgBoxStyle.Exclamation)
                txtCaseNo.Focus()
                Exit Sub
            End If

            conn.Close()
            'end

            str = "insert into guidance_incidents (StudentNumber, caseNo, incidentDate, incPlace, quarter, offenseLevel, offense, sanction, actionTaken, sem, sy) values('" & txtStudenNumber.Text & "','" & txtCaseNo.Text & "','" & Convert.ToDateTime(dtpDate.Text).ToString("yyyy-MM-dd") & "','" & txtPlace.Text & "','','" & cboOffenseLevel.Text & "','" & txtOffense.Text & "','" & txtSanction.Text & "','" & txtActionTaken.Text & "','" & frmGuidance.stSemester.Text & "','" & frmGuidance.stSY.Text & "')"
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

            str = "update guidance_incidents set caseNo='" & txtCaseNo.Text & "', incidentDate='" & Convert.ToDateTime(dtpDate.Text).ToString("yyyy-MM-dd") & "', incPlace='" & txtPlace.Text & "', offenseLevel='" & cboOffenseLevel.Text & "', offense='" & txtOffense.Text & "', sanction='" & txtSanction.Text & "', actionTaken='" & txtActionTaken.Text & "' where incID='" & lblincID.Text & "'"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.ExecuteNonQuery()
            conn.Close()

            MsgBox("The incident record has been successfully updated.", MsgBoxStyle.Information, "Updated Successfully")
            Formload()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub tsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDelete.Click
        Try

            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from guidance_incidents where incID='" & lblincID.Text & "'"
                conn.Open()
                Dim mysC As New MySqlCommand(str, conn)
                mysC.ExecuteNonQuery()
                conn.Close()


                MsgBox("The selected incident has been deleted successfully!", MsgBoxStyle.Exclamation, "Deleted Successfully")
                Formload()

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        frmSearchIncidents.ShowDialog()
    End Sub
End Class