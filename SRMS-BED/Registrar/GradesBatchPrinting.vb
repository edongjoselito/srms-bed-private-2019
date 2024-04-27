Imports MySql.Data.MySqlClient
Public Class frmGradesBatchPrinting
    Dim str As String
    Public Sub getSection()
        Try
            str = "select * from sections where YearLevel='" & cboYearLevel.Text & "' order by Section"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "sections")
            conn.Close()

            cboSection.ValueMember = "sections"
            cboSection.DisplayMember = "Section"
            cboSection.DataSource = ds.Tables("sections")

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

                cboCourse.ValueMember = "course_table"
                cboCourse.DisplayMember = "CourseDescription"
                cboCourse.DataSource = ds.Tables("course_table")
                conn.Close()
            Else
                str = "select * from course_table where CourseDescription!='Senior High School' group by CourseDescription order by CourseDescription"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
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
            Dim ds As New DataSet
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
    Private Sub frmGradesBatchPrinting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getCourse()
    End Sub

    Private Sub cboCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCourse.SelectedIndexChanged
        getCourseMajor()
    End Sub

    Private Sub cboYearLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYearLevel.SelectedIndexChanged
        getSection()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Try
            str = "select s.StudentNumber, p.FirstName, p.MiddleName, p.LastName from semesterstude s join studeprofile p on s.StudentNumber=p.StudentNumber where s.Course='" & cboCourse.Text & "' and s.YearLevel='" & cboYearLevel.Text & "' and s.Section='" & cboSection.Text & "' and s.Semester='" & frmRegistrar.stSemester.Text & "' and s.SY='" & frmRegistrar.stSY.Text & "' order by p.LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "semesterstude")
            dg1.DataSource = ds.Tables("semesterstude")
            conn.Close()


            dg1.Columns(0).HeaderText = "Student Number"
            dg1.Columns(1).HeaderText = "First Name"
            dg1.Columns(1).Width = 150
            dg1.Columns(2).HeaderText = "Middle Name"
            dg1.Columns(2).Width = 150
            dg1.Columns(3).HeaderText = "Last Name"
            dg1.Columns(3).Width = 150






        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try

            If frmRegistrar.stSemester.Text = "First Semester" Or frmRegistrar.stSemester.Text = "Second Semester" Then
                For x As Integer = 0 To dg1.Rows.Count - 1
                    str = "select p.StudentNumber, p.LRN, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudeName, p.Sex, p.BirthDate, p.Age, p.BirthPlace, p.Guardian, ss.Course, ss.YearLevel, ss.Adviser, ss.Section, ss.Track, ss.Qualification, g.Description, g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Average, g.SY, sr.SchoolName, sr.SchoolAddress, sr.SchoolHead, sr.sHeadPosition,sr.Division,sr.Region, sr.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join grades g on ss.StudentNumber=g.StudentNumber join srms_settings sr on ss.settingsID=sr.settingsID where p.StudentNumber='" & dg1.Item(1, x).Value & "' and ss.SY='" & frmRegistrar.stSY.Text & "' and ss.Semester='" & frmRegistrar.stSemester.Text & "' and g.SY='" & frmRegistrar.stSY.Text & "' and g.Sem='" & frmRegistrar.stSemester.Text & "'  group by g.SubjectCode order by g.Description"
                    conn.Open()
                    Dim mysDA As New MySqlDataAdapter(str, conn)
                    Dim mysds As New DataSet
                    mysDA.Fill(mysds, "p.studeprofile, g.grades, ss.semesterstude")
                    Dim obj As New ReportofGrades
                    obj.SetDataSource(mysds.Tables("p.studeprofile, g.grades, ss.semesterstude"))
                    frmRegistrar.crViewer.ReportSource = obj
                    frmRegistrar.crViewer.Refresh()
                    conn.Close()
                    PrintDialog1.AllowSomePages = True
                    obj.PrintToPrinter(PrintDialog1.PrinterSettings.Copies, True, PrintDialog1.PrinterSettings.FromPage, PrintDialog1.PrinterSettings.ToPage)
                Next
            Else
                For x As Integer = 0 To dg1.Rows.Count - 1


                    Dim MapehAve, SubAve, SubjCount As Double

                    ' Calculate MapehAve
                    conn.Open()
                    MapehAve = ExecuteScalar("SELECT AVG(Average) FROM grades WHERE (Description LIKE '%mapeh%' OR Description LIKE '%Music%') and StudentNumber='" & dg1.Item(1, x).Value & "' and Sem='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "'")

                    ' Calculate SubAve
                    SubAve = ExecuteScalar("SELECT SUM(Average) FROM grades WHERE Description NOT LIKE '%mapeh%' AND Description NOT LIKE '%Music%' and StudentNumber='" & dg1.Item(1, x).Value & "' and Sem='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "'")

                    ' Calculate SubjCount
                    SubjCount = ExecuteScalar("SELECT COUNT(DISTINCT Description) FROM grades WHERE StudentNumber='" & dg1.Item(1, x).Value & "' and Sem='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "'")


                    Dim TotalAve, GeneralAve, FinalAve As Double
                    TotalAve = Val(SubAve) + Val(MapehAve)
                    GeneralAve = If(SubjCount <> 0, TotalAve / SubjCount, 0)
                    FinalAve = Math.Round(GeneralAve)

                    conn.Close()

                    str = "select p.StudentNumber, p.LRN, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudeName, p.Sex, p.BirthDate, p.Age, p.BirthPlace, p.Guardian, ss.Course, ss.YearLevel, ss.Adviser, ss.Section, ss.Track, ss.Qualification, g.Description, g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Average, g.SY, g.subComponent, sr.SchoolName, sr.SchoolAddress, sr.SchoolHead, sr.sHeadPosition,sr.Division,sr.Region, sr.letterHead from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join grades g on ss.StudentNumber=g.StudentNumber join srms_settings sr on ss.settingsID=sr.settingsID where p.StudentNumber='" & dg1.Item(1, x).Value & "' and ss.SY='" & frmRegistrar.stSY.Text & "' and ss.Semester='" & frmRegistrar.stSemester.Text & "' and g.SY='" & frmRegistrar.stSY.Text & "' and g.Sem='" & frmRegistrar.stSemester.Text & "' order by g.Description"
                    conn.Open()
                    Dim mysDA As New MySqlDataAdapter(str, conn)
                    Dim mysds As New DataSet
                    mysDA.Fill(mysds, "p.studeprofile, g.grades, ss.semesterstude")
                    Dim obj As New ReportOfGradesJHS
                    obj.SetDataSource(mysds.Tables("p.studeprofile, g.grades, ss.semesterstude"))
                    obj.SetParameterValue("GenAve", FinalAve)
                    frmRegistrar.crViewer.ReportSource = obj
                    frmRegistrar.crViewer.Refresh()
                    conn.Close()
                    PrintDialog1.AllowSomePages = True
                    obj.PrintToPrinter(PrintDialog1.PrinterSettings.Copies, True, PrintDialog1.PrinterSettings.FromPage, PrintDialog1.PrinterSettings.ToPage)
                Next
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Function ExecuteScalar(ByVal query As String) As Double
        Using cmd As New MySql.Data.MySqlClient.MySqlCommand(query, conn)
            Dim result As Object = cmd.ExecuteScalar()
            If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                Return Convert.ToDouble(result)
            Else
                Return 0
            End If
        End Using
    End Function

    Private Sub btnPrintRC_Click(sender As Object, e As EventArgs) Handles btnPrintRC.Click
        Try
            Dim str1 As String
            If frmRegistrar.stSemester.Text = "First Semester" Or frmRegistrar.stSemester.Text = "Second Semester" Then

                For x As Integer = 0 To dg1.Rows.Count - 1
                    str = "select p.StudentNumber, LRN, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudeName, p.Sex, p.BirthDate, p.Age, p.BirthPlace, p.Guardian, ss.Course, g.YearLevel, g.Adviser, ss.Section, g.Track, g.strand, g.Description, g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Average, g.Sem, g.SY, sr.SchoolName, sr.SchoolAddress, sr.SchoolHead, sr.sHeadPosition,sr.Division,sr.Region, sr.letterHead, sr.depedlogo, sr.schoolLogo, sr.district, sr.principalPre, sr.principalGS, sr.principalJHS, sr.principalSHS from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join grades g on ss.StudentNumber=g.StudentNumber join srms_settings sr on ss.settingsID=sr.settingsID where p.StudentNumber='" & dg1.Item(1, x).Value & "' and ss.SY='" & frmRegistrar.stSY.Text & "' and ss.Semester='" & frmRegistrar.stSemester.Text & "' and g.SY='" & frmRegistrar.stSY.Text & "' group by g.Sem, g.SubjectCode order by g.SubjectCode"
                    str1 = "SELECT s.attendanceID, s.StudentNumber, s.fName, s.mName, s.lName, s.janPres, s.janTardy, s.febPres, s.febTardy, s.marPres, s.marTardy, s.aprPres, s.aprTardy, s.mayPres, s.mayTardy, s.junPres, s.junTardy, s.julPres, s.julTardy, s.augPres, s.augTardy, s.sepPres, s.sepTardy, s.octPres, s.octTardy, s.novPres, s.novTardy, s.decPres, s.decTardy, s.YearLevel, s.studeSection, s.SY, c.jan, c.feb, c.mar, c.apr, c.may, c.jun, c.jul, c.aug, c.sep, c.oct, c.nov, c.december FROM stude_attendance s join classdays c on s.SY=c.SY where s.StudentNumber='" & dg1.Item(1, x).Value & "' and s.SY='" & frmRegistrar.stSY.Text & "'"
                    conn.Open()
                    Dim mysDA As New MySqlDataAdapter(str, conn)
                    Dim mysDA1 As New MySqlDataAdapter(str1, conn)

                    Dim mysds As New DataSet
                    Dim mysds1 As New DataSet

                    mysDA.Fill(mysds, "p.studeprofile, g.grades, ss.semesterstude")
                    mysDA1.Fill(mysds1, "stude_attendance, classdays")

                    Dim obj As New ReportCardSHS2
                    obj.SetDataSource(mysds.Tables("p.studeprofile, g.grades, ss.semesterstude"))
                    obj.Subreports.Item("StudentsAttendance.rpt").SetDataSource(mysds1.Tables("stude_attendance, classdays"))
                    frmRegistrar.crViewer.ReportSource = obj
                    frmRegistrar.crViewer.Refresh()
                    conn.Close()
                    PrintDialog1.AllowSomePages = True
                    obj.PrintToPrinter(PrintDialog1.PrinterSettings.Copies, True, PrintDialog1.PrinterSettings.FromPage, PrintDialog1.PrinterSettings.ToPage)
                Next
            Else
                For x As Integer = 0 To dg1.Rows.Count - 1

                    Dim MapehAve, SubAve, SubjCount As Double

                    ' Calculate MapehAve
                    conn.Open()
                    MapehAve = ExecuteScalar("SELECT AVG(Average) FROM grades WHERE (Description LIKE '%mapeh%' OR Description LIKE '%Music%') and StudentNumber='" & dg1.Item(1, x).Value & "' and Sem='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "'")

                    ' Calculate SubAve
                    SubAve = ExecuteScalar("SELECT SUM(Average) FROM grades WHERE Description NOT LIKE '%mapeh%' AND Description NOT LIKE '%Music%' and StudentNumber='" & dg1.Item(1, x).Value & "' and Sem='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "'")

                    ' Calculate SubjCount
                    SubjCount = ExecuteScalar("SELECT COUNT(DISTINCT Description) FROM grades WHERE StudentNumber='" & dg1.Item(1, x).Value & "' and Sem='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "'")


                    Dim TotalAve, GeneralAve, FinalAve As Double
                    TotalAve = Val(SubAve) + Val(MapehAve)
                    GeneralAve = If(SubjCount <> 0, TotalAve / SubjCount, 0)
                    FinalAve = Math.Round(GeneralAve)

                    conn.Close()

                    str = "select p.StudentNumber, LRN, concat(p.LastName,', ',p.FirstName,' ',p.MiddleName) as StudeName, p.Sex, p.BirthDate, p.Age, p.BirthPlace, p.Guardian, ss.Course, g.YearLevel, g.Adviser, ss.Section, g.Track, g.strand, g.Description, g.PGrade, g.MGrade, g.PFinalGrade, g.FGrade, g.Average, g.Sem, g.SY, g.subComponent, sr.SchoolName, sr.SchoolAddress, sr.SchoolHead, sr.sHeadPosition,sr.Division,sr.Region, sr.letterHead, sr.depedlogo, sr.schoolLogo, sr.district, sr.principalPre, sr.principalGS, sr.principalJHS, sr.principalSHS from studeprofile p join semesterstude ss on p.StudentNumber=ss.StudentNumber join grades g on ss.StudentNumber=g.StudentNumber join srms_settings sr on ss.settingsID=sr.settingsID where p.StudentNumber='" & dg1.Item(1, x).Value & "' and ss.SY='" & frmRegistrar.stSY.Text & "' and ss.Semester='" & frmRegistrar.stSemester.Text & "' and g.SY='" & frmRegistrar.stSY.Text & "' and g.Sem='" & frmRegistrar.stSemester.Text & "' order by g.SubjectCode"
                    str1 = "SELECT s.attendanceID, s.StudentNumber, s.fName, s.mName, s.lName, s.janPres, s.janTardy, s.febPres, s.febTardy, s.marPres, s.marTardy, s.aprPres, s.aprTardy, s.mayPres, s.mayTardy, s.junPres, s.junTardy, s.julPres, s.julTardy, s.augPres, s.augTardy, s.sepPres, s.sepTardy, s.octPres, s.octTardy, s.novPres, s.novTardy, s.decPres, s.decTardy, s.YearLevel, s.studeSection, s.SY, c.jan, c.feb, c.mar, c.apr, c.may, c.jun, c.jul, c.aug, c.sep, c.oct, c.nov, c.december FROM stude_attendance s join classdays c on s.SY=c.SY where s.StudentNumber='" & dg1.Item(1, x).Value & "' and s.SY='" & frmRegistrar.stSY.Text & "'"

                    conn.Open()
                    Dim mysDA As New MySqlDataAdapter(str, conn)
                    Dim mysDA1 As New MySqlDataAdapter(str1, conn)

                    Dim mysds As New DataSet
                    Dim mysds1 As New DataSet

                    mysDA.Fill(mysds, "p.studeprofile, g.grades, ss.semesterstude")
                    mysDA1.Fill(mysds1, "stude_attendance, classdays")
                    Dim obj As New ReportCard
                    obj.SetDataSource(mysds.Tables("p.studeprofile, g.grades, ss.semesterstude"))
                    obj.Subreports.Item("StudentsAttendance.rpt").SetDataSource(mysds1.Tables("stude_attendance, classdays"))
                    obj.SetParameterValue("GenAve", FinalAve)
                    frmRegistrar.crViewer.ReportSource = obj
                    frmRegistrar.crViewer.Refresh()
                    conn.Close()
                    PrintDialog1.AllowSomePages = True
                    obj.PrintToPrinter(PrintDialog1.PrinterSettings.Copies, True, PrintDialog1.PrinterSettings.FromPage, PrintDialog1.PrinterSettings.ToPage)
                Next
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class