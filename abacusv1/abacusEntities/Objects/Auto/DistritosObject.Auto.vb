
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 20/08/2013 - 01:48 p.m.
' This is a Partial class file. The other one is DistritosObject.vb
' You should not modifiy this file, please edit the other partial class file.
'------------------------------------------------------------------------------

Imports Cooperator.Framework.Core
Imports System

Namespace Objects

    Public Partial Class DistritosObject
        Inherits BaseObject
        Implements IMappeableDistritosObject
        Implements IUniqueIdentifiable
        Implements IEquatable(Of DistritosObject)
        Implements ICloneable

#Region "Ctor"

        Public Sub New()
            MyBase.New()

			_IdDistrito =  ValuesGenerator.GetInt32

        End Sub

        
        Public Sub New(ByVal IdDistrito As System.Int32)
            MyBase.New()

			_IdDistrito = IdDistrito

            Call Initialized()
        End Sub
        

        
        Public Sub New(ByVal IdDistrito As System.Int32, _
			ByVal IdProvincia As System.Nullable(Of System.Int32), _
			ByVal Distrito As System.String)
            MyBase.New()

			_IdDistrito = IdDistrito
			_IdProvincia = IdProvincia
			_Distrito = Distrito

            Call Initialized()
        End Sub
        

#End Region

#Region "Events"

        
#End Region

#Region "Fields"

        Protected _IdDistrito As System.Int32
Protected _IdProvincia As System.Nullable(Of System.Int32) 
Protected _Distrito As System.String

#End Region

#Region "Properties"
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable ReadOnly Property IdDistrito As System.Int32
            Get
                Return _IdDistrito
            End Get
            
        End Property
        
        ''' <summary>
        ''' Nullable property
        ''' </summary>
        Public Overridable Property IdProvincia As System.Nullable(Of System.Int32) 
            Get        
                Return _IdProvincia
            End Get
            
            Set
                MyBase.PropertyModified()
                _IdProvincia = value
                
            End Set
            
        End Property
                
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property Distrito As System.String
            Get
                Return _Distrito
            End Get
            
            Set
                MyBase.PropertyModified()
                _Distrito = value
                
            End Set
            
        End Property
        
        #End Region

        

        Protected Overrides Sub SetOriginalValue()
            MyBase.InternalOriginalValue = CType(Me.MemberwiseClone(), IObject)
        End Sub

        Protected Overridable Function Clone() As Object Implements ICloneable.Clone
            Dim newObject As DistritosObject 
            Dim newOriginalValue As DistritosObject 

            newObject = CType(Me.MemberwiseClone(), DistritosObject) 
            If (MyBase.InternalOriginalValue IsNot Nothing) Then
                newOriginalValue = CType(Me.OriginalValue().MemberwiseClone(), DistritosObject)
                newObject.InternalOriginalValue = newOriginalValue
            End If
            Return newObject
        End Function


        ''' <summary>
        ''' Returns de original value of object since was created or restored.
        ''' </summary>
        Public Shadows Function OriginalValue() As DistritosObject 
           Return CType(MyBase.OriginalValue, DistritosObject)
        End Function


        Private Sub HydrateFields(ByVal IdDistrito As System.Int32, _
			ByVal IdProvincia As System.Nullable(Of System.Int32) , _
			ByVal Distrito As System.String) Implements IMappeableDistritosObject.HydrateFields        
        	_IdDistrito = IdDistrito
			_IdProvincia = IdProvincia
			_Distrito = Distrito
        End Sub

        Private Function GetFieldsForInsert() As Object() Implements IMappeableDistritosObject.GetFieldsForInsert
        
        
            Dim _myArray(2) As Object
            _myArray(0) = _IdDistrito
			If (_IdProvincia.HasValue) Then _myArray(1) = _IdProvincia.Value
			If (Not System.String.IsNullOrEmpty(_Distrito)) Then _myArray(2) = _Distrito
			
            Return _myArray
        
        End Function

        Private Function GetFieldsForUpdate() As Object() Implements IMappeableDistritosObject.GetFieldsForUpdate
        
        
            
            Dim _myArray(2) As Object
            _myArray(0) = _IdDistrito
			If (_IdProvincia.HasValue) Then _myArray(1) = _IdProvincia.Value
			If (Not System.String.IsNullOrEmpty(_Distrito)) Then _myArray(2) = _Distrito
			
            Return _myArray
        
        End Function

        Private Function GetFieldsForDelete() As Object() Implements IMappeableDistritosObject.GetFieldsForDelete
        
            Dim _myArray(0) As Object
            _myArray(0) = _IdDistrito
			
            Return _myArray
        
        End Function


        Private Sub UpdateObjectFromOutputParams(parameters As Object()) Implements IMappeableDistritosObject.UpdateObjectFromOutputParams
            ' Update properties from Output parameters
            _IdDistrito = CType(parameters(0), System.Int32)

        End Sub

        Private Function Identifier() As Object() Implements IUniqueIdentifiable.Identifier
            Dim o As DistritosObject = Nothing
            If ObjectStateHelper.IsModified(Me) Then
                o = Me.OriginalValue()
            Else
                o = Me
            End If

            Return New Object() {o.IdDistrito}
        End Function


        Public Overloads Function Equals(other As DistritosObject) As Boolean Implements IEquatable(Of DistritosObject).Equals
            Return UniqueIdentifierHelper.IsSameObject(CType(Me, IUniqueIdentifiable), CType(other, IUniqueIdentifiable))
        End Function


    End Class

    Public Interface IMappeableDistritosObject
        Sub HydrateFields( ByVal IdDistrito As System.Int32, _
				 ByVal IdProvincia As System.Nullable(Of System.Int32) , _
				 ByVal Distrito As System.String)

        Function GetFieldsForInsert() As Object() 

        Function GetFieldsForUpdate() As Object() 

        Function GetFieldsForDelete() As Object()

        Sub UpdateObjectFromOutputParams(ByVal parameters As Object() )
    End Interface

    Public Partial Class DistritosObjectList
        Inherits ObjectList(Of DistritosObject)
    End Class
End Namespace

Namespace Views
    Partial Public Class DistritosObjectListView
        Inherits ObjectListView(Of Objects.DistritosObject)

        Sub New(ByVal list As Objects.DistritosObjectList)
            MyBase.New(list)
        End Sub
    End Class
End NameSpace

