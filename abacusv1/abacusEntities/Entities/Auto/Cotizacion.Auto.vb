
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 20/08/2013 - 01:49 p.m.
' This is a partial class file. The other one is CotizacionEntity.cs
' You should not modifiy this file, please edit the other partial class file.
'------------------------------------------------------------------------------

Imports abacusRules.Objects


Imports Cooperator.Framework.Core
Imports Cooperator.Framework.Core.LazyLoad
Imports System

Namespace Entities

    Public Partial Class Cotizacion
        Inherits Objects.CotizacionObject
        Implements IMappeableCotizacion
        Implements IEquatable(Of Cotizacion)
        Implements ICloneable

        #Region "Ctor"

        Public Sub New()
            MyBase.New()
            
        End Sub

        
        Public Sub New (ByVal IdCoti As System.Int32)
            MyBase.New()

			_IdCoti = IdCoti

            
            Call Initialized()
        End Sub
        

        
        Public Sub New(ByVal IdCoti As System.Int32, _
			ByVal IdTrabjador As System.Nullable(Of System.Int32), _
			ByVal Año As System.Nullable(Of System.DateTime), _
			ByVal Numero As System.Nullable(Of System.Int32), _
			ByVal IdCliente As System.Nullable(Of System.Int32), _
			ByVal FPago As System.Nullable(Of System.Int32), _
			ByVal FecEmision As System.Nullable(Of System.DateTime), _
			ByVal Referencia As System.String, _
			ByVal Atencion As System.String, _
			ByVal Moneda As System.String, _
			ByVal TC As System.Nullable(Of System.Decimal), _
			ByVal Garantia As System.String, _
			ByVal TiempoEntrega As System.String, _
			ByVal IdVendedor As System.Nullable(Of System.Int32), _
			ByVal Nota As System.String, _
			ByVal upsize_ts As System.Nullable(Of System.DateTime), _
			ByVal ClientesString As System.String, _
			ByVal TrabajadoresString As System.String)
            MyBase.New()

			_IdCoti = IdCoti
			_IdTrabjador = IdTrabjador
			_Año = Año
			_Numero = Numero
			_IdCliente = IdCliente
			_FPago = FPago
			_FecEmision = FecEmision
			_Referencia = Referencia
			_Atencion = Atencion
			_Moneda = Moneda
			_TC = TC
			_Garantia = Garantia
			_TiempoEntrega = TiempoEntrega
			_IdVendedor = IdVendedor
			_Nota = Nota
			_upsize_ts = upsize_ts
			_ClientesString = ClientesString
			_TrabajadoresString = TrabajadoresString

            
            Call Initialized()
        End Sub
        
        #End Region

        #Region "Fields"

        Protected  _ClientesEntity As Objects.ClientesObject
Protected  _TrabajadoresEntity As Objects.TrabajadoresObject

        #End Region

        #Region "Properties"
        
Dim _ClientesEntityFetched As Boolean
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property ClientesEntity As Objects.ClientesObject
            Get
                If _ClientesEntity Is Nothing  AndAlso Me.IdCliente.HasValue AndAlso Not _ClientesEntityFetched  Then
_ClientesEntityFetched = True
Dim _ClientesEntityTemp As Objects.ClientesObject = New Objects.ClientesObject(Me.IdCliente.Value) 
Dim lazyProvider As ILazyProvider = LazyProviderFactory.Get(GetType(Objects.ClientesObject))
 _ClientesEntity = CType(lazyProvider.GetEntity(GetType(Objects.ClientesObject), _ClientesEntityTemp), Objects.ClientesObject)
End If

                Return _ClientesEntity
            End Get
            Set (value As Objects.ClientesObject)
                MyBase.PropertyModified()
                _ClientesEntity = value
                If value IsNot Nothing Then
   _IdCliente = value.IdCliente
If value.Nombre IsNot Nothing Then 
_ClientesString = value.Nombre.ToString() 
Else
    _ClientesString = "" 
End If

Else 
   _IdCliente = Nothing
_ClientesString = ""
End If

                            CorrectDescriptionField(value)


            End Set
        End Property
        
Dim _TrabajadoresEntityFetched As Boolean
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property TrabajadoresEntity As Objects.TrabajadoresObject
            Get
                If _TrabajadoresEntity Is Nothing  AndAlso Me.IdTrabjador.HasValue AndAlso Not _TrabajadoresEntityFetched  Then
_TrabajadoresEntityFetched = True
Dim _TrabajadoresEntityTemp As Objects.TrabajadoresObject = New Objects.TrabajadoresObject(Me.IdTrabjador.Value) 
Dim lazyProvider As ILazyProvider = LazyProviderFactory.Get(GetType(Objects.TrabajadoresObject))
 _TrabajadoresEntity = CType(lazyProvider.GetEntity(GetType(Objects.TrabajadoresObject), _TrabajadoresEntityTemp), Objects.TrabajadoresObject)
End If

                Return _TrabajadoresEntity
            End Get
            Set (value As Objects.TrabajadoresObject)
                MyBase.PropertyModified()
                _TrabajadoresEntity = value
                If value IsNot Nothing Then
   _IdTrabjador = value.IdTrabjador
If value.Nombres IsNot Nothing Then 
_TrabajadoresString = value.Nombres.ToString() 
Else
    _TrabajadoresString = "" 
End If

Else 
   _IdTrabjador = Nothing
_TrabajadoresString = ""
End If

                            CorrectDescriptionField(value)


            End Set
        End Property
        
        #End Region

        ''' <summary>
        ''' Returns de original value of entity since was created or restored. 
        ''' </summary>
        Public Shadows Function OriginalValue() As Cotizacion 
                Return CType(MyBase.OriginalValue, Cotizacion)
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Protected Overrides Function Clone() As Object 
            Dim newObject As Cotizacion 
            

            newObject = CType(Me.MemberwiseClone(), Cotizacion)
            ' Entities
                         
            If Me._ClientesEntity IsNot Nothing Then
                newObject._ClientesEntity = CType(CType(Me._ClientesEntity, ICloneable).Clone(),Objects.ClientesObject)
            End If
                         
            If Me._TrabajadoresEntity IsNot Nothing Then
                newObject._TrabajadoresEntity = CType(CType(Me._TrabajadoresEntity, ICloneable).Clone(),Objects.TrabajadoresObject)
            End If
            
            ' Colections
            
            ' OriginalValue
            Dim newOriginalValue As Cotizacion
            If MyBase.InternalOriginalValue IsNot Nothing Then
                newOriginalValue = CType(Me.OriginalValue().MemberwiseClone(), Cotizacion)
                ' Entities
                             
                If Me.OriginalValue()._ClientesEntity IsNot Nothing Then
                    newOriginalValue._ClientesEntity = CType(CType(Me.OriginalValue()._ClientesEntity, ICloneable).Clone(), Objects.ClientesObject)
                End If
                             
                If Me.OriginalValue()._TrabajadoresEntity IsNot Nothing Then
                    newOriginalValue._TrabajadoresEntity = CType(CType(Me.OriginalValue()._TrabajadoresEntity, ICloneable).Clone(), Objects.TrabajadoresObject)
                End If
                
                ' Colections
                            
                newObject.InternalOriginalValue = newOriginalValue

            End If
            Return newObject
        End Function



        Private Sub CompleteEntity(ClientesEntity As Objects.ClientesObject, TrabajadoresEntity As Objects.TrabajadoresObject) Implements IMappeableCotizacion.CompleteEntity
        _ClientesEntity = ClientesEntity
_TrabajadoresEntity = TrabajadoresEntity
        End Sub

        
        Private Function IsClientesEntityNull() As Boolean Implements IMappeableCotizacion.IsClientesEntityNull
            Return IsNothing(_ClientesEntity)
        End Function
        
        Private Function IsTrabajadoresEntityNull() As Boolean Implements IMappeableCotizacion.IsTrabajadoresEntityNull
            Return IsNothing(_TrabajadoresEntity)
        End Function
        

        Private Sub SetFKValuesForChilds(entity As Cotizacion) Implements IMappeableCotizacion.SetFKValuesForChilds
                
        End Sub

        Public Overloads Function Equals(other As Cotizacion) As Boolean Implements IEquatable(Of Cotizacion).Equals
            Return UniqueIdentifierHelper.IsSameObject(CType(Me, IUniqueIdentifiable), CType(other, IUniqueIdentifiable))
        End Function

    End Class

    Public Interface IMappeableCotizacion
        Sub CompleteEntity(ClientesEntity As Objects.ClientesObject, TrabajadoresEntity As Objects.TrabajadoresObject)
        
        Function IsClientesEntityNull() As Boolean
        
        Function IsTrabajadoresEntityNull() As Boolean
        
        Sub SetFKValuesForChilds(entity As Cotizacion )
    End Interface

    Public Partial Class CotizacionList
        Inherits ObjectList(Of Cotizacion)    
    End Class
End Namespace

Namespace Views
    Partial Public Class CotizacionListView
        Inherits ObjectListView(Of Entities.Cotizacion)

        Sub New(ByVal list As Entities.CotizacionList)
            MyBase.New(list)
        End Sub
    End Class
End NameSpace

