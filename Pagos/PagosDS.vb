Partial Class PagosDS
    Partial Public Class CONT_CPF_PagosFiraDataTable
        Private Sub CONT_CPF_PagosFiraDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.FechaPagoFiraColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class
End Class
