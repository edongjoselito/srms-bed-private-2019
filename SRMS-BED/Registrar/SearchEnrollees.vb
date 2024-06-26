﻿Imports MySql.Data.MySqlClient
Public Class frmSearchEnrollees
    Dim str As String

    Private Sub frmSearchEnrollees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select semstudentid, p.StudentNumber, p.FirstName, p.MiddleName, p.LastName, m.Course, YearLevel, Status, StudeStatus, Section, m.Scholarship, Track, Qualification, BalikAral, IP, FourPs, Repeater, Transferee from semesterstude m join studeprofile p on m.StudentNumber=p.StudentNumber where Semester='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "' order by p.LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New Data.DataSet
            mysda.Fill(ds, "semesterstude, studeprofile")
            dg1.DataSource = ds.Tables("semesterstude, studeprofile")
            conn.Close()
            dg1.Columns(0).Visible = False
            dg1.Columns(1).Visible = True
            dg1.Columns(1).HeaderText = "Student Number"
            dg1.Columns(2).Visible = True
            dg1.Columns(2).HeaderText = "First Name"
            dg1.Columns(3).Visible = True
            dg1.Columns(3).HeaderText = "Middle Name"
            dg1.Columns(4).Visible = True
            dg1.Columns(4).HeaderText = "Last Name"
            dg1.Columns(5).Visible = True
            dg1.Columns(5).HeaderText = "Department"
            dg1.Columns(6).Visible = True
            dg1.Columns(6).HeaderText = "Grade Level"

            dg1.Columns(7).Visible = False
            dg1.Columns(8).Visible = False
            dg1.Columns(9).Visible = False
            dg1.Columns(10).Visible = False
            dg1.Columns(11).Visible = False
            dg1.Columns(12).Visible = False
            dg1.Columns(13).Visible = False
            dg1.Columns(14).Visible = False
            dg1.Columns(15).Visible = False
            dg1.Columns(16).Visible = False
            dg1.Columns(17).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select semstudentid, p.StudentNumber, p.FirstName, p.MiddleName, p.LastName, m.Course, YearLevel, Status, StudeStatus, Section, m.Scholarship, Track, Qualification, BalikAral, IP, FourPs, Repeater, Transferee from semesterstude m join studeprofile p on m.StudentNumber=p.StudentNumber where LastName like '%" & txtSearch.Text & "%' and Semester='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "' order by LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New Data.DataSet
            mysda.Fill(ds, "semesterstude, studeprofile")
            dg1.DataSource = ds.Tables("semesterstude, studeprofile")
            conn.Close()
            dg1.Columns(0).Visible = False
            dg1.Columns(1).Visible = True
            dg1.Columns(1).HeaderText = "Student Number"
            dg1.Columns(2).Visible = True
            dg1.Columns(2).HeaderText = "First Name"
            dg1.Columns(3).Visible = True
            dg1.Columns(3).HeaderText = "Middle Name"
            dg1.Columns(4).Visible = True
            dg1.Columns(4).HeaderText = "Last Name"
            dg1.Columns(5).Visible = True
            dg1.Columns(5).HeaderText = "Department"
            dg1.Columns(6).Visible = True
            dg1.Columns(6).HeaderText = "Grade Level"


            dg1.Columns(7).Visible = False
            dg1.Columns(8).Visible = False
            dg1.Columns(9).Visible = False
            dg1.Columns(10).Visible = False
            dg1.Columns(11).Visible = False
            dg1.Columns(12).Visible = False
            dg1.Columns(13).Visible = False
            dg1.Columns(14).Visible = False
            dg1.Columns(15).Visible = False
            dg1.Columns(16).Visible = False
            dg1.Columns(17).Visible = False


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Try

            Dim i As Integer
            i = dg1.CurrentRow.Index
            frmSemStudent.lblID.Text = dg1(0, i).Value
            frmSemStudent.mskStudentNumber.Text = dg1(1, i).Value
            frmSemStudent.txtFname.Text = dg1(2, i).Value
            frmSemStudent.txtMName.Text = dg1(3, i).Value
            frmSemStudent.txtLastName.Text = dg1(4, i).Value
            frmSemStudent.cboCourse.Text = dg1(5, i).Value
            frmSemStudent.cboYear.Text = dg1(6, i).Value

            frmSemStudent.cboStatus.Text = dg1(7, i).Value
            frmSemStudent.cboStudeStatus.Text = dg1(8, i).Value
            frmSemStudent.cboSection.Text = dg1(9, i).Value
            frmSemStudent.cboScholarship.Text = dg1(10, i).Value
            frmSemStudent.cboTrack.Text = dg1.Item(11, i).Value
            frmSemStudent.cboQualification.Text = dg1.Item(12, i).Value
            frmSemStudent.cboBalikAral.Text = dg1.Item(13, i).Value
            frmSemStudent.cboIP.Text = dg1.Item(14, i).Value
            frmSemStudent.cbo4Ps.Text = dg1.Item(15, i).Value
            frmSemStudent.cboRepeater.Text = dg1.Item(16, i).Value
            frmSemStudent.cboTransferee.Text = dg1.Item(17, i).Value


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

        frmSemStudent.btnSave.Text = "UPDATE"
        frmSemStudent.btnDelete.Visible = True
        frmSemStudent.Enabled = True

        frmSemStudent.btnAccecelrated.Enabled = True
        frmSemStudent.btnDropped.Enabled = True
        frmSemStudent.btnTransferredOut.Enabled = True

        Me.Close()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class