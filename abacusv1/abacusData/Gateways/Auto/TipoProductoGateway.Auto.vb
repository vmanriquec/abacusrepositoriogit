
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 20/08/2013 - 01:48 p.m.
' This is a partial class file. The other one is TipoProductoGateway.vb
' You should not modifiy this file, please edit the other partial class file.
'------------------------------------------------------------------------------

Imports System
Imports abacusRules.Objects
Imports Cooperator.Framework.Data
Imports Cooperator.Framework.Data.Exceptions
Imports Cooperator.Framework.Core
Imports System.Data.Common
Imports System.Reflection
Imports System.Web

Namespace Gateways
        
    Public Partial Class TipoProductoGateway 
        Inherits BaseGateway(Of TipoProductoObject, TipoProductoObjectList)
        Implements IGenericGateway

#Region "Singleton"

        Private Shared _instance As TipoProductoGateway

        Private Sub New()
        End Sub

        Public Shared Function Instance() As TipoProductoGateway
            If _instance Is Nothing Then
                If HttpContext.Current Is Nothing Then
                    _instance = New TipoProductoGateway()
                Else
                    Dim inst As TipoProductoGateway = TryCast(HttpContext.Current.Items("abacusRules.TipoProductoGatewaySingleton"), TipoProductoGateway)
                    If inst Is Nothing Then
                        inst = New TipoProductoGateway()
                        HttpContext.Current.Items.Add("abacusRules.TipoProductoGatewaySingleton", inst)
                    End If
                    Return inst
                End If
            End If
            Return _instance
        End Function

#End Region

        ''' <summary>
        ''' Return the mapped table name
        ''' </summary>
        Protected Overrides ReadOnly Property TableName() As String
            Get
                Return "TipoProducto"
            End Get
        End Property

        ''' <summary>
        ''' Return the TipoProductoGateway type FullName
        ''' </summary>
        Protected Overrides ReadOnly Property RuleName() As String
            Get
                Return GetType(TipoProductoGateway ).FullName
            End Get
        End Property


        

        


        ''' <summary>
        ''' Assign properties values based on DataReader
        ''' </summary>
        Protected Overrides Sub HydrateFields(ByVal reader As DbDataReader, ByVal entity As TipoProductoObject )
            Dim _TipoProducto As String
If reader.IsDBNull(1) Then 
	 _TipoProducto = ""
Else
	 _TipoProducto = reader.GetString(1)
End If

            Dim TipoProducto As IMappeableTipoProductoObject  = CType(entity, IMappeableTipoProductoObject)
            TipoProducto.HydrateFields(reader.GetInt32(0), _
_TipoProducto)
            CType(entity, IObject).State = ObjectState.Restored
        End Sub

        ''' <summary>
        ''' Get field values to call insertion stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForInsert(ByVal entity As TipoProductoObject) As Object()
            Dim TipoProducto As IMappeableTipoProductoObject = CType(entity, IMappeableTipoProductoObject)
            Return TipoProducto.GetFieldsForInsert()
        End Function

        ''' <summary>
        ''' Get field values to call update stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForUpdate(ByVal entity As TipoProductoObject) As Object()
            Dim TipoProducto As IMappeableTipoProductoObject = CType(entity, IMappeableTipoProductoObject)
            Return TipoProducto.GetFieldsForUpdate()
        End Function

        ''' <summary>
        ''' Get field values to call deletion stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForDelete(ByVal entity As TipoProductoObject) As Object()
            Dim TipoProducto As IMappeableTipoProductoObject = CType(entity, IMappeableTipoProductoObject)
            Return TipoProducto.GetFieldsForDelete()
        End Function

        ''' <summary>
        ''' Raised after insert and update. Update properties from Output parameters
        ''' </summary>
        Protected Overrides Sub UpdateObjectFromOutputParams(ByVal row As TipoProductoObject, parameters As Object())
            ' Update properties from Output parameters
            CType(row, IMappeableTipoProductoObject).UpdateObjectFromOutputParams(parameters)
            CType(row, IObject).State = ObjectState.Restored
        End Sub

        ''' <summary>
        ''' StoredProceduresPrefix, for example: coop_
        ''' </summary>
        Protected Overrides Function StoredProceduresPrefix() As String
            Return "coop_"
        End Function


        ''' <summary>
        ''' Get a TipoProductoObject by execute a SQL Query Text
        ''' </summary>
        Public Function GetOneBySQLQuery(sqlQueryText As String) As TipoProductoObject 
            Return MyBase.GetObjectBySQLText(sqlQueryText)
        End Function

        ''' <summary>
        ''' Get a TipoProductoObjectList by execute a SQL Query Text
        ''' </summary>
        Public Function GetBySQLQuery(sqlQueryText As String) As TipoProductoObjectList 
            Return MyBase.GetObjectListBySQLText(sqlQueryText)
        End Function



        ''' <summary>
        ''' Get a TipoProductoObject by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetOne(ByVal Id_TipoProducto As System.Int32) As TipoProductoObject         
            Return MyBase.GetOne(New TipoProductoObject(Id_TipoProducto))
        End Function

            


        


        

        
        ''' <summary>
        ''' Delete TipoProducto 
        ''' </summary>
        Public Overloads Sub Delete(ByVal Id_TipoProducto As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "TipoProducto_Delete", Id_TipoProducto)
        End Sub

        ''' <summary>
        ''' Delete TipoProducto
        ''' </summary>
        Public Overloads Sub Delete(transaction As DbTransaction , ByVal Id_TipoProducto As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "TipoProducto_Delete", Id_TipoProducto)
        End Sub

            



        

    

    

    


        'Database Queries 
        



        #Region "IGenericGateway"

        Private Function GetOne2(identifier As IUniqueIdentifiable) As Object Implements IGenericGateway.GetOne
            Return MyBase.GetOne(identifier)
        End Function

        Private Function GetAll2() As Object Implements IGenericGateway.GetAll
            Return MyBase.GetAll()
        End Function

        Private Function GeyByParent2(parentEntity As IUniqueIdentifiable) As Object Implements IGenericGateway.GetByParent
            Return MyBase.GetByParent(parentEntity)
        End Function

        #End Region

    End Class
End Namespace




