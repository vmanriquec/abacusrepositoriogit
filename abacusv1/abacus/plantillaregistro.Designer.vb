<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class plantillaregistro
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
        Me.PanelEx1 = New Stimulsoft.Controls.Win.DotNetBar.PanelEx()
        Me.chkestado = New System.Windows.Forms.CheckBox()
        Me.txtobservaciones = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = Stimulsoft.Controls.Win.DotNetBar.eDotNetBarStyle.Office2007
        Me.PanelEx1.Controls.Add(Me.chkestado)
        Me.PanelEx1.Controls.Add(Me.txtobservaciones)
        Me.PanelEx1.Controls.Add(Me.Label10)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(649, 403)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = Stimulsoft.Controls.Win.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = Stimulsoft.Controls.Win.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 45
        '
        'chkestado
        '
        Me.chkestado.AutoSize = True
        Me.chkestado.Location = New System.Drawing.Point(541, 12)
        Me.chkestado.Name = "chkestado"
        Me.chkestado.Size = New System.Drawing.Size(58, 17)
        Me.chkestado.TabIndex = 54
        Me.chkestado.Text = "estado"
        Me.chkestado.UseVisualStyleBackColor = True
        '
        'txtobservaciones
        '
        Me.txtobservaciones.Location = New System.Drawing.Point(206, 49)
        Me.txtobservaciones.Multiline = True
        Me.txtobservaciones.Name = "txtobservaciones"
        Me.txtobservaciones.Size = New System.Drawing.Size(372, 80)
        Me.txtobservaciones.TabIndex = 53
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(203, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "observaciones"
        '
        'plantillaregistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 403)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "plantillaregistro"
        Me.Text = "plantillaregistro"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents chkestado As System.Windows.Forms.CheckBox
    Public WithEvents PanelEx1 As Stimulsoft.Controls.Win.DotNetBar.PanelEx
    Public WithEvents txtobservaciones As System.Windows.Forms.TextBox
    Public WithEvents Label10 As System.Windows.Forms.Label
End Class
