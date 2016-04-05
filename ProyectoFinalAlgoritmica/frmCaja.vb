Public Class frmCaja

    Private Sub frmCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cbFormapago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFormapago.SelectedIndexChanged

    End Sub

    Private Sub cbTipopago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipopago.SelectedIndexChanged

        Select Case cbTipopago.SelectedIndex
            Case 0
                txtTotal.Text = "80"
            Case 1
                txtTotal.Text = "350"
            Case 2
                txtTotal.Text = "400"
            Case 3
            Case 4
                txtTotal.Text = "20"
            Case 5
                txtTotal.Text = "50"


        End Select

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtCliente.Clear()
        txtCantidad.Clear()
        txtTotal.Clear()
        cbTipopago.Text = "--Seleccione--"
        cbFormapago.Text = "--Seleccione--"
        Label6.Visible = False
        Label6.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtCliente.Text = "" Then
            MsgBox("Debes ingresar todos los datos.")
            If txtCantidad.Text = "" Then
                MsgBox("Debes ingresar todos los datos.")
            End If
        Else
            total = txtTotal.Text
            recibida = txtCantidad.Text
            cambio = recibida - total

            MsgBox("Su Pago fue cobrado con éxito, vaya a la pestaña de Ticket para imprimir su recibo, Gracias", MsgBoxStyle.Information)
            Label6.Visible = True
            Label6.Text = total
            lblCliente.Visible = True
            lblCliente.Text = txtCliente.Text
            lblForma.Visible = True
            lblForma.Text = cbFormapago.Text
            lblTipopago.Visible = True
            lblTipopago.Text = cbTipopago.Text
            lblRecibida.Visible = True
            lblRecibida.Text = recibida
            lblCambio.Visible = True
            lblCambio.Text = cambio
        End If

      





    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        MsgBox("Su ticket se imprimio de forma satisfactoria", MsgBoxStyle.Information)
    End Sub



    Private Sub PictureBox4_Click_1(sender As Object, e As EventArgs) Handles PictureBox4.Click
        frmMenu.Show()
        Me.Hide()
    End Sub
End Class