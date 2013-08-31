
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 20/08/2013 - 01:49 p.m.
' This is a partial class file. The other one is usuarioEntity.cs
' You should not modifiy this file, please edit the other partial class file.
'------------------------------------------------------------------------------

Imports abacusRules.Objects


Imports Cooperator.Framework.Core
Imports Cooperator.Framework.Core.LazyLoad
Imports System

Namespace Entities

    Public Partial Class usuario
        Inherits Objects.usuarioObject
        Implements IMappeableusuario
        Implements IEquatable(Of usuario)
        Implements ICloneable

        #Region "Ctor"

        Public Sub New()
            MyBase.New()
            
        End Sub

        
        Public Sub New (ByVal idusuario As System.Int32)
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

        #Region "Fields"

        Protected  _tipousuarioEntity As Objects.tipousuarioObject
Protected  _TrabajadoresEntity As Objects.TrabajadoresObject

        #End Region

        #Region "Properties"
        
Dim _tipousuarioEntityFetched As Boolean
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property tipousuarioEntity As Objects.tipousuarioObject
            Get
                If _tipousuarioEntity Is Nothing  AndAlso Me.idtipousuario.HasValue AndAlso Not _tipousuarioEntityFetched  Then
_tipousuarioEntityFetched = True
Dim _tipousuarioEntityTemp As Objects.tipousuarioObject = New Objects.tipousuarioObject(Me.idtipousuario.Value) 
Dim lazyProvider As ILazyProvider = LazyProviderFactory.Get(GetType(Objects.tipousuarioObject))
 _tipousuarioEntity = CType(lazyProvider.GetEntity(GetType(Objects.tipousuarioObject), _tipousuarioEntityTemp), Objects.tipousuarioObject)
End If

                Return _tipousuarioEntity
            End Get
            Set (value As Objects.tipousuarioObject)
                MyBase.PropertyModified()
                _tipousuarioEntity = value
                If value IsNot Nothing Then
   _idtipousuario = value.idtipousuario
If value.nombretipousuario IsNot Nothing Then 
_tipousuarioString = value.nombretipousuario.ToString() 
Else
    _tipousuarioString = "" 
End If

Else 
   _idtipousuario = Nothing
_tipousuarioString = ""
End If

                            CorrectDescriptionField(value)


            End Set
        End Property
        
Dim _TrabajadoresEntityFetched As Boolean
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property TrabajadoresEntity As Objects.TrabajadoresObject
            Get
                If _TrabajadoresEntity Is Nothing  AndAlso Me.idtrabjador.HasValue AndAlso Not _TrabajadoresEntityFetched  Then
_TrabajadoresEntityFetched = True
Dim _TrabajadoresEntityTemp As Objects.TrabajadoresObject = New Objects.TrabajadoresObject(Me.idtrabjador.Value) 
Dim lazyProvider As ILazyProvider = LazyProviderFactory.Get(GetType(Objects.TrabajadoresObject))
 _TrabajadoresEntity = CType(lazyProvider.GetEntity(GetType(Objects.TrabajadoresObject), _TrabajadoresEntityTemp), Objects.TrabajadoresObject)
End If

                Return _TrabajadoresEntity
            End Get
            Set (value As Objects.TrabajadoresObject)
                MyBase.PropertyModified()
                _TrabajadoresEntity = value
                If value IsNot Nothing Then
   _idtrabjador = value.IdTrabjador
If value.Nombres IsNot Nothing Then 
_TrabajadoresString = value.Nombres.ToString() 
Else
    _TrabajadoresString = "" 
End If

Else 
   _idtrabjador = Nothing
_TrabajadoresString = ""
End If

                            CorrectDescriptionField(value)


            End Set
        End Property
        
        #End Region

        ''' <summary>
        ''' Returns de original value of entity since was created or restored. 
        ''' </summary>
        Public Shadows Function OriginalValue() As usuario 
                Return CType(MyBase.OriginalValue, usuario)
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Protected Overrides Function Clone() As Object 
            Dim newObject As usuario 
            

            newObject = CType(Me.MemberwiseClone(), usuario)
            ' Entities
                         
            If Me._tipousuarioEntity IsNot Nothing Then
                newObject._tipousuarioEntity = CType(CType(Me._tipousuarioEntity, ICloneable).Clone(),Objects.tipousuarioObject)
            End If
                         
            If Me._TrabajadoresEntity IsNot Nothing Then
                newObject._TrabajadoresEntity = CType(CType(Me._TrabajadoresEntity, ICloneable).Clone(),Objects.TrabajadoresObject)
            End If
            
            ' Colections
            
            ' OriginalValue
            Dim newOriginalValue As usuario
            If MyBase.InternalOriginalValue IsNot Nothing Then
                newOriginalValue = CType(Me.OriginalValue().MemberwiseClone(), usuario)
                ' Entities
                             
                If Me.OriginalValue()._tipousuarioEntity IsNot Nothing Then
                    newOriginalValue._tipousuarioEntity = CType(CType(Me.OriginalValue()._tipousuarioEntity, ICloneable).Clone(), Objects.tipousuarioObject)
                End If
                             
                If Me.OriginalValue()._TrabajadoresEntity IsNot Nothing Then
                    newOriginalValue._TrabajadoresEntity = CType(CType(Me.OriginalValue()._TrabajadoresEntity, ICloneable).Clone(), Objects.TrabajadoresObject)
                End If
                
                ' Colections
                            
                newObject.InternalOriginalValue = newOriginalValue

            End If
            Return newObject
        End Function



        Private Sub CompleteEntity(tipousuarioEntity As Objects.tipousuarioObject, TrabajadoresEntity As Objects.TrabajadoresObject) Implements IMappeableusuario.CompleteEntity
        _tipousuarioEntity = tipousuarioEntity
_TrabajadoresEntity = TrabajadoresEntity
        End Sub

        
        Private Function IstipousuarioEntityNull() As Boolean Implements IMappeableusuario.IstipousuarioEntityNull
            Return IsNothing(_tipousuarioEntity)
        End Function
        
        Private Function IsTrabajadoresEntityNull() As Boolean Implements IMappeableusuario.IsTrabajadoresEntityNull
            Return IsNothing(_TrabajadoresEntity)
        End Function
        

        Private Sub SetFKValuesForChilds(entity As usuario) Implements IMappeableusuario.SetFKValuesForChilds
                
        End Sub

        Public Overloads Function Equals(other As usuario) As Boolean Implements IEquatable(Of usuario).Equals
            Return UniqueIdentifierHelper.IsSameObject(CType(Me, IUniqueIdentifiable), CType(other, IUniqueIdentifiable))
        End Function

    End Class

    Public Interface IMappeableusuario
        Sub CompleteEntity(tipousuarioEntity As Objects.tipousuarioObject, TrabajadoresEntity As Objects.TrabajadoresObject)
        
        Function IstipousuarioEntityNull() As Boolean
        
        Function IsTrabajadoresEntityNull() As Boolean
        
        Sub SetFKValuesForChilds(entity As usuario )
    End Interface

    Public Partial Class usuarioList
        Inherits ObjectList(Of usuario)    
    End Class
End Namespace

Namespace Views
    Partial Public Class usuarioListView
        Inherits ObjectListView(Of Entities.usuario)

        Sub New(ByVal list As Entities.usuarioList)
            MyBase.New(list)
        End Sub
    End Class
End NameSpace

