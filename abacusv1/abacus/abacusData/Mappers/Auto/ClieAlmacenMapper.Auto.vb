
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 15/08/2013 - 05:51 p.m.
' This is a partial class file. The other one is ClieAlmacenMapper.cs
' You should not modifiy this file, please edit the other partial class file.
'------------------------------------------------------------------------------

Imports System
Imports abacusRules.Entities
Imports abacusRules.Objects
Imports Cooperator.Framework.Data
Imports Cooperator.Framework.Data.Exceptions
Imports Cooperator.Framework.Core
Imports System.Data.Common
Imports System.Reflection
Imports System.Web


Namespace Mappers
    

    Public Partial Class ClieAlmacenMapper
        Inherits BaseGateway(Of ClieAlmacen, ClieAlmacenList)
        Implements IGenericGateway

#Region "Singleton"

        Private Shared _instance As ClieAlmacenMapper

        Private Sub New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Shared Function Instance() As ClieAlmacenMapper
            If _instance Is Nothing Then
                If HttpContext.Current Is Nothing Then
                    _instance = New ClieAlmacenMapper()
                Else
                    Dim inst As ClieAlmacenMapper = TryCast(HttpContext.Current.Items("abacusRules.ClieAlmacenMapperSingleton"), ClieAlmacenMapper)
                    If inst Is Nothing Then
                        inst = New ClieAlmacenMapper()
                        HttpContext.Current.Items.Add("abacusRules.ClieAlmacenMapperSingleton", inst)
                    End If
                    Return inst
                End If
            End If
            Return _instance
        End Function


#End Region


        ''' <summary>
        ''' 
        ''' </summary>
        Public Function GetPKPropertiesNames() as string()
            
            Dim  s() as String={"IdClialmacen"}
            return s
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Function GetMappingType() as Type
            return GetType(ClieAlmacen)
        End Function


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
                Return GetType(ClieAlmacenMapper).FullName
            End Get
        End Property


        

        

        ''' <summary>
        ''' Assign properties values based on DataReader
        ''' </summary>
        Protected Overrides Sub HydrateFields(ByVal reader As DbDataReader, ByVal entity As ClieAlmacen)
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
Dim _ClieAlmacenString As String
If reader.IsDBNull(12) Then 
	 _ClieAlmacenString = ""
Else
	 _ClieAlmacenString = reader.GetString(12)
End If
Dim _ClientesString As String
If reader.IsDBNull(13) Then 
	 _ClientesString = ""
Else
	 _ClientesString = reader.GetString(13)
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
_ClieAlmacenString, _
_ClientesString)
        End Sub

        ''' <summary>
        ''' Get field values to call insertion stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForInsert(ByVal entity As ClieAlmacen) As Object()
            Dim ClieAlmacen As IMappeableClieAlmacenObject = CType(entity, IMappeableClieAlmacenObject)
            Return ClieAlmacen.GetFieldsForInsert()
        End Function

        ''' <summary>
        ''' Get field values to call update stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForUpdate(ByVal entity As ClieAlmacen) As Object()
            Dim ClieAlmacen As IMappeableClieAlmacenObject = CType(entity, IMappeableClieAlmacenObject)
            Return ClieAlmacen.GetFieldsForUpdate()
        End Function

        ''' <summary>
        ''' Get field values to call deletion stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForDelete(ByVal entity As ClieAlmacen) As Object()
            Dim ClieAlmacen As IMappeableClieAlmacenObject = CType(entity, IMappeableClieAlmacenObject)
            Return ClieAlmacen.GetFieldsForDelete()
        End Function

        ''' <summary>
        ''' Raised after insert and update. Update properties from Output parameters
        ''' </summary>
        Protected Overrides Sub UpdateObjectFromOutputParams(ByVal entity As ClieAlmacen, ByVal parameters As Object())
            ' Update properties from Output parameters
            CType(entity, IMappeableClieAlmacenObject).UpdateObjectFromOutputParams(parameters)
        End Sub

        ''' <summary>
        ''' StoredProceduresPrefix, for example: coop_
        ''' </summary>
        Protected Overrides Function StoredProceduresPrefix() As String 
            Return "coop_"
        End Function


        


        

        ''' <summary>
        ''' Complete the aggregations for this entity. 
        ''' </summary>
        Protected Overrides Sub CompleteEntity(ByVal entity As ClieAlmacen)
            Dim ClieAlmacenEntity As Objects.ClieAlmacenObject = Nothing 'Lazy load
Dim ClientesEntity As Objects.ClientesObject = Nothing 'Lazy load
Dim rutaEntity As Objects.rutaObject = Nothing 'Lazy load
            CType(entity, IMappeableClieAlmacen).CompleteEntity(ClieAlmacenEntity, ClientesEntity, rutaEntity)
        End Sub


        # Region "CRUD Operations"
        

        # End Region
        
        ''' <summary>
        ''' Delete children for this entity
        ''' </summary>
        Public Sub DeleteChildren(ByVal transaction As DbTransaction, ByVal entity As IUniqueIdentifiable)
                        
        End Sub


          



        ''' <summary>
        ''' Get a ClieAlmacen by execute a SQL Query Text
        ''' </summary>
        Public Function GetOneBySQLQuery(sqlQueryText As String) As ClieAlmacen
            Return MyBase.GetObjectBySQLText(sqlQueryText)
        End Function

        ''' <summary>
        ''' Get a ClieAlmacenList by execute a SQL Query Text
        ''' </summary>
        Public Function GetBySQLQuery(sqlQueryText As String) As ClieAlmacenList
            Return MyBase.GetObjectListBySQLText(sqlQueryText)
        End Function

        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetOne(IdClialmacen As System.Int32) As ClieAlmacen
            Return MyBase.GetOne(New ClieAlmacen(IdClialmacen))
        End Function

        

        ' GetOne By Objects and Params
            

        

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByClieAlmacen(IdClialmacen_2 As System.Int32) As ClieAlmacenList
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ClieAlmacen_GetByClieAlmacen", IdClialmacen_2)
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByClieAlmacen(ByVal ClieAlmacen As IUniqueIdentifiable) As ClieAlmacenList
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ClieAlmacen_GetByClieAlmacen", ClieAlmacen.Identifier())
        End Function

    

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByClientes(IdCliente As System.Int32) As ClieAlmacenList
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ClieAlmacen_GetByClientes", IdCliente)
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByClientes(ByVal Clientes As IUniqueIdentifiable) As ClieAlmacenList
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ClieAlmacen_GetByClientes", Clientes.Identifier())
        End Function

    

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByruta(IdRuta As System.Int32) As ClieAlmacenList
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ClieAlmacen_GetByruta", IdRuta)
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByruta(ByVal ruta As IUniqueIdentifiable) As ClieAlmacenList
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ClieAlmacen_GetByruta", ruta.Identifier())
        End Function

    


        

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByClieAlmacen(ByVal transaction As DbTransaction,IdClialmacen_2 As System.Int32) As ClieAlmacenList
            Return MyBase.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ClieAlmacen_GetByClieAlmacen", IdClialmacen_2)
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByClieAlmacen(ByVal transaction As DbTransaction, ByVal ClieAlmacen As IUniqueIdentifiable) As ClieAlmacenList
            Return MyBase.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ClieAlmacen_GetByClieAlmacen", ClieAlmacen.Identifier())
        End Function

    

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByClientes(ByVal transaction As DbTransaction,IdCliente As System.Int32) As ClieAlmacenList
            Return MyBase.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ClieAlmacen_GetByClientes", IdCliente)
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByClientes(ByVal transaction As DbTransaction, ByVal Clientes As IUniqueIdentifiable) As ClieAlmacenList
            Return MyBase.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ClieAlmacen_GetByClientes", Clientes.Identifier())
        End Function

    

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByruta(ByVal transaction As DbTransaction,IdRuta As System.Int32) As ClieAlmacenList
            Return MyBase.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ClieAlmacen_GetByruta", IdRuta)
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByruta(ByVal transaction As DbTransaction, ByVal ruta As IUniqueIdentifiable) As ClieAlmacenList
            Return MyBase.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ClieAlmacen_GetByruta", ruta.Identifier())
        End Function

    

        





        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub Delete(IdClialmacen As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ClieAlmacen_Delete", IdClialmacen)
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub Delete(ByVal transaction As DbTransaction ,IdClialmacen As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ClieAlmacen_Delete", IdClialmacen)
        End Sub

        ' Delete By Objects and Params
            



        

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub DeleteByClieAlmacen(IdClialmacen_2 As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ClieAlmacen_DeleteByClieAlmacen", IdClialmacen_2)
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub DeleteByClieAlmacen(ByVal transaction As DbTransaction , IdClialmacen_2 As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ClieAlmacen_DeleteByClieAlmacen", IdClialmacen_2)
        End Sub


        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub DeleteByClieAlmacen(ByVal ClieAlmacen As IUniqueIdentifiable)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ClieAlmacen_DeleteByClieAlmacen", ClieAlmacen.Identifier())
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub DeleteByClieAlmacen(ByVal transaction As DbTransaction, ByVal ClieAlmacen As IUniqueIdentifiable)        
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ClieAlmacen_DeleteByClieAlmacen", ClieAlmacen.Identifier())
        End Sub

        

    

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub DeleteByClientes(IdCliente As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ClieAlmacen_DeleteByClientes", IdCliente)
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub DeleteByClientes(ByVal transaction As DbTransaction , IdCliente As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ClieAlmacen_DeleteByClientes", IdCliente)
        End Sub


        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub DeleteByClientes(ByVal Clientes As IUniqueIdentifiable)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ClieAlmacen_DeleteByClientes", Clientes.Identifier())
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub DeleteByClientes(ByVal transaction As DbTransaction, ByVal Clientes As IUniqueIdentifiable)        
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ClieAlmacen_DeleteByClientes", Clientes.Identifier())
        End Sub

        

    

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub DeleteByruta(IdRuta As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ClieAlmacen_DeleteByruta", IdRuta)
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub DeleteByruta(ByVal transaction As DbTransaction , IdRuta As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ClieAlmacen_DeleteByruta", IdRuta)
        End Sub


        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub DeleteByruta(ByVal ruta As IUniqueIdentifiable)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ClieAlmacen_DeleteByruta", ruta.Identifier())
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub DeleteByruta(ByVal transaction As DbTransaction, ByVal ruta As IUniqueIdentifiable)        
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ClieAlmacen_DeleteByruta", ruta.Identifier())
        End Sub

        

    


        'Database Queries 
        






        #Region "IGenericGateway"

        Private Function GetOne2(ByVal identifier As IUniqueIdentifiable) As Object Implements IGenericGateway.GetOne
            Return MyBase.GetOne(identifier)
        End Function

        Private Function GetAll2() As Object Implements IGenericGateway.GetAll
            Return MyBase.GetAll()
        End Function

        Private Function GetByParent2(parentEntity As IUniqueIdentifiable) As Object Implements IGenericGateway.GetByParent
            Return MyBase.GetByParent(parentEntity)
        End Function

        #End Region

    End Class

End Namespace


Namespace Wrappers
    ''' <summary>
    ''' 
    ''' </summary>
    Public Class ClieAlmacenMapperWrapper

        ''' <summary>
        ''' 
        ''' </summary>
        Public Function GetPKPropertiesNames() as string()
            return Instance().GetPKPropertiesNames()
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Function GetMappingType() as Type
            return Instance().GetMappingType()
        End Function


        ''' <summary>
        ''' 
        ''' </summary>
        Public Function Instance() As abacusRules.Mappers.ClieAlmacenMapper
            Return abacusRules.Mappers.ClieAlmacenMapper.Instance()
        End Function

        
        ''' <summary>
        ''' Get a ClieAlmacen Entity by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetOne(ByVal IdClialmacen As System.Int32) As Entities.ClieAlmacen         
            Return Instance().GetOne( IdClialmacen)
        End Function
        

        ' GetBy Objects and Params
            

        

        ''' <summary>
        ''' Get a ClieAlmacenList by calling a Stored Procedure
        ''' </summary>
        Public Function GetByClieAlmacen( ByVal IdClialmacen_2 As System.Int32) As Entities.ClieAlmacenList 
            Return Instance().GetByClieAlmacen(IdClialmacen_2)
        End Function

        ''' <summary>
        ''' Get a ClieAlmacenList by calling a Stored Procedure
        ''' </summary>
        Public Function GetByClieAlmacen(ByVal  ClieAlmacen As IUniqueIdentifiable) As Entities.ClieAlmacenList
            Return Instance().GetByClieAlmacen(ClieAlmacen)
        End Function

    

        ''' <summary>
        ''' Get a ClieAlmacenList by calling a Stored Procedure
        ''' </summary>
        Public Function GetByClientes( ByVal IdCliente As System.Int32) As Entities.ClieAlmacenList 
            Return Instance().GetByClientes(IdCliente)
        End Function

        ''' <summary>
        ''' Get a ClieAlmacenList by calling a Stored Procedure
        ''' </summary>
        Public Function GetByClientes(ByVal  Clientes As IUniqueIdentifiable) As Entities.ClieAlmacenList
            Return Instance().GetByClientes(Clientes)
        End Function

    

        ''' <summary>
        ''' Get a ClieAlmacenList by calling a Stored Procedure
        ''' </summary>
        Public Function GetByruta( ByVal IdRuta As System.Int32) As Entities.ClieAlmacenList 
            Return Instance().GetByruta(IdRuta)
        End Function

        ''' <summary>
        ''' Get a ClieAlmacenList by calling a Stored Procedure
        ''' </summary>
        Public Function GetByruta(ByVal  ruta As IUniqueIdentifiable) As Entities.ClieAlmacenList
            Return Instance().GetByruta(ruta)
        End Function

    

        ''' <summary>
        ''' GetAll ClieAlmacen 
        ''' </summary>
        Public Function GetAll() As Entities.ClieAlmacenList
            Return Instance().GetAll()
        End Function

        
        

        ''' <summary>
        ''' Delete children for ClieAlmacen
        ''' </summary>
        Public Sub DeleteChildren(ByVal transaction As DbTransaction, ByVal entity As ClieAlmacen)
            Instance().DeleteChildren(transaction, entity)
        End Sub

        


            

        

        ''' <summary>
        ''' Delete ClieAlmacen by ClieAlmacen
        ''' </summary>
        Public Sub DeleteByClieAlmacen( ByVal IdClialmacen_2 As System.Int32)
            Instance().DeleteByClieAlmacen(IdClialmacen_2)
        End Sub

        ''' <summary>
        ''' Delete ClieAlmacen by ClieAlmacen
        ''' </summary>
        Public Sub DeleteByClieAlmacen(ByVal ClieAlmacen As IUniqueIdentifiable )
            Instance().DeleteByClieAlmacen(ClieAlmacen)
        End Sub

    

        ''' <summary>
        ''' Delete ClieAlmacen by Clientes
        ''' </summary>
        Public Sub DeleteByClientes( ByVal IdCliente As System.Int32)
            Instance().DeleteByClientes(IdCliente)
        End Sub

        ''' <summary>
        ''' Delete ClieAlmacen by Clientes
        ''' </summary>
        Public Sub DeleteByClientes(ByVal Clientes As IUniqueIdentifiable )
            Instance().DeleteByClientes(Clientes)
        End Sub

    

        ''' <summary>
        ''' Delete ClieAlmacen by ruta
        ''' </summary>
        Public Sub DeleteByruta( ByVal IdRuta As System.Int32)
            Instance().DeleteByruta(IdRuta)
        End Sub

        ''' <summary>
        ''' Delete ClieAlmacen by ruta
        ''' </summary>
        Public Sub DeleteByruta(ByVal ruta As IUniqueIdentifiable )
            Instance().DeleteByruta(ruta)
        End Sub

    

        ''' <summary>
        ''' Delete ClieAlmacen 
        ''' </summary>
        Public Overloads Sub Delete(ByVal IdClialmacen As System.Int32)
            Instance().Delete(IdClialmacen)
        End Sub

        ''' <summary>
        ''' Delete ClieAlmacen 
        ''' </summary>
        Public Overloads Sub Delete(ByVal entity As Entities.ClieAlmacen)
            Instance().Delete(entity)
        End Sub

        ''' <summary>
        ''' Save ClieAlmacen  
        ''' </summary>
        Public Overloads Sub Save(ByVal entity As Entities.ClieAlmacen)
            Instance().Save(entity)
        End Sub

        ''' <summary>
        ''' Insert ClieAlmacen 
        ''' </summary>
        Public Overloads Sub Insert(ByVal entity As Entities.ClieAlmacen)
            Instance().Insert(entity)
        End Sub

        ''' <summary>
        ''' Save ClieAlmacen 
        ''' </summary>
        Public Overloads Sub Save(ByVal IdClialmacen As System.Int32, ByVal IdClialmacen_2 As System.Int32, ByVal Direccion As System.String, ByVal Provincia As System.Int32, ByVal Distrito As System.Int32, ByVal Pais As System.String, ByVal Referencia As System.String, ByVal IdCliente As System.Int32, ByVal IdVendedor As System.Int32, ByVal IdRuta As System.Int32, ByVal Observacion As System.String, ByVal upsize_ts As System.DateTime, ByVal ClieAlmacenString As System.String, ByVal ClientesString As System.String)
            Dim entity As Entities.ClieAlmacen = Instance().GetOne(IdClialmacen)
            If entity Is Nothing Then
                Throw New ApplicationException(String.Format("Entity not found. IUniqueIdentifiable values: {0} = {1}", "IdClialmacen", IdClialmacen))
            End If

            entity.IdClialmacen_2 = IdClialmacen_2
            entity.Direccion = Direccion
            entity.Provincia = Provincia
            entity.Distrito = Distrito
            entity.Pais = Pais
            entity.Referencia = Referencia
            entity.IdCliente = IdCliente
            entity.IdVendedor = IdVendedor
            entity.IdRuta = IdRuta
            entity.Observacion = Observacion
            entity.upsize_ts = upsize_ts
            Instance().Save(entity)
        End Sub

        ''' <summary>
        ''' Insert ClieAlmacen
        ''' </summary>
        Public Overloads Sub Insert(ByVal IdClialmacen_2 As System.Int32, ByVal Direccion As System.String, ByVal Provincia As System.Int32, ByVal Distrito As System.Int32, ByVal Pais As System.String, ByVal Referencia As System.String, ByVal IdCliente As System.Int32, ByVal IdVendedor As System.Int32, ByVal IdRuta As System.Int32, ByVal Observacion As System.String, ByVal upsize_ts As System.DateTime)
            Dim entity As Entities.ClieAlmacen = New Entities.ClieAlmacen

            entity.IdClialmacen_2 = IdClialmacen_2
            entity.Direccion = Direccion
            entity.Provincia = Provincia
            entity.Distrito = Distrito
            entity.Pais = Pais
            entity.Referencia = Referencia
            entity.IdCliente = IdCliente
            entity.IdVendedor = IdVendedor
            entity.IdRuta = IdRuta
            entity.Observacion = Observacion
            entity.upsize_ts = upsize_ts
            Instance().Insert(entity)
        End Sub

        

        'Database Queries 
        


    End Class
End Namespace


Namespace Loaders

    ''' <summary>
    ''' 
    ''' </summary>
    Partial Public Class ClieAlmacenLoader(Of T As {ClieAlmacen, New})
        Inherits BaseLoader(Of T, ClieAlmacen, ObjectList(Of T))
        Implements IGenericGateway



#Region "Singleton"

        Private Shared _instance As ClieAlmacenLoader(Of T)

        Private Sub New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Shared Function Instance() As ClieAlmacenLoader(Of T)
            If _instance Is Nothing Then
                If HttpContext.Current Is Nothing Then
                    _instance = New ClieAlmacenLoader(Of T)
                Else
                    Dim inst As ClieAlmacenLoader(Of T) = TryCast(HttpContext.Current.Items("abacusRules.ClieAlmacenLoaderSingleton"), ClieAlmacenLoader(Of T))
                    If inst Is Nothing Then
                        inst = New ClieAlmacenLoader(Of T)
                        HttpContext.Current.Items.Add("abacusRules.ClieAlmacenLoaderSingleton", inst)
                    End If
                    Return inst
                End If
            End If
            Return _instance
        End Function

#End Region


        ''' <summary>
        ''' 
        ''' </summary>
        Public Function GetPKPropertiesNames() as string()
            
            Dim s() as String={"IdClialmacen"}
            Return s
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Function GetMappingType() as Type
            Return GetType(ClieAlmacen)
        End Function


        Protected Overrides ReadOnly Property TableName As String 
            Get
                Return "ClieAlmacen"
            End Get
        End Property

        

        


        Protected Overrides Sub HydrateFields(ByVal reader As DbDataReader, ByVal entity As ClieAlmacen)
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
Dim _ClieAlmacenString As String
If reader.IsDBNull(12) Then 
	 _ClieAlmacenString = ""
Else
	 _ClieAlmacenString = reader.GetString(12)
End If
Dim _ClientesString As String
If reader.IsDBNull(13) Then 
	 _ClientesString = ""
Else
	 _ClientesString = reader.GetString(13)
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
_ClieAlmacenString, _
_ClientesString)
        End Sub


        Protected Overrides Function StoredProceduresPrefix() As String 
            Return "coop_"
        End Function

        

        

        ' Complete the aggregations for this entity.         
        Protected Overrides Sub CompleteEntity(ByVal entity As t)
            Dim ClieAlmacenEntity As Objects.ClieAlmacenObject = Nothing 'Lazy load
Dim ClientesEntity As Objects.ClientesObject = Nothing 'Lazy load
Dim rutaEntity As Objects.rutaObject = Nothing 'Lazy load
            CType(entity, IMappeableClieAlmacen).CompleteEntity(ClieAlmacenEntity, ClientesEntity, rutaEntity)
        End Sub

        


        ''' <summary>
        ''' Get a ClieAlmacen by execute a SQL Query Text
        ''' </summary>
        Public Function GetOneBySQLQuery(sqlQueryText As String) As t
            Return MyBase.GetObjectBySQLText(sqlQueryText)
        End Function

        ''' <summary>
        ''' Get a ClieAlmacenList by execute a SQL Query Text
        ''' </summary>
        Public Function GetBySQLQuery(sqlQueryText As String) As ObjectList(Of T)
            Return MyBase.GetObjectListBySQLText(sqlQueryText)
        End Function

        
        ''' <summary>
        ''' GetOne By Params
        ''' </summary>
        Public Overloads Function GetOne(IdClialmacen As System.Int32) As t
            Return MyBase.GetObjectByAnyStoredProcedure(StoredProceduresPrefix() + "ClieAlmacen_GetOne", IdClialmacen)
        End Function
        


        ' GetOne By Objects and Params
            

        

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByClieAlmacen(IdClialmacen_2 As System.Int32) As ObjectList(Of T)
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ClieAlmacen_GetByClieAlmacen", IdClialmacen_2)
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByClieAlmacen(ByVal ClieAlmacen As IUniqueIdentifiable) As ObjectList(Of T)
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ClieAlmacen_GetByClieAlmacen", ClieAlmacen.Identifier())
        End Function

    

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByClientes(IdCliente As System.Int32) As ObjectList(Of T)
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ClieAlmacen_GetByClientes", IdCliente)
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByClientes(ByVal Clientes As IUniqueIdentifiable) As ObjectList(Of T)
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ClieAlmacen_GetByClientes", Clientes.Identifier())
        End Function

    

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByruta(IdRuta As System.Int32) As ObjectList(Of T)
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ClieAlmacen_GetByruta", IdRuta)
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByruta(ByVal ruta As IUniqueIdentifiable) As ObjectList(Of T)
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ClieAlmacen_GetByruta", ruta.Identifier())
        End Function

    


        'Database Queries 
        


        #Region "IGenericGateway"

        Private Function GetOne2(ByVal identifier As IUniqueIdentifiable) As Object Implements IGenericGateway.GetOne
            Return MyBase.GetOne(identifier)
        End Function

        Private Function GetAll2() As Object Implements IGenericGateway.GetAll
            Return MyBase.GetAll()
        End Function

        Private Function GetByParent2(parentEntity As IUniqueIdentifiable) As Object Implements IGenericGateway.GetByParent
            Return MyBase.GetByParent(parentEntity)
        End Function

        #End Region

    End Class

End Namespace



