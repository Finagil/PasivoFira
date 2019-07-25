Imports System.IO
Public Class frmLayoutFact
    Public Shared lote As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim monto As Decimal
        Dim Inserto As Boolean = False
        Dim nominal As Decimal
        Dim procesado As Integer = 0
        Dim contador As Integer = 1
        Dim contador_archivo As Integer
        Dim sRenglon As String = Nothing
        Dim strStreamW As Stream = Nothing
        Dim strStreamWriter As StreamWriter = Nothing
        Dim ContenidoArchivo As String = Nothing
        ' Donde guardamos los paths de los archivos que vamos a estar utilizando ..
        Dim PathArchivo As String
        Dim i As Integer
        '  BP = Me.Vw_AnexosTableAdapter.SacaTasaTRA(Me.Vw_AnexosBindingSource.Current("Anexo"))
        If Directory.Exists("C:\Factoraje") = False Then ' si no existe la carpeta se crea
            Directory.CreateDirectory("C:\Factoraje")
        End If
        '  BP = Me.Vw_AnexosTableAdapter.SacaTasaTRA(Me.Vw_AnexosBindingSource.Current("Anexo"))

        'cb_tasa.SelectedIndex = 2

        'BP = Me.Vw_AnexosTableAdapter.SacaDiferAVI(Me.Vw_AnexosBindingSource.Current("Anexo"), Me.Vw_AnexosBindingSource.Current("Ciclo"))
        Dim RENG As Integer = DGFACT.RowCount

        For Renglones As Integer = 0 To DGFACT.RowCount - 1

            Dim rfc As String = Me.DGFACT.Item(2, Renglones).Value
            monto = Me.DGFACT.Item(3, Renglones).Value
            Dim DOC As String = Me.DGFACT.Item(0, Renglones).Value
            Dim TASA As Decimal = Me.DGFACT.Item(4, Renglones).Value
            Dim fecha As Date = Me.DGFACT.Item(5, Renglones).Value
            Dim producto, operacion, prestamo, divisa, intermediario, esquema, tipotasa As Integer
            producto = cb_producto.SelectedValue
            divisa = cb_divisa.SelectedValue
            Dim tasafijafira As Decimal
            tasafijafira = Me.DGFACT.Item(4, Renglones).Value

            If producto = 1 Then
                TXT_NOM.Text = ""
            End If
            'GENERAR ARCHIVO
            'creamos archivo 
            If contador = 1 Then

                sRenglon = Nothing
                strStreamW = Nothing
                strStreamWriter = Nothing
                ContenidoArchivo = Nothing
                contador_archivo = Me.CONT_CPF_configuracionTableAdapter.ScalarQueryconfiguracion(CONFIG.ARCHIVOfac)
                Windows.Forms.Cursor.Current = Cursors.WaitCursor
                PathArchivo = "C:\Factoraje\FACTORAJE" & Format(Today.Date, "ddMMyyyy") & "LOTE " & ComboBox2.SelectedValue & "_" & contador_archivo & ".csv" ' Se determina el nombre del archivo con la fecha actual

                'verificamos si existe el archivo

                If File.Exists(PathArchivo) Then
                    strStreamW = File.Open(PathArchivo, FileMode.Open) 'Abrimos el archivo
                Else
                    strStreamW = File.Create(PathArchivo) ' lo creamos
                End If


                strStreamWriter = New StreamWriter(strStreamW, System.Text.Encoding.Default) ' tipo de codificacion para escritura
            End If


            If contador <= 100 Then
                strStreamWriter.WriteLine(producto & "," & divisa & "," & TXT_NOM.Text & "," & "" & "," & "" & "," & "1" & "," &
                                          DOC & "," & Me.DGFACT.Item(1, Renglones).Value & "," & "" & "," &
                                          Me.DGFACT.Item(2, Renglones).Value & "," & monto & "," &
                                          TASA & "," & Me.DGFACT.Item(5, Renglones).Value & "," & Me.DGFACT.Item(6, Renglones).Value)
            End If

            If contador = 100 Then
                strStreamWriter.Close() ' cerramos
                contador = 0
                Me.CONT_CPF_configuracionTableAdapter.CONSUMEARCHIVOFACT()

                sRenglon = Nothing
                strStreamW = Nothing
                strStreamWriter = Nothing
                ContenidoArchivo = Nothing
                ' Donde guardamos los paths de los archivos que vamos a estar utilizando ..
                ' PathArchivo As String
            End If

            If RENG = DGFACT.RowCount - 1 Then
                strStreamWriter.Close() ' cerramos
            End If
            contador = contador + 1
        Next
        Me.CONT_CPF_Factor_FacturasTableAdapter.Fill(Me.FactorajeDS.CONT_CPF_Factor_Facturas, ComboBox2.SelectedValue)
        strStreamWriter.Close() ' cerramos
        Me.CONT_CPF_configuracionTableAdapter.CONSUMEARCHIVOFACT()
        MessageBox.Show("Layout generado en C:\Factoraje\", "FACTORAJE CARTERA PASIVA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub frmLayoutFact_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CONT_CPF_divisasTableAdapter.Fill(Me.DS_contratos.CONT_CPF_divisas)
        'TODO: esta línea de código carga datos en la tabla 'DS_contratos.CONT_CPF_productos_fira' Puede moverla o quitarla según sea necesario.
        Me.CONT_CPF_productos_firaTableAdapter.Fill(Me.DS_contratos.CONT_CPF_productos_fira)
        'TODO: esta línea de código carga datos en la tabla 'FactorajeDS.WEB_Lotes' Puede moverla o quitarla según sea necesario.
        Me.WEB_LotesTableAdapter.Fill(Me.FactorajeDS.WEB_Lotes)
        cb_producto.SelectedValue = 2
        cb_divisa.SelectedValue = 1

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedValueChanged
        Me.CONT_CPF_Factor_FacturasTableAdapter.Fill(Me.FactorajeDS.CONT_CPF_Factor_Facturas, ComboBox2.SelectedValue)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lote = ComboBox2.SelectedValue
        Dim f As New Frm_DescuentosFAC
        f.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub bt_cambiarFecha_Click(sender As Object, e As EventArgs) Handles bt_cambiarFecha.Click
        Me.CONT_CPF_Factor_FacturasTableAdapter.UpdateFechaExp(DTFecha.Text, ComboBox2.SelectedValue)
        Me.CONT_CPF_Factor_FacturasTableAdapter.Fill(Me.FactorajeDS.CONT_CPF_Factor_Facturas, ComboBox2.SelectedValue)
        MessageBox.Show("Fecha de Exp. se cambió correctamente", "FACTORAJE CARTERA PASIVA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub
End Class