
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 20/08/2013 - 01:48 p.m.
' This is a Partial class file. The other one is ClientesObject.vb
' You should not modifiy this file, please edit the other partial class file.
'------------------------------------------------------------------------------

Imports Cooperator.Framework.Core
Imports System

Namespace Objects

    Public Partial Class ClientesObject
        Inherits BaseObject
        Implements IMappeableClientesObject
        Implements IUniqueIdentifiable
        Implements IEquatable(Of ClientesObject)
        Implements ICloneable

#Region "Ctor"

        Public Sub New()
            MyBase.New()

			_IdCliente =  ValuesGenerator.GetInt32

        End Sub

        
        Public Sub New(ByVal IdCliente As System.Int32)
            MyBase.New()

			_IdCliente = IdCliente

            Call Initialized()
        End Sub
        

        
        Public Sub New(ByVal IdCliente As System.Int32, _
			ByVal TipoCliente As System.Nullable(Of System.Int32), _
			ByVal Nombre As System.String, _
			ByVal Apellido As System.String, _
			ByVal Cliente As System.String, _
			ByVal NomComercial As System.String, _
			ByVal TipoDI As System.Nullable(Of System.Int32), _
			ByVal DI As System.String, _
			ByVal Direccion As System.String, _
			ByVal Distrito As System.Nullable(Of System.Int32), _
			ByVal Provincia As System.Nullable(Of System.Int32), _
			ByVal Pais As System.String, _
			ByVal Telefono1 As System.String, _
			ByVal Telefono2 As System.String, _
			ByVal Fax As System.String, _
			ByVal Email As System.String, _
			ByVal Logo As System.String, _
			ByVal Movil As System.String, _
			ByVal TipMovil As System.String, _
			ByVal Observaciones As System.String, _
			ByVal CodCliente As System.String, _
			ByVal CondPago As System.Nullable(Of System.Int32), _
			ByVal Ruta As System.String, _
			ByVal fechaderegistro As System.Nullable(Of System.DateTime), _
			ByVal estadocliente As System.String, _
			ByVal DistritosString As System.String, _
			ByVal ProvinciasString As System.String)
            MyBase.New()

			_IdCliente = IdCliente
			_TipoCliente = TipoCliente
			_Nombre = Nombre
			_Apellido = Apellido
			_Cliente = Cliente
			_NomComercial = NomComercial
			_TipoDI = TipoDI
			_DI = DI
			_Direccion = Direccion
			_Distrito = Distrito
			_Provincia = Provincia
			_Pais = Pais
			_Telefono1 = Telefono1
			_Telefono2 = Telefono2
			_Fax = Fax
			_Email = Email
			_Logo = Logo
			_Movil = Movil
			_TipMovil = TipMovil
			_Observaciones = Observaciones
			_CodCliente = CodCliente
			_CondPago = CondPago
			_Ruta = Ruta
			_fechaderegistro = fechaderegistro
			_estadocliente = estadocliente
			_DistritosString = DistritosString
			_ProvinciasString = ProvinciasString

            Call Initialized()
        End Sub
        

#End Region

#Region "Events"

        
        Public Event Update_DistritosString(ByVal sender As Object, ByVal e As DescriptionFieldEventArg)
        
        Public Event Update_ProvinciasString(ByVal sender As Object, ByVal e As DescriptionFieldEventArg)
        
#End Region

#Region "Fields"

        Protected _IdCliente As System.Int32
Protected _TipoCliente As System.Nullable(Of System.Int32) 
Protected _Nombre As System.String
Protected _Apellido As System.String
Protected _Cliente As System.String
Protected _NomComercial As System.String
Protected _TipoDI As System.Nullable(Of System.Int32) 
Protected _DI As System.String
Protected _Direccion As System.String
Protected _Distrito As System.Nullable(Of System.Int32) 
Protected _Provincia As System.Nullable(Of System.Int32) 
Protected _Pais As System.String
Protected _Telefono1 As System.String
Protected _Telefono2 As System.String
Protected _Fax As System.String
Protected _Email As System.String
Protected _Logo As System.String
Protected _Movil As System.String
Protected _TipMovil As System.String
Protected _Observaciones As System.String
Protected _CodCliente As System.String
Protected _CondPago As System.Nullable(Of System.Int32) 
Protected _Ruta As System.String
Protected _fechaderegistro As System.Nullable(Of System.DateTime) 
Protected _estadocliente As System.String
Protected _DistritosString As System.String
Protected _ProvinciasString As System.String

#End Region

#Region "Properties"
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable ReadOnly Property IdCliente As System.Int32
            Get
                Return _IdCliente
            End Get
            
        End Property
        
        ''' <summary>
        ''' Nullable property
        ''' </summary>
        Public Overridable Property TipoCliente As System.Nullable(Of System.Int32) 
            Get        
                Return _TipoCliente
            End Get
            
            Set
                MyBase.PropertyModified()
                _TipoCliente = value
                
            End Set
            
        End Property
                
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property Nombre As System.String
            Get
                Return _Nombre
            End Get
            
            Set
                MyBase.PropertyModified()
                _Nombre = value
                
            End Set
            
        End Property
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property Apellido As System.String
            Get
                Return _Apellido
            End Get
            
            Set
                MyBase.PropertyModified()
                _Apellido = value
                
            End Set
            
        End Property
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property Cliente As System.String
            Get
                Return _Cliente
            End Get
            
            Set
                MyBase.PropertyModified()
                _Cliente = value
                
            End Set
            
        End Property
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property NomComercial As System.String
            Get
                Return _NomComercial
            End Get
            
            Set
                MyBase.PropertyModified()
                _NomComercial = value
                
            End Set
            
        End Property
        
        ''' <summary>
        ''' Nullable property
        ''' </summary>
        Public Overridable Property TipoDI As System.Nullable(Of System.Int32) 
            Get        
                Return _TipoDI
            End Get
            
            Set
                MyBase.PropertyModified()
                _TipoDI = value
                
            End Set
            
        End Property
                
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property DI As System.String
            Get
                Return _DI
            End Get
            
            Set
                MyBase.PropertyModified()
                _DI = value
                
            End Set
            
        End Property
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property Direccion As System.String
            Get
                Return _Direccion
            End Get
            
            Set
                MyBase.PropertyModified()
                _Direccion = value
                
            End Set
            
        End Property
        
        ''' <summary>
        ''' Nullable property
        ''' </summary>
        Public Overridable Property Distrito As System.Nullable(Of System.Int32) 
            Get        
                Return _Distrito
            End Get
            
            Set
                MyBase.PropertyModified()
                _Distrito = value
                
                   If value.HasValue Then 
                    Dim e As DescriptionFieldEventArg = New DescriptionFieldEventArg(New DistritosObject (_Distrito.Value))
                    RaiseEvent Update_DistritosString(Me, e)
                    _DistritosString = e.DescriptionString
                   End If 
                
            End Set
            
        End Property
                
        ''' <summary>
        ''' Nullable property
        ''' </summary>
        Public Overridable Property Provincia As System.Nullable(Of System.Int32) 
            Get        
                Return _Provincia
            End Get
            
            Set
                MyBase.PropertyModified()
                _Provincia = value
                
                   If value.HasValue Then 
                    Dim e As DescriptionFieldEventArg = New DescriptionFieldEventArg(New ProvinciasObject (_Provincia.Value))
                    RaiseEvent Update_ProvinciasString(Me, e)
                    _ProvinciasString = e.DescriptionString
                   End If 
                
            End Set
            
        End Property
                
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property Pais As System.String
            Get
                Return _Pais
            End Get
            
            Set
                MyBase.PropertyModified()
                _Pais = value
                
            End Set
            
        End Property
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property Telefono1 As System.String
            Get
                Return _Telefono1
            End Get
            
            Set
                MyBase.PropertyModified()
                _Telefono1 = value
                
            End Set
            
        End Property
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property Telefono2 As System.String
            Get
                Return _Telefono2
            End Get
            
            Set
                MyBase.PropertyModified()
                _Telefono2 = value
                
            End Set
            
        End Property
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property Fax As System.String
            Get
                Return _Fax
            End Get
            
            Set
                MyBase.PropertyModified()
                _Fax = value
                
            End Set
            
        End Property
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property Email As System.String
            Get
                Return _Email
            End Get
            
            Set
                MyBase.PropertyModified()
                _Email = value
                
            End Set
            
        End Property
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property Logo As System.String
            Get
                Return _Logo
            End Get
            
            Set
                MyBase.PropertyModified()
                _Logo = value
                
            End Set
            
        End Property
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property Movil As System.String
            Get
                Return _Movil
            End Get
            
            Set
                MyBase.PropertyModified()
                _Movil = value
                
            End Set
            
        End Property
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property TipMovil As System.String
            Get
                Return _TipMovil
            End Get
            
            Set
                MyBase.PropertyModified()
                _TipMovil = value
                
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
        Public Overridable Property CodCliente As System.String
            Get
                Return _CodCliente
            End Get
            
            Set
                MyBase.PropertyModified()
                _CodCliente = value
                
            End Set
            
        End Property
        
        ''' <summary>
        ''' Nullable property
        ''' </summary>
        Public Overridable Property CondPago As System.Nullable(Of System.Int32) 
            Get        
                Return _CondPago
            End Get
            
            Set
                MyBase.PropertyModified()
                _CondPago = value
                
            End Set
            
        End Property
                
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property Ruta As System.String
            Get
                Return _Ruta
            End Get
            
            Set
                MyBase.PropertyModified()
                _Ruta = value
                
            End Set
            
        End Property
        
        ''' <summary>
        ''' Nullable property
        ''' </summary>
        Public Overridable Property fechaderegistro As System.Nullable(Of System.DateTime) 
            Get        
                Return _fechaderegistro
            End Get
            
            Set
                MyBase.PropertyModified()
                _fechaderegistro = value
                
            End Set
            
        End Property
                
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property estadocliente As System.String
            Get
                Return _estadocliente
            End Get
            
            Set
                MyBase.PropertyModified()
                _estadocliente = value
                
            End Set
            
        End Property
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable ReadOnly Property DistritosString As System.String
            Get
                Return _DistritosString
            End Get
            
        End Property
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable ReadOnly Property ProvinciasString As System.String
            Get
                Return _ProvinciasString
            End Get
            
        End Property
        
        #End Region

        

        Protected Overrides Sub SetOriginalValue()
            MyBase.InternalOriginalValue = CType(Me.MemberwiseClone(), IObject)
        End Sub

        Protected Overridable Function Clone() As Object Implements ICloneable.Clone
            Dim newObject As ClientesObject 
            Dim newOriginalValue As ClientesObject 

            newObject = CType(Me.MemberwiseClone(), ClientesObject) 
            If (MyBase.InternalOriginalValue IsNot Nothing) Then
                newOriginalValue = CType(Me.OriginalValue().MemberwiseClone(), ClientesObject)
                newObject.InternalOriginalValue = newOriginalValue
            End If
            Return newObject
        End Function


        ''' <summary>
        ''' Returns de original value of object since was created or restored.
        ''' </summary>
        Public Shadows Function OriginalValue() As ClientesObject 
           Return CType(MyBase.OriginalValue, ClientesObject)
        End Function


        Private Sub HydrateFields(ByVal IdCliente As System.Int32, _
			ByVal TipoCliente As System.Nullable(Of System.Int32) , _
			ByVal Nombre As System.String, _
			ByVal Apellido As System.String, _
			ByVal Cliente As System.String, _
			ByVal NomComercial As System.String, _
			ByVal TipoDI As System.Nullable(Of System.Int32) , _
			ByVal DI As System.String, _
			ByVal Direccion As System.String, _
			ByVal Distrito As System.Nullable(Of System.Int32) , _
			ByVal Provincia As System.Nullable(Of System.Int32) , _
			ByVal Pais As System.String, _
			ByVal Telefono1 As System.String, _
			ByVal Telefono2 As System.String, _
			ByVal Fax As System.String, _
			ByVal Email As System.String, _
			ByVal Logo As System.String, _
			ByVal Movil As System.String, _
			ByVal TipMovil As System.String, _
			ByVal Observaciones As System.String, _
			ByVal CodCliente As System.String, _
			ByVal CondPago As System.Nullable(Of System.Int32) , _
			ByVal Ruta As System.String, _
			ByVal fechaderegistro As System.Nullable(Of System.DateTime) , _
			ByVal estadocliente As System.String, _
			ByVal DistritosString As System.String, _
			ByVal ProvinciasString As System.String) Implements IMappeableClientesObject.HydrateFields        
        	_IdCliente = IdCliente
			_TipoCliente = TipoCliente
			_Nombre = Nombre
			_Apellido = Apellido
			_Cliente = Cliente
			_NomComercial = NomComercial
			_TipoDI = TipoDI
			_DI = DI
			_Direccion = Direccion
			_Distrito = Distrito
			_Provincia = Provincia
			_Pais = Pais
			_Telefono1 = Telefono1
			_Telefono2 = Telefono2
			_Fax = Fax
			_Email = Email
			_Logo = Logo
			_Movil = Movil
			_TipMovil = TipMovil
			_Observaciones = Observaciones
			_CodCliente = CodCliente
			_CondPago = CondPago
			_Ruta = Ruta
			_fechaderegistro = fechaderegistro
			_estadocliente = estadocliente
			_DistritosString = DistritosString
			_ProvinciasString = ProvinciasString
        End Sub

        Private Function GetFieldsForInsert() As Object() Implements IMappeableClientesObject.GetFieldsForInsert
        
        
            Dim _myArray(24) As Object
            _myArray(0) = _IdCliente
			If (_TipoCliente.HasValue) Then _myArray(1) = _TipoCliente.Value
			If (Not System.String.IsNullOrEmpty(_Nombre)) Then _myArray(2) = _Nombre
			If (Not System.String.IsNullOrEmpty(_Apellido)) Then _myArray(3) = _Apellido
			If (Not System.String.IsNullOrEmpty(_Cliente)) Then _myArray(4) = _Cliente
			If (Not System.String.IsNullOrEmpty(_NomComercial)) Then _myArray(5) = _NomComercial
			If (_TipoDI.HasValue) Then _myArray(6) = _TipoDI.Value
			If (Not System.String.IsNullOrEmpty(_DI)) Then _myArray(7) = _DI
			If (Not System.String.IsNullOrEmpty(_Direccion)) Then _myArray(8) = _Direccion
			If (_Distrito.HasValue) Then _myArray(9) = _Distrito.Value
			If (_Provincia.HasValue) Then _myArray(10) = _Provincia.Value
			If (Not System.String.IsNullOrEmpty(_Pais)) Then _myArray(11) = _Pais
			If (Not System.String.IsNullOrEmpty(_Telefono1)) Then _myArray(12) = _Telefono1
			If (Not System.String.IsNullOrEmpty(_Telefono2)) Then _myArray(13) = _Telefono2
			If (Not System.String.IsNullOrEmpty(_Fax)) Then _myArray(14) = _Fax
			If (Not System.String.IsNullOrEmpty(_Email)) Then _myArray(15) = _Email
			If (Not System.String.IsNullOrEmpty(_Logo)) Then _myArray(16) = _Logo
			If (Not System.String.IsNullOrEmpty(_Movil)) Then _myArray(17) = _Movil
			If (Not System.String.IsNullOrEmpty(_TipMovil)) Then _myArray(18) = _TipMovil
			If (Not System.String.IsNullOrEmpty(_Observaciones)) Then _myArray(19) = _Observaciones
			If (Not System.String.IsNullOrEmpty(_CodCliente)) Then _myArray(20) = _CodCliente
			If (_CondPago.HasValue) Then _myArray(21) = _CondPago.Value
			If (Not System.String.IsNullOrEmpty(_Ruta)) Then _myArray(22) = _Ruta
			If (_fechaderegistro.HasValue) Then _myArray(23) = _fechaderegistro.Value
			If (Not System.String.IsNullOrEmpty(_estadocliente)) Then _myArray(24) = _estadocliente
			
            Return _myArray
        
        End Function

        Private Function GetFieldsForUpdate() As Object() Implements IMappeableClientesObject.GetFieldsForUpdate
        
        
            
            Dim _myArray(24) As Object
            _myArray(0) = _IdCliente
			If (_TipoCliente.HasValue) Then _myArray(1) = _TipoCliente.Value
			If (Not System.String.IsNullOrEmpty(_Nombre)) Then _myArray(2) = _Nombre
			If (Not System.String.IsNullOrEmpty(_Apellido)) Then _myArray(3) = _Apellido
			If (Not System.String.IsNullOrEmpty(_Cliente)) Then _myArray(4) = _Cliente
			If (Not System.String.IsNullOrEmpty(_NomComercial)) Then _myArray(5) = _NomComercial
			If (_TipoDI.HasValue) Then _myArray(6) = _TipoDI.Value
			If (Not System.String.IsNullOrEmpty(_DI)) Then _myArray(7) = _DI
			If (Not System.String.IsNullOrEmpty(_Direccion)) Then _myArray(8) = _Direccion
			If (_Distrito.HasValue) Then _myArray(9) = _Distrito.Value
			If (_Provincia.HasValue) Then _myArray(10) = _Provincia.Value
			If (Not System.String.IsNullOrEmpty(_Pais)) Then _myArray(11) = _Pais
			If (Not System.String.IsNullOrEmpty(_Telefono1)) Then _myArray(12) = _Telefono1
			If (Not System.String.IsNullOrEmpty(_Telefono2)) Then _myArray(13) = _Telefono2
			If (Not System.String.IsNullOrEmpty(_Fax)) Then _myArray(14) = _Fax
			If (Not System.String.IsNullOrEmpty(_Email)) Then _myArray(15) = _Email
			If (Not System.String.IsNullOrEmpty(_Logo)) Then _myArray(16) = _Logo
			If (Not System.String.IsNullOrEmpty(_Movil)) Then _myArray(17) = _Movil
			If (Not System.String.IsNullOrEmpty(_TipMovil)) Then _myArray(18) = _TipMovil
			If (Not System.String.IsNullOrEmpty(_Observaciones)) Then _myArray(19) = _Observaciones
			If (Not System.String.IsNullOrEmpty(_CodCliente)) Then _myArray(20) = _CodCliente
			If (_CondPago.HasValue) Then _myArray(21) = _CondPago.Value
			If (Not System.String.IsNullOrEmpty(_Ruta)) Then _myArray(22) = _Ruta
			If (_fechaderegistro.HasValue) Then _myArray(23) = _fechaderegistro.Value
			If (Not System.String.IsNullOrEmpty(_estadocliente)) Then _myArray(24) = _estadocliente
			
            Return _myArray
        
        End Function

        Private Function GetFieldsForDelete() As Object() Implements IMappeableClientesObject.GetFieldsForDelete
        
            Dim _myArray(0) As Object
            _myArray(0) = _IdCliente
			
            Return _myArray
        
        End Function


        Private Sub UpdateObjectFromOutputParams(parameters As Object()) Implements IMappeableClientesObject.UpdateObjectFromOutputParams
            ' Update properties from Output parameters
            _IdCliente = CType(parameters(0), System.Int32)

        End Sub

        Private Function Identifier() As Object() Implements IUniqueIdentifiable.Identifier
            Dim o As ClientesObject = Nothing
            If ObjectStateHelper.IsModified(Me) Then
                o = Me.OriginalValue()
            Else
                o = Me
            End If

            Return New Object() {o.IdCliente}
        End Function


        Public Overloads Function Equals(other As ClientesObject) As Boolean Implements IEquatable(Of ClientesObject).Equals
            Return UniqueIdentifierHelper.IsSameObject(CType(Me, IUniqueIdentifiable), CType(other, IUniqueIdentifiable))
        End Function


    End Class

    Public Interface IMappeableClientesObject
        Sub HydrateFields( ByVal IdCliente As System.Int32, _
				 ByVal TipoCliente As System.Nullable(Of System.Int32) , _
				 ByVal Nombre As System.String, _
				 ByVal Apellido As System.String, _
				 ByVal Cliente As System.String, _
				 ByVal NomComercial As System.String, _
				 ByVal TipoDI As System.Nullable(Of System.Int32) , _
				 ByVal DI As System.String, _
				 ByVal Direccion As System.String, _
				 ByVal Distrito As System.Nullable(Of System.Int32) , _
				 ByVal Provincia As System.Nullable(Of System.Int32) , _
				 ByVal Pais As System.String, _
				 ByVal Telefono1 As System.String, _
				 ByVal Telefono2 As System.String, _
				 ByVal Fax As System.String, _
				 ByVal Email As System.String, _
				 ByVal Logo As System.String, _
				 ByVal Movil As System.String, _
				 ByVal TipMovil As System.String, _
				 ByVal Observaciones As System.String, _
				 ByVal CodCliente As System.String, _
				 ByVal CondPago As System.Nullable(Of System.Int32) , _
				 ByVal Ruta As System.String, _
				 ByVal fechaderegistro As System.Nullable(Of System.DateTime) , _
				 ByVal estadocliente As System.String, _
				 ByVal DistritosString As System.String, _
				 ByVal ProvinciasString As System.String)

        Function GetFieldsForInsert() As Object() 

        Function GetFieldsForUpdate() As Object() 

        Function GetFieldsForDelete() As Object()

        Sub UpdateObjectFromOutputParams(ByVal parameters As Object() )
    End Interface

    Public Partial Class ClientesObjectList
        Inherits ObjectList(Of ClientesObject)
    End Class
End Namespace

Namespace Views
    Partial Public Class ClientesObjectListView
        Inherits ObjectListView(Of Objects.ClientesObject)

        Sub New(ByVal list As Objects.ClientesObjectList)
            MyBase.New(list)
        End Sub
    End Class
End NameSpace


