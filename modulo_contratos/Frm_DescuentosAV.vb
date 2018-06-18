Public Class Frm_DescuentosAV

    Private Sub Frm_Descuentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cad As String = Date.Now.AddMonths(-12).ToString("yyyyMMdd")
        Me.DescuentosTableAdapter.Fill(Me.DescuentosDS.Descuentos, cad)
        DescuentosBindingSource.Filter = " Fondeotit = 'Fira'"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        sinanexo = False
        If TxtAnexo.Text.Trim = "" Then
            MessageBox.Show("No hay contrato Selecionado", "Descuentos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim F As New frm_contratos_alta
        F.Text = "Alta de contrato: " & DescuentosBindingSource.Current("descr")
        F.GroupBox1.Enabled = False
        F.Ministracion1 = True
        F.Anexo = TxtAnexo.Text
        F.Ciclo = TxtCiclo.Text
        If F.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.DescuentosTableAdapter.Fill(Me.DescuentosDS.Descuentos, Date.Now.AddMonths(-12).ToString("yyyyMMdd"))
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            DescuentosBindingSource.Filter = " Fondeotit = 'Fira'"
        Else
            DescuentosBindingSource.Filter = ""
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class