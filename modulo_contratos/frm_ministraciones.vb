Public Class frm_ministraciones


    Private Sub frm_ministraciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_contratos' Puede moverla o quitarla según sea necesario.
        '    Me.CONT_CPF_contratosTableAdapter.Fill(Me.DS_contratos.CONT_CPF_contratos)
        'TODO: This line of code loads data into the 'DS_contratos.CONT_CPF_ministraciones' table. You can move, or remove it, as needed.
        If sinanexo = True And frm_contratos_alta.id_contrato = 0 Then
            Me.CONT_CPF_ministracionesTableAdapter.FillByCONTRATO(Me.DS_contratos.CONT_CPF_ministraciones, frm_contrato2.id_contrato2)
        Else
            Me.CONT_CPF_ministracionesTableAdapter.FillByCONTRATO(Me.DS_contratos.CONT_CPF_ministraciones, frm_contratos_alta.id_contrato)

        End If

        '  If frm_contratos_alta.id_contrato = 0 Then

        'Else

        'End If

    End Sub

    Private Sub bt_agregar_Click(sender As Object, e As EventArgs) Handles bt_agregar.Click
        Dim fecha As Date
        Dim monto As Decimal = 0
        Dim iva As Decimal = 0
        Dim porcentaje As Decimal = 0
        Dim importe As Decimal = 0
        Dim descuento As Date
        Dim consecutivo As Integer = 0
        Dim estatus As String
        Dim smonto As Decimal = 0
        Dim fechaaux As Date
        Dim idcontrato As Integer

        'SUMAR MONTO TOTAL Y VALIDAD QUE NO EXCEDA EL MONTO FINANCIADO
        Dim MontoFinanciado As Decimal = 0
        If sinanexo = True Then
            idcontrato = frm_contrato2.id_contrato2
        Else
            idcontrato = frm_contratos_alta.id_contrato
        End If

        MontoFinanciado = Me.CONT_CPF_contratosTableAdapter.monto_contrato(idcontrato)

        For Renglones As Integer = 0 To CONT_CPF_ministracionesDataGridView.RowCount - 2
            smonto = smonto + Me.CONT_CPF_ministracionesDataGridView.Item(2, Renglones).Value
        Next

        If MontoFinanciado <> smonto Then
            MessageBox.Show("La suma del monto " & monto & " no coincide con el monto Financiado: " & MontoFinanciado, "MINISTRACIONES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ' MsgBox("La suma del monto " & monto & " no coincide con el monto Financiado: " & MontoFinanciado)
        Else

            Me.CONT_CPF_ministracionesTableAdapter.deletreministracion(idcontrato)

            For Renglones As Integer = 0 To CONT_CPF_ministracionesDataGridView.RowCount - 2
                consecutivo = consecutivo + 1
                fecha = Me.CONT_CPF_ministracionesDataGridView.Item(1, Renglones).Value
                If Renglones <> 0 Then
                    fechaaux = Me.CONT_CPF_ministracionesDataGridView.Item(1, Renglones - 1).Value
                    If fechaaux > fecha Then
                        MessageBox.Show("Error en la fecha programada", "MINISTRACIONES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                End If

                monto = Me.CONT_CPF_ministracionesDataGridView.Item(2, Renglones).Value
                porcentaje = Me.CONT_CPF_ministracionesDataGridView.Item(3, Renglones).Value
                iva = Me.CONT_CPF_ministracionesDataGridView.Item(4, Renglones).Value
                importe = Me.CONT_CPF_ministracionesDataGridView.Item(5, Renglones).Value
                estatus = Me.CONT_CPF_ministracionesDataGridView.Item(6, Renglones).Value
                descuento = Me.CONT_CPF_ministracionesDataGridView.Item(7, Renglones).Value



                Me.CONT_CPF_ministracionesTableAdapter.InsertQueryMinistracion(monto, fecha, consecutivo, porcentaje, iva, importe, idcontrato, estatus, descuento)

            Next
            MessageBox.Show("se agrego ministracion correctamente", "MINISTRACIONES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            'Me.CONT_CPF_ministracionesDataGridView.DataBindings.Clear()

            '     Me.CONT_CPF_ministracionesDataGridView.DataSource = Nothing
            '    Me.CONT_CPF_ministracionesTableAdapter.FillByCONTRATO(Me.DS_contratos.CONT_CPF_ministraciones, frm_contratos_alta.id_contrato)
        End If

    End Sub

    Private Sub CONT_CPF_ministracionesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CONT_CPF_ministracionesDataGridView.CellContentClick

    End Sub

    Private Sub bt_eliminar_Click(sender As Object, e As EventArgs) Handles bt_eliminar.Click
        ' deleterenglonmin
        Dim id As Integer
        id = txt_id.Text
        Me.CONT_CPF_ministracionesTableAdapter.borrarMIN(id)
        'Me.CONT_CPF_ministracionesDataGridView.DataSource = Nothing
        'Me.CONT_CPF_ministracionesTableAdapter.FillByCONTRATO(Me.DS_contratos.CONT_CPF_ministraciones, frm_contratos_alta.id_contrato)
        MessageBox.Show("se eliminó ministracion correctamente", "MINISTRACIONES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub bt_modificar_Click(sender As Object, e As EventArgs) Handles bt_modificar.Click
        Dim fecha As Date
        Dim monto As Decimal = 0
        Dim iva As Decimal = 0
        Dim porcentaje As Decimal = 0
        Dim importe As Decimal = 0
        Dim descuento As Date
        Dim consecutivo As Integer = 0
        Dim estatus As String
        Dim smonto As Decimal = 0
        Dim fechaaux As Date

        'SUMAR MONTO TOTAL Y VALIDAD QUE NO EXCEDA EL MONTO FINANCIADO
        Dim MontoFinanciado As Decimal = 0
        MontoFinanciado = Me.CONT_CPF_contratosTableAdapter.monto_contrato(frm_contratos_alta.id_contrato)

        For Renglones As Integer = 0 To CONT_CPF_ministracionesDataGridView.RowCount - 2
            smonto = smonto + Me.CONT_CPF_ministracionesDataGridView.Item(2, Renglones).Value
        Next

        If MontoFinanciado <> smonto Then
            MessageBox.Show("La suma del monto " & monto & " no coincide con el monto Financiado: " & MontoFinanciado, "MINISTRACIONES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ' MsgBox("La suma del monto " & monto & " no coincide con el monto Financiado: " & MontoFinanciado)
        Else

            ' Me.CONT_CPF_ministracionesTableAdapter.deletreministracion(frm_contratos_alta.id_contrato)

            '  For Renglones As Integer = 0 To CONT_CPF_ministracionesDataGridView.RowCount - 2

            '                smonto = smonto + Me.CONT_CPF_ministracionesDataGridView.Item(2, Renglones).Value
            Dim r As Integer
            r = Me.CONT_CPF_ministracionesDataGridView.CurrentRow.Index

            'For Columnas As Integer = 0 To CONT_CPF_ministracionesDataGridView.ColumnCount - 1
            '   consecutivo = consecutivo + 1
            fecha = Me.CONT_CPF_ministracionesDataGridView.Item(1, r).Value
            If r <> 0 Then
                fechaaux = Me.CONT_CPF_ministracionesDataGridView.Item(1, r - 1).Value
                If fechaaux > fecha Then
                    MessageBox.Show("Error en la fecha programada", "MINISTRACIONES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            End If
            monto = Me.CONT_CPF_ministracionesDataGridView.Item(2, r).Value
            porcentaje = Me.CONT_CPF_ministracionesDataGridView.Item(3, r).Value
            iva = Me.CONT_CPF_ministracionesDataGridView.Item(4, r).Value
            importe = Me.CONT_CPF_ministracionesDataGridView.Item(5, r).Value
            estatus = Me.CONT_CPF_ministracionesDataGridView.Item(6, r).Value
            descuento = Me.CONT_CPF_ministracionesDataGridView.Item(7, r).Value
            Dim idmin As Integer
            idmin = txt_id.Text
            Me.CONT_CPF_ministracionesTableAdapter.UpdateQueryMinistracion(monto, fecha, porcentaje, iva, importe, estatus, descuento, idmin)


            '    Me.CONT_CPF_ministracionesTableAdapter.InsertQueryMinistracion(monto, fecha, consecutivo, porcentaje, iva, importe, frm_contratos_alta.id_contrato, estatus, descuento)
            '  Next



            'Next
            MessageBox.Show("se modificó ministracion correctamente", "MINISTRACIONES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ' Me.Close()
            '   Me.CONT_CPF_ministracionesTableAdapter.FillByCONTRATO(Me.DS_contratos.CONT_CPF_ministraciones, frm_contratos_alta.id_contrato)
            '     Me.CONT_CPF_ministracionesDataGridView.DataSource = Nothing
            ' Me.CONT_CPF_ministracionesTableAdapter
            ' Me.CONT_CPF_ministracionesDataGridView.DataSource = Me.CONT_CPF_ministracionesTableAdapter.FillByCONTRATO(Me.DS_contratos.CONT_CPF_ministraciones, frm_contratos_alta.id_contrato)
            Me.CONT_CPF_ministracionesDataGridView.DataBindings.Clear()
            Me.CONT_CPF_ministracionesTableAdapter.FillByCONTRATO(Me.DS_contratos.CONT_CPF_ministraciones, frm_contratos_alta.id_contrato)
        End If
    End Sub
End Class