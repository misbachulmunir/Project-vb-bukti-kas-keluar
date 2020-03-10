Imports System.Data.OleDb
Module Module1
    Public koneksistring As String
    Dim path As String = My.Application.Info.DirectoryPath + "\"
    Public koneksidata As OleDbConnection
    Public perintahdata As OleDbCommand
    Public adapter As OleDbDataAdapter
    Public table As DataTable
    Public bacadata As OleDbDataReader

    Public Sub ambilkoneksi()
        koneksistring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "db.mdb"
        koneksidata = New OleDbConnection(koneksistring)
        Try
            If koneksidata.State = ConnectionState.Closed Then
                koneksidata.Open()

            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Eror")

        End Try
    End Sub
End Module
