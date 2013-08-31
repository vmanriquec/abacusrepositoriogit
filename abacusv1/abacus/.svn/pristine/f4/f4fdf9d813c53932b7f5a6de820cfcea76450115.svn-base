Imports abacusRules.Objects
Imports abacusRules.Entities
Imports abacusRules.Mappers
Imports abacusRules.micapadatos
Public Class gestionclientes
    Dim actuali, siempreid As Integer
    Private Sub cargartodos()
        Me.DataGridView1.DataSource = ClientesMapper.Instance.GetAll
    End Sub
    Private Sub limpiar()
        Me.nombre.Text = ""
        Me.apellidos.Text = ""
        Me.apellidos.Text = ""
        Me.dni.Text = ""
    End Sub
    Private Sub bloquear()
        Me.nombre.Enabled = False
        Me.apellidos.Enabled = False
        Me.direccion.Enabled = False
        Me.LAB.Enabled = False

        Me.registro.Enabled = False
        Me.registro.Enabled = False
        Me.dni.Enabled = False
    End Sub
    Private Sub habilitar()
        Me.nombre.Enabled = True
        Me.apellidos.Enabled = True
        Me.registro.Enabled = True
        Me.registro.Enabled = True
        Me.dni.Enabled = True
    End Sub
    Public Shared Sub cargarcomboprovincia(ByVal cbo As ComboBox)
        Try
            cbo.DataSource = ProvinciasMapper.cargarnombreprovinciascargocombo()

            cbo.DisplayMember = "Provincia"
            cbo.ValueMember = "IdProvincia"

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Shared Sub cargarcomboformapago(ByVal cbo As ComboBox)
        Try
            cbo.DataSource = FormaPagoMapper.cargarnombreformapagocargocombo()

            cbo.DisplayMember = "forma"
            cbo.ValueMember = "IdFPago"

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Shared Sub cargarcombodistrito(ByVal cbo As ComboBox)
        Try
            cbo.DataSource = DistritosMapper.cargarnombredistritosargocombo()
            cbo.DisplayMember = "Distrito"
            cbo.ValueMember = "IdDistrito"

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarcombodistrito(Me.distrito)
        cargarcomboprovincia(Me.provincia)
        cargarcomboformapago(Me.condicionpago)
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



    Private Sub KryptonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton1.Click
        Me.Close()
    End Sub
    Private Sub nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nuevo.Click
        limpiar()
    End Sub

    Private Sub grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grabar.Click
        'If actuali <> 1 Then

        Dim cliente1 As New ClientesObject

        cliente1.Nombre = Me.nombre.Text
        cliente1.Apellido = Me.apellidos.Text
        cliente1.Direccion = Me.direccion.Text
        cliente1.DI = Me.dni.Text
        cliente1.NomComercial = Me.razonsocial.Text
        cliente1.Telefono1 = Me.LAB.Text
        cliente1.Fax = Me.fax.Text
        cliente1.Email = Me.email.Text
        cliente1.fechaderegistro = CDate(Me.registro.Value)
        cliente1.estadocliente = "1"
        cliente1.Provincia = CType(Me.provincia.SelectedValue.ToString, Integer?)
        cliente1.CondPago = CType(Me.condicionpago.SelectedValue.ToString, Integer?)
        cliente1.Distrito = CType(Me.distrito.SelectedValue.ToString, Integer?)
        cliente1.Observaciones = Me.observaciones.Text
        ClientesMapper.Instance.Insert(CType(cliente1, Clientes))


        MsgBox("se agrego un nuevo cliente")
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
        '    trabajador2.FecNacimiento = Me.registro.Value
        '    trabajador2.FecRegistro = Me.registro.Value
        '    trabajador2.fecRetiro = Me.retiro.Value
        '    TrabajadoresMapper.Instance.Save(trabajador2)
        '    MsgBox("se actualizo un nuevo trabajador")
        'End If
        cargartodos()

    End Sub


    Private Sub eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eliminar.Click
        If Me.DataGridView1.RowCount = 0 Then
            MsgBox("busque primero el trabajador")
        Else
            Dim fila As Byte
            Dim i As Integer
            fila = CByte(Me.DataGridView1.CurrentCell.RowIndex())
            Dim trabajador As New Trabajadores
            i = CInt(CDec(Me.DataGridView1.Item(0, fila).Value()))
            TrabajadoresMapper.Instance.Delete(i)
            MsgBox("traajador eliminado con exito")
            Me.DataGridView1.DataSource = TrabajadoresMapper.Instance.GetAll
        End If
    End Sub

    Private Sub editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editar.Click
        Dim fila As Byte
        Dim i As Integer
        fila = CByte(Me.DataGridView1.CurrentCell.RowIndex())
        Dim trabajador1 As TrabajadoresObject
        i = CInt(CDec(Me.DataGridView1.Item(0, fila).Value()))
        trabajador1 = TrabajadoresMapper.Instance.GetOne(i)
        Me.nombre.Text = CStr(trabajador1.Nombres)
        Me.apellidos.Text = trabajador1.Apellidos
        Me.razonsocial.Text = trabajador1.Cargo
        Me.dni.Text = trabajador1.DNI
        Me.registro.Value = CDate(trabajador1.FecNacimiento)
        actuali = 1
    End Sub

    Private Sub todos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles todos.Click

    End Sub

    Private Sub PanelEx1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanelEx1.Click

    End Sub
End Class

