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
    Public Shared id_contrato2, id_subrama2 As Integer




    Private Sub txtcliente_TextChanged(sender As Object, e As EventArgs) Handles txtcliente.TextChanged
        If txtcliente.TextLength > 5 Then
            Me.ClientesBindingSource.Filter = "descr like '%" & txtcliente.Text.Trim & "%'"
            cbclientes_SelectedIndexChanged(Nothing, Nothing)
        End If
        'cbclientes_SelectedIndexChanged(Nothing, Nothing)

        'Me.ClientesBindingSource.Filter = "descr like '%" & txtcliente.Text.Trim & "%'"
        'cbclientes_SelectedIndexChanged(Nothing, Nothing)

        'Me.ClientesBindingSource.Filter = "descr like '%" & txtcliente.Text.Trim & "%'"
        'cbclientes_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub frm_contrato2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frm_contratos_alta.id_contrato = 0
        sinanexo = True

        'TODO: esta línea de código carga datos en la tabla 'DS_contratos2.CONT_CPF_reestructura' Puede moverla o quitarla según sea necesario.
        'Me.CONT_CPF_reestructuraTableAdapter.Fill(Me.DS_contratos2.CONT_CPF_reestructura)
        'TODO: esta línea de código carga datos en la tabla 'DescuentosDS.CONT_CPF_GL' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_GLTableAdapter.Fill(Me.DescuentosDS.CONT_CPF_GL)

        'TODO: esta línea de código carga datos en la tabla 'DS_contratos1.CONT_CPF_vencimientos' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_vencimientosTableAdapter.Fill(Me.DS_contratos1.CONT_CPF_vencimientos)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos1.CONT_CPF_ministraciones' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_ministracionesTableAdapter.Fill(Me.DS_contratos1.CONT_CPF_ministraciones)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_contratos' Puede moverla o quitarla según sea necesario.
        ' Me.CONT_CPF_contratosTableAdapter.Fill(Me.DS_contratos.CONT_CPF_contratos)
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
        '  Me.ClientesTableAdapter.Fill(Me.DS_contratos.Clientes)
        Me.ClientesTableAdapter.Fill(Me.DS_contratos.Clientes)
      '  cbclientes_SelectedIndexChanged(Nothing, Nothing)

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
        '   id_contrato2 = 442
        If id_contrato2 <> 0 Then

            '  sinanexo = True
            frm_ministraciones.Show()

        Else
            Me.CONT_CPF_ministracionesTableAdapter.FillByCONTRATO(Me.DS_contratos.CONT_CPF_ministraciones, frm_contrato2.id_contrato)

        End If



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' id_contrato2 = 442

        CreaCalendarioRevisoinTasa(id_contrato2, "")
        MessageBox.Show("Se creo calendario tasa", "Contratos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '  id_contrato2 = 442
        If id_contrato2 <> 0 Then

            Nuevo.Show()
            ' Else
            '    Me.CONT_CPF_vencimientosTableAdapter.FillBycontrato(Me.DS_contratos.CONT_CPF_vencimientos, frm_contratos_alta.id_contrato)
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim id_credito As Integer = ComboBox1.SelectedValue
        If id_credito <> 0 Then
            '  id_contrato2 = Me.CONT_CPF_contratosTableAdapter.scalarid_contratoSINANEXO(cbclientes.SelectedValue, id_credito)
            ' If id_credito <> 0 Then
            'Me.Vw_descuentoSATableAdapter.FillByCONTRATO(Me.DS_contratos.vw_descuentoSA, id_contrato2)
            'Me.CONT_CPF_contratosTableAdapter.FillByIDCREDITO(Me.DS_contratos.CONT_CPF_contratos, id_credito)
            'End If

        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub BT_IMPRIMIR_Click(sender As Object, e As EventArgs) Handles BT_IMPRIMIR.Click
        ' id_contrato = ComboBox1.SelectedValue
        'frm_edo_cuenta.Show()
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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        '  id_contrato2 = Me.CONTCPFcontratosBindingSource.Current("id_contrato")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        '   If txt_credito.Text = "" Then
        txt_credito.Text = 0
        '  End If
        ' If txt_autorizacion.Text = "" Then
        txt_autorizacion.Text = 0
        ' End If

        'If txt_aportacion.Text = "" Then
        txt_aportacion.Text = 0
        'End If
        'If txt_id_contrato_siiof.Text = "" Then
        txt_id_contrato_siiof.Text = 0
        'End If
        'If txt_monto.Text = "" Then
        txt_monto.Text = 0
        'End If
        'If txt_socios.Text = "" Then
        txt_socios.Text = 0
        'End If
        'If txt_nvsm.Text = "" Then
        txt_nvsm.Text = 0
        'End If
        ' If txt_tasafija.Text = "" Then
        'txt_tasafija.Text = 0
        'End If
        'If txt_jornales.Text = "" Then
        txt_jornales.Text = 0
        'End If
        'If txt_capacidad.Text = "" Then
        txt_capacidad.Text = 0
        'End If
        'If txt_ingresoneto.Text = "" Then
        txt_ingresoneto.Text = 0
        'End If
        'If txt_capital.Text = "" Then
        txt_capital.Text = 0
        'End If
        'If txt_activofijo.Text = "" Then
        txt_activofijo.Text = 0
        'End If
        'If txt_activototal.Text = "" Then
        txt_activototal.Text = 0
        'End If
        'If txt_ingresos.Text = "" Then
        txt_ingresos.Text = 0
        'End If
        'If txt_utilidad.Text = "" Then
        txt_utilidad.Text = 0
        'End If
        'If txt_fondo.Text = "" Then
        txt_fondo.Text = 0
        'End If
        '  If txt_tasa.Text = "" Then
        ' txt_tasa.Text = 0
        '  End If
        'If txt_sieban.Text = "" Then
        txt_sieban.Text = "SUSPENDIDO"
        'End If
        'If txt_egresos.Text = "" Then
        txt_egresos.Text = 0
        'End If

        'If PCXSG_TXT.Text = "" Then
        PCXSG_TXT.Text = 0
        'End If

        'If dt_febalance.Text = "" Then
        fecha = "01/01/1900"
        'Else
       ' fecha = dt_febalance.Text
        'End If
        'If txt_BP.Text = "" Then
        txt_BP.Text = 0
        'End If
        'If TXT_FB.Text = "" Then
        TXT_FB.Text = 0
        'End If
        'If TXT_FN.Text = "" Then
        TXT_FN.Text = 0
        'End If
    End Sub

    Private Sub cbclientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbclientes.SelectedIndexChanged
        If cbclientes.SelectedIndex >= 0 And Ministracion1 = False Then
            'If sinanexo = False Then
            '  Me.Vw_AnexosTableAdapter.FillBy_anexoporcliente(Me.DS_contratos.Vw_Anexos, cbclientes.SelectedValue)
            'Me.Vw_Anexos1TableAdapter.FillBy_anexo(Me.DS_contratos6.Vw_Anexos1, Anexo, Ciclo)
            'Else

            ' Me.Vw_descuentoSATableAdapter.FillBYCLIENTE(Me.DS_contratos.vw_descuentoSA, cbclientes.SelectedValue)



            'End If

            '  If txtanexo.TextLength > 0 Then
            ' sinanexo = False
            'Anexo = txtanexo.Text
            'Ciclo = ET_CICLO.Text

            'End If
        End If
    End Sub

    Private Sub bt_guardar_Click(sender As Object, e As EventArgs) Handles bt_guardar.Click
        Dim FN, FB, BP As Decimal
        '  Dim año As String = Year(Now)
        Dim sucursal As String
        Dim Inserto As Boolean = False
        Dim Pcxsg As Decimal
        Dim id_contrato_padre As Integer
        ' id_contrato_padre = Me.CONT_CPF_contratosTableAdapter.scalarid_contratoSINANEXO(cbclientes.SelectedValue, ComboBox1.SelectedValue)



        Dim secuencial_banco As Integer
        Dim FECMIN As Date
        Dim fonaga As String
        Dim año1 As Date = Now
        Dim año As String
        año = año1.ToString("yyyy")

        Dim periodo As Integer = año
        Dim coberturanominal As Decimal = Me.CONT_CPF_configuracionTableAdapter.CNOMINAL(periodo)
        validar_vacios()
        Pcxsg = PCXSG_TXT.Text
        Dim tasafijafira As Decimal = TXT_FN.Text
        ' If CB_TIPAR.Text = "CREDITO DE AVÍO" Then
        'cb_periodo_capital.Text = "AL VENCIMIENTO"
        'End If
        id_contrato_padre = 0
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


            If Me.CONT_CPF_contratosTableAdapter.contratobycredito(txt_credito.Text) > 0 Then
                MessageBox.Show("Ya existe un contrato con ese id_credito", "CONTRATOS CARTERA PASIVA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
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
                '  Pcxsg = 0    PREGUNTAR SI APLICA O NO 
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
            id_contrato2 = Me.CONT_CPF_contratosTableAdapter.scalarid_contratoSINANEXO(cbclientes.SelectedValue, txt_credito.Text)
            'INGRESAR REESTRUCTURA
            If ch_res.Checked = True Then
                '  id_contrato_padre = ComboBox1.SelectedValue
                id_contrato_padre = TXT_CONTRATO_PADRE.Text
                Me.CONT_CPF_vencimientosTableAdapter.updateFECHAVENCIMIENTO(Date.Now, id_contrato_padre)
                If id_contrato_padre <> 0 Then
                    Me.CONT_CPF_reestructuraTableAdapter.InsertQuery(id_contrato_padre, id_contrato2)
                    MessageBox.Show("Reestructura Registrada", "CONTRATOS CARTERA PASIVA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End If
            End If
            ' Me.CONT_CPF_reestructuraTableAdapter.InsertQuery(id_contrato_padre, id_contrato2)
            Me.CONT_CPF_contratosTableAdapter.penalizacionupdate(ch_pen.Checked, id_contrato2) 'dagl 02/07/2018 guardar penalizacion 


            Me.CONT_CPF_contratosTableAdapter.id_inter(CInt(cb_intermediario.SelectedValue), CInt(id_contrato2))
            Me.CONT_CPF_configuracionTableAdapter.ConsumeSecuencial() 'consume el secuencial banco




            ' Dim tipo_ga As Integer = Me.CONT_CPF_contratosTableAdapter.tipo_garantia(id_contrato2)

            'If Me.CONT_CPF_clasificacion_garantiasTableAdapter.categoria(tipo_ga) = "OTRO" Then
            'If CK_FEGA.Checked = True Then
            '
            'ID_garantina = 1
            'Else
            '   ID_garantina = 2

            'End If

            'Nominal = TXT_NOM.Text
            'Efectiva = TXT_EFEC.Text
            'Else


            'Dim ga_fonaga As String = Me.CONT_CPF_clasificacion_garantiasTableAdapter.fonaga(tipo_ga)


            'If ga_fonaga = "SI" Then

            'ID_garantina = 2 ' id tabla de garantias
            'If PGLM = "0" Then
            'Nominal = 45
            'Efectiva = 45
            'Else
            '   Nominal = 50
            '  Efectiva = 45
            'End If
            'Else
            '
            'ID_garantina = 1 ' id tabla de garantias
            'Nominal = 50
            'Efectiva = 50
            'End If
            If cb_gl.SelectedIndex = 4 Then
                If CK_FONAGA.Checked = True Then
                    ID_garantina = 2
                    'F2.PCXSG = PCXSG_FEGA
                Else
                    'F2.PCXSG = PCXSG_FONAGA

                    ID_garantina = 1
                End If

                Pcxsg = Pcxsg
                Nominal = TXT_NOM.Text
                Efectiva = TXT_EFEC.Text
            Else
                ' Dim tipo_ga As Integer = Me.CONT_CPF_contratosTableAdapter.tipo_garantia(id_contrato)
                '  Dim ga_fonaga As String = Me.CONT_CPF_clasificacion_garantiasTableAdapter.fonaga(tipo_ga)

                If CK_FONAGA.Checked = True Then

                    ID_garantina = 2

                    Dim GL As Integer = cb_gl.SelectedValue

                    Select Case GL
                        Case 1
                            Pcxsg = Me.CONT_CPF_configuracionTableAdapter.FONAGA0(periodo)
                        Case 2
                            Pcxsg = Me.CONT_CPF_configuracionTableAdapter.FONAGA10(periodo)
                        Case 3
                            Pcxsg = Me.CONT_CPF_configuracionTableAdapter.FONAGA15(periodo)
                        Case 4
                            Pcxsg = Me.CONT_CPF_configuracionTableAdapter.FONAGA20(periodo)
                    End Select
                Else 'FEGA

                    ID_garantina = 1

                    Dim GL As Integer = cb_gl.SelectedValue

                    Select Case GL
                        Case 1
                            Pcxsg = Me.CONT_CPF_configuracionTableAdapter.FEGA0(periodo)
                        Case 2
                            Pcxsg = Me.CONT_CPF_configuracionTableAdapter.FEGA10(periodo)
                        Case 3
                            Pcxsg = Me.CONT_CPF_configuracionTableAdapter.FEGA15(periodo)
                        Case 4
                            Pcxsg = Me.CONT_CPF_configuracionTableAdapter.FEGA20(periodo)
                    End Select

                End If

                'If ga_fonaga = "SI" Then
                ''F2.PCXSG = PCXSG_FONAGA 'comentado el valor real lo trae el campo pCXSG
                'F2.PCXSG = Pcxsg
                ' F2.ID_garantina = 2 ' id tabla de garantias
                'If CONT_CPF_clasificacion_garantiasBindingSource.Current("gl_mosusa") = "0" Then
                'F2.Nominal = 45
                'F2.Efectiva = 45
                'Else
                'F2.Nominal = 50
                'F2.Efectiva = 45
                'End If
                '   Else
                '  'F2.PCXSG = PCXSG_FEGA
                ' F2.PCXSG = Pcxsg
                'F2.ID_garantina = 1 ' id tabla de garantias
                'F2.Nominal = 50
                'F2.Efectiva = 50
                'End If

                Nominal = coberturanominal
                Dim vgl As Integer = Me.CONT_CPF_GLTableAdapter.gliquida(cb_gl.SelectedValue)
                Efectiva = (100 - vgl) * coberturanominal / 100
                Me.CONT_CPF_contratosTableAdapter.UpdateCXSG(Pcxsg, vgl, id_contrato) 'dagl 26/06/2018 guardar PCXG Y GL

                Dim montobase As Decimal = txt_monto.Text

                Dim taGarantias As New DS_contratosTableAdapters.CONT_CPF_contratos_garantiasTableAdapter

                Dim NoGarantias As Integer = taGarantias.ExistenGarantias(id_contrato2)
                If NoGarantias = 0 Then
                    taGarantias.Insert(id_contrato2, ID_garantina, Nominal, montobase * (Nominal / 100), Efectiva, True)
                    ' Me.CONT_CPF_contratosTableAdapter.Updatesubsidio(CheckBox1.Checked, id_contrato)

                End If

            End If
            ' ComboBox1.SelectedValue = id_contrato2
            MessageBox.Show("Contrato Guardado", "CONTRATOS CARTERA PASIVA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

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
            MessageBox.Show("El contrato ya cuenta con ministracion anterior", "CONTRATOS CARTERA PASIVA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If


    End Sub

    Private Sub cb_subrama_SelectedValueChanged(sender As Object, e As EventArgs) Handles cb_subrama.SelectedValueChanged
        If cb_subrama.SelectedIndex >= 0 Then
            id_subrama = Me.CONT_CPF_subramasTableAdapter.clave_subrama(cb_subrama.SelectedValue)
            '  Me.CONT_CPF_cadenasTableAdapter.Fill(Me.DS_contratos.CONT_CPF_cadenas, cb_rama.SelectedValue, id_subrama)
            Me.View_cadenas_subramasTableAdapter.Fill(Me.DS_contratos.View_cadenas_subramas, id_subrama, cb_rama.SelectedValue)

        End If

    End Sub





    Private Sub cbclientes_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbclientes.SelectedValueChanged
        ' Me.CONT_CPF_contratosTableAdapter.FillBycliente(Me.DS_contratos.CONT_CPF_contratos, cbclientes.SelectedValue)



        If cbclientes.SelectedIndex > -1 Then

            If Not cbclientes.SelectedItem Is Nothing Then
                If cbclientes.SelectedValue <> 0 Then
                    Me.CONT_CPF_contratosTableAdapter.FillBycliente(Me.DS_contratos.CONT_CPF_contratos, cbclientes.SelectedValue)

                End If

            End If

            End If
    End Sub

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        If ComboBox1.SelectedValue <> 0 Then
            id_contrato2 = Me.CONT_CPF_contratosTableAdapter.idcontrato(ComboBox1.SelectedValue)
            '  id_contrato2 = Me.CONT_CPF_contratosTableAdapter.scalarid_contratoSINANEXO(cbclientes.SelectedValue, ComboBox1.SelectedValue)
        End If


    End Sub
End Class