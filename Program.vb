Imports System
Imports Npgsql

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")

        Dim myPassword = new String("abcdefg")
        Dim _connstr = new String("Server=127.0.0.1;Port=5432;User Id=postgres;Password=secret;Database=vulnerable_json;")
        Dim username = new String ("myuser")

        Dim conn = new NpgsqlConnection (_connstr)

        conn.Open ()

        Dim cmd = new NpgsqlCommand ("SELECT username FROM USERS WHERE USERNAME LIKE '%" + username + "%';", conn)
        Dim rdr = cmd.ExecuteReader ()

        ' while (rdr.Read ()) {
        '    JObject obj = new JObject ()
        '    obj ["username"] = (string)rdr [0]
        '    users.Add (obj)
        '}
    End Sub
End Module
