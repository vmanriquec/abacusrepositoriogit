
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 20/08/2013 - 01:48 p.m.
' This is a Partial class file. The other one is ProductosObject.vb
' You should not modifiy this file, please edit the other partial class file.
'------------------------------------------------------------------------------

Imports Cooperator.Framework.Core
Imports System

Namespace Objects

    Public Partial Class ProductosObject
        Inherits BaseObject
        Implements IMappeableProductosObject
        Implements IUniqueIdentifiable
        Implements IEquatable(Of ProductosObject)
        Implements ICloneable

#Region "Ctor"

        Public Sub New()
            MyBase.New()

			_IdProducto =  ValuesGenerator.GetInt32

        End Sub

        
        Public Sub New(ByVal IdProducto As System.Int32)
            MyBase.New()

			_IdProducto = IdProducto

            Call Initialized()
        End Sub
        

        
        Public Sub New(ByVal IdProducto As System.Int32, _
			ByVal IdProveedor As System.Nullable(Of System.Int32), _
			ByVal Id_TipoProducto As System.Nullable(Of System.Int32), _
			ByVal CodProducto As System.String, _
			ByVal Producto As System.String, _
			ByVal TipoProducto As System.Nullable(Of System.Int32), _
			ByVal Capacidad As System.String, _
			ByVal UMedida As System.String, _
			ByVal NumParte As System.String, _
			ByVal Familia As System.Nullable(Of System.Int32), _
			ByVal Categoria As System.Nullable(Of System.Int32), _
			ByVal Observaciones As System.String, _
			ByVal IdProveedores As System.String, _
			ByVal ImagenProd As System.String, _
			ByVal PrecioCosto As System.Nullable(Of System.Decimal), _
			ByVal MonedaC As System.Nullable(Of System.Int32), _
			ByVal PrecioVenta As System.Nullable(Of System.Decimal), _
			ByVal MonedaV As System.Nullable(Of System.Int32), _
			ByVal upsize_ts As System.Nullable(Of System.DateTime), _
			ByVal fechaingreso As System.Nullable(Of System.DateTime), _
			ByVal fechadecaducidad As System.Nullable(Of System.DateTime), _
			ByVal estado As System.String, _
			ByVal fotoproducto As System.Byte(), _
			ByVal ProveedoresString As System.String, _
			ByVal TipoProductoString As System.String)
            MyBase.New()

			_IdProducto = IdProducto
			_IdProveedor = IdProveedor
			_Id_TipoProducto = Id_TipoProducto
			_CodProducto = CodProducto
			_Producto = Producto
			_TipoProducto = TipoProducto
			_Capacidad = Capacidad
			_UMedida = UMedida
			_NumParte = NumParte
			_Familia = Familia
			_Categoria = Categoria
			_Observaciones = Observaciones
			_IdProveedores = IdProveedores
			_ImagenProd = ImagenProd
			_PrecioCosto = PrecioCosto
			_MonedaC = MonedaC
			_PrecioVenta = PrecioVenta
			_MonedaV = MonedaV
			_upsize_ts = upsize_ts
			_fechaingreso = fechaingreso
			_fechadecaducidad = fechadecaducidad
			_estado = estado
			_fotoproducto = fotoproducto
			_ProveedoresString = ProveedoresString
			_TipoProductoString = TipoProductoString

            Call Initialized()
        End Sub
        

#End Region

#Region "Events"

        
        Public Event Update_ProveedoresString(ByVal sender As Object, ByVal e As DescriptionFieldEventArg)
        
        Public Event Update_TipoProductoString(ByVal sender As Object, ByVal e As DescriptionFieldEventArg)
        
#End Region

#Region "Fields"

        Protected _IdProducto As System.Int32
Protected _IdProveedor As System.Nullable(Of System.Int32) 
Protected _Id_TipoProducto As System.Nullable(Of System.Int32) 
Protected _CodProducto As System.String
Protected _Producto As System.String
Protected _TipoProducto As System.Nullable(Of System.Int32) 
Protected _Capacidad As System.String
Protected _UMedida As System.String
Protected _NumParte As System.String
Protected _Familia As System.Nullable(Of System.Int32) 
Protected _Categoria As System.Nullable(Of System.Int32) 
Protected _Observaciones As System.String
Protected _IdProveedores As System.String
Protected _ImagenProd As System.String
Protected _PrecioCosto As System.Nullable(Of System.Decimal) 
Protected _MonedaC As System.Nullable(Of System.Int32) 
Protected _PrecioVenta As System.Nullable(Of System.Decimal) 
Protected _MonedaV As System.Nullable(Of System.Int32) 
Protected _upsize_ts As System.Nullable(Of System.DateTime) 
Protected _fechaingreso As System.Nullable(Of System.DateTime) 
Protected _fechadecaducidad As System.Nullable(Of System.DateTime) 
Protected _estado As System.String
Protected _fotoproducto As System.Byte()
Protected _ProveedoresString As System.String
Protected _TipoProductoString As System.String

#End Region

#Region "Properties"
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable ReadOnly Property IdProducto As System.Int32
            Get
                Return _IdProducto
            End Get
            
        End Property
        
        ''' <summary>
        ''' Nullable property
        ''' </summary>
        Public Overridable Property IdProveedor As System.Nullable(Of System.Int32) 
            Get        
                Return _IdProveedor
            End Get
            
            Set
                MyBase.PropertyModified()
                _IdProveedor = value
                
                   If value.HasValue Then 
                    Dim e As DescriptionFieldEventArg = New DescriptionFieldEventArg(New ProveedoresObject (_IdProveedor.Value))
                    RaiseEvent Update_ProveedoresString(Me, e)
                    _ProveedoresString = e.DescriptionString
                   End If 
                
            End Set
            
        End Property
                
        ''' <summary>
        ''' Nullable property
        ''' </summary>
        Public Overridable Property Id_TipoProducto As System.Nullable(Of System.Int32) 
            Get        
                Return _Id_TipoProducto
            End Get
            
            Set
                MyBase.PropertyModified()
                _Id_TipoProducto = value
                
                   If value.HasValue Then 
                    Dim e As DescriptionFieldEventArg = New DescriptionFieldEventArg(New TipoProductoObject (_Id_TipoProducto.Value))
                    RaiseEvent Update_TipoProductoString(Me, e)
                    _TipoProductoString = e.DescriptionString
                   End If 
                
            End Set
            
        End Property
                
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property CodProducto As System.String
            Get
                Return _CodProducto
            End Get
            
            Set
                MyBase.PropertyModified()
                _CodProducto = value
                
            End Set
            
        End Property
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property Producto As System.String
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
        Public Overridable Property TipoProducto As System.Nullable(Of System.Int32) 
            Get        
                Return _TipoProducto
            End Get
            
            Set
                MyBase.PropertyModified()
                _TipoProducto = value
                
            End Set
            
        End Property
                
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property Capacidad As System.String
            Get
                Return _Capacidad
            End Get
            
            Set
                MyBase.PropertyModified()
                _Capacidad = value
                
            End Set
            
        End Property
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property UMedida As System.String
            Get
                Return _UMedida
            End Get
            
            Set
                MyBase.PropertyModified()
                _UMedida = value
                
            End Set
            
        End Property
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property NumParte As System.String
            Get
                Return _NumParte
            End Get
            
            Set
                MyBase.PropertyModified()
                _NumParte = value
                
            End Set
            
        End Property
        
        ''' <summary>
        ''' Nullable property
        ''' </summary>
        Public Overridable Property Familia As System.Nullable(Of System.Int32) 
            Get        
                Return _Familia
            End Get
            
            Set
                MyBase.PropertyModified()
                _Familia = value
                
            End Set
            
        End Property
                
        ''' <summary>
        ''' Nullable property
        ''' </summary>
        Public Overridable Property Categoria As System.Nullable(Of System.Int32) 
            Get        
                Return _Categoria
            End Get
            
            Set
                MyBase.PropertyModified()
                _Categoria = value
                
            End Set
            
        End Property
                
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property Observaciones As System.String
            Get
                Return _Observaciones
            End Get
            
            Set
                MyBase.PropertyModified()
                _Observaciones = value
                
            End Set
            
        End Property
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property IdProveedores As System.String
            Get
                Return _IdProveedores
            End Get
            
            Set
                MyBase.PropertyModified()
                _IdProveedores = value
                
            End Set
            
        End Property
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property ImagenProd As System.String
            Get
                Return _ImagenProd
            End Get
            
            Set
                MyBase.PropertyModified()
                _ImagenProd = value
                
            End Set
            
        End Property
        
        ''' <summary>
        ''' Nullable property
        ''' </summary>
        Public Overridable Property PrecioCosto As System.Nullable(Of System.Decimal) 
            Get        
                Return _PrecioCosto
            End Get
            
            Set
                MyBase.PropertyModified()
                _PrecioCosto = value
                
            End Set
            
        End Property
                
        ''' <summary>
        ''' Nullable property
        ''' </summary>
        Public Overridable Property MonedaC As System.Nullable(Of System.Int32) 
            Get        
                Return _MonedaC
            End Get
            
            Set
                MyBase.PropertyModified()
                _MonedaC = value
                
            End Set
            
        End Property
                
        ''' <summary>
        ''' Nullable property
        ''' </summary>
        Public Overridable Property PrecioVenta As System.Nullable(Of System.Decimal) 
            Get        
                Return _PrecioVenta
            End Get
            
            Set
                MyBase.PropertyModified()
                _PrecioVenta = value
                
            End Set
            
        End Property
                
        ''' <summary>
        ''' Nullable property
        ''' </summary>
        Public Overridable Property MonedaV As System.Nullable(Of System.Int32) 
            Get        
                Return _MonedaV
            End Get
            
            Set
                MyBase.PropertyModified()
                _MonedaV = value
                
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
        ''' Nullable property
        ''' </summary>
        Public Overridable Property fechaingreso As System.Nullable(Of System.DateTime) 
            Get        
                Return _fechaingreso
            End Get
            
            Set
                MyBase.PropertyModified()
                _fechaingreso = value
                
            End Set
            
        End Property
                
        ''' <summary>
        ''' Nullable property
        ''' </summary>
        Public Overridable Property fechadecaducidad As System.Nullable(Of System.DateTime) 
            Get        
                Return _fechadecaducidad
            End Get
            
            Set
                MyBase.PropertyModified()
                _fechadecaducidad = value
                
            End Set
            
        End Property
                
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property estado As System.String
            Get
                Return _estado
            End Get
            
            Set
                MyBase.PropertyModified()
                _estado = value
                
            End Set
            
        End Property
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property fotoproducto As System.Byte()
            Get
                Return _fotoproducto
            End Get
            
            Set
                MyBase.PropertyModified()
                _fotoproducto = value
                
            End Set
            
        End Property
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable ReadOnly Property ProveedoresString As System.String
            Get
                Return _ProveedoresString
            End Get
            
        End Property
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable ReadOnly Property TipoProductoString As System.String
            Get
                Return _TipoProductoString
            End Get
            
        End Property
        
        #End Region

        

        Protected Overrides Sub SetOriginalValue()
            MyBase.InternalOriginalValue = CType(Me.MemberwiseClone(), IObject)
        End Sub

        Protected Overridable Function Clone() As Object Implements ICloneable.Clone
            Dim newObject As ProductosObject 
            Dim newOriginalValue As ProductosObject 

            newObject = CType(Me.MemberwiseClone(), ProductosObject) 
            If (MyBase.InternalOriginalValue IsNot Nothing) Then
                newOriginalValue = CType(Me.OriginalValue().MemberwiseClone(), ProductosObject)
                newObject.InternalOriginalValue = newOriginalValue
            End If
            Return newObject
        End Function


        ''' <summary>
        ''' Returns de original value of object since was created or restored.
        ''' </summary>
        Public Shadows Function OriginalValue() As ProductosObject 
           Return CType(MyBase.OriginalValue, ProductosObject)
        End Function


        Private Sub HydrateFields(ByVal IdProducto As System.Int32, _
			ByVal IdProveedor As System.Nullable(Of System.Int32) , _
			ByVal Id_TipoProducto As System.Nullable(Of System.Int32) , _
			ByVal CodProducto As System.String, _
			ByVal Producto As System.String, _
			ByVal TipoProducto As System.Nullable(Of System.Int32) , _
			ByVal Capacidad As System.String, _
			ByVal UMedida As System.String, _
			ByVal NumParte As System.String, _
			ByVal Familia As System.Nullable(Of System.Int32) , _
			ByVal Categoria As System.Nullable(Of System.Int32) , _
			ByVal Observaciones As System.String, _
			ByVal IdProveedores As System.String, _
			ByVal ImagenProd As System.String, _
			ByVal PrecioCosto As System.Nullable(Of System.Decimal) , _
			ByVal MonedaC As System.Nullable(Of System.Int32) , _
			ByVal PrecioVenta As System.Nullable(Of System.Decimal) , _
			ByVal MonedaV As System.Nullable(Of System.Int32) , _
			ByVal upsize_ts As System.Nullable(Of System.DateTime) , _
			ByVal fechaingreso As System.Nullable(Of System.DateTime) , _
			ByVal fechadecaducidad As System.Nullable(Of System.DateTime) , _
			ByVal estado As System.String, _
			ByVal fotoproducto As System.Byte(), _
			ByVal ProveedoresString As System.String, _
			ByVal TipoProductoString As System.String) Implements IMappeableProductosObject.HydrateFields        
        	_IdProducto = IdProducto
			_IdProveedor = IdProveedor
			_Id_TipoProducto = Id_TipoProducto
			_CodProducto = CodProducto
			_Producto = Producto
			_TipoProducto = TipoProducto
			_Capacidad = Capacidad
			_UMedida = UMedida
			_NumParte = NumParte
			_Familia = Familia
			_Categoria = Categoria
			_Observaciones = Observaciones
			_IdProveedores = IdProveedores
			_ImagenProd = ImagenProd
			_PrecioCosto = PrecioCosto
			_MonedaC = MonedaC
			_PrecioVenta = PrecioVenta
			_MonedaV = MonedaV
			_upsize_ts = upsize_ts
			_fechaingreso = fechaingreso
			_fechadecaducidad = fechadecaducidad
			_estado = estado
			_fotoproducto = fotoproducto
			_ProveedoresString = ProveedoresString
			_TipoProductoString = TipoProductoString
        End Sub

        Private Function GetFieldsForInsert() As Object() Implements IMappeableProductosObject.GetFieldsForInsert
        
        
            Dim _myArray(22) As Object
            _myArray(0) = _IdProducto
			If (_IdProveedor.HasValue) Then _myArray(1) = _IdProveedor.Value
			If (_Id_TipoProducto.HasValue) Then _myArray(2) = _Id_TipoProducto.Value
			If (Not System.String.IsNullOrEmpty(_CodProducto)) Then _myArray(3) = _CodProducto
			If (Not System.String.IsNullOrEmpty(_Producto)) Then _myArray(4) = _Producto
			If (_TipoProducto.HasValue) Then _myArray(5) = _TipoProducto.Value
			If (Not System.String.IsNullOrEmpty(_Capacidad)) Then _myArray(6) = _Capacidad
			If (Not System.String.IsNullOrEmpty(_UMedida)) Then _myArray(7) = _UMedida
			If (Not System.String.IsNullOrEmpty(_NumParte)) Then _myArray(8) = _NumParte
			If (_Familia.HasValue) Then _myArray(9) = _Familia.Value
			If (_Categoria.HasValue) Then _myArray(10) = _Categoria.Value
			If (Not System.String.IsNullOrEmpty(_Observaciones)) Then _myArray(11) = _Observaciones
			If (Not System.String.IsNullOrEmpty(_IdProveedores)) Then _myArray(12) = _IdProveedores
			If (Not System.String.IsNullOrEmpty(_ImagenProd)) Then _myArray(13) = _ImagenProd
			If (_PrecioCosto.HasValue) Then _myArray(14) = _PrecioCosto.Value
			If (_MonedaC.HasValue) Then _myArray(15) = _MonedaC.Value
			If (_PrecioVenta.HasValue) Then _myArray(16) = _PrecioVenta.Value
			If (_MonedaV.HasValue) Then _myArray(17) = _MonedaV.Value
			If (_upsize_ts.HasValue) Then _myArray(18) = _upsize_ts.Value
			If (_fechaingreso.HasValue) Then _myArray(19) = _fechaingreso.Value
			If (_fechadecaducidad.HasValue) Then _myArray(20) = _fechadecaducidad.Value
			If (Not System.String.IsNullOrEmpty(_estado)) Then _myArray(21) = _estado
			_myArray(22) = _fotoproducto
			
            Return _myArray
        
        End Function

        Private Function GetFieldsForUpdate() As Object() Implements IMappeableProductosObject.GetFieldsForUpdate
        
        
            
            Dim _myArray(22) As Object
            _myArray(0) = _IdProducto
			If (_IdProveedor.HasValue) Then _myArray(1) = _IdProveedor.Value
			If (_Id_TipoProducto.HasValue) Then _myArray(2) = _Id_TipoProducto.Value
			If (Not System.String.IsNullOrEmpty(_CodProducto)) Then _myArray(3) = _CodProducto
			If (Not System.String.IsNullOrEmpty(_Producto)) Then _myArray(4) = _Producto
			If (_TipoProducto.HasValue) Then _myArray(5) = _TipoProducto.Value
			If (Not System.String.IsNullOrEmpty(_Capacidad)) Then _myArray(6) = _Capacidad
			If (Not System.String.IsNullOrEmpty(_UMedida)) Then _myArray(7) = _UMedida
			If (Not System.String.IsNullOrEmpty(_NumParte)) Then _myArray(8) = _NumParte
			If (_Familia.HasValue) Then _myArray(9) = _Familia.Value
			If (_Categoria.HasValue) Then _myArray(10) = _Categoria.Value
			If (Not System.String.IsNullOrEmpty(_Observaciones)) Then _myArray(11) = _Observaciones
			If (Not System.String.IsNullOrEmpty(_IdProveedores)) Then _myArray(12) = _IdProveedores
			If (Not System.String.IsNullOrEmpty(_ImagenProd)) Then _myArray(13) = _ImagenProd
			If (_PrecioCosto.HasValue) Then _myArray(14) = _PrecioCosto.Value
			If (_MonedaC.HasValue) Then _myArray(15) = _MonedaC.Value
			If (_PrecioVenta.HasValue) Then _myArray(16) = _PrecioVenta.Value
			If (_MonedaV.HasValue) Then _myArray(17) = _MonedaV.Value
			If (_upsize_ts.HasValue) Then _myArray(18) = _upsize_ts.Value
			If (_fechaingreso.HasValue) Then _myArray(19) = _fechaingreso.Value
			If (_fechadecaducidad.HasValue) Then _myArray(20) = _fechadecaducidad.Value
			If (Not System.String.IsNullOrEmpty(_estado)) Then _myArray(21) = _estado
			_myArray(22) = _fotoproducto
			
            Return _myArray
        
        End Function

        Private Function GetFieldsForDelete() As Object() Implements IMappeableProductosObject.GetFieldsForDelete
        
            Dim _myArray(0) As Object
            _myArray(0) = _IdProducto
			
            Return _myArray
        
        End Function


        Private Sub UpdateObjectFromOutputParams(parameters As Object()) Implements IMappeableProductosObject.UpdateObjectFromOutputParams
            ' Update properties from Output parameters
            _IdProducto = CType(parameters(0), System.Int32)

        End Sub

        Private Function Identifier() As Object() Implements IUniqueIdentifiable.Identifier
            Dim o As ProductosObject = Nothing
            If ObjectStateHelper.IsModified(Me) Then
                o = Me.OriginalValue()
            Else
                o = Me
            End If

            Return New Object() {o.IdProducto}
        End Function


        Public Overloads Function Equals(other As ProductosObject) As Boolean Implements IEquatable(Of ProductosObject).Equals
            Return UniqueIdentifierHelper.IsSameObject(CType(Me, IUniqueIdentifiable), CType(other, IUniqueIdentifiable))
        End Function


    End Class

    Public Interface IMappeableProductosObject
        Sub HydrateFields( ByVal IdProducto As System.Int32, _
				 ByVal IdProveedor As System.Nullable(Of System.Int32) , _
				 ByVal Id_TipoProducto As System.Nullable(Of System.Int32) , _
				 ByVal CodProducto As System.String, _
				 ByVal Producto As System.String, _
				 ByVal TipoProducto As System.Nullable(Of System.Int32) , _
				 ByVal Capacidad As System.String, _
				 ByVal UMedida As System.String, _
				 ByVal NumParte As System.String, _
				 ByVal Familia As System.Nullable(Of System.Int32) , _
				 ByVal Categoria As System.Nullable(Of System.Int32) , _
				 ByVal Observaciones As System.String, _
				 ByVal IdProveedores As System.String, _
				 ByVal ImagenProd As System.String, _
				 ByVal PrecioCosto As System.Nullable(Of System.Decimal) , _
				 ByVal MonedaC As System.Nullable(Of System.Int32) , _
				 ByVal PrecioVenta As System.Nullable(Of System.Decimal) , _
				 ByVal MonedaV As System.Nullable(Of System.Int32) , _
				 ByVal upsize_ts As System.Nullable(Of System.DateTime) , _
				 ByVal fechaingreso As System.Nullable(Of System.DateTime) , _
				 ByVal fechadecaducidad As System.Nullable(Of System.DateTime) , _
				 ByVal estado As System.String, _
				 ByVal fotoproducto As System.Byte(), _
				 ByVal ProveedoresString As System.String, _
				 ByVal TipoProductoString As System.String)

        Function GetFieldsForInsert() As Object() 

        Function GetFieldsForUpdate() As Object() 

        Function GetFieldsForDelete() As Object()

        Sub UpdateObjectFromOutputParams(ByVal parameters As Object() )
    End Interface

    Public Partial Class ProductosObjectList
        Inherits ObjectList(Of ProductosObject)
    End Class
End Namespace

Namespace Views
    Partial Public Class ProductosObjectListView
        Inherits ObjectListView(Of Objects.ProductosObject)

        Sub New(ByVal list As Objects.ProductosObjectList)
            MyBase.New(list)
        End Sub
    End Class
End NameSpace

