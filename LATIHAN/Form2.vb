Imports System.Data.SqlClient

Public Class Form2

    Private Sub T_userBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.T_userBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Penjualan_barangDataSet1)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MsgBox("Silakan isi Username dan Password")
        Else
            Call koneksi()
            Cmd = New SqlCommand("Select * From t_user where id = '" & UsernameTextBox.Text & "' and password = '" & PasswordTextBox.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("username atau Password Salah")
            End If
        End If
    End Sub
End Class