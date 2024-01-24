﻿Imports MySql.Data.MySqlClient
Public Class frmFirstGradingSearch
    Dim str As String
    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            If frmFirstGrading.txtInstructor.Text = "" Then
                str = " select SubjectCode, Description, Section, ff.IDNumber, concat(FIrstName,' ',MiddleName,' ',LastName) as Teacher from semsubjects s join staff ff on s.IDNumber=ff.IDNumber where SubjectCode like '%" & txtSearch.Text & "%' and Semester='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "' order by SubjectCode"
                conn.Open()
                Dim Search As New MySqlDataAdapter(str, conn)
                Dim ds As DataSet = New DataSet
                Search.Fill(ds, "semsubjects, staff")
                dg1.DataSource = ds.Tables("semsubjects, staff")
                conn.Close()
                dg1.Columns(0).HeaderText = "SUBJECT CODE"
                dg1.Columns(1).Width = 80
                dg1.Columns(1).HeaderText = "DESCRIPTION"
                dg1.Columns(1).Width = 250
                dg1.Columns(2).HeaderText = "SECTION"
                dg1.Columns(3).HeaderText = "TEACHER'S ID"
                dg1.Columns(4).HeaderText = "TEACHER"
                dg1.Columns(4).Width = 250



            Else
                str = " select SubjectCode, Description, Section, ff.IDNumber, concat(FIrstName,' ',MiddleName,' ',LastName) as Teacher from semsubjects s join staff ff on s.IDNumber=ff.IDNumber where SubjectCode like '%" & txtSearch.Text & "%' and Semester='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "' and Instructor='" & frmFirstGrading.txtInstructor.Text & "' order by SubjectCode"
                conn.Open()
                Dim Search As New MySqlDataAdapter(str, conn)
                Dim ds As DataSet = New DataSet
                Search.Fill(ds, "semsubjects, staff")
                dg1.DataSource = ds.Tables("semsubjects, staff")
                conn.Close()
                dg1.Columns(0).HeaderText = "SUBJECT CODE"
                dg1.Columns(1).Width = 80
                dg1.Columns(1).HeaderText = "DESCRIPTION"
                dg1.Columns(1).Width = 250
                dg1.Columns(2).HeaderText = "SECTION"
                dg1.Columns(3).HeaderText = "TEACHER'S ID"
                dg1.Columns(4).HeaderText = "TEACHER"
                dg1.Columns(4).Width = 250

            End If
            
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub frmGPrelimSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If frmFirstGrading.txtInstructor.Text = "" Then
                str = "select SubjectCode, Description, Section, ff.IDNumber, concat(FIrstName,' ',MiddleName,' ',LastName) as Teacher from semsubjects s join staff ff on s.IDNumber=ff.IDNumber where Semester='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "' order by SubjectCode"
                conn.Open()
                Dim mysC As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet

                mysC.Fill(ds, "semsubjects")
                dg1.DataSource = ds.Tables("semsubjects")
                conn.Close()
                dg1.Columns(0).HeaderText = "SUBJECT CODE"
                dg1.Columns(1).Width = 80
                dg1.Columns(1).HeaderText = "DESCRIPTION"
                dg1.Columns(1).Width = 250
                dg1.Columns(2).HeaderText = "SECTION"
                dg1.Columns(3).HeaderText = "TEACHER'S ID"
                dg1.Columns(4).HeaderText = "TEACHER"
                dg1.Columns(4).Width = 250

            Else
                str = "select SubjectCode, Description, Section, ff.IDNumber, concat(FIrstName,' ',MiddleName,' ',LastName) as Teacher from semsubjects s join staff ff on s.IDNumber=ff.IDNumber where Semester='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "' and Instructor='" & frmFirstGrading.txtInstructor.Text & "' order by SubjectCode"
                conn.Open()
                Dim mysC As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet

                mysC.Fill(ds, "semsubjects")
                dg1.DataSource = ds.Tables("semsubjects")
                conn.Close()

                dg1.Columns(0).HeaderText = "SUBJECT CODE"
                dg1.Columns(1).Width = 80
                dg1.Columns(1).HeaderText = "DESCRIPTION"
                dg1.Columns(1).Width = 250
                dg1.Columns(2).HeaderText = "SECTION"
                dg1.Columns(3).HeaderText = "TEACHER'S ID"
                dg1.Columns(4).HeaderText = "TEACHER"
                dg1.Columns(4).Width = 250
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Try

            Dim i As Integer
            i = dg1.CurrentRow.Index

            If dg1(2, i).Value.Contains("MAPEH") OrElse dg1(2, i).Value.Contains("Mapeh") OrElse dg1(2, i).Value.Contains("Music Arts Physical Education Health") Then
                frmFirstGrading.txtSubjectcode.Text = dg1(0, i).Value
                frmFirstGrading.txtDescription.Text = dg1(1, i).Value
                frmFirstGrading.txtSection.Text = dg1(2, i).Value
                frmFirstGrading.lblInstructorID.Text = dg1(3, i).Value
                frmFirstGrading.txtInstructor.Text = dg1(4, i).Value
                'frmFirstGrading.lblSubjectStatus.Text = dg1(16, i).Value

                'frmFirstGrading.tsSave.Enabled = True
                frmFirstGrading.tsDelete.Enabled = True
                frmFirstGrading.getInstructor()
                frmFirstGrading.getStatus()
                frmMapehComponent.ShowDialog()

            Else
                frmFirstGrading.txtSubjectcode.Text = dg1(0, i).Value
                frmFirstGrading.txtDescription.Text = dg1(1, i).Value
                frmFirstGrading.txtSection.Text = dg1(2, i).Value
                frmFirstGrading.lblInstructorID.Text = dg1(3, i).Value
                frmFirstGrading.txtInstructor.Text = dg1(4, i).Value

                'frmFirstGrading.tsSave.Enabled = True
                frmFirstGrading.tsDelete.Enabled = True
                frmFirstGrading.getInstructor()
                frmFirstGrading.getStatus()
                'frmFirstGrading.disableSave()
            End If


            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class