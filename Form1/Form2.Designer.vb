<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataSiswaTSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataTahunAjaranTSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarTSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeuanganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SPPTSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.DPPTSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.AktifitasPilihanTSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanTSM = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TentangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataKelasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.KeuanganToolStripMenuItem, Me.AdminToolStripMenuItem, Me.TentangToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(584, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataSiswaTSM, Me.DataKelasToolStripMenuItem, Me.DataTahunAjaranTSM, Me.KeluarTSM})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'DataSiswaTSM
        '
        Me.DataSiswaTSM.Name = "DataSiswaTSM"
        Me.DataSiswaTSM.Size = New System.Drawing.Size(172, 22)
        Me.DataSiswaTSM.Text = "Data Siswa"
        '
        'DataTahunAjaranTSM
        '
        Me.DataTahunAjaranTSM.Name = "DataTahunAjaranTSM"
        Me.DataTahunAjaranTSM.Size = New System.Drawing.Size(172, 22)
        Me.DataTahunAjaranTSM.Text = "Data Tahun Ajaran"
        '
        'KeluarTSM
        '
        Me.KeluarTSM.Name = "KeluarTSM"
        Me.KeluarTSM.Size = New System.Drawing.Size(172, 22)
        Me.KeluarTSM.Text = "Keluar"
        '
        'KeuanganToolStripMenuItem
        '
        Me.KeuanganToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SPPTSM, Me.DPPTSM, Me.AktifitasPilihanTSM, Me.LaporanTSM})
        Me.KeuanganToolStripMenuItem.Name = "KeuanganToolStripMenuItem"
        Me.KeuanganToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.KeuanganToolStripMenuItem.Text = "Pembayaran"
        '
        'SPPTSM
        '
        Me.SPPTSM.Name = "SPPTSM"
        Me.SPPTSM.Size = New System.Drawing.Size(156, 22)
        Me.SPPTSM.Text = "SPP"
        '
        'DPPTSM
        '
        Me.DPPTSM.Name = "DPPTSM"
        Me.DPPTSM.Size = New System.Drawing.Size(156, 22)
        Me.DPPTSM.Text = "DPP"
        '
        'AktifitasPilihanTSM
        '
        Me.AktifitasPilihanTSM.Name = "AktifitasPilihanTSM"
        Me.AktifitasPilihanTSM.Size = New System.Drawing.Size(156, 22)
        Me.AktifitasPilihanTSM.Text = "Aktifitas Pilihan"
        '
        'LaporanTSM
        '
        Me.LaporanTSM.Name = "LaporanTSM"
        Me.LaporanTSM.Size = New System.Drawing.Size(156, 22)
        Me.LaporanTSM.Text = "Laporan"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'TentangToolStripMenuItem
        '
        Me.TentangToolStripMenuItem.Name = "TentangToolStripMenuItem"
        Me.TentangToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.TentangToolStripMenuItem.Text = "Tentang"
        '
        'DataKelasToolStripMenuItem
        '
        Me.DataKelasToolStripMenuItem.Name = "DataKelasToolStripMenuItem"
        Me.DataKelasToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.DataKelasToolStripMenuItem.Text = "Data Kelas"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 379)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataSiswaTSM As ToolStripMenuItem
    Friend WithEvents DataTahunAjaranTSM As ToolStripMenuItem
    Friend WithEvents KeluarTSM As ToolStripMenuItem
    Friend WithEvents KeuanganToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SPPTSM As ToolStripMenuItem
    Friend WithEvents DPPTSM As ToolStripMenuItem
    Friend WithEvents AktifitasPilihanTSM As ToolStripMenuItem
    Friend WithEvents LaporanTSM As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TentangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataKelasToolStripMenuItem As ToolStripMenuItem
End Class
