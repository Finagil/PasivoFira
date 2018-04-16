Public Class Frm_descuentos_porfecha

    Private Sub Frm_descuentos_porfecha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_reportes.vw_ministraciones_contratos' table. You can move, or remove it, as needed.
        ' Me.Vw_ministraciones_contratosTableAdapter.Fill(Me.DS_reportes.vw_ministraciones_contratos)
        'TODO: This line of code loads data into the 'DescuentosDS.Ministraciones' table. You can move, or remove it, as needed.
        ' Me.MinistracionesTableAdapter.Fill(Me.DescuentosDS.Ministraciones)

    End Sub

    Private Sub bt_procesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_procesar.Click
        Me.Vw_ministraciones_contratosTableAdapter.FillByministraciones_fecha(Me.DS_reportes.vw_ministraciones_contratos, dt_fecha.Text)
        Dim rpt As New rpt_descuentos_porfecha()
        rpt.SetDataSource(DS_reportes)
        crv_descuentos.ReportSource = rpt
    End Sub
End Class