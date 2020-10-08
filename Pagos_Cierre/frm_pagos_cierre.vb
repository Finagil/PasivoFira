Imports System.IO
Imports System.IO.File
Public Class frm_pagos_cierre
    Public taCorreos As New FactorajeDSTableAdapters.GEN_Correos_SistemaFinagilTableAdapter
    Private Sub frm_pagos_cierre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_contratos' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_contratosTableAdapter.Fill(Me.DS_contratos.CONT_CPF_contratos)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_contratos_garantias' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_contratos_garantiasTableAdapter.Fill(Me.DS_contratos.CONT_CPF_contratos_garantias)

    End Sub

    Private Sub bt_aplicar_Click(sender As Object, e As EventArgs) Handles bt_aplicar.Click
        Dim fechat, fech_aux As Date
        Dim cont_obs As Integer
        Dim MENSAJE As String
        Dim estatus As String

        '  Dim diferencia As Boolean
        'LEER EL ARCHIVO DE SIIOF

        fechat = dt_fecha.Text
        fech_aux = Now
        fech_aux = fech_aux.AddDays(-9) 'Resta 2 días
        If fechat < fech_aux Then
            MessageBox.Show("Fecha no disponible ", "PAGOS FIRA CIERRE DIARIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim FECHA1 As String = fechat.ToString("ddMMyyyy")



        'PROCESO PARA CAMBIAR VALORES SEGUN FIRA
        Dim Ruta As String = "\\SERVER-RAID2\Fira\DETALLE DE CARGOS Y ABONOS PASIVA\Detalle de cargos y abonos " & FECHA1 & ".txt"
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
                Dim contrato As Integer = Me.CONT_CPF_contratosTableAdapter.idcontrato(Trim(LineaX(9)))

                If contrato <> 0 Then

                    Dim id_cont_gar As Integer = Me.CONT_CPF_contratos_garantiasTableAdapter.id_contrato_garantia(contrato)


                    Dim tipo As Integer = Trim(LineaX(12))
                    Dim movimiento As String = Trim(LineaX(15))

                    Dim importe As Decimal = CDec(Trim(LineaX(17)))
                    Dim iva As Integer = Trim(LineaX(12))
                    Dim importe_iva = Trim(LineaX(19))
                    Dim monto_iva As Decimal = CDec(Trim(LineaX(20)))

                    If id_cont_gar <> 0 Then

                        If (tipo = 16) And movimiento = "CARGO" Then 'COBRO POR SERVICIO

                            Dim id_csg As Integer = Me.CONT_CPF_csgTableAdapter.saca_idcsg(id_cont_gar)
                            If id_csg = 0 Then
                                Dim ii As Integer = 1
                            End If


                            If id_csg <> 0 Then
                                Dim monto_importe As Decimal = Me.CONT_CPF_csgTableAdapter.ImporteCobro(id_cont_gar)
                                Dim importeIVA As Decimal = Me.CONT_CPF_csgTableAdapter.ImporteIVA(id_cont_gar)

                                If monto_importe <> importe Then
                                    sw.WriteLine(FECHA1 & " " & "Revisar Monto Importe COBRO POR SERVICIO ID_CONT_GAR: " & id_cont_gar & "Importe anterior " & monto_importe & "se cambio por" & importe)
                                    MENSAJE = MENSAJE & "Revisar Monto Importe COBRO POR SERVICIO ID_CONT_GAR: " & id_cont_gar & "<br>"
                                End If

                                If importeIVA <> monto_iva Then
                                    sw.WriteLine(FECHA1 & " " & "Revisar Monto IVA COBRO POR SERVICIO ID_CONT_GAR: " & id_cont_gar & "Importe anterior " & importeIVA & "se cambio por" & importe_iva)
                                    MENSAJE = MENSAJE & "Revisar Monto IVA COBRO POR SERVICIO ID_CONT_GAR: " & id_cont_gar & "<br>"
                                End If

                                Me.CONT_CPF_csgTableAdapter.UpdateQuerymonto(importe, monto_iva, importe + monto_iva, id_cont_gar)
                            Else

                                sw.WriteLine(FECHA1 & " " & "Revisar no hay registros en CONT_CPF_cxsg contrato " & contrato)
                                MENSAJE = MENSAJE & "Revisar no hay registros en CONT_CPF_cxsg contrato " & contrato & "<br>"
                                cont_obs = cont_obs + 1

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


            End While


            sw.Close()

            If cont_obs > 0 Then

            End If
            MessageBox.Show("Se han aplicado los cambios correspondientes", "CIERRE FIRA PASIVA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ' Dim fechacorreo As Date
            'Fecha = FormatDateTime(Now, DateFormat.ShortDate)
            If MENSAJE.Length >= 2000 Then
                MENSAJE = "Revisar Archivo de observaciones en C:\CierreFira" & "\Detalle de cargos y abonos " & FECHA1 & ".txt"

            End If
            taCorreos.Insert("PasivoFira@finagil.com.mx", "denise.gonzalez@finagil.com.mx", "Cierre Fira " & FECHA1, "Se ha efectuado el cierre con las sig. observaciones <br>" & MENSAJE, False, Date.Now, "")
                taCorreos.Insert("PasivoFira@finagil.com.mx", "maria.bautista@finagil.com.mx", "Cierre Fira " & FECHA1, "Se ha efectuado el cierre con las sig. observaciones <br>" & MENSAJE, False, Date.Now, "")

                cont_obs = 0

            Else
                MessageBox.Show("Detalle de cargos y abonos " & FECHA1 & ".txt  Archivo no encontrado", "PAGOS FIRA CIERRE DIARIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If


        '  Me.CONT_CPF_lotesTableAdapter.Insert(ComboBox2.SelectedValue, 0, 0, 1)

    End Sub
End Class