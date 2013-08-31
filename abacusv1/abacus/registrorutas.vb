Imports abacusRules.Objects
Imports abacusRules.Entities
Imports abacusRules.Mappers
Imports abacusRules.micapadatos
Public Class registrorutas
    Dim actuali, siempreid As Integer
    Private Sub cargartodos()
        Me.DataGridView1.DataSource = rutaMapper.Instance.GetAll
    End Sub
    Private Sub limpiar()
        Me.txtcodigoruta.Text = ""
        Me.txtnombreruta.Text = ""
        Me.txtobservacion.Text = ""
        Me.cbodistrito.Text = ""
    End Sub
    Private Sub bloquear()
        Me.txtcodigoruta.Enabled = False
        Me.txtnombreruta.Enabled = False
        Me.txtobservacion.Enabled = False
        Me.cbodistrito.Enabled = False
    End Sub
    Private Sub habilitar()
        Me.txtcodigoruta.Enabled = True
        Me.txtnombreruta.Enabled = True
        Me.txtobservacion.Enabled = True
        Me.cbodistrito.Enabled = True
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
    Private Sub editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim fila As Byte
        Dim i As Integer
        fila = CByte(Me.DataGridView1.CurrentCell.RowIndex())
        Dim ruta1 As rutaObject
        i = CInt(CDec(Me.DataGridView1.Item(0, fila).Value()))
        ruta1 = rutaMapper.Instance.GetOne(i)
        Me.txtcodigoruta.Text = CStr(ruta1.codigoruta)
        Me.txtnombreruta.Text = ruta1.nombreruta
        Me.txtobservacion.Text = ruta1.observacionruta
        Me.cbodistrito.SelectedValue = ruta1.iddistrito
        actuali = 1
    End Sub

    Private Sub KryptonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiar()
    End Sub
    
    Private Sub registrorutas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarcombodistrito(Me.cbodistrito)

    End Sub

    Private Sub nuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiar()
    End Sub

    Private Sub grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If actuali <> 1 Then

            Dim ruta1 As New ruta
            ruta1.codigoruta = Me.txtcodigoruta.Text
            ruta1.nombreruta = Me.txtnombreruta.Text
            ruta1.observacionruta = Me.txtobservacion.Text
            ruta1.iddistrito = CType(Me.cbodistrito.SelectedValue.ToString, Integer?)
            rutaMapper.Instance.Insert(ruta1)
            MsgBox("se agrego una nueva ruta")
            limpiar()

        Else
            Dim fila As Byte
            Dim i As Integer
            fila = CByte(Me.DataGridView1.CurrentCell.RowIndex())
            i = CInt(CDec(Me.DataGridView1.Item(0, fila).Value()))
            Dim ruta1 As New abacusRules.Entities.ruta
            ruta1 = rutaMapper.Instance.GetOne(i)
            ruta1.codigoruta = Me.txtcodigoruta.Text
            ruta1.nombreruta = Me.txtnombreruta.Text
            ruta1.observacionruta = Me.txtobservacion.Text
            ruta1.iddistrito = CType(Me.cbodistrito.SelectedValue.ToString, Integer?)
            rutaMapper.Instance.Save(ruta1)
            MsgBox("se actualizo ruta")
            limpiar()
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
            Dim ruta1 As New ruta
            i = CInt(CDec(Me.DataGridView1.Item(0, fila).Value()))
            rutaMapper.Instance.Delete(i)
            MsgBox("ruta eliminada con exito")
            cargartodos()
        End If

    End Sub

    Private Sub todos_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cargartodos()
    End Sub

   
End Class


