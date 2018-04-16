Public Class frm_datos_contrato

    Private Sub bt_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Salir.Click
        Me.Close()
    End Sub

    Private Sub bt_procesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_procesar.Click
        ' Dim fecha As Date
        ' Dim fechacon As String
        ' fecha = dt_fecha.Text
        ' fechacon = Format(fecha, "yyyMMdd")

        ' fecha = fecha.("yyyMMdd")
        'Me.Vw_descuentosTableAdapter.FillBy_descuentofecha(Me.DS_reportes.vw_descuentos, fechacon)
        'Me.Vw_descuentosTableAdapter.Fill(Me.DS_reportes.vw_descuentos)

        'Dim rpt As New rpt_datos_contrato()
        'rpt.SetDataSource(DS_reportes)

        'rpt.SetParameterValue("IMPORTE", frm_Solicitud_Transferencia.IMPORTE_T)
        'rpt.SetParameterValue("RECURSO", frm_Solicitud_Transferencia.recursos_fira)
        'rpt.SetParameterValue("fecha", frm_Solicitud_Transferencia.fecha_p)
        'crv.ReportSource = rpt
    End Sub

    Private Sub frm_descuentosfecha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_reportes.vw_descuentos' table. You can move, or remove it, as needed.
        'Me.Vw_descuentosTableAdapter.Fill(Me.DS_reportes.vw_descuentos)
        Me.Vw_descuentosTableAdapter.FillByporcontrato(Me.DS_reportes.vw_descuentos, frm_contratos_alta.id_contrato)
        'Me.Vw_descuentosTableAdapter.Fill(Me.DS_reportes.vw_descuentos)

        Dim rpt As New rpt_datos_contrato()
        rpt.SetDataSource(DS_reportes)

        'rpt.SetParameterValue("IMPORTE", frm_Solicitud_Transferencia.IMPORTE_T)
        'rpt.SetParameterValue("RECURSO", frm_Solicitud_Transferencia.recursos_fira)
        'rpt.SetParameterValue("fecha", frm_Solicitud_Transferencia.fecha_p)
        crv.ReportSource = rpt
    End Sub

    Private Sub dt_fecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dt_fecha.ValueChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class