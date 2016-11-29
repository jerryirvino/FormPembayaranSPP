Imports System.Data.SqlClient
Public Class Form1

    Private Sub BtnMasuk_Click(sender As Object, e As EventArgs) Handles BtnMasuk.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        con.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=SiswaBW ;Integrated Security= True"
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "Select username, password from " &
        "Users where username = '" & TxtUsername.Text & "' and " &
        "password ='" & TxtPass.Text & "'"

        rd = cmd.ExecuteReader()

        If rd.HasRows Then
            Form2.Show()
        Else
            MessageBox.Show("Mohon maaf username dan password anda salah!")
        End If
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Me.Close()
    End Sub
End Class
