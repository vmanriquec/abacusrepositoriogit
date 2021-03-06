
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 15/08/2013 - 05:51 p.m.
' This is a partial class file. The other one is MonedasGateway.vb
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
        
    Public Partial Class MonedasGateway 
        Inherits BaseGateway(Of MonedasObject, MonedasObjectList)
        Implements IGenericGateway

#Region "Singleton"

        Private Shared _instance As MonedasGateway

        Private Sub New()
        End Sub

        Public Shared Function Instance() As MonedasGateway
            If _instance Is Nothing Then
                If HttpContext.Current Is Nothing Then
                    _instance = New MonedasGateway()
                Else
                    Dim inst As MonedasGateway = TryCast(HttpContext.Current.Items("abacusRules.MonedasGatewaySingleton"), MonedasGateway)
                    If inst Is Nothing Then
                        inst = New MonedasGateway()
                        HttpContext.Current.Items.Add("abacusRules.MonedasGatewaySingleton", inst)
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
                Return "Monedas"
            End Get
        End Property

        ''' <summary>
        ''' Return the MonedasGateway type FullName
        ''' </summary>
        Protected Overrides ReadOnly Property RuleName() As String
            Get
                Return GetType(MonedasGateway ).FullName
            End Get
        End Property


        

        


        ''' <summary>
        ''' Assign properties values based on DataReader
        ''' </summary>
        Protected Overrides Sub HydrateFields(ByVal reader As DbDataReader, ByVal entity As MonedasObject )
            Dim _Moneda As String
If reader.IsDBNull(1) Then 
	 _Moneda = ""
Else
	 _Moneda = reader.GetString(1)
End If
Dim _Simbolo As String
If reader.IsDBNull(2) Then 
	 _Simbolo = ""
Else
	 _Simbolo = reader.GetString(2)
End If

            Dim Monedas As IMappeableMonedasObject  = CType(entity, IMappeableMonedasObject)
            Monedas.HydrateFields(reader.GetInt32(0), _
_Moneda, _
_Simbolo)
            CType(entity, IObject).State = ObjectState.Restored
        End Sub

        ''' <summary>
        ''' Get field values to call insertion stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForInsert(ByVal entity As MonedasObject) As Object()
            Dim Monedas As IMappeableMonedasObject = CType(entity, IMappeableMonedasObject)
            Return Monedas.GetFieldsForInsert()
        End Function

        ''' <summary>
        ''' Get field values to call update stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForUpdate(ByVal entity As MonedasObject) As Object()
            Dim Monedas As IMappeableMonedasObject = CType(entity, IMappeableMonedasObject)
            Return Monedas.GetFieldsForUpdate()
        End Function

        ''' <summary>
        ''' Get field values to call deletion stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForDelete(ByVal entity As MonedasObject) As Object()
            Dim Monedas As IMappeableMonedasObject = CType(entity, IMappeableMonedasObject)
            Return Monedas.GetFieldsForDelete()
        End Function

        ''' <summary>
        ''' Raised after insert and update. Update properties from Output parameters
        ''' </summary>
        Protected Overrides Sub UpdateObjectFromOutputParams(ByVal row As MonedasObject, parameters As Object())
            ' Update properties from Output parameters
            CType(row, IMappeableMonedasObject).UpdateObjectFromOutputParams(parameters)
            CType(row, IObject).State = ObjectState.Restored
        End Sub

        ''' <summary>
        ''' StoredProceduresPrefix, for example: coop_
        ''' </summary>
        Protected Overrides Function StoredProceduresPrefix() As String
            Return "coop_"
        End Function


        ''' <summary>
        ''' Get a MonedasObject by execute a SQL Query Text
        ''' </summary>
        Public Function GetOneBySQLQuery(sqlQueryText As String) As MonedasObject 
            Return MyBase.GetObjectBySQLText(sqlQueryText)
        End Function

        ''' <summary>
        ''' Get a MonedasObjectList by execute a SQL Query Text
        ''' </summary>
        Public Function GetBySQLQuery(sqlQueryText As String) As MonedasObjectList 
            Return MyBase.GetObjectListBySQLText(sqlQueryText)
        End Function



        ''' <summary>
        ''' Get a MonedasObject by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetOne(ByVal IdMoneda As System.Int32) As MonedasObject         
            Return MyBase.GetOne(New MonedasObject(IdMoneda))
        End Function

            


        


        

        
        ''' <summary>
        ''' Delete Monedas 
        ''' </summary>
        Public Overloads Sub Delete(ByVal IdMoneda As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Monedas_Delete", IdMoneda)
        End Sub

        ''' <summary>
        ''' Delete Monedas
        ''' </summary>
        Public Overloads Sub Delete(transaction As DbTransaction , ByVal IdMoneda As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Monedas_Delete", IdMoneda)
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




