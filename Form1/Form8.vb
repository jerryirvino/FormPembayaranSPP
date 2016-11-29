Imports System.Data.SqlClient
Imports System.ComponentModel
Public Class Form8
    Public Kelas As New Tabel("Kelas")
    Private baru As Boolean
    Private kdLama As String

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DgvDataKelas.DataSource = Kelas.getBs()
        bind()
        modeSave()
        TxtJumlahKelas.Enabled = False
    End Sub

    Private Sub bind()
        TxtTingkat.DataBindings.Add("Text", Me.Kelas.getBs(), "Tingkat")
        TxtKelas.DataBindings.Add("Text", Me.Kelas.getBs(), "NamaKelas")
        TxtKeterangan.DataBindings.Add("Text", Me.Kelas.getBs(), "KetKelas")
    End Sub

    Sub modeSave()
        TxtTingkat.Enabled = False
        TxtKelas.Enabled = False
        TxtKeterangan.Enabled = False
    End Sub

    Sub modeEdit()
        TxtTingkat.Enabled = True
        TxtKelas.Enabled = True
        TxtKeterangan.Enabled = True
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        TxtTingkat.Text = ""
        TxtKelas.Text = ""
        TxtKeterangan.Text = ""
        modeEdit()
    End Sub

    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        modeEdit()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click

    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        modeSave()
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        modeSave()
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Me.Close()
    End Sub
End Class