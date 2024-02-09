Imports MySql.Data.MySqlClient
Public Class frmSearchIncidents
    Dim str As String
    Private Sub frmSearchIncidents_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtSearch.Clear()
        Try
            str = "SELECT g.incID, CONCAT(p.LastName,', ',p.FirstName,' ', p.MiddleName) AS FullName, p.FirstName, p.MiddleName, p.LastName, g.StudentNumber, g.caseNo, g.incidentDate, g.incPlace, g.offenseLevel, g.offense, g.sanction, g.actionTaken, g.sem, g.sy FROM guidance_incidents g join studeprofile p on g.StudentNumber=p.StudentNumber order by p.LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "guidance_incidents, studeprofile")
            dg1.DataSource = ds.Tables("guidance_incidents, studeprofile")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).HeaderText = "Person Involved"
            dg1.Columns(1).Width = 200
            dg1.Columns(2).Visible = False
            dg1.Columns(3).Visible = False
            dg1.Columns(4).Visible = False
            dg1.Columns(5).HeaderText = "Student No."
            dg1.Columns(6).HeaderText = "Case No."
            dg1.Columns(7).HeaderText = "Date"
            dg1.Columns(8).HeaderText = "Place"
            dg1.Columns(9).HeaderText = "Offense Level"
            dg1.Columns(10).HeaderText = "Offense"
            dg1.Columns(11).HeaderText = "Sanction"
            dg1.Columns(12).HeaderText = "Action Taken"
            dg1.Columns(13).HeaderText = "Sem."
            dg1.Columns(14).HeaderText = "SY"
           
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            str = "SELECT g.incID, CONCAT(p.LastName,', ',p.FirstName,' ', p.MiddleName) AS FullName, p.FirstName, p.MiddleName, p.LastName, g.StudentNumber, g.caseNo, g.incidentDate, g.incPlace, g.offenseLevel, g.offense, g.sanction, g.actionTaken, g.sem, g.sy FROM guidance_incidents g join studeprofile p on g.StudentNumber=p.StudentNumber where g.StudentNumber like '%" & txtSearch.Text & "%' or p.LastName like '%" & txtSearch.Text & "%' order by p.LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "guidance_incidents, studeprofile")
            dg1.DataSource = ds.Tables("guidance_incidents, studeprofile")
            conn.Close()

            dg1.Columns(0).Visible = False
            dg1.Columns(1).HeaderText = "Person Involved"
            dg1.Columns(1).Width = 200
            dg1.Columns(2).Visible = False
            dg1.Columns(3).Visible = False
            dg1.Columns(4).Visible = False
            dg1.Columns(5).HeaderText = "Student No."
            dg1.Columns(6).HeaderText = "Case No."
            dg1.Columns(7).HeaderText = "Date"
            dg1.Columns(8).HeaderText = "Place"
            dg1.Columns(9).HeaderText = "Offense Level"
            dg1.Columns(10).HeaderText = "Offense"
            dg1.Columns(11).HeaderText = "Sanction"
            dg1.Columns(12).HeaderText = "Action Taken"
            dg1.Columns(13).HeaderText = "Sem."
            dg1.Columns(14).HeaderText = "SY"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg1.DoubleClick
        Try
            Dim i As Integer
            i = dg1.CurrentRow.Index
            frmAddIncidents.lblincID.Text = dg1(0, i).Value
            frmAddIncidents.txtFname.Text = dg1.Item(2, i).Value
            frmAddIncidents.txtMname.Text = dg1(3, i).Value
            frmAddIncidents.txtLname.Text = dg1(4, i).Value
            frmAddIncidents.txtStudenNumber.Text = dg1(5, i).Value
            frmAddIncidents.txtCaseNo.Text = dg1.Item(6, i).Value
            frmAddIncidents.dtpDate.Text = dg1(7, i).Value
            frmAddIncidents.txtPlace.Text = dg1(8, i).Value
            frmAddIncidents.cboOffenseLevel.Text = dg1(9, i).Value
            frmAddIncidents.txtOffense.Text = dg1(10, i).Value
            frmAddIncidents.txtSanction.Text = dg1.Item(11, i).Value
            frmAddIncidents.txtActionTaken.Text = dg1(12, i).Value
           

            frmAddIncidents.tsSave.Enabled = False
            frmAddIncidents.tsUpdate.Enabled = True
            frmAddIncidents.tsDelete.Enabled = True
            frmAddIncidents.Button1.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try

        Me.Close()
    End Sub
End Class