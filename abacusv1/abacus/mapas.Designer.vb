<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mapas
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
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.RibbonClientPanel1 = New Stimulsoft.Controls.Win.DotNetBar.Ribbon.RibbonClientPanel()
        Me.grabar = New Stimulsoft.Controls.Win.DotNetBar.ButtonX()
        Me.ButtonX1 = New Stimulsoft.Controls.Win.DotNetBar.ButtonX()
        Me.RibbonClientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(156, 23)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(398, 20)
        Me.txtdireccion.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(16, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Direccion a Buscar"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 56)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1377, 475)
        Me.WebBrowser1.TabIndex = 4
        '
        'RibbonClientPanel1
        '
        Me.RibbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.RibbonClientPanel1.Controls.Add(Me.ButtonX1)
        Me.RibbonClientPanel1.Controls.Add(Me.WebBrowser1)
        Me.RibbonClientPanel1.Controls.Add(Me.grabar)
        Me.RibbonClientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonClientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonClientPanel1.Name = "RibbonClientPanel1"
        Me.RibbonClientPanel1.Size = New System.Drawing.Size(1380, 534)
        '
        '
        '
        Me.RibbonClientPanel1.Style.Class = "RibbonClientPanel"
        Me.RibbonClientPanel1.TabIndex = 5
        Me.RibbonClientPanel1.Text = "RibbonClientPanel1"
        '
        'grabar
        '
        Me.grabar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.grabar.ColorTable = Stimulsoft.Controls.Win.DotNetBar.eButtonColor.OrangeWithBackground
        Me.grabar.Image = Global.abacus.My.Resources.Resources.Icon_577
        Me.grabar.Location = New System.Drawing.Point(560, 12)
        Me.grabar.Name = "grabar"
        Me.grabar.Size = New System.Drawing.Size(44, 38)
        Me.grabar.TabIndex = 1
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = Stimulsoft.Controls.Win.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Image = Global.abacus.My.Resources.Resources._1376806550_print_32
        Me.ButtonX1.Location = New System.Drawing.Point(610, 12)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(52, 38)
        Me.ButtonX1.TabIndex = 5
        '
        'mapas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1380, 534)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.RibbonClientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "mapas"
        Me.Text = "mapas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.RibbonClientPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grabar As Stimulsoft.Controls.Win.DotNetBar.ButtonX
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents RibbonClientPanel1 As Stimulsoft.Controls.Win.DotNetBar.Ribbon.RibbonClientPanel
    Friend WithEvents ButtonX1 As Stimulsoft.Controls.Win.DotNetBar.ButtonX
End Class
