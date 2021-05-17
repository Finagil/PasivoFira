Imports System.IO
Imports System
Imports Microsoft.Win32
Public Class Frm_PagosFAC
    Public taCorreos As New FactorajeDSTableAdapters.GEN_Correos_SistemaFinagilTableAdapter
    Public tacorreos2 As New PagosDSTableAdapters.GEN_ComandosCMDTableAdapter

    Public LOTE As Integer
    Private Sub Frm_PagosFAC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PagosDS.GEN_ComandosCMD' Puede moverla o quitarla según sea necesario.
        Me.GEN_ComandosCMDTableAdapter.Fill(Me.PagosDS.GEN_ComandosCMD)
        'TODO: esta línea de código carga datos en la tabla 'PagosDS1.CONT_CPF_PagosFira' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_PagosFiraTableAdapter1.Fill(Me.PagosDS1.CONT_CPF_PagosFira)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_vencimientos' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_vencimientosTableAdapter.Fill(Me.DS_contratos.CONT_CPF_vencimientos)
        'TODO: esta línea de código carga datos en la tabla 'FactorajeDS3.CONT_CPF_FacturasERROR' Puede moverla o quitarla según sea necesario.
        'Me.CONT_CPF_FacturasERRORTableAdapter.FillFACTERROR(Me.FactorajeDS3.CONT_CPF_FacturasERROR)
        'TODO: esta línea de código carga datos en la tabla 'FactorajeDS3.WEB_Lotes' Puede moverla o quitarla según sea necesario.
        Me.WEB_LotesTableAdapter.FillByPAGOS(Me.FactorajeDS3.WEB_Lotes)
        'TODO: esta línea de código carga datos en la tabla 'FactorajeDS2.CONT_CPF_PagosFira' Puede moverla o quitarla según sea necesario.
        '   Me.CONT_CPF_PagosFiraTableAdapter.Fill(Me.FactorajeDS2.CONT_CPF_PagosFira)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos1.CONT_CPF_configuracion' Puede moverla o quitarla según sea necesario.
        '  Me.CONT_CPF_configuracionTableAdapter.Fill(Me.DS_contratos1.CONT_CPF_configuracion)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_contratos' Puede moverla o quitarla según sea necesario.
        ' Me.CONT_CPF_contratosTableAdapter.Fill(Me.DS_contratos.CONT_CPF_contratos)
        'TODO: esta línea de código carga datos en la tabla 'FactorajeDS1.CONT_CPF_lotes' Puede moverla o quitarla según sea necesario.
        '   Me.CONT_CPF_lotesTableAdapter.FillBydescontados(Me.FactorajeDS1.CONT_CPF_lotes)
        'TODO: esta línea de código carga datos en la tabla 'FactorajeDS.CONT_CPF_Factor_Pagos' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'FactorajeDS.WEB_Lotes' Puede moverla o quitarla según sea necesario.
        '  Me.WEB_LotesTableAdapter.FillByPAGADOS(Me.FactorajeDS.WEB_Lotes)


    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedValueChanged
        LOTE = ComboBox2.SelectedValue
        Me.CONT_CPF_Factor_PagosTableAdapter.FillPORPAGAR(Me.FactorajeDS.CONT_CPF_Factor_Pagos, LOTE)
        Dim total As Decimal = Me.CONT_CPF_Factor_PagosTableAdapter.total(LOTE)
        txttotal.Text = total.ToString("n2")
    End Sub

    Private Sub btlayput_Click(sender As Object, e As EventArgs) Handles btlayput.Click

        Dim monto As Decimal
        Dim Inserto As Boolean = False
        Dim nominal As Decimal
        Dim procesado As Integer = 0
        Dim contador As Integer = 1
        Dim contador_archivo As Integer
        Dim sRenglon As String = Nothing
        Dim strStreamW As Stream = Nothing
        Dim strStreamWriter As StreamWriter = Nothing
        Dim ContenidoArchivo As String = Nothing
        Dim adelantado As String
        ' Donde guardamos los paths de los archivos que vamos a estar utilizando ..
        Dim PathArchivo As String

        'usuariogl()




        'tacorreos2.InsertQuery("C:\Jobs\", "Pago Factoraje", " PAGOFACT", UsuarioGlobal)

        'MessageBox.Show("Layout generado en C:\Factoraje\", "FACTORAJE CARTERA PASIVA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


        usuariogl()
        Dim u As String = usuarioglobal

        'Mandacorreofase(usuarioglobal, "PAGOS_FACT", "PAGO FACTORAJE LOTE" & ComboBox2.SelectedValue, "Se ha generado el layout del lote " & ComboBox2.SelectedValue & " para aplicar pagos por $" & total.ToString("n2"), usuarioglobal)

        Dim i As Integer
        '  BP = Me.Vw_AnexosTableAdapter.SacaTasaTRA(Me.Vw_AnexosBindingSource.Current("Anexo"))
        If Directory.Exists("C:\Factoraje") = False Then ' si no existe la carpeta se crea
            Directory.CreateDirectory("C:\Factoraje")
        End If
        '  BP = Me.Vw_AnexosTableAdapter.SacaTasaTRA(Me.Vw_AnexosBindingSource.Current("Anexo"))

        'cb_tasa.SelectedIndex = 2

        'BP = Me.Vw_AnexosTableAdapter.SacaDiferAVI(Me.Vw_AnexosBindingSource.Current("Anexo"), Me.Vw_AnexosBindingSource.Current("Ciclo"))
        Dim RENG As Integer = DG_pagos.RowCount
        Dim total As Decimal

        For Renglones As Integer = 0 To DG_pagos.RowCount - 1


            Dim fac As String = Me.DG_pagos.Item(1, Renglones).Value
            'fac = "EPG7010"
            Dim fac_aux As String = Me.CONT_CPF_FacturasERRORTableAdapter.facturanueva(fac)
            If fac_aux <> "" Then
                fac = fac_aux
            End If
            monto = Me.DG_pagos.Item(2, Renglones).Value
            Dim fecha As Date = Me.DG_pagos.Item(3, Renglones).Value
            If chk_anticipo.Checked = True Then
                adelantado = "S"
            Else
                adelantado = "N"
            End If
            'GENERAR ARCHIVO
            'creamos archivo 
            If contador = 1 Then

                sRenglon = Nothing
                strStreamW = Nothing
                strStreamWriter = Nothing
                ContenidoArchivo = Nothing
                contador_archivo = Me.CONT_CPF_configuracionTableAdapter.ScalarQueryconfiguracion(CONFIG.ARCHIVOfac)
                Windows.Forms.Cursor.Current = Cursors.WaitCursor
                PathArchivo = "C:\Factoraje\PAGOSFAC" & Format(Today.Date, "ddMMyyyy") & "LOTE " & ComboBox2.SelectedValue & "_" & contador_archivo & ".csv" ' Se determina el nombre del archivo con la fecha actual

                'verificamos si existe el archivo

                If File.Exists(PathArchivo) Then
                    strStreamW = File.Open(PathArchivo, FileMode.Open) 'Abrimos el archivo
                Else
                    strStreamW = File.Create(PathArchivo) ' lo creamos
                End If



                strStreamWriter = New StreamWriter(strStreamW, System.Text.Encoding.Default) ' tipo de codificacion para escritura
                strStreamWriter.WriteLine("id_credito" & "," & "monto" & "," & "fecha" & ",A" & ",N" & ",S")

            End If



            'If contador <= 1000 Then
            Dim id_credito As Integer = Me.CONT_CPF_contratosTableAdapter.IDCREDITOBYDOC(fac)

            If id_credito = 0 Then
                strStreamWriter.WriteLine(fac & "," & monto & "," & fecha & ",A" & ",N" & ",S")

            Else
                strStreamWriter.WriteLine(id_credito & "," & monto & "," & fecha & ",A" & ",N" & "," & adelantado)

            End If

            'End If

            ' If contador = 100 Then
            '  strStreamWriter.Close() ' cerramos
            ' contador = 0
            ' Me.CONT_CPF_configuracionTableAdapter.CONSUMEARCHIVOFACT()

            ' sRenglon = Nothing
            ' strStreamW = Nothing
            ' strStreamWriter = Nothing
            ' ContenidoArchivo = Nothing
            ' Donde guardamos los paths de los archivos que vamos a estar utilizando ..
            ' PathArchivo As String
            'End If

            If RENG = DG_pagos.RowCount - 1 Then
                strStreamWriter.Close() ' cerramos
            End If
            contador = contador + 1

            total = total + monto
        Next
        'Me.CONT_CPF_Factor_FacturasTableAdapter.Fill(Me.FactorajeDS.CONT_CPF_Factor_Facturas, ComboBox2.SelectedValue)
        strStreamWriter.Close() ' cerramos
        Me.CONT_CPF_configuracionTableAdapter.CONSUMEARCHIVOFACT()
        'Total = FormatCurrency(total)
        'Dim total1 As Double
        'total1 = FormatNumber(total, , TriState.True)
        ' total = total.ToString("n2")



        usuariogl()




        'tacorreos2.InsertQuery("C:\Jobs\", "Pago Factoraje", " PAGOFACT", UsuarioGlobal)

        MessageBox.Show("Layout generado en C:\Factoraje\", "FACTORAJE CARTERA PASIVA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Mandacorreofase(usuarioglobal, "PAGOS_FACT", "PAGO FACTORAJE LOTE" & ComboBox2.SelectedValue, "Se ha generado el layout del lote " & ComboBox2.SelectedValue & " para aplicar pagos por $" & total.ToString("n2"), usuarioglobal)

        'Mandacorreofase(usuarioglobal, "PAGOS_FACT", "PAGO FACTORAJE LOTE" & ComboBox2.SelectedValue, "Se ha generado el layout del lote " & ComboBox2.SelectedValue & " para aplicar pagos por $" & total.ToString("n2"), usuarioglobal)
        'taCorreos.Insert("PasivoFira@finagil.com.mx", "denise.gonzalez@finagil.com.mx", "PAGO FACTORAJE LOTE" & ComboBox2.SelectedValue, "Se ha generado el layout del lote " & ComboBox2.SelectedValue & " para aplicar pagos por $" & total.ToString("n2"), False, Date.Now, "")
        'taCorreos.Insert("PasivoFira@finagil.com.mx", "ecacerest@finagil.com.mx", "PAGO FACTORAJE LOTE" & ComboBox2.SelectedValue, "Se ha generado el layout del lote " & ComboBox2.SelectedValue & " para aplicar pagos por $" & total.ToString("n2"), False, Date.Now, "")
        'taCorreos.Insert("PasivoFira@finagil.com.mx", "maria.bautista@finagil.com.mx", "PAGO FACTORAJE LOTE" & ComboBox2.SelectedValue, "Se ha generado el layout del lote " & ComboBox2.SelectedValue & " para aplicar pagos por $" & total.ToString("n2"), False, Date.Now, "")
        'taCorreos.Insert("PasivoFira@finagil.com.mx", "layala@finagil.com.mx", "PAGO FACTORAJE LOTE" & ComboBox2.SelectedValue, "Se ha generado el layout del lote " & ComboBox2.SelectedValue & " para aplicar pagos por $" & total.ToString("n2"), False, Date.Now, "")
        ' taCorreos.Insert("PasivoFira@finagil.com.mx", "atorres@finagil.com.mx", "PAGO FACTORAJE LOTE" & ComboBox2.SelectedValue, "Se ha generado el layout del lote " & ComboBox2.SelectedValue & " para aplicar pagos por $" & total.ToString("n2"), False, Date.Now, "")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim RENG As Integer = DG_pagos.RowCount
        Dim monto As Decimal
        Dim procesado As Integer = 0
        Dim total_registros As Integer = 0

        For Renglones As Integer = 0 To DG_pagos.RowCount - 1

            Dim fac As String = Me.DG_pagos.Item(1, Renglones).Value
            'Dim fac As String = Me.DG_pagos.Item(1, Renglones).Value
            'fac = "EPG7010"
            Dim fac_aux As String = Me.CONT_CPF_FacturasERRORTableAdapter.facturanueva(fac)
            If fac_aux <> "" Then
                fac = fac_aux
            End If
            monto = Me.DG_pagos.Item(2, Renglones).Value
            Dim fecha As Date = Me.DG_pagos.Item(3, Renglones).Value
            Dim fechapago As String = Format(fecha, "yyyyMMdd")
            Dim id_contrato As Integer = Me.CONT_CPF_contratosTableAdapter.idcontrato_by_factura(fac)
            Dim id_credito As Integer = Me.CONT_CPF_contratosTableAdapter.IDCREDITOBYDOC(fac)
            Dim estatus As Integer = Me.CONT_CPF_contratosTableAdapter.ESTATUSCONTRATO(id_contrato)

            Dim existe As Integer = Me.CONT_CPF_PagosFiraTableAdapter.id_contrato_pago(id_contrato, fechapago)
            If estatus <> 0 Then


                If existe = 0 Then
                    Me.CONT_CPF_PagosFiraTableAdapter.InsertQuery(id_contrato, fecha, monto, 0, fechapago, 0, id_credito, 0, 0)
                    procesado = procesado + 1
                End If


                If chk_adelantado.Checked = True Then

                    'Me.CONT_CPF_vencimientosTableAdapter.UpdateCapital(monto, id_contrato, fecha)
                    Me.CONT_CPF_vencimientosTableAdapter1.DeleteQuery(id_contrato)
                    Me.CONT_CPF_vencimientosTableAdapter1.InsertVencimiento(fecha, monto, "01/01/1900", "VIGENTE", 0, id_contrato, 0)
                    Me.CONT_CPF_PagosFiraTableAdapter1.UpdateQueryPROCESADO(id_contrato, fecha)
                    Me.CONT_CPF_CalendariosRevisionTasaTableAdapter.DeleteQuery(id_contrato)
                    Me.CONT_CPF_CalendariosRevisionTasaTableAdapter.InsertCalendario(id_contrato, fecha, 1, 0, 1, 1, 0)


                End If

            End If

                total_registros = total_registros + 1
        Next

        Me.CONT_CPF_lotesTableAdapter.Updatelote_pagado(LOTE)
        Me.CONT_CPF_Factor_PagosTableAdapter.UpdatePROCESADO(LOTE)
        Me.CONT_CPF_lotesTableAdapter.Fill(Me.FactorajeDS1.CONT_CPF_lotes)
        MessageBox.Show("Se han procesado " & procesado & "registros de " & total_registros, "FACTORAJE CARTERA PASIVA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.Close()

    End Sub

    Private Sub txttotal_TextChanged(sender As Object, e As EventArgs) Handles txttotal.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class