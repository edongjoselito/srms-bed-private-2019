﻿Imports MySql.Data.MySqlClient
Public Class frmSearchSubjects
    Dim str As String

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        Try

            str = "select * from subjects where description like '%" & txtsearch.Text & "%' or SubjectCode like '%" & txtsearch.Text & "%'"
            conn.Open()
            Dim Search As New MySqlDataAdapter(str, conn)
            Dim ds As Data.DataSet = New Data.DataSet
            Search.Fill(ds, "subjects")
            dgsubjects.DataSource = ds.Tables("subjects")
            conn.Close()
            dgsubjects.Columns(0).Visible = False
            dgsubjects.Columns(1).HeaderText = "Subject Code"
            dgsubjects.Columns(2).HeaderText = "Description"
            dgsubjects.Columns(2).Width = 300
            dgsubjects.Columns(3).Width = 120
            dgsubjects.Columns(3).HeaderText = "Grade Level"
            dgsubjects.Columns(4).Visible = False
            dgsubjects.Columns(5).Visible = False
            dgsubjects.Columns(6).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub


    Private Sub dgsubjects_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgsubjects.DoubleClick
        Try
            Dim dclick As Integer
            dclick = dgsubjects.CurrentRow.Index
            frmSemSubjects.txtSubjectCode.Text = dgsubjects.Item(1, dclick).Value
            frmSemSubjects.txtSubjectDescription.Text = dgsubjects.Item(2, dclick).Value
            'frmSemSubjects.txtLecUnits.Text = dgsubjects.Item(3, dclick).Value
            ' frmSemSubjects.txtLabUnits.Text = dgsubjects.Item(4, dclick).Value

            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

    End Sub

    Private Sub frmSearchSubjects_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            str = "select * from subjects where Course='" & frmSemSubjects.cboCourse.Text & "' and YearLevel='" & frmSemSubjects.cboYearLevel.Text & "' order by SubjectCode"
            conn.Open()
            Dim Search As New MySqlDataAdapter(str, conn)
            Dim ds As Data.DataSet = New Data.DataSet
            Search.Fill(ds, "subjects")
            dgsubjects.DataSource = ds.Tables("subjects")
            conn.Close()
            dgsubjects.Columns(0).Visible = False
            dgsubjects.Columns(1).HeaderText = "Subject Code"
            dgsubjects.Columns(2).HeaderText = "Description"
            dgsubjects.Columns(2).Width = 300
            dgsubjects.Columns(3).Width = 120
            dgsubjects.Columns(3).HeaderText = "Grade Level"
            dgsubjects.Columns(4).Visible = False
            dgsubjects.Columns(5).Visible = False
            dgsubjects.Columns(6).Visible = False


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class