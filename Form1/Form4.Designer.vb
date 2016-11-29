<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.GbxThnAjaran = New System.Windows.Forms.GroupBox()
        Me.CbxSemester = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtThnAjaran = New System.Windows.Forms.TextBox()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnBaru = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvThnAjaran = New System.Windows.Forms.DataGridView()
        Me.ThnAjaran = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Semester = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglMulai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglAkhir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PbxSDBW = New System.Windows.Forms.PictureBox()
        Me.PbxLogo = New System.Windows.Forms.PictureBox()
        Me.DtpMulai = New System.Windows.Forms.DateTimePicker()
        Me.DtpAkhir = New System.Windows.Forms.DateTimePicker()
        Me.GbxThnAjaran.SuspendLayout()
        CType(Me.DgvThnAjaran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxSDBW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbxThnAjaran
        '
        Me.GbxThnAjaran.Controls.Add(Me.DtpAkhir)
        Me.GbxThnAjaran.Controls.Add(Me.DtpMulai)
        Me.GbxThnAjaran.Controls.Add(Me.CbxSemester)
        Me.GbxThnAjaran.Controls.Add(Me.Label4)
        Me.GbxThnAjaran.Controls.Add(Me.TxtThnAjaran)
        Me.GbxThnAjaran.Controls.Add(Me.BtnKeluar)
        Me.GbxThnAjaran.Controls.Add(Me.BtnHapus)
        Me.GbxThnAjaran.Controls.Add(Me.BtnEdit)
        Me.GbxThnAjaran.Controls.Add(Me.BtnBaru)
        Me.GbxThnAjaran.Controls.Add(Me.Label3)
        Me.GbxThnAjaran.Controls.Add(Me.Label2)
        Me.GbxThnAjaran.Controls.Add(Me.Label1)
        Me.GbxThnAjaran.Location = New System.Drawing.Point(12, 103)
        Me.GbxThnAjaran.Name = "GbxThnAjaran"
        Me.GbxThnAjaran.Size = New System.Drawing.Size(389, 181)
        Me.GbxThnAjaran.TabIndex = 0
        Me.GbxThnAjaran.TabStop = False
        Me.GbxThnAjaran.Text = "Data Tahun Ajaran"
        '
        'CbxSemester
        '
        Me.CbxSemester.FormattingEnabled = True
        Me.CbxSemester.Items.AddRange(New Object() {"GANJIL", "GENAP"})
        Me.CbxSemester.Location = New System.Drawing.Point(106, 61)
        Me.CbxSemester.Name = "CbxSemester"
        Me.CbxSemester.Size = New System.Drawing.Size(150, 21)
        Me.CbxSemester.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Akhir"
        '
        'TxtThnAjaran
        '
        Me.TxtThnAjaran.Location = New System.Drawing.Point(106, 29)
        Me.TxtThnAjaran.Name = "TxtThnAjaran"
        Me.TxtThnAjaran.Size = New System.Drawing.Size(150, 20)
        Me.TxtThnAjaran.TabIndex = 10
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Location = New System.Drawing.Point(277, 152)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(75, 23)
        Me.BtnKeluar.TabIndex = 9
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(196, 152)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(75, 23)
        Me.BtnHapus.TabIndex = 8
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(115, 152)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(75, 23)
        Me.BtnEdit.TabIndex = 7
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnBaru
        '
        Me.BtnBaru.Location = New System.Drawing.Point(34, 152)
        Me.BtnBaru.Name = "BtnBaru"
        Me.BtnBaru.Size = New System.Drawing.Size(75, 23)
        Me.BtnBaru.TabIndex = 6
        Me.BtnBaru.Text = "Baru"
        Me.BtnBaru.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Mulai"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Semester"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tahun Ajaran"
        '
        'DgvThnAjaran
        '
        Me.DgvThnAjaran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvThnAjaran.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ThnAjaran, Me.Semester, Me.TglMulai, Me.TglAkhir})
        Me.DgvThnAjaran.Location = New System.Drawing.Point(13, 291)
        Me.DgvThnAjaran.Name = "DgvThnAjaran"
        Me.DgvThnAjaran.Size = New System.Drawing.Size(388, 180)
        Me.DgvThnAjaran.TabIndex = 1
        '
        'ThnAjaran
        '
        Me.ThnAjaran.DataPropertyName = "ThnAjaran"
        Me.ThnAjaran.HeaderText = "Tahun Ajaran"
        Me.ThnAjaran.Name = "ThnAjaran"
        '
        'Semester
        '
        Me.Semester.DataPropertyName = "Semester"
        Me.Semester.HeaderText = "Semester"
        Me.Semester.Name = "Semester"
        '
        'TglMulai
        '
        Me.TglMulai.DataPropertyName = "TglMulai"
        Me.TglMulai.HeaderText = "Tanggal Mulai"
        Me.TglMulai.Name = "TglMulai"
        '
        'TglAkhir
        '
        Me.TglAkhir.DataPropertyName = "TglAkhir"
        Me.TglAkhir.HeaderText = "Tanggal Akhir"
        Me.TglAkhir.Name = "TglAkhir"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(109, 60)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(263, 13)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "Telp. 0274 562537, Email: infosd@budyawacana.com"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(109, 43)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(189, 13)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "Jl. Kranggan no 11, Yogyakarta 55233"
        '
        'PbxSDBW
        '
        Me.PbxSDBW.Image = Global.Form1.My.Resources.Resources.SDBW
        Me.PbxSDBW.Location = New System.Drawing.Point(103, 12)
        Me.PbxSDBW.Name = "PbxSDBW"
        Me.PbxSDBW.Size = New System.Drawing.Size(302, 28)
        Me.PbxSDBW.TabIndex = 41
        Me.PbxSDBW.TabStop = False
        '
        'PbxLogo
        '
        Me.PbxLogo.Image = Global.Form1.My.Resources.Resources.LogoSDBW
        Me.PbxLogo.Location = New System.Drawing.Point(12, 12)
        Me.PbxLogo.Name = "PbxLogo"
        Me.PbxLogo.Size = New System.Drawing.Size(85, 85)
        Me.PbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxLogo.TabIndex = 40
        Me.PbxLogo.TabStop = False
        '
        'DtpMulai
        '
        Me.DtpMulai.Location = New System.Drawing.Point(106, 88)
        Me.DtpMulai.Name = "DtpMulai"
        Me.DtpMulai.Size = New System.Drawing.Size(200, 20)
        Me.DtpMulai.TabIndex = 14
        '
        'DtpAkhir
        '
        Me.DtpAkhir.Location = New System.Drawing.Point(106, 115)
        Me.DtpAkhir.Name = "DtpAkhir"
        Me.DtpAkhir.Size = New System.Drawing.Size(200, 20)
        Me.DtpAkhir.TabIndex = 15
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 485)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.DgvThnAjaran)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.GbxThnAjaran)
        Me.Controls.Add(Me.PbxSDBW)
        Me.Controls.Add(Me.PbxLogo)
        Me.Name = "Form4"
        Me.Text = "Data Tahun Ajaran"
        Me.GbxThnAjaran.ResumeLayout(False)
        Me.GbxThnAjaran.PerformLayout()
        CType(Me.DgvThnAjaran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxSDBW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GbxThnAjaran As GroupBox
    Friend WithEvents BtnKeluar As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnBaru As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvThnAjaran As DataGridView
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents PbxSDBW As PictureBox
    Friend WithEvents PbxLogo As PictureBox
    Friend WithEvents CbxSemester As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtThnAjaran As TextBox
    Friend WithEvents ThnAjaran As DataGridViewTextBoxColumn
    Friend WithEvents Semester As DataGridViewTextBoxColumn
    Friend WithEvents TglMulai As DataGridViewTextBoxColumn
    Friend WithEvents TglAkhir As DataGridViewTextBoxColumn
    Friend WithEvents DtpAkhir As DateTimePicker
    Friend WithEvents DtpMulai As DateTimePicker
End Class
