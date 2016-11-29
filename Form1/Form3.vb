Imports System.Data.SqlClient
Imports System.ComponentModel
Public Class Form3
    Public siswa As New Tabel("Siswa")
    Private baru As Boolean
    Private kdLama As String
    Private gender As String

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DgvProfilSiswa.DataSource = siswa.getBs()
        bind()
        modeSave()
        CbxTampilThnAjaran.Text = "2016-2017"
    End Sub

    Private Sub bind()
        TxtNIS.DataBindings.Add("Text", Me.siswa.getBs(), "NIS")
        TxtNama.DataBindings.Add("Text", Me.siswa.getBs(), "Nama")
        TxtTmptLahir.DataBindings.Add("Text", Me.siswa.getBs(), "TmpLahir")
        DtpTglLahir.DataBindings.Add("Text", Me.siswa.getBs(), "TglLahir")
        CbxAgama.DataBindings.Add("Text", Me.siswa.getBs(), "Agama")
        RtbAlamat.DataBindings.Add("Text", Me.siswa.getBs(), "Alamat")
        TxtNamaWali.DataBindings.Add("Text", Me.siswa.getBs(), "NamaWali")
        TxtKontakWali.DataBindings.Add("Text", Me.siswa.getBs(), "Telp")

    End Sub

    Sub modeSave()
        TxtNIS.Enabled = False
        TxtNama.Enabled = False
        GbxGender.Enabled = False
        TxtTmptLahir.Enabled = False
        DtpTglLahir.Enabled = False
        CbxAgama.Enabled = False
        RtbAlamat.Enabled = False
        TxtNamaWali.Enabled = False
        TxtKontakWali.Enabled = False
        CbxTampilKelas.Enabled = False
        CbxTampilThnAjaran.Enabled = False
    End Sub

    Sub modeEdit()
        TxtNIS.Enabled = True
        TxtNama.Enabled = True
        GbxGender.Enabled = True
        TxtTmptLahir.Enabled = True
        DtpTglLahir.Enabled = True
        CbxAgama.Enabled = True
        RtbAlamat.Enabled = True
        TxtNamaWali.Enabled = True
        TxtKontakWali.Enabled = True
    End Sub

    Private Sub BtnBaru_Click(sender As Object, e As EventArgs) Handles BtnBaru.Click
        TxtNIS.Text = ""
        TxtNama.Text = ""
        If RBL.Checked Then
            gender = "L"
        Else
            gender = "P"
        End If
        TxtTmptLahir.Text = ""
        DtpTglLahir.Text = ""
        CbxAgama.Text = "Kristen" '<-- salah satu dari yg tersedia di Combo Box
        RtbAlamat.Text = ""
        TxtNamaWali.Text = ""
        TxtKontakWali.Text = ""
        modeEdit()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        modeSave()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        modeEdit()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click

    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        modeSave()
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Me.Close()
    End Sub
End Class