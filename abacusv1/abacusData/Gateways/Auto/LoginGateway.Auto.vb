
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 20/08/2013 - 01:48 p.m.
' This is a partial class file. The other one is LoginGateway.vb
' You should not modifiy this file, please edit the other partial class file.
'------------------------------------------------------------------------------

Imports System
Imports abacusRules.Objects
Imports Cooperator.Framework.Data
Imports Cooperator.Framework.Data.Exceptions
Imports Cooperator.Framework.Core
Imports System.Data.Common
Imports System.Reflection
Imports System.Web

Namespace Gateways
        
    Public Partial Class LoginGateway 
        Inherits BaseGateway(Of LoginObject, LoginObjectList)
        Implements IGenericGateway

#Region "Singleton"

        Private Shared _instance As LoginGateway

        Private Sub New()
        End Sub

        Public Shared Function Instance() As LoginGateway
            If _instance Is Nothing Then
                If HttpContext.Current Is Nothing Then
                    _instance = New LoginGateway()
                Else
                    Dim inst As LoginGateway = TryCast(HttpContext.Current.Items("abacusRules.LoginGatewaySingleton"), LoginGateway)
                    If inst Is Nothing Then
                        inst = New LoginGateway()
                        HttpContext.Current.Items.Add("abacusRules.LoginGatewaySingleton", inst)
                    End If
                    Return inst
                End If
            End If
            Return _instance
        End Function

#End Region

        ''' <summary>
        ''' Return the mapped table name
        ''' </summary>
        Protected Overrides ReadOnly Property TableName() As String
            Get
                Return "Login"
            End Get
        End Property

        ''' <summary>
        ''' Return the LoginGateway type FullName
        ''' </summary>
        Protected Overrides ReadOnly Property RuleName() As String
            Get
                Return GetType(LoginGateway ).FullName
            End Get
        End Property


        

        


        ''' <summary>
        ''' Assign properties values based on DataReader
        ''' </summary>
        Protected Overrides Sub HydrateFields(ByVal reader As DbDataReader, ByVal entity As LoginObject )
            Dim _IdProveedor As System.Nullable(Of System.Int32) 
If reader.IsDBNull(1) Then 
	 _IdProveedor = New System.Nullable(Of System.Int32)
Else
	 _IdProveedor = reader.GetInt32(1)
End If
Dim _Usuario As String
If reader.IsDBNull(2) Then 
	 _Usuario = ""
Else
	 _Usuario = reader.GetString(2)
End If
Dim _Contraseña As String
If reader.IsDBNull(3) Then 
	 _Contraseña = ""
Else
	 _Contraseña = reader.GetString(3)
End If
Dim _Administrador As System.Nullable(Of System.Boolean) 
If reader.IsDBNull(4) Then 
	 _Administrador = New System.Nullable(Of System.Boolean)
Else
	 _Administrador = reader.GetBoolean(4)
End If
Dim _Produccion As System.Nullable(Of System.Boolean) 
If reader.IsDBNull(5) Then 
	 _Produccion = New System.Nullable(Of System.Boolean)
Else
	 _Produccion = reader.GetBoolean(5)
End If
Dim _Lectura As System.Nullable(Of System.Boolean) 
If reader.IsDBNull(6) Then 
	 _Lectura = New System.Nullable(Of System.Boolean)
Else
	 _Lectura = reader.GetBoolean(6)
End If
Dim _ProveedoresString As String
If reader.IsDBNull(7) Then 
	 _ProveedoresString = ""
Else
	 _ProveedoresString = reader.GetString(7)
End If

            Dim Login As IMappeableLoginObject  = CType(entity, IMappeableLoginObject)
            Login.HydrateFields(reader.GetInt32(0), _
_IdProveedor, _
_Usuario, _
_Contraseña, _
_Administrador, _
_Produccion, _
_Lectura, _
_ProveedoresString)
            CType(entity, IObject).State = ObjectState.Restored
        End Sub

        ''' <summary>
        ''' Get field values to call insertion stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForInsert(ByVal entity As LoginObject) As Object()
            Dim Login As IMappeableLoginObject = CType(entity, IMappeableLoginObject)
            Return Login.GetFieldsForInsert()
        End Function

        ''' <summary>
        ''' Get field values to call update stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForUpdate(ByVal entity As LoginObject) As Object()
            Dim Login As IMappeableLoginObject = CType(entity, IMappeableLoginObject)
            Return Login.GetFieldsForUpdate()
        End Function

        ''' <summary>
        ''' Get field values to call deletion stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForDelete(ByVal entity As LoginObject) As Object()
            Dim Login As IMappeableLoginObject = CType(entity, IMappeableLoginObject)
            Return Login.GetFieldsForDelete()
        End Function

        ''' <summary>
        ''' Raised after insert and update. Update properties from Output parameters
        ''' </summary>
        Protected Overrides Sub UpdateObjectFromOutputParams(ByVal row As LoginObject, parameters As Object())
            ' Update properties from Output parameters
            CType(row, IMappeableLoginObject).UpdateObjectFromOutputParams(parameters)
            CType(row, IObject).State = ObjectState.Restored
        End Sub

        ''' <summary>
        ''' StoredProceduresPrefix, for example: coop_
        ''' </summary>
        Protected Overrides Function StoredProceduresPrefix() As String
            Return "coop_"
        End Function


        ''' <summary>
        ''' Get a LoginObject by execute a SQL Query Text
        ''' </summary>
        Public Function GetOneBySQLQuery(sqlQueryText As String) As LoginObject 
            Return MyBase.GetObjectBySQLText(sqlQueryText)
        End Function

        ''' <summary>
        ''' Get a LoginObjectList by execute a SQL Query Text
        ''' </summary>
        Public Function GetBySQLQuery(sqlQueryText As String) As LoginObjectList 
            Return MyBase.GetObjectListBySQLText(sqlQueryText)
        End Function



        ''' <summary>
        ''' Get a LoginObject by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetOne(ByVal Idlogin As System.Int32) As LoginObject         
            Return MyBase.GetOne(New LoginObject(Idlogin))
        End Function

            


        
        ''' <summary>
        ''' Get a LoginObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByProveedores(ByVal transaction As DbTransaction, ByVal IdProveedor As System.Int32) As LoginObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Login_GetByProveedores", IdProveedor)
        End Function

        ''' <summary>
        ''' Get a LoginObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByProveedores(ByVal transaction As DbTransaction, Proveedores As IUniqueIdentifiable) As LoginObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Login_GetByProveedores", Proveedores.Identifier())
        End Function
    


        
        ''' <summary>
        ''' Get a LoginObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByProveedores(ByVal IdProveedor As System.Int32) As LoginObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Login_GetByProveedores", IdProveedor)
        End Function

        ''' <summary>
        ''' Get a LoginObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByProveedores(Proveedores As IUniqueIdentifiable) As LoginObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Login_GetByProveedores", Proveedores.Identifier())
        End Function
    

        
        ''' <summary>
        ''' Delete Login 
        ''' </summary>
        Public Overloads Sub Delete(ByVal Idlogin As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Login_Delete", Idlogin)
        End Sub

        ''' <summary>
        ''' Delete Login
        ''' </summary>
        Public Overloads Sub Delete(transaction As DbTransaction , ByVal Idlogin As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Login_Delete", Idlogin)
        End Sub

            



        

    

    

    

    

    

    

    

    

        ''' <summary>
        ''' Delete Login By Proveedores
        ''' </summary>
        Public Overloads Sub DeleteByProveedores(ByVal IdProveedor As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Login_DeleteByProveedores", IdProveedor)
        End Sub

        ''' <summary>
        ''' Delete Login By Proveedores
        ''' </summary>
        Public Overloads Sub DeleteByProveedores(ByVal transaction As DbTransaction , ByVal IdProveedor As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Login_DeleteByProveedores", IdProveedor)
        End Sub

        ''' <summary>
        ''' Delete Login By Proveedores
        ''' </summary>
        Public Overloads Sub DeleteByProveedores(ByVal Proveedores As IUniqueIdentifiable )
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Login_DeleteByProveedores", Proveedores.Identifier())
        End Sub

        ''' <summary>
        ''' Delete Login By Proveedores
        ''' </summary>
        Public Overloads Sub DeleteByProveedores(ByVal transaction As DbTransaction , ByVal Proveedores As IUniqueIdentifiable)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Login_DeleteByProveedores", Proveedores.Identifier())
        End Sub

        

    


        'Database Queries 
        



        #Region "IGenericGateway"

        Private Function GetOne2(identifier As IUniqueIdentifiable) As Object Implements IGenericGateway.GetOne
            Return MyBase.GetOne(identifier)
        End Function

        Private Function GetAll2() As Object Implements IGenericGateway.GetAll
            Return MyBase.GetAll()
        End Function

        Private Function GeyByParent2(parentEntity As IUniqueIdentifiable) As Object Implements IGenericGateway.GetByParent
            Return MyBase.GetByParent(parentEntity)
        End Function

        #End Region

    End Class
End Namespace




