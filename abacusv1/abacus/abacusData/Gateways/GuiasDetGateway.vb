
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 15/08/2013 - 05:51 p.m.
' This is a partial class file. The other one is GuiasDetGateway.Auto.vb
' You can edit this file as your wish.
'------------------------------------------------------------------------------

Imports abacusRules.Objects
Imports Cooperator.Framework.Core
Imports Cooperator.Framework.Data
Imports Cooperator.Framework.Data.Exceptions
Imports System.Data.Common
Imports System.Reflection
Imports System

Namespace Gateways

    ''' <summary>
    ''' Gateway between GuiasDetObject class and GuiasDet table.
    ''' This class provide CRUD methods for GuiasDet table.
    ''' </summary>
    Public Partial Class GuiasDetGateway

        ' ''' <summary>
        ' ''' Enables GetObjectBySQLText and GetObjectListBySQLText methods.
        ' ''' </summary>
        'Protected Overrides Function SQLQueriesEnabled() As Boolean
        '    Return True
        'End Function

        ' ''' <summary>
        ' ''' Checks for security ritghs
        ' ''' </summary>
        'Protected Overrides Function CheckForSecurityRights(ByVal action As SecurityRights, ByVal ObjectListOrEntityList As GuiasDetObjectList) As Boolean
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

    End Class

End Namespace



