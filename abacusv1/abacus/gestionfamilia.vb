Imports abacusRules.Objects
Imports abacusRules.Entities
Imports abacusRules.Mappers
Imports abacusRules.micapadatos
Imports abacusRules

Public Class gestionfamilia
    Dim actuali, siempreid As Integer
    Private Sub cargartodos()
        Me.DataGridView1.DataSource = capafamilias.cargartodoasfamilias
    End Sub
    Private Sub limpiar()
        Me.txtfamilia.Text = ""
    End Sub
    Private Sub bloquear()
        Me.txtfamilia.Enabled = False
    End Sub
    Private Sub habilitar()
        Me.txtfamilia.Enabled = True
    End Sub
    Private Sub editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim fila As Byte
        fila = CByte(Me.DataGridView1.CurrentCell.RowIndex())
        Dim familia1 As New familia
        familia1.IdFamilia = CInt(CDec(Me.DataGridView1.Item(0, fila).Value()))
        Dim st As DataRow
        st = capafamilias.listarfamiliaporid(familia1)
        Me.txtfamilia.Text = CStr(st.Item("Familia"))
        actuali = 1
    End Sub

    Private Sub KryptonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiar()
        actuali = 0
    End Sub
    Private Sub nuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiar()
        actuali = 0
    End Sub

    Private Sub grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        If txtfamilia.Text = "" Then
            MsgBox(" debe llenar un dato solicitado")
        Else
            If actuali <> 1 Then

                Dim familia1 As New familia
                familia1.Familia = Me.txtfamilia.Text
                capafamilias.familia_Insert(familia1)
                MsgBox("se agrego un nuevo registro")
                limpiar()
            Else
                Dim fila As Byte
                Dim i As Integer
                fila = CByte(Me.DataGridView1.CurrentCell.RowIndex())
                i = CInt(CDec(Me.DataGridView1.Item(0, fila).Value()))
                Dim familia1 As New familia
                familia1.IdFamilia = i
                familia1.Familia = Me.txtfamilia.Text
                capafamilias.actualizarfamilia(familia1)
                MsgBox("se modifico el registro")
                limpiar()

            End If
            cargartodos()

        End If

    End Sub

    Private Sub eliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.DataGridView1.RowCount = 0 Then
            MsgBox("busque primero el registro")
        Else
            Dim fila As Byte
            Dim i As Integer
            fila = CByte(Me.DataGridView1.CurrentCell.RowIndex())
            Dim familia1 As New familia
            i = CInt(CDec(Me.DataGridView1.Item(0, fila).Value()))
            familia1.IdFamilia = i
            capafamilias.eliminarfamilia(familia1)
            MsgBox("registro eliminada con exito")
            cargartodos()
        End If

    End Sub

    Private Sub todos_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cargartodos()
    End Sub

    Private Sub gestionfamilia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class