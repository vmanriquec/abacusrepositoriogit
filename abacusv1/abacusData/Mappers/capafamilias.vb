

Imports abacusRules.Objects
Imports abacusRules.Entities
Imports Cooperator.Framework.Core
Imports Cooperator.Framework.Data
Imports Cooperator.Framework.Data.Exceptions
Imports System.Data.Common
Imports System.Reflection
Imports System
Imports System.Data.SqlClient


Public Class capafamilias
    Public Shared Function cargartodoasfamilias() As DataTable
        Using cn As New SqlConnection(cox)
            Using cmd As New SqlCommand("coop_Familias_GetAll", cn)
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




    Public Shared Function cargarcombofamilias() As DataTable
        Using cn As New SqlConnection(cox)
            Using cmd As New SqlCommand("coop_Familias_GetAll", cn)
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














    Public Shared Sub familia_Insert(ByVal familia1 As familia)
        Dim tr As SqlClient.SqlTransaction
        Using cn As New SqlClient.SqlConnection(cox)
            Using cmd As New SqlClient.SqlCommand("coop_Familias_Insertmio", cn)
                cmd.Parameters.AddWithValue("@Familia", familia1.Familia)
                cmd.CommandType = CommandType.StoredProcedure
                Try
                    cn.Open()
                    tr = cn.BeginTransaction()
                    cmd.Transaction = tr
                    cmd.ExecuteNonQuery()
                    tr.Commit()
                Catch ex As Exception
                    tr.Rollback()
                    Throw ex
                End Try
            End Using
        End Using
    End Sub
    Public Shared Function listarfamiliaporid(ByVal familia1 As familia) As DataRow
        Using cn As New SqlClient.SqlConnection(cox)
            Using cmd As New SqlClient.SqlCommand("coop_Familias_GetOne", cn)
                cmd.Parameters.AddWithValue("@IdFamilia", familia1.IdFamilia)
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
    Public Shared Sub actualizarfamilia(ByVal familia1 As familia)
        Dim t As SqlClient.SqlTransaction
        Using cn As New SqlClient.SqlConnection(cox)
            Using cmd As New SqlClient.SqlCommand("coop_Familias_Update", cn)
                cmd.Parameters.AddWithValue("@IdFamilia", familia1.IdFamilia)
                cmd.Parameters.AddWithValue("@Familia", familia1.Familia)
                cmd.CommandType = CommandType.StoredProcedure
                Try
                    cn.Open()
                    t = cn.BeginTransaction()
                    cmd.Transaction = t
                    cmd.ExecuteNonQuery()
                    t.Commit()

                Catch ex As Exception
                    t.Rollback()
                    Throw ex
                End Try
            End Using
        End Using
    End Sub


    Public Shared Function eliminarfamilia(ByVal familia1 As familia) As DataTable
        Dim tr As SqlClient.SqlTransaction
        Using cn As New SqlClient.SqlConnection(cox)
            Using cmd As New SqlClient.SqlCommand("coop_Familias_Delete", cn)
                cmd.Parameters.AddWithValue("@IdFamilia", familia1.IdFamilia)
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

End Class
