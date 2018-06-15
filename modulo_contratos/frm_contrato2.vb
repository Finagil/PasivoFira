Public Class frm_contrato2
    Dim num_control, z25 As String
    Public Shared id_contrato, id_subrama As Integer
    Public Ministracion1, existe As Boolean
    Dim fecha As Date
    Public PCXSG As Decimal = 0
    Public PCXSG_Aux As Decimal = 0
    Public Nominal As Decimal = 0
    Public Efectiva As Decimal = 0
    Public ID_garantina As Integer = 0

    Private Sub txtcliente_TextChanged(sender As Object, e As EventArgs) Handles txtcliente.TextChanged
        Me.ClientesBindingSource.Filter = "descr like '%" & txtcliente.Text.Trim & "%'"
        'cbclientes_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub frm_contrato2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos1.CONT_CPF_vencimientos' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_vencimientosTableAdapter.Fill(Me.DS_contratos1.CONT_CPF_vencimientos)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos1.CONT_CPF_ministraciones' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_ministracionesTableAdapter.Fill(Me.DS_contratos1.CONT_CPF_ministraciones)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_contratos' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_contratosTableAdapter.Fill(Me.DS_contratos.CONT_CPF_contratos)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_configuracion' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_configuracionTableAdapter.Fill(Me.DS_contratos.CONT_CPF_configuracion)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.GEN_ProductosFinagil' Puede moverla o quitarla según sea necesario.
        Me.GEN_ProductosFinagilTableAdapter.Fill(Me.DS_contratos.GEN_ProductosFinagil)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_tipoprestamos' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_tipoprestamosTableAdapter.Fill(Me.DS_contratos.CONT_CPF_tipoprestamos)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.vw_conceptos_inversion' Puede moverla o quitarla según sea necesario.
        Me.Vw_conceptos_inversionTableAdapter.Fill(Me.DS_contratos.vw_conceptos_inversion)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_programas' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_programasTableAdapter.Fill(Me.DS_contratos.CONT_CPF_programas)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_cadenas' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_cadenasTableAdapter.Fill(Me.DS_contratos.CONT_CPF_cadenas)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_ramas' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_ramasTableAdapter.Fill(Me.DS_contratos.CONT_CPF_ramas)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_actividad' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_actividadTableAdapter.Fill(Me.DS_contratos.CONT_CPF_actividad)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_unidades_medida' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_unidades_medidaTableAdapter.Fill(Me.DS_contratos.CONT_CPF_unidades_medida)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_periodicidad' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_periodicidadTableAdapter.Fill(Me.DS_contratos.CONT_CPF_periodicidad)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_clasificacion_garantias' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_clasificacion_garantiasTableAdapter.Fill(Me.DS_contratos.CONT_CPF_clasificacion_garantias)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_ESTATUS' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_ESTATUSTableAdapter.Fill(Me.DS_contratos.CONT_CPF_ESTATUS)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_tipo_tasas' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_tipo_tasasTableAdapter.Fill(Me.DS_contratos.CONT_CPF_tipo_tasas)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_esquema_cobro' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_esquema_cobroTableAdapter.Fill(Me.DS_contratos.CONT_CPF_esquema_cobro)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_seguros' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_segurosTableAdapter.Fill(Me.DS_contratos.CONT_CPF_seguros)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_divisas' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_divisasTableAdapter.Fill(Me.DS_contratos.CONT_CPF_divisas)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_sucursales' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_sucursalesTableAdapter.Fill(Me.DS_contratos.CONT_CPF_sucursales)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_productos_fira' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_productos_firaTableAdapter.Fill(Me.DS_contratos.CONT_CPF_productos_fira)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_operacion' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_operacionTableAdapter.Fill(Me.DS_contratos.CONT_CPF_operacion)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_intermediarios' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_intermediariosTableAdapter.Fill(Me.DS_contratos.CONT_CPF_intermediarios)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.FillBytodos(Me.DS_contratos.Clientes)

    End Sub

    Private Sub cbclientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbclientes.SelectedIndexChanged

    End Sub

    Private Sub cb_rama_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_rama.SelectedIndexChanged

    End Sub

    Private Sub cb_rama_SelectedValueChanged(sender As Object, e As EventArgs) Handles cb_rama.SelectedValueChanged
        If cb_rama.SelectedIndex >= 0 Then
            Me.CONT_CPF_subramasTableAdapter.Fill(Me.DS_contratos.CONT_CPF_subramas, cb_rama.SelectedValue)

        End If
    End Sub

    Private Sub cb_subrama_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_subrama.SelectedIndexChanged

    End Sub

    Private Sub txt_clave_TextChanged(sender As Object, e As EventArgs) Handles txt_clave.TextChanged
        If txt_clave.Text.Length > 0 Then
            Me.CONT_CPF_conceptos_inversionTableAdapter.Fill(Me.DS_contratos.CONT_CPF_conceptos_inversion, txt_clave.Text, cb_rama.SelectedValue)

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.CONT_CPF_ministracionesTableAdapter.FillByCONTRATO(Me.DS_contratos.CONT_CPF_ministraciones, frm_contrato2.id_contrato)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If frm_contrato2.id_contrato <> 0 Then
        Else
            Me.CONT_CPF_vencimientosTableAdapter.FillBycontrato(Me.DS_contratos.CONT_CPF_vencimientos, frm_contratos_alta.id_contrato)
        End If

    End Sub

    Private Sub validar_vacios()

        If txt_credito.Text = "" Then
            txt_credito.Text = 0
        End If
        If txt_autorizacion.Text = "" Then
            txt_autorizacion.Text = 0
        End If

        If txt_aportacion.Text = "" Then
            txt_aportacion.Text = 0
        End If
        If txt_id_contrato_siiof.Text = "" Then
            txt_id_contrato_siiof.Text = 0
        End If
        If txt_monto.Text = "" Then
            txt_monto.Text = 0
        End If
        If txt_socios.Text = "" Then
            txt_socios.Text = 0
        End If
        If txt_nvsm.Text = "" Then
            txt_nvsm.Text = 0
        End If
        ' If txt_tasafija.Text = "" Then
        'txt_tasafija.Text = 0
        'End If
        If txt_jornales.Text = "" Then
            txt_jornales.Text = 0
        End If
        If txt_capacidad.Text = "" Then
            txt_capacidad.Text = 0
        End If
        If txt_ingresoneto.Text = "" Then
            txt_ingresoneto.Text = 0
        End If
        If txt_capital.Text = "" Then
            txt_capital.Text = 0
        End If
        If txt_activofijo.Text = "" Then
            txt_activofijo.Text = 0
        End If
        If txt_activototal.Text = "" Then
            txt_activototal.Text = 0
        End If
        If txt_ingresos.Text = "" Then
            txt_ingresos.Text = 0
        End If
        If txt_utilidad.Text = "" Then
            txt_utilidad.Text = 0
        End If
        If txt_fondo.Text = "" Then
            txt_fondo.Text = 0
        End If
        '  If txt_tasa.Text = "" Then
        ' txt_tasa.Text = 0
        '  End If
        If txt_sieban.Text = "" Then
            txt_sieban.Text = "SUSPENDIDO"
        End If
        If txt_egresos.Text = "" Then
            txt_egresos.Text = 0
        End If

        If PCXSG_TXT.Text = "" Then
            PCXSG_TXT.Text = 0
        End If

        If dt_febalance.Text = "" Then
            fecha = "01/01/1900"
        Else
            fecha = dt_febalance.Text
        End If
        If txt_BP.Text = "" Then
            txt_BP.Text = 0
        End If
        If TXT_FB.Text = "" Then
            TXT_FB.Text = 0
        End If
        If TXT_FN.Text = "" Then
            TXT_FN.Text = 0
        End If

        ' z25 = LB_Z25.Text
    End Sub
    Private Sub bt_guardar_Click(sender As Object, e As EventArgs) Handles bt_guardar.Click
        Dim FN, FB, BP As Decimal
        Dim año As String = Year(Now)
        Dim sucursal As String
        Dim Inserto As Boolean = False
        Dim Pcxsg As Decimal

        Dim secuencial_banco As Integer
        Dim FECMIN As Date
        Dim fonaga As String

        validar_vacios()
        Pcxsg = PCXSG_TXT.Text
        Dim tasafijafira As Decimal = TXT_FN.Text
        ' If CB_TIPAR.Text = "CREDITO DE AVÍO" Then
        'cb_periodo_capital.Text = "AL VENCIMIENTO"
        'End If
        id_contrato = Me.CONT_CPF_contratosTableAdapter.scalarid_contratoSINANEXO(cbclientes.SelectedValue, txt_credito.Text)
        If id_contrato > 0 Then
            FECMIN = Me.CONT_CPF_ministracionesTableAdapter.PrimeraMinistracion(id_contrato)
            If FECMIN = "01/01/1900" Then
                Ministracion1 = True
            End If
        Else
            Ministracion1 = True
        End If
        If Ministracion1 = True Then 'INSERT
            'Select Case CB_TIPAR.SelectedValue
            'Case "H", "C", "A"
            'FN = 0
            'FB = 0.1
            'Case Else
            'FN = 0.1
            'FB = 0.1
            'End Select
            ' If Me.Vw_AnexosBindingSource.Current("Tipta") = "7" Then ' saca la tasa del cliente 7=FIJA
            'cb_tasa.SelectedIndex = 0
            'If Me.Vw_AnexosBindingSource.Current("Ciclo").ToString.Trim = "" Then
            'BP = Me.Vw_AnexosTableAdapter.SacaTasaTRA(Me.Vw_AnexosBindingSource.Current("Anexo"))
            'Else
            '   BP = Me.Vw_AnexosTableAdapter.SacaTasaAVI(Me.Vw_AnexosBindingSource.Current("Anexo"), Me.Vw_AnexosBindingSource.Current("Ciclo"))
            'End If
            'Else
            '   cb_tasa.SelectedIndex = 2
            '  If Me.Vw_AnexosBindingSource.Current("Ciclo").ToString.Trim = "" Then
            ' BP = Me.Vw_AnexosTableAdapter.SacaDiferTRA(Me.Vw_AnexosBindingSource.Current("Anexo"))
            'Else
            '   BP = Me.Vw_AnexosTableAdapter.SacaDiferAVI(Me.Vw_AnexosBindingSource.Current("Anexo"), Me.Vw_AnexosBindingSource.Current("Ciclo"))
            'End If
            'End If
            BP = txt_BP.Text
            FB = TXT_FB.Text
            FN = TXT_FN.Text
            secuencial_banco = Me.CONT_CPF_configuracionTableAdapter.ScalarQueryconfiguracion(CONFIG.secuencial_banco)
            año = año.ToString().Substring(año.Length - 3, 3)
            sucursal = Me.CONT_CPF_sucursalesTableAdapter.ScalarQueryclave(cb_sucursal.SelectedValue)
            num_control = cb_prestamo.SelectedValue & "/" & TxtIntermediario.Text & "/" & sucursal & "/" & secuencial_banco & "/" & año
            PGLM = Me.CONT_CPF_clasificacion_garantiasTableAdapter.ScalarQueryGLMOSUSA(cb_clasificacion.SelectedValue)
            PGLP = Me.CONT_CPF_clasificacion_garantiasTableAdapter.ScalarQueryGLproductor(cb_clasificacion.SelectedValue)
            If PGLM = 0 And PGLP = 0 Then
                Pcxsg = 0
            End If

            Me.CONT_CPF_contratosTableAdapter.InsertQueryprueba(cb_producto.SelectedValue, num_control, cb_operacion.SelectedValue,
            cb_prestamo.SelectedValue, cb_divisa.SelectedValue, txt_monto.Text, "", txt_credito.Text, cb_sucursal.SelectedValue,
            cb_esquema.SelectedValue, cb_tasa.SelectedValue, BP, FN, FB, "", ch_ifnd.Checked,
            txt_socios.Text, cb_seguro.SelectedValue, secuencial_banco, cb_periodo.SelectedValue, cb_estatus.SelectedValue, txt_autorizacion.Text,
            txt_id_contrato_siiof.Text, txt_capacidad.Text, cb_medida.SelectedValue, txt_aportacion.Text, txt_estrato.Text, txt_sieban.Text, cb_actividad.SelectedValue,
            cb_rama.SelectedValue, cb_subrama.SelectedValue, cb_programa.SelectedValue, txt_monto.Text, txt_clave.Text, txt_nvsm.Text, txt_BP.Text,
            txt_jornales.Text, txt_ingresoneto.Text, txt_capital.Text, txt_programaespecial.Text, z25, fecha, txt_activofijo.Text, txt_activototal.Text,
            txt_ingresos.Text, txt_egresos.Text, txt_utilidad.Text, cb_concepto.SelectedValue, txt_localidad.Text, txt_fondo.Text, cb_cadena.SelectedValue,
            Pcxsg, PGLP, PGLM, cb_clasificacion.SelectedValue, "01/01/1900", Cksubsidio.Checked, cb_periodo_capital.SelectedValue, cb_periodo_int.SelectedValue,
            cb_periodo_revision.SelectedValue, cbclientes.SelectedValue)
            Inserto = True
            id_contrato = Me.CONT_CPF_contratosTableAdapter.scalarid_contratoSINANEXO(cbclientes.SelectedValue, txt_credito.Text)

            Me.CONT_CPF_contratosTableAdapter.id_inter(CInt(cb_intermediario.SelectedValue), CInt(id_contrato))
            Me.CONT_CPF_configuracionTableAdapter.ConsumeSecuencial() 'consume el secuencial banco

            Dim tipo_ga As Integer = Me.CONT_CPF_contratosTableAdapter.tipo_garantia(id_contrato)
            Dim ga_fonaga As String = Me.CONT_CPF_clasificacion_garantiasTableAdapter.fonaga(tipo_ga)


            If ga_fonaga = "SI" Then
                Pcxsg = PCXSG_FONAGA
                ID_garantina = 2 ' id tabla de garantias
                If PGLM = "0" Then
                    Nominal = 45
                    Efectiva = 45
                Else
                    Nominal = 50
                    Efectiva = 45
                End If
            Else
                Pcxsg = PCXSG_FEGA
                ID_garantina = 1 ' id tabla de garantias
                Nominal = 50
                Efectiva = 50
            End If
            Dim montobase As Decimal = txt_monto.Text

            Dim taGarantias As New DS_contratosTableAdapters.CONT_CPF_contratos_garantiasTableAdapter

            Dim NoGarantias As Integer = taGarantias.ExistenGarantias(id_contrato)
            If NoGarantias = 0 Then
                taGarantias.Insert(id_contrato, ID_garantina, Nominal, montobase * (Nominal / 100), Efectiva, True)
                ' Me.CONT_CPF_contratosTableAdapter.Updatesubsidio(CheckBox1.Checked, id_contrato)

            End If


        Else 'UPDATE
                '   If Me.Vw_AnexosBindingSource.Current("Tipta") = "7" Then ' saca la tasa del cliente 7=FIJA
                '  cb_tasa.SelectedIndex = 0
                ' Else
                'cb_tasa.SelectedIndex = 2
                'End If
                '   id_contrato = Me.CONT_CPF_contratosTableAdapter.ScalarQueryID_CONTRATO(Vw_AnexosBindingSource.Current("Anexo"), Vw_AnexosBindingSource.Current("Ciclo"))


                '    Me.CONT_CPF_contratosTableAdapter.UPDATE_CONTRATOS(cb_producto.SelectedValue, cb_operacion.SelectedValue,
                '   cb_prestamo.SelectedValue, cb_divisa.SelectedValue, txt_monto.Text, Vw_AnexosBindingSource.Current("Anexo"), txt_credito.Text, cb_sucursal.SelectedValue,
                '  cb_esquema.SelectedValue, cb_tasa.SelectedValue, txt_tasa.Text, FN, FB, Vw_AnexosBindingSource.Current("Ciclo"), ch_ifnd.Checked,
                ' txt_socios.Text, cb_seguro.SelectedValue, cb_periodo.SelectedValue, cb_estatus.SelectedValue, txt_autorizacion.Text,
                'txt_id_contrato_siiof.Text, txt_capacidad.Text, cb_medida.SelectedValue, txt_aportacion.Text, txt_estrato.Text, txt_sieban.Text,
                'cb_actividad.SelectedValue, cb_rama.SelectedValue, cb_subrama.SelectedValue, cb_programa.SelectedValue, LB_LINEA.Text, txt_clave.Text,
                'txt_nvsm.Text, txt_BP.Text, txt_jornales.Text, txt_ingresoneto.Text, txt_capital.Text, txt_programaespecial.Text, z25, fecha,
                'txt_activofijo.Text, txt_activototal.Text, txt_ingresos.Text, txt_egresos.Text, txt_utilidad.Text, cb_concepto.SelectedValue,
                'txt_localidad.Text, txt_fondo.Text, cb_cadena.SelectedValue, Pcxsg, PGLP, PGLM, cb_clasificacion.SelectedValue,
                'Cksubsidio.Checked, cb_periodo_capital.SelectedValue, cb_periodo_int.SelectedValue, cb_periodo_revision.SelectedValue, id_contrato)
                'Me.CONT_CPF_contratosTableAdapter.id_inter(CInt(cb_intermediario.SelectedValue), id_contrato)

            End If

        MessageBox.Show("Contrato Guardado", "CONTRATOS CARTERA PASIVA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


    End Sub

    Private Sub cb_subrama_SelectedValueChanged(sender As Object, e As EventArgs) Handles cb_subrama.SelectedValueChanged
        If cb_subrama.SelectedIndex >= 0 Then
            id_subrama = Me.CONT_CPF_subramasTableAdapter.clave_subrama(cb_subrama.SelectedValue)
            '  Me.CONT_CPF_cadenasTableAdapter.Fill(Me.DS_contratos.CONT_CPF_cadenas, cb_rama.SelectedValue, id_subrama)
            Me.View_cadenas_subramasTableAdapter.Fill(Me.DS_contratos.View_cadenas_subramas, id_subrama, cb_rama.SelectedValue)

        End If

    End Sub
End Class