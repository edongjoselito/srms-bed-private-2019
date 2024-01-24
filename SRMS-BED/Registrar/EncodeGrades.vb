Imports MySql.Data.MySqlClient
Public Class frmEncodeGrades
    Dim str As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmSearchForEncodeGrades.ShowDialog()
        frmSearchForEncodeGrades.txtSearch.Focus()

    End Sub

    Private Sub tsNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsNew.Click
        frmSearchStudeEncodeGrades.ShowDialog()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try

            str = "insert into grades values(0,'" & mskStudentNumber.Text & "','" & txtStudeName.Text & "','" & txtSubjectCode.Text & "','" & txtDescription.Text & "','" & txtLec.Text & "','" & txtLab.Text & "','" & txtTeacher.Text & "','" & txtSection.Text & "','" & txtFirst.Text & "','" & txtSecond.Text & "','" & txtThird.Text & "','" & txtFourth.Text & "','" & txtFirst.Text & "','" & frmRegistrar.stSemester.Text & "','" & frmRegistrar.stSY.Text & "','Open','Open','Open','Open','" & frmModifyGrades.lblYearLevel.Text & "','" & frmRegistrar.lblSettingsID.Text & "','" & frmModifyGrades.lblTrack.Text & "','" & frmModifyGrades.lblQualification.Text & "','" & frmModifyGrades.lblAdviser.Text & "','" & txtSubComp.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()

            MsgBox("Record successfully saved!", MsgBoxStyle.Information)

            formLoad()
            frmModifyGrades.getGrades()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()

        End Try
    End Sub
    Public Sub formLoad()
        'mskStudentNumber.Clear()
        'txtStudeName.Clear()

        txtSubjectCode.Clear()
        txtDescription.Clear()
        txtSubComp.Clear()
        txtSection.Clear()
        txtTeacher.Clear()
        txtFirst.Text = 0
        txtSecond.Text = 0
        txtThird.Text = 0
        txtFourth.Text = 0

    End Sub

    Private Sub frmEncodeGrades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtDescription_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescription.TextChanged
        If txtDescription.Text.Contains("MAPEH") OrElse txtDescription.Text.Contains("Mapeh") OrElse txtDescription.Text.Contains("Music Arts Physical Education Health") Then


        Else

            txtSubComp.Text = ""
        End If
    End Sub
End Class