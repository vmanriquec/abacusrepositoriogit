
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 15/08/2013 - 05:51 p.m.
' This is a partial class file. The other one is ClieContactosMapper.cs
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
    

    Public Partial Class ClieContactosMapper
        Inherits BaseGateway(Of ClieContactosObject, ClieContactosObjectList)
        Implements IGenericGateway

#Region "Singleton"

        Private Shared _instance As ClieContactosMapper

        Private Sub New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Shared Function Instance() As ClieContactosMapper
            If _instance Is Nothing Then
                If HttpContext.Current Is Nothing Then
                    _instance = New ClieContactosMapper()
                Else
                    Dim inst As ClieContactosMapper = TryCast(HttpContext.Current.Items("abacusRules.ClieContactosMapperSingleton"), ClieContactosMapper)
                    If inst Is Nothing Then
                        inst = New ClieContactosMapper()
                        HttpContext.Current.Items.Add("abacusRules.ClieContactosMapperSingleton", inst)
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
            
            Dim  s() as String={"IdClicontactos"}
            return s
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Function GetMappingType() as Type
            return GetType(ClieContactosObject)
        End Function


        ''' <summary>
        ''' Return the mapped table name
        ''' </summary>
        Protected Overrides ReadOnly Property TableName() As String 
            Get
                Return "ClieContactos"
            End Get
        End Property

        ''' <summary>
        ''' Return the ClieContactosGateway type FullName
        ''' </summary>
        Protected Overrides ReadOnly Property RuleName() As String
            Get
                Return GetType(ClieContactosMapper).FullName
            End Get
        End Property


        

        

        ''' <summary>
        ''' Assign properties values based on DataReader
        ''' </summary>
        Protected Overrides Sub HydrateFields(ByVal reader As DbDataReader, ByVal entity As ClieContactosObject)
            Dim _Nombre As String
If reader.IsDBNull(1) Then 
	 _Nombre = ""
Else
	 _Nombre = reader.GetString(1)
End If
Dim _Anexo As String
If reader.IsDBNull(2) Then 
	 _Anexo = ""
Else
	 _Anexo = reader.GetString(2)
End If
Dim _TipMovil1 As String
If reader.IsDBNull(3) Then 
	 _TipMovil1 = ""
Else
	 _TipMovil1 = reader.GetString(3)
End If
Dim _Movil1 As String
If reader.IsDBNull(4) Then 
	 _Movil1 = ""
Else
	 _Movil1 = reader.GetString(4)
End If
Dim _Email1 As String
If reader.IsDBNull(5) Then 
	 _Email1 = ""
Else
	 _Email1 = reader.GetString(5)
End If
Dim _TipMovil2 As String
If reader.IsDBNull(6) Then 
	 _TipMovil2 = ""
Else
	 _TipMovil2 = reader.GetString(6)
End If
Dim _Movil2 As String
If reader.IsDBNull(7) Then 
	 _Movil2 = ""
Else
	 _Movil2 = reader.GetString(7)
End If
Dim _Email2 As String
If reader.IsDBNull(8) Then 
	 _Email2 = ""
Else
	 _Email2 = reader.GetString(8)
End If
Dim _IdCliente As System.Nullable(Of System.Int32) 
If reader.IsDBNull(9) Then 
	 _IdCliente = New System.Nullable(Of System.Int32)
Else
	 _IdCliente = reader.GetInt32(9)
End If
Dim _Trato As String
If reader.IsDBNull(10) Then 
	 _Trato = ""
Else
	 _Trato = reader.GetString(10)
End If

            Dim ClieContactos As IMappeableClieContactosObject  = CType(entity, IMappeableClieContactosObject)
            ClieContactos.HydrateFields(reader.GetInt32(0), _
_Nombre, _
_Anexo, _
_TipMovil1, _
_Movil1, _
_Email1, _
_TipMovil2, _
_Movil2, _
_Email2, _
_IdCliente, _
_Trato)
        End Sub

        ''' <summary>
        ''' Get field values to call insertion stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForInsert(ByVal entity As ClieContactosObject) As Object()
            Dim ClieContactos As IMappeableClieContactosObject = CType(entity, IMappeableClieContactosObject)
            Return ClieContactos.GetFieldsForInsert()
        End Function

        ''' <summary>
        ''' Get field values to call update stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForUpdate(ByVal entity As ClieContactosObject) As Object()
            Dim ClieContactos As IMappeableClieContactosObject = CType(entity, IMappeableClieContactosObject)
            Return ClieContactos.GetFieldsForUpdate()
        End Function

        ''' <summary>
        ''' Get field values to call deletion stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForDelete(ByVal entity As ClieContactosObject) As Object()
            Dim ClieContactos As IMappeableClieContactosObject = CType(entity, IMappeableClieContactosObject)
            Return ClieContactos.GetFieldsForDelete()
        End Function

        ''' <summary>
        ''' Raised after insert and update. Update properties from Output parameters
        ''' </summary>
        Protected Overrides Sub UpdateObjectFromOutputParams(ByVal entity As ClieContactosObject, ByVal parameters As Object())
            ' Update properties from Output parameters
            CType(entity, IMappeableClieContactosObject).UpdateObjectFromOutputParams(parameters)
        End Sub

        ''' <summary>
        ''' StoredProceduresPrefix, for example: coop_
        ''' </summary>
        Protected Overrides Function StoredProceduresPrefix() As String 
            Return "coop_"
        End Function


          



        ''' <summary>
        ''' Get a ClieContactos by execute a SQL Query Text
        ''' </summary>
        Public Function GetOneBySQLQuery(sqlQueryText As String) As ClieContactosObject
            Return MyBase.GetObjectBySQLText(sqlQueryText)
        End Function

        ''' <summary>
        ''' Get a ClieContactosList by execute a SQL Query Text
        ''' </summary>
        Public Function GetBySQLQuery(sqlQueryText As String) As ClieContactosObjectList
            Return MyBase.GetObjectListBySQLText(sqlQueryText)
        End Function

        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetOne(IdClicontactos As System.Int32) As ClieContactosObject
            Return MyBase.GetOne(New ClieContactosObject(IdClicontactos))
        End Function

        

        ' GetOne By Objects and Params
            

        


        

        





        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub Delete(IdClicontactos As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ClieContactos_Delete", IdClicontactos)
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub Delete(ByVal transaction As DbTransaction ,IdClicontactos As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ClieContactos_Delete", IdClicontactos)
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
    Public Class ClieContactosMapperWrapper

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
        Public Function Instance() As abacusRules.Mappers.ClieContactosMapper
            Return abacusRules.Mappers.ClieContactosMapper.Instance()
        End Function

        
        ''' <summary>
        ''' Get a ClieContactos Entity by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetOne(ByVal IdClicontactos As System.Int32) As Objects.ClieContactosObject         
            Return Instance().GetOne( IdClicontactos)
        End Function
        

        ' GetBy Objects and Params
            

        

        ''' <summary>
        ''' GetAll ClieContactos 
        ''' </summary>
        Public Function GetAll() As Objects.ClieContactosObjectList
            Return Instance().GetAll()
        End Function

        
        


            

        

        ''' <summary>
        ''' Delete ClieContactos 
        ''' </summary>
        Public Overloads Sub Delete(ByVal IdClicontactos As System.Int32)
            Instance().Delete(IdClicontactos)
        End Sub

        ''' <summary>
        ''' Delete ClieContactos 
        ''' </summary>
        Public Overloads Sub Delete(ByVal entity As Objects.ClieContactosObject)
            Instance().Delete(entity)
        End Sub

        ''' <summary>
        ''' Save ClieContactos  
        ''' </summary>
        Public Overloads Sub Save(ByVal entity As Objects.ClieContactosObject)
            Instance().Save(entity)
        End Sub

        ''' <summary>
        ''' Insert ClieContactos 
        ''' </summary>
        Public Overloads Sub Insert(ByVal entity As Objects.ClieContactosObject)
            Instance().Insert(entity)
        End Sub

        ''' <summary>
        ''' Save ClieContactos 
        ''' </summary>
        Public Overloads Sub Save(ByVal IdClicontactos As System.Int32, ByVal Nombre As System.String, ByVal Anexo As System.String, ByVal TipMovil1 As System.String, ByVal Movil1 As System.String, ByVal Email1 As System.String, ByVal TipMovil2 As System.String, ByVal Movil2 As System.String, ByVal Email2 As System.String, ByVal IdCliente As System.Int32, ByVal Trato As System.String)
            Dim entity As Objects.ClieContactosObject = Instance().GetOne(IdClicontactos)
            If entity Is Nothing Then
                Throw New ApplicationException(String.Format("Entity not found. IUniqueIdentifiable values: {0} = {1}", "IdClicontactos", IdClicontactos))
            End If

            entity.Nombre = Nombre
            entity.Anexo = Anexo
            entity.TipMovil1 = TipMovil1
            entity.Movil1 = Movil1
            entity.Email1 = Email1
            entity.TipMovil2 = TipMovil2
            entity.Movil2 = Movil2
            entity.Email2 = Email2
            entity.IdCliente = IdCliente
            entity.Trato = Trato
            Instance().Save(entity)
        End Sub

        ''' <summary>
        ''' Insert ClieContactos
        ''' </summary>
        Public Overloads Sub Insert(ByVal Nombre As System.String, ByVal Anexo As System.String, ByVal TipMovil1 As System.String, ByVal Movil1 As System.String, ByVal Email1 As System.String, ByVal TipMovil2 As System.String, ByVal Movil2 As System.String, ByVal Email2 As System.String, ByVal IdCliente As System.Int32, ByVal Trato As System.String)
            Dim entity As Objects.ClieContactosObject = New Objects.ClieContactosObject

            entity.Nombre = Nombre
            entity.Anexo = Anexo
            entity.TipMovil1 = TipMovil1
            entity.Movil1 = Movil1
            entity.Email1 = Email1
            entity.TipMovil2 = TipMovil2
            entity.Movil2 = Movil2
            entity.Email2 = Email2
            entity.IdCliente = IdCliente
            entity.Trato = Trato
            Instance().Insert(entity)
        End Sub

        

        'Database Queries 
        


    End Class
End Namespace


Namespace Loaders

    ''' <summary>
    ''' 
    ''' </summary>
    Partial Public Class ClieContactosLoader(Of T As {ClieContactosObject, New})
        Inherits BaseLoader(Of T, ClieContactosObject, ObjectList(Of T))
        Implements IGenericGateway



#Region "Singleton"

        Private Shared _instance As ClieContactosLoader(Of T)

        Private Sub New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Shared Function Instance() As ClieContactosLoader(Of T)
            If _instance Is Nothing Then
                If HttpContext.Current Is Nothing Then
                    _instance = New ClieContactosLoader(Of T)
                Else
                    Dim inst As ClieContactosLoader(Of T) = TryCast(HttpContext.Current.Items("abacusRules.ClieContactosLoaderSingleton"), ClieContactosLoader(Of T))
                    If inst Is Nothing Then
                        inst = New ClieContactosLoader(Of T)
                        HttpContext.Current.Items.Add("abacusRules.ClieContactosLoaderSingleton", inst)
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
            
            Dim s() as String={"IdClicontactos"}
            Return s
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Function GetMappingType() as Type
            Return GetType(ClieContactosObject)
        End Function


        Protected Overrides ReadOnly Property TableName As String 
            Get
                Return "ClieContactos"
            End Get
        End Property

        

        


        Protected Overrides Sub HydrateFields(ByVal reader As DbDataReader, ByVal entity As ClieContactosObject)
            Dim _Nombre As String
If reader.IsDBNull(1) Then 
	 _Nombre = ""
Else
	 _Nombre = reader.GetString(1)
End If
Dim _Anexo As String
If reader.IsDBNull(2) Then 
	 _Anexo = ""
Else
	 _Anexo = reader.GetString(2)
End If
Dim _TipMovil1 As String
If reader.IsDBNull(3) Then 
	 _TipMovil1 = ""
Else
	 _TipMovil1 = reader.GetString(3)
End If
Dim _Movil1 As String
If reader.IsDBNull(4) Then 
	 _Movil1 = ""
Else
	 _Movil1 = reader.GetString(4)
End If
Dim _Email1 As String
If reader.IsDBNull(5) Then 
	 _Email1 = ""
Else
	 _Email1 = reader.GetString(5)
End If
Dim _TipMovil2 As String
If reader.IsDBNull(6) Then 
	 _TipMovil2 = ""
Else
	 _TipMovil2 = reader.GetString(6)
End If
Dim _Movil2 As String
If reader.IsDBNull(7) Then 
	 _Movil2 = ""
Else
	 _Movil2 = reader.GetString(7)
End If
Dim _Email2 As String
If reader.IsDBNull(8) Then 
	 _Email2 = ""
Else
	 _Email2 = reader.GetString(8)
End If
Dim _IdCliente As System.Nullable(Of System.Int32) 
If reader.IsDBNull(9) Then 
	 _IdCliente = New System.Nullable(Of System.Int32)
Else
	 _IdCliente = reader.GetInt32(9)
End If
Dim _Trato As String
If reader.IsDBNull(10) Then 
	 _Trato = ""
Else
	 _Trato = reader.GetString(10)
End If

            Dim ClieContactos As IMappeableClieContactosObject  = CType(entity, IMappeableClieContactosObject)
            ClieContactos.HydrateFields(reader.GetInt32(0), _
_Nombre, _
_Anexo, _
_TipMovil1, _
_Movil1, _
_Email1, _
_TipMovil2, _
_Movil2, _
_Email2, _
_IdCliente, _
_Trato)
        End Sub


        Protected Overrides Function StoredProceduresPrefix() As String 
            Return "coop_"
        End Function

        


        ''' <summary>
        ''' Get a ClieContactos by execute a SQL Query Text
        ''' </summary>
        Public Function GetOneBySQLQuery(sqlQueryText As String) As t
            Return MyBase.GetObjectBySQLText(sqlQueryText)
        End Function

        ''' <summary>
        ''' Get a ClieContactosList by execute a SQL Query Text
        ''' </summary>
        Public Function GetBySQLQuery(sqlQueryText As String) As ObjectList(Of T)
            Return MyBase.GetObjectListBySQLText(sqlQueryText)
        End Function

        
        ''' <summary>
        ''' GetOne By Params
        ''' </summary>
        Public Overloads Function GetOne(IdClicontactos As System.Int32) As t
            Return MyBase.GetObjectByAnyStoredProcedure(StoredProceduresPrefix() + "ClieContactos_GetOne", IdClicontactos)
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




