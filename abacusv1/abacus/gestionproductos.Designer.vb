<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gestionproductos
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelEx1 = New Stimulsoft.Controls.Win.DotNetBar.PanelEx()
        Me.cboalmacen = New System.Windows.Forms.ComboBox()
        Me.ButtonX4 = New Stimulsoft.Controls.Win.DotNetBar.ButtonX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonX2 = New Stimulsoft.Controls.Win.DotNetBar.ButtonX()
        Me.chestado = New System.Windows.Forms.CheckBox()
        Me.dtfechacaducidad = New System.Windows.Forms.DateTimePicker()
        Me.dtfecharegistro = New System.Windows.Forms.DateTimePicker()
        Me.picimagen = New System.Windows.Forms.PictureBox()
        Me.cbounidadmedida = New System.Windows.Forms.ComboBox()
        Me.cboproveedor = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbocategoria = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtprecioventa = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtpreciocosto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtobservaciones = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcapacidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupPanel1 = New Stimulsoft.Controls.Win.DotNetBar.Controls.GroupPanel()
        Me.ButtonX3 = New Stimulsoft.Controls.Win.DotNetBar.ButtonX()
        Me.imprimir_datagrid = New Stimulsoft.Controls.Win.DotNetBar.ButtonX()
        Me.ButtonX1 = New Stimulsoft.Controls.Win.DotNetBar.ButtonX()
        Me.todos = New Stimulsoft.Controls.Win.DotNetBar.ButtonX()
        Me.editar = New Stimulsoft.Controls.Win.DotNetBar.ButtonX()
        Me.eliminar = New Stimulsoft.Controls.Win.DotNetBar.ButtonX()
        Me.grabar = New Stimulsoft.Controls.Win.DotNetBar.ButtonX()
        Me.nuevo = New Stimulsoft.Controls.Win.DotNetBar.ButtonX()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.PanelEx1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picimagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = Stimulsoft.Controls.Win.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.cboalmacen)
        Me.PanelEx1.Controls.Add(Me.ButtonX4)
        Me.PanelEx1.Controls.Add(Me.PictureBox1)
        Me.PanelEx1.Controls.Add(Me.DataGridView1)
        Me.PanelEx1.Controls.Add(Me.ButtonX2)
        Me.PanelEx1.Controls.Add(Me.chestado)
        Me.PanelEx1.Controls.Add(Me.dtfechacaducidad)
        Me.PanelEx1.Controls.Add(Me.dtfecharegistro)
        Me.PanelEx1.Controls.Add(Me.picimagen)
        Me.PanelEx1.Controls.Add(Me.cbounidadmedida)
        Me.PanelEx1.Controls.Add(Me.cboproveedor)
        Me.PanelEx1.Controls.Add(Me.Label11)
        Me.PanelEx1.Controls.Add(Me.cbocategoria)
        Me.PanelEx1.Controls.Add(Me.Label7)
        Me.PanelEx1.Controls.Add(Me.txtprecioventa)
        Me.PanelEx1.Controls.Add(Me.Label13)
        Me.PanelEx1.Controls.Add(Me.Label6)
        Me.PanelEx1.Controls.Add(Me.txtpreciocosto)
        Me.PanelEx1.Controls.Add(Me.Label5)
        Me.PanelEx1.Controls.Add(Me.txtobservaciones)
        Me.PanelEx1.Controls.Add(Me.Label4)
        Me.PanelEx1.Controls.Add(Me.Label12)
        Me.PanelEx1.Controls.Add(Me.Label10)
        Me.PanelEx1.Controls.Add(Me.Label9)
        Me.PanelEx1.Controls.Add(Me.Label8)
        Me.PanelEx1.Controls.Add(Me.Label3)
        Me.PanelEx1.Controls.Add(Me.txtcodigo)
        Me.PanelEx1.Controls.Add(Me.Label14)
        Me.PanelEx1.Controls.Add(Me.txtcapacidad)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.txtnombre)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(941, 536)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = Stimulsoft.Controls.Win.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'cboalmacen
        '
        Me.cboalmacen.FormattingEnabled = True
        Me.cboalmacen.Location = New System.Drawing.Point(73, 87)
        Me.cboalmacen.Name = "cboalmacen"
        Me.cboalmacen.Size = New System.Drawing.Size(149, 21)
        Me.cboalmacen.TabIndex = 13
        '
        'ButtonX4
        '
        Me.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX4.ColorTable = Stimulsoft.Controls.Win.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX4.Image = Global.abacus.My.Resources.Resources.symantec_norton_icono_9047_32
        Me.ButtonX4.Location = New System.Drawing.Point(733, 14)
        Me.ButtonX4.Name = "ButtonX4"
        Me.ButtonX4.Size = New System.Drawing.Size(118, 30)
        Me.ButtonX4.TabIndex = 12
        Me.ButtonX4.Text = "Generar QR"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.abacus.My.Resources.Resources.unnamed
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(716, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(135, 129)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 256)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Size = New System.Drawing.Size(765, 268)
        Me.DataGridView1.TabIndex = 10
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = Stimulsoft.Controls.Win.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Image = Global.abacus.My.Resources.Resources._1376867913_kview
        Me.ButtonX2.Location = New System.Drawing.Point(491, 38)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(39, 31)
        Me.ButtonX2.TabIndex = 8
        '
        'chestado
        '
        Me.chestado.AutoSize = True
        Me.chestado.Location = New System.Drawing.Point(278, 204)
        Me.chestado.Name = "chestado"
        Me.chestado.Size = New System.Drawing.Size(59, 17)
        Me.chestado.TabIndex = 6
        Me.chestado.Text = "Estado"
        Me.chestado.UseVisualStyleBackColor = True
        '
        'dtfechacaducidad
        '
        Me.dtfechacaducidad.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfechacaducidad.Location = New System.Drawing.Point(330, 217)
        Me.dtfechacaducidad.Name = "dtfechacaducidad"
        Me.dtfechacaducidad.Size = New System.Drawing.Size(106, 20)
        Me.dtfechacaducidad.TabIndex = 5
        '
        'dtfecharegistro
        '
        Me.dtfecharegistro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecharegistro.Location = New System.Drawing.Point(109, 217)
        Me.dtfecharegistro.Name = "dtfecharegistro"
        Me.dtfecharegistro.Size = New System.Drawing.Size(110, 20)
        Me.dtfecharegistro.TabIndex = 5
        '
        'picimagen
        '
        Me.picimagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picimagen.Image = Global.abacus.My.Resources.Resources._1376797454_download_box_blue
        Me.picimagen.Location = New System.Drawing.Point(536, 38)
        Me.picimagen.Name = "picimagen"
        Me.picimagen.Size = New System.Drawing.Size(171, 142)
        Me.picimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picimagen.TabIndex = 4
        Me.picimagen.TabStop = False
        '
        'cbounidadmedida
        '
        Me.cbounidadmedida.FormattingEnabled = True
        Me.cbounidadmedida.Items.AddRange(New Object() {"Ml", "Gr", "Kg", "l", "Tn", "Mt", "Cm", "mm"})
        Me.cbounidadmedida.Location = New System.Drawing.Point(259, 161)
        Me.cbounidadmedida.Name = "cbounidadmedida"
        Me.cbounidadmedida.Size = New System.Drawing.Size(78, 21)
        Me.cbounidadmedida.TabIndex = 3
        '
        'cboproveedor
        '
        Me.cboproveedor.FormattingEnabled = True
        Me.cboproveedor.Location = New System.Drawing.Point(74, 48)
        Me.cboproveedor.Name = "cboproveedor"
        Me.cboproveedor.Size = New System.Drawing.Size(380, 21)
        Me.cboproveedor.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(233, 219)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Fecha Caducidad"
        '
        'cbocategoria
        '
        Me.cbocategoria.FormattingEnabled = True
        Me.cbocategoria.Location = New System.Drawing.Point(307, 90)
        Me.cbocategoria.Name = "cbocategoria"
        Me.cbocategoria.Size = New System.Drawing.Size(180, 21)
        Me.cbocategoria.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 217)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Fecha Registro"
        '
        'txtprecioventa
        '
        Me.txtprecioventa.Location = New System.Drawing.Point(467, 167)
        Me.txtprecioventa.Name = "txtprecioventa"
        Me.txtprecioventa.Size = New System.Drawing.Size(63, 20)
        Me.txtprecioventa.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 90)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Almacen"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(399, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Prec. Venta"
        '
        'txtpreciocosto
        '
        Me.txtpreciocosto.Location = New System.Drawing.Point(466, 141)
        Me.txtpreciocosto.Name = "txtpreciocosto"
        Me.txtpreciocosto.Size = New System.Drawing.Size(64, 20)
        Me.txtpreciocosto.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(398, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Prec. Costo"
        '
        'txtobservaciones
        '
        Me.txtobservaciones.Location = New System.Drawing.Point(530, 208)
        Me.txtobservaciones.Multiline = True
        Me.txtobservaciones.Name = "txtobservaciones"
        Me.txtobservaciones.Size = New System.Drawing.Size(321, 42)
        Me.txtobservaciones.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(448, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "observaciones"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(554, 192)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Imagen"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(488, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Imagen"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Proveedor"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(162, 165)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "unidad de medida"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(244, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Categoria"
        '
        'txtcapacidad
        '
        Me.txtcapacidad.Location = New System.Drawing.Point(74, 162)
        Me.txtcapacidad.Name = "txtcapacidad"
        Me.txtcapacidad.Size = New System.Drawing.Size(82, 20)
        Me.txtcapacidad.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "capacidad"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(73, 14)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(381, 20)
        Me.txtnombre.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "nombre"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = Stimulsoft.Controls.Win.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.ButtonX3)
        Me.GroupPanel1.Controls.Add(Me.imprimir_datagrid)
        Me.GroupPanel1.Controls.Add(Me.ButtonX1)
        Me.GroupPanel1.Controls.Add(Me.todos)
        Me.GroupPanel1.Controls.Add(Me.editar)
        Me.GroupPanel1.Controls.Add(Me.eliminar)
        Me.GroupPanel1.Controls.Add(Me.grabar)
        Me.GroupPanel1.Controls.Add(Me.nuevo)
        Me.GroupPanel1.Location = New System.Drawing.Point(879, 3)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(50, 387)
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
        Me.GroupPanel1.TabIndex = 0
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = Stimulsoft.Controls.Win.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Image = Global.abacus.My.Resources.Resources._1377399061_pdf
        Me.ButtonX3.Location = New System.Drawing.Point(9, 321)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(32, 38)
        Me.ButtonX3.TabIndex = 30
        '
        'imprimir_datagrid
        '
        Me.imprimir_datagrid.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.imprimir_datagrid.ColorTable = Stimulsoft.Controls.Win.DotNetBar.eButtonColor.OrangeWithBackground
        Me.imprimir_datagrid.Image = Global.abacus.My.Resources.Resources._1376806550_print_32
        Me.imprimir_datagrid.Location = New System.Drawing.Point(3, 226)
        Me.imprimir_datagrid.Name = "imprimir_datagrid"
        Me.imprimir_datagrid.Size = New System.Drawing.Size(34, 38)
        Me.imprimir_datagrid.TabIndex = 0
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = Stimulsoft.Controls.Win.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Image = Global.abacus.My.Resources.Resources._1377398986_File_XLS_Excel
        Me.ButtonX1.Location = New System.Drawing.Point(3, 270)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(42, 45)
        Me.ButtonX1.TabIndex = 29
        '
        'todos
        '
        Me.todos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.todos.ColorTable = Stimulsoft.Controls.Win.DotNetBar.eButtonColor.OrangeWithBackground
        Me.todos.Image = Global.abacus.My.Resources.Resources.kaboodleloop
        Me.todos.Location = New System.Drawing.Point(3, 182)
        Me.todos.Name = "todos"
        Me.todos.Size = New System.Drawing.Size(34, 38)
        Me.todos.TabIndex = 0
        '
        'editar
        '
        Me.editar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.editar.ColorTable = Stimulsoft.Controls.Win.DotNetBar.eButtonColor.OrangeWithBackground
        Me.editar.Image = Global.abacus.My.Resources.Resources._1376862975_profile_edit
        Me.editar.Location = New System.Drawing.Point(3, 138)
        Me.editar.Name = "editar"
        Me.editar.Size = New System.Drawing.Size(34, 38)
        Me.editar.TabIndex = 0
        '
        'eliminar
        '
        Me.eliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.eliminar.ColorTable = Stimulsoft.Controls.Win.DotNetBar.eButtonColor.OrangeWithBackground
        Me.eliminar.Image = Global.abacus.My.Resources.Resources._1376862824_human_trashcan_full_new
        Me.eliminar.Location = New System.Drawing.Point(3, 94)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(34, 38)
        Me.eliminar.TabIndex = 0
        '
        'grabar
        '
        Me.grabar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.grabar.ColorTable = Stimulsoft.Controls.Win.DotNetBar.eButtonColor.OrangeWithBackground
        Me.grabar.Image = Global.abacus.My.Resources.Resources._1376862745_Gnome_Document_Save_32
        Me.grabar.Location = New System.Drawing.Point(3, 50)
        Me.grabar.Name = "grabar"
        Me.grabar.Size = New System.Drawing.Size(34, 38)
        Me.grabar.TabIndex = 0
        '
        'nuevo
        '
        Me.nuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.nuevo.ColorTable = Stimulsoft.Controls.Win.DotNetBar.eButtonColor.OrangeWithBackground
        Me.nuevo.Image = Global.abacus.My.Resources.Resources._1376862496_appointment_new
        Me.nuevo.Location = New System.Drawing.Point(3, 6)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(34, 38)
        Me.nuevo.TabIndex = 0
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(11, 132)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Codigo"
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(74, 132)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(307, 20)
        Me.txtcodigo.TabIndex = 2
        '
        'gestionproductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 536)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "gestionproductos"
        Me.Text = "gestionproductos"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picimagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As Stimulsoft.Controls.Win.DotNetBar.PanelEx
    Friend WithEvents GroupPanel1 As Stimulsoft.Controls.Win.DotNetBar.Controls.GroupPanel
    Friend WithEvents nuevo As Stimulsoft.Controls.Win.DotNetBar.ButtonX
    Friend WithEvents grabar As Stimulsoft.Controls.Win.DotNetBar.ButtonX
    Friend WithEvents eliminar As Stimulsoft.Controls.Win.DotNetBar.ButtonX
    Friend WithEvents editar As Stimulsoft.Controls.Win.DotNetBar.ButtonX
    Friend WithEvents todos As Stimulsoft.Controls.Win.DotNetBar.ButtonX
    Friend WithEvents imprimir_datagrid As Stimulsoft.Controls.Win.DotNetBar.ButtonX
    Friend WithEvents chestado As System.Windows.Forms.CheckBox
    Friend WithEvents dtfechacaducidad As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtfecharegistro As System.Windows.Forms.DateTimePicker
    Friend WithEvents picimagen As System.Windows.Forms.PictureBox
    Friend WithEvents cbounidadmedida As System.Windows.Forms.ComboBox
    Friend WithEvents cboproveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbocategoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtprecioventa As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtpreciocosto As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtobservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtcapacidad As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents ButtonX2 As Stimulsoft.Controls.Win.DotNetBar.ButtonX
    Friend WithEvents IdProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProveedoresStringDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CapacidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UMedidaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FamiliaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoriaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObservacionesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioCostoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioVentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UpsizetsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaingresoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechadecaducidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FotoproductoDataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonX3 As Stimulsoft.Controls.Win.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As Stimulsoft.Controls.Win.DotNetBar.ButtonX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonX4 As Stimulsoft.Controls.Win.DotNetBar.ButtonX
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboalmacen As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
