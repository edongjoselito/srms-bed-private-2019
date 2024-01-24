Imports MySql.Data.MySqlClient
Public Class frmSemSubjects
    Dim str As String
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmSemSubjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Formload()

    End Sub

    Public Sub getSections()
        Try
            str = "select * from sections where YearLevel='" & cboYearLevel.Text & "' group by Section order by Section"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New Data.DataSet
            mysda.Fill(ds, "sections")
            conn.Close()
            cboSection.ValueMember = "sections"
            cboSection.DisplayMember = "Section"
            cboSection.DataSource = ds.Tables("sections")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Public Sub Formload()
        Try
            str = "SELECT subjectid, SubjectCode, Description, Section, SchedTime, Room, Time1, AM1, Time2, AM2, Course, YearLevel, SubjectStatus, ff.IDNumber, concat(FirstName,' ',MiddleName,' ',LastName) as Teacher, Days1 FROM semsubjects s join staff ff on s.IDNumber=ff.IDNumber where Semester ='" & frmAdmin.stSemester.Text & "' and SY='" & frmAdmin.stSY.Text & "' order by SubjectCode"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim ds As New Data.DataSet
            mysDA.Fill(ds, "semsubjects")
            dgsubjects.DataSource = ds.Tables("semsubjects")
            conn.Close()

            dgsubjects.Columns(0).Visible = False
            dgsubjects.Columns(1).Width = 100
            dgsubjects.Columns(1).HeaderText = "SUBJECT CODE"
            dgsubjects.Columns(2).Width = 200
            dgsubjects.Columns(2).HeaderText = "DESCRIPTION"
            dgsubjects.Columns(3).HeaderText = "SECTION"
            dgsubjects.Columns(4).HeaderText = "CLASS SCHEDULE"
            dgsubjects.Columns(4).Width = 200
            dgsubjects.Columns(5).HeaderText = "ROOM"
            dgsubjects.Columns(6).Visible = False
            dgsubjects.Columns(7).Visible = False
            dgsubjects.Columns(8).Visible = False
            dgsubjects.Columns(9).Visible = False
            dgsubjects.Columns(10).HeaderText = "DEPARTMENT"
            dgsubjects.Columns(11).HeaderText = "YEAR LEVEL"
            dgsubjects.Columns(12).Visible = False
            dgsubjects.Columns(13).Visible = False
            dgsubjects.Columns(14).HeaderText = "TEACHER"
            dgsubjects.Columns(14).Width = 200
            dgsubjects.Columns(15).Visible = False
            txtSubjectCode.Clear()
            txtSubjectDescription.Clear()

            txtLab.Clear()
            txtTime.Clear()
            'txtRoom.ResetText()

            txtInstructor.Clear()
            txtInstructorName.Clear()
            cboTime1.ResetText()
            cboAM1.ResetText()
            cboTime2.ResetText()
            cboAM2.ResetText()


            btnSave.Text = "SAVE"
            btnDelete.Visible = False

            getCourse()
            getSections()
            getRooms()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
    Public Sub getCourse()
        Try
            If frmAdmin.stSemester.Text = "First Semester" Or frmAdmin.stSemester.Text = "Second Semester" Then
                str = "select * from course_table where CourseDescription='Senior High School' group by CourseDescription order by CourseDescription"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New Data.DataSet
                mysda.Fill(ds, "course_table")
                conn.Close()

                cboCourse.ValueMember = "course_table"
                cboCourse.DisplayMember = "CourseDescription"
                cboCourse.DataSource = ds.Tables("course_table")
                conn.Close()
            Else
                str = "select * from course_table where CourseDescription!='Senior High School' group by CourseDescription order by CourseDescription"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New Data.DataSet
                mysda.Fill(ds, "course_table")
                conn.Close()

                cboCourse.ValueMember = "course_table"
                cboCourse.DisplayMember = "CourseDescription"
                cboCourse.DataSource = ds.Tables("course_table")
                conn.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub getCourseMajor()
        Try
            str = "select * from course_table where CourseDescription='" & cboCourse.Text & "' order by Major"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New Data.DataSet
            mysda.Fill(ds, "course_table")
            conn.Close()

            cboYearLevel.ValueMember = "course_table"
            cboYearLevel.DisplayMember = "Major"
            cboYearLevel.DataSource = ds.Tables("course_table")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub getRooms()
        Try
            str = "select * from rooms group by Room order by Room"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New Data.DataSet
            mysda.Fill(ds, "rooms")
            conn.Close()
            txtRoom.ValueMember = "rooms"
            txtRoom.DisplayMember = "Room"
            txtRoom.DataSource = ds.Tables("rooms")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub loadSubjects()
        Try
            str = "SELECT subjectid, SubjectCode, Description, Section, SchedTime, Room, Time1, AM1, Time2, AM2, Course, YearLevel, SubjectStatus, ff.IDNumber, concat(FirstName,' ',MiddleName,' ',LastName) as Teacher, Days1 FROM semsubjects s join staff ff on s.IDNumber=ff.IDNumber where Semester ='" & frmAdmin.stSemester.Text & "' and SY='" & frmAdmin.stSY.Text & "' and Course='" & cboCourse.Text & "' and YearLevel='" & cboYearLevel.Text & "' and Section='" & cboSection.Text & "'  order by SubjectCode"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim ds As New Data.DataSet
            mysDA.Fill(ds, "semsubjects")
            dgsubjects.DataSource = ds.Tables("semsubjects")
            conn.Close()

            dgsubjects.Columns(0).Visible = False
            dgsubjects.Columns(1).Width = 100
            dgsubjects.Columns(1).HeaderText = "SUBJECT CODE"
            dgsubjects.Columns(2).Width = 200
            dgsubjects.Columns(2).HeaderText = "DESCRIPTION"
            dgsubjects.Columns(3).HeaderText = "SECTION"
            dgsubjects.Columns(4).HeaderText = "CLASS SCHEDULE"
            dgsubjects.Columns(4).Width = 200
            dgsubjects.Columns(5).HeaderText = "ROOM"
            dgsubjects.Columns(6).Visible = False
            dgsubjects.Columns(7).Visible = False
            dgsubjects.Columns(8).Visible = False
            dgsubjects.Columns(9).Visible = False
            dgsubjects.Columns(10).HeaderText = "DEPARTMENT"
            dgsubjects.Columns(11).HeaderText = "YEAR LEVEL"
            dgsubjects.Columns(12).Visible = False
            dgsubjects.Columns(13).Visible = False
            dgsubjects.Columns(14).HeaderText = "TEACHER"
            dgsubjects.Columns(14).Width = 200
            dgsubjects.Columns(15).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub cboCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCourse.SelectedIndexChanged
        getCourseMajor()
    End Sub

    Private Sub cboYearLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYearLevel.SelectedIndexChanged
        getSections()
    End Sub


    Private Sub cboSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSection.SelectedIndexChanged
        loadSubjects()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            If chkSubjectCode.Checked = True Then

                str = "SELECT subjectid, SubjectCode, Description, Section, SchedTime, Room, Time1, AM1, Time2, AM2, Course, YearLevel, SubjectStatus, ff.IDNumber, concat(FirstName,' ',MiddleName,' ',LastName) as Teacher, Days1 FROM semsubjects s join staff ff on s.IDNumber=ff.IDNumber where SubjectCode like '%" & txtSearch.Text & "%' and SY='" & frmAdmin.stSY.Text & "' and Semester='" & frmAdmin.stSemester.Text & "'"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim ds As New Data.DataSet
                mysDA.Fill(ds, "semsubjects")
                dgsubjects.DataSource = ds.Tables("semsubjects")
                conn.Close()

                dgsubjects.Columns(0).Visible = False
                dgsubjects.Columns(1).Width = 100
                dgsubjects.Columns(1).HeaderText = "SUBJECT CODE"
                dgsubjects.Columns(2).Width = 200
                dgsubjects.Columns(2).HeaderText = "DESCRIPTION"
                dgsubjects.Columns(3).HeaderText = "SECTION"
                dgsubjects.Columns(4).HeaderText = "CLASS SCHEDULE"
                dgsubjects.Columns(4).Width = 200
                dgsubjects.Columns(5).HeaderText = "ROOM"
                dgsubjects.Columns(6).Visible = False
                dgsubjects.Columns(7).Visible = False
                dgsubjects.Columns(8).Visible = False
                dgsubjects.Columns(9).Visible = False
                dgsubjects.Columns(10).HeaderText = "DEPARTMENT"
                dgsubjects.Columns(11).HeaderText = "YEAR LEVEL"
                dgsubjects.Columns(12).Visible = False
                dgsubjects.Columns(13).Visible = False
                dgsubjects.Columns(14).HeaderText = "TEACHER"
                dgsubjects.Columns(14).Width = 200
                dgsubjects.Columns(15).Visible = False
            Else

                str = "SELECT subjectid, SubjectCode, Description, Section, SchedTime, Room, Time1, AM1, Time2, AM2, Course, YearLevel, SubjectStatus, ff.IDNumber, concat(FirstName,' ',MiddleName,' ',LastName) as Teacher, Days1 FROM semsubjects s join staff ff on s.IDNumber=ff.IDNumber where Description like '%" & txtSearch.Text & "%' and SY='" & frmAdmin.stSY.Text & "' and Semester='" & frmAdmin.stSemester.Text & "'"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim ds As New Data.DataSet
                mysDA.Fill(ds, "semsubjects")
                dgsubjects.DataSource = ds.Tables("semsubjects")
                conn.Close()

                dgsubjects.Columns(0).Visible = False
                dgsubjects.Columns(1).Width = 100
                dgsubjects.Columns(1).HeaderText = "SUBJECT CODE"
                dgsubjects.Columns(2).Width = 200
                dgsubjects.Columns(2).HeaderText = "DESCRIPTION"
                dgsubjects.Columns(3).HeaderText = "SECTION"
                dgsubjects.Columns(4).HeaderText = "CLASS SCHEDULE"
                dgsubjects.Columns(4).Width = 200
                dgsubjects.Columns(5).HeaderText = "ROOM"
                dgsubjects.Columns(6).Visible = False
                dgsubjects.Columns(7).Visible = False
                dgsubjects.Columns(8).Visible = False
                dgsubjects.Columns(9).Visible = False
                dgsubjects.Columns(10).HeaderText = "DEPARTMENT"
                dgsubjects.Columns(11).HeaderText = "YEAR LEVEL"
                dgsubjects.Columns(12).Visible = False
                dgsubjects.Columns(13).Visible = False
                dgsubjects.Columns(14).HeaderText = "TEACHER"
                dgsubjects.Columns(14).Width = 200
                dgsubjects.Columns(15).Visible = False
            End If




        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            If cboCourse.Text = "" Then
                MsgBox("Department is required!", MsgBoxStyle.Exclamation)
                cboCourse.Focus()
                Exit Sub
            End If

            If cboYearLevel.Text = "" Then
                MsgBox("Grade level is required!", MsgBoxStyle.Exclamation)
                cboYearLevel.Focus()
                Exit Sub
            End If

            str = "SELECT subjectid, SubjectCode, Description, Section, SchedTime, Room, Time1, AM1, Time2, AM2, Course, YearLevel, SubjectStatus, ff.IDNumber, concat(FirstName,' ',MiddleName,' ',LastName) as Teacher, Days1 FROM semsubjects s join staff ff on s.IDNumber=ff.IDNumber where Semester ='" & frmAdmin.stSemester.Text & "' and SY='" & frmAdmin.stSY.Text & "' and Course='" & cboCourse.Text & "' and YearLevel='" & cboYearLevel.Text & "'  order by SubjectCode"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim ds As New Data.DataSet
            mysDA.Fill(ds, "semsubjects")
            dgsubjects.DataSource = ds.Tables("semsubjects")
            conn.Close()

            dgsubjects.Columns(0).Visible = False
            dgsubjects.Columns(1).Width = 100
            dgsubjects.Columns(1).HeaderText = "SUBJECT CODE"
            dgsubjects.Columns(2).Width = 200
            dgsubjects.Columns(2).HeaderText = "DESCRIPTION"
            dgsubjects.Columns(3).HeaderText = "SECTION"
            dgsubjects.Columns(4).HeaderText = "CLASS SCHEDULE"
            dgsubjects.Columns(4).Width = 200
            dgsubjects.Columns(5).HeaderText = "ROOM"
            dgsubjects.Columns(6).Visible = False
            dgsubjects.Columns(7).Visible = False
            dgsubjects.Columns(8).Visible = False
            dgsubjects.Columns(9).Visible = False
            dgsubjects.Columns(10).HeaderText = "DEPARTMENT"
            dgsubjects.Columns(11).HeaderText = "YEAR LEVEL"
            dgsubjects.Columns(12).Visible = False
            dgsubjects.Columns(13).Visible = False
            dgsubjects.Columns(14).HeaderText = "TEACHER"
            dgsubjects.Columns(14).Width = 200
            dgsubjects.Columns(15).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmAddSection.lblYearLevel.Text = cboYearLevel.Text
        frmAddSection.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cboCourse.Text = "" Then
            MsgBox("Department is required before selecting subjects!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If cboYearLevel.Text = "" Then
            MsgBox("Grade level is required before selecting subjects!|", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        'Formload()
        frmSearchSubjects.ShowDialog()
        frmSearchSubjects.txtsearch.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmAddRooms.ShowDialog()
    End Sub

    Private Sub btnSearchInstructor_Click(sender As Object, e As EventArgs) Handles btnSearchInstructor.Click
        frmSearchPersonnel.ShowDialog()
    End Sub
    Public Sub GetSchedule()
        txtTime.Text = cboTime1.Text + cboAM1.Text + "-" + cboTime2.Text + cboAM2.Text + " " + txtDaysLec.Text
      
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If btnSave.Text = "SAVE" Then
                GetSchedule()

                If cboCourse.Text = "" Then
                    MsgBox("Course is required!", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If

                If cboYearLevel.Text = "" Then
                    MsgBox("Grade level is required!", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If

                If txtSubjectCode.Text = "" Then
                    MsgBox("Subject Code is required!", MsgBoxStyle.Exclamation)
                    txtSubjectCode.Focus()
                    Exit Sub
                End If

                If cboSection.Text = "" Then
                    MsgBox("Section is required!", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If

                If txtInstructor.Text = "" Then
                    MsgBox("Teacher's ID is required!", MsgBoxStyle.Exclamation)
                    txtInstructor.Focus()
                    Exit Sub
                End If

                'check existing subjects
                str = "select * from semsubjects where SubjectCode='" & txtSubjectCode.Text & "' and Description='" & txtSubjectDescription.Text & "' and Section='" & cboSection.Text & "' and Course='" & cboCourse.Text & "' and YearLevel='" & cboYearLevel.Text & "' and SY='" & frmAdmin.stSY.Text & "' and Semester='" & frmAdmin.stSemester.Text & "'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New Data.DataSet
                mysda.Fill(ds, "semsubjects")
                conn.Close()
                If ds.Tables("semsubjects").Rows.Count = 1 Then
                    MsgBox("Selected subject already exist for the current semester!", MsgBoxStyle.Exclamation)
                    conn.Close()
                    Exit Sub
                    conn.Close()
                End If


                Dim subject As String
                subject = txtSubjectDescription.Text.Replace("'", "''")

                str = "insert into semsubjects values('0','" & txtSubjectCode.Text & "','" & subject & "','" & cboSection.Text & "','" & txtTime.Text & "','" & txtRoom.Text & "','" & txtInstructor.Text & "','" & frmAdmin.stSY.Text & "','" & frmAdmin.stSemester.Text & "','" & cboTime1.Text & "','" & cboAM1.Text & "','" & cboTime2.Text & "','" & cboAM2.Text & "','" & txtDaysLec.Text & "','" & cboCourse.Text & "','" & cboYearLevel.Text & "','Open','" & frmAdmin.lblSettingsID.Text & "')"
                conn.Open()
                Dim mysC As New MySqlCommand(str, conn)
                mysC.ExecuteNonQuery()
                MsgBox("Data successfully added!", MsgBoxStyle.Information)
                conn.Close()

                Formload()
                loadSubjects()

            Else
                GetSchedule()
                If txtSubjectCode.Text = "" Then
                    MsgBox("Cannot find any data to update!", MsgBoxStyle.Information)
                    Exit Sub
                End If

                str = "update semsubjects set SubjectCode='" & txtSubjectCode.Text & "',Description='" & txtSubjectDescription.Text & "',Section='" & cboSection.Text & "',SchedTime='" & txtTime.Text & "',Room='" & txtRoom.Text & "',IDNumber='" & txtInstructor.Text & "',Time1='" & cboTime1.Text & "',AM1='" & cboAM1.Text & "',Time2='" & cboTime2.Text & "',AM2='" & cboAM2.Text & "',Days1='" & txtDaysLec.Text & "',Course='" & cboCourse.Text & "',YearLevel='" & cboYearLevel.Text & "' where subjectid='" & lblID.Text & "'"
                conn.Open()
                Dim mysC As New MySqlCommand(str, conn)
                mysC.ExecuteNonQuery()
                conn.Close()

                'update CoR
                str = "update registration set Section='" & cboSection.Text & "',SchedTime='" & txtTime.Text & "',Room='" & txtRoom.Text & "',Instructor='" & txtInstructorName.Text & "' where SubjectCode='" & txtSubjectCode.Text & "' and Description='" & txtSubjectDescription.Text & "' and Section='" & cboSection.Text & "' and Sem='" & frmAdmin.stSemester.Text & "' and SY='" & frmAdmin.stSY.Text & "'"
                conn.Open()
                Dim mysC1 As New MySqlCommand(str, conn)
                mysC1.ExecuteNonQuery()
                conn.Close()

                'update CoR
                str = "update grades set Instructor='" & txtInstructorName.Text & "' where SubjectCode='" & txtSubjectCode.Text & "' and Description='" & txtSubjectDescription.Text & "' and Section='" & cboSection.Text & "' and Sem='" & frmAdmin.stSemester.Text & "' and SY='" & frmAdmin.stSY.Text & "'"
                conn.Open()
                Dim mysC2 As New MySqlCommand(str, conn)
                mysC2.ExecuteNonQuery()
                conn.Close()

                MsgBox("Data successfully updated!", MsgBoxStyle.Information)
                Formload()
                loadSubjects()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub dgsubjects_DoubleClick(sender As Object, e As EventArgs) Handles dgsubjects.DoubleClick
        Try
            Dim dclick As Integer
            dclick = dgsubjects.CurrentRow.Index
            lblID.Text = dgsubjects.Item(0, dclick).Value
            txtSubjectCode.Text = dgsubjects.Item(1, dclick).Value
            txtSubjectDescription.Text = dgsubjects.Item(2, dclick).Value
            cboSection.Text = dgsubjects.Item(3, dclick).Value
            txtRoom.Text = dgsubjects.Item(5, dclick).Value
            cboTime1.Text = dgsubjects.Item(6, dclick).Value
            cboAM1.Text = dgsubjects.Item(7, dclick).Value
            cboTime2.Text = dgsubjects.Item(8, dclick).Value
            cboAM2.Text = dgsubjects.Item(9, dclick).Value
            cboCourse.Text = dgsubjects.Item(10, dclick).Value
            cboYearLevel.Text = dgsubjects.Item(11, dclick).Value
            txtInstructor.Text = dgsubjects.Item(13, dclick).Value
            txtInstructorName.Text = dgsubjects.Item(14, dclick).Value
            txtDaysLec.Text = dgsubjects.Item(15, dclick).Value

            btnSave.Text = "UPDATE"
            btnDelete.Visible = True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try

            If (MsgBox("Are you sure you want to delete this subject?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from semsubjects where subjectid='" & lblID.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                MsgBox("Selected subject has been deleted!", MsgBoxStyle.Information)
                conn.Close()
                Formload()

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class