Public Class frmAño
    Private Sub frmAño_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label2.Text = frmMenu.txtNombre.Text
        lblName.Hide()
        lblGracias.Hide()
        lblUseryear.Hide()
        lblMaria.Hide()
        btnInicio.Hide()
        btnSalir.Hide()
    End Sub
    Private Sub txtAño_TextChanged(sender As Object, e As EventArgs) Handles txtAño.TextChanged
        txtAño.SelectionLength = 0
        Dim anio As Integer
        anio = Val(txtAño.Text)
    End Sub
    Public Function CalcularAnio(ByVal Anio As Integer) As Boolean
        Dim Tf As Boolean
        If Anio Mod 400 = 0 Then
            Tf = True
        Else
            If Anio Mod 100 = 0 Then
                Tf = False
            Else
                If Anio Mod 4 = 0 Then
                    Tf = True
                Else
                    Tf = False
                End If
            End If
        End If

        Return Tf
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim Anio As Integer
        Anio = Val(txtAño.Text)
        Dim bi As Boolean
        bi = CalcularAnio(Anio)
        If (Anio <> 0) Then
            Select Case bi
                Case True
                    lblUseryear.Text = "El año " & Anio & " es bisiesto"
                    lblUseryear.ForeColor = Color.Green
                    lblUseryear.Show()
                    lblGracias.Show()
                    lblMaria.Show()
                    lblName.Show()
                Case False
                    lblUseryear.Text = "El año no " & Anio & " es bisiesto"
                    lblUseryear.ForeColor = Color.Red
                    lblUseryear.Show()
                    lblGracias.Show()
                    lblMaria.Show()
                    lblName.Show()
            End Select
        Else
            MsgBox("¡No puedo hacer mis calculos si no ingresas un Año!")

        End If
        txtAño.Clear()
        btnInicio.Show()
        btnSalir.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles lblName.Click

    End Sub

    Private Sub lblAño_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblUseryear_Click(sender As Object, e As EventArgs) Handles lblUseryear.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblGracias_Click(sender As Object, e As EventArgs) Handles lblGracias.Click

    End Sub

    Private Sub lblMaria_Click(sender As Object, e As EventArgs) Handles lblMaria.Click

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        frmMenu.Close()
        Me.Close()
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        frmMenu.Show()
        Me.Hide()

    End Sub

    Private Sub frmAño_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmMenu.Close()
    End Sub
End Class