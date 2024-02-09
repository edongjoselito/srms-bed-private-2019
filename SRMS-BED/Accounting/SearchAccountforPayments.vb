Imports MySql.Data.MySqlClient
Public Class frmSearchAccountforPayments
    Dim str As String
    Private Sub frmSearchAccountforPayments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "select p.StudentNumber, FirstName, MiddleName, LastName, ss.Course, ss.YearLevel from semesterstude ss join studeprofile p on ss.StudentNumber=p.StudentNumber where SY='" & frmAccounting.stSY.Text & "' and Semester='" & frmAccounting.stSemester.Text & "' order by StudentNumber Desc"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "semesterstude, studeprofile")
            dg1.DataSource = ds.Tables("semesterstude, studeprofile")
            conn.Close()

            dg1.Columns(0).HeaderText = "STUDENT NO."
            dg1.Columns(1).HeaderText = "FIRST NAME"
            dg1.Columns(2).HeaderText = "MIDDLE NAME"
            dg1.Columns(3).HeaderText = "LAST NAME"
            dg1.Columns(4).HeaderText = "DEPARTMENT"
            dg1.Columns(5).HeaderText = "GRADE LEVEL"


        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "select p.StudentNumber, FirstName, MiddleName, LastName, ss.Course, ss.YearLevel from semesterstude ss join studeprofile p on ss.StudentNumber=p.StudentNumber where LastName like '%" & txtSearch.Text & "%' and SY='" & frmAccounting.stSY.Text & "' and Semester='" & frmAccounting.stSemester.Text & "'"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "semesterstude, studeprofile")
            dg1.DataSource = ds.Tables("semesterstude, studeprofile")
            conn.Close()

            dg1.Columns(0).HeaderText = "STUDENT NO."
            dg1.Columns(1).HeaderText = "FIRST NAME"
            dg1.Columns(2).HeaderText = "MIDDLE NAME"
            dg1.Columns(3).HeaderText = "LAST NAME"
            dg1.Columns(4).HeaderText = "DEPARTMENT"
            dg1.Columns(5).HeaderText = "GRADE LEVEL"
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Try
            Dim i As Integer
            i = dg1.CurrentRow.Index
            frmPayment.mskStudentNumber.Text = dg1.Item(0, i).Value
            frmPayment.txtFname.Text = dg1.Item(1, i).Value
            frmPayment.txtMName.Text = dg1.Item(2, i).Value
            frmPayment.txtLastName.Text = dg1.Item(3, i).Value
            frmPayment.lblCourse.Text = dg1.Item(4, i).Value
            frmPayment.lblYearLevel.Text = dg1.Item(5, i).Value

            Dim totalpayment, totalAccount, Discount As Double
            'Get Total Payments
            str = "select Amount from paymentsaccounts where StudentNumber='" & frmPayment.mskStudentNumber.Text & "' and Sem='" & frmAccounting.stSemester.Text & "' and SY='" & frmAccounting.stSY.Text & "' and ORStatus='Valid' and CollectionSource!='Services'"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            Dim mysDR As MySqlDataReader = mysC.ExecuteReader

            While mysDR.Read
                totalpayment += Val(mysDR(0))
            End While

            frmPayment.txtCurrentPayments.Text = Format(totalpayment, "00.00")

            mysDR.Close()
            conn.Close()

            ' Get the Total Account
            str = "select * from studeaccount where StudentNumber='" & frmPayment.mskStudentNumber.Text & "' and Sem='" & frmAccounting.stSemester.Text & "' and SY='" & frmAccounting.stSY.Text & "' group by AcctTotal"
            conn.Open()
            Dim mysC2 As New MySqlCommand(str, conn)
            Dim mysDR2 As MySqlDataReader = mysC2.ExecuteReader

            While mysDR2.Read
                totalAccount = Val(mysDR2(10))
                Discount = Val(mysDR2(9))
            End While

            frmPayment.txtTotalAccts.Text = Format(totalAccount, "00.00")
            frmPayment.txtDiscount.Text = Format(Discount, "00.00")
            mysDR2.Close()
            conn.Close()

            frmPayment.CourseCode()
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class