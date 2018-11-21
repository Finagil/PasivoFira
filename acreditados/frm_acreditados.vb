Public Class frm_acreditados
    Private Sub frm_acreditados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AcreditadosDS.CONT_CPF_acreditado' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_acreditadoTableAdapter.Fill(Me.AcreditadosDS.CONT_CPF_acreditado)
        'TODO: esta línea de código carga datos en la tabla 'AcreditadosDS.Vw_FIRA_Acreditados_Layout' Puede moverla o quitarla según sea necesario.
        Me.Vw_FIRA_Acreditados_LayoutTableAdapter.Fill(Me.AcreditadosDS.Vw_FIRA_Acreditados_Layout)

    End Sub

    Private Sub txtcliente_TextChanged(sender As Object, e As EventArgs) Handles txtcliente.TextChanged
        Me.VwFIRAAcreditadosLayoutBindingSource.Filter = "nombre like '%" & txtcliente.Text.Trim & "%'"
    End Sub

    Private Sub bt_Guardar_Click(sender As Object, e As EventArgs) Handles bt_Guardar.Click
        Me.CONT_CPF_acreditadoTableAdapter.InsertQuery(txt_tipo.Text, txt_curp.Text, txt_nombre.Text, txt_apaterno.Text, txt_amaterno.Text, txt_Nacionalidad.Text, txt_Calle.Text,
                                                       txt_numext.Text, txt_numint.Text, txt_cp.Text, txt_edo.Text, txt_municipio.Text, txt_localidad.Text, txt_ingreso.Text,
                                                       txt_edoinv.Text, txt_municipioinv.Text, txt_localidadinv.Text, txt_scian.Text, txt_clave.Text, txt_clave.Text, txt_capital.Text,
                                                       txt_ventas.Text, txt_tec.Text, txt_cliente.Text)


        MessageBox.Show("Contrato Guardado", "CONTRATOS CARTERA PASIVA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.Vw_FIRA_Acreditados_LayoutTableAdapter.Fill(Me.AcreditadosDS.Vw_FIRA_Acreditados_Layout)
    End Sub
End Class