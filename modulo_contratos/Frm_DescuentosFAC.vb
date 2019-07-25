Imports System.IO
Public Class Frm_DescuentosFAC
    Private Sub Frm_DescuentosFAC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FactorajeDS.CONT_CPF_saldos_contingente' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_saldos_contingenteTableAdapter.Fill(Me.FactorajeDS.CONT_CPF_saldos_contingente)
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
        cb_producto.SelectedValue = 2
        cb_esquema.SelectedValue = 2
        cb_divisa.SelectedValue = 1
        cb_prestamo.SelectedValue = 5
        cb_periodo_revision.SelectedValue = 6
        cb_periodo_capital.SelectedValue = 6
        cb_periodo_int.SelectedValue = 6
    End Sub


    Private Sub TXT_EFEC_TextChanged(sender As Object, e As EventArgs)

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

    Private Sub CLIENTETXT_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ch_subsidio_CheckedChanged(sender As Object, e As EventArgs) Handles ch_subsidio.CheckedChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub TXT_IVA_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub cb_divisa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_divisa.SelectedIndexChanged

    End Sub

    Private Sub cb_gl_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CK_FONAGA_CheckedChanged(sender As Object, e As EventArgs) Handles CK_FONAGA.CheckedChanged

    End Sub

    Private Sub Label69_Click(sender As Object, e As EventArgs) Handles Label69.Click

    End Sub

    Private Sub Label68_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label67_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label66_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TXT_NOM_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PCXSG_TXT_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TXT_FN_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TXT_FB_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txt_BP_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label55_Click(sender As Object, e As EventArgs)

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

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
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
        Dim contador As Integer = 1
        Dim contador_archivo As Integer
        Dim sRenglon As String = Nothing
        Dim strStreamW As Stream = Nothing
        Dim strStreamWriter As StreamWriter = Nothing
        Dim ContenidoArchivo As String = Nothing
        ' Donde guardamos los paths de los archivos que vamos a estar utilizando ..
        Dim PathArchivo As String

        Dim i As Integer
        '  BP = Me.Vw_AnexosTableAdapter.SacaTasaTRA(Me.Vw_AnexosBindingSource.Current("Anexo"))
        If Directory.Exists("C:\Capeta") = False Then ' si no existe la carpeta se crea
            Directory.CreateDirectory("C:\carpeta")
        End If
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
            clientetxt.Text = Me.ClientesTableAdapter.clientexrfc(Me.DGFACT.Item(2, Renglones).Value)
            monto = Me.DGFACT.Item(3, Renglones).Value

            Dim DOC As String = Me.DGFACT.Item(0, Renglones).Value
            Dim TASA As Decimal = Me.DGFACT.Item(4, Renglones).Value
            '   Dim pcsx = CDec(Val(PCXSG_TXT.Text))
            '  FB = CDec(Val(TXT_FB.Text))
            Dim fecha As Date = Me.DGFACT.Item(5, Renglones).Value
            Dim producto, operacion, prestamo, divisa, intermediario, esquema, tipotasa As Integer
            producto = cb_producto.SelectedValue
            operacion = cb_operacion.SelectedValue
            prestamo = cb_prestamo.SelectedValue
            divisa = cb_divisa.SelectedValue
            intermediario = cb_intermediario.SelectedValue
            esquema = cb_esquema.SelectedValue
            tipotasa = cb_tasa.SelectedValue
            ' Dim ta As New DescuentosDSTableAdapters.TIIETableAdapter
            'ta.Connection.ConnectionString = "Provider=SQLOLEDB;Data Source=server-raid;Persist Security Info=True;Password=User_PRO2015;User ID=User_PRO;Initial Catalog=Production"
            'tiieactiva = ta.SacaTIIE28(fecha.ToString("yyyyMMdd"))
            'tiieactiva = 1
            'Dim tipotasatiie As String = "TIIE28"
            Dim tasafijafira As Decimal
            tasafijafira = Me.DGFACT.Item(4, Renglones).Value

            If producto = 1 Then
                TXT_NOM.Text = ""
            End If

            'Me.CONT_CPF_contratosTableAdapter.InsertQueryFactoraje(cb_producto.SelectedValue, num_control, cb_operacion.SelectedValue,
            'cb_prestamo.SelectedValue, cb_divisa.SelectedValue, monto, 0, idcreditofact, 1,
            'cb_esquema.SelectedValue, cb_tasa.SelectedValue, BP, FN, FB, 0, 0,
            '0, 1, secuencial_banco, 1, 1, 0,
            '0, 0, 1, 0, 0, 0, 0,
            '0, 0, 0, monto, 0, 0, BP,
            '0, 0, 0, 0, 0, fecha, 0, 0,
            '0, 0, 0, 0, 0, 0, 0,
            'pcsx, 0, 0, 0, "01/01/1900", ch_subsidio.Checked, cb_periodo_capital.SelectedValue, cb_periodo_int.SelectedValue,
            ' cb_periodo_revision.SelectedValue, clientetxt.Text, DOC, tiieactiva, tipotasatiie, ch_subsidio.Checked, tasafijafira)




            Inserto = True
            ' Me.CONT_CPF_configuracionTableAdapter.consumeidcreditofact() 'consume el creditofact
            'GENERAR ARCHIVO
            If Inserto = True Then
                'creamos archivo 
                If contador = 1 Then

                    sRenglon = Nothing
                    strStreamW = Nothing
                    strStreamWriter = Nothing
                    ContenidoArchivo = Nothing
                    contador_archivo = Me.CONT_CPF_configuracionTableAdapter.ScalarQueryconfiguracion(CONFIG.ARCHIVOfac)
                    Windows.Forms.Cursor.Current = Cursors.WaitCursor
                    PathArchivo = "C:\carpeta\FACTORAJE" & Format(Today.Date, "ddMMyyyy") & "LOTE " & ComboBox2.SelectedValue & "_" & contador_archivo & ".csv" ' Se determina el nombre del archivo con la fecha actual

                    'verificamos si existe el archivo

                    If File.Exists(PathArchivo) Then
                        strStreamW = File.Open(PathArchivo, FileMode.Open) 'Abrimos el archivo
                    Else
                        strStreamW = File.Create(PathArchivo) ' lo creamos
                    End If


                    strStreamWriter = New StreamWriter(strStreamW, System.Text.Encoding.Default) ' tipo de codificacion para escritura
                End If


                If contador <= 100 Then
                    strStreamWriter.WriteLine(producto & "," & divisa & "," & TXT_NOM.Text & "," & "" & "," & "" & "," & "1" & "," &
                                              DOC & "," & Me.DGFACT.Item(1, Renglones).Value & "," & "" & "," &
                                              Me.DGFACT.Item(2, Renglones).Value & "," & monto & "," &
                                              TASA & "," & Me.DGFACT.Item(5, Renglones).Value & "," & Me.DGFACT.Item(6, Renglones).Value)
                End If


                If contador = 100 Then
                    strStreamWriter.Close() ' cerramos
                    contador = 0
                    Me.CONT_CPF_configuracionTableAdapter.CONSUMEARCHIVOFACT()

                    sRenglon = Nothing
                    strStreamW = Nothing
                    strStreamWriter = Nothing
                    ContenidoArchivo = Nothing
                    ' Donde guardamos los paths de los archivos que vamos a estar utilizando ..
                    ' PathArchivo As String
                End If

                If RENG = DGFACT.RowCount - 1 Then
                    strStreamWriter.Close() ' cerramos
                End If

                ' Catch ex As Exception
                'MsgBox("Error al Guardar la ingormacion en el archivo. " & ex.ToString, MsgBoxStyle.Critical, Application.ProductName)
                ' strStreamWriter.Close() ' cerramos
                'End Try

            End If




            contador = contador + 1
        Next
        Me.CONT_CPF_Factor_FacturasTableAdapter.Fill(Me.FactorajeDS1.CONT_CPF_Factor_Facturas, ComboBox2.SelectedValue)
        'Me.WEB_LotesTableAdapter.Updateestatus(ComboBox2.SelectedValue)
        'PROCECE MENOS DE 100 REGISTROS CERRAR EL ARCHIVO Y CONSUMIR NUMERO DE ARCHIVO
        strStreamWriter.Close() ' cerramos
        Me.CONT_CPF_configuracionTableAdapter.CONSUMEARCHIVOFACT()

        ' MessageBox.Show("Reestructura Registrada", "CONTRATOS CARTERA PASIVA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        MessageBox.Show("Factoraje Registrada", "CONTRATOS CARTERA PASIVA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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
        Dim coberturanominal As Decimal
        Dim monto As Decimal
        Dim cliente As String
        Dim tiieactiva As Decimal
        Dim tasatiie, id_contrato As Integer
        Dim num_control As String
        Dim nominal As Decimal
        Dim efectiva As Decimal
        Dim id_garantia As Integer
        Dim procesado As Integer = 0
        Dim cont As Integer
        Dim logs() As String
        Dim CONFACT As Integer


        Dim sRenglon As String = Nothing
        Dim strStreamW As Stream = Nothing
        Dim strStreamWriter As StreamWriter = Nothing
        Dim ContenidoArchivo As String = Nothing
        ' Donde guardamos los paths de los archivos que vamos a estar utilizando ..
        Dim PathArchivo As String
        Dim i As Integer
        '  BP = Me.Vw_AnexosTableAdapter.SacaTasaTRA(Me.Vw_AnexosBindingSource.Current("Anexo"))
        If Directory.Exists("C:\Factor") = False Then ' si no existe la carpeta se crea
            Directory.CreateDirectory("C:\Factor")
        End If
        'LEER EL ARCHIVO DE SIIOF

        'PROCESO PARA DESCONTAR FACTORAJE
        Dim Ruta As String = "C:\Files\FACTORAJE.TXT"
        'If File.Exists(Ruta) = True Then
        If MessageBox.Show("Desea descontar Factoraje", "Factojare", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim Arch As New StreamReader(Ruta)
            Dim Linea As String = "Primera"
            Dim CAD As String = ""
            Dim cTipop As String = ""
            Dim LineaX As String()
            Dim doc As String
            Dim existe As Boolean
            Dim lote As Integer
            While Not Arch.EndOfStream
                CAD = ""
                If Linea = "Primera" Then
                    Linea = Arch.ReadLine
                End If
                Linea = Arch.ReadLine
                For X As Integer = 1 To Linea.Length
                    If Mid(Linea, X, 1) <> """" Then
                        CAD = CAD & Mid(Linea, X, 1)
                    End If
                Next
                Linea = CAD
                LineaX = Linea.Split(vbTab)



                doc = Trim(LineaX(3))

                If Trim(LineaX(3)) = "ETP380888" Then
                    Dim s As String = "checar"
                End If
                lote = frmLayoutFact.lote

                Dim documento = Me.CONT_CPF_Factor_FacturasTableAdapter.factura(doc, lote)

                Dim contrato As Integer

                contrato = Me.CONT_CPF_contratosTableAdapter.idcontrato(Trim(LineaX(15)))




                'consultar que documento exista
                If (documento IsNot Nothing) And contrato = 0 Then

                    'si existe guardar datos en pasivo fira


                    secuencial_banco = Me.CONT_CPF_configuracionTableAdapter.ScalarQueryconfiguracion(CONFIG.secuencial_banco)
                    año = año.ToString().Substring(año.Length - 3, 3)
                    sucursal = 1
                    num_control = cb_prestamo.SelectedValue & "/" & TxtIntermediario.Text & "/" & sucursal & "/" & secuencial_banco & "/" & año

                    If Trim(LineaX(7)) = "TCH850701RM1" Then
                        Dim s As String = "checar"
                    End If
                    Dim rfc As String = Trim(LineaX(7))
                    clientetxt.Text = Me.ClientesTableAdapter.clientexrfc(rfc)
                    monto = Trim(LineaX(25))

                    'doc = documento
                    Dim TASA As Decimal = Trim(LineaX(24))
                    Dim pcsx = CDec(Trim(LineaX(30)))
                    BP = CDec(Trim(LineaX(23)))
                    FB = 0.1
                    FN = 0  ' cuando es tasa fija 
                    Dim fecha As Date = Trim(LineaX(33))
                    Dim fechaVen As Date = Trim(LineaX(34))
                    Dim producto, operacion, prestamo, divisa, intermediario, esquema, tipotasa As Integer
                    producto = cb_producto.SelectedValue
                    operacion = cb_operacion.SelectedValue
                    prestamo = cb_prestamo.SelectedValue
                    divisa = cb_divisa.SelectedValue
                    intermediario = cb_intermediario.SelectedValue
                    esquema = cb_esquema.SelectedValue
                    tipotasa = cb_tasa.SelectedValue
                    Dim totaldias As Integer
                    totaldias = DateDiff(DateInterval.Day, fecha, fechaVen)
                    Dim ta As New DescuentosDSTableAdapters.TIIETableAdapter
                    ta.Connection.ConnectionString = "Provider=SQLOLEDB;Data Source=server-raid2;Persist Security Info=True;Password=User_PRO2015;User ID=User_PRO;Initial Catalog=Production"
                    Dim tipotasatiie As String
                    If totaldias < 32 Then
                        TIIE28 = ta.SacaTIIE28(fecha.ToString("yyyyMMdd"))
                        tipotasatiie = "TIIE28"
                        TIIE_Aplica = TIIE182
                    End If
                    If totaldias > 31 And totaldias < 92 Then
                        TIIE91 = ta.SacaTIIE91(fecha.ToString("yyyyMMdd"))
                        tipotasatiie = "TIIE91"
                        TIIE_Aplica = TIIE91
                    End If
                    If totaldias > 91 And totaldias < 182 Then
                        TIIE182 = ta.SacaTIIE182(fecha.ToString("yyyyMMdd"))
                        tipotasatiie = "TIIE182"
                        TIIE_Aplica = TIIE182
                    End If

                    If totaldias > 182 And totaldias < 366 Then
                        TIIE365 = ta.SacaTIIE365(fecha.ToString("yyyyMMdd"))
                        tipotasatiie = "TIIE365"
                        TIIE_Aplica = TIIE365
                    End If


                    idcreditofact = Trim(LineaX(15))

                    Me.CONT_CPF_contratosTableAdapter.InsertQueryFactoraje(cb_producto.SelectedValue, num_control, cb_operacion.SelectedValue,
                            cb_prestamo.SelectedValue, cb_divisa.SelectedValue, monto, 0, idcreditofact, 1,
                            cb_esquema.SelectedValue, cb_tasa.SelectedValue, BP, FN, FB, 0, 0,
                            0, 1, secuencial_banco, 1, 1, 0,
                            0, 0, 1, 0, 0, 0, 0,
                            0, 0, 0, monto, 0, 0, 0,
                            0, 0, 0, 0, 0, fecha, 0, 0,
                            0, 0, 0, 0, 0, 0, 0,
                            pcsx, 0, 0, 0, fecha, ch_subsidio.Checked, cb_periodo_capital.SelectedValue, cb_periodo_int.SelectedValue,
                             cb_periodo_revision.SelectedValue, clientetxt.Text, TIIE182, tipotasatiie, ch_subsidio.Checked, TASA, doc)
                    Inserto = True



                    If Inserto = True Then  'GENERAMOS CALCULO Y EDITAMOS PROCESADO

                        Me.CONT_CPF_Factor_FacturasTableAdapter.UpdateQuery(lote, doc)

                        CONFACT = CONFACT + 1
                        'Me.CONT_CPF_Factor_FacturasTableAdapter.Fill(Me.FactorajeDS1.CONT_CPF_Factor_Facturas, ComboBox2.SelectedValue)
                        id_contrato = Me.CONT_CPF_contratosTableAdapter.IDCONTRATOXDOC(clientetxt.Text, doc)

                        Pcxsg = CDec(Trim(LineaX(30)))
                        nominal = Trim(LineaX(28))
                        efectiva = Trim(LineaX(29))

                        If CK_FONAGA.Checked = True Then
                            id_garantia = 2

                        Else 'FEGA
                            id_garantia = 1

                        End If

                        If LineaX(27) = "" Then
                            LineaX(27) = "0"

                        End If
                        Dim GL As Integer = Trim(LineaX(27))

                        ' cobro por servicios

                        Dim Subsidio As Decimal
                        Dim subsidiox As Boolean
                        Dim FECHAPAGO, fechafinal As Date
                        Dim dias As Integer

                        FECHAPAGO = fecha
                        ' If MinistracionesBindingSource.Current("Tipar") = "H" Or MinistracionesBindingSource.Current("Tipar") = "C" Or MinistracionesBindingSource.Current("Tipar") = "A" Then
                        fechafinal = fechaVen
                        monto = monto
                        dias = DateDiff(DateInterval.Day, FECHAPAGO, fechafinal)

                        'dias = DateDiff(DateInterval.Day, dt_descuento.Value.Date, fechafinal)
                        subsidiox = ch_subsidio.Checked
                        If subsidiox = True Then
                            Subsidio = 2
                        Else
                            Subsidio = 1
                        End If

                        Dim Cobro As Decimal = ((((monto / Subsidio) * (Pcxsg / 100)) / 360)) * (dias)
                        Dim PCXSG_Aux As Decimal = Pcxsg / Subsidio

                        'nominal = TXT_NOM.Text
                        Dim vgl As Integer

                        vgl = GL




                        ' efectiva = TXT_EFEC.Text
                        Me.CONT_CPF_contratosTableAdapter.UpdateCXSG(Pcxsg, vgl, id_contrato) 'dagl 26/06/2018 guardar PCXG Y GL

                        Dim montobase As Decimal = monto

                        Dim taGarantias As New DS_contratosTableAdapters.CONT_CPF_contratos_garantiasTableAdapter

                        Dim NoGarantias As Integer = taGarantias.ExistenGarantias(id_contrato)
                        If NoGarantias = 0 Then
                            taGarantias.Insert(id_contrato, id_garantia, nominal, montobase * (nominal / 100), efectiva, True)
                        End If

                        Dim id_cg As Integer
                        id_cg = Me.CONT_CPF_contratos_garantiasTableAdapter.sacaidcontratogarantia(id_contrato, id_garantia)

                        'AGREGANDO MINISTRACIONES


                        Dim taEdoCta As New DS_contratosTableAdapters.CONT_CPF_edocuentaTableAdapter
                        Dim taCargosXservico As New DS_contratosTableAdapters.CONT_CPF_csgTableAdapter
                        Dim SaldoCont As New DS_contratosTableAdapters.CONT_CPF_saldos_contingenteTableAdapter
                        Dim SaldoINI, SaldoFIN, InteORD, InteORDFN, InteORDFB As Decimal
                        Dim FechaUltimoMov As Date

                        SaldoINI = taEdoCta.SaldoContrato(id_contrato)
                        SaldoFIN = SaldoINI + monto
                        FechaUltimoMov = fecha

                        Dim porcentaje As Decimal = Pcxsg
                        Dim importe As Decimal = Cobro
                        Dim estatus As String = "OTORGADO"
                        Dim descuento As Date = FECHAPAGO
                        Dim iva As Decimal = Cobro + (16 / 100)


                        InteORD = SaldoINI * ((BP + TIIE_Aplica) / 100 / 360) * dias
                        InteORDFB = SaldoINI * ((FB + TIIE_Aplica) / 100 / 360) * dias

                        Me.MinistracionesTableAdapter.InsertQuery(monto, FECHAPAGO, 1, porcentaje, iva, importe, id_contrato, estatus, descuento)

                        'AGREGAR VENCIMIENTO
                        Me.CONT_CPF_vencimientosTableAdapter.InsertQuerymanual(fechaVen, monto, "VIGENTE", 0, id_contrato)

                        ' Me.CONT_CPF_csgTableAdapter.InsertQueryCSG(fecha, fechaVen, dias, fecha, monto, importe, iva, importe + iva, Pcxsg, id_cg, ch_subsidio.Checked)
                        taCargosXservico.Insert(fecha, fechafinal, dias, Date.Now, montobase, Cobro, Cobro * TasaIVA, Cobro * (1 + TasaIVA), porcentaje, id_cg, subsidiox)
                        SaldoCont.Insert(fecha, Nothing, Nothing, Nothing, Nothing, montobase, SaldoFIN, nominal, efectiva, SaldoFIN * (nominal / 100), SaldoFIN * (efectiva / 100), id_cg)

                        taEdoCta.Insert("BP", fecha, fecha, SaldoINI, SaldoFIN, 0, Nothing, 0, 0, 0, 0, 0, 0, montobase, id_contrato, BP + TIIE_Aplica, 0, InteORD, 0)
                        taEdoCta.Insert("FB", fecha, fecha, SaldoINI, SaldoFIN, 0, Nothing, 0, 0, 0, 0, 0, 0, montobase, id_contrato, FB + TIIE_Aplica, 0, InteORDFB, 0)


                        ' Me.CONT_CPF_saldos_contingenteTableAdapter.InsertQuery(fecha, fecha, monto,)
                        ' Me.CONT_CPF_configuracionTableAdapter.ConsumeSecuencial() 'consume el secuencial banco


                        'CREAR CALENDARIO


                        CreaCalendarioRevisoinTasa(id_contrato, "")
                        ' Me.CONT_CPF_Factor_FacturasTableAdapter.UpdateQuery(doc, lote)
                        'procesado = procesado + 1

                        Me.CONT_CPF_configuracionTableAdapter.ConsumeSecuencial() 'consume el secuencial banco

                    End If


                Else

                End If

                'CREAR LOGS DE DOCUMENTOS NO ENCONTRADOS 

            End While
            MessageBox.Show(CONFACT & "Documentos Registrados ", "FACTORAJE CARTERA PASIVA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'CAMBIO ESTATUS LOTE A PROCESADO
            Me.WEB_LotesTableAdapter.Updateestatus(ComboBox2.SelectedValue)


            ' End If
        End If
    End Sub
End Class