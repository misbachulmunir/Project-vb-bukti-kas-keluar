<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cetak_Transaksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cetak_Transaksi))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_dibuat = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_kepada = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_tanggal = New System.Windows.Forms.TextBox()
        Me.txt_kdbukti = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.txt_nobukti = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_noakun = New System.Windows.Forms.TextBox()
        Me.txt_keterangan = New System.Windows.Forms.TextBox()
        Me.txt_debit = New System.Windows.Forms.TextBox()
        Me.txt_kredit = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.txt_debit2 = New System.Windows.Forms.TextBox()
        Me.txt_kredit2 = New System.Windows.Forms.TextBox()
        Me.btn_cetak = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(139, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(347, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PT. ANUGERAH DAYA INDUSTRI KOMPONEN UTAMA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(243, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "BUKTI KAS KELUAR"
        '
        'txt_dibuat
        '
        Me.txt_dibuat.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txt_dibuat.Enabled = False
        Me.txt_dibuat.Location = New System.Drawing.Point(552, 62)
        Me.txt_dibuat.Name = "txt_dibuat"
        Me.txt_dibuat.Size = New System.Drawing.Size(100, 20)
        Me.txt_dibuat.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(552, 81)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(490, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "DIBUAT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(490, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "DIINPUT"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TextBox6)
        Me.Panel1.Controls.Add(Me.TextBox5)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.txt_kredit)
        Me.Panel1.Controls.Add(Me.txt_debit)
        Me.Panel1.Controls.Add(Me.txt_keterangan)
        Me.Panel1.Controls.Add(Me.txt_noakun)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.txt_kepada)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txt_tanggal)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txt_dibuat)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Location = New System.Drawing.Point(13, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(657, 474)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txt_kredit2)
        Me.Panel2.Controls.Add(Me.txt_debit2)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Enabled = False
        Me.Panel2.Location = New System.Drawing.Point(-1, 319)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(657, 24)
        Me.Panel2.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Enabled = False
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "KETERANGAN:"
        '
        'txt_kepada
        '
        Me.txt_kepada.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txt_kepada.Enabled = False
        Me.txt_kepada.Location = New System.Drawing.Point(136, 113)
        Me.txt_kepada.Name = "txt_kepada"
        Me.txt_kepada.Size = New System.Drawing.Size(374, 20)
        Me.txt_kepada.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Enabled = False
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "DIBERIKAN KEPADA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "TANGGAL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "NO. TRANSAKSI"
        '
        'txt_tanggal
        '
        Me.txt_tanggal.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txt_tanggal.Enabled = False
        Me.txt_tanggal.Location = New System.Drawing.Point(136, 81)
        Me.txt_tanggal.Name = "txt_tanggal"
        Me.txt_tanggal.Size = New System.Drawing.Size(127, 20)
        Me.txt_tanggal.TabIndex = 7
        '
        'txt_kdbukti
        '
        Me.txt_kdbukti.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txt_kdbukti.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_kdbukti.Enabled = False
        Me.txt_kdbukti.Location = New System.Drawing.Point(0, 2)
        Me.txt_kdbukti.Name = "txt_kdbukti"
        Me.txt_kdbukti.Size = New System.Drawing.Size(40, 13)
        Me.txt_kdbukti.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Enabled = False
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 360)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "DIBUAT OLEH,"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Enabled = False
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(157, 360)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "DIPERIKSA OLEH,"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Enabled = False
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(329, 360)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "DISETUJUI OLEH,"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Enabled = False
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(577, 360)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 13)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "PENERIMA,"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(655, 472)
        Me.ShapeContainer1.TabIndex = 18
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Enabled = False
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 8
        Me.LineShape1.X2 = 101
        Me.LineShape1.Y1 = 441
        Me.LineShape1.Y2 = 441
        '
        'LineShape2
        '
        Me.LineShape2.Enabled = False
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 157
        Me.LineShape2.X2 = 271
        Me.LineShape2.Y1 = 441
        Me.LineShape2.Y2 = 441
        '
        'LineShape3
        '
        Me.LineShape3.Enabled = False
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 325
        Me.LineShape3.X2 = 445
        Me.LineShape3.Y1 = 441
        Me.LineShape3.Y2 = 441
        '
        'LineShape4
        '
        Me.LineShape4.Enabled = False
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 555
        Me.LineShape4.X2 = 648
        Me.LineShape4.Y1 = 440
        Me.LineShape4.Y2 = 440
        '
        'txt_nobukti
        '
        Me.txt_nobukti.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txt_nobukti.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nobukti.Enabled = False
        Me.txt_nobukti.Location = New System.Drawing.Point(33, 2)
        Me.txt_nobukti.Name = "txt_nobukti"
        Me.txt_nobukti.Size = New System.Drawing.Size(90, 13)
        Me.txt_nobukti.TabIndex = 19
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txt_nobukti)
        Me.Panel3.Controls.Add(Me.txt_kdbukti)
        Me.Panel3.Enabled = False
        Me.Panel3.Location = New System.Drawing.Point(136, 62)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(127, 20)
        Me.Panel3.TabIndex = 20
        '
        'txt_noakun
        '
        Me.txt_noakun.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txt_noakun.Enabled = False
        Me.txt_noakun.Location = New System.Drawing.Point(-1, 161)
        Me.txt_noakun.Multiline = True
        Me.txt_noakun.Name = "txt_noakun"
        Me.txt_noakun.Size = New System.Drawing.Size(127, 159)
        Me.txt_noakun.TabIndex = 21
        '
        'txt_keterangan
        '
        Me.txt_keterangan.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txt_keterangan.Enabled = False
        Me.txt_keterangan.Location = New System.Drawing.Point(125, 161)
        Me.txt_keterangan.Multiline = True
        Me.txt_keterangan.Name = "txt_keterangan"
        Me.txt_keterangan.Size = New System.Drawing.Size(317, 159)
        Me.txt_keterangan.TabIndex = 22
        '
        'txt_debit
        '
        Me.txt_debit.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txt_debit.Enabled = False
        Me.txt_debit.Location = New System.Drawing.Point(441, 161)
        Me.txt_debit.Multiline = True
        Me.txt_debit.Name = "txt_debit"
        Me.txt_debit.Size = New System.Drawing.Size(107, 159)
        Me.txt_debit.TabIndex = 23
        '
        'txt_kredit
        '
        Me.txt_kredit.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txt_kredit.Location = New System.Drawing.Point(547, 161)
        Me.txt_kredit.Multiline = True
        Me.txt_kredit.Name = "txt_kredit"
        Me.txt_kredit.Size = New System.Drawing.Size(109, 159)
        Me.txt_kredit.TabIndex = 24
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.MenuBar
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(-1, 142)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(127, 20)
        Me.TextBox3.TabIndex = 25
        Me.TextBox3.Text = "KODE"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.MenuBar
        Me.TextBox4.Enabled = False
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(125, 142)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(317, 20)
        Me.TextBox4.TabIndex = 26
        Me.TextBox4.Text = "KETERANGAN"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.SystemColors.MenuBar
        Me.TextBox5.Enabled = False
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(441, 142)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(107, 20)
        Me.TextBox5.TabIndex = 27
        Me.TextBox5.Text = "DEBIT"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.SystemColors.MenuBar
        Me.TextBox6.Enabled = False
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(547, 142)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(109, 20)
        Me.TextBox6.TabIndex = 28
        Me.TextBox6.Text = "CREDIT"
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_debit2
        '
        Me.txt_debit2.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txt_debit2.Enabled = False
        Me.txt_debit2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_debit2.Location = New System.Drawing.Point(441, -1)
        Me.txt_debit2.Multiline = True
        Me.txt_debit2.Name = "txt_debit2"
        Me.txt_debit2.Size = New System.Drawing.Size(107, 24)
        Me.txt_debit2.TabIndex = 26
        Me.txt_debit2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_kredit2
        '
        Me.txt_kredit2.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txt_kredit2.Enabled = False
        Me.txt_kredit2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_kredit2.Location = New System.Drawing.Point(547, -1)
        Me.txt_kredit2.Multiline = True
        Me.txt_kredit2.Name = "txt_kredit2"
        Me.txt_kredit2.Size = New System.Drawing.Size(109, 24)
        Me.txt_kredit2.TabIndex = 27
        Me.txt_kredit2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_cetak
        '
        Me.btn_cetak.Location = New System.Drawing.Point(309, 492)
        Me.btn_cetak.Name = "btn_cetak"
        Me.btn_cetak.Size = New System.Drawing.Size(83, 33)
        Me.btn_cetak.TabIndex = 7
        Me.btn_cetak.Text = "PRINT"
        Me.btn_cetak.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Cetak_Transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 537)
        Me.Controls.Add(Me.btn_cetak)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Cetak_Transaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cetak Transaksi"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_dibuat As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_tanggal As System.Windows.Forms.TextBox
    Friend WithEvents txt_kdbukti As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_kepada As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txt_nobukti As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_kredit As System.Windows.Forms.TextBox
    Friend WithEvents txt_debit As System.Windows.Forms.TextBox
    Friend WithEvents txt_keterangan As System.Windows.Forms.TextBox
    Friend WithEvents txt_noakun As System.Windows.Forms.TextBox
    Friend WithEvents txt_kredit2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_debit2 As System.Windows.Forms.TextBox
    Friend WithEvents btn_cetak As System.Windows.Forms.Button
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
End Class
