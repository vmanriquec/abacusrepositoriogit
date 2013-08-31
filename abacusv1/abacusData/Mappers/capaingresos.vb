
Imports abacusRules.Objects
Imports abacusRules.Entities
Imports Cooperator.Framework.Core
Imports Cooperator.Framework.Data
Imports Cooperator.Framework.Data.Exceptions
Imports System.Data.Common
Imports System.Reflection
Imports System
Imports System.Data.SqlClient
Public Class capaingresos
    Public Shared Sub Registraringreso(ByVal ingreso1 As ingreso)
        Dim cn As New SqlConnection(cox)
        Dim tr As SqlTransaction = Nothing
        Dim cmd As New SqlCommand("coop_Ingresos_Insertmio", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@IdIngresos", 0).Direction = ParameterDirection.Output
            cmd.Parameters.AddWithValue("@IdAlmacen", ingreso1.IdAlmacen)
            cmd.Parameters.AddWithValue("@IdTrabjador", ingreso1.IdTrabjador)
            cmd.Parameters.AddWithValue("@Fecha", ingreso1.Fecha)
            cmd.Parameters.AddWithValue("@TipDoc", ingreso1.TipDoc)
            cmd.Parameters.AddWithValue("@Serie", ingreso1.Serie)
            cmd.Parameters.AddWithValue("@Numero", ingreso1.Numero)
            cmd.Parameters.AddWithValue("@IdProveedor", ingreso1.IdProveedor)
            cmd.Parameters.AddWithValue("@ModoPago", ingreso1.ModoPago)
            cmd.Parameters.AddWithValue("@estado", ingreso1.estado)
            cmd.Parameters.AddWithValue("@valortotal", ingreso1.valortotal)
            cmd.Parameters.AddWithValue("@lote", ingreso1.lote)
        End With
        Try
            cn.Open()
            tr = cn.BeginTransaction
            cmd.Transaction = tr
            cmd.ExecuteNonQuery()

            tr.Commit()
        Catch ex As Exception
            tr.Rollback()
            Throw
        Finally
            cmd.Dispose()
            cmd = Nothing
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Dispose()
            cn.Close()
        End Try
    End Sub

    Public Shared Sub Registrardetalle(ByVal ingresodet As ingresodetalle)
        Dim cn As New SqlConnection(cox)
        Dim tr As SqlTransaction = Nothing
        Dim cmdD As New SqlCommand("coop_IngresosDet_Insertmio", cn)
        Dim cmd As New SqlCommand("coop_Ingresos_Insertmio", cn)
        cmdD.CommandType = CommandType.StoredProcedure
        Try
            cn.Open()
            tr = cn.BeginTransaction

            cmdD.Transaction = tr
            cmdD.Parameters.AddWithValue("@IdIngresos", ingresodet.IdIngresos)
            cmdD.Parameters.AddWithValue("@IdProducto", ingresodet.IdProducto)
            cmdD.Parameters.AddWithValue("@Cantidad", ingresodet.Cantidad)
            cmdD.Parameters.AddWithValue("@PU", ingresodet.PU)
            cmdD.Parameters.AddWithValue("@IdAlmacen", ingresodet.IdAlmacen)
            cmdD.Parameters.AddWithValue("@subtotal", ingresodet.subtotal)
            cmdD.Parameters.AddWithValue("@pventa", ingresodet.pventa)
            cmdD.ExecuteNonQuery()
            tr.Commit()
        Catch ex As Exception
            tr.Rollback()
            Throw
        Finally
            cmdD.Dispose()
            cmdD = Nothing
            cmd.Dispose()
            cmd = Nothing
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Dispose()
            cn.Close()
        End Try
    End Sub
    Public Shared Function listartodoslosingresos() As DataTable
        Using cn As New SqlClient.SqlConnection(cox)
            Using cmd As New SqlCommand("todosingresos", cn)
                cmd.CommandType = CommandType.StoredProcedure
                Using da As New SqlDataAdapter(cmd)
                    Try
                        Dim datos As New DataTable
                        da.Fill(datos)
                        Return datos
                    Catch ex As Exception
                        Throw ex
                    End Try
                End Using
            End Using
        End Using
    End Function
    Public Shared Function listartodoslosingresosporproveedor(ByVal IdProveedor As Integer) As DataTable
        Using cn As New SqlClient.SqlConnection(cox)
            Using cmd As New SqlClient.SqlCommand("coop_ingresosporproveedor", cn)
                cmd.Parameters.AddWithValue("@IdProveedor", IdProveedor)
                cmd.CommandType = CommandType.StoredProcedure
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Try
                        Dim datos As New DataTable
                        da.Fill(datos)
                        Return datos
                    Catch ex As Exception
                        Throw ex
                    End Try
                End Using
            End Using
        End Using
    End Function
    Public Shared Function listartodoslosingresosporproveedorconfecha(ByVal IdProveedor As Integer, ByVal fechainicio As Date, ByVal fechafin As Date) As DataTable
        Using cn As New SqlClient.SqlConnection(cox)
            Using cmd As New SqlClient.SqlCommand("coop_ingresosporproveedorconfecha", cn)
                cmd.Parameters.AddWithValue("@IdProveedor", IdProveedor)
                cmd.Parameters.AddWithValue("@fechainicio", fechainicio)
                cmd.Parameters.AddWithValue("@fechafin", fechafin)
                cmd.CommandType = CommandType.StoredProcedure
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Try
                        Dim datos As New DataTable
                        da.Fill(datos)
                        Return datos
                    Catch ex As Exception
                        Throw ex
                    End Try
                End Using
            End Using
        End Using
    End Function
    Public Shared Function listartodoslosingresospornumero(ByVal numero As String) As DataTable
        Using cn As New SqlClient.SqlConnection(cox)
            Using cmd As New SqlClient.SqlCommand("coop_ingresospornumero", cn)
                cmd.Parameters.AddWithValue("@Numero", numero)
                cmd.CommandType = CommandType.StoredProcedure
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Try
                        Dim datos As New DataTable
                        da.Fill(datos)
                        Return datos
                    Catch ex As Exception
                        Throw ex
                    End Try
                End Using
            End Using
        End Using
    End Function
    Public Shared Function listartodoslosingresosporserie(ByVal serie As String) As DataTable
        Using cn As New SqlClient.SqlConnection(cox)
            Using cmd As New SqlClient.SqlCommand("coop_ingresosporserie", cn)
                cmd.Parameters.AddWithValue("@Serie", serie)
                cmd.CommandType = CommandType.StoredProcedure
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Try
                        Dim datos As New DataTable
                        da.Fill(datos)
                        Return datos
                    Catch ex As Exception
                        Throw ex
                    End Try
                End Using
            End Using
        End Using
    End Function
    Public Shared Function listaringresoporcadena(ByVal cadena As String) As DataTable
        Using cn As New SqlClient.SqlConnection(cox)
            Using cmd As New SqlCommand(cadena, cn)
                cmd.CommandType = CommandType.Text
                Using da As New SqlDataAdapter(cmd)
                    Try
                        Dim datos As New DataTable
                        da.Fill(datos)
                        Return datos
                    Catch ex As Exception
                        Throw ex
                    End Try
                End Using
            End Using
        End Using
    End Function
    Public Shared Function listardetalleporingreso(ByVal ingreso1 As ingreso) As DataTable
        Using cn As New SqlClient.SqlConnection(cox)
            Using cmd As New SqlClient.SqlCommand("detalleporingreso", cn)
                cmd.Parameters.AddWithValue("@IdIngresos", ingreso1.IdIngresos)
                cmd.CommandType = CommandType.StoredProcedure
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Try
                        Dim datos As New DataTable
                        da.Fill(datos)
                        Return datos
                    Catch ex As Exception
                        Throw ex
                    End Try
                End Using
            End Using
        End Using
    End Function

    Public Shared Function listarsolodetalleporidingreso(ByVal idetingreso As Integer) As DataTable
        Using cn As New SqlClient.SqlConnection(cox)
            Using cmd As New SqlClient.SqlCommand("detalleporingreso", cn)
                cmd.Parameters.AddWithValue("@IdIngresos", idetingreso)
                cmd.CommandType = CommandType.StoredProcedure
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Try
                        Dim datos As New DataTable
                        da.Fill(datos)
                        Return datos
                    Catch ex As Exception
                        Throw ex
                    End Try
                End Using
            End Using
        End Using
    End Function
    Public Shared Sub actualizaringreso(ByVal ingreso1 As ingreso)
        Dim cn As New SqlConnection(cox)
        Dim tr As SqlTransaction = Nothing
        Dim cmd As New SqlCommand("coop_Ingresos_Updatemioo", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            cmd.Parameters.AddWithValue("@idingresos", ingreso1.IdIngresos)
            cmd.Parameters.AddWithValue("@IdAlmacen", ingreso1.IdAlmacen)
            cmd.Parameters.AddWithValue("@IdTrabjador", ingreso1.IdTrabjador)
            cmd.Parameters.AddWithValue("@Fecha", ingreso1.Fecha)
            cmd.Parameters.AddWithValue("@TipDoc", ingreso1.TipDoc)
            cmd.Parameters.AddWithValue("@Serie", ingreso1.Serie)
            cmd.Parameters.AddWithValue("@Numero", ingreso1.Numero)
            cmd.Parameters.AddWithValue("@IdProveedor", ingreso1.IdProveedor)
            cmd.Parameters.AddWithValue("@ModoPago", ingreso1.ModoPago)
            cmd.Parameters.AddWithValue("@estado", ingreso1.estado)
            cmd.Parameters.AddWithValue("@valortotal", ingreso1.valortotal)
            cmd.Parameters.AddWithValue("@lote", ingreso1.lote)
        End With
        Try
            cn.Open()
            tr = cn.BeginTransaction
            cmd.Transaction = tr
            cmd.ExecuteNonQuery()

            tr.Commit()
        Catch ex As Exception
            tr.Rollback()
            Throw
        Finally
            cmd.Dispose()
            cmd = Nothing
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Dispose()
            cn.Close()
        End Try
    End Sub

    Public Shared Sub actualizardetalle(ByVal ingresodet As ingresodetalle)
        Dim cn As New SqlConnection(cox)
        Dim tr As SqlTransaction = Nothing
        Dim cmdD As New SqlCommand("coop_IngresosDet_Updatemioo", cn)
        cmdD.CommandType = CommandType.StoredProcedure
        Try
            cn.Open()
            tr = cn.BeginTransaction
            cmdD.Transaction = tr
            cmdD.Parameters.AddWithValue("@IdIngresosDet", ingresodet.IdIngresosDet)
            cmdD.Parameters.AddWithValue("@IdIngresos", ingresodet.IdIngresos)
            cmdD.Parameters.AddWithValue("@IdProducto", ingresodet.IdProducto)
            cmdD.Parameters.AddWithValue("@Cantidad", ingresodet.Cantidad)
            cmdD.Parameters.AddWithValue("@PU", ingresodet.PU)
            cmdD.Parameters.AddWithValue("@IdAlmacen", ingresodet.IdAlmacen)
            cmdD.Parameters.AddWithValue("@subtotal", ingresodet.subtotal)
            cmdD.Parameters.AddWithValue("@pventa", ingresodet.pventa)
            cmdD.ExecuteNonQuery()
            tr.Commit()
        Catch ex As Exception
            tr.Rollback()
            Throw
        Finally
            cmdD.Dispose()
            cmdD = Nothing
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Dispose()
            cn.Close()
        End Try
    End Sub
    Public Shared Function eliminarsolodetalle(ByVal detingreso1 As ingresodetalle) As DataTable
        Dim tr As SqlClient.SqlTransaction
        Using cn As New SqlClient.SqlConnection(cox)
            Using cmd As New SqlClient.SqlCommand("eliminarsolodetlleingreso", cn)
                cmd.Parameters.AddWithValue("@IngresosDet", detingreso1.IdIngresosDet)
                cmd.CommandType = CommandType.StoredProcedure
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Try
                        cn.Open()
                        Dim datos As New DataTable
                        da.Fill(datos)
                        Return datos
                        tr = cn.BeginTransaction()
                        cmd.Transaction = tr
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        tr.Rollback()
                        Throw ex
                    End Try
                End Using
            End Using
        End Using
    End Function





    Public Shared Function eliminardetalleporingreso(ByVal i As Integer) As DataTable
        Dim tr As SqlClient.SqlTransaction
        Using cn As New SqlClient.SqlConnection(cox)
            Using cmd As New SqlClient.SqlCommand("coop_IngresosDet_DeleteByIngresosmiooo", cn)
                cmd.Parameters.AddWithValue("@IdIngresos", i)
                cmd.CommandType = CommandType.StoredProcedure
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Try
                        cn.Open()
                        Dim datos As New DataTable
                        da.Fill(datos)
                        Return datos
                        tr = cn.BeginTransaction()
                        cmd.Transaction = tr
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        tr.Rollback()
                        Throw ex
                    End Try
                End Using
            End Using
        End Using
    End Function

    Public Shared Function eliminaringreso(ByVal i As Integer) As DataTable
        Dim tr As SqlClient.SqlTransaction
        Using cn As New SqlClient.SqlConnection(cox)
            Using cmd As New SqlClient.SqlCommand("coop_Ingresos_Delete", cn)
                cmd.Parameters.AddWithValue("@IdIngresos", i)
                cmd.CommandType = CommandType.StoredProcedure
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Try
                        cn.Open()
                        Dim datos As New DataTable
                        da.Fill(datos)
                        Return datos
                        tr = cn.BeginTransaction()
                        cmd.Transaction = tr
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        tr.Rollback()
                        Throw ex
                    End Try
                End Using
            End Using
        End Using
    End Function

    Public Shared Sub actualizarundetalle(ByVal ingresodet As ingresodetalle)
        Dim cn As New SqlConnection(cox)
        Dim tr As SqlTransaction = Nothing
        Dim cmdD As New SqlCommand("coop_IngresosDet_Update", cn)
        cmdD.CommandType = CommandType.StoredProcedure
        Try
            cn.Open()
            tr = cn.BeginTransaction
            cmdD.Transaction = tr
            cmdD.Parameters.AddWithValue("@IdIngresosDet", ingresodet.IdIngresosDet)
            cmdD.Parameters.AddWithValue("@IdIngresos", ingresodet.IdIngresos)
            cmdD.Parameters.AddWithValue("@IdProducto", ingresodet.IdProducto)
            cmdD.Parameters.AddWithValue("@Cantidad", ingresodet.Cantidad)
            cmdD.Parameters.AddWithValue("@PU", ingresodet.PU)
            cmdD.Parameters.AddWithValue("@IdAlmacen", ingresodet.IdAlmacen)
            cmdD.Parameters.AddWithValue("@subtotal", ingresodet.subtotal)
            cmdD.Parameters.AddWithValue("@pventa", ingresodet.pventa)
            cmdD.ExecuteNonQuery()
            tr.Commit()
        Catch ex As Exception
            tr.Rollback()
            Throw
        Finally
            cmdD.Dispose()
            cmdD = Nothing

            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Dispose()
            cn.Close()
        End Try
    End Sub

End Class

