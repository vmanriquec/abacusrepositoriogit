
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 20/08/2013 - 01:48 p.m.
' This is a Partial class file. The other one is ClieContactosObject.vb
' You should not modifiy this file, please edit the other partial class file.
'------------------------------------------------------------------------------

Imports Cooperator.Framework.Core
Imports System

Namespace Objects

    Public Partial Class ClieContactosObject
        Inherits BaseObject
        Implements IMappeableClieContactosObject
        Implements IUniqueIdentifiable
        Implements IEquatable(Of ClieContactosObject)
        Implements ICloneable

#Region "Ctor"

        Public Sub New()
            MyBase.New()

			_IdClicontactos =  ValuesGenerator.GetInt32

        End Sub

        
        Public Sub New(ByVal IdClicontactos As System.Int32)
            MyBase.New()

			_IdClicontactos = IdClicontactos

            Call Initialized()
        End Sub
        

        
        Public Sub New(ByVal IdClicontactos As System.Int32, _
			ByVal Nombre As System.String, _
			ByVal Anexo As System.String, _
			ByVal TipMovil1 As System.String, _
			ByVal Movil1 As System.String, _
			ByVal Email1 As System.String, _
			ByVal TipMovil2 As System.String, _
			ByVal Movil2 As System.String, _
			ByVal Email2 As System.String, _
			ByVal IdCliente As System.Nullable(Of System.Int32), _
			ByVal Trato As System.String)
            MyBase.New()

			_IdClicontactos = IdClicontactos
			_Nombre = Nombre
			_Anexo = Anexo
			_TipMovil1 = TipMovil1
			_Movil1 = Movil1
			_Email1 = Email1
			_TipMovil2 = TipMovil2
			_Movil2 = Movil2
			_Email2 = Email2
			_IdCliente = IdCliente
			_Trato = Trato

            Call Initialized()
        End Sub
        

#End Region

#Region "Events"

        
#End Region

#Region "Fields"

        Protected _IdClicontactos As System.Int32
Protected _Nombre As System.String
Protected _Anexo As System.String
Protected _TipMovil1 As System.String
Protected _Movil1 As System.String
Protected _Email1 As System.String
Protected _TipMovil2 As System.String
Protected _Movil2 As System.String
Protected _Email2 As System.String
Protected _IdCliente As System.Nullable(Of System.Int32) 
Protected _Trato As System.String

#End Region

#Region "Properties"
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable ReadOnly Property IdClicontactos As System.Int32
            Get
                Return _IdClicontactos
            End Get
            
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
        Public Overridable Property Anexo As System.String
            Get
                Return _Anexo
            End Get
            
            Set
                MyBase.PropertyModified()
                _Anexo = value
                
            End Set
            
        End Property
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property TipMovil1 As System.String
            Get
                Return _TipMovil1
            End Get
            
            Set
                MyBase.PropertyModified()
                _TipMovil1 = value
                
            End Set
            
        End Property
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property Movil1 As System.String
            Get
                Return _Movil1
            End Get
            
            Set
                MyBase.PropertyModified()
                _Movil1 = value
                
            End Set
            
        End Property
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property Email1 As System.String
            Get
                Return _Email1
            End Get
            
            Set
                MyBase.PropertyModified()
                _Email1 = value
                
            End Set
            
        End Property
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property TipMovil2 As System.String
            Get
                Return _TipMovil2
            End Get
            
            Set
                MyBase.PropertyModified()
                _TipMovil2 = value
                
            End Set
            
        End Property
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property Movil2 As System.String
            Get
                Return _Movil2
            End Get
            
            Set
                MyBase.PropertyModified()
                _Movil2 = value
                
            End Set
            
        End Property
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property Email2 As System.String
            Get
                Return _Email2
            End Get
            
            Set
                MyBase.PropertyModified()
                _Email2 = value
                
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
                
            End Set
            
        End Property
                
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property Trato As System.String
            Get
                Return _Trato
            End Get
            
            Set
                MyBase.PropertyModified()
                _Trato = value
                
            End Set
            
        End Property
        
        #End Region

        

        Protected Overrides Sub SetOriginalValue()
            MyBase.InternalOriginalValue = CType(Me.MemberwiseClone(), IObject)
        End Sub

        Protected Overridable Function Clone() As Object Implements ICloneable.Clone
            Dim newObject As ClieContactosObject 
            Dim newOriginalValue As ClieContactosObject 

            newObject = CType(Me.MemberwiseClone(), ClieContactosObject) 
            If (MyBase.InternalOriginalValue IsNot Nothing) Then
                newOriginalValue = CType(Me.OriginalValue().MemberwiseClone(), ClieContactosObject)
                newObject.InternalOriginalValue = newOriginalValue
            End If
            Return newObject
        End Function


        ''' <summary>
        ''' Returns de original value of object since was created or restored.
        ''' </summary>
        Public Shadows Function OriginalValue() As ClieContactosObject 
           Return CType(MyBase.OriginalValue, ClieContactosObject)
        End Function


        Private Sub HydrateFields(ByVal IdClicontactos As System.Int32, _
			ByVal Nombre As System.String, _
			ByVal Anexo As System.String, _
			ByVal TipMovil1 As System.String, _
			ByVal Movil1 As System.String, _
			ByVal Email1 As System.String, _
			ByVal TipMovil2 As System.String, _
			ByVal Movil2 As System.String, _
			ByVal Email2 As System.String, _
			ByVal IdCliente As System.Nullable(Of System.Int32) , _
			ByVal Trato As System.String) Implements IMappeableClieContactosObject.HydrateFields        
        	_IdClicontactos = IdClicontactos
			_Nombre = Nombre
			_Anexo = Anexo
			_TipMovil1 = TipMovil1
			_Movil1 = Movil1
			_Email1 = Email1
			_TipMovil2 = TipMovil2
			_Movil2 = Movil2
			_Email2 = Email2
			_IdCliente = IdCliente
			_Trato = Trato
        End Sub

        Private Function GetFieldsForInsert() As Object() Implements IMappeableClieContactosObject.GetFieldsForInsert
        
        
            Dim _myArray(10) As Object
            _myArray(0) = _IdClicontactos
			If (Not System.String.IsNullOrEmpty(_Nombre)) Then _myArray(1) = _Nombre
			If (Not System.String.IsNullOrEmpty(_Anexo)) Then _myArray(2) = _Anexo
			If (Not System.String.IsNullOrEmpty(_TipMovil1)) Then _myArray(3) = _TipMovil1
			If (Not System.String.IsNullOrEmpty(_Movil1)) Then _myArray(4) = _Movil1
			If (Not System.String.IsNullOrEmpty(_Email1)) Then _myArray(5) = _Email1
			If (Not System.String.IsNullOrEmpty(_TipMovil2)) Then _myArray(6) = _TipMovil2
			If (Not System.String.IsNullOrEmpty(_Movil2)) Then _myArray(7) = _Movil2
			If (Not System.String.IsNullOrEmpty(_Email2)) Then _myArray(8) = _Email2
			If (_IdCliente.HasValue) Then _myArray(9) = _IdCliente.Value
			If (Not System.String.IsNullOrEmpty(_Trato)) Then _myArray(10) = _Trato
			
            Return _myArray
        
        End Function

        Private Function GetFieldsForUpdate() As Object() Implements IMappeableClieContactosObject.GetFieldsForUpdate
        
        
            
            Dim _myArray(10) As Object
            _myArray(0) = _IdClicontactos
			If (Not System.String.IsNullOrEmpty(_Nombre)) Then _myArray(1) = _Nombre
			If (Not System.String.IsNullOrEmpty(_Anexo)) Then _myArray(2) = _Anexo
			If (Not System.String.IsNullOrEmpty(_TipMovil1)) Then _myArray(3) = _TipMovil1
			If (Not System.String.IsNullOrEmpty(_Movil1)) Then _myArray(4) = _Movil1
			If (Not System.String.IsNullOrEmpty(_Email1)) Then _myArray(5) = _Email1
			If (Not System.String.IsNullOrEmpty(_TipMovil2)) Then _myArray(6) = _TipMovil2
			If (Not System.String.IsNullOrEmpty(_Movil2)) Then _myArray(7) = _Movil2
			If (Not System.String.IsNullOrEmpty(_Email2)) Then _myArray(8) = _Email2
			If (_IdCliente.HasValue) Then _myArray(9) = _IdCliente.Value
			If (Not System.String.IsNullOrEmpty(_Trato)) Then _myArray(10) = _Trato
			
            Return _myArray
        
        End Function

        Private Function GetFieldsForDelete() As Object() Implements IMappeableClieContactosObject.GetFieldsForDelete
        
            Dim _myArray(0) As Object
            _myArray(0) = _IdClicontactos
			
            Return _myArray
        
        End Function


        Private Sub UpdateObjectFromOutputParams(parameters As Object()) Implements IMappeableClieContactosObject.UpdateObjectFromOutputParams
            ' Update properties from Output parameters
            _IdClicontactos = CType(parameters(0), System.Int32)

        End Sub

        Private Function Identifier() As Object() Implements IUniqueIdentifiable.Identifier
            Dim o As ClieContactosObject = Nothing
            If ObjectStateHelper.IsModified(Me) Then
                o = Me.OriginalValue()
            Else
                o = Me
            End If

            Return New Object() {o.IdClicontactos}
        End Function


        Public Overloads Function Equals(other As ClieContactosObject) As Boolean Implements IEquatable(Of ClieContactosObject).Equals
            Return UniqueIdentifierHelper.IsSameObject(CType(Me, IUniqueIdentifiable), CType(other, IUniqueIdentifiable))
        End Function


    End Class

    Public Interface IMappeableClieContactosObject
        Sub HydrateFields( ByVal IdClicontactos As System.Int32, _
				 ByVal Nombre As System.String, _
				 ByVal Anexo As System.String, _
				 ByVal TipMovil1 As System.String, _
				 ByVal Movil1 As System.String, _
				 ByVal Email1 As System.String, _
				 ByVal TipMovil2 As System.String, _
				 ByVal Movil2 As System.String, _
				 ByVal Email2 As System.String, _
				 ByVal IdCliente As System.Nullable(Of System.Int32) , _
				 ByVal Trato As System.String)

        Function GetFieldsForInsert() As Object() 

        Function GetFieldsForUpdate() As Object() 

        Function GetFieldsForDelete() As Object()

        Sub UpdateObjectFromOutputParams(ByVal parameters As Object() )
    End Interface

    Public Partial Class ClieContactosObjectList
        Inherits ObjectList(Of ClieContactosObject)
    End Class
End Namespace

Namespace Views
    Partial Public Class ClieContactosObjectListView
        Inherits ObjectListView(Of Objects.ClieContactosObject)

        Sub New(ByVal list As Objects.ClieContactosObjectList)
            MyBase.New(list)
        End Sub
    End Class
End NameSpace


