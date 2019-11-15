Public Class FrmGarantiasXEjercer
    Dim efectivo, saldo, garantia, monto As Decimal
    Dim manual As Boolean
    Private Sub FrmGarantiasEjercidas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_contratos' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_contratosTableAdapter.Fill(Me.DS_contratos.CONT_CPF_contratos)
        '     'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_garantias' Puede moverla o quitarla según sea necesario.
        ' Me.CONT_CPF_garantiasTableAdapter.Fill(Me.DS_contratos.CONT_CPF_garantias)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_contratos_garantias' Puede moverla o quitarla según sea necesario.

        Me.CliGarantiasTableAdapter.Fill(Me.DescuentosDS.CliGarantias)
        CmbCli_SelectedIndexChanged(Nothing, Nothing)
        txtmonto.Text = "0.0"
        Texgar.Text = "0.0"



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

            'dagl 
            If CDec(txtmonto.Text) > 0 And manual = True Then
                SaldoContingente = GarantiasEjerBindingSource.Current("saldo_contingente")

                '  If monto > SaldoContingente Then
                ' MessageBox.Show("Monto no puede ser mayor al saldo contingente", "FACTORAJE CARTERA PASIVA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                '            Else
                'ta.Insert(GarantiasEjerBindingSource.Current("id_contrato"), garantia, 0, 0, 0, FechaVenc, FechaVenc, Date.Now, FechaVenc, 0, saldo, monto)
                ta.Insert(GarantiasEjerBindingSource.Current("id_contrato"), monto, 0, 0, 0, FechaVenc, FechaVenc, DTFecha.Text, FechaVenc, 0, saldo, monto)
                '  ta.Insert(GarantiasEjerBindingSource.Current("id_contrato"), SaldoContingente,
                '0, 0, 0, FechaVenc, FechaVenc, Date.Now, FechaVenc, 0, CDec(TxtSaldo.Text), GarantiasEjerBindingSource.Current("saldo_contingente"))
                '               End If
                Me.CONT_CPF_contratosTableAdapter.UpdateIDSUSTITUCION(ID_TEXT.text, GarantiasEjerBindingSource.Current("id_contrato"))
                MessageBox.Show("Garantia ejercida", "FACTORAJE CARTERA PASIVA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                CmbCli_SelectedIndexChanged(Nothing, Nothing)

            Else

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


        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles Txtefec.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        manual = True
        efectivo = Txtefec.Text
        saldo = TxtSaldo.Text
        garantia = Texgar.Text
        monto = (saldo - garantia) * efectivo / 100
        txtmonto.Text = monto.ToString("n2")

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        '  Me.CONT_CPF_contratos_garantiasTableAdapter.FillBycontrato
        If TextBox1.Text <> "" Then
            Dim id_contrato = CInt(TextBox1.Text)
            Me.CONT_CPF_contratos_garantiasTableAdapter.FillBycontrato(Me.DS_contratos.CONT_CPF_contratos_garantias, id_contrato)

            If Me.CONTCPFcontratosgarantiasBindingSource.Current("id_garantia") = 1 Then
                ch_fonaga.Checked = False
            Else
                ch_fonaga.Checked = True

            End If
        End If



    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        txtmonto.Text = "0.0"
        manual = False

    End Sub
End Class