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

    Private Sub bt_agregar_Click(sender As Object, e As EventArgs) Handles bt_agregar.Click
        Dim fecha, fechaup As Date
        Dim monto As Decimal = 0
        Dim intereses As Decimal = 0
        Dim porcentaje As Decimal = 0
        Dim importe As Decimal = 0
        Dim descuento As Date
        Dim consecutivo As Integer = 0
        Dim estatus As String
        Dim smonto As Decimal = 0
        Dim fechaaux As Date

        If sinanexo = True Then
            ID_Contrato = frm_contrato2.id_contrato2
        Else

            ID_Contrato = frm_contratos_alta.id_contrato

        End If


        For Renglones As Integer = 0 To CONT_CPF_vencimientosDataGridView.RowCount - 2
            consecutivo = consecutivo + 1
            fecha = Me.CONT_CPF_vencimientosDataGridView.Item(0, Renglones).Value
            If Renglones <> 0 Then
                fechaaux = Me.CONT_CPF_vencimientosDataGridView.Item(0, Renglones - 1).Value
                If fechaaux > fecha Then
                    MessageBox.Show("Error en la fecha programada", "MINISTRACIONES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            End If

            monto = Me.CONT_CPF_vencimientosDataGridView.Item(1, Renglones).Value
            fechaup = Me.CONT_CPF_vencimientosDataGridView.Item(2, Renglones).Value
            intereses = Me.CONT_CPF_vencimientosDataGridView.Item(4, Renglones).Value

            estatus = Me.CONT_CPF_vencimientosDataGridView.Item(3, Renglones).Value



            Me.CONT_CPF_vencimientosTableAdapter.InsertQueryVencimiento(fecha, monto, fechaup, estatus, intereses, ID_Contrato)

        Next
        MessageBox.Show("se agrego l vencimiento correctamente", "MINISTRACIONES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


    End Sub
End Class