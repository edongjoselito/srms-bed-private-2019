Imports MySql.Data.MySqlClient
Public Class frmRoomSched
    Dim str As String
    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        Try
            'str = "select SubjectCode, Description, Room, concat(SchedTime, ' ', LabTime) as SchedTime, Instructor, Sem, SY from registration where Room='" & cboRoom.Text & "' and Sem='" & frmParent.lblSem.Text & "' and SY='" & frmParent.lblSY.Text & "' group by SchedTime, Section"
            str = "select * from semsubjects where Room='" & cboRoom.Text & "' and Semester='" & frmReportsDashboard.stSemester.Text & "' and SY='" & frmReportsDashboard.stSY.Text & "' order by SubjectCode"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(Str, conn)
            Dim ds As New DataSet
            mysda.Fill(ds, "semsubjects")
            Dim obj As New RoomsSched
            obj.SetDataSource(ds.Tables("semsubjects"))
            frmReportsDashboard.crViewer.ReportSource = obj
            frmReportsDashboard.crViewer.Visible = True
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub

    Private Sub frmRoomSched_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getRooms()
    End Sub

    Public Sub getRooms()
        Try
            str = "select * from rooms group by Room order by Room"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(str, conn)
            Dim ds As New Data.DataSet
            mysda.Fill(ds, "rooms")
            conn.Close()
            cboRoom.ValueMember = "rooms"
            cboRoom.DisplayMember = "Room"
            cboRoom.DataSource = ds.Tables("rooms")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class