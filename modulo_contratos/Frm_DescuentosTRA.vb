Public Class Frm_DescuentosTRA

    Private Sub Frm_Descuentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DescuentosTRATableAdapter.Fill(Me.DescuentosDS.DescuentosTRA)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TxtAnexo.Text.Trim = "" Then
            MessageBox.Show("No hay contrato Selecionado", "Descuentos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim F As New frm_contratos_alta
        F.Text = "Alta de contrato: " & DescuentosTRABindingSource.Current("descr")
        F.GroupBox1.Enabled = False
        F.Ministracion1 = True
        F.Anexo = TxtAnexo.Text
        If F.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.DescuentosTRATableAdapter.Fill(Me.DescuentosDS.DescuentosTRA)
        End If
    End Sub
End Class