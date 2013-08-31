
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 20/08/2013 - 01:48 p.m.
' This is a partial class file. The other one is ClieAlmacenGateway.vb
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
        
    Public Partial Class ClieAlmacenGateway 
        Inherits BaseGateway(Of ClieAlmacenObject, ClieAlmacenObjectList)
        Implements IGenericGateway

#Region "Singleton"

        Private Shared _instance As ClieAlmacenGateway

        Private Sub New()
        End Sub

        Public Shared Function Instance() As ClieAlmacenGateway
            If _instance Is Nothing Then
                If HttpContext.Current Is Nothing Then
                    _instance = New ClieAlmacenGateway()
                Else
                    Dim inst As ClieAlmacenGateway = TryCast(HttpContext.Current.Items("abacusRules.ClieAlmacenGatewaySingleton"), ClieAlmacenGateway)
                    If inst Is Nothing Then
                        inst = New ClieAlmacenGateway()
                        HttpContext.Current.Items.Add("abacusRules.ClieAlmacenGatewaySingleton", inst)
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
                Return "ClieAlmacen"
            End Get
        End Property

        ''' <summary>
        ''' Return the ClieAlmacenGateway type FullName
        ''' </summary>
        Protected Overrides ReadOnly Property RuleName() As String
            Get
                Return GetType(ClieAlmacenGateway ).FullName
            End Get
        End Property


        

        


        ''' <summary>
        ''' Assign properties values based on DataReader
        ''' </summary>
        Protected Overrides Sub HydrateFields(ByVal reader As DbDataReader, ByVal entity As ClieAlmacenObject )
            Dim _IdClialmacen_2 As System.Nullable(Of System.Int32) 
If reader.IsDBNull(1) Then 
	 _IdClialmacen_2 = New System.Nullable(Of System.Int32)
Else
	 _IdClialmacen_2 = reader.GetInt32(1)
End If
Dim _Direccion As String
If reader.IsDBNull(2) Then 
	 _Direccion = ""
Else
	 _Direccion = reader.GetString(2)
End If
Dim _Provincia As System.Nullable(Of System.Int32) 
If reader.IsDBNull(3) Then 
	 _Provincia = New System.Nullable(Of System.Int32)
Else
	 _Provincia = reader.GetInt32(3)
End If
Dim _Distrito As System.Nullable(Of System.Int32) 
If reader.IsDBNull(4) Then 
	 _Distrito = New System.Nullable(Of System.Int32)
Else
	 _Distrito = reader.GetInt32(4)
End If
Dim _Pais As String
If reader.IsDBNull(5) Then 
	 _Pais = ""
Else
	 _Pais = reader.GetString(5)
End If
Dim _Referencia As String
If reader.IsDBNull(6) Then 
	 _Referencia = ""
Else
	 _Referencia = reader.GetString(6)
End If
Dim _IdCliente As System.Nullable(Of System.Int32) 
If reader.IsDBNull(7) Then 
	 _IdCliente = New System.Nullable(Of System.Int32)
Else
	 _IdCliente = reader.GetInt32(7)
End If
Dim _IdVendedor As System.Nullable(Of System.Int32) 
If reader.IsDBNull(8) Then 
	 _IdVendedor = New System.Nullable(Of System.Int32)
Else
	 _IdVendedor = reader.GetInt32(8)
End If
Dim _IdRuta As System.Nullable(Of System.Int32) 
If reader.IsDBNull(9) Then 
	 _IdRuta = New System.Nullable(Of System.Int32)
Else
	 _IdRuta = reader.GetInt32(9)
End If
Dim _Observacion As String
If reader.IsDBNull(10) Then 
	 _Observacion = ""
Else
	 _Observacion = reader.GetString(10)
End If
Dim _upsize_ts As System.Nullable(Of System.DateTime) 
If reader.IsDBNull(11) Then 
	 _upsize_ts = New System.Nullable(Of System.DateTime)
Else
	 _upsize_ts = reader.GetDateTime(11)
End If
Dim _ClientesString As String
If reader.IsDBNull(12) Then 
	 _ClientesString = ""
Else
	 _ClientesString = reader.GetString(12)
End If

            Dim ClieAlmacen As IMappeableClieAlmacenObject  = CType(entity, IMappeableClieAlmacenObject)
            ClieAlmacen.HydrateFields(reader.GetInt32(0), _
_IdClialmacen_2, _
_Direccion, _
_Provincia, _
_Distrito, _
_Pais, _
_Referencia, _
_IdCliente, _
_IdVendedor, _
_IdRuta, _
_Observacion, _
_upsize_ts, _
_ClientesString)
            CType(entity, IObject).State = ObjectState.Restored
        End Sub

        ''' <summary>
        ''' Get field values to call insertion stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForInsert(ByVal entity As ClieAlmacenObject) As Object()
            Dim ClieAlmacen As IMappeableClieAlmacenObject = CType(entity, IMappeableClieAlmacenObject)
            Return ClieAlmacen.GetFieldsForInsert()
        End Function

        ''' <summary>
        ''' Get field values to call update stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForUpdate(ByVal entity As ClieAlmacenObject) As Object()
            Dim ClieAlmacen As IMappeableClieAlmacenObject = CType(entity, IMappeableClieAlmacenObject)
            Return ClieAlmacen.GetFieldsForUpdate()
        End Function

        ''' <summary>
        ''' Get field values to call deletion stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForDelete(ByVal entity As ClieAlmacenObject) As Object()
            Dim ClieAlmacen As IMappeableClieAlmacenObject = CType(entity, IMappeableClieAlmacenObject)
            Return ClieAlmacen.GetFieldsForDelete()
        End Function

        ''' <summary>
        ''' Raised after insert and update. Update properties from Output parameters
        ''' </summary>
        Protected Overrides Sub UpdateObjectFromOutputParams(ByVal row As ClieAlmacenObject, parameters As Object())
            ' Update properties from Output parameters
            CType(row, IMappeableClieAlmacenObject).UpdateObjectFromOutputParams(parameters)
            CType(row, IObject).State = ObjectState.Restored
        End Sub

        ''' <summary>
        ''' StoredProceduresPrefix, for example: coop_
        ''' </summary>
        Protected Overrides Function StoredProceduresPrefix() As String
            Return "coop_"
        End Function


        ''' <summary>
        ''' Get a ClieAlmacenObject by execute a SQL Query Text
        ''' </summary>
        Public Function GetOneBySQLQuery(sqlQueryText As String) As ClieAlmacenObject 
            Return MyBase.GetObjectBySQLText(sqlQueryText)
        End Function

        ''' <summary>
        ''' Get a ClieAlmacenObjectList by execute a SQL Query Text
        ''' </summary>
        Public Function GetBySQLQuery(sqlQueryText As String) As ClieAlmacenObjectList 
            Return MyBase.GetObjectListBySQLText(sqlQueryText)
        End Function



        ''' <summary>
        ''' Get a ClieAlmacenObject by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetOne(ByVal IdClialmacen As System.Int32) As ClieAlmacenObject         
            Return MyBase.GetOne(New ClieAlmacenObject(IdClialmacen))
        End Function

            


        
        ''' <summary>
        ''' Get a ClieAlmacenObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByClientes(ByVal transaction As DbTransaction, ByVal IdCliente As System.Int32) As ClieAlmacenObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ClieAlmacen_GetByClientes", IdCliente)
        End Function

        ''' <summary>
        ''' Get a ClieAlmacenObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByClientes(ByVal transaction As DbTransaction, Clientes As IUniqueIdentifiable) As ClieAlmacenObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ClieAlmacen_GetByClientes", Clientes.Identifier())
        End Function
    
        ''' <summary>
        ''' Get a ClieAlmacenObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByruta(ByVal transaction As DbTransaction, ByVal IdRuta As System.Int32) As ClieAlmacenObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ClieAlmacen_GetByruta", IdRuta)
        End Function

        ''' <summary>
        ''' Get a ClieAlmacenObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByruta(ByVal transaction As DbTransaction, ruta As IUniqueIdentifiable) As ClieAlmacenObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ClieAlmacen_GetByruta", ruta.Identifier())
        End Function
    


        
        ''' <summary>
        ''' Get a ClieAlmacenObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByClientes(ByVal IdCliente As System.Int32) As ClieAlmacenObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ClieAlmacen_GetByClientes", IdCliente)
        End Function

        ''' <summary>
        ''' Get a ClieAlmacenObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByClientes(Clientes As IUniqueIdentifiable) As ClieAlmacenObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ClieAlmacen_GetByClientes", Clientes.Identifier())
        End Function
    
        ''' <summary>
        ''' Get a ClieAlmacenObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByruta(ByVal IdRuta As System.Int32) As ClieAlmacenObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ClieAlmacen_GetByruta", IdRuta)
        End Function

        ''' <summary>
        ''' Get a ClieAlmacenObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByruta(ruta As IUniqueIdentifiable) As ClieAlmacenObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ClieAlmacen_GetByruta", ruta.Identifier())
        End Function
    

        
        ''' <summary>
        ''' Delete ClieAlmacen 
        ''' </summary>
        Public Overloads Sub Delete(ByVal IdClialmacen As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ClieAlmacen_Delete", IdClialmacen)
        End Sub

        ''' <summary>
        ''' Delete ClieAlmacen
        ''' </summary>
        Public Overloads Sub Delete(transaction As DbTransaction , ByVal IdClialmacen As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ClieAlmacen_Delete", IdClialmacen)
        End Sub

            



        

    

    

    

    

    

    

    

    

    

    

    

    

    

    

        ''' <summary>
        ''' Delete ClieAlmacen By Clientes
        ''' </summary>
        Public Overloads Sub DeleteByClientes(ByVal IdCliente As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ClieAlmacen_DeleteByClientes", IdCliente)
        End Sub

        ''' <summary>
        ''' Delete ClieAlmacen By Clientes
        ''' </summary>
        Public Overloads Sub DeleteByClientes(ByVal transaction As DbTransaction , ByVal IdCliente As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ClieAlmacen_DeleteByClientes", IdCliente)
        End Sub

        ''' <summary>
        ''' Delete ClieAlmacen By Clientes
        ''' </summary>
        Public Overloads Sub DeleteByClientes(ByVal Clientes As IUniqueIdentifiable )
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ClieAlmacen_DeleteByClientes", Clientes.Identifier())
        End Sub

        ''' <summary>
        ''' Delete ClieAlmacen By Clientes
        ''' </summary>
        Public Overloads Sub DeleteByClientes(ByVal transaction As DbTransaction , ByVal Clientes As IUniqueIdentifiable)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ClieAlmacen_DeleteByClientes", Clientes.Identifier())
        End Sub

        

    

        ''' <summary>
        ''' Delete ClieAlmacen By ruta
        ''' </summary>
        Public Overloads Sub DeleteByruta(ByVal IdRuta As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ClieAlmacen_DeleteByruta", IdRuta)
        End Sub

        ''' <summary>
        ''' Delete ClieAlmacen By ruta
        ''' </summary>
        Public Overloads Sub DeleteByruta(ByVal transaction As DbTransaction , ByVal IdRuta As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ClieAlmacen_DeleteByruta", IdRuta)
        End Sub

        ''' <summary>
        ''' Delete ClieAlmacen By ruta
        ''' </summary>
        Public Overloads Sub DeleteByruta(ByVal ruta As IUniqueIdentifiable )
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ClieAlmacen_DeleteByruta", ruta.Identifier())
        End Sub

        ''' <summary>
        ''' Delete ClieAlmacen By ruta
        ''' </summary>
        Public Overloads Sub DeleteByruta(ByVal transaction As DbTransaction , ByVal ruta As IUniqueIdentifiable)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ClieAlmacen_DeleteByruta", ruta.Identifier())
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




