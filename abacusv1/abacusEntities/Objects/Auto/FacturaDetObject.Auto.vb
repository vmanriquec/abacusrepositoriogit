
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 20/08/2013 - 01:48 p.m.
' This is a Partial class file. The other one is FacturaDetObject.vb
' You should not modifiy this file, please edit the other partial class file.
'------------------------------------------------------------------------------

Imports Cooperator.Framework.Core
Imports System

Namespace Objects

    Public Partial Class FacturaDetObject
        Inherits BaseObject
        Implements IMappeableFacturaDetObject
        Implements IUniqueIdentifiable
        Implements IEquatable(Of FacturaDetObject)
        Implements ICloneable

#Region "Ctor"

        Public Sub New()
            MyBase.New()

			_IdFactDet =  ValuesGenerator.GetInt32

        End Sub

        
        Public Sub New(ByVal IdFactDet As System.Int32)
            MyBase.New()

			_IdFactDet = IdFactDet

            Call Initialized()
        End Sub
        

        
        Public Sub New(ByVal IdFactDet As System.Int32, _
			ByVal IdFactura As System.Nullable(Of System.Int32), _
			ByVal Codigo As System.Nullable(Of System.Int32), _
			ByVal Producto As System.Nullable(Of System.Int32), _
			ByVal Cantidad As System.Nullable(Of System.Int32), _
			ByVal PUnitario As System.Nullable(Of System.Decimal), _
			ByVal Dscto As System.Nullable(Of System.Decimal), _
			ByVal upsize_ts As System.Nullable(Of System.DateTime), _
			ByVal FacturaString As System.String)
            MyBase.New()

			_IdFactDet = IdFactDet
			_IdFactura = IdFactura
			_Codigo = Codigo
			_Producto = Producto
			_Cantidad = Cantidad
			_PUnitario = PUnitario
			_Dscto = Dscto
			_upsize_ts = upsize_ts
			_FacturaString = FacturaString

            Call Initialized()
        End Sub
        

#End Region

#Region "Events"

        
        Public Event Update_FacturaString(ByVal sender As Object, ByVal e As DescriptionFieldEventArg)
        
#End Region

#Region "Fields"

        Protected _IdFactDet As System.Int32
Protected _IdFactura As System.Nullable(Of System.Int32) 
Protected _Codigo As System.Nullable(Of System.Int32) 
Protected _Producto As System.Nullable(Of System.Int32) 
Protected _Cantidad As System.Nullable(Of System.Int32) 
Protected _PUnitario As System.Nullable(Of System.Decimal) 
Protected _Dscto As System.Nullable(Of System.Decimal) 
Protected _upsize_ts As System.Nullable(Of System.DateTime) 
Protected _FacturaString As System.String

#End Region

#Region "Properties"
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable ReadOnly Property IdFactDet As System.Int32
            Get
                Return _IdFactDet
            End Get
            
        End Property
        
        ''' <summary>
        ''' Nullable property
        ''' </summary>
        Public Overridable Property IdFactura As System.Nullable(Of System.Int32) 
            Get        
                Return _IdFactura
            End Get
            
            Set
                MyBase.PropertyModified()
                _IdFactura = value
                
                   If value.HasValue Then 
                    Dim e As DescriptionFieldEventArg = New DescriptionFieldEventArg(New FacturaObject (_IdFactura.Value))
                    RaiseEvent Update_FacturaString(Me, e)
                    _FacturaString = e.DescriptionString
                   End If 
                
            End Set
            
        End Property
                
        ''' <summary>
        ''' Nullable property
        ''' </summary>
        Public Overridable Property Codigo As System.Nullable(Of System.Int32) 
            Get        
                Return _Codigo
            End Get
            
            Set
                MyBase.PropertyModified()
                _Codigo = value
                
            End Set
            
        End Property
                
        ''' <summary>
        ''' Nullable property
        ''' </summary>
        Public Overridable Property Producto As System.Nullable(Of System.Int32) 
            Get        
                Return _Producto
            End Get
            
            Set
                MyBase.PropertyModified()
                _Producto = value
                
            End Set
            
        End Property
                
        ''' <summary>
        ''' Nullable property
        ''' </summary>
        Public Overridable Property Cantidad As System.Nullable(Of System.Int32) 
            Get        
                Return _Cantidad
            End Get
            
            Set
                MyBase.PropertyModified()
                _Cantidad = value
                
            End Set
            
        End Property
                
        ''' <summary>
        ''' Nullable property
        ''' </summary>
        Public Overridable Property PUnitario As System.Nullable(Of System.Decimal) 
            Get        
                Return _PUnitario
            End Get
            
            Set
                MyBase.PropertyModified()
                _PUnitario = value
                
            End Set
            
        End Property
                
        ''' <summary>
        ''' Nullable property
        ''' </summary>
        Public Overridable Property Dscto As System.Nullable(Of System.Decimal) 
            Get        
                Return _Dscto
            End Get
            
            Set
                MyBase.PropertyModified()
                _Dscto = value
                
            End Set
            
        End Property
                
        ''' <summary>
        ''' Nullable property
        ''' </summary>
        Public Overridable Property upsize_ts As System.Nullable(Of System.DateTime) 
            Get        
                Return _upsize_ts
            End Get
            
            Set
                MyBase.PropertyModified()
                _upsize_ts = value
                
            End Set
            
        End Property
                
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable ReadOnly Property FacturaString As System.String
            Get
                Return _FacturaString
            End Get
            
        End Property
        
        #End Region

        

        Protected Overrides Sub SetOriginalValue()
            MyBase.InternalOriginalValue = CType(Me.MemberwiseClone(), IObject)
        End Sub

        Protected Overridable Function Clone() As Object Implements ICloneable.Clone
            Dim newObject As FacturaDetObject 
            Dim newOriginalValue As FacturaDetObject 

            newObject = CType(Me.MemberwiseClone(), FacturaDetObject) 
            If (MyBase.InternalOriginalValue IsNot Nothing) Then
                newOriginalValue = CType(Me.OriginalValue().MemberwiseClone(), FacturaDetObject)
                newObject.InternalOriginalValue = newOriginalValue
            End If
            Return newObject
        End Function


        ''' <summary>
        ''' Returns de original value of object since was created or restored.
        ''' </summary>
        Public Shadows Function OriginalValue() As FacturaDetObject 
           Return CType(MyBase.OriginalValue, FacturaDetObject)
        End Function


        Private Sub HydrateFields(ByVal IdFactDet As System.Int32, _
			ByVal IdFactura As System.Nullable(Of System.Int32) , _
			ByVal Codigo As System.Nullable(Of System.Int32) , _
			ByVal Producto As System.Nullable(Of System.Int32) , _
			ByVal Cantidad As System.Nullable(Of System.Int32) , _
			ByVal PUnitario As System.Nullable(Of System.Decimal) , _
			ByVal Dscto As System.Nullable(Of System.Decimal) , _
			ByVal upsize_ts As System.Nullable(Of System.DateTime) , _
			ByVal FacturaString As System.String) Implements IMappeableFacturaDetObject.HydrateFields        
        	_IdFactDet = IdFactDet
			_IdFactura = IdFactura
			_Codigo = Codigo
			_Producto = Producto
			_Cantidad = Cantidad
			_PUnitario = PUnitario
			_Dscto = Dscto
			_upsize_ts = upsize_ts
			_FacturaString = FacturaString
        End Sub

        Private Function GetFieldsForInsert() As Object() Implements IMappeableFacturaDetObject.GetFieldsForInsert
        
        
            Dim _myArray(7) As Object
            _myArray(0) = _IdFactDet
			If (_IdFactura.HasValue) Then _myArray(1) = _IdFactura.Value
			If (_Codigo.HasValue) Then _myArray(2) = _Codigo.Value
			If (_Producto.HasValue) Then _myArray(3) = _Producto.Value
			If (_Cantidad.HasValue) Then _myArray(4) = _Cantidad.Value
			If (_PUnitario.HasValue) Then _myArray(5) = _PUnitario.Value
			If (_Dscto.HasValue) Then _myArray(6) = _Dscto.Value
			If (_upsize_ts.HasValue) Then _myArray(7) = _upsize_ts.Value
			
            Return _myArray
        
        End Function

        Private Function GetFieldsForUpdate() As Object() Implements IMappeableFacturaDetObject.GetFieldsForUpdate
        
        
            
            Dim _myArray(7) As Object
            _myArray(0) = _IdFactDet
			If (_IdFactura.HasValue) Then _myArray(1) = _IdFactura.Value
			If (_Codigo.HasValue) Then _myArray(2) = _Codigo.Value
			If (_Producto.HasValue) Then _myArray(3) = _Producto.Value
			If (_Cantidad.HasValue) Then _myArray(4) = _Cantidad.Value
			If (_PUnitario.HasValue) Then _myArray(5) = _PUnitario.Value
			If (_Dscto.HasValue) Then _myArray(6) = _Dscto.Value
			If (_upsize_ts.HasValue) Then _myArray(7) = _upsize_ts.Value
			
            Return _myArray
        
        End Function

        Private Function GetFieldsForDelete() As Object() Implements IMappeableFacturaDetObject.GetFieldsForDelete
        
            Dim _myArray(0) As Object
            _myArray(0) = _IdFactDet
			
            Return _myArray
        
        End Function


        Private Sub UpdateObjectFromOutputParams(parameters As Object()) Implements IMappeableFacturaDetObject.UpdateObjectFromOutputParams
            ' Update properties from Output parameters
            _IdFactDet = CType(parameters(0), System.Int32)

        End Sub

        Private Function Identifier() As Object() Implements IUniqueIdentifiable.Identifier
            Dim o As FacturaDetObject = Nothing
            If ObjectStateHelper.IsModified(Me) Then
                o = Me.OriginalValue()
            Else
                o = Me
            End If

            Return New Object() {o.IdFactDet}
        End Function


        Public Overloads Function Equals(other As FacturaDetObject) As Boolean Implements IEquatable(Of FacturaDetObject).Equals
            Return UniqueIdentifierHelper.IsSameObject(CType(Me, IUniqueIdentifiable), CType(other, IUniqueIdentifiable))
        End Function


    End Class

    Public Interface IMappeableFacturaDetObject
        Sub HydrateFields( ByVal IdFactDet As System.Int32, _
				 ByVal IdFactura As System.Nullable(Of System.Int32) , _
				 ByVal Codigo As System.Nullable(Of System.Int32) , _
				 ByVal Producto As System.Nullable(Of System.Int32) , _
				 ByVal Cantidad As System.Nullable(Of System.Int32) , _
				 ByVal PUnitario As System.Nullable(Of System.Decimal) , _
				 ByVal Dscto As System.Nullable(Of System.Decimal) , _
				 ByVal upsize_ts As System.Nullable(Of System.DateTime) , _
				 ByVal FacturaString As System.String)

        Function GetFieldsForInsert() As Object() 

        Function GetFieldsForUpdate() As Object() 

        Function GetFieldsForDelete() As Object()

        Sub UpdateObjectFromOutputParams(ByVal parameters As Object() )
    End Interface

    Public Partial Class FacturaDetObjectList
        Inherits ObjectList(Of FacturaDetObject)
    End Class
End Namespace

Namespace Views
    Partial Public Class FacturaDetObjectListView
        Inherits ObjectListView(Of Objects.FacturaDetObject)

        Sub New(ByVal list As Objects.FacturaDetObjectList)
            MyBase.New(list)
        End Sub
    End Class
End NameSpace


