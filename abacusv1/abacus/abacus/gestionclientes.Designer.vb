﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gestionclientes
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
        Me.provincia = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.apellidos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dni = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.registro = New System.Windows.Forms.DateTimePicker()
        Me.GroupPanel1 = New Stimulsoft.Controls.Win.DotNetBar.Controls.GroupPanel()
        Me.eliminar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonButton1 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.todos = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.nuevo = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.editar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.grabar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ClientesObjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelEx1 = New Stimulsoft.Controls.Win.DotNetBar.PanelEx()
        Me.fax = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TELEFONO = New System.Windows.Forms.TextBox()
        Me.LAB = New System.Windows.Forms.Label()
        Me.direccion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.TextBox()
        Me.observaciones = New System.Windows.Forms.TextBox()
        Me.razonsocial = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.condicionpago = New System.Windows.Forms.ComboBox()
        Me.distrito = New System.Windows.Forms.ComboBox()
        Me.TrabajadoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NomComercialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvinciasString = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DistritoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvinciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FaxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CondPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesObjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        CType(Me.TrabajadoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'provincia
        '
        Me.provincia.FormattingEnabled = True
        Me.provincia.Location = New System.Drawing.Point(335, 47)
        Me.provincia.Name = "provincia"
        Me.provincia.Size = New System.Drawing.Size(124, 21)
        Me.provincia.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "nombres"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(279, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "provincia"
        '
        'nombre
        '
        Me.nombre.Location = New System.Drawing.Point(57, 14)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(196, 20)
        Me.nombre.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "apellidos"
        '
        'apellidos
        '
        Me.apellidos.Location = New System.Drawing.Point(57, 40)
        Me.apellidos.Name = "apellidos"
        Me.apellidos.Size = New System.Drawing.Size(195, 20)
        Me.apellidos.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "dni"
        '
        'dni
        '
        Me.dni.Location = New System.Drawing.Point(57, 123)
        Me.dni.Name = "dni"
        Me.dni.Size = New System.Drawing.Size(149, 20)
        Me.dni.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "fecha de nacimiento"
        '
        'registro
        '
        Me.registro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.registro.Location = New System.Drawing.Point(113, 217)
        Me.registro.Name = "registro"
        Me.registro.Size = New System.Drawing.Size(139, 20)
        Me.registro.TabIndex = 4
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = Stimulsoft.Controls.Win.DotNetBar.eDotNetBarStyle.Office2000
        Me.GroupPanel1.Controls.Add(Me.eliminar)
        Me.GroupPanel1.Controls.Add(Me.KryptonButton1)
        Me.GroupPanel1.Controls.Add(Me.todos)
        Me.GroupPanel1.Controls.Add(Me.nuevo)
        Me.GroupPanel1.Controls.Add(Me.editar)
        Me.GroupPanel1.Controls.Add(Me.grabar)
        Me.GroupPanel1.Location = New System.Drawing.Point(848, 3)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(55, 282)
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
        Me.GroupPanel1.TabIndex = 50
        '
        'eliminar
        '
        Me.eliminar.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form
        Me.eliminar.Location = New System.Drawing.Point(-3, 146)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(42, 40)
        Me.eliminar.TabIndex = 46
        Me.eliminar.Values.Image = Global.abacus.My.Resources.Resources.edittrash
        Me.eliminar.Values.Text = ""
        '
        'KryptonButton1
        '
        Me.KryptonButton1.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.FormClose
        Me.KryptonButton1.Location = New System.Drawing.Point(2, 235)
        Me.KryptonButton1.Name = "KryptonButton1"
        Me.KryptonButton1.Size = New System.Drawing.Size(40, 44)
        Me.KryptonButton1.TabIndex = 44
        Me.KryptonButton1.Values.Image = Global.abacus.My.Resources.Resources._exit
        Me.KryptonButton1.Values.Text = ""
        '
        'todos
        '
        Me.todos.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form
        Me.todos.Location = New System.Drawing.Point(5, 192)
        Me.todos.Name = "todos"
        Me.todos.Size = New System.Drawing.Size(37, 37)
        Me.todos.TabIndex = 49
        Me.todos.Values.Image = Global.abacus.My.Resources.Resources.kaboodleloop
        Me.todos.Values.Text = ""
        '
        'nuevo
        '
        Me.nuevo.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form
        Me.nuevo.Location = New System.Drawing.Point(5, 44)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(42, 48)
        Me.nuevo.TabIndex = 45
        Me.nuevo.Values.Image = Global.abacus.My.Resources.Resources.filenew
        Me.nuevo.Values.Text = ""
        '
        'editar
        '
        Me.editar.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form
        Me.editar.Location = New System.Drawing.Point(3, 96)
        Me.editar.Name = "editar"
        Me.editar.Size = New System.Drawing.Size(39, 44)
        Me.editar.TabIndex = 47
        Me.editar.Values.Image = Global.abacus.My.Resources.Resources.kontact_todo
        Me.editar.Values.Text = ""
        '
        'grabar
        '
        Me.grabar.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form
        Me.grabar.Location = New System.Drawing.Point(1, -3)
        Me.grabar.Name = "grabar"
        Me.grabar.Size = New System.Drawing.Size(46, 45)
        Me.grabar.TabIndex = 48
        Me.grabar.Values.Image = Global.abacus.My.Resources.Resources.halfencrypted
        Me.grabar.Values.Text = ""
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomComercialDataGridViewTextBoxColumn, Me.Column1, Me.ProvinciasString, Me.NombreDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.DI, Me.DistritoDataGridViewTextBoxColumn, Me.ProvinciaDataGridViewTextBoxColumn, Me.Telefono1DataGridViewTextBoxColumn, Me.FaxDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.ObservacionesDataGridViewTextBoxColumn, Me.CondPagoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ClientesObjectBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(3, 291)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(900, 272)
        Me.DataGridView1.TabIndex = 43
        '
        'ClientesObjectBindingSource
        '
        Me.ClientesObjectBindingSource.DataSource = GetType(abacusRules.Objects.ClientesObject)
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = Stimulsoft.Controls.Win.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.DataGridView1)
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.Controls.Add(Me.registro)
        Me.PanelEx1.Controls.Add(Me.Label5)
        Me.PanelEx1.Controls.Add(Me.fax)
        Me.PanelEx1.Controls.Add(Me.Label12)
        Me.PanelEx1.Controls.Add(Me.dni)
        Me.PanelEx1.Controls.Add(Me.Label3)
        Me.PanelEx1.Controls.Add(Me.TELEFONO)
        Me.PanelEx1.Controls.Add(Me.LAB)
        Me.PanelEx1.Controls.Add(Me.direccion)
        Me.PanelEx1.Controls.Add(Me.Label7)
        Me.PanelEx1.Controls.Add(Me.apellidos)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.email)
        Me.PanelEx1.Controls.Add(Me.observaciones)
        Me.PanelEx1.Controls.Add(Me.razonsocial)
        Me.PanelEx1.Controls.Add(Me.nombre)
        Me.PanelEx1.Controls.Add(Me.Label6)
        Me.PanelEx1.Controls.Add(Me.Label11)
        Me.PanelEx1.Controls.Add(Me.Label4)
        Me.PanelEx1.Controls.Add(Me.Label10)
        Me.PanelEx1.Controls.Add(Me.Label9)
        Me.PanelEx1.Controls.Add(Me.Label8)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.condicionpago)
        Me.PanelEx1.Controls.Add(Me.distrito)
        Me.PanelEx1.Controls.Add(Me.provincia)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(965, 566)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = Stimulsoft.Controls.Win.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 45
        '
        'fax
        '
        Me.fax.Location = New System.Drawing.Point(57, 149)
        Me.fax.Name = "fax"
        Me.fax.Size = New System.Drawing.Size(149, 20)
        Me.fax.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 149)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(21, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "fax"
        '
        'TELEFONO
        '
        Me.TELEFONO.Location = New System.Drawing.Point(57, 94)
        Me.TELEFONO.Name = "TELEFONO"
        Me.TELEFONO.Size = New System.Drawing.Size(195, 20)
        Me.TELEFONO.TabIndex = 3
        '
        'LAB
        '
        Me.LAB.AutoSize = True
        Me.LAB.Location = New System.Drawing.Point(4, 98)
        Me.LAB.Name = "LAB"
        Me.LAB.Size = New System.Drawing.Size(45, 13)
        Me.LAB.TabIndex = 2
        Me.LAB.Text = "telefono"
        '
        'direccion
        '
        Me.direccion.Location = New System.Drawing.Point(57, 66)
        Me.direccion.Name = "direccion"
        Me.direccion.Size = New System.Drawing.Size(195, 20)
        Me.direccion.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "direccion"
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(57, 180)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(196, 20)
        Me.email.TabIndex = 3
        '
        'observaciones
        '
        Me.observaciones.Location = New System.Drawing.Point(282, 164)
        Me.observaciones.Multiline = True
        Me.observaciones.Name = "observaciones"
        Me.observaciones.Size = New System.Drawing.Size(372, 80)
        Me.observaciones.TabIndex = 3
        '
        'razonsocial
        '
        Me.razonsocial.Location = New System.Drawing.Point(355, 12)
        Me.razonsocial.Name = "razonsocial"
        Me.razonsocial.Size = New System.Drawing.Size(290, 20)
        Me.razonsocial.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(279, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "condicion de pago"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(4, 180)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(465, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "distrito"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(279, 142)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "observaciones"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(279, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Razon Social"
        '
        'condicionpago
        '
        Me.condicionpago.FormattingEnabled = True
        Me.condicionpago.Location = New System.Drawing.Point(380, 98)
        Me.condicionpago.Name = "condicionpago"
        Me.condicionpago.Size = New System.Drawing.Size(134, 21)
        Me.condicionpago.TabIndex = 1
        '
        'distrito
        '
        Me.distrito.FormattingEnabled = True
        Me.distrito.Location = New System.Drawing.Point(511, 47)
        Me.distrito.Name = "distrito"
        Me.distrito.Size = New System.Drawing.Size(134, 21)
        Me.distrito.TabIndex = 1
        '
        'TrabajadoresBindingSource
        '
        Me.TrabajadoresBindingSource.DataSource = GetType(abacusRules.Entities.Trabajadores)
        '
        'NomComercialDataGridViewTextBoxColumn
        '
        Me.NomComercialDataGridViewTextBoxColumn.DataPropertyName = "NomComercial"
        Me.NomComercialDataGridViewTextBoxColumn.HeaderText = "NomComercial"
        Me.NomComercialDataGridViewTextBoxColumn.Name = "NomComercialDataGridViewTextBoxColumn"
        Me.NomComercialDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "DistritosString"
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'ProvinciasString
        '
        Me.ProvinciasString.DataPropertyName = "ProvinciasString"
        Me.ProvinciasString.HeaderText = "ProvinciasString"
        Me.ProvinciasString.Name = "ProvinciasString"
        Me.ProvinciasString.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApellidoDataGridViewTextBoxColumn
        '
        Me.ApellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido"
        Me.ApellidoDataGridViewTextBoxColumn.HeaderText = "Apellido"
        Me.ApellidoDataGridViewTextBoxColumn.Name = "ApellidoDataGridViewTextBoxColumn"
        Me.ApellidoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DI
        '
        Me.DI.DataPropertyName = "DI"
        Me.DI.HeaderText = "DI"
        Me.DI.Name = "DI"
        Me.DI.ReadOnly = True
        '
        'DistritoDataGridViewTextBoxColumn
        '
        Me.DistritoDataGridViewTextBoxColumn.DataPropertyName = "Distrito"
        Me.DistritoDataGridViewTextBoxColumn.HeaderText = "Distrito"
        Me.DistritoDataGridViewTextBoxColumn.Name = "DistritoDataGridViewTextBoxColumn"
        Me.DistritoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProvinciaDataGridViewTextBoxColumn
        '
        Me.ProvinciaDataGridViewTextBoxColumn.DataPropertyName = "Provincia"
        Me.ProvinciaDataGridViewTextBoxColumn.HeaderText = "Provincia"
        Me.ProvinciaDataGridViewTextBoxColumn.Name = "ProvinciaDataGridViewTextBoxColumn"
        Me.ProvinciaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Telefono1DataGridViewTextBoxColumn
        '
        Me.Telefono1DataGridViewTextBoxColumn.DataPropertyName = "Telefono1"
        Me.Telefono1DataGridViewTextBoxColumn.HeaderText = "Telefono1"
        Me.Telefono1DataGridViewTextBoxColumn.Name = "Telefono1DataGridViewTextBoxColumn"
        Me.Telefono1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'FaxDataGridViewTextBoxColumn
        '
        Me.FaxDataGridViewTextBoxColumn.DataPropertyName = "Fax"
        Me.FaxDataGridViewTextBoxColumn.HeaderText = "Fax"
        Me.FaxDataGridViewTextBoxColumn.Name = "FaxDataGridViewTextBoxColumn"
        Me.FaxDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ObservacionesDataGridViewTextBoxColumn
        '
        Me.ObservacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.Name = "ObservacionesDataGridViewTextBoxColumn"
        Me.ObservacionesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CondPagoDataGridViewTextBoxColumn
        '
        Me.CondPagoDataGridViewTextBoxColumn.DataPropertyName = "CondPago"
        Me.CondPagoDataGridViewTextBoxColumn.HeaderText = "CondPago"
        Me.CondPagoDataGridViewTextBoxColumn.Name = "CondPagoDataGridViewTextBoxColumn"
        Me.CondPagoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'gestionclientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 566)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "gestionclientes"
        Me.Text = "gestionclientes"
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesObjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.TrabajadoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents provincia As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents apellidos As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dni As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents registro As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupPanel1 As Stimulsoft.Controls.Win.DotNetBar.Controls.GroupPanel
    Friend WithEvents eliminar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonButton1 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents todos As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents nuevo As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents editar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents grabar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ClientesObjectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PanelEx1 As Stimulsoft.Controls.Win.DotNetBar.PanelEx
    Friend WithEvents TrabajadoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TELEFONO As System.Windows.Forms.TextBox
    Friend WithEvents LAB As System.Windows.Forms.Label
    Friend WithEvents direccion As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents condicionpago As System.Windows.Forms.ComboBox
    Friend WithEvents distrito As System.Windows.Forms.ComboBox
    Friend WithEvents email As System.Windows.Forms.TextBox
    Friend WithEvents observaciones As System.Windows.Forms.TextBox
    Friend WithEvents razonsocial As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents fax As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents NomComercialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvinciasString As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DistritoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvinciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefono1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FaxDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObservacionesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CondPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
