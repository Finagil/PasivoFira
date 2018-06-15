Public Class Nuevo

    Public ID_Contrato As Integer

    Private Sub Frm_vencimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ID_Contrato <> 0 Then
        Else
            Me.CONT_CPF_vencimientosTableAdapter.FillBycontrato(Me.DS_contratos.CONT_CPF_vencimientos, frm_contratos_alta.id_contrato)
        End If


    End Sub

    Private Sub CONT_CPF_vencimientosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CONT_CPF_vencimientosDataGridView.CellContentClick

    End Sub
End Class