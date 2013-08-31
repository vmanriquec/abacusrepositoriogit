Imports abacusRules.Objects
Imports abacusRules.Entities
Imports abacusRules.Mappers
Imports abacusRules.micapadatos
Public Class Form1
    Dim actuali, siempreid As Integer
    Private Sub limpiar()
        Me.nombre.Text = ""
        Me.apellidos.Text = ""
        Me.apellidos.Text = ""
        Me.dni.Text = ""
    End Sub
    Private Sub bloquear()
        Me.nombre.Enabled = False
        Me.apellidos.Enabled = False
        Me.cbocargo.Enabled = False
        Me.nacimiento.Enabled = False
        Me.registro.Enabled = False
        Me.retiro.Enabled = False
        Me.dni.Enabled = False
    End Sub
    Private Sub habilitar()
        Me.nombre.Enabled = True
        Me.apellidos.Enabled = True
        Me.cbocargo.Enabled = True
        Me.nacimiento.Enabled = True
        Me.registro.Enabled = True
        Me.retiro.Enabled = True
        Me.dni.Enabled = True
    End Sub
    Public Shared Sub cargarcombocargo(ByVal cbo As ComboBox)
        Try
            cbo.DataSource = TrabajadoresMapper.cargarnombrecargocombo()
            cbo.DisplayMember = "nombre"
            cbo.ValueMember = "idcargopersonal"
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarcombocargo(Me.cbocargo)

    End Sub
    ' Private Sub grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grabar.Click
    'If actuali <> 1 Then

    '    capturaridgeneralregresa_siempreid("idcargopersonal", "cargopersonal", "nombre", CStr(Me.cbocargo.Text))
    '    Dim trabajador As New Trabajadores
    '    trabajador.Nombres = Me.nombre.Text
    '    trabajador.Apellidos = Me.apellidos.Text
    '    trabajador.Cargo = Me.cbocargo.Text
    '    trabajador.DNI = Me.dni.Text

    '    trabajador.idcargopersonal = CType(Me.cbocargo.SelectedValue.ToString, Integer?)
    '    trabajador.FecNacimiento = Me.nacimiento.Value
    '    trabajador.FecRegistro = Me.registro.Value
    '    trabajador.fecRetiro = Me.retiro.Value
    '    TrabajadoresMapper.Instance.Insert(trabajador)
    '    MsgBox("se agrego un nuevo trabajador")
    'Else
    '    Dim fila As Byte
    '    Dim i As Integer
    '    fila = CByte(Me.DataGridView1.CurrentCell.RowIndex())
    '    i = CInt(CDec(Me.DataGridView1.Item(0, fila).Value()))
    '    capturaridgeneralregresa_siempreid("idcargopersonal", "cargopersonal", "nombre", CStr(Me.cbocargo.Text))
    '    Dim trabajador2 As New abacusRules.Entities.Trabajadores
    '    trabajador2 = TrabajadoresMapper.Instance.GetOne(i)
    '    trabajador2.Nombres = Me.nombre.Text
    '    trabajador2.Apellidos = Me.apellidos.Text
    '    trabajador2.Cargo = Me.cbocargo.Text
    '    trabajador2.DNI = Me.dni.Text
    '    trabajador2.FecNacimiento = Me.nacimiento.Value
    '    trabajador2.FecRegistro = Me.registro.Value
    '    trabajador2.fecRetiro = Me.retiro.Value
    '    TrabajadoresMapper.Instance.Save(trabajador2)
    '    MsgBox("se actualizo un nuevo trabajador")
    'End If
    'Me.DataGridView1.DataSource = TrabajadoresMapper.Instance.GetAll()
    'End Sub

    'Private Sub eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eliminar.Click
    '    If Me.DataGridView1.RowCount = 0 Then
    '        MsgBox("busque primero el trabajador")
    '    Else
    '        Dim fila As Byte
    '        Dim i As Integer
    '        fila = CByte(Me.DataGridView1.CurrentCell.RowIndex())
    '        Dim trabajador As New Trabajadores
    '        i = CInt(CDec(Me.DataGridView1.Item(0, fila).Value()))
    '        TrabajadoresMapper.Instance.Delete(i)
    '        MsgBox("traajador eliminado con exito")
    '        Me.DataGridView1.DataSource = TrabajadoresMapper.Instance.GetAll
    '    End If

    'End Sub
    'Private Sub editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editar.Click
    'Dim fila As Byte
    'Dim i As Integer
    'fila = CByte(Me.DataGridView1.CurrentCell.RowIndex())
    'Dim trabajador1 As TrabajadoresObject
    'i = CInt(CDec(Me.DataGridView1.Item(0, fila).Value()))
    'trabajador1 = TrabajadoresMapper.Instance.GetOne(i)
    'Me.nombre.Text = CStr(trabajador1.Nombres)
    'Me.apellidos.Text = trabajador1.Apellidos
    'Me.cbocargo.Text = trabajador1.Cargo
    'Me.dni.Text = trabajador1.DNI
    'Me.nacimiento.Value = CDate(trabajador1.FecNacimiento)
    'Me.registro.Value = CDate(trabajador1.FecRegistro)
    'Me.retiro.Value = CDate(trabajador1.fecRetiro)
    'actuali = 1
    ' End Sub

    'Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    Me.DataGridView1.DataSource = TrabajadoresMapper.Instance.GetAll
    'End Sub



    Private Sub KryptonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub





    Private Sub nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiar()
    End Sub

    Private Sub grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If actuali <> 1 Then

            capturaridgeneralregresa_siempreid("idcargopersonal", "cargopersonal", "nombre", CStr(Me.cbocargo.Text))
            Dim trabajador As New Trabajadores
            trabajador.Nombres = Me.nombre.Text
            trabajador.Apellidos = Me.apellidos.Text
            trabajador.Cargo = Me.cbocargo.Text
            trabajador.DNI = Me.dni.Text

            trabajador.idcargopersonal = CType(Me.cbocargo.SelectedValue.ToString, Integer?)
            trabajador.FecNacimiento = Me.nacimiento.Value
            trabajador.FecRegistro = Me.registro.Value
            trabajador.fecRetiro = Me.retiro.Value
            TrabajadoresMapper.Instance.Insert(trabajador)
            MsgBox("se agrego un nuevo trabajador")
            limpiar()
        Else
            Dim fila As Byte
            Dim i As Integer
            fila = CByte(Me.DataGridView1.CurrentCell.RowIndex())
            i = CInt(CDec(Me.DataGridView1.Item(0, fila).Value()))
            capturaridgeneralregresa_siempreid("idcargopersonal", "cargopersonal", "nombre", CStr(Me.cbocargo.Text))
            Dim trabajador2 As New abacusRules.Entities.Trabajadores
            trabajador2 = TrabajadoresMapper.Instance.GetOne(i)
            trabajador2.Nombres = Me.nombre.Text
            trabajador2.Apellidos = Me.apellidos.Text
            trabajador2.Cargo = Me.cbocargo.Text
            trabajador2.DNI = Me.dni.Text
            trabajador2.FecNacimiento = Me.nacimiento.Value
            trabajador2.FecRegistro = Me.registro.Value
            trabajador2.fecRetiro = Me.retiro.Value
            TrabajadoresMapper.Instance.Save(trabajador2)
            MsgBox("se actualizo un nuevo trabajador")
            limpiar()
        End If
        Me.DataGridView1.DataSource = TrabajadoresMapper.Instance.GetAll()
    End Sub


    Private Sub eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.DataGridView1.RowCount = 0 Then
            MsgBox("busque primero el trabajador")
        Else
            Dim fila As Byte
            Dim i As Integer
            fila = CByte(Me.DataGridView1.CurrentCell.RowIndex())
            Dim trabajador As New Trabajadores
            i = CInt(CDec(Me.DataGridView1.Item(0, fila).Value()))
            TrabajadoresMapper.Instance.Delete(i)
            MsgBox("trabajador eliminado con exito")
            Me.DataGridView1.DataSource = TrabajadoresMapper.Instance.GetAll
        End If
    End Sub

    Private Sub editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim fila As Byte
        Dim i As Integer
        fila = CByte(Me.DataGridView1.CurrentCell.RowIndex())
        Dim trabajador1 As TrabajadoresObject
        i = CInt(CDec(Me.DataGridView1.Item(0, fila).Value()))
        trabajador1 = TrabajadoresMapper.Instance.GetOne(i)
        Me.nombre.Text = CStr(trabajador1.Nombres)
        Me.apellidos.Text = trabajador1.Apellidos
        Me.cbocargo.Text = trabajador1.Cargo
        Me.dni.Text = trabajador1.DNI
        Me.nacimiento.Value = CDate(trabajador1.FecNacimiento)
        Me.registro.Value = CDate(trabajador1.FecRegistro)
        Me.retiro.Value = CDate(trabajador1.fecRetiro)
        actuali = 1
    End Sub

    Private Sub todos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DataGridView1.DataSource = TrabajadoresMapper.Instance.GetAll
    End Sub

    Private Sub PanelEx1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanelEx1.Click

    End Sub

    Private Sub eliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eliminar.Click

    End Sub
End Class



