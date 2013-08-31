
Imports abacusRules.Objects
Imports abacusRules.Entities
Imports Cooperator.Framework.Core
Imports Cooperator.Framework.Data
Imports Cooperator.Framework.Data.Exceptions
Imports System.Data.Common
Imports System.Reflection
Imports System
Imports System.Data.SqlClient
Public Class capaproveedores

    Public Shared Function cargarcomboconcatenadoproveedores() As DataTable
        Using cn As New SqlConnection(cox)
            Using cmd As New SqlCommand("concatenadonombresdetproveedores", cn)
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



    Public Shared Function cargartodosproveedores() As DataTable
        Using cn As New SqlConnection(cox)
            Using cmd As New SqlCommand("listartodoslosproveedores", cn)
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
    Public Shared Sub proveedores_Insert(ByVal proveedores As proveedor)
        Dim tr As SqlClient.SqlTransaction
        Using cn As New SqlClient.SqlConnection(cox)
            Using cmd As New SqlClient.SqlCommand("coop_Proveedores_Insertmio", cn)
                cmd.Parameters.AddWithValue("@Nombre", proveedores.Nombre)
                cmd.Parameters.AddWithValue("@Apellido", proveedores.Apellido)
                cmd.Parameters.AddWithValue("@NomComercial", proveedores.NomComercial)
                cmd.Parameters.AddWithValue("@DI", proveedores.DI)
                cmd.Parameters.AddWithValue("@Direccionp", proveedores.Direccionp)
                cmd.Parameters.AddWithValue("@Distritop", proveedores.Distritop)
                cmd.Parameters.AddWithValue("@Provinciap", proveedores.Provinciap)
                cmd.Parameters.AddWithValue("@Telefono1p", proveedores.Telefono1p)
                cmd.Parameters.AddWithValue("@Faxp", proveedores.Faxp)
                cmd.Parameters.AddWithValue("@Emailp", proveedores.Emailp)
                cmd.Parameters.AddWithValue("@Webp", proveedores.Webp)
                cmd.Parameters.AddWithValue("@Observaciones", proveedores.Observaciones)
                cmd.Parameters.AddWithValue("@estado", proveedores.estado)
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
    Public Shared Function listarproveedorporid(ByVal proveedor1 As proveedor) As DataRow
        Using cn As New SqlClient.SqlConnection(cox)
            Using cmd As New SqlClient.SqlCommand("coop_Proveedores_GetOne", cn)
                cmd.Parameters.AddWithValue("@IdProveedor", proveedor1.IdProveedor)
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
    Public Shared Sub actualizarfamilia(ByVal proveedores As proveedor)
        Dim t As SqlClient.SqlTransaction
        Using cn As New SqlClient.SqlConnection(cox)
            Using cmd As New SqlClient.SqlCommand("coop_Proveedores_Update", cn)
                cmd.Parameters.AddWithValue("@IdProveedor", proveedores.Nombre)
                cmd.Parameters.AddWithValue("@Nombre", proveedores.Nombre)
                cmd.Parameters.AddWithValue("@Apellido", proveedores.Apellido)
                cmd.Parameters.AddWithValue("@NomComercial", proveedores.NomComercial)
                cmd.Parameters.AddWithValue("@DI", proveedores.DI)
                cmd.Parameters.AddWithValue("@Direccionp", proveedores.Direccionp)
                cmd.Parameters.AddWithValue("@Distritop", proveedores.Distritop)
                cmd.Parameters.AddWithValue("@Provinciap", proveedores.Provinciap)
                cmd.Parameters.AddWithValue("@Telefono1p", proveedores.Telefono1p)
                cmd.Parameters.AddWithValue("@Faxp", proveedores.Faxp)
                cmd.Parameters.AddWithValue("@Emailp", proveedores.Emailp)
                cmd.Parameters.AddWithValue("@Webp", proveedores.Webp)
                cmd.Parameters.AddWithValue("@Observaciones", proveedores.Observaciones)
                cmd.Parameters.AddWithValue("@estado", proveedores.estado)
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


    Public Shared Function eliminarproveedor(ByVal proveedores As proveedor) As DataTable
        Dim tr As SqlClient.SqlTransaction
        Using cn As New SqlClient.SqlConnection(cox)
            Using cmd As New SqlClient.SqlCommand("coop_Proveedores_Delete", cn)
                cmd.Parameters.AddWithValue("@IdProveedor", proveedores.IdProveedor)
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
