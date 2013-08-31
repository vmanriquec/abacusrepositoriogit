Imports abacusRules.Objects
Imports abacusRules.Entities
Imports Cooperator.Framework.Core
Imports Cooperator.Framework.Data
Imports Cooperator.Framework.Data.Exceptions
Imports System.Data.Common
Imports System.Reflection
Imports System
Imports System.Data.SqlClient
Public Class capadevisitas
    Public Shared Sub actualizarvisita(ByVal visita2 As visita1)
        Dim t As SqlClient.SqlTransaction
        Using cn As New SqlClient.SqlConnection(cox)
            Using cmd As New SqlClient.SqlCommand("coop_registrodevisitas_Update", cn)
                cmd.Parameters.AddWithValue("@Idvisitas", visita2.Idvisitas)
                cmd.Parameters.AddWithValue("@IdTrabjador", visita2.IdTrabjador)
                cmd.Parameters.AddWithValue("@idruta", visita2.idruta)
                cmd.Parameters.AddWithValue("@fechavisita", visita2.fechavisita)
                cmd.Parameters.AddWithValue("@observaciones", visita2.observaciones)
                cmd.Parameters.AddWithValue("@idtrabajador2", visita2.idtrabajador2)
                cmd.Parameters.AddWithValue("@estado", visita2.estado)
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

End Class
