
        
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 15/08/2013 - 05:51 p.m.
' This is a partial class file. The other one is AlmacenesMapper.cs
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
    

    Public Partial Class AlmacenesMapper
        Inherits BaseGateway(Of AlmacenesObject, AlmacenesObjectList)
        Implements IGenericGateway

#Region "Singleton"

        Private Shared _instance As AlmacenesMapper

        Private Sub New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Shared Function Instance() As AlmacenesMapper
            If _instance Is Nothing Then
                If HttpContext.Current Is Nothing Then
                    _instance = New AlmacenesMapper()
                Else
                    Dim inst As AlmacenesMapper = TryCast(HttpContext.Current.Items("abacusRules.AlmacenesMapperSingleton"), AlmacenesMapper)
                    If inst Is Nothing Then
                        inst = New AlmacenesMapper()
                        HttpContext.Current.Items.Add("abacusRules.AlmacenesMapperSingleton", inst)
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
            
            Dim  s() as String={"IdAlmacen"}
            return s
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Function GetMappingType() as Type
            return GetType(AlmacenesObject)
        End Function


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
                Return GetType(AlmacenesMapper).FullName
            End Get
        End Property


        

        

        ''' <summary>
        ''' Assign properties values based on DataReader
        ''' </summary>
        Protected Overrides Sub HydrateFields(ByVal reader As DbDataReader, ByVal entity As AlmacenesObject)
            Dim _Almacen As String
If reader.IsDBNull(1) Then 
	 _Almacen = ""
Else
	 _Almacen = reader.GetString(1)
End If

            Dim Almacenes As IMappeableAlmacenesObject  = CType(entity, IMappeableAlmacenesObject)
            Almacenes.HydrateFields(reader.GetInt32(0), _
_Almacen)
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
        Protected Overrides Sub UpdateObjectFromOutputParams(ByVal entity As AlmacenesObject, ByVal parameters As Object())
            ' Update properties from Output parameters
            CType(entity, IMappeableAlmacenesObject).UpdateObjectFromOutputParams(parameters)
        End Sub

        ''' <summary>
        ''' StoredProceduresPrefix, for example: coop_
        ''' </summary>
        Protected Overrides Function StoredProceduresPrefix() As String 
            Return "coop_"
        End Function


          



        ''' <summary>
        ''' Get a Almacenes by execute a SQL Query Text
        ''' </summary>
        Public Function GetOneBySQLQuery(sqlQueryText As String) As AlmacenesObject
            Return MyBase.GetObjectBySQLText(sqlQueryText)
        End Function

        ''' <summary>
        ''' Get a AlmacenesList by execute a SQL Query Text
        ''' </summary>
        Public Function GetBySQLQuery(sqlQueryText As String) As AlmacenesObjectList
            Return MyBase.GetObjectListBySQLText(sqlQueryText)
        End Function

        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetOne(IdAlmacen As System.Int32) As AlmacenesObject
            Return MyBase.GetOne(New AlmacenesObject(IdAlmacen))
        End Function

        

        ' GetOne By Objects and Params
            

        


        

        





        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub Delete(IdAlmacen As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Almacenes_Delete", IdAlmacen)
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub Delete(ByVal transaction As DbTransaction ,IdAlmacen As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Almacenes_Delete", IdAlmacen)
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
    Public Class AlmacenesMapperWrapper

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
        Public Function Instance() As abacusRules.Mappers.AlmacenesMapper
            Return abacusRules.Mappers.AlmacenesMapper.Instance()
        End Function

        
        ''' <summary>
        ''' Get a Almacenes Entity by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetOne(ByVal IdAlmacen As System.Int32) As Objects.AlmacenesObject         
            Return Instance().GetOne( IdAlmacen)
        End Function
        

        ' GetBy Objects and Params
            

        

        ''' <summary>
        ''' GetAll Almacenes 
        ''' </summary>
        Public Function GetAll() As Objects.AlmacenesObjectList
            Return Instance().GetAll()
        End Function

        
        


            

        

        ''' <summary>
        ''' Delete Almacenes 
        ''' </summary>
        Public Overloads Sub Delete(ByVal IdAlmacen As System.Int32)
            Instance().Delete(IdAlmacen)
        End Sub

        ''' <summary>
        ''' Delete Almacenes 
        ''' </summary>
        Public Overloads Sub Delete(ByVal entity As Objects.AlmacenesObject)
            Instance().Delete(entity)
        End Sub

        ''' <summary>
        ''' Save Almacenes  
        ''' </summary>
        Public Overloads Sub Save(ByVal entity As Objects.AlmacenesObject)
            Instance().Save(entity)
        End Sub

        ''' <summary>
        ''' Insert Almacenes 
        ''' </summary>
        Public Overloads Sub Insert(ByVal entity As Objects.AlmacenesObject)
            Instance().Insert(entity)
        End Sub

        ''' <summary>
        ''' Save Almacenes 
        ''' </summary>
        Public Overloads Sub Save(ByVal IdAlmacen As System.Int32, ByVal Almacen As System.String)
            Dim entity As Objects.AlmacenesObject = Instance().GetOne(IdAlmacen)
            If entity Is Nothing Then
                Throw New ApplicationException(String.Format("Entity not found. IUniqueIdentifiable values: {0} = {1}", "IdAlmacen", IdAlmacen))
            End If

            entity.Almacen = Almacen
            Instance().Save(entity)
        End Sub

        ''' <summary>
        ''' Insert Almacenes
        ''' </summary>
        Public Overloads Sub Insert(ByVal Almacen As System.String)
            Dim entity As Objects.AlmacenesObject = New Objects.AlmacenesObject

            entity.Almacen = Almacen
            Instance().Insert(entity)
        End Sub

        

        'Database Queries 
        


    End Class
End Namespace


Namespace Loaders

    ''' <summary>
    ''' 
    ''' </summary>
    Partial Public Class AlmacenesLoader(Of T As {AlmacenesObject, New})
        Inherits BaseLoader(Of T, AlmacenesObject, ObjectList(Of T))
        Implements IGenericGateway



#Region "Singleton"

        Private Shared _instance As AlmacenesLoader(Of T)

        Private Sub New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Shared Function Instance() As AlmacenesLoader(Of T)
            If _instance Is Nothing Then
                If HttpContext.Current Is Nothing Then
                    _instance = New AlmacenesLoader(Of T)
                Else
                    Dim inst As AlmacenesLoader(Of T) = TryCast(HttpContext.Current.Items("abacusRules.AlmacenesLoaderSingleton"), AlmacenesLoader(Of T))
                    If inst Is Nothing Then
                        inst = New AlmacenesLoader(Of T)
                        HttpContext.Current.Items.Add("abacusRules.AlmacenesLoaderSingleton", inst)
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
            
            Dim s() as String={"IdAlmacen"}
            Return s
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Function GetMappingType() as Type
            Return GetType(AlmacenesObject)
        End Function


        Protected Overrides ReadOnly Property TableName As String 
            Get
                Return "Almacenes"
            End Get
        End Property

        

        


        Protected Overrides Sub HydrateFields(ByVal reader As DbDataReader, ByVal entity As AlmacenesObject)
            Dim _Almacen As String
If reader.IsDBNull(1) Then 
	 _Almacen = ""
Else
	 _Almacen = reader.GetString(1)
End If

            Dim Almacenes As IMappeableAlmacenesObject  = CType(entity, IMappeableAlmacenesObject)
            Almacenes.HydrateFields(reader.GetInt32(0), _
_Almacen)
        End Sub


        Protected Overrides Function StoredProceduresPrefix() As String 
            Return "coop_"
        End Function

        


        ''' <summary>
        ''' Get a Almacenes by execute a SQL Query Text
        ''' </summary>
        Public Function GetOneBySQLQuery(sqlQueryText As String) As t
            Return MyBase.GetObjectBySQLText(sqlQueryText)
        End Function

        ''' <summary>
        ''' Get a AlmacenesList by execute a SQL Query Text
        ''' </summary>
        Public Function GetBySQLQuery(sqlQueryText As String) As ObjectList(Of T)
            Return MyBase.GetObjectListBySQLText(sqlQueryText)
        End Function

        
        ''' <summary>
        ''' GetOne By Params
        ''' </summary>
        Public Overloads Function GetOne(IdAlmacen As System.Int32) As t
            Return MyBase.GetObjectByAnyStoredProcedure(StoredProceduresPrefix() + "Almacenes_GetOne", IdAlmacen)
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




