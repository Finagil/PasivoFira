Public Class frmPagoManual
    Dim id_contrato As Integer

    Private Sub frmPagoManual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PagosDS.CONT_CPF_PagosFira' Puede moverla o quitarla según sea necesario.
        ' Me.CONT_CPF_PagosFiraTableAdapter.Fill(Me.PagosDS.CONT_CPF_PagosFira)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.Clientes' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_contratos' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_contratosTableAdapter.Fill(Me.DS_contratos.CONT_CPF_contratos)
        id_contrato = Me.CONT_CPF_contratosTableAdapter.idcontrato(frm_pagoAnticipo.id_credito)
        Me.CONT_CPF_contratosTableAdapter.FillByIDCREDITO(Me.DS_contratos.CONT_CPF_contratos, frm_pagoAnticipo.id_credito)
        'TODO: esta línea de código carga datos en la tabla 'PagosDS.CONT_CPF_vencimientos' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_vencimientosTableAdapter.Fill(Me.PagosDS.CONT_CPF_vencimientos, id_contrato)
        'TODO: esta línea de código carga datos en la tabla 'PagosDS.CONT_CPF_CalendariosRevisionTasa' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_CalendariosRevisionTasaTableAdapter.Fill(Me.PagosDS.CONT_CPF_CalendariosRevisionTasa, id_contrato)
        'Dim cliente As Integer = Me.CONTCPFcontratosBindingSource.Current("cliente")
        Me.ClientesTableAdapter.FillBycliente_contrato(Me.DS_contratos.Clientes, id_contrato)
    End Sub

    Private Sub bt_aplicar_Click(sender As Object, e As EventArgs) Handles bt_aplicar.Click
        Dim fecha_pago As String
        Dim fecha_aplicacion As Date

        fecha_aplicacion = dt_fecha.Text
        fecha_pago = fecha_aplicacion.ToString("ddMMyyyy")

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

        'agregar pagofira SOLO SI ES NUEVO
        Dim id_contrato_pago = Me.CONT_CPF_PagosFiraTableAdapter.ID_CONTRATO_PAGO(id_contrato, fecha_pago)
        '  If id_contrato_pago = 0 Then
        ' Me.CONT_CPF_PagosFiraTableAdapter.InsertQuery(id_contrato, fecha_aplicacion, txt_monto.Text, 0, fecha_pago, 0, frm_pagoAnticipo.id_credito, 0, 0)
        'End If

        'Agregar calendario tasa
        Dim id_calendario As Integer = Me.CONT_CPF_CalendariosRevisionTasaTableAdapter.id_calendario(fecha_aplicacion, id_contrato)
        If id_calendario = 0 Then
            Me.CONT_CPF_CalendariosRevisionTasaTableAdapter.InsertCalendario(id_contrato, dt_fecha.Text, 1, 0, 1, 1, 0)
        Else
            Me.CONT_CPF_CalendariosRevisionTasaTableAdapter.UpdateCalendario(id_contrato, fecha_aplicacion, 1, 0, 1, 1, 0, id_contrato, fecha_aplicacion)
        End If

        'Me.CONT_CPF_CalendariosRevisionTasaTableAdapter.InsertCalendario(id_contrato, dt_fecha.Text, 1, 0, 1, 1, 0)
        'Borrar vencimiento

        '  If sinanexo = True Then
        ' id_contrato = frm_contrato2.id_contrato2
        'Else

        'id_contrato = frm_contratos_alta.id_contrato

        'End If
        ' cambiar vencimientos 
        Me.CONT_CPF_vencimientosTableAdapter.DeleteQuery(id_contrato)
        'Agregar vencimiento del anticipo
        If txt_intereses.Text = "" Then
            txt_intereses.Text = 0
        End If



        Me.CONT_CPF_vencimientosTableAdapter.InsertVencimiento(fecha_aplicacion, txt_monto.Text, fecha_aplicacion, "pagada", txt_intereses.Text, id_contrato, 0)

        For Renglones As Integer = 0 To CONT_CPF_vencimientosDataGridView.RowCount - 2
            consecutivo = consecutivo + 1
            fecha = Me.CONT_CPF_vencimientosDataGridView.Item(1, Renglones).Value
            '  If Renglones <> 0 Then
            ' fechaaux = Me.CONT_CPF_vencimientosDataGridView.Item(0, Renglones - 1).Value
            'If fechaaux > fecha Then
            'MessageBox.Show("Error en la fecha programada", "MINISTRACIONES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Exit Sub
            'End If
            'End If

            monto = Me.CONT_CPF_vencimientosDataGridView.Item(2, Renglones).Value
            fechaup = Me.CONT_CPF_vencimientosDataGridView.Item(3, Renglones).Value
            intereses = Me.CONT_CPF_vencimientosDataGridView.Item(5, Renglones).Value

            estatus = Me.CONT_CPF_vencimientosDataGridView.Item(4, Renglones).Value


            Me.CONT_CPF_vencimientosTableAdapter.InsertVencimiento(fecha, monto, fechaup, estatus, intereses, id_contrato, 0)


        Next
        MessageBox.Show("se agrego el pago correctamente", "PAGO MANUAL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


    End Sub
End Class