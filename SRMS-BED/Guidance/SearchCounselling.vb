Imports MySql.Data.MySqlClient
Public Class frmSearchCounselling
    Dim str As String
    Private Sub frmSearchCounselling_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtSearch.Clear()
        Try
            str = "SELECT g.id, g.recordNo, g.recordDate, CONCAT(p.LastName,', ',p.FirstName,' ', p.MiddleName) AS FullName, p.FirstName, p.MiddleName, p.LastName, g.StudentNumber, g.details, g.actionPlan FROM guidance_counselling g join studeprofile p on g.StudentNumber=p.StudentNumber order by p.LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "guidance_counselling, studeprofile")
            dg1.DataSource = ds.Tables("guidance_counselling, studeprofile")
            conn.Close()


            dg1.Columns(0).Visible = False
            dg1.Columns(1).HeaderText = "Counselling No."
            dg1.Columns(1).Width = 200
            dg1.Columns(2).HeaderText = "Date"
            dg1.Columns(2).Width = 200
            dg1.Columns(3).HeaderText = "Student Name"
            dg1.Columns(3).Width = 200
            dg1.Columns(4).Visible = False
            dg1.Columns(5).Visible = False
            dg1.Columns(6).Visible = False
            dg1.Columns(7).HeaderText = "Student No."
            dg1.Columns(7).Width = 200
            dg1.Columns(8).Visible = False
            dg1.Columns(9).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "SELECT g.id, g.recordNo, g.recordDate, CONCAT(p.LastName,', ',p.FirstName,' ', p.MiddleName) AS FullName, p.FirstName, p.MiddleName, p.LastName, g.StudentNumber, g.details, g.actionPlan FROM guidance_counselling g join studeprofile p on g.StudentNumber=p.StudentNumber where g.StudentNumber like '%" & txtSearch.Text & "%' or p.LastName like '%" & txtSearch.Text & "%' order by p.LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "guidance_counselling, studeprofile")
            dg1.DataSource = ds.Tables("guidance_counselling, studeprofile")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).HeaderText = "Counselling No."
            dg1.Columns(1).Width = 200
            dg1.Columns(2).HeaderText = "Date"
            dg1.Columns(2).Width = 200
            dg1.Columns(3).HeaderText = "Student Name"
            dg1.Columns(3).Width = 200
            dg1.Columns(4).Visible = False
            dg1.Columns(5).Visible = False
            dg1.Columns(6).Visible = False
            dg1.Columns(7).HeaderText = "Student No."
            dg1.Columns(7).Width = 200
            dg1.Columns(8).Visible = False
            dg1.Columns(9).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Try
            Dim i As Integer
            i = dg1.CurrentRow.Index
            frmAddCounselling.lblID.Text = dg1(0, i).Value
            frmAddCounselling.txtCounsellingNo.Text = dg1(1, i).Value
            frmAddCounselling.dtpDate.Text = dg1(2, i).Value
            frmAddCounselling.txtFname.Text = dg1.Item(4, i).Value
            frmAddCounselling.txtMname.Text = dg1(5, i).Value
            frmAddCounselling.txtLname.Text = dg1(6, i).Value
            frmAddCounselling.txtStudenNumber.Text = dg1(7, i).Value
            frmAddCounselling.txtDetails.Text = dg1.Item(8, i).Value
            frmAddCounselling.txtActionTaken.Text = dg1(9, i).Value
          

            frmAddCounselling.tsSave.Enabled = False
            frmAddCounselling.tsUpdate.Enabled = True
            frmAddCounselling.tsDelete.Enabled = True
            frmAddCounselling.Button1.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

        Me.Close()
    End Sub
End Class