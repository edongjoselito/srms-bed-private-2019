Imports MySql.Data.MySqlClient
Public Class frmTrack
    Dim str As String
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Public Sub getTrack()
        Try
            str = "select * from track_strand order by track"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(Str, conn)
            Dim ds As New Data.DataSet
            mysda.Fill(ds, "track_strand")
            dg1.DataSource = ds.Tables("track_strand")
            conn.Close()
            dg1.Columns(0).Visible = False
            dg1.Columns(1).HeaderText = "Track"
            dg1.Columns(1).Width = 300
            dg1.Columns(2).HeaderText = "Strand"
            dg1.Columns(2).Width = 300

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Public Sub formLoad()
        txtTrack.Focus()
        txtTrack.Clear()
        txtStrand.Clear()

        btnDelete.Visible = False
        btnCancel.Visible = False
        btnSave.Enabled = True
        btnSave.Text = "SAVE"

        getTrack()
    End Sub

    Private Sub frmTrack_Load(sender As Object, e As EventArgs) Handles Me.Load
        formLoad()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        formLoad()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Save()
    End Sub
    Public Sub Save()
        Try
            If txtTrack.Text = "" Then
                MsgBox("Track is required.", MsgBoxStyle.Exclamation)
                txtTrack.Focus()
                Exit Sub
            End If

            If txtStrand.Text = "" Then
                MsgBox("Strand is required.", MsgBoxStyle.Exclamation)
                txtStrand.Focus()
                Exit Sub
            End If

            If btnSave.Text = "SAVE" Then
                str = "insert into track_strand  (track, strand) values('" & txtTrack.Text & "','" & txtStrand.Text & "')"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()
                MsgBox("Added successfully!", MsgBoxStyle.Information)
                formLoad()
            Else
                str = "update track_strand  set track='" & txtTrack.Text & "',strand='" & txtStrand.Text & "' where trackID='" & lblID.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()
                MsgBox("Updated successfully!", MsgBoxStyle.Information)
                formLoad()
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub



    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If (MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                str = "delete from track_strand where trackID='" & lblID.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()
                MsgBox("1 record deleted!", MsgBoxStyle.Information)
                formLoad()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub dg1_DoubleClick(sender As Object, e As EventArgs) Handles dg1.DoubleClick
        Try
            Dim i As Integer
            i = dg1.CurrentRow.Index
            lblID.Text = dg1.Item(0, i).Value
            txtTrack.Text = dg1.Item(1, i).Value
            txtStrand.Text = dg1.Item(2, i).Value

            btnCancel.Visible = True
            btnDelete.Visible = True
            btnSave.Text = "Update"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class