Imports Excel = Microsoft.Office.Interop.Excel

Public Class Form1
    Dim Aplicacion As Excel.Application
    Dim Libro As Excel.Workbook
    Dim Hoja As Excel.Worksheet

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim OpenFileDialog1 As New System.Windows.Forms.OpenFileDialog

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim path As String = OpenFileDialog1.FileName
            TextFile.Text = path
            Cursor.Current = Cursors.WaitCursor
            CargaEdoCtaFira()
            Cursor.Current = Cursors.Default
            MessageBox.Show("Carga Terminada", "Carga de DAtos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub CargaEdoCtaFira()
        Try
            Dim ARRE(10) As String
            Dim z, w As Integer
            Dim ta As New DataSet1TableAdapters.ZS976SDOTableAdapter
            Aplicacion = New Excel.Application
            Libro = Aplicacion.Workbooks.Open(TextFile.Text)
            Hoja = Libro.Worksheets(1)
            ta.DeleteAll()

            For X As Integer = 1 To 30000
                If Hoja.Range("A" & X).Value = "SIIOF" Then
                    ARRE(1) = Hoja.Range("AD" & X).Value 'SALDO CAP
                    ARRE(2) = Hoja.Range("AE" & X).Value 'SALDO FIN
                    ARRE(3) = Hoja.Range("AF" & X).Value 'INTERES
                    ARRE(4) = Hoja.Range("AP" & X).Value 'TASA FB
                    ARRE(5) = Hoja.Range("AT" & X).Value 'T FIJA
                    ARRE(6) = CDate(Hoja.Range("BA" & X).Value).ToString("dd/MM/yyyy") 'FECHA ULTIMO VENC
                    ARRE(7) = Hoja.Range("BX" & X).Value 'RFC
                    ARRE(8) = Hoja.Range("BY" & X).Value 'NOMBRE
                    ARRE(9) = Hoja.Range("CV" & X).Value 'OD_CREDITO
                    ARRE(10) = Hoja.Range("DW" & X).Value 'CREDITO INTERMEDIARIO
                    If IsNothing(Hoja.Range("DW" & X).Value) Then
                        ARRE(10) = ""
                    End If
                    ta.Insert(ARRE(1), ARRE(2), ARRE(3), ARRE(4), ARRE(5), ARRE(6), ARRE(7), ARRE(8), ARRE(9), ARRE(10)) 'CREDITO INTERMEDIARIO
                    w += 1
                ElseIf IsNothing(Hoja.Range("A" & X).Value) Then
                    z += 1
                End If
                If z = 10 Then
                    Exit For
                End If
            Next
            If w <= 0 Then
                MessageBox.Show("No se cargaron Filas al estado de cuenta", "Error en Excel", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en Excel", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Libro.Close()
            Aplicacion.Quit()
            releaseObject(Aplicacion)
            releaseObject(Libro)
            releaseObject(Hoja)
        End Try
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.ZS976SDO' Puede moverla o quitarla según sea necesario.
        Me.ZS976SDOTableAdapter.Fill(Me.DataSet1.ZS976SDO)
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.ZS976SDO' Puede moverla o quitarla según sea necesario.
        Me.ZS976SDOTableAdapter.Fill(Me.DataSet1.ZS976SDO)

    End Sub
End Class
