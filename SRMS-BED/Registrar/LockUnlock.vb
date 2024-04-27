Imports MySql.Data.MySqlClient
Public Class frmLockUnlock
    Dim str As String
    Public Sub getStatus()
        Try
            Dim objCmd As MySql.Data.MySqlClient.MySqlCommand
            str = "select firstStat, secondStat, thirdStat, fourthStat from grades where Sem='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "'"
            conn.Open()
            Dim dtReader As MySql.Data.MySqlClient.MySqlDataReader
            objCmd = New MySql.Data.MySqlClient.MySqlCommand(str, conn)
            dtReader = objCmd.ExecuteReader()
            If dtReader.Read Then
                If dtReader.Item(0) = "Closed" Then
                    btnFirst.Text = "UNLOCK FIRST GRADING"
                Else
                    btnFirst.Text = "LOCK FIRST GRADING"
                End If

                If dtReader.Item(1) = "Closed" Then
                    btnSecond.Text = "UNLOCK SECOND GRADING"
                Else
                    btnSecond.Text = "LOCK SECOND GRADING"
                End If

                If dtReader.Item(2) = "Closed" Then
                    btnThird.Text = "UNLOCK THIRD GRADING"
                Else
                    btnThird.Text = "LOCK THIRD GRADING"
                End If

                If dtReader.Item(3) = "Closed" Then
                    btnFourth.Text = "UNLOCK FOURTH GRADING"
                Else
                    btnFourth.Text = "LOCK FOURTH GRADING"
                End If

                If dtReader.Item(0) = "Closed" And dtReader.Item(1) = "Closed" And dtReader.Item(2) = "Closed" And dtReader.Item(3) = "Closed" Then
                    btnStatus.Text = "UNLOCK ALL GRADES"
                Else
                    btnStatus.Text = "LOCK ALL GRADES"
                End If

            End If
            conn.Close()

            'str = "select * from grades where Sem='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "'"
            'conn.Open()
            'Dim mysda As New MySqlDataAdapter(str, conn)
            'Dim ds As New DataSet
            'mysda.Fill(ds, "grades")

            'cboStatus.ValueMember = "grades"
            'cboStatus.DisplayMember = "firstStat"
            'cboStatus.DataSource = ds.Tables("grades")
            'conn.Close()



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnStatus_Click(sender As Object, e As EventArgs) Handles btnStatus.Click
        Try
            If btnStatus.Text = "LOCK ALL GRADES" Then
                str = "update grades set firstStat='Closed', SecondStat='Closed', thirdStat='Closed', fourthStat='Closed' where Sem='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()

                'Audit Trail
                str = "insert into atrail values('0','Lock All Grades','" & Convert.ToDateTime(frmRegistrar.stDate.Text).ToString("yyyy-MM-dd") & "','" & frmRegistrar.stTime.Text & "','" & frmRegistrar.stUser.Text & "','')"
                conn.Open()
                Dim mysc1 As New MySqlCommand(str, conn)
                mysc1.ExecuteNonQuery()
                conn.Close()

                MsgBox("Updated successfully!", MsgBoxStyle.Information)

                getStatus()

                btnStatus.Text = "UNLOCK ALL GRADES"
            Else
                str = "update grades set firstStat='Open', SecondStat='Open', thirdStat='Open', fourthStat='Open' where Sem='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()

                'Audit Trail
                str = "insert into atrail values('0','Unlock All Grades','" & Convert.ToDateTime(frmRegistrar.stDate.Text).ToString("yyyy-MM-dd") & "','" & frmRegistrar.stTime.Text & "','" & frmRegistrar.stUser.Text & "','')"
                conn.Open()
                Dim mysc1 As New MySqlCommand(str, conn)
                mysc1.ExecuteNonQuery()
                conn.Close()

                MsgBox("Updated successfully!", MsgBoxStyle.Information)

                getStatus()
                btnStatus.Text = "LOCK ALL GRADES"
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub frmLockUnlock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getStatus()
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        Try
            If btnFirst.Text = "LOCK FIRST GRADING" Then
                str = "update grades set firstStat='Closed' where Sem='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()

                'Audit Trail
                str = "insert into atrail values('0','Lock First Grading','" & Convert.ToDateTime(frmRegistrar.stDate.Text).ToString("yyyy-MM-dd") & "','" & frmRegistrar.stTime.Text & "','" & frmRegistrar.stUser.Text & "','')"
                conn.Open()
                Dim mysc1 As New MySqlCommand(str, conn)
                mysc1.ExecuteNonQuery()
                conn.Close()

                MsgBox("Updated successfully!", MsgBoxStyle.Information)

                getStatus()


            Else
                str = "update grades set firstStat='Open' where Sem='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()

                'Audit Trail
                str = "insert into atrail values('0','Unlock First Grading','" & Convert.ToDateTime(frmRegistrar.stDate.Text).ToString("yyyy-MM-dd") & "','" & frmRegistrar.stTime.Text & "','" & frmRegistrar.stUser.Text & "','')"
                conn.Open()
                Dim mysc1 As New MySqlCommand(str, conn)
                mysc1.ExecuteNonQuery()
                conn.Close()

                MsgBox("Updated successfully!", MsgBoxStyle.Information)

                getStatus()

            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnSecond_Click(sender As Object, e As EventArgs) Handles btnSecond.Click
        Try
            If btnSecond.Text = "LOCK SECOND GRADING" Then
                str = "update grades set secondStat='Closed' where Sem='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()

                'Audit Trail
                str = "insert into atrail values('0','Lock Second Grading','" & Convert.ToDateTime(frmRegistrar.stDate.Text).ToString("yyyy-MM-dd") & "','" & frmRegistrar.stTime.Text & "','" & frmRegistrar.stUser.Text & "','')"
                conn.Open()
                Dim mysc1 As New MySqlCommand(str, conn)
                mysc1.ExecuteNonQuery()
                conn.Close()

                MsgBox("Updated successfully!", MsgBoxStyle.Information)

                getStatus()


            Else
                str = "update grades set secondStat='Open' where Sem='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()

                'Audit Trail
                str = "insert into atrail values('0','Unlock Second Grading','" & Convert.ToDateTime(frmRegistrar.stDate.Text).ToString("yyyy-MM-dd") & "','" & frmRegistrar.stTime.Text & "','" & frmRegistrar.stUser.Text & "','')"
                conn.Open()
                Dim mysc1 As New MySqlCommand(str, conn)
                mysc1.ExecuteNonQuery()
                conn.Close()

                MsgBox("Updated successfully!", MsgBoxStyle.Information)

                getStatus()

            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnThird_Click(sender As Object, e As EventArgs) Handles btnThird.Click
        Try
            If btnThird.Text = "LOCK THIRD GRADING" Then
                str = "update grades set thirdStat='Closed' where Sem='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()

                'Audit Trail
                str = "insert into atrail values('0','Lock Third Grading','" & Convert.ToDateTime(frmRegistrar.stDate.Text).ToString("yyyy-MM-dd") & "','" & frmRegistrar.stTime.Text & "','" & frmRegistrar.stUser.Text & "','')"
                conn.Open()
                Dim mysc1 As New MySqlCommand(str, conn)
                mysc1.ExecuteNonQuery()
                conn.Close()

                MsgBox("Updated successfully!", MsgBoxStyle.Information)

                getStatus()


            Else
                str = "update grades set thirdStat='Open' where Sem='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()

                'Audit Trail
                str = "insert into atrail values('0','Unlock Third Grading','" & Convert.ToDateTime(frmRegistrar.stDate.Text).ToString("yyyy-MM-dd") & "','" & frmRegistrar.stTime.Text & "','" & frmRegistrar.stUser.Text & "','')"
                conn.Open()
                Dim mysc1 As New MySqlCommand(str, conn)
                mysc1.ExecuteNonQuery()
                conn.Close()

                MsgBox("Updated successfully!", MsgBoxStyle.Information)

                getStatus()

            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub

    Private Sub btnFourth_Click(sender As Object, e As EventArgs) Handles btnFourth.Click
        Try
            If btnFourth.Text = "LOCK FOURTH GRADING" Then
                str = "update grades set fourthStat='Closed' where Sem='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()

                'Audit Trail
                str = "insert into atrail values('0','Lock Fourth Grading','" & Convert.ToDateTime(frmRegistrar.stDate.Text).ToString("yyyy-MM-dd") & "','" & frmRegistrar.stTime.Text & "','" & frmRegistrar.stUser.Text & "','')"
                conn.Open()
                Dim mysc1 As New MySqlCommand(str, conn)
                mysc1.ExecuteNonQuery()
                conn.Close()

                MsgBox("Updated successfully!", MsgBoxStyle.Information)

                getStatus()


            Else
                str = "update grades set fourthStat='Open' where Sem='" & frmRegistrar.stSemester.Text & "' and SY='" & frmRegistrar.stSY.Text & "'"
                conn.Open()
                Dim mysc As New MySqlCommand(str, conn)
                mysc.ExecuteNonQuery()
                conn.Close()

                'Audit Trail
                str = "insert into atrail values('0','Unlock Fourth Grading','" & Convert.ToDateTime(frmRegistrar.stDate.Text).ToString("yyyy-MM-dd") & "','" & frmRegistrar.stTime.Text & "','" & frmRegistrar.stUser.Text & "','')"
                conn.Open()
                Dim mysc1 As New MySqlCommand(str, conn)
                mysc1.ExecuteNonQuery()
                conn.Close()

                MsgBox("Updated successfully!", MsgBoxStyle.Information)

                getStatus()

            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            conn.Close()
        End Try
    End Sub
End Class