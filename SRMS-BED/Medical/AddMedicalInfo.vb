Imports MySql.Data.MySqlClient
Public Class frmAddMedicalInfo
    Dim str As String
    Private Sub frmAddMedicalInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formload()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmCompleteList.lblSource.Text = "Medical Info"
        frmCompleteList.ShowDialog()
    End Sub

    Public Sub formload()
        txtStudenNumber.Clear()
        txtFname.Clear()
        txtMname.Clear()
        txtLname.Clear()
        txtBloodType.Clear()
        txtHeight.Clear()
        txtWeight.Clear()
        txtVision.Clear()
        txtfoodAllergies.Clear()
        txtdrugAllergies.Clear()
        txtSDN.Clear()
        txtSPN.Clear()
        txtRespiratoryProb.Clear()
        txtEyeColor.Clear()
        txtHairColor.Clear()

        tsSave.Enabled = True
        tsUpdate.Enabled = False
        tsDelete.Enabled = False
        Button1.Enabled = True

    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try
 

            'check duplicate names
            str = "select * from medical_info where StudentNumber='" & txtStudenNumber.Text & "'"
            conn.Open()
            Dim mysda1 As New MySqlDataAdapter(str, conn)
            Dim ds1 As New DataSet
            mysda1.Fill(ds1, "medical_info")

            If ds1.Tables("medical_info").Rows.Count = 1 Then
                MsgBox("Record already exist!", MsgBoxStyle.Exclamation)
                conn.Close()
                Exit Sub
            End If
            'end

            If txtStudenNumber.Text = "" Then
                MsgBox("Student number is required. Please fill-up the form completely!", MsgBoxStyle.Exclamation)
                txtStudenNumber.Focus()
                Exit Sub
            End If
            conn.Close()
            'end

            Dim safeHeight As String = txtHeight.Text.Replace("'", "''")

            str = "insert into medical_info (StudentNumber, height, weight, bloodType, vision, allergiesDrugs, allergiesFood, eyeColor, hairColor, specialPhyNeeds, specialDieNeeds, respiratoryProblems) values('" & txtStudenNumber.Text & "','" & safeHeight & "','" & txtWeight.Text & "','" & txtBloodType.Text & "','" & txtVision.Text & "','" & txtdrugAllergies.Text & "','" & txtfoodAllergies.Text & "','" & txtEyeColor.Text & "','" & txtHairColor.Text & "','" & txtSPN.Text & "','" & txtSDN.Text & "','" & txtRespiratoryProb.Text & "')"
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

    Private Sub tsNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsNew.Click
        frmSearchMedicalInfo.ShowDialog()
    End Sub

    Private Sub tsUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsUpdate.Click
        Try
          

            Dim safeHeight As String = txtHeight.Text.Replace("'", "''")

            str = "update medical_info set height='" & safeHeight & "',weight='" & txtWeight.Text & "',bloodType='" & txtBloodType.Text & "', vision='" & txtVision.Text & "', allergiesDrugs='" & txtdrugAllergies.Text & "', allergiesFood='" & txtfoodAllergies.Text & "', eyeColor='" & txtEyeColor.Text & "', hairColor='" & txtHairColor.Text & "', specialPhyNeeds='" & txtSPN.Text & "', specialDieNeeds='" & txtSDN.Text & "', respiratoryProblems='" & txtRespiratoryProb.Text & "' where medID='" & lblMedID.Text & "'"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.ExecuteNonQuery()
            conn.Close()

            MsgBox("The medical information has been successfully updated.", MsgBoxStyle.Information, "Updated Successfully")
            formload()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub tsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDelete.Click
        Try
           
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from medical_info where medID='" & lblMedID.Text & "'"
                conn.Open()
                Dim mysC As New MySqlCommand(str, conn)
                mysC.ExecuteNonQuery()
                conn.Close()


                MsgBox("The medical information has been deleted successfully!", MsgBoxStyle.Exclamation, "Deleted Successfully")
                formload()

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class