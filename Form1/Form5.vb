Public Class Form5
    Private pemb As New Tabel("SPP")
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
        MessageBox.Show("Pembayaran dengan NIS : " & nis & "sukses diinputkan")

    End Sub

    Sub viewMode()

    End Sub

End Class