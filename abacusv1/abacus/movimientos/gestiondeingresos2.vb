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

Public Class gestiondeingresos2
    Dim actuali, actualidetalle, ultimoid, e As Integer
    Dim mRow As Integer = 0
    Dim newpage As Boolean = True
    Dim caden, cadena As String
    Dim fecha1, fecha2 As Date
    Dim idprov, valacdet As Integer
    Dim det As DataTable
    Private arrCols(0 To 5) As DataGridViewColumn 'Arreglo que contendrá la definición de las columnas.
    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function
    Public Sub ExportarDatosPDF(ByVal document As Document)
        'Se crea un objeto PDFTable con el numero de columnas del DataGridView. 
        Dim datatable As New PdfPTable(dgbusqueda.ColumnCount)
        'Se asignan algunas propiedades para el diseño del PDF.
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(dgbusqueda)
        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
        'Se crea el encabezado en el PDF. 
        Dim encabezado As New Paragraph("lista de ingresos")
        Dim espacio As New Paragraph("                                           ")
        Dim linea As New Paragraph("_____________________________________________")
        'Se crea el texto abajo del encabezado.
        Dim texto As New Phrase("Reporte de Ingresos:" + CStr(Now.Date()))
        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To dgbusqueda.ColumnCount - 1
            datatable.AddCell(dgbusqueda.Columns(i).HeaderText)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1
        'Se generan las columnas del DataGridView. 
        For i As Integer = 0 To dgbusqueda.RowCount - 1
            For j As Integer = 0 To dgbusqueda.ColumnCount - 1
                'compruebo que columna contien la imagen y en que columna deseo que se muestre
                'If (j = 4) Then
                'capturo la ruta de la imagen
                'Dim RutaImage As String
                ' RutaImage = CStr(dgbusqueda("txt_dgbusqueda_RutaImagen", i).Value)
                'Procedo a convertir a imagen de tipo itextsharp.text.image
                'Dim Img As Image = Image.GetInstance(RutaImage)
                'agrego la imagen a la celda
                'datatable.AddCell(Img)
                'Else
                datatable.AddCell(dgbusqueda(j, i).Value.ToString())
                'End If

            Next
            datatable.CompleteRow()
        Next
        'Se agrega el PDFTable al documento.
        'document.Add(encabezado)
        document.Add(texto)
        'document.Add(espacio)
        document.Add(linea)
        'document.Add(espacio)
        document.Add(datatable)
    End Sub
    








    Public Function GetColumnasSize() As Single()
        Dim values As Single() = New Single(dgbusqueda.ColumnCount - 1) {}
        For i As Integer = 0 To dgbusqueda.ColumnCount - 1
            values(i) = CSng(dgbusqueda.Columns(i).Width)
        Next
        Return values
    End Function


    Private Sub cargartodos()
        Me.dgbusqueda.DataSource = capaingresos.listartodoslosingresos
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


    Public Shared Sub cargarcombonombreproducto(ByVal cbo As ComboBox)
        Try
            cbo.DataSource = capaproductos.cargarcomboproductos
            cbo.DisplayMember = "Producto"
            cbo.ValueMember = "IdProducto"
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Shared Sub cargarcombonombretrabajador(ByVal cbo As ComboBox)
        Try
            cbo.DataSource = TrabajadoresMapper.cargarnombretrabajador
            cbo.DisplayMember = "nombre"
            cbo.ValueMember = "IdTrabjador"
        Catch ex As Exception
            Throw ex
        End Try
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
    Private Function Sumar(ByVal a As String, ByVal Dgv As DataGridView) As Decimal

        Dim total As Decimal = 0
        ' recorrer las filas y obtener los items de la columna indicada en "nombre_Columna"  
        Try
            For i As Integer = 0 To Dgv.RowCount - 1
                total = CDec(total + CDec(Dgv.Item(a, i).Value))
            Next

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        ' retornar el valor  
        Return total

    End Function
    Private Sub crearcadenaconfecha(ByVal campo As String, ByVal idabuscar As Integer, ByVal fecha1 As Date, ByVal fecha2 As Date)
        cadena = "SELECT dbo.Ingresos.IdIngresos AS ID,dbo.Trabajadores.Nombres+ '--' + dbo.Trabajadores.Apellidos AS Reg_Ingreso,dbo.Ingresos.Fecha,dbo.Ingresos.Serie,dbo.Ingresos.Numero,dbo.Ingresos.estado,dbo.Ingresos.valortotal AS Total,dbo.Ingresos.lote,dbo.Proveedores.NomComercial AS Proveedor,dbo.Almacenes.Almacen,dbo.FormaPago.Forma AS Form_Pago,dbo.Ingresos.TipDoc  FROM    dbo.Ingresos INNER JOIN dbo.Proveedores ON dbo.Ingresos.IdProveedor = dbo.Proveedores.IdProveedor INNER JOIN dbo.Trabajadores ON dbo.Ingresos.IdTrabjador = dbo.Trabajadores.IdTrabjador INNER JOIN dbo.Almacenes ON dbo.Ingresos.IdAlmacen = dbo.Almacenes.IdAlmacen INNER JOIN dbo.FormaPago ON dbo.FormaPago.IdFPago = dbo.Ingresos.ModoPago  WHERE '" & campo & "'='" & idabuscar & "' AND Fecha Between '" & fecha1 & "'  And   '" & fecha2 & "'"
    End Sub
    Private Sub crearcadenasinfecha(ByVal campo As String, ByVal idabuscar As Integer)
        cadena = "SELECT dbo.Ingresos.IdIngresos AS ID,dbo.Trabajadores.Nombres+ '--' + dbo.Trabajadores.Apellidos AS Reg_Ingreso,dbo.Ingresos.Fecha,dbo.Ingresos.Serie,dbo.Ingresos.Numero,dbo.Ingresos.estado,dbo.Ingresos.valortotal AS Total,dbo.Ingresos.lote,dbo.Proveedores.NomComercial AS Proveedor,dbo.Almacenes.Almacen,dbo.FormaPago.Forma AS Form_Pago,dbo.Ingresos.TipDoc  FROM    dbo.Ingresos INNER JOIN dbo.Proveedores ON dbo.Ingresos.IdProveedor = dbo.Proveedores.IdProveedor INNER JOIN dbo.Trabajadores ON dbo.Ingresos.IdTrabjador = dbo.Trabajadores.IdTrabjador INNER JOIN dbo.Almacenes ON dbo.Ingresos.IdAlmacen = dbo.Almacenes.IdAlmacen INNER JOIN dbo.FormaPago ON dbo.FormaPago.IdFPago = dbo.Ingresos.ModoPago  WHERE '" & campo & "'='" & idabuscar & "'"
    End Sub

    Private Sub idultimoingreso()
        Dim cn As New SqlClient.SqlConnection(cox)
        caden = ("SELECT max(IdIngresos) FROM Ingresos")
        Dim cmd As New SqlClient.SqlCommand(caden, cn)
        Dim drConsulta1 As SqlClient.SqlDataReader
        cn.Open()
        drConsulta1 = cmd.ExecuteReader()
        While drConsulta1.Read
            ultimoid = CInt(CStr((drConsulta1(0))))
        End While
        drConsulta1.NextResult()
        drConsulta1.Close()
        cn.Close()
    End Sub


    Private Sub muestrarapidadedetalles(ByVal a As Integer)

        If a = 1 Then


            If Me.dgbusqueda.RowCount = 0 Then
                MsgBox("no hay nada seleccionado")
            Else
                Dim fila As Byte
                Dim i As Integer
                fila = CByte(Me.dgbusqueda.CurrentCell.RowIndex())
                Dim ingreso1 As IngresosObject

                i = CInt(CDec(Me.dgbusqueda.Item(0, fila).Value()))
                ingreso1 = IngresosMapper.Instance.GetOne(i)
                Dim aa As New ingreso
                aa.IdIngresos = i
                Me.dgdetalle.DataSource = capaingresos.listardetalleporingreso(aa)
            End If
        Else
        End If
    End Sub
    Private Sub beditar()
        Me.nuevo.Enabled = False
        Me.eliminar.Enabled = False
        Me.todos.Enabled = False
        Me.grabar.Enabled = True
        Me.editar.Enabled = False

    End Sub

    Private Sub bgrabar()
        Me.nuevo.Enabled = True
        Me.eliminar.Enabled = False
        Me.todos.Enabled = True
        Me.grabar.Enabled = False
        Me.editar.Enabled = False

    End Sub
    Private Sub beliminar()
        Me.nuevo.Enabled = True
        Me.eliminar.Enabled = False
        Me.todos.Enabled = True
        Me.grabar.Enabled = False
        Me.editar.Enabled = False
    End Sub
    Private Sub btodos()
        Me.nuevo.Enabled = True
        Me.eliminar.Enabled = True
        Me.todos.Enabled = True
        Me.grabar.Enabled = False
        Me.editar.Enabled = True
    End Sub

    Private Sub binicio()
        Me.nuevo.Enabled = True
        Me.eliminar.Enabled = False
        Me.todos.Enabled = True
        Me.grabar.Enabled = False
        Me.editar.Enabled = False
        Me.DataGridView1.Enabled = True
        Me.DataGridView1.Visible = True
        Me.dgdetalle.Enabled = False
        Me.dgdetalle.Visible = False
        Me.cboeliminardetalle.Enabled = False
        Me.btadicionar.Enabled = False

    End Sub
    Private Sub bnuevo()
        Me.nuevo.Enabled = False
        Me.eliminar.Enabled = False
        Me.todos.Enabled = False
        Me.grabar.Enabled = True
        Me.editar.Enabled = False
    End Sub



    Private Sub limpiardetalle()
        Me.txtcantidad.Text = ""
        Me.txtcosto.Text = ""
        Me.txtventa.Text = ""
        Me.cboproducto.Text = ""
        'Me.txtobservaciones.Text = ""
    End Sub
    Private Sub limpiarcabecera()
        Me.cboalmacen.Text = ""
        Me.cboproducto.Text = ""
        Me.cboproveedor.Text = ""
        Me.cbotipodocumento.Text = ""
        Me.cbotipopago.Text = ""
        Me.cbotrabajador.Text = ""
        Me.txtserie.Text = ""
        Me.txtnumero.Text = ""
        Me.txtlote.Text = ""
        Me.labmonto.Text = ""
    End Sub
    Private Sub habilitarcabecera()
        Me.cboalmacen.Enabled = True
        Me.cboproducto.Enabled = True
        Me.cboproveedor.Enabled = True
        Me.cbotipodocumento.Enabled = True
        Me.cbotipopago.Enabled = True
        Me.cbotrabajador.Enabled = True
        Me.txtserie.Enabled = True
        Me.txtnumero.Enabled = True
        Me.txtlote.Enabled = True
        Me.labmonto.Enabled = True
    End Sub
    Private Sub habilitardetalle()
        Me.txtcantidad.Enabled = True
        Me.txtcosto.Enabled = True
        Me.txtventa.Enabled = True
        Me.cboproducto.Enabled = True
    End Sub
    Private Sub inhabilitarcabecera()
        Me.cboalmacen.Enabled = False
        Me.cboproducto.Enabled = False
        Me.cboproveedor.Enabled = False
        Me.cbotipodocumento.Enabled = False
        Me.cbotipopago.Enabled = False
        Me.cbotrabajador.Enabled = False
        Me.txtserie.Enabled = False
        Me.txtnumero.Enabled = False
        Me.txtlote.Enabled = False
        Me.labmonto.Enabled = False
    End Sub
    Private Sub inhabilitardetalle()
        Me.txtcantidad.Enabled = False
        Me.txtcosto.Enabled = False
        Me.txtventa.Enabled = False
        Me.cboproducto.Enabled = False
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
        limpiarcabecera()
        actuali = 0
    End Sub

    Private Sub gestiondeingresos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarcombonombreproveedor(cboproveedor)
        cargarcombonombreproducto(cboproducto)
        cargarcombonombretrabajador(cbotrabajador)
        cargarcomboalmacen(cboalmacen)
        limpiarcabecera()
        limpiardetalle()
        inhabilitarcabecera()
        inhabilitardetalle()
        Me.GenerarColumnas()
        binicio()
    End Sub

    Private Sub cboagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btadicionar.Click

        If txtcantidad.Text = "" Or Me.txtcosto.Text = "" Or Me.txtventa.Text = "" Then

            MsgBox("debe llenar algun numero en costo o cantidad ademas de por lo menos un trabajador y un proveedor")
        Else
            If actualidetalle = 1 Then
                Me.labmonto.Text = ""
                Dim fila As Byte
                Dim i As Integer
                fila = CByte(Me.dgbusqueda.CurrentCell.RowIndex())
                i = CInt(CDec(Me.dgbusqueda.Item(0, fila).Value()))
                Dim oo As New ingreso
                oo.IdIngresos = i
                Dim detalle1 As New ingresodetalle
                detalle1.IdIngresos = i
                detalle1.IdProducto = CInt(CType(Me.cboproducto.SelectedValue.ToString, Integer?))
                detalle1.Cantidad = CDec(Me.txtcantidad.Text)
                detalle1.PU = CDec(Me.txtcosto.Text)
                Dim t As Integer = CInt(Me.txtcantidad.Text)
                Dim c As Decimal = CDec(Me.txtcosto.Text)
                Dim r As Decimal = t * c
                detalle1.subtotal = r
                detalle1.pventa = CDec(Me.txtventa.Text)
                detalle1.IdAlmacen = CInt(Me.cboalmacen.SelectedValue)
                capaingresos.Registrardetalle(detalle1)
                Me.dgdetalle.DataSource = capaingresos.listardetalleporingreso(oo)
                Me.labmonto.Text = CStr(Sumar("subtotal", Me.dgdetalle))
            ElseIf actualidetalle = 2 Then
                Dim fila As Byte
                Dim i As Integer
                fila = CByte(Me.dgbusqueda.CurrentCell.RowIndex())
                i = CInt(CDec(Me.dgbusqueda.Item(0, fila).Value()))
                Dim detalle1 As New ingresodetalle
                detalle1.IdIngresosDet = valacdet
                detalle1.IdIngresos = i
                detalle1.IdProducto = CInt(CType(Me.cboproducto.SelectedValue.ToString, Integer?))
                detalle1.Cantidad = CDec(Me.txtcantidad.Text)
                detalle1.PU = CDec(Me.txtcosto.Text)
                Dim t As Integer = CInt(Me.txtcantidad.Text)
                Dim c As Decimal = CDec(Me.txtcosto.Text)
                Dim r As Decimal = t * c
                detalle1.subtotal = r
                detalle1.pventa = CDec(Me.txtventa.Text)
                detalle1.IdAlmacen = CInt(Me.cboalmacen.SelectedValue)
                capaingresos.actualizardetalle(detalle1)
                MsgBox("se actualizo la fila ")
                Dim oo As New ingreso
                oo.IdIngresos = i
                Me.dgdetalle.DataSource = capaingresos.listardetalleporingreso(oo)
                Me.labmonto.Text = CStr(Sumar("subtotal", Me.dgdetalle))
            Else
                Dim ee As Integer = CInt(CType(Me.cboproducto.SelectedValue.ToString, Integer?))
                Dim p As Decimal = CDec(Me.txtventa.Text)
                Dim t As Integer = CInt(Me.txtcantidad.Text)
                Dim c As Decimal = CDec(Me.txtcosto.Text)
                Dim r As Decimal = t * c
                Me.DataGridView1.Rows.Add(ee, Me.cboproducto.Text, t, c, p, r)
                Me.labmonto.Text = CStr(Sumar("subtotal", Me.DataGridView1))
            End If
            End If

    End Sub
    Private Sub grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grabar.Click
        If actuali = 1 Then
            Dim fila As Byte
            Dim i As Integer
            fila = CByte(Me.dgbusqueda.CurrentCell.RowIndex())
            i = CInt(CDec(Me.dgbusqueda.Item(0, fila).Value()))
            Dim ingreso1 As New ingreso
            ingreso1.IdIngresos = i
            ingreso1.IdAlmacen = CInt(CType(Me.cboalmacen.SelectedValue.ToString, Integer?))
            ingreso1.IdTrabjador = CInt(CType(Me.cbotrabajador.SelectedValue.ToString, Integer?))
            ingreso1.Fecha = Me.dtfecha.Value
            ingreso1.Serie = Me.txtserie.Text
            ingreso1.Numero = Me.txtnumero.Text
            Select Case Me.cbotipodocumento.Text
                Case Is = "Boleta"
                    ingreso1.TipDoc = 1
                Case Is = "Factura"
                    ingreso1.TipDoc = 2
                Case Is = "Guia"
                    ingreso1.TipDoc = 3
            End Select

            Select Case Me.cbotipopago.Text
                Case Is = "Contado"
                    ingreso1.ModoPago = 1
                Case Is = "Credito"
                    ingreso1.ModoPago = 2
                Case Is = "Letra"
                    ingreso1.ModoPago = 3
                Case Is = "Otros"
                    ingreso1.ModoPago = 4
            End Select

            ingreso1.IdProveedor = CInt(CType(Me.cboproveedor.SelectedValue.ToString, Integer?))
            ingreso1.estado = "1"
            ingreso1.valortotal = CDec(CType(Me.labmonto.Text, Decimal?))
            ingreso1.lote = Me.txtlote.Text()
            ingreso1.valortotal = CDec(Me.labmonto.Text)
            capaingresos.actualizaringreso(ingreso1)
            idultimoingreso()
            Dim filas As Integer = Me.DataGridView1.RowCount
            Dim q As Integer
            For q = 0 To filas - 1
                Dim detalle1 As New ingresodetalle
                detalle1.IdIngresos = ultimoid
                detalle1.IdProducto = CInt(Me.DataGridView1.Item(0, q).Value)
                detalle1.Cantidad = CInt(Me.DataGridView1.Item(2, q).Value)
                detalle1.PU = CDec(Me.DataGridView1.Item(3, q).Value)
                detalle1.subtotal = CDec(Me.DataGridView1.Item(4, q).Value)
                detalle1.pventa = CDec(Me.DataGridView1.Item(5, q).Value)
                detalle1.IdAlmacen = CInt(Me.cboalmacen.SelectedValue)
                capaingresos.actualizardetalle(detalle1)
                cargartodos()
            Next
            MsgBox("se grabo el ingreso registro")
            bgrabar()
            Me.dgdetalle.Visible = False
            Me.dgdetalle.Enabled = False
            Me.DataGridView1.Visible = True
        Else

            If Me.cboproducto.Text = "" Or Me.txtcosto.Text = "" Or Me.txtcantidad.Text = "" Then

                MsgBox("debe llenar por lo menos un nombre")

            Else
                If actuali <> 1 Then
                    Dim ingreso1 As New ingreso
                    ingreso1.IdAlmacen = CInt(CType(Me.cboalmacen.SelectedValue.ToString, Integer?))
                    ingreso1.IdTrabjador = CInt(CType(Me.cbotrabajador.SelectedValue.ToString, Integer?))
                    ingreso1.Fecha = Me.dtfecha.Value
                    ingreso1.Serie = Me.txtserie.Text
                    ingreso1.Numero = Me.txtnumero.Text

                    Select Case Me.cbotipodocumento.Text
                        Case Is = "Boleta"
                            ingreso1.TipDoc = 1
                        Case Is = "Factura"
                            ingreso1.TipDoc = 2
                        Case Is = "Guia"
                            ingreso1.TipDoc = 3
                    End Select

                    Select Case Me.cbotipopago.Text
                        Case Is = "Contado"
                            ingreso1.ModoPago = 1
                        Case Is = "Credito"
                            ingreso1.ModoPago = 2
                        Case Is = "Letra"
                            ingreso1.ModoPago = 3
                        Case Is = "Otros"
                            ingreso1.ModoPago = 4
                    End Select
                    ingreso1.IdProveedor = CInt(CType(Me.cboproveedor.SelectedValue.ToString, Integer?))


                    If Me.Chestado.Checked = True Then
                        ingreso1.estado = "1"
                    Else
                        ingreso1.estado = "0"
                    End If


                    ingreso1.valortotal = CDec(CType(Me.labmonto.Text, Decimal?))
                    ingreso1.lote = Me.txtlote.Text
                    capaingresos.Registraringreso(ingreso1)
                    idultimoingreso()
                    Dim filas As Integer = Me.DataGridView1.RowCount
                    Dim q As Integer
                    For q = 0 To filas - 1

                        Dim detalle1 As New ingresodetalle
                        detalle1.IdIngresos = ultimoid
                        detalle1.IdProducto = CInt(Me.DataGridView1.Item(0, q).Value)
                        detalle1.Cantidad = CInt(Me.DataGridView1.Item(2, q).Value)
                        detalle1.PU = CDec(Me.DataGridView1.Item(3, q).Value)
                        detalle1.subtotal = CDec(Me.DataGridView1.Item(4, q).Value)
                        detalle1.pventa = CDec(Me.DataGridView1.Item(5, q).Value)
                        detalle1.IdAlmacen = CInt(Me.cboalmacen.SelectedValue)
                        capaingresos.Registrardetalle(detalle1)
                    Next
                    MsgBox("se agrego el registro")

                End If
            End If
        End If
        bgrabar()
        cargartodos()
        Me.DataGridView1.Rows.Clear()
        muestrarapidadedetalles(1)
        Me.dgbusqueda.Enabled = True

        Me.dgdetalle.Enabled = False
        Me.dgdetalle.Visible = False
        Me.DataGridView1.Enabled = True
        Me.DataGridView1.Visible = True
        limpiarcabecera()
        limpiardetalle()
        actualidetalle = 0
    End Sub
    Private Sub botonbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botonbuscar.Click

        If Me.chfecha.Checked = False Then
        ElseIf Me.opproveedor.Checked = True Then
            Me.dgbusqueda.DataSource = capaingresos.listartodoslosingresosporproveedorconfecha(CInt(Me.cbobusqueda.SelectedValue), Me.datefechainicio.Value, Me.datefechafin.Value)
        ElseIf Me.opproducto.Checked = True Then
        End If

        If Me.opnumero.Checked = True Then
            Me.dgbusqueda.DataSource = capaingresos.listartodoslosingresospornumero(CStr(Me.txtdato.Text))
        End If


        If Me.opserie.Checked = True Then
            Me.dgbusqueda.DataSource = capaingresos.listartodoslosingresosporserie(CStr(Me.txtdato.Text))
        End If

        If Me.chfecha.Checked = True Then


        ElseIf Me.opproveedor.Checked = True Then
            Me.dgbusqueda.DataSource = capaingresos.listartodoslosingresosporproveedor(CInt(Me.cbobusqueda.SelectedValue))

        ElseIf Me.opproducto.Checked = True Then

        ElseIf Me.opnumero.Checked = True Then
        ElseIf Me.opserie.Checked = True Then

        End If
        Dim cant As Integer = Me.dgbusqueda.RowCount
        Me.Label17.Text = CStr(cant)
        btodos()
        btadicionar.Enabled = False
        Me.cboeliminardetalle.Enabled = False

    End Sub

    Private Sub editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editar.Click
        If Me.dgbusqueda.RowCount = 0 Then
            MsgBox("busque primero la ruta")
        Else
            Dim fila As Byte
            Dim i As Integer
            fila = CByte(Me.dgbusqueda.CurrentCell.RowIndex())
            Dim ingreso1 As IngresosObject

            i = CInt(CDec(Me.dgbusqueda.Item(0, fila).Value()))
            ingreso1 = IngresosMapper.Instance.GetOne(i)
            Me.cbotrabajador.SelectedValue = ingreso1.IdTrabjador
            Me.cboproveedor.SelectedValue = ingreso1.IdProveedor
            Me.cboalmacen.SelectedValue = ingreso1.IdAlmacen

            Select Case ingreso1.ModoPago
                Case Is = 1
                    Me.cbotipopago.Text = "boleta"
                Case Is = 2
                    Me.cbotipopago.Text = "factura"
                Case Is = 3
                    Me.cbotipopago.Text = "guia"
            End Select

            Select Case ingreso1.TipDoc
                Case Is = 1
                    Me.cbotipodocumento.Text = "contado"
                Case Is = 2
                    Me.cbotipodocumento.Text = "credito"
                Case Is = 3
                    Me.cbotipodocumento.Text = "letra"
                Case Is = 4
                    Me.cbotipodocumento.Text = "otros"
            End Select
            Me.txtlote.Text = ingreso1.lote
            Me.txtserie.Text = ingreso1.Serie
            Me.txtnumero.Text = ingreso1.Numero
            Me.labmonto.Text = CStr(ingreso1.valortotal)
            actuali = 1
            actualidetalle = 1
            Dim aa As New ingreso
            aa.IdIngresos = i
            det = capaingresos.listardetalleporingreso(aa)
            Me.dgdetalle.DataSource = det
            muestrarapidadedetalles(0)
            Me.dgbusqueda.Enabled = False
            Me.btadicionar.Enabled = True
            habilitarcabecera()
            habilitardetalle()
            btadicionar.Enabled = True
            Me.cboeliminardetalle.Enabled = True
            Me.grabar.Enabled = True
        End If
        beditar()
    End Sub
    Private Sub todos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles todos.Click
        cargartodos()
        btodos()
        Dim cant As Integer = Me.dgbusqueda.RowCount
        Me.Label17.Text = CStr(cant)
        eliminar.Enabled = True
        actualidetalle = 0
    End Sub
    
    Private Sub nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nuevo.Click
        Me.DataGridView1.Enabled = True
        bnuevo()
        limpiarcabecera()
        limpiardetalle()
        habilitarcabecera()
        habilitardetalle()
        cboeliminardetalle.Enabled = True
        btadicionar.Enabled = True
        Me.dgdetalle.Enabled = False
        actualidetalle = 0
    End Sub

    Private Sub eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eliminar.Click

        If Me.dgbusqueda.RowCount = 0 Then
            MsgBox("no existen registros a eliminar")
        Else
            Dim fila As Byte
            Dim i As Integer
            fila = CByte(Me.dgbusqueda.CurrentCell.RowIndex())
            'Dim ingresos2 As Ingresos
            i = CInt(CDec(Me.dgbusqueda.Item(0, fila).Value()))

            IngresosDetMapper.Instance.DeleteByIngresos(i)
            IngresosMapper.Instance.Delete(i)

            '            ingresos2.IdIngresos = CInt(i)
            '           capaingresos.eliminardetalleporingreso(i)
            '          capaingresos.eliminaringreso(i)
            MsgBox("ingreso y detalle eliminado")
            cargartodos()
            actualidetalle = 0

        End If
    End Sub
    Private Sub cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelar.Click
        binicio()
        Me.DataGridView1.DataSource = ""
        limpiarcabecera()
        limpiardetalle()
        Me.dgbusqueda.Enabled = True
        actualidetalle = 0

    End Sub

    Private Sub dgbusqueda_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgbusqueda.CellContentClick
        muestrarapidadedetalles(1)
        Me.dgdetalle.Visible = True
        Me.dgdetalle.Enabled = True
        Me.DataGridView1.Visible = False
        Me.DataGridView1.Enabled = False
    End Sub

    Private Sub opproveedor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opproveedor.CheckedChanged
        cargarcombonombreproveedor(Me.cbobusqueda)
    End Sub
    Private Sub opproducto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opproducto.CheckedChanged
        cargarcombonombreproducto(cbobusqueda)
    End Sub
    Private Sub cboeliminardetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboeliminardetalle.Click
        If Me.dgdetalle.RowCount = 0 Then
            MsgBox("no existen detalles")
        Else
            If actualidetalle = 1 Then

                Dim fila As Byte
                Dim i As Integer
                fila = CByte(Me.dgdetalle.CurrentCell.RowIndex())
                Dim ingresodetalle1 As ingresodetalle
                i = CInt(CDec(Me.dgdetalle.Item(0, fila).Value()))
                IngresosDetMapper.Instance.Delete(i)
                Dim fila1 As Byte
                Dim ii As Integer
                fila1 = CByte(Me.dgbusqueda.CurrentCell.RowIndex())
                Dim ingreso1 As ingreso
                ii = CInt(CDec(Me.dgbusqueda.Item(0, fila1).Value()))
                capaingresos.listarsolodetalleporidingreso(ii)
                Me.dgdetalle.DataSource = capaingresos.listarsolodetalleporidingreso(ii)
                Me.labmonto.Text = CStr(Sumar("subtotal", Me.dgdetalle))
            ElseIf actualidetalle = 2 Then

            ElseIf actualidetalle = 0 Then
            Else

                'solo sin datos recuperados
                DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
                Me.labmonto.Text = CStr(Sumar("subtotal", Me.dgdetalle))
            End If
            beditar()
            Me.grabar.Enabled = True
        End If
    End Sub
    Private Sub dgdetalle_RowStateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowStateChangedEventArgs)
        Me.labmonto.Text = CStr(Sumar("subtotal", Me.dgdetalle))
    End Sub
    Private Sub GenerarColumnas()
        arrCols(0) = New DataGridViewTextBoxColumn() 'Creación del Objeto de Columna en la posición '0' del Arreglo.
        arrCols(0).HeaderText = "Id" 'Texto de Cabecera de la Columna.
        arrCols(0).Name = "ID" 'Nombre de la Columna dentro del DataGridView.
        arrCols(0).Width = 20 'Ancho de la Columna dentro del DataGridView.

        arrCols(1) = New DataGridViewTextBoxColumn()
        arrCols(1).HeaderText = "Producto"
        arrCols(1).Name = "Producto"
        arrCols(1).Width = 80

        arrCols(2) = New DataGridViewTextBoxColumn()
        arrCols(2).HeaderText = "cantidad"
        arrCols(2).Name = "Cantidad"
        arrCols(2).Width = 80

        arrCols(3) = New DataGridViewTextBoxColumn()
        arrCols(3).HeaderText = "Precuni"
        arrCols(3).Name = "Pre_Uni"
        arrCols(3).Width = 80

        arrCols(4) = New DataGridViewTextBoxColumn()
        arrCols(4).HeaderText = "prec_vta"
        arrCols(4).Name = "Prec_Vta"
        arrCols(4).Width = 80

        arrCols(5) = New DataGridViewTextBoxColumn()
        arrCols(5).HeaderText = "subtotal"
        arrCols(5).Name = ""
        arrCols(5).Width = 80

        Me.DataGridView1.Columns.AddRange(arrCols) 'Agregamos el conjunto de Columnas al DataGridView.
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.DataGridView1.DataSource = ""
        'Dim ee As Integer = CInt(CType(Me.cboproducto.SelectedValue.ToString, Integer?))
        'Dim p As Decimal = CDec(Me.txtventa.Text)
        'Dim t As Integer = CInt(Me.txtcantidad.Text)
        'Dim c As Decimal = CDec(Me.txtcosto.Text)
        'Dim r As Decimal = t * c
        'Dim arrDatos() As Object = {ee, p, t, c, r} 'Creamos un nuevo arreglo con los datos a agregar.

        'Me.DataGridView1.Rows.Add(arrDatos) 'Agregamos el arreglo de datos a las filas de la Grilla.
    End Sub
    Private Sub DataGridView1_RowStateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowStateChangedEventArgs)
        Me.labmonto.Text = CStr(Sumar("subtotal", Me.DataGridView1))
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        If Me.dgdetalle.RowCount = 0 Then
            MsgBox("no existen detalles")
        Else

            'Crer dataset para exportar
            Dim dset As New DataSet
            'add table to dataset
            dset.Tables.Add()
            'agregar columnas a la tabla
            For i As Integer = 0 To dgbusqueda.ColumnCount - 1
                dset.Tables(0).Columns.Add(dgbusqueda.Columns(i).HeaderText)
            Next
            'agregar filas a la tabla
            Dim dr1 As DataRow
            For i As Integer = 0 To dgbusqueda.RowCount - 1
                dr1 = dset.Tables(0).NewRow
                For j As Integer = 0 To dgbusqueda.Columns.Count - 1
                    dr1(j) = dgbusqueda.Rows(i).Cells(j).Value
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

        If Me.dgdetalle.RowCount = 0 Then
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
    Private Sub dgdetalle_CellContentClick_2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgdetalle.CellContentClick
        If Me.dgdetalle.RowCount = 0 Then
            MsgBox("no existen detalles")
        Else

            Dim fila As Byte
            Dim i As Integer
            fila = CByte(Me.dgdetalle.CurrentCell.RowIndex())
            Dim detalleingreso1 As IngresosDet
            i = CInt(CDec(Me.dgdetalle.Item(0, fila).Value()))
            detalleingreso1 = IngresosDetMapper.Instance.GetOne(i)
            Me.cboproducto.SelectedValue = detalleingreso1.IdProducto
            Me.txtcantidad.Text = CStr(detalleingreso1.Cantidad)
            Me.txtcosto.Text = CStr(detalleingreso1.PU)
            Me.txtventa.Text = CStr(detalleingreso1.pventa)
            Me.DataGridView1.Enabled = False
            Me.dgbusqueda.Enabled = False
            valacdet = i
            actualidetalle = 2
        End If
    End Sub

    Private Sub txtcantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcantidad.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    
End Class
    

