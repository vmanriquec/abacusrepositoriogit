
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 20/08/2013 - 01:49 p.m.
' This is a partial class file. The other one is TrabajadoresMapper.cs
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
    

    Public Partial Class TrabajadoresMapper
        Inherits BaseGateway(Of Trabajadores, TrabajadoresList)
        Implements IGenericGateway

#Region "Singleton"

        Private Shared _instance As TrabajadoresMapper

        Private Sub New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Shared Function Instance() As TrabajadoresMapper
            If _instance Is Nothing Then
                If HttpContext.Current Is Nothing Then
                    _instance = New TrabajadoresMapper()
                Else
                    Dim inst As TrabajadoresMapper = TryCast(HttpContext.Current.Items("abacusRules.TrabajadoresMapperSingleton"), TrabajadoresMapper)
                    If inst Is Nothing Then
                        inst = New TrabajadoresMapper()
                        HttpContext.Current.Items.Add("abacusRules.TrabajadoresMapperSingleton", inst)
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
            
            Dim  s() as String={"IdTrabjador"}
            return s
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Function GetMappingType() as Type
            return GetType(Trabajadores)
        End Function


        ''' <summary>
        ''' Return the mapped table name
        ''' </summary>
        Protected Overrides ReadOnly Property TableName() As String 
            Get
                Return "Trabajadores"
            End Get
        End Property

        ''' <summary>
        ''' Return the TrabajadoresGateway type FullName
        ''' </summary>
        Protected Overrides ReadOnly Property RuleName() As String
            Get
                Return GetType(TrabajadoresMapper).FullName
            End Get
        End Property


        

        

        ''' <summary>
        ''' Assign properties values based on DataReader
        ''' </summary>
        Protected Overrides Sub HydrateFields(ByVal reader As DbDataReader, ByVal entity As Trabajadores)
            Dim _idcargopersonal As System.Nullable(Of System.Int32) 
If reader.IsDBNull(1) Then 
	 _idcargopersonal = New System.Nullable(Of System.Int32)
Else
	 _idcargopersonal = reader.GetInt32(1)
End If
Dim _Nombres As String
If reader.IsDBNull(2) Then 
	 _Nombres = ""
Else
	 _Nombres = reader.GetString(2)
End If
Dim _Apellidos As String
If reader.IsDBNull(3) Then 
	 _Apellidos = ""
Else
	 _Apellidos = reader.GetString(3)
End If
Dim _DNI As String
If reader.IsDBNull(4) Then 
	 _DNI = ""
Else
	 _DNI = reader.GetString(4)
End If
Dim _Cargo As String
If reader.IsDBNull(5) Then 
	 _Cargo = ""
Else
	 _Cargo = reader.GetString(5)
End If
Dim _FecNacimiento As System.Nullable(Of System.DateTime) 
If reader.IsDBNull(6) Then 
	 _FecNacimiento = New System.Nullable(Of System.DateTime)
Else
	 _FecNacimiento = reader.GetDateTime(6)
End If
Dim _FecRegistro As System.Nullable(Of System.DateTime) 
If reader.IsDBNull(7) Then 
	 _FecRegistro = New System.Nullable(Of System.DateTime)
Else
	 _FecRegistro = reader.GetDateTime(7)
End If
Dim _fecRetiro As System.Nullable(Of System.DateTime) 
If reader.IsDBNull(8) Then 
	 _fecRetiro = New System.Nullable(Of System.DateTime)
Else
	 _fecRetiro = reader.GetDateTime(8)
End If
Dim _estado As String
If reader.IsDBNull(9) Then 
	 _estado = ""
Else
	 _estado = reader.GetString(9)
End If
Dim _cargopersonalString As String
If reader.IsDBNull(10) Then 
	 _cargopersonalString = ""
Else
	 _cargopersonalString = reader.GetString(10)
End If

            Dim Trabajadores As IMappeableTrabajadoresObject  = CType(entity, IMappeableTrabajadoresObject)
            Trabajadores.HydrateFields(reader.GetInt32(0), _
_idcargopersonal, _
_Nombres, _
_Apellidos, _
_DNI, _
_Cargo, _
_FecNacimiento, _
_FecRegistro, _
_fecRetiro, _
_estado, _
_cargopersonalString)
        End Sub

        ''' <summary>
        ''' Get field values to call insertion stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForInsert(ByVal entity As Trabajadores) As Object()
            Dim Trabajadores As IMappeableTrabajadoresObject = CType(entity, IMappeableTrabajadoresObject)
            Return Trabajadores.GetFieldsForInsert()
        End Function

        ''' <summary>
        ''' Get field values to call update stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForUpdate(ByVal entity As Trabajadores) As Object()
            Dim Trabajadores As IMappeableTrabajadoresObject = CType(entity, IMappeableTrabajadoresObject)
            Return Trabajadores.GetFieldsForUpdate()
        End Function

        ''' <summary>
        ''' Get field values to call deletion stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForDelete(ByVal entity As Trabajadores) As Object()
            Dim Trabajadores As IMappeableTrabajadoresObject = CType(entity, IMappeableTrabajadoresObject)
            Return Trabajadores.GetFieldsForDelete()
        End Function

        ''' <summary>
        ''' Raised after insert and update. Update properties from Output parameters
        ''' </summary>
        Protected Overrides Sub UpdateObjectFromOutputParams(ByVal entity As Trabajadores, ByVal parameters As Object())
            ' Update properties from Output parameters
            CType(entity, IMappeableTrabajadoresObject).UpdateObjectFromOutputParams(parameters)
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
        Protected Overrides Sub CompleteEntity(ByVal entity As Trabajadores)
            Dim cargopersonalEntity As Objects.cargopersonalObject = Nothing 'Lazy load
            CType(entity, IMappeableTrabajadores).CompleteEntity(cargopersonalEntity)
        End Sub


        # Region "CRUD Operations"
        

        # End Region
        
        ''' <summary>
        ''' Delete children for this entity
        ''' </summary>
        Public Sub DeleteChildren(ByVal transaction As DbTransaction, ByVal entity As IUniqueIdentifiable)
                        
        End Sub


          



        ''' <summary>
        ''' Get a Trabajadores by execute a SQL Query Text
        ''' </summary>
        Public Function GetOneBySQLQuery(sqlQueryText As String) As Trabajadores
            Return MyBase.GetObjectBySQLText(sqlQueryText)
        End Function

        ''' <summary>
        ''' Get a TrabajadoresList by execute a SQL Query Text
        ''' </summary>
        Public Function GetBySQLQuery(sqlQueryText As String) As TrabajadoresList
            Return MyBase.GetObjectListBySQLText(sqlQueryText)
        End Function

        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetOne(IdTrabjador As System.Int32) As Trabajadores
            Return MyBase.GetOne(New Trabajadores(IdTrabjador))
        End Function

        

        ' GetOne By Objects and Params
            

        

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetBycargopersonal(idcargopersonal As System.Int32) As TrabajadoresList
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Trabajadores_GetBycargopersonal", idcargopersonal)
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetBycargopersonal(ByVal cargopersonal As IUniqueIdentifiable) As TrabajadoresList
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Trabajadores_GetBycargopersonal", cargopersonal.Identifier())
        End Function

    


        

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetBycargopersonal(ByVal transaction As DbTransaction,idcargopersonal As System.Int32) As TrabajadoresList
            Return MyBase.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Trabajadores_GetBycargopersonal", idcargopersonal)
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetBycargopersonal(ByVal transaction As DbTransaction, ByVal cargopersonal As IUniqueIdentifiable) As TrabajadoresList
            Return MyBase.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Trabajadores_GetBycargopersonal", cargopersonal.Identifier())
        End Function

    

        





        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub Delete(IdTrabjador As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Trabajadores_Delete", IdTrabjador)
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub Delete(ByVal transaction As DbTransaction ,IdTrabjador As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Trabajadores_Delete", IdTrabjador)
        End Sub

        ' Delete By Objects and Params
            



        

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub DeleteBycargopersonal(idcargopersonal As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Trabajadores_DeleteBycargopersonal", idcargopersonal)
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub DeleteBycargopersonal(ByVal transaction As DbTransaction , idcargopersonal As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Trabajadores_DeleteBycargopersonal", idcargopersonal)
        End Sub


        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub DeleteBycargopersonal(ByVal cargopersonal As IUniqueIdentifiable)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Trabajadores_DeleteBycargopersonal", cargopersonal.Identifier())
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub DeleteBycargopersonal(ByVal transaction As DbTransaction, ByVal cargopersonal As IUniqueIdentifiable)        
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Trabajadores_DeleteBycargopersonal", cargopersonal.Identifier())
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
    Public Class TrabajadoresMapperWrapper

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
        Public Function Instance() As abacusRules.Mappers.TrabajadoresMapper
            Return abacusRules.Mappers.TrabajadoresMapper.Instance()
        End Function

        
        ''' <summary>
        ''' Get a Trabajadores Entity by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetOne(ByVal IdTrabjador As System.Int32) As Entities.Trabajadores         
            Return Instance().GetOne( IdTrabjador)
        End Function
        

        ' GetBy Objects and Params
            

        

        ''' <summary>
        ''' Get a TrabajadoresList by calling a Stored Procedure
        ''' </summary>
        Public Function GetBycargopersonal( ByVal idcargopersonal As System.Int32) As Entities.TrabajadoresList 
            Return Instance().GetBycargopersonal(idcargopersonal)
        End Function

        ''' <summary>
        ''' Get a TrabajadoresList by calling a Stored Procedure
        ''' </summary>
        Public Function GetBycargopersonal(ByVal  cargopersonal As IUniqueIdentifiable) As Entities.TrabajadoresList
            Return Instance().GetBycargopersonal(cargopersonal)
        End Function

    

        ''' <summary>
        ''' GetAll Trabajadores 
        ''' </summary>
        Public Function GetAll() As Entities.TrabajadoresList
            Return Instance().GetAll()
        End Function

        
        

        ''' <summary>
        ''' Delete children for Trabajadores
        ''' </summary>
        Public Sub DeleteChildren(ByVal transaction As DbTransaction, ByVal entity As Trabajadores)
            Instance().DeleteChildren(transaction, entity)
        End Sub

        


            

        

        ''' <summary>
        ''' Delete Trabajadores by cargopersonal
        ''' </summary>
        Public Sub DeleteBycargopersonal( ByVal idcargopersonal As System.Int32)
            Instance().DeleteBycargopersonal(idcargopersonal)
        End Sub

        ''' <summary>
        ''' Delete Trabajadores by cargopersonal
        ''' </summary>
        Public Sub DeleteBycargopersonal(ByVal cargopersonal As IUniqueIdentifiable )
            Instance().DeleteBycargopersonal(cargopersonal)
        End Sub

    

        ''' <summary>
        ''' Delete Trabajadores 
        ''' </summary>
        Public Overloads Sub Delete(ByVal IdTrabjador As System.Int32)
            Instance().Delete(IdTrabjador)
        End Sub

        ''' <summary>
        ''' Delete Trabajadores 
        ''' </summary>
        Public Overloads Sub Delete(ByVal entity As Entities.Trabajadores)
            Instance().Delete(entity)
        End Sub

        ''' <summary>
        ''' Save Trabajadores  
        ''' </summary>
        Public Overloads Sub Save(ByVal entity As Entities.Trabajadores)
            Instance().Save(entity)
        End Sub

        ''' <summary>
        ''' Insert Trabajadores 
        ''' </summary>
        Public Overloads Sub Insert(ByVal entity As Entities.Trabajadores)
            Instance().Insert(entity)
        End Sub

        ''' <summary>
        ''' Save Trabajadores 
        ''' </summary>
        Public Overloads Sub Save(ByVal IdTrabjador As System.Int32, ByVal idcargopersonal As System.Int32, ByVal Nombres As System.String, ByVal Apellidos As System.String, ByVal DNI As System.String, ByVal Cargo As System.String, ByVal FecNacimiento As System.DateTime, ByVal FecRegistro As System.DateTime, ByVal fecRetiro As System.DateTime, ByVal estado As System.String, ByVal cargopersonalString As System.String)
            Dim entity As Entities.Trabajadores = Instance().GetOne(IdTrabjador)
            If entity Is Nothing Then
                Throw New ApplicationException(String.Format("Entity not found. IUniqueIdentifiable values: {0} = {1}", "IdTrabjador", IdTrabjador))
            End If

            entity.idcargopersonal = idcargopersonal
            entity.Nombres = Nombres
            entity.Apellidos = Apellidos
            entity.DNI = DNI
            entity.Cargo = Cargo
            entity.FecNacimiento = FecNacimiento
            entity.FecRegistro = FecRegistro
            entity.fecRetiro = fecRetiro
            entity.estado = estado
            Instance().Save(entity)
        End Sub

        ''' <summary>
        ''' Insert Trabajadores
        ''' </summary>
        Public Overloads Sub Insert(ByVal idcargopersonal As System.Int32, ByVal Nombres As System.String, ByVal Apellidos As System.String, ByVal DNI As System.String, ByVal Cargo As System.String, ByVal FecNacimiento As System.DateTime, ByVal FecRegistro As System.DateTime, ByVal fecRetiro As System.DateTime, ByVal estado As System.String)
            Dim entity As Entities.Trabajadores = New Entities.Trabajadores

            entity.idcargopersonal = idcargopersonal
            entity.Nombres = Nombres
            entity.Apellidos = Apellidos
            entity.DNI = DNI
            entity.Cargo = Cargo
            entity.FecNacimiento = FecNacimiento
            entity.FecRegistro = FecRegistro
            entity.fecRetiro = fecRetiro
            entity.estado = estado
            Instance().Insert(entity)
        End Sub

        

        'Database Queries 
        


    End Class
End Namespace


Namespace Loaders

    ''' <summary>
    ''' 
    ''' </summary>
    Partial Public Class TrabajadoresLoader(Of T As {Trabajadores, New})
        Inherits BaseLoader(Of T, Trabajadores, ObjectList(Of T))
        Implements IGenericGateway



#Region "Singleton"

        Private Shared _instance As TrabajadoresLoader(Of T)

        Private Sub New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Shared Function Instance() As TrabajadoresLoader(Of T)
            If _instance Is Nothing Then
                If HttpContext.Current Is Nothing Then
                    _instance = New TrabajadoresLoader(Of T)
                Else
                    Dim inst As TrabajadoresLoader(Of T) = TryCast(HttpContext.Current.Items("abacusRules.TrabajadoresLoaderSingleton"), TrabajadoresLoader(Of T))
                    If inst Is Nothing Then
                        inst = New TrabajadoresLoader(Of T)
                        HttpContext.Current.Items.Add("abacusRules.TrabajadoresLoaderSingleton", inst)
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
            
            Dim s() as String={"IdTrabjador"}
            Return s
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Function GetMappingType() as Type
            Return GetType(Trabajadores)
        End Function


        Protected Overrides ReadOnly Property TableName As String 
            Get
                Return "Trabajadores"
            End Get
        End Property

        

        


        Protected Overrides Sub HydrateFields(ByVal reader As DbDataReader, ByVal entity As Trabajadores)
            Dim _idcargopersonal As System.Nullable(Of System.Int32) 
If reader.IsDBNull(1) Then 
	 _idcargopersonal = New System.Nullable(Of System.Int32)
Else
	 _idcargopersonal = reader.GetInt32(1)
End If
Dim _Nombres As String
If reader.IsDBNull(2) Then 
	 _Nombres = ""
Else
	 _Nombres = reader.GetString(2)
End If
Dim _Apellidos As String
If reader.IsDBNull(3) Then 
	 _Apellidos = ""
Else
	 _Apellidos = reader.GetString(3)
End If
Dim _DNI As String
If reader.IsDBNull(4) Then 
	 _DNI = ""
Else
	 _DNI = reader.GetString(4)
End If
Dim _Cargo As String
If reader.IsDBNull(5) Then 
	 _Cargo = ""
Else
	 _Cargo = reader.GetString(5)
End If
Dim _FecNacimiento As System.Nullable(Of System.DateTime) 
If reader.IsDBNull(6) Then 
	 _FecNacimiento = New System.Nullable(Of System.DateTime)
Else
	 _FecNacimiento = reader.GetDateTime(6)
End If
Dim _FecRegistro As System.Nullable(Of System.DateTime) 
If reader.IsDBNull(7) Then 
	 _FecRegistro = New System.Nullable(Of System.DateTime)
Else
	 _FecRegistro = reader.GetDateTime(7)
End If
Dim _fecRetiro As System.Nullable(Of System.DateTime) 
If reader.IsDBNull(8) Then 
	 _fecRetiro = New System.Nullable(Of System.DateTime)
Else
	 _fecRetiro = reader.GetDateTime(8)
End If
Dim _estado As String
If reader.IsDBNull(9) Then 
	 _estado = ""
Else
	 _estado = reader.GetString(9)
End If
Dim _cargopersonalString As String
If reader.IsDBNull(10) Then 
	 _cargopersonalString = ""
Else
	 _cargopersonalString = reader.GetString(10)
End If

            Dim Trabajadores As IMappeableTrabajadoresObject  = CType(entity, IMappeableTrabajadoresObject)
            Trabajadores.HydrateFields(reader.GetInt32(0), _
_idcargopersonal, _
_Nombres, _
_Apellidos, _
_DNI, _
_Cargo, _
_FecNacimiento, _
_FecRegistro, _
_fecRetiro, _
_estado, _
_cargopersonalString)
        End Sub


        Protected Overrides Function StoredProceduresPrefix() As String 
            Return "coop_"
        End Function

        

        

        ' Complete the aggregations for this entity.         
        Protected Overrides Sub CompleteEntity(ByVal entity As t)
            Dim cargopersonalEntity As Objects.cargopersonalObject = Nothing 'Lazy load
            CType(entity, IMappeableTrabajadores).CompleteEntity(cargopersonalEntity)
        End Sub

        


        ''' <summary>
        ''' Get a Trabajadores by execute a SQL Query Text
        ''' </summary>
        Public Function GetOneBySQLQuery(sqlQueryText As String) As t
            Return MyBase.GetObjectBySQLText(sqlQueryText)
        End Function

        ''' <summary>
        ''' Get a TrabajadoresList by execute a SQL Query Text
        ''' </summary>
        Public Function GetBySQLQuery(sqlQueryText As String) As ObjectList(Of T)
            Return MyBase.GetObjectListBySQLText(sqlQueryText)
        End Function

        
        ''' <summary>
        ''' GetOne By Params
        ''' </summary>
        Public Overloads Function GetOne(IdTrabjador As System.Int32) As t
            Return MyBase.GetObjectByAnyStoredProcedure(StoredProceduresPrefix() + "Trabajadores_GetOne", IdTrabjador)
        End Function
        


        ' GetOne By Objects and Params
            

        

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetBycargopersonal(idcargopersonal As System.Int32) As ObjectList(Of T)
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Trabajadores_GetBycargopersonal", idcargopersonal)
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetBycargopersonal(ByVal cargopersonal As IUniqueIdentifiable) As ObjectList(Of T)
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Trabajadores_GetBycargopersonal", cargopersonal.Identifier())
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



