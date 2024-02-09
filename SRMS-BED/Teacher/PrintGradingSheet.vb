Imports MySql.Data.MySqlClient
Public Class frmPrintGradingSheet
    Dim str As String
   
    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Try
            If txtsubjectcode.Text = "" Or txtSection.Text = "" Or txtInstructor.Text = "'" Then
                MsgBox("All fields are required.  Please fill it up completely!", MsgBoxStyle.Information)
                txtsubjectcode.Focus()
                Exit Sub
            End If

            If cboPeriod.Text = "1st Grading" Then
                str = "select g.Instructor, sp.StudentNumber, sp.Sex, concat(sp.LastName,', ',sp.FirstName,' ',sp.MiddleName) as StudentName, g.Section, g.SubjectCode, g.Description,g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Average, g.SY, g.Sem, sr.SchoolName, sr.SchoolAddress, sr.letterHead from grades g join studeprofile sp on sp.StudentNumber=g.StudentNumber join srms_settings sr on sp.settingsID=sr.settingsID where g.SubjectCode='" & txtsubjectcode.Text & "' and g.Instructor='" & txtInstructor.Text & "' and g.Section='" & txtSection.Text & "' and g.Description='" & txtDescription.Text & "' and g.subComponent='" & cboSubComp.Text & "' and g.SY='" & frmTeacher.stSY.Text & "' group by g.SubjectCode, g.StudentNumber  order by StudentName"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysda.Fill(mysds, "studeprofile, grades")
                Dim obj As New GS1st
                obj.SetDataSource(mysds.Tables("studeprofile, grades"))
                obj.SetParameterValue("subComponent", cboSubComp.Text)
                frmTeacher.crViewer.ReportSource = obj
                conn.Close()
                frmTeacher.crViewer.Visible = True
                Me.Hide()

            ElseIf cboPeriod.Text = "2nd Grading" Then
                str = "select g.Instructor, sp.StudentNumber, sp.Sex, concat(sp.LastName,', ',sp.FirstName,' ',sp.MiddleName) as StudentName, g.Section, g.SubjectCode, g.Description, g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Average, g.SY, g.Sem, sr.SchoolName, sr.SchoolAddress, sr.letterHead from grades g join studeprofile sp on sp.StudentNumber=g.StudentNumber join srms_settings sr on sp.settingsID=sr.settingsID where g.SubjectCode='" & txtsubjectcode.Text & "' and g.Instructor='" & txtInstructor.Text & "' and g.Section='" & txtSection.Text & "' and g.Description='" & txtDescription.Text & "' and g.subComponent='" & cboSubComp.Text & "'  and g.SY='" & frmTeacher.stSY.Text & "' order by StudentName"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysda.Fill(mysds, "studeprofile, grades")
                Dim obj As New GS2nd
                obj.SetDataSource(mysds.Tables("studeprofile, grades"))
                obj.SetParameterValue("subComponent", cboSubComp.Text)
                frmTeacher.crViewer.ReportSource = obj
                conn.Close()
                frmTeacher.crViewer.Visible = True
                Me.Hide()

            ElseIf cboPeriod.Text = "3rd Grading" Then
                str = "select g.Instructor, sp.StudentNumber, sp.Sex, concat(sp.LastName,', ',sp.FirstName,' ',sp.MiddleName) as StudentName, g.Section, g.SubjectCode, g.Description, g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Average, g.SY, g.Sem, sr.SchoolName, sr.SchoolAddress, sr.letterHead from grades g join studeprofile sp on sp.StudentNumber=g.StudentNumber join srms_settings sr on sp.settingsID=sr.settingsID where g.SubjectCode='" & txtsubjectcode.Text & "' and g.Instructor='" & txtInstructor.Text & "' and g.Section='" & txtSection.Text & "' and g.Description='" & txtDescription.Text & "' and g.subComponent='" & cboSubComp.Text & "' and g.SY='" & frmTeacher.stSY.Text & "' order by StudentName"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysda.Fill(mysds, "studeprofile, grades")
                Dim obj As New GS3rd
                obj.SetDataSource(mysds.Tables("studeprofile, grades"))
                obj.SetParameterValue("subComponent", cboSubComp.Text)
                frmTeacher.crViewer.ReportSource = obj
                conn.Close()
                frmTeacher.crViewer.Visible = True
                Me.Hide()

            ElseIf cboPeriod.Text = "4th Grading" Then
                str = "select g.Instructor, sp.StudentNumber, sp.Sex, concat(sp.LastName,', ',sp.FirstName,' ',sp.MiddleName) as StudentName, g.Section, g.SubjectCode, g.Description, g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Average, g.SY, g.Sem, sr.SchoolName, sr.SchoolAddress, sr.letterHead from grades g join studeprofile sp on sp.StudentNumber=g.StudentNumber join srms_settings sr on sp.settingsID=sr.settingsID where g.SubjectCode='" & txtsubjectcode.Text & "' and g.Instructor='" & txtInstructor.Text & "' and g.Section='" & txtSection.Text & "' and g.Description='" & txtDescription.Text & "' and g.subComponent='" & cboSubComp.Text & "' and g.SY='" & frmTeacher.stSY.Text & "' order by StudentName"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysda.Fill(mysds, "studeprofile, grades")
                Dim obj As New GS4th
                obj.SetDataSource(mysds.Tables("studeprofile, grades"))
                obj.SetParameterValue("subComponent", cboSubComp.Text)
                frmTeacher.crViewer.ReportSource = obj
                conn.Close()
                frmTeacher.crViewer.Visible = True
                Me.Hide()
            Else
                If frmTeacher.stSemester.Text = "" Then
                    str = "select g.Instructor, sp.StudentNumber, sp.Sex, concat(sp.LastName,', ',sp.FirstName,' ',sp.MiddleName) as StudentName, g.Section, g.SubjectCode, g.Description, g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Average, g.SY, g.Sem, sr.SchoolName, sr.SchoolAddress, sr.letterHead from grades g join studeprofile sp on sp.StudentNumber=g.StudentNumber join srms_settings sr on sp.settingsID=sr.settingsID where g.SubjectCode='" & txtsubjectcode.Text & "' and g.Instructor='" & txtInstructor.Text & "' and g.Section='" & txtSection.Text & "' and g.Description='" & txtDescription.Text & "' and g.subComponent='" & cboSubComp.Text & "' and g.SY='" & frmTeacher.stSY.Text & "' order by StudentName"
                    conn.Open()
                    Dim mysda As New MySqlDataAdapter(str, conn)
                    Dim mysds As New DataSet
                    mysda.Fill(mysds, "studeprofile, grades")
                    Dim obj As New GradingSheetJHS
                    obj.SetDataSource(mysds.Tables("studeprofile, grades"))
                    obj.SetParameterValue("subComponent", cboSubComp.Text)
                    frmTeacher.crViewer.ReportSource = obj
                    conn.Close()
                    frmTeacher.crViewer.Visible = True
                    Me.Hide()
                Else
                    str = "select g.Instructor, sp.StudentNumber, sp.Sex, concat(sp.LastName,', ',sp.FirstName,' ',sp.MiddleName) as StudentName, g.Section, g.SubjectCode, g.Description, g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Average, g.SY, g.Sem, sr.SchoolName, sr.SchoolAddress, sr.letterHead from grades g join studeprofile sp on sp.StudentNumber=g.StudentNumber join srms_settings sr on sp.settingsID=sr.settingsID where g.SubjectCode='" & txtsubjectcode.Text & "' and g.Instructor='" & txtInstructor.Text & "' and g.Section='" & txtSection.Text & "' and g.Description='" & txtDescription.Text & "' and g.subComponent='" & cboSubComp.Text & "' and g.SY='" & frmTeacher.stSY.Text & "' order by StudentName"
                    conn.Open()
                    Dim mysda As New MySqlDataAdapter(str, conn)
                    Dim mysds As New DataSet
                    mysda.Fill(mysds, "studeprofile, grades")
                    Dim obj As New GradingSheet
                    obj.SetDataSource(mysds.Tables("studeprofile, grades"))
                    obj.SetParameterValue("subComponent", cboSubComp.Text)
                    frmTeacher.crViewer.ReportSource = obj
                    conn.Close()
                    frmTeacher.crViewer.Visible = True
                    Me.Hide()
                End If
               
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnSelectSubject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Public Sub getInstructor()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select concat(FirstName,' ',LastName) as Name from staff where IDNumber='" & frmTeacher.stUser.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                txtInstructor.Text = dtReader.Item(0)
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Public Sub getGradeLevel()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select YearLevel, Section from registration where Instructor='" & txtInstructor.Text & "' and Sem='" & frmTeacher.stSemester.Text & "' and SY='" & frmTeacher.stSY.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lblYearLevel.Text = dtReader.Item(0)
                'lblSection.Text = dtReader.Item(1)
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub frmPrintGradingSheet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getInstructor()
        getGradeLevel()
        getAcctLevel()
        cboSubComp.Text = ""
    End Sub

    Public Sub getAcctLevel()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select * from users where username='" & frmTeacher.stUser.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lblUserLevel.Text = dtReader(2)
                'lblName.Text = dtReader(4)

            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        frmSearchPrintGS.Show()
    End Sub

    Private Sub txtDescription_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescription.TextChanged
        If txtDescription.Text.Contains("MAPEH") OrElse txtDescription.Text.Contains("Mapeh") OrElse txtDescription.Text.Contains("Music Arts Physical Education Health") Then
            cboSubComp.Enabled = True

        Else

            cboSubComp.SelectedIndex = 0
            cboSubComp.Enabled = False
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class