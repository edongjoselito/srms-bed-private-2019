Imports MySql.Data.MySqlClient
Public Class frmClassDays
    Dim str As String
    Private Sub frmClassDays_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formload()
        daysload()
    End Sub
    Public Sub formload()
        Try

            str = "select * from classdays where Semester='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "'"
        conn.Open()
        Dim mysda As New MySqlDataAdapter(str, conn)
        Dim ds As New DataSet
        mysda.Fill(ds, "classdays")

            If ds.Tables("classdays").Rows.Count = 1 Then
                btnSave.Enabled = False
                btnUpdate.Enabled = True
                conn.Close()
            Else
                btnSave.Enabled = True
                btnUpdate.Enabled = False
                conn.Close()
            End If

            conn.Close()


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
    Public Sub daysload()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "SELECT jan, feb, mar, apr, may, jun, jul, aug, sep, oct, nov, december FROM classdays WHERE Semester='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSemester.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                txtJan.Text = dtReader.Item(0)
                txtFeb.Text = dtReader.Item(1)
                txtMar.Text = dtReader.Item(2)
                txtApr.Text = dtReader.Item(3)
                txtMay.Text = dtReader.Item(4)
                txtJun.Text = dtReader.Item(5)
                txtJul.Text = dtReader.Item(6)
                txtAug.Text = dtReader.Item(7)
                txtSep.Text = dtReader.Item(8)
                txtOct.Text = dtReader.Item(9)
                txtNov.Text = dtReader.Item(10)
                txtDec.Text = dtReader.Item(11)
            Else
                txtJan.Text = 0
                txtFeb.Text = 0
                txtMar.Text = 0
                txtApr.Text = 0
                txtMay.Text = 0
                txtJun.Text = 0
                txtJul.Text = 0
                txtAug.Text = 0
                txtSep.Text = 0
                txtOct.Text = 0
                txtNov.Text = 0
                txtDec.Text = 0


            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            str = "insert into classdays values(0,'1','" & txtJan.Text & "','" & txtFeb.Text & "','" & txtMar.Text & "','" & txtApr.Text & "','" & txtMay.Text & "','" & txtJun.Text & "','" & txtJul.Text & "','" & txtAug.Text & "','" & txtSep.Text & "','" & txtOct.Text & "','" & txtNov.Text & "','" & txtDec.Text & "','" & frmRegistrar.stSemester.Text & "','" & frmRegistrar.stSY.Text & "')"
            conn.Open()
            Dim mysc As New MySqlCommand(str, conn)
            mysc.ExecuteNonQuery()
            conn.Close()



            MsgBox("Class days saved successfully.", MsgBoxStyle.Information)
            formload()
            daysload()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try

            str = "update classdays set jan='" & txtJan.Text & "',feb='" & txtFeb.Text & "',mar='" & txtMar.Text & "',apr='" & txtApr.Text & "',may='" & txtMay.Text & "',jun='" & txtJun.Text & "',jul='" & txtJul.Text & "',aug='" & txtAug.Text & "',sep='" & txtSep.Text & "',oct='" & txtOct.Text & "',nov='" & txtNov.Text & "',december='" & txtDec.Text & "' where Semester='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "'"
            conn.Open()
            Dim mysC As New MySqlCommand(str, conn)
            mysC.ExecuteNonQuery()
            conn.Close()




            'Audit Trail
            str = "insert into atrail values('0','Update class days','" & Convert.ToDateTime(frmRegistrar.stDate.Text).ToString("yyyy-MM-dd") & "','" & frmRegistrar.stTime.Text & "','" & frmRegistrar.stUser.Text & "','" & frmRegistrar.stSY.Text & "')"
            conn.Open()
            Dim mysc1 As New MySqlCommand(str, conn)
            mysc1.ExecuteNonQuery()
            conn.Close()

           
            MsgBox("Class days updated successfully.", MsgBoxStyle.Information)

            formload()
            daysload()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub
End Class