Public Class Nuevo

   

    Private Sub Frm_vencimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.CONT_CPF_vencimientosTableAdapter.FillBycontrato(Me.DS_contratos.CONT_CPF_vencimientos, frm_contratos_alta.id_contrato)

    End Sub


End Class