Public Class frm_rpt_estado


    Private Sub frm_rpt_estado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_contratos.vw_GARANTIA' table. You can move, or remove it, as needed.

        Me.CONT_CPF_vencimientosTableAdapter.FillByporcontrato(Me.DS_contratos.CONT_CPF_vencimientos, frm_contratos_alta.id_contrato)
        Me.CONT_CPF_ministracionesTableAdapter.FillByporcontrato(Me.DS_contratos.CONT_CPF_ministraciones, frm_contratos_alta.id_contrato)
        Me.CONT_CPF_contratos_garantiasTableAdapter.Fill(Me.DS_contratos.CONT_CPF_contratos_garantias)
        Me.Vw_TIIEpromedioTableAdapter.Fill(Me.DS_contratos.Vw_TIIEpromedio)
        Me.CONT_CPF_saldos_contingenteTableAdapter.FillByporcontrato(Me.DS_contratos.CONT_CPF_saldos_contingente, frm_contratos_alta.id_contrato)
        '   Me.Vw_descuentosTableAdapter.FillByPorContrato(Me.DS_contratos.vw_descuentos, frm_contratos_alta.id_contrato)
        '  Me.Vw_descuentosTableAdapter.FillByPorContrato(Me.DS_contratos.vw_descuentos, frm_contratos_alta.id_contrato)
        Me.Vw_descuentoSATableAdapter.FillByCONTRATO(Me.DS_contratos.vw_descuentoSA, frm_contratos_alta.id_contrato)
        Me.CONT_CPF_pagosTableAdapter.Fill(Me.DS_contratos.CONT_CPF_pagos, frm_contratos_alta.id_contrato)
        Dim s As Decimal
        s = Me.CONT_CPF_edocuentaTableAdapter.SaldoContrato(frm_contratos_alta.id_contrato)
        Dim esquema As Integer
        esquema = Me.Vw_descuentosTableAdapter.esquema_cobro(frm_contratos_alta.id_contrato)
        If esquema = 21 Then
            Me.CONT_CPF_edocuentaTableAdapter.FillByporcontrato(Me.DS_contratos.CONT_CPF_edocuenta, frm_contratos_alta.id_contrato)
        Else
            Me.CONT_CPF_edocuentaTableAdapter.FillByporcontratoFN(Me.DS_contratos.CONT_CPF_edocuenta, frm_contratos_alta.id_contrato)
        End If
        'Me.CONT_CPF_edocuentaTableAdapter.FillByporcontrato(Me.DS_contratos.CONT_CPF_edocuenta, frm_contratos_alta.id_contrato)
        Dim cg As Integer
        cg = Me.CONT_CPF_contratos_garantiasTableAdapter.max_registro_contrato(frm_contratos_alta.id_contrato)
        'Me.CONT_CPF_contratos_garantiasTableAdapter.FillByultimo_registro(Me.DS_contratos.CONT_CPF_contratos_garantias, cg)
        Me.Vw_GARANTIATableAdapter.FillByID_CONT_GARA(Me.DS_contratos.vw_GARANTIA, cg)
        Me.CONT_CPF_csgTableAdapter.Fill(Me.DS_contratos.CONT_CPF_csg, cg)
        Dim sumafb, sumabp, Tiie, fb, bp, s1, s2, s3, s4, s5 As Decimal
        Dim t1, t2, t3 As Decimal
        Dim fecha As Date
        fecha = Me.Vw_descuentosTableAdapter.fechacorte_contrato(frm_contratos_alta.id_contrato)
        fb = Me.Vw_descuentosTableAdapter.fb(frm_contratos_alta.id_contrato)
        bp = Me.Vw_descuentosTableAdapter.bp(frm_contratos_alta.id_contrato)
        Tiie = Me.Vw_TIIEpromedioTableAdapter.sacatiie28(Me.DS_contratos.Vw_TIIEpromedio, fecha.ToString("yyyyMMdd"))
        sumafb = Tiie + fb
        sumabp = Tiie + bp

        'valores para el reporte
        Dim rpt As New rpt_edocta()
        rpt.SetDataSource(DS_contratos)
        rpt.SetParameterValue("tiiefb", sumafb)
        rpt.SetParameterValue("tiiebp", sumabp)
        rpt.SetParameterValue("intordvig", frm_edo_cuenta.TXT_ORD_VI.Text)
        rpt.SetParameterValue("intfinvig", frm_edo_cuenta.TXT_FIN_VI.Text)
        rpt.SetParameterValue("intmorord", frm_edo_cuenta.TXT_MOR_OR.Text)
        rpt.SetParameterValue("capvigente", frm_edo_cuenta.TXT_CAP_VI.Text)
        rpt.SetParameterValue("CAPINTVIG", frm_edo_cuenta.TXT_CAP_INT_VIG.Text)
        rpt.SetParameterValue("intordvven", frm_edo_cuenta.TXT_ORD_VE1.Text)
        rpt.SetParameterValue("intfinven", frm_edo_cuenta.TXT_FIN_VE.Text)
        rpt.SetParameterValue("intmorpen", frm_edo_cuenta.TXT_MOR_PE.Text)
        rpt.SetParameterValue("capvencido", frm_edo_cuenta.txt_cap_ve.Text)
        rpt.SetParameterValue("CAPINTVen", frm_edo_cuenta.txt_cap_int_ve.Text)
        s1 = CDec(frm_edo_cuenta.TXT_ORD_VE1.Text) + CDec(frm_edo_cuenta.TXT_ORD_VI.Text)
        rpt.SetParameterValue("sum1", s1)
        s2 = CDec(frm_edo_cuenta.TXT_FIN_VE.Text) + CDec(frm_edo_cuenta.TXT_FIN_VI.Text)
        rpt.SetParameterValue("sum2", s2)
        s3 = CDec(frm_edo_cuenta.TXT_MOR_PE.Text) + CDec(frm_edo_cuenta.TXT_MOR_OR.Text)
        rpt.SetParameterValue("sum3", s3)
        s4 = CDec(frm_edo_cuenta.txt_cap_ve.Text) + CDec(frm_edo_cuenta.TXT_CAP_VI.Text)
        rpt.SetParameterValue("sum4", s4)
        s5 = CDec(frm_edo_cuenta.txt_cap_int_ve.Text) + CDec(frm_edo_cuenta.TXT_CAP_INT_VIG.Text)
        rpt.SetParameterValue("sum5", s5)
        t1 = CDec(frm_edo_cuenta.TXT_ORD_VI.Text) + CDec(frm_edo_cuenta.TXT_FIN_VI.Text) + CDec(frm_edo_cuenta.TXT_MOR_OR.Text) + CDec(frm_edo_cuenta.TXT_CAP_VI.Text) + CDec(frm_edo_cuenta.TXT_CAP_INT_VIG.Text)
        rpt.SetParameterValue("total1", t1)
        t2 = CDec(frm_edo_cuenta.TXT_ORD_VE1.Text) + CDec(frm_edo_cuenta.TXT_FIN_VE.Text) + CDec(frm_edo_cuenta.TXT_MOR_PE.Text) + CDec(frm_edo_cuenta.txt_cap_ve.Text) + CDec(frm_edo_cuenta.txt_cap_int_ve.Text)
        rpt.SetParameterValue("total2", t2)
        t3 = s1 + s2 + s3 + s4 + s5
        rpt.SetParameterValue("total3", t3)

        'rpt.SetParameterValue("RECURSO", frm_Solicitud_Transferencia.recursos_fira)
        'rpt.SetParameterValue("fecha", frm_Solicitud_Transferencia.fecha_p)
        crv.ReportSource = rpt

    End Sub

    Private Sub crv_Load(sender As Object, e As EventArgs) Handles crv.Load

    End Sub
End Class