
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 20/08/2013 - 01:49 p.m.
' This is a partial class file. The other one is DistritosMapper.cs
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
    

    Public Partial Class DistritosMapper
        Inherits BaseGateway(Of DistritosObject, DistritosObjectList)
        Implements IGenericGateway

#Region "Singleton"

        Private Shared _instance As DistritosMapper

        Private Sub New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Shared Function Instance() As DistritosMapper
            If _instance Is Nothing Then
                If HttpContext.Current Is Nothing Then
                    _instance = New DistritosMapper()
                Else
                    Dim inst As DistritosMapper = TryCast(HttpContext.Current.Items("abacusRules.DistritosMapperSingleton"), DistritosMapper)
                    If inst Is Nothing Then
                        inst = New DistritosMapper()
                        HttpContext.Current.Items.Add("abacusRules.DistritosMapperSingleton", inst)
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
            
            Dim  s() as String={"IdDistrito"}
            return s
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Function GetMappingType() as Type
            return GetType(DistritosObject)
        End Function


        ''' <summary>
        ''' Return the mapped table name
        ''' </summary>
        Protected Overrides ReadOnly Property TableName() As String 
            Get
                Return "Distritos"
            End Get
        End Property

        ''' <summary>
        ''' Return the DistritosGateway type FullName
        ''' </summary>
        Protected Overrides ReadOnly Property RuleName() As String
            Get
                Return GetType(DistritosMapper).FullName
            End Get
        End Property


        

        

        ''' <summary>
        ''' Assign properties values based on DataReader
        ''' </summary>
        Protected Overrides Sub HydrateFields(ByVal reader As DbDataReader, ByVal entity As DistritosObject)
            Dim _IdProvincia As System.Nullable(Of System.Int32) 
If reader.IsDBNull(1) Then 
	 _IdProvincia = New System.Nullable(Of System.Int32)
Else
	 _IdProvincia = reader.GetInt32(1)
End If
Dim _Distrito As String
If reader.IsDBNull(2) Then 
	 _Distrito = ""
Else
	 _Distrito = reader.GetString(2)
End If

            Dim Distritos As IMappeableDistritosObject  = CType(entity, IMappeableDistritosObject)
            Distritos.HydrateFields(reader.GetInt32(0), _
_IdProvincia, _
_Distrito)
        End Sub

        ''' <summary>
        ''' Get field values to call insertion stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForInsert(ByVal entity As DistritosObject) As Object()
            Dim Distritos As IMappeableDistritosObject = CType(entity, IMappeableDistritosObject)
            Return Distritos.GetFieldsForInsert()
        End Function

        ''' <summary>
        ''' Get field values to call update stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForUpdate(ByVal entity As DistritosObject) As Object()
            Dim Distritos As IMappeableDistritosObject = CType(entity, IMappeableDistritosObject)
            Return Distritos.GetFieldsForUpdate()
        End Function

        ''' <summary>
        ''' Get field values to call deletion stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForDelete(ByVal entity As DistritosObject) As Object()
            Dim Distritos As IMappeableDistritosObject = CType(entity, IMappeableDistritosObject)
            Return Distritos.GetFieldsForDelete()
        End Function

        ''' <summary>
        ''' Raised after insert and update. Update properties from Output parameters
        ''' </summary>
        Protected Overrides Sub UpdateObjectFromOutputParams(ByVal entity As DistritosObject, ByVal parameters As Object())
            ' Update properties from Output parameters
            CType(entity, IMappeableDistritosObject).UpdateObjectFromOutputParams(parameters)
        End Sub

        ''' <summary>
        ''' StoredProceduresPrefix, for example: coop_
        ''' </summary>
        Protected Overrides Function StoredProceduresPrefix() As String 
            Return "coop_"
        End Function


          



        ''' <summary>
        ''' Get a Distritos by execute a SQL Query Text
        ''' </summary>
        Public Function GetOneBySQLQuery(sqlQueryText As String) As DistritosObject
            Return MyBase.GetObjectBySQLText(sqlQueryText)
        End Function

        ''' <summary>
        ''' Get a DistritosList by execute a SQL Query Text
        ''' </summary>
        Public Function GetBySQLQuery(sqlQueryText As String) As DistritosObjectList
            Return MyBase.GetObjectListBySQLText(sqlQueryText)
        End Function

        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetOne(IdDistrito As System.Int32) As DistritosObject
            Return MyBase.GetOne(New DistritosObject(IdDistrito))
        End Function

        

        ' GetOne By Objects and Params
            

        


        

        





        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub Delete(IdDistrito As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Distritos_Delete", IdDistrito)
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub Delete(ByVal transaction As DbTransaction ,IdDistrito As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Distritos_Delete", IdDistrito)
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
    Public Class DistritosMapperWrapper

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
        Public Function Instance() As abacusRules.Mappers.DistritosMapper
            Return abacusRules.Mappers.DistritosMapper.Instance()
        End Function

        
        ''' <summary>
        ''' Get a Distritos Entity by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetOne(ByVal IdDistrito As System.Int32) As Objects.DistritosObject         
            Return Instance().GetOne( IdDistrito)
        End Function
        

        ' GetBy Objects and Params
            

        

        ''' <summary>
        ''' GetAll Distritos 
        ''' </summary>
        Public Function GetAll() As Objects.DistritosObjectList
            Return Instance().GetAll()
        End Function

        
        


            

        

        ''' <summary>
        ''' Delete Distritos 
        ''' </summary>
        Public Overloads Sub Delete(ByVal IdDistrito As System.Int32)
            Instance().Delete(IdDistrito)
        End Sub

        ''' <summary>
        ''' Delete Distritos 
        ''' </summary>
        Public Overloads Sub Delete(ByVal entity As Objects.DistritosObject)
            Instance().Delete(entity)
        End Sub

        ''' <summary>
        ''' Save Distritos  
        ''' </summary>
        Public Overloads Sub Save(ByVal entity As Objects.DistritosObject)
            Instance().Save(entity)
        End Sub

        ''' <summary>
        ''' Insert Distritos 
        ''' </summary>
        Public Overloads Sub Insert(ByVal entity As Objects.DistritosObject)
            Instance().Insert(entity)
        End Sub

        ''' <summary>
        ''' Save Distritos 
        ''' </summary>
        Public Overloads Sub Save(ByVal IdDistrito As System.Int32, ByVal IdProvincia As System.Int32, ByVal Distrito As System.String)
            Dim entity As Objects.DistritosObject = Instance().GetOne(IdDistrito)
            If entity Is Nothing Then
                Throw New ApplicationException(String.Format("Entity not found. IUniqueIdentifiable values: {0} = {1}", "IdDistrito", IdDistrito))
            End If

            entity.IdProvincia = IdProvincia
            entity.Distrito = Distrito
            Instance().Save(entity)
        End Sub

        ''' <summary>
        ''' Insert Distritos
        ''' </summary>
        Public Overloads Sub Insert(ByVal IdProvincia As System.Int32, ByVal Distrito As System.String)
            Dim entity As Objects.DistritosObject = New Objects.DistritosObject

            entity.IdProvincia = IdProvincia
            entity.Distrito = Distrito
            Instance().Insert(entity)
        End Sub

        

        'Database Queries 
        


    End Class
End Namespace


Namespace Loaders

    ''' <summary>
    ''' 
    ''' </summary>
    Partial Public Class DistritosLoader(Of T As {DistritosObject, New})
        Inherits BaseLoader(Of T, DistritosObject, ObjectList(Of T))
        Implements IGenericGateway



#Region "Singleton"

        Private Shared _instance As DistritosLoader(Of T)

        Private Sub New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Shared Function Instance() As DistritosLoader(Of T)
            If _instance Is Nothing Then
                If HttpContext.Current Is Nothing Then
                    _instance = New DistritosLoader(Of T)
                Else
                    Dim inst As DistritosLoader(Of T) = TryCast(HttpContext.Current.Items("abacusRules.DistritosLoaderSingleton"), DistritosLoader(Of T))
                    If inst Is Nothing Then
                        inst = New DistritosLoader(Of T)
                        HttpContext.Current.Items.Add("abacusRules.DistritosLoaderSingleton", inst)
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
            
            Dim s() as String={"IdDistrito"}
            Return s
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Function GetMappingType() as Type
            Return GetType(DistritosObject)
        End Function


        Protected Overrides ReadOnly Property TableName As String 
            Get
                Return "Distritos"
            End Get
        End Property

        

        


        Protected Overrides Sub HydrateFields(ByVal reader As DbDataReader, ByVal entity As DistritosObject)
            Dim _IdProvincia As System.Nullable(Of System.Int32) 
If reader.IsDBNull(1) Then 
	 _IdProvincia = New System.Nullable(Of System.Int32)
Else
	 _IdProvincia = reader.GetInt32(1)
End If
Dim _Distrito As String
If reader.IsDBNull(2) Then 
	 _Distrito = ""
Else
	 _Distrito = reader.GetString(2)
End If

            Dim Distritos As IMappeableDistritosObject  = CType(entity, IMappeableDistritosObject)
            Distritos.HydrateFields(reader.GetInt32(0), _
_IdProvincia, _
_Distrito)
        End Sub


        Protected Overrides Function StoredProceduresPrefix() As String 
            Return "coop_"
        End Function

        


        ''' <summary>
        ''' Get a Distritos by execute a SQL Query Text
        ''' </summary>
        Public Function GetOneBySQLQuery(sqlQueryText As String) As t
            Return MyBase.GetObjectBySQLText(sqlQueryText)
        End Function

        ''' <summary>
        ''' Get a DistritosList by execute a SQL Query Text
        ''' </summary>
        Public Function GetBySQLQuery(sqlQueryText As String) As ObjectList(Of T)
            Return MyBase.GetObjectListBySQLText(sqlQueryText)
        End Function

        
        ''' <summary>
        ''' GetOne By Params
        ''' </summary>
        Public Overloads Function GetOne(IdDistrito As System.Int32) As t
            Return MyBase.GetObjectByAnyStoredProcedure(StoredProceduresPrefix() + "Distritos_GetOne", IdDistrito)
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




