
Public Class frm_contratos_alta
   
    Dim num_control, z25 As String
    Dim secuencial_banco As Integer
    Public Anexo As String
    Public Ciclo As String
    Public Shared id_contrato, id_subrama As Integer
    Dim aportacion As Decimal
    Dim monto, nvsm As Decimal
    Dim fecha As Date
    Public Ministracion1, existe As Boolean


    Private Sub frm_contratos_alta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos5.CONT_CPF_conceptos_inversion' Puede moverla o quitarla según sea necesario.
        ' Me.CONT_CPF_conceptos_inversionTableAdapter.Fill(Me.DS_contratos5.CONT_CPF_conceptos_inversion)
        If sinanexo = False Then
            cbanexos.Visible = True
            cbanexos2.Visible = False

        Else
            cbanexos.Visible = False
            cbanexos2.Visible = True
            bt_guardar.Enabled = False

            cb_esquema.Enabled = False
            cb_clasificacion.Enabled = False
            Cksubsidio.Enabled = False
            cb_periodo_capital.Enabled = False
            cb_periodo_int.Enabled = False
            cb_periodo_revision.Enabled = False

        End If
        cargar_combos()
        If Ministracion1 = False Then
            cb_esquema.Enabled = False
            cb_clasificacion.Enabled = False
            Cksubsidio.Enabled = False
            cb_periodo_capital.Enabled = False
            cb_periodo_int.Enabled = False
            cb_periodo_revision.Enabled = False
        End If
        Me.CONT_CPF_vencimientosTableAdapter.Fill(Me.DS_contratos.CONT_CPF_vencimientos)
        Me.CONT_CPF_ministracionesTableAdapter.Fill(Me.DS_contratos.CONT_CPF_ministraciones)

        If Ministracion1 = False Then
            Me.ClientesTableAdapter.Fill(Me.DS_contratos.Clientes)
            cbclientes_SelectedIndexChanged(Nothing, Nothing)
            Vw_AnexosBindingSource_CurrentChanged(Nothing, Nothing)
        Else
            Me.ClientesTableAdapter.FillByAnexo(Me.DS_contratos.Clientes, Anexo)
            If IsNothing(Ciclo) Then Ciclo = ""
            Me.Vw_AnexosTableAdapter.FillBy_ANEXO(Me.DS_contratos.Vw_Anexos, Anexo, Ciclo)
            bt_guardar.Enabled = False
            BT_IMPRIMIR.Enabled = False

        End If
    End Sub

    Private Sub txtcliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcliente.TextChanged
        Me.ClientesBindingSource.Filter = "descr like '%" & txtcliente.Text.Trim & "%'"
        cbclientes_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_guardar.Click
        Dim FN, FB, BP As Decimal
        Dim año As String = Year(Now)
        Dim sucursal As String
        Dim Inserto As Boolean = False
        Dim Pcxsg As Decimal
        Dim tasafijafira As Decimal = txt_tasafija.Text
        validar_vacios()


        If CONT_CPF_clasificacion_garantiasBindingSource.Current("fonaga") <> "NO" Then
            '   If Vw_AnexosBindingSource.Current("tipta") = 7 Then
            '  Pcxsg = Me.CONT_CPF_configuracionTableAdapter.cxsg_tf_periodo(año)
            'Else

            Select Case Vw_AnexosBindingSource.Current("Tipar")
                Case "H", "C", "A"   'AVIO Y CC
                    Pcxsg = Me.CONT_CPF_configuracionTableAdapter.CXSG_FONAGA_IF(año)
                Case Else

                    Pcxsg = Me.CONT_CPF_configuracionTableAdapter.CXSG_FONAGA_CT(año)

            End Select
            'End If

            'Pcxsg = PCXSG_FONAGA
        Else

            Pcxsg = Me.CONT_CPF_configuracionTableAdapter.cxsg_tf_periodo(año)
        End If
        ' Pcxsg = 0.5
        If txt_tipo.Text = "CREDITO DE AVÍO" Then
            cb_periodo_capital.Text = "AL VENCIMIENTO"
        End If

        If Ministracion1 = True Then 'INSERT
            Select Case Vw_AnexosBindingSource.Current("Tipar")
                Case "H", "C", "A"
                    FN = 0
                    FB = 0.1
                Case Else
                    FN = 0.1
                    FB = 0.1
            End Select
            If Me.Vw_AnexosBindingSource.Current("Tipta") = "7" Then ' saca la tasa del cliente 7=FIJA
                cb_tasa.SelectedIndex = 0
                If Me.Vw_AnexosBindingSource.Current("Ciclo").ToString.Trim = "" Then
                    BP = Me.Vw_AnexosTableAdapter.SacaTasaTRA(Me.Vw_AnexosBindingSource.Current("Anexo"))
                Else
                    BP = Me.Vw_AnexosTableAdapter.SacaTasaAVI(Me.Vw_AnexosBindingSource.Current("Anexo"), Me.Vw_AnexosBindingSource.Current("Ciclo"))
                End If
            Else
                cb_tasa.SelectedIndex = 2
                If Me.Vw_AnexosBindingSource.Current("Ciclo").ToString.Trim = "" Then
                    BP = Me.Vw_AnexosTableAdapter.SacaDiferTRA(Me.Vw_AnexosBindingSource.Current("Anexo"))
                Else
                    BP = Me.Vw_AnexosTableAdapter.SacaDiferAVI(Me.Vw_AnexosBindingSource.Current("Anexo"), Me.Vw_AnexosBindingSource.Current("Ciclo"))
                End If
            End If
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
            cb_prestamo.SelectedValue, cb_divisa.SelectedValue, txt_monto.Text, Vw_AnexosBindingSource.Current("Anexo"), txt_credito.Text, cb_sucursal.SelectedValue,
            cb_esquema.SelectedValue, cb_tasa.SelectedValue, BP, FN, FB, Vw_AnexosBindingSource.Current("Ciclo"), ch_ifnd.Checked,
            txt_socios.Text, cb_seguro.SelectedValue, secuencial_banco, cb_periodo.SelectedValue, cb_estatus.SelectedValue, txt_autorizacion.Text,
            txt_id_contrato_siiof.Text, txt_capacidad.Text, cb_medida.SelectedValue, txt_aportacion.Text, txt_estrato.Text, txt_sieban.Text, cb_actividad.SelectedValue,
            cb_rama.SelectedValue, cb_subrama.SelectedValue, cb_programa.SelectedValue, LB_LINEA.Text, txt_clave.Text, txt_nvsm.Text, txt_tasafija.Text,
            txt_jornales.Text, txt_ingresoneto.Text, txt_capital.Text, txt_programaespecial.Text, z25, fecha, txt_activofijo.Text, txt_activototal.Text,
            txt_ingresos.Text, txt_egresos.Text, txt_utilidad.Text, cb_concepto.SelectedValue, txt_localidad.Text, txt_fondo.Text, cb_cadena.SelectedValue,
            Pcxsg, PGLP, PGLM, cb_clasificacion.SelectedValue, "01/01/1900", Cksubsidio.Checked, cb_periodo_capital.SelectedValue, cb_periodo_int.SelectedValue,
            cb_periodo_revision.SelectedValue, Me.Vw_AnexosBindingSource.Current("Cliente"))
            Inserto = True
            id_contrato = Me.CONT_CPF_contratosTableAdapter.ScalarQueryID_CONTRATO(Vw_AnexosBindingSource.Current("Anexo"), Vw_AnexosBindingSource.Current("Ciclo"))

            Me.CONT_CPF_contratosTableAdapter.id_inter(CInt(cb_intermediario.SelectedValue), CInt(id_contrato))
            Me.CONT_CPF_configuracionTableAdapter.ConsumeSecuencial() 'consume el secuencial banco

        Else 'UPDATE
            If Me.Vw_AnexosBindingSource.Current("Tipta") = "7" Then ' saca la tasa del cliente 7=FIJA
                cb_tasa.SelectedIndex = 0
            Else
                cb_tasa.SelectedIndex = 2
            End If
            id_contrato = Me.CONT_CPF_contratosTableAdapter.ScalarQueryID_CONTRATO(Vw_AnexosBindingSource.Current("Anexo"), Vw_AnexosBindingSource.Current("Ciclo"))


            Me.CONT_CPF_contratosTableAdapter.UPDATE_CONTRATOS(cb_producto.SelectedValue, cb_operacion.SelectedValue,
            cb_prestamo.SelectedValue, cb_divisa.SelectedValue, txt_monto.Text, Vw_AnexosBindingSource.Current("Anexo"), txt_credito.Text, cb_sucursal.SelectedValue,
            cb_esquema.SelectedValue, cb_tasa.SelectedValue, txt_tasa.Text, FN, FB, Vw_AnexosBindingSource.Current("Ciclo"), ch_ifnd.Checked,
            txt_socios.Text, cb_seguro.SelectedValue, cb_periodo.SelectedValue, cb_estatus.SelectedValue, txt_autorizacion.Text,
            txt_id_contrato_siiof.Text, txt_capacidad.Text, cb_medida.SelectedValue, txt_aportacion.Text, txt_estrato.Text, txt_sieban.Text,
            cb_actividad.SelectedValue, cb_rama.SelectedValue, cb_subrama.SelectedValue, cb_programa.SelectedValue, LB_LINEA.Text, txt_clave.Text,
            txt_nvsm.Text, txt_tasafija.Text, txt_jornales.Text, txt_ingresoneto.Text, txt_capital.Text, txt_programaespecial.Text, z25, fecha,
            txt_activofijo.Text, txt_activototal.Text, txt_ingresos.Text, txt_egresos.Text, txt_utilidad.Text, cb_concepto.SelectedValue,
            txt_localidad.Text, txt_fondo.Text, cb_cadena.SelectedValue, Pcxsg, PGLP, PGLM, cb_clasificacion.SelectedValue,
            Cksubsidio.Checked, cb_periodo_capital.SelectedValue, cb_periodo_int.SelectedValue, cb_periodo_revision.SelectedValue, id_contrato)
            Me.CONT_CPF_contratosTableAdapter.id_inter(CInt(cb_intermediario.SelectedValue), id_contrato)

        End If
        If txt_acreditado.Text.Length > 0 Then
            Dim persona As String
            persona = Me.ClientesTableAdapter.ScalarQueryid_acreditado(cbclientes.SelectedValue)
            If persona Is Nothing Then
                Me.ClientesTableAdapter.UpdateQueryId_Acreditado(txt_acreditado.Text, cbclientes.SelectedValue)
                ' Dim s As String
                's = txt_acreditado.Text & "-" & cbclientes.SelectedValue
                'MessageBox.Show(s)
            Else
                If persona <> txt_acreditado.Text.Trim Then
                    MessageBox.Show("Verificar Id_Acreditado, hay un valor distinto almacenado anteriormente", "CONTRATOS CARTERA PASIVA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txt_acreditado.Text = persona
                End If

                'MessageBox.Show("Verificar Id_Acreditado", "CONTRATOS CARTERA PASIVA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If

        MessageBox.Show("Contrato Guardado", "CONTRATOS CARTERA PASIVA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'id_contrato = Me.CONT_CPF_contratosTableAdapter.ScalarQueryID_CONTRATO(Vw_AnexosBindingSource.Current("Anexo"), Vw_AnexosBindingSource.Current("Ciclo"))
        ' Me.CONT_CPF_contratosTableAdapter.updatetasafija(tasafijafira, id_contrato) 'dagl 03/04/2018 guardar subsidio 
        ' Me.CONT_CPF_contratosTableAdapter.Updatesubsidio(Cksubsidio.Checked, id_contrato) 'dagl 23/01/2018 guardar subsidio 
        If Ministracion1 = True And Inserto = True Then
            CargaVencimientos()

            Dim F2 As New Frm_MinistracionesADD
            F2.BP = BP
            F2.FB = FB
            F2.FN = FN
            F2.Ministracion1 = Ministracion1
            F2.ID_Contrato = id_contrato
            Dim tipo_ga As Integer = Me.CONT_CPF_contratosTableAdapter.tipo_garantia(id_contrato)
            Dim ga_fonaga As String = Me.CONT_CPF_clasificacion_garantiasTableAdapter.fonaga(tipo_ga)

            If ga_fonaga = "SI" Then
                F2.PCXSG = PCXSG_FONAGA
                F2.ID_garantina = 2 ' id tabla de garantias
                If CONT_CPF_clasificacion_garantiasBindingSource.Current("gl_mosusa") = "0" Then
                    F2.Nominal = 45
                    F2.Efectiva = 45
                Else
                    F2.Nominal = 50
                    F2.Efectiva = 45
                End If
            Else
                F2.PCXSG = PCXSG_FEGA
                F2.ID_garantina = 1 ' id tabla de garantias
                F2.Nominal = 50
                F2.Efectiva = 50
            End If
            If F2.ShowDialog = Windows.Forms.DialogResult.OK Then
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
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
        If txt_tasafija.Text = "" Then
            txt_tasafija.Text = 0
        End If
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
        If txt_tasa.Text = "" Then
            txt_tasa.Text = 0
        End If
        If txt_sieban.Text = "" Then
            txt_sieban.Text = "SUSPENDIDO"
        End If
        If txt_egresos.Text = "" Then
            txt_egresos.Text = 0
        End If

        If dt_febalance.Text = "" Then
            fecha = "01/01/1900"
        Else
            fecha = dt_febalance.Text
        End If
        z25 = LB_Z25.Text
    End Sub

    Private Function cargar_combos()
        ' Me.CONT_CPF_cadenasTableAdapter.Fill(Me.DS_contratos.CONT_CPF_cadenas)
        Me.View_cadenas_subramasTableAdapter.Fill(Me.DS_contratos.View_cadenas_subramas, 101, 1)
        ' Me.CONT_CPF_subramasTableAdapter.Fill(Me.DS_contratos.CONT_CPF_subramas)
        Me.CONT_CPF_programasTableAdapter.Fill(Me.DS_contratos.CONT_CPF_programas)
        ' Me.CONT_CPF_programasBindingSource.Filter = "id_programa=23"
        Me.CONT_CPF_ramasTableAdapter.Fill(Me.DS_contratos.CONT_CPF_ramas)
        Me.CONT_CPF_actividadTableAdapter.Fill(Me.DS_contratos.CONT_CPF_actividad)
        Me.CONT_CPF_unidades_medidaTableAdapter.Fill(Me.DS_contratos.CONT_CPF_unidades_medida)
        Me.CONT_CPF_esquema_cobroTableAdapter.Fill(Me.DS_contratos.CONT_CPF_esquema_cobro)
        Me.CONT_CPF_tipo_tasasTableAdapter.Fill(Me.DS_contratos.CONT_CPF_tipo_tasas)
        Me.CONT_CPF_segurosTableAdapter.Fill(Me.DS_contratos.CONT_CPF_seguros)
        Me.CONT_CPF_sucursalesTableAdapter.Fill(Me.DS_contratos.CONT_CPF_sucursales)
        Me.CONT_CPF_sucursalesBindingSource.Filter = "id_sucursal=2"
        Me.CONT_CPF_divisasTableAdapter.Fill(Me.DS_contratos.CONT_CPF_divisas)
        Me.CONT_CPF_tipoprestamosTableAdapter.Fill(Me.DS_contratos.CONT_CPF_tipoprestamos)
        Me.CONT_CPF_productos_firaTableAdapter.Fill(Me.DS_contratos.CONT_CPF_productos_fira)
        Me.CONT_CPF_clasificacion_garantiasTableAdapter.Fill(Me.DS_contratos.CONT_CPF_clasificacion_garantias)
        Me.CONT_CPF_intermediariosTableAdapter.Fill(Me.DS_contratos.CONT_CPF_intermediarios)
        Me.CONT_CPF_periodicidadTableAdapter.Fill(Me.DS_contratos.CONT_CPF_periodicidad)
        ' Me.Vw_conceptos_inversionTableAdapter.Fill(Me.DS_contratos.vw_conceptos_inversion)
        Me.CONT_CPF_operacionTableAdapter.Fill(Me.DS_contratos.CONT_CPF_operacion)
        Me.CONT_CPF_ESTATUSTableAdapter.Fill(Me.DS_contratos.CONT_CPF_ESTATUS)
        Me.CONT_CPF_esquema_cobroBindingSource.Filter = "id_esquema_cobro <= 2"
        Me.CONT_CPF_periodicidadTableAdapter.Fill(Me.DS_contratos3.CONT_CPF_periodicidad)
        Me.CONT_CPF_periodicidadTableAdapter.Fill(Me.DS_contratos2.CONT_CPF_periodicidad)
        Me.CONT_CPF_periodicidadTableAdapter.Fill(Me.DS_contratos1.CONT_CPF_periodicidad)

        txt_credito.Text = 0
        txt_autorizacion.Text = 0
        txt_id_contrato_siiof.Text = 0
        txt_socios.Text = 0
        txt_nvsm.Text = 0
        txt_tasafija.Text = 0
        txt_jornales.Text = 0
        txt_capacidad.Text = 0
        txt_ingresoneto.Text = 0
        txt_capital.Text = 0
        txt_activofijo.Text = 0
        txt_activototal.Text = 0
        txt_ingresos.Text = 0
        txt_egresos.Text = 0
        txt_utilidad.Text = 0
        txt_fondo.Text = 0
        txt_tasa.Text = 0
        txt_monto.Text = LB_LINEA.Text
        txt_sieban.Text = "SUSPENDIDO"
        Cksubsidio.Checked = True
        If txt_monto.TextLength > 0 Then
            monto = Convert.ToDecimal(txt_monto.Text)
            txt_aportacion.Text = Math.Round((monto / 0.9) * 0.1)
        Else
            txt_monto.Text = 0
        End If

    End Function

    Private Sub bt_ministraciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_ministraciones.Click
        frm_ministraciones.Show()
    End Sub

    Private Sub bt_vencimientos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_vencimientos.Click
        Nuevo.Show()
    End Sub

    Private Sub bt_garantias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_garantias.Click
        frm_garantias.Show()
    End Sub

    Private Sub cbclientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbclientes.SelectedIndexChanged
        If cbclientes.SelectedIndex >= 0 And Ministracion1 = False Then
            If sinanexo = False Then
                Me.Vw_AnexosTableAdapter.FillBy_anexoporcliente(Me.DS_contratos.Vw_Anexos, cbclientes.SelectedValue)
            Else
                Me.Vw_descuentoSATableAdapter.FillBYCLIENTE(Me.DS_contratos.vw_descuentoSA, cbclientes.SelectedValue)
            End If

        End If
    End Sub
    Private Sub txt_nvsm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_nvsm.TextChanged

        If txt_nvsm.Text.Length > 0 Then
            nvsm = Convert.ToDecimal(txt_nvsm.Text)
            If nvsm >= 0 And nvsm <= 1000 Then
                txt_estrato.Text = "PD1"
            ElseIf nvsm > 1000 And txt_nvsm.Text <= 3000 Then
                txt_estrato.Text = "PD2"
            Else
                txt_estrato.Text = "PD3"
            End If
        End If
    End Sub

    Private Sub cb_clase_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_clase.SelectedValueChanged
        If Not cb_clase.SelectedValue Is Nothing Then
            ' Me.Vw_conceptos_inversion_fullTableAdapter.FillBy_credito(Me.DS_contratos.vw_conceptos_inversion_full, cb_clase.SelectedValue)
        End If
    End Sub

    Private Sub cb_concepto_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_concepto.SelectedValueChanged
        '    txt_clave.Text = cb_concepto.SelectedValue
    End Sub

    Private Sub txt_estrato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_estrato.TextChanged
        If txt_monto.Text.Length > 0 Then
            monto = Convert.ToDecimal(txt_monto.Text)
            If txt_estrato.Text = "PD1" Then
                txt_aportacion.Text = Math.Round((monto / 0.9) * 0.1)
            Else
                txt_aportacion.Text = Math.Round((monto / 0.8) * 0.2)
            End If

        End If

    End Sub

    Private Sub txt_capacidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_capacidad.TextChanged
        If cb_medida.SelectedValue = 2 And txt_capacidad.Text.Length > 0 Then
            If Math.Round(Convert.ToDecimal(txt_capacidad.Text * 10 / 280)) < 1 Then
                txt_jornales.Text = 1
            Else
                txt_jornales.Text = Math.Round(Convert.ToDecimal(txt_capacidad.Text * 10 / 280))
            End If

        Else
            txt_jornales.Text = 0
        End If
    End Sub

    Private Sub txt_monto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_monto.TextChanged

        If txt_monto.Text.Length > 0 Then
            If txt_monto.Text <> "" Then
                monto = Convert.ToDecimal(txt_monto.Text)
                txt_aportacion.Text = Math.Round((monto / 0.9) * 0.1)
            End If
        End If
    End Sub

    Private Sub cb_medida_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_medida.SelectedValueChanged
        If cb_medida.SelectedValue = 2 And txt_capacidad.Text.Length > 0 Then
            If Math.Round(Convert.ToDecimal(txt_capacidad.Text * 10 / 280)) < 1 Then
                txt_jornales.Text = 1
            Else
                txt_jornales.Text = Math.Round(Convert.ToDecimal(txt_capacidad.Text * 10 / 280))

            End If
        Else
            txt_jornales.Text = 0
            'End If
        End If
    End Sub

    Sub CargaVencimientos()
        Dim taVencimieto As New DS_contratosTableAdapters.CONT_CPF_vencimientosTableAdapter
        Dim FechaVen As Date
        Select Case Vw_AnexosBindingSource.Current("Tipar")
            Case "H", "A", "C"

                Dim montoAUX As Decimal = 0
                montoAUX = Me.CONT_CPF_contratosTableAdapter.monto_contrato(id_contrato) 'TRAER EL MONTO DEL CONTRATO, NO EL CAPITAL FINANCIADO DAGL 27/02/2018
                FechaVen = CDate(Vw_AnexosBindingSource.Current("FechaVen"))
                taVencimieto.InsertQueryVencimiento(FechaVen, montoAUX, "01/01/1900", "Vigente", 0, id_contrato)
                DIAS_ENTRE_VENC = 30
            Case Else
                Dim EdoCta As New DS_contratosTableAdapters.EdoctavTableAdapter
                Dim t As New DS_contratos.EdoctavDataTable
                Dim r As DS_contratos.EdoctavRow
                EdoCta.Fill(t, Vw_AnexosBindingSource.Current("Anexo"))
                For Each r In t.Rows
                    FechaVen = CTOD(r.Feven)
                    If r.Abcap > 0 Then
                        taVencimieto.InsertQueryVencimiento(FechaVen, r.Abcap, "01/01/1900", "Vigente", 0, id_contrato)
                    End If
                Next
                DIAS_ENTRE_VENC = taVencimieto.DiasEntreVencimientos(Vw_AnexosBindingSource.Current("Anexo"))
        End Select
        Select Case DIAS_ENTRE_VENC
            Case Is <= 89
                Me.CONT_CPF_contratosTableAdapter.UpdateTasaTIIE("TIIE28", id_contrato)
            Case Is < 180
                Me.CONT_CPF_contratosTableAdapter.UpdateTasaTIIE("TIIE91", id_contrato)
            Case Is < 365
                Me.CONT_CPF_contratosTableAdapter.UpdateTasaTIIE("TIIE182", id_contrato)
            Case Else
                Me.CONT_CPF_contratosTableAdapter.UpdateTasaTIIE("TIIE365", id_contrato)
        End Select

    End Sub

    Private Sub TxtCultivo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCultivo.TextChanged
        If TxtCultivo.Text = "TRIGO" Then
            Me.CONT_CPF_clasificacion_garantiasBindingSource.Filter = "cultivo = 'T' and Fondeo = 'FIRA'"
        Else
            Me.CONT_CPF_clasificacion_garantiasBindingSource.Filter = "cultivo = 'O' and Fondeo = 'FIRA'"
        End If
    End Sub

    Private Sub CkCorteFinMes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cksubsidio.CheckedChanged
        If Cksubsidio.Checked = True Then
            'DT_FechaCorte.Value = "01/01/1900"
        Else
            'DT_FechaCorte.Value = Today
        End If
    End Sub

    Private Sub LB_LINEA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LB_LINEA.TextChanged
        If LB_LINEA.Text.Length > 0 Then
            txt_monto.Text = LB_LINEA.Text
        End If
    End Sub

    Private Sub cb_esquema_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_esquema.SelectedIndexChanged
        If cb_esquema.Text = "SIMPLE CON FINANCIAMIENTO" Then
            cb_periodo_int.Text = "MENSUAL"
            cb_periodo_revision.Text = "MENSUAL"
        End If
    End Sub

    Private Sub cb_rama_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_rama.SelectedIndexChanged

    End Sub

    Private Sub Vw_AnexosBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles Vw_AnexosBindingSource.CurrentChanged
        If Not IsNothing(Vw_AnexosBindingSource.Current) Then
            TabControl1.Enabled = True
            bt_guardar.Enabled = True
            If Ministracion1 = False Then
                'CargaDatosFira()
            End If
        End If

    End Sub

    Private Sub BT_IMPRIMIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_IMPRIMIR.Click
        If sinanexo = False Then

        Else
            ' frm_edo_cuenta.Tipar = Me.VwdescuentoSABindingSource.Current("Tipar")
            frm_edo_cuenta.Anexo = Me.VwdescuentoSABindingSource.Current("Anexo")

            If frm_edo_cuenta.Anexo.Substring(0, 3) = "S/A" Then
                frm_edo_cuenta.Anexo = ""
                frm_edo_cuenta.Ciclo = ""
            Else
                frm_edo_cuenta.Ciclo = Me.VwdescuentoSABindingSource.Current("Ciclo")
            End If

        End If

            frm_edo_cuenta.Show()
    End Sub

    Private Sub cb_medida_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_medida.SelectedIndexChanged

    End Sub

    Private Sub txt_clave_TextChanged(sender As Object, e As EventArgs) Handles txt_clave.TextChanged
        If txt_clave.Text.Length > 0 Then
            Me.CONT_CPF_conceptos_inversionTableAdapter.Fill(Me.DS_contratos5.CONT_CPF_conceptos_inversion, txt_clave.Text, cb_rama.SelectedValue)

        End If
    End Sub

    Private Sub cb_subrama_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_subrama.SelectedIndexChanged

    End Sub

    Private Sub cb_concepto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_concepto.SelectedIndexChanged

    End Sub

    Private Sub cbanexos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbanexos.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frm_datos_contrato.Show()
    End Sub

    Private Sub VwdescuentoSABindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles VwdescuentoSABindingSource.CurrentChanged
        If Not IsNothing(VwdescuentoSABindingSource.Current) Then
            TabControl1.Enabled = True
            bt_guardar.Enabled = True
            If Ministracion1 = False Then
                CargaDatosFira()
            End If
        End If
    End Sub

    Private Sub cbanexos2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbanexos2.SelectedIndexChanged

    End Sub

    Sub CargaDatosFira()
        'Me.CONT_CPF_contratosTableAdapter.FillByporanexo(Me.DS_contratos.CONT_CPF_contratos, Vw_AnexosBindingSource.Current("Anexo"), Vw_AnexosBindingSource.Current("Ciclo"))
        Me.CONT_CPF_contratosTableAdapter.FillByIDCREDITO(Me.DS_contratos.CONT_CPF_contratos, VwdescuentoSABindingSource.Current("id_credito"))
        id_contrato = Me.CONT_CPF_contratosTableAdapter.idcontrato(VwdescuentoSABindingSource.Current("id_credito"))
        txt_total_m.Text = Me.CONT_CPF_ministracionesTableAdapter.ScalarQueryministraciones_contar(id_contrato)
        txt_total_v.Text = Me.CONT_CPF_vencimientosTableAdapter.ScalarQueryvencimientos_contar(id_contrato)
        txt_total_G.Text = Me.ConT_CPF_contratos_garantiasTableAdapter.SacaTotalGarantia(id_contrato)
        Dim suma_m, suma_v, suma_g As Decimal
        If txt_total_m.Text > 0 Then
            suma_m = Me.CONT_CPF_ministracionesTableAdapter.ScalarQueryministraciones_suma(id_contrato)
        End If
        If txt_total_m.Text > 0 Then
            suma_v = Me.CONT_CPF_vencimientosTableAdapter.ScalarQueryvencimientos_suma(id_contrato)
        End If
        If txt_total_G.Text > 0 Then
            suma_g = Me.ConT_CPF_contratos_garantiasTableAdapter.SacaSumaGarantia(id_contrato)
        End If
        txt_suma_m.Text = suma_m.ToString("n2")
        txt_suma_v.Text = suma_v.ToString("n2")
        txt_Suma_G.Text = suma_g.ToString("n2")
        txt_sieban.Text = "SUSPENDIDO"
    End Sub

    Private Sub cb_rama_SelectedValueChanged(sender As Object, e As EventArgs) Handles cb_rama.SelectedValueChanged
        If cb_rama.SelectedIndex >= 0 Then
            Me.CONT_CPF_subramasTableAdapter.Fill(Me.DS_contratos.CONT_CPF_subramas, cb_rama.SelectedValue)

        End If
    End Sub

    Private Sub cb_subrama_SelectedValueChanged(sender As Object, e As EventArgs) Handles cb_subrama.SelectedValueChanged
        If cb_subrama.SelectedIndex >= 0 Then
            id_subrama = Me.CONT_CPF_subramasTableAdapter.clave_subrama(cb_subrama.SelectedValue)
            '  Me.CONT_CPF_cadenasTableAdapter.Fill(Me.DS_contratos.CONT_CPF_cadenas, cb_rama.SelectedValue, id_subrama)
            Me.View_cadenas_subramasTableAdapter.Fill(Me.DS_contratos.View_cadenas_subramas, id_subrama, cb_rama.SelectedValue)
        End If

    End Sub

    Private Sub cbanexos_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbanexos.SelectedValueChanged

    End Sub
End Class