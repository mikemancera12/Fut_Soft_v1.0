Public Class FrmLogin

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        End

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        MsgBox("¿Realmente desea salir de la Aplicación?", MsgBoxStyle.YesNo)
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (txtUsuario.Text = "mike") Then
            If txtContraseña.Text = "futbol1" Then
                Me.Close()
                MsgBox("Bienvenido, Haz iniciado sesión correctamente", MsgBoxStyle.Information)
                frmMenu.Show()
                Me.Close()
            Else

                MsgBox("Contraseña Incorrecta, por favor Verifica tus Datos", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("Nombre de Usuario Incorrecto, por favor Verifica tus Datos", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsuario.Text = "@usuario"
        txtContraseña.Text = "******"
    End Sub
End Class