
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 15/08/2013 - 05:51 p.m.
' This is a partial class file. The other one is FormaPagoMapper.cs
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
    

    Public Partial Class FormaPagoMapper
        Inherits BaseGateway(Of FormaPagoObject, FormaPagoObjectList)
        Implements IGenericGateway

#Region "Singleton"

        Private Shared _instance As FormaPagoMapper

        Private Sub New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Shared Function Instance() As FormaPagoMapper
            If _instance Is Nothing Then
                If HttpContext.Current Is Nothing Then
                    _instance = New FormaPagoMapper()
                Else
                    Dim inst As FormaPagoMapper = TryCast(HttpContext.Current.Items("abacusRules.FormaPagoMapperSingleton"), FormaPagoMapper)
                    If inst Is Nothing Then
                        inst = New FormaPagoMapper()
                        HttpContext.Current.Items.Add("abacusRules.FormaPagoMapperSingleton", inst)
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
            
            Dim  s() as String={"IdFPago"}
            return s
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Function GetMappingType() as Type
            return GetType(FormaPagoObject)
        End Function


        ''' <summary>
        ''' Return the mapped table name
        ''' </summary>
        Protected Overrides ReadOnly Property TableName() As String 
            Get
                Return "FormaPago"
            End Get
        End Property

        ''' <summary>
        ''' Return the FormaPagoGateway type FullName
        ''' </summary>
        Protected Overrides ReadOnly Property RuleName() As String
            Get
                Return GetType(FormaPagoMapper).FullName
            End Get
        End Property


        

        

        ''' <summary>
        ''' Assign properties values based on DataReader
        ''' </summary>
        Protected Overrides Sub HydrateFields(ByVal reader As DbDataReader, ByVal entity As FormaPagoObject)
            Dim _Forma As String
If reader.IsDBNull(1) Then 
	 _Forma = ""
Else
	 _Forma = reader.GetString(1)
End If
Dim _Numero As System.Nullable(Of System.Int32) 
If reader.IsDBNull(2) Then 
	 _Numero = New System.Nullable(Of System.Int32)
Else
	 _Numero = reader.GetInt32(2)
End If
Dim _Tiempo As String
If reader.IsDBNull(3) Then 
	 _Tiempo = ""
Else
	 _Tiempo = reader.GetString(3)
End If

            Dim FormaPago As IMappeableFormaPagoObject  = CType(entity, IMappeableFormaPagoObject)
            FormaPago.HydrateFields(reader.GetInt32(0), _
_Forma, _
_Numero, _
_Tiempo)
        End Sub

        ''' <summary>
        ''' Get field values to call insertion stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForInsert(ByVal entity As FormaPagoObject) As Object()
            Dim FormaPago As IMappeableFormaPagoObject = CType(entity, IMappeableFormaPagoObject)
            Return FormaPago.GetFieldsForInsert()
        End Function

        ''' <summary>
        ''' Get field values to call update stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForUpdate(ByVal entity As FormaPagoObject) As Object()
            Dim FormaPago As IMappeableFormaPagoObject = CType(entity, IMappeableFormaPagoObject)
            Return FormaPago.GetFieldsForUpdate()
        End Function

        ''' <summary>
        ''' Get field values to call deletion stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForDelete(ByVal entity As FormaPagoObject) As Object()
            Dim FormaPago As IMappeableFormaPagoObject = CType(entity, IMappeableFormaPagoObject)
            Return FormaPago.GetFieldsForDelete()
        End Function

        ''' <summary>
        ''' Raised after insert and update. Update properties from Output parameters
        ''' </summary>
        Protected Overrides Sub UpdateObjectFromOutputParams(ByVal entity As FormaPagoObject, ByVal parameters As Object())
            ' Update properties from Output parameters
            CType(entity, IMappeableFormaPagoObject).UpdateObjectFromOutputParams(parameters)
        End Sub

        ''' <summary>
        ''' StoredProceduresPrefix, for example: coop_
        ''' </summary>
        Protected Overrides Function StoredProceduresPrefix() As String 
            Return "coop_"
        End Function


          



        ''' <summary>
        ''' Get a FormaPago by execute a SQL Query Text
        ''' </summary>
        Public Function GetOneBySQLQuery(sqlQueryText As String) As FormaPagoObject
            Return MyBase.GetObjectBySQLText(sqlQueryText)
        End Function

        ''' <summary>
        ''' Get a FormaPagoList by execute a SQL Query Text
        ''' </summary>
        Public Function GetBySQLQuery(sqlQueryText As String) As FormaPagoObjectList
            Return MyBase.GetObjectListBySQLText(sqlQueryText)
        End Function

        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Function GetOne(IdFPago As System.Int32) As FormaPagoObject
            Return MyBase.GetOne(New FormaPagoObject(IdFPago))
        End Function

        

        ' GetOne By Objects and Params
            

        


        

        





        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub Delete(IdFPago As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "FormaPago_Delete", IdFPago)
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Overloads Sub Delete(ByVal transaction As DbTransaction ,IdFPago As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "FormaPago_Delete", IdFPago)
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
    Public Class FormaPagoMapperWrapper

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
        Public Function Instance() As abacusRules.Mappers.FormaPagoMapper
            Return abacusRules.Mappers.FormaPagoMapper.Instance()
        End Function

        
        ''' <summary>
        ''' Get a FormaPago Entity by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetOne(ByVal IdFPago As System.Int32) As Objects.FormaPagoObject         
            Return Instance().GetOne( IdFPago)
        End Function
        

        ' GetBy Objects and Params
            

        

        ''' <summary>
        ''' GetAll FormaPago 
        ''' </summary>
        Public Function GetAll() As Objects.FormaPagoObjectList
            Return Instance().GetAll()
        End Function

        
        


            

        

        ''' <summary>
        ''' Delete FormaPago 
        ''' </summary>
        Public Overloads Sub Delete(ByVal IdFPago As System.Int32)
            Instance().Delete(IdFPago)
        End Sub

        ''' <summary>
        ''' Delete FormaPago 
        ''' </summary>
        Public Overloads Sub Delete(ByVal entity As Objects.FormaPagoObject)
            Instance().Delete(entity)
        End Sub

        ''' <summary>
        ''' Save FormaPago  
        ''' </summary>
        Public Overloads Sub Save(ByVal entity As Objects.FormaPagoObject)
            Instance().Save(entity)
        End Sub

        ''' <summary>
        ''' Insert FormaPago 
        ''' </summary>
        Public Overloads Sub Insert(ByVal entity As Objects.FormaPagoObject)
            Instance().Insert(entity)
        End Sub

        ''' <summary>
        ''' Save FormaPago 
        ''' </summary>
        Public Overloads Sub Save(ByVal IdFPago As System.Int32, ByVal Forma As System.String, ByVal Numero As System.Int32, ByVal Tiempo As System.String)
            Dim entity As Objects.FormaPagoObject = Instance().GetOne(IdFPago)
            If entity Is Nothing Then
                Throw New ApplicationException(String.Format("Entity not found. IUniqueIdentifiable values: {0} = {1}", "IdFPago", IdFPago))
            End If

            entity.Forma = Forma
            entity.Numero = Numero
            entity.Tiempo = Tiempo
            Instance().Save(entity)
        End Sub

        ''' <summary>
        ''' Insert FormaPago
        ''' </summary>
        Public Overloads Sub Insert(ByVal Forma As System.String, ByVal Numero As System.Int32, ByVal Tiempo As System.String)
            Dim entity As Objects.FormaPagoObject = New Objects.FormaPagoObject

            entity.Forma = Forma
            entity.Numero = Numero
            entity.Tiempo = Tiempo
            Instance().Insert(entity)
        End Sub

        

        'Database Queries 
        


    End Class
End Namespace


Namespace Loaders

    ''' <summary>
    ''' 
    ''' </summary>
    Partial Public Class FormaPagoLoader(Of T As {FormaPagoObject, New})
        Inherits BaseLoader(Of T, FormaPagoObject, ObjectList(Of T))
        Implements IGenericGateway



#Region "Singleton"

        Private Shared _instance As FormaPagoLoader(Of T)

        Private Sub New()
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        Public Shared Function Instance() As FormaPagoLoader(Of T)
            If _instance Is Nothing Then
                If HttpContext.Current Is Nothing Then
                    _instance = New FormaPagoLoader(Of T)
                Else
                    Dim inst As FormaPagoLoader(Of T) = TryCast(HttpContext.Current.Items("abacusRules.FormaPagoLoaderSingleton"), FormaPagoLoader(Of T))
                    If inst Is Nothing Then
                        inst = New FormaPagoLoader(Of T)
                        HttpContext.Current.Items.Add("abacusRules.FormaPagoLoaderSingleton", inst)
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
            
            Dim s() as String={"IdFPago"}
            Return s
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Public Function GetMappingType() as Type
            Return GetType(FormaPagoObject)
        End Function


        Protected Overrides ReadOnly Property TableName As String 
            Get
                Return "FormaPago"
            End Get
        End Property

        

        


        Protected Overrides Sub HydrateFields(ByVal reader As DbDataReader, ByVal entity As FormaPagoObject)
            Dim _Forma As String
If reader.IsDBNull(1) Then 
	 _Forma = ""
Else
	 _Forma = reader.GetString(1)
End If
Dim _Numero As System.Nullable(Of System.Int32) 
If reader.IsDBNull(2) Then 
	 _Numero = New System.Nullable(Of System.Int32)
Else
	 _Numero = reader.GetInt32(2)
End If
Dim _Tiempo As String
If reader.IsDBNull(3) Then 
	 _Tiempo = ""
Else
	 _Tiempo = reader.GetString(3)
End If

            Dim FormaPago As IMappeableFormaPagoObject  = CType(entity, IMappeableFormaPagoObject)
            FormaPago.HydrateFields(reader.GetInt32(0), _
_Forma, _
_Numero, _
_Tiempo)
        End Sub


        Protected Overrides Function StoredProceduresPrefix() As String 
            Return "coop_"
        End Function

        


        ''' <summary>
        ''' Get a FormaPago by execute a SQL Query Text
        ''' </summary>
        Public Function GetOneBySQLQuery(sqlQueryText As String) As t
            Return MyBase.GetObjectBySQLText(sqlQueryText)
        End Function

        ''' <summary>
        ''' Get a FormaPagoList by execute a SQL Query Text
        ''' </summary>
        Public Function GetBySQLQuery(sqlQueryText As String) As ObjectList(Of T)
            Return MyBase.GetObjectListBySQLText(sqlQueryText)
        End Function

        
        ''' <summary>
        ''' GetOne By Params
        ''' </summary>
        Public Overloads Function GetOne(IdFPago As System.Int32) As t
            Return MyBase.GetObjectByAnyStoredProcedure(StoredProceduresPrefix() + "FormaPago_GetOne", IdFPago)
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




