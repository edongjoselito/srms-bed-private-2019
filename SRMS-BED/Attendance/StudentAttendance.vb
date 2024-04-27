Imports MySql.Data.MySqlClient
Public Class frmStudentAttendance
    Dim str As String
    Public Sub getYearLevel()
        Try
            str = "select * from course_table where CourseDescription='" & cboDepartment.Text & "' order by Major"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
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
    Public Sub getCourse()
        Try
            If frmRegistrar.stSemester.Text = "First Semester" Or frmRegistrar.stSemester.Text = "Second Semester" Then
                str = "select * from course_table where CourseDescription='Senior High School' group by CourseDescription order by CourseDescription"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "course_table")
                conn.Close()

                cboDepartment.ValueMember = "course_table"
                cboDepartment.DisplayMember = "CourseDescription"
                cboDepartment.DataSource = ds.Tables("course_table")
                conn.Close()

            Else
                str = "select * from course_table where CourseDescription!='Senior High School' group by CourseDescription order by CourseDescription"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "course_table")
                conn.Close()

                cboDepartment.ValueMember = "course_table"
                cboDepartment.DisplayMember = "CourseDescription"
                cboDepartment.DataSource = ds.Tables("course_table")
                conn.Close()
            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub getSection()
        Try
            str = "select * from sections where YearLevel='" & cboYear.Text & "' group by Section order by Section" 'where Course='" & cboCourse.Text & "' and Major='" & cboYearLevel.Text & "' group by Section order by Section"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
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


    Private Sub frmStudentAttendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim monthNo As String
        monthNo = Date.Now.ToString("MM")
        cboMonth.SelectedIndex = Val(monthNo) - 1
        getCourse()
        getYearLevel()
        getSection()
    End Sub

    Private Sub cboDepartment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDepartment.SelectedIndexChanged
        getYearLevel()
        sectionID()
        getAdviser()

    End Sub
    Public Sub sectionID()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select sectionID, concat(FirstName,' ',MiddleName,' ',LastName) as Adviser from sections s join staff f on s.IDNumber=f.IDNumber where YearLevel='" & cboYear.Text & "' and Section='" & cboSection.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lblAdviserID.Text = dtReader.Item(0)
                conn.Close()
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub getAdviser()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select sectionID, concat(FirstName,' ',MiddleName,' ',LastName) as Adviser from sections s join staff f on s.IDNumber=f.IDNumber where sectionID='" & lblAdviserID.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lblAdviser.Text = dtReader.Item(1)
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub cboYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboYear.SelectedIndexChanged
        getSection()
        sectionID()
        getAdviser()
        LoadStudents()
    End Sub

    Private Sub cboSection_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSection.SelectedIndexChanged
        sectionID()
        getAdviser()
        LoadStudents()
    End Sub
    Public Sub LoadStudents()
        Try
            conn.Close()
            str = "SELECT StudentNumber, fName, mName, lName, janPres, janTardy, febPres, febTardy, marPres, marTardy, aprPres, aprTardy, mayPres, mayTardy, junPres, junTardy, julPres, julTardy, augPres, augTardy, sepPres, sepTardy, octPres, octTardy, novPres, novTardy, decPres, decTardy, YearLevel, studeSection, SY FROM stude_attendance where SY ='" & frmRegistrar.stSY.Text & "' and YearLevel='" & cboYear.Text & "' and studeSection='" & cboSection.Text & "' "
            conn.Open()
            Dim mysC As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysC.Fill(ds, "stude_attendance")

            dg1.Columns.Clear()
            If ds.Tables("stude_attendance").Rows.Count >= 1 Then
                dg1.DataSource = ds.Tables("stude_attendances")
                conn.Close()

                If cboMonth.Text = "JANUARY" Then
                    str = "SELECT StudentNumber, concat(LName,', ',FName,' ',MName) as Fullname, fName, mName, lName, janPres, janTardy FROM stude_attendance where SY ='" & frmRegistrar.stSY.Text & "' and YearLevel='" & cboYear.Text & "' and studeSection='" & cboSection.Text & "' order by lName"
                    conn.Open()
                    Dim mysda As New MySqlDataAdapter(str, conn)
                    Dim ds1 As New DataSet
                    mysda.Fill(ds1, "stude_attendances")
                    dg1.DataSource = ds1.Tables("stude_attendances")
                    conn.Close()

                    dg1.Columns(0).ReadOnly = True
                    dg1.Columns(0).HeaderText = "Student Number"
                    dg1.Columns(0).Width = 130
                    dg1.Columns(1).Width = 315
                    dg1.Columns(1).HeaderText = "Student Name"
                    dg1.Columns(1).ReadOnly = True
                    dg1.Columns(2).Visible = False
                    dg1.Columns(3).Visible = False
                    dg1.Columns(4).Visible = False
                    dg1.Columns(5).HeaderText = "Days Present"
                    dg1.Columns(6).HeaderText = "Times Tardy"
                    conn.Close()
                ElseIf cboMonth.Text = "FEBRUARY" Then

                    str = "SELECT StudentNumber, concat(LName,', ',FName,' ',MName) as Fullname, fName, mName, lName, febPres, febTardy FROM stude_attendance where SY ='" & frmRegistrar.stSY.Text & "' and YearLevel='" & cboYear.Text & "' and studeSection='" & cboSection.Text & "' order by lName"
                    conn.Open()
                    Dim mysda As New MySqlDataAdapter(str, conn)
                    Dim ds1 As New DataSet
                    mysda.Fill(ds1, "stude_attendances")
                    dg1.DataSource = ds1.Tables("stude_attendances")
                    conn.Close()


                    dg1.Columns(0).ReadOnly = True
                    dg1.Columns(0).HeaderText = "Student Number"
                    dg1.Columns(0).Width = 130
                    dg1.Columns(1).Width = 315
                    dg1.Columns(1).HeaderText = "Student Name"
                    dg1.Columns(1).ReadOnly = True
                    dg1.Columns(2).Visible = False
                    dg1.Columns(3).Visible = False
                    dg1.Columns(4).Visible = False
                    dg1.Columns(5).HeaderText = "Days Present"
                    dg1.Columns(6).HeaderText = "Times Tardy"
                    conn.Close()
                ElseIf cboMonth.Text = "MARCH" Then

                    str = "SELECT StudentNumber, concat(LName,', ',FName,' ',MName) as Fullname, fName, mName, lName, marPres, marTardy FROM stude_attendance where SY ='" & frmRegistrar.stSY.Text & "' and YearLevel='" & cboYear.Text & "' and studeSection='" & cboSection.Text & "' order by lName"
                    conn.Open()
                    Dim mysda As New MySqlDataAdapter(str, conn)
                    Dim ds1 As New DataSet
                    mysda.Fill(ds1, "stude_attendances")
                    dg1.DataSource = ds1.Tables("stude_attendances")
                    conn.Close()

                    dg1.Columns(0).ReadOnly = True
                    dg1.Columns(0).HeaderText = "Student Number"
                    dg1.Columns(0).Width = 130
                    dg1.Columns(1).Width = 315
                    dg1.Columns(1).HeaderText = "Student Name"
                    dg1.Columns(1).ReadOnly = True
                    dg1.Columns(2).Visible = False
                    dg1.Columns(3).Visible = False
                    dg1.Columns(4).Visible = False
                    dg1.Columns(5).HeaderText = "Days Present"
                    dg1.Columns(6).HeaderText = "Times Tardy"
                    conn.Close()

                ElseIf cboMonth.Text = "APRIL" Then

                    str = "SELECT StudentNumber, concat(LName,', ',FName,' ',MName) as Fullname, fName, mName, lName, aprPres, aprTardy FROM stude_attendance where SY ='" & frmRegistrar.stSY.Text & "' and YearLevel='" & cboYear.Text & "' and studeSection='" & cboSection.Text & "' order by lName"
                    conn.Open()
                    Dim mysda As New MySqlDataAdapter(str, conn)
                    Dim ds1 As New DataSet
                    mysda.Fill(ds1, "stude_attendances")
                    dg1.DataSource = ds1.Tables("stude_attendances")
                    conn.Close()


                    dg1.Columns(0).ReadOnly = True
                    dg1.Columns(0).HeaderText = "Student Number"
                    dg1.Columns(0).Width = 130
                    dg1.Columns(1).Width = 315
                    dg1.Columns(1).HeaderText = "Student Name"
                    dg1.Columns(1).ReadOnly = True
                    dg1.Columns(2).Visible = False
                    dg1.Columns(3).Visible = False
                    dg1.Columns(4).Visible = False
                    dg1.Columns(5).HeaderText = "Days Present"
                    dg1.Columns(6).HeaderText = "Times Tardy"
                    conn.Close()
                ElseIf cboMonth.Text = "MAY" Then

                    str = "SELECT StudentNumber, concat(LName,', ',FName,' ',MName) as Fullname, fName, mName, lName, mayPres, mayTardy FROM stude_attendance where SY ='" & frmRegistrar.stSY.Text & "' and YearLevel='" & cboYear.Text & "' and studeSection='" & cboSection.Text & "' order by lName"
                    conn.Open()
                    Dim mysda As New MySqlDataAdapter(str, conn)
                    Dim ds1 As New DataSet
                    mysda.Fill(ds1, "stude_attendances")
                    dg1.DataSource = ds1.Tables("stude_attendances")
                    conn.Close()

                    dg1.Columns(0).ReadOnly = True
                    dg1.Columns(0).HeaderText = "Student Number"
                    dg1.Columns(0).Width = 130
                    dg1.Columns(1).Width = 315
                    dg1.Columns(1).HeaderText = "Student Name"
                    dg1.Columns(1).ReadOnly = True
                    dg1.Columns(2).Visible = False
                    dg1.Columns(3).Visible = False
                    dg1.Columns(4).Visible = False
                    dg1.Columns(5).HeaderText = "Days Present"
                    dg1.Columns(6).HeaderText = "Times Tardy"
                    conn.Close()
                ElseIf cboMonth.Text = "JUNE" Then
                    str = "SELECT StudentNumber, concat(LName,', ',FName,' ',MName) as Fullname, fName, mName, lName, junPres, junTardy FROM stude_attendance where SY ='" & frmRegistrar.stSY.Text & "' and YearLevel='" & cboYear.Text & "' and studeSection='" & cboSection.Text & "' order by lName"
                    conn.Open()
                    Dim mysda As New MySqlDataAdapter(str, conn)
                    Dim ds1 As New DataSet
                    mysda.Fill(ds1, "stude_attendances")
                    dg1.DataSource = ds1.Tables("stude_attendances")
                    conn.Close()

                    dg1.Columns(0).ReadOnly = True
                    dg1.Columns(0).HeaderText = "Student Number"
                    dg1.Columns(0).Width = 130
                    dg1.Columns(1).Width = 315
                    dg1.Columns(1).HeaderText = "Student Name"
                    dg1.Columns(1).ReadOnly = True
                    dg1.Columns(2).Visible = False
                    dg1.Columns(3).Visible = False
                    dg1.Columns(4).Visible = False
                    dg1.Columns(5).HeaderText = "Days Present"
                    dg1.Columns(6).HeaderText = "Times Tardy"
                    conn.Close()
                ElseIf cboMonth.Text = "JULY" Then
                    str = "SELECT StudentNumber, concat(LName,', ',FName,' ',MName) as Fullname, fName, mName, lName, julPres, julTardy FROM stude_attendance where SY ='" & frmRegistrar.stSY.Text & "' and YearLevel='" & cboYear.Text & "' and studeSection='" & cboSection.Text & "' order by lName"
                    conn.Open()
                    Dim mysda As New MySqlDataAdapter(str, conn)
                    Dim ds1 As New DataSet
                    mysda.Fill(ds1, "stude_attendances")
                    dg1.DataSource = ds1.Tables("stude_attendances")
                    conn.Close()

                    dg1.Columns(0).ReadOnly = True
                    dg1.Columns(0).HeaderText = "Student Number"
                    dg1.Columns(0).Width = 130
                    dg1.Columns(1).Width = 315
                    dg1.Columns(1).HeaderText = "Student Name"
                    dg1.Columns(1).ReadOnly = True
                    dg1.Columns(2).Visible = False
                    dg1.Columns(3).Visible = False
                    dg1.Columns(4).Visible = False
                    dg1.Columns(5).HeaderText = "Days Present"
                    dg1.Columns(6).HeaderText = "Times Tardy"
                    conn.Close()
                ElseIf cboMonth.Text = "AUGUST" Then
                    str = "SELECT StudentNumber, concat(LName,', ',FName,' ',MName) as Fullname, fName, mName, lName, augPres, augTardy FROM stude_attendance where SY ='" & frmRegistrar.stSY.Text & "' and YearLevel='" & cboYear.Text & "' and studeSection='" & cboSection.Text & "' order by lName"
                    conn.Open()
                    Dim mysda As New MySqlDataAdapter(str, conn)
                    Dim ds1 As New DataSet
                    mysda.Fill(ds1, "stude_attendances")
                    dg1.DataSource = ds1.Tables("stude_attendances")
                    conn.Close()

                    dg1.Columns(0).ReadOnly = True
                    dg1.Columns(0).HeaderText = "Student Number"
                    dg1.Columns(0).Width = 130
                    dg1.Columns(1).Width = 315
                    dg1.Columns(1).HeaderText = "Student Name"
                    dg1.Columns(1).ReadOnly = True
                    dg1.Columns(2).Visible = False
                    dg1.Columns(3).Visible = False
                    dg1.Columns(4).Visible = False
                    dg1.Columns(5).HeaderText = "Days Present"
                    dg1.Columns(6).HeaderText = "Times Tardy"
                    conn.Close()
                ElseIf cboMonth.Text = "SEPTEMBER" Then
                    str = "SELECT StudentNumber, concat(LName,', ',FName,' ',MName) as Fullname, fName, mName, lName, sepPres, sepTardy FROM stude_attendance where SY ='" & frmRegistrar.stSY.Text & "' and YearLevel='" & cboYear.Text & "' and studeSection='" & cboSection.Text & "' order by lName"
                    conn.Open()
                    Dim mysda As New MySqlDataAdapter(str, conn)
                    Dim ds1 As New DataSet
                    mysda.Fill(ds1, "stude_attendances")
                    dg1.DataSource = ds1.Tables("stude_attendances")
                    conn.Close()


                    dg1.Columns(0).ReadOnly = True
                    dg1.Columns(0).HeaderText = "Student Number"
                    dg1.Columns(0).Width = 130
                    dg1.Columns(1).Width = 315
                    dg1.Columns(1).HeaderText = "Student Name"
                    dg1.Columns(1).ReadOnly = True
                    dg1.Columns(2).Visible = False
                    dg1.Columns(3).Visible = False
                    dg1.Columns(4).Visible = False
                    dg1.Columns(5).HeaderText = "Days Present"
                    dg1.Columns(6).HeaderText = "Times Tardy"
                    conn.Close()
                ElseIf cboMonth.Text = "OCTOBER" Then
                    str = "SELECT StudentNumber, concat(LName,', ',FName,' ',MName) as Fullname, fName, mName, lName, octPres, octTardy FROM stude_attendance where SY ='" & frmRegistrar.stSY.Text & "' and YearLevel='" & cboYear.Text & "' and studeSection='" & cboSection.Text & "' order by lName"
                    conn.Open()
                    Dim mysda As New MySqlDataAdapter(str, conn)
                    Dim ds1 As New DataSet
                    mysda.Fill(ds1, "stude_attendances")
                    dg1.DataSource = ds1.Tables("stude_attendances")
                    conn.Close()

                    dg1.Columns(0).ReadOnly = True
                    dg1.Columns(0).HeaderText = "Student Number"
                    dg1.Columns(0).Width = 130
                    dg1.Columns(1).Width = 315
                    dg1.Columns(1).HeaderText = "Student Name"
                    dg1.Columns(1).ReadOnly = True
                    dg1.Columns(2).Visible = False
                    dg1.Columns(3).Visible = False
                    dg1.Columns(4).Visible = False
                    dg1.Columns(5).HeaderText = "Days Present"
                    dg1.Columns(6).HeaderText = "Times Tardy"
                    conn.Close()
                ElseIf cboMonth.Text = "NOVEMBER" Then
                    str = "SELECT StudentNumber, concat(LName,', ',FName,' ',MName) as Fullname, fName, mName, lName, novPres, novTardy FROM stude_attendance where SY ='" & frmRegistrar.stSY.Text & "' and YearLevel='" & cboYear.Text & "' and studeSection='" & cboSection.Text & "' order by lName"
                    conn.Open()
                    Dim mysda As New MySqlDataAdapter(str, conn)
                    Dim ds1 As New DataSet
                    mysda.Fill(ds1, "stude_attendances")
                    dg1.DataSource = ds1.Tables("stude_attendances")
                    conn.Close()

                    dg1.Columns(0).ReadOnly = True
                    dg1.Columns(0).HeaderText = "Student Number"
                    dg1.Columns(0).Width = 130
                    dg1.Columns(1).Width = 315
                    dg1.Columns(1).HeaderText = "Student Name"
                    dg1.Columns(1).ReadOnly = True
                    dg1.Columns(2).Visible = False
                    dg1.Columns(3).Visible = False
                    dg1.Columns(4).Visible = False
                    dg1.Columns(5).HeaderText = "Days Present"
                    dg1.Columns(6).HeaderText = "Times Tardy"
                    conn.Close()
                ElseIf cboMonth.Text = "DECEMBER" Then
                    str = "SELECT StudentNumber, concat(LName,', ',FName,' ',MName) as Fullname, fName, mName, lName, decPres, decTardy FROM stude_attendance where SY ='" & frmRegistrar.stSY.Text & "' and YearLevel='" & cboYear.Text & "' and studeSection='" & cboSection.Text & "' order by lName"
                    conn.Open()
                    Dim mysda As New MySqlDataAdapter(str, conn)
                    Dim ds1 As New DataSet
                    mysda.Fill(ds1, "stude_attendances")
                    dg1.DataSource = ds1.Tables("stude_attendances")
                    conn.Close()

                    dg1.Columns(0).ReadOnly = True
                    dg1.Columns(0).HeaderText = "Student Number"
                    dg1.Columns(0).Width = 130
                    dg1.Columns(1).Width = 315
                    dg1.Columns(1).HeaderText = "Student Name"
                    dg1.Columns(1).ReadOnly = True
                    dg1.Columns(2).Visible = False
                    dg1.Columns(3).Visible = False
                    dg1.Columns(4).Visible = False
                    dg1.Columns(5).HeaderText = "Days Present"
                    dg1.Columns(6).HeaderText = "Times Tardy"
                    conn.Close()
                End If

                conn.Close()

            Else
                ' kung wala pay attendance
                conn.Close()
                str = "Select p.StudentNumber, concat(LastName,', ',FirstName,' ',MiddleName) as Fullname, FirstName, MiddleName, LastName, '','' from semesterstude ss join studeprofile p on ss.StudentNumber=p.StudentNumber where  Status='Enrolled' and Semester='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "' and YearLevel='" & cboYear.Text & "' and Section='" & cboSection.Text & "' order by LastName"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(str, conn)
                Dim ds1 As New DataSet
                mysDA.Fill(ds1, "semesterstude, studeprofile")
                dg1.DataSource = ds1.Tables("semesterstude, studeprofile")

                dg1.Columns(0).ReadOnly = True
                dg1.Columns(0).HeaderText = "Student Number"
                dg1.Columns(0).Width = 130
                dg1.Columns(1).Width = 315
                dg1.Columns(1).HeaderText = "Student Name"
                dg1.Columns(1).ReadOnly = True
                dg1.Columns(2).Visible = False
                dg1.Columns(3).Visible = False
                dg1.Columns(4).Visible = False
                dg1.Columns(5).HeaderText = "Days Present"
                dg1.Columns(6).HeaderText = "Times Tardy"


                conn.Close()

            End If
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub cboMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMonth.SelectedIndexChanged
        LoadStudents()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try

            If cboMonth.Text = "" Then
                MsgBox("Please select month first before saving!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            str = "select StudentNumber from stude_attendance where SY ='" & frmRegistrar.stSY.Text & "' and YearLevel='" & cboYear.Text & "' and studeSection='" & cboSection.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "stude_attendance")
            If ds.Tables("stude_attendance").Rows.Count >= 1 Then
                'code kung nag exist
                For x As Integer = 0 To dg1.Rows.Count - 1
                    conn.Close()
                    If cboMonth.Text = "JANUARY" Then
                        str = "update stude_attendance set janPres='" & dg1.Item(5, x).Value & "',  janTardy='" & dg1.Item(6, x).Value & "' where StudentNumber='" & dg1.Item(0, x).Value & "' and SY ='" & frmRegistrar.stSY.Text & "' and YearLevel='" & cboYear.Text & "' and studeSection='" & cboSection.Text & "'"
                        conn.Open()
                        Dim mysC1 As New MySqlCommand(str, conn)
                        mysC1.ExecuteNonQuery()
                        conn.Close()
                    ElseIf cboMonth.Text = "FEBRUARY" Then

                        str = "update stude_attendance set febPres='" & dg1.Item(5, x).Value & "', febTardy='" & dg1.Item(6, x).Value & "' where StudentNumber='" & dg1.Item(0, x).Value & "' and SY ='" & frmRegistrar.stSY.Text & "' and YearLevel='" & cboYear.Text & "' and studeSection='" & cboSection.Text & "'"
                        conn.Open()
                        Dim mysC1 As New MySqlCommand(str, conn)
                        mysC1.ExecuteNonQuery()
                        conn.Close()

                    ElseIf cboMonth.Text = "MARCH" Then

                        str = "update stude_attendance set marPres='" & dg1.Item(5, x).Value & "', marTardy='" & dg1.Item(6, x).Value & "' where StudentNumber='" & dg1.Item(0, x).Value & "' and SY ='" & frmRegistrar.stSY.Text & "' and YearLevel='" & cboYear.Text & "' and studeSection='" & cboSection.Text & "'"
                        conn.Open()
                        Dim mysC1 As New MySqlCommand(str, conn)
                        mysC1.ExecuteNonQuery()
                        conn.Close()

                    ElseIf cboMonth.Text = "APRIL" Then

                        str = "update stude_attendance set aprPres='" & dg1.Item(5, x).Value & "', aprTardy='" & dg1.Item(6, x).Value & "' where StudentNumber='" & dg1.Item(0, x).Value & "' and SY ='" & frmRegistrar.stSY.Text & "' and YearLevel='" & cboYear.Text & "' and studeSection='" & cboSection.Text & "'"
                        conn.Open()
                        Dim mysC1 As New MySqlCommand(str, conn)
                        mysC1.ExecuteNonQuery()
                        conn.Close()
                    ElseIf cboMonth.Text = "MAY" Then

                        str = "update stude_attendance set mayPres='" & dg1.Item(5, x).Value & "', mayTardy='" & dg1.Item(6, x).Value & "' where StudentNumber='" & dg1.Item(0, x).Value & "' and SY ='" & frmRegistrar.stSY.Text & "' and YearLevel='" & cboYear.Text & "' and studeSection='" & cboSection.Text & "'"
                        conn.Open()
                        Dim mysC1 As New MySqlCommand(str, conn)
                        mysC1.ExecuteNonQuery()
                        conn.Close()
                    ElseIf cboMonth.Text = "JUNE" Then
                        str = "update stude_attendance set junPres='" & dg1.Item(5, x).Value & "', junTardy='" & dg1.Item(6, x).Value & "' where StudentNumber='" & dg1.Item(0, x).Value & "' and SY ='" & frmRegistrar.stSY.Text & "' and YearLevel='" & cboYear.Text & "' and studeSection='" & cboSection.Text & "'"
                        conn.Open()
                        Dim mysC1 As New MySqlCommand(str, conn)
                        mysC1.ExecuteNonQuery()
                        conn.Close()
                    ElseIf cboMonth.Text = "JULY" Then
                        str = "update stude_attendance set julPres='" & dg1.Item(5, x).Value & "',  julTardy='" & dg1.Item(6, x).Value & "' where StudentNumber='" & dg1.Item(0, x).Value & "' and SY ='" & frmRegistrar.stSY.Text & "' and YearLevel='" & cboYear.Text & "' and studeSection='" & cboSection.Text & "'"
                        conn.Open()
                        Dim mysC1 As New MySqlCommand(str, conn)
                        mysC1.ExecuteNonQuery()
                        conn.Close()
                    ElseIf cboMonth.Text = "AUGUST" Then
                        str = "update stude_attendance set augPres='" & dg1.Item(5, x).Value & "',  augTardy='" & dg1.Item(6, x).Value & "' where StudentNumber='" & dg1.Item(0, x).Value & "' and SY ='" & frmRegistrar.stSY.Text & "' and YearLevel='" & cboYear.Text & "' and studeSection='" & cboSection.Text & "'"
                        conn.Open()
                        Dim mysC1 As New MySqlCommand(str, conn)
                        mysC1.ExecuteNonQuery()
                        conn.Close()
                    ElseIf cboMonth.Text = "SEPTEMBER" Then
                        str = "update stude_attendance set sepPres='" & dg1.Item(5, x).Value & "',  sepTardy='" & dg1.Item(6, x).Value & "' where StudentNumber='" & dg1.Item(0, x).Value & "' and SY ='" & frmRegistrar.stSY.Text & "' and YearLevel='" & cboYear.Text & "' and studeSection='" & cboSection.Text & "'"
                        conn.Open()
                        Dim mysC1 As New MySqlCommand(str, conn)
                        mysC1.ExecuteNonQuery()
                        conn.Close()
                    ElseIf cboMonth.Text = "OCTOBER" Then
                        str = "update stude_attendance set octPres='" & dg1.Item(5, x).Value & "',  octTardy='" & dg1.Item(6, x).Value & "' where StudentNumber='" & dg1.Item(0, x).Value & "' and SY ='" & frmRegistrar.stSY.Text & "' and YearLevel='" & cboYear.Text & "' and studeSection='" & cboSection.Text & "'"
                        conn.Open()
                        Dim mysC1 As New MySqlCommand(str, conn)
                        mysC1.ExecuteNonQuery()
                        conn.Close()
                    ElseIf cboMonth.Text = "NOVEMBER" Then
                        str = "update stude_attendance set novPres='" & dg1.Item(5, x).Value & "', novTardy='" & dg1.Item(6, x).Value & "' where StudentNumber='" & dg1.Item(0, x).Value & "' and SY ='" & frmRegistrar.stSY.Text & "' and YearLevel='" & cboYear.Text & "' and studeSection='" & cboSection.Text & "'"
                        conn.Open()
                        Dim mysC1 As New MySqlCommand(str, conn)
                        mysC1.ExecuteNonQuery()
                        conn.Close()
                    ElseIf cboMonth.Text = "DECEMBER" Then
                        str = "update stude_attendance set decPres='" & dg1.Item(5, x).Value & "',  decTardy='" & dg1.Item(6, x).Value & "' where StudentNumber='" & dg1.Item(0, x).Value & "' and SY ='" & frmRegistrar.stSY.Text & "' and YearLevel='" & cboYear.Text & "' and studeSection='" & cboSection.Text & "'"
                        conn.Open()
                        Dim mysC1 As New MySqlCommand(str, conn)
                        mysC1.ExecuteNonQuery()
                        conn.Close()
                    End If
                    conn.Close()
                Next
                MsgBox("Student attendance successfully saved!", MsgBoxStyle.Information)
                conn.Close()
                LoadStudents()

                'kung wala nag exist
            Else
                For x As Integer = 0 To dg1.Rows.Count - 1
                    conn.Close()
                    If cboMonth.Text = "JANUARY" Then
                        str = "insert into stude_attendance values('0','" & dg1.Item(0, x).Value & "','" & dg1.Item(2, x).Value & "','" & dg1.Item(3, x).Value & "','" & dg1.Item(4, x).Value & "','" & dg1.Item(5, x).Value & "','" & dg1.Item(6, x).Value & "','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','" & cboYear.Text & "','" & cboSection.Text & "','" & frmRegistrar.stSY.Text & "')"
                        conn.Open()
                        Dim mysC2 As New MySqlCommand(str, conn)
                        mysC2.ExecuteNonQuery()
                        conn.Close()
                    ElseIf cboMonth.Text = "FEBRUARY" Then

                        str = "insert into stude_attendance values('0','" & dg1.Item(0, x).Value & "','" & dg1.Item(2, x).Value & "','" & dg1.Item(3, x).Value & "','" & dg1.Item(4, x).Value & "','0','0','" & dg1.Item(5, x).Value & "','" & dg1.Item(6, x).Value & "','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0''" & cboYear.Text & "','" & cboSection.Text & "','" & frmRegistrar.stSY.Text & "')"
                        conn.Open()
                        Dim mysC2 As New MySqlCommand(str, conn)
                        mysC2.ExecuteNonQuery()
                        conn.Close()

                    ElseIf cboMonth.Text = "MARCH" Then

                        str = "insert into stude_attendance values('0','" & dg1.Item(0, x).Value & "','" & dg1.Item(2, x).Value & "','" & dg1.Item(3, x).Value & "','" & dg1.Item(4, x).Value & "','0','0','0','0','" & dg1.Item(5, x).Value & "','" & dg1.Item(6, x).Value & "','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','" & cboYear.Text & "','" & cboSection.Text & "','" & frmRegistrar.stSY.Text & "')"
                        conn.Open()
                        Dim mysC2 As New MySqlCommand(str, conn)
                        mysC2.ExecuteNonQuery()
                        conn.Close()

                    ElseIf cboMonth.Text = "APRIL" Then

                        str = "insert into stude_attendance values('0','" & dg1.Item(0, x).Value & "','" & dg1.Item(2, x).Value & "','" & dg1.Item(3, x).Value & "','" & dg1.Item(4, x).Value & "','0','0','0','0','0','0','" & dg1.Item(5, x).Value & "','" & dg1.Item(6, x).Value & "','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','" & cboYear.Text & "','" & cboSection.Text & "','" & frmRegistrar.stSY.Text & "')"
                        conn.Open()
                        Dim mysC2 As New MySqlCommand(str, conn)
                        mysC2.ExecuteNonQuery()
                        conn.Close()
                    ElseIf cboMonth.Text = "MAY" Then
                        str = "insert into stude_attendance values('0','" & dg1.Item(0, x).Value & "','" & dg1.Item(2, x).Value & "','" & dg1.Item(3, x).Value & "','" & dg1.Item(4, x).Value & "','0','0','0','0','0','0','0','0','" & dg1.Item(5, x).Value & "','" & dg1.Item(6, x).Value & "','0','0','0','0','0','0','0','0','0','0','0','0','0','0','" & cboYear.Text & "','" & cboSection.Text & "','" & frmRegistrar.stSY.Text & "')"
                        conn.Open()
                        Dim mysC2 As New MySqlCommand(str, conn)
                        mysC2.ExecuteNonQuery()
                        conn.Close()
                    ElseIf cboMonth.Text = "JUNE" Then
                        str = "insert into stude_attendance values('0','" & dg1.Item(0, x).Value & "','" & dg1.Item(2, x).Value & "','" & dg1.Item(3, x).Value & "','" & dg1.Item(4, x).Value & "','0','0','0','0','0','0','0','0','0','0','" & dg1.Item(5, x).Value & "','" & dg1.Item(6, x).Value & "','0','0','0','0','0','0','0','0','0','0','0','0','" & cboYear.Text & "','" & cboSection.Text & "','" & frmRegistrar.stSY.Text & "')"
                        conn.Open()
                        Dim mysC2 As New MySqlCommand(str, conn)
                        mysC2.ExecuteNonQuery()
                        conn.Close()
                    ElseIf cboMonth.Text = "JULY" Then
                        str = "insert into stude_attendance values('0','" & dg1.Item(0, x).Value & "','" & dg1.Item(2, x).Value & "','" & dg1.Item(3, x).Value & "','" & dg1.Item(4, x).Value & "','0','0','0','0','0','0','0','0','0','0','0','0','" & dg1.Item(5, x).Value & "','" & dg1.Item(6, x).Value & "','0','0','0','0','0','0','0','0','0','0','" & cboYear.Text & "','" & cboSection.Text & "','" & frmRegistrar.stSY.Text & "')"
                        conn.Open()
                        Dim mysC2 As New MySqlCommand(str, conn)
                        mysC2.ExecuteNonQuery()
                        conn.Close()
                    ElseIf cboMonth.Text = "AUGUST" Then
                        str = "insert into stude_attendance values('0','" & dg1.Item(0, x).Value & "','" & dg1.Item(2, x).Value & "','" & dg1.Item(3, x).Value & "','" & dg1.Item(4, x).Value & "','0','0','0','0','0','0','0','0','0','0','0','0','0','0','" & dg1.Item(5, x).Value & "','" & dg1.Item(6, x).Value & "','0','0','0','0','0','0','0','0','" & cboYear.Text & "','" & cboSection.Text & "','" & frmRegistrar.stSY.Text & "')"
                        conn.Open()
                        Dim mysC2 As New MySqlCommand(str, conn)
                        mysC2.ExecuteNonQuery()
                        conn.Close()
                    ElseIf cboMonth.Text = "SEPTEMBER" Then
                        str = "insert into stude_attendance values('0','" & dg1.Item(0, x).Value & "','" & dg1.Item(2, x).Value & "','" & dg1.Item(3, x).Value & "','" & dg1.Item(4, x).Value & "','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','" & dg1.Item(5, x).Value & "','" & dg1.Item(6, x).Value & "','0','0','0','0','0','0','" & cboYear.Text & "','" & cboSection.Text & "','" & frmRegistrar.stSY.Text & "')"
                        conn.Open()
                        Dim mysC2 As New MySqlCommand(str, conn)
                        mysC2.ExecuteNonQuery()
                        conn.Close()
                    ElseIf cboMonth.Text = "OCTOBER" Then
                        str = "insert into stude_attendance values('0','" & dg1.Item(0, x).Value & "','" & dg1.Item(2, x).Value & "','" & dg1.Item(3, x).Value & "','" & dg1.Item(4, x).Value & "','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','" & dg1.Item(5, x).Value & "','" & dg1.Item(6, x).Value & "','0','0','0','0','" & cboYear.Text & "','" & cboSection.Text & "','" & frmRegistrar.stSY.Text & "')"
                        conn.Open()
                        Dim mysC2 As New MySqlCommand(str, conn)
                        mysC2.ExecuteNonQuery()
                        conn.Close()
                    ElseIf cboMonth.Text = "NOVEMBER" Then
                        str = "insert into stude_attendance values('0','" & dg1.Item(0, x).Value & "','" & dg1.Item(2, x).Value & "','" & dg1.Item(3, x).Value & "','" & dg1.Item(4, x).Value & "','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','" & dg1.Item(5, x).Value & "','" & dg1.Item(6, x).Value & "','0','0','" & cboYear.Text & "','" & cboSection.Text & "','" & frmRegistrar.stSY.Text & "')"
                        conn.Open()
                        Dim mysC2 As New MySqlCommand(str, conn)
                        mysC2.ExecuteNonQuery()
                        conn.Close()
                    ElseIf cboMonth.Text = "DECEMBER" Then
                        str = "insert into stude_attendance values('0','" & dg1.Item(0, x).Value & "','" & dg1.Item(2, x).Value & "','" & dg1.Item(3, x).Value & "','" & dg1.Item(4, x).Value & "','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','0','" & dg1.Item(5, x).Value & "','" & dg1.Item(6, x).Value & "','" & cboYear.Text & "','" & cboSection.Text & "','" & frmRegistrar.stSY.Text & "')"
                        conn.Open()
                        Dim mysC2 As New MySqlCommand(str, conn)
                        mysC2.ExecuteNonQuery()
                        conn.Close()
                    End If
                    conn.Close()
                Next
                MsgBox("Student attendance successfully saved!", MsgBoxStyle.Information)
                conn.Close()
                LoadStudents()

            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
        conn.Close()
    End Sub

    Private Sub cboDepartment_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDepartment.TextChanged
        getYearLevel()
        sectionID()
        getAdviser()
    End Sub

    Private Sub cboSection_TextChanged(sender As Object, e As EventArgs) Handles cboSection.TextChanged
        getSection()
        sectionID()
        getAdviser()
        LoadStudents()
    End Sub

    Private Sub cboSection_TabStopChanged(sender As Object, e As EventArgs) Handles cboSection.TabStopChanged
        sectionID()
        getAdviser()
        LoadStudents()
    End Sub
End Class