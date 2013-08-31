
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 15/08/2013 - 05:51 p.m.
' This is a partial class file. The other one is CategoriasMapper.Auto.cs
' You can edit this file as your wish.
'------------------------------------------------------------------------------



Imports abacusRules.Objects
Imports abacusRules.Entities
Imports Cooperator.Framework.Core
Imports Cooperator.Framework.Data
Imports Cooperator.Framework.Data.Exceptions
Imports System.Data.Common
Imports System.Reflection
Imports System
Imports System.Data.SqlClient

Namespace Mappers

    ''' <summary>
    ''' Mapper for Categorias entity
    ''' This class provide persistence methods for this entity
    ''' </summary>
    Public Partial Class CategoriasMapper

        ' ''' <summary>
        ' ''' Enables GetObjectBySQLText and GetObjectListBySQLText methods.
        ' ''' </summary>
        'Protected Overrides Function SQLQueriesEnabled() As Boolean
        '    Return True
        'End Function

        ' ''' <summary>
        ' ''' Checks for security ritghs
        ' ''' </summary>
        'Protected Overrides Function CheckForSecurityRights(ByVal action As SecurityRights, ByVal ObjectListOrEntityList As CategoriasList) As Boolean
        '    Select Case action
        '        Case SecurityRights.Read
        '            Return True
        '        Case SecurityRights.Insert
        '            Return True
        '        Case SecurityRights.Update
        '            Return True
        '        Case SecurityRights.Delete
        '            Return True
        '    End Select
        'End Function

        Public Shared Function cargarcomboconcatenadocategoriaproducto() As DataTable
            Using cn As New SqlConnection(cox)
                Using cmd As New SqlCommand("coop_Categorias_GetAll", cn)
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
End Namespace

Namespace Loaders

    ''' <summary>
    ''' Loader for Categorias entity
    ''' This class provide get methods for this entity
    ''' </summary>
    Public Partial Class CategoriasLoader
    End Class

End Namespace



