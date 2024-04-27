Imports MySql.Data.MySqlClient
Public Class frmCOR
    Dim str As String

    Private Sub frmAddStudent_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddStudent.Click
        lvCOR.Items.Clear()
        frmSearchSemesterStudent.ShowDialog()
    End Sub

    Private Sub btnAddSubject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSubject.Click
        frmSearchSemSubjects.ShowDialog()
    End Sub

    Private Sub btnRemoveSubjects_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveSubjects.Click
        Try
            Dim i As Integer

            lvCOR.Select()

            If lvCOR.Items.Count = 0 Then
                MsgBox("Cannot find subject(s) to remove", MsgBoxStyle.Exclamation, "Prompt")
                Exit Sub
            Else
                i = lvCOR.FocusedItem.Index
                lvCOR.Items.RemoveAt(i)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub frmCOR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormLoad()
    End Sub
    Public Sub FormLoad()
        Try
            ' lvCOR.Items.Clear()
            Me.lvCOR.Columns.Add("Subject Code", 90)
            Me.lvCOR.Columns.Add("Description", 200)
            Me.lvCOR.Columns.Add("Class Schedules", 200)
            Me.lvCOR.Columns.Add("Room", 50)
            Me.lvCOR.Columns.Add("Section", 90)
            Me.lvCOR.Columns.Add("IDNumber", 0)
            Me.lvCOR.Columns.Add("Teacher", 200)

            Me.lvCOR.View = View.Details
            Me.lvCOR.GridLines = True

            mskStudentNumber.Clear()
            txtFirstName.Clear()
            txtMiddleName.Clear()
            txtLastName.Clear()
            txtCourse.Clear()
            txtYearLevel.Clear()

            btnAddSubject.Enabled = False
            btnRemoveSubjects.Enabled = False

            tsSave.Enabled = False
            tsSave.Text = "SAVE"
            tsUpdate.Enabled = False
            tsDelete.Enabled = False


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
    Public Sub LoadSubjects()
        Try
            If txtCourse.Text = "Senior High School" Then

                Dim dt As New DataTable
                str = "SELECT s.SubjectCode, s.Description, s.SchedTime, s.Room, s.Section, s.IDNumber, concat(FirstName,' ',MiddleName,' ',LastName) as Teacher FROM semsubjects s join staff ff on s.IDNumber=ff.IDNumber where Course='" & txtCourse.Text & "' and YearLevel='" & txtYearLevel.Text & "' and Semester='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "' and Section='" & lblSection.Text & "'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                mysda.Fill(dt)
                Dim newrow As DataRow
                For Each newrow In dt.Rows
                    lvCOR.Items.Add(newrow.Item(0))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(1))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(2))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(3))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(4))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(5))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(6))

                Next
                conn.Close()
            Else
                Dim dt As New DataTable
                str = "SELECT s.SubjectCode, s.Description, s.SchedTime, s.Room, s.Section, s.IDNumber, concat(FirstName,' ',MiddleName,' ',LastName) as Teacher FROM semsubjects s join staff ff on s.IDNumber=ff.IDNumber where Course='" & txtCourse.Text & "' and YearLevel='" & txtYearLevel.Text & "' and Semester='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "' and Section='" & lblSection.Text & "'"
                conn.Open()
                Dim mysda As New MySqlDataAdapter(str, conn)
                mysda.Fill(dt)
                Dim newrow As DataRow
                For Each newrow In dt.Rows
                    lvCOR.Items.Add(newrow.Item(0))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(1))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(2))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(3))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(4))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(5))
                    lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(6))
                Next
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub mskStudentNumber_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskStudentNumber.Click
        'frmSearchSemesterStudent.ShowDialog()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsFind.Click
        lvCOR.Items.Clear()
        frmSearchCOR.ShowDialog()
    End Sub

    Private Sub tsSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSave.Click
        Try
            If mskStudentNumber.Text = "" Or lvCOR.Items.Count = 0 Then
                MsgBox("Cannot save data! Add Student and subject first before saving!", MsgBoxStyle.Exclamation)
                mskStudentNumber.Focus()
                Exit Sub
            End If

            str = "select * from registration where StudentNumber='" & mskStudentNumber.Text & "' and SY='" & frmRegistrar.stSY.Text & "' and Sem='" & frmRegistrar.stSemester.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New Data.DataSet

            mysda.Fill(ds, "registration")

            If ds.Tables("registration").Rows.Count >= 1 Then
                MsgBox("This student has already been advised.", MsgBoxStyle.Exclamation)
                conn.Close()
                Exit Sub
            End If
            conn.Close()

            For i As Integer = 0 To lvCOR.Items.Count - 1

                str = "insert into registration (SubjectCode, Description, Section, SchedTime, Room, Instructor, Sem, SY, StudentNumber, Course, YearLevel, settingsID) values('" & lvCOR.Items(i).SubItems(0).Text & "','" & lvCOR.Items(i).SubItems(1).Text & "','" & lvCOR.Items(i).SubItems(4).Text & "','" & lvCOR.Items(i).SubItems(2).Text & "','" & lvCOR.Items(i).SubItems(3).Text & "','" & lvCOR.Items(i).SubItems(6).Text & "','" & frmRegistrar.stSemester.Text & "','" & frmRegistrar.stSY.Text & "','" & mskStudentNumber.Text & "','" & txtCourse.Text & "','" & txtYearLevel.Text & "','" & frmRegistrar.lblSettingsID.Text & "')"
                conn.Open()
                Dim mysC As New MySqlCommand(str, conn)
                mysC.ExecuteNonQuery()

                conn.Close()
            Next
            MsgBox("Registration has been processed successfully!", MsgBoxStyle.Information)
            lvCOR.Items.Clear()
            FormLoad()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub tsUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            str = "delete from registration where StudentNumber='" & mskStudentNumber.Text & "' and SY='" & frmRegistrar.stSY.Text & "' and Sem='" & frmRegistrar.stSemester.Text & "'"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.ExecuteNonQuery()
            conn.Close()
            tsSave.PerformClick()
            lvCOR.Items.Clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub tsClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsClear.Click
        lvCOR.Items.Clear()
        mskStudentNumber.Clear()
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtLastName.Clear()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        tsSave.PerformClick()
    End Sub

    Private Sub SearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripMenuItem.Click
        tsFind.PerformClick()
    End Sub

    Private Sub AddStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddStudentToolStripMenuItem.Click
        btnAddStudent.PerformClick()
    End Sub

    Private Sub AddSubjectsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSubjectsToolStripMenuItem.Click
        btnAddSubject.PerformClick()
    End Sub
    Private Sub tsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record from the registration?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from registration where StudentNumber='" & mskStudentNumber.Text & "' and Sem='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                MsgBox("Selected record has been deleted", MsgBoxStyle.Information)
                conn.Close()
                FormLoad()
                lvCOR.Items.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
    Public Sub loadEnrolledSubjects()
        Try
            Dim dt As New DataTable
            str = "SELECT SubjectCode, Description, SchedTime, Room, Section, Instructor FROM registration where Sem='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "' and StudentNumber='" & mskStudentNumber.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            mysda.Fill(dt)
            Dim newrow As DataRow
            For Each newrow In dt.Rows
                lvCOR.Items.Add(newrow.Item(0))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(1))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(2))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(3))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(4))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(5))
                lvCOR.Items(lvCOR.Items.Count - 1).SubItems.Add(newrow.Item(5))
            Next

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub tsUpdate_Click_1(sender As Object, e As EventArgs) Handles tsUpdate.Click
        Try
            str = "delete from registration where StudentNumber='" & mskStudentNumber.Text & "' and SY='" & frmRegistrar.stSY.Text & "' and Sem='" & frmRegistrar.stSemester.Text & "'"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.ExecuteNonQuery()
            conn.Close()
            tsSave.PerformClick()
            ' lvCOR.Items.Clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class