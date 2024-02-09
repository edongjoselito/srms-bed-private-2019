Imports MySql.Data.MySqlClient
Public Class frmSearchMedicalInfo
    Dim str As String
    Private Sub frmSearchMedicalInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtSearch.Clear()
        Try
            str = "SELECT m.medID, m.StudentNumber, CONCAT(p.FirstName, ' ', LEFT(p.MiddleName, 1), '. ', p.LastName) AS FullName, p.FirstName, p.MiddleName, p.LastName, m.height, m.weight, m.bloodType, m.vision, m.allergiesDrugs, m.allergiesFood, m.eyeColor, m.hairColor, m.specialPhyNeeds, m.specialDieNeeds, m.respiratoryProblems FROM medical_info m join studeprofile p on m.StudentNumber=p.StudentNumber order by p.LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "medical_info, studeprofile")
            dg1.DataSource = ds.Tables("medical_info, studeprofile")
            conn.Close()
            dg1.Columns(0).Visible = False
            dg1.Columns(1).HeaderText = "Student Number"
            dg1.Columns(2).HeaderText = "Student Name"
            dg1.Columns(3).Visible = False
            dg1.Columns(4).Visible = False
            dg1.Columns(5).Visible = False
            dg1.Columns(6).HeaderText = "Height"
            dg1.Columns(7).HeaderText = "Weight"
            dg1.Columns(8).HeaderText = "Blood Type"
            dg1.Columns(9).HeaderText = "Vision"
            dg1.Columns(10).HeaderText = "Drug Allergies"
            dg1.Columns(11).HeaderText = "Food Allergies"
            dg1.Columns(12).HeaderText = "Eye Color"
            dg1.Columns(13).HeaderText = "Hair Color"
            dg1.Columns(14).HeaderText = "Special Physical Needs"
            dg1.Columns(15).HeaderText = "Special Dietary Needs"
            dg1.Columns(16).HeaderText = "Respiratory Problems"
           
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "SELECT m.medID, m.StudentNumber, CONCAT(p.FirstName, ' ', LEFT(p.MiddleName, 1), '. ', p.LastName) AS FullName, p.FirstName, p.MiddleName, p.LastName, m.height, m.weight, m.bloodType, m.vision, m.allergiesDrugs, m.allergiesFood, m.eyeColor, m.hairColor, m.specialPhyNeeds, m.specialDieNeeds, m.respiratoryProblems FROM medical_info m join studeprofile p on m.StudentNumber=p.StudentNumber where m.StudentNumber like '%" & txtSearch.Text & "%' or p.LastName like '%" & txtSearch.Text & "%' order by p.LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "medical_info, studeprofile")
            dg1.DataSource = ds.Tables("medical_info, studeprofile")
            conn.Close()
            dg1.Columns(0).Visible = False
            dg1.Columns(1).HeaderText = "Student Number"
            dg1.Columns(2).HeaderText = "Student Name"
            dg1.Columns(3).Visible = False
            dg1.Columns(4).Visible = False
            dg1.Columns(5).Visible = False
            dg1.Columns(6).HeaderText = "Height"
            dg1.Columns(7).HeaderText = "Weight"
            dg1.Columns(8).HeaderText = "Blood Type"
            dg1.Columns(9).HeaderText = "Vision"
            dg1.Columns(10).HeaderText = "Drug Allergies"
            dg1.Columns(11).HeaderText = "Food Allergies"
            dg1.Columns(12).HeaderText = "Eye Color"
            dg1.Columns(13).HeaderText = "Hair Color"
            dg1.Columns(14).HeaderText = "Special Physical Needs"
            dg1.Columns(15).HeaderText = "Special Dietary Needs"
            dg1.Columns(16).HeaderText = "Respiratory Problems"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Try

            Dim i As Integer
            i = dg1.CurrentRow.Index
            frmAddMedicalInfo.lblMedID.Text = dg1(0, i).Value
            frmAddMedicalInfo.txtStudenNumber.Text = dg1(1, i).Value
            frmAddMedicalInfo.txtFname.Text = dg1.Item(3, i).Value
            frmAddMedicalInfo.txtMname.Text = dg1(4, i).Value
            frmAddMedicalInfo.txtLname.Text = dg1(5, i).Value
            frmAddMedicalInfo.txtHeight.Text = dg1.Item(6, i).Value
            frmAddMedicalInfo.txtWeight.Text = dg1(7, i).Value
            frmAddMedicalInfo.txtBloodType.Text = dg1(8, i).Value
            frmAddMedicalInfo.txtVision.Text = dg1(9, i).Value
            frmAddMedicalInfo.txtdrugAllergies.Text = dg1(10, i).Value
            frmAddMedicalInfo.txtfoodAllergies.Text = dg1.Item(11, i).Value
            frmAddMedicalInfo.txtEyeColor.Text = dg1(12, i).Value
            frmAddMedicalInfo.txtHairColor.Text = dg1(13, i).Value
            frmAddMedicalInfo.txtSPN.Text = dg1.Item(14, i).Value
            frmAddMedicalInfo.txtSDN.Text = dg1(15, i).Value
            frmAddMedicalInfo.txtRespiratoryProb.Text = dg1.Item(16, i).Value
           
            frmAddMedicalInfo.tsSave.Enabled = False
            frmAddMedicalInfo.tsUpdate.Enabled = True
            frmAddMedicalInfo.tsDelete.Enabled = True
            frmAddMedicalInfo.Button1.Enabled = False
        
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

        Me.Close()
    End Sub
End Class