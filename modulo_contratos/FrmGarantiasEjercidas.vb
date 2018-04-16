
Public Class FrmGarantiasEjercidas
    Public Shared idcontrato, garantia As Integer
    Public Shared fecRec As Date
    Private Sub FrmGarantiasEjercidas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.CliGarantiasTableAdapter.FillByEjercidas(Me.DescuentosDS.CliGarantias)
        CmbCli_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private Sub CmbCli_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCli.SelectedIndexChanged
        If CmbCli.SelectedValue > 0 Then
            Me.GarantiaEjercidaRESUMTableAdapter.Fill(Me.DescuentosDS.GarantiaEjercidaRESUM, CmbCli.SelectedValue)
        End If
    End Sub

    Private Sub GarantiaEjercidaRESUMBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GarantiaEjercidaRESUMBindingSource.CurrentChanged
        If Not IsNothing(GarantiaEjercidaRESUMBindingSource.Current) Then
            Me.SaldoGarantiaEjercidaTableAdapter.Fill(Me.DescuentosDS.SaldoGarantiaEjercida, GarantiaEjercidaRESUMBindingSource.Current("id_contrato"))
            idcontrato = GarantiaEjercidaRESUMBindingSource.Current("id_contrato")
        End If
    End Sub

    Private Sub TxtImporte_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtImporte.KeyPress
        NumerosyDecimal(TxtImporte, e)
    End Sub

    Private Sub TxtTasa_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTasa.KeyPress
        NumerosyDecimal(TxtTasa, e)
    End Sub

    Private Sub TxtCapital_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCapital.KeyPress
        NumerosyDecimal(TxtCapital, e)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If IsNumeric(TxtInte.Text) And IsNumeric(TxtCapital.Text) And IsNumeric(TxtImporte.Text) Then
            CalculaInteres()
            Me.SaldoGarantiaEjercidaTableAdapter.Insert(GarantiaEjercidaRESUMBindingSource.Current("id_contrato"),
            0, TxtCapital.Text, TxtInte.Text, TxtTasa.Text, DtpIni.Value, DtpFin.Value, Date.Now, DtpRec.Value, TxtImporte.Text, 0, 0)
            CmbCli_SelectedIndexChanged(Nothing, Nothing)
            TxtImporte.Clear()
            TxtTasa.Clear()
            TxtCapital.Clear()
            TxtInte.Clear()
            DtpRec.Value = Today
            DtpFin.Value = Today
            MessageBox.Show("Pago Cargado.", "Carga de Pago", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No se puede realizar la carga del pago.", "Carga de Pago", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CalculaInteres()
        If IsNumeric(TxtImporte.Text) And IsNumeric(TxtTasa.Text) Then
            Dim dias As Integer = DateDiff(DateInterval.Day, DtpIni.Value, DtpFin.Value)
            Dim Saldo As Decimal = GarantiaEjercidaRESUMBindingSource.Current("ImporteGarantia") - GarantiaEjercidaRESUMBindingSource.Current("CapitalRecuperado")
            Dim tasa As Decimal = TxtTasa.Text
            Dim Intereses As Decimal = 0
            Dim CoberturaEFE As Decimal = GarantiaEjercidaRESUMBindingSource.Current("cobertura_efectiva") / 100
            Intereses = ((Saldo * (tasa / 100)) / 360 * dias) * CoberturaEFE
            TxtInte.Text = Intereses.ToString("n2")
        End If
    End Sub

    Private Sub TxtTasa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTasa.TextChanged
        CalculaInteres()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frm_rpt_solicitud_cargo.Show()
    End Sub

    Private Sub TxtCoberEfect_TextChanged(sender As Object, e As EventArgs) Handles TxtCoberEfect.TextChanged
        garantia = TxtCoberEfect.Text
    End Sub

    Private Sub DtpRec_ValueChanged(sender As Object, e As EventArgs) Handles DtpRec.ValueChanged
        fecRec = DtpRec.Text
    End Sub
End Class