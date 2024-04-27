Imports MySql.Data.MySqlClient
Public Class frmSearchCOR
    Dim str As String


    Private Sub frmSearchCOR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "SELECT r.StudentNumber, p.FirstName, p.MiddleName, p.LastName, r.Course, r.YearLevel FROM registration r join studeprofile p on r.StudentNumber=p.StudentNumber where Sem='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "' group by r.StudentNumber"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim ds As New Data.DataSet
            mysDA.Fill(ds, "registration, studeprofile")
            dg1.DataSource = ds.Tables("registration, studeprofile")
            conn.Close()

            dg1.Columns(0).HeaderText = "STUDENT NUMBER"
            dg1.Columns(1).HeaderText = "FIRST NAME"
            dg1.Columns(2).HeaderText = "MIDDLE NAME"
            dg1.Columns(3).HeaderText = "LAST NAME"
            dg1.Columns(4).HeaderText = "DEPARTMENT"
            dg1.Columns(5).HeaderText = "GRADE LEVEL"


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "SELECT r.StudentNumber, p.FirstName, p.MiddleName, p.LastName, r.Course, r.YearLevel FROM registration r join studeprofile p on r.StudentNumber=p.StudentNumber where (r.StudentNumber like '%" & txtSearch.Text & "%' or p.LastName like '%" & txtSearch.Text & "%') and Sem='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "' group by r.StudentNumber"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim ds As New Data.DataSet
            mysDA.Fill(ds, "registration, studeprofile")
            dg1.DataSource = ds.Tables("registration, studeprofile")
            conn.Close()
            dg1.Columns(0).HeaderText = "STUDENT NUMBER"
            dg1.Columns(1).HeaderText = "FIRST NAME"
            dg1.Columns(2).HeaderText = "MIDDLE NAME"
            dg1.Columns(3).HeaderText = "LAST NAME"
            dg1.Columns(4).HeaderText = "DEPARTMENT"
            dg1.Columns(5).HeaderText = "GRADE LEVEL"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

    End Sub
    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick

        Dim currentrow As Integer
        currentrow = dg1.CurrentRow.Index
        frmCOR.mskStudentNumber.Text = dg1.Item(0, currentrow).Value
        frmCOR.txtFirstName.Text = dg1.Item(1, currentrow).Value
        frmCOR.txtMiddleName.Text = dg1.Item(2, currentrow).Value
        frmCOR.txtLastName.Text = dg1.Item(3, currentrow).Value
        frmCOR.txtCourse.Text = dg1.Item(4, currentrow).Value
        frmCOR.txtYearLevel.Text = dg1.Item(5, currentrow).Value


        frmCOR.tsSave.Enabled = True
        frmCOR.tsSave.Text = "SAVE"
        frmCOR.tsUpdate.Enabled = True
        frmCOR.tsDelete.Enabled = True
        frmCOR.btnAddSubject.Enabled = True
        frmCOR.btnRemoveSubjects.Enabled = True

        frmCOR.loadEnrolledSubjects()

        txtSearch.Clear()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class