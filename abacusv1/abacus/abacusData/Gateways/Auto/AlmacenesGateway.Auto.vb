
        
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 15/08/2013 - 05:51 p.m.
' This is a partial class file. The other one is AlmacenesGateway.vb
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
        
    Public Partial Class AlmacenesGateway 
        Inherits BaseGateway(Of AlmacenesObject, AlmacenesObjectList)
        Implements IGenericGateway

#Region "Singleton"

        Private Shared _instance As AlmacenesGateway

        Private Sub New()
        End Sub

        Public Shared Function Instance() As AlmacenesGateway
            If _instance Is Nothing Then
                If HttpContext.Current Is Nothing Then
                    _instance = New AlmacenesGateway()
                Else
                    Dim inst As AlmacenesGateway = TryCast(HttpContext.Current.Items("abacusRules.AlmacenesGatewaySingleton"), AlmacenesGateway)
                    If inst Is Nothing Then
                        inst = New AlmacenesGateway()
                        HttpContext.Current.Items.Add("abacusRules.AlmacenesGatewaySingleton", inst)
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
                Return "Almacenes"
            End Get
        End Property

        ''' <summary>
        ''' Return the AlmacenesGateway type FullName
        ''' </summary>
        Protected Overrides ReadOnly Property RuleName() As String
            Get
                Return GetType(AlmacenesGateway ).FullName
            End Get
        End Property


        

        


        ''' <summary>
        ''' Assign properties values based on DataReader
        ''' </summary>
        Protected Overrides Sub HydrateFields(ByVal reader As DbDataReader, ByVal entity As AlmacenesObject )
            Dim _Almacen As String
If reader.IsDBNull(1) Then 
	 _Almacen = ""
Else
	 _Almacen = reader.GetString(1)
End If

            Dim Almacenes As IMappeableAlmacenesObject  = CType(entity, IMappeableAlmacenesObject)
            Almacenes.HydrateFields(reader.GetInt32(0), _
_Almacen)
            CType(entity, IObject).State = ObjectState.Restored
        End Sub

        ''' <summary>
        ''' Get field values to call insertion stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForInsert(ByVal entity As AlmacenesObject) As Object()
            Dim Almacenes As IMappeableAlmacenesObject = CType(entity, IMappeableAlmacenesObject)
            Return Almacenes.GetFieldsForInsert()
        End Function

        ''' <summary>
        ''' Get field values to call update stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForUpdate(ByVal entity As AlmacenesObject) As Object()
            Dim Almacenes As IMappeableAlmacenesObject = CType(entity, IMappeableAlmacenesObject)
            Return Almacenes.GetFieldsForUpdate()
        End Function

        ''' <summary>
        ''' Get field values to call deletion stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForDelete(ByVal entity As AlmacenesObject) As Object()
            Dim Almacenes As IMappeableAlmacenesObject = CType(entity, IMappeableAlmacenesObject)
            Return Almacenes.GetFieldsForDelete()
        End Function

        ''' <summary>
        ''' Raised after insert and update. Update properties from Output parameters
        ''' </summary>
        Protected Overrides Sub UpdateObjectFromOutputParams(ByVal row As AlmacenesObject, parameters As Object())
            ' Update properties from Output parameters
            CType(row, IMappeableAlmacenesObject).UpdateObjectFromOutputParams(parameters)
            CType(row, IObject).State = ObjectState.Restored
        End Sub

        ''' <summary>
        ''' StoredProceduresPrefix, for example: coop_
        ''' </summary>
        Protected Overrides Function StoredProceduresPrefix() As String
            Return "coop_"
        End Function


        ''' <summary>
        ''' Get a AlmacenesObject by execute a SQL Query Text
        ''' </summary>
        Public Function GetOneBySQLQuery(sqlQueryText As String) As AlmacenesObject 
            Return MyBase.GetObjectBySQLText(sqlQueryText)
        End Function

        ''' <summary>
        ''' Get a AlmacenesObjectList by execute a SQL Query Text
        ''' </summary>
        Public Function GetBySQLQuery(sqlQueryText As String) As AlmacenesObjectList 
            Return MyBase.GetObjectListBySQLText(sqlQueryText)
        End Function



        ''' <summary>
        ''' Get a AlmacenesObject by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetOne(ByVal IdAlmacen As System.Int32) As AlmacenesObject         
            Return MyBase.GetOne(New AlmacenesObject(IdAlmacen))
        End Function

            


        


        

        
        ''' <summary>
        ''' Delete Almacenes 
        ''' </summary>
        Public Overloads Sub Delete(ByVal IdAlmacen As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Almacenes_Delete", IdAlmacen)
        End Sub

        ''' <summary>
        ''' Delete Almacenes
        ''' </summary>
        Public Overloads Sub Delete(transaction As DbTransaction , ByVal IdAlmacen As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Almacenes_Delete", IdAlmacen)
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




