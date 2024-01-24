Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Public Class frmBulkUploadStudent
    Dim str As String
    Dim conn1 As OleDbConnection
    Dim dtr As OleDbDataReader
    Dim dta As OleDbDataAdapter
    Dim cmd As OleDbCommand
    Dim dts As Data.DataSet
    Dim excel As String
    Dim OpenFileDialog As New OpenFileDialog
    Private Sub btnLoadData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadData.Click
        Try
            OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            OpenFileDialog.Filter = "All Files (*.*)|*.*|Excel files (*.xlsx)|*.xlsx|CSV Files (*.csv)|*.csv|XLS Files (*.xls)|*xls"

            If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then

                Dim fi As New IO.FileInfo(OpenFileDialog.FileName)
                Dim FileName As String = OpenFileDialog.FileName

                excel = fi.FullName
                conn1 = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excel + ";Extended Properties=Excel 12.0;")
                dta = New OleDbDataAdapter("Select * From [Sheet1$]", conn1)
                dts = New Data.DataSet
                dta.Fill(dts, "[Sheet1$]")
                dg1.DataSource = dts
                dg1.DataMember = "[Sheet1$]"
                conn.Close()
                dg1.Columns(0).ReadOnly = True
                dg1.Columns(1).Width = 180
                dg1.Columns(1).ReadOnly = True
                dg1.Columns(2).Width = 150
                dg1.Columns(2).ReadOnly = True
                dg1.Columns(3).Width = 150
                dg1.Columns(3).ReadOnly = True
                dg1.Columns(4).Width = 150
                dg1.Columns(4).ReadOnly = False
                dg1.Columns(5).Width = 150
                dg1.Columns(5).ReadOnly = False


            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            For x As Integer = 0 To dg1.Rows.Count - 1

                'getAge
                Dim strBirth As String
                Dim intAge As Integer
                strBirth = dg1.Item(11, x).Value
                intAge = Math.Floor(DateDiff(DateInterval.Month, DateValue(strBirth), Now()) / 12)


                'Pronoun and Title
                Dim T, P, Ps, Pe As String
                If dg1.Item(6, x).Value = "Male" Then
                    T = "MR."
                    P = "him"
                    Ps = "he"
                    Pe = "his"
                Else
                    T = "MS."
                    P = "her"
                    Ps = "she"
                    Pe = "her"
                End If

                'str = "update payroll_masterlist set dedGSIS='" & dg1.Item(4, x).Value & "',govtLNR='" & dg1.Item(5, x).Value & "' where IDNumber='" & dg1.Item(0, x).Value & "'"
                'str = "insert into studeprofile (StudentNumber, FirstName, MiddleName, LastName, Sex, CivilStatus, BirthPlace, Religion, email, contactNo, working, occupation, salary, employer, employerAddress, birthDate, admissionDate, graduationDate, guardian, guardianRelationship, guardianContact, guardianAddress, spouse, spouseRelationship, spouseContact, children, spouseIncome, imagePath, course, yearLevel, father, fOccupation, fatherAddress, mother, mOccupation, motherAddress, siblings, birthOrder, age, title, pronoun, pronoun2, pronoun3, scholarship, ethnicity, fourPs, seniorCitizen, als, disability, parentsMonthly, province, city, brgy, sitio, provincePresent, cityPresent, brgyPresent, sitioPresent, elementary, elementaryAddress, elemGraduated, elemMerits, secondary, secondaryAddress, secondaryGraduated, secondaryMerits, vocational, vocationaladdress, vocationalGraduated, vocationalCourse, ncLevel, transfereeSchool, transfereeAddress, transfereeCourse, transfereeGraduated, skills, settingsID, applicationNo, testCenter, testDate, encoder, admissionSem, admissionSY, admissionBasis, lastAttended, lastSchool, lastSchoolDate, honors, rotcSerial, cwtsSerial, 4psNo, nameExtn, fatherContact, motherContact, nationality, Major, SHS, SHSaddress, SHSstrand, SHSgraduated, SHSmerits, VaccStat) values('" & mskStudentNumber.Text & "','" & txtFName.Text & "','" & txtMName.Text & "','" & txtLName.Text & "','" & cboSex.Text & "','" & cboCivilStatus.Text & "','" & txtBirthPlace.Text & "','" & txtReligion.Text & "','" & txtEmail.Text & "','" & mskMobileNumber.Text & "','" & cboWorkingStudent.Text & "','" & txtOccupation.Text & "','" & txtSalary.Text & "','" & txtEmployer.Text & "','" & txtCompanyAddress.Text & "','" & Convert.ToDateTime(dtpBirthDate.Text).ToString("yyyy-MM-dd") & "','" & Convert.ToDateTime(dtpAdmission.Text).ToString("yyyy-MM-dd") & "','" & txtGraduationDate.Text & "','" & txtGuardian.Text & "','" & txtGuardianRelationship.Text & "','" & txtGuardianContact.Text & "','" & txtGuardianAddress.Text & "','" & txtSpouse.Text & "','" & txtSpouseRelationShip.Text & "','" & txtSpouseContact.Text & "','" & txtNoChildren.Text & "','" & txtSpouseIncome.Text & "','','" & cboCourse.Text & "','" & cboYearLevel.Text & "','" & txtFather.Text & "','" & txtFatherOccupation.Text & "','" & txtFatherAddress.Text & "','" & txtMother.Text & "','" & txtMotherOccupation.Text & "','" & txtMotherAddress.Text & "','" & txtSiblings.Text & "','" & txtBirthOrder.Text & "','" & txtAge.Text & "','" & lblTitle.Text & "','" & lblPronoun.Text & "','" & lblPronoun2.Text & "','" & lblPronoun3.Text & "','" & cboScholarship.Text & "','" & cboEthnicity.Text & "','" & cbo4Ps.Text & "','" & cboSenior.Text & "','" & cboAls.Text & "','" & txtDisability.Text & "','" & cboParentsIncome.Text & "','" & cboProvince.Text & "','" & cboMuncipality.Text & "','" & cboBrgy.Text & "','" & txtSubdivision.Text & "','" & cboProvincePresent.Text & "','" & cboMunPresent.Text & "','" & cboBarangayPresent.Text & "','" & txtSubPresent.Text & "','" & txtElementary.Text & "','" & txtElemAddress.Text & "','" & txtElemYear.Text & "','" & txtElemMerits.Text & "','" & txtHighSchool.Text & "','" & txtHSAddress.Text & "','" & txtHSYear.Text & "','" & txtHSMerit.Text & "','" & txtVocational.Text & "','" & txtVocationalAddress.Text & "','" & txtVocYearGrad.Text & "','" & txtVocCourse.Text & "','" & txtVocNC.Text & "','" & txtSchoolTransferee.Text & "','" & txtSchoolTransAddress.Text & "','" & txtCourseTransferee.Text & "','" & txtYearGradTransferee.Text & "','" & cboSkills.Text & "','" & lblSettingsID.Text & "','" & txtApplicationNo.Text & "','" & txtTestCenter.Text & "','" & dtpTestDate.Text & "','" & frmAdmissionForm.lblUser.Text & "','" & cboSemester.Text & "','" & txtSY.Text & "','" & txtAdmissionReq.Text & "','" & txtGraduationDate.Text & "','" & txtLastSchool.Text & "','" & txtDateLastAttended.Text & "','" & txtHonors.Text & "','" & txtROTC.Text & "','" & txtCWTS.Text & "','" & txt4PsNo.Text & "','" & txtExtension.Text & "','" & txtFatherContact.Text & "','" & txtMotherContact.Text & "','" & txtNationality.Text & "','" & cboMajor.Text & "','" & txtSHS.Text & "','" & txtshsAddress.Text & "','" & txtSHSstrand.Text & "','" & txtSHSYearGrad.Text & "','" & txtSHSmerits.Text & "','" & cboVaccStat.Text & "')"
                str = "insert into studeprofile (StudentNumber, LRN, FirstName, MiddleName, LastName, nameExt, Sex, CivilStatus, BirthPlace, Religion, MobileNumber, birthDate, Course, Province, City, Brgy, Sitio, Ethnicity, settingsID, uploadBatch, AdmissionDate, Citizenship, EmailAddress, GraduationDate, ImagePath, Requirements, Title, Pronoun, Pronoun2, Pronoun3, Age) values('" & dg1.Item(0, x).Value & "','" & dg1.Item(1, x).Value & "','" & dg1.Item(2, x).Value & "','" & dg1.Item(3, x).Value & "','" & dg1.Item(4, x).Value & "','" & dg1.Item(5, x).Value & "','" & dg1.Item(6, x).Value & "','" & dg1.Item(7, x).Value & "','" & dg1.Item(8, x).Value & "','" & dg1.Item(9, x).Value & "','" & dg1.Item(10, x).Value & "','" & Convert.ToDateTime(dg1.Item(11, x).Value).ToString("yyyy-MM-dd") & "','" & dg1.Item(12, x).Value & "','" & dg1.Item(13, x).Value & "','" & dg1.Item(14, x).Value & "','" & dg1.Item(15, x).Value & "','" & dg1.Item(16, x).Value & "','" & dg1.Item(17, x).Value & "','1','" & lblBatch.Text & "','" & Convert.ToDateTime(lblDate.Text).ToString("yyyy-MM-dd") & "','Filipino','" & dg1.Item(18, x).Value & "','','','','" & T & "','" & P & "','" & Ps & "','" & Pe & "','" & intAge & "')"
                conn.Open()
                Dim mysC As New MySqlCommand(str, conn)
                mysC.ExecuteNonQuery()
                conn.Close()
            Next

            MsgBox("Uploaded successfully!", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub frmBulkUploadStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        generateRandom()
        lblDate.Text = Today
    End Sub

    Public Sub generateRandom()
        Dim rnd As New Random
        Dim x As Integer
        x = rnd.Next
        lblBatch.Text = x
    End Sub
End Class