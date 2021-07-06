Public Class FrmImportaPagos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Cursor.Current = Cursors.WaitCursor
            Dim p As New Process
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            p.StartInfo.FileName = My.Settings.RutaSRV & "Executables\MOD_PasivoFiraCalculos.exe"
            p.StartInfo.Arguments = "PAGOS"
            p.Start()
            p.WaitForExit()


            Cursor.Current = Cursors.Default
            MessageBox.Show("Pagos Importados.", "Importación de pagos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.PagosFiraTableAdapter.Fill(PagosDS.PagosFira, False)
            Boton()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Pasivo Fira", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FrmImportaPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PagosDS.GEN_ComandosCMD' Puede moverla o quitarla según sea necesario.
        Me.GEN_ComandosCMDTableAdapter.Fill(Me.PagosDS.GEN_ComandosCMD)
        Me.PagosFiraTableAdapter.Fill(PagosDS.PagosFira, False)
        Boton()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Cursor.Current = Cursors.WaitCursor
            For Each r As PagosDS.PagosFiraRow In PagosDS.PagosFira.Rows
                Me.PagosFiraTableAdapter.UpdatePagos(DTP_FechaFira.Value.Date, r.id_contrato, r.FechaAplicacion.ToString("yyyyMMdd"))
            Next
            usuariogl()

            Me.GEN_ComandosCMDTableAdapter.InsertQuery("E:\Dropbox (Finagil)\Contratos$\Executables\", "MOD_PasivoFiraCalculos.exe", " PROCESA_PAGOS", usuarioglobal)
            'Shell("\\SERVER-RAID2\Contratos$\Executables\PsExec.exe \\192.168.10.232 -u AGIL\edgar-caceres -p c4c3r1t0s1 E:\Contratos$\Executables\MOD_PasivoFiraCalculos.exe PROCESA_PAGOS", AppWinStyle.Hide, False)
            'mandacorrefas
            Me.PagosFiraTableAdapter.Fill(PagosDS.PagosFira, False)
            Boton()
            Cursor.Current = Cursors.Default
            MessageBox.Show("En breve recibirás un correo de confirmación de terminación de proceso..", "Aplicación de pagos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Pasivo Fira", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub Boton()
        If PagosDS.PagosFira.Rows.Count <= 0 Then
            Button2.Enabled = False
        Else
            Button2.Enabled = True
        End If
    End Sub
End Class