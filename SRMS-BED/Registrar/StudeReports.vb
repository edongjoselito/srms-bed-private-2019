Imports MySql.Data.MySqlClient
Public Class frmStudeReports
    Dim str As String
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtStudentNo_Click(sender As Object, e As EventArgs) Handles mskStudentNumber.Click
        frmCompleteList.lblSource.Text = "Reports"
        frmCompleteList.ShowDialog()
    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        If mskStudentNumber.Text = "" Then
            MsgBox("Please enter Student Number!", MsgBoxStyle.Information)
            Exit Sub
            mskStudentNumber.Focus()
        End If

        Try
            'COR
            If cboStudeReport.SelectedIndex = 0 Then

                str = "select r.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as StudentName, r.Sem, r.SY, r.Course, r.YearLevel, r.SubjectCode, r.Description, r.Section, r.SchedTime, r.Room, r.Instructor, sr.SchoolName, sr.SchoolAddress, sr.letterHead from registration r join studeprofile p on r.StudentNumber=p.StudentNumber join srms_settings sr on r.settingsID=sr.settingsID where r.StudentNumber = '" & mskStudentNumber.Text & "' and r.Sem = '" & frmRegistrar.stSemester.Text & "' and r.SY = '" & frmRegistrar.stSY.Text & "' group by r.SubjectCode, r.Description order by r.SubjectCode"
                conn.Open()
                Dim mysDa As New MySqlDataAdapter(Str, conn)
                Dim mysds As New DataSet
                mysDa.Fill(mysds, "registration, srms_settings")
                Dim obj As New COR
                obj.SetDataSource(mysds.Tables("registration, srms_settings"))
                specialReportViewer.ReportSource = obj
                specialReportViewer.Refresh()
                conn.Close()
            End If

            'Cert of Enrollment
            If cboStudeReport.SelectedIndex = 1 Then
                str = "select r.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as StudentName, r.Sem, r.SY, r.Course, r.YearLevel, r.SubjectCode, r.Description, r.Section, r.SchedTime, r.Room, r.Instructor, sr.SchoolName, sr.SchoolAddress, sr.letterHead, sr.RegistrarSHS, sr.RegistrarJHS from registration r join studeprofile p on r.StudentNumber=p.StudentNumber join srms_settings sr on r.settingsID=sr.settingsID where r.StudentNumber = '" & mskStudentNumber.Text & "' and r.Sem = '" & frmRegistrar.stSemester.Text & "' and r.SY = '" & frmRegistrar.stSY.Text & "' group by r.SubjectCode, r.Description order by r.SubjectCode"
                conn.Open()
                Dim mysDa As New MySqlDataAdapter(Str, conn)
                Dim mysds As New DataSet
                mysDa.Fill(mysds, "registration, srms_settings")
                Dim obj As New COE
                obj.SetDataSource(mysds.Tables("registration, srms_settings"))
                specialReportViewer.ReportSource = obj
                specialReportViewer.Refresh()
                conn.Close()
            End If

            'Cert. of Good Moral Character
            If cboStudeReport.SelectedIndex = 2 Then
                Str = "select ss.semstudentid, ss.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as StudentName, p.LastName, p.Title, p.Pronoun, p.Pronoun2, p.Pronoun3, ss.Course, ss.YearLevel, ss.Semester, ss.SY, sr.SchoolName, sr.SchoolAddress, sr.GuidanceJHS, sr.SchoolHead, sr.sHeadPosition, sr.RegistrarJHS, sr.RegistrarSHS, sr.letterHead, sr.principalPre, sr.principalGS, sr.principalJHS, sr.principalSHS from semesterstude ss join studeprofile p on ss.StudentNumber=p.StudentNumber join srms_settings sr on ss.settingsID=sr.settingsID where ss.StudentNumber='" & mskStudentNumber.Text & "' order by ss.semstudentid desc limit 1"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(Str, conn)
                Dim mysds As New DataSet
                mysDA.Fill(mysds, "studeprofile, semesterstude")
                Dim obj As New GoodMoral
                obj.SetDataSource(mysds.Tables("studeprofile, semesterstude"))
                specialReportViewer.ReportSource = obj

                specialReportViewer.Refresh()
                conn.Close()


            End If

            'Certificate of Clearance
            If cboStudeReport.SelectedIndex = 3 Then
                getDepartment()
                str = "Select r.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as Fullname, p.LRN, s.Course, s.YearLevel, r.Sem, r.SY, sr.SchoolName, sr.SchoolAddress, sr.letterHead, p.Pronoun2, p.Pronoun3, sr.financeOfficer, sr.financeOfficerPosition from registration r join semesterstude s on s.StudentNumber = r.StudentNumber join studeprofile p on p.StudentNumber = r.StudentNumber join srms_settings sr on p.settingsID=sr.settingsID where r.StudentNumber = '" & mskStudentNumber.Text & "' and r.Sem = '" & frmRegistrar.stSemester.Text & "' and r.SY = '" & frmRegistrar.stSY.Text & "' group by r.StudentNumber"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(Str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "registration, studeprofile, semsubjects, semesterstude, staff")
                Dim obj As New ClearanceV2
                obj.SetDataSource(ds.Tables("registration, studeprofile, semsubjects, semesterstude, staff"))
                obj.SetParameterValue("studentType", lblStudeType.Text)
                specialReportViewer.ReportSource = obj
                specialReportViewer.Refresh()
                conn.Close()

            End If

            'Clearance
            If cboStudeReport.SelectedIndex = 4 Then
                str = "select r.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as Fullname, s.Course, s.YearLevel, r.SubjectCode, r.Description, r.Section, ss.SchedTime, ss.Room, ss.Semester, ss.SY, s.Semester, s.SY, concat(sf.FirstName,' ',sf.LastName) as Instructor, sr.SchoolName, sr.SchoolAddress, sr.letterHead from registration r join semsubjects ss on ss.SubjectCode = r.SubjectCode join semesterstude s on s.StudentNumber = r.StudentNumber join studeprofile p on p.StudentNumber = r.StudentNumber join staff sf on sf.IDNumber=ss.IDNumber join srms_settings sr on p.settingsID=sr.settingsID where r.StudentNumber = '" & mskStudentNumber.Text & "' and r.Sem = '" & frmRegistrar.stSemester.Text & "' and r.SY = '" & frmRegistrar.stSY.Text & "' and ss.Semester = '" & frmRegistrar.stSemester.Text & "' and ss.SY = '" & frmRegistrar.stSY.Text & "' and s.Semester = '" & frmRegistrar.stSemester.Text & "' and s.SY = '" & frmRegistrar.stSY.Text & "' group by r.SubjectCode order by r.SubjectCode"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(Str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "registration, studeprofile, semsubjects, semesterstude, staff")
                Dim obj As New Clearance
                obj.SetDataSource(ds.Tables("registration, studeprofile, semsubjects, semesterstude, staff"))
                specialReportViewer.ReportSource = obj
                specialReportViewer.Refresh()
                conn.Close()

            End If

            'Report of Grades
            If cboStudeReport.SelectedIndex = 5 Then
                getDepartment()
                If lblDepartment.Text = "Senior High School" Then
                    str = "select p.LRN, p.StudentNumber, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudeName, p.Sex, p.BirthDate, p.Age, p.BirthPlace, p.Guardian, ss.Course, ss.YearLevel, ss.Section, ss.Track, ss.Qualification, g.Description, g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Average, g.SY, g.Adviser, sr.SchoolName, sr.SchoolAddress, sr.SchoolHead, sr.sHeadPosition,sr.Division,sr.Region, sr.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join grades g on ss.StudentNumber=g.StudentNumber join srms_settings sr on ss.settingsID=sr.settingsID where p.StudentNumber='" & mskStudentNumber.Text & "' and ss.SY='" & frmRegistrar.stSY.Text & "' and ss.Semester='" & frmRegistrar.stSemester.Text & "' and g.SY='" & frmRegistrar.stSY.Text & "' and g.Sem='" & frmRegistrar.stSemester.Text & "'  group by g.SubjectCode order by g.SubjectCode"
                    conn.Open()
                    Dim mysDA As New MySqlDataAdapter(Str, conn)
                    Dim mysds As New DataSet
                    mysDA.Fill(mysds, "p.studeprofile, g.grades, ss.semesterstude")
                    Dim obj As New ReportofGrades
                    obj.SetDataSource(mysds.Tables("p.studeprofile, g.grades, ss.semesterstude"))
                    specialReportViewer.ReportSource = obj
                    specialReportViewer.Refresh()
                    conn.Close()
                ElseIf lblDepartment.Text = "Junior High School" Then
                    str = "select p.LRN, p.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as StudeName, p.Sex, p.BirthDate, p.Age, p.BirthPlace, p.Guardian, ss.Course, g.YearLevel, ss.Section, g.Track, g.strand, g.Description, g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Average, g.Sem, g.SY, g.subComponent, g.Adviser, sr.SchoolName, sr.SchoolAddress, sr.SchoolHead, sr.sHeadPosition,sr.Division,sr.Region, sr.letterHead, sr.depedlogo, sr.schoolLogo, sr.district, sr.principalPre, sr.principalGS, sr.principalJHS, sr.principalSHS, sr.RegistrarJHS, sr.RegistrarSHS from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join grades g on ss.StudentNumber=g.StudentNumber join srms_settings sr on ss.settingsID=sr.settingsID where p.StudentNumber='" & mskStudentNumber.Text & "' and ss.SY='" & frmRegistrar.stSY.Text & "' and ss.Semester='" & frmRegistrar.stSemester.Text & "' and g.SY='" & frmRegistrar.stSY.Text & "' and g.Sem='" & frmRegistrar.stSemester.Text & "' order by g.SubjectCode"
                    conn.Open()
                    Dim mysDA As New MySqlDataAdapter(Str, conn)
                    Dim mysds As New DataSet
                    mysDA.Fill(mysds, "p.studeprofile, g.grades, ss.semesterstude")
                    Dim obj As New ROGElem
                    obj.SetDataSource(mysds.Tables("p.studeprofile, g.grades, ss.semesterstude"))
                    obj.SetParameterValue("studeType", lblStudeType.Text)
                    obj.SetParameterValue("GenAve", lblGenAve.Text)
                    obj.SetParameterValue("FirstAve", lblFirstAve.Text)
                    obj.SetParameterValue("SecondAve", lblSecondAve.Text)
                    obj.SetParameterValue("ThirdAve", lblThirdAve.Text)
                    obj.SetParameterValue("FourthAve", lblFourthAve.Text)
                    specialReportViewer.ReportSource = obj
                    conn.Close()

                Else
                    str = "select p.LRN, p.StudentNumber, concat(p.FirstName,' ',p.MiddleName,' ',p.LastName) as StudeName, p.Sex, p.BirthDate, p.Age, p.BirthPlace, p.Guardian, ss.Course, g.YearLevel, ss.Section, g.Track, g.strand, g.Description, g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Average, g.Sem, g.SY, g.subComponent, g.Adviser, sr.SchoolName, sr.SchoolAddress, sr.SchoolHead, sr.sHeadPosition,sr.Division,sr.Region, sr.letterHead, sr.depedlogo, sr.schoolLogo, sr.district, sr.principalPre, sr.principalGS, sr.principalJHS, sr.principalSHS, sr.RegistrarJHS, sr.RegistrarSHS from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join grades g on ss.StudentNumber=g.StudentNumber join srms_settings sr on ss.settingsID=sr.settingsID where p.StudentNumber='" & mskStudentNumber.Text & "' and ss.SY='" & frmRegistrar.stSY.Text & "' and ss.Semester='" & frmRegistrar.stSemester.Text & "' and g.SY='" & frmRegistrar.stSY.Text & "' and g.Sem='" & frmRegistrar.stSemester.Text & "' order by g.SubjectCode"
                    conn.Open()
                    Dim mysDA As New MySqlDataAdapter(Str, conn)
                    Dim mysds As New DataSet
                    mysDA.Fill(mysds, "p.studeprofile, g.grades, ss.semesterstude")
                    Dim obj As New ROGElem

                    obj.SetDataSource(mysds.Tables("p.studeprofile, g.grades, ss.semesterstude"))
                    obj.SetParameterValue("studeType", lblStudeType.Text)
                    obj.SetParameterValue("GenAve", lblGenAve.Text)
                    obj.SetParameterValue("FirstAve", lblFirstAve.Text)
                    obj.SetParameterValue("SecondAve", lblSecondAve.Text)
                    obj.SetParameterValue("ThirdAve", lblThirdAve.Text)
                    obj.SetParameterValue("FourthAve", lblFourthAve.Text)
                    specialReportViewer.ReportSource = obj
                    conn.Close()
                End If

            End If

            'Report of Grades V2
            If cboStudeReport.SelectedIndex = 6 Then
                getDepartment()
                If lblDepartment.Text = "Senior High School" Then
                    str = "select p.StudentNumber, LRN, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudeName, p.Sex, p.BirthDate, p.Age, p.BirthPlace, p.Guardian, ss.Course, ss.YearLevel, ss.Section, ss.Track, ss.Qualification, g.Description, g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Average, g.SY, g.adviser, sr.SchoolName, sr.SchoolAddress, sr.SchoolHead, sr.sHeadPosition,sr.Division,sr.Region, sr.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join grades g on ss.StudentNumber=g.StudentNumber join srms_settings sr on ss.settingsID=sr.settingsID where p.StudentNumber='" & mskStudentNumber.Text & "' and ss.SY='" & frmRegistrar.stSY.Text & "' and ss.Semester='" & frmRegistrar.stSemester.Text & "' and g.SY='" & frmRegistrar.stSY.Text & "' and g.Sem='" & frmRegistrar.stSemester.Text & "'  group by g.SubjectCode order by g.SubjectCode"
                    conn.Open()
                    Dim mysDA As New MySqlDataAdapter(Str, conn)
                    Dim mysds As New DataSet
                    mysDA.Fill(mysds, "p.studeprofile, g.grades, ss.semesterstude")
                    Dim obj As New ReportofGrades
                    obj.SetDataSource(mysds.Tables("p.studeprofile, g.grades, ss.semesterstude"))
                    specialReportViewer.ReportSource = obj
                    conn.Close()
                ElseIf lblDepartment.Text = "Junior High School" Then
                    str = "select p.StudentNumber, LRN, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudeName, p.Sex, p.BirthDate, p.Age, p.BirthPlace, p.Guardian, ss.Course, ss.YearLevel, ss.Section, ss.Track, ss.Qualification, g.Description, g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Average, g.SY, g.subComponent, g.adviser, sr.SchoolName, sr.SchoolAddress, sr.SchoolHead, sr.sHeadPosition,sr.Division,sr.Region, sr.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join grades g on ss.StudentNumber=g.StudentNumber join srms_settings sr on ss.settingsID=sr.settingsID where p.StudentNumber='" & mskStudentNumber.Text & "' and ss.SY='" & frmRegistrar.stSY.Text & "' and ss.Semester='" & frmRegistrar.stSemester.Text & "' and g.SY='" & frmRegistrar.stSY.Text & "' and g.Sem='" & frmRegistrar.stSemester.Text & "' order by g.SubjectCode"
                    conn.Open()
                    Dim mysDA As New MySqlDataAdapter(Str, conn)
                    Dim mysds As New DataSet
                    mysDA.Fill(mysds, "p.studeprofile, g.grades, ss.semesterstude")
                    Dim obj As New ReportOfGradesJHS
                    obj.SetDataSource(mysds.Tables("p.studeprofile, g.grades, ss.semesterstude"))
                    obj.SetParameterValue("GenAve", lblGenAve.Text)
                    obj.SetParameterValue("FirstAve", lblFirstAve.Text)
                    obj.SetParameterValue("SecondAve", lblSecondAve.Text)
                    obj.SetParameterValue("ThirdAve", lblThirdAve.Text)
                    obj.SetParameterValue("FourthAve", lblFourthAve.Text)
                    specialReportViewer.ReportSource = obj
                    conn.Close()

                Else
                    str = "select p.StudentNumber, LRN, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudeName, p.Sex, p.BirthDate, p.Age, p.BirthPlace, p.Guardian, ss.Course, ss.YearLevel, ss.Section, ss.Track, ss.Qualification, g.Description, g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Average, g.SY, g.subComponent, g.adviser, sr.SchoolName, sr.SchoolAddress, sr.SchoolHead, sr.sHeadPosition,sr.Division,sr.Region, sr.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join grades g on ss.StudentNumber=g.StudentNumber join srms_settings sr on ss.settingsID=sr.settingsID where p.StudentNumber='" & mskStudentNumber.Text & "' and ss.SY='" & frmRegistrar.stSY.Text & "' and ss.Semester='" & frmRegistrar.stSemester.Text & "' and g.SY='" & frmRegistrar.stSY.Text & "' and g.Sem='" & frmRegistrar.stSemester.Text & "' order by g.SubjectCode"
                    conn.Open()
                    Dim mysDA As New MySqlDataAdapter(Str, conn)
                    Dim mysds As New DataSet
                    mysDA.Fill(mysds, "p.studeprofile, g.grades, ss.semesterstude")
                    Dim obj As New ReportOfGradesJHS
                    obj.SetDataSource(mysds.Tables("p.studeprofile, g.grades, ss.semesterstude"))
                    obj.SetParameterValue("GenAve", lblGenAve.Text)
                    obj.SetParameterValue("FirstAve", lblFirstAve.Text)
                    obj.SetParameterValue("SecondAve", lblSecondAve.Text)
                    obj.SetParameterValue("ThirdAve", lblThirdAve.Text)
                    obj.SetParameterValue("FourthAve", lblFourthAve.Text)
                    specialReportViewer.ReportSource = obj
                    conn.Close()
                End If

            End If

            'Report Card
            If cboStudeReport.SelectedIndex = 7 Then
                Dim str1 As String
                If lblDepartment.Text = "Senior High School" Then

                    str = "select p.StudentNumber, LRN, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudeName, p.Sex, p.BirthDate, p.Age, p.BirthPlace, p.Guardian, ss.Course, g.YearLevel, g.Adviser, ss.Section, g.Track, g.strand, g.Description, g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Average, g.Sem, g.SY, g.Adviser, sr.SchoolName, sr.SchoolAddress, sr.SchoolHead, sr.sHeadPosition,sr.Division,sr.Region, sr.letterHead, sr.depedlogo, sr.schoolLogo, sr.district, sr.principalPre, sr.principalGS, sr.principalJHS, sr.principalSHS from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join grades g on ss.StudentNumber=g.StudentNumber join srms_settings sr on ss.settingsID=sr.settingsID where p.StudentNumber='" & mskStudentNumber.Text & "' and ss.SY='" & frmRegistrar.stSY.Text & "' and ss.Semester='" & frmRegistrar.stSemester.Text & "' and g.SY='" & frmRegistrar.stSY.Text & "' group by g.Sem, g.SubjectCode order by g.SubjectCode"
                    str1 = "SELECT s.attendanceID, s.StudentNumber, s.fName, s.mName, s.lName, s.janPres, s.janTardy, s.febPres, s.febTardy, s.marPres, s.marTardy, s.aprPres, s.aprTardy, s.mayPres, s.mayTardy, s.junPres, s.junTardy, s.julPres, s.julTardy, s.augPres, s.augTardy, s.sepPres, s.sepTardy, s.octPres, s.octTardy, s.novPres, s.novTardy, s.decPres, s.decTardy, s.YearLevel, s.studeSection, s.SY, c.jan, c.feb, c.mar, c.apr, c.may, c.jun, c.jul, c.aug, c.sep, c.oct, c.nov, c.december FROM stude_attendance s join classdays c on s.SY=c.SY where s.StudentNumber='" & mskStudentNumber.Text & "' and s.SY='" & frmRegistrar.stSY.Text & "'"
                    conn.Open()
                    Dim mysDA As New MySqlDataAdapter(Str, conn)
                    Dim mysDA1 As New MySqlDataAdapter(str1, conn)

                    Dim mysds As New DataSet
                    Dim mysds1 As New DataSet

                    mysDA.Fill(mysds, "p.studeprofile, g.grades, ss.semesterstude")
                    mysDA1.Fill(mysds1, "stude_attendance, classdays")

                    Dim obj As New ReportCardSHS2
                    obj.SetDataSource(mysds.Tables("p.studeprofile, g.grades, ss.semesterstude"))
                    obj.Subreports.Item("StudentsAttendance.rpt").SetDataSource(mysds1.Tables("stude_attendance, classdays"))
                    specialReportViewer.ReportSource = obj
                    conn.Close()

                ElseIf lblDepartment.Text = "Junior High School" Then
                    str = "select p.StudentNumber, LRN, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudeName, p.Sex, p.BirthDate, p.Age, p.BirthPlace, p.Guardian, ss.Course, g.YearLevel, g.Adviser, ss.Section, g.Track, g.strand, g.Description, g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Average, g.Sem, g.SY, g.subComponent, sr.SchoolName, sr.SchoolAddress, sr.SchoolHead, sr.sHeadPosition,sr.Division,sr.Region, sr.letterHead, sr.depedlogo, sr.schoolLogo, sr.district, sr.principalPre, sr.principalGS, sr.principalJHS, sr.principalSHS from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join grades g on ss.StudentNumber=g.StudentNumber join srms_settings sr on ss.settingsID=sr.settingsID where p.StudentNumber='" & mskStudentNumber.Text & "' and ss.SY='" & frmRegistrar.stSY.Text & "' and ss.Semester='" & frmRegistrar.stSemester.Text & "' and g.SY='" & frmRegistrar.stSY.Text & "' and g.Sem='" & frmRegistrar.stSemester.Text & "' order by g.SubjectCode"
                    str1 = "SELECT s.attendanceID, s.StudentNumber, s.fName, s.mName, s.lName, s.janPres, s.janTardy, s.febPres, s.febTardy, s.marPres, s.marTardy, s.aprPres, s.aprTardy, s.mayPres, s.mayTardy, s.junPres, s.junTardy, s.julPres, s.julTardy, s.augPres, s.augTardy, s.sepPres, s.sepTardy, s.octPres, s.octTardy, s.novPres, s.novTardy, s.decPres, s.decTardy, s.YearLevel, s.studeSection, s.SY, c.jan, c.feb, c.mar, c.apr, c.may, c.jun, c.jul, c.aug, c.sep, c.oct, c.nov, c.december FROM stude_attendance s join classdays c on s.SY=c.SY where s.StudentNumber='" & mskStudentNumber.Text & "' and s.SY='" & frmRegistrar.stSY.Text & "'"

                    conn.Open()
                    Dim mysDA As New MySqlDataAdapter(Str, conn)
                    Dim mysDA1 As New MySqlDataAdapter(str1, conn)

                    Dim mysds As New DataSet
                    Dim mysds1 As New DataSet

                    mysDA.Fill(mysds, "p.studeprofile, g.grades, ss.semesterstude")
                    mysDA1.Fill(mysds1, "stude_attendance, classdays")
                    Dim obj As New ReportCard
                    obj.SetDataSource(mysds.Tables("p.studeprofile, g.grades, ss.semesterstude"))
                    obj.Subreports.Item("StudentsAttendance.rpt").SetDataSource(mysds1.Tables("stude_attendance, classdays"))
                    obj.SetParameterValue("GenAve", lblGenAve.Text)
                    specialReportViewer.ReportSource = obj
                    conn.Close()

                Else
                    str = "select p.StudentNumber, LRN, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudeName, p.Sex, p.BirthDate, p.Age, p.BirthPlace, p.Guardian, ss.Course, g.YearLevel, g.Adviser, ss.Section, g.Track, g.strand, g.Description, g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Average, g.Sem, g.SY, g.subComponent, sr.SchoolName, sr.SchoolAddress, sr.SchoolHead, sr.sHeadPosition,sr.Division,sr.Region, sr.letterHead, sr.depedlogo, sr.schoolLogo, sr.district, sr.principalPre, sr.principalGS, sr.principalJHS, sr.principalSHS from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join grades g on ss.StudentNumber=g.StudentNumber join srms_settings sr on ss.settingsID=sr.settingsID where p.StudentNumber='" & mskStudentNumber.Text & "' and ss.SY='" & frmRegistrar.stSY.Text & "' and ss.Semester='" & frmRegistrar.stSemester.Text & "' and g.SY='" & frmRegistrar.stSY.Text & "' and g.Sem='" & frmRegistrar.stSemester.Text & "' order by g.SubjectCode"
                    str1 = "SELECT s.attendanceID, s.StudentNumber, s.fName, s.mName, s.lName, s.janPres, s.janTardy, s.febPres, s.febTardy, s.marPres, s.marTardy, s.aprPres, s.aprTardy, s.mayPres, s.mayTardy, s.junPres, s.junTardy, s.julPres, s.julTardy, s.augPres, s.augTardy, s.sepPres, s.sepTardy, s.octPres, s.octTardy, s.novPres, s.novTardy, s.decPres, s.decTardy, s.YearLevel, s.studeSection, s.SY, c.jan, c.feb, c.mar, c.apr, c.may, c.jun, c.jul, c.aug, c.sep, c.oct, c.nov, c.december FROM stude_attendance s join classdays c on s.SY=c.SY where s.StudentNumber='" & mskStudentNumber.Text & "' and s.SY='" & frmRegistrar.stSY.Text & "'"

                    conn.Open()
                    Dim mysDA As New MySqlDataAdapter(Str, conn)
                    Dim mysDA1 As New MySqlDataAdapter(str1, conn)

                    Dim mysds As New DataSet
                    Dim mysds1 As New DataSet

                    mysDA.Fill(mysds, "p.studeprofile, g.grades, ss.semesterstude")
                    mysDA1.Fill(mysds1, "stude_attendance, classdays")

                    Dim obj As New ReportCard
                    obj.SetDataSource(mysds.Tables("p.studeprofile, g.grades, ss.semesterstude"))
                    obj.Subreports.Item("StudentsAttendance.rpt").SetDataSource(mysds1.Tables("stude_attendance, classdays"))
                    obj.SetParameterValue("GenAve", lblGenAve.Text)
                    specialReportViewer.ReportSource = obj
                    conn.Close()
                End If

            End If

            'Scholastic Record
            If cboStudeReport.SelectedIndex = 8 Then

                If frmRegistrar.stSemester.Text = "First Semester" Or frmRegistrar.stSemester.Text = "Second Semester" Then

                    str = "select p.StudentNumber, p.FirstName, p.MiddleName, p.LastName, p.BirthPlace, p.BirthDate, p.Guardian, p.GuardianAddress, p.Sex, p.guardianOccupation, p.Elementary, p.ElemAddress, p.elemSY, p.HighSchool, p.HSAddress, p.elemAve, p.jhsAve, p.jhsGradDate, p.elemGradDate, p.eligibility, p.elemSchoolID, p.jhsSchoolID, p.peptRating, p.peptExamDate, p.alsRating, p.alsTestingCenter, p.nameExt, g.YearLevel, ss.Semester, concat(g.Sem,', ',g.SY) as batch, g.Sem ,g.SY,g.track, g.strand, g.adviser, g.Section, ss.Qualification, ss.Semester as SemSem, ss.SY as SemSY, g.SubjectCode, g.Description, g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Average, st.SchoolName, st.SchoolAddress, st.Division, st.SchoolIDSHS, st.SchoolIDJHS, st.SchoolHead, st.sHeadPosition, st.RegistrarSHS, st.RegistrarJHS, st.letterHead, st.Division, st.Region, st.schoolLogo from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join grades g on p.StudentNumber=g.StudentNumber join srms_settings st on p.settingsID=st.settingsID join classdays cd on st.settingsID=cd.settingsID  where p.StudentNumber='" & mskStudentNumber.Text & "' and g.Sem!='' group by g.SubjectCode, g.SY, g.Sem order by g.SY, g.Sem, g.SubjectCode"
                    conn.Open()
                    Dim mysDA As New MySqlDataAdapter(str, conn)
                    Dim mysds As New DataSet
                    mysDA.Fill(mysds, "studeprofile, grades, semesterstude, srms_settings")
                    Dim obj As New TOR
                    obj.SetDataSource(mysds.Tables("studeprofile, grades, semesterstude, srms_settings"))
                    specialReportViewer.ReportSource = obj
                    conn.Close()
                Else

                    str = "select p.StudentNumber, p.FirstName, p.MiddleName, p.LastName, p.BirthPlace, p.BirthDate, p.Guardian, p.GuardianAddress, p.Sex, p.guardianOccupation, p.Elementary, p.ElemAddress, p.elemSY, p.HighSchool, p.HSAddress, p.elemAve, p.jhsAve, p.jhsGradDate, p.elemGradDate, p.eligibility, p.elemSchoolID, p.jhsSchoolID, p.peptRating, p.peptExamDate, p.alsRating, p.alsTestingCenter, p.nameExt, g.YearLevel, ss.Semester, concat(g.Sem,', ',g.SY) as batch, g.Sem ,g.SY,g.track, g.strand, g.adviser, g.Section, ss.Qualification, ss.Semester as SemSem, ss.SY as SemSY, g.SubjectCode, g.Description, g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Average, st.SchoolName, st.SchoolAddress, st.Division, st.SchoolIDSHS, st.SchoolIDJHS, st.SchoolHead, st.sHeadPosition, st.RegistrarSHS, st.RegistrarJHS, st.letterHead, st.Division, st.Region, st.schoolLogo from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join grades g on p.StudentNumber=g.StudentNumber join srms_settings st on p.settingsID=st.settingsID join classdays cd on st.settingsID=cd.settingsID where p.StudentNumber='" & mskStudentNumber.Text & "' and ss.Course='Junior High School' group by g.SubjectCode, g.SY, g.Sem order by g.SY, g.Sem, g.SubjectCode"
                    conn.Open()
                    Dim mysDA As New MySqlDataAdapter(Str, conn)
                    Dim mysds As New DataSet
                    mysDA.Fill(mysds, "studeprofile, grades, semesterstude, srms_settings")
                    Dim obj As New TORJHS1
                    obj.SetDataSource(mysds.Tables("studeprofile, grades, semesterstude, srms_settings"))
                    specialReportViewer.ReportSource = obj
                    conn.Close()
                End If
            End If


            'Student's Profile
            If cboStudeReport.SelectedIndex = 9 Then
                str = "SELECT * FROM studeprofile s join semesterstude ss on s.StudentNumber=ss.StudentNumber join srms_settings st on s.settingsID=st.settingsID join stude_requirements sr on s.StudentNumber=sr.StudentNumber where ss.StudentNumber='" & mskStudentNumber.Text & "' and ss.SY='" & frmRegistrar.stSY.Text & "'"
                'str = "SELECT * FROM studeprofile s join semesterstude ss on s.StudentNumber=ss.StudentNumber join srms_settings st on s.settingsID=st.settingsID join stude_requirements sr on s.StudentNumber=sr.StudentNumber join stude_esc_requirements ser on s.StudentNumber=ser.StudentNumber where ss.StudentNumber='" & mskStudentNumber.Text & "' and ss.SY='" & frmRegistrar.stSY.Text & "'"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(Str, conn)
                Dim mysds As New Reports3
                mysDA.Fill(mysds, "studeprofile, semesterstude")
                'Dim obj As New StudeProfile
                Dim obj As New StudeProfilev2
                obj.SetDataSource(mysds.Tables("studeprofile, semesterstude"))
                specialReportViewer.ReportSource = obj
                conn.Close()
            End If


            'Registration Form
            If cboStudeReport.SelectedIndex = 10 Then
                str = "SELECT * FROM studeprofile s join semesterstude ss on s.StudentNumber=ss.StudentNumber join srms_settings st on s.settingsID=st.settingsID  where ss.StudentNumber='" & mskStudentNumber.Text & "' and ss.SY='" & frmRegistrar.stSY.Text & "'"
                conn.Open()
                Dim mysDA As New MySqlDataAdapter(Str, conn)
                Dim mysds As New Reports3
                mysDA.Fill(mysds, "studeprofile, semesterstude")
                Dim obj As New RegistrationForm
                obj.SetDataSource(mysds.Tables("studeprofile, semesterstude"))
                specialReportViewer.ReportSource = obj
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Public Sub getDepartment()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select * from semesterstude where StudentNumber='" & mskStudentNumber.Text & "' order by semstudentid desc limit 1"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lblDepartment.Text = dtReader(2)

            End If
            conn.Close()

            If lblDepartment.Text = "Elementary" Then
                lblStudeType.Text = "pupil"
                'lblrecogNo.Text = "E-010. Series 2011"
            ElseIf lblDepartment.Text = "Junior High School" Then
                lblStudeType.Text = "student"
                'lblrecogNo.Text = "S-043. Series 2011"
            Else
                lblStudeType.Text = "student"
                'lblrecogNo.Text = "SHS-0429. Series 2015"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub mskStudentNumber_TextChanged(sender As Object, e As EventArgs) Handles mskStudentNumber.TextChanged
        getDepartment()
        getSumPerQuarter()
        getMapehPerQuarter()
        getmapehAve()
        getSubjectSum()
        getSubjectCount()


    End Sub
    Public Sub getSumPerQuarter()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "SELECT Sum(PGrade) as FirstQuarter, Sum(MGrade) as SecondQuarter, Sum(PFinalGrade) as ThirdQuarter, Sum(FGrade) as FourthQuarter FROM grades where Description not like '%mapeh%' and Description not like '%Music%' and (StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "')"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                If Not dtReader.IsDBNull(0) Then
                    lblFirst.Text = dtReader(0)
                    lblSecond.Text = dtReader(1)
                    lblThird.Text = dtReader(2)
                    lblFourth.Text = dtReader(3)
                Else
                    lblFirst.Text = 0
                    lblSecond.Text = 0
                    lblThird.Text = 0
                    lblFourth.Text = 0
                End If
                conn.Close()
            Else
                lblFirst.Text = 0
                lblSecond.Text = 0
                lblThird.Text = 0
                lblFourth.Text = 0
            End If
            conn.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Public Sub getMapehPerQuarter()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "SELECT Avg(PGrade) as PAverage, Avg(MGrade) as MAverage, Avg(PFinalGrade) as PFAverage, Avg(FGrade) as FAverage FROM grades where (Description like '%mapeh%' or Description like '%Music%') and StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()

            If dtReader.Read() Then
                ' Check for DBNull before assigning the value
                If Not dtReader.IsDBNull(0) Then
                    lblMFirst.Text = dtReader(0)
                    lblMSecond.Text = dtReader(1)
                    lblMThird.Text = dtReader(2)
                    lblMFourth.Text = dtReader(3)

                Else

                    lblMFirst.Text = "0"
                    lblMSecond.Text = "0"
                    lblMThird.Text = "0"
                    lblMFourth.Text = "0"
                End If
                conn.Close()
            Else

                lblMFirst.Text = "0"
                lblMSecond.Text = "0"
                lblMThird.Text = "0"
                lblMFourth.Text = "0"
            End If


            conn.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Public Sub getmapehAve()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "SELECT Avg(Average) as Average FROM grades where (Description like '%mapeh%' or Description like '%Music%') and StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()

            If dtReader.Read() Then
                ' Check for DBNull before assigning the value
                If Not dtReader.IsDBNull(0) Then
                    lblMapehAve.Text = dtReader(0)
                Else
                    lblMapehAve.Text = "0"
                End If
                conn.Close()
            Else
                lblMapehAve.Text = "0"
            End If


            conn.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Public Sub getSubjectSum()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "SELECT Sum(Average) as Average FROM grades where Description not like '%mapeh%' and Description not like '%Music%' and (StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "')"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                If Not dtReader.IsDBNull(0) Then
                    lblSubjAve.Text = dtReader(0)
                Else
                    lblSubjAve.Text = "0"
                End If
                conn.Close()
            Else
                lblSubjAve.Text = 0
            End If
            conn.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Public Sub getSubjectCount()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "SELECT Count(Distinct Description) as CountDesc FROM grades where StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                lblSubjCount.Text = dtReader.GetInt32(0)
            Else
                lblSubjCount.Text = 0
            End If
            conn.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Public Sub ComputeAve()
        Try
            Dim TotalAve, GenAve, FirstAve, SecondAve, ThirdAve, FourthAve As Double

            TotalAve = Val(lblSubjAve.Text) + Val(lblMapehAve.Text)

            FirstAve = Val(Val(lblFirst.Text) + Val(lblMFirst.Text)) / lblSubjCount.Text
            SecondAve = Val(Val(lblSecond.Text) + Val(lblMSecond.Text)) / lblSubjCount.Text
            ThirdAve = Val(Val(lblThird.Text) + Val(lblMThird.Text)) / lblSubjCount.Text
            FourthAve = Val(Val(lblFourth.Text) + Val(lblMFourth.Text)) / lblSubjCount.Text

            GenAve = TotalAve / lblSubjCount.Text
            lblGenAve.Text = Math.Round(GenAve)

            lblFirstAve.Text = Math.Round(FirstAve)
            lblSecondAve.Text = Math.Round(SecondAve)
            lblThirdAve.Text = Math.Round(ThirdAve)
            lblFourthAve.Text = Math.Round(FourthAve)

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub lblMapehAve_TextChanged(sender As Object, e As EventArgs) Handles lblMapehAve.TextChanged
        ComputeAve()
    End Sub

    Private Sub lblSubjAve_TextChanged(sender As Object, e As EventArgs) Handles lblSubjAve.TextChanged
        ComputeAve()
    End Sub

    Private Sub lblSubjCount_TextChanged(sender As Object, e As EventArgs) Handles lblSubjCount.TextChanged
        ComputeAve()
    End Sub
End Class