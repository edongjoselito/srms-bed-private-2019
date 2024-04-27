Imports MySql.Data.MySqlClient
Module connection
    'Public conn As New MySqlConnection("database=wcmanilasrms_bed;" &
    '                                     "server =srms-db-new.ce0mhjgkvjuk.ap-southeast-2.rds.amazonaws.com;" &
    '                                     "user id = admin; password = wcm-softtech2024;")


    Public conn As New MySqlConnection("Database=wcmanilasrms_bed;" &
                                           "Server =localhost;" &
                                           "User ID = root; Password = moth34board;")
    ' "Server =srms-db-new.ce0mhjgkvjuk.ap-southeast-2.rds.amazonaws.com;" &
    '                                     "User ID = admin; Password = Wcm-softtech2024;")

    'New connection
    ' srms-db-new.ce0mhjgkvjuk.ap-southeast-2.rds.amazonaws.com
    ' admin
    ' Wcm-softtech2024

    Function getSHA1Hash(ByVal strToHash As String) As String
        Dim sha1Obj As New Security.Cryptography.SHA1CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)
        bytesToHash = sha1Obj.ComputeHash(bytesToHash)
        Dim strResult As String = ""
        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next
        Return strResult
    End Function

    Public Sub AddSemSubjects(ByVal ls As ListView, ByVal subjectcode As String, ByVal Description As String, ByVal SchedTime As String, ByVal Room As String, ByVal Section As String, ByVal IDNumber As String, ByVal Teacher As String)
        Dim lv As New ListViewItem
        ls.Items.Add(lv)
        lv.Text = subjectcode
        lv.SubItems.Add(Description)
        lv.SubItems.Add(SchedTime)
        lv.SubItems.Add(Room)
        lv.SubItems.Add(Section)
        lv.SubItems.Add(IDNumber)
        lv.SubItems.Add(Teacher)

    End Sub

    Public Sub AddFees(ByVal lv As ListView, ByVal Description As String, ByVal Amount As Double)
        Dim n As New ListViewItem
        lv.Items.Add(n)
        n.Text = Description
        n.SubItems.Add(Amount)

    End Sub

End Module
