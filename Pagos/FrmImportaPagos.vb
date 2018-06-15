﻿Public Class FrmImportaPagos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cursor.Current = Cursors.WaitCursor
        Dim p As New Process
        p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        p.StartInfo.FileName = "F:\Executables\MOD_PasivoFiraCalculos.exe"
        p.StartInfo.Arguments = "PAGOS"
        p.Start()
        p.WaitForExit()
        Cursor.Current = Cursors.Default
        MessageBox.Show("Pagos Importados.", "Importación de pagos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.PagosFiraTableAdapter.Fill(PagosDS.PagosFira, False)
        Boton()
    End Sub

    Private Sub FrmImportaPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PagosFiraTableAdapter.Fill(PagosDS.PagosFira, False)
        Boton()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Cursor.Current = Cursors.WaitCursor
        For Each r As PagosDS.PagosFiraRow In PagosDS.PagosFira.Rows
            Me.PagosFiraTableAdapter.UpdatePagos(DTP_FechaFira.Value, r.id_contrato, r.FechaAplicacion.ToString("yyyyMMdd"))
        Next
        Shell("F:\Executables\PsExec.exe \\server-raid -u Agil\edgar-caceres -p c4c3r1t0s1 D:\Contratos$\Executables\MOD_PasivoFiraCalculos.exe PROCESA_PAGOS", AppWinStyle.Hide, False)
        Me.PagosFiraTableAdapter.Fill(PagosDS.PagosFira, False)
        Boton()
        Cursor.Current = Cursors.Default
        MessageBox.Show("En breve recibirás un correo de confirmación de terminación de proceso..", "Aplicación de pagos", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Sub Boton()
        If PagosDS.PagosFira.Rows.Count <= 0 Then
            Button2.Enabled = False
        Else
            Button2.Enabled = True
        End If
    End Sub
End Class