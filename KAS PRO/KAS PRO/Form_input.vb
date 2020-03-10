Imports System.Data.OleDb
Public Class FORM_UTAMA
    Dim koneksistring As String
    Dim path As String = My.Application.Info.DirectoryPath + "\"
    Dim koneksidata As New OleDbConnection
    Dim perintahdata As New OleDbCommand
    Dim adapter As New OleDbDataAdapter
    Dim table As New DataTable
    Dim bacadata As OleDbDataReader
    Dim a, b As String
    Dim jumlahkredit, jumlahdebit, jumlahsaldo As Long



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbDataSet.saldo' table. You can move, or remove it, as needed.

        koneksistring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path & "db.mdb"
        tampil()
        txbox_kredit.Enabled = False
        rd_debit.Checked = True
        refreshwaktu()
        debit()
        kredit()
        saldo()


    End Sub
    Sub debit()


        jumlahdebit = 0
        For t As Integer = 0 To dgv_saldo.Rows.Count - 1
            jumlahdebit = jumlahdebit + Val(dgv_saldo.Rows(t).Cells(6).Value)
            '-----------cell 2 disini menunjukan posisi field yang akan kita jumlahkan
        Next
        label_debit.Text = jumlahdebit
    End Sub
    Sub kredit()


        jumlahkredit = 0
        For t As Integer = 0 To dgv_saldo.Rows.Count - 1
            jumlahkredit = jumlahkredit + Val(dgv_saldo.Rows(t).Cells(7).Value)
            '-----------cell 2 disini menunjukan posisi field yang akan kita jumlahkan
        Next
        label_kredit.Text = jumlahkredit
    End Sub
    Sub saldo()
        jumlahsaldo = jumlahdebit - jumlahkredit
        label_saldo.Text = jumlahsaldo
    End Sub

    Sub refreshwaktu()
        TANGGAL_INPUT.Text = DateAndTime.Now
    End Sub
    Sub bersih()
        txbox_keterangan.Text = ""
        txbox_debit.Text = ""
        txbox_kode_bukti.Text = ""
        txbox_kredit.Text = ""
        txbox_nobukti.Text = ""
        txbox_no_akun.Text = ""

    End Sub
    Public Sub tampil()
        Dim ds As DataSet = New DataSet
        koneksidata.ConnectionString = koneksistring
        Dim perintah As String = "Select * from saldo"
        Dim search As New OleDbDataAdapter(perintah, koneksidata)
        search.Fill(ds, "saldo")
        dgv_saldo.DataSource = ds.Tables("saldo")
        koneksidata.Close()

    End Sub
    Sub hapus()
        Try
            koneksidata.ConnectionString = koneksistring
            koneksidata.Open()
            perintahdata.CommandText = "delete from saldo where ID_INPUT='" & TANGGAL_INPUT.Text & "'"
            perintahdata.Connection = koneksidata
            Dim pertanyaan As Integer = MsgBox("Apakah anda ingin menghapus data ini? ", MsgBoxStyle.YesNo, "Pesan")
            If pertanyaan = DialogResult.Yes Then
                perintahdata.ExecuteNonQuery()
                MsgBox("Berhasil Menghapus", MsgBoxStyle.Information, "Info")
                koneksidata.Close()
                perintahdata.Dispose()
                Call tampil()

            Else
                MsgBox("Gagal Menghapus", MsgBoxStyle.Information, "Info")
                koneksidata.Close()
                perintahdata.Dispose()
            End If
        Catch ex As Exception
            MsgBox("Gagal menghapus data", MsgBoxStyle.Critical, "Kesalahan")
        End Try
    End Sub
    Sub tambah()

        If txbox_kredit.Text = "" And txbox_debit.Text = "" Then
            MsgBox("Debit atau Kredit Belum Di isi")
        Else
            Try
                koneksidata.ConnectionString = koneksistring
                koneksidata.Open()
                perintahdata.CommandText = "insert into saldo(ID_INPUT,TANGGAL,KODE_BUKTI,NO_BUKTI,NO_AKUN,KETERANGAN,DEBIT,KREDIT) values ('" & TANGGAL_INPUT.Text & "','" & txbox_tanggal.Text & "','" & txbox_kode_bukti.Text & "','" & txbox_nobukti.Text & "','" & txbox_no_akun.Text & "','" & txbox_keterangan.Text & "','" & txbox_debit.Text & "','" & txbox_kredit.Text & "')"
                perintahdata.Connection = koneksidata
                perintahdata.ExecuteNonQuery()
                koneksidata.Close()
            Catch ex As Exception
                koneksidata.Close()
                koneksidata.ConnectionString = koneksistring
                koneksidata.Open()
                perintahdata.CommandText = "update saldo set TANGGAL='" & txbox_tanggal.Text & "',KODE_BUKTI='" & txbox_kode_bukti.Text & "', NO_BUKTI='" & txbox_nobukti.Text & "',NO_AKUN='" & txbox_no_akun.Text & "',KETERANGAN='" & txbox_keterangan.Text & "',DEBIT='" & txbox_debit.Text & "',KREDIT='" & txbox_kredit.Text & "' where ID_INPUT='" & TANGGAL_INPUT.Text & "'"
                perintahdata.Connection = koneksidata
                perintahdata.ExecuteNonQuery()
                koneksidata.Close()
                perintahdata.Dispose()
            End Try


        End If
    End Sub


    Private Sub tbox_kode_bukti_TextChanged(sender As Object, e As EventArgs) Handles txbox_kode_bukti.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txbox_nobukti_TextChanged(sender As Object, e As EventArgs) Handles txbox_nobukti.TextChanged

    End Sub

    Private Sub tbox_kode_bukti_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txbox_kode_bukti.KeyPress
        If e.KeyChar = Chr(13) Then
            txbox_nobukti.Focus()
        End If
    End Sub

    Private Sub txbox_no_akun_TextChanged(sender As Object, e As EventArgs) Handles txbox_no_akun.TextChanged

    End Sub

    Private Sub txbox_nobukti_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txbox_nobukti.KeyPress
        If e.KeyChar = Chr(13) Then
            txbox_no_akun.Focus()
        End If
    End Sub

    Private Sub txbox_keterangan_TextChanged(sender As Object, e As EventArgs) Handles txbox_keterangan.TextChanged

    End Sub

    Private Sub txbox_tanggal_ValueChanged(sender As Object, e As EventArgs) Handles txbox_tanggal.ValueChanged

    End Sub

    Private Sub txbox_no_akun_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txbox_no_akun.KeyPress
        If e.KeyChar = Chr(13) Then
            txbox_keterangan.Focus()
        End If
    End Sub

    Private Sub rd_debit_CheckedChanged(sender As Object, e As EventArgs) Handles rd_debit.CheckedChanged
        txbox_kredit.Enabled = False
        txbox_kredit.Text = ""
        txbox_debit.Enabled = True

    End Sub

    Private Sub rd_kredit_CheckedChanged(sender As Object, e As EventArgs) Handles rd_kredit.CheckedChanged
        txbox_debit.Enabled = False
        txbox_debit.Text = ""
        txbox_kredit.Enabled = True

    End Sub

    Private Sub txbox_debit_TextChanged(sender As Object, e As EventArgs) Handles txbox_debit.TextChanged

    End Sub

    Private Sub txbox_tanggal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txbox_tanggal.KeyPress
        If e.KeyChar = Chr(13) Then
            txbox_kode_bukti.Focus()
        End If
    End Sub

    Private Sub txbox_kredit_TextChanged(sender As Object, e As EventArgs) Handles txbox_kredit.TextChanged

    End Sub

    Private Sub txbox_debit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txbox_debit.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
          AndAlso e.KeyChar <> ControlChars.Back Then 'AndAlso e.KeyChar <> "-"
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            btn_simpan.Focus()
        End If
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        tambah()
        tampil()
        debit()
        kredit()
        saldo()
        bersih()
        refreshwaktu()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub SaldoBindingSource_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgv_saldo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_saldo.CellContentClick




    End Sub

    Private Sub txbox_kredit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txbox_kredit.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
         AndAlso e.KeyChar <> ControlChars.Back Then 'AndAlso e.KeyChar <> "-"
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            btn_simpan.Focus()
        End If
    End Sub

    Private Sub dgv_saldo_DoubleClick(sender As Object, e As EventArgs) Handles dgv_saldo.DoubleClick

    End Sub

    Private Sub label_saldo_Click(sender As Object, e As EventArgs) Handles label_saldo.Click

    End Sub

    Private Sub label_debit_Click(sender As Object, e As EventArgs) Handles label_debit.Click

    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        hapus()
        tampil()
        debit()
        kredit()
        saldo()
        refreshwaktu()
        bersih()

    End Sub

    Private Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        bersih()
        refreshwaktu()
    End Sub

    Private Sub dgv_saldo_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_saldo.CellDoubleClick
        Dim index As Integer
        index = e.RowIndex
        Dim pilihrow As DataGridViewRow
        pilihrow = dgv_saldo.Rows(index)

        TANGGAL_INPUT.Text = pilihrow.Cells(0).Value.ToString
        txbox_tanggal.Text = pilihrow.Cells(1).Value.ToString
        txbox_kode_bukti.Text = pilihrow.Cells(2).Value.ToString
        txbox_nobukti.Text = pilihrow.Cells(3).Value.ToString
        txbox_no_akun.Text = pilihrow.Cells(4).Value.ToString
        txbox_keterangan.Text = pilihrow.Cells(5).Value.ToString
        txbox_debit.Text = pilihrow.Cells(6).Value.ToString
        txbox_kredit.Text = pilihrow.Cells(7).Value.ToString
        If txbox_debit.Text = "" Then
            rd_kredit.Checked = True
            rd_debit.Checked = False
            txbox_kredit.Text = pilihrow.Cells(7).Value.ToString

        ElseIf txbox_kredit.Text = ""
            rd_debit.Checked = True
            rd_kredit.Checked = False
            txbox_debit.Text = pilihrow.Cells(6).Value.ToString


        End If
    End Sub

End Class
