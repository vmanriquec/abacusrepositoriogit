Imports Microsoft.VisualBasic
Imports Excel = Microsoft.Office.Interop.Excel
Imports Marshal = System.Runtime.InteropServices.Marshal
Public Class clsGenerarExcel
    Public Enum datoResp
        OK = 0
        MSG = 1
    End Enum
    ''' Clase que contiene Funciones que permiten Generar Archivos en formato Excel con Tablas Dinámicas.
    ''' Enumerador de los Tipos de de datos devueltos por la función Generar Excel.
    ''' </summary>
    ''' <remarks>Permite determinar el tipo de información que contiene el Diccionario de Respuesta.</remarks>

        ''' <summary>
        ''' Enumerador de las Versiones que soporta el Exportar (v2000=Excel 2000 : v10=Excel XP : v11=Excel 2003 : v12=Excel 2007 : v14=Excel 2010).
        ''' </summary>
        ''' <remarks>Permite determinar el tipo de Archivo a Generar, y las propiedades del mismo según la versión.</remarks>
        Public Enum VersionExcel
            v10 = 0
            v11 = 1
            v12 = 2
            v14 = 3
            v2000 = 4
        End Enum

        ''' <summary>
        ''' Función que Genera un Archivo Excel a partir de un objeto DataTable.
        ''' </summary>
        ''' <param name="nombreArch">El nombre y la dirección del archivo a generar, sin la extensión.</param>
        ''' <param name="dt">Objeto de tipo DataTable con los datos del informe.</param>
        ''' <param name="titulosColumnas">ArrayList con los Títulos para las Columnas de la Hoja de Datos.</param>
        ''' <param name="datosFilas">ArrayList con los Títulos de los datos a ser mostrador en las Filas.</param>
        ''' <param name="datosColumnas">ArrayList con los Títulos de los datos a ser mostrador en las Columnas.</param>
        ''' <param name="datosFiltros">ArrayList con los Títulos de los datos a ser mostrador en los Filtros.</param>
        ''' <param name="datosDatoCalculado">ArrayList con los Títulos de los datos a ser mostrador en las la sección de Datos.</param>
        ''' <param name="version">Versión del archivo generado (v12[Excel2007] : v14[Excel2010]).</param>
        ''' <returns>Diccionario con la información para determinar si se pudo Generar el archivo o no.</returns>
        ''' <remarks>Permite generar un archivo Excel con una Tabla Dinámica con los datos Solicitados.</remarks>
    Public Function GenerarExcel(ByVal nombreArch As String, ByVal dt As DataGridView, _
                                            ByVal titulosColumnas As ArrayList, _
                                            ByVal datosFilas As ArrayList, _
                                            ByVal datosColumnas As ArrayList, _
                                            ByVal datosFiltros As ArrayList, _
                                            ByVal datosDatoCalculado As ArrayList, _
                                            ByVal version As VersionExcel) As Dictionary(Of datoResp, Object)
        Dim dict As New Dictionary(Of datoResp, Object)

        Dim extArchivo As String = ""
        Dim versionExcel As Excel.XlPivotTableVersionList
        If version = clsGenerarExcel.VersionExcel.v10 Then
            versionExcel = Excel.XlPivotTableVersionList.xlPivotTableVersion10
            extArchivo = ".xls"
        ElseIf version = clsGenerarExcel.VersionExcel.v11 Then
            versionExcel = Excel.XlPivotTableVersionList.xlPivotTableVersion11
            extArchivo = ".xls"
        ElseIf version = clsGenerarExcel.VersionExcel.v12 Then
            versionExcel = Excel.XlPivotTableVersionList.xlPivotTableVersion12
            extArchivo = ".xlsx"
        ElseIf version = clsGenerarExcel.VersionExcel.v2000 Then
            versionExcel = Excel.XlPivotTableVersionList.xlPivotTableVersion2000
            extArchivo = ".xls"
        End If

        Dim col As Integer = 0
        Dim fila As Integer = 1
        Dim colmax As Integer = titulosColumnas.Count

        Dim app As Excel.Application
        Dim book As Excel.Workbook
        Dim hojaDatos As Excel.Worksheet
        Dim hojaTabla As Excel.Worksheet

        Try
            app = New Excel.Application()
            app.Visible = False

            book = app.Workbooks.Add()
            CType(book.Sheets.Item(3), Excel.Worksheet).Delete()

            hojaDatos = CType(book.Sheets.Item(2), Excel.Worksheet)
            hojaDatos.Name = "Datos"

            For Each titulo As String In titulosColumnas
                col += 1
                hojaDatos.Cells(fila, col) = titulo.ToUpper().Trim()
            Next

            For Each dr As Data.DataRow In dt.Rows
                fila += 1
                col = 0
                For i As Integer = 0 To colmax - 1
                    col += 1
                    hojaDatos.Cells(fila, col) = dr.Item(i)
                Next
            Next

            hojaTabla = CType(book.Sheets.Item(1), Excel.Worksheet)
            hojaTabla.Name = "Tabla"

            Dim pc As Excel.PivotCache
            pc = book.PivotCaches.Create(Excel.XlPivotTableSourceType.xlDatabase, _
                                         "Datos!R1C1:R" & fila.ToString().Trim() & _
                                         "C" & colmax.ToString().Trim(), _
                                         versionExcel)
            Dim pt As Excel.PivotTable
            pt = pc.CreatePivotTable("Tabla!R1C1", "PT", , _
                                     versionExcel)

            hojaTabla.Select()

            For Each dato As String In datosDatoCalculado
                pt.AddDataField(pt.PivotFields(dato), "Suma de " & dato, _
                                Excel.XlConsolidationFunction.xlSum)
            Next

            Dim posCol As Integer = 0
            For Each dato As String In datosColumnas
                posCol += 1
                With CType(pt.PivotFields(dato), Excel.PivotField)
                    .Orientation = Excel.XlPivotFieldOrientation.xlColumnField
                    .Position = posCol
                    .LayoutBlankLine = True
                End With
            Next

            Dim posFila As Integer = 0
            For Each dato As String In datosFilas
                posFila += 1
                With CType(pt.PivotFields(dato), Excel.PivotField)
                    .Orientation = Excel.XlPivotFieldOrientation.xlRowField
                    .Position = posFila
                    .LayoutBlankLine = True
                End With
            Next

            For Each dato As String In datosFiltros
                With CType(pt.PivotFields(dato), Excel.PivotField)
                    .Orientation = Excel.XlPivotFieldOrientation.xlPageField
                    .Position = 1
                    .LayoutBlankLine = True
                End With
            Next

            For Each dato As String In datosDatoCalculado
                With CType(pt.PivotFields(dato), Excel.PivotField)
                    .NumberFormat = "$ #.##0;[Rojo]$ #.##0"
                    .LayoutBlankLine = True
                End With
            Next

            Try
                pt.TableStyle2 = "PivotStyleMedium2"
            Catch : End Try
            pt.ShowTableStyleRowStripes = True
            pt.ShowTableStyleColumnStripes = True
            pt.SubtotalLocation(Excel.XlSubtototalLocationType.xlAtBottom)
            pt.NullString = "0"

            book.SaveAs(nombreArch & extArchivo)
            app.Quit()

            liberarRecursos(hojaDatos)
            liberarRecursos(hojaTabla)
            liberarRecursos(book)
            liberarRecursos(app)

            GC.Collect()

            dict.Add(datoResp.OK, True)
            dict.Add(datoResp.MSG, "Archivo generado exitosamente.")
        Catch ex As Exception
            dict.Add(datoResp.OK, False)
            dict.Add(datoResp.MSG, "Ha ocurrido un error al generar el archivo: " & vbCrLf & _
                                   "" & vbTab & ex.Message)
        End Try

        Return dict
    End Function

        ''' <summary>
        ''' Función que liberar los recursos utilizados para generar el archivo.
        ''' </summary>
        ''' <param name="obj">El objeto a ser anulado y liberado de memoria.</param>
        ''' <remarks>Permite cerrar completamente los Procesos de Excel.</remarks>
        Private Sub liberarRecursos(ByVal obj As Object)
            Try
                Marshal.ReleaseComObject(obj)
                obj = Nothing
            Catch ex As Exception
                obj = Nothing
            Finally
                GC.Collect()
            End Try
        End Sub
End Class
