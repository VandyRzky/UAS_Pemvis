Imports MySql.Data.MySqlClient

Module DatabaseConnection
    Public CONN As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Public DS As DataSet
    Public STR As String
    Sub koneksi()
        Try
            Dim STR As String =
            "server=localhost;port=3306;userid=root;password=;database=mahasiswadb"
            CONN = New MySqlConnection(STR)
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
