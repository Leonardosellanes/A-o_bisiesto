Public Class frmMenu

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Public Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        txtNombre.SelectionLength = 0

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click
        If (txtNombre.Text <> "") Then
            frmAño.Show()
            Me.Hide()

        Else
            MsgBox("Por favor,ingresa tu nombre para continuar")

        End If
        txtNombre.Clear()
    End Sub

End Class
