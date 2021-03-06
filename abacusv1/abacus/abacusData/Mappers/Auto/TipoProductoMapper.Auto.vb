
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 15/08/2013 - 05:51 p.m.
' This is a partial class file. The other one is TipoProductoMapper.cs
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
    

    Public Partial Class TipoProductoMapper
        Inherits BaseGateway(Of TipoProductoObject, TipoProductoObjectList)
        Implements IGenericGateway

#Region "Singleton"

        Private Shared _instance As TipoProductoMapper

        Private Sub New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Shared Function Instance() As TipoProductoMapper
            If _instance Is Nothing Then
                If HttpContext.Current Is Nothing Then
                    _instance = New TipoProductoMapper()
                Else
                    Dim inst As TipoProductoMapper = TryCast(HttpContext.Current.Items("abacusRules.TipoProductoMapperSingleton"), TipoProductoMapper)
                    If inst Is Nothing Then
                        inst = New TipoProductoMapper()
                        HttpContext.Current.Items.Add("abacusRules.TipoProductoMapperSingleton", inst)
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
            
            Dim  s() as String={"Id_TipoProducto"}
            return s
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Function GetMappingType() as Type
            return GetType(TipoProductoObject)
        End Function


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
                Return GetType(TipoProductoMapper).FullName
            End Get
        End Property


        

        

        ''' <summary>
        ''' Assign properties values based on DataReader
        ''' </summary>
        Protected Overrides Sub HydrateFields(ByVal reader As DbDataReader, ByVal entity As TipoProductoObject)
            Dim _TipoProducto As String
If reader.IsDBNull(1) Then 
	 _TipoProducto = ""
Else
	 _TipoProducto = reader.GetString(1)
End If

            Dim TipoProducto As IMappeableTipoProductoObject  = CType(entity, IMappeableTipoProductoObject)
            TipoProducto.HydrateFields(reader.GetInt32(0), _
_TipoProducto)
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
        Protected Overrides Sub UpdateObjectFromOutputParams(ByVal entity As TipoProductoObject, ByVal parameters As Object())
            ' Update properties from Output parameters
            CType(entity, IMappeableTipoProductoObject).UpdateObjectFromOutputParams(parameters)
        End Sub

        ''' <summary>
        ''' StoredProceduresPrefix, for example: coop_
        ''' </summary>
        Protected Overrides Function StoredProceduresPrefix() As String 
            Return "coop_"
        End Function


          



        ''' <summary>
        ''' Get a TipoProducto by execute a SQL Query Text
        ''' </summary>
        Public Function GetOneBySQLQuery(sqlQueryText As String) As TipoProductoObject
            Return MyBase.GetObjectBySQLText(sqlQueryText)
        End Function

        ''' <summary>
        ''' Get a TipoProductoList by execute a SQL Query Text
        ''' </summary>
        Public Function GetBySQLQuery(sqlQueryText As String) As TipoProductoObjectList
            Return MyBase.GetObjectListBySQLText(sqlQueryText)
        End Function

        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetOne(Id_TipoProducto As System.Int32) As TipoProductoObject
            Return MyBase.GetOne(New TipoProductoObject(Id_TipoProducto))
        End Function

        

        ' GetOne By Objects and Params
            

        


        

        





        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub Delete(Id_TipoProducto As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "TipoProducto_Delete", Id_TipoProducto)
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub Delete(ByVal transaction As DbTransaction ,Id_TipoProducto As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "TipoProducto_Delete", Id_TipoProducto)
        End Sub

        ' Delete By Objects and Params
            



        

    

    

    


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
    Public Class TipoProductoMapperWrapper

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
        Public Function Instance() As abacusRules.Mappers.TipoProductoMapper
            Return abacusRules.Mappers.TipoProductoMapper.Instance()
        End Function

        
        ''' <summary>
        ''' Get a TipoProducto Entity by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetOne(ByVal Id_TipoProducto As System.Int32) As Objects.TipoProductoObject         
            Return Instance().GetOne( Id_TipoProducto)
        End Function
        

        ' GetBy Objects and Params
            

        

        ''' <summary>
        ''' GetAll TipoProducto 
        ''' </summary>
        Public Function GetAll() As Objects.TipoProductoObjectList
            Return Instance().GetAll()
        End Function

        
        


            

        

        ''' <summary>
        ''' Delete TipoProducto 
        ''' </summary>
        Public Overloads Sub Delete(ByVal Id_TipoProducto As System.Int32)
            Instance().Delete(Id_TipoProducto)
        End Sub

        ''' <summary>
        ''' Delete TipoProducto 
        ''' </summary>
        Public Overloads Sub Delete(ByVal entity As Objects.TipoProductoObject)
            Instance().Delete(entity)
        End Sub

        ''' <summary>
        ''' Save TipoProducto  
        ''' </summary>
        Public Overloads Sub Save(ByVal entity As Objects.TipoProductoObject)
            Instance().Save(entity)
        End Sub

        ''' <summary>
        ''' Insert TipoProducto 
        ''' </summary>
        Public Overloads Sub Insert(ByVal entity As Objects.TipoProductoObject)
            Instance().Insert(entity)
        End Sub

        ''' <summary>
        ''' Save TipoProducto 
        ''' </summary>
        Public Overloads Sub Save(ByVal Id_TipoProducto As System.Int32, ByVal TipoProducto As System.String)
            Dim entity As Objects.TipoProductoObject = Instance().GetOne(Id_TipoProducto)
            If entity Is Nothing Then
                Throw New ApplicationException(String.Format("Entity not found. IUniqueIdentifiable values: {0} = {1}", "Id_TipoProducto", Id_TipoProducto))
            End If

            entity.TipoProducto = TipoProducto
            Instance().Save(entity)
        End Sub

        ''' <summary>
        ''' Insert TipoProducto
        ''' </summary>
        Public Overloads Sub Insert(ByVal TipoProducto As System.String)
            Dim entity As Objects.TipoProductoObject = New Objects.TipoProductoObject

            entity.TipoProducto = TipoProducto
            Instance().Insert(entity)
        End Sub

        

        'Database Queries 
        


    End Class
End Namespace


Namespace Loaders

    ''' <summary>
    ''' 
    ''' </summary>
    Partial Public Class TipoProductoLoader(Of T As {TipoProductoObject, New})
        Inherits BaseLoader(Of T, TipoProductoObject, ObjectList(Of T))
        Implements IGenericGateway



#Region "Singleton"

        Private Shared _instance As TipoProductoLoader(Of T)

        Private Sub New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Shared Function Instance() As TipoProductoLoader(Of T)
            If _instance Is Nothing Then
                If HttpContext.Current Is Nothing Then
                    _instance = New TipoProductoLoader(Of T)
                Else
                    Dim inst As TipoProductoLoader(Of T) = TryCast(HttpContext.Current.Items("abacusRules.TipoProductoLoaderSingleton"), TipoProductoLoader(Of T))
                    If inst Is Nothing Then
                        inst = New TipoProductoLoader(Of T)
                        HttpContext.Current.Items.Add("abacusRules.TipoProductoLoaderSingleton", inst)
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
            
            Dim s() as String={"Id_TipoProducto"}
            Return s
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Function GetMappingType() as Type
            Return GetType(TipoProductoObject)
        End Function


        Protected Overrides ReadOnly Property TableName As String 
            Get
                Return "TipoProducto"
            End Get
        End Property

        

        


        Protected Overrides Sub HydrateFields(ByVal reader As DbDataReader, ByVal entity As TipoProductoObject)
            Dim _TipoProducto As String
If reader.IsDBNull(1) Then 
	 _TipoProducto = ""
Else
	 _TipoProducto = reader.GetString(1)
End If

            Dim TipoProducto As IMappeableTipoProductoObject  = CType(entity, IMappeableTipoProductoObject)
            TipoProducto.HydrateFields(reader.GetInt32(0), _
_TipoProducto)
        End Sub


        Protected Overrides Function StoredProceduresPrefix() As String 
            Return "coop_"
        End Function

        


        ''' <summary>
        ''' Get a TipoProducto by execute a SQL Query Text
        ''' </summary>
        Public Function GetOneBySQLQuery(sqlQueryText As String) As t
            Return MyBase.GetObjectBySQLText(sqlQueryText)
        End Function

        ''' <summary>
        ''' Get a TipoProductoList by execute a SQL Query Text
        ''' </summary>
        Public Function GetBySQLQuery(sqlQueryText As String) As ObjectList(Of T)
            Return MyBase.GetObjectListBySQLText(sqlQueryText)
        End Function

        
        ''' <summary>
        ''' GetOne By Params
        ''' </summary>
        Public Overloads Function GetOne(Id_TipoProducto As System.Int32) As t
            Return MyBase.GetObjectByAnyStoredProcedure(StoredProceduresPrefix() + "TipoProducto_GetOne", Id_TipoProducto)
        End Function
        


        ' GetOne By Objects and Params
            

        


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




