<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.TxtNIS = New System.Windows.Forms.TextBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.TxtTmptLahir = New System.Windows.Forms.TextBox()
        Me.GbxGender = New System.Windows.Forms.GroupBox()
        Me.RBP = New System.Windows.Forms.RadioButton()
        Me.RBL = New System.Windows.Forms.RadioButton()
        Me.DtpTglLahir = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RtbAlamat = New System.Windows.Forms.RichTextBox()
        Me.TxtNamaWali = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtKontakWali = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CbxAgama = New System.Windows.Forms.ComboBox()
        Me.BtnBaru = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvProfilSiswa = New System.Windows.Forms.DataGridView()
        Me.NIS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kelamin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TmpLahir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglLahir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Agama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Alamat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaWali = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CbxTampilKelas = New System.Windows.Forms.ComboBox()
        Me.CbxTampilThnAjaran = New System.Windows.Forms.ComboBox()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PbxSDBW = New System.Windows.Forms.PictureBox()
        Me.PbxLogo = New System.Windows.Forms.PictureBox()
        Me.GbxGender.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvProfilSiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxSDBW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtNIS
        '
        Me.TxtNIS.Location = New System.Drawing.Point(138, 19)
        Me.TxtNIS.Name = "TxtNIS"
        Me.TxtNIS.Size = New System.Drawing.Size(100, 20)
        Me.TxtNIS.TabIndex = 1
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(138, 45)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(306, 20)
        Me.TxtNama.TabIndex = 2
        '
        'TxtTmptLahir
        '
        Me.TxtTmptLahir.Location = New System.Drawing.Point(138, 120)
        Me.TxtTmptLahir.Name = "TxtTmptLahir"
        Me.TxtTmptLahir.Size = New System.Drawing.Size(100, 20)
        Me.TxtTmptLahir.TabIndex = 3
        '
        'GbxGender
        '
        Me.GbxGender.Controls.Add(Me.RBP)
        Me.GbxGender.Controls.Add(Me.RBL)
        Me.GbxGender.Location = New System.Drawing.Point(138, 71)
        Me.GbxGender.Name = "GbxGender"
        Me.GbxGender.Size = New System.Drawing.Size(163, 43)
        Me.GbxGender.TabIndex = 4
        Me.GbxGender.TabStop = False
        '
        'RBP
        '
        Me.RBP.AutoSize = True
        Me.RBP.Location = New System.Drawing.Point(80, 19)
        Me.RBP.Name = "RBP"
        Me.RBP.Size = New System.Drawing.Size(79, 17)
        Me.RBP.TabIndex = 1
        Me.RBP.TabStop = True
        Me.RBP.Text = "Perempuan"
        Me.RBP.UseVisualStyleBackColor = True
        '
        'RBL
        '
        Me.RBL.AutoSize = True
        Me.RBL.Location = New System.Drawing.Point(6, 19)
        Me.RBL.Name = "RBL"
        Me.RBL.Size = New System.Drawing.Size(68, 17)
        Me.RBL.TabIndex = 0
        Me.RBL.TabStop = True
        Me.RBL.Text = "Laki-Laki"
        Me.RBL.UseVisualStyleBackColor = True
        '
        'DtpTglLahir
        '
        Me.DtpTglLahir.Location = New System.Drawing.Point(244, 120)
        Me.DtpTglLahir.Name = "DtpTglLahir"
        Me.DtpTglLahir.Size = New System.Drawing.Size(200, 20)
        Me.DtpTglLahir.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Tempat Tanggal Lahir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Alamat"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Agama"
        '
        'RtbAlamat
        '
        Me.RtbAlamat.Location = New System.Drawing.Point(138, 172)
        Me.RtbAlamat.Name = "RtbAlamat"
        Me.RtbAlamat.Size = New System.Drawing.Size(306, 96)
        Me.RtbAlamat.TabIndex = 17
        Me.RtbAlamat.Text = ""
        '
        'TxtNamaWali
        '
        Me.TxtNamaWali.Location = New System.Drawing.Point(138, 274)
        Me.TxtNamaWali.Name = "TxtNamaWali"
        Me.TxtNamaWali.Size = New System.Drawing.Size(306, 20)
        Me.TxtNamaWali.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 277)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Nama Wali"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 303)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Kontak Wali"
        '
        'TxtKontakWali
        '
        Me.TxtKontakWali.Location = New System.Drawing.Point(138, 300)
        Me.TxtKontakWali.Name = "TxtKontakWali"
        Me.TxtKontakWali.Size = New System.Drawing.Size(134, 20)
        Me.TxtKontakWali.TabIndex = 24
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CbxAgama)
        Me.GroupBox2.Controls.Add(Me.BtnBaru)
        Me.GroupBox2.Controls.Add(Me.BtnBatal)
        Me.GroupBox2.Controls.Add(Me.BtnHapus)
        Me.GroupBox2.Controls.Add(Me.BtnEdit)
        Me.GroupBox2.Controls.Add(Me.BtnSimpan)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtKontakWali)
        Me.GroupBox2.Controls.Add(Me.TxtNIS)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.TxtNama)
        Me.GroupBox2.Controls.Add(Me.TxtTmptLahir)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.GbxGender)
        Me.GroupBox2.Controls.Add(Me.DtpTglLahir)
        Me.GroupBox2.Controls.Add(Me.TxtNamaWali)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.RtbAlamat)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(460, 401)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Siswa"
        '
        'CbxAgama
        '
        Me.CbxAgama.FormattingEnabled = True
        Me.CbxAgama.Items.AddRange(New Object() {"Kristen", "Katolik", "Islam", "Hindu", "Budha", "Kong Hu Chu"})
        Me.CbxAgama.Location = New System.Drawing.Point(138, 146)
        Me.CbxAgama.Name = "CbxAgama"
        Me.CbxAgama.Size = New System.Drawing.Size(121, 21)
        Me.CbxAgama.TabIndex = 30
        '
        'BtnBaru
        '
        Me.BtnBaru.Location = New System.Drawing.Point(27, 364)
        Me.BtnBaru.Name = "BtnBaru"
        Me.BtnBaru.Size = New System.Drawing.Size(75, 23)
        Me.BtnBaru.TabIndex = 29
        Me.BtnBaru.Text = "Baru"
        Me.BtnBaru.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.Location = New System.Drawing.Point(351, 364)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(75, 23)
        Me.BtnBatal.TabIndex = 28
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(270, 364)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(75, 23)
        Me.BtnHapus.TabIndex = 27
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(189, 364)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(75, 23)
        Me.BtnEdit.TabIndex = 26
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(108, 364)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.BtnSimpan.TabIndex = 25
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIS"
        '
        'DgvProfilSiswa
        '
        Me.DgvProfilSiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvProfilSiswa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NIS, Me.Nama, Me.Kelamin, Me.TmpLahir, Me.TglLahir, Me.Agama, Me.Alamat, Me.NamaWali, Me.Telp})
        Me.DgvProfilSiswa.Location = New System.Drawing.Point(478, 104)
        Me.DgvProfilSiswa.Name = "DgvProfilSiswa"
        Me.DgvProfilSiswa.Size = New System.Drawing.Size(481, 294)
        Me.DgvProfilSiswa.TabIndex = 26
        '
        'NIS
        '
        Me.NIS.DataPropertyName = "NIS"
        Me.NIS.HeaderText = "NIS"
        Me.NIS.Name = "NIS"
        Me.NIS.Width = 50
        '
        'Nama
        '
        Me.Nama.DataPropertyName = "Nama"
        Me.Nama.HeaderText = "Nama"
        Me.Nama.Name = "Nama"
        '
        'Kelamin
        '
        Me.Kelamin.DataPropertyName = "Kelamin"
        Me.Kelamin.HeaderText = "Jenis Kelamin"
        Me.Kelamin.Name = "Kelamin"
        Me.Kelamin.Width = 50
        '
        'TmpLahir
        '
        Me.TmpLahir.DataPropertyName = "TmpLahir"
        Me.TmpLahir.HeaderText = "Tempat Lahir"
        Me.TmpLahir.Name = "TmpLahir"
        Me.TmpLahir.Width = 70
        '
        'TglLahir
        '
        Me.TglLahir.DataPropertyName = "TglLahir"
        Me.TglLahir.HeaderText = "Tanggal Lahir"
        Me.TglLahir.Name = "TglLahir"
        Me.TglLahir.Width = 60
        '
        'Agama
        '
        Me.Agama.DataPropertyName = "Agama"
        Me.Agama.HeaderText = "Agama"
        Me.Agama.Name = "Agama"
        Me.Agama.Width = 70
        '
        'Alamat
        '
        Me.Alamat.DataPropertyName = "Alamat"
        Me.Alamat.HeaderText = "Alamat"
        Me.Alamat.Name = "Alamat"
        Me.Alamat.Width = 150
        '
        'NamaWali
        '
        Me.NamaWali.DataPropertyName = "NamaWali"
        Me.NamaWali.HeaderText = "Nama Wali"
        Me.NamaWali.Name = "NamaWali"
        '
        'Telp
        '
        Me.Telp.DataPropertyName = "Telp"
        Me.Telp.HeaderText = "Telp"
        Me.Telp.Name = "Telp"
        Me.Telp.Width = 80
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(490, 411)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 13)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Kelas"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(490, 438)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 13)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Tahun Ajaran"
        '
        'CbxTampilKelas
        '
        Me.CbxTampilKelas.FormattingEnabled = True
        Me.CbxTampilKelas.Location = New System.Drawing.Point(579, 408)
        Me.CbxTampilKelas.Name = "CbxTampilKelas"
        Me.CbxTampilKelas.Size = New System.Drawing.Size(121, 21)
        Me.CbxTampilKelas.TabIndex = 29
        '
        'CbxTampilThnAjaran
        '
        Me.CbxTampilThnAjaran.FormattingEnabled = True
        Me.CbxTampilThnAjaran.Location = New System.Drawing.Point(579, 435)
        Me.CbxTampilThnAjaran.Name = "CbxTampilThnAjaran"
        Me.CbxTampilThnAjaran.Size = New System.Drawing.Size(121, 21)
        Me.CbxTampilThnAjaran.TabIndex = 34
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Location = New System.Drawing.Point(886, 509)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(75, 23)
        Me.BtnKeluar.TabIndex = 35
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(109, 43)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(189, 13)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "Jl. Kranggan no 11, Yogyakarta 55233"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(109, 60)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(263, 13)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "Telp. 0274 562537, Email: infosd@budyawacana.com"
        '
        'PbxSDBW
        '
        Me.PbxSDBW.Image = Global.Form1.My.Resources.Resources.SDBW
        Me.PbxSDBW.Location = New System.Drawing.Point(103, 12)
        Me.PbxSDBW.Name = "PbxSDBW"
        Me.PbxSDBW.Size = New System.Drawing.Size(302, 28)
        Me.PbxSDBW.TabIndex = 37
        Me.PbxSDBW.TabStop = False
        '
        'PbxLogo
        '
        Me.PbxLogo.Image = Global.Form1.My.Resources.Resources.LogoSDBW
        Me.PbxLogo.Location = New System.Drawing.Point(12, 12)
        Me.PbxLogo.Name = "PbxLogo"
        Me.PbxLogo.Size = New System.Drawing.Size(85, 85)
        Me.PbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxLogo.TabIndex = 36
        Me.PbxLogo.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 539)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.PbxSDBW)
        Me.Controls.Add(Me.PbxLogo)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.CbxTampilThnAjaran)
        Me.Controls.Add(Me.CbxTampilKelas)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.DgvProfilSiswa)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Form3"
        Me.Text = "Data Siswa"
        Me.GbxGender.ResumeLayout(False)
        Me.GbxGender.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DgvProfilSiswa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxSDBW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtNIS As TextBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents TxtTmptLahir As TextBox
    Friend WithEvents GbxGender As GroupBox
    Friend WithEvents RBP As RadioButton
    Friend WithEvents RBL As RadioButton
    Friend WithEvents DtpTglLahir As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents RtbAlamat As RichTextBox
    Friend WithEvents TxtNamaWali As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtKontakWali As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnBatal As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvProfilSiswa As DataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents CbxTampilKelas As ComboBox
    Friend WithEvents CbxTampilThnAjaran As ComboBox
    Friend WithEvents BtnKeluar As Button
    Friend WithEvents PbxLogo As PictureBox
    Friend WithEvents PbxSDBW As PictureBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents CbxAgama As ComboBox
    Friend WithEvents BtnBaru As Button
    Friend WithEvents NIS As DataGridViewTextBoxColumn
    Friend WithEvents Nama As DataGridViewTextBoxColumn
    Friend WithEvents Kelamin As DataGridViewTextBoxColumn
    Friend WithEvents TmpLahir As DataGridViewTextBoxColumn
    Friend WithEvents TglLahir As DataGridViewTextBoxColumn
    Friend WithEvents Agama As DataGridViewTextBoxColumn
    Friend WithEvents Alamat As DataGridViewTextBoxColumn
    Friend WithEvents NamaWali As DataGridViewTextBoxColumn
    Friend WithEvents Telp As DataGridViewTextBoxColumn
End Class
