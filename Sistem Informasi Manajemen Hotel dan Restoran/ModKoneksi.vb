Imports System.Text
Imports MySql.Data.MySqlClient

Module ModKoneksi
    Public jalur As String = "server=localhost;uid=root;pwd=;database=db_hotelrestoran"
    Public penghubung As MySqlConnection
    Public sqlcmd As MySqlCommand
    Public instruksi As MySqlCommand
    Public translator As MySqlDataReader
    Public sqlreader As MySqlDataReader
    Public Function jembatan() As MySqlConnection
        Try
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance)


            penghubung = New MySqlConnection(jalur)
            If penghubung.State = ConnectionState.Closed = True Then
                penghubung.Open()
            Else
                penghubung.Close()
                penghubung.Open()
            End If
        Catch ex As Exception
            MsgBox(Err.Description.ToString())
        End Try
        Return penghubung
    End Function
End Module
