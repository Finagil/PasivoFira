Public Class frm_garantias


    Private Sub frm_garantias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_contratos.CONT_CPF_garantias' table. You can move, or remove it, as needed.
        Me.CONT_CPF_garantiasTableAdapter.Fill(Me.DS_contratos.CONT_CPF_garantias)
        'TODO: This line of code loads data into the 'DS_contratos.CONT_CPF_contratos_garantias' table. You can move, or remove it, as needed.
        Me.CONT_CPF_contratos_garantiasTableAdapter.FillBycontrato(Me.DS_contratos.CONT_CPF_contratos_garantias, frm_contratos_alta.id_contrato)

    End Sub


    

   






End Class