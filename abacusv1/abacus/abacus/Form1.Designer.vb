
        <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cbocargo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.apellidos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dni = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.registro = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.retiro = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdTrabjadorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FecNacimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FecRegistroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FecRetiroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CargopersonalStringDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrabajadoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PanelEx1 = New Stimulsoft.Controls.Win.DotNetBar.PanelEx()
        Me.todos = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.grabar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.editar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.eliminar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.nuevo = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonButton1 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.GroupPanel1 = New Stimulsoft.Controls.Win.DotNetBar.Controls.GroupPanel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrabajadoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbocargo
        '
        Me.cbocargo.FormattingEnabled = True
        Me.cbocargo.Location = New System.Drawing.Point(368, 47)
        Me.cbocargo.Name = "cbocargo"
        Me.cbocargo.Size = New System.Drawing.Size(134, 21)
        Me.cbocargo.TabIndex = 1
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
        'nombre
        '
        Me.nombre.Location = New System.Drawing.Point(50, 14)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(239, 20)
        Me.nombre.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(322, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "apellidos"
        '
        'apellidos
        '
        Me.apellidos.Location = New System.Drawing.Point(368, 14)
        Me.apellidos.Name = "apellidos"
        Me.apellidos.Size = New System.Drawing.Size(195, 20)
        Me.apellidos.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "dni"
        '
        'dni
        '
        Me.dni.Location = New System.Drawing.Point(50, 50)
        Me.dni.Name = "dni"
        Me.dni.Size = New System.Drawing.Size(149, 20)
        Me.dni.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "fecha de nacimiento"
        '
        'nacimiento
        '
        Me.nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.nacimiento.Location = New System.Drawing.Point(50, 109)
        Me.nacimiento.Name = "nacimiento"
        Me.nacimiento.Size = New System.Drawing.Size(128, 20)
        Me.nacimiento.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(208, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "fecha de registro"
        '
        'registro
        '
        Me.registro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.registro.Location = New System.Drawing.Point(245, 109)
        Me.registro.Name = "registro"
        Me.registro.Size = New System.Drawing.Size(125, 20)
        Me.registro.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(385, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "fecha de Retiro"
        '
        'retiro
        '
        Me.retiro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.retiro.Location = New System.Drawing.Point(428, 109)
        Me.retiro.Name = "retiro"
        Me.retiro.Size = New System.Drawing.Size(135, 20)
        Me.retiro.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdTrabjadorDataGridViewTextBoxColumn, Me.NombresDataGridViewTextBoxColumn, Me.ApellidosDataGridViewTextBoxColumn, Me.DNIDataGridViewTextBoxColumn, Me.FecNacimientoDataGridViewTextBoxColumn, Me.FecRegistroDataGridViewTextBoxColumn, Me.FecRetiroDataGridViewTextBoxColumn, Me.CargopersonalStringDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TrabajadoresBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(7, 135)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(606, 206)
        Me.DataGridView1.TabIndex = 43
        '
        'IdTrabjadorDataGridViewTextBoxColumn
        '
        Me.IdTrabjadorDataGridViewTextBoxColumn.DataPropertyName = "IdTrabjador"
        Me.IdTrabjadorDataGridViewTextBoxColumn.HeaderText = "IdTrabjador"
        Me.IdTrabjadorDataGridViewTextBoxColumn.Name = "IdTrabjadorDataGridViewTextBoxColumn"
        Me.IdTrabjadorDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdTrabjadorDataGridViewTextBoxColumn.Visible = False
        '
        'NombresDataGridViewTextBoxColumn
        '
        Me.NombresDataGridViewTextBoxColumn.DataPropertyName = "Nombres"
        Me.NombresDataGridViewTextBoxColumn.HeaderText = "Nombres"
        Me.NombresDataGridViewTextBoxColumn.Name = "NombresDataGridViewTextBoxColumn"
        Me.NombresDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApellidosDataGridViewTextBoxColumn
        '
        Me.ApellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.Name = "ApellidosDataGridViewTextBoxColumn"
        Me.ApellidosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DNIDataGridViewTextBoxColumn
        '
        Me.DNIDataGridViewTextBoxColumn.DataPropertyName = "DNI"
        Me.DNIDataGridViewTextBoxColumn.HeaderText = "DNI"
        Me.DNIDataGridViewTextBoxColumn.Name = "DNIDataGridViewTextBoxColumn"
        Me.DNIDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FecNacimientoDataGridViewTextBoxColumn
        '
        Me.FecNacimientoDataGridViewTextBoxColumn.DataPropertyName = "FecNacimiento"
        Me.FecNacimientoDataGridViewTextBoxColumn.HeaderText = "FecNacimiento"
        Me.FecNacimientoDataGridViewTextBoxColumn.Name = "FecNacimientoDataGridViewTextBoxColumn"
        Me.FecNacimientoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FecRegistroDataGridViewTextBoxColumn
        '
        Me.FecRegistroDataGridViewTextBoxColumn.DataPropertyName = "FecRegistro"
        Me.FecRegistroDataGridViewTextBoxColumn.HeaderText = "FecRegistro"
        Me.FecRegistroDataGridViewTextBoxColumn.Name = "FecRegistroDataGridViewTextBoxColumn"
        Me.FecRegistroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FecRetiroDataGridViewTextBoxColumn
        '
        Me.FecRetiroDataGridViewTextBoxColumn.DataPropertyName = "fecRetiro"
        Me.FecRetiroDataGridViewTextBoxColumn.HeaderText = "fecRetiro"
        Me.FecRetiroDataGridViewTextBoxColumn.Name = "FecRetiroDataGridViewTextBoxColumn"
        Me.FecRetiroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CargopersonalStringDataGridViewTextBoxColumn
        '
        Me.CargopersonalStringDataGridViewTextBoxColumn.DataPropertyName = "cargopersonalString"
        Me.CargopersonalStringDataGridViewTextBoxColumn.HeaderText = "cargo"
        Me.CargopersonalStringDataGridViewTextBoxColumn.Name = "CargopersonalStringDataGridViewTextBoxColumn"
        Me.CargopersonalStringDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TrabajadoresBindingSource
        '
        Me.TrabajadoresBindingSource.DataSource = GetType(abacusRules.Entities.Trabajadores)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(322, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "cargo"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = Stimulsoft.Controls.Win.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.DataGridView1)
        Me.PanelEx1.Controls.Add(Me.KryptonButton1)
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.Controls.Add(Me.retiro)
        Me.PanelEx1.Controls.Add(Me.Label7)
        Me.PanelEx1.Controls.Add(Me.registro)
        Me.PanelEx1.Controls.Add(Me.Label6)
        Me.PanelEx1.Controls.Add(Me.nacimiento)
        Me.PanelEx1.Controls.Add(Me.Label5)
        Me.PanelEx1.Controls.Add(Me.dni)
        Me.PanelEx1.Controls.Add(Me.Label3)
        Me.PanelEx1.Controls.Add(Me.apellidos)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.nombre)
        Me.PanelEx1.Controls.Add(Me.Label8)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.cbocargo)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(620, 401)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = Stimulsoft.Controls.Win.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 44
        '
        'todos
        '
        Me.todos.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form
        Me.todos.Location = New System.Drawing.Point(185, 5)
        Me.todos.Name = "todos"
        Me.todos.Size = New System.Drawing.Size(37, 37)
        Me.todos.TabIndex = 49
        Me.todos.Values.Image = Global.abacus.My.Resources.Resources.kaboodleloop
        Me.todos.Values.Text = ""
        '
        'grabar
        '
        Me.grabar.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form
        Me.grabar.Location = New System.Drawing.Point(48, 1)
        Me.grabar.Name = "grabar"
        Me.grabar.Size = New System.Drawing.Size(46, 45)
        Me.grabar.TabIndex = 48
        Me.grabar.Values.Image = Global.abacus.My.Resources.Resources.halfencrypted
        Me.grabar.Values.Text = ""
        '
        'editar
        '
        Me.editar.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form
        Me.editar.Location = New System.Drawing.Point(92, 2)
        Me.editar.Name = "editar"
        Me.editar.Size = New System.Drawing.Size(39, 44)
        Me.editar.TabIndex = 47
        Me.editar.Values.Image = Global.abacus.My.Resources.Resources.kontact_todo
        Me.editar.Values.Text = ""
        '
        'eliminar
        '
        Me.eliminar.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form
        Me.eliminar.Location = New System.Drawing.Point(137, 5)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(42, 40)
        Me.eliminar.TabIndex = 46
        Me.eliminar.Values.Image = Global.abacus.My.Resources.Resources.edittrash
        Me.eliminar.Values.Text = ""
        '
        'nuevo
        '
        Me.nuevo.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form
        Me.nuevo.Location = New System.Drawing.Point(5, 1)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(42, 48)
        Me.nuevo.TabIndex = 45
        Me.nuevo.Values.Image = Global.abacus.My.Resources.Resources.filenew
        Me.nuevo.Values.Text = ""
        '
        'KryptonButton1
        '
        Me.KryptonButton1.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.FormClose
        Me.KryptonButton1.Location = New System.Drawing.Point(568, 347)
        Me.KryptonButton1.Name = "KryptonButton1"
        Me.KryptonButton1.Size = New System.Drawing.Size(40, 44)
        Me.KryptonButton1.TabIndex = 44
        Me.KryptonButton1.Values.Image = Global.abacus.My.Resources.Resources._exit
        Me.KryptonButton1.Values.Text = ""
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = Stimulsoft.Controls.Win.DotNetBar.eDotNetBarStyle.Office2000
        Me.GroupPanel1.Controls.Add(Me.eliminar)
        Me.GroupPanel1.Controls.Add(Me.todos)
        Me.GroupPanel1.Controls.Add(Me.nuevo)
        Me.GroupPanel1.Controls.Add(Me.editar)
        Me.GroupPanel1.Controls.Add(Me.grabar)
        Me.GroupPanel1.Location = New System.Drawing.Point(145, 347)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(245, 49)
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 401)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion de Personal"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrabajadoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbocargo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents apellidos As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dni As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents nacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents registro As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents retiro As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TrabajadoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents IdTrabjadorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombresDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DNIDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FecNacimientoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FecRegistroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FecRetiroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CargopersonalStringDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PanelEx1 As Stimulsoft.Controls.Win.DotNetBar.PanelEx
    Friend WithEvents KryptonButton1 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents nuevo As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents eliminar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents editar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents grabar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents todos As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents GroupPanel1 As Stimulsoft.Controls.Win.DotNetBar.Controls.GroupPanel

End Class

