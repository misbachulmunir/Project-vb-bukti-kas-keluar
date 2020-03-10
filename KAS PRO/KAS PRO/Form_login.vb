Imports System.Data.OleDb
Public Class Form_login
    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            Call ambilkoneksi()
            perintahdata = New OleDbCommand("select * from akun where username='" & TextBox1.Text & "' and password='" & TextBox2.Text & "'", koneksidata)
            bacadata = perintahdata.ExecuteReader
            bacadata.Read()
            If Not bacadata.HasRows Then
                MsgBox("Kode Admin atau Password salah")
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox1.Focus()
            Else
                MsgBox("Anda telah berhasil Login", MsgBoxStyle.Information, "Informasi")
                FORM_UTAMA.Show()
                TextBox2.Text = ""
                Me.Hide()
            End If
            bacadata.Close()
        End If
    End Sub

    Private Sub Form_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class