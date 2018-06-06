Module ModuleGlobal

    Public P1000, P1001, PR, PCXSG_FEGA, PCXSG_FONAGA, GLP, GLM, PGLP, PGLM As Decimal
    Public TasaIVA As Decimal = 0.16
    Public TIIE28 As Decimal = 0
    Public TIIE91 As Decimal = 0
    Public TIIE182 As Decimal = 0
    Public TIIE365 As Decimal = 0
    Public TIIE_Aplica As Decimal = 0
    Public TIIE_Promedio As Decimal = 0
    Public DIAS_ENTRE_VENC As Decimal = 0
    Public flagmin As Boolean

    Public Enum EsquemaCobro As Integer
        SIMFA = 20
        SIMPLE = 71
        SIMPLE_FIN = 21
    End Enum

    Public Enum CONFIG
        FN = 1 'ID DE LA TABLA DE CONFIGURACION
        FB = 2
        AVIO = 3
        REFAC = 4
        CC = 5
        MIL = 6
        MIL1 = 7
        CXSG_FEGA = 8
        secuencial_banco = 9
        CXSG_FONAGA = 11
    End Enum

    Public Function CTOD(ByVal cFecha As String) As Date
        Dim nDia, nMes, nYear As Integer
        nDia = Val(Right(cFecha, 2))
        nMes = Val(Mid(cFecha, 5, 2))
        nYear = Val(Left(cFecha, 4))
        CTOD = DateSerial(nYear, nMes, nDia)
    End Function

    Public Function CargaTIIE(ByVal Fecha As Date, ByVal Tipta As String, ByVal claveCobro As String) As Boolean
        CargaTIIE = True
        Dim ta As New DescuentosDSTableAdapters.TIIETableAdapter
        ta.Connection.ConnectionString = "Provider=SQLOLEDB;Data Source=server-raid;Persist Security Info=True;Password=User_PRO2015;User ID=User_PRO;Initial Catalog=Production"
        TIIE28 = ta.SacaTIIE28(Fecha.ToString("yyyyMMdd"))
        TIIE91 = ta.SacaTIIE91(Fecha.ToString("yyyyMMdd"))
        TIIE182 = ta.SacaTIIE182(Fecha.ToString("yyyyMMdd"))
        TIIE365 = ta.SacaTIIE365(Fecha.ToString("yyyyMMdd"))
        TIIE_Promedio = ta.SacaTIIEpromedio(Fecha.AddMonths(-1).ToString("yyyyMMdd"))
        ' TIIE28 = 1
        ' TIIE91 = 1
        ' TIIE182 = 1
        ' TIIE365 = 1
        'If TIIE28 = 0 Or TIIE91 = 0 Or TIIE182 = 0 Or TIIE365 = 0 Then
        If TIIE28 = 0 Or TIIE91 = 0 Then
            'MessageBox.Show("No hay TIIE Capturada para la Fecha " & Fecha.ToShortDateString, "Error TIIE", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'CargaTIIE = False
        End If
        If claveCobro = "" Then
            claveCobro = 0

        End If
        If CInt(claveCobro.Trim) = EsquemaCobro.SIMPLE_FIN And Tipta.Trim <> "7" Then
            TIIE_Aplica = TIIE28
        End If

        If CInt(claveCobro.Trim) = EsquemaCobro.SIMPLE And Tipta.Trim = "7" Then 'SIMPLE Y FIJA TRAER LA TIIE28 DAGL
            TIIE_Aplica = TIIE28
        End If
        ta.Dispose()
    End Function

    Sub InsertaLineaCalendario(ByRef id_Contrato As Integer, ByVal FechaIni As Date, ByVal Fecha As Date, ByVal Periodo As String,
    ByVal Capital As Boolean, EsFinMesX As Boolean)
        Dim Factor As Integer = -1
        Dim taCalendar As New DescuentosDSTableAdapters.CONT_CPF_CalendariosRevisionTasaTableAdapter
        Dim FinMES1 As Date = Fecha.AddDays(Fecha.Day * -1)
        Dim FinMES2 As Date = Fecha.AddMonths(1).AddDays(Fecha.Day * -1)
        taCalendar.Insert(id_Contrato, Fecha, Capital, False, True, True, False)
        Select Case Periodo.ToUpper
            Case "MENSUAL"
                If EsFinMesX = True Then
                    Fecha = FinMES1
                Else
                    Fecha = Fecha.AddMonths(1 * Factor)
                End If
            Case "BIMESTRAL"
                Fecha = Fecha.AddMonths(2 * Factor)
            Case "TRIMESTRAL"
                Fecha = Fecha.AddMonths(3 * Factor)
            Case "SEMESTRAL"
                Fecha = Fecha.AddMonths(6 * Factor)
            Case "ANUAL"
                Fecha = Fecha.AddMonths(12 * Factor)
            Case "AL VENCIMIENTO"
                Fecha = Fecha.AddYears(12 * Factor)
        End Select

        If FechaIni < Fecha Then
            InsertaLineaCalendario(id_Contrato, FechaIni, Fecha, Periodo, False, EsFinMesX)
        End If
        If EsFinMesX = False And FechaIni < FinMES1 Then ' corte de fin de mes
            taCalendar.Insert(id_Contrato, FinMES1, False, False, False, False, False)
        End If

    End Sub

    Public Sub NumerosyDecimal(ByVal CajaTexto As Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not CajaTexto.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub CreaCalendarioRevisoinTasa(ByVal Id_Contrato As Integer, TipoTasa As String)
        Dim taCalendarios As New DescuentosDSTableAdapters.CONT_CPF_CalendariosRevisionTasaTableAdapter
        Dim tCalendarios As New DescuentosDS.CONT_CPF_CalendariosRevisionTasaDataTable
        Dim Rcont As DescuentosDS.ContratoDatosRow
        Dim DS1 As New DS_contratos
        Dim DS2 As New DescuentosDS
        Dim taVecn As New DS_contratosTableAdapters.CONT_CPF_vencimientosTableAdapter
        Dim taCont As New DescuentosDSTableAdapters.ContratoDatosTableAdapter
        Dim taCalendar As New DescuentosDSTableAdapters.CONT_CPF_CalendariosRevisionTasaTableAdapter
        Dim DiaMax, DiaAux As Integer
        Dim taMinis As New DS_contratosTableAdapters.CONT_CPF_ministracionesTableAdapter
        Dim taMinis1 As New DS_contratosTableAdapters.mFIRATableAdapter
        Dim FechaMinistracion1, FechaAnt As Date
        Dim AcumINTE As Boolean
        Dim EsFinMES As Boolean = False
        Dim fec1 As String

        If flagmin = False Then
            FechaMinistracion1 = taMinis.PrimeraMinistracion(Id_Contrato)
        Else
            fec1 = taMinis1.PRIMERMINISTRACION(Id_Contrato)
            FechaMinistracion1 = fec1.Substring(6, 2) + "/" + fec1.Substring(4, 2) + "/" + fec1.Substring(0, 4)
        End If


        FechaAnt = FechaMinistracion1
        taVecn.FillBycontrato(DS1.CONT_CPF_vencimientos, Id_Contrato)
        taCont.Fill(DS2.ContratoDatos, Id_Contrato)
        Rcont = DS2.ContratoDatos.Rows(0)
        For Each r As DS_contratos.CONT_CPF_vencimientosRow In DS1.CONT_CPF_vencimientos.Rows
            DiaAux = DateDiff(DateInterval.Day, FechaAnt, r.fecha)
            If DiaAux > DiaMax Then DiaMax = DiaAux
            FechaAnt = r.fecha
        Next

        Select Case Rcont.clave.Trim
            Case EsquemaCobro.SIMPLE
            Case EsquemaCobro.SIMPLE_FIN
                taCont.CambiaPeriodoSimpleConFina(1, 1, Id_Contrato)
                taCont.Fill(DS2.ContratoDatos, Id_Contrato)
                Rcont = DS2.ContratoDatos.Rows(0)
                AcumINTE = False
            Case EsquemaCobro.SIMFA
        End Select
        FechaAnt = FechaMinistracion1

        'genera calendario de revicion de tasas
        'Dim FFF As Date = CDate("20/07/2017")
        For Each r As DS_contratos.CONT_CPF_vencimientosRow In DS1.CONT_CPF_vencimientos.Rows
            'r.fecha = FFF
            If r.fecha.AddDays(1).Day = 1 Then
                EsFinMES = True
            End If
            InsertaLineaCalendario(Id_Contrato, FechaAnt, r.fecha, Rcont.PeriodoTASA, True, EsFinMES)
            FechaAnt = r.fecha
            taCalendarios.Fill(tCalendarios, Id_Contrato)
            'FFF = FFF.AddYears(1)
        Next
        'For Each rr As DescuentosDS.CONT_CPF_CalendariosRevisionTasaRow In tCalendarios.Rows
        '    If TipoTasa <> "7" Then ' diferente de tasa Fija
        '        'EsSabDomFestivo(rr)
        '    End If
        'Next
        tCalendarios.GetChanges()
        taCalendarios.Update(tCalendarios)
    End Sub

    Sub EsSabDomFestivo(ByRef rr As DescuentosDS.CONT_CPF_CalendariosRevisionTasaRow)
        Dim Revisar As Boolean = False
        Dim ta As New DescuentosDSTableAdapters.DiasFestivosTableAdapter
        If ta.EsFestivo(rr.Fecha, "MXN") > 0 Then
            rr.Fecha = rr.Fecha.AddDays(1)
            Revisar = True
        End If
        If rr.Fecha.DayOfWeek = DayOfWeek.Saturday Then
            rr.Fecha = rr.Fecha.AddDays(2)
            Revisar = True
        End If
        If rr.Fecha.DayOfWeek = DayOfWeek.Sunday Then
            rr.Fecha = rr.Fecha.AddDays(1)
            Revisar = True
        End If
        If Revisar = True Then
            EsSabDomFestivo(rr)
        End If
        ta.Dispose()

    End Sub

End Module
