Imports MySql.Data.MySqlClient
Public Class frmStudeAccount
    Dim str As String
    
    Private Sub frmStudeAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getGradeLevel()

    End Sub

    Private Sub btnStudeAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudeAccount.Click
        Try
            If cboSection.Text = "" Then
                str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName) as Fullname, b.AcctTotal, b.TotalPayments, b.Discount, b.CurrentBalance, b.Course, b.YearLevel, b.Section, b.SY, st.letterHead  from studeprofile p join studeaccount b on p.StudentNumber=b.StudentNumber join srms_settings st on p.settingsID=st.settingsID where b.YearLevel='" & cboYearLevelAccount.Text & "' and b.Sem='" & frmAccounting.stSemester.Text & "' and b.SY='" & frmAccounting.stSY.Text & "' group by p.StudentNumber order by Fullname"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysda.Fill(mysds, "b.studeaccount, p.studeprofile")
                Dim obj As New StudeAccounts_All
                obj.SetDataSource(mysds.Tables("b.studeaccount, p.studeprofile"))
                frmAccounting.crViewer.ReportSource = obj
                conn.Close()
                frmAccounting.crViewer.Visible = True
                Me.Close()
            Else
                str = "select p.StudentNumber, concat(p.LastName,', ',p.FirstName) as Fullname, b.AcctTotal, b.TotalPayments, b.Discount, b.CurrentBalance, b.Course, b.YearLevel, b.Section, b.SY, st.letterHead  from studeprofile p join studeaccount b on p.StudentNumber=b.StudentNumber join srms_settings st on p.settingsID=st.settingsID where b.Section='" & cboSection.Text & "' and b.YearLevel='" & cboYearLevelAccount.Text & "' and b.Sem='" & frmAccounting.stSemester.Text & "' and b.SY='" & frmAccounting.stSY.Text & "' group by p.StudentNumber order by Fullname"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim mysds As New DataSet
                mysda.Fill(mysds, "b.studeaccount, p.studeprofile")
                Dim obj As New StudeAccounts
                obj.SetDataSource(mysds.Tables("b.studeaccount, p.studeprofile"))
                frmAccounting.crViewer.ReportSource = obj
                conn.Close()
                frmAccounting.crViewer.Visible = True
                Me.Close()
            End If
            

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Public Sub getGradeLevel()
        Try
            If frmAccounting.stSemester.Text = "First Semester" Or frmAccounting.stSemester.Text = "Second Semester" Then
                str = "select * from course_table where CourseDescription='Senior High School'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "course_table")
                conn.Close()

                cboYearLevelAccount.ValueMember = "course_table"
                cboYearLevelAccount.DisplayMember = "Major"
                cboYearLevelAccount.DataSource = ds.Tables("course_table")

            Else
                str = "select * from course_table where CourseDescription!='Senior High School'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                Dim ds As New DataSet
                mysda.Fill(ds, "course_table")
                conn.Close()

                cboYearLevelAccount.ValueMember = "course_table"
                cboYearLevelAccount.DisplayMember = "Major"
                cboYearLevelAccount.DataSource = ds.Tables("course_table")
            End If
           

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub cboCourseAccount_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        getGradeLevel()
    End Sub
    Public Sub getSection()
        str = "select * from sections where YearLevel='" & cboYearLevelAccount.Text & "'"
        conn.Open()
        Dim mysda As New MySqlDataAdapter(str, conn)
        Dim ds As New DataSet
        mysda.Fill(ds, "sections")
        conn.Close()

        cboSection.ValueMember = "sections"
        cboSection.DisplayMember = "Section"
        cboSection.DataSource = ds.Tables("sections")

    End Sub

    Private Sub cboYearLevelAccount_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboYearLevelAccount.SelectedIndexChanged
        getSection()
    End Sub
End Class