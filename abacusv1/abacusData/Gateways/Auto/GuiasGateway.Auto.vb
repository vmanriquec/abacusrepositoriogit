
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 20/08/2013 - 01:48 p.m.
' This is a partial class file. The other one is GuiasGateway.vb
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
        
    Public Partial Class GuiasGateway 
        Inherits BaseGateway(Of GuiasObject, GuiasObjectList)
        Implements IGenericGateway

#Region "Singleton"

        Private Shared _instance As GuiasGateway

        Private Sub New()
        End Sub

        Public Shared Function Instance() As GuiasGateway
            If _instance Is Nothing Then
                If HttpContext.Current Is Nothing Then
                    _instance = New GuiasGateway()
                Else
                    Dim inst As GuiasGateway = TryCast(HttpContext.Current.Items("abacusRules.GuiasGatewaySingleton"), GuiasGateway)
                    If inst Is Nothing Then
                        inst = New GuiasGateway()
                        HttpContext.Current.Items.Add("abacusRules.GuiasGatewaySingleton", inst)
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
                Return "Guias"
            End Get
        End Property

        ''' <summary>
        ''' Return the GuiasGateway type FullName
        ''' </summary>
        Protected Overrides ReadOnly Property RuleName() As String
            Get
                Return GetType(GuiasGateway ).FullName
            End Get
        End Property


        

        


        ''' <summary>
        ''' Assign properties values based on DataReader
        ''' </summary>
        Protected Overrides Sub HydrateFields(ByVal reader As DbDataReader, ByVal entity As GuiasObject )
            Dim _IdFactura As System.Nullable(Of System.Int32) 
If reader.IsDBNull(1) Then 
	 _IdFactura = New System.Nullable(Of System.Int32)
Else
	 _IdFactura = reader.GetInt32(1)
End If
Dim _NGuia As System.Nullable(Of System.Int32) 
If reader.IsDBNull(2) Then 
	 _NGuia = New System.Nullable(Of System.Int32)
Else
	 _NGuia = reader.GetInt32(2)
End If
Dim _SGuia As String
If reader.IsDBNull(3) Then 
	 _SGuia = ""
Else
	 _SGuia = reader.GetString(3)
End If
Dim _FecTraslado As System.Nullable(Of System.DateTime) 
If reader.IsDBNull(4) Then 
	 _FecTraslado = New System.Nullable(Of System.DateTime)
Else
	 _FecTraslado = reader.GetDateTime(4)
End If
Dim _IdCliente As System.Nullable(Of System.Int32) 
If reader.IsDBNull(5) Then 
	 _IdCliente = New System.Nullable(Of System.Int32)
Else
	 _IdCliente = reader.GetInt32(5)
End If
Dim _IdAlmacen As System.Nullable(Of System.Int32) 
If reader.IsDBNull(6) Then 
	 _IdAlmacen = New System.Nullable(Of System.Int32)
Else
	 _IdAlmacen = reader.GetInt32(6)
End If
Dim _OCompra As String
If reader.IsDBNull(7) Then 
	 _OCompra = ""
Else
	 _OCompra = reader.GetString(7)
End If
Dim _PuntoPartida As String
If reader.IsDBNull(8) Then 
	 _PuntoPartida = ""
Else
	 _PuntoPartida = reader.GetString(8)
End If
Dim _NFactura As String
If reader.IsDBNull(9) Then 
	 _NFactura = ""
Else
	 _NFactura = reader.GetString(9)
End If
Dim _Venta As System.Nullable(Of System.Boolean) 
If reader.IsDBNull(10) Then 
	 _Venta = New System.Nullable(Of System.Boolean)
Else
	 _Venta = reader.GetBoolean(10)
End If
Dim _Compra As System.Nullable(Of System.Boolean) 
If reader.IsDBNull(11) Then 
	 _Compra = New System.Nullable(Of System.Boolean)
Else
	 _Compra = reader.GetBoolean(11)
End If
Dim _Consignacion As System.Nullable(Of System.Boolean) 
If reader.IsDBNull(12) Then 
	 _Consignacion = New System.Nullable(Of System.Boolean)
Else
	 _Consignacion = reader.GetBoolean(12)
End If
Dim _VentaET As System.Nullable(Of System.Boolean) 
If reader.IsDBNull(13) Then 
	 _VentaET = New System.Nullable(Of System.Boolean)
Else
	 _VentaET = reader.GetBoolean(13)
End If
Dim _VentaC As System.Nullable(Of System.Boolean) 
If reader.IsDBNull(14) Then 
	 _VentaC = New System.Nullable(Of System.Boolean)
Else
	 _VentaC = reader.GetBoolean(14)
End If
Dim _TrasladoEE As System.Nullable(Of System.Boolean) 
If reader.IsDBNull(15) Then 
	 _TrasladoEE = New System.Nullable(Of System.Boolean)
Else
	 _TrasladoEE = reader.GetBoolean(15)
End If
Dim _Devolucion As System.Nullable(Of System.Boolean) 
If reader.IsDBNull(16) Then 
	 _Devolucion = New System.Nullable(Of System.Boolean)
Else
	 _Devolucion = reader.GetBoolean(16)
End If
Dim _Recojo As System.Nullable(Of System.Boolean) 
If reader.IsDBNull(17) Then 
	 _Recojo = New System.Nullable(Of System.Boolean)
Else
	 _Recojo = reader.GetBoolean(17)
End If
Dim _Importacion As System.Nullable(Of System.Boolean) 
If reader.IsDBNull(18) Then 
	 _Importacion = New System.Nullable(Of System.Boolean)
Else
	 _Importacion = reader.GetBoolean(18)
End If
Dim _Exportacion As System.Nullable(Of System.Boolean) 
If reader.IsDBNull(19) Then 
	 _Exportacion = New System.Nullable(Of System.Boolean)
Else
	 _Exportacion = reader.GetBoolean(19)
End If
Dim _TrasladoZP As System.Nullable(Of System.Boolean) 
If reader.IsDBNull(20) Then 
	 _TrasladoZP = New System.Nullable(Of System.Boolean)
Else
	 _TrasladoZP = reader.GetBoolean(20)
End If
Dim _TrasladoEI As System.Nullable(Of System.Boolean) 
If reader.IsDBNull(21) Then 
	 _TrasladoEI = New System.Nullable(Of System.Boolean)
Else
	 _TrasladoEI = reader.GetBoolean(21)
End If
Dim _TrasladoB As System.Nullable(Of System.Boolean) 
If reader.IsDBNull(22) Then 
	 _TrasladoB = New System.Nullable(Of System.Boolean)
Else
	 _TrasladoB = reader.GetBoolean(22)
End If
Dim _Otros As System.Nullable(Of System.Boolean) 
If reader.IsDBNull(23) Then 
	 _Otros = New System.Nullable(Of System.Boolean)
Else
	 _Otros = reader.GetBoolean(23)
End If
Dim _EspecOtros As String
If reader.IsDBNull(24) Then 
	 _EspecOtros = ""
Else
	 _EspecOtros = reader.GetString(24)
End If
Dim _IdCoti As System.Nullable(Of System.Int32) 
If reader.IsDBNull(25) Then 
	 _IdCoti = New System.Nullable(Of System.Int32)
Else
	 _IdCoti = reader.GetInt32(25)
End If
Dim _IdTransportista As System.Nullable(Of System.Int32) 
If reader.IsDBNull(26) Then 
	 _IdTransportista = New System.Nullable(Of System.Int32)
Else
	 _IdTransportista = reader.GetInt32(26)
End If
Dim _IdFact As System.Nullable(Of System.Int32) 
If reader.IsDBNull(27) Then 
	 _IdFact = New System.Nullable(Of System.Int32)
Else
	 _IdFact = reader.GetInt32(27)
End If
Dim _Anulado As System.Nullable(Of System.Boolean) 
If reader.IsDBNull(28) Then 
	 _Anulado = New System.Nullable(Of System.Boolean)
Else
	 _Anulado = reader.GetBoolean(28)
End If
Dim _ObsAnulado As String
If reader.IsDBNull(29) Then 
	 _ObsAnulado = ""
Else
	 _ObsAnulado = reader.GetString(29)
End If
Dim _Almacen As String
If reader.IsDBNull(30) Then 
	 _Almacen = ""
Else
	 _Almacen = reader.GetString(30)
End If
Dim _IdTienda As System.Nullable(Of System.Int32) 
If reader.IsDBNull(31) Then 
	 _IdTienda = New System.Nullable(Of System.Int32)
Else
	 _IdTienda = reader.GetInt32(31)
End If
Dim _GoR As System.Nullable(Of System.Boolean) 
If reader.IsDBNull(32) Then 
	 _GoR = New System.Nullable(Of System.Boolean)
Else
	 _GoR = reader.GetBoolean(32)
End If
Dim _estado As String
If reader.IsDBNull(33) Then 
	 _estado = ""
Else
	 _estado = reader.GetString(33)
End If
Dim _AlmacenesString As String
If reader.IsDBNull(34) Then 
	 _AlmacenesString = ""
Else
	 _AlmacenesString = reader.GetString(34)
End If
Dim _ClientesString As String
If reader.IsDBNull(35) Then 
	 _ClientesString = ""
Else
	 _ClientesString = reader.GetString(35)
End If
Dim _CotizacionString As String
If reader.IsDBNull(36) Then 
	 _CotizacionString = ""
Else
	 _CotizacionString = reader.GetString(36)
End If
Dim _FacturaString As String
If reader.IsDBNull(37) Then 
	 _FacturaString = ""
Else
	 _FacturaString = reader.GetString(37)
End If
Dim _TransportistaString As String
If reader.IsDBNull(38) Then 
	 _TransportistaString = ""
Else
	 _TransportistaString = reader.GetString(38)
End If

            Dim Guias As IMappeableGuiasObject  = CType(entity, IMappeableGuiasObject)
            Guias.HydrateFields(reader.GetInt32(0), _
_IdFactura, _
_NGuia, _
_SGuia, _
_FecTraslado, _
_IdCliente, _
_IdAlmacen, _
_OCompra, _
_PuntoPartida, _
_NFactura, _
_Venta, _
_Compra, _
_Consignacion, _
_VentaET, _
_VentaC, _
_TrasladoEE, _
_Devolucion, _
_Recojo, _
_Importacion, _
_Exportacion, _
_TrasladoZP, _
_TrasladoEI, _
_TrasladoB, _
_Otros, _
_EspecOtros, _
_IdCoti, _
_IdTransportista, _
_IdFact, _
_Anulado, _
_ObsAnulado, _
_Almacen, _
_IdTienda, _
_GoR, _
_estado, _
_AlmacenesString, _
_ClientesString, _
_CotizacionString, _
_FacturaString, _
_TransportistaString)
            CType(entity, IObject).State = ObjectState.Restored
        End Sub

        ''' <summary>
        ''' Get field values to call insertion stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForInsert(ByVal entity As GuiasObject) As Object()
            Dim Guias As IMappeableGuiasObject = CType(entity, IMappeableGuiasObject)
            Return Guias.GetFieldsForInsert()
        End Function

        ''' <summary>
        ''' Get field values to call update stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForUpdate(ByVal entity As GuiasObject) As Object()
            Dim Guias As IMappeableGuiasObject = CType(entity, IMappeableGuiasObject)
            Return Guias.GetFieldsForUpdate()
        End Function

        ''' <summary>
        ''' Get field values to call deletion stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForDelete(ByVal entity As GuiasObject) As Object()
            Dim Guias As IMappeableGuiasObject = CType(entity, IMappeableGuiasObject)
            Return Guias.GetFieldsForDelete()
        End Function

        ''' <summary>
        ''' Raised after insert and update. Update properties from Output parameters
        ''' </summary>
        Protected Overrides Sub UpdateObjectFromOutputParams(ByVal row As GuiasObject, parameters As Object())
            ' Update properties from Output parameters
            CType(row, IMappeableGuiasObject).UpdateObjectFromOutputParams(parameters)
            CType(row, IObject).State = ObjectState.Restored
        End Sub

        ''' <summary>
        ''' StoredProceduresPrefix, for example: coop_
        ''' </summary>
        Protected Overrides Function StoredProceduresPrefix() As String
            Return "coop_"
        End Function


        ''' <summary>
        ''' Get a GuiasObject by execute a SQL Query Text
        ''' </summary>
        Public Function GetOneBySQLQuery(sqlQueryText As String) As GuiasObject 
            Return MyBase.GetObjectBySQLText(sqlQueryText)
        End Function

        ''' <summary>
        ''' Get a GuiasObjectList by execute a SQL Query Text
        ''' </summary>
        Public Function GetBySQLQuery(sqlQueryText As String) As GuiasObjectList 
            Return MyBase.GetObjectListBySQLText(sqlQueryText)
        End Function



        ''' <summary>
        ''' Get a GuiasObject by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetOne(ByVal IdGuias As System.Int32) As GuiasObject         
            Return MyBase.GetOne(New GuiasObject(IdGuias))
        End Function

            


        
        ''' <summary>
        ''' Get a GuiasObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByAlmacenes(ByVal transaction As DbTransaction, ByVal IdAlmacen As System.Int32) As GuiasObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Guias_GetByAlmacenes", IdAlmacen)
        End Function

        ''' <summary>
        ''' Get a GuiasObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByAlmacenes(ByVal transaction As DbTransaction, Almacenes As IUniqueIdentifiable) As GuiasObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Guias_GetByAlmacenes", Almacenes.Identifier())
        End Function
    
        ''' <summary>
        ''' Get a GuiasObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByClientes(ByVal transaction As DbTransaction, ByVal IdCliente As System.Int32) As GuiasObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Guias_GetByClientes", IdCliente)
        End Function

        ''' <summary>
        ''' Get a GuiasObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByClientes(ByVal transaction As DbTransaction, Clientes As IUniqueIdentifiable) As GuiasObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Guias_GetByClientes", Clientes.Identifier())
        End Function
    
        ''' <summary>
        ''' Get a GuiasObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByCotizacion(ByVal transaction As DbTransaction, ByVal IdCoti As System.Int32) As GuiasObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Guias_GetByCotizacion", IdCoti)
        End Function

        ''' <summary>
        ''' Get a GuiasObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByCotizacion(ByVal transaction As DbTransaction, Cotizacion As IUniqueIdentifiable) As GuiasObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Guias_GetByCotizacion", Cotizacion.Identifier())
        End Function
    
        ''' <summary>
        ''' Get a GuiasObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByFactura(ByVal transaction As DbTransaction, ByVal IdFactura As System.Int32) As GuiasObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Guias_GetByFactura", IdFactura)
        End Function

        ''' <summary>
        ''' Get a GuiasObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByFactura(ByVal transaction As DbTransaction, Factura As IUniqueIdentifiable) As GuiasObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Guias_GetByFactura", Factura.Identifier())
        End Function
    
        ''' <summary>
        ''' Get a GuiasObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByTransportista(ByVal transaction As DbTransaction, ByVal IdTransportista As System.Int32) As GuiasObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Guias_GetByTransportista", IdTransportista)
        End Function

        ''' <summary>
        ''' Get a GuiasObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByTransportista(ByVal transaction As DbTransaction, Transportista As IUniqueIdentifiable) As GuiasObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Guias_GetByTransportista", Transportista.Identifier())
        End Function
    


        
        ''' <summary>
        ''' Get a GuiasObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByAlmacenes(ByVal IdAlmacen As System.Int32) As GuiasObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Guias_GetByAlmacenes", IdAlmacen)
        End Function

        ''' <summary>
        ''' Get a GuiasObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByAlmacenes(Almacenes As IUniqueIdentifiable) As GuiasObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Guias_GetByAlmacenes", Almacenes.Identifier())
        End Function
    
        ''' <summary>
        ''' Get a GuiasObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByClientes(ByVal IdCliente As System.Int32) As GuiasObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Guias_GetByClientes", IdCliente)
        End Function

        ''' <summary>
        ''' Get a GuiasObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByClientes(Clientes As IUniqueIdentifiable) As GuiasObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Guias_GetByClientes", Clientes.Identifier())
        End Function
    
        ''' <summary>
        ''' Get a GuiasObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByCotizacion(ByVal IdCoti As System.Int32) As GuiasObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Guias_GetByCotizacion", IdCoti)
        End Function

        ''' <summary>
        ''' Get a GuiasObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByCotizacion(Cotizacion As IUniqueIdentifiable) As GuiasObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Guias_GetByCotizacion", Cotizacion.Identifier())
        End Function
    
        ''' <summary>
        ''' Get a GuiasObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByFactura(ByVal IdFactura As System.Int32) As GuiasObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Guias_GetByFactura", IdFactura)
        End Function

        ''' <summary>
        ''' Get a GuiasObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByFactura(Factura As IUniqueIdentifiable) As GuiasObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Guias_GetByFactura", Factura.Identifier())
        End Function
    
        ''' <summary>
        ''' Get a GuiasObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByTransportista(ByVal IdTransportista As System.Int32) As GuiasObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Guias_GetByTransportista", IdTransportista)
        End Function

        ''' <summary>
        ''' Get a GuiasObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByTransportista(Transportista As IUniqueIdentifiable) As GuiasObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Guias_GetByTransportista", Transportista.Identifier())
        End Function
    

        
        ''' <summary>
        ''' Delete Guias 
        ''' </summary>
        Public Overloads Sub Delete(ByVal IdGuias As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Guias_Delete", IdGuias)
        End Sub

        ''' <summary>
        ''' Delete Guias
        ''' </summary>
        Public Overloads Sub Delete(transaction As DbTransaction , ByVal IdGuias As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Guias_Delete", IdGuias)
        End Sub

            



        

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

    

        ''' <summary>
        ''' Delete Guias By Almacenes
        ''' </summary>
        Public Overloads Sub DeleteByAlmacenes(ByVal IdAlmacen As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Guias_DeleteByAlmacenes", IdAlmacen)
        End Sub

        ''' <summary>
        ''' Delete Guias By Almacenes
        ''' </summary>
        Public Overloads Sub DeleteByAlmacenes(ByVal transaction As DbTransaction , ByVal IdAlmacen As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Guias_DeleteByAlmacenes", IdAlmacen)
        End Sub

        ''' <summary>
        ''' Delete Guias By Almacenes
        ''' </summary>
        Public Overloads Sub DeleteByAlmacenes(ByVal Almacenes As IUniqueIdentifiable )
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Guias_DeleteByAlmacenes", Almacenes.Identifier())
        End Sub

        ''' <summary>
        ''' Delete Guias By Almacenes
        ''' </summary>
        Public Overloads Sub DeleteByAlmacenes(ByVal transaction As DbTransaction , ByVal Almacenes As IUniqueIdentifiable)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Guias_DeleteByAlmacenes", Almacenes.Identifier())
        End Sub

        

    

        ''' <summary>
        ''' Delete Guias By Clientes
        ''' </summary>
        Public Overloads Sub DeleteByClientes(ByVal IdCliente As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Guias_DeleteByClientes", IdCliente)
        End Sub

        ''' <summary>
        ''' Delete Guias By Clientes
        ''' </summary>
        Public Overloads Sub DeleteByClientes(ByVal transaction As DbTransaction , ByVal IdCliente As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Guias_DeleteByClientes", IdCliente)
        End Sub

        ''' <summary>
        ''' Delete Guias By Clientes
        ''' </summary>
        Public Overloads Sub DeleteByClientes(ByVal Clientes As IUniqueIdentifiable )
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Guias_DeleteByClientes", Clientes.Identifier())
        End Sub

        ''' <summary>
        ''' Delete Guias By Clientes
        ''' </summary>
        Public Overloads Sub DeleteByClientes(ByVal transaction As DbTransaction , ByVal Clientes As IUniqueIdentifiable)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Guias_DeleteByClientes", Clientes.Identifier())
        End Sub

        

    

        ''' <summary>
        ''' Delete Guias By Cotizacion
        ''' </summary>
        Public Overloads Sub DeleteByCotizacion(ByVal IdCoti As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Guias_DeleteByCotizacion", IdCoti)
        End Sub

        ''' <summary>
        ''' Delete Guias By Cotizacion
        ''' </summary>
        Public Overloads Sub DeleteByCotizacion(ByVal transaction As DbTransaction , ByVal IdCoti As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Guias_DeleteByCotizacion", IdCoti)
        End Sub

        ''' <summary>
        ''' Delete Guias By Cotizacion
        ''' </summary>
        Public Overloads Sub DeleteByCotizacion(ByVal Cotizacion As IUniqueIdentifiable )
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Guias_DeleteByCotizacion", Cotizacion.Identifier())
        End Sub

        ''' <summary>
        ''' Delete Guias By Cotizacion
        ''' </summary>
        Public Overloads Sub DeleteByCotizacion(ByVal transaction As DbTransaction , ByVal Cotizacion As IUniqueIdentifiable)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Guias_DeleteByCotizacion", Cotizacion.Identifier())
        End Sub

        

    

        ''' <summary>
        ''' Delete Guias By Factura
        ''' </summary>
        Public Overloads Sub DeleteByFactura(ByVal IdFactura As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Guias_DeleteByFactura", IdFactura)
        End Sub

        ''' <summary>
        ''' Delete Guias By Factura
        ''' </summary>
        Public Overloads Sub DeleteByFactura(ByVal transaction As DbTransaction , ByVal IdFactura As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Guias_DeleteByFactura", IdFactura)
        End Sub

        ''' <summary>
        ''' Delete Guias By Factura
        ''' </summary>
        Public Overloads Sub DeleteByFactura(ByVal Factura As IUniqueIdentifiable )
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Guias_DeleteByFactura", Factura.Identifier())
        End Sub

        ''' <summary>
        ''' Delete Guias By Factura
        ''' </summary>
        Public Overloads Sub DeleteByFactura(ByVal transaction As DbTransaction , ByVal Factura As IUniqueIdentifiable)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Guias_DeleteByFactura", Factura.Identifier())
        End Sub

        

    

        ''' <summary>
        ''' Delete Guias By Transportista
        ''' </summary>
        Public Overloads Sub DeleteByTransportista(ByVal IdTransportista As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Guias_DeleteByTransportista", IdTransportista)
        End Sub

        ''' <summary>
        ''' Delete Guias By Transportista
        ''' </summary>
        Public Overloads Sub DeleteByTransportista(ByVal transaction As DbTransaction , ByVal IdTransportista As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Guias_DeleteByTransportista", IdTransportista)
        End Sub

        ''' <summary>
        ''' Delete Guias By Transportista
        ''' </summary>
        Public Overloads Sub DeleteByTransportista(ByVal Transportista As IUniqueIdentifiable )
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Guias_DeleteByTransportista", Transportista.Identifier())
        End Sub

        ''' <summary>
        ''' Delete Guias By Transportista
        ''' </summary>
        Public Overloads Sub DeleteByTransportista(ByVal transaction As DbTransaction , ByVal Transportista As IUniqueIdentifiable)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Guias_DeleteByTransportista", Transportista.Identifier())
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




