
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 20/08/2013 - 01:48 p.m.
' This is a partial class file. The other one is MarcasGateway.vb
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
        
    Public Partial Class MarcasGateway 
        Inherits BaseGateway(Of MarcasObject, MarcasObjectList)
        Implements IGenericGateway

#Region "Singleton"

        Private Shared _instance As MarcasGateway

        Private Sub New()
        End Sub

        Public Shared Function Instance() As MarcasGateway
            If _instance Is Nothing Then
                If HttpContext.Current Is Nothing Then
                    _instance = New MarcasGateway()
                Else
                    Dim inst As MarcasGateway = TryCast(HttpContext.Current.Items("abacusRules.MarcasGatewaySingleton"), MarcasGateway)
                    If inst Is Nothing Then
                        inst = New MarcasGateway()
                        HttpContext.Current.Items.Add("abacusRules.MarcasGatewaySingleton", inst)
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
                Return "Marcas"
            End Get
        End Property

        ''' <summary>
        ''' Return the MarcasGateway type FullName
        ''' </summary>
        Protected Overrides ReadOnly Property RuleName() As String
            Get
                Return GetType(MarcasGateway ).FullName
            End Get
        End Property


        

        


        ''' <summary>
        ''' Assign properties values based on DataReader
        ''' </summary>
        Protected Overrides Sub HydrateFields(ByVal reader As DbDataReader, ByVal entity As MarcasObject )
            Dim _Marca As String
If reader.IsDBNull(1) Then 
	 _Marca = ""
Else
	 _Marca = reader.GetString(1)
End If

            Dim Marcas As IMappeableMarcasObject  = CType(entity, IMappeableMarcasObject)
            Marcas.HydrateFields(reader.GetInt32(0), _
_Marca)
            CType(entity, IObject).State = ObjectState.Restored
        End Sub

        ''' <summary>
        ''' Get field values to call insertion stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForInsert(ByVal entity As MarcasObject) As Object()
            Dim Marcas As IMappeableMarcasObject = CType(entity, IMappeableMarcasObject)
            Return Marcas.GetFieldsForInsert()
        End Function

        ''' <summary>
        ''' Get field values to call update stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForUpdate(ByVal entity As MarcasObject) As Object()
            Dim Marcas As IMappeableMarcasObject = CType(entity, IMappeableMarcasObject)
            Return Marcas.GetFieldsForUpdate()
        End Function

        ''' <summary>
        ''' Get field values to call deletion stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForDelete(ByVal entity As MarcasObject) As Object()
            Dim Marcas As IMappeableMarcasObject = CType(entity, IMappeableMarcasObject)
            Return Marcas.GetFieldsForDelete()
        End Function

        ''' <summary>
        ''' Raised after insert and update. Update properties from Output parameters
        ''' </summary>
        Protected Overrides Sub UpdateObjectFromOutputParams(ByVal row As MarcasObject, parameters As Object())
            ' Update properties from Output parameters
            CType(row, IMappeableMarcasObject).UpdateObjectFromOutputParams(parameters)
            CType(row, IObject).State = ObjectState.Restored
        End Sub

        ''' <summary>
        ''' StoredProceduresPrefix, for example: coop_
        ''' </summary>
        Protected Overrides Function StoredProceduresPrefix() As String
            Return "coop_"
        End Function


        ''' <summary>
        ''' Get a MarcasObject by execute a SQL Query Text
        ''' </summary>
        Public Function GetOneBySQLQuery(sqlQueryText As String) As MarcasObject 
            Return MyBase.GetObjectBySQLText(sqlQueryText)
        End Function

        ''' <summary>
        ''' Get a MarcasObjectList by execute a SQL Query Text
        ''' </summary>
        Public Function GetBySQLQuery(sqlQueryText As String) As MarcasObjectList 
            Return MyBase.GetObjectListBySQLText(sqlQueryText)
        End Function



        ''' <summary>
        ''' Get a MarcasObject by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetOne(ByVal IdMarca As System.Int32) As MarcasObject         
            Return MyBase.GetOne(New MarcasObject(IdMarca))
        End Function

            


        


        

        
        ''' <summary>
        ''' Delete Marcas 
        ''' </summary>
        Public Overloads Sub Delete(ByVal IdMarca As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Marcas_Delete", IdMarca)
        End Sub

        ''' <summary>
        ''' Delete Marcas
        ''' </summary>
        Public Overloads Sub Delete(transaction As DbTransaction , ByVal IdMarca As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Marcas_Delete", IdMarca)
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




