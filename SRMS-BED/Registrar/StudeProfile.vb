Imports MySql.Data.MySqlClient
Public Class frmStudeProfile
    Dim str As String
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If btnSave.Text = "SAVE" Then
                'check duplicate student number
                str = "select * from studeprofile where StudentNumber='" & mskStudentNumber.Text & "'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New Data.DataSet
                mysda.Fill(ds, "studeprofile")

                If ds.Tables("studeprofile").Rows.Count = 1 Then
                    MsgBox("Student Number already exist!", MsgBoxStyle.Exclamation)
                    conn.Close()
                    mskStudentNumber.Focus()
                    Exit Sub
                End If
                If mskStudentNumber.Text = "" Then
                    MsgBox("Student number is required. Please fill-up the form completely!", MsgBoxStyle.Exclamation)
                    mskStudentNumber.Focus()
                    Exit Sub
                End If

                conn.Close()
                'end

                'check duplicate names
                str = "select * from studeprofile where FirstName='" & txtFName.Text & "' and LastName='" & txtLName.Text & "'"
                conn.Open()
                Dim mysda1 As New MySqlDataAdapter(str, conn)
                Dim ds1 As New Data.DataSet
                mysda1.Fill(ds1, "studeprofile")

                If ds1.Tables("studeprofile").Rows.Count = 1 Then
                    MsgBox("Record already exist!", MsgBoxStyle.Exclamation)
                    conn.Close()
                    Exit Sub
                End If
                'end

                If mskStudentNumber.Text = "" Then
                    MsgBox("Student number is required. Please fill-up the form completely!", MsgBoxStyle.Exclamation)
                    mskStudentNumber.Focus()
                    Exit Sub
                End If
                conn.Close()
                'end

                If txtFName.Text = "" Then
                    MsgBox("First name is required!", MsgBoxStyle.Exclamation)
                    txtFName.Focus()
                    Exit Sub
                End If
                If txtLName.Text = "" Then
                    MsgBox("Last name is required!", MsgBoxStyle.Exclamation)
                    txtLName.Focus()
                    Exit Sub
                End If

                If cboProvince.Text = "" Then
                    MsgBox("Provincial address is required!", MsgBoxStyle.Exclamation)
                    cboProvince.Focus()
                    Exit Sub
                End If

                If cboMuncipality.Text = "" Then
                    MsgBox("City or Municipality is required!", MsgBoxStyle.Exclamation)
                    cboMuncipality.Focus()
                    Exit Sub
                End If

                If cboSex.Text = "" Then
                    MsgBox("Sex/Gender is required!", MsgBoxStyle.Exclamation)
                    cboSex.Focus()
                    Exit Sub
                End If


                str = "insert into studeprofile (StudentNumber, FirstName, MiddleName, LastName, Sex, CivilStatus, BirthPlace, Citizenship, Religion, BloodType, TelNumber, MobileNumber, HighSchool, HSAddress, College, CAddress, Encoder, BirthDate, Guardian, GuardianContact, GuardianAddress, Elementary, ElemAddress, GuardianRelationship, GuardianTelNo, EmailAddress, Father, FOccupation, Mother, MOccupation, Age, Title, Pronoun, Pronoun2, Pronoun3, Ethnicity, ParentsMonthly, Province, City, Brgy, Sitio, settingsID, guardianOccupation, elemSY, elemAve, elemGradDate, eligibility, jhsAve, jhsGradDate, elemSchoolID, jhsSchoolID, peptRating, peptExamDate, alsRating, alsTestingCenter, nameExt, rfid, LRN, classification, fContactNo, mContactNo, Scholarship, Notes) values ('" & mskStudentNumber.Text & "','" & txtFName.Text & "','" & txtMName.Text & "','" & txtLName.Text & "','" & cboSex.Text & "','" & cboCivilStatus.Text & "','" & txtBirthPlace.Text & "','" & cboCitizenship.Text & "','" & txtReligion.Text & "','" & txtBloodType.Text & "','" & mskTelNumber.Text & "','" & mskMobileNumber.Text & "','" & txtHighSchool.Text & "','" & txtJHSAddress.Text & "','" & txtCollege.Text & "','" & txtCollegeAddress.Text & "','" & frmRegistrar.stUser.Text & "','" & Convert.ToDateTime(dtpBirthDate.Text).ToString("yyyy-MM-dd") & "','" & txtGuardian.Text & "','" & txtGuardianContact.Text & "','" & btnSet.Text & "','" & txtElementary.Text & "','" & txtElemAddress.Text & "','" & txtGuardianRelationship.Text & "','" & mskGuardianTel.Text & "','" & txtEmail.Text & "','" & txtFather.Text & "','" & txtFatherOccupation.Text & "','" & txtMother.Text & "','" & txtMotherOccupation.Text & "','" & txtAge.Text & "','" & lblTitle.Text & "','" & lblPronoun.Text & "','" & lblPronoun2.Text & "','" & lblPronoun3.Text & "','" & cboEthnicity.Text & "','" & txtMonthlyIncome.Text & "','" & cboProvince.Text & "','" & cboMuncipality.Text & "','" & cboBrgy.Text & "','" & txtSubdivision.Text & "','" & lblSettingsID.Text & "','" & lblGuardianOccupation.Text & "','" & txtelemSchoolYear.Text & "','" & txtElemGenAve.Text & "','" & mskElemGradDate.Text & "','" & cboEligibility.Text & "','" & txtJHSGenAve.Text & "','" & mskJHSGradDate.Text & "','" & txtElemSchoolID.Text & "','" & txtJHSSchoolID.Text & "','" & txtPEPTRating.Text & "','" & mskPEPTExamDate.Text & "','" & txtALSRating.Text & "','" & txtAlsTestingCenter.Text & "','" & txtNameExt.Text & "','" & txtRFID.Text & "','" & txtLRN.Text & "','" & cboClassification.Text & "','" & txtFatherContactNo.Text & "','" & txtMotherContactNo.Text & "','" & cboScholarship.Text & "','" & txtNotes.Text & "')"
                conn.Open()
                Dim mysC As New MySqlCommand(str, conn)
                mysC.ExecuteNonQuery()
                conn.Close()

                'create user account
                Dim pass As String

                pass = getSHA1Hash(Convert.ToDateTime(dtpBirthDate.Text).ToString("yyyy-MM-dd"))

                'save requirements
                str = "insert into stude_requirements values(0,'" & mskStudentNumber.Text & "','" & chk1.Text & "','" & lbl1.Text & "','" & chk2.Text & "','" & lbl2.Text & "','" & chk3.Text & "','" & lbl3.Text & "','" & chk4.Text & "','" & lbl4.Text & "','" & chk5.Text & "','" & lbl5.Text & "','" & chk6.Text & "','" & lbl6.Text & "','" & chk7.Text & "','" & lbl7.Text & "','" & chk8.Text & "','" & lbl8.Text & "','" & chk9.Text & "','" & lbl9.Text & "')"
                conn.Open()
                Dim mysC2 As New MySqlCommand(str, conn)
                mysC2.ExecuteNonQuery()
                conn.Close()


                'Audit Trail
                str = "insert into atrail values('0','Encoded Student''s Profile','" & Convert.ToDateTime(frmRegistrar.stDate.Text).ToString("yyyy-MM-dd") & "','" & frmRegistrar.stTime.Text & "','" & frmRegistrar.stUser.Text & "','" & mskStudentNumber.Text & "')"
                conn.Open()
                Dim mysc1 As New MySqlCommand(str, conn)
                mysc1.ExecuteNonQuery()
                conn.Close()

                'insert into user accounts
                str = "insert into users values('" & mskStudentNumber.Text & "','" & pass & "','Student','" & txtFName.Text & "','" & txtMName.Text & "','" & txtLName.Text & "','" & txtEmail.Text & "','avatar.png','active','" & Convert.ToDateTime(frmRegistrar.stDate.Text).ToString("yyyy-MM-dd") & "','" & mskStudentNumber.Text & "')"
                conn.Open()
                Dim mysC3 As New MySqlCommand(str, conn)
                mysC3.ExecuteNonQuery()
                conn.Close()


                mskStudentNumber.Focus()
                conn.Close()
                If (MsgBox("Record successfully saved.  Would you like to save another record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                    mskStudentNumber.Focus()
                Else
                    Me.Close()
                End If
                formLoad()
            Else
                'create user account
                Dim pass As String

                pass = getSHA1Hash(Convert.ToDateTime(dtpBirthDate.Text).ToString("yyyy-MM-dd"))

                str = "update studeprofile set StudentNumber='" & mskStudentNumber.Text & "',FirstName='" & txtFName.Text & "',MiddleName='" & txtMName.Text & "',LastName='" & txtLName.Text & "',Sex='" & cboSex.Text & "',CivilStatus='" & cboCivilStatus.Text & "',BirthPlace='" & txtBirthPlace.Text & "',Citizenship='" & cboCitizenship.Text & "',Religion='" & txtReligion.Text & "',BloodType='" & txtBloodType.Text & "',TelNumber='" & mskTelNumber.Text & "',MobileNumber='" & mskMobileNumber.Text & "',HighSchool='" & txtHighSchool.Text & "',HSAddress='" & txtJHSAddress.Text & "',College='" & txtCollege.Text & "',CAddress='" & txtCollegeAddress.Text & "',Requirements='" & txtRequirements.Text & "',Encoder='" & frmRegistrar.stUser.Text & "',BirthDate='" & Convert.ToDateTime(dtpBirthDate.Text).ToString("yyyy-MM-dd") & "',Guardian='" & txtGuardian.Text & "',GuardianContact='" & txtGuardianContact.Text & "',GuardianAddress='" & btnSet.Text & "',Course='" & cboCourse.Text & "',Elementary='" & txtElementary.Text & "',ElemAddress='" & txtElemAddress.Text & "',GuardianRelationship='" & txtGuardianRelationship.Text & "',GuardianTelNo='" & mskGuardianTel.Text & "',EmailAddress='" & txtEmail.Text & "',Father='" & txtFather.Text & "',FOccupation='" & txtFatherOccupation.Text & "',Mother='" & txtMother.Text & "',MOccupation='" & txtMotherOccupation.Text & "',Age='" & txtAge.Text & "',Title='" & lblTitle.Text & "',Pronoun='" & lblPronoun.Text & "',Pronoun2='" & lblPronoun2.Text & "',Pronoun3='" & lblPronoun3.Text & "',Ethnicity='" & cboEthnicity.Text & "',ParentsMonthly='" & txtMonthlyIncome.Text & "',Province='" & cboProvince.Text & "',City='" & cboMuncipality.Text & "',Brgy='" & cboBrgy.Text & "',Sitio='" & txtSubdivision.Text & "',guardianOccupation='" & lblGuardianOccupation.Text & "',elemSY='" & txtelemSchoolYear.Text & "',elemAve='" & txtElemGenAve.Text & "',elemGradDate='" & mskElemGradDate.Text & "',eligibility='" & cboEligibility.Text & "',jhsAve='" & txtJHSGenAve.Text & "',jhsGradDate='" & mskJHSGradDate.Text & "',elemSchoolID='" & txtElemSchoolID.Text & "',jhsSchoolID='" & txtJHSSchoolID.Text & "',peptRating='" & txtPEPTRating.Text & "',peptExamDate='" & mskPEPTExamDate.Text & "',alsRating='" & txtALSRating.Text & "',alsTestingCenter='" & txtAlsTestingCenter.Text & "',nameExt='" & txtNameExt.Text & "',rfid='" & txtRFID.Text & "',LRN='" & txtLRN.Text & "',classification='" & cboClassification.Text & "',fContactNo='" & txtFatherContactNo.Text & "',mContactNo='" & txtMotherContactNo.Text & "',Scholarship='" & cboScholarship.Text & "', Notes='" & txtNotes.Text & "' where StudentNumber='" & lblStudentNumber.Text & "'"
                conn.Open()
                Dim mysC As New MySqlCommand(str, conn)
                mysC.ExecuteNonQuery()
                conn.Close()

                'update user accounts
                str = "update users set username='" & mskStudentNumber.Text & "',password='" & pass & "', fName='" & txtFName.Text & "',mName='" & txtMName.Text & "',lName='" & txtLName.Text & "', email='" & txtEmail.Text & "' where username='" & lblStudentNumber.Text & "'"
                conn.Open()
                Dim mysc1 As New MySqlCommand(str, conn)
                mysc1.ExecuteNonQuery()
                conn.Close()

                'save requirements
                str = "update stude_requirements set req1='" & chk1.Text & "',req2='" & chk2.Text & "',req3='" & chk3.Text & "',req4='" & chk4.Text & "',req5='" & chk5.Text & "',req6='" & chk6.Text & "',req7='" & chk7.Text & "',req8='" & chk8.Text & "',req9='" & chk9.Text & "',req1Stat='" & lbl1.Text & "',req2Stat='" & lbl2.Text & "',req3Stat='" & lbl3.Text & "',req4Stat='" & lbl4.Text & "',req5Stat='" & lbl5.Text & "',req6Stat='" & lbl6.Text & "',req7Stat='" & lbl7.Text & "',req8Stat='" & lbl8.Text & "',req9Stat='" & lbl9.Text & "' where StudentNumber='" & mskStudentNumber.Text & "'"
                conn.Open()
                Dim mysC7 As New MySqlCommand(str, conn)
                mysC7.ExecuteNonQuery()
                conn.Close()


                'Audit Trail
                str = "insert into atrail values('0','Update Student''s Profile','" & Convert.ToDateTime(frmRegistrar.stDate.Text).ToString("yyyy-MM-dd") & "','" & frmRegistrar.stTime.Text & "','" & frmRegistrar.stUser.Text & "','" & mskStudentNumber.Text & "')"
                conn.Open()
                Dim mysc8 As New MySqlCommand(str, conn)
                mysc8.ExecuteNonQuery()
                conn.Close()


                MsgBox("Data successfully updated!", MsgBoxStyle.Information, "Prompt")
                formLoad()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub formLoad()
        Try
            mskStudentNumber.Clear()
            txtFName.Clear()
            txtMName.Clear()
            txtLName.Clear()
            txtNameExt.Clear()
            cboSex.ResetText()
            cboCivilStatus.Text = "SINGLE"
            txtReligion.ResetText()
            txtBloodType.Clear()
            mskTelNumber.Clear()
            mskMobileNumber.Clear()
            txtHighSchool.Clear()
            txtJHSAddress.Clear()
            txtCollege.Clear()
            txtCollegeAddress.Clear()
            txtElementary.Clear()
            txtElemAddress.Clear()
            txtRequirements.Clear()
            dtpBirthDate.Text = Today
            txtGuardian.ResetText()
            btnSet.Clear()
            txtGuardianContact.Clear()
            cboCourse.ResetText()
            cboEthnicity.ResetText()
            txtMonthlyIncome.Text = 0
            txtGuardianRelationship.Clear()
            txtFather.Clear()
            txtFatherOccupation.Clear()
            txtMother.Clear()
            txtMotherOccupation.Clear()
            txtRFID.Clear()
            cboMuncipality.ResetText()
            cboBrgy.ResetText()
            txtSubdivision.Clear()
            txtLRN.Clear()
            txtNotes.Clear()

            txtElemAddress.Clear()
            txtEmail.Clear()
            lblGuardianOccupation.Text = ""
            txtElementary.Clear()
            txtElemGenAve.Clear()
            cboEligibility.ResetText()
            txtJHSGenAve.Clear()
            txtHighSchool.Clear()
            txtJHSAddress.Clear()
            txtelemSchoolYear.Clear()
            cboEligibility.ResetText()

            txtBirthPlace.Clear()
            cboCitizenship.ResetText()
            cboEligibility.ResetText()
            mskElemGradDate.Clear()
            txtJHSGenAve.Clear()
            mskJHSGradDate.Clear()
            txtElemSchoolID.Clear()
            txtJHSSchoolID.Clear()
            txtPEPTRating.Clear()
            mskPEPTExamDate.Clear()
            txtALSRating.Clear()
            txtAlsTestingCenter.Clear()
            txtNameExt.Clear()
            cboClassification.ResetText()
            txtFatherContactNo.Clear()
            txtMotherContactNo.Clear()

            mskStudentNumber.Focus()
            mskStudentNumber.ReadOnly = False


            getProvince()
            getCity()
            getBrgy()
            getReligion()
            getEthnicity()
            schoolInfo()
            getGuardian()
            getScholarship()

            btnSave.Enabled = True
            btnSave.Text = "SAVE"
            btnDelete.Visible = False


            chk1.Checked = False
            chk2.Checked = False
            chk3.Checked = False
            chk4.Checked = False
            chk5.Checked = False
            chk6.Checked = False
            chk7.Checked = False
            chk8.Checked = False
            chk9.Checked = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try


    End Sub

    Public Sub checkBox()
        If chk1.Checked = True Then
            lbl1.Text = "Submitted"
        Else
            lbl1.Text = "Not Yet Submitted"
        End If

        If chk2.Checked = True Then
            lbl2.Text = "Submitted"
        Else
            lbl2.Text = "Not Yet Submitted"

        End If
        If chk3.Checked = True Then
            lbl3.Text = "Submitted"
        Else
            lbl3.Text = "Not Yet Submitted"
        End If

        If chk4.Checked = True Then
            lbl4.Text = "Submitted"
        Else
            lbl4.Text = "Not Yet Submitted"
        End If

        If chk5.Checked = True Then
            lbl5.Text = "Submitted"

        Else
            lbl5.Text = "Not Yet Submitted"

        End If

        If chk6.Checked = True Then
            lbl6.Text = "Submitted"

        Else
            lbl6.Text = "Not Yet Submitted"

        End If

        If chk7.Checked = True Then
            lbl7.Text = "Submitted"

        Else
            lbl7.Text = "Not Yet Submitted"

        End If

        If chk8.Checked = True Then
            lbl8.Text = "Submitted"

        Else
            lbl8.Text = "Not Yet Submitted"

        End If
        If chk9.Checked = True Then
            lbl9.Text = "Submitted"

        Else
            lbl9.Text = "Not Yet Submitted"

        End If
    End Sub
    Public Sub getTitle()
        Dim i As String
        If cboSex.Text = "Male" Then
            i = "MR."
            lblTitle.Text = i
        Else
            i = "MS."
            lblTitle.Text = i
        End If
    End Sub
    Public Sub getPronoun()
        Dim i As String
        If cboSex.Text = "Male" Then
            i = "him"
            lblPronoun.Text = i
        Else
            i = "her"
            lblPronoun.Text = i
        End If
    End Sub
    Public Sub getPronoun2()
        Dim i As String
        If cboSex.Text = "Male" Or cboSex.Text = "MALE" Then
            i = "He"
            lblPronoun2.Text = i
        Else
            i = "She"
            lblPronoun2.Text = i
        End If
    End Sub
    Public Sub getPronoun3()
        Dim i As String
        If cboSex.Text = "Male" Then
            i = "his"
            lblPronoun3.Text = i
        Else
            i = "her"
            lblPronoun3.Text = i
        End If
    End Sub

    Private Sub cboSex_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSex.SelectedIndexChanged
        getTitle()
        getPronoun()
        getPronoun2()
        getPronoun3()
    End Sub

    Public Sub getAge()
        Try
            Dim strBirth As String
            Dim intAge As Integer
            strBirth = dtpBirthDate.Text
            intAge = Math.Floor(DateDiff(DateInterval.Month, DateValue(strBirth), Now()) / 12)
            txtAge.Text = intAge
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub dtpBirthDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpBirthDate.ValueChanged
        getAge()
    End Sub

    Public Sub getProvince()
        Try
            str = "Select Province from settings_address group by Province order by Province"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New Data.DataSet
            mysda.Fill(ds, "settings_address")
            conn.Close()
            cboProvince.ValueMember = "settings_address"
            cboProvince.DisplayMember = "Province"
            cboProvince.DataSource = ds.Tables("settings_address")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub getCity()
        Try
            str = "Select City from settings_address where Province='" & cboProvince.Text & "' group by City order by City"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New Data.DataSet
            mysda.Fill(ds, "settings_address")
            conn.Close()
            cboMuncipality.ValueMember = "settings_address"
            cboMuncipality.DisplayMember = "City"
            cboMuncipality.DataSource = ds.Tables("settings_address")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub getBrgy()
        Try
            str = "select Brgy from settings_address where Province='" & cboProvince.Text & "' and City='" & cboMuncipality.Text & "' order by Brgy"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New Data.DataSet
            mysda.Fill(ds, "settings_address")
            conn.Close()
            cboBrgy.ValueMember = "settings_address"
            cboBrgy.DisplayMember = "Brgy"
            cboBrgy.DataSource = ds.Tables("settings_address")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub getReligion()
        Try
            str = "select religion from settings_religion order by religion"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New Data.DataSet
            mysda.Fill(ds, "settings_religion")
            conn.Close()
            txtReligion.ValueMember = "settings_religion"
            txtReligion.DisplayMember = "religion"
            txtReligion.DataSource = ds.Tables("settings_religion")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub getEthnicity()
        Try
            str = "select ethnicity from settings_ethnicity order by ethnicity"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New Data.DataSet
            mysda.Fill(ds, "settings_ethnicity")
            conn.Close()
            cboEthnicity.ValueMember = "settings_ethnicity"
            cboEthnicity.DisplayMember = "ethnicity"
            cboEthnicity.DataSource = ds.Tables("settings_ethnicity")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub cboProvince_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProvince.SelectedIndexChanged
        getCity()
        getBrgy()
    End Sub

    Private Sub cboMuncipality_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMuncipality.SelectedIndexChanged
        getBrgy()
    End Sub

    Public Sub getScholarship()
        Try
            str = "select * from scholarships order by Scholarship"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New Data.DataSet
            mysda.Fill(ds, "scholarships")

            cboScholarship.ValueMember = "scholarships"
            cboScholarship.DisplayMember = "Scholarship"
            cboScholarship.DataSource = ds.Tables("scholarships")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Public Sub getRequirements()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select * from stude_requirements where StudentNumber='" & mskStudentNumber.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lbl1.Text = dtReader.Item(3)
                lbl2.Text = dtReader.Item(5)
                lbl3.Text = dtReader.Item(7)
                lbl4.Text = dtReader.Item(9)
                lbl5.Text = dtReader.Item(11)
                lbl6.Text = dtReader.Item(13)
                lbl7.Text = dtReader.Item(15)
                lbl8.Text = dtReader.Item(17)
                lbl9.Text = dtReader.Item(19)
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
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
    Public Sub getGuardian()
        Try
            str = "select * from studeprofile group by Guardian order by Guardian "
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New Data.DataSet
            mysda.Fill(ds, "qualifications")
            conn.Close()

            txtGuardian.ValueMember = "Guardian"
            txtGuardian.DisplayMember = "Guardian"
            txtGuardian.DataSource = ds.Tables("qualifications")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub frmStudeProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formLoad()
    End Sub

    Private Sub cboBrgy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBrgy.SelectedIndexChanged

    End Sub


    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        AddReligion.ShowDialog()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        frmAddScholarship.ShowDialog()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        AddEthnicity.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmSelectSchool0.ShowDialog()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        frmCompleteList.lblSource.Text = "Profile Form"
        frmCompleteList.ShowDialog()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from studeprofile where StudentNumber='" & mskStudentNumber.Text & "'"
                conn.Open()
                Dim mysC As New MySqlCommand(str, conn)
                mysC.ExecuteNonQuery()
                conn.Close()

                'delete from useraccounts
                str = "delete from users where username='" & mskStudentNumber.Text & "'"
                conn.Open()
                Dim mysc1 As New MySqlCommand(str, conn)
                mysc1.ExecuteNonQuery()
                MsgBox("Data successfully deleted!", MsgBoxStyle.Information, "Prompt")
                conn.Close()


                'Audit Trail
                str = "insert into atrail values('0','Deleted Student Profile','" & Convert.ToDateTime(frmRegistrar.stDate.Text).ToString("yyyy-MM-dd") & "','" & frmRegistrar.stTime.Text & "','" & frmRegistrar.stUser.Text & "','" & mskStudentNumber.Text & "')"
                conn.Open()
                Dim mysc2 As New MySqlCommand(str, conn)
                mysc2.ExecuteNonQuery()
                conn.Close()

                formLoad()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Open()

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txtGuardian.Text = txtFather.Text
        txtGuardianRelationship.Text = lblFather.Text
        lblGuardianOccupation.Text = txtFatherOccupation.Text
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        txtGuardian.Text = txtMother.Text
        txtGuardianRelationship.Text = labelMother.Text
        lblGuardianOccupation.Text = txtMotherOccupation.Text
    End Sub

    Private Sub chk1_CheckedChanged(sender As Object, e As EventArgs) Handles chk1.CheckedChanged
        checkBox()
    End Sub

    Private Sub chk2_CheckedChanged(sender As Object, e As EventArgs) Handles chk2.CheckedChanged
        checkBox()
    End Sub

    Private Sub chk3_CheckedChanged(sender As Object, e As EventArgs) Handles chk3.CheckedChanged
        checkBox()
    End Sub

    Private Sub chk4_CheckedChanged(sender As Object, e As EventArgs) Handles chk4.CheckedChanged
        checkBox()

    End Sub

    Private Sub chk5_CheckedChanged(sender As Object, e As EventArgs) Handles chk5.CheckedChanged
        checkBox()
    End Sub

    Private Sub chk6_CheckedChanged(sender As Object, e As EventArgs) Handles chk6.CheckedChanged
        checkBox()
    End Sub

    Private Sub chk7_CheckedChanged(sender As Object, e As EventArgs) Handles chk7.CheckedChanged
        checkBox()
    End Sub

    Private Sub chk8_CheckedChanged(sender As Object, e As EventArgs) Handles chk8.CheckedChanged
        checkBox()
    End Sub

    Private Sub chk9_CheckedChanged(sender As Object, e As EventArgs) Handles chk9.CheckedChanged
        checkBox()
    End Sub

    Private Sub lbl1_TextChanged(sender As Object, e As EventArgs) Handles lbl1.TextChanged
        CheckTheBoxRequirements()
    End Sub

    Private Sub lbl2_TextChanged(sender As Object, e As EventArgs) Handles lbl2.TextChanged
        CheckTheBoxRequirements()
    End Sub

    Private Sub lbl3_TextChanged(sender As Object, e As EventArgs) Handles lbl3.TextChanged
        CheckTheBoxRequirements()
    End Sub

    Private Sub lbl4_TextChanged(sender As Object, e As EventArgs) Handles lbl4.TextChanged
        CheckTheBoxRequirements()
    End Sub

    Private Sub lbl5_TextChanged(sender As Object, e As EventArgs) Handles lbl5.TextChanged
        CheckTheBoxRequirements()
    End Sub

    Private Sub lbl6_TextChanged(sender As Object, e As EventArgs) Handles lbl6.TextChanged
        CheckTheBoxRequirements()
    End Sub

    Private Sub lbl7_TextChanged(sender As Object, e As EventArgs) Handles lbl7.TextChanged
        CheckTheBoxRequirements()
    End Sub

    Private Sub lbl8_TextChanged(sender As Object, e As EventArgs) Handles lbl8.TextChanged
        CheckTheBoxRequirements()
    End Sub

    Private Sub lbl9_TextChanged(sender As Object, e As EventArgs) Handles lbl9.TextChanged
        CheckTheBoxRequirements()
    End Sub
    Public Sub CheckTheBoxRequirements()
        If lbl1.Text = "Submitted" Then
            chk1.Checked = True
        Else
            chk1.Checked = False
        End If

        If lbl2.Text = "Submitted" Then
            chk2.Checked = True
        Else
            chk2.Checked = False
        End If

        If lbl3.Text = "Submitted" Then
            chk3.Checked = True
        Else
            chk3.Checked = False
        End If

        If lbl4.Text = "Submitted" Then
            chk4.Checked = True
        Else
            chk4.Checked = False
        End If

        If lbl5.Text = "Submitted" Then
            chk5.Checked = True
        Else
            chk5.Checked = False
        End If

        If lbl6.Text = "Submitted" Then
            chk6.Checked = True
        Else
            chk6.Checked = False
        End If

        If lbl7.Text = "Submitted" Then
            chk7.Checked = True
        Else
            chk7.Checked = False
        End If

        If lbl8.Text = "Submitted" Then
            chk8.Checked = True
        Else
            chk8.Checked = False
        End If

        If lbl9.Text = "Submitted" Then
            chk9.Checked = True
        Else
            chk9.Checked = False
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        formLoad()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        btnSave.PerformClick()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        frmBulkUploadStudent.ShowDialog()
    End Sub
End Class