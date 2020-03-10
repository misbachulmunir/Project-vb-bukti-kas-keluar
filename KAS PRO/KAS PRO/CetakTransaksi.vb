Imports System.Data.OleDb
Public Class Cetak_Transaksi

    Private Sub Cetak_Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_dibuat.Text = Form_login.TextBox1.Text
        txt_tanggal.Text = FORM_UTAMA.txbox_tanggal.Value
        txt_kdbukti.Text = FORM_UTAMA.txbox_kode_bukti.Text
        txt_nobukti.Text = FORM_UTAMA.txbox_nobukti.Text
        txt_keterangan.Text = FORM_UTAMA.txbox_keterangan.Text
        txt_kepada.Text = FORM_UTAMA.txbox_keterangan.Text
        txt_noakun.Text = FORM_UTAMA.txbox_no_akun.Text
        txt_debit.Text = FORM_UTAMA.txbox_debit.Text
        txt_kredit.Text = FORM_UTAMA.txbox_kredit.Text
        txt_debit2.Text = FORM_UTAMA.txbox_debit.Text
        txt_kredit2.Text = FORM_UTAMA.txbox_kredit.Text
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btn_cetak_Click(sender As Object, e As EventArgs) Handles btn_cetak.Click
        btn_cetak.Visible = False
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
        btn_cetak.Visible = True
        Me.Close()
    End Sub
End Class