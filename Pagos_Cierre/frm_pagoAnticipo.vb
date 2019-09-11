Public Class frm_pagoAnticipo
    Public Shared id_credito As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        id_credito = txtCredito.Text
        Dim f As New frmPagoManual
        f.Show()
    End Sub
End Class