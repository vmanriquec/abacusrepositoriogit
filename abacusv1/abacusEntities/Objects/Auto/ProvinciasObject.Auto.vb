
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 20/08/2013 - 01:48 p.m.
' This is a Partial class file. The other one is ProvinciasObject.vb
' You should not modifiy this file, please edit the other partial class file.
'------------------------------------------------------------------------------

Imports Cooperator.Framework.Core
Imports System

Namespace Objects

    Public Partial Class ProvinciasObject
        Inherits BaseObject
        Implements IMappeableProvinciasObject
        Implements IUniqueIdentifiable
        Implements IEquatable(Of ProvinciasObject)
        Implements ICloneable

#Region "Ctor"

        Public Sub New()
            MyBase.New()

			_IdProvincia =  ValuesGenerator.GetInt32

        End Sub

        
        Public Sub New(ByVal IdProvincia As System.Int32)
            MyBase.New()

			_IdProvincia = IdProvincia

            Call Initialized()
        End Sub
        

        
        Public Sub New(ByVal IdProvincia As System.Int32, _
			ByVal Provincia As System.String)
            MyBase.New()

			_IdProvincia = IdProvincia
			_Provincia = Provincia

            Call Initialized()
        End Sub
        

#End Region

#Region "Events"

        
#End Region

#Region "Fields"

        Protected _IdProvincia As System.Int32
Protected _Provincia As System.String

#End Region

#Region "Properties"
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable ReadOnly Property IdProvincia As System.Int32
            Get
                Return _IdProvincia
            End Get
            
        End Property
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property Provincia As System.String
            Get
                Return _Provincia
            End Get
            
            Set
                MyBase.PropertyModified()
                _Provincia = value
                
            End Set
            
        End Property
        
        #End Region

        

        Protected Overrides Sub SetOriginalValue()
            MyBase.InternalOriginalValue = CType(Me.MemberwiseClone(), IObject)
        End Sub

        Protected Overridable Function Clone() As Object Implements ICloneable.Clone
            Dim newObject As ProvinciasObject 
            Dim newOriginalValue As ProvinciasObject 

            newObject = CType(Me.MemberwiseClone(), ProvinciasObject) 
            If (MyBase.InternalOriginalValue IsNot Nothing) Then
                newOriginalValue = CType(Me.OriginalValue().MemberwiseClone(), ProvinciasObject)
                newObject.InternalOriginalValue = newOriginalValue
            End If
            Return newObject
        End Function


        ''' <summary>
        ''' Returns de original value of object since was created or restored.
        ''' </summary>
        Public Shadows Function OriginalValue() As ProvinciasObject 
           Return CType(MyBase.OriginalValue, ProvinciasObject)
        End Function


        Private Sub HydrateFields(ByVal IdProvincia As System.Int32, _
			ByVal Provincia As System.String) Implements IMappeableProvinciasObject.HydrateFields        
        	_IdProvincia = IdProvincia
			_Provincia = Provincia
        End Sub

        Private Function GetFieldsForInsert() As Object() Implements IMappeableProvinciasObject.GetFieldsForInsert
        
        
            Dim _myArray(1) As Object
            _myArray(0) = _IdProvincia
			If (Not System.String.IsNullOrEmpty(_Provincia)) Then _myArray(1) = _Provincia
			
            Return _myArray
        
        End Function

        Private Function GetFieldsForUpdate() As Object() Implements IMappeableProvinciasObject.GetFieldsForUpdate
        
        
            
            Dim _myArray(1) As Object
            _myArray(0) = _IdProvincia
			If (Not System.String.IsNullOrEmpty(_Provincia)) Then _myArray(1) = _Provincia
			
            Return _myArray
        
        End Function

        Private Function GetFieldsForDelete() As Object() Implements IMappeableProvinciasObject.GetFieldsForDelete
        
            Dim _myArray(0) As Object
            _myArray(0) = _IdProvincia
			
            Return _myArray
        
        End Function


        Private Sub UpdateObjectFromOutputParams(parameters As Object()) Implements IMappeableProvinciasObject.UpdateObjectFromOutputParams
            ' Update properties from Output parameters
            _IdProvincia = CType(parameters(0), System.Int32)

        End Sub

        Private Function Identifier() As Object() Implements IUniqueIdentifiable.Identifier
            Dim o As ProvinciasObject = Nothing
            If ObjectStateHelper.IsModified(Me) Then
                o = Me.OriginalValue()
            Else
                o = Me
            End If

            Return New Object() {o.IdProvincia}
        End Function


        Public Overloads Function Equals(other As ProvinciasObject) As Boolean Implements IEquatable(Of ProvinciasObject).Equals
            Return UniqueIdentifierHelper.IsSameObject(CType(Me, IUniqueIdentifiable), CType(other, IUniqueIdentifiable))
        End Function


    End Class

    Public Interface IMappeableProvinciasObject
        Sub HydrateFields( ByVal IdProvincia As System.Int32, _
				 ByVal Provincia As System.String)

        Function GetFieldsForInsert() As Object() 

        Function GetFieldsForUpdate() As Object() 

        Function GetFieldsForDelete() As Object()

        Sub UpdateObjectFromOutputParams(ByVal parameters As Object() )
    End Interface

    Public Partial Class ProvinciasObjectList
        Inherits ObjectList(Of ProvinciasObject)
    End Class
End Namespace

Namespace Views
    Partial Public Class ProvinciasObjectListView
        Inherits ObjectListView(Of Objects.ProvinciasObject)

        Sub New(ByVal list As Objects.ProvinciasObjectList)
            MyBase.New(list)
        End Sub
    End Class
End NameSpace

