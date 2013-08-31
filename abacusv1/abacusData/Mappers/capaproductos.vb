
Imports abacusRules.Objects
Imports abacusRules.Entities
Imports Cooperator.Framework.Core
Imports Cooperator.Framework.Data
Imports Cooperator.Framework.Data.Exceptions
Imports System.Data.Common
Imports System.Reflection
Imports System
Imports System.Data.SqlClient
Public Class capaproductos
    Public Shared Function cargartodosproductos() As DataTable
        Using cn As New SqlConnection(cox)
            Using cmd As New SqlCommand("todosproductos", cn)
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
    Public Shared Function cargarcomboproductos() As DataTable
        Using cn As New SqlConnection(cox)
            Using cmd As New SqlCommand("concatenadoproductoscombo", cn)
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

End Class
