
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 20/08/2013 - 01:48 p.m.
' This is a Partial class file. The other one is usuarioObject.vb
' You should not modifiy this file, please edit the other partial class file.
'------------------------------------------------------------------------------

Imports Cooperator.Framework.Core
Imports System

Namespace Objects

    Public Partial Class usuarioObject
        Inherits BaseObject
        Implements IMappeableusuarioObject
        Implements IUniqueIdentifiable
        Implements IEquatable(Of usuarioObject)
        Implements ICloneable

#Region "Ctor"

        Public Sub New()
            MyBase.New()


        End Sub

        
        Public Sub New(ByVal idusuario As System.Int32)
            MyBase.New()

			_idusuario = idusuario

            Call Initialized()
        End Sub
        

        
        Public Sub New(ByVal nombreusuario As System.String, _
			ByVal claveusuario As System.String, _
			ByVal descripcion As System.String, _
			ByVal estado As System.String, _
			ByVal idusuario As System.Int32, _
			ByVal idtipousuario As System.Nullable(Of System.Int32), _
			ByVal idtrabjador As System.Nullable(Of System.Int32), _
			ByVal tipousuarioString As System.String, _
			ByVal TrabajadoresString As System.String)
            MyBase.New()

			_nombreusuario = nombreusuario
			_claveusuario = claveusuario
			_descripcion = descripcion
			_estado = estado
			_idusuario = idusuario
			_idtipousuario = idtipousuario
			_idtrabjador = idtrabjador
			_tipousuarioString = tipousuarioString
			_TrabajadoresString = TrabajadoresString

            Call Initialized()
        End Sub
        

#End Region

#Region "Events"

        
        Public Event Update_tipousuarioString(ByVal sender As Object, ByVal e As DescriptionFieldEventArg)
        
        Public Event Update_TrabajadoresString(ByVal sender As Object, ByVal e As DescriptionFieldEventArg)
        
#End Region

#Region "Fields"

        Protected _nombreusuario As System.String
Protected _claveusuario As System.String
Protected _descripcion As System.String
Protected _estado As System.String
Protected _idusuario As System.Int32
Protected _idtipousuario As System.Nullable(Of System.Int32) 
Protected _idtrabjador As System.Nullable(Of System.Int32) 
Protected _tipousuarioString As System.String
Protected _TrabajadoresString As System.String

#End Region

#Region "Properties"
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable ReadOnly Property nombreusuario As System.String
            Get
                Return _nombreusuario
            End Get
            
        End Property
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable ReadOnly Property claveusuario As System.String
            Get
                Return _claveusuario
            End Get
            
        End Property
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable ReadOnly Property descripcion As System.String
            Get
                Return _descripcion
            End Get
            
        End Property
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable ReadOnly Property estado As System.String
            Get
                Return _estado
            End Get
            
        End Property
        
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable ReadOnly Property idusuario As System.Int32
            Get
                Return _idusuario
            End Get
            
        End Property
        
        ''' <summary>
        ''' Nullable property
        ''' </summary>
        Public Overridable ReadOnly Property idtipousuario As System.Nullable(Of System.Int32) 
            Get        
                Return _idtipousuario
            End Get
            
        End Property
                
        ''' <summary>
        ''' Nullable property
        ''' </summary>
        Public Overridable ReadOnly Property idtrabjador As System.Nullable(Of System.Int32) 
            Get        
                Return _idtrabjador
            End Get
            
        End Property
                
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable ReadOnly Property tipousuarioString As System.String
            Get
                Return _tipousuarioString
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
            Dim newObject As usuarioObject 
            Dim newOriginalValue As usuarioObject 

            newObject = CType(Me.MemberwiseClone(), usuarioObject) 
            If (MyBase.InternalOriginalValue IsNot Nothing) Then
                newOriginalValue = CType(Me.OriginalValue().MemberwiseClone(), usuarioObject)
                newObject.InternalOriginalValue = newOriginalValue
            End If
            Return newObject
        End Function


        ''' <summary>
        ''' Returns de original value of object since was created or restored.
        ''' </summary>
        Public Shadows Function OriginalValue() As usuarioObject 
           Return CType(MyBase.OriginalValue, usuarioObject)
        End Function


        Private Sub HydrateFields(ByVal nombreusuario As System.String, _
			ByVal claveusuario As System.String, _
			ByVal descripcion As System.String, _
			ByVal estado As System.String, _
			ByVal idusuario As System.Int32, _
			ByVal idtipousuario As System.Nullable(Of System.Int32) , _
			ByVal idtrabjador As System.Nullable(Of System.Int32) , _
			ByVal tipousuarioString As System.String, _
			ByVal TrabajadoresString As System.String) Implements IMappeableusuarioObject.HydrateFields        
        	_nombreusuario = nombreusuario
			_claveusuario = claveusuario
			_descripcion = descripcion
			_estado = estado
			_idusuario = idusuario
			_idtipousuario = idtipousuario
			_idtrabjador = idtrabjador
			_tipousuarioString = tipousuarioString
			_TrabajadoresString = TrabajadoresString
        End Sub

        Private Function GetFieldsForInsert() As Object() Implements IMappeableusuarioObject.GetFieldsForInsert
        
        
            Dim _myArray(2) As Object
            _myArray(0) = _idusuario
			If (_idtipousuario.HasValue) Then _myArray(1) = _idtipousuario.Value
			If (_idtrabjador.HasValue) Then _myArray(2) = _idtrabjador.Value
			
            Return _myArray
        
        End Function

        Private Function GetFieldsForUpdate() As Object() Implements IMappeableusuarioObject.GetFieldsForUpdate
        
        
            
            Dim _myArray(3) As Object
            _myArray(0) = _idusuario
			If (_idtipousuario.HasValue) Then _myArray(1) = _idtipousuario.Value
			If (_idtrabjador.HasValue) Then _myArray(2) = _idtrabjador.Value
			_myArray(3) = Me.OriginalValue()._idusuario
			
            Return _myArray
        
        End Function

        Private Function GetFieldsForDelete() As Object() Implements IMappeableusuarioObject.GetFieldsForDelete
        
            Dim _myArray(0) As Object
            _myArray(0) = _idusuario
			
            Return _myArray
        
        End Function


        Private Sub UpdateObjectFromOutputParams(parameters As Object()) Implements IMappeableusuarioObject.UpdateObjectFromOutputParams
            ' Update properties from Output parameters
            
        End Sub

        Private Function Identifier() As Object() Implements IUniqueIdentifiable.Identifier
            Dim o As usuarioObject = Nothing
            If ObjectStateHelper.IsModified(Me) Then
                o = Me.OriginalValue()
            Else
                o = Me
            End If

            Return New Object() {o.idusuario}
        End Function


        Public Overloads Function Equals(other As usuarioObject) As Boolean Implements IEquatable(Of usuarioObject).Equals
            Return UniqueIdentifierHelper.IsSameObject(CType(Me, IUniqueIdentifiable), CType(other, IUniqueIdentifiable))
        End Function


    End Class

    Public Interface IMappeableusuarioObject
        Sub HydrateFields( ByVal nombreusuario As System.String, _
				 ByVal claveusuario As System.String, _
				 ByVal descripcion As System.String, _
				 ByVal estado As System.String, _
				 ByVal idusuario As System.Int32, _
				 ByVal idtipousuario As System.Nullable(Of System.Int32) , _
				 ByVal idtrabjador As System.Nullable(Of System.Int32) , _
				 ByVal tipousuarioString As System.String, _
				 ByVal TrabajadoresString As System.String)

        Function GetFieldsForInsert() As Object() 

        Function GetFieldsForUpdate() As Object() 

        Function GetFieldsForDelete() As Object()

        Sub UpdateObjectFromOutputParams(ByVal parameters As Object() )
    End Interface

    Public Partial Class usuarioObjectList
        Inherits ObjectList(Of usuarioObject)
    End Class
End Namespace

Namespace Views
    Partial Public Class usuarioObjectListView
        Inherits ObjectListView(Of Objects.usuarioObject)

        Sub New(ByVal list As Objects.usuarioObjectList)
            MyBase.New(list)
        End Sub
    End Class
End NameSpace

