Imports abacusRules.Objects
Imports abacusRules.Entities
Imports abacusRules.Mappers
Imports abacusRules.micapadatos
Public Class clientedireccionruta
    Dim actuali, siempreid As Integer
    Private Sub cargartodos()
        Me.DataGridView1.DataSource = idcrdMapper.Instance.GetAll
    End Sub

    Public Shared Sub cargarcombonombrecliente(ByVal cbo As ComboBox)
        Try
            cbo.DataSource = ClientesMapper.cargarnombrecliente()
            cbo.DisplayMember = "Nombre"
            cbo.ValueMember = "IdCliente"
             Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Public Shared Sub cargarcomborutas(ByVal cbo As ComboBox)
        Try
            cbo.DataSource = rutaMapper.cargarnombreruta()
            cbo.DisplayMember = "nombreruta"
            cbo.ValueMember = "Idruta"

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub clientedireccionruta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarcombonombrecliente(Me.cbocliente)
        cargarcomborutas(Me.cboruta)
    End Sub
    Private Sub limpiar()
        Me.cbocliente.Text = ""
        Me.cboruta.Text = ""
        Me.txtobservacion.Text = ""
        Me.txtdireccion.Text = ""
    End Sub
    Private Sub bloquear()
        Me.cbocliente.Enabled = False
        Me.cboruta.Enabled = False
        Me.txtobservacion.Enabled = False
        Me.txtdireccion.Enabled = False
    End Sub
    Private Sub habilitar()
        Me.cbocliente.Enabled = True
        Me.cboruta.Enabled = True
        Me.txtobservacion.Enabled = True
        Me.txtdireccion.Enabled = True
    End Sub
    Private Sub editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        If Me.DataGridView1.RowCount = 0 Then
            MsgBox("busque primero la ruta")
        Else


            Dim fila As Byte
            Dim i As Integer
            fila = CByte(Me.DataGridView1.CurrentCell.RowIndex())
            Dim idcrd1 As idcrdObject
            i = CInt(CDec(Me.DataGridView1.Item(0, fila).Value()))
            idcrd1 = idcrdMapper.Instance.GetOne(i)
            Me.cbocliente.SelectedValue = idcrd1.idcliente
            Me.cboruta.SelectedValue = idcrd1.idruta
            Me.txtobservacion.Text = idcrd1.observacion
            Me.txtdireccion.Text = idcrd1.direcciontienda
            actuali = 1
        End If
    End Sub

    Private Sub KryptonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiar()
    End Sub

    Private Sub nuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiar()
    End Sub

    Private Sub grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If actuali <> 1 Then

            Dim idcrd1 As New idcrd
            idcrd1.idcliente = CType(Me.cbocliente.SelectedValue.ToString, Integer?)
            idcrd1.idruta = CType(Me.cboruta.SelectedValue.ToString, Integer?)
            idcrd1.observacion = Me.txtobservacion.Text
            idcrd1.direcciontienda = Me.txtdireccion.Text
            idcrdMapper.Instance.Insert(idcrd1)
            MsgBox("se agrego una nueva ruta")
        Else
            Dim fila As Byte
            Dim i As Integer
            fila = CByte(Me.DataGridView1.CurrentCell.RowIndex())
            i = CInt(CDec(Me.DataGridView1.Item(0, fila).Value()))

            Dim idcrd1 As New abacusRules.Entities.idcrd
            idcrd1.idcliente = CType(Me.cbocliente.SelectedValue.ToString, Integer?)
            idcrd1.idruta = CType(Me.cboruta.SelectedValue.ToString, Integer?)
            idcrd1.observacion = Me.txtobservacion.Text
            idcrd1.direcciontienda = Me.txtdireccion.Text
            idcrdMapper.Instance.Save(idcrd1)
            MsgBox("se actualizo ruta")
        End If
        cargartodos()
    End Sub

    Private Sub eliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.DataGridView1.RowCount = 0 Then
            MsgBox("busque primero la ruta")
        Else
            Dim fila As Byte
            Dim i As Integer
            fila = CByte(Me.DataGridView1.CurrentCell.RowIndex())
            Dim idcrd1 As New idcrd
            i = CInt(CDec(Me.DataGridView1.Item(0, fila).Value()))
            idcrdMapper.Instance.Delete(i)
            MsgBox("ruta eliminada con exito")
            cargartodos()

        End If

    End Sub

    Private Sub todos_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cargartodos()
    End Sub






End Class