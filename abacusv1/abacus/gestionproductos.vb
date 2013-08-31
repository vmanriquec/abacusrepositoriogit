Imports abacusRules.Objects
Imports abacusRules.Entities
Imports abacusRules.Mappers
Imports abacusRules.micapadatos
Imports abacusRules
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.IO
Imports abacus.clsGenerarExcel
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports ThoughtWorks.QRCode
Imports ThoughtWorks.QRCode.Codec
Imports ThoughtWorks.QRCode.Codec.Data
Imports Microsoft.Office.Interop.Excel
Public Class gestionproductos
    Private qrBackColor As Integer = System.Drawing.Color.FromArgb(255, 255, 255, 255).ToArgb
    Private qrForeColor As Integer = System.Drawing.Color.FromArgb(255, 0, 0, 0).ToArgb

    Private objgridimages As ImageClass
    Dim actuali, siempreid, e, idv As Integer
    Dim mRow As Integer = 0
    Dim newpage As Boolean = True
    Dim can As String
    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function
    Public Sub ExportarDatosPDF(ByVal document As Document)
        'Se crea un objeto PDFTable con el numero de columnas del DataGridView. 
        Dim datatable As New PdfPTable(datagridview1.ColumnCount)
        'Se asignan algunas propiedades para el diseño del PDF.
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(datagridview1)
        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
        'Se crea el encabezado en el PDF. 
        Dim encabezado As New Paragraph("lista de Productos")
        Dim espacio As New Paragraph("                                           ")
        Dim linea As New Paragraph("_____________________________________________")

        'Se crea el texto abajo del encabezado.
        Dim texto As New Phrase("Reporte de Productos:" + CStr(Now.Date()))
        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To datagridview1.ColumnCount - 1
            datatable.AddCell(datagridview1.Columns(i).HeaderText)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1
        'Se generan las columnas del DataGridView. 
        For i As Integer = 0 To datagridview1.RowCount - 1
            For j As Integer = 0 To datagridview1.ColumnCount - 1
                'compruebo que columna contien la imagen y en que columna deseo que se muestre
                ' If (j = 12) Then
                'capturo la ruta de la imagen
                'Dim RutaImage As String
                ' RutaImage = CStr(datagridview1("txt_datagridview1_RutaImagen", i).Value)
                'Procedo a convertir a imagen de tipo itextsharp.text.image
                'Dim Img As Image = Me.picimagen.Image
                'Image.GetInstance(RutaImage)
                'agrego la imagen a la celda
                'datatable.AddCell(Img)
                'Else
                datatable.AddCell(DataGridView1(j, i).Value.ToString())
                'End If

            Next
            datatable.CompleteRow()
        Next



        Dim imagendemo As iTextSharp.text.Image 'Declaracion de una imagen

        imagendemo = iTextSharp.text.Image.GetInstance("c:/logomio.jpg") 'Dirreccion a la imagen que se hace referencia
        imagendemo.SetAbsolutePosition(700, 550) 'Posicion en el eje cartesiano
        imagendemo.ScaleAbsoluteWidth(120) 'Ancho de la imagen
        imagendemo.ScaleAbsoluteHeight(40) 'Altura de la imagen




        'Se agrega el PDFTable al documento.
        'document.Add(encabezado)
        document.Add(texto)
        document.Add(espacio)
        document.Add(linea)
        'document.Add(espacio)
        document.Add(datatable)
        document.Add(imagendemo) ' Agrega la imagen al documento
    End Sub
    Public Function GetColumnasSize() As Single()
        Dim values As Single() = New Single(datagridview1.ColumnCount - 1) {}
        For i As Integer = 0 To datagridview1.ColumnCount - 1
            values(i) = CSng(datagridview1.Columns(i).Width)
        Next
        Return values
    End Function

    Private Sub verificarsiproductoexiste(ByVal cod As String)
        Dim cn As New SqlClient.SqlConnection(cox)
        can = ("SELECT idproducto FROM productos WHERE CodProducto ='" & cod & "'")
        Dim cmd As New SqlClient.SqlCommand(can, cn)
        Dim drConsulta1 As SqlClient.SqlDataReader
        cn.Open()
        drConsulta1 = cmd.ExecuteReader()
        While drConsulta1.Read
            idv = CInt(CStr((drConsulta1(0))))
        End While
        drConsulta1.NextResult()
        drConsulta1.Close()
        cn.Close()
    End Sub














    Private Sub cargartodos()
        Me.DataGridView1.DataSource = capaproductos.cargartodosproductos
    End Sub
    Public Shared Sub cargarcombonombreproveedor(ByVal cbo As ComboBox)
        Try
            cbo.DataSource = capaproveedores.cargarcomboconcatenadoproveedores
            cbo.DisplayMember = "nombre"
            cbo.ValueMember = "IdProveedor"
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Public Shared Sub cargarcombonombrecategoria(ByVal cbo As ComboBox)
        Try
            cbo.DataSource = CategoriasMapper.cargarcomboconcatenadocategoriaproducto
            cbo.DisplayMember = "Categoria"
            cbo.ValueMember = "Id_Categoria"
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub limpiar()
        Me.txtobservaciones.Text = ""
    End Sub
    Private Sub bloquear()
        'Me.cboruta.Enabled = False
        'Me.txtobservacion.Enabled = False
        'Me.cbotrabajador.Enabled = False
    End Sub
    Private Sub habilitar()
        'Me.cbotrabajador.Enabled = True
        'Me.cboruta.Enabled = True
        'Me.txtobservacion.Enabled = True

    End Sub
    Private Sub nuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiar()
        actuali = 0
    End Sub
    Private Sub eliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.DataGridView1.RowCount = 0 Then
            MsgBox("busque primero el registro a eliminar")
        Else
            Dim fila As Byte
            Dim i As Integer
            fila = CByte(Me.DataGridView1.CurrentCell.RowIndex())
            Dim productos1 As New Productos
            i = CInt(CDec(Me.DataGridView1.Item(0, fila).Value()))
            ProductosMapper.Instance.Delete(i)
            MsgBox("registro eliminado con exito")
            cargartodos()
        End If

    End Sub

   

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        With DataGridView1
            Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
            fmt.LineAlignment = StringAlignment.Near
            fmt.Trimming = StringTrimming.None
            Dim y As Single = e.MarginBounds.Top
            Do While mRow < .RowCount
                Dim row As DataGridViewRow = .Rows(mRow)
                Dim x As Single = e.MarginBounds.Left
                Dim h As Single = 0
                For Each cell As DataGridViewCell In row.Cells
                    Dim rc As RectangleF = New RectangleF(x, y, cell.Size.Width, cell.Size.Height)

                    e.Graphics.DrawRectangle(Pens.Black, rc.Left, rc.Top, rc.Width, rc.Height)
                    If (newpage) Then
                        e.Graphics.DrawString(DataGridView1.Columns(cell.ColumnIndex).HeaderText, .Font, Brushes.Black, rc, fmt)
                    Else
                        e.Graphics.DrawString(DataGridView1.Rows(cell.RowIndex).Cells(cell.ColumnIndex).FormattedValue.ToString(), .Font, Brushes.Black, rc, fmt)
                    End If
                    x += rc.Width

                    h = Math.Max(h, rc.Height)
                Next
                newpage = False
                y += h
                mRow += 1
                If y + h > e.MarginBounds.Bottom Then
                    e.HasMorePages = True
                    mRow -= 1
                    newpage = True
                    Exit Sub
                End If
            Loop
            mRow = 0

        End With
    End Sub

    Public Shared Sub cargarcomboalmacen(ByVal cbo As ComboBox)
        Try
            cbo.DataSource = AlmacenesMapper.cargarcomboalmacen
            cbo.DisplayMember = "Almacen"
            cbo.ValueMember = "IdAlmacen"
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub gestionproductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarcombonombrecategoria(cbocategoria)
        cargarcombonombreproveedor(cboproveedor)
        cargarcomboalmacen(cboalmacen)

        'cargargrid()
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Dim openFileDialog1 As New OpenFileDialog()

        Dim result As New DialogResult
        openFileDialog1.InitialDirectory = "Bibliotecas\Imágenes"
        openFileDialog1.Filter = "archivos de imagen (*.jpg)|*.png|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 3
        openFileDialog1.RestoreDirectory = True
        result = openFileDialog1.ShowDialog()
        If (result = DialogResult.OK) Then
            picimagen.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName)
        End If
    End Sub

    Private Sub grabar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grabar.Click
        If Me.txtnombre.Text = "" And Me.txtpreciocosto.Text = "" And Me.txtprecioventa.Text = "" Then

            MsgBox("debe llenar por lo menos un nombre")


        Else
            If actuali <> 1 Then

                verificarsiproductoexiste(Me.txtcodigo.Text)
                Dim idv1 As String = CStr(idv)
                If idv1 = "0" Then
                    Dim productos1 As New Productos
                    productos1.IdProveedor = CType(Me.cboproveedor.SelectedValue.ToString, Integer?)
                    productos1.Categoria = CType(CStr(Me.cbocategoria.SelectedValue), Integer?)
                    productos1.Producto = Me.txtnombre.Text
                    productos1.fotoproducto = convertimage.ImageToByteArray(Me.picimagen.Image)
                    productos1.Capacidad = Me.txtcapacidad.Text
                    productos1.UMedida = Me.cbounidadmedida.Text
                    productos1.estado = "1"
                    productos1.PrecioCosto = CDec(Me.txtpreciocosto.Text)
                    productos1.PrecioVenta = CDec(Me.txtprecioventa.Text)
                    productos1.fechaingreso = CDate(Me.dtfecharegistro.Value)
                    productos1.fechadecaducidad = CDate(Me.dtfechacaducidad.Value)
                    productos1.Observaciones = Me.txtobservaciones.Text
                    productos1.TipoProducto = CType(CStr(Me.cboalmacen.SelectedValue), Integer?)
                    productos1.CodProducto = Me.txtcodigo.Text
                    ProductosMapper.Instance.Insert(productos1)
                    MsgBox("se agrego el registro")
                Else
                    MsgBox("el codigo del producto ya existe")
                End If

            Else
                Dim fila As Byte
                Dim i As Integer
                fila = CByte(Me.DataGridView1.CurrentCell.RowIndex())
                i = CInt(CDec(Me.DataGridView1.Item(0, fila).Value()))

                Dim productos1 As New abacusRules.Entities.Productos
                productos1 = ProductosMapper.Instance.GetOne(i)
                productos1.IdProveedor = CType(Me.cboproveedor.SelectedValue.ToString, Integer?)
                productos1.Categoria = CType(CStr(Me.cbocategoria.SelectedValue), Integer?)
                productos1.Producto = Me.txtnombre.Text
                productos1.fotoproducto = convertimage.ImageToByteArray(Me.picimagen.Image)
                productos1.Capacidad = Me.txtcapacidad.Text
                productos1.UMedida = Me.cbounidadmedida.Text
                productos1.estado = "1"
                productos1.PrecioCosto = CDec(Me.txtpreciocosto.Text)
                productos1.PrecioVenta = CDec(Me.txtprecioventa.Text)
                productos1.fechaingreso = CDate(Me.dtfecharegistro.Value)
                productos1.fechadecaducidad = CDate(Me.dtfechacaducidad.Value)
                productos1.Observaciones = Me.txtobservaciones.Text
                productos1.TipoProducto = CType(CStr(Me.cboalmacen.SelectedValue), Integer?)
                productos1.CodProducto = Me.txtcodigo.Text
                ProductosMapper.Instance.Save(productos1)
                MsgBox("se actualizo registro")
            End If
            End If

        cargartodos()
    End Sub

    Private Sub todos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles todos.Click
        cargartodos()
    End Sub
    'Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
    '    Dim bm As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
    '    DataGridView1.DrawToBitmap(bm, New System.Drawing.Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
    '    e.Graphics.DrawImage(bm, 0, 0)
    'End Sub
    Private Sub imprimir_datagrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imprimir_datagrid.Click

        'PrintPreviewDialog1.Document = PrintDocument1
        ' PrintDialog1.Document = PrintDocument1
        'PrintPreviewControl 
        PrintDocument1.Print()
    End Sub

    Private Sub nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nuevo.Click

    End Sub

    Private Sub editar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editar.Click
        limpiar()

        If Me.DataGridView1.RowCount = 0 Then
            MsgBox("busque primero el dato a editar")
        Else
            Dim fila As Byte
            Dim i As Integer
            fila = CByte(Me.DataGridView1.CurrentCell.RowIndex())


            Dim productos1 As ProductosObject
            i = CInt(CDec(Me.DataGridView1.Item(0, fila).Value()))
            productos1 = ProductosMapper.Instance.GetOne(i)
            Me.cboproveedor.SelectedValue = CStr(productos1.IdProveedor)
            Me.cbocategoria.SelectedValue = productos1.Categoria
            Me.cboalmacen.SelectedValue = productos1.TipoProducto
            Me.txtnombre.Text = productos1.Producto
            Me.picimagen.Image = convertimage.ByteArrayToImage(productos1.fotoproducto)
            Me.txtcapacidad.Text = productos1.Capacidad
            Me.cbounidadmedida.Text = productos1.UMedida

            Me.txtcodigo.Text = productos1.CodProducto
            If productos1.estado = "1" Then
                Me.chestado.Checked = True
            Else
                Me.chestado.Checked = False
            End If
            Me.txtpreciocosto.Text = CStr(CDec(productos1.PrecioCosto))
            Me.txtprecioventa.Text = CStr(CDec(productos1.PrecioVenta))
            Me.dtfecharegistro.Value = CDate(productos1.fechaingreso)
            Me.dtfechacaducidad.Value = CDate(productos1.fechadecaducidad)
            Me.txtobservaciones.Text = productos1.Observaciones
            actuali = 1
        End If
    End Sub

    Private Sub picimagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picimagen.Click

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If Me.DataGridView1.RowCount = 0 Then
            MsgBox("no existen detalles")
        Else

            'Crer dataset para exportar
            Dim dset As New DataSet
            'add table to dataset
            dset.Tables.Add()
            'agregar columnas a la tabla
            For i As Integer = 0 To DataGridView1.ColumnCount - 1
                dset.Tables(0).Columns.Add(DataGridView1.Columns(i).HeaderText)
            Next
            'agregar filas a la tabla
            Dim dr1 As DataRow
            For i As Integer = 0 To DataGridView1.RowCount - 1
                dr1 = dset.Tables(0).NewRow
                For j As Integer = 0 To DataGridView1.Columns.Count - 1
                    dr1(j) = DataGridView1.Rows(i).Cells(j).Value
                Next
                dset.Tables(0).Rows.Add(dr1)
            Next
            Dim excel As New Microsoft.Office.Interop.Excel.ApplicationClass
            Dim wBook As Microsoft.Office.Interop.Excel.Workbook
            Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet
            wBook = excel.Workbooks.Add()
            wSheet = CType(wBook.ActiveSheet(), Microsoft.Office.Interop.Excel.Worksheet)
            wSheet.Name = "Ejemplo"
            Dim dt As System.Data.DataTable = dset.Tables(0)
            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0
            For Each dc In dt.Columns
                colIndex = colIndex + 1
                excel.Cells(1, colIndex) = dc.ColumnName
            Next
            For Each dr In dt.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In dt.Columns
                    colIndex = colIndex + 1
                    excel.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next
            wSheet.Columns.AutoFit()
            Dim blnFileOpen As Boolean = False
            Try
            Catch ex As Exception
                blnFileOpen = False
            End Try
            excel.Visible = True
        End If
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click

        If Me.DataGridView1.RowCount = 0 Then
            MsgBox("no existen detalles")
        Else
            'Intentar generar el documento.
            Dim doc As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)

            'Path que guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Reporte_de_ingreos.pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, file)
            doc.Open()
            ExportarDatosPDF(doc)
            doc.Close()
            Process.Start(filename)
        End If
    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        Dim qrCodeEncoder As QRCodeEncoder = New QRCodeEncoder
        qrCodeEncoder.QRCodeEncodeMode = ThoughtWorks.QRCode.Codec.QRCodeEncoder.ENCODE_MODE.BYTE
        'qrCodeEncoder.QRCodeEncodeMode = Codec.QRCodeEncoder.ENCODE_MODE.ALPHA_NUMERIC
        qrCodeEncoder.QRCodeScale = 4

        qrCodeEncoder.QRCodeErrorCorrect = ThoughtWorks.QRCode.Codec.QRCodeEncoder.ERROR_CORRECTION.H
        'La versión "0" calcula automáticamente el tamaño
        qrCodeEncoder.QRCodeVersion = 0

        '' --------- Forzar una determinada version -----------
        ''En caso de querer forzar una determinada version (tamaño) el siguiente código devuelve la
        ''versión mínima para el texto que se quiere códificar:
        'Dim iVersion As Integer = AdjustQRVersion(TextBox1.Text, qrCodeEncoder.QRCodeErrorCorrect)
        'If iVersion = -1 Then
        '    MessageBox.Show("El texto es demasiado grande o el Correction Level (ERROR_CORRECTION) no es el apropiado")
        '    Exit Sub
        'Else
        '    qrCodeEncoder.QRCodeVersion = iVersion
        'End If
        '' -----------------------------------------------------

        qrCodeEncoder.QRCodeBackgroundColor = System.Drawing.Color.FromArgb(qrBackColor)
        qrCodeEncoder.QRCodeForegroundColor = System.Drawing.Color.FromArgb(qrForeColor)

        'La codificación con UTF8 nos permite guardar caracteres propios del castellano: La ñ, los acentos, la ç, etc

        Dim qq As String = Me.txtnombre.Text
        Dim aa As String = Me.txtpreciocosto.Text
        Dim a1 As String = Me.txtprecioventa.Text
        Dim f1 As String = Me.dtfecharegistro.Text
        Dim f2 As String = Me.dtfechacaducidad.Text
        Dim cr As String = qq + " PC:" + aa + " PV:" + a1 + " FR:" + f1 + " FV:" + f2
        PictureBox1.Image = qrCodeEncoder.Encode(qq, System.Text.Encoding.UTF8)
        Me.Label12.Text = cr
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click, Label13.Click

    End Sub

    Private Sub PanelEx1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanelEx1.Click

    End Sub

    Private Sub eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eliminar.Click
        If Me.DataGridView1.RowCount = 0 Then
            MsgBox("busque primero el producto")
        Else
            Dim fila As Byte
            Dim i As Integer
            fila = CByte(Me.DataGridView1.CurrentCell.RowIndex())
            Dim producto As New Productos
            i = CInt(CDec(Me.DataGridView1.Item(0, fila).Value()))
            ProductosMapper.Instance.Delete(i)
            MsgBox("producto eliminado con exito")
            Me.DataGridView1.DataSource = capaproductos.cargartodosproductos
        End If


    End Sub
End Class