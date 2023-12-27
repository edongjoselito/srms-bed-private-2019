Imports MySql.Data.MySqlClient
Module connection
    Public conn As New MySqlConnection("Database=srms_bed;" &
                                           "Server =localhost;" &
                                           "User ID = root; Password = ;")
End Module
