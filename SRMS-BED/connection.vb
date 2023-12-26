Imports MySql.Data.MySqlClient
Module connection
    Public conn As New MySqlConnection("Database=wcmanilasrms_bed;" &
                                           "Server =localhost;" &
                                           "User ID = root; Password = ;")
End Module
