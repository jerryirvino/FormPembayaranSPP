Public Class Form2
    Private Sub DataSiswaTSM_Click(sender As Object, e As EventArgs) Handles DataSiswaTSM.Click
        Form3.Show()
    End Sub

    Private Sub DataKelasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataKelasToolStripMenuItem.Click
        Form8.Show()
    End Sub

    Private Sub DataTahunAjaranTSM_Click(sender As Object, e As EventArgs) Handles DataTahunAjaranTSM.Click
        Form4.Show()
    End Sub

    Private Sub KeluarTSM_Click(sender As Object, e As EventArgs) Handles KeluarTSM.Click
        Me.Close()
    End Sub
End Class