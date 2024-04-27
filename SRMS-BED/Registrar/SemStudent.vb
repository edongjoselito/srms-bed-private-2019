Imports MySql.Data.MySqlClient
Public Class frmSemStudent
    Dim str As String
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmSemStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formLoad()

    End Sub
    Public Sub formLoad()
        getScholarship()

        getCourse()
        getCourseMajor()
        getSection()
        schoolInfo()


        cboScholarship.ResetText()
        cboCourse.ResetText()
        cboYear.ResetText()
        cboSection.ResetText()

        btnSave.Text = "SAVE"
        btnDelete.Visible = False

        btnAccecelrated.Enabled = False
        btnDropped.Enabled = False
        btnTransferredOut.Enabled = False

        mskStudentNumber.Clear()
        txtFname.Clear()
        txtMName.Clear()
        txtLastName.Clear()
        cboYear.ResetText()

        cboScholarship.ResetText()
        mskFrom.Clear()
        mskTo.Clear()
        mskAssessmentDate.Clear()
        cboAssessmentResult.ResetText()
        cboAccountStatus.ResetText()
        cboStudeStatus.ResetText()
        cboYearStat.ResetText()
        cboTrack.ResetText()
        cboBalikAral.ResetText()
        cboIP.ResetText()
        cbo4Ps.ResetText()
        cboRepeater.ResetText()
        cboTransferee.ResetText()
        lblAdviser.Clear()
        cboYear.ResetText()
        cboStatus.ResetText()
        cboStudeStatus.ResetText()

        mskStudentNumber.Focus()


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
    Public Sub getCourse()
        Try
            If frmRegistrar.stSemester.Text = "First Semester" Or frmRegistrar.stSemester.Text = "Second Semester" Then
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
            cboYear.ValueMember = "course_table"
            cboYear.DisplayMember = "Major"
            cboYear.DataSource = ds.Tables("course_table")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Public Sub getSection()
        Try
            str = "select * from sections where YearLevel='" & cboYear.Text & "' group by Section order by Section"
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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        frmAddScholarship.ShowDialog()
    End Sub

    Private Sub cboCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCourse.SelectedIndexChanged
        getCourseMajor()
        getTrack()
        getAdviser()
    End Sub

    Public Sub getQualification()
        Try

            str = "select * from track_strand where track='" & cboTrack.Text & "' order by strand"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New Data.DataSet
            mysda.Fill(ds, "track_strand")
            conn.Close()

            cboQualification.ValueMember = "strand"
            cboQualification.DisplayMember = "strand"
            cboQualification.DataSource = ds.Tables("track_strand")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try

    End Sub
    Public Sub getTrack()
        Try
            str = "select * from track_strand group by track order by track"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New Data.DataSet
            mysda.Fill(ds, "track_strand")
            conn.Close()

            cboTrack.ValueMember = "track"
            cboTrack.DisplayMember = "track"
            cboTrack.DataSource = ds.Tables("track_strand")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Public Sub getAdviser()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select sectionID, concat(FirstName,' ',MiddleName,' ',LastName) as Adviser, s.IDNumber from sections s join staff st on s.IDNumber=st.IDNumber where sectionID='" & lblAdviserID.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lblAdviser.Text = dtReader.Item(1)
                lblIDNumber.Text = dtReader.Item(2)
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub cboTrack_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTrack.SelectedIndexChanged
        getQualification()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If cboYear.Text = "" Then
            MsgBox("Please select Year Level", MsgBoxStyle.Exclamation)
            Exit Sub

        Else
            frmAddSection.lblCourse.Text = cboCourse.Text
            frmAddSection.lblYearLevel.Text = cboYear.Text
            frmAddSection.ShowDialog()
        End If
    End Sub

    Private Sub tsNew_Click(sender As Object, e As EventArgs) Handles tsNew.Click
        frmCompleteList.lblSource.Text = "Enrollment Form"

        frmCompleteList.ShowDialog()
    End Sub

    Private Sub cboYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYear.SelectedIndexChanged
        getSection()
        getAdviser()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If btnSave.Text = "SAVE" Then
                If mskStudentNumber.Text = "" Then
                    MsgBox("Student number is required!", MsgBoxStyle.Exclamation)
                    mskStudentNumber.Focus()
                    Exit Sub
                End If

                If cboCourse.Text = "" Then
                    MsgBox("Course is required!", MsgBoxStyle.Exclamation)
                    cboCourse.Focus()
                    Exit Sub
                End If

                If cboSection.Text = "" Then
                    MsgBox("Section is required!", MsgBoxStyle.Exclamation)
                    cboSection.Focus()
                    Exit Sub
                End If

                If cboStudeStatus.Text = "" Then
                    MsgBox("Student Status is required!", MsgBoxStyle.Exclamation)
                    cboStudeStatus.Focus()
                    Exit Sub
                End If

                str = "select * from semesterstude where StudentNumber='" & mskStudentNumber.Text & "' and Semester='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New Data.DataSet
                mysda.Fill(ds, "semesterstude")
                conn.Close()

                If ds.Tables("semesterstude").Rows.Count = 1 Then
                    MsgBox("Student Number already exist!", MsgBoxStyle.Exclamation)
                    conn.Close()
                    mskStudentNumber.Focus()
                    Exit Sub
                End If

                str = "insert into semesterstude values('0','" & mskStudentNumber.Text & "','" & cboCourse.Text & "','" & cboYear.Text & "','" & cboStatus.Text & "','" & frmRegistrar.stSemester.Text & "','" & frmRegistrar.stSY.Text & "','" & cboSection.Text & "','" & cboStudeStatus.Text & "','" & cboScholarship.Text & "','" & cboYearStat.Text & "','" & cboMajor.Text & "','" & cboTrack.Text & "','" & cboQualification.Text & "','" & cboBalikAral.Text & "','" & cboIP.Text & "','" & cbo4Ps.Text & "','" & cboRepeater.Text & "','" & cboTransferee.Text & "','" & Convert.ToDateTime(frmRegistrar.stDate.Text).ToString("yyyy-MM-dd") & "','" & lblAdviser.Text & "','" & lblSettingsID.Text & "','" & lblAdviserID.Text & "','" & lblIDNumber.Text & "')"
                conn.Open()
                Dim mysC As New MySqlCommand(str, conn)
                mysC.ExecuteNonQuery()
                conn.Close()

                'Audit Trail
                str = "insert into atrail values('0','Enrolled a Student','" & Convert.ToDateTime(frmRegistrar.stDate.Text).ToString("yyyy-MM-dd") & "','" & frmRegistrar.stTime.Text & "','" & frmRegistrar.stUser.Text & "','" & mskStudentNumber.Text & "')"
                conn.Open()
                Dim mysc1 As New MySqlCommand(str, conn)
                mysc1.ExecuteNonQuery()
                conn.Close()


                MsgBox("Data successfully saved!", MsgBoxStyle.Information)

                formLoad()

                'Update Enrollment
            Else

                str = "update semesterstude set Course='" & cboCourse.Text & "',YearLevel='" & cboYear.Text & "',Status='" & cboStatus.Text & "',Section='" & cboSection.Text & "',StudeStatus='" & cboStudeStatus.Text & "',Scholarship='" & cboScholarship.Text & "',YearLevelStat='" & cboYearStat.Text & "',Major='" & cboMajor.Text & "',Track='" & cboTrack.Text & "',Qualification='" & cboQualification.Text & "',BalikAral='" & cboBalikAral.Text & "',IP='" & cboIP.Text & "',FourPs='" & cbo4Ps.Text & "',Repeater='" & cboRepeater.Text & "',Transferee='" & cboTransferee.Text & "',sectionID='" & lblAdviserID.Text & "',Adviser='" & lblAdviser.Text & "',IDNumber='" & lblIDNumber.Text & "' where semstudentid='" & lblID.Text & "'"
                conn.Open()
                Dim mysC As New MySqlCommand(str, conn)
                mysC.ExecuteNonQuery()
                conn.Close()



                'update course in student's account
                str = "update studeaccount set Course='" & cboCourse.Text & "',YearLevel='" & cboYear.Text & "' where StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "'"
                conn.Open()
                Dim mysC3 As New MySqlCommand(str, conn)
                mysC3.ExecuteNonQuery()
                conn.Close()

                'update grades
                str = "update grades set YearLevel='" & cboYear.Text & "',track='" & cboTrack.Text & "',strand='" & cboQualification.Text & "',adviser='" & lblAdviser.Text & "' where StudentNumber='" & mskStudentNumber.Text & "' and SY='" & frmRegistrar.stSY.Text & "'"
                conn.Open()
                Dim mysC6 As New MySqlCommand(str, conn)
                mysC6.ExecuteNonQuery()
                conn.Close()


                'Audit Trail
                str = "insert into atrail values('0','Update Student Enrollment','" & Convert.ToDateTime(frmRegistrar.stDate.Text).ToString("yyyy-MM-dd") & "','" & frmRegistrar.stTime.Text & "','" & frmRegistrar.stUser.Text & "','" & mskStudentNumber.Text & "')"
                conn.Open()
                Dim mysc1 As New MySqlCommand(str, conn)
                mysc1.ExecuteNonQuery()
                conn.Close()

                MsgBox("Data successfully updated!", MsgBoxStyle.Information)

                formLoad()


            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        btnSave.PerformClick()
    End Sub

    Private Sub ReloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadToolStripMenuItem.Click
        formLoad()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        tsNew.PerformClick()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        frmSearchEnrollees.ShowDialog()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                'delete from enrollment
                str = "delete from semesterstude where semstudentid='" & lblID.Text & "'"
                conn.Open()
                Dim mysC As New MySqlCommand(str, conn)
                mysC.ExecuteNonQuery()
                conn.Close()

                'delete from registration
                str = "delete from registration where StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "'"
                conn.Open()
                Dim mysC1 As New MySqlCommand(str, conn)
                mysC1.ExecuteNonQuery()
                conn.Close()

                'delete from stude account
                str = "delete from studeaccount where StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "'"
                conn.Open()
                Dim mysC2 As New MySqlCommand(str, conn)
                mysC2.ExecuteNonQuery()
                MsgBox("Data successfully deleted!", MsgBoxStyle.Information)
                conn.Close()


                'Audit Trail
                str = "insert into atrail values('0','Delete Student from Enrollment','" & Convert.ToDateTime(frmRegistrar.stDate.Text).ToString("yyyy-MM-dd") & "','" & frmRegistrar.stTime.Text & "','" & frmRegistrar.stUser.Text & "','" & mskStudentNumber.Text & "')"
                conn.Open()
                Dim mysc3 As New MySqlCommand(str, conn)
                mysc3.ExecuteNonQuery()
                conn.Close()

                formLoad()

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub cboSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSection.SelectedIndexChanged
        sectionID()
        getAdviser()
    End Sub

    Public Sub sectionID()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select sectionID, concat(FirstName,' ',MiddleName,' ',LastName) as Adviser from sections s join staff st on s.IDNumber=st.IDNumber where YearLevel='" & cboYear.Text & "' and Section='" & cboSection.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lblAdviserID.Text = dtReader.Item(0)
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class