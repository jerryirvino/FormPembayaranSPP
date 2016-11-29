Imports System.Data.SqlClient
Imports System.ComponentModel
Public Class Form4
    Public tahunAjaran As New Tabel("TahunAjaran")
    Private baru As Boolean
    Private kdLama As String

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DgvThnAjaran.DataSource = tahunAjaran.getBs()
        bind()
        modeSave()
    End Sub

    Private Sub bind()
        TxtThnAjaran.DataBindings.Add("Text", Me.tahunAjaran.getBs(), "ThnAjaran")
        CbxSemester.DataBindings.Add("Text", Me.tahunAjaran.getBs(), "Semester")
        DtpMulai.DataBindings.Add("Text", Me.tahunAjaran.getBs(), "TglMulai")
        DtpAkhir.DataBindings.Add("Text", Me.tahunAjaran.getBs(), "TglAkhir")
    End Sub

    Sub modeSave()
        TxtThnAjaran.Enabled = False
        CbxSemester.Enabled = False
        DtpMulai.Enabled = False
        DtpAkhir.Enabled = False
    End Sub
End Class