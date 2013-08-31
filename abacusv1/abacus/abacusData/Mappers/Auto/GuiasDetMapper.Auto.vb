
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 15/08/2013 - 05:51 p.m.
' This is a partial class file. The other one is GuiasDetMapper.cs
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
    

    Public Partial Class GuiasDetMapper
        Inherits BaseGateway(Of GuiasDet, GuiasDetList)
        Implements IGenericGateway

#Region "Singleton"

        Private Shared _instance As GuiasDetMapper

        Private Sub New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Shared Function Instance() As GuiasDetMapper
            If _instance Is Nothing Then
                If HttpContext.Current Is Nothing Then
                    _instance = New GuiasDetMapper()
                Else
                    Dim inst As GuiasDetMapper = TryCast(HttpContext.Current.Items("abacusRules.GuiasDetMapperSingleton"), GuiasDetMapper)
                    If inst Is Nothing Then
                        inst = New GuiasDetMapper()
                        HttpContext.Current.Items.Add("abacusRules.GuiasDetMapperSingleton", inst)
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
            
            Dim  s() as String={"IdGuiasDet"}
            return s
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Function GetMappingType() as Type
            return GetType(GuiasDet)
        End Function


        ''' <summary>
        ''' Return the mapped table name
        ''' </summary>
        Protected Overrides ReadOnly Property TableName() As String 
            Get
                Return "GuiasDet"
            End Get
        End Property

        ''' <summary>
        ''' Return the GuiasDetGateway type FullName
        ''' </summary>
        Protected Overrides ReadOnly Property RuleName() As String
            Get
                Return GetType(GuiasDetMapper).FullName
            End Get
        End Property


        

        

        ''' <summary>
        ''' Assign properties values based on DataReader
        ''' </summary>
        Protected Overrides Sub HydrateFields(ByVal reader As DbDataReader, ByVal entity As GuiasDet)
            Dim _IdProducto As System.Nullable(Of System.Int32) 
If reader.IsDBNull(1) Then 
	 _IdProducto = New System.Nullable(Of System.Int32)
Else
	 _IdProducto = reader.GetInt32(1)
End If
Dim _Cantidad As System.Nullable(Of System.Int32) 
If reader.IsDBNull(2) Then 
	 _Cantidad = New System.Nullable(Of System.Int32)
Else
	 _Cantidad = reader.GetInt32(2)
End If
Dim _UMedida As String
If reader.IsDBNull(3) Then 
	 _UMedida = ""
Else
	 _UMedida = reader.GetString(3)
End If
Dim _Peso As String
If reader.IsDBNull(4) Then 
	 _Peso = ""
Else
	 _Peso = reader.GetString(4)
End If
Dim _Serie As String
If reader.IsDBNull(5) Then 
	 _Serie = ""
Else
	 _Serie = reader.GetString(5)
End If
Dim _Codigo As String
If reader.IsDBNull(6) Then 
	 _Codigo = ""
Else
	 _Codigo = reader.GetString(6)
End If
Dim _IdGuias As System.Nullable(Of System.Int32) 
If reader.IsDBNull(7) Then 
	 _IdGuias = New System.Nullable(Of System.Int32)
Else
	 _IdGuias = reader.GetInt32(7)
End If
Dim _IdTienda As System.Nullable(Of System.Int32) 
If reader.IsDBNull(8) Then 
	 _IdTienda = New System.Nullable(Of System.Int32)
Else
	 _IdTienda = reader.GetInt32(8)
End If
Dim _GuiasString As String
If reader.IsDBNull(9) Then 
	 _GuiasString = ""
Else
	 _GuiasString = reader.GetString(9)
End If
Dim _ProductosString As String
If reader.IsDBNull(10) Then 
	 _ProductosString = ""
Else
	 _ProductosString = reader.GetString(10)
End If

            Dim GuiasDet As IMappeableGuiasDetObject  = CType(entity, IMappeableGuiasDetObject)
            GuiasDet.HydrateFields(reader.GetInt32(0), _
_IdProducto, _
_Cantidad, _
_UMedida, _
_Peso, _
_Serie, _
_Codigo, _
_IdGuias, _
_IdTienda, _
_GuiasString, _
_ProductosString)
        End Sub

        ''' <summary>
        ''' Get field values to call insertion stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForInsert(ByVal entity As GuiasDet) As Object()
            Dim GuiasDet As IMappeableGuiasDetObject = CType(entity, IMappeableGuiasDetObject)
            Return GuiasDet.GetFieldsForInsert()
        End Function

        ''' <summary>
        ''' Get field values to call update stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForUpdate(ByVal entity As GuiasDet) As Object()
            Dim GuiasDet As IMappeableGuiasDetObject = CType(entity, IMappeableGuiasDetObject)
            Return GuiasDet.GetFieldsForUpdate()
        End Function

        ''' <summary>
        ''' Get field values to call deletion stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForDelete(ByVal entity As GuiasDet) As Object()
            Dim GuiasDet As IMappeableGuiasDetObject = CType(entity, IMappeableGuiasDetObject)
            Return GuiasDet.GetFieldsForDelete()
        End Function

        ''' <summary>
        ''' Raised after insert and update. Update properties from Output parameters
        ''' </summary>
        Protected Overrides Sub UpdateObjectFromOutputParams(ByVal entity As GuiasDet, ByVal parameters As Object())
            ' Update properties from Output parameters
            CType(entity, IMappeableGuiasDetObject).UpdateObjectFromOutputParams(parameters)
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
        Protected Overrides Sub CompleteEntity(ByVal entity As GuiasDet)
            Dim GuiasEntity As Objects.GuiasObject = Nothing 'Lazy load
Dim ProductosEntity As Objects.ProductosObject = Nothing 'Lazy load
            CType(entity, IMappeableGuiasDet).CompleteEntity(GuiasEntity, ProductosEntity)
        End Sub


        # Region "CRUD Operations"
        

        # End Region
        
        ''' <summary>
        ''' Delete children for this entity
        ''' </summary>
        Public Sub DeleteChildren(ByVal transaction As DbTransaction, ByVal entity As IUniqueIdentifiable)
                        
        End Sub


          



        ''' <summary>
        ''' Get a GuiasDet by execute a SQL Query Text
        ''' </summary>
        Public Function GetOneBySQLQuery(sqlQueryText As String) As GuiasDet
            Return MyBase.GetObjectBySQLText(sqlQueryText)
        End Function

        ''' <summary>
        ''' Get a GuiasDetList by execute a SQL Query Text
        ''' </summary>
        Public Function GetBySQLQuery(sqlQueryText As String) As GuiasDetList
            Return MyBase.GetObjectListBySQLText(sqlQueryText)
        End Function

        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetOne(IdGuiasDet As System.Int32) As GuiasDet
            Return MyBase.GetOne(New GuiasDet(IdGuiasDet))
        End Function

        

        ' GetOne By Objects and Params
            

        

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByGuias(IdGuias As System.Int32) As GuiasDetList
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "GuiasDet_GetByGuias", IdGuias)
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByGuias(ByVal Guias As IUniqueIdentifiable) As GuiasDetList
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "GuiasDet_GetByGuias", Guias.Identifier())
        End Function

    

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByProductos(IdProducto As System.Int32) As GuiasDetList
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "GuiasDet_GetByProductos", IdProducto)
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByProductos(ByVal Productos As IUniqueIdentifiable) As GuiasDetList
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "GuiasDet_GetByProductos", Productos.Identifier())
        End Function

    


        

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByGuias(ByVal transaction As DbTransaction,IdGuias As System.Int32) As GuiasDetList
            Return MyBase.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "GuiasDet_GetByGuias", IdGuias)
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByGuias(ByVal transaction As DbTransaction, ByVal Guias As IUniqueIdentifiable) As GuiasDetList
            Return MyBase.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "GuiasDet_GetByGuias", Guias.Identifier())
        End Function

    

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByProductos(ByVal transaction As DbTransaction,IdProducto As System.Int32) As GuiasDetList
            Return MyBase.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "GuiasDet_GetByProductos", IdProducto)
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByProductos(ByVal transaction As DbTransaction, ByVal Productos As IUniqueIdentifiable) As GuiasDetList
            Return MyBase.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "GuiasDet_GetByProductos", Productos.Identifier())
        End Function

    

        





        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub Delete(IdGuiasDet As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "GuiasDet_Delete", IdGuiasDet)
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub Delete(ByVal transaction As DbTransaction ,IdGuiasDet As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "GuiasDet_Delete", IdGuiasDet)
        End Sub

        ' Delete By Objects and Params
            



        

    

    

    

    

    

    

    

    

    

    

    

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub DeleteByGuias(IdGuias As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "GuiasDet_DeleteByGuias", IdGuias)
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub DeleteByGuias(ByVal transaction As DbTransaction , IdGuias As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "GuiasDet_DeleteByGuias", IdGuias)
        End Sub


        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub DeleteByGuias(ByVal Guias As IUniqueIdentifiable)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "GuiasDet_DeleteByGuias", Guias.Identifier())
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub DeleteByGuias(ByVal transaction As DbTransaction, ByVal Guias As IUniqueIdentifiable)        
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "GuiasDet_DeleteByGuias", Guias.Identifier())
        End Sub

        

    

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub DeleteByProductos(IdProducto As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "GuiasDet_DeleteByProductos", IdProducto)
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub DeleteByProductos(ByVal transaction As DbTransaction , IdProducto As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "GuiasDet_DeleteByProductos", IdProducto)
        End Sub


        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub DeleteByProductos(ByVal Productos As IUniqueIdentifiable)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "GuiasDet_DeleteByProductos", Productos.Identifier())
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub DeleteByProductos(ByVal transaction As DbTransaction, ByVal Productos As IUniqueIdentifiable)        
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "GuiasDet_DeleteByProductos", Productos.Identifier())
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
    Public Class GuiasDetMapperWrapper

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
        Public Function Instance() As abacusRules.Mappers.GuiasDetMapper
            Return abacusRules.Mappers.GuiasDetMapper.Instance()
        End Function

        
        ''' <summary>
        ''' Get a GuiasDet Entity by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetOne(ByVal IdGuiasDet As System.Int32) As Entities.GuiasDet         
            Return Instance().GetOne( IdGuiasDet)
        End Function
        

        ' GetBy Objects and Params
            

        

        ''' <summary>
        ''' Get a GuiasDetList by calling a Stored Procedure
        ''' </summary>
        Public Function GetByGuias( ByVal IdGuias As System.Int32) As Entities.GuiasDetList 
            Return Instance().GetByGuias(IdGuias)
        End Function

        ''' <summary>
        ''' Get a GuiasDetList by calling a Stored Procedure
        ''' </summary>
        Public Function GetByGuias(ByVal  Guias As IUniqueIdentifiable) As Entities.GuiasDetList
            Return Instance().GetByGuias(Guias)
        End Function

    

        ''' <summary>
        ''' Get a GuiasDetList by calling a Stored Procedure
        ''' </summary>
        Public Function GetByProductos( ByVal IdProducto As System.Int32) As Entities.GuiasDetList 
            Return Instance().GetByProductos(IdProducto)
        End Function

        ''' <summary>
        ''' Get a GuiasDetList by calling a Stored Procedure
        ''' </summary>
        Public Function GetByProductos(ByVal  Productos As IUniqueIdentifiable) As Entities.GuiasDetList
            Return Instance().GetByProductos(Productos)
        End Function

    

        ''' <summary>
        ''' GetAll GuiasDet 
        ''' </summary>
        Public Function GetAll() As Entities.GuiasDetList
            Return Instance().GetAll()
        End Function

        
        

        ''' <summary>
        ''' Delete children for GuiasDet
        ''' </summary>
        Public Sub DeleteChildren(ByVal transaction As DbTransaction, ByVal entity As GuiasDet)
            Instance().DeleteChildren(transaction, entity)
        End Sub

        


            

        

        ''' <summary>
        ''' Delete GuiasDet by Guias
        ''' </summary>
        Public Sub DeleteByGuias( ByVal IdGuias As System.Int32)
            Instance().DeleteByGuias(IdGuias)
        End Sub

        ''' <summary>
        ''' Delete GuiasDet by Guias
        ''' </summary>
        Public Sub DeleteByGuias(ByVal Guias As IUniqueIdentifiable )
            Instance().DeleteByGuias(Guias)
        End Sub

    

        ''' <summary>
        ''' Delete GuiasDet by Productos
        ''' </summary>
        Public Sub DeleteByProductos( ByVal IdProducto As System.Int32)
            Instance().DeleteByProductos(IdProducto)
        End Sub

        ''' <summary>
        ''' Delete GuiasDet by Productos
        ''' </summary>
        Public Sub DeleteByProductos(ByVal Productos As IUniqueIdentifiable )
            Instance().DeleteByProductos(Productos)
        End Sub

    

        ''' <summary>
        ''' Delete GuiasDet 
        ''' </summary>
        Public Overloads Sub Delete(ByVal IdGuiasDet As System.Int32)
            Instance().Delete(IdGuiasDet)
        End Sub

        ''' <summary>
        ''' Delete GuiasDet 
        ''' </summary>
        Public Overloads Sub Delete(ByVal entity As Entities.GuiasDet)
            Instance().Delete(entity)
        End Sub

        ''' <summary>
        ''' Save GuiasDet  
        ''' </summary>
        Public Overloads Sub Save(ByVal entity As Entities.GuiasDet)
            Instance().Save(entity)
        End Sub

        ''' <summary>
        ''' Insert GuiasDet 
        ''' </summary>
        Public Overloads Sub Insert(ByVal entity As Entities.GuiasDet)
            Instance().Insert(entity)
        End Sub

        ''' <summary>
        ''' Save GuiasDet 
        ''' </summary>
        Public Overloads Sub Save(ByVal IdGuiasDet As System.Int32, ByVal IdProducto As System.Int32, ByVal Cantidad As System.Int32, ByVal UMedida As System.String, ByVal Peso As System.String, ByVal Serie As System.String, ByVal Codigo As System.String, ByVal IdGuias As System.Int32, ByVal IdTienda As System.Int32, ByVal GuiasString As System.String, ByVal ProductosString As System.String)
            Dim entity As Entities.GuiasDet = Instance().GetOne(IdGuiasDet)
            If entity Is Nothing Then
                Throw New ApplicationException(String.Format("Entity not found. IUniqueIdentifiable values: {0} = {1}", "IdGuiasDet", IdGuiasDet))
            End If

            entity.IdProducto = IdProducto
            entity.Cantidad = Cantidad
            entity.UMedida = UMedida
            entity.Peso = Peso
            entity.Serie = Serie
            entity.Codigo = Codigo
            entity.IdGuias = IdGuias
            entity.IdTienda = IdTienda
            Instance().Save(entity)
        End Sub

        ''' <summary>
        ''' Insert GuiasDet
        ''' </summary>
        Public Overloads Sub Insert(ByVal IdProducto As System.Int32, ByVal Cantidad As System.Int32, ByVal UMedida As System.String, ByVal Peso As System.String, ByVal Serie As System.String, ByVal Codigo As System.String, ByVal IdGuias As System.Int32, ByVal IdTienda As System.Int32)
            Dim entity As Entities.GuiasDet = New Entities.GuiasDet

            entity.IdProducto = IdProducto
            entity.Cantidad = Cantidad
            entity.UMedida = UMedida
            entity.Peso = Peso
            entity.Serie = Serie
            entity.Codigo = Codigo
            entity.IdGuias = IdGuias
            entity.IdTienda = IdTienda
            Instance().Insert(entity)
        End Sub

        

        'Database Queries 
        


    End Class
End Namespace


Namespace Loaders

    ''' <summary>
    ''' 
    ''' </summary>
    Partial Public Class GuiasDetLoader(Of T As {GuiasDet, New})
        Inherits BaseLoader(Of T, GuiasDet, ObjectList(Of T))
        Implements IGenericGateway



#Region "Singleton"

        Private Shared _instance As GuiasDetLoader(Of T)

        Private Sub New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Shared Function Instance() As GuiasDetLoader(Of T)
            If _instance Is Nothing Then
                If HttpContext.Current Is Nothing Then
                    _instance = New GuiasDetLoader(Of T)
                Else
                    Dim inst As GuiasDetLoader(Of T) = TryCast(HttpContext.Current.Items("abacusRules.GuiasDetLoaderSingleton"), GuiasDetLoader(Of T))
                    If inst Is Nothing Then
                        inst = New GuiasDetLoader(Of T)
                        HttpContext.Current.Items.Add("abacusRules.GuiasDetLoaderSingleton", inst)
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
            
            Dim s() as String={"IdGuiasDet"}
            Return s
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Function GetMappingType() as Type
            Return GetType(GuiasDet)
        End Function


        Protected Overrides ReadOnly Property TableName As String 
            Get
                Return "GuiasDet"
            End Get
        End Property

        

        


        Protected Overrides Sub HydrateFields(ByVal reader As DbDataReader, ByVal entity As GuiasDet)
            Dim _IdProducto As System.Nullable(Of System.Int32) 
If reader.IsDBNull(1) Then 
	 _IdProducto = New System.Nullable(Of System.Int32)
Else
	 _IdProducto = reader.GetInt32(1)
End If
Dim _Cantidad As System.Nullable(Of System.Int32) 
If reader.IsDBNull(2) Then 
	 _Cantidad = New System.Nullable(Of System.Int32)
Else
	 _Cantidad = reader.GetInt32(2)
End If
Dim _UMedida As String
If reader.IsDBNull(3) Then 
	 _UMedida = ""
Else
	 _UMedida = reader.GetString(3)
End If
Dim _Peso As String
If reader.IsDBNull(4) Then 
	 _Peso = ""
Else
	 _Peso = reader.GetString(4)
End If
Dim _Serie As String
If reader.IsDBNull(5) Then 
	 _Serie = ""
Else
	 _Serie = reader.GetString(5)
End If
Dim _Codigo As String
If reader.IsDBNull(6) Then 
	 _Codigo = ""
Else
	 _Codigo = reader.GetString(6)
End If
Dim _IdGuias As System.Nullable(Of System.Int32) 
If reader.IsDBNull(7) Then 
	 _IdGuias = New System.Nullable(Of System.Int32)
Else
	 _IdGuias = reader.GetInt32(7)
End If
Dim _IdTienda As System.Nullable(Of System.Int32) 
If reader.IsDBNull(8) Then 
	 _IdTienda = New System.Nullable(Of System.Int32)
Else
	 _IdTienda = reader.GetInt32(8)
End If
Dim _GuiasString As String
If reader.IsDBNull(9) Then 
	 _GuiasString = ""
Else
	 _GuiasString = reader.GetString(9)
End If
Dim _ProductosString As String
If reader.IsDBNull(10) Then 
	 _ProductosString = ""
Else
	 _ProductosString = reader.GetString(10)
End If

            Dim GuiasDet As IMappeableGuiasDetObject  = CType(entity, IMappeableGuiasDetObject)
            GuiasDet.HydrateFields(reader.GetInt32(0), _
_IdProducto, _
_Cantidad, _
_UMedida, _
_Peso, _
_Serie, _
_Codigo, _
_IdGuias, _
_IdTienda, _
_GuiasString, _
_ProductosString)
        End Sub


        Protected Overrides Function StoredProceduresPrefix() As String 
            Return "coop_"
        End Function

        

        

        ' Complete the aggregations for this entity.         
        Protected Overrides Sub CompleteEntity(ByVal entity As t)
            Dim GuiasEntity As Objects.GuiasObject = Nothing 'Lazy load
Dim ProductosEntity As Objects.ProductosObject = Nothing 'Lazy load
            CType(entity, IMappeableGuiasDet).CompleteEntity(GuiasEntity, ProductosEntity)
        End Sub

        


        ''' <summary>
        ''' Get a GuiasDet by execute a SQL Query Text
        ''' </summary>
        Public Function GetOneBySQLQuery(sqlQueryText As String) As t
            Return MyBase.GetObjectBySQLText(sqlQueryText)
        End Function

        ''' <summary>
        ''' Get a GuiasDetList by execute a SQL Query Text
        ''' </summary>
        Public Function GetBySQLQuery(sqlQueryText As String) As ObjectList(Of T)
            Return MyBase.GetObjectListBySQLText(sqlQueryText)
        End Function

        
        ''' <summary>
        ''' GetOne By Params
        ''' </summary>
        Public Overloads Function GetOne(IdGuiasDet As System.Int32) As t
            Return MyBase.GetObjectByAnyStoredProcedure(StoredProceduresPrefix() + "GuiasDet_GetOne", IdGuiasDet)
        End Function
        


        ' GetOne By Objects and Params
            

        

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByGuias(IdGuias As System.Int32) As ObjectList(Of T)
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "GuiasDet_GetByGuias", IdGuias)
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByGuias(ByVal Guias As IUniqueIdentifiable) As ObjectList(Of T)
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "GuiasDet_GetByGuias", Guias.Identifier())
        End Function

    

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByProductos(IdProducto As System.Int32) As ObjectList(Of T)
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "GuiasDet_GetByProductos", IdProducto)
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetByProductos(ByVal Productos As IUniqueIdentifiable) As ObjectList(Of T)
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "GuiasDet_GetByProductos", Productos.Identifier())
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




