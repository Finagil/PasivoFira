Public Class frmconsulta
    Public Anexo As String
    Public Ciclo As String

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim ccliente As String

        If Not ComboBox1.SelectedValue Is Nothing Then
            ccliente = ComboBox1.SelectedValue.ToString()
            lblAnexos.Visible = True
            ListBox1.Visible = True
            'ListBox1.Items.Clear()
            'Vw_Anexos1BindingSource_CurrentChanged(Nothing, Nothing)

            Me.Vw_descuentoSATableAdapter.FillBYCLIENTE(Me.DS_contratos.vw_descuentoSA, ccliente)

        End If
    End Sub

    Private Sub frmconsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.Vw_Anexos1' Puede moverla o quitarla según sea necesario.
        ' Me.Vw_Anexos1TableAdapter.Fill(Me.DS_contratos.Vw_Anexos1)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.DS_contratos.Clientes)


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim F As New frm_contratos_alta
        'F.id_credito_consulta = ListBox1.SelectedValue
        If ListBox1.SelectedIndex >= 0 Then
            Dim idcredito_aux As Integer = ListBox1.SelectedValue
            F.consulta = True
            Anexo = Me.Vw_descuentoSATableAdapter.ANEXO(ListBox1.SelectedValue)
            F.GroupBox1.Enabled = False
            F.txtcredito.Text = ListBox1.SelectedValue
            F.contrato_consulta = ListBox1.SelectedValue
            'F.txt_id_contrato = 
            If Anexo <> "" Then
                Anexo = Trim(Anexo)
                If Anexo = "sa" Then
                    Anexo = ""
                End If
            End If

            If Anexo <> "" Then
                sinanexo = False
                'F.GroupBox1.Enabled = False
                'F.Ministracion1 = True
                Anexo = Me.Vw_descuentoSATableAdapter.ANEXO(idcredito_aux)
                Ciclo = Me.Vw_descuentoSATableAdapter.ciclo(idcredito_aux)
                F.Anexo = Anexo
                F.Ciclo = Ciclo
                'F.txtcredito.Text = ListBox1.SelectedValue
                'F.GroupBox1.Enabled = False
            Else
                'F.Ministracion1 = True
                sinanexo = True
                'F.GroupBox1.Enabled = False
                'F.Ministracion1 = True
                'F.txtcredito.Text = ListBox1.SelectedValue
            End If

            F.Show()
            'Me.Close()
        End If

    End Sub

    Private Sub ListBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedValueChanged
        Dim F As New frm_contratos_alta
        'F.Text = "Alta de contrato: " & DescuentosTRABindingSource.Current("descr")
        ' F.GroupBox1.Enabled = False
        'F.Ministracion1 = False
        'F.ListBox1.SelectedIndex = ListBox1.SelectedIndex
        ' F.Show()
        'Dim idcredito_aux As Integer = ListBox1.SelectedValue
        'ListBox1.SelectedIndex = ListBox1.SelectedIndex
        If ListBox1.SelectedIndex >= 0 Then
            'F.id_credito_consulta = ListBox1.SelectedValue

            Anexo = Me.Vw_descuentoSATableAdapter.ANEXO(ListBox1.SelectedValue)

            If Anexo <> "" Then
                Anexo = Anexo.Replace("/", "")
                If Anexo.Length > 0 Then
                    sinanexo = False
                    '   Dim CREDITO As Integer = cbanexos2.SelectedValue
                    F.Anexo = Me.Vw_descuentoSATableAdapter.ANEXO(ListBox1.SelectedValue)
                    F.Ciclo = Me.Vw_descuentoSATableAdapter.ciclo(ListBox1.SelectedValue)
                    F.GroupBox1.Enabled = False
                    F.Ministracion1 = False
                    ' F.Anexo = TxtAnexo.Text
                    ' F.Ciclo = TxtCiclo.Text
                    ' Me.CONT_CPF_contratosTableAdapter.FillByIDCREDITO(Me.DS_contratos.CONT_CPF_contratos, CREDITO)
                    ' Me.Vw_AnexosTableAdapter.FillBy_ANEXO(Me.DS_contratos.Vw_Anexos, Anexo, Ciclo)
                    'Me.Vw_Anexos1TableAdapter.FillBy_anexo(Me.DS_contratos6.Vw_Anexos1, Anexo, Ciclo)
                Else
                    sinanexo = True
                End If
                'F.Anexo = TxtAnexo.Text
                'F.Ciclo = TxtCiclo.Text
            End If
        End If


        'F.Show()
    End Sub
End Class