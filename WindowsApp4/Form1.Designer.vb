<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.penerbangan = New System.Windows.Forms.ComboBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bisnis = New System.Windows.Forms.RadioButton()
        Me.ekonomi = New System.Windows.Forms.RadioButton()
        Me.harga = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.noKtp = New System.Windows.Forms.Label()
        Me.ktp = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.subTotal = New System.Windows.Forms.TextBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.bayi = New System.Windows.Forms.TextBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dewasa = New System.Windows.Forms.TextBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bagasi3 = New System.Windows.Forms.CheckBox()
        Me.bagasi2 = New System.Windows.Forms.CheckBox()
        Me.bagasi1 = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.totalSemua = New System.Windows.Forms.TextBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tanggalBerangkat = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.tanggalKembali = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'penerbangan
        '
        Me.penerbangan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.penerbangan.FormattingEnabled = True
        Me.penerbangan.Items.AddRange(New Object() {"Jakarta(CGK)-Denpasar(DPS)", "Denpasar (DPS)-Jakarta(CGK)", "Jakarta(CGK)-Surabaya(SBY)", "Surabaya(SBY)-Jakarta(CGK)", "Bandung(BDG)-Surabaya(SBY)", "Surabaya(SBY)-Bandung(BDG)", "Bandung(BDG)-Denpasar(DPS)", "Denpasar(DPS)-Bandung(BDG)", "Jakarta(CGK)-Singapur(SNG)", "Singapur(SNG)-Jakarta(CGK)", "Jakarta(CGK)-Kuala Lumpur(KLI)", "Kuala Lumpur(KLI)-Jakarta(CGK)", "Jakarta(CGK)-Bangkok(BGK)", "Bangkok(BGK)-Jakarta(CGK)", "Bandung(BDG)-Singapur(SNG)", "Singapur(SNG)-Bandung(BDG)", "Bandung(BDG)-Kuala Lumpur(KLI)", "Kuala Lumpur(KLI)-Bandung(BDG)", "Bandung(BDG)-Bangkok(BGK)", "Bangkok(BGK)-Bandung(BDG)", "Surabaya(SBY)-Singapur(SNG)", "Singapur(SNG)-Surabaya(SBY)", "Surabaya(SBY)-Kuala Lumpur(KLI)", "Kuala Lumpur(KLI)-Surabaya(SBY)", "Surabaya(SBY)-Bangkok(BGK)", "Bangkok(BGK)-Surabaya(SBY)", "Denpasar(DPS)-Singapur(SNG)", "Singapur(SNG)-Denpasar(DPS)", "Denpasar(DPS)-Kuala Lumpur(KLI)", "Kuala Lumpur(KLI)-Denpasar(DPS)", "Denpasar(DPS)-Bangkok(BGK)", "Bangkok(BGK)-Denpasar(DPS)"})
        Me.penerbangan.Location = New System.Drawing.Point(127, 30)
        Me.penerbangan.Name = "penerbangan"
        Me.penerbangan.Size = New System.Drawing.Size(200, 21)
        Me.penerbangan.TabIndex = 10
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(122, 27)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(210, 27)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 31
        Me.PictureBox5.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(12, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Pilih Penerbangan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(12, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Kelas"
        '
        'bisnis
        '
        Me.bisnis.AutoSize = True
        Me.bisnis.ForeColor = System.Drawing.Color.White
        Me.bisnis.Location = New System.Drawing.Point(122, 82)
        Me.bisnis.Name = "bisnis"
        Me.bisnis.Size = New System.Drawing.Size(52, 17)
        Me.bisnis.TabIndex = 34
        Me.bisnis.TabStop = True
        Me.bisnis.Text = "Bisnis"
        Me.bisnis.UseVisualStyleBackColor = True
        '
        'ekonomi
        '
        Me.ekonomi.AutoSize = True
        Me.ekonomi.ForeColor = System.Drawing.Color.White
        Me.ekonomi.Location = New System.Drawing.Point(201, 84)
        Me.ekonomi.Name = "ekonomi"
        Me.ekonomi.Size = New System.Drawing.Size(66, 17)
        Me.ekonomi.TabIndex = 35
        Me.ekonomi.TabStop = True
        Me.ekonomi.Text = "Ekonomi"
        Me.ekonomi.UseVisualStyleBackColor = True
        '
        'harga
        '
        Me.harga.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.harga.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.harga.Enabled = False
        Me.harga.ForeColor = System.Drawing.Color.Black
        Me.harga.Location = New System.Drawing.Point(127, 133)
        Me.harga.Multiline = True
        Me.harga.Name = "harga"
        Me.harga.Size = New System.Drawing.Size(200, 20)
        Me.harga.TabIndex = 36
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(122, 129)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(210, 27)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 37
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(12, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Harga (Rp.)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(12, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Nama"
        '
        'nama
        '
        Me.nama.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nama.Location = New System.Drawing.Point(127, 186)
        Me.nama.Multiline = True
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(200, 20)
        Me.nama.TabIndex = 39
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(122, 182)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(210, 27)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'noKtp
        '
        Me.noKtp.AutoSize = True
        Me.noKtp.BackColor = System.Drawing.Color.Transparent
        Me.noKtp.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noKtp.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.noKtp.Location = New System.Drawing.Point(12, 237)
        Me.noKtp.Name = "noKtp"
        Me.noKtp.Size = New System.Drawing.Size(45, 13)
        Me.noKtp.TabIndex = 44
        Me.noKtp.Text = "No. KTP"
        '
        'ktp
        '
        Me.ktp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ktp.Location = New System.Drawing.Point(127, 237)
        Me.ktp.Multiline = True
        Me.ktp.Name = "ktp"
        Me.ktp.Size = New System.Drawing.Size(200, 20)
        Me.ktp.TabIndex = 42
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(122, 233)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(210, 27)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 43
        Me.PictureBox3.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(12, 288)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Tgl.Berangkat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(12, 339)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Tgl. Kembali"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(12, 390)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Sub Total (Rp.)"
        '
        'subTotal
        '
        Me.subTotal.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.subTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.subTotal.Enabled = False
        Me.subTotal.ForeColor = System.Drawing.Color.Black
        Me.subTotal.Location = New System.Drawing.Point(127, 390)
        Me.subTotal.Multiline = True
        Me.subTotal.Name = "subTotal"
        Me.subTotal.Size = New System.Drawing.Size(200, 20)
        Me.subTotal.TabIndex = 51
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(122, 386)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(210, 27)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 52
        Me.PictureBox7.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(360, 339)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 13)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "Bayi"
        '
        'bayi
        '
        Me.bayi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.bayi.Location = New System.Drawing.Point(475, 339)
        Me.bayi.Multiline = True
        Me.bayi.Name = "bayi"
        Me.bayi.Size = New System.Drawing.Size(78, 20)
        Me.bayi.TabIndex = 57
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(470, 335)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(88, 27)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 58
        Me.PictureBox8.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label10.Location = New System.Drawing.Point(285, 345)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "Dewasa"
        '
        'dewasa
        '
        Me.dewasa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dewasa.Location = New System.Drawing.Point(475, 288)
        Me.dewasa.Multiline = True
        Me.dewasa.Name = "dewasa"
        Me.dewasa.Size = New System.Drawing.Size(78, 20)
        Me.dewasa.TabIndex = 54
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(470, 284)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(88, 27)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 55
        Me.PictureBox9.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox1.Controls.Add(Me.bagasi3)
        Me.GroupBox1.Controls.Add(Me.bagasi2)
        Me.GroupBox1.Controls.Add(Me.bagasi1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(12, 436)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(546, 78)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bagasi"
        '
        'bagasi3
        '
        Me.bagasi3.AutoSize = True
        Me.bagasi3.Location = New System.Drawing.Point(200, 31)
        Me.bagasi3.Name = "bagasi3"
        Me.bagasi3.Size = New System.Drawing.Size(76, 17)
        Me.bagasi3.TabIndex = 2
        Me.bagasi3.Text = "31 - 50 Kg"
        Me.bagasi3.UseVisualStyleBackColor = True
        '
        'bagasi2
        '
        Me.bagasi2.AutoSize = True
        Me.bagasi2.Location = New System.Drawing.Point(107, 31)
        Me.bagasi2.Name = "bagasi2"
        Me.bagasi2.Size = New System.Drawing.Size(76, 17)
        Me.bagasi2.TabIndex = 1
        Me.bagasi2.Text = "16 - 30 Kg"
        Me.bagasi2.UseVisualStyleBackColor = True
        '
        'bagasi1
        '
        Me.bagasi1.AutoSize = True
        Me.bagasi1.Location = New System.Drawing.Point(17, 31)
        Me.bagasi1.Name = "bagasi1"
        Me.bagasi1.Size = New System.Drawing.Size(70, 17)
        Me.bagasi1.TabIndex = 0
        Me.bagasi1.Text = "0 - 15 Kg"
        Me.bagasi1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label11.Location = New System.Drawing.Point(17, 541)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 13)
        Me.Label11.TabIndex = 63
        Me.Label11.Text = "Total (Rp.)"
        '
        'totalSemua
        '
        Me.totalSemua.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.totalSemua.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.totalSemua.Enabled = False
        Me.totalSemua.ForeColor = System.Drawing.Color.Black
        Me.totalSemua.Location = New System.Drawing.Point(132, 541)
        Me.totalSemua.Multiline = True
        Me.totalSemua.Name = "totalSemua"
        Me.totalSemua.Size = New System.Drawing.Size(200, 20)
        Me.totalSemua.TabIndex = 61
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(127, 537)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(210, 27)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 62
        Me.PictureBox10.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(383, 534)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 27)
        Me.Button1.TabIndex = 64
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(483, 534)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 27)
        Me.Button2.TabIndex = 65
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'tanggalBerangkat
        '
        Me.tanggalBerangkat.Location = New System.Drawing.Point(127, 288)
        Me.tanggalBerangkat.Name = "tanggalBerangkat"
        Me.tanggalBerangkat.Size = New System.Drawing.Size(200, 20)
        Me.tanggalBerangkat.TabIndex = 66
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(123, 284)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(209, 27)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 67
        Me.PictureBox4.TabStop = False
        '
        'tanggalKembali
        '
        Me.tanggalKembali.Location = New System.Drawing.Point(127, 339)
        Me.tanggalKembali.Name = "tanggalKembali"
        Me.tanggalKembali.Size = New System.Drawing.Size(200, 20)
        Me.tanggalKembali.TabIndex = 68
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(123, 335)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(209, 27)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 69
        Me.PictureBox11.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(360, 294)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Dewasa"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(604, 583)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tanggalKembali)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.tanggalBerangkat)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.totalSemua)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.bayi)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dewasa)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.subTotal)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.noKtp)
        Me.Controls.Add(Me.ktp)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.harga)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ekonomi)
        Me.Controls.Add(Me.bisnis)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.penerbangan)
        Me.Controls.Add(Me.PictureBox5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents penerbangan As ComboBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents bisnis As RadioButton
    Friend WithEvents ekonomi As RadioButton
    Friend WithEvents harga As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents nama As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents noKtp As Label
    Friend WithEvents ktp As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents subTotal As TextBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents bayi As TextBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dewasa As TextBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents bagasi3 As CheckBox
    Friend WithEvents bagasi2 As CheckBox
    Friend WithEvents bagasi1 As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents totalSemua As TextBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents tanggalBerangkat As DateTimePicker
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents tanggalKembali As DateTimePicker
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents Label5 As Label
End Class
