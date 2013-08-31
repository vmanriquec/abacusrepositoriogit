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
Public Class gestionguias
    Dim actuali, actualidetalle, ultimoid, e, cb1 As Integer
    Dim mRow As Integer = 0
    Dim newpage As Boolean = True
    Dim caden, cadena As String
    Dim fecha1, fecha2 As Date
    Dim idprov As Integer
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
        Me.dgbusqueda.DataSource = capaguias.listartodoslasguias
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
    Public Shared Sub cargarcombonombrecliente(ByVal cbo As ComboBox)
        Try
            cbo.DataSource = ClientesMapper.cargarnombreclientecombo
            cbo.DisplayMember = "nombre"
            cbo.ValueMember = "IdCliente"
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
    Private Function Sumar( _
        ByVal nombre_Columna As String, _
        ByVal Dgv As DataGridView) As Decimal
        Dim total As Decimal = 0
        ' recorrer las filas y obtener los items de la columna indicada en "nombre_Columna"  
        Try
            For i As Integer = 0 To Dgv.RowCount - 1
                total = CDec(total + CDec(Dgv.Item(nombre_Columna.ToLower, i).Value))
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
    Private Sub idultimaguia()
        Dim cn As New SqlClient.SqlConnection(cox)
        caden = ("SELECT max(Idguias) FROM guias")
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
                MsgBox("busque primero la ruta")
            Else
                Dim fila As Byte
                Dim i As Integer
                fila = CByte(Me.dgbusqueda.CurrentCell.RowIndex())
                Dim guia1 As Guias
                i = CInt(CDec(Me.dgbusqueda.Item(0, fila).Value()))
                Me.dgdetalle.DataSource = capaguias.listardetalleporidguia(i)
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
       
        Me.cboproducto.Text = ""
        'Me.txtobservaciones.Text = ""
    End Sub
    Private Sub limpiarcabecera()
        Me.cboalmacen.Text = ""
        Me.cboproducto.Text = ""
        Me.cbcliente.Text = ""
        Me.cbotrabajador.Text = ""
        Me.txtserie.Text = ""
        Me.txtnumero.Text = ""
        Me.txtpuntollegada.Text = ""
    End Sub
    Private Sub habilitarcabecera()
        Me.cboalmacen.Enabled = True
        Me.cboproducto.Enabled = True
        Me.cbcliente.Enabled = True
        Me.cbotrabajador.Enabled = True
        Me.txtserie.Enabled = True
        Me.txtnumero.Enabled = True
        Me.txtpuntollegada.Enabled = True

    End Sub
    Private Sub habilitardetalle()
        Me.txtcantidad.Enabled = True
        Me.cboproducto.Enabled = True
    End Sub
    Private Sub inhabilitarcabecera()
        Me.cboalmacen.Enabled = False
        Me.cboproducto.Enabled = False
        Me.cbcliente.Enabled = False
        Me.cbotrabajador.Enabled = False
        Me.txtserie.Enabled = False
        Me.txtnumero.Enabled = False
        Me.txtpuntollegada.Enabled = False
    End Sub
    Private Sub inhabilitardetalle()
        Me.txtcantidad.Enabled = False
        Me.cboproducto.Enabled = False
    End Sub
    Private Sub nuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiarcabecera()
        actuali = 0
    End Sub

    Private Sub gestiondeingresos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cb1 = 0
        Me.cboalmacenllegada.Enabled = False
        Me.cboalmacenllegada.Visible = False
        cargarcombonombrecliente(cbcliente)
        cargarcombonombreproducto(cboproducto)
        cargarcombonombretrabajador(cbotrabajador)
        cargarcomboalmacen(cboalmacen)
        cargarcomboalmacen(cboalmacenllegada)
        limpiarcabecera()
        limpiardetalle()
        inhabilitarcabecera()
        inhabilitardetalle()
        binicio()
    End Sub

    Private Sub cboagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btadicionar.Click

        If txtcantidad.Text = "" Then

            MsgBox("debe llenar alguna cantidad ")
        Else
            If actualidetalle = 1 Then
                Dim fila As Byte
                Dim i As Integer
                fila = CByte(Me.dgbusqueda.CurrentCell.RowIndex())
                i = CInt(CDec(Me.dgbusqueda.Item(0, fila).Value()))
                Dim oo As New guia
                oo.IdGuias = i
                Dim guiasdet1 As New guiadetalles
                guiasdet1.IdGuiasDet = i
                guiasdet1.idproducto = CInt(CType(Me.cboproducto.SelectedValue.ToString, Integer?))
                guiasdet1.cantidad = CInt(CDec(Me.txtcantidad.Text))
                guiasdet1.IdTienda = CInt(Me.cboalmacen.SelectedValue)
                capaguias.Registrardetalle(guiasdet1)
                Me.dgdetalle.DataSource = capaguias.listardetalleporidguia(i)
            Else
                Dim ee As Integer = CInt(CType(Me.cboproducto.SelectedValue.ToString, Integer?))
                Dim t As Integer = CInt(Me.txtcantidad.Text)
                Dim r As Integer = CInt(CType(Me.cboalmacen.SelectedValue.ToString, Integer?))
                Dim w As Integer = CInt(CType(Me.cboalmacenllegada.SelectedValue.ToString, Integer?))
                Me.DataGridView1.Rows.Add(ee, Me.cboproducto.Text, t, r, w)
            End If
        End If
    End Sub

    Private Sub grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grabar.Click
        If actuali = 1 And actualidetalle = 1 Then
            Dim fila As Byte
            Dim i As Integer
            fila = CByte(Me.dgbusqueda.CurrentCell.RowIndex())
            i = CInt(CDec(Me.dgbusqueda.Item(0, fila).Value()))
            Dim guia1 As New guia
            guia1.IdGuias = i
            guia1.idalmacen = CInt(CType(Me.cboalmacen.SelectedValue.ToString, Integer?))
            guia1.idtrabajador = CInt(CType(Me.cbotrabajador.SelectedValue.ToString, Integer?))
            guia1.FecTraslado = Me.dtfecha.Value
            guia1.sguia = Me.txtserie.Text
            guia1.nguia = CInt(Me.txtnumero.Text)
            guia1.nfactura = Me.txtfactura.Text
            guia1.idcliente = CInt(CType(Me.cbcliente.SelectedValue.ToString, Integer?))

            If Me.chestado.Checked = True Then
                guia1.estado = "1"
            Else
                guia1.estado = "0"
            End If
            If cbotipomovimiento.Text = "entre_almacenes" Then
                guia1.puntopartida = Me.cboalmacenllegada.Text
            Else
                guia1.puntopartida = Me.txtpuntollegada.Text
            End If
            guia1.EspecOtros = Me.cbotipomovimiento.Text
            guia1.ObsAnulado = Me.txtobservacion.Text

            capaguias.actualizarguia(guia1)
            idultimaguia()

            Dim filas As Integer = Me.DataGridView1.RowCount
            Dim q As Integer
            For q = 0 To filas - 1

                Dim guiad1 As New guiadetalles
                guiad1.IdGuias = ultimoid
                guiad1.idproducto = CInt(Me.DataGridView1.Item(0, q).Value)
                guiad1.cantidad = CInt(Me.DataGridView1.Item(2, q).Value)
                guiad1.IdTienda = CInt(Me.cboalmacen.SelectedValue)
                guiad1.idllegada = CInt(Me.cboalmacenllegada.SelectedValue)
                capaguias.actualizardetalleguia(guiad1)
                cargartodos()
            Next
            MsgBox("se actualizo registro")
        Else

            If Me.cboproducto.Text = "" Then

                MsgBox("debe llenar por lo menos un nombre")

            Else
                If actuali <> 1 Then
                    Dim guia1 As New guia
                    guia1.idalmacen = CInt(CType(Me.cboalmacen.SelectedValue.ToString, Integer?))
                    guia1.idtrabajador = CInt(CType(Me.cbotrabajador.SelectedValue.ToString, Integer?))
                    guia1.FecTraslado = Me.dtfecha.Value
                    guia1.sguia = Me.txtserie.Text
                    guia1.nguia = CInt(Me.txtnumero.Text)
                    guia1.nfactura = Me.txtfactura.Text
                    guia1.idcliente = CInt(CType(Me.cbcliente.SelectedValue.ToString, Integer?))
                    If Me.chestado.Checked = True Then
                        guia1.estado = "1"
                    Else
                        guia1.estado = "0"
                    End If
                    If cbotipomovimiento.Text = "entre_almacenes" Then
                        guia1.puntopartida = Me.cboalmacenllegada.Text
                    Else
                        guia1.puntopartida = Me.txtpuntollegada.Text
                    End If
                    guia1.EspecOtros = Me.cbotipomovimiento.Text
                    guia1.ObsAnulado = Me.txtobservacion.Text

                    capaguias.Registrarguias(guia1)
                    idultimaguia()
                    Dim filas As Integer = Me.DataGridView1.RowCount
                    Dim q As Integer
                    For q = 0 To filas - 1

                        Dim guiad1 As New guiadetalles
                        guiad1.IdGuias = ultimoid
                        guiad1.idproducto = CInt(Me.DataGridView1.Item(0, q).Value)
                        guiad1.cantidad = CInt(Me.DataGridView1.Item(2, q).Value)
                        guiad1.IdTienda = CInt(Me.cboalmacen.SelectedValue)
                        guiad1.idllegada = CInt(Me.cboalmacenllegada.SelectedValue)
                        capaguias.Registrardetalle(guiad1)
                    Next
                    MsgBox("se agrego el registro")
                End If
            End If
        End If
        bgrabar()
        cargartodos()
        'muestrarapidadedetalles(1)
        Me.dgbusqueda.Enabled = True
        Me.DataGridView1.DataSource = ""
        limpiarcabecera()
        limpiardetalle()

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
            i = CInt(CDec(Me.dgbusqueda.Item(0, fila).Value()))
            Dim st As DataRow
            st = capaguias.listarguiagetone(i)
            Me.cboalmacen.SelectedValue = CInt(st.Item("IdAlmacen"))
            Me.dtfecha.Value = CDate(st.Item("FecTraslado"))
            Me.txtserie.Text = CStr(CInt(st.Item("SGuia")))
            Me.txtnumero.Text = CStr(CInt(st.Item("NGuia")))
            Me.txtfactura.Text = CStr(CInt(st.Item("NFactura")))
            Me.cbcliente.Text = CStr(st.Item("cliente"))

            If CStr(st.Item("estado")) = "1" Then
                Me.chestado.Checked = True
            Else
                Me.chestado.Checked = False
            End If
            cbotipomovimiento.Text = CStr(st.Item("EspecOtros"))
            Me.txtobservacion.Text = CStr(st.Item("observacion"))
            Me.cbotrabajador.Text = CStr(st.Item("trabajador"))
            Me.txtpuntollegada.Text = CStr(st.Item("Punto_llegada"))
            actuali = 1
            actualidetalle = 1
            Dim aa As New guia
            aa.IdGuias = i
            det = capaguias.listardetalleporidguia(i)
            Me.dgdetalle.DataSource = det
            muestrarapidadedetalles(0)
            Me.dgbusqueda.Enabled = False
            Me.btadicionar.Enabled = True
            habilitarcabecera()
            habilitardetalle()
            btadicionar.Enabled = True
            Me.cboeliminardetalle.Enabled = True
            Me.grabar.Enabled = True
            Me.cboalmacenllegada.Visible = True
            Me.cboalmacenllegada.Enabled = True
            If cboalmacen.Text = "entre_almacenes" Then
                cb1 = 0
            Else
                cb1 = 1

            End If
        End If
    End Sub
    Private Sub todos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles todos.Click
        cargartodos()
        btodos()
        Dim cant As Integer = Me.dgbusqueda.RowCount
        Me.Label17.Text = CStr(cant)
        eliminar.Enabled = True
    End Sub
    Private Sub dgdetalle_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        If Me.dgdetalle.RowCount = 0 Then
            MsgBox("no existen detalles")
        Else
            Dim fila As Byte
            Dim i As Integer
            fila = CByte(Me.dgdetalle.CurrentCell.RowIndex())
            Dim detalleguia1 As GuiasDet
            i = CInt(CDec(Me.dgdetalle.Item(0, fila).Value()))
            detalleguia1 = GuiasDetMapper.Instance.GetOne(i)


            Me.cboproducto.SelectedValue = detalleguia1.IdProducto
            Me.txtcantidad.Text = CStr(detalleguia1.Cantidad)
            Me.cboalmacen.SelectedValue = detalleguia1.IdTienda
            actualidetalle = 1
            Me.DataGridView1.Enabled = False
            Me.dgbusqueda.Enabled = False
            Me.btadicionar.Enabled = False
        End If

    End Sub

    Private Sub nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nuevo.Click
        Me.DataGridView1.Enabled = True
        cb1 = 1
        bnuevo()
        limpiarcabecera()
        limpiardetalle()
        habilitarcabecera()
        habilitardetalle()
        cboeliminardetalle.Enabled = True
        btadicionar.Enabled = True
        Me.dgdetalle.Enabled = False
        Me.cboalmacenllegada.Visible = False
    End Sub

    Private Sub eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eliminar.Click

        If Me.dgbusqueda.RowCount = 0 Then
            MsgBox("no existen registros a eliminar")
        Else
            Dim fila As Byte
            Dim i As Integer
            fila = CByte(Me.dgbusqueda.CurrentCell.RowIndex())

            Dim guia1 As guia
            i = CInt(CDec(Me.dgbusqueda.Item(0, fila).Value()))
            capaguias.eliminardetalleporguia(i)
            capaguias.eliminarguia(i)
            MsgBox("ingreso y detalle eliminado")
        End If
    End Sub
    Private Sub cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelar.Click
        binicio()
        Me.DataGridView1.DataSource = ""
        limpiarcabecera()
        limpiardetalle()
    End Sub

    Private Sub dgbusqueda_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgbusqueda.CellContentClick
        muestrarapidadedetalles(1)
        Me.dgdetalle.Visible = True
        Me.dgdetalle.Enabled = True
        Me.DataGridView1.Visible = False
        Me.DataGridView1.Enabled = False
    End Sub
    Private Sub dgdetalle_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgdetalle.CellContentClick
        If Me.dgdetalle.RowCount = 0 Then
            MsgBox("no existen detalles")
        Else
            Dim fila As Byte
            Dim i As Integer
            fila = CByte(Me.dgdetalle.CurrentCell.RowIndex())
            Dim detalleguia1 As GuiasDet
            i = CInt(CDec(Me.dgdetalle.Item(0, fila).Value()))
            detalleguia1 = GuiasDetMapper.Instance.GetOne(i)
            Me.cboproducto.SelectedValue = detalleguia1.IdProducto
            Me.txtcantidad.Text = CStr(detalleguia1.Cantidad)
            Me.cboalmacen.SelectedValue = detalleguia1.IdTienda
            Me.DataGridView1.Enabled = False
            Me.dgbusqueda.Enabled = False
        End If
    End Sub

    'Private Sub opproveedor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opproveedor.CheckedChanged, CheckBoxX5.CheckedChanged, CheckBoxX4.CheckedChanged, CheckBoxX2.CheckedChanged, CheckBoxX1.CheckedChanged
    '    cargarcombonombreproveedor(Me.cbobusqueda)

    'End Sub
    'Private Sub opproducto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opproducto.CheckedChanged, CheckBoxX3.CheckedChanged
    '    cargarcombonombreproducto(cbobusqueda)
    'End Sub
    Private Sub cboeliminardetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboeliminardetalle.Click
        If Me.dgdetalle.RowCount = 0 Then
            MsgBox("no existen detalles")
        Else
            If actualidetalle = 1 Then

                Dim fila As Byte
                Dim i As Integer
                fila = CByte(Me.dgdetalle.CurrentCell.RowIndex())

                Dim ingresoguia1 As GuiasDet
                i = CInt(CDec(Me.dgdetalle.Item(0, fila).Value()))
                GuiasDetMapper.Instance.Delete(i)
                Dim fila1 As Byte
                Dim ii As Integer
                fila1 = CByte(Me.dgbusqueda.CurrentCell.RowIndex())
                Dim guia1 As Guias
                ii = CInt(CDec(Me.dgbusqueda.Item(0, fila1).Value()))
                capaguias.listardetalleporidguia(ii)
                Me.dgdetalle.DataSource = capaguias.listardetalleporidguia(ii)
            Else
                'solo sin datos recuperados
                DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
            End If
            beditar()
            Me.grabar.Enabled = True
        End If
    End Sub
    Private Sub dgdetalle_RowStateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowStateChangedEventArgs) Handles dgdetalle.RowStateChanged
        Me.labcantidadarticulos.Text = CStr(Sumar("cantidad", Me.dgdetalle))
    End Sub
    
    Private Sub DataGridView1_RowStateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowStateChangedEventArgs) Handles DataGridView1.RowStateChanged
        Me.labcantidadarticulos.Text = CStr(Sumar("cantidad", Me.DataGridView1))
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
    Private Sub cbotipomovimiento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbotipomovimiento.SelectedIndexChanged

        If cb1 = 1 Then
            If Me.cbotipomovimiento.Text = "entre_almacenes" Then
                Me.cboalmacenllegada.Enabled = True
                Me.cboalmacenllegada.Visible = True
                Me.txtpuntollegada.Visible = False
                Me.txtpuntollegada.Text = "ee"
            Else
                Me.cboalmacenllegada.Enabled = False
                Me.cboalmacenllegada.Visible = False
                Me.txtpuntollegada.Visible = True
                Me.txtpuntollegada.Text = ""
            End If


        Else


        End If

    End Sub

    Private Sub labcantidadarticulos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles labcantidadarticulos.Click

    End Sub
End Class