
Public Class frm_contratos_alta

    Dim num_control, z25 As String
    Dim moneda As String
    Dim secuencial_banco As Integer
    Public Anexo As String
    Public Ciclo As String
    Public contrato_consulta As Integer

    Public Shared id_contrato, id_subrama As Integer
    Public Shared penalizacion As Boolean
    Dim aportacion As Decimal
    Dim monto, nvsm As Decimal
    Dim fecha As Date
    Dim vgl As Integer
    Public Ministracion1, existe, consulta As Boolean


    Private Sub frm_contratos_alta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_reestructura' Puede moverla o quitarla según sea necesario.
        'Me.CONT_CPF_reestructuraTableAdapter.Fill(Me.DS_contratos.CONT_CPF_reestructura)
        'TODO: esta línea de código carga datos en la tabla 'DescuentosDS.AnexosBloqueadosMC' Puede moverla o quitarla según sea necesario.
        '  Me.AnexosBloqueadosMCTableAdapter.Fill(Me.DescuentosDS.AnexosBloqueadosMC)
        'TODO: esta línea de código carga datos en la tabla 'DescuentosDS.Avios' Puede moverla o quitarla según sea necesario.
        '  Me.AviosTableAdapter.Fill(Me.DescuentosDS.Avios)
        'TODO: esta línea de código carga datos en la tabla 'DescuentosDS.Anexos' Puede moverla o quitarla según sea necesario.
        ' Me.AnexosTableAdapter.Fill(Me.DescuentosDS.Anexos)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_garantias' Puede moverla o quitarla según sea necesario.
        'Me.CONT_CPF_garantiasTableAdapter.Fill(Me.DS_contratos.CONT_CPF_garantias)
        'TODO: esta línea de código carga datos en la tabla 'DescuentosDS.CONT_CPF_GL' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_GLTableAdapter.Fill(Me.DescuentosDS.CONT_CPF_GL)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos7.CONT_CPF_contratos' Puede moverla o quitarla según sea necesario.
        '   Me.CONT_CPF_contratosTableAdapter.Fill(Me.DS_contratos7.CONT_CPF_contratos)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos7.CONT_CPF_contratos' Puede moverla o quitarla según sea necesario.
        '  Me.CONT_CPF_contratosTableAdapter.Fill(Me.DS_contratos7.CONT_CPF_contratos)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos7.CONT_CPF_contratos' Puede moverla o quitarla según sea necesario.
        ' Me.CONT_CPF_contratosTableAdapter.Fill(Me.DS_contratos7.CONT_CPF_contratos)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos6.Vw_Anexos1' Puede moverla o quitarla según sea necesario.
        ' Me.Vw_Anexos1TableAdapter.Fill(Me.DS_contratos6.Vw_Anexos1)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos5.CONT_CPF_conceptos_inversion' Puede moverla o quitarla según sea necesario.
        ' Me.CONT_CPF_conceptos_inversionTableAdapter.Fill(Me.DS_contratos5.CONT_CPF_conceptos_inversion)
        ' txt_id_contrato.Text = 0
        If consulta = True Then
            'Ministracion1 = False

            'Me.Vw_descuentoSATableAdapter.FillByANEXO(Me.DS_contratos.vw_descuentoSA, Anexo, Ciclo)
            'cbanexos.Visible = True
            ' cbanexos2.Visible = False
            'ListBox1.Visible = True
            bt_guardar.Enabled = False
            cb_esquema.Enabled = False
            cb_clasificacion.Enabled = False
            Cksubsidio.Enabled = False
            cb_periodo_capital.Enabled = False
            cb_periodo_int.Enabled = False
            cb_periodo_revision.Enabled = False
            cargar_combos()

            ' Me.CONT_CPF_vencimientosTableAdapter.Fill(Me.DS_contratos.CONT_CPF_vencimientos)
            'Me.CONT_CPF_ministracionesTableAdapter.Fill(Me.DS_contratos.CONT_CPF_ministraciones)
            ' Me.ClientesTableAdapter.Fill(Me.DS_contratos.Clientes)
            'cbclientes_SelectedIndexChanged(Nothing, Nothing)

            'Me.ClientesTableAdapter.FillBycliente_contrato(Me.DS_contratos.Clientes,)
            '   Vw_AnexosBindingSource_CurrentChanged(Nothing, Nothing)
            Me.Vw_descuentoSATableAdapter.FillByCONTRATO(Me.DS_contratos.vw_descuentoSA, Me.CONT_CPF_contratosTableAdapter.idcontrato(contrato_consulta))

            If sinanexo = False Then
                Me.ClientesTableAdapter.FillByAnexo(Me.DS_contratos.Clientes, Anexo)
                If IsNothing(Ciclo) Then Ciclo = ""
                Me.Vw_AnexosTableAdapter.FillBy_ANEXO(Me.DS_contratos.Vw_Anexos, Anexo, Ciclo)
                Me.Vw_Anexos1TableAdapter.FillBy_anexo(Me.DS_contratos6.Vw_Anexos1, Anexo, Ciclo)

            Else
                Me.ClientesTableAdapter.FillBycliente_contrato(Me.DS_contratos.Clientes, Me.CONT_CPF_contratosTableAdapter.idcontrato(contrato_consulta))


                '   If IsNothing(Ciclo) Then Ciclo = ""
                ' Me.Vw_AnexosTableAdapter.FillBy_ANEXO(Me.DS_contratos.Vw_Anexos, Anexo, Ciclo)
                ' Me.Vw_Anexos1TableAdapter.FillBy_anexo(Me.DS_contratos6.Vw_Anexos1, Anexo, Ciclo)


            End If

            Reestructura_txt.Text = ""
            If txt_id_contrato.Text <> "" Then
                Dim res As Integer = Me.CONT_CPF_reestructuraTableAdapter.reestructura_credito(txt_id_contrato.Text)
                If res <> 0 Then
                    Reestructura_txt.Text = res
                    'If txt_id_contrato.Text = "1022" Then
                    ' Dim XX As Integer = 0
                End If
            End If

            If txt_id_contrato.TextLength > 0 Then

                Dim CREDITO1 As Integer = contrato_consulta
                Dim id_contrato1 As Integer = txt_id_contrato.Text
                'cb_gl.SelectedValue = Me.CONT_CPF_contratosTableAdapter.gliquida(id_contrato1)
                Dim gfonaga As Integer = Me.CONT_CPF_contratosTableAdapter.id_garantia(id_contrato1)

                If gfonaga = 2 Then
                    CK_FONAGA.Checked = True
                Else
                    CK_FONAGA.Checked = False
                End If
            End If
            'Dim cliente As String
            ' cliente = cbclientes.SelectedValue


            'Me.Vw_AnexosTableAdapter.FillBy_ANEXO(Me.DS_contratos.Vw_Anexos, Anexo, Ciclo)
            'Me.Vw_Anexos1TableAdapter.FillBy_anexo(Me.DS_contratos6.Vw_Anexos1, Anexo, Ciclo)

            ' cbclientes_SelectedIndexChanged(Nothing, Nothing)
            ' Vw_AnexosBindingSource_CurrentChanged(Nothing, Nothing)
        Else

            If sinanexo = False Then
                cbanexos.Visible = True
                ' cbanexos2.Visible = False
                ListBox1.Visible = False

            Else
                cbanexos.Visible = False
                ' cbanexos2.Visible = True
                bt_guardar.Enabled = False
                '  ListBox1.Visible = False
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
                'cb_gl.SelectedValue = Me.CONTCPFcontratosBindingSource("porcentaje_Gliquida")
                'Dim fonaga As String
                Vw_AnexosBindingSource_CurrentChanged(Nothing, Nothing)
                bt_guardar.Enabled = False
            Else
                Me.ClientesTableAdapter.FillByAnexo(Me.DS_contratos.Clientes, Anexo)
                If IsNothing(Ciclo) Then Ciclo = ""
                Me.Vw_AnexosTableAdapter.FillBy_ANEXO(Me.DS_contratos.Vw_Anexos, Anexo, Ciclo)
                Me.Vw_Anexos1TableAdapter.FillBy_anexo(Me.DS_contratos6.Vw_Anexos1, Anexo, Ciclo)
                ' Me.Vw_descuentoSATableAdapter.FillByANEXO(Me.DS_contratos.vw_descuentoSA, Anexo, Ciclo)

                bt_guardar.Enabled = True
                ' BT_IMPRIMIR.Enabled = False

            End If
        End If

    End Sub

    Private Sub txtcliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcliente.TextChanged
        Me.ClientesBindingSource.Filter = "descr like '%" & txtcliente.Text.Trim & "%'"
        cbclientes_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_guardar.Click
        Dim FN, FB, BP As Decimal
        Dim año1 As Date = Now
        Dim sucursal As String
        Dim Inserto As Boolean = False
        Dim Pcxsg As Decimal
        Dim tasafijafira As Decimal = txt_tasafija.Text
        validar_vacios()
        Dim año As String
        año = año1.ToString("yyyy")

        Dim periodo As Integer = año
        Dim coberturanominal As Decimal = Me.CONT_CPF_configuracionTableAdapter.CNOMINAL(periodo)
        ' If CONT_CPF_clasificacion_garantiasBindingSource.Current("fonaga") <> "NO" Then
        '   If Vw_AnexosBindingSource.Current("tipta") = 7 Then
        '  Pcxsg = Me.CONT_CPF_configuracionTableAdapter.cxsg_tf_periodo(año)
        'Else
        'If CONT_CPF_clasificacion_garantiasBindingSource.Current("categoria") = "OTRO" Then
        'Pcxsg = TXT_CXS.Text
        'Else
        'Select Case Vw_AnexosBindingSource.Current("Tipar")
        'Case "H", "C"   'AVIO Y CC
        'Pcxsg = Me.CONT_CPF_configuracionTableAdapter.CXSG_FONAGA_CT(año)
        'Case "A"  'AVIO Y CC
        'Pcxsg = 0
        'Case Else
        'Pcxsg = Me.CONT_CPF_configuracionTableAdapter.CXSG_FONAGA_IF(año)
        'End Select
        'End If

        'Pcxsg = PCXSG_FONAGA
        'End If

        'Else

        'Pcxsg = Me.CONT_CPF_configuracionTableAdapter.cxsg_tf_periodo(año)
        'End If





        ' Pcxsg = 0.5

        If cb_gl.SelectedValue = 4 Then 'caso especial 
            Pcxsg = TXT_CXS.Text
        End If
        If txt_tipo.Text = "CREDITO DE AVÍO" Then
            cb_periodo_capital.Text = "AL VENCIMIENTO"
        End If

        If Ministracion1 = True Then 'INSERT

            '  id_contrato = Me.CONT_CPF_contratosTableAdapter.ScalarQueryID_CONTRATO(Vw_AnexosBindingSource.Current("Anexo"), Vw_AnexosBindingSource.Current("Ciclo"))
            '  If Me.CONT_CPF_contratosTableAdapter.ScalarQueryID_CONTRATO(Vw_AnexosBindingSource.Current("Anexo"), Vw_AnexosBindingSource.Current("Ciclo")) > 0 Then
            ' MessageBox.Show("Ya existe un contrato para ese contrato y ciclo", "CONTRATOS CARTERA PASIVA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Exit Sub
            'End If
            ' id_contrato = Me.CONT_CPF_contratosTableAdapter.contratobycredito(txt_credito.Text)

            If Me.CONT_CPF_contratosTableAdapter.contratobycredito(txt_credito.Text) > 0 Then
                MessageBox.Show("Ya existe un contrato con ese id_credito", "CONTRATOS CARTERA PASIVA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If txt_credito.Text = "" Then
                txt_credito.Text = Me.CONT_CPF_configuracionTableAdapter.ScalarQueryconfiguracion(CONFIG.idcreditofac)
                Me.CONT_CPF_configuracionTableAdapter.consumeidcreditofact()
            End If

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
                ' Pcxsg = 0 se aplica o no?
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
            'ACTUALIZA IDCREDITO EN LA CARPETA ACTIVA

            'revisar que no este bloqueado por mc
            Dim bloqueo As String
            bloqueo = Me.AnexosBloqueadosMCTableAdapter.Fill(Me.DescuentosDS.AnexosBloqueadosMC, Vw_AnexosBindingSource.Current("Anexo"))
            If bloqueo <> "" Then 'desbloquear
                Me.AnexosBloqueadosMCTableAdapter.desbloquearMC(Vw_AnexosBindingSource.Current("Anexo"))
            End If
            If AVIO = True Then
                Me.AviosTableAdapter.UpdateQueryidcredito(txt_credito.Text, Vw_AnexosBindingSource.Current("Ciclo"), Vw_AnexosBindingSource.Current("Anexo"))
            Else
                Me.AnexosTableAdapter.updateidcredito(txt_credito.Text, Vw_AnexosBindingSource.Current("Anexo"))

            End If
            If bloqueo <> "0" Then 'bloqueo
                Me.AnexosBloqueadosMCTableAdapter.bloquearMC(Vw_AnexosBindingSource.Current("Anexo"))
            End If


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
            persona = Me.ClientesTableAdapter.ScalarQueryId_Acreditado(cbclientes.SelectedValue)
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
        id_contrato = Me.CONT_CPF_contratosTableAdapter.ScalarQueryID_CONTRATO(Vw_AnexosBindingSource.Current("Anexo"), Vw_AnexosBindingSource.Current("Ciclo"))
        Me.CONT_CPF_contratosTableAdapter.penalizacionupdate(ch_pen.Checked, id_contrato) 'dagl 26/06/2018 guardar subsidio 
        penalizacion = ch_pen.Checked
        ' Me.CONT_CPF_contratosTableAdapter.Updatesubsidio(Cksubsidio.Checked, id_contrato) 'dagl 23/01/2018 guardar subsidio 

        If Ministracion1 = True And Inserto = True Then
            CargaVencimientos()

            Dim F2 As New Frm_MinistracionesADD

            F2.BP = BP
            F2.FB = FB
            F2.FN = FN
            F2.Ministracion1 = Ministracion1
            F2.ID_Contrato = id_contrato
            If cb_gl.SelectedIndex = 4 Then
                If CK_FONAGA.Checked = True Then
                    F2.ID_garantina = 2
                    'FONAGA
                Else
                    'FEGA

                    F2.ID_garantina = 1
                End If

                F2.PCXSG = Pcxsg
                F2.Nominal = TXT_NOM.Text
                F2.Efectiva = TXT_EFEC.Text
            Else
                ' Dim tipo_ga As Integer = Me.CONT_CPF_contratosTableAdapter.tipo_garantia(id_contrato)
                '  Dim ga_fonaga As String = Me.CONT_CPF_clasificacion_garantiasTableAdapter.fonaga(tipo_ga)

                If CK_FONAGA.Checked = True Then

                    F2.ID_garantina = 2

                    Dim GL As Integer = cb_gl.SelectedValue

                    If CH_q09.Checked = True Then 'PROGRAMAQ09
                        Select Case GL
                            Case 1
                                F2.PCXSG = Me.CONT_CPF_configuracionTableAdapter.FONAGAQ09_0(periodo)
                            Case 2
                                F2.PCXSG = Me.CONT_CPF_configuracionTableAdapter.FONAGAQ09_10(periodo)
                            Case 3
                                F2.PCXSG = Me.CONT_CPF_configuracionTableAdapter.FONAGAQ09_15(periodo)
                            Case 4
                                F2.PCXSG = Me.CONT_CPF_configuracionTableAdapter.FONAGAQ09_20(periodo)
                        End Select
                    Else 'PROGRAMAZ16
                        Select Case GL
                            Case 1
                                F2.PCXSG = Me.CONT_CPF_configuracionTableAdapter.FONAGA0(periodo)
                            Case 2
                                F2.PCXSG = Me.CONT_CPF_configuracionTableAdapter.FONAGA10(periodo)
                            Case 3
                                F2.PCXSG = Me.CONT_CPF_configuracionTableAdapter.FONAGA15(periodo)
                            Case 4
                                F2.PCXSG = Me.CONT_CPF_configuracionTableAdapter.FONAGA20(periodo)
                        End Select

                    End If

                Else 'FEGA

                    F2.ID_garantina = 1

                    Dim GL As Integer = cb_gl.SelectedValue


                    Select Case GL
                        Case 1
                            F2.PCXSG = Me.CONT_CPF_configuracionTableAdapter.FEGA0(periodo)
                        Case 2
                            F2.PCXSG = Me.CONT_CPF_configuracionTableAdapter.FEGA10(periodo)
                        Case 3
                            F2.PCXSG = Me.CONT_CPF_configuracionTableAdapter.FEGA15(periodo)
                        Case 4
                            F2.PCXSG = Me.CONT_CPF_configuracionTableAdapter.FEGA20(periodo)
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

                F2.Nominal = coberturanominal
                vgl = Me.CONT_CPF_GLTableAdapter.gliquida(cb_gl.SelectedValue)
                F2.Efectiva = (100 - vgl) * coberturanominal / 100


            End If

            'id_contrato = Me.CONT_CPF_contratosTableAdapter.ScalarQueryID_CONTRATO(Vw_AnexosBindingSource.Current("Anexo"), Vw_AnexosBindingSource.Current("Ciclo"))
            Me.CONT_CPF_contratosTableAdapter.UpdateCXSG(F2.PCXSG, vgl, id_contrato) 'dagl 26/06/2018 guardar PCXG Y GL

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


        If cb_gl.SelectedValue >= 0 Then
            cb_gl.SelectedValue = 1
        End If
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
        Cksubsidio.Checked = False
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
            'If sinanexo = False Then
            '  Me.Vw_AnexosTableAdapter.FillBy_anexoporcliente(Me.DS_contratos.Vw_Anexos, cbclientes.SelectedValue)
            'Me.Vw_Anexos1TableAdapter.FillBy_anexo(Me.DS_contratos6.Vw_Anexos1, Anexo, Ciclo)
            'Else

            Me.Vw_descuentoSATableAdapter.FillBYCLIENTE(Me.DS_contratos.vw_descuentoSA, cbclientes.SelectedValue)



            'End If

            '  If txtanexo.TextLength > 0 Then
            ' sinanexo = False
            'Anexo = txtanexo.Text
            'Ciclo = ET_CICLO.Text

            'End If
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

        Dim ANEXO As String
        ANEXO = Vw_AnexosBindingSource.Current("Anexo")

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
                DIAS_ENTRE_VENC = taVencimieto.DiasEntreVencimientos(ANEXO)
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
                CargaDatosFira()
            End If
        End If

    End Sub

    Private Sub BT_IMPRIMIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_IMPRIMIR.Click
        If sinanexo = False Then
            frm_edo_cuenta.Anexo = Anexo
            frm_edo_cuenta.Ciclo = Ciclo
        Else

            If Reestructura_txt.TextLength > 0 Then
                frm_edo_cuenta.reestructura = True
            End If
            ' frm_edo_cuenta.Tipar = Me.VwdescuentoSABindingSource.Current("Tipar")
            'frm_edo_cuenta.Anexo = Me.VwdescuentoSABindingSource.Current("Anexo")
            'frm_edo_cuenta.Ciclo = Me.VwdescuentoSABindingSource.Current("ciclo")

            penalizacion = Me.CONTCPFcontratosBindingSource1.Current("penalizacion")

            If sinanexo = True Then
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

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub cbanexos2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TXTMONEDA.TextChanged
        If TXTMONEDA.Text.Trim = "MXN" Then

            cb_divisa.SelectedValue = 1

        Else

            cb_divisa.SelectedValue = 2

        End If
    End Sub

    Private Sub TXT_SUBRAMA_TextChanged(sender As Object, e As EventArgs) Handles TXT_SUBRAMA.TextChanged
        If TXT_SUBRAMA.Text.Length >= 3 Then
            If cb_rama.SelectedIndex >= 0 Then
                Me.CONT_CPF_subramasTableAdapter.clave(Me.DS_contratos.CONT_CPF_subramas, cb_rama.SelectedValue, TXT_SUBRAMA.Text)

            End If
        End If
    End Sub

    Private Sub lb_ciclo_Click(sender As Object, e As EventArgs) Handles lb_ciclo.Click

    End Sub

    Private Sub cb_clasificacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_clasificacion.SelectedIndexChanged

    End Sub

    Private Sub TextBox2_TextChanged_1(sender As Object, e As EventArgs) Handles TXT_NOM.TextChanged

    End Sub

    Private Sub Label68_Click(sender As Object, e As EventArgs) Handles Label68.Click

    End Sub

    Private Sub txt_prenda_TextChanged(sender As Object, e As EventArgs) Handles txt_prenda.TextChanged

    End Sub

    Sub CargaDatosFira()
        'Me.CONT_CPF_contratosTableAdapter.FillByporanexo(Me.DS_contratos.CONT_CPF_contratos, Vw_AnexosBindingSource.Current("Anexo"), Vw_AnexosBindingSource.Current("Ciclo"))
        Me.CONT_CPF_contratosTableAdapter.FillByIDCREDITO(Me.DS_contratos.CONT_CPF_contratos, VwdescuentoSABindingSource.Current("id_credito"))
        Me.CONT_CPF_contratosTableAdapter.FillByIDCREDITO(Me.DS_contratos7.CONT_CPF_contratos, VwdescuentoSABindingSource.Current("id_credito"))
        id_contrato = Me.CONT_CPF_contratosTableAdapter.idcontrato(VwdescuentoSABindingSource.Current("id_credito"))
        If id_contrato = "1022" Then
            Dim x As Integer = 0
        End If
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

    Private Sub Label55_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label55_Click_1(sender As Object, e As EventArgs) Handles Label55.Click

    End Sub

    Private Sub TextBox2_TextChanged_2(sender As Object, e As EventArgs) Handles Reestructura_txt.TextChanged

    End Sub

    Private Sub cb_rama_SelectedValueChanged(sender As Object, e As EventArgs) Handles cb_rama.SelectedValueChanged

    End Sub

    Private Sub txt_suma_m_TextChanged(sender As Object, e As EventArgs) Handles txt_suma_m.TextChanged

    End Sub

    Private Sub txt_credito_TextChanged(sender As Object, e As EventArgs) Handles txt_credito.TextChanged

    End Sub

    Private Sub cb_subrama_SelectedValueChanged(sender As Object, e As EventArgs) Handles cb_subrama.SelectedValueChanged
        If cb_subrama.SelectedIndex >= 0 Then
            id_subrama = Me.CONT_CPF_subramasTableAdapter.clave_subrama(cb_subrama.SelectedValue)
            '  Me.CONT_CPF_cadenasTableAdapter.Fill(Me.DS_contratos.CONT_CPF_cadenas, cb_rama.SelectedValue, id_subrama)
            Me.View_cadenas_subramasTableAdapter.Fill(Me.DS_contratos.View_cadenas_subramas, id_subrama, cb_rama.SelectedValue)
        End If

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txt_tasafija_TextChanged(sender As Object, e As EventArgs) Handles txt_tasafija.TextChanged

    End Sub

    Private Sub cbanexos_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbanexos.SelectedValueChanged

    End Sub



    Private Sub txt_id_contrato_TextChanged(sender As Object, e As EventArgs) Handles txt_id_contrato.TextChanged
        Reestructura_txt.Text = ""
        If txt_id_contrato.Text = "" Then
            txt_id_contrato.Text = 0
        End If
        If txt_id_contrato.Text = 14092 Then
            Reestructura_txt.Text = "0"
        End If
        Dim res As Integer = Me.CONT_CPF_reestructuraTableAdapter.reestructura_credito(txt_id_contrato.Text)
        If res <> 0 Then
            Reestructura_txt.Text = res
            ' If txt_id_contrato.Text = "1022" Then
            'Dim XX As Integer = 0

        End If
        'If Ministracion1 = False Then
        'CargaDatosFira()
        'End If
        'End If
    End Sub

    Private Sub cbclientes_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbclientes.SelectedValueChanged

    End Sub

    Private Sub ListBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedValueChanged
        'Me.ClientesTableAdapter.FillByAnexo(Me.DS_contratos.Clientes, Anexo)
        Reestructura_txt.Text = ""
        If txt_id_contrato.Text <> "" Then
            Dim res As Integer = Me.CONT_CPF_reestructuraTableAdapter.reestructura_credito(txt_id_contrato.Text)
            If res <> 0 Then
                Reestructura_txt.Text = res
                'If txt_id_contrato.Text = "1022" Then
                ' Dim XX As Integer = 0
            End If
        End If


        If cbclientes.SelectedIndex >= 0 And Ministracion1 = False Then
            If ListBox1.SelectedIndex >= 0 Then
                Dim idcredito_aux As Integer = ListBox1.SelectedValue

                Anexo = Me.Vw_descuentoSATableAdapter.ANEXO(idcredito_aux)

                If Anexo <> "" Then
                    Anexo = Anexo.Replace("/", "")
                    If Anexo.Length > 0 Then
                        '   Dim CREDITO As Integer = cbanexos2.SelectedValue
                        Anexo = Me.Vw_descuentoSATableAdapter.ANEXO(idcredito_aux)
                        Ciclo = Me.Vw_descuentoSATableAdapter.ciclo(idcredito_aux)
                        ' Me.CONT_CPF_contratosTableAdapter.FillByIDCREDITO(Me.DS_contratos.CONT_CPF_contratos, CREDITO)
                        Me.Vw_AnexosTableAdapter.FillBy_ANEXO(Me.DS_contratos.Vw_Anexos, Anexo, Ciclo)
                        Me.Vw_Anexos1TableAdapter.FillBy_anexo(Me.DS_contratos6.Vw_Anexos1, Anexo, Ciclo)

                    End If

                End If

                ' Ciclo = Me.Vw_descuentoSATableAdapter.ciclo(cbanexos2.SelectedValue)
                '  If Ciclo = 0 Then
                ' Ciclo = ""
                'End If

                'If txt_id_contrato.Text = "1022" Then
                'Dim A As Integer = 1
                'End If
                ' Anexo = Me.Vw_descuentoSATableAdapter.ANEXO(cbanexos2.SelectedValue)
                'Ciclo = Me.Vw_descuentoSATableAdapter.ciclo(cbanexos2.SelectedValue)
                'Me.CONT_CPF_contratosTableAdapter.FillByIDCREDITO(Me.DS_contratos.CONT_CPF_contratos, CREDITO)



                If txt_id_contrato.TextLength > 0 Then

                    Dim CREDITO1 As Integer = ListBox1.SelectedValue
                    Dim id_contrato1 As Integer = txt_id_contrato.Text
                    'cb_gl.SelectedValue = Me.CONT_CPF_contratosTableAdapter.gliquida(id_contrato1)
                    Dim gfonaga As Integer = Me.CONT_CPF_contratosTableAdapter.id_garantia(id_contrato1)

                    If gfonaga = 2 Then
                        CK_FONAGA.Checked = True
                    Else
                        CK_FONAGA.Checked = False
                    End If
                End If
                ' Dim id_contrato1 As Integer = Me.CONT_CPF_contratosBindingSource("id_contrato")
                '  cb_gl.SelectedValue = Me.CONT_CPF_contratosTableAdapter.gliquida(id_contrato1)

                ' CargaDatosFira()
            End If

        End If



    End Sub
End Class