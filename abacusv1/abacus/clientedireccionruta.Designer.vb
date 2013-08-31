<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clientedireccionruta
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
        Me.txtobservacion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientesStringDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RutaStringDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirecciontiendaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdcrdObjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboruta = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbocliente = New System.Windows.Forms.ComboBox()
        Me.GroupPanel1 = New Stimulsoft.Controls.Win.DotNetBar.Controls.GroupPanel()
        Me.ButtonX3 = New Stimulsoft.Controls.Win.DotNetBar.ButtonX()
        Me.imprimir_datagrid = New Stimulsoft.Controls.Win.DotNetBar.ButtonX()
        Me.ButtonX1 = New Stimulsoft.Controls.Win.DotNetBar.ButtonX()
        Me.todos = New Stimulsoft.Controls.Win.DotNetBar.ButtonX()
        Me.editar = New Stimulsoft.Controls.Win.DotNetBar.ButtonX()
        Me.eliminar = New Stimulsoft.Controls.Win.DotNetBar.ButtonX()
        Me.grabar = New Stimulsoft.Controls.Win.DotNetBar.ButtonX()
        Me.nuevo = New Stimulsoft.Controls.Win.DotNetBar.ButtonX()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdcrdObjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtobservacion
        '
        Me.txtobservacion.Location = New System.Drawing.Point(103, 118)
        Me.txtobservacion.Multiline = True
        Me.txtobservacion.Name = "txtobservacion"
        Me.txtobservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtobservacion.Size = New System.Drawing.Size(383, 59)
        Me.txtobservacion.TabIndex = 55
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "cliente"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.ClientesStringDataGridViewTextBoxColumn, Me.RutaStringDataGridViewTextBoxColumn, Me.DirecciontiendaDataGridViewTextBoxColumn, Me.ObservacionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.IdcrdObjectBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 184)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(536, 278)
        Me.DataGridView1.TabIndex = 58
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "idcrd"
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'ClientesStringDataGridViewTextBoxColumn
        '
        Me.ClientesStringDataGridViewTextBoxColumn.DataPropertyName = "ClientesString"
        Me.ClientesStringDataGridViewTextBoxColumn.HeaderText = "ClientesString"
        Me.ClientesStringDataGridViewTextBoxColumn.Name = "ClientesStringDataGridViewTextBoxColumn"
        Me.ClientesStringDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RutaStringDataGridViewTextBoxColumn
        '
        Me.RutaStringDataGridViewTextBoxColumn.DataPropertyName = "rutaString"
        Me.RutaStringDataGridViewTextBoxColumn.HeaderText = "rutaString"
        Me.RutaStringDataGridViewTextBoxColumn.Name = "RutaStringDataGridViewTextBoxColumn"
        Me.RutaStringDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DirecciontiendaDataGridViewTextBoxColumn
        '
        Me.DirecciontiendaDataGridViewTextBoxColumn.DataPropertyName = "direcciontienda"
        Me.DirecciontiendaDataGridViewTextBoxColumn.HeaderText = "direcciontienda"
        Me.DirecciontiendaDataGridViewTextBoxColumn.Name = "DirecciontiendaDataGridViewTextBoxColumn"
        Me.DirecciontiendaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ObservacionDataGridViewTextBoxColumn
        '
        Me.ObservacionDataGridViewTextBoxColumn.DataPropertyName = "observacion"
        Me.ObservacionDataGridViewTextBoxColumn.HeaderText = "observacion"
        Me.ObservacionDataGridViewTextBoxColumn.Name = "ObservacionDataGridViewTextBoxColumn"
        Me.ObservacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdcrdObjectBindingSource
        '
        Me.IdcrdObjectBindingSource.DataSource = GetType(abacusRules.Objects.idcrdObject)
        '
        'cboruta
        '
        Me.cboruta.FormattingEnabled = True
        Me.cboruta.Location = New System.Drawing.Point(103, 89)
        Me.cboruta.Name = "cboruta"
        Me.cboruta.Size = New System.Drawing.Size(193, 21)
        Me.cboruta.TabIndex = 59
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Observaciones"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "ruta"
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(103, 50)
        Me.txtdireccion.Multiline = True
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtdireccion.Size = New System.Drawing.Size(379, 33)
        Me.txtdireccion.TabIndex = 60
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Direccion"
        '
        'cbocliente
        '
        Me.cbocliente.FormattingEnabled = True
        Me.cbocliente.Location = New System.Drawing.Point(103, 23)
        Me.cbocliente.Name = "cbocliente"
        Me.cbocliente.Size = New System.Drawing.Size(193, 21)
        Me.cbocliente.TabIndex = 59
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
        Me.GroupPanel1.Location = New System.Drawing.Point(549, 12)
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
        Me.GroupPanel1.TabIndex = 61
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
        'clientedireccionruta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 466)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.cboruta)
        Me.Controls.Add(Me.cbocliente)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtobservacion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "clientedireccionruta"
        Me.Text = "clientedireccionruta"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdcrdObjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtobservacion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cboruta As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents IdcrdObjectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClientesStringDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RutaStringDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DirecciontiendaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObservacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbocliente As System.Windows.Forms.ComboBox
    Friend WithEvents GroupPanel1 As Stimulsoft.Controls.Win.DotNetBar.Controls.GroupPanel
    Friend WithEvents ButtonX3 As Stimulsoft.Controls.Win.DotNetBar.ButtonX
    Friend WithEvents imprimir_datagrid As Stimulsoft.Controls.Win.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As Stimulsoft.Controls.Win.DotNetBar.ButtonX
    Friend WithEvents todos As Stimulsoft.Controls.Win.DotNetBar.ButtonX
    Friend WithEvents editar As Stimulsoft.Controls.Win.DotNetBar.ButtonX
    Friend WithEvents eliminar As Stimulsoft.Controls.Win.DotNetBar.ButtonX
    Friend WithEvents grabar As Stimulsoft.Controls.Win.DotNetBar.ButtonX
    Friend WithEvents nuevo As Stimulsoft.Controls.Win.DotNetBar.ButtonX
End Class
