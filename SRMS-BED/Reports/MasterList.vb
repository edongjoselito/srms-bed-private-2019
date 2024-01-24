Imports MySql.Data.MySqlClient
Public Class frmMasterList
    Dim str As String
    Private Sub btnMasterlist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMasterlist.Click
        Try
            If txtsubjectcode.Text = "" Or txtSection.Text = "" Or txtInstructor.Text = "'" Then
                MsgBox("All fields are required.  Please fill it up completely!", MsgBoxStyle.Information)
                txtsubjectcode.Focus()
                Exit Sub
            End If

            str = "SELECT p.StudentNumber, LastName, FirstName, MiddleName, Sex, r.Course, YearLevel, SubjectCode, Description, Section, SchedTime, Instructor, Sem, SY, letterHead FROM registration r join studeprofile p on r.StudentNumber=p.StudentNumber join srms_settings st on r.settingsID=st.settingsID where r.SubjectCode='" & txtsubjectcode.Text & "' and r.Description='" & txtDescription.Text & "' and r.Section='" & txtSection.Text & "' and r.Sem='" & frmRegistrar.stSemester.Text & "' and r.SY='" & frmRegistrar.stSY.Text & "' order by p.LastName"
            conn.Open()
            Dim mysda As New MySqlDataAdapter(Str, conn)
            Dim mysds As New Data.DataSet
            mysda.Fill(mysds, "registration, srms_settings")
            Dim obj As New Class_List
            obj.SetDataSource(mysds.Tables("registration, srms_settings"))
            frmRegistrar.crViewer.ReportSource = obj
            conn.Close()
            frmRegistrar.crViewer.Visible = True

            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            conn.Close()
        End Try
    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSelectSubject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectSubject.Click
        frmSelectSubject_Masterlist.ShowDialog()
    End Sub

    Private Sub txtsubjectcode_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsubjectcode.Click
        frmSelectSubject_Masterlist.ShowDialog()
    End Sub
End Class