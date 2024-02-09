Imports MySql.Data.MySqlClient
Public Class frmStaff
    Dim str As String
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Public Sub FormLoad()

        schoolInfo()
        getEmpStat()

        btnSave.Enabled = True
        btnSave.Text = "SAVE"
        btnDelete.Visible = False

        btnFamily.Enabled = False
        btnEduc.Enabled = False
        btnCSE.Enabled = False
        btnWe.Enabled = False
        btnVW.Enabled = False
        btnTrainings.Enabled = False
        btnOtherInfo.Enabled = False

        mskIDNumber.Clear()
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtLastName.Clear()
        txtNameExtn.Clear()
        cboPrefix.ResetText()
        txtJobTitle.Clear()
        txtPosition.Clear()
        txtDepartment.Clear()
        cboMStatus.ResetText()
        cboEmpStatus.ResetText()
        dtpBirthDate.Text = Now
        txtBirthPlace.Clear()
        cboSex.ResetText()
        txtHeight.Clear()
        txtWeight.Clear()
        txtBloodType.Clear()
        txtGSIS.Clear()
        txtPagibig.Clear()
        txtPhilHealth.Clear()
        txtSSS.Clear()
        txtTIN.Clear()
        dtpHiredDate.Text = Now
        txtResHouseNo.Clear()
        txtResStreet.Clear()
        txtResVillage.Clear()
        txtResBrgy.Clear()
        txtResCity.Clear()
        txtResProvince.Clear()
        txtResZip.Clear()
        txtPerHouseNo.Clear()
        txtPerStreet.Clear()
        txtPerVillage.Clear()
        txtPerBrgy.Clear()
        txtPerCity.Clear()
        txtPerProvince.Clear()
        txtPerZip.Clear()
        txtTelNo.Clear()
        txtMobile.Clear()
        txtEmailAd.Clear()

        mskIDNumber.Focus()

        chkPermanent.Checked = False

    End Sub
    Public Sub getEmpStat()
        Try
            str = "select empStat from settings_empstat order by empStat"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New Data.DataSet
            mysda.Fill(ds, "settings_empstat")
            conn.Close()
            cboEmpStatus.ValueMember = "settings_empstat"
            cboEmpStatus.DisplayMember = "empStat"
            cboEmpStatus.DataSource = ds.Tables("settings_empstat")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub schoolInfo()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select * from srms_settings limit 1"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lblSettingsID.Text = dtReader(0)
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub frmStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormLoad()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from staff where IDNumber='" & mskIDNumber.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()

                'audit trail here

                MsgBox("Selected record has been deleted!", MsgBoxStyle.Information)
                FormLoad()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If btnSave.Text = "SAVE" Then
                If mskIDNumber.Text = "" Then
                    MsgBox("Employee number is required!", MsgBoxStyle.Exclamation)
                    mskIDNumber.Focus()
                    Exit Sub
                End If

                If txtFirstName.Text = "" Then
                    MsgBox("First Name is required!", MsgBoxStyle.Exclamation)
                    txtFirstName.Focus()
                    Exit Sub
                End If

                If txtLastName.Text = "" Then
                    MsgBox("Last Name is required!", MsgBoxStyle.Exclamation)
                    txtLastName.Focus()
                    Exit Sub
                End If

                str = "insert into staff values('" & mskIDNumber.Text & "','" & txtFirstName.Text & "','" & txtMiddleName.Text & "','" & txtLastName.Text & "','" & txtNameExtn.Text & "','" & cboPrefix.Text & "','" & txtJobTitle.Text & "','" & txtPosition.Text & "','" & txtDepartment.Text & "','" & cboMStatus.Text & "','" & cboEmpStatus.Text & "','" & Convert.ToDateTime(dtpBirthDate.Text).ToString("yyyy-MM-dd") & "','" & txtBirthPlace.Text & "','" & cboSex.Text & "','" & txtHeight.Text & "','" & txtWeight.Text & "','" & txtBloodType.Text & "','" & txtGSIS.Text & "','" & txtPagibig.Text & "','" & txtPhilHealth.Text & "','" & txtSSS.Text & "','" & txtTIN.Text & "','" & Convert.ToDateTime(dtpHiredDate.Text).ToString("yyyy-MM-dd") & "','" & txtResHouseNo.Text & "','" & txtResStreet.Text & "','" & txtResVillage.Text & "','" & txtResBrgy.Text & "','" & txtResCity.Text & "','" & txtResProvince.Text & "','" & txtResZip.Text & "','" & txtPerHouseNo.Text & "','" & txtResStreet.Text & "','" & txtPerVillage.Text & "','" & txtPerBrgy.Text & "','" & txtPerCity.Text & "','" & txtPerProvince.Text & "','" & txtPerZip.Text & "','" & txtTelNo.Text & "','" & txtMobile.Text & "','" & txtEmailAd.Text & "','" & lblSettingsID.Text & "')"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()

                MsgBox("New Record has been added!", MsgBoxStyle.Information)
                FormLoad()
            Else
                str = "update staff set IDNUmber='" & mskIDNumber.Text & "',FirstName='" & txtFirstName.Text & "',MiddleName='" & txtMiddleName.Text & "',LastName='" & txtLastName.Text & "',NameExtn='" & txtNameExtn.Text & "',prefix='" & cboPrefix.Text & "',empPosition='" & txtPosition.Text & "',Department='" & txtDepartment.Text & "',MaritalStatus='" & cboMStatus.Text & "',empStatus='" & cboEmpStatus.Text & "',BirthDate='" & Convert.ToDateTime(dtpBirthDate.Text).ToString("yyyy-MM-dd") & "',BirthPlace='" & txtBirthPlace.Text & "',Sex='" & cboSex.Text & "',height='" & txtHeight.Text & "',weight='" & txtWeight.Text & "',bloodType='" & txtBloodType.Text & "',gsis='" & txtGSIS.Text & "',pagibig='" & txtPagibig.Text & "',philHealth='" & txtPhilHealth.Text & "',sssNo='" & txtSSS.Text & "',tinNo='" & txtTIN.Text & "',dateHired='" & Convert.ToDateTime(dtpHiredDate.Text).ToString("yyyy-MM-dd") & "',resHouseNo='" & txtResHouseNo.Text & "',resStreet='" & txtResStreet.Text & "',resVillage='" & txtResVillage.Text & "',resBarangay='" & txtResBrgy.Text & "',resCity='" & txtResCity.Text & "',resProvince='" & txtResProvince.Text & "',resZipCode='" & txtResZip.Text & "',perHouseNo='" & txtPerHouseNo.Text & "',perStreet='" & txtPerStreet.Text & "',perVillage='" & txtPerVillage.Text & "',perBarangay='" & txtPerBrgy.Text & "',perCity='" & txtPerCity.Text & "',perProvince='" & txtPerProvince.Text & "',perZipCode='" & txtPerZip.Text & "',empTelNo='" & txtTelNo.Text & "',empMobile='" & txtMobile.Text & "',empEmail='" & txtEmailAd.Text & "' where IDNumber='" & lblIDNumber.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()
                MsgBox("The selected record has been updated!", MsgBoxStyle.Information)

                FormLoad()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        frmSearchPersonnel.lblSource.Text = "Profile Form"
        frmSearchPersonnel.ShowDialog()
    End Sub

    Private Sub chkPermanent_CheckedChanged(sender As Object, e As EventArgs) Handles chkPermanent.CheckedChanged
        If chkPermanent.Checked = True Then
            txtPerHouseNo.Text = txtResHouseNo.Text
            txtPerStreet.Text = txtResStreet.Text
            txtPerVillage.Text = txtResVillage.Text
            txtPerBrgy.Text = txtResBrgy.Text
            txtPerCity.Text = txtResCity.Text
            txtPerProvince.Text = txtResProvince.Text
            txtPerZip.Text = txtResZip.Text
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        frmAddEmpStat.ShowDialog()
    End Sub

    Private Sub ReloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadToolStripMenuItem.Click
        FormLoad()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        btnSave.PerformClick()
    End Sub

    Private Sub btnFamily_Click(sender As Object, e As EventArgs) Handles btnFamily.Click
        frmFamilyBackground.ShowDialog()
    End Sub

    Public Sub getWE()
        Try
            str = "select * from hris_we where IDNumber='" & mskIDNumber.Text & "' order by weID desc"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New Data.DataSet
            mysda.Fill(ds, "hris_we")
            dgWE.DataSource = ds.Tables("hris_we")
            conn.Close()
            dgWE.Columns(0).Visible = False
            dgWE.Columns(1).HeaderText = "From"
            dgWE.Columns(2).HeaderText = "To"
            dgWE.Columns(3).HeaderText = "Position Title"
            dgWE.Columns(3).Width = 250
            dgWE.Columns(4).HeaderText = "Office"
            dgWE.Columns(4).Width = 250
            dgWE.Columns(5).HeaderText = "Monthly Salary"
            dgWE.Columns(6).HeaderText = "Salary Grade"
            dgWE.Columns(7).HeaderText = "Appointment Status"
            dgWE.Columns(8).HeaderText = "Gov't. Service?"
            dgWE.Columns(9).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

    End Sub
    Public Sub getVW()
        Try
            str = "select * from hris_vw where IDNumber='" & mskIDNumber.Text & "' order by vwID desc"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New Data.DataSet
            mysda.Fill(ds, "hris_vw")
            dgVW.DataSource = ds.Tables("hris_vw")
            conn.Close()
            dgVW.Columns(0).Visible = False
            dgVW.Columns(1).HeaderText = "Organization Name"
            dgVW.Columns(1).Width = 200
            dgVW.Columns(2).HeaderText = "Organization Address"
            dgVW.Columns(2).Width = 200
            dgVW.Columns(3).HeaderText = "From"
            dgVW.Columns(4).HeaderText = "To"
            dgVW.Columns(5).HeaderText = "No. of Hours"
            dgVW.Columns(6).HeaderText = "Position/Nature of Work"
            dgVW.Columns(6).Width = 150
            dgWE.Columns(7).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

    End Sub
    Public Sub getTrainings()
        Try
            str = "select * from hris_trainings where IDNumber='" & mskIDNumber.Text & "' order by trainingID desc"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New Data.DataSet
            mysda.Fill(ds, "hris_trainings")
            dgTrainings.DataSource = ds.Tables("hris_trainings")
            conn.Close()
            dgTrainings.Columns(0).Visible = False
            dgTrainings.Columns(1).HeaderText = "Training Title/Programs"
            dgTrainings.Columns(1).Width = 260
            dgTrainings.Columns(2).HeaderText = "From"
            dgTrainings.Columns(3).HeaderText = "To"
            dgTrainings.Columns(4).HeaderText = "No. of Hours"
            dgTrainings.Columns(5).HeaderText = "Training Type"
            dgTrainings.Columns(6).HeaderText = "Conducted by/Sponsored by"
            dgTrainings.Columns(6).Width = 220
            dgTrainings.Columns(7).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
    Public Sub getEduc()
        Try
            str = "select * from hris_educ where IDNumber='" & mskIDNumber.Text & "' order by educID desc"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New Data.DataSet
            mysda.Fill(ds, "hris_educ")
            dgEducational.DataSource = ds.Tables("hris_educ")
            conn.Close()
            dgEducational.Columns(0).Visible = False
            dgEducational.Columns(1).HeaderText = "Level"
            dgEducational.Columns(2).HeaderText = "School Name"
            dgEducational.Columns(2).Width = 150
            dgEducational.Columns(3).HeaderText = "Basic Education/Degree/Course"
            dgEducational.Columns(3).Width = 150
            dgEducational.Columns(4).HeaderText = "From"
            dgEducational.Columns(5).HeaderText = "To"
            dgEducational.Columns(6).HeaderText = "Highest Level/Units Eearned"
            dgEducational.Columns(6).Width = 150
            dgEducational.Columns(7).HeaderText = "Year Graduated"
            dgEducational.Columns(8).HeaderText = "Scholarship"
            dgEducational.Columns(8).Width = 150
            dgEducational.Columns(9).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
    Public Sub getFamily()
        Try
            str = "select * from hris_family where IDNumber='" & mskIDNumber.Text & "' order by famID desc"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New Data.DataSet
            mysda.Fill(ds, "hris_family")
            dgFamily.DataSource = ds.Tables("hris_family")
            conn.Close()
            dgFamily.Columns(0).Visible = False
            dgFamily.Columns(1).HeaderText = "Full Name"
            dgFamily.Columns(1).Width = 420
            dgFamily.Columns(2).HeaderText = "Relationship"
            dgFamily.Columns(2).Width = 230
            dgFamily.Columns(3).HeaderText = "Birth Date"
            dgFamily.Columns(3).Width = 220
            dgFamily.Columns(4).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
    Public Sub getOtherInfo()
        Try
            str = "select * from hris_oi where IDNumber='" & mskIDNumber.Text & "' order by oiID desc"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New Data.DataSet
            mysda.Fill(ds, "hris_oi")
            dgOI.DataSource = ds.Tables("hris_oi")
            conn.Close()
            dgOI.Columns(0).Visible = False
            dgOI.Columns(1).HeaderText = "Info Type"
            dgOI.Columns(1).Width = 430
            dgOI.Columns(2).HeaderText = "Info Details"
            dgOI.Columns(2).Width = 430
            dgOI.Columns(3).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

End Class