Public Class Frm_MinistracionesADD
    Public ID_Contrato As Integer
    Public PCXSG As Decimal = 0
    Public PCXSG_Aux As Decimal = 0
    Public Nominal As Decimal = 0
    Public Efectiva As Decimal = 0
    Public ID_garantina As Integer = 0
    Public FechaVecn As Date
    Dim FechaPago As Date
    Dim FechaFinal As Date
    Dim MontoBase As Decimal = 0
    Dim dias As Integer = 0
    Dim Cobro As Decimal = 0
    Dim id_contratoGarantia As Integer = 0
    Public FN, FB, BP As Decimal
    Public Ministracion1 As Boolean = False



    Private Sub Frm_Descuentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_contratos' Puede moverla o quitarla según sea necesario.
        ' Me.CONT_CPF_contratosTableAdapter.Fill(Me.DS_contratos.CONT_CPF_contratos)
        CargaDatosDS()
        Dim F As Date = Date.Now.ToShortDateString
        Dim MAS As Integer = 1
        flagmin = False
        If F.DayOfWeek = DayOfWeek.Friday Then
            MAS = 3
        End If
        'If Ministracion1 = False Then
        '    dt_descuento.MinDate = F.AddDays(MAS)
        '    dt_descuento.MaxDate = F.AddDays(MAS)
        '    dt_descuento.Value = F.AddDays(MAS)
        'Else
        '    dt_descuento.MinDate = F
        '    dt_descuento.MaxDate = F.AddDays(MAS)
        '    dt_descuento.Value = F
        'End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim CONT_CPF_ministracionesTableAdapter As New DS_contratosTableAdapters.CONT_CPF_ministracionesTableAdapter
        Dim tasafira As Decimal = 0
        If TxttasaFira.Text.Length = 0 Then TxttasaFira.Text = 0
        tasafira = TxttasaFira.Text

        If MinistracionesBindingSource.Current("Tipta") = "7" And IsNumeric(TxttasaFira.Text) = 0 Then 'DAGL 24/01/2018 Se anexa "= 0", la validacion no permitia pasar de este punto 
            MessageBox.Show("Tasa Fira No valida", "Tasa Fira Cotizada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If MinistracionesBindingSource.Current("Tipta") = "7" And Val(TxttasaFira.Text) <= 0 Then
            MessageBox.Show("Tasa Fira No valida", "Tasa Fira Cotizada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If TxtAnexoCon.Text.Trim = "" Then
            MessageBox.Show("No hay contrato Selecionado", "Ministraciones", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If MessageBox.Show("Esta seguro de enviar la ministración de: " & MinistracionesBindingSource.Current("DESCr"), "Agregar ministración", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim Consec As Integer = Me.MinistracionesTableAdapter.SacaConsecutivo(MinistracionesBindingSource.Current("id_contrato"))
            Dim taGarantias As New DS_contratosTableAdapters.CONT_CPF_contratos_garantiasTableAdapter
            Dim taEdoCta As New DS_contratosTableAdapters.CONT_CPF_edocuentaTableAdapter
            Dim taCargosXservico As New DS_contratosTableAdapters.CONT_CPF_csgTableAdapter
            Dim SaldoCont As New DS_contratosTableAdapters.CONT_CPF_saldos_contingenteTableAdapter
            Dim NoGarantias As Integer = taGarantias.ExistenGarantias(MinistracionesBindingSource.Current("id_contrato"))
            Dim SaldoINI, SaldoFIN, InteORD, InteORDFN, InteORDFB As Decimal
            Dim FechaUltimoMov As Date

            CalculaServicioCobro()
            SaldoINI = taEdoCta.SaldoContrato(MinistracionesBindingSource.Current("id_contrato"))
            SaldoFIN = SaldoINI + MontoBase

            CONT_CPF_ministracionesTableAdapter.InsertQueryMinistracion(txt_monto.Text, dt_solicitud.Text, Consec, PCXSG_Aux, TXT_IVA.Text, txt_importe.Text, MinistracionesBindingSource.Current("id_contrato"), "Solicitado", dt_descuento.Text)
            Me.MinistracionesTableAdapter.Descontar(MinistracionesBindingSource.Current("Anexo"), MinistracionesBindingSource.Current("ciclo"), FechaPago.ToString("yyyyMMdd"))

            If NoGarantias = 0 Then
                taGarantias.Insert(MinistracionesBindingSource.Current("id_contrato"), ID_garantina, Nominal, MontoBase * (Nominal / 100), Efectiva, True)
                Me.CONT_CPF_contratosTableAdapter.Updatesubsidio(CheckBox1.Checked, ID_Contrato)


            Else
                Nominal = MinistracionesBindingSource.Current("Cobertura_Nominal")
                Efectiva = MinistracionesBindingSource.Current("Cobertura_Efectiva")
                taGarantias.UpdateSaldoConti(SaldoFIN * (Efectiva / 100), MinistracionesBindingSource.Current("id_contrato"))
                FB = MinistracionesBindingSource.Current("FB")
                BP = MinistracionesBindingSource.Current("BP")
                FN = MinistracionesBindingSource.Current("FN")
            End If

            If SaldoINI > 0 Then
                CargaTIIE(MinistracionesBindingSource.Current("FechaCorte"), MinistracionesBindingSource.Current("Tipta"), MinistracionesBindingSource.Current("ClaveEsquema"))
                If MinistracionesBindingSource.Current("Tipta") = "7" Then TIIE_Aplica = TxttasaFira.Text - FB 'DAGL 25/01/2018 En tasa fija se resta el valor FB
                FechaUltimoMov = Me.MinistracionesTableAdapter.FechaUltimoMov(MinistracionesBindingSource.Current("id_contrato"))
                Dim DiasX As Integer = DateDiff(DateInterval.Day, FechaUltimoMov, dt_descuento.Value)
                InteORD = SaldoINI * ((BP + TIIE_Aplica) / 100 / 360) * DiasX
                If MinistracionesBindingSource.Current("Tipta") = "7" Then 'DAGL 25/01/2018 En tasa fija se resta el valor FB
                    InteORDFB = SaldoINI * ((FB + tasafira) / 100 / 360) * DiasX
                Else
                    InteORDFB = SaldoINI * ((FB + TIIE_Aplica) / 100 / 360) * DiasX
                End If

                InteORDFN = SaldoINI * ((FN + TIIE_Aplica) / 100 / 360) * DiasX
            Else
                CargaTIIE(dt_descuento.Value, MinistracionesBindingSource.Current("Tipta"), MinistracionesBindingSource.Current("ClaveEsquema"))
                If MinistracionesBindingSource.Current("Tipta") = "7" Then TIIE_Aplica = TxttasaFira.Text - FB 'DAGL 25/01/2018 En tasa fija se resta el valor FB
                FechaUltimoMov = dt_descuento.Value.ToShortDateString
            End If

            id_contratoGarantia = Me.MinistracionesTableAdapter.SacaID(MinistracionesBindingSource.Current("id_contrato"))
            Dim subsidioaux As Boolean
            subsidioaux = Me.CONT_CPF_contratosTableAdapter.subsidio_contrato(ID_Contrato) 'dagl 24/01/2018 se agrega subsidio de la tabla contratos
            taCargosXservico.Insert(dt_descuento.Value, FechaFinal, dias, Date.Now, MontoBase, Cobro, Cobro * TasaIVA, Cobro * (1 + TasaIVA), txt_porcentaje.Text, id_contratoGarantia, subsidioaux)
            SaldoCont.Insert(dt_descuento.Value, Nothing, Nothing, Nothing, Nothing, MontoBase, SaldoFIN, Nominal, Efectiva, SaldoFIN * (Nominal / 100), SaldoFIN * (Efectiva / 100), id_contratoGarantia)


            If MinistracionesBindingSource.Current("FN") > 0 Then
                'If MinistracionesBindingSource.Current("Tipta") = "7" Then
                '  taEdoCta.Insert("FN", FechaUltimoMov, dt_descuento.Value.ToShortDateString, SaldoINI, SaldoFIN, 0, Nothing, 0, 0, 0, 0, 0, 0, MontoBase, MinistracionesBindingSource.Current("id_contrato"), TIIE_Aplica, 0, InteORDFN, 0)
                'Else
                taEdoCta.Insert("FN", FechaUltimoMov, dt_descuento.Value.ToShortDateString, SaldoINI, SaldoFIN, 0, Nothing, 0, 0, 0, 0, 0, 0, MontoBase, MinistracionesBindingSource.Current("id_contrato"), FN + TIIE_Aplica, 0, InteORDFN, 0)
                'End If

            End If

            If MinistracionesBindingSource.Current("Tipta") = "7" Then
                taEdoCta.Insert("BP", FechaUltimoMov, dt_descuento.Value.ToShortDateString, SaldoINI, SaldoFIN, 0, Nothing, 0, 0, 0, 0, 0, 0, MontoBase, MinistracionesBindingSource.Current("id_contrato"), BP, 0, InteORD, 0)
            Else
                taEdoCta.Insert("BP", FechaUltimoMov, dt_descuento.Value.ToShortDateString, SaldoINI, SaldoFIN, 0, Nothing, 0, 0, 0, 0, 0, 0, MontoBase, MinistracionesBindingSource.Current("id_contrato"), BP + TIIE_Aplica, 0, InteORD, 0)
            End If

            ' Dim TIIEfirafija As Decimal = 0
            '  TIIE_APLICA_TABLA = Me.TIIETableAdapter.SacaTIIE28(dt_descuento.Value.ToShortDateString)
            If MinistracionesBindingSource.Current("Tipta") = "7" Then
                tasafira = TxttasaFira.Text 'DAGL 25/01/2018 En tasa fija se resta el valor FB

                taEdoCta.Insert("FB", FechaUltimoMov, dt_descuento.Value.ToShortDateString, SaldoINI, SaldoFIN, 0, Nothing, 0, 0, 0, 0, 0, 0, MontoBase, MinistracionesBindingSource.Current("id_contrato"), tasafira, 0, InteORDFB, 0) 'tasafijafira
            Else
                taEdoCta.Insert("FB", FechaUltimoMov, dt_descuento.Value.ToShortDateString, SaldoINI, SaldoFIN, 0, Nothing, 0, 0, 0, 0, 0, 0, MontoBase, MinistracionesBindingSource.Current("id_contrato"), FB + TIIE_Aplica, 0, InteORDFB, 0)

            End If


            If ID_Contrato > 0 Then


                Me.MinistracionesTableAdapter.UpdateFechaCorteTIIE(dt_descuento.Value.ToShortDateString, TIIE_Aplica, ID_Contrato)
                Me.CONT_CPF_contratosTableAdapter.updatetasafijafira(tasafira, ID_Contrato) 'INGRESAMOS VALOR DE LA TASA FIRA FIJA
                CreaCalendarioRevisoinTasa(ID_Contrato, MinistracionesBindingSource.Current("Tipta"))
                Shell("F:\Executables\PsExec.exe \\192.168.29.41 -u AGIL\edgar-caceres -p c4c3r1t0s1 D:\Contratos$\Executables\MOD_PasivoFiraCalculos.exe " & ID_Contrato, AppWinStyle.Hide, False)
                Me.DialogResult = Windows.Forms.DialogResult.OK
                End If

                MessageBox.Show("Se Agregó la ministración", "Ministraciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                CargaDatosDS()
            End If
    End Sub

    Private Sub txt_monto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_monto.TextChanged
        CArgadatos()
    End Sub

    Sub CArgadatos()
        If Not IsNothing(MinistracionesBindingSource.Current) Then
            TasaIVA = MinistracionesBindingSource.Current("TasaIvaCliente") / 100
            CalculaServicioCobro()
        End If
        If txt_monto.Text.Trim <> "" Then
            txt_importe.Text = Cobro.ToString("n2")
            TXT_IVA.Text = (Cobro * TasaIVA).ToString("n2")
            txt_porcentaje.Text = PCXSG.ToString("n2")
        Else
            txt_importe.Text = "0.0"
            TXT_IVA.Text = "0.0"
            txt_porcentaje.Text = "0.0"
        End If
    End Sub

    Sub CargaDatosDS()

        If ID_Contrato <> 0 Then
            Me.MinistracionesTableAdapter.FillByIDContrato(Me.DescuentosDS.Ministraciones, ID_Contrato, ID_Contrato)
            If MinistracionesBindingSource.Current("Tipta") = "7" Then
                TxttasaFira.Visible = True
                TxttasaFira.ReadOnly = False
                Label8.Visible = True
                TxttasaFira.Text = "0.0"
            Else
                TxttasaFira.Visible = False
                Label8.Visible = False
            End If


        Else
            If MinistracionesBindingSource.Count > 0 Then

                If (MinistracionesBindingSource.Current("Tipta") = "7") Then
                    TxttasaFira.Visible = True
                    Label8.Visible = True
                Else
                    TxttasaFira.Visible = False
                    Label8.Visible = False
                End If

            End If
            Me.MinistracionesTableAdapter.Fill(Me.DescuentosDS.Ministraciones)
            If MinistracionesBindingSource.Count > 0 Then
                PCXSG = MinistracionesBindingSource.Current("porcentaje_CXSG")
                PCXSG_Aux = PCXSG
                CArgadatos()
            Else
                txt_importe.Text = "0.0"
                TXT_IVA.Text = "0.0"
                txt_porcentaje.Text = "0.0"
            End If

        End If
    End Sub

    Sub CalculaServicioCobro()
        Dim Subsidio As Decimal
        Dim subsidiox As Boolean
        FechaPago = Me.MinistracionesBindingSource.Current("FechaPAgo")
        If MinistracionesBindingSource.Current("Tipar") = "H" Or MinistracionesBindingSource.Current("Tipar") = "C" Or MinistracionesBindingSource.Current("Tipar") = "A" Then
            FechaFinal = Me.MinistracionesTableAdapter.PrimerVencimientoAVI(MinistracionesBindingSource.Current("Anexo"), MinistracionesBindingSource.Current("Ciclo"))
            MontoBase = MinistracionesBindingSource.Current("Importe")
        Else
            FechaFinal = Me.MinistracionesTableAdapter.PrimerVencimientoTRA(MinistracionesBindingSource.Current("Anexo"))
            MontoBase = MinistracionesBindingSource.Current("MontoFinanciado")
        End If
        PCXSG = MinistracionesBindingSource.Current("porcentaje_CXSG")
        dias = DateDiff(DateInterval.Day, dt_descuento.Value.Date, FechaFinal)
        Subsidiox = Me.CONT_CPF_contratosTableAdapter.subsidio_contrato(frm_contratos_alta.id_contrato)
        If subsidiox = True Then
            Subsidio = 2
        Else
            Subsidio = 1
        End If

        'If MinistracionesBindingSource.Current("Tipar") = "H" Or MinistracionesBindingSource.Current("Tipar") = "C" Or MinistracionesBindingSource.Current("Tipar") = "A" Then
        '    Cobro = ((((MontoBase / Subsidio) * (PCXSG / 100)) / 360)) * (dias + 1)
        'Else
        '    Cobro = ((((MontoBase / Subsidio) * (PCXSG / 100)) / 360)) * (dias)
        'End If
        Cobro = ((((MontoBase / Subsidio) * (PCXSG / 100)) / 360)) * (dias)
        PCXSG_Aux = PCXSG / Subsidio
    End Sub

    Private Sub LbFec_Click(sender As Object, e As EventArgs) Handles LbFec.Click
        dt_descuento.MinDate = Today.AddYears(-2)
        dt_descuento.MaxDate = Today.AddYears(2)
        dt_descuento.Value = Today
        dt_solicitud.Enabled = True
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        CalculaServicioCobro()
        CArgadatos()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        'CArgadatos()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.CONT_CPF_contratosTableAdapter.Updatesubsidio(CheckBox1.Checked, ID_Contrato) 'dagl 23/01/2018 guardar subsidio 
        MessageBox.Show("Se cambio el valor del subsidio", "Ministraciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        CArgadatos()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_DataMemberChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DataMemberChanged
        CArgadatos()
    End Sub

    Private Sub dt_descuento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dt_descuento.ValueChanged
        CArgadatos()
    End Sub
End Class