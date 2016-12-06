Public Class Form5
    Private pemb As New Tabel("SPP")
    Sub viewMode()
        TxtNoInvoice.Enabled = False
        DtpTglSPP.Enabled = False
        TxtNIS.Enabled = False
        TxtNama.Enabled = False
        CbxThnAjaran.Enabled = False
        TxtKelas.Enabled = False
        TxtUangSPP.Enabled = False
        CbxBlnBayar.Enabled = False
        CbxThnBayar.Enabled = False
        BtnCetak.Visible = False
        BtnBaru.Visible = True
    End Sub

    Sub editMode()
        TxtNoInvoice.Enabled = True
        DtpTglSPP.Enabled = True
        TxtNIS.Enabled = True
        TxtNama.Enabled = True
        CbxThnAjaran.Enabled = True
        TxtKelas.Enabled = True
        TxtUangSPP.Enabled = True
        CbxBlnBayar.Enabled = True
        CbxThnBayar.Enabled = True
        BtnCetak.Visible = True
        BtnBaru.Visible = False
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Dim strsql, nin, tg, nis, nm, ta, kls, spp, bl, th As String
        nin = TxtNoInvoice.Text
        tg = DtpTglSPP.Value
        nis = TxtNIS.Text
        nm = TxtNama.Text
        ta = CbxThnAjaran.Text
        kls = TxtKelas.Text
        spp = TxtUangSPP.Text
        bl = CbxBlnBayar.Text
        th = CbxThnBayar.Text
        strsql = "INSERT INTO SPP(No_Invoice,Tanggal,NIS,Nama," &
            "Thn_Ajaran,Kelas,Bayar,Bulan,Tahun) Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')"
        strsql = String.Format(strsql, nin, tg, nis, nm, ta, kls, spp, bl, th)
        pemb.isiDataTable(strsql)
        '? masih bingung ni gimana cara ngecek itu data udah masuk apa belom
        'kalo udah tau suksesnya di bawah. kalo gagal, tinggal d tulis gagal
        MessageBox.Show("Pembayaran dengan NIS : " & nis & "sukses diinputkan")

        viewMode()
    End Sub

    Private Sub BtnBaru_Click(sender As Object, e As EventArgs) Handles BtnBaru.Click
        TxtNoInvoice.Clear()
        DtpTglSPP.Value = Date.Now
        TxtNIS.Clear()
        TxtNama.Clear()
        CbxThnAjaran.Text = ""
        TxtKelas.Clear()
        TxtUangSPP.Clear()
        CbxBlnBayar.Text = ""
        CbxThnBayar.Text = ""
        editMode()
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Me.Close()
    End Sub

    Private Sub BtnCetak_Click(sender As Object, e As EventArgs) Handles BtnCetak.Click
        'cari di internet codingannya
    End Sub
End Class