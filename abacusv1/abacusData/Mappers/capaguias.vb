Imports abacusRules.Objects
Imports abacusRules.Entities
Imports Cooperator.Framework.Core
Imports Cooperator.Framework.Data
Imports Cooperator.Framework.Data.Exceptions
Imports System.Data.Common
Imports System.Reflection
Imports System
Imports System.Data.SqlClient
Imports abacusRules
Public Class capaguias
    Public Shared Sub Registrarguias(ByVal guia1 As guia)
        Dim cn As New SqlConnection(cox)
        Dim tr As SqlTransaction = Nothing
        Dim cmd As New SqlCommand("coop_Guias_Insertmiooo", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@IdGuias", 0).Direction = ParameterDirection.Output
            cmd.Parameters.AddWithValue("@nguia", guia1.nguia)
            cmd.Parameters.AddWithValue("@sguia", guia1.sguia)
            cmd.Parameters.AddWithValue("@FecTraslado ", guia1.FecTraslado)
            cmd.Parameters.AddWithValue("@idcliente ", guia1.idcliente)
            cmd.Parameters.AddWithValue("@idalmacen ", guia1.idalmacen)
            cmd.Parameters.AddWithValue("@puntopartida ", guia1.puntopartida)
            cmd.Parameters.AddWithValue("@nfactura ", guia1.nfactura)
            cmd.Parameters.AddWithValue("@obsanulado", guia1.ObsAnulado)
            cmd.Parameters.AddWithValue("@estado", guia1.estado)
            cmd.Parameters.AddWithValue("@especotros", guia1.EspecOtros)
            cmd.Parameters.AddWithValue("@idtrabajador", guia1.idtrabajador)
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
    Public Shared Sub Registrardetalle(ByVal guiadetalle As guiadetalles)
        Dim cn As New SqlConnection(cox)
        Dim tr As SqlTransaction = Nothing
        Dim cmdD As New SqlCommand("coop_GuiasDet_Insertmiooo", cn)
        cmdD.CommandType = CommandType.StoredProcedure
        Try
            cn.Open()
            tr = cn.BeginTransaction

            cmdD.Transaction = tr
            cmdD.Parameters.AddWithValue("@Idguias", guiadetalle.IdGuias)
            cmdD.Parameters.AddWithValue("@IdProducto", guiadetalle.idproducto)
            cmdD.Parameters.AddWithValue("@Cantidad", guiadetalle.cantidad)
            cmdD.Parameters.AddWithValue("@idtienda", guiadetalle.IdTienda)
            cmdD.Parameters.AddWithValue("@idllegada", guiadetalle.idllegada)
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
    Public Shared Function listartodoslasguias() As DataTable
        Using cn As New SqlClient.SqlConnection(cox)
            Using cmd As New SqlCommand("coop_Guias_GetAllmioo", cn)
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
    Public Shared Function listartodoslasguiasporalmacen(ByVal Idalmacen As Integer) As DataTable
        Using cn As New SqlClient.SqlConnection(cox)
            Using cmd As New SqlClient.SqlCommand("coop_Guias_poralmacen", cn)
                cmd.Parameters.AddWithValue("@Idalmacen", Idalmacen)
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
    Public Shared Function listartodoslasguiasporalmacenfecha(ByVal Idalmacen As Integer, ByVal fechainicio As Date, ByVal fechafin As Date) As DataTable
        Using cn As New SqlClient.SqlConnection(cox)
            Using cmd As New SqlClient.SqlCommand("coop_ingresosporproveedorconfecha", cn)
                cmd.Parameters.AddWithValue("@idalmacen", Idalmacen)
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
    Public Shared Function listartodoslasguiaspornumero(ByVal nguia As String) As DataTable
        Using cn As New SqlClient.SqlConnection(cox)
            Using cmd As New SqlClient.SqlCommand("coop_Guias_pornumero", cn)
                cmd.Parameters.AddWithValue("@nguia", nguia)
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
    Public Shared Function listartodoslasguiasporserie(ByVal sguia As String) As DataTable
        Using cn As New SqlClient.SqlConnection(cox)
            Using cmd As New SqlClient.SqlCommand("coop_Guias_porserie", cn)
                cmd.Parameters.AddWithValue("@sguia", sguia)
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











    Public Shared Function listardetalleporidguia(ByVal id As Integer) As DataTable
        Using cn As New SqlClient.SqlConnection(cox)
            Using cmd As New SqlClient.SqlCommand("listardetalleporguia", cn)
                cmd.Parameters.AddWithValue("@Idguia", id)
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
    'Public Shared Function listarsolodetalleporidguia(ByVal guia1 As guia) As DataTable
    '    Using cn As New SqlClient.SqlConnection(cox)
    '        Using cmd As New SqlClient.SqlCommand("detalleporingreso", cn)
    '            cmd.Parameters.AddWithValue("@Idguias", guia1.IdGuias)
    '            cmd.CommandType = CommandType.StoredProcedure
    '            Using da As New SqlClient.SqlDataAdapter(cmd)
    '                Try
    '                    Dim datos As New DataTable
    '                    da.Fill(datos)
    '                    Return datos
    '                Catch ex As Exception
    '                    Throw ex
    '                End Try
    '            End Using
    '        End Using
    '    End Using
    'End Function
    'almacen es  punto de partida y puntodepartidaespuntodellegada 

    Public Shared Sub actualizarguia(ByVal guia1 As guia)
        Dim cn As New SqlConnection(cox)
        Dim tr As SqlTransaction = Nothing
        Dim cmd As New SqlCommand("coop_Guias_updatemiooo", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            cmd.Parameters.AddWithValue("@Idguias", guia1.IdGuias)
            cmd.Parameters.AddWithValue("@nguia", guia1.nguia)
            cmd.Parameters.AddWithValue("@sguia", guia1.sguia)
            cmd.Parameters.AddWithValue("@FecTraslado ", guia1.FecTraslado)
            cmd.Parameters.AddWithValue("@idcliente ", guia1.idcliente)
            cmd.Parameters.AddWithValue("@idalmacen ", guia1.idalmacen)
            cmd.Parameters.AddWithValue("@puntopartida ", guia1.puntopartida)
            cmd.Parameters.AddWithValue("@nfactura ", guia1.nfactura)
            cmd.Parameters.AddWithValue("@obsanulado", guia1.ObsAnulado)
            cmd.Parameters.AddWithValue("@estado", guia1.estado)
            cmd.Parameters.AddWithValue("@especotros", guia1.EspecOtros)
            cmd.Parameters.AddWithValue("@idtrabajador", guia1.idtrabajador)
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
    Public Shared Sub actualizardetalleguia(ByVal guiadetalle As guiadetalles)
        Dim cn As New SqlConnection(cox)
        Dim tr As SqlTransaction = Nothing
        Dim cmdD As New SqlCommand("coop_GuiasDet_Updatemioo", cn)
        cmdD.CommandType = CommandType.StoredProcedure
        Try
            cn.Open()
            tr = cn.BeginTransaction
            cmdD.Transaction = tr
            cmdD.Parameters.AddWithValue("@IdGuiasDet", guiadetalle.IdGuiasDet)
            cmdD.Parameters.AddWithValue("@Idguias", guiadetalle.IdGuias)
            cmdD.Parameters.AddWithValue("@IdProducto", guiadetalle.idproducto)
            cmdD.Parameters.AddWithValue("@Cantidad", guiadetalle.cantidad)
            cmdD.Parameters.AddWithValue("@idtienda", guiadetalle.IdTienda)
            cmdD.Parameters.AddWithValue("@idllegada", guiadetalle.idllegada)
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
    Public Shared Function eliminarsolodetalleguia(ByVal detguia1 As guiadetalles) As DataTable
        Dim tr As SqlClient.SqlTransaction
        Using cn As New SqlClient.SqlConnection(cox)
            Using cmd As New SqlClient.SqlCommand("coop_GuiasDet_Deletemio", cn)
                cmd.Parameters.AddWithValue("@IdGuiasDet", detguia1.IdGuiasDet)
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
    Public Shared Function eliminardetalleporguia(ByVal i As Integer) As DataTable
        Dim tr As SqlClient.SqlTransaction
        Using cn As New SqlClient.SqlConnection(cox)
            Using cmd As New SqlClient.SqlCommand("coop_GuiasDet_DeleteByGuias", cn)
                cmd.Parameters.AddWithValue("@IdGuias", i)
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
    Public Shared Function eliminarguia(ByVal i As Integer) As DataTable
        Dim tr As SqlClient.SqlTransaction
        Using cn As New SqlClient.SqlConnection(cox)
            Using cmd As New SqlClient.SqlCommand("coop_Guias_Delete", cn)
                cmd.Parameters.AddWithValue("@IdGuias", i)
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
    Public Shared Function listarguiagetone(ByVal idguias As Integer) As DataRow
        Using cn As New SqlClient.SqlConnection(cox)
            Using cmd As New SqlClient.SqlCommand("coop_Guias_GetOnemio", cn)
                cmd.Parameters.AddWithValue("@idguias", idguias)
                cmd.CommandType = CommandType.StoredProcedure
                Using da As New SqlClient.SqlDataAdapter(cmd)
                    Try
                        Dim datos As New DataTable
                        da.Fill(datos)
                        Return datos.Rows(0)
                    Catch ex As Exception
                        Throw ex
                    End Try
                End Using
            End Using
        End Using
    End Function


End Class

