<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FORM_UTAMA
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txbox_tanggal = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.label_saldo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TANGGAL_INPUT = New System.Windows.Forms.Label()
        Me.label_kredit = New System.Windows.Forms.Label()
        Me.rd_kredit = New System.Windows.Forms.RadioButton()
        Me.rd_debit = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btn_batal = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.label_debit = New System.Windows.Forms.Label()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.txbox_kredit = New System.Windows.Forms.TextBox()
        Me.txbox_debit = New System.Windows.Forms.TextBox()
        Me.txbox_keterangan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txbox_no_akun = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txbox_nobukti = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txbox_kode_bukti = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgv_saldo = New Guna.UI.WinForms.GunaDataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btn_cetak = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_saldo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tanggal"
        '
        'txbox_tanggal
        '
        Me.txbox_tanggal.Location = New System.Drawing.Point(97, 57)
        Me.txbox_tanggal.Name = "txbox_tanggal"
        Me.txbox_tanggal.Size = New System.Drawing.Size(175, 20)
        Me.txbox_tanggal.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_cetak)
        Me.GroupBox1.Controls.Add(Me.label_saldo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TANGGAL_INPUT)
        Me.GroupBox1.Controls.Add(Me.label_kredit)
        Me.GroupBox1.Controls.Add(Me.rd_kredit)
        Me.GroupBox1.Controls.Add(Me.rd_debit)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.btn_batal)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.label_debit)
        Me.GroupBox1.Controls.Add(Me.btn_hapus)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btn_simpan)
        Me.GroupBox1.Controls.Add(Me.txbox_kredit)
        Me.GroupBox1.Controls.Add(Me.txbox_debit)
        Me.GroupBox1.Controls.Add(Me.txbox_keterangan)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txbox_no_akun)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txbox_nobukti)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txbox_kode_bukti)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txbox_tanggal)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(373, 489)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INPUT DATA"
        '
        'label_saldo
        '
        Me.label_saldo.AutoSize = True
        Me.label_saldo.BackColor = System.Drawing.Color.Blue
        Me.label_saldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_saldo.Location = New System.Drawing.Point(107, 444)
        Me.label_saldo.Name = "label_saldo"
        Me.label_saldo.Size = New System.Drawing.Size(110, 24)
        Me.label_saldo.TabIndex = 42
        Me.label_saldo.Text = "Total Debit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Waktu Input :"
        '
        'TANGGAL_INPUT
        '
        Me.TANGGAL_INPUT.AutoSize = True
        Me.TANGGAL_INPUT.Location = New System.Drawing.Point(108, 30)
        Me.TANGGAL_INPUT.Name = "TANGGAL_INPUT"
        Me.TANGGAL_INPUT.Size = New System.Drawing.Size(26, 13)
        Me.TANGGAL_INPUT.TabIndex = 35
        Me.TANGGAL_INPUT.Text = "time"
        '
        'label_kredit
        '
        Me.label_kredit.AutoSize = True
        Me.label_kredit.BackColor = System.Drawing.Color.Red
        Me.label_kredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_kredit.Location = New System.Drawing.Point(107, 417)
        Me.label_kredit.Name = "label_kredit"
        Me.label_kredit.Size = New System.Drawing.Size(110, 24)
        Me.label_kredit.TabIndex = 40
        Me.label_kredit.Text = "Total Debit"
        '
        'rd_kredit
        '
        Me.rd_kredit.AutoSize = True
        Me.rd_kredit.Location = New System.Drawing.Point(33, 265)
        Me.rd_kredit.Name = "rd_kredit"
        Me.rd_kredit.Size = New System.Drawing.Size(52, 17)
        Me.rd_kredit.TabIndex = 34
        Me.rd_kredit.TabStop = True
        Me.rd_kredit.Text = "Kredit"
        Me.rd_kredit.UseVisualStyleBackColor = True
        '
        'rd_debit
        '
        Me.rd_debit.AutoSize = True
        Me.rd_debit.Location = New System.Drawing.Point(33, 239)
        Me.rd_debit.Name = "rd_debit"
        Me.rd_debit.Size = New System.Drawing.Size(50, 17)
        Me.rd_debit.TabIndex = 33
        Me.rd_debit.TabStop = True
        Me.rd_debit.Text = "Debit"
        Me.rd_debit.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(42, 444)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Saldo"
        '
        'btn_batal
        '
        Me.btn_batal.Location = New System.Drawing.Point(257, 303)
        Me.btn_batal.Name = "btn_batal"
        Me.btn_batal.Size = New System.Drawing.Size(75, 23)
        Me.btn_batal.TabIndex = 32
        Me.btn_batal.Text = "Batal"
        Me.btn_batal.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 417)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Total Kredit"
        '
        'label_debit
        '
        Me.label_debit.AutoSize = True
        Me.label_debit.BackColor = System.Drawing.Color.Lime
        Me.label_debit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_debit.Location = New System.Drawing.Point(107, 388)
        Me.label_debit.Name = "label_debit"
        Me.label_debit.Size = New System.Drawing.Size(72, 24)
        Me.label_debit.TabIndex = 37
        Me.label_debit.Text = "Label3"
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(176, 303)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(75, 23)
        Me.btn_hapus.TabIndex = 31
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 388)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Total Debit"
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(95, 303)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(75, 23)
        Me.btn_simpan.TabIndex = 30
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'txbox_kredit
        '
        Me.txbox_kredit.Location = New System.Drawing.Point(96, 265)
        Me.txbox_kredit.Name = "txbox_kredit"
        Me.txbox_kredit.Size = New System.Drawing.Size(174, 20)
        Me.txbox_kredit.TabIndex = 29
        '
        'txbox_debit
        '
        Me.txbox_debit.Location = New System.Drawing.Point(96, 239)
        Me.txbox_debit.Name = "txbox_debit"
        Me.txbox_debit.Size = New System.Drawing.Size(174, 20)
        Me.txbox_debit.TabIndex = 28
        '
        'txbox_keterangan
        '
        Me.txbox_keterangan.Location = New System.Drawing.Point(97, 161)
        Me.txbox_keterangan.Multiline = True
        Me.txbox_keterangan.Name = "txbox_keterangan"
        Me.txbox_keterangan.Size = New System.Drawing.Size(236, 72)
        Me.txbox_keterangan.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Keterangan"
        '
        'txbox_no_akun
        '
        Me.txbox_no_akun.Location = New System.Drawing.Point(97, 135)
        Me.txbox_no_akun.Name = "txbox_no_akun"
        Me.txbox_no_akun.Size = New System.Drawing.Size(174, 20)
        Me.txbox_no_akun.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "No Akun"
        '
        'txbox_nobukti
        '
        Me.txbox_nobukti.Location = New System.Drawing.Point(97, 109)
        Me.txbox_nobukti.Name = "txbox_nobukti"
        Me.txbox_nobukti.Size = New System.Drawing.Size(174, 20)
        Me.txbox_nobukti.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(31, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "No Bukti"
        '
        'txbox_kode_bukti
        '
        Me.txbox_kode_bukti.Location = New System.Drawing.Point(97, 83)
        Me.txbox_kode_bukti.Name = "txbox_kode_bukti"
        Me.txbox_kode_bukti.Size = New System.Drawing.Size(174, 20)
        Me.txbox_kode_bukti.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(31, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Kode Bukti"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgv_saldo)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(373, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(673, 489)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LIST DATA"
        '
        'dgv_saldo
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.dgv_saldo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_saldo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_saldo.BackgroundColor = System.Drawing.Color.White
        Me.dgv_saldo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_saldo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_saldo.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.dgv_saldo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_saldo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgv_saldo.ColumnHeadersHeight = 30
        Me.dgv_saldo.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_saldo.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgv_saldo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_saldo.EnableHeadersVisualStyles = False
        Me.dgv_saldo.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_saldo.Location = New System.Drawing.Point(3, 16)
        Me.dgv_saldo.Name = "dgv_saldo"
        Me.dgv_saldo.ReadOnly = True
        Me.dgv_saldo.RowHeadersVisible = False
        Me.dgv_saldo.RowHeadersWidth = 50
        Me.dgv_saldo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_saldo.ShowCellToolTips = False
        Me.dgv_saldo.Size = New System.Drawing.Size(667, 470)
        Me.dgv_saldo.TabIndex = 0
        Me.dgv_saldo.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgv_saldo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv_saldo.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgv_saldo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgv_saldo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgv_saldo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgv_saldo.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgv_saldo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_saldo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_saldo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgv_saldo.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgv_saldo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgv_saldo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgv_saldo.ThemeStyle.HeaderStyle.Height = 30
        Me.dgv_saldo.ThemeStyle.ReadOnly = True
        Me.dgv_saldo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgv_saldo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_saldo.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgv_saldo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgv_saldo.ThemeStyle.RowsStyle.Height = 22
        Me.dgv_saldo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_saldo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'btn_cetak
        '
        Me.btn_cetak.Enabled = False
        Me.btn_cetak.Location = New System.Drawing.Point(176, 349)
        Me.btn_cetak.Name = "btn_cetak"
        Me.btn_cetak.Size = New System.Drawing.Size(75, 23)
        Me.btn_cetak.TabIndex = 43
        Me.btn_cetak.Text = "PRINT"
        Me.btn_cetak.UseVisualStyleBackColor = True
        '
        'FORM_UTAMA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 489)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FORM_UTAMA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgv_saldo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txbox_tanggal As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rd_kredit As RadioButton
    Friend WithEvents rd_debit As RadioButton
    Friend WithEvents btn_batal As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_simpan As Button
    Friend WithEvents txbox_kredit As TextBox
    Friend WithEvents txbox_debit As TextBox
    Friend WithEvents txbox_keterangan As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txbox_no_akun As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txbox_nobukti As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txbox_kode_bukti As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgv_saldo As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents TANGGAL_INPUT As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents label_debit As Label
    Friend WithEvents label_saldo As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents label_kredit As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_cetak As System.Windows.Forms.Button
End Class
