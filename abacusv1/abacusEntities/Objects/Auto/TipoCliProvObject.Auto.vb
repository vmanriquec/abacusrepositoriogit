
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 20/08/2013 - 01:48 p.m.
' This is a Partial class file. The other one is TipoCliProvObject.vb
' You should not modifiy this file, please edit the other partial class file.
'------------------------------------------------------------------------------

Imports Cooperator.Framework.Core
Imports System

Namespace Objects

    Public Partial Class TipoCliProvObject
        Inherits BaseObject
        Implements IMappeableTipoCliProvObject
        Implements IUniqueIdentifiable
        Implements IEquatable(Of TipoCliProvObject)
        Implements ICloneable

#Region "Ctor"

        Public Sub New()
            MyBase.New()

			_Id =  ValuesGenerator.GetInt32

        End Sub

        
        Public Sub New(ByVal Id As System.Int32)
            MyBase.New()

			_Id = Id

            Call Initialized()
        End Sub
        

        
        Public Sub New(ByVal Id As System.Int32, _
			ByVal Tipo As System.String)
            MyBase.New()

			_Id = Id
			_Tipo = Tipo

            Call Initialized()
        End Sub
        

#End Region

#Region "Events"

        
#End Region

#Region "Fields"

        Protected _Id As System.Int32
Protected _Tipo As System.String

#End Region

#Region "Properties"
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable ReadOnly Property Id As System.Int32
            Get
                Return _Id
            End Get
            
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
        
        #End Region

        

        Protected Overrides Sub SetOriginalValue()
            MyBase.InternalOriginalValue = CType(Me.MemberwiseClone(), IObject)
        End Sub

        Protected Overridable Function Clone() As Object Implements ICloneable.Clone
            Dim newObject As TipoCliProvObject 
            Dim newOriginalValue As TipoCliProvObject 

            newObject = CType(Me.MemberwiseClone(), TipoCliProvObject) 
            If (MyBase.InternalOriginalValue IsNot Nothing) Then
                newOriginalValue = CType(Me.OriginalValue().MemberwiseClone(), TipoCliProvObject)
                newObject.InternalOriginalValue = newOriginalValue
            End If
            Return newObject
        End Function


        ''' <summary>
        ''' Returns de original value of object since was created or restored.
        ''' </summary>
        Public Shadows Function OriginalValue() As TipoCliProvObject 
           Return CType(MyBase.OriginalValue, TipoCliProvObject)
        End Function


        Private Sub HydrateFields(ByVal Id As System.Int32, _
			ByVal Tipo As System.String) Implements IMappeableTipoCliProvObject.HydrateFields        
        	_Id = Id
			_Tipo = Tipo
        End Sub

        Private Function GetFieldsForInsert() As Object() Implements IMappeableTipoCliProvObject.GetFieldsForInsert
        
        
            Dim _myArray(1) As Object
            _myArray(0) = _Id
			If (Not System.String.IsNullOrEmpty(_Tipo)) Then _myArray(1) = _Tipo
			
            Return _myArray
        
        End Function

        Private Function GetFieldsForUpdate() As Object() Implements IMappeableTipoCliProvObject.GetFieldsForUpdate
        
        
            
            Dim _myArray(1) As Object
            _myArray(0) = _Id
			If (Not System.String.IsNullOrEmpty(_Tipo)) Then _myArray(1) = _Tipo
			
            Return _myArray
        
        End Function

        Private Function GetFieldsForDelete() As Object() Implements IMappeableTipoCliProvObject.GetFieldsForDelete
        
            Dim _myArray(0) As Object
            _myArray(0) = _Id
			
            Return _myArray
        
        End Function


        Private Sub UpdateObjectFromOutputParams(parameters As Object()) Implements IMappeableTipoCliProvObject.UpdateObjectFromOutputParams
            ' Update properties from Output parameters
            _Id = CType(parameters(0), System.Int32)

        End Sub

        Private Function Identifier() As Object() Implements IUniqueIdentifiable.Identifier
            Dim o As TipoCliProvObject = Nothing
            If ObjectStateHelper.IsModified(Me) Then
                o = Me.OriginalValue()
            Else
                o = Me
            End If

            Return New Object() {o.Id}
        End Function


        Public Overloads Function Equals(other As TipoCliProvObject) As Boolean Implements IEquatable(Of TipoCliProvObject).Equals
            Return UniqueIdentifierHelper.IsSameObject(CType(Me, IUniqueIdentifiable), CType(other, IUniqueIdentifiable))
        End Function


    End Class

    Public Interface IMappeableTipoCliProvObject
        Sub HydrateFields( ByVal Id As System.Int32, _
				 ByVal Tipo As System.String)

        Function GetFieldsForInsert() As Object() 

        Function GetFieldsForUpdate() As Object() 

        Function GetFieldsForDelete() As Object()

        Sub UpdateObjectFromOutputParams(ByVal parameters As Object() )
    End Interface

    Public Partial Class TipoCliProvObjectList
        Inherits ObjectList(Of TipoCliProvObject)
    End Class
End Namespace

Namespace Views
    Partial Public Class TipoCliProvObjectListView
        Inherits ObjectListView(Of Objects.TipoCliProvObject)

        Sub New(ByVal list As Objects.TipoCliProvObjectList)
            MyBase.New(list)
        End Sub
    End Class
End NameSpace

