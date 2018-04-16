Public Class FrmGarantiasXEjercer

    Private Sub FrmGarantiasEjercidas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CliGarantiasTableAdapter.Fill(Me.DescuentosDS.CliGarantias)
        CmbCli_SelectedIndexChanged(Nothing, Nothing)

    End Sub

    Private Sub CmbCli_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCli.SelectedIndexChanged
        If CmbCli.SelectedValue > 0 Then
            Me.GarantiasEjerTableAdapter.Fill(Me.DescuentosDS.GarantiasEjer, CmbCli.SelectedValue)
        End If
    End Sub


    Private Sub GarantiasEjerBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GarantiasEjerBindingSource.CurrentChanged
        If Not IsNothing(GarantiasEjerBindingSource.Current) Then
            Dim FechaVenc As Date = Me.GarantiasEjerTableAdapter.Vencimiento(GarantiasEjerBindingSource.Current("id_contrato"))
            Dim Fecha2 As Date = FechaVenc.AddDays(120)
            If Today >= FechaVenc And Today <= Fecha2 Then
                BtnEjercer.Enabled = True
                If GarantiasEjerBindingSource.Current("Ciclo") > "" Then
                    TxtSaldo.Text = Me.GarantiasEjerTableAdapter.SaldoAnexoAV(GarantiasEjerBindingSource.Current("Anexo"), GarantiasEjerBindingSource.Current("Ciclo"))
                    TxtSaldo.Text = CDec(TxtSaldo.Text).ToString("n2")
                Else
                    TxtSaldo.Text = Me.GarantiasEjerTableAdapter.SaldoAnexoTRA(GarantiasEjerBindingSource.Current("Anexo"))
                    TxtSaldo.Text = CDec(TxtSaldo.Text).ToString("n2")
                End If
            Else
                'BtnEjercer.Enabled = False
                TxtSaldo.Text = "0.0"
            End If
        End If

    End Sub

    Private Sub BtnEjercer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEjercer.Click
        If Not IsNothing(GarantiasEjerBindingSource.Current) Then
            Dim ta As New DescuentosDSTableAdapters.SaldoGarantiaEjercidaTableAdapter
            Dim FechaVenc As Date = Me.GarantiasEjerTableAdapter.Vencimiento(GarantiasEjerBindingSource.Current("id_contrato"))
            Dim SaldoContingente As Decimal
            If CDec(TxtSaldo.Text) > GarantiasEjerBindingSource.Current("saldo_contingente") Then
                SaldoContingente = GarantiasEjerBindingSource.Current("saldo_contingente")
            Else
                If CDec(TxtSaldo.Text) > 0 Then
                    SaldoContingente = CDec(TxtSaldo.Text)
                Else
                    SaldoContingente = GarantiasEjerBindingSource.Current("saldo_contingente")
                End If
            End If
            ta.Insert(GarantiasEjerBindingSource.Current("id_contrato"), SaldoContingente,
            0, 0, 0, FechaVenc, FechaVenc, Date.Now, FechaVenc, 0, CDec(TxtSaldo.Text), GarantiasEjerBindingSource.Current("saldo_contingente"))
            CmbCli_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub
End Class