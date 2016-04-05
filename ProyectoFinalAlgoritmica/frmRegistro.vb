Public Class frmRegistro


    Private Sub cbEdad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEdad.SelectedIndexChanged


        Dim edad As Integer
        edad = cbEdad.Text
        If edad <= 12 Then
            txtCategoria.Text = "Infantil"
        ElseIf edad <= 22 Then
            txtCategoria.Text = "Juvenil"
        ElseIf edad <= 30 Then
            txtCategoria.Text = "Mixto"
        ElseIf edad <= 40 Then
            txtCategoria.Text = "Veterano"

        End If
    End Sub

    Private Sub frmRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FutsoftDataSet.RegistroJugador' Puede moverla o quitarla según sea necesario.
        Me.RegistroJugadorTableAdapter.Fill(Me.FutsoftDataSet.RegistroJugador)
        For i = 5 To 40 Step 1

            cbEdad.Items.Add(i)

        Next
        For i = 5 To 40 Step 1

            cbEdaded.Items.Add(i)
        Next

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Me.RegistroJugadorTableAdapter.Insertar(txtid.Text, txtNombre.Text, txtPaterno.Text, txtMaterno.Text, txtNumero.Text, cbEdad.Text, txtCategoria.Text, txtEquipo.Text)
        Me.RegistroJugadorTableAdapter.Fill(Me.FutsoftDataSet.RegistroJugador)
        MsgBox("Los Datos fueron Guardados Correctamente", MsgBoxStyle.Information)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        frmMenu.Show()
        Me.Hide()

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtid.Clear()
        txtNombre.Clear()
        txtPaterno.Clear()
        txtMaterno.Clear()
        cbEdad.Text = "--Seleccione--"
        txtCategoria.Clear()
        txtEquipo.Clear()
        txtNumero.Clear()

    End Sub

    Private Sub btnNuevoed_Click(sender As Object, e As EventArgs) Handles btnNuevoed.Click
        txtided.Clear()
        txtNombreed.Clear()
        txtPaternoed.Clear()
        txtMaternoed.Clear()
        cbEdaded.Text = "--Seleccione--"
        txtCategoriaed.Clear()
        txtEquipoed.Clear()
        txtNumeroed.Clear()
    End Sub

    Private Sub btnGuardared_Click(sender As Object, e As EventArgs) Handles btnGuardared.Click
        Me.RegistroJugadorTableAdapter.Actualizar(txtided.Text, txtNombreed.Text, txtPaternoed.Text, txtMaternoed.Text, txtNumeroed.Text, cbEdaded.Text, txtCategoriaed.Text, txtEquipoed.Text)
        Me.RegistroJugadorTableAdapter.Fill(Me.FutsoftDataSet.RegistroJugador)
        MsgBox("Los Datos fueron Actualizados Correctamente", MsgBoxStyle.Information)
    End Sub

    Private Sub cbEdaded_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEdaded.SelectedIndexChanged
        Dim edad2 As Integer
        edad2 = cbEdaded.Text
        If edad2 <= 12 Then
            txtCategoriaed.Text = "Infantil"
        ElseIf edad2 <= 22 Then
            txtCategoriaed.Text = "Juvenil"
        ElseIf edad2 <= 30 Then
            txtCategoriaed.Text = "Mixto"
        ElseIf edad2 <= 40 Then
            txtCategoriaed.Text = "Veterano"

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.RegistroJugadorTableAdapter.Borrar(txtidel.Text)
        Me.RegistroJugadorTableAdapter.Fill(Me.FutsoftDataSet.RegistroJugador)
        MsgBox("El registro seleccionado fue borrado exitosamente", MsgBoxStyle.Information)
        txtidel.Clear()
    End Sub

    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click

    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Me.RegistroJugadorTableAdapter.FillBy(Me.FutsoftDataSet.RegistroJugador, txtConsulta.Text)

        DataGridView2.Visible = True

    End Sub

    Private Sub _selectToolStripButton_Click(sender As Object, e As EventArgs) Handles _selectToolStripButton.Click
        Try
            Me.RegistroJugadorTableAdapter._select(Me.FutsoftDataSet.RegistroJugador)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click

    End Sub

    Private Sub GuardarToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Me.RegistroJugadorTableAdapter.Insertar(txtid.Text, txtNombre.Text, txtPaterno.Text, txtMaterno.Text, txtNumero.Text, cbEdad.Text, txtCategoria.Text, txtEquipo.Text)
        Me.RegistroJugadorTableAdapter.Fill(Me.FutsoftDataSet.RegistroJugador)
        MsgBox("Los Datos fueron Guardados Correctamente", MsgBoxStyle.Information)
    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        txtid.Clear()
        txtNombre.Clear()
        txtPaterno.Clear()
        txtMaterno.Clear()
        cbEdad.Text = "--Seleccione--"
        txtCategoria.Clear()
        txtEquipo.Clear()
        txtNumero.Clear()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        Me.RegistroJugadorTableAdapter.FillBy(Me.FutsoftDataSet.RegistroJugador, txtConsulta.Text)

        DataGridView2.Visible = True
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click
        Me.RegistroJugadorTableAdapter.Actualizar(txtided.Text, txtNombreed.Text, txtPaternoed.Text, txtMaternoed.Text, txtNumeroed.Text, cbEdaded.Text, txtCategoriaed.Text, txtEquipoed.Text)
        Me.RegistroJugadorTableAdapter.Fill(Me.FutsoftDataSet.RegistroJugador)
        MsgBox("Los Datos fueron Actualizados Correctamente", MsgBoxStyle.Information)
    End Sub

    Private Sub LimpiarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem1.Click
        txtided.Clear()
        txtNombreed.Clear()
        txtPaternoed.Clear()
        txtMaternoed.Clear()
        cbEdaded.Text = "--Seleccione--"
        txtCategoriaed.Clear()
        txtEquipoed.Clear()
        txtNumeroed.Clear()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Me.RegistroJugadorTableAdapter.Borrar(txtidel.Text)
        Me.RegistroJugadorTableAdapter.Fill(Me.FutsoftDataSet.RegistroJugador)
        MsgBox("El registro seleccionado fue borrado exitosamente", MsgBoxStyle.Information)
        txtidel.Clear()
    End Sub

    Private Sub MenúToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenúToolStripMenuItem.Click
        frmMenu.Show()
        Me.Hide()
    End Sub
End Class