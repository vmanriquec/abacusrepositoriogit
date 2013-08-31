
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 20/08/2013 - 01:48 p.m.
' This is a Partial class file. The other one is SalidasObject.vb
' You should not modifiy this file, please edit the other partial class file.
'------------------------------------------------------------------------------

Imports Cooperator.Framework.Core
Imports System

Namespace Objects

    Public Partial Class SalidasObject
        Inherits BaseObject
        Implements IMappeableSalidasObject
        Implements IUniqueIdentifiable
        Implements IEquatable(Of SalidasObject)
        Implements ICloneable

#Region "Ctor"

        Public Sub New()
            MyBase.New()

			_IdSalidasP =  ValuesGenerator.GetInt32

        End Sub

        
        Public Sub New(ByVal IdSalidasP As System.Int32)
            MyBase.New()

			_IdSalidasP = IdSalidasP

            Call Initialized()
        End Sub
        

        
        Public Sub New(ByVal IdSalidasP As System.Int32, _
			ByVal IdAlmacen As System.Nullable(Of System.Int32), _
			ByVal IdTrabjador As System.Nullable(Of System.Int32), _
			ByVal IdSalidas As System.Nullable(Of System.Int32), _
			ByVal IdTienda As System.Nullable(Of System.Int32), _
			ByVal Fecha As System.Nullable(Of System.DateTime), _
			ByVal TipDoc As System.Nullable(Of System.Int32), _
			ByVal Tipo As System.String, _
			ByVal Serie As System.String, _
			ByVal Numero As System.String, _
			ByVal IdCliente As System.Nullable(Of System.Int32), _
			ByVal Moneda As System.Nullable(Of System.Int32), _
			ByVal estado As System.String, _
			ByVal totalvalor As System.Nullable(Of System.Decimal), _
			ByVal AlmacenesString As System.String, _
			ByVal ClientesString As System.String, _
			ByVal TrabajadoresString As System.String)
            MyBase.New()

			_IdSalidasP = IdSalidasP
			_IdAlmacen = IdAlmacen
			_IdTrabjador = IdTrabjador
			_IdSalidas = IdSalidas
			_IdTienda = IdTienda
			_Fecha = Fecha
			_TipDoc = TipDoc
			_Tipo = Tipo
			_Serie = Serie
			_Numero = Numero
			_IdCliente = IdCliente
			_Moneda = Moneda
			_estado = estado
			_totalvalor = totalvalor
			_AlmacenesString = AlmacenesString
			_ClientesString = ClientesString
			_TrabajadoresString = TrabajadoresString

            Call Initialized()
        End Sub
        

#End Region

#Region "Events"

        
        Public Event Update_AlmacenesString(ByVal sender As Object, ByVal e As DescriptionFieldEventArg)
        
        Public Event Update_ClientesString(ByVal sender As Object, ByVal e As DescriptionFieldEventArg)
        
        Public Event Update_TrabajadoresString(ByVal sender As Object, ByVal e As DescriptionFieldEventArg)
        
#End Region

#Region "Fields"

        Protected _IdSalidasP As System.Int32
Protected _IdAlmacen As System.Nullable(Of System.Int32) 
Protected _IdTrabjador As System.Nullable(Of System.Int32) 
Protected _IdSalidas As System.Nullable(Of System.Int32) 
Protected _IdTienda As System.Nullable(Of System.Int32) 
Protected _Fecha As System.Nullable(Of System.DateTime) 
Protected _TipDoc As System.Nullable(Of System.Int32) 
Protected _Tipo As System.String
Protected _Serie As System.String
Protected _Numero As System.String
Protected _IdCliente As System.Nullable(Of System.Int32) 
Protected _Moneda As System.Nullable(Of System.Int32) 
Protected _estado As System.String
Protected _totalvalor As System.Nullable(Of System.Decimal) 
Protected _AlmacenesString As System.String
Protected _ClientesString As System.String
Protected _TrabajadoresString As System.String

#End Region

#Region "Properties"
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable ReadOnly Property IdSalidasP As System.Int32
            Get
                Return _IdSalidasP
            End Get
            
        End Property
        
        ''' <summary>
        ''' Nullable property
        ''' </summary>
        Public Overridable Property IdAlmacen As System.Nullable(Of System.Int32) 
            Get        
                Return _IdAlmacen
            End Get
            
            Set
                MyBase.PropertyModified()
                _IdAlmacen = value
                
                   If value.HasValue Then 
                    Dim e As DescriptionFieldEventArg = New DescriptionFieldEventArg(New AlmacenesObject (_IdAlmacen.Value))
                    RaiseEvent Update_AlmacenesString(Me, e)
                    _AlmacenesString = e.DescriptionString
                   End If 
                
            End Set
            
        End Property
                
        ''' <summary>
        ''' Nullable property
        ''' </summary>
        Public Overridable Property IdTrabjador As System.Nullable(Of System.Int32) 
            Get        
                Return _IdTrabjador
            End Get
            
            Set
                MyBase.PropertyModified()
                _IdTrabjador = value
                
                   If value.HasValue Then 
                    Dim e As DescriptionFieldEventArg = New DescriptionFieldEventArg(New TrabajadoresObject (_IdTrabjador.Value))
                    RaiseEvent Update_TrabajadoresString(Me, e)
                    _TrabajadoresString = e.DescriptionString
                   End If 
                
            End Set
            
        End Property
                
        ''' <summary>
        ''' Nullable property
        ''' </summary>
        Public Overridable Property IdSalidas As System.Nullable(Of System.Int32) 
            Get        
                Return _IdSalidas
            End Get
            
            Set
                MyBase.PropertyModified()
                _IdSalidas = value
                
            End Set
            
        End Property
                
        ''' <summary>
        ''' Nullable property
        ''' </summary>
        Public Overridable Property IdTienda As System.Nullable(Of System.Int32) 
            Get        
                Return _IdTienda
            End Get
            
            Set
                MyBase.PropertyModified()
                _IdTienda = value
                
            End Set
            
        End Property
                
        ''' <summary>
        ''' Nullable property
        ''' </summary>
        Public Overridable Property Fecha As System.Nullable(Of System.DateTime) 
            Get        
                Return _Fecha
            End Get
            
            Set
                MyBase.PropertyModified()
                _Fecha = value
                
            End Set
            
        End Property
                
        ''' <summary>
        ''' Nullable property
        ''' </summary>
        Public Overridable Property TipDoc As System.Nullable(Of System.Int32) 
            Get        
                Return _TipDoc
            End Get
            
            Set
                MyBase.PropertyModified()
                _TipDoc = value
                
            End Set
            
        End Property
                
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property Tipo As System.String
            Get
                Return _Tipo
            End Get
            
            Set
                MyBase.PropertyModified()
                _Tipo = value
                
            End Set
            
        End Property
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property Serie As System.String
            Get
                Return _Serie
            End Get
            
            Set
                MyBase.PropertyModified()
                _Serie = value
                
            End Set
            
        End Property
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property Numero As System.String
            Get
                Return _Numero
            End Get
            
            Set
                MyBase.PropertyModified()
                _Numero = value
                
            End Set
            
        End Property
        
        ''' <summary>
        ''' Nullable property
        ''' </summary>
        Public Overridable Property IdCliente As System.Nullable(Of System.Int32) 
            Get        
                Return _IdCliente
            End Get
            
            Set
                MyBase.PropertyModified()
                _IdCliente = value
                
                   If value.HasValue Then 
                    Dim e As DescriptionFieldEventArg = New DescriptionFieldEventArg(New ClientesObject (_IdCliente.Value))
                    RaiseEvent Update_ClientesString(Me, e)
                    _ClientesString = e.DescriptionString
                   End If 
                
            End Set
            
        End Property
                
        ''' <summary>
        ''' Nullable property
        ''' </summary>
        Public Overridable Property Moneda As System.Nullable(Of System.Int32) 
            Get        
                Return _Moneda
            End Get
            
            Set
                MyBase.PropertyModified()
                _Moneda = value
                
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
        ''' Nullable property
        ''' </summary>
        Public Overridable Property totalvalor As System.Nullable(Of System.Decimal) 
            Get        
                Return _totalvalor
            End Get
            
            Set
                MyBase.PropertyModified()
                _totalvalor = value
                
            End Set
            
        End Property
                
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable ReadOnly Property AlmacenesString As System.String
            Get
                Return _AlmacenesString
            End Get
            
        End Property
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable ReadOnly Property ClientesString As System.String
            Get
                Return _ClientesString
            End Get
            
        End Property
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable ReadOnly Property TrabajadoresString As System.String
            Get
                Return _TrabajadoresString
            End Get
            
        End Property
        
        #End Region

        

        Protected Overrides Sub SetOriginalValue()
            MyBase.InternalOriginalValue = CType(Me.MemberwiseClone(), IObject)
        End Sub

        Protected Overridable Function Clone() As Object Implements ICloneable.Clone
            Dim newObject As SalidasObject 
            Dim newOriginalValue As SalidasObject 

            newObject = CType(Me.MemberwiseClone(), SalidasObject) 
            If (MyBase.InternalOriginalValue IsNot Nothing) Then
                newOriginalValue = CType(Me.OriginalValue().MemberwiseClone(), SalidasObject)
                newObject.InternalOriginalValue = newOriginalValue
            End If
            Return newObject
        End Function


        ''' <summary>
        ''' Returns de original value of object since was created or restored.
        ''' </summary>
        Public Shadows Function OriginalValue() As SalidasObject 
           Return CType(MyBase.OriginalValue, SalidasObject)
        End Function


        Private Sub HydrateFields(ByVal IdSalidasP As System.Int32, _
			ByVal IdAlmacen As System.Nullable(Of System.Int32) , _
			ByVal IdTrabjador As System.Nullable(Of System.Int32) , _
			ByVal IdSalidas As System.Nullable(Of System.Int32) , _
			ByVal IdTienda As System.Nullable(Of System.Int32) , _
			ByVal Fecha As System.Nullable(Of System.DateTime) , _
			ByVal TipDoc As System.Nullable(Of System.Int32) , _
			ByVal Tipo As System.String, _
			ByVal Serie As System.String, _
			ByVal Numero As System.String, _
			ByVal IdCliente As System.Nullable(Of System.Int32) , _
			ByVal Moneda As System.Nullable(Of System.Int32) , _
			ByVal estado As System.String, _
			ByVal totalvalor As System.Nullable(Of System.Decimal) , _
			ByVal AlmacenesString As System.String, _
			ByVal ClientesString As System.String, _
			ByVal TrabajadoresString As System.String) Implements IMappeableSalidasObject.HydrateFields        
        	_IdSalidasP = IdSalidasP
			_IdAlmacen = IdAlmacen
			_IdTrabjador = IdTrabjador
			_IdSalidas = IdSalidas
			_IdTienda = IdTienda
			_Fecha = Fecha
			_TipDoc = TipDoc
			_Tipo = Tipo
			_Serie = Serie
			_Numero = Numero
			_IdCliente = IdCliente
			_Moneda = Moneda
			_estado = estado
			_totalvalor = totalvalor
			_AlmacenesString = AlmacenesString
			_ClientesString = ClientesString
			_TrabajadoresString = TrabajadoresString
        End Sub

        Private Function GetFieldsForInsert() As Object() Implements IMappeableSalidasObject.GetFieldsForInsert
        
        
            Dim _myArray(13) As Object
            _myArray(0) = _IdSalidasP
			If (_IdAlmacen.HasValue) Then _myArray(1) = _IdAlmacen.Value
			If (_IdTrabjador.HasValue) Then _myArray(2) = _IdTrabjador.Value
			If (_IdSalidas.HasValue) Then _myArray(3) = _IdSalidas.Value
			If (_IdTienda.HasValue) Then _myArray(4) = _IdTienda.Value
			If (_Fecha.HasValue) Then _myArray(5) = _Fecha.Value
			If (_TipDoc.HasValue) Then _myArray(6) = _TipDoc.Value
			If (Not System.String.IsNullOrEmpty(_Tipo)) Then _myArray(7) = _Tipo
			If (Not System.String.IsNullOrEmpty(_Serie)) Then _myArray(8) = _Serie
			If (Not System.String.IsNullOrEmpty(_Numero)) Then _myArray(9) = _Numero
			If (_IdCliente.HasValue) Then _myArray(10) = _IdCliente.Value
			If (_Moneda.HasValue) Then _myArray(11) = _Moneda.Value
			If (Not System.String.IsNullOrEmpty(_estado)) Then _myArray(12) = _estado
			If (_totalvalor.HasValue) Then _myArray(13) = _totalvalor.Value
			
            Return _myArray
        
        End Function

        Private Function GetFieldsForUpdate() As Object() Implements IMappeableSalidasObject.GetFieldsForUpdate
        
        
            
            Dim _myArray(13) As Object
            _myArray(0) = _IdSalidasP
			If (_IdAlmacen.HasValue) Then _myArray(1) = _IdAlmacen.Value
			If (_IdTrabjador.HasValue) Then _myArray(2) = _IdTrabjador.Value
			If (_IdSalidas.HasValue) Then _myArray(3) = _IdSalidas.Value
			If (_IdTienda.HasValue) Then _myArray(4) = _IdTienda.Value
			If (_Fecha.HasValue) Then _myArray(5) = _Fecha.Value
			If (_TipDoc.HasValue) Then _myArray(6) = _TipDoc.Value
			If (Not System.String.IsNullOrEmpty(_Tipo)) Then _myArray(7) = _Tipo
			If (Not System.String.IsNullOrEmpty(_Serie)) Then _myArray(8) = _Serie
			If (Not System.String.IsNullOrEmpty(_Numero)) Then _myArray(9) = _Numero
			If (_IdCliente.HasValue) Then _myArray(10) = _IdCliente.Value
			If (_Moneda.HasValue) Then _myArray(11) = _Moneda.Value
			If (Not System.String.IsNullOrEmpty(_estado)) Then _myArray(12) = _estado
			If (_totalvalor.HasValue) Then _myArray(13) = _totalvalor.Value
			
            Return _myArray
        
        End Function

        Private Function GetFieldsForDelete() As Object() Implements IMappeableSalidasObject.GetFieldsForDelete
        
            Dim _myArray(0) As Object
            _myArray(0) = _IdSalidasP
			
            Return _myArray
        
        End Function


        Private Sub UpdateObjectFromOutputParams(parameters As Object()) Implements IMappeableSalidasObject.UpdateObjectFromOutputParams
            ' Update properties from Output parameters
            _IdSalidasP = CType(parameters(0), System.Int32)

        End Sub

        Private Function Identifier() As Object() Implements IUniqueIdentifiable.Identifier
            Dim o As SalidasObject = Nothing
            If ObjectStateHelper.IsModified(Me) Then
                o = Me.OriginalValue()
            Else
                o = Me
            End If

            Return New Object() {o.IdSalidasP}
        End Function


        Public Overloads Function Equals(other As SalidasObject) As Boolean Implements IEquatable(Of SalidasObject).Equals
            Return UniqueIdentifierHelper.IsSameObject(CType(Me, IUniqueIdentifiable), CType(other, IUniqueIdentifiable))
        End Function


    End Class

    Public Interface IMappeableSalidasObject
        Sub HydrateFields( ByVal IdSalidasP As System.Int32, _
				 ByVal IdAlmacen As System.Nullable(Of System.Int32) , _
				 ByVal IdTrabjador As System.Nullable(Of System.Int32) , _
				 ByVal IdSalidas As System.Nullable(Of System.Int32) , _
				 ByVal IdTienda As System.Nullable(Of System.Int32) , _
				 ByVal Fecha As System.Nullable(Of System.DateTime) , _
				 ByVal TipDoc As System.Nullable(Of System.Int32) , _
				 ByVal Tipo As System.String, _
				 ByVal Serie As System.String, _
				 ByVal Numero As System.String, _
				 ByVal IdCliente As System.Nullable(Of System.Int32) , _
				 ByVal Moneda As System.Nullable(Of System.Int32) , _
				 ByVal estado As System.String, _
				 ByVal totalvalor As System.Nullable(Of System.Decimal) , _
				 ByVal AlmacenesString As System.String, _
				 ByVal ClientesString As System.String, _
				 ByVal TrabajadoresString As System.String)

        Function GetFieldsForInsert() As Object() 

        Function GetFieldsForUpdate() As Object() 

        Function GetFieldsForDelete() As Object()

        Sub UpdateObjectFromOutputParams(ByVal parameters As Object() )
    End Interface

    Public Partial Class SalidasObjectList
        Inherits ObjectList(Of SalidasObject)
    End Class
End Namespace

Namespace Views
    Partial Public Class SalidasObjectListView
        Inherits ObjectListView(Of Objects.SalidasObject)

        Sub New(ByVal list As Objects.SalidasObjectList)
            MyBase.New(list)
        End Sub
    End Class
End NameSpace


