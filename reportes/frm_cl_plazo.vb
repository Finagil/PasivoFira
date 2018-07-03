Public Class frm_cl_plazo
    Private Sub frm_cl_plazo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpCLPlazo.MinDate = New Date(Date.Now.Year, Date.Now.Month - 1, System.DateTime.DaysInMonth(Date.Now.Year, Date.Now.Month - 1))
        dtpCLPlazo.MaxDate = New Date(Date.Now.Year, Date.Now.Month - 1, System.DateTime.DaysInMonth(Date.Now.Year, Date.Now.Month - 1))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Try

            Me.CL_Plazo_03TableAdapter.Global_Fill(Me.DS_reportes.CL_Plazo_03, New System.Nullable(Of Date)(CType(dtpCLPlazo.Value.ToString("yyyy-MM-dd"), Date)))



            Dim dtarreglo As New DataTable("reporte")
            dtarreglo.Columns.Add("Mes")
            For col As Integer = 0 To 10
                dtarreglo.Columns.Add((dtpCLPlazo.Value.Year + col).ToString, Type.GetType("System.Decimal"))
            Next

            Dim arreglo(12, 11) As String

            For fila_new As Integer = 0 To 11
                arreglo(0, fila_new) = StrConv(MonthName(fila_new + 1).ToString, VbStrConv.ProperCase)
            Next

            Dim contados As Integer = 0
            Dim CP As Double = 0
            Dim CP2 As Double = 0
            Dim total As Double = 0
            For Each fila As DataRow In DS_reportes.CL_Plazo_03.Rows
                If fila.Item(0) = dtpCLPlazo.Value.Year Then
                    If fila.Item(1) < dtpCLPlazo.Value.Month Then
                        arreglo(1, contados) = "0"
                    Else
                        arreglo(1, contados + dtpCLPlazo.Value.Month) = fila.Item(2)
                        CP += fila.Item(2)
                    End If
                ElseIf fila.Item(0) = dtpCLPlazo.Value.Year + 1 Then
                    arreglo(2, contados) = fila.Item(2)
                    If fila.Item(1) <= dtpCLPlazo.Value.Month Then
                        CP2 += fila.Item(2)
                    End If
                ElseIf fila.Item(0) = dtpCLPlazo.Value.Year + 2 Then
                    arreglo(3, contados) = fila.Item(2)
                ElseIf fila.Item(0) = dtpCLPlazo.Value.Year + 3 Then
                    arreglo(4, contados) = fila.Item(2)
                ElseIf fila.Item(0) = dtpCLPlazo.Value.Year + 4 Then
                    arreglo(5, contados) = fila.Item(2)
                ElseIf fila.Item(0) = dtpCLPlazo.Value.Year + 5 Then
                    arreglo(6, contados) = fila.Item(2)
                ElseIf fila.Item(0) = dtpCLPlazo.Value.Year + 6 Then
                    arreglo(7, contados) = fila.Item(2)
                ElseIf fila.Item(0) = dtpCLPlazo.Value.Year + 7 Then
                    arreglo(8, contados) = fila.Item(2)
                ElseIf fila.Item(0) = dtpCLPlazo.Value.Year + 8 Then
                    arreglo(9, contados) = fila.Item(2)
                ElseIf fila.Item(0) = dtpCLPlazo.Value.Year + 9 Then
                    arreglo(10, contados) = fila.Item(2)
                ElseIf fila.Item(0) = dtpCLPlazo.Value.Year + 10 Then
                    arreglo(11, contados) = fila.Item(2)
                End If

                contados += 1
                If fila.Item(1) = 12 Then
                    contados = 0
                End If
                total += fila.Item(2)
            Next

            Dim row As DataRow
            For fila As Integer = 0 To 11
                row = dtarreglo.NewRow()
                row("Mes") = arreglo(0, fila)
                For columna As Integer = 0 To 10
                    row((dtpCLPlazo.Value.Year + columna).ToString) = Val(arreglo(columna + 1, fila))
                Next
                dtarreglo.Rows.Add(row)
            Next
            'Corto Plazo Producto
            Me.CL_Plazo_03TableAdapter.CP_Total_FillBy(Me.DS_reportes.CL_Plazo_03, New System.Nullable(Of Date)(CType(dtpCLPlazo.Value.ToString("yyyy-MM-dd"), Date)), New System.Nullable(Of Date)(CType(dtpCLPlazo.Value.ToString("yyyy-MM-dd"), Date)), New System.Nullable(Of Date)(CType(dtpCLPlazo.Value.ToString("yyyy-MM-dd"), Date)), New System.Nullable(Of Date)(CType(dtpCLPlazo.Value.ToString("yyyy-MM-dd"), Date)))

            Dim dtarregloCP As New DataTable("reporteCP")
            dtarregloCP.Columns.Add("PRODUCTO")
            dtarregloCP.Columns.Add("TOTAL", Type.GetType("System.Decimal"))
            dtarregloCP.Columns.Add("NOCREDITOS", Type.GetType("System.Decimal"))

            Dim rowCP As DataRow
            For Each fila As DataRow In DS_reportes.CL_Plazo_03.Rows
                rowCP = dtarregloCP.NewRow()
                rowCP("TOTAL") = fila.Item(2)
                rowCP("PRODUCTO") = fila.Item(3)
                rowCP("NOCREDITOS") = fila.Item(4)
                dtarregloCP.Rows.Add(rowCP)
            Next
            'Largo Plazo Producto
            Me.CL_Plazo_03TableAdapter.LP_Total_FillBy(Me.DS_reportes.CL_Plazo_03, New System.Nullable(Of Date)(CType(dtpCLPlazo.Value.ToString("yyyy-MM-dd"), Date)), New System.Nullable(Of Date)(CType(dtpCLPlazo.Value.ToString("yyyy-MM-dd"), Date)), New System.Nullable(Of Date)(CType(dtpCLPlazo.Value.ToString("yyyy-MM-dd"), Date)))

            Dim dtarregloLP As New DataTable("reporteLP")
            dtarregloLP.Columns.Add("PRODUCTO")
            dtarregloLP.Columns.Add("TOTAL", Type.GetType("System.Decimal"))
            dtarregloLP.Columns.Add("NOCREDITOS", Type.GetType("System.Decimal"))

            Dim rowLP As DataRow
            For Each fila As DataRow In DS_reportes.CL_Plazo_03.Rows
                rowLP = dtarregloLP.NewRow()
                rowLP("TOTAL") = fila.Item(2)
                rowLP("PRODUCTO") = fila.Item(3)
                rowLP("NOCREDITOS") = fila.Item(4)
                dtarregloLP.Rows.Add(rowLP)
            Next

            'Corto Plazo Sucursal
            Me.CL_Plazo_03TableAdapter.CP_Suc_Total_FillBy(Me.DS_reportes.CL_Plazo_03, New System.Nullable(Of Date)(CType(dtpCLPlazo.Value.ToString("yyyy-MM-dd"), Date)), New System.Nullable(Of Date)(CType(dtpCLPlazo.Value.ToString("yyyy-MM-dd"), Date)), New System.Nullable(Of Date)(CType(dtpCLPlazo.Value.ToString("yyyy-MM-dd"), Date)), New System.Nullable(Of Date)(CType(dtpCLPlazo.Value.ToString("yyyy-MM-dd"), Date)))

            Dim dtarregloCPS As New DataTable("reporteCPS")
            dtarregloCPS.Columns.Add("SUCURSAL")
            dtarregloCPS.Columns.Add("TOTAL", Type.GetType("System.Decimal"))
            dtarregloCPS.Columns.Add("NOCREDITOS", Type.GetType("System.Decimal"))

            Dim rowCPS As DataRow
            'For Each fila As DataRow In DS_reportes.CL_Plazo_03.Rows
            For Each fila As DataRow In DS_reportes.CL_Plazo_03.Rows
                rowCPS = dtarregloCPS.NewRow()
                rowCPS("TOTAL") = fila.Item(2)
                rowCPS("SUCURSAL") = fila.Item(5)
                rowCPS("NOCREDITOS") = fila.Item(4)
                dtarregloCPS.Rows.Add(rowCPS)
            Next

            'Largo Plazo Sucursal
            Me.CL_Plazo_03TableAdapter.LP_Suc_Total_FillBy(Me.DS_reportes.CL_Plazo_03, New System.Nullable(Of Date)(CType(dtpCLPlazo.Value.ToString("yyyy-MM-dd"), Date)), New System.Nullable(Of Date)(CType(dtpCLPlazo.Value.ToString("yyyy-MM-dd"), Date)), New System.Nullable(Of Date)(CType(dtpCLPlazo.Value.ToString("yyyy-MM-dd"), Date)))

            Dim dtarregloLPS As New DataTable("reporteLPS")
            dtarregloLPS.Columns.Add("SUCURSAL")
            dtarregloLPS.Columns.Add("TOTAL", Type.GetType("System.Decimal"))
            dtarregloLPS.Columns.Add("NOCREDITOS", Type.GetType("System.Decimal"))

            Dim rowLPS As DataRow
            For Each fila As DataRow In DS_reportes.CL_Plazo_03.Rows
                rowLPS = dtarregloLPS.NewRow()
                rowLPS("TOTAL") = fila.Item(2)
                rowLPS("SUCURSAL") = fila.Item(5)
                rowLPS("NOCREDITOS") = fila.Item(4)
                dtarregloLPS.Rows.Add(rowLPS)
            Next

            'Reporte
            Dim rpt As New rpt_cl_plazo02
            rpt.SetDataSource(dtarreglo)
            rpt.Subreports.Item("rpt_CP").SetDataSource(dtarregloCP)
            rpt.Subreports.Item("rpt_LP").SetDataSource(dtarregloLP)
            rpt.Subreports.Item("rpt_CPS").SetDataSource(dtarregloCPS)
            rpt.Subreports.Item("rpt_LPS").SetDataSource(dtarregloLPS)

            rpt.SetParameterValue("var_cp", CP + CP2)
            rpt.SetParameterValue("var_lp", total - (CP + CP2))
            rpt.SetParameterValue("var_mes", MonthName(dtpCLPlazo.Value.Month).ToUpper)
            rpt.SetParameterValue("var_anio", dtpCLPlazo.Value.Year)
            rpt.SetParameterValue("var_fecha_dtp", dtpCLPlazo.Value.ToShortDateString)
            CrystalReportViewer1.ReportSource = rpt
            dtarreglo.Clear()
            dtarregloCP.Clear()

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function validaNull(valor As String)
        If valor = "" Then
            Return ""
            Exit Function
        Else
            Return valor
            Exit Function
        End If
    End Function
End Class