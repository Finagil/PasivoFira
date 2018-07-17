Public Class frm_edo_cuenta
    Public Anexo As String

    Public Ciclo As String
    Public Tipar As String
    Dim FechaAnt As Date
    Dim Minis_Base As Decimal
    Dim diasX As Integer = 0
    Dim Id_contro As Integer
    Dim R As DescuentosDS.ContratoDatosRow


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim f As New frm_rpt_estado
        f.WindowState = FormWindowState.Maximized
        f.Show()
    End Sub

    Private Sub frm_edo_cuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.PagosClienteTableAdapter.Fill(Me.DS_reportes.PagosCliente, Anexo, Ciclo, Anexo)
        Me.PagosClienteBindingSource.Sort = "Fecha"
        Dtp_Fecha.Text = Today


        '  Dtp_Fecha.MinDate = R.FechaCorte.AddDays(1)
        '  Dtp_Fecha.MaxDate = R.FechaCorte.AddMonths(1)
        'CalculaInteres()
        Button1.Focus()
    End Sub

    Sub CalculaInteres()
        Dim Total As Decimal = 0
        Dim RestaDias As Integer
        If Tipar = "H" Or Tipar = "C" Or Tipar = "A" Then
            RestaDias = 0
        Else
            RestaDias = 0
        End If
        diasX = DateDiff(DateInterval.Day, R.FechaCorte, Dtp_Fecha.Value)
        Dim diasY As Integer = DateDiff(DateInterval.Day, FechaAnt, Dtp_Fecha.Value)
        Dim InteORD As Decimal = 0

        If R.id_tipo_tasa <> 3 Then
            CargaTIIE(R.FechaCorte, "7", "")
            If R.id_tipo_tasa = 1 Then
                If R.FN > 0 Then
                    ' Dim InteresAux1FN As Decimal = 0
                   
                    '  InteresAux1FN = Me.CONT_CPF_edocuentaTableAdapter.sacaintFN(R.id_contrato, R.FechaCorte,  Dtp_Fecha.Value)
                    ' InteORD = Math.Round((CDec(TXT_CAP_VI.Text)) * ((R.FN + R.TiieActiva)) / 100 / 360) * (diasX)
                    InteORD = Math.Round((CDec(TXT_CAP_VI.Text)) * ((R.FN + R.TiieActiva)) / 100 / 360) * (diasX)
                    '   InteORD = InteORD
                End If



            Else

                CargaTIIE(R.FechaCorte, "7", "")
                If diasX <> diasY And Minis_Base > 0 Then
                    InteORD = (CDec(TXT_CAP_VI.Text) + CDec(TXT_FIN_VI.Text) - Minis_Base) * ((R.FB) / 100 / 360) * (diasX - RestaDias)
                    InteORD += (Minis_Base) * ((R.FB + R.TiieActiva) / 100 / 360) * (diasY - 1)
                Else
                    InteORD = (CDec(TXT_CAP_VI.Text) + CDec(TXT_FIN_VI.Text)) * ((R.FB) / 100 / 360) * (diasX - RestaDias)
                End If

            End If
        Else








            If diasX <> diasY And Minis_Base > 0 Then
                InteORD = (CDec(TXT_CAP_VI.Text) + CDec(TXT_FIN_VI.Text) - Minis_Base) * ((R.FB + R.TiieActiva) / 100 / 360) * (diasX - RestaDias)
                InteORD += (Minis_Base) * ((R.FB + R.TiieActiva) / 100 / 360) * (diasY - 1)
            Else
                InteORD = (CDec(TXT_CAP_VI.Text) + CDec(TXT_FIN_VI.Text)) * ((R.FB + R.TiieActiva) / 100 / 360) * (diasX - RestaDias)
            End If
        End If
        If R.id_tipo_tasa = 1 Then
            ' TXT_FIN_VI.Text = 0.00
            '  TXT_FIN_VE.Text = 0.00


        End If

        TXT_ORD_VI.Text = InteORD.ToString("n2")
        Total += CDec(TXT_ORD_VI.Text) + CDec(TXT_ORD_VE1.Text)
        Total += CDec(TXT_FIN_VI.Text) + CDec(TXT_FIN_VE.Text)
        Total += CDec(TXT_MOR_OR.Text) + CDec(TXT_MOR_PE.Text)
        Total += CDec(TXT_CAP_VI.Text) + CDec(txt_cap_ve.Text)
        Total += CDec(TXT_CAP_INT_VIG.Text) + CDec(txt_cap_int_ve.Text)
        TxtTotal.Text = Total.ToString("n2")
        If Total <= 0 Then
            Button3.Enabled = False
        Else
            Button3.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Not IsNumeric(TxtPago.Text) Then
            MessageBox.Show("Importe no valido.", "Importe de pago", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtPago.Focus()
            Exit Sub
        End If
        If CDec(TxtPago.Text) > CDec(TxtTotal.Text) Then
            MessageBox.Show("Importe mayor al saldo.", "Importe de pago", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtPago.Focus()
            Exit Sub
        End If

        If MessageBox.Show("¿Esta seguro de aplicar el pago de " & FormatCurrency(TxtPago.Text) & "?", "Pago de contrato", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim Pago As Decimal = CDec(TxtPago.Text)
            Dim taEdoCta As New DS_contratosTableAdapters.CONT_CPF_edocuentaTableAdapter
            Dim CAP, FIN, ORD, Saldo_INI, Saldo_FIN As Decimal
            Dim CAP_pag, FIN_pag, ORD_pag As Decimal

            CAP = CDec(TXT_CAP_VI.Text).ToString("n2")
            FIN = CDec(TXT_FIN_VI.Text).ToString("n2")
            ORD = CDec(TXT_ORD_VI.Text).ToString("n2")
            Saldo_INI = CAP + FIN

            If Pago > ORD Then
                ORD_pag = ORD
                Pago -= ORD
            Else
                ORD_pag = Pago
                Pago = 0
            End If

            If Pago > FIN Then
                FIN_pag = FIN
                Pago -= FIN
            Else
                FIN_pag = Pago
                Pago = 0
            End If

            If Pago > CAP Then
                CAP_pag = CAP
                Pago -= CAP
            Else
                CAP_pag = Pago
                Pago = 0
            End If
            Saldo_FIN = CAP + FIN - FIN_pag - CAP_pag
            If R.id_tipo_tasa <> 3 Then
                CargaTIIE(R.FechaCorte, "7", "")
                If R.FN > 0 Then
                    taEdoCta.Insert("FN", R.FechaCorte, Dtp_Fecha.Value, Saldo_INI, Saldo_FIN, CAP_pag, 0, ORD, 0, 0, 0, 0, FIN, 0, R.id_contrato, R.FN + TIIE28, diasX, (FIN_pag) * -1, 0)
                End If
                taEdoCta.Insert("BP", R.FechaCorte, Dtp_Fecha.Value, Saldo_INI, Saldo_FIN, CAP_pag, 0, ORD, 0, 0, 0, 0, FIN_pag, 0, R.id_contrato, R.BP, diasX, (FIN_pag) * -1, 0)
                taEdoCta.Insert("FB", R.FechaCorte, Dtp_Fecha.Value, Saldo_INI, Saldo_FIN, CAP_pag, 0, ORD, 0, 0, 0, 0, FIN_pag, 0, R.id_contrato, R.FB + R.TiieActiva, diasX, (FIN_pag) * -1, 0)
            Else
                If R.FN > 0 Then
                    taEdoCta.Insert("FN", R.FechaCorte, Dtp_Fecha.Value, Saldo_INI, Saldo_FIN, CAP_pag, 0, ORD, 0, 0, 0, 0, FIN, 0, R.id_contrato, R.FN + R.TiieActiva, diasX, (FIN_pag) * -1, 0)
                End If
                taEdoCta.Insert("BP", R.FechaCorte, Dtp_Fecha.Value, Saldo_INI, Saldo_FIN, CAP_pag, 0, ORD, 0, 0, 0, 0, FIN_pag, 0, R.id_contrato, R.BP + R.TiieActiva, diasX, (FIN_pag) * -1, 0)
                taEdoCta.Insert("FB", R.FechaCorte, Dtp_Fecha.Value, Saldo_INI, Saldo_FIN, CAP_pag, 0, ORD, 0, 0, 0, 0, FIN_pag, 0, R.id_contrato, R.FB + R.TiieActiva, diasX, (FIN_pag) * -1, 0)
            End If

            Dim ta As New DS_contratosTableAdapters.CONT_CPF_contratosTableAdapter
            ta.UpdateFechaCorteTiie(Dtp_Fecha.Value.ToShortDateString, R.TiieActiva, frm_contratos_alta.id_contrato)
            ta.Dispose()
            Dim Pag As New DS_reportesTableAdapters.PagosTableAdapter
            Pag.Insert("PREPAGO", "PAGADO", Dtp_Fecha.Value.ToShortDateString, 0, 0, 0, ORD, FIN, CAP_pag, 0, R.id_contrato)
            Pag.Dispose()
            MessageBox.Show("Pago realizado", "Prepago", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frm_edo_cuenta_Load(Nothing, Nothing)
            TxtPago.Clear()
        End If
    End Sub

    Private Sub Dtp_Fecha_ValueChanged(sender As Object, e As EventArgs) Handles Dtp_Fecha.ValueChanged

        TXT_FIN_VI.Text = Me.CONT_CPF_edocuentaTableAdapter.int_ord(frm_contratos_alta.id_contrato, Dtp_Fecha.Value)
        TXT_CAP_VI.Text = Me.CONT_CPF_edocuentaTableAdapter.cap_vig(frm_contratos_alta.id_contrato, Dtp_Fecha.Value)
        TXT_ORD_VE.Text = Me.CONT_CPF_edocuentaTableAdapter.int_ord_ven(frm_contratos_alta.id_contrato, Dtp_Fecha.Value)
        If IsNothing(Me.CONT_CPF_edocuentaTableAdapter.Minis_base(frm_contratos_alta.id_contrato, Dtp_Fecha.Value)) Then
            Minis_Base = 0
        Else
            Minis_Base = Me.CONT_CPF_edocuentaTableAdapter.Minis_base(frm_contratos_alta.id_contrato, Dtp_Fecha.Value)
        End If
        FechaAnt = Me.CONT_CPF_edocuentaTableAdapter.Minis_Base_Fec(frm_contratos_alta.id_contrato, Dtp_Fecha.Value)

        TXT_CAP_VI.Text = CDec(TXT_CAP_VI.Text).ToString("n2")
        TXT_FIN_VI.Text = CDec(TXT_FIN_VI.Text).ToString("n2")
        TXT_ORD_VI.Text = CDec(TXT_ORD_VI.Text).ToString("n2")

        Dim ta As New DescuentosDSTableAdapters.ContratoDatosTableAdapter
        Dim ds As New DescuentosDS

        If sinanexo = True Then
            ta.FillByContrato2(ds.ContratoDatos, frm_contratos_alta.id_contrato)
        Else
            ta.Fill(ds.ContratoDatos, frm_contratos_alta.id_contrato)
        End If
        R = ds.ContratoDatos.Rows(0)
        CalculaInteres()
    End Sub

    Private Sub TxtPago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPago.KeyPress
        NumerosyDecimal(TxtPago, e)
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        If Not IsNothing(Me.PagosClienteBindingSource) Then
            TxtPago.Text = Me.PagosClienteBindingSource.Current("Importe")
        End If

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class