﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gestiondeingresos2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelEx1 = New Stimulsoft.Controls.Win.DotNetBar.PanelEx()
        Me.dgdetalle = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombrepro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pventa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonX3 = New Stimulsoft.Controls.Win.DotNetBar.ButtonX()
        Me.ButtonX2 = New Stimulsoft.Controls.Win.DotNetBar.ButtonX()
        Me.GroupPanel3 = New Stimulsoft.Controls.Win.DotNetBar.Controls.GroupPanel()
        Me.Chestado = New System.Windows.Forms.CheckBox()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.labmonto = New System.Windows.Forms.Label()
        Me.txtlote = New System.Windows.Forms.TextBox()
        Me.txtserie = New System.Windows.Forms.TextBox()
        Me.cbotrabajador = New System.Windows.Forms.ComboBox()
        Me.cbotipopago = New System.Windows.Forms.ComboBox()
        Me.cboalmacen = New System.Windows.Forms.ComboBox()
        Me.cbotipodocumento = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtfecha = New System.Windows.Forms.DateTimePicker()
        Me.cboproveedor = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupPanel2 = New Stimulsoft.Controls.Win.DotNetBar.Controls.GroupPanel()
        Me.cboeliminardetalle = New Stimulsoft.Controls.Win.DotNetBar.ButtonX()
        Me.btadicionar = New Stimulsoft.Controls.Win.DotNetBar.ButtonX()
        Me.txtventa = New System.Windows.Forms.TextBox()
        Me.txtcosto = New System.Windows.Forms.TextBox()
        Me.cboproducto = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupPanel1 = New Stimulsoft.Controls.Win.DotNetBar.Controls.GroupPanel()
        Me.cancelar = New Stimulsoft.Controls.Win.DotNetBar.ButtonX()
        Me.todos = New Stimulsoft.Controls.Win.DotNetBar.ButtonX()
        Me.imprimir_datagrid = New Stimulsoft.Controls.Win.DotNetBar.ButtonX()
        Me.editar = New Stimulsoft.Controls.Win.DotNetBar.ButtonX()
        Me.eliminar = New Stimulsoft.Controls.Win.DotNetBar.ButtonX()
        Me.grabar = New Stimulsoft.Controls.Win.DotNetBar.ButtonX()
        Me.nuevo = New Stimulsoft.Controls.Win.DotNetBar.ButtonX()
        Me.PanelEx2 = New Stimulsoft.Controls.Win.DotNetBar.PanelEx()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dgbusqueda = New Stimulsoft.Controls.Win.DotNetBar.Controls.DataGridViewX()
        Me.ExpandablePanel1 = New Stimulsoft.Controls.Win.DotNetBar.ExpandablePanel()
        Me.cbobusqueda = New System.Windows.Forms.ComboBox()
        Me.chfecha = New System.Windows.Forms.CheckBox()
        Me.botonbuscar = New Stimulsoft.Controls.Win.DotNetBar.ButtonX()
        Me.cboestado = New Stimulsoft.Controls.Win.DotNetBar.Controls.ComboBoxEx()
        Me.datefechafin = New System.Windows.Forms.DateTimePicker()
        Me.txtdato = New Stimulsoft.Controls.Win.DotNetBar.Controls.TextBoxX()
        Me.datefechainicio = New System.Windows.Forms.DateTimePicker()
        Me.opproveedor = New Stimulsoft.Controls.Win.DotNetBar.Controls.CheckBoxX()
        Me.opserie = New Stimulsoft.Controls.Win.DotNetBar.Controls.CheckBoxX()
        Me.opnumero = New Stimulsoft.Controls.Win.DotNetBar.Controls.CheckBoxX()
        Me.opproducto = New Stimulsoft.Controls.Win.DotNetBar.Controls.CheckBoxX()
        Me.LabelX3 = New Stimulsoft.Controls.Win.DotNetBar.LabelX()
        Me.LabelX4 = New Stimulsoft.Controls.Win.DotNetBar.LabelX()
        Me.LabelX2 = New Stimulsoft.Controls.Win.DotNetBar.LabelX()
        Me.IngresosObjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BalloonTip1 = New Stimulsoft.Controls.Win.DotNetBar.BalloonTip()
        Me.PanelEx1.SuspendLayout()
        CType(Me.dgdetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel3.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        CType(Me.dgbusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ExpandablePanel1.SuspendLayout()
        CType(Me.IngresosObjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = Stimulsoft.Controls.Win.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.dgdetalle)
        Me.PanelEx1.Controls.Add(Me.DataGridView1)
        Me.PanelEx1.Controls.Add(Me.ButtonX3)
        Me.PanelEx1.Controls.Add(Me.ButtonX2)
        Me.PanelEx1.Controls.Add(Me.GroupPanel3)
        Me.PanelEx1.Controls.Add(Me.GroupPanel2)
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(610, 544)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = Stimulsoft.Controls.Win.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'dgdetalle
        '
        Me.dgdetalle.AllowUserToAddRows = False
        Me.dgdetalle.AllowUserToDeleteRows = False
        Me.dgdetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdetalle.Location = New System.Drawing.Point(9, 265)
        Me.dgdetalle.Name = "dgdetalle"
        Me.dgdetalle.ReadOnly = True
        Me.dgdetalle.Size = New System.Drawing.Size(541, 267)
        Me.dgdetalle.TabIndex = 30
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProducto, Me.nombrepro, Me.cantidad, Me.pu, Me.pventa, Me.subtotal})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 265)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(538, 251)
        Me.DataGridView1.TabIndex = 29
        '
        'IdProducto
        '
        Me.IdProducto.HeaderText = "idproducto"
        Me.IdProducto.Name = "IdProducto"
        Me.IdProducto.ReadOnly = True
        Me.IdProducto.Width = 82
        '
        'nombrepro
        '
        Me.nombrepro.HeaderText = "producto"
        Me.nombrepro.Name = "nombrepro"
        Me.nombrepro.ReadOnly = True
        Me.nombrepro.Width = 74
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        Me.cantidad.Width = 73
        '
        'pu
        '
        Me.pu.HeaderText = "Prec. Uni"
        Me.pu.Name = "pu"
        Me.pu.ReadOnly = True
        Me.pu.Width = 76
        '
        'pventa
        '
        Me.pventa.HeaderText = "Pre. Venta"
        Me.pventa.Name = "pventa"
        Me.pventa.ReadOnly = True
        Me.pventa.Width = 82
        '
        'subtotal
        '
        Me.subtotal.HeaderText = "subtotal"
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        Me.subtotal.Width = 69
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = Stimulsoft.Controls.Win.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Image = Global.abacus.My.Resources.Resources._1377399061_pdf
        Me.ButtonX3.Location = New System.Drawing.Point(560, 379)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(32, 38)
        Me.ButtonX3.TabIndex = 28
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = Stimulsoft.Controls.Win.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Image = Global.abacus.My.Resources.Resources._1377398986_File_XLS_Excel
        Me.ButtonX2.Location = New System.Drawing.Point(555, 326)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(42, 45)
        Me.ButtonX2.TabIndex = 27
        '
        'GroupPanel3
        '
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = Stimulsoft.Controls.Win.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.Chestado)
        Me.GroupPanel3.Controls.Add(Me.txtnumero)
        Me.GroupPanel3.Controls.Add(Me.labmonto)
        Me.GroupPanel3.Controls.Add(Me.txtlote)
        Me.GroupPanel3.Controls.Add(Me.txtserie)
        Me.GroupPanel3.Controls.Add(Me.cbotrabajador)
        Me.GroupPanel3.Controls.Add(Me.cbotipopago)
        Me.GroupPanel3.Controls.Add(Me.cboalmacen)
        Me.GroupPanel3.Controls.Add(Me.cbotipodocumento)
        Me.GroupPanel3.Controls.Add(Me.Label2)
        Me.GroupPanel3.Controls.Add(Me.Label6)
        Me.GroupPanel3.Controls.Add(Me.Label8)
        Me.GroupPanel3.Controls.Add(Me.Label4)
        Me.GroupPanel3.Controls.Add(Me.Label13)
        Me.GroupPanel3.Controls.Add(Me.Label14)
        Me.GroupPanel3.Controls.Add(Me.Label5)
        Me.GroupPanel3.Controls.Add(Me.Label3)
        Me.GroupPanel3.Controls.Add(Me.dtfecha)
        Me.GroupPanel3.Controls.Add(Me.cboproveedor)
        Me.GroupPanel3.Controls.Add(Me.Label7)
        Me.GroupPanel3.Controls.Add(Me.Label9)
        Me.GroupPanel3.Location = New System.Drawing.Point(4, 5)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(544, 187)
        '
        '
        '
        Me.GroupPanel3.Style.BackColor2SchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel3.Style.BackColorGradientAngle = 90
        Me.GroupPanel3.Style.BackColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel3.Style.BorderBottom = Stimulsoft.Controls.Win.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderBottomWidth = 1
        Me.GroupPanel3.Style.BorderColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel3.Style.BorderLeft = Stimulsoft.Controls.Win.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderLeftWidth = 1
        Me.GroupPanel3.Style.BorderRight = Stimulsoft.Controls.Win.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderRightWidth = 1
        Me.GroupPanel3.Style.BorderTop = Stimulsoft.Controls.Win.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderTopWidth = 1
        Me.GroupPanel3.Style.CornerDiameter = 4
        Me.GroupPanel3.Style.CornerType = Stimulsoft.Controls.Win.DotNetBar.eCornerType.Rounded
        Me.GroupPanel3.Style.TextAlignment = Stimulsoft.Controls.Win.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel3.Style.TextColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel3.Style.TextLineAlignment = Stimulsoft.Controls.Win.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel3.TabIndex = 26
        '
        'Chestado
        '
        Me.Chestado.AutoSize = True
        Me.Chestado.Location = New System.Drawing.Point(397, 84)
        Me.Chestado.Name = "Chestado"
        Me.Chestado.Size = New System.Drawing.Size(59, 17)
        Me.Chestado.TabIndex = 20
        Me.Chestado.Text = "Estado"
        Me.Chestado.UseVisualStyleBackColor = True
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(333, 145)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(77, 20)
        Me.txtnumero.TabIndex = 19
        '
        'labmonto
        '
        Me.labmonto.BackColor = System.Drawing.Color.Orange
        Me.labmonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labmonto.ForeColor = System.Drawing.Color.White
        Me.labmonto.Location = New System.Drawing.Point(396, 29)
        Me.labmonto.Name = "labmonto"
        Me.labmonto.Size = New System.Drawing.Size(122, 33)
        Me.labmonto.TabIndex = 17
        Me.labmonto.Text = "Monto Total"
        '
        'txtlote
        '
        Me.txtlote.Location = New System.Drawing.Point(268, 79)
        Me.txtlote.Name = "txtlote"
        Me.txtlote.Size = New System.Drawing.Size(79, 20)
        Me.txtlote.TabIndex = 19
        '
        'txtserie
        '
        Me.txtserie.Location = New System.Drawing.Point(448, 145)
        Me.txtserie.Name = "txtserie"
        Me.txtserie.Size = New System.Drawing.Size(70, 20)
        Me.txtserie.TabIndex = 19
        '
        'cbotrabajador
        '
        Me.cbotrabajador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbotrabajador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbotrabajador.FormattingEnabled = True
        Me.cbotrabajador.Location = New System.Drawing.Point(62, 3)
        Me.cbotrabajador.Name = "cbotrabajador"
        Me.cbotrabajador.Size = New System.Drawing.Size(299, 21)
        Me.cbotrabajador.TabIndex = 18
        '
        'cbotipopago
        '
        Me.cbotipopago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbotipopago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbotipopago.FormattingEnabled = True
        Me.cbotipopago.Items.AddRange(New Object() {"Contado", "Credito", "Letra", "Otros"})
        Me.cbotipopago.Location = New System.Drawing.Point(62, 117)
        Me.cbotipopago.Name = "cbotipopago"
        Me.cbotipopago.Size = New System.Drawing.Size(154, 21)
        Me.cbotipopago.TabIndex = 18
        '
        'cboalmacen
        '
        Me.cboalmacen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboalmacen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboalmacen.FormattingEnabled = True
        Me.cboalmacen.Items.AddRange(New Object() {"Boleta", "Factura", "Guia"})
        Me.cboalmacen.Location = New System.Drawing.Point(62, 80)
        Me.cboalmacen.Name = "cboalmacen"
        Me.cboalmacen.Size = New System.Drawing.Size(160, 21)
        Me.cboalmacen.TabIndex = 18
        '
        'cbotipodocumento
        '
        Me.cbotipodocumento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbotipodocumento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbotipodocumento.FormattingEnabled = True
        Me.cbotipodocumento.Items.AddRange(New Object() {"Boleta", "Factura", "Guia"})
        Me.cbotipodocumento.Location = New System.Drawing.Point(92, 145)
        Me.cbotipodocumento.Name = "cbotipodocumento"
        Me.cbotipodocumento.Size = New System.Drawing.Size(160, 21)
        Me.cbotipodocumento.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Trabajador"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(-3, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Tipo Pago"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(386, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Monto Total :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(288, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Numero"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(4, 83)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 13)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Almacen"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(238, 82)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(24, 13)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "lote"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(0, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Tipo Documento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(416, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Serie"
        '
        'dtfecha
        '
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecha.Location = New System.Drawing.Point(333, 117)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(185, 20)
        Me.dtfecha.TabIndex = 15
        '
        'cboproveedor
        '
        Me.cboproveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboproveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboproveedor.FormattingEnabled = True
        Me.cboproveedor.Location = New System.Drawing.Point(62, 41)
        Me.cboproveedor.Name = "cboproveedor"
        Me.cboproveedor.Size = New System.Drawing.Size(299, 21)
        Me.cboproveedor.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(252, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Fecha Registro"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(0, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Proveedor"
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = Stimulsoft.Controls.Win.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.cboeliminardetalle)
        Me.GroupPanel2.Controls.Add(Me.btadicionar)
        Me.GroupPanel2.Controls.Add(Me.txtventa)
        Me.GroupPanel2.Controls.Add(Me.txtcosto)
        Me.GroupPanel2.Controls.Add(Me.cboproducto)
        Me.GroupPanel2.Controls.Add(Me.Label1)
        Me.GroupPanel2.Controls.Add(Me.txtcantidad)
        Me.GroupPanel2.Controls.Add(Me.Label11)
        Me.GroupPanel2.Controls.Add(Me.Label10)
        Me.GroupPanel2.Controls.Add(Me.Label12)
        Me.GroupPanel2.Location = New System.Drawing.Point(7, 198)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(541, 61)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = Stimulsoft.Controls.Win.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = Stimulsoft.Controls.Win.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = Stimulsoft.Controls.Win.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = Stimulsoft.Controls.Win.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = Stimulsoft.Controls.Win.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = Stimulsoft.Controls.Win.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = Stimulsoft.Controls.Win.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel2.TabIndex = 22
        '
        'cboeliminardetalle
        '
        Me.cboeliminardetalle.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cboeliminardetalle.ColorTable = Stimulsoft.Controls.Win.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cboeliminardetalle.Image = Global.abacus.My.Resources.Resources.edit_remove
        Me.cboeliminardetalle.Location = New System.Drawing.Point(421, 11)
        Me.cboeliminardetalle.Name = "cboeliminardetalle"
        Me.cboeliminardetalle.Size = New System.Drawing.Size(44, 37)
        Me.cboeliminardetalle.TabIndex = 21
        '
        'btadicionar
        '
        Me.btadicionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btadicionar.ColorTable = Stimulsoft.Controls.Win.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btadicionar.Image = Global.abacus.My.Resources.Resources.edit_add
        Me.btadicionar.Location = New System.Drawing.Point(371, 11)
        Me.btadicionar.Name = "btadicionar"
        Me.btadicionar.Size = New System.Drawing.Size(44, 37)
        Me.btadicionar.TabIndex = 21
        '
        'txtventa
        '
        Me.txtventa.Location = New System.Drawing.Point(300, 30)
        Me.txtventa.Name = "txtventa"
        Me.txtventa.Size = New System.Drawing.Size(65, 20)
        Me.txtventa.TabIndex = 19
        '
        'txtcosto
        '
        Me.txtcosto.Location = New System.Drawing.Point(170, 30)
        Me.txtcosto.Name = "txtcosto"
        Me.txtcosto.Size = New System.Drawing.Size(73, 20)
        Me.txtcosto.TabIndex = 19
        '
        'cboproducto
        '
        Me.cboproducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboproducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboproducto.FormattingEnabled = True
        Me.cboproducto.Location = New System.Drawing.Point(58, 3)
        Me.cboproducto.Name = "cboproducto"
        Me.cboproducto.Size = New System.Drawing.Size(307, 21)
        Me.cboproducto.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Producto"
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(53, 30)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(61, 20)
        Me.txtcantidad.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(120, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "P Costo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(-2, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Cantidad"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(249, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "P Venta"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.Yellow
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = Stimulsoft.Controls.Win.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.cancelar)
        Me.GroupPanel1.Controls.Add(Me.todos)
        Me.GroupPanel1.Controls.Add(Me.imprimir_datagrid)
        Me.GroupPanel1.Controls.Add(Me.editar)
        Me.GroupPanel1.Controls.Add(Me.eliminar)
        Me.GroupPanel1.Controls.Add(Me.grabar)
        Me.GroupPanel1.Controls.Add(Me.nuevo)
        Me.GroupPanel1.Location = New System.Drawing.Point(554, 5)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(46, 421)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = Stimulsoft.Controls.Win.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = Stimulsoft.Controls.Win.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = Stimulsoft.Controls.Win.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = Stimulsoft.Controls.Win.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = Stimulsoft.Controls.Win.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = Stimulsoft.Controls.Win.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = Stimulsoft.Controls.Win.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel1.TabIndex = 11
        '
        'cancelar
        '
        Me.cancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cancelar.ColorTable = Stimulsoft.Controls.Win.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cancelar.Image = Global.abacus.My.Resources.Resources._error
        Me.cancelar.Location = New System.Drawing.Point(-1, 263)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(41, 45)
        Me.cancelar.TabIndex = 23
        '
        'todos
        '
        Me.todos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.todos.ColorTable = Stimulsoft.Controls.Win.DotNetBar.eButtonColor.OrangeWithBackground
        Me.todos.Image = Global.abacus.My.Resources.Resources.kaboodleloop
        Me.todos.Location = New System.Drawing.Point(5, 89)
        Me.todos.Name = "todos"
        Me.todos.Size = New System.Drawing.Size(34, 38)
        Me.todos.TabIndex = 22
        '
        'imprimir_datagrid
        '
        Me.imprimir_datagrid.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.imprimir_datagrid.ColorTable = Stimulsoft.Controls.Win.DotNetBar.eButtonColor.OrangeWithBackground
        Me.imprimir_datagrid.Image = Global.abacus.My.Resources.Resources._1376806550_print_32
        Me.imprimir_datagrid.Location = New System.Drawing.Point(5, 219)
        Me.imprimir_datagrid.Name = "imprimir_datagrid"
        Me.imprimir_datagrid.Size = New System.Drawing.Size(34, 38)
        Me.imprimir_datagrid.TabIndex = 0
        '
        'editar
        '
        Me.editar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.editar.ColorTable = Stimulsoft.Controls.Win.DotNetBar.eButtonColor.OrangeWithBackground
        Me.editar.Image = Global.abacus.My.Resources.Resources._1376862975_profile_edit
        Me.editar.Location = New System.Drawing.Point(5, 133)
        Me.editar.Name = "editar"
        Me.editar.Size = New System.Drawing.Size(34, 38)
        Me.editar.TabIndex = 0
        '
        'eliminar
        '
        Me.eliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.eliminar.ColorTable = Stimulsoft.Controls.Win.DotNetBar.eButtonColor.OrangeWithBackground
        Me.eliminar.Image = Global.abacus.My.Resources.Resources._1376862824_human_trashcan_full_new
        Me.eliminar.Location = New System.Drawing.Point(5, 177)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(34, 38)
        Me.eliminar.TabIndex = 0
        '
        'grabar
        '
        Me.grabar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.grabar.ColorTable = Stimulsoft.Controls.Win.DotNetBar.eButtonColor.OrangeWithBackground
        Me.grabar.Image = Global.abacus.My.Resources.Resources._1376862745_Gnome_Document_Save_32
        Me.grabar.Location = New System.Drawing.Point(5, 45)
        Me.grabar.Name = "grabar"
        Me.grabar.Size = New System.Drawing.Size(34, 38)
        Me.grabar.TabIndex = 0
        '
        'nuevo
        '
        Me.nuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.nuevo.ColorTable = Stimulsoft.Controls.Win.DotNetBar.eButtonColor.OrangeWithBackground
        Me.nuevo.Image = Global.abacus.My.Resources.Resources._1376862496_appointment_new
        Me.nuevo.Location = New System.Drawing.Point(5, 1)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(34, 38)
        Me.nuevo.TabIndex = 0
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Window
        Me.PanelEx2.ColorSchemeStyle = Stimulsoft.Controls.Win.DotNetBar.eDotNetBarStyle.VS2005
        Me.PanelEx2.Controls.Add(Me.Label16)
        Me.PanelEx2.Controls.Add(Me.Label17)
        Me.PanelEx2.Controls.Add(Me.Label15)
        Me.PanelEx2.Controls.Add(Me.dgbusqueda)
        Me.PanelEx2.Controls.Add(Me.ExpandablePanel1)
        Me.PanelEx2.Location = New System.Drawing.Point(616, 0)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(734, 538)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = Stimulsoft.Controls.Win.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 25
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label16.Location = New System.Drawing.Point(590, 515)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(117, 20)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "coincidencias"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Yellow
        Me.Label17.Location = New System.Drawing.Point(555, 515)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(19, 20)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label15.Location = New System.Drawing.Point(406, 515)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(143, 20)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Se encontraron :"
        '
        'dgbusqueda
        '
        Me.dgbusqueda.AllowUserToAddRows = False
        Me.dgbusqueda.AllowUserToDeleteRows = False
        Me.dgbusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgbusqueda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgbusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgbusqueda.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgbusqueda.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgbusqueda.Location = New System.Drawing.Point(7, 97)
        Me.dgbusqueda.Name = "dgbusqueda"
        Me.dgbusqueda.ReadOnly = True
        Me.dgbusqueda.Size = New System.Drawing.Size(722, 415)
        Me.dgbusqueda.TabIndex = 24
        '
        'ExpandablePanel1
        '
        Me.ExpandablePanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.ExpandablePanel1.ColorSchemeStyle = Stimulsoft.Controls.Win.DotNetBar.eDotNetBarStyle.Office2007
        Me.ExpandablePanel1.Controls.Add(Me.cbobusqueda)
        Me.ExpandablePanel1.Controls.Add(Me.chfecha)
        Me.ExpandablePanel1.Controls.Add(Me.botonbuscar)
        Me.ExpandablePanel1.Controls.Add(Me.cboestado)
        Me.ExpandablePanel1.Controls.Add(Me.datefechafin)
        Me.ExpandablePanel1.Controls.Add(Me.txtdato)
        Me.ExpandablePanel1.Controls.Add(Me.datefechainicio)
        Me.ExpandablePanel1.Controls.Add(Me.opproveedor)
        Me.ExpandablePanel1.Controls.Add(Me.opserie)
        Me.ExpandablePanel1.Controls.Add(Me.opnumero)
        Me.ExpandablePanel1.Controls.Add(Me.opproducto)
        Me.ExpandablePanel1.Controls.Add(Me.LabelX3)
        Me.ExpandablePanel1.Controls.Add(Me.LabelX4)
        Me.ExpandablePanel1.Controls.Add(Me.LabelX2)
        Me.ExpandablePanel1.Location = New System.Drawing.Point(6, 4)
        Me.ExpandablePanel1.Name = "ExpandablePanel1"
        Me.ExpandablePanel1.Size = New System.Drawing.Size(723, 85)
        Me.ExpandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.Style.BackColor1.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel1.Style.BackColor2.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel1.Style.Border = Stimulsoft.Controls.Win.DotNetBar.eBorderType.SingleLine
        Me.ExpandablePanel1.Style.BorderColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.ExpandablePanel1.Style.ForeColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandablePanel1.Style.GradientAngle = 90
        Me.ExpandablePanel1.TabIndex = 23
        Me.ExpandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.TitleStyle.BackColor1.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel1.TitleStyle.BackColor2.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel1.TitleStyle.Border = Stimulsoft.Controls.Win.DotNetBar.eBorderType.RaisedInner
        Me.ExpandablePanel1.TitleStyle.BorderColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandablePanel1.TitleStyle.ForeColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelText
        Me.ExpandablePanel1.TitleStyle.GradientAngle = 90
        Me.ExpandablePanel1.TitleText = "Busqueda Rapida"
        '
        'cbobusqueda
        '
        Me.cbobusqueda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbobusqueda.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbobusqueda.FormattingEnabled = True
        Me.cbobusqueda.Location = New System.Drawing.Point(158, 30)
        Me.cbobusqueda.Name = "cbobusqueda"
        Me.cbobusqueda.Size = New System.Drawing.Size(230, 21)
        Me.cbobusqueda.TabIndex = 25
        '
        'chfecha
        '
        Me.chfecha.AutoSize = True
        Me.chfecha.Location = New System.Drawing.Point(601, 58)
        Me.chfecha.Name = "chfecha"
        Me.chfecha.Size = New System.Drawing.Size(53, 17)
        Me.chfecha.TabIndex = 24
        Me.chfecha.Text = "fecha"
        Me.chfecha.UseVisualStyleBackColor = True
        '
        'botonbuscar
        '
        Me.botonbuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.botonbuscar.ColorTable = Stimulsoft.Controls.Win.DotNetBar.eButtonColor.OrangeWithBackground
        Me.botonbuscar.Image = Global.abacus.My.Resources.Resources.openterm
        Me.botonbuscar.Location = New System.Drawing.Point(660, 33)
        Me.botonbuscar.Name = "botonbuscar"
        Me.botonbuscar.Size = New System.Drawing.Size(53, 39)
        Me.botonbuscar.TabIndex = 8
        '
        'cboestado
        '
        Me.cboestado.DisplayMember = "Text"
        Me.cboestado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboestado.FormattingEnabled = True
        Me.cboestado.ItemHeight = 14
        Me.cboestado.Location = New System.Drawing.Point(417, 56)
        Me.cboestado.Name = "cboestado"
        Me.cboestado.Size = New System.Drawing.Size(174, 20)
        Me.cboestado.TabIndex = 7
        '
        'datefechafin
        '
        Me.datefechafin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datefechafin.Location = New System.Drawing.Point(246, 58)
        Me.datefechafin.Name = "datefechafin"
        Me.datefechafin.Size = New System.Drawing.Size(115, 20)
        Me.datefechafin.TabIndex = 6
        '
        'txtdato
        '
        '
        '
        '
        Me.txtdato.Border.Class = "TextBoxBorder"
        Me.txtdato.Location = New System.Drawing.Point(519, 32)
        Me.txtdato.Name = "txtdato"
        Me.txtdato.Size = New System.Drawing.Size(135, 20)
        Me.txtdato.TabIndex = 4
        '
        'datefechainicio
        '
        Me.datefechainicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datefechainicio.Location = New System.Drawing.Point(68, 55)
        Me.datefechainicio.Name = "datefechainicio"
        Me.datefechainicio.Size = New System.Drawing.Size(108, 20)
        Me.datefechainicio.TabIndex = 5
        '
        'opproveedor
        '
        Me.opproveedor.CheckBoxStyle = Stimulsoft.Controls.Win.DotNetBar.eCheckBoxStyle.RadioButton
        Me.opproveedor.Location = New System.Drawing.Point(1, 30)
        Me.opproveedor.Name = "opproveedor"
        Me.opproveedor.Size = New System.Drawing.Size(77, 23)
        Me.opproveedor.TabIndex = 1
        Me.opproveedor.Text = "Proveedor"
        '
        'opserie
        '
        Me.opserie.CheckBoxStyle = Stimulsoft.Controls.Win.DotNetBar.eCheckBoxStyle.RadioButton
        Me.opserie.Location = New System.Drawing.Point(469, 27)
        Me.opserie.Name = "opserie"
        Me.opserie.Size = New System.Drawing.Size(44, 23)
        Me.opserie.TabIndex = 1
        Me.opserie.Text = "serie"
        '
        'opnumero
        '
        Me.opnumero.CheckBoxStyle = Stimulsoft.Controls.Win.DotNetBar.eCheckBoxStyle.RadioButton
        Me.opnumero.Location = New System.Drawing.Point(404, 27)
        Me.opnumero.Name = "opnumero"
        Me.opnumero.Size = New System.Drawing.Size(69, 23)
        Me.opnumero.TabIndex = 1
        Me.opnumero.Text = "numero"
        '
        'opproducto
        '
        Me.opproducto.CheckBoxStyle = Stimulsoft.Controls.Win.DotNetBar.eCheckBoxStyle.RadioButton
        Me.opproducto.Location = New System.Drawing.Point(77, 29)
        Me.opproducto.Name = "opproducto"
        Me.opproducto.Size = New System.Drawing.Size(75, 23)
        Me.opproducto.TabIndex = 1
        Me.opproducto.Text = "Producto"
        '
        'LabelX3
        '
        Me.LabelX3.Location = New System.Drawing.Point(1, 52)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(70, 23)
        Me.LabelX3.TabIndex = 3
        Me.LabelX3.Text = "Fecha Inicio"
        '
        'LabelX4
        '
        Me.LabelX4.Location = New System.Drawing.Point(367, 56)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(56, 19)
        Me.LabelX4.TabIndex = 3
        Me.LabelX4.Text = "Estado"
        '
        'LabelX2
        '
        Me.LabelX2.Location = New System.Drawing.Point(182, 56)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(60, 23)
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "Fecha Fin"
        '
        'IngresosObjectBindingSource
        '
        Me.IngresosObjectBindingSource.DataSource = GetType(abacusRules.Objects.IngresosObject)
        '
        'gestiondeingresos2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1347, 544)
        Me.Controls.Add(Me.PanelEx2)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "gestiondeingresos2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "gestiondeingresos"
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.dgdetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel3.ResumeLayout(False)
        Me.GroupPanel3.PerformLayout()
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel2.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        CType(Me.dgbusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ExpandablePanel1.ResumeLayout(False)
        Me.ExpandablePanel1.PerformLayout()
        CType(Me.IngresosObjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As Stimulsoft.Controls.Win.DotNetBar.PanelEx
    Friend WithEvents dtfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboproveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupPanel1 As Stimulsoft.Controls.Win.DotNetBar.Controls.GroupPanel
    Friend WithEvents imprimir_datagrid As Stimulsoft.Controls.Win.DotNetBar.ButtonX
    Friend WithEvents editar As Stimulsoft.Controls.Win.DotNetBar.ButtonX
    Friend WithEvents eliminar As Stimulsoft.Controls.Win.DotNetBar.ButtonX
    Friend WithEvents grabar As Stimulsoft.Controls.Win.DotNetBar.ButtonX
    Friend WithEvents nuevo As Stimulsoft.Controls.Win.DotNetBar.ButtonX
    Friend WithEvents cboproducto As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbotrabajador As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtserie As System.Windows.Forms.TextBox
    Friend WithEvents txtnumero As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbotipopago As System.Windows.Forms.ComboBox
    Friend WithEvents cbotipodocumento As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btadicionar As Stimulsoft.Controls.Win.DotNetBar.ButtonX
    Friend WithEvents Chestado As System.Windows.Forms.CheckBox
    Friend WithEvents labmonto As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboeliminardetalle As Stimulsoft.Controls.Win.DotNetBar.ButtonX
    Friend WithEvents todos As Stimulsoft.Controls.Win.DotNetBar.ButtonX
    Friend WithEvents txtventa As System.Windows.Forms.TextBox
    Friend WithEvents txtcosto As System.Windows.Forms.TextBox
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboalmacen As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupPanel2 As Stimulsoft.Controls.Win.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtlote As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ExpandablePanel1 As Stimulsoft.Controls.Win.DotNetBar.ExpandablePanel
    Friend WithEvents chfecha As System.Windows.Forms.CheckBox
    Friend WithEvents botonbuscar As Stimulsoft.Controls.Win.DotNetBar.ButtonX
    Friend WithEvents cboestado As Stimulsoft.Controls.Win.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents datefechafin As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtdato As Stimulsoft.Controls.Win.DotNetBar.Controls.TextBoxX
    Friend WithEvents datefechainicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents opproveedor As Stimulsoft.Controls.Win.DotNetBar.Controls.CheckBoxX
    Friend WithEvents opnumero As Stimulsoft.Controls.Win.DotNetBar.Controls.CheckBoxX
    Friend WithEvents opproducto As Stimulsoft.Controls.Win.DotNetBar.Controls.CheckBoxX
    Friend WithEvents LabelX3 As Stimulsoft.Controls.Win.DotNetBar.LabelX
    Friend WithEvents LabelX4 As Stimulsoft.Controls.Win.DotNetBar.LabelX
    Friend WithEvents LabelX2 As Stimulsoft.Controls.Win.DotNetBar.LabelX
    Friend WithEvents dgbusqueda As Stimulsoft.Controls.Win.DotNetBar.Controls.DataGridViewX
    Friend WithEvents opserie As Stimulsoft.Controls.Win.DotNetBar.Controls.CheckBoxX
    Friend WithEvents PanelEx2 As Stimulsoft.Controls.Win.DotNetBar.PanelEx
    Friend WithEvents cancelar As Stimulsoft.Controls.Win.DotNetBar.ButtonX
    Friend WithEvents GroupPanel3 As Stimulsoft.Controls.Win.DotNetBar.Controls.GroupPanel
    Friend WithEvents cbobusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ButtonX2 As Stimulsoft.Controls.Win.DotNetBar.ButtonX
    Friend WithEvents ButtonX3 As Stimulsoft.Controls.Win.DotNetBar.ButtonX
    Friend WithEvents IngresosObjectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dgdetalle As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IdProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombrepro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pventa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BalloonTip1 As Stimulsoft.Controls.Win.DotNetBar.BalloonTip
End Class
