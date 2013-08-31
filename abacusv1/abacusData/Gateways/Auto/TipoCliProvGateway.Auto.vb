
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 20/08/2013 - 01:48 p.m.
' This is a partial class file. The other one is TipoCliProvGateway.vb
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
        
    Public Partial Class TipoCliProvGateway 
        Inherits BaseGateway(Of TipoCliProvObject, TipoCliProvObjectList)
        Implements IGenericGateway

#Region "Singleton"

        Private Shared _instance As TipoCliProvGateway

        Private Sub New()
        End Sub

        Public Shared Function Instance() As TipoCliProvGateway
            If _instance Is Nothing Then
                If HttpContext.Current Is Nothing Then
                    _instance = New TipoCliProvGateway()
                Else
                    Dim inst As TipoCliProvGateway = TryCast(HttpContext.Current.Items("abacusRules.TipoCliProvGatewaySingleton"), TipoCliProvGateway)
                    If inst Is Nothing Then
                        inst = New TipoCliProvGateway()
                        HttpContext.Current.Items.Add("abacusRules.TipoCliProvGatewaySingleton", inst)
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
                Return "TipoCliProv"
            End Get
        End Property

        ''' <summary>
        ''' Return the TipoCliProvGateway type FullName
        ''' </summary>
        Protected Overrides ReadOnly Property RuleName() As String
            Get
                Return GetType(TipoCliProvGateway ).FullName
            End Get
        End Property


        

        


        ''' <summary>
        ''' Assign properties values based on DataReader
        ''' </summary>
        Protected Overrides Sub HydrateFields(ByVal reader As DbDataReader, ByVal entity As TipoCliProvObject )
            Dim _Tipo As String
If reader.IsDBNull(1) Then 
	 _Tipo = ""
Else
	 _Tipo = reader.GetString(1)
End If

            Dim TipoCliProv As IMappeableTipoCliProvObject  = CType(entity, IMappeableTipoCliProvObject)
            TipoCliProv.HydrateFields(reader.GetInt32(0), _
_Tipo)
            CType(entity, IObject).State = ObjectState.Restored
        End Sub

        ''' <summary>
        ''' Get field values to call insertion stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForInsert(ByVal entity As TipoCliProvObject) As Object()
            Dim TipoCliProv As IMappeableTipoCliProvObject = CType(entity, IMappeableTipoCliProvObject)
            Return TipoCliProv.GetFieldsForInsert()
        End Function

        ''' <summary>
        ''' Get field values to call update stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForUpdate(ByVal entity As TipoCliProvObject) As Object()
            Dim TipoCliProv As IMappeableTipoCliProvObject = CType(entity, IMappeableTipoCliProvObject)
            Return TipoCliProv.GetFieldsForUpdate()
        End Function

        ''' <summary>
        ''' Get field values to call deletion stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForDelete(ByVal entity As TipoCliProvObject) As Object()
            Dim TipoCliProv As IMappeableTipoCliProvObject = CType(entity, IMappeableTipoCliProvObject)
            Return TipoCliProv.GetFieldsForDelete()
        End Function

        ''' <summary>
        ''' Raised after insert and update. Update properties from Output parameters
        ''' </summary>
        Protected Overrides Sub UpdateObjectFromOutputParams(ByVal row As TipoCliProvObject, parameters As Object())
            ' Update properties from Output parameters
            CType(row, IMappeableTipoCliProvObject).UpdateObjectFromOutputParams(parameters)
            CType(row, IObject).State = ObjectState.Restored
        End Sub

        ''' <summary>
        ''' StoredProceduresPrefix, for example: coop_
        ''' </summary>
        Protected Overrides Function StoredProceduresPrefix() As String
            Return "coop_"
        End Function


        ''' <summary>
        ''' Get a TipoCliProvObject by execute a SQL Query Text
        ''' </summary>
        Public Function GetOneBySQLQuery(sqlQueryText As String) As TipoCliProvObject 
            Return MyBase.GetObjectBySQLText(sqlQueryText)
        End Function

        ''' <summary>
        ''' Get a TipoCliProvObjectList by execute a SQL Query Text
        ''' </summary>
        Public Function GetBySQLQuery(sqlQueryText As String) As TipoCliProvObjectList 
            Return MyBase.GetObjectListBySQLText(sqlQueryText)
        End Function



        ''' <summary>
        ''' Get a TipoCliProvObject by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetOne(ByVal Id As System.Int32) As TipoCliProvObject         
            Return MyBase.GetOne(New TipoCliProvObject(Id))
        End Function

            


        


        

        
        ''' <summary>
        ''' Delete TipoCliProv 
        ''' </summary>
        Public Overloads Sub Delete(ByVal Id As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "TipoCliProv_Delete", Id)
        End Sub

        ''' <summary>
        ''' Delete TipoCliProv
        ''' </summary>
        Public Overloads Sub Delete(transaction As DbTransaction , ByVal Id As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "TipoCliProv_Delete", Id)
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




