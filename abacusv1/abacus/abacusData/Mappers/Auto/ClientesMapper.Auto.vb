
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 15/08/2013 - 05:51 p.m.
' This is a partial class file. The other one is ClientesMapper.cs
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
    

    Public Partial Class ClientesMapper
        Inherits BaseGateway(Of Clientes, ClientesList)
        Implements IGenericGateway

#Region "Singleton"

        Private Shared _instance As ClientesMapper

        Private Sub New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Shared Function Instance() As ClientesMapper
            If _instance Is Nothing Then
                If HttpContext.Current Is Nothing Then
                    _instance = New ClientesMapper()
                Else
                    Dim inst As ClientesMapper = TryCast(HttpContext.Current.Items("abacusRules.ClientesMapperSingleton"), ClientesMapper)
                    If inst Is Nothing Then
                        inst = New ClientesMapper()
                        HttpContext.Current.Items.Add("abacusRules.ClientesMapperSingleton", inst)
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
            
            Dim  s() as String={"IdCliente"}
            return s
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Function GetMappingType() as Type
            return GetType(Clientes)
        End Function


        ''' <summary>
        ''' Return the mapped table name
        ''' </summary>
        Protected Overrides ReadOnly Property TableName() As String 
            Get
                Return "Clientes"
            End Get
        End Property

        ''' <summary>
        ''' Return the ClientesGateway type FullName
        ''' </summary>
        Protected Overrides ReadOnly Property RuleName() As String
            Get
                Return GetType(ClientesMapper).FullName
            End Get
        End Property


        

        

        ''' <summary>
        ''' Assign properties values based on DataReader
        ''' </summary>
        Protected Overrides Sub HydrateFields(ByVal reader As DbDataReader, ByVal entity As Clientes)
            Dim _TipoCliente As System.Nullable(Of System.Int32) 
If reader.IsDBNull(1) Then 
	 _TipoCliente = New System.Nullable(Of System.Int32)
Else
	 _TipoCliente = reader.GetInt32(1)
End If
Dim _Nombre As String
If reader.IsDBNull(2) Then 
	 _Nombre = ""
Else
	 _Nombre = reader.GetString(2)
End If
Dim _Apellido As String
If reader.IsDBNull(3) Then 
	 _Apellido = ""
Else
	 _Apellido = reader.GetString(3)
End If
Dim _Cliente As String
If reader.IsDBNull(4) Then 
	 _Cliente = ""
Else
	 _Cliente = reader.GetString(4)
End If
Dim _NomComercial As String
If reader.IsDBNull(5) Then 
	 _NomComercial = ""
Else
	 _NomComercial = reader.GetString(5)
End If
Dim _TipoDI As System.Nullable(Of System.Int32) 
If reader.IsDBNull(6) Then 
	 _TipoDI = New System.Nullable(Of System.Int32)
Else
	 _TipoDI = reader.GetInt32(6)
End If
Dim _DI As String
If reader.IsDBNull(7) Then 
	 _DI = ""
Else
	 _DI = reader.GetString(7)
End If
Dim _Direccion As String
If reader.IsDBNull(8) Then 
	 _Direccion = ""
Else
	 _Direccion = reader.GetString(8)
End If
Dim _Distrito As System.Nullable(Of System.Int32) 
If reader.IsDBNull(9) Then 
	 _Distrito = New System.Nullable(Of System.Int32)
Else
	 _Distrito = reader.GetInt32(9)
End If
Dim _Provincia As System.Nullable(Of System.Int32) 
If reader.IsDBNull(10) Then 
	 _Provincia = New System.Nullable(Of System.Int32)
Else
	 _Provincia = reader.GetInt32(10)
End If
Dim _Pais As String
If reader.IsDBNull(11) Then 
	 _Pais = ""
Else
	 _Pais = reader.GetString(11)
End If
Dim _Telefono1 As String
If reader.IsDBNull(12) Then 
	 _Telefono1 = ""
Else
	 _Telefono1 = reader.GetString(12)
End If
Dim _Telefono2 As String
If reader.IsDBNull(13) Then 
	 _Telefono2 = ""
Else
	 _Telefono2 = reader.GetString(13)
End If
Dim _Fax As String
If reader.IsDBNull(14) Then 
	 _Fax = ""
Else
	 _Fax = reader.GetString(14)
End If
Dim _Email As String
If reader.IsDBNull(15) Then 
	 _Email = ""
Else
	 _Email = reader.GetString(15)
End If
Dim _Logo As String
If reader.IsDBNull(16) Then 
	 _Logo = ""
Else
	 _Logo = reader.GetString(16)
End If
Dim _Movil As String
If reader.IsDBNull(17) Then 
	 _Movil = ""
Else
	 _Movil = reader.GetString(17)
End If
Dim _TipMovil As String
If reader.IsDBNull(18) Then 
	 _TipMovil = ""
Else
	 _TipMovil = reader.GetString(18)
End If
Dim _Observaciones As String
If reader.IsDBNull(19) Then 
	 _Observaciones = ""
Else
	 _Observaciones = reader.GetString(19)
End If
Dim _CodCliente As String
If reader.IsDBNull(20) Then 
	 _CodCliente = ""
Else
	 _CodCliente = reader.GetString(20)
End If
Dim _CondPago As System.Nullable(Of System.Int32) 
If reader.IsDBNull(21) Then 
	 _CondPago = New System.Nullable(Of System.Int32)
Else
	 _CondPago = reader.GetInt32(21)
End If
Dim _Ruta As String
If reader.IsDBNull(22) Then 
	 _Ruta = ""
Else
	 _Ruta = reader.GetString(22)
End If
Dim _fechaderegistro As System.Nullable(Of System.DateTime) 
If reader.IsDBNull(23) Then 
	 _fechaderegistro = New System.Nullable(Of System.DateTime)
Else
	 _fechaderegistro = reader.GetDateTime(23)
End If
Dim _estadocliente As String
If reader.IsDBNull(24) Then 
	 _estadocliente = ""
Else
	 _estadocliente = reader.GetString(24)
End If
Dim _DistritosString As String
If reader.IsDBNull(25) Then 
	 _DistritosString = ""
Else
	 _DistritosString = reader.GetString(25)
End If
Dim _ProvinciasString As String
If reader.IsDBNull(26) Then 
	 _ProvinciasString = ""
Else
	 _ProvinciasString = reader.GetString(26)
End If

            Dim Clientes As IMappeableClientesObject  = CType(entity, IMappeableClientesObject)
            Clientes.HydrateFields(reader.GetInt32(0), _
_TipoCliente, _
_Nombre, _
_Apellido, _
_Cliente, _
_NomComercial, _
_TipoDI, _
_DI, _
_Direccion, _
_Distrito, _
_Provincia, _
_Pais, _
_Telefono1, _
_Telefono2, _
_Fax, _
_Email, _
_Logo, _
_Movil, _
_TipMovil, _
_Observaciones, _
_CodCliente, _
_CondPago, _
_Ruta, _
_fechaderegistro, _
_estadocliente, _
_DistritosString, _
_ProvinciasString)
        End Sub

        ''' <summary>
        ''' Get field values to call insertion stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForInsert(ByVal entity As Clientes) As Object()
            Dim Clientes As IMappeableClientesObject = CType(entity, IMappeableClientesObject)
            Return Clientes.GetFieldsForInsert()
        End Function

        ''' <summary>
        ''' Get field values to call update stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForUpdate(ByVal entity As Clientes) As Object()
            Dim Clientes As IMappeableClientesObject = CType(entity, IMappeableClientesObject)
            Return Clientes.GetFieldsForUpdate()
        End Function

        ''' <summary>
        ''' Get field values to call deletion stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForDelete(ByVal entity As Clientes) As Object()
            Dim Clientes As IMappeableClientesObject = CType(entity, IMappeableClientesObject)
            Return Clientes.GetFieldsForDelete()
        End Function

        ''' <summary>
        ''' Raised after insert and update. Update properties from Output parameters
        ''' </summary>
        Protected Overrides Sub UpdateObjectFromOutputParams(ByVal entity As Clientes, ByVal parameters As Object())
            ' Update properties from Output parameters
            CType(entity, IMappeableClientesObject).UpdateObjectFromOutputParams(parameters)
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
        Protected Overrides Sub CompleteEntity(ByVal entity As Clientes)
            Dim DistritosEntity As Objects.DistritosObject = Nothing 'Lazy load
Dim ProvinciasEntity As Objects.ProvinciasObject = Nothing 'Lazy load
            CType(entity, IMappeableClientes).CompleteEntity(DistritosEntity, ProvinciasEntity)
        End Sub


        # Region "CRUD Operations"
        

        # End Region
        
        ''' <summary>
        ''' Delete children for this entity
        ''' </summary>
        Public Sub DeleteChildren(ByVal transaction As DbTransaction, ByVal entity As IUniqueIdentifiable)
                        
        End Sub


          



        ''' <summary>
        ''' Get a Clientes by execute a SQL Query Text
        ''' </summary>
        Public Function GetOneBySQLQuery(sqlQueryText As String) As Clientes
            Return MyBase.GetObjectBySQLText(sqlQueryText)
        End Function

        ''' <summary>
        ''' Get a ClientesList by execute a SQL Query Text
        ''' </summary>
        Public Function GetBySQLQuery(sqlQueryText As String) As ClientesList
            Return MyBase.GetObjectListBySQLText(sqlQueryText)
        End Function

        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetOne(IdCliente As System.Int32) As Clientes
            Return MyBase.GetOne(New Clientes(IdCliente))
        End Function

        

        ' GetOne By Objects and Params
            

        

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByDistritos(Distrito As System.Int32) As ClientesList
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Clientes_GetByDistritos", Distrito)
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByDistritos(ByVal Distritos As IUniqueIdentifiable) As ClientesList
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Clientes_GetByDistritos", Distritos.Identifier())
        End Function

    

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByProvincias(Provincia As System.Int32) As ClientesList
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Clientes_GetByProvincias", Provincia)
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByProvincias(ByVal Provincias As IUniqueIdentifiable) As ClientesList
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Clientes_GetByProvincias", Provincias.Identifier())
        End Function

    


        

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByDistritos(ByVal transaction As DbTransaction,Distrito As System.Int32) As ClientesList
            Return MyBase.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Clientes_GetByDistritos", Distrito)
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByDistritos(ByVal transaction As DbTransaction, ByVal Distritos As IUniqueIdentifiable) As ClientesList
            Return MyBase.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Clientes_GetByDistritos", Distritos.Identifier())
        End Function

    

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByProvincias(ByVal transaction As DbTransaction,Provincia As System.Int32) As ClientesList
            Return MyBase.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Clientes_GetByProvincias", Provincia)
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByProvincias(ByVal transaction As DbTransaction, ByVal Provincias As IUniqueIdentifiable) As ClientesList
            Return MyBase.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Clientes_GetByProvincias", Provincias.Identifier())
        End Function

    

        





        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub Delete(IdCliente As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Clientes_Delete", IdCliente)
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub Delete(ByVal transaction As DbTransaction ,IdCliente As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Clientes_Delete", IdCliente)
        End Sub

        ' Delete By Objects and Params
            



        

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub DeleteByDistritos(Distrito As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Clientes_DeleteByDistritos", Distrito)
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub DeleteByDistritos(ByVal transaction As DbTransaction , Distrito As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Clientes_DeleteByDistritos", Distrito)
        End Sub


        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub DeleteByDistritos(ByVal Distritos As IUniqueIdentifiable)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Clientes_DeleteByDistritos", Distritos.Identifier())
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub DeleteByDistritos(ByVal transaction As DbTransaction, ByVal Distritos As IUniqueIdentifiable)        
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Clientes_DeleteByDistritos", Distritos.Identifier())
        End Sub

        

    

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub DeleteByProvincias(Provincia As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Clientes_DeleteByProvincias", Provincia)
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub DeleteByProvincias(ByVal transaction As DbTransaction , Provincia As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Clientes_DeleteByProvincias", Provincia)
        End Sub


        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub DeleteByProvincias(ByVal Provincias As IUniqueIdentifiable)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Clientes_DeleteByProvincias", Provincias.Identifier())
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub DeleteByProvincias(ByVal transaction As DbTransaction, ByVal Provincias As IUniqueIdentifiable)        
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Clientes_DeleteByProvincias", Provincias.Identifier())
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
    Public Class ClientesMapperWrapper

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
        Public Function Instance() As abacusRules.Mappers.ClientesMapper
            Return abacusRules.Mappers.ClientesMapper.Instance()
        End Function

        
        ''' <summary>
        ''' Get a Clientes Entity by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetOne(ByVal IdCliente As System.Int32) As Entities.Clientes         
            Return Instance().GetOne( IdCliente)
        End Function
        

        ' GetBy Objects and Params
            

        

        ''' <summary>
        ''' Get a ClientesList by calling a Stored Procedure
        ''' </summary>
        Public Function GetByDistritos( ByVal Distrito As System.Int32) As Entities.ClientesList 
            Return Instance().GetByDistritos(Distrito)
        End Function

        ''' <summary>
        ''' Get a ClientesList by calling a Stored Procedure
        ''' </summary>
        Public Function GetByDistritos(ByVal  Distritos As IUniqueIdentifiable) As Entities.ClientesList
            Return Instance().GetByDistritos(Distritos)
        End Function

    

        ''' <summary>
        ''' Get a ClientesList by calling a Stored Procedure
        ''' </summary>
        Public Function GetByProvincias( ByVal Provincia As System.Int32) As Entities.ClientesList 
            Return Instance().GetByProvincias(Provincia)
        End Function

        ''' <summary>
        ''' Get a ClientesList by calling a Stored Procedure
        ''' </summary>
        Public Function GetByProvincias(ByVal  Provincias As IUniqueIdentifiable) As Entities.ClientesList
            Return Instance().GetByProvincias(Provincias)
        End Function

    

        ''' <summary>
        ''' GetAll Clientes 
        ''' </summary>
        Public Function GetAll() As Entities.ClientesList
            Return Instance().GetAll()
        End Function

        
        

        ''' <summary>
        ''' Delete children for Clientes
        ''' </summary>
        Public Sub DeleteChildren(ByVal transaction As DbTransaction, ByVal entity As Clientes)
            Instance().DeleteChildren(transaction, entity)
        End Sub

        


            

        

        ''' <summary>
        ''' Delete Clientes by Distritos
        ''' </summary>
        Public Sub DeleteByDistritos( ByVal Distrito As System.Int32)
            Instance().DeleteByDistritos(Distrito)
        End Sub

        ''' <summary>
        ''' Delete Clientes by Distritos
        ''' </summary>
        Public Sub DeleteByDistritos(ByVal Distritos As IUniqueIdentifiable )
            Instance().DeleteByDistritos(Distritos)
        End Sub

    

        ''' <summary>
        ''' Delete Clientes by Provincias
        ''' </summary>
        Public Sub DeleteByProvincias( ByVal Provincia As System.Int32)
            Instance().DeleteByProvincias(Provincia)
        End Sub

        ''' <summary>
        ''' Delete Clientes by Provincias
        ''' </summary>
        Public Sub DeleteByProvincias(ByVal Provincias As IUniqueIdentifiable )
            Instance().DeleteByProvincias(Provincias)
        End Sub

    

        ''' <summary>
        ''' Delete Clientes 
        ''' </summary>
        Public Overloads Sub Delete(ByVal IdCliente As System.Int32)
            Instance().Delete(IdCliente)
        End Sub

        ''' <summary>
        ''' Delete Clientes 
        ''' </summary>
        Public Overloads Sub Delete(ByVal entity As Entities.Clientes)
            Instance().Delete(entity)
        End Sub

        ''' <summary>
        ''' Save Clientes  
        ''' </summary>
        Public Overloads Sub Save(ByVal entity As Entities.Clientes)
            Instance().Save(entity)
        End Sub

        ''' <summary>
        ''' Insert Clientes 
        ''' </summary>
        Public Overloads Sub Insert(ByVal entity As Entities.Clientes)
            Instance().Insert(entity)
        End Sub

        ''' <summary>
        ''' Save Clientes 
        ''' </summary>
        Public Overloads Sub Save(ByVal IdCliente As System.Int32, ByVal TipoCliente As System.Int32, ByVal Nombre As System.String, ByVal Apellido As System.String, ByVal Cliente As System.String, ByVal NomComercial As System.String, ByVal TipoDI As System.Int32, ByVal DI As System.String, ByVal Direccion As System.String, ByVal Distrito As System.Int32, ByVal Provincia As System.Int32, ByVal Pais As System.String, ByVal Telefono1 As System.String, ByVal Telefono2 As System.String, ByVal Fax As System.String, ByVal Email As System.String, ByVal Logo As System.String, ByVal Movil As System.String, ByVal TipMovil As System.String, ByVal Observaciones As System.String, ByVal CodCliente As System.String, ByVal CondPago As System.Int32, ByVal Ruta As System.String, ByVal fechaderegistro As System.DateTime, ByVal estadocliente As System.String, ByVal DistritosString As System.String, ByVal ProvinciasString As System.String)
            Dim entity As Entities.Clientes = Instance().GetOne(IdCliente)
            If entity Is Nothing Then
                Throw New ApplicationException(String.Format("Entity not found. IUniqueIdentifiable values: {0} = {1}", "IdCliente", IdCliente))
            End If

            entity.TipoCliente = TipoCliente
            entity.Nombre = Nombre
            entity.Apellido = Apellido
            entity.Cliente = Cliente
            entity.NomComercial = NomComercial
            entity.TipoDI = TipoDI
            entity.DI = DI
            entity.Direccion = Direccion
            entity.Distrito = Distrito
            entity.Provincia = Provincia
            entity.Pais = Pais
            entity.Telefono1 = Telefono1
            entity.Telefono2 = Telefono2
            entity.Fax = Fax
            entity.Email = Email
            entity.Logo = Logo
            entity.Movil = Movil
            entity.TipMovil = TipMovil
            entity.Observaciones = Observaciones
            entity.CodCliente = CodCliente
            entity.CondPago = CondPago
            entity.Ruta = Ruta
            entity.fechaderegistro = fechaderegistro
            entity.estadocliente = estadocliente
            Instance().Save(entity)
        End Sub

        ''' <summary>
        ''' Insert Clientes
        ''' </summary>
        Public Overloads Sub Insert(ByVal TipoCliente As System.Int32, ByVal Nombre As System.String, ByVal Apellido As System.String, ByVal Cliente As System.String, ByVal NomComercial As System.String, ByVal TipoDI As System.Int32, ByVal DI As System.String, ByVal Direccion As System.String, ByVal Distrito As System.Int32, ByVal Provincia As System.Int32, ByVal Pais As System.String, ByVal Telefono1 As System.String, ByVal Telefono2 As System.String, ByVal Fax As System.String, ByVal Email As System.String, ByVal Logo As System.String, ByVal Movil As System.String, ByVal TipMovil As System.String, ByVal Observaciones As System.String, ByVal CodCliente As System.String, ByVal CondPago As System.Int32, ByVal Ruta As System.String, ByVal fechaderegistro As System.DateTime, ByVal estadocliente As System.String)
            Dim entity As Entities.Clientes = New Entities.Clientes

            entity.TipoCliente = TipoCliente
            entity.Nombre = Nombre
            entity.Apellido = Apellido
            entity.Cliente = Cliente
            entity.NomComercial = NomComercial
            entity.TipoDI = TipoDI
            entity.DI = DI
            entity.Direccion = Direccion
            entity.Distrito = Distrito
            entity.Provincia = Provincia
            entity.Pais = Pais
            entity.Telefono1 = Telefono1
            entity.Telefono2 = Telefono2
            entity.Fax = Fax
            entity.Email = Email
            entity.Logo = Logo
            entity.Movil = Movil
            entity.TipMovil = TipMovil
            entity.Observaciones = Observaciones
            entity.CodCliente = CodCliente
            entity.CondPago = CondPago
            entity.Ruta = Ruta
            entity.fechaderegistro = fechaderegistro
            entity.estadocliente = estadocliente
            Instance().Insert(entity)
        End Sub

        

        'Database Queries 
        


    End Class
End Namespace


Namespace Loaders

    ''' <summary>
    ''' 
    ''' </summary>
    Partial Public Class ClientesLoader(Of T As {Clientes, New})
        Inherits BaseLoader(Of T, Clientes, ObjectList(Of T))
        Implements IGenericGateway



#Region "Singleton"

        Private Shared _instance As ClientesLoader(Of T)

        Private Sub New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Shared Function Instance() As ClientesLoader(Of T)
            If _instance Is Nothing Then
                If HttpContext.Current Is Nothing Then
                    _instance = New ClientesLoader(Of T)
                Else
                    Dim inst As ClientesLoader(Of T) = TryCast(HttpContext.Current.Items("abacusRules.ClientesLoaderSingleton"), ClientesLoader(Of T))
                    If inst Is Nothing Then
                        inst = New ClientesLoader(Of T)
                        HttpContext.Current.Items.Add("abacusRules.ClientesLoaderSingleton", inst)
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
            
            Dim s() as String={"IdCliente"}
            Return s
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Function GetMappingType() as Type
            Return GetType(Clientes)
        End Function


        Protected Overrides ReadOnly Property TableName As String 
            Get
                Return "Clientes"
            End Get
        End Property

        

        


        Protected Overrides Sub HydrateFields(ByVal reader As DbDataReader, ByVal entity As Clientes)
            Dim _TipoCliente As System.Nullable(Of System.Int32) 
If reader.IsDBNull(1) Then 
	 _TipoCliente = New System.Nullable(Of System.Int32)
Else
	 _TipoCliente = reader.GetInt32(1)
End If
Dim _Nombre As String
If reader.IsDBNull(2) Then 
	 _Nombre = ""
Else
	 _Nombre = reader.GetString(2)
End If
Dim _Apellido As String
If reader.IsDBNull(3) Then 
	 _Apellido = ""
Else
	 _Apellido = reader.GetString(3)
End If
Dim _Cliente As String
If reader.IsDBNull(4) Then 
	 _Cliente = ""
Else
	 _Cliente = reader.GetString(4)
End If
Dim _NomComercial As String
If reader.IsDBNull(5) Then 
	 _NomComercial = ""
Else
	 _NomComercial = reader.GetString(5)
End If
Dim _TipoDI As System.Nullable(Of System.Int32) 
If reader.IsDBNull(6) Then 
	 _TipoDI = New System.Nullable(Of System.Int32)
Else
	 _TipoDI = reader.GetInt32(6)
End If
Dim _DI As String
If reader.IsDBNull(7) Then 
	 _DI = ""
Else
	 _DI = reader.GetString(7)
End If
Dim _Direccion As String
If reader.IsDBNull(8) Then 
	 _Direccion = ""
Else
	 _Direccion = reader.GetString(8)
End If
Dim _Distrito As System.Nullable(Of System.Int32) 
If reader.IsDBNull(9) Then 
	 _Distrito = New System.Nullable(Of System.Int32)
Else
	 _Distrito = reader.GetInt32(9)
End If
Dim _Provincia As System.Nullable(Of System.Int32) 
If reader.IsDBNull(10) Then 
	 _Provincia = New System.Nullable(Of System.Int32)
Else
	 _Provincia = reader.GetInt32(10)
End If
Dim _Pais As String
If reader.IsDBNull(11) Then 
	 _Pais = ""
Else
	 _Pais = reader.GetString(11)
End If
Dim _Telefono1 As String
If reader.IsDBNull(12) Then 
	 _Telefono1 = ""
Else
	 _Telefono1 = reader.GetString(12)
End If
Dim _Telefono2 As String
If reader.IsDBNull(13) Then 
	 _Telefono2 = ""
Else
	 _Telefono2 = reader.GetString(13)
End If
Dim _Fax As String
If reader.IsDBNull(14) Then 
	 _Fax = ""
Else
	 _Fax = reader.GetString(14)
End If
Dim _Email As String
If reader.IsDBNull(15) Then 
	 _Email = ""
Else
	 _Email = reader.GetString(15)
End If
Dim _Logo As String
If reader.IsDBNull(16) Then 
	 _Logo = ""
Else
	 _Logo = reader.GetString(16)
End If
Dim _Movil As String
If reader.IsDBNull(17) Then 
	 _Movil = ""
Else
	 _Movil = reader.GetString(17)
End If
Dim _TipMovil As String
If reader.IsDBNull(18) Then 
	 _TipMovil = ""
Else
	 _TipMovil = reader.GetString(18)
End If
Dim _Observaciones As String
If reader.IsDBNull(19) Then 
	 _Observaciones = ""
Else
	 _Observaciones = reader.GetString(19)
End If
Dim _CodCliente As String
If reader.IsDBNull(20) Then 
	 _CodCliente = ""
Else
	 _CodCliente = reader.GetString(20)
End If
Dim _CondPago As System.Nullable(Of System.Int32) 
If reader.IsDBNull(21) Then 
	 _CondPago = New System.Nullable(Of System.Int32)
Else
	 _CondPago = reader.GetInt32(21)
End If
Dim _Ruta As String
If reader.IsDBNull(22) Then 
	 _Ruta = ""
Else
	 _Ruta = reader.GetString(22)
End If
Dim _fechaderegistro As System.Nullable(Of System.DateTime) 
If reader.IsDBNull(23) Then 
	 _fechaderegistro = New System.Nullable(Of System.DateTime)
Else
	 _fechaderegistro = reader.GetDateTime(23)
End If
Dim _estadocliente As String
If reader.IsDBNull(24) Then 
	 _estadocliente = ""
Else
	 _estadocliente = reader.GetString(24)
End If
Dim _DistritosString As String
If reader.IsDBNull(25) Then 
	 _DistritosString = ""
Else
	 _DistritosString = reader.GetString(25)
End If
Dim _ProvinciasString As String
If reader.IsDBNull(26) Then 
	 _ProvinciasString = ""
Else
	 _ProvinciasString = reader.GetString(26)
End If

            Dim Clientes As IMappeableClientesObject  = CType(entity, IMappeableClientesObject)
            Clientes.HydrateFields(reader.GetInt32(0), _
_TipoCliente, _
_Nombre, _
_Apellido, _
_Cliente, _
_NomComercial, _
_TipoDI, _
_DI, _
_Direccion, _
_Distrito, _
_Provincia, _
_Pais, _
_Telefono1, _
_Telefono2, _
_Fax, _
_Email, _
_Logo, _
_Movil, _
_TipMovil, _
_Observaciones, _
_CodCliente, _
_CondPago, _
_Ruta, _
_fechaderegistro, _
_estadocliente, _
_DistritosString, _
_ProvinciasString)
        End Sub


        Protected Overrides Function StoredProceduresPrefix() As String 
            Return "coop_"
        End Function

        

        

        ' Complete the aggregations for this entity.         
        Protected Overrides Sub CompleteEntity(ByVal entity As t)
            Dim DistritosEntity As Objects.DistritosObject = Nothing 'Lazy load
Dim ProvinciasEntity As Objects.ProvinciasObject = Nothing 'Lazy load
            CType(entity, IMappeableClientes).CompleteEntity(DistritosEntity, ProvinciasEntity)
        End Sub

        


        ''' <summary>
        ''' Get a Clientes by execute a SQL Query Text
        ''' </summary>
        Public Function GetOneBySQLQuery(sqlQueryText As String) As t
            Return MyBase.GetObjectBySQLText(sqlQueryText)
        End Function

        ''' <summary>
        ''' Get a ClientesList by execute a SQL Query Text
        ''' </summary>
        Public Function GetBySQLQuery(sqlQueryText As String) As ObjectList(Of T)
            Return MyBase.GetObjectListBySQLText(sqlQueryText)
        End Function

        
        ''' <summary>
        ''' GetOne By Params
        ''' </summary>
        Public Overloads Function GetOne(IdCliente As System.Int32) As t
            Return MyBase.GetObjectByAnyStoredProcedure(StoredProceduresPrefix() + "Clientes_GetOne", IdCliente)
        End Function
        


        ' GetOne By Objects and Params
            

        

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByDistritos(Distrito As System.Int32) As ObjectList(Of T)
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Clientes_GetByDistritos", Distrito)
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByDistritos(ByVal Distritos As IUniqueIdentifiable) As ObjectList(Of T)
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Clientes_GetByDistritos", Distritos.Identifier())
        End Function

    

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByProvincias(Provincia As System.Int32) As ObjectList(Of T)
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Clientes_GetByProvincias", Provincia)
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByProvincias(ByVal Provincias As IUniqueIdentifiable) As ObjectList(Of T)
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Clientes_GetByProvincias", Provincias.Identifier())
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



