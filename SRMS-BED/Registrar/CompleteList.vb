﻿Imports MySql.Data.MySqlClient
Public Class frmCompleteList
    Dim str As String
    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            If chkLastName.Checked = True Then
                str = "select * from studeprofile where LastName like '%" & txtSearch.Text & "%' order by StudentNumber desc"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "studeprofile")
                dgstudentsearch.DataSource = ds.Tables("studeprofile")
                dgstudentsearch.Columns(25).Visible = False
                conn.Close()
                dgstudentsearch.Columns(0).Visible = True
                dgstudentsearch.Columns(0).Width = 150
                dgstudentsearch.Columns(0).HeaderText = "Student Number"
                dgstudentsearch.Columns(1).Visible = True
                dgstudentsearch.Columns(1).Width = 200
                dgstudentsearch.Columns(1).HeaderText = "First Name"
                dgstudentsearch.Columns(2).Visible = True
                dgstudentsearch.Columns(2).Width = 150
                dgstudentsearch.Columns(2).HeaderText = "Midde Name"
                dgstudentsearch.Columns(3).Visible = True
                dgstudentsearch.Columns(3).Width = 200
                dgstudentsearch.Columns(3).HeaderText = "Last Name"
                dgstudentsearch.Columns(4).Visible = True
                dgstudentsearch.Columns(4).Width = 110
                dgstudentsearch.Columns(4).HeaderText = "Sex"
                dgstudentsearch.Columns(5).Visible = False
                dgstudentsearch.Columns(6).Visible = False
                dgstudentsearch.Columns(7).Visible = False
                dgstudentsearch.Columns(8).Visible = False
                dgstudentsearch.Columns(9).Visible = False
                dgstudentsearch.Columns(10).Visible = False
                dgstudentsearch.Columns(11).Visible = False
                dgstudentsearch.Columns(12).Visible = False
                dgstudentsearch.Columns(13).Visible = False
                dgstudentsearch.Columns(14).Visible = False
                dgstudentsearch.Columns(15).Visible = False
                dgstudentsearch.Columns(16).Visible = False
                dgstudentsearch.Columns(17).Visible = False
                dgstudentsearch.Columns(18).Visible = False
                dgstudentsearch.Columns(19).Visible = False
                dgstudentsearch.Columns(20).Visible = False
                dgstudentsearch.Columns(21).Visible = False
                dgstudentsearch.Columns(22).Visible = False
                dgstudentsearch.Columns(23).Visible = False
                dgstudentsearch.Columns(24).Visible = False
                dgstudentsearch.Columns(25).Visible = False
                dgstudentsearch.Columns(26).Visible = False
                dgstudentsearch.Columns(27).Visible = False
                dgstudentsearch.Columns(28).Visible = False
                dgstudentsearch.Columns(29).Visible = False
                dgstudentsearch.Columns(30).Visible = False
                dgstudentsearch.Columns(31).Visible = False
                dgstudentsearch.Columns(32).Visible = False
                dgstudentsearch.Columns(33).Visible = False
                dgstudentsearch.Columns(34).Visible = False
                dgstudentsearch.Columns(35).Visible = False
                dgstudentsearch.Columns(36).Visible = False
                dgstudentsearch.Columns(37).Visible = False
                dgstudentsearch.Columns(38).Visible = False
                dgstudentsearch.Columns(39).Visible = False
                dgstudentsearch.Columns(40).Visible = False
                dgstudentsearch.Columns(41).Visible = False
                dgstudentsearch.Columns(42).Visible = False
                dgstudentsearch.Columns(43).Visible = False
                dgstudentsearch.Columns(44).Visible = False
                dgstudentsearch.Columns(45).Visible = False
                dgstudentsearch.Columns(46).Visible = False
                dgstudentsearch.Columns(47).Visible = False
                dgstudentsearch.Columns(48).Visible = False
                dgstudentsearch.Columns(49).Visible = False
                dgstudentsearch.Columns(50).Visible = False
                dgstudentsearch.Columns(51).Visible = False
                dgstudentsearch.Columns(52).Visible = False
                dgstudentsearch.Columns(53).Visible = False
                dgstudentsearch.Columns(54).Visible = False
                dgstudentsearch.Columns(55).Visible = False
                dgstudentsearch.Columns(56).Visible = False
            End If
            If chkStudentNumber.Checked = True Then
                str = "select * from studeprofile where StudentNumber like '%" & txtSearch.Text & "%' order by StudentNumber desc"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "studeprofile")
                dgstudentsearch.DataSource = ds.Tables("studeprofile")
                dgstudentsearch.Columns(25).Visible = False
                conn.Close()
                dgstudentsearch.Columns(0).Visible = True
                dgstudentsearch.Columns(0).Width = 150
                dgstudentsearch.Columns(0).HeaderText = "Student Number"
                dgstudentsearch.Columns(1).Visible = True
                dgstudentsearch.Columns(1).Width = 200
                dgstudentsearch.Columns(1).HeaderText = "First Name"
                dgstudentsearch.Columns(2).Visible = True
                dgstudentsearch.Columns(2).Width = 150
                dgstudentsearch.Columns(2).HeaderText = "Midde Name"
                dgstudentsearch.Columns(3).Visible = True
                dgstudentsearch.Columns(3).Width = 200
                dgstudentsearch.Columns(3).HeaderText = "Last Name"
                dgstudentsearch.Columns(4).Visible = True
                dgstudentsearch.Columns(4).Width = 110
                dgstudentsearch.Columns(4).HeaderText = "Sex"
                dgstudentsearch.Columns(5).Visible = False
                dgstudentsearch.Columns(6).Visible = False
                dgstudentsearch.Columns(7).Visible = False
                dgstudentsearch.Columns(8).Visible = False
                dgstudentsearch.Columns(9).Visible = False
                dgstudentsearch.Columns(10).Visible = False
                dgstudentsearch.Columns(11).Visible = False
                dgstudentsearch.Columns(12).Visible = False
                dgstudentsearch.Columns(13).Visible = False
                dgstudentsearch.Columns(14).Visible = False
                dgstudentsearch.Columns(15).Visible = False
                dgstudentsearch.Columns(16).Visible = False
                dgstudentsearch.Columns(17).Visible = False
                dgstudentsearch.Columns(18).Visible = False
                dgstudentsearch.Columns(19).Visible = False
                dgstudentsearch.Columns(20).Visible = False
                dgstudentsearch.Columns(21).Visible = False
                dgstudentsearch.Columns(22).Visible = False
                dgstudentsearch.Columns(23).Visible = False
                dgstudentsearch.Columns(24).Visible = False
                dgstudentsearch.Columns(25).Visible = False
                dgstudentsearch.Columns(26).Visible = False
                dgstudentsearch.Columns(27).Visible = False
                dgstudentsearch.Columns(28).Visible = False
                dgstudentsearch.Columns(29).Visible = False
                dgstudentsearch.Columns(30).Visible = False
                dgstudentsearch.Columns(31).Visible = False
                dgstudentsearch.Columns(32).Visible = False
                dgstudentsearch.Columns(33).Visible = False
                dgstudentsearch.Columns(34).Visible = False
                dgstudentsearch.Columns(35).Visible = False
                dgstudentsearch.Columns(36).Visible = False
                dgstudentsearch.Columns(37).Visible = False
                dgstudentsearch.Columns(38).Visible = False
                dgstudentsearch.Columns(39).Visible = False
                dgstudentsearch.Columns(40).Visible = False
                dgstudentsearch.Columns(41).Visible = False
                dgstudentsearch.Columns(42).Visible = False
                dgstudentsearch.Columns(43).Visible = False
                dgstudentsearch.Columns(44).Visible = False
                dgstudentsearch.Columns(45).Visible = False
                dgstudentsearch.Columns(46).Visible = False
                dgstudentsearch.Columns(47).Visible = False
                dgstudentsearch.Columns(48).Visible = False
                dgstudentsearch.Columns(49).Visible = False
                dgstudentsearch.Columns(50).Visible = False
                dgstudentsearch.Columns(51).Visible = False
                dgstudentsearch.Columns(52).Visible = False
                dgstudentsearch.Columns(53).Visible = False
                dgstudentsearch.Columns(54).Visible = False
                dgstudentsearch.Columns(55).Visible = False
                dgstudentsearch.Columns(56).Visible = False
                dgstudentsearch.Columns(57).Visible = False
                dgstudentsearch.Columns(58).Visible = False
                dgstudentsearch.Columns(59).Visible = False
                dgstudentsearch.Columns(60).Visible = False
                dgstudentsearch.Columns(61).Visible = False
                dgstudentsearch.Columns(62).Visible = False
                dgstudentsearch.Columns(63).Visible = False
                dgstudentsearch.Columns(64).Visible = False
                dgstudentsearch.Columns(65).Visible = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub frmCompleteList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chkLastName.Checked = True
        Try
            str = "select * from studeprofile order by StudentNumber DESC"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "studeprofile")
            dgstudentsearch.DataSource = ds.Tables("studeprofile")
            conn.Close()
            dgstudentsearch.Columns(0).Visible = True
            dgstudentsearch.Columns(0).Width = 110
            dgstudentsearch.Columns(0).HeaderText = "Student Number"
            dgstudentsearch.Columns(1).Visible = True
            dgstudentsearch.Columns(1).Width = 200
            dgstudentsearch.Columns(1).HeaderText = "First Name"
            dgstudentsearch.Columns(2).Visible = True
            dgstudentsearch.Columns(2).Width = 150
            dgstudentsearch.Columns(2).HeaderText = "Midde Name"
            dgstudentsearch.Columns(3).Visible = True
            dgstudentsearch.Columns(3).Width = 200
            dgstudentsearch.Columns(3).HeaderText = "Last Name"
            dgstudentsearch.Columns(4).Visible = True
            dgstudentsearch.Columns(4).Width = 110
            dgstudentsearch.Columns(4).HeaderText = "Sex"
            dgstudentsearch.Columns(5).Visible = False
            dgstudentsearch.Columns(6).Visible = False
            dgstudentsearch.Columns(7).Visible = False
            dgstudentsearch.Columns(8).Visible = False
            dgstudentsearch.Columns(9).Visible = False
            dgstudentsearch.Columns(10).Visible = False
            dgstudentsearch.Columns(11).Visible = False
            dgstudentsearch.Columns(12).Visible = False
            dgstudentsearch.Columns(13).Visible = False
            dgstudentsearch.Columns(14).Visible = False
            dgstudentsearch.Columns(15).Visible = False
            dgstudentsearch.Columns(16).Visible = False
            dgstudentsearch.Columns(17).Visible = False
            dgstudentsearch.Columns(18).Visible = False
            dgstudentsearch.Columns(19).Visible = False
            dgstudentsearch.Columns(20).Visible = False
            dgstudentsearch.Columns(21).Visible = False
            dgstudentsearch.Columns(22).Visible = False
            dgstudentsearch.Columns(23).Visible = False
            dgstudentsearch.Columns(24).Visible = False
            dgstudentsearch.Columns(25).Visible = False
            dgstudentsearch.Columns(26).Visible = False
            dgstudentsearch.Columns(27).Visible = False
            dgstudentsearch.Columns(28).Visible = False
            dgstudentsearch.Columns(29).Visible = False
            dgstudentsearch.Columns(30).Visible = False
            dgstudentsearch.Columns(31).Visible = False
            dgstudentsearch.Columns(32).Visible = False
            dgstudentsearch.Columns(33).Visible = False
            dgstudentsearch.Columns(34).Visible = False
            dgstudentsearch.Columns(35).Visible = False
            dgstudentsearch.Columns(36).Visible = False
            dgstudentsearch.Columns(37).Visible = False
            dgstudentsearch.Columns(38).Visible = False
            dgstudentsearch.Columns(39).Visible = False
            dgstudentsearch.Columns(40).Visible = False
            dgstudentsearch.Columns(41).Visible = False
            dgstudentsearch.Columns(42).Visible = False
            dgstudentsearch.Columns(43).Visible = False
            dgstudentsearch.Columns(44).Visible = False
            dgstudentsearch.Columns(45).Visible = False
            dgstudentsearch.Columns(46).Visible = False
            dgstudentsearch.Columns(47).Visible = False
            dgstudentsearch.Columns(48).Visible = False
            dgstudentsearch.Columns(49).Visible = False
            dgstudentsearch.Columns(50).Visible = False
            dgstudentsearch.Columns(51).Visible = False
            dgstudentsearch.Columns(52).Visible = False
            dgstudentsearch.Columns(53).Visible = False
            dgstudentsearch.Columns(54).Visible = False
            dgstudentsearch.Columns(55).Visible = False
            dgstudentsearch.Columns(56).Visible = False
            dgstudentsearch.Columns(57).Visible = False
            dgstudentsearch.Columns(58).Visible = False
            dgstudentsearch.Columns(59).Visible = False
            dgstudentsearch.Columns(60).Visible = False
            dgstudentsearch.Columns(61).Visible = False
            dgstudentsearch.Columns(62).Visible = False
            dgstudentsearch.Columns(63).Visible = False
            dgstudentsearch.Columns(64).Visible = False
            dgstudentsearch.Columns(65).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub dgstudentsearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgstudentsearch.DoubleClick
        Try
            Dim dclick As Integer
            dclick = dgstudentsearch.CurrentRow.Index
            frmStudeProfile.mskStudentNumber.Text = dgstudentsearch.Item(0, dclick).Value
            frmStudeProfile.lblStudentNumber.Text = dgstudentsearch.Item(0, dclick).Value
            frmStudeProfile.txtFName.Text = dgstudentsearch.Item(1, dclick).Value
            frmStudeProfile.txtMName.Text = dgstudentsearch.Item(2, dclick).Value
            frmStudeProfile.txtLName.Text = dgstudentsearch.Item(3, dclick).Value
            frmStudeProfile.cboSex.Text = dgstudentsearch.Item(4, dclick).Value
            frmStudeProfile.cboCivilStatus.Text = dgstudentsearch.Item(5, dclick).Value
            frmStudeProfile.txtBirthPlace.Text = dgstudentsearch.Item(6, dclick).Value
            frmStudeProfile.cboCitizenship.Text = dgstudentsearch.Item(7, dclick).Value
            frmStudeProfile.txtReligion.Text = dgstudentsearch.Item(8, dclick).Value
            frmStudeProfile.txtBloodType.Text = dgstudentsearch.Item(9, dclick).Value
            frmStudeProfile.mskTelNumber.Text = dgstudentsearch.Item(10, dclick).Value
            frmStudeProfile.mskMobileNumber.Text = dgstudentsearch.Item(11, dclick).Value
            frmStudeProfile.txtHighSchool.Text = dgstudentsearch.Item(12, dclick).Value
            frmStudeProfile.txtJHSAddress.Text = dgstudentsearch.Item(13, dclick).Value
            frmStudeProfile.txtCollege.Text = dgstudentsearch.Item(14, dclick).Value
            frmStudeProfile.txtCollegeAddress.Text = dgstudentsearch.Item(15, dclick).Value
            frmStudeProfile.txtRequirements.Text = dgstudentsearch.Item(16, dclick).Value
            frmStudeProfile.dtpBirthDate.Text = dgstudentsearch.Item(18, dclick).Value
            'frmStudeProfile.dtpAdmission.Text = dgstudentsearch.Item(19, dclick).Value
            ' frmStudeProfile.dtpGraduation.Text = dgstudentsearch.Item(20, dclick).Value
            frmStudeProfile.txtGuardian.Text = dgstudentsearch.Item(19, dclick).Value
            frmStudeProfile.txtGuardianContact.Text = dgstudentsearch.Item(20, dclick).Value
            frmStudeProfile.btnSet.Text = dgstudentsearch.Item(21, dclick).Value
            frmStudeProfile.cboCourse.Text = dgstudentsearch.Item(22, dclick).Value
            frmStudeProfile.txtElementary.Text = dgstudentsearch.Item(23, dclick).Value
            frmStudeProfile.txtElemAddress.Text = dgstudentsearch.Item(24, dclick).Value
            frmStudeProfile.txtGuardianRelationship.Text = dgstudentsearch.Item(25, dclick).Value
            frmStudeProfile.mskGuardianTel.Text = dgstudentsearch.Item(26, dclick).Value
            frmStudeProfile.txtEmail.Text = dgstudentsearch.Item(27, dclick).Value
            frmStudeProfile.txtFather.Text = dgstudentsearch.Item(28, dclick).Value
            frmStudeProfile.txtFatherOccupation.Text = dgstudentsearch.Item(29, dclick).Value
            frmStudeProfile.txtMother.Text = dgstudentsearch.Item(30, dclick).Value
            frmStudeProfile.txtMotherOccupation.Text = dgstudentsearch.Item(31, dclick).Value
            frmStudeProfile.txtAge.Text = dgstudentsearch.Item(32, dclick).Value

            frmStudeProfile.cboEthnicity.Text = dgstudentsearch.Item(37, dclick).Value
            frmStudeProfile.txtMonthlyIncome.Text = dgstudentsearch.Item(38, dclick).Value
            frmStudeProfile.cboProvince.Text = dgstudentsearch.Item(39, dclick).Value
            frmStudeProfile.cboMuncipality.Text = dgstudentsearch.Item(40, dclick).Value
            frmStudeProfile.cboBrgy.Text = dgstudentsearch.Item(41, dclick).Value
            frmStudeProfile.txtSubdivision.Text = dgstudentsearch.Item(42, dclick).Value

            frmStudeProfile.lblGuardianOccupation.Text = dgstudentsearch.Item(44, dclick).Value
            frmStudeProfile.txtelemSchoolYear.Text = dgstudentsearch.Item(45, dclick).Value
            frmStudeProfile.txtElemGenAve.Text = dgstudentsearch.Item(46, dclick).Value
            frmStudeProfile.mskElemGradDate.Text = dgstudentsearch.Item(47, dclick).Value
            frmStudeProfile.cboEligibility.Text = dgstudentsearch.Item(48, dclick).Value
            frmStudeProfile.txtJHSGenAve.Text = dgstudentsearch.Item(49, dclick).Value
            frmStudeProfile.mskJHSGradDate.Text = dgstudentsearch.Item(50, dclick).Value
            frmStudeProfile.txtElemSchoolID.Text = dgstudentsearch.Item(51, dclick).Value
            frmStudeProfile.txtJHSSchoolID.Text = dgstudentsearch.Item(52, dclick).Value
            frmStudeProfile.txtPEPTRating.Text = dgstudentsearch.Item(53, dclick).Value
            frmStudeProfile.mskPEPTExamDate.Text = dgstudentsearch.Item(54, dclick).Value
            frmStudeProfile.txtALSRating.Text = dgstudentsearch.Item(55, dclick).Value
            frmStudeProfile.txtAlsTestingCenter.Text = dgstudentsearch.Item(56, dclick).Value
            frmStudeProfile.txtNameExt.Text = dgstudentsearch.Item(57, dclick).Value
            frmStudeProfile.txtRFID.Text = dgstudentsearch.Item(58, dclick).Value
            frmStudeProfile.txtLRN.Text = dgstudentsearch.Item(59, dclick).Value
            frmStudeProfile.cboClassification.Text = dgstudentsearch.Item(60, dclick).Value
            frmStudeProfile.txtFatherContactNo.Text = dgstudentsearch.Item(61, dclick).Value
            frmStudeProfile.txtMotherContactNo.Text = dgstudentsearch.Item(62, dclick).Value
            frmStudeProfile.cboScholarship.Text = dgstudentsearch.Item(64, dclick).Value
            frmStudeProfile.txtNotes.Text = dgstudentsearch.Item(65, dclick).Value


            '  frmuseraccounts.txtUsername.Text = dgstudentsearch.Item(0, dclick).Value
            ' frmuseraccounts.txtFName.Text = dgstudentsearch.Item(1, dclick).Value
            ' frmuseraccounts.txtMName.Text = dgstudentsearch.Item(2, dclick).Value
            ' frmuseraccounts.txtLName.Text = dgstudentsearch.Item(3, dclick).Value


            frmStudeProfile.btnSave.Text = "UPDATE"
            frmStudeProfile.btnDelete.Enabled = True
            frmStudeProfile.btnDelete.Visible = True
            ' frmStudeProfile.tsLRN.Enabled = True
            ' frmStudeProfile.tsPrint.Enabled = True
            ' frmStudeProfile.tsCAV.Enabled = True


            frmStudeProfile.Tab.Show()


            frmStudeProfile.getAge()
            frmStudeProfile.getRequirements()
            txtSearch.Clear()
            txtSearch.Focus()
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub
End Class