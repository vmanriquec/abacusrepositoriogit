
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 15/08/2013 - 05:51 p.m.
' This is a partial class file. The other one is cargopersonalMapper.cs
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
    

    Public Partial Class cargopersonalMapper
        Inherits BaseGateway(Of cargopersonalObject, cargopersonalObjectList)
        Implements IGenericGateway

#Region "Singleton"

        Private Shared _instance As cargopersonalMapper

        Private Sub New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Shared Function Instance() As cargopersonalMapper
            If _instance Is Nothing Then
                If HttpContext.Current Is Nothing Then
                    _instance = New cargopersonalMapper()
                Else
                    Dim inst As cargopersonalMapper = TryCast(HttpContext.Current.Items("abacusRules.cargopersonalMapperSingleton"), cargopersonalMapper)
                    If inst Is Nothing Then
                        inst = New cargopersonalMapper()
                        HttpContext.Current.Items.Add("abacusRules.cargopersonalMapperSingleton", inst)
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
            
            Dim  s() as String={"idcargopersonal"}
            return s
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Function GetMappingType() as Type
            return GetType(cargopersonalObject)
        End Function


        ''' <summary>
        ''' Return the mapped table name
        ''' </summary>
        Protected Overrides ReadOnly Property TableName() As String 
            Get
                Return "cargopersonal"
            End Get
        End Property

        ''' <summary>
        ''' Return the cargopersonalGateway type FullName
        ''' </summary>
        Protected Overrides ReadOnly Property RuleName() As String
            Get
                Return GetType(cargopersonalMapper).FullName
            End Get
        End Property


        

        

        ''' <summary>
        ''' Assign properties values based on DataReader
        ''' </summary>
        Protected Overrides Sub HydrateFields(ByVal reader As DbDataReader, ByVal entity As cargopersonalObject)
            Dim _nombre As String
If reader.IsDBNull(1) Then 
	 _nombre = ""
Else
	 _nombre = reader.GetString(1)
End If

            Dim cargopersonal As IMappeablecargopersonalObject  = CType(entity, IMappeablecargopersonalObject)
            cargopersonal.HydrateFields(reader.GetInt32(0), _
_nombre)
        End Sub

        ''' <summary>
        ''' Get field values to call insertion stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForInsert(ByVal entity As cargopersonalObject) As Object()
            Dim cargopersonal As IMappeablecargopersonalObject = CType(entity, IMappeablecargopersonalObject)
            Return cargopersonal.GetFieldsForInsert()
        End Function

        ''' <summary>
        ''' Get field values to call update stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForUpdate(ByVal entity As cargopersonalObject) As Object()
            Dim cargopersonal As IMappeablecargopersonalObject = CType(entity, IMappeablecargopersonalObject)
            Return cargopersonal.GetFieldsForUpdate()
        End Function

        ''' <summary>
        ''' Get field values to call deletion stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForDelete(ByVal entity As cargopersonalObject) As Object()
            Dim cargopersonal As IMappeablecargopersonalObject = CType(entity, IMappeablecargopersonalObject)
            Return cargopersonal.GetFieldsForDelete()
        End Function

        ''' <summary>
        ''' Raised after insert and update. Update properties from Output parameters
        ''' </summary>
        Protected Overrides Sub UpdateObjectFromOutputParams(ByVal entity As cargopersonalObject, ByVal parameters As Object())
            ' Update properties from Output parameters
            CType(entity, IMappeablecargopersonalObject).UpdateObjectFromOutputParams(parameters)
        End Sub

        ''' <summary>
        ''' StoredProceduresPrefix, for example: coop_
        ''' </summary>
        Protected Overrides Function StoredProceduresPrefix() As String 
            Return "coop_"
        End Function


          



        ''' <summary>
        ''' Get a cargopersonal by execute a SQL Query Text
        ''' </summary>
        Public Function GetOneBySQLQuery(sqlQueryText As String) As cargopersonalObject
            Return MyBase.GetObjectBySQLText(sqlQueryText)
        End Function

        ''' <summary>
        ''' Get a cargopersonalList by execute a SQL Query Text
        ''' </summary>
        Public Function GetBySQLQuery(sqlQueryText As String) As cargopersonalObjectList
            Return MyBase.GetObjectListBySQLText(sqlQueryText)
        End Function

        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetOne(idcargopersonal As System.Int32) As cargopersonalObject
            Return MyBase.GetOne(New cargopersonalObject(idcargopersonal))
        End Function

        

        ' GetOne By Objects and Params
            

        


        

        





        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub Delete(idcargopersonal As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "cargopersonal_Delete", idcargopersonal)
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub Delete(ByVal transaction As DbTransaction ,idcargopersonal As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "cargopersonal_Delete", idcargopersonal)
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
    Public Class cargopersonalMapperWrapper

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
        Public Function Instance() As abacusRules.Mappers.cargopersonalMapper
            Return abacusRules.Mappers.cargopersonalMapper.Instance()
        End Function

        
        ''' <summary>
        ''' Get a cargopersonal Entity by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetOne(ByVal idcargopersonal As System.Int32) As Objects.cargopersonalObject         
            Return Instance().GetOne( idcargopersonal)
        End Function
        

        ' GetBy Objects and Params
            

        

        ''' <summary>
        ''' GetAll cargopersonal 
        ''' </summary>
        Public Function GetAll() As Objects.cargopersonalObjectList
            Return Instance().GetAll()
        End Function

        
        


            

        

        ''' <summary>
        ''' Delete cargopersonal 
        ''' </summary>
        Public Overloads Sub Delete(ByVal idcargopersonal As System.Int32)
            Instance().Delete(idcargopersonal)
        End Sub

        ''' <summary>
        ''' Delete cargopersonal 
        ''' </summary>
        Public Overloads Sub Delete(ByVal entity As Objects.cargopersonalObject)
            Instance().Delete(entity)
        End Sub

        ''' <summary>
        ''' Save cargopersonal  
        ''' </summary>
        Public Overloads Sub Save(ByVal entity As Objects.cargopersonalObject)
            Instance().Save(entity)
        End Sub

        ''' <summary>
        ''' Insert cargopersonal 
        ''' </summary>
        Public Overloads Sub Insert(ByVal entity As Objects.cargopersonalObject)
            Instance().Insert(entity)
        End Sub

        ''' <summary>
        ''' Save cargopersonal 
        ''' </summary>
        Public Overloads Sub Save(ByVal idcargopersonal As System.Int32, ByVal nombre As System.String)
            Dim entity As Objects.cargopersonalObject = Instance().GetOne(idcargopersonal)
            If entity Is Nothing Then
                Throw New ApplicationException(String.Format("Entity not found. IUniqueIdentifiable values: {0} = {1}", "idcargopersonal", idcargopersonal))
            End If

            entity.nombre = nombre
            Instance().Save(entity)
        End Sub

        ''' <summary>
        ''' Insert cargopersonal
        ''' </summary>
        Public Overloads Sub Insert(ByVal nombre As System.String)
            Dim entity As Objects.cargopersonalObject = New Objects.cargopersonalObject

            entity.nombre = nombre
            Instance().Insert(entity)
        End Sub

        

        'Database Queries 
        


    End Class
End Namespace


Namespace Loaders

    ''' <summary>
    ''' 
    ''' </summary>
    Partial Public Class cargopersonalLoader(Of T As {cargopersonalObject, New})
        Inherits BaseLoader(Of T, cargopersonalObject, ObjectList(Of T))
        Implements IGenericGateway



#Region "Singleton"

        Private Shared _instance As cargopersonalLoader(Of T)

        Private Sub New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Shared Function Instance() As cargopersonalLoader(Of T)
            If _instance Is Nothing Then
                If HttpContext.Current Is Nothing Then
                    _instance = New cargopersonalLoader(Of T)
                Else
                    Dim inst As cargopersonalLoader(Of T) = TryCast(HttpContext.Current.Items("abacusRules.cargopersonalLoaderSingleton"), cargopersonalLoader(Of T))
                    If inst Is Nothing Then
                        inst = New cargopersonalLoader(Of T)
                        HttpContext.Current.Items.Add("abacusRules.cargopersonalLoaderSingleton", inst)
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
            
            Dim s() as String={"idcargopersonal"}
            Return s
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Function GetMappingType() as Type
            Return GetType(cargopersonalObject)
        End Function


        Protected Overrides ReadOnly Property TableName As String 
            Get
                Return "cargopersonal"
            End Get
        End Property

        

        


        Protected Overrides Sub HydrateFields(ByVal reader As DbDataReader, ByVal entity As cargopersonalObject)
            Dim _nombre As String
If reader.IsDBNull(1) Then 
	 _nombre = ""
Else
	 _nombre = reader.GetString(1)
End If

            Dim cargopersonal As IMappeablecargopersonalObject  = CType(entity, IMappeablecargopersonalObject)
            cargopersonal.HydrateFields(reader.GetInt32(0), _
_nombre)
        End Sub


        Protected Overrides Function StoredProceduresPrefix() As String 
            Return "coop_"
        End Function

        


        ''' <summary>
        ''' Get a cargopersonal by execute a SQL Query Text
        ''' </summary>
        Public Function GetOneBySQLQuery(sqlQueryText As String) As t
            Return MyBase.GetObjectBySQLText(sqlQueryText)
        End Function

        ''' <summary>
        ''' Get a cargopersonalList by execute a SQL Query Text
        ''' </summary>
        Public Function GetBySQLQuery(sqlQueryText As String) As ObjectList(Of T)
            Return MyBase.GetObjectListBySQLText(sqlQueryText)
        End Function

        
        ''' <summary>
        ''' GetOne By Params
        ''' </summary>
        Public Overloads Function GetOne(idcargopersonal As System.Int32) As t
            Return MyBase.GetObjectByAnyStoredProcedure(StoredProceduresPrefix() + "cargopersonal_GetOne", idcargopersonal)
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



