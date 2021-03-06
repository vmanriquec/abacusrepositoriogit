
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 20/08/2013 - 01:48 p.m.
' This is a partial class file. The other one is ProveedoresGateway.vb
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
        
    Public Partial Class ProveedoresGateway 
        Inherits BaseGateway(Of ProveedoresObject, ProveedoresObjectList)
        Implements IGenericGateway

#Region "Singleton"

        Private Shared _instance As ProveedoresGateway

        Private Sub New()
        End Sub

        Public Shared Function Instance() As ProveedoresGateway
            If _instance Is Nothing Then
                If HttpContext.Current Is Nothing Then
                    _instance = New ProveedoresGateway()
                Else
                    Dim inst As ProveedoresGateway = TryCast(HttpContext.Current.Items("abacusRules.ProveedoresGatewaySingleton"), ProveedoresGateway)
                    If inst Is Nothing Then
                        inst = New ProveedoresGateway()
                        HttpContext.Current.Items.Add("abacusRules.ProveedoresGatewaySingleton", inst)
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
                Return "Proveedores"
            End Get
        End Property

        ''' <summary>
        ''' Return the ProveedoresGateway type FullName
        ''' </summary>
        Protected Overrides ReadOnly Property RuleName() As String
            Get
                Return GetType(ProveedoresGateway ).FullName
            End Get
        End Property


        

        


        ''' <summary>
        ''' Assign properties values based on DataReader
        ''' </summary>
        Protected Overrides Sub HydrateFields(ByVal reader As DbDataReader, ByVal entity As ProveedoresObject )
            Dim _TipoProve As System.Nullable(Of System.Int32) 
If reader.IsDBNull(1) Then 
	 _TipoProve = New System.Nullable(Of System.Int32)
Else
	 _TipoProve = reader.GetInt32(1)
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
Dim _Proveedor As String
If reader.IsDBNull(4) Then 
	 _Proveedor = ""
Else
	 _Proveedor = reader.GetString(4)
End If
Dim _NomComercial As String
If reader.IsDBNull(5) Then 
	 _NomComercial = ""
Else
	 _NomComercial = reader.GetString(5)
End If
Dim _TipDoc As System.Nullable(Of System.Int32) 
If reader.IsDBNull(6) Then 
	 _TipDoc = New System.Nullable(Of System.Int32)
Else
	 _TipDoc = reader.GetInt32(6)
End If
Dim _DI As String
If reader.IsDBNull(7) Then 
	 _DI = ""
Else
	 _DI = reader.GetString(7)
End If
Dim _Direccionp As String
If reader.IsDBNull(8) Then 
	 _Direccionp = ""
Else
	 _Direccionp = reader.GetString(8)
End If
Dim _Distritop As String
If reader.IsDBNull(9) Then 
	 _Distritop = ""
Else
	 _Distritop = reader.GetString(9)
End If
Dim _Provinciap As String
If reader.IsDBNull(10) Then 
	 _Provinciap = ""
Else
	 _Provinciap = reader.GetString(10)
End If
Dim _Paisp As String
If reader.IsDBNull(11) Then 
	 _Paisp = ""
Else
	 _Paisp = reader.GetString(11)
End If
Dim _Telefono1p As String
If reader.IsDBNull(12) Then 
	 _Telefono1p = ""
Else
	 _Telefono1p = reader.GetString(12)
End If
Dim _Telefono2p As String
If reader.IsDBNull(13) Then 
	 _Telefono2p = ""
Else
	 _Telefono2p = reader.GetString(13)
End If
Dim _Faxp As String
If reader.IsDBNull(14) Then 
	 _Faxp = ""
Else
	 _Faxp = reader.GetString(14)
End If
Dim _Movilp As String
If reader.IsDBNull(15) Then 
	 _Movilp = ""
Else
	 _Movilp = reader.GetString(15)
End If
Dim _Emailp As String
If reader.IsDBNull(16) Then 
	 _Emailp = ""
Else
	 _Emailp = reader.GetString(16)
End If
Dim _Webp As String
If reader.IsDBNull(17) Then 
	 _Webp = ""
Else
	 _Webp = reader.GetString(17)
End If
Dim _TipMovilp As String
If reader.IsDBNull(18) Then 
	 _TipMovilp = ""
Else
	 _TipMovilp = reader.GetString(18)
End If
Dim _Observaciones As String
If reader.IsDBNull(19) Then 
	 _Observaciones = ""
Else
	 _Observaciones = reader.GetString(19)
End If
Dim _Logo As String
If reader.IsDBNull(20) Then 
	 _Logo = ""
Else
	 _Logo = reader.GetString(20)
End If
Dim _upsize_ts As System.Nullable(Of System.DateTime) 
If reader.IsDBNull(21) Then 
	 _upsize_ts = New System.Nullable(Of System.DateTime)
Else
	 _upsize_ts = reader.GetDateTime(21)
End If
Dim _estado As String
If reader.IsDBNull(22) Then 
	 _estado = ""
Else
	 _estado = reader.GetString(22)
End If

            Dim Proveedores As IMappeableProveedoresObject  = CType(entity, IMappeableProveedoresObject)
            Proveedores.HydrateFields(reader.GetInt32(0), _
_TipoProve, _
_Nombre, _
_Apellido, _
_Proveedor, _
_NomComercial, _
_TipDoc, _
_DI, _
_Direccionp, _
_Distritop, _
_Provinciap, _
_Paisp, _
_Telefono1p, _
_Telefono2p, _
_Faxp, _
_Movilp, _
_Emailp, _
_Webp, _
_TipMovilp, _
_Observaciones, _
_Logo, _
_upsize_ts, _
_estado)
            CType(entity, IObject).State = ObjectState.Restored
        End Sub

        ''' <summary>
        ''' Get field values to call insertion stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForInsert(ByVal entity As ProveedoresObject) As Object()
            Dim Proveedores As IMappeableProveedoresObject = CType(entity, IMappeableProveedoresObject)
            Return Proveedores.GetFieldsForInsert()
        End Function

        ''' <summary>
        ''' Get field values to call update stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForUpdate(ByVal entity As ProveedoresObject) As Object()
            Dim Proveedores As IMappeableProveedoresObject = CType(entity, IMappeableProveedoresObject)
            Return Proveedores.GetFieldsForUpdate()
        End Function

        ''' <summary>
        ''' Get field values to call deletion stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForDelete(ByVal entity As ProveedoresObject) As Object()
            Dim Proveedores As IMappeableProveedoresObject = CType(entity, IMappeableProveedoresObject)
            Return Proveedores.GetFieldsForDelete()
        End Function

        ''' <summary>
        ''' Raised after insert and update. Update properties from Output parameters
        ''' </summary>
        Protected Overrides Sub UpdateObjectFromOutputParams(ByVal row As ProveedoresObject, parameters As Object())
            ' Update properties from Output parameters
            CType(row, IMappeableProveedoresObject).UpdateObjectFromOutputParams(parameters)
            CType(row, IObject).State = ObjectState.Restored
        End Sub

        ''' <summary>
        ''' StoredProceduresPrefix, for example: coop_
        ''' </summary>
        Protected Overrides Function StoredProceduresPrefix() As String
            Return "coop_"
        End Function


        ''' <summary>
        ''' Get a ProveedoresObject by execute a SQL Query Text
        ''' </summary>
        Public Function GetOneBySQLQuery(sqlQueryText As String) As ProveedoresObject 
            Return MyBase.GetObjectBySQLText(sqlQueryText)
        End Function

        ''' <summary>
        ''' Get a ProveedoresObjectList by execute a SQL Query Text
        ''' </summary>
        Public Function GetBySQLQuery(sqlQueryText As String) As ProveedoresObjectList 
            Return MyBase.GetObjectListBySQLText(sqlQueryText)
        End Function



        ''' <summary>
        ''' Get a ProveedoresObject by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetOne(ByVal IdProveedor As System.Int32) As ProveedoresObject         
            Return MyBase.GetOne(New ProveedoresObject(IdProveedor))
        End Function

            


        


        

        
        ''' <summary>
        ''' Delete Proveedores 
        ''' </summary>
        Public Overloads Sub Delete(ByVal IdProveedor As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Proveedores_Delete", IdProveedor)
        End Sub

        ''' <summary>
        ''' Delete Proveedores
        ''' </summary>
        Public Overloads Sub Delete(transaction As DbTransaction , ByVal IdProveedor As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Proveedores_Delete", IdProveedor)
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




