Imports MySql.Data.MySqlClient
Public Class frmSearchMedicalRecords
    Dim str As String
    Private Sub frmSearchMedicalRecords_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtSearch.Clear()
        Try
            str = "SELECT m.mrID, m.StudentNumber, CONCAT(p.FirstName, ' ', LEFT(p.MiddleName, 1), '. ', p.LastName) AS FullName, p.FirstName, p.MiddleName, p.LastName, m.caseNo, m.incidentDate, m.complaint, m.temperature, m.bp, m.painTolerance, m.otherDetails, m.medication, m.otherNotes FROM medical_records m join studeprofile p on m.StudentNumber=p.StudentNumber order by p.LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "medical_records, studeprofile")
            dg1.DataSource = ds.Tables("medical_records, studeprofile")
            conn.Close()
            dg1.Columns(0).Visible = False
            dg1.Columns(1).HeaderText = "Student Number"
            dg1.Columns(2).HeaderText = "Student Name"
            dg1.Columns(3).Visible = False
            dg1.Columns(4).Visible = False
            dg1.Columns(5).Visible = False
            dg1.Columns(6).HeaderText = "Case No."
            dg1.Columns(7).HeaderText = "Incident Date"
            dg1.Columns(8).HeaderText = "Major Complaint"
            dg1.Columns(9).HeaderText = "Temperature"
            dg1.Columns(10).HeaderText = "Blood Pressure"
            dg1.Columns(11).HeaderText = "Pain Tolerance"
            dg1.Columns(12).HeaderText = "Other Details"
            dg1.Columns(13).HeaderText = "Medication"
            dg1.Columns(14).HeaderText = "Notes"
         
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "SELECT m.mrID, m.StudentNumber, CONCAT(p.FirstName, ' ', LEFT(p.MiddleName, 1), '. ', p.LastName) AS FullName, p.FirstName, p.MiddleName, p.LastName, m.caseNo, m.incidentDate, m.complaint, m.temperature, m.bp, m.painTolerance, m.otherDetails, m.medication, m.otherNotes FROM medical_records m join studeprofile p on m.StudentNumber=p.StudentNumber where m.StudentNumber like '%" & txtSearch.Text & "%' or p.LastName like '%" & txtSearch.Text & "%' order by p.LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "medical_records, studeprofile")
            dg1.DataSource = ds.Tables("medical_records, studeprofile")
            conn.Close()
            dg1.Columns(0).Visible = False
            dg1.Columns(1).HeaderText = "Student Number"
            dg1.Columns(2).HeaderText = "Student Name"
            dg1.Columns(3).Visible = False
            dg1.Columns(4).Visible = False
            dg1.Columns(5).Visible = False
            dg1.Columns(6).HeaderText = "Case No."
            dg1.Columns(7).HeaderText = "Incident Date"
            dg1.Columns(8).HeaderText = "Major Complaint"
            dg1.Columns(9).HeaderText = "Temperature"
            dg1.Columns(10).HeaderText = "Blood Pressure"
            dg1.Columns(11).HeaderText = "Pain Tolerance"
            dg1.Columns(12).HeaderText = "Other Details"
            dg1.Columns(13).HeaderText = "Medication"
            dg1.Columns(14).HeaderText = "Notes"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Try

            Dim i As Integer
            i = dg1.CurrentRow.Index
            frmAddMedicalRecords.lblMedID.Text = dg1(0, i).Value
            frmAddMedicalRecords.txtStudenNumber.Text = dg1(1, i).Value
            frmAddMedicalRecords.txtFname.Text = dg1.Item(3, i).Value
            frmAddMedicalRecords.txtMname.Text = dg1(4, i).Value
            frmAddMedicalRecords.txtLname.Text = dg1(5, i).Value
            frmAddMedicalRecords.txtCaseNo.Text = dg1.Item(6, i).Value
            frmAddMedicalRecords.dtpDate.Text = dg1.Item(7, i).Value
            frmAddMedicalRecords.txtMajorComplaint.Text = dg1(8, i).Value
            frmAddMedicalRecords.txtTemperature.Text = dg1(9, i).Value
            frmAddMedicalRecords.txtBP.Text = dg1(10, i).Value
            frmAddMedicalRecords.txtPainTolerance.Text = dg1(11, i).Value
            frmAddMedicalRecords.txtOtherDetails.Text = dg1.Item(12, i).Value
            frmAddMedicalRecords.txtMedication.Text = dg1(13, i).Value
            frmAddMedicalRecords.txtNotes.Text = dg1(14, i).Value
          
            frmAddMedicalRecords.tsSave.Enabled = False
            frmAddMedicalRecords.tsUpdate.Enabled = True
            frmAddMedicalRecords.tsDelete.Enabled = True
            frmAddMedicalRecords.Button1.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

        Me.Close()
    End Sub
End Class