Public Class frm_acreditados_edit
    Private Sub frm_acreditados_edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AcreditadosDS.CONT_CPF_acreditado' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_acreditadoTableAdapter.Fill(Me.AcreditadosDS.CONT_CPF_acreditado)

    End Sub

    Private Sub txtcliente_TextChanged(sender As Object, e As EventArgs) Handles txtcliente.TextChanged

    End Sub
End Class