﻿Imports abacusRules.Objects
Imports abacusRules.Entities
Imports abacusRules.Mappers
Imports abacusRules.micapadatos
Public Class categoriasdeproductos

    Dim actuali, siempreid As Integer
    Private Sub cargartodos()
        Me.DataGridView1.DataSource = CategoriasMapper.Instance.GetAll
    End Sub
    Private Sub limpiar()
        Me.txtcategoria.Text = ""
        Me.cbofamilia.Text = ""
    End Sub
    Private Sub bloquear()
        Me.txtcategoria.Enabled = False
        Me.cbofamilia.Enabled = False
    End Sub
    Private Sub habilitar()
        Me.txtcategoria.Enabled = True
        Me.cbofamilia.Enabled = True
    End Sub
    Public Shared Sub cargarcombofamilia(ByVal cbo As ComboBox)
        Try
            cbo.DataSource = FamiliasMapper.cargarcombofamilias()
            cbo.DisplayMember = "Familia"
            cbo.ValueMember = "IdFamilia"
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub KryptonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiar()
    End Sub

    Private Sub registrorutas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarcombofamilia(Me.cbofamilia)

    End Sub

    Private Sub nuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiar()
    End Sub

    Private Sub todos_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cargartodos()
    End Sub

    Private Sub grabar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtcategoria.Text = "" Then

            MsgBox("debe llenar los datos ")
        Else

            If actuali <> 1 Then

                Dim categorias1 As New Categorias
                categorias1.Categoria = Me.txtcategoria.Text
                categorias1.IdFamilia = CType(Me.cbofamilia.SelectedValue.ToString, Integer?)
                CategoriasMapper.Instance.Insert(categorias1)
                MsgBox("se agrego una nueva ruta")
                limpiar()

            Else
                Dim fila As Byte
                Dim i As Integer
                fila = CByte(Me.DataGridView1.CurrentCell.RowIndex())
                i = CInt(CDec(Me.DataGridView1.Item(0, fila).Value()))
                Dim categorias1 As New abacusRules.Entities.Categorias

                categorias1 = CategoriasMapper.Instance.GetOne(i)
                categorias1.Categoria = Me.txtcategoria.Text
                categorias1.IdFamilia = CType(Me.cbofamilia.SelectedValue.ToString, Integer?)
                CategoriasMapper.Instance.Save(categorias1)
                MsgBox("se actualizo ruta")
                limpiar()
            End If
            cargartodos()
        End If
    End Sub

    Private Sub eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.DataGridView1.RowCount = 0 Then
            MsgBox("busque primero la ruta")
        Else
            Dim fila As Byte
            Dim i As Integer
            fila = CByte(Me.DataGridView1.CurrentCell.RowIndex())
            Dim categorias1 As New Categorias
            i = CInt(CDec(Me.DataGridView1.Item(0, fila).Value()))
            CategoriasMapper.Instance.Delete(i)
            MsgBox("ruta eliminada con exito")
            cargartodos()
        End If

    End Sub

    Private Sub editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim fila As Byte
        Dim i As Integer
        fila = CByte(Me.DataGridView1.CurrentCell.RowIndex())
        Dim categorias1 As CategoriasObject
        i = CInt(CDec(Me.DataGridView1.Item(0, fila).Value()))
        categorias1 = CategoriasMapper.Instance.GetOne(i)
        Me.txtcategoria.Text = CStr(categorias1.Categoria)
        Me.cbofamilia.SelectedValue = categorias1.IdFamilia
        actuali = 1
    End Sub

    Private Sub todos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cargartodos()
    End Sub
End Class