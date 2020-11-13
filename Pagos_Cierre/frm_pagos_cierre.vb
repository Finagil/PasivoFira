Imports System.IO
Imports System.IO.File
Public Class frm_pagos_cierre
    Public taCorreos As New FactorajeDSTableAdapters.GEN_Correos_SistemaFinagilTableAdapter
    Private Sub frm_pagos_cierre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_cierre_diario' Puede moverla o quitarla según sea necesario.
        'Me.CONT_CPF_cierre_diarioTableAdapter.Fill(Me.DS_contratos.CONT_CPF_cierre_diario)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_cierremes' Puede moverla o quitarla según sea necesario.
        'Me.CONT_CPF_cierremesTableAdapter.Fill(Me.DS_contratos.CONT_CPF_cierremes)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_CierreContable' Puede moverla o quitarla según sea necesario.
        ' Me.CONT_CPF_CierreContableTableAdapter.Fill(Me.DS_contratos.CONT_CPF_CierreContable)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_vencimiento_interes' Puede moverla o quitarla según sea necesario.
        'Me.CONT_CPF_vencimiento_interesTableAdapter.Fill(Me.DS_contratos.CONT_CPF_vencimiento_interes)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_vencimientos' Puede moverla o quitarla según sea necesario.
        ''Me.CONT_CPF_vencimientosTableAdapter.Fill(Me.DS_contratos.CONT_CPF_vencimientos)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_contratos' Puede moverla o quitarla según sea necesario.
        'Me.CONT_CPF_contratosTableAdapter.Fill(Me.DS_contratos.CONT_CPF_contratos)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_contratos_garantias' Puede moverla o quitarla según sea necesario.
        ''Me.CONT_CPF_contratos_garantiasTableAdapter.Fill(Me.DS_contratos.CONT_CPF_contratos_garantias)

    End Sub

    Private Sub bt_aplicar_Click(sender As Object, e As EventArgs) Handles bt_aplicar.Click
        Dim fechat, fech_aux As Date
        Dim cont_obs As Integer
        Dim MENSAJE As String
        Dim estatus As Boolean
        Dim archivo As String
        Dim mensaje1 As String
        Dim contrato As Integer
        'estatus = True

        '  Dim diferencia As Boolean
        'LEER EL ARCHIVO DE SIIOF

        fechat = dt_fecha.Text
        fech_aux = Now
        If ch_diario.Checked = True Then ' SOLO CIERRE DIARIO
            fech_aux = fech_aux.AddDays(-7) 'Resta 2 días
            If fechat < fech_aux Then
                MessageBox.Show("Fecha no disponible ", "PAGOS FIRA CIERRE DIARIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If fechat > Now Then
                MessageBox.Show("Fecha no disponible ", "PAGOS FIRA CIERRE DIARIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            estatus = Me.CONT_CPF_CierreContableTableAdapter.Scalarestatus(fechat.AddDays(-1)) 'QUE EL CIERRE ANTERIOR ESTE EN OK

            If estatus = False Then
                MessageBox.Show("El cierre del día " & fechat.AddDays(-1) & " No se ha cerrado ", "PAGOS FIRA CIERRE DIARIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            estatus = Me.CONT_CPF_CierreContableTableAdapter.Scalarestatus(fechat)

            If estatus = True Then ' SI ESTA EN OK EL CIERRE DE HOY NO SE PUEDE CERRAR NUEVAMENTE
                MessageBox.Show("El cierre del día " & fechat & " Ya se cerró correctamente anteriormente ", "PAGOS FIRA CIERRE DIARIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            archivo = "Detalle de cargos y abonos "
        Else
            archivo = "CIERRE"
            Me.CONT_CPF_cierremesTableAdapter.DeleteQuery(fechat)


        End If

        Dim FECHA1 As String = fechat.ToString("ddMMyyyy")



        'PROCESO PARA CAMBIAR VALORES SEGUN FIRA
        Dim Ruta As String = "\\SERVER-RAID2\Fira\CIERREFIRA\" & archivo & FECHA1 & ".txt"
        'Dim Ruta As String = "\\SERVER-RAID2\Fira\DETALLE DE CARGOS Y ABONOS PASIVA\" & archivo & FECHA1 & ".txt"
        'Path = Ruta



        If File.Exists(Ruta) Then
            Dim Arch As New StreamReader(Ruta)





            'Dim Arch As New StreamReader(Ruta)
            Dim Linea As String = "Primera"
            Dim CAD As String = ""
            Dim cTipop As String = ""
            Dim LineaX As String()
            Dim doc As String
            Dim existe As Boolean
            If Directory.Exists("C:\CierreFira") = False Then ' si no existe la carpeta se crea
                Directory.CreateDirectory("C:\CierreFira")
            End If
            Dim filename As String = "C:\CierreFira\test" & FECHA1 & ".log"
            Dim sw As StreamWriter = AppendText(filename)

            If ch_diario.Checked = True Then
                Me.CONT_CPF_vencimiento_interesTableAdapter.DeleteQuery(fechat)
            End If


            While Not Arch.EndOfStream
                ' diferencia = False

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
                '  If (Trim(LineaX(9))) = 1904665 Then

                'Dim i As Integer = 1

                'End If
                If ch_diario.Checked = True Then 'CIERRE DIARIO

                    contrato = Me.CONT_CPF_contratosTableAdapter.idcontrato(Trim(LineaX(9)))
                    If contrato = 0 Then 'BUSCAR POR ID_SUSTITUCION  SE EJERCIO GARANTÍA
                        contrato = Me.CONT_CPF_contratosTableAdapter.idcontratoBYIDSUSTITUCION(Trim(LineaX(9)))
                    End If
                    If contrato <> 0 Then

                        Dim id_cont_gar As Integer = Me.CONT_CPF_contratos_garantiasTableAdapter.id_contrato_garantia(contrato)
                        Dim csg = Me.CONT_CPF_contratosTableAdapter.cxsg(contrato)

                        Dim tipo As Integer = Trim(LineaX(12))
                        Dim movimiento As String = Trim(LineaX(15))

                        Dim importe As Decimal = CDec(Trim(LineaX(17)))
                        Dim iva As Integer = Trim(LineaX(12))
                        Dim importe_iva = Trim(LineaX(19))
                        Dim monto_iva As Decimal = CDec(Trim(LineaX(20)))

                        If id_cont_gar <> 0 Then
                            If (tipo = 10) And movimiento = "CARGO" Then  ' PAGO DE CAPITAL
                                Dim vencimiento As Integer = Me.CONT_CPF_vencimientosTableAdapter.ScalarQueryvencimientofecha(fechat, contrato)
                                If vencimiento > 0 Then


                                    Dim capital As Decimal = Me.CONT_CPF_vencimientosTableAdapter.CapitalVencimiento(contrato, fechat)

                                    If capital <> importe Then
                                        sw.WriteLine(FECHA1 & " " & "Se cambio el capital de vencimiento del contrato " & contrato & "Importe anterior " & capital & "se cambio por " & importe)
                                        MENSAJE = MENSAJE & "Se cambio el capital de vencimiento del contrato " & contrato & " Importe anterior " & capital & "se cambio por " & importe & "<br>"

                                        Me.CONT_CPF_vencimientosTableAdapter.UpdateCapital(importe, contrato, fechat)

                                    End If
                                Else
                                    Dim CONTARven As Integer = Me.CONT_CPF_vencimientosTableAdapter.ScalarQueryvencimientos_contar(contrato)
                                    If CONTARven = 1 Then
                                        Me.CONT_CPF_vencimientosTableAdapter.Deletevencimiento(contrato)

                                    End If

                                    Me.CONT_CPF_vencimientosTableAdapter.InsertQueryVencimiento(fechat, importe, "05/01/1900", "VIGENTE", 0, contrato)
                                    MENSAJE = MENSAJE & "EL CONTRATO" & contrato & " NO TENIA VENCIMIENTO  AL DIA " & fechat & " SE DIO DE ALTA POR " & importe & "<br>"

                                End If

                            End If

                            If (tipo = 11) And movimiento = "CARGO" Then  ' PAGO DE INTERESES

                                Me.CONT_CPF_vencimiento_interesTableAdapter.InsertVencimientoInteres(fechat, importe, contrato)

                            End If

                            If (tipo = 16) And movimiento = "CARGO" Then 'COBRO POR SERVICIO

                                Dim id_csg As Integer = Me.CONT_CPF_csgTableAdapter.saca_idcsg(id_cont_gar)
                                If id_csg = 0 Then
                                    Dim ii As Integer = 1
                                End If


                                If id_csg <> 0 Then
                                    Dim monto_importe As Decimal = Me.CONT_CPF_csgTableAdapter.ImporteCobro(id_cont_gar)
                                    Dim importeIVA As Decimal = Me.CONT_CPF_csgTableAdapter.ImporteIVA(id_cont_gar)

                                    If monto_importe <> importe Then
                                        'sw.WriteLine(FECHA1 & " " & "Revisar Monto Importe COBRO POR SERVICIO ID_CONT_GAR: " & id_cont_gar & "Importe anterior " & monto_importe & "se cambio por" & importe)
                                        'MENSAJE = MENSAJE & "Revisar Monto Importe COBRO POR SERVICIO ID_CONT_GAR: " & id_cont_gar & "<br>"
                                    End If

                                    If importeIVA <> monto_iva Then
                                        'sw.WriteLine(FECHA1 & " " & "Revisar Monto IVA COBRO POR SERVICIO ID_CONT_GAR: " & id_cont_gar & "Importe anterior " & importeIVA & "se cambio por" & importe_iva)
                                        'MENSAJE = MENSAJE & "Revisar Monto IVA COBRO POR SERVICIO ID_CONT_GAR: " & id_cont_gar & "<br>"
                                    End If

                                    '    Me.CONT_CPF_csgTableAdapter.UpdateQuerymonto(importe, monto_iva, importe + monto_iva, id_cont_gar)
                                    Me.CONT_CPF_csgTableAdapter.DeleteQuery(fechat, importe, id_cont_gar)
                                    Me.CONT_CPF_csgTableAdapter.Insertcsgcierre(fechat, fechat, importe, importeIVA, csg, id_cont_gar)
                                Else

                                    'sw.WriteLine(FECHA1 & " " & "Revisar no hay registros en CONT_CPF_cxsg contrato " & contrato)
                                    'MENSAJE = MENSAJE & "Revisar no hay registros en CONT_CPF_cxsg contrato " & contrato & "<br>"
                                    'cont_obs = cont_obs + 1


                                End If

                            End If
                        Else
                            sw.WriteLine(FECHA1 & " " & "No hay registro de contrato garantia para el contrato " & contrato)
                            cont_obs = cont_obs + 1
                            MENSAJE = MENSAJE & "No hay registro de contrato garantia para el contrato " & contrato & "<br>"

                        End If
                    Else
                        sw.WriteLine(FECHA1 & " " & "No se ha cargado el id_credito" & Trim(LineaX(9)))
                        cont_obs = cont_obs + 1
                        MENSAJE = MENSAJE & "No se ha cargado el id_credito" & Trim(LineaX(9)) & "<br>"
                    End If


                    '    doc = Trim(LineaX(3))

                    ' Trim(LineaX(7))
                    ' CDec(Trim(LineaX(23)))
                Else 'CIERRE MENSUAL

                    If Trim(LineaX(1)) <> "" Then



                        Dim fechacorte As Date = Trim(LineaX(1))
                        Dim divisa As String = Trim(LineaX(4))
                        Dim capital As Decimal = CDec(Trim(LineaX(29)))
                        Dim saldo_financiado As Decimal = CDec(Trim(LineaX(30)))
                        Dim intereses As Decimal = CDec(Trim(LineaX(31)))
                        Dim subsidio As String = Trim(LineaX(89))

                        Dim id_credito As String = Trim(LineaX(99))
                        If id_credito = "" Then
                            id_credito = 0
                        End If
                        contrato = Me.CONT_CPF_contratosTableAdapter.idcontrato(id_credito)


                        If subsidio = "No" Or subsidio = "" Then
                            subsidio = False

                        End If

                        If divisa = "DOLARES" Then
                            divisa = 2
                        Else
                            divisa = 1

                        End If
                        'If id_credito > 0 Then
                        Me.CONT_CPF_cierremesTableAdapter.InsertQuery(fechacorte, capital, saldo_financiado, intereses, subsidio, id_credito, contrato, divisa)
                        'Else
                        ' Dim cadena1 As String = "lineavacia"
                        'End If

                    End If

                End If


            End While


            sw.Close()

            If ch_diario.Checked = True Then





                If cont_obs > 0 Then

                    estatus = False
                    mensaje1 = "No se ha cerrado el día, Revisar Archivo de observaciones en C:\CierreFira" & "\Detalle de cargos y abonos " & FECHA1 & ".txt"
                    MessageBox.Show("No se puede cerrar el día, revisar correo", "CIERRE FIRA PASIVA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


                Else
                    estatus = True
                    mensaje1 = "Se cerro el día contable correctamente"
                    MessageBox.Show("SEl día se cerro correctamente", "CIERRE FIRA PASIVA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


                End If
                Me.CONT_CPF_CierreContableTableAdapter.DeleteQuery(fechat)
                Me.CONT_CPF_CierreContableTableAdapter.InsertQuery(estatus, fechat, mensaje1)
            End If


            '  MessageBox.Show("Se han aplicado los cambios correspondientes", "CIERRE FIRA PASIVA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ' Dim fechacorreo As Date
            'Fecha = FormatDateTime(Now, DateFormat.ShortDate)
            'If MENSAJE.Length >= 2000 Then
            'MENSAJE = "Revisar Archivo de observaciones en C:\CierreFira" & "\Detalle de cargos y abonos " & FECHA1 & ".txt"

            'End If

            taCorreos.Insert("PasivoFira@finagil.com.mx", "denise.gonzalez@finagil.com.mx", "Cierre Fira " & FECHA1, "Se ha efectuado el cierre con las sig. observaciones <br>" & mensaje1, False, Date.Now, "")
            taCorreos.Insert("PasivoFira@finagil.com.mx", "maria.bautista@finagil.com.mx", "Cierre Fira " & FECHA1, "Se ha efectuado el cierre con las sig. observaciones <br>" & mensaje1, False, Date.Now, "")

            cont_obs = 0

        Else
            MessageBox.Show(archivo & FECHA1 & ".txt  Archivo no encontrado", "PAGOS FIRA CIERRE DIARIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If


        '  Me.CONT_CPF_lotesTableAdapter.Insert(ComboBox2.SelectedValue, 0, 0, 1)

    End Sub

    Private Sub ch_mensual_CheckedChanged(sender As Object, e As EventArgs)

    End Sub
    Sub cambiardatos()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim Ruta As String = "\\SERVER-RAID2\Fira\CIERREFIRA\"
        Dim rutamover As String = "\\SERVER-RAID2\Fira\procesadocierrefira\"
        Dim dir As New DirectoryInfo(Ruta)
        Dim estatus_contrato As Boolean
        Dim fechat, fech_aux As Date
        Dim ARCHIVO As String
        Dim MENSAJE As String
        Dim estatus As Boolean
        Dim cont_obs As Integer = 0
        Dim lectura_archivo As Integer = 0
        Dim FECHA1 As String

        For Each file As FileInfo In dir.GetFiles()


            Dim palabracortada As String
            palabracortada = Strings.Right(file.Name, 12)
            Dim fecha_archivo As String = Strings.Left(palabracortada, 8)
            Dim inteh As Integer = 1


            Dim contrato As Integer


            'LEER EL ARCHIVO DE SIIOF

            fechat = dt_fecha.Text
            fech_aux = Now
            cont_obs = 0

            FECHA1 = fechat.ToString("ddMMyyyy")
            If FECHA1 = fecha_archivo Then


                lectura_archivo = lectura_archivo + 1


                Dim Arch As New StreamReader(Ruta & file.Name)

                Dim Linea As String = "Primera"
                Dim CAD As String = ""
                Dim cTipop As String = ""
                Dim LineaX As String()
                Dim doc As String
                Dim existe As Boolean
                If Directory.Exists("C:\logsPASIVO") = False Then ' si no existe la carpeta se crea
                    Directory.CreateDirectory("C:\logsPASIVO")
                End If
                Dim filename As String = "C:\logsPASIVO\cierreDIARIO" & FECHA1 & ".log"
                Dim sw As StreamWriter = AppendText(filename)

                If ch_diario.Checked = True Then
                    Me.CONT_CPF_vencimiento_interesTableAdapter.DeleteQuery(fechat)
                End If

                Dim cuenta As Integer = Me.CONT_CPF_cierre_diarioTableAdapter.ScalarQuery(file.Name) 'NO DUPLICAR ARCHIVO

                If cuenta = 0 Then

                    While Not Arch.EndOfStream
                        ' diferencia = False

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


                        Dim idcredito As Integer
                        If Trim(LineaX(20)) <> "" Then


                            idcredito = Trim(LineaX(20))

                            contrato = Me.CONT_CPF_contratosTableAdapter.idcontrato(idcredito)
                            ' contrato = Me.CONT_CPF_contratosTableAdapter.idcontrato(Trim(LineaX(8)))

                            If contrato = 0 Then 'BUSCAR POR ID_SUSTITUCION  SE EJERCIO GARANTÍA
                                contrato = Me.CONT_CPF_contratosTableAdapter.idcontratoBYIDSUSTITUCION(idcredito)

                                If contrato = 0 Then
                                    estatus_contrato = False
                                Else
                                    estatus_contrato = True
                                End If
                            Else
                                estatus_contrato = True

                            End If

                            Dim divisa As Integer  'F

                            If Trim(LineaX(5)) = "DOLARES" Then
                                divisa = 2
                            Else
                                divisa = 1
                            End If

                            Dim fecha_inicial As String = Trim(LineaX(28)) 'AC
                            Dim fecha_final As String = "01/01/1900" 'AD
                            Dim concepto As Integer
                            If Trim(LineaX(45)) <> "" Then
                                concepto = Trim(LineaX(45)) 'AT
                            Else
                                concepto = 0 'AT
                            End If

                            Dim descripcion As String = Trim(LineaX(46)) 'AU
                            Dim importe_cargo As Decimal
                            Dim importe_abono As Decimal
                            Dim iva_cargo As Decimal
                            Dim iva_abono As Decimal

                            ' Dim concepto = Trim(LineaX(19))
                            If Trim(LineaX(49)) = "" Then
                                importe_cargo = 0
                            Else
                                importe_cargo = CDec(Trim(LineaX(49)))
                            End If
                            If Trim(LineaX(50)) = "" Then
                                importe_abono = 0
                            Else
                                importe_abono = CDec(Trim(LineaX(50)))
                            End If
                            If Trim(LineaX(51)) = "" Then
                                iva_cargo = 0
                            Else
                                iva_cargo = CDec(Trim(LineaX(51)))
                            End If
                            If Trim(LineaX(52)) = "" Then
                                iva_abono = 0
                            Else
                                iva_abono = CDec(Trim(LineaX(52)))
                            End If




                            Me.CONT_CPF_cierre_diarioTableAdapter.InsertQuery(idcredito, divisa, fechat, fecha_inicial, fecha_final, concepto, descripcion, importe_cargo, importe_abono, iva_cargo, iva_abono, file.Name, contrato, estatus_contrato)

                            'CAMBIAR CXS Y VENCIMIENTOS DE CAPITAL E INTERESES

                            If contrato <> 0 Then

                                Dim id_cont_gar As Integer = Me.CONT_CPF_contratos_garantiasTableAdapter.id_contrato_garantia(contrato)
                                Dim csg = Me.CONT_CPF_contratosTableAdapter.cxsg(contrato)

                                If id_cont_gar <> 0 Then


                                    ''''

                                    If (concepto = 16) And importe_cargo > 0 Then 'COBRO POR SERVICIO

                                        Dim id_csg As Integer = Me.CONT_CPF_csgTableAdapter.saca_idcsg(id_cont_gar)
                                        If id_csg = 0 Then
                                            Dim ii As Integer = 1
                                        End If


                                        If id_csg <> 0 Then

                                            Me.CONT_CPF_csgTableAdapter.DeleteQuery(fechat, importe_cargo, id_cont_gar)
                                            Me.CONT_CPF_csgTableAdapter.Insertcsgcierre(fechat, fechat, importe_cargo, iva_cargo, csg, id_cont_gar)

                                        End If
                                    End If


                                Else
                                    'mandar aviso que den de alta contrato garantia

                                End If

                                'DAR DE ALTA VENCIMIENTOS DE INTERES



                                If (concepto = 10) And importe_cargo > 0 Then  ' PAGO DE CAPITAL
                                    Dim vencimiento As Integer = Me.CONT_CPF_vencimientosTableAdapter.ScalarQueryvencimientofecha(fechat, contrato)
                                    If vencimiento > 0 Then


                                        Dim capital As Decimal = Me.CONT_CPF_vencimientosTableAdapter.CapitalVencimiento(contrato, fechat)

                                        If capital <> importe_cargo Then

                                            Me.CONT_CPF_vencimientosTableAdapter.UpdateCapital(importe_cargo, contrato, fechat)

                                        End If
                                    Else
                                        Dim CONTARven As Integer = Me.CONT_CPF_vencimientosTableAdapter.ScalarQueryvencimientos_contar(contrato)
                                        If CONTARven = 1 Then
                                            Me.CONT_CPF_vencimientosTableAdapter.Deletevencimiento(contrato)

                                        End If

                                        Me.CONT_CPF_vencimientosTableAdapter.InsertQueryVencimiento(fechat, importe_cargo, "05/01/1900", "VIGENTE", 0, contrato)
                                        'MENSAJE = MENSAJE & "EL CONTRATO" & contrato & " NO TENIA VENCIMIENTO  AL DIA " & fechat & " SE DIO DE ALTA POR " & importe & "<br>"

                                    End If

                                End If

                                If (concepto = 11) And importe_cargo > 0 Then  ' PAGO DE INTERESES AUTOMATICOS

                                    Me.CONT_CPF_vencimiento_interesTableAdapter.InsertVencimientoInteres(fechat, importe_cargo, contrato)

                                End If

                                If (concepto = 501) And importe_cargo > 0 Then  ' PAGO DE INTERESES POR REFINANCIAMIENTO

                                    Me.CONT_CPF_vencimiento_interesTableAdapter.InsertVencimientoInteres(fechat, importe_cargo, contrato)

                                End If




                            Else
                                'mandar aviso que no se ha dado de alta

                                sw.WriteLine(FECHA1 & " " & "No se ha cargado el id_credito " & idcredito)
                                cont_obs = cont_obs + 1

                            End If



                        End If


                    End While



                Else 'CUANDO YA ESTA leido el archivo Y EL DIA ESTA PENDIENTE POR CERRAR

                    estatus = Me.CONT_CPF_CierreContableTableAdapter.Scalarestatus(fechat)

                    If estatus = True Then ' SI ESTA EN OK EL CIERRE DE HOY NO SE PUEDE CERRAR NUEVAMENTE
                        MessageBox.Show("El cierre del día " & fechat & " Ya se cerró correctamente anteriormente ", "PAGOS FIRA CIERRE DIARIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub

                    Else 'VOY A LEER TODO LO DEL CIERRE QUE NO SE HA CARGADO


                        For Each row As DataRow In CONT_CPF_cierre_diarioTableAdapter.GetDataBy2(fechat) 'TRAER TODOS LOS CONTRATOS QUE NO SE HAN CARGADO

                            contrato = Me.CONT_CPF_contratosTableAdapter.idcontrato(row("id_credito"))


                            If contrato <> 0 Then

                                estatus_contrato = True
                                Me.CONT_CPF_cierre_diarioTableAdapter.UpdateQContrato(estatus_contrato, contrato, row("id_credito"))

                                Dim id_cont_gar As Integer = Me.CONT_CPF_contratos_garantiasTableAdapter.id_contrato_garantia(contrato)
                                Dim csg = Me.CONT_CPF_contratosTableAdapter.cxsg(contrato)

                                If id_cont_gar <> 0 Then


                                    ''''

                                    If (row("concepto") = 16) And row("importe_cargo") > 0 Then 'COBRO POR SERVICIO

                                        Dim id_csg As Integer = Me.CONT_CPF_csgTableAdapter.saca_idcsg(id_cont_gar)
                                        If id_csg = 0 Then
                                            Dim ii As Integer = 1
                                        End If


                                        If id_csg <> 0 Then

                                            Me.CONT_CPF_csgTableAdapter.DeleteQuery(fechat, row("importe_cargo"), id_cont_gar)
                                            Me.CONT_CPF_csgTableAdapter.Insertcsgcierre(fechat, fechat, row("importe_cargo"), row("iva_cargo"), csg, id_cont_gar)

                                        End If
                                    End If


                                Else
                                    'mandar aviso que den de alta contrato garantia

                                End If

                                'DAR DE ALTA VENCIMIENTOS DE INTERES



                                If (row("concepto") = 10) And row("importe_cargo") > 0 Then  ' PAGO DE CAPITAL
                                    Dim vencimiento As Integer = Me.CONT_CPF_vencimientosTableAdapter.ScalarQueryvencimientofecha(fechat, contrato)
                                    If vencimiento > 0 Then


                                        Dim capital As Decimal = Me.CONT_CPF_vencimientosTableAdapter.CapitalVencimiento(contrato, fechat)

                                        If capital <> row("importe_cargo") Then

                                            Me.CONT_CPF_vencimientosTableAdapter.UpdateCapital(row("importe_cargo"), contrato, fechat)

                                        End If
                                    Else
                                        Dim CONTARven As Integer = Me.CONT_CPF_vencimientosTableAdapter.ScalarQueryvencimientos_contar(contrato)
                                        If CONTARven = 1 Then
                                            Me.CONT_CPF_vencimientosTableAdapter.Deletevencimiento(contrato)

                                        End If

                                        Me.CONT_CPF_vencimientosTableAdapter.InsertQueryVencimiento(fechat, row("importe_cargo"), "05/01/1900", "VIGENTE", 0, contrato)
                                        'MENSAJE = MENSAJE & "EL CONTRATO" & contrato & " NO TENIA VENCIMIENTO  AL DIA " & fechat & " SE DIO DE ALTA POR " & importe & "<br>"

                                    End If

                                End If

                                If row("concepto") = 11 And row("importe_cargo") > 0 Then  ' PAGO DE INTERESES

                                    Me.CONT_CPF_vencimiento_interesTableAdapter.InsertVencimientoInteres(fechat, row("importe_cargo"), contrato)

                                End If
                                If row("concepto") = 501 And row("importe_cargo") > 0 Then  ' PAGO DE INTERESES

                                    Me.CONT_CPF_vencimiento_interesTableAdapter.InsertVencimientoInteres(fechat, row("importe_cargo"), contrato)

                                End If
                            Else

                                sw.WriteLine(FECHA1 & " " & "No se ha cargado el id_credito " & row("id_credito"))
                                cont_obs = cont_obs + 1




                            End If



                        Next



                    End If




                End If



                sw.Close()







            End If


        Next



        If lectura_archivo > 0 Then


            If cont_obs > 0 Then
                estatus = False 'el dia aun no se ha cerrado

            End If
            Dim mensaje1 As String

                If estatus = True Then
                    mensaje1 = "El día  se cerro correctamente"
                    MessageBox.Show("El día  se cerro correctamente", "CIERRE FIRA PASIVA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    mensaje1 = "No se cerro el día contable correctamente"
                    MessageBox.Show("No se cerro el día", "CIERRE FIRA PASIVA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

                Me.CONT_CPF_CierreContableTableAdapter.DeleteQuery(fechat)
                Me.CONT_CPF_CierreContableTableAdapter.InsertQuery(estatus, fechat, mensaje1)


                taCorreos.Insert("PasivoFira@finagil.com.mx", "denise.gonzalez@finagil.com.mx", "Cierre Fira " & FECHA1, "Se ha efectuado el cierre con las sig. observaciones <br>" & mensaje1, False, Date.Now, "")
                taCorreos.Insert("PasivoFira@finagil.com.mx", "maria.bautista@finagil.com.mx", "Cierre Fira " & FECHA1, "Se ha efectuado el cierre con las sig. observaciones <br>" & mensaje1, False, Date.Now, "")


            Else

                MessageBox.Show("No hay archivo para el día seleccionado", "CIERRE FIRA PASIVA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


        cont_obs = 0



    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fechat, fech_aux As Date
        Dim cont_obs As Integer
        Dim MENSAJE As String
        Dim estatus As Boolean
        Dim archivo As String
        Dim mensaje1 As String
        Dim contrato As Integer


        'LEER EL ARCHIVO DE SIIOF

        fechat = dt_fecha.Text
        fech_aux = Now
        archivo = "CIERRE"
        Me.CONT_CPF_cierremesTableAdapter.DeleteQuery(fechat)

        Dim FECHA1 As String = fechat.ToString("ddMMyyyy")


        'PROCESO PARA CAMBIAR VALORES SEGUN FIRA
        Dim Ruta As String = "\\SERVER-RAID2\Fira\CIERREFIRA\" & archivo & FECHA1 & ".txt"

        If File.Exists(Ruta) Then
            Dim Arch As New StreamReader(Ruta)

            'Dim Arch As New StreamReader(Ruta)
            Dim Linea As String = "Primera"
            Dim CAD As String = ""
            Dim cTipop As String = ""
            Dim LineaX As String()
            Dim doc As String
            Dim existe As Boolean
            If Directory.Exists("C:\logsPASIVO") = False Then ' si no existe la carpeta se crea
                Directory.CreateDirectory("C:\logsPASIVO")
            End If
            Dim filename As String = "C:\logsPASIVO\cierreMES" & FECHA1 & ".log"
            Dim sw As StreamWriter = AppendText(filename)




            While Not Arch.EndOfStream
                ' diferencia = False

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
                If Trim(LineaX(1)) <> "" Then



                    Dim fechacorte As Date = Trim(LineaX(1))
                    Dim divisa As String = Trim(LineaX(4))
                    Dim capital As Decimal = CDec(Trim(LineaX(29)))
                    Dim saldo_financiado As Decimal = CDec(Trim(LineaX(30)))
                    Dim intereses As Decimal = CDec(Trim(LineaX(31)))
                    Dim subsidio As String = Trim(LineaX(89))

                    Dim id_credito As String = Trim(LineaX(99))
                    If id_credito = "" Then
                        id_credito = 0
                    End If
                    contrato = Me.CONT_CPF_contratosTableAdapter.idcontrato(id_credito)


                    If subsidio = "No" Or subsidio = "" Then
                        subsidio = False

                    End If

                    If divisa = "DOLARES" Then
                        divisa = 2
                    Else
                        divisa = 1

                    End If
                    'If id_credito > 0 Then
                    Me.CONT_CPF_cierremesTableAdapter.InsertQuery(fechacorte, capital, saldo_financiado, intereses, subsidio, id_credito, contrato, divisa)
                    'Else
                    ' Dim cadena1 As String = "lineavacia"
                    'End If

                End If




            End While


            sw.Close()

            mensaje1 = "EL ARCHIVO CIERRE MES SE HA LEIDO CORRECTAMENTE"

            MessageBox.Show(mensaje1, "PAGOS FIRA CIERRE DIARIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


            taCorreos.Insert("PasivoFira@finagil.com.mx", "denise.gonzalez@finagil.com.mx", "Cierre Fira " & FECHA1, "Se ha efectuado el cierre con las sig. observaciones <br>" & mensaje1, False, Date.Now, "")
            taCorreos.Insert("PasivoFira@finagil.com.mx", "maria.bautista@finagil.com.mx", "Cierre Fira " & FECHA1, "Se ha efectuado el cierre con las sig. observaciones <br>" & mensaje1, False, Date.Now, "")


        Else
            MessageBox.Show(archivo & FECHA1 & ".txt  Archivo no encontrado", "PAGOS FIRA CIERRE DIARIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If





    End Sub
End Class