Public Class Frm_DescuentosFAC
    Private Sub Frm_DescuentosFAC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FactorajeDS.WEB_Lotes' Puede moverla o quitarla según sea necesario.
        Me.WEB_LotesTableAdapter.Fill(Me.FactorajeDS.WEB_Lotes)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_periodicidad' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_periodicidadTableAdapter.Fill(Me.DS_contratos.CONT_CPF_periodicidad)

        sinanexo = True
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_contratos' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_contratosTableAdapter.Fill(Me.DS_contratos.CONT_CPF_contratos)
        'TODO: esta línea de código carga datos en la tabla 'DescuentosDS.Ministraciones' Puede moverla o quitarla según sea necesario.
        '  Me.MinistracionesTableAdapter.Fill(Me.DescuentosDS.Ministraciones)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_vencimientos' Puede moverla o quitarla según sea necesario.
        ' Me.CONT_CPF_vencimientosTableAdapter.Fill(Me.DS_contratos.CONT_CPF_vencimientos)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_contratos_garantias' Puede moverla o quitarla según sea necesario.
        'Me.CONT_CPF_contratos_garantiasTableAdapter.Fill(Me.DS_contratos.CONT_CPF_contratos_garantias)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_ministraciones' Puede moverla o quitarla según sea necesario.
        'Me.CONT_CPF_ministracionesTableAdapter.Fill(Me.DS_contratos.CONT_CPF_ministraciones)
        'TODO: esta línea de código carga datos en la tabla 'FactorajeDS2.Clientes' Puede moverla o quitarla según sea necesario.
        'Me.ClientesTableAdapter.Fill(Me.FactorajeDS2.Clientes)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_divisas' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_divisasTableAdapter.Fill(Me.DS_contratos.CONT_CPF_divisas)
        'TODO: esta línea de código carga datos en la tabla 'FactorajeDS.CONT_CPF_contratos' Puede moverla o quitarla según sea necesario.
        'Me.CONT_CPF_contratosTableAdapter.Fill(Me.FactorajeDS.CONT_CPF_contratos)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_contratos' Puede moverla o quitarla según sea necesario.
        '  Me.CONT_CPF_contratosTableAdapter.Fill(Me.DS_contratos.CONT_CPF_contratos)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_configuracion' Puede moverla o quitarla según sea necesario.
        'Me.CONT_CPF_configuracionTableAdapter.Fill(Me.DS_contratos.CONT_CPF_configuracion)
        'TODO: esta línea de código carga datos en la tabla 'DescuentosDS.CONT_CPF_GL' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_GLTableAdapter.Fill(Me.DescuentosDS.CONT_CPF_GL)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_tipo_tasas' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_tipo_tasasTableAdapter.Fill(Me.DS_contratos.CONT_CPF_tipo_tasas)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_esquema_cobro' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_esquema_cobroTableAdapter.Fill(Me.DS_contratos.CONT_CPF_esquema_cobro)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_tipoprestamos' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_tipoprestamosTableAdapter.Fill(Me.DS_contratos.CONT_CPF_tipoprestamos)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_productos_fira' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_productos_firaTableAdapter.Fill(Me.DS_contratos.CONT_CPF_productos_fira)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_operacion' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_operacionTableAdapter.Fill(Me.DS_contratos.CONT_CPF_operacion)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_intermediarios' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_intermediariosTableAdapter.Fill(Me.DS_contratos.CONT_CPF_intermediarios)
        'TODO: esta línea de código carga datos en la tabla 'FactorajeDS1.CONT_CPF_Factor_Facturas' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'FactorajeDS.CONT_CPF_Factor_Facturas' Puede moverla o quitarla según sea necesario.
        'Me.CONT_CPF_Factor_FacturasTableAdapter.Fill(Me.FactorajeDS.CONT_CPF_Factor_Facturas)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim FN, FB, BP As Decimal
        Dim año1 As Date = Now
        Dim sucursal As String
        Dim Inserto As Boolean = False
        Dim Pcxsg As Decimal
        ' Dim tasafijafira As Decimal = txt_tasafija.Text
        ' validar_vacios()
        Dim año As String
        año = año1.ToString("yyyy")
        Dim secuencial_banco, idcreditofact As Integer
        Dim periodo As Integer = año
        Dim coberturanominal As Decimal = Me.CONT_CPF_configuracionTableAdapter.CNOMINAL(periodo)
        Dim monto As Decimal
        Dim cliente As String
        Dim tiieactiva As Decimal
        Dim tasatiie, id_contrato As Integer
        Dim num_control As String
        Dim nominal As Decimal
        Dim efectiva As Decimal
        Dim id_garantia As Integer
        Dim procesado As Integer = 0

        '  BP = Me.Vw_AnexosTableAdapter.SacaTasaTRA(Me.Vw_AnexosBindingSource.Current("Anexo"))

        cb_tasa.SelectedIndex = 2

        'BP = Me.Vw_AnexosTableAdapter.SacaDiferAVI(Me.Vw_AnexosBindingSource.Current("Anexo"), Me.Vw_AnexosBindingSource.Current("Ciclo"))
        Dim RENG As Integer = DGFACT.RowCount

        For Renglones As Integer = 0 To DGFACT.RowCount - 1


            idcreditofact = Me.CONT_CPF_configuracionTableAdapter.ScalarQueryconfiguracion(CONFIG.idcreditofac)
            secuencial_banco = Me.CONT_CPF_configuracionTableAdapter.ScalarQueryconfiguracion(CONFIG.secuencial_banco)
            año = año.ToString().Substring(año.Length - 3, 3)
            sucursal = 1
            num_control = cb_prestamo.SelectedValue & "/" & TxtIntermediario.Text & "/" & sucursal & "/" & secuencial_banco & "/" & año

            Dim rfc As String = Me.DGFACT.Item(2, Renglones).Value
            CLIENTETXT.Text = Me.ClientesTableAdapter.clientexrfc(Me.DGFACT.Item(2, Renglones).Value)
            monto = Me.DGFACT.Item(3, Renglones).Value

            Dim DOC As String = Me.DGFACT.Item(0, Renglones).Value
            Dim TASA As Decimal = Me.DGFACT.Item(4, Renglones).Value
            Dim pcsx = CDec(Val(PCXSG_TXT.Text))
            FB = CDec(Val(TXT_FB.Text))
            Dim fecha As Date = Me.DGFACT.Item(5, Renglones).Value
            Dim producto, operacion, prestamo, divisa, intermediario, esquema, tipotasa As Integer
            producto = cb_producto.SelectedValue
            operacion = cb_operacion.SelectedValue
            prestamo = cb_prestamo.SelectedValue
            divisa = cb_divisa.SelectedValue
            intermediario = cb_intermediario.SelectedValue
            esquema = cb_esquema.SelectedValue
            tipotasa = cb_tasa.SelectedValue
            Dim ta As New DescuentosDSTableAdapters.TIIETableAdapter
            ta.Connection.ConnectionString = "Provider=SQLOLEDB;Data Source=server-raid;Persist Security Info=True;Password=User_PRO2015;User ID=User_PRO;Initial Catalog=Production"
            tiieactiva = ta.SacaTIIE28(fecha.ToString("yyyyMMdd"))
            'tiieactiva = 1
            Dim tipotasatiie As String = "TIIE28"
            Dim tasafijafira As Decimal
            tasafijafira = Me.DGFACT.Item(4, Renglones).Value



            Me.CONT_CPF_contratosTableAdapter.InsertQueryFactoraje(cb_producto.SelectedValue, num_control, cb_operacion.SelectedValue,
            cb_prestamo.SelectedValue, cb_divisa.SelectedValue, monto, 0, idcreditofact, 1,
            cb_esquema.SelectedValue, cb_tasa.SelectedValue, BP, FN, FB, 0, 0,
            0, 1, secuencial_banco, 1, 1, 0,
            0, 0, 1, 0, 0, 0, 0,
            0, 0, 0, monto, 0, 0, BP,
            0, 0, 0, 0, 0, fecha, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
           pcsx, 0, 0, 0, "01/01/1900", ch_subsidio.Checked, cb_periodo_capital.SelectedValue, cb_periodo_int.SelectedValue,
            cb_periodo_revision.SelectedValue, CLIENTETXT.Text, DOC, tiieactiva, tipotasatiie, ch_subsidio.Checked, tasafijafira)




            Inserto = True
            id_contrato = Me.CONT_CPF_contratosTableAdapter.IDCONTRATOXDOC(CLIENTETXT.Text, DOC)

            Pcxsg = PCXSG_TXT.Text
            nominal = TXT_NOM.Text
            efectiva = TXT_EFEC.Text
            If CK_FONAGA.Checked = True Then

                id_garantia = 2

                Dim GL As Integer = cb_gl.SelectedValue


            Else 'FEGA

                id_garantia = 1

                Dim GL As Integer = cb_gl.SelectedValue



            End If

            ' cobro por servicios

            Dim Subsidio As Decimal
            Dim subsidiox As Boolean
            Dim FECHAPAGO, fechafinal As Date
            Dim dias As Integer

            FECHAPAGO = Me.DGFACT.Item(5, Renglones).Value
            ' If MinistracionesBindingSource.Current("Tipar") = "H" Or MinistracionesBindingSource.Current("Tipar") = "C" Or MinistracionesBindingSource.Current("Tipar") = "A" Then
            fechafinal = Me.DGFACT.Item(6, Renglones).Value
            monto = Me.DGFACT.Item(3, Renglones).Value
            dias = DateDiff(DateInterval.Day, FECHAPAGO, FECHAPAGO)
            subsidiox = ch_subsidio.Checked
            If subsidiox = True Then
                Subsidio = 2
            Else
                Subsidio = 1
            End If

            Dim Cobro As Decimal = ((((monto / Subsidio) * (Pcxsg / 100)) / 360)) * (dias)
            Dim PCXSG_Aux As Decimal = Pcxsg / Subsidio

            nominal = TXT_NOM.Text
            Dim vgl As Integer = Me.CONT_CPF_GLTableAdapter.gliquida(cb_gl.SelectedValue)
            efectiva = TXT_EFEC.Text
            Me.CONT_CPF_contratosTableAdapter.UpdateCXSG(Pcxsg, vgl, id_contrato) 'dagl 26/06/2018 guardar PCXG Y GL

            Dim montobase As Decimal = monto

            Dim taGarantias As New DS_contratosTableAdapters.CONT_CPF_contratos_garantiasTableAdapter

            Dim NoGarantias As Integer = taGarantias.ExistenGarantias(id_contrato)
            If NoGarantias = 0 Then
                taGarantias.Insert(id_contrato, id_garantia, nominal, montobase * (nominal / 100), efectiva, True)
            End If


            'AGREGANDO MINISTRACIONES


            Dim taEdoCta As New DS_contratosTableAdapters.CONT_CPF_edocuentaTableAdapter
            Dim taCargosXservico As New DS_contratosTableAdapters.CONT_CPF_csgTableAdapter
            Dim SaldoCont As New DS_contratosTableAdapters.CONT_CPF_saldos_contingenteTableAdapter
            Dim SaldoINI, SaldoFIN, InteORD, InteORDFN, InteORDFB As Decimal
            Dim FechaUltimoMov As Date

            SaldoINI = taEdoCta.SaldoContrato(id_contrato)
            SaldoFIN = SaldoINI + monto

            Dim porcentaje As Decimal = Pcxsg
            Dim importe As Decimal = Cobro
            Dim estatus As String = "OTORGADO"
            Dim descuento As Date = FECHAPAGO
            Dim iva As Decimal = Cobro + (TXT_IVA.Text / 100)

            Me.MinistracionesTableAdapter.InsertQuery(monto, FECHAPAGO, 1, porcentaje, iva, importe, id_contrato, estatus, descuento)

            'AGREGAR VENCIMIENTO
            Me.CONT_CPF_vencimientosTableAdapter.InsertQuerymanual(Me.DGFACT.Item(6, Renglones).Value, monto, "VIGENTE", 0, id_contrato)


            Me.CONT_CPF_configuracionTableAdapter.ConsumeSecuencial() 'consume el secuencial banco


            'CREAR CALENDARIO


            CreaCalendarioRevisoinTasa(id_contrato, "")
            Me.CONT_CPF_Factor_FacturasTableAdapter.UpdateQuery(Me.DGFACT.Item(8, Renglones).Value)
            procesado = procesado + 1

            Me.CONT_CPF_configuracionTableAdapter.ConsumeSecuencial() 'consume el secuencial banco
            Me.CONT_CPF_configuracionTableAdapter.consumeidcreditofact() 'consume el creditofact

        Next
        Me.CONT_CPF_Factor_FacturasTableAdapter.Fill(Me.FactorajeDS1.CONT_CPF_Factor_Facturas, ComboBox2.SelectedValue)


        ' MessageBox.Show("Reestructura Registrada", "CONTRATOS CARTERA PASIVA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)




    End Sub

    Private Sub TXT_EFEC_TextChanged(sender As Object, e As EventArgs) Handles TXT_EFEC.TextChanged

    End Sub

    Sub CalculaServicioCobro()

    End Sub

    Private Sub Label63_Click(sender As Object, e As EventArgs) Handles Label63.Click




    End Sub

    Private Sub Label59_Click(sender As Object, e As EventArgs) Handles Label59.Click

    End Sub

    Private Sub Label54_Click(sender As Object, e As EventArgs) Handles Label54.Click

    End Sub

    Private Sub cb_periodo_revision_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_periodo_revision.SelectedIndexChanged

    End Sub

    Private Sub cb_periodo_int_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_periodo_int.SelectedIndexChanged

    End Sub

    Private Sub cb_periodo_capital_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_periodo_capital.SelectedIndexChanged

    End Sub

    Private Sub CLIENTETXT_TextChanged(sender As Object, e As EventArgs) Handles CLIENTETXT.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ch_subsidio_CheckedChanged(sender As Object, e As EventArgs) Handles ch_subsidio.CheckedChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub TXT_IVA_TextChanged(sender As Object, e As EventArgs) Handles TXT_IVA.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub cb_divisa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_divisa.SelectedIndexChanged

    End Sub

    Private Sub cb_gl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_gl.SelectedIndexChanged

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub CK_FONAGA_CheckedChanged(sender As Object, e As EventArgs) Handles CK_FONAGA.CheckedChanged

    End Sub

    Private Sub Label69_Click(sender As Object, e As EventArgs) Handles Label69.Click

    End Sub

    Private Sub Label68_Click(sender As Object, e As EventArgs) Handles Label68.Click

    End Sub

    Private Sub Label67_Click(sender As Object, e As EventArgs) Handles Label67.Click

    End Sub

    Private Sub Label66_Click(sender As Object, e As EventArgs) Handles Label66.Click

    End Sub

    Private Sub TXT_NOM_TextChanged(sender As Object, e As EventArgs) Handles TXT_NOM.TextChanged

    End Sub

    Private Sub PCXSG_TXT_TextChanged(sender As Object, e As EventArgs) Handles PCXSG_TXT.TextChanged

    End Sub

    Private Sub TXT_FN_TextChanged(sender As Object, e As EventArgs) Handles TXT_FN.TextChanged

    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click

    End Sub

    Private Sub TXT_FB_TextChanged(sender As Object, e As EventArgs) Handles TXT_FB.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txt_BP_TextChanged(sender As Object, e As EventArgs) Handles txt_BP.TextChanged

    End Sub

    Private Sub Label55_Click(sender As Object, e As EventArgs) Handles Label55.Click

    End Sub

    Private Sub cb_tasa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_tasa.SelectedIndexChanged

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub cb_esquema_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_esquema.SelectedIndexChanged

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub TxtIntermediario_TextChanged(sender As Object, e As EventArgs) Handles TxtIntermediario.TextChanged

    End Sub

    Private Sub cb_prestamo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_prestamo.SelectedIndexChanged

    End Sub

    Private Sub cb_operacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_operacion.SelectedIndexChanged

    End Sub

    Private Sub Label62_Click(sender As Object, e As EventArgs) Handles Label62.Click

    End Sub

    Private Sub cb_intermediario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_intermediario.SelectedIndexChanged

    End Sub

    Private Sub Label57_Click(sender As Object, e As EventArgs) Handles Label57.Click

    End Sub

    Private Sub cb_producto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_producto.SelectedIndexChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedValueChanged
        Me.CONT_CPF_Factor_FacturasTableAdapter.Fill(Me.FactorajeDS1.CONT_CPF_Factor_Facturas, ComboBox2.SelectedValue)
    End Sub
End Class