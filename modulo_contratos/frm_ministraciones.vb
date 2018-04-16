Public Class frm_ministraciones


    Private Sub frm_ministraciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_contratos.CONT_CPF_ministraciones' table. You can move, or remove it, as needed.
       
        Me.CONT_CPF_ministracionesTableAdapter.FillByCONTRATO(Me.DS_contratos.CONT_CPF_ministraciones, frm_contratos_alta.id_contrato)

    End Sub

    Private Sub CONT_CPF_ministracionesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CONT_CPF_ministracionesDataGridView.CellContentClick

    End Sub
End Class