
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 20/08/2013 - 01:48 p.m.
' This is a Partial class file. The other one is idcrdObject.vb
' You should not modifiy this file, please edit the other partial class file.
'------------------------------------------------------------------------------

Imports Cooperator.Framework.Core
Imports System

Namespace Objects

    Public Partial Class idcrdObject
        Inherits BaseObject
        Implements IMappeableidcrdObject
        Implements IUniqueIdentifiable
        Implements IEquatable(Of idcrdObject)
        Implements ICloneable

#Region "Ctor"

        Public Sub New()
            MyBase.New()

			_idcrd =  ValuesGenerator.GetInt32

        End Sub

        
        Public Sub New(ByVal idcrd As System.Int32)
            MyBase.New()

			_idcrd = idcrd

            Call Initialized()
        End Sub
        

        
        Public Sub New(ByVal idcrd As System.Int32, _
			ByVal idcliente As System.Nullable(Of System.Int32), _
			ByVal idruta As System.Nullable(Of System.Int32), _
			ByVal direcciontienda As System.String, _
			ByVal observacion As System.String, _
			ByVal ClientesString As System.String, _
			ByVal rutaString As System.String)
            MyBase.New()

			_idcrd = idcrd
			_idcliente = idcliente
			_idruta = idruta
			_direcciontienda = direcciontienda
			_observacion = observacion
			_ClientesString = ClientesString
			_rutaString = rutaString

            Call Initialized()
        End Sub
        

#End Region

#Region "Events"

        
        Public Event Update_ClientesString(ByVal sender As Object, ByVal e As DescriptionFieldEventArg)
        
        Public Event Update_rutaString(ByVal sender As Object, ByVal e As DescriptionFieldEventArg)
        
#End Region

#Region "Fields"

        Protected _idcrd As System.Int32
Protected _idcliente As System.Nullable(Of System.Int32) 
Protected _idruta As System.Nullable(Of System.Int32) 
Protected _direcciontienda As System.String
Protected _observacion As System.String
Protected _ClientesString As System.String
Protected _rutaString As System.String

#End Region

#Region "Properties"
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable ReadOnly Property idcrd As System.Int32
            Get
                Return _idcrd
            End Get
            
        End Property
        
        ''' <summary>
        ''' Nullable property
        ''' </summary>
        Public Overridable Property idcliente As System.Nullable(Of System.Int32) 
            Get        
                Return _idcliente
            End Get
            
            Set
                MyBase.PropertyModified()
                _idcliente = value
                
                   If value.HasValue Then 
                    Dim e As DescriptionFieldEventArg = New DescriptionFieldEventArg(New ClientesObject (_idcliente.Value))
                    RaiseEvent Update_ClientesString(Me, e)
                    _ClientesString = e.DescriptionString
                   End If 
                
            End Set
            
        End Property
                
        ''' <summary>
        ''' Nullable property
        ''' </summary>
        Public Overridable Property idruta As System.Nullable(Of System.Int32) 
            Get        
                Return _idruta
            End Get
            
            Set
                MyBase.PropertyModified()
                _idruta = value
                
                   If value.HasValue Then 
                    Dim e As DescriptionFieldEventArg = New DescriptionFieldEventArg(New rutaObject (_idruta.Value))
                    RaiseEvent Update_rutaString(Me, e)
                    _rutaString = e.DescriptionString
                   End If 
                
            End Set
            
        End Property
                
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property direcciontienda As System.String
            Get
                Return _direcciontienda
            End Get
            
            Set
                MyBase.PropertyModified()
                _direcciontienda = value
                
            End Set
            
        End Property
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property observacion As System.String
            Get
                Return _observacion
            End Get
            
            Set
                MyBase.PropertyModified()
                _observacion = value
                
            End Set
            
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
        Public Overridable ReadOnly Property rutaString As System.String
            Get
                Return _rutaString
            End Get
            
        End Property
        
        #End Region

        

        Protected Overrides Sub SetOriginalValue()
            MyBase.InternalOriginalValue = CType(Me.MemberwiseClone(), IObject)
        End Sub

        Protected Overridable Function Clone() As Object Implements ICloneable.Clone
            Dim newObject As idcrdObject 
            Dim newOriginalValue As idcrdObject 

            newObject = CType(Me.MemberwiseClone(), idcrdObject) 
            If (MyBase.InternalOriginalValue IsNot Nothing) Then
                newOriginalValue = CType(Me.OriginalValue().MemberwiseClone(), idcrdObject)
                newObject.InternalOriginalValue = newOriginalValue
            End If
            Return newObject
        End Function


        ''' <summary>
        ''' Returns de original value of object since was created or restored.
        ''' </summary>
        Public Shadows Function OriginalValue() As idcrdObject 
           Return CType(MyBase.OriginalValue, idcrdObject)
        End Function


        Private Sub HydrateFields(ByVal idcrd As System.Int32, _
			ByVal idcliente As System.Nullable(Of System.Int32) , _
			ByVal idruta As System.Nullable(Of System.Int32) , _
			ByVal direcciontienda As System.String, _
			ByVal observacion As System.String, _
			ByVal ClientesString As System.String, _
			ByVal rutaString As System.String) Implements IMappeableidcrdObject.HydrateFields        
        	_idcrd = idcrd
			_idcliente = idcliente
			_idruta = idruta
			_direcciontienda = direcciontienda
			_observacion = observacion
			_ClientesString = ClientesString
			_rutaString = rutaString
        End Sub

        Private Function GetFieldsForInsert() As Object() Implements IMappeableidcrdObject.GetFieldsForInsert
        
        
            Dim _myArray(4) As Object
            _myArray(0) = _idcrd
			If (_idcliente.HasValue) Then _myArray(1) = _idcliente.Value
			If (_idruta.HasValue) Then _myArray(2) = _idruta.Value
			If (Not System.String.IsNullOrEmpty(_direcciontienda)) Then _myArray(3) = _direcciontienda
			If (Not System.String.IsNullOrEmpty(_observacion)) Then _myArray(4) = _observacion
			
            Return _myArray
        
        End Function

        Private Function GetFieldsForUpdate() As Object() Implements IMappeableidcrdObject.GetFieldsForUpdate
        
        
            
            Dim _myArray(4) As Object
            _myArray(0) = _idcrd
			If (_idcliente.HasValue) Then _myArray(1) = _idcliente.Value
			If (_idruta.HasValue) Then _myArray(2) = _idruta.Value
			If (Not System.String.IsNullOrEmpty(_direcciontienda)) Then _myArray(3) = _direcciontienda
			If (Not System.String.IsNullOrEmpty(_observacion)) Then _myArray(4) = _observacion
			
            Return _myArray
        
        End Function

        Private Function GetFieldsForDelete() As Object() Implements IMappeableidcrdObject.GetFieldsForDelete
        
            Dim _myArray(0) As Object
            _myArray(0) = _idcrd
			
            Return _myArray
        
        End Function


        Private Sub UpdateObjectFromOutputParams(parameters As Object()) Implements IMappeableidcrdObject.UpdateObjectFromOutputParams
            ' Update properties from Output parameters
            _idcrd = CType(parameters(0), System.Int32)

        End Sub

        Private Function Identifier() As Object() Implements IUniqueIdentifiable.Identifier
            Dim o As idcrdObject = Nothing
            If ObjectStateHelper.IsModified(Me) Then
                o = Me.OriginalValue()
            Else
                o = Me
            End If

            Return New Object() {o.idcrd}
        End Function


        Public Overloads Function Equals(other As idcrdObject) As Boolean Implements IEquatable(Of idcrdObject).Equals
            Return UniqueIdentifierHelper.IsSameObject(CType(Me, IUniqueIdentifiable), CType(other, IUniqueIdentifiable))
        End Function


    End Class

    Public Interface IMappeableidcrdObject
        Sub HydrateFields( ByVal idcrd As System.Int32, _
				 ByVal idcliente As System.Nullable(Of System.Int32) , _
				 ByVal idruta As System.Nullable(Of System.Int32) , _
				 ByVal direcciontienda As System.String, _
				 ByVal observacion As System.String, _
				 ByVal ClientesString As System.String, _
				 ByVal rutaString As System.String)

        Function GetFieldsForInsert() As Object() 

        Function GetFieldsForUpdate() As Object() 

        Function GetFieldsForDelete() As Object()

        Sub UpdateObjectFromOutputParams(ByVal parameters As Object() )
    End Interface

    Public Partial Class idcrdObjectList
        Inherits ObjectList(Of idcrdObject)
    End Class
End Namespace

Namespace Views
    Partial Public Class idcrdObjectListView
        Inherits ObjectListView(Of Objects.idcrdObject)

        Sub New(ByVal list As Objects.idcrdObjectList)
            MyBase.New(list)
        End Sub
    End Class
End NameSpace

