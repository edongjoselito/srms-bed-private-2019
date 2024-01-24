Imports MySql.Data.MySqlClient
Public Class SearchAccounts
    Dim str As String

    Private Sub SearchAccounts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        Try
            str = "SELECT s.StudentNumber, p.FirstName, p.MiddleName, p.LastName, s.Course, YearLevel, Section, Status FROM semesterstude s join studeprofile p on s.StudentNumber=p.StudentNumber where Semester = '" & frmAccounting.stSemester.Text & "' and SY = '" & frmAccounting.stSY.Text & "'"
            conn.Open()
            Dim mysDA As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysDA.Fill(ds, "semesterstude, studeprofile")
            dgstudentsearch.DataSource = ds.Tables("semesterstude, studeprofile")
            conn.Close()

            dgstudentsearch.Columns(0).HeaderText = "STUDENT NO."
            dgstudentsearch.Columns(1).HeaderText = "FIRST NAME"
            dgstudentsearch.Columns(2).HeaderText = "MIDDLE NAME"
            dgstudentsearch.Columns(3).HeaderText = "LAST NAME"
            dgstudentsearch.Columns(4).HeaderText = "DEPARTMENT"
            dgstudentsearch.Columns(5).HeaderText = "GRADE LEVEL"
            dgstudentsearch.Columns(6).HeaderText = "SECTION"
            dgstudentsearch.Columns(7).HeaderText = "STATUS"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

        frmBilling.btnOldAcct.Enabled = True
        frmBilling.tsSave.Enabled = True

    End Sub


    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgstudentsearch.DoubleClick
        Try
            Dim dclick As Integer
            dclick = dgstudentsearch.CurrentRow.Index
            frmBilling.mskStudentNumber.Text = dgstudentsearch.Item(0, dclick).Value
            frmBilling.txtFname.Text = dgstudentsearch.Item(1, dclick).Value
            frmBilling.txtMName.Text = dgstudentsearch.Item(2, dclick).Value
            frmBilling.txtLastName.Text = dgstudentsearch.Item(3, dclick).Value
            frmBilling.cboCourse.Text = dgstudentsearch.Item(4, dclick).Value
            frmBilling.cboYear.Text = dgstudentsearch.Item(5, dclick).Value
            frmBilling.txtSection.Text = dgstudentsearch.Item(6, dclick).Value
            frmBilling.cboStatus.Text = dgstudentsearch.Item(7, dclick).Value

            ' frmBilling.Show()
            frmBilling.LoadFees()


            Dim totalpayment As Double

            str = "select Amount from paymentsaccounts where StudentNumber='" & frmBilling.mskStudentNumber.Text & "' and SY='" & frmAccounting.stSY.Text & "' and ORStatus='Valid' and CollectionSource!='Services'"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            Dim mysDR As MySqlDataReader = mysC.ExecuteReader

            While mysDR.Read
                totalpayment += Val(mysDR(0))
            End While

            frmBilling.txtPayments.Text = Format(totalpayment, "00.00")
            mysDR.Close()
            conn.Close()



            frmBilling.tsSave.Enabled = True
            frmBilling.tsUpdate.Enabled = False
            frmBilling.btnOldAcct.Enabled = True

            '   frmBilling.CourseFees()

            frmBilling.btnCompute.PerformClick()
            frmBilling.btnOldAcct.PerformClick()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try


            str = "SELECT s.StudentNumber, p.FirstName, p.MiddleName, p.LastName, s.Course, YearLevel, Section, Status FROM semesterstude s join studeprofile p on s.StudentNumber=p.StudentNumber where LastName like '%" & txtSearch.Text & "%' or p.StudentNumber like '%" & txtSearch.Text & "%' and Semester='" & frmAccounting.stSemester.Text & "' and SY='" & frmAccounting.stSY.Text & "'"
            conn.Open()
            Dim Search As New MySqlDataAdapter(str, conn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "semesterstude, studeprofile")
            dgstudentsearch.DataSource = ds.Tables("semesterstude, studeprofile")
            conn.Close()

            dgstudentsearch.Columns(0).HeaderText = "STUDENT NO."
            dgstudentsearch.Columns(1).HeaderText = "FIRST NAME"
            dgstudentsearch.Columns(2).HeaderText = "MIDDLE NAME"
            dgstudentsearch.Columns(3).HeaderText = "LAST NAME"
            dgstudentsearch.Columns(4).HeaderText = "DEPARTMENT"
            dgstudentsearch.Columns(5).HeaderText = "GRADE LEVEL"
            dgstudentsearch.Columns(6).HeaderText = "SECTION"
            dgstudentsearch.Columns(7).HeaderText = "STATUS"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class