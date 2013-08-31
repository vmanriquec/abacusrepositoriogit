
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 20/08/2013 - 01:48 p.m.
' This is a partial class file. The other one is IngresosDetGateway.vb
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
        
    Public Partial Class IngresosDetGateway 
        Inherits BaseGateway(Of IngresosDetObject, IngresosDetObjectList)
        Implements IGenericGateway

#Region "Singleton"

        Private Shared _instance As IngresosDetGateway

        Private Sub New()
        End Sub

        Public Shared Function Instance() As IngresosDetGateway
            If _instance Is Nothing Then
                If HttpContext.Current Is Nothing Then
                    _instance = New IngresosDetGateway()
                Else
                    Dim inst As IngresosDetGateway = TryCast(HttpContext.Current.Items("abacusRules.IngresosDetGatewaySingleton"), IngresosDetGateway)
                    If inst Is Nothing Then
                        inst = New IngresosDetGateway()
                        HttpContext.Current.Items.Add("abacusRules.IngresosDetGatewaySingleton", inst)
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
                Return "IngresosDet"
            End Get
        End Property

        ''' <summary>
        ''' Return the IngresosDetGateway type FullName
        ''' </summary>
        Protected Overrides ReadOnly Property RuleName() As String
            Get
                Return GetType(IngresosDetGateway ).FullName
            End Get
        End Property


        

        


        ''' <summary>
        ''' Assign properties values based on DataReader
        ''' </summary>
        Protected Overrides Sub HydrateFields(ByVal reader As DbDataReader, ByVal entity As IngresosDetObject )
            Dim _IdIngresos As System.Nullable(Of System.Int32) 
If reader.IsDBNull(1) Then 
	 _IdIngresos = New System.Nullable(Of System.Int32)
Else
	 _IdIngresos = reader.GetInt32(1)
End If
Dim _IdProducto As System.Nullable(Of System.Int32) 
If reader.IsDBNull(2) Then 
	 _IdProducto = New System.Nullable(Of System.Int32)
Else
	 _IdProducto = reader.GetInt32(2)
End If
Dim _Cantidad As System.Nullable(Of System.Decimal) 
If reader.IsDBNull(3) Then 
	 _Cantidad = New System.Nullable(Of System.Decimal)
Else
	 _Cantidad = reader.GetDecimal(3)
End If
Dim _PU As System.Nullable(Of System.Decimal) 
If reader.IsDBNull(4) Then 
	 _PU = New System.Nullable(Of System.Decimal)
Else
	 _PU = reader.GetDecimal(4)
End If
Dim _IdAlmacen As System.Nullable(Of System.Int32) 
If reader.IsDBNull(5) Then 
	 _IdAlmacen = New System.Nullable(Of System.Int32)
Else
	 _IdAlmacen = reader.GetInt32(5)
End If
Dim _upsize_ts As System.Nullable(Of System.DateTime) 
If reader.IsDBNull(6) Then 
	 _upsize_ts = New System.Nullable(Of System.DateTime)
Else
	 _upsize_ts = reader.GetDateTime(6)
End If
Dim _subtotal As System.Nullable(Of System.Decimal) 
If reader.IsDBNull(7) Then 
	 _subtotal = New System.Nullable(Of System.Decimal)
Else
	 _subtotal = reader.GetDecimal(7)
End If
Dim _pventa As System.Nullable(Of System.Decimal) 
If reader.IsDBNull(8) Then 
	 _pventa = New System.Nullable(Of System.Decimal)
Else
	 _pventa = reader.GetDecimal(8)
End If
Dim _AlmacenesString As String
If reader.IsDBNull(9) Then 
	 _AlmacenesString = ""
Else
	 _AlmacenesString = reader.GetString(9)
End If
Dim _IngresosString As String
If reader.IsDBNull(10) Then 
	 _IngresosString = ""
Else
	 _IngresosString = reader.GetString(10)
End If
Dim _ProductosString As String
If reader.IsDBNull(11) Then 
	 _ProductosString = ""
Else
	 _ProductosString = reader.GetString(11)
End If

            Dim IngresosDet As IMappeableIngresosDetObject  = CType(entity, IMappeableIngresosDetObject)
            IngresosDet.HydrateFields(reader.GetInt32(0), _
_IdIngresos, _
_IdProducto, _
_Cantidad, _
_PU, _
_IdAlmacen, _
_upsize_ts, _
_subtotal, _
_pventa, _
_AlmacenesString, _
_IngresosString, _
_ProductosString)
            CType(entity, IObject).State = ObjectState.Restored
        End Sub

        ''' <summary>
        ''' Get field values to call insertion stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForInsert(ByVal entity As IngresosDetObject) As Object()
            Dim IngresosDet As IMappeableIngresosDetObject = CType(entity, IMappeableIngresosDetObject)
            Return IngresosDet.GetFieldsForInsert()
        End Function

        ''' <summary>
        ''' Get field values to call update stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForUpdate(ByVal entity As IngresosDetObject) As Object()
            Dim IngresosDet As IMappeableIngresosDetObject = CType(entity, IMappeableIngresosDetObject)
            Return IngresosDet.GetFieldsForUpdate()
        End Function

        ''' <summary>
        ''' Get field values to call deletion stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForDelete(ByVal entity As IngresosDetObject) As Object()
            Dim IngresosDet As IMappeableIngresosDetObject = CType(entity, IMappeableIngresosDetObject)
            Return IngresosDet.GetFieldsForDelete()
        End Function

        ''' <summary>
        ''' Raised after insert and update. Update properties from Output parameters
        ''' </summary>
        Protected Overrides Sub UpdateObjectFromOutputParams(ByVal row As IngresosDetObject, parameters As Object())
            ' Update properties from Output parameters
            CType(row, IMappeableIngresosDetObject).UpdateObjectFromOutputParams(parameters)
            CType(row, IObject).State = ObjectState.Restored
        End Sub

        ''' <summary>
        ''' StoredProceduresPrefix, for example: coop_
        ''' </summary>
        Protected Overrides Function StoredProceduresPrefix() As String
            Return "coop_"
        End Function


        ''' <summary>
        ''' Get a IngresosDetObject by execute a SQL Query Text
        ''' </summary>
        Public Function GetOneBySQLQuery(sqlQueryText As String) As IngresosDetObject 
            Return MyBase.GetObjectBySQLText(sqlQueryText)
        End Function

        ''' <summary>
        ''' Get a IngresosDetObjectList by execute a SQL Query Text
        ''' </summary>
        Public Function GetBySQLQuery(sqlQueryText As String) As IngresosDetObjectList 
            Return MyBase.GetObjectListBySQLText(sqlQueryText)
        End Function



        ''' <summary>
        ''' Get a IngresosDetObject by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetOne(ByVal IdIngresosDet As System.Int32) As IngresosDetObject         
            Return MyBase.GetOne(New IngresosDetObject(IdIngresosDet))
        End Function

            


        
        ''' <summary>
        ''' Get a IngresosDetObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByAlmacenes(ByVal transaction As DbTransaction, ByVal IdAlmacen As System.Int32) As IngresosDetObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "IngresosDet_GetByAlmacenes", IdAlmacen)
        End Function

        ''' <summary>
        ''' Get a IngresosDetObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByAlmacenes(ByVal transaction As DbTransaction, Almacenes As IUniqueIdentifiable) As IngresosDetObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "IngresosDet_GetByAlmacenes", Almacenes.Identifier())
        End Function
    
        ''' <summary>
        ''' Get a IngresosDetObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByIngresos(ByVal transaction As DbTransaction, ByVal IdIngresos As System.Int32) As IngresosDetObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "IngresosDet_GetByIngresos", IdIngresos)
        End Function

        ''' <summary>
        ''' Get a IngresosDetObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByIngresos(ByVal transaction As DbTransaction, Ingresos As IUniqueIdentifiable) As IngresosDetObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "IngresosDet_GetByIngresos", Ingresos.Identifier())
        End Function
    
        ''' <summary>
        ''' Get a IngresosDetObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByProductos(ByVal transaction As DbTransaction, ByVal IdProducto As System.Int32) As IngresosDetObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "IngresosDet_GetByProductos", IdProducto)
        End Function

        ''' <summary>
        ''' Get a IngresosDetObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByProductos(ByVal transaction As DbTransaction, Productos As IUniqueIdentifiable) As IngresosDetObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "IngresosDet_GetByProductos", Productos.Identifier())
        End Function
    


        
        ''' <summary>
        ''' Get a IngresosDetObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByAlmacenes(ByVal IdAlmacen As System.Int32) As IngresosDetObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "IngresosDet_GetByAlmacenes", IdAlmacen)
        End Function

        ''' <summary>
        ''' Get a IngresosDetObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByAlmacenes(Almacenes As IUniqueIdentifiable) As IngresosDetObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "IngresosDet_GetByAlmacenes", Almacenes.Identifier())
        End Function
    
        ''' <summary>
        ''' Get a IngresosDetObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByIngresos(ByVal IdIngresos As System.Int32) As IngresosDetObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "IngresosDet_GetByIngresos", IdIngresos)
        End Function

        ''' <summary>
        ''' Get a IngresosDetObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByIngresos(Ingresos As IUniqueIdentifiable) As IngresosDetObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "IngresosDet_GetByIngresos", Ingresos.Identifier())
        End Function
    
        ''' <summary>
        ''' Get a IngresosDetObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByProductos(ByVal IdProducto As System.Int32) As IngresosDetObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "IngresosDet_GetByProductos", IdProducto)
        End Function

        ''' <summary>
        ''' Get a IngresosDetObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByProductos(Productos As IUniqueIdentifiable) As IngresosDetObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "IngresosDet_GetByProductos", Productos.Identifier())
        End Function
    

        
        ''' <summary>
        ''' Delete IngresosDet 
        ''' </summary>
        Public Overloads Sub Delete(ByVal IdIngresosDet As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "IngresosDet_Delete", IdIngresosDet)
        End Sub

        ''' <summary>
        ''' Delete IngresosDet
        ''' </summary>
        Public Overloads Sub Delete(transaction As DbTransaction , ByVal IdIngresosDet As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "IngresosDet_Delete", IdIngresosDet)
        End Sub

            



        

    

    

    

    

    

    

    

    

    

    

    

    

        ''' <summary>
        ''' Delete IngresosDet By Almacenes
        ''' </summary>
        Public Overloads Sub DeleteByAlmacenes(ByVal IdAlmacen As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "IngresosDet_DeleteByAlmacenes", IdAlmacen)
        End Sub

        ''' <summary>
        ''' Delete IngresosDet By Almacenes
        ''' </summary>
        Public Overloads Sub DeleteByAlmacenes(ByVal transaction As DbTransaction , ByVal IdAlmacen As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "IngresosDet_DeleteByAlmacenes", IdAlmacen)
        End Sub

        ''' <summary>
        ''' Delete IngresosDet By Almacenes
        ''' </summary>
        Public Overloads Sub DeleteByAlmacenes(ByVal Almacenes As IUniqueIdentifiable )
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "IngresosDet_DeleteByAlmacenes", Almacenes.Identifier())
        End Sub

        ''' <summary>
        ''' Delete IngresosDet By Almacenes
        ''' </summary>
        Public Overloads Sub DeleteByAlmacenes(ByVal transaction As DbTransaction , ByVal Almacenes As IUniqueIdentifiable)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "IngresosDet_DeleteByAlmacenes", Almacenes.Identifier())
        End Sub

        

    

        ''' <summary>
        ''' Delete IngresosDet By Ingresos
        ''' </summary>
        Public Overloads Sub DeleteByIngresos(ByVal IdIngresos As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "IngresosDet_DeleteByIngresos", IdIngresos)
        End Sub

        ''' <summary>
        ''' Delete IngresosDet By Ingresos
        ''' </summary>
        Public Overloads Sub DeleteByIngresos(ByVal transaction As DbTransaction , ByVal IdIngresos As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "IngresosDet_DeleteByIngresos", IdIngresos)
        End Sub

        ''' <summary>
        ''' Delete IngresosDet By Ingresos
        ''' </summary>
        Public Overloads Sub DeleteByIngresos(ByVal Ingresos As IUniqueIdentifiable )
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "IngresosDet_DeleteByIngresos", Ingresos.Identifier())
        End Sub

        ''' <summary>
        ''' Delete IngresosDet By Ingresos
        ''' </summary>
        Public Overloads Sub DeleteByIngresos(ByVal transaction As DbTransaction , ByVal Ingresos As IUniqueIdentifiable)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "IngresosDet_DeleteByIngresos", Ingresos.Identifier())
        End Sub

        

    

        ''' <summary>
        ''' Delete IngresosDet By Productos
        ''' </summary>
        Public Overloads Sub DeleteByProductos(ByVal IdProducto As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "IngresosDet_DeleteByProductos", IdProducto)
        End Sub

        ''' <summary>
        ''' Delete IngresosDet By Productos
        ''' </summary>
        Public Overloads Sub DeleteByProductos(ByVal transaction As DbTransaction , ByVal IdProducto As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "IngresosDet_DeleteByProductos", IdProducto)
        End Sub

        ''' <summary>
        ''' Delete IngresosDet By Productos
        ''' </summary>
        Public Overloads Sub DeleteByProductos(ByVal Productos As IUniqueIdentifiable )
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "IngresosDet_DeleteByProductos", Productos.Identifier())
        End Sub

        ''' <summary>
        ''' Delete IngresosDet By Productos
        ''' </summary>
        Public Overloads Sub DeleteByProductos(ByVal transaction As DbTransaction , ByVal Productos As IUniqueIdentifiable)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "IngresosDet_DeleteByProductos", Productos.Identifier())
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




