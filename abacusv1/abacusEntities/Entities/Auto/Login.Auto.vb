
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 20/08/2013 - 01:49 p.m.
' This is a partial class file. The other one is LoginEntity.cs
' You should not modifiy this file, please edit the other partial class file.
'------------------------------------------------------------------------------

Imports abacusRules.Objects


Imports Cooperator.Framework.Core
Imports Cooperator.Framework.Core.LazyLoad
Imports System

Namespace Entities

    Public Partial Class Login
        Inherits Objects.LoginObject
        Implements IMappeableLogin
        Implements IEquatable(Of Login)
        Implements ICloneable

        #Region "Ctor"

        Public Sub New()
            MyBase.New()
            
        End Sub

        
        Public Sub New (ByVal Idlogin As System.Int32)
            MyBase.New()

			_Idlogin = Idlogin

            
            Call Initialized()
        End Sub
        

        
        Public Sub New(ByVal Idlogin As System.Int32, _
			ByVal IdProveedor As System.Nullable(Of System.Int32), _
			ByVal Usuario As System.String, _
			ByVal Contraseña As System.String, _
			ByVal Administrador As System.Nullable(Of System.Boolean), _
			ByVal Produccion As System.Nullable(Of System.Boolean), _
			ByVal Lectura As System.Nullable(Of System.Boolean), _
			ByVal ProveedoresString As System.String)
            MyBase.New()

			_Idlogin = Idlogin
			_IdProveedor = IdProveedor
			_Usuario = Usuario
			_Contraseña = Contraseña
			_Administrador = Administrador
			_Produccion = Produccion
			_Lectura = Lectura
			_ProveedoresString = ProveedoresString

            
            Call Initialized()
        End Sub
        
        #End Region

        #Region "Fields"

        Protected  _ProveedoresEntity As Objects.ProveedoresObject

        #End Region

        #Region "Properties"
        
Dim _ProveedoresEntityFetched As Boolean
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property ProveedoresEntity As Objects.ProveedoresObject
            Get
                If _ProveedoresEntity Is Nothing  AndAlso Me.IdProveedor.HasValue AndAlso Not _ProveedoresEntityFetched  Then
_ProveedoresEntityFetched = True
Dim _ProveedoresEntityTemp As Objects.ProveedoresObject = New Objects.ProveedoresObject(Me.IdProveedor.Value) 
Dim lazyProvider As ILazyProvider = LazyProviderFactory.Get(GetType(Objects.ProveedoresObject))
 _ProveedoresEntity = CType(lazyProvider.GetEntity(GetType(Objects.ProveedoresObject), _ProveedoresEntityTemp), Objects.ProveedoresObject)
End If

                Return _ProveedoresEntity
            End Get
            Set (value As Objects.ProveedoresObject)
                MyBase.PropertyModified()
                _ProveedoresEntity = value
                If value IsNot Nothing Then
   _IdProveedor = value.IdProveedor
If value.Nombre IsNot Nothing Then 
_ProveedoresString = value.Nombre.ToString() 
Else
    _ProveedoresString = "" 
End If

Else 
   _IdProveedor = Nothing
_ProveedoresString = ""
End If

                            CorrectDescriptionField(value)


            End Set
        End Property
        
        #End Region

        ''' <summary>
        ''' Returns de original value of entity since was created or restored. 
        ''' </summary>
        Public Shadows Function OriginalValue() As Login 
                Return CType(MyBase.OriginalValue, Login)
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Protected Overrides Function Clone() As Object 
            Dim newObject As Login 
            

            newObject = CType(Me.MemberwiseClone(), Login)
            ' Entities
                         
            If Me._ProveedoresEntity IsNot Nothing Then
                newObject._ProveedoresEntity = CType(CType(Me._ProveedoresEntity, ICloneable).Clone(),Objects.ProveedoresObject)
            End If
            
            ' Colections
            
            ' OriginalValue
            Dim newOriginalValue As Login
            If MyBase.InternalOriginalValue IsNot Nothing Then
                newOriginalValue = CType(Me.OriginalValue().MemberwiseClone(), Login)
                ' Entities
                             
                If Me.OriginalValue()._ProveedoresEntity IsNot Nothing Then
                    newOriginalValue._ProveedoresEntity = CType(CType(Me.OriginalValue()._ProveedoresEntity, ICloneable).Clone(), Objects.ProveedoresObject)
                End If
                
                ' Colections
                            
                newObject.InternalOriginalValue = newOriginalValue

            End If
            Return newObject
        End Function



        Private Sub CompleteEntity(ProveedoresEntity As Objects.ProveedoresObject) Implements IMappeableLogin.CompleteEntity
        _ProveedoresEntity = ProveedoresEntity
        End Sub

        
        Private Function IsProveedoresEntityNull() As Boolean Implements IMappeableLogin.IsProveedoresEntityNull
            Return IsNothing(_ProveedoresEntity)
        End Function
        

        Private Sub SetFKValuesForChilds(entity As Login) Implements IMappeableLogin.SetFKValuesForChilds
                
        End Sub

        Public Overloads Function Equals(other As Login) As Boolean Implements IEquatable(Of Login).Equals
            Return UniqueIdentifierHelper.IsSameObject(CType(Me, IUniqueIdentifiable), CType(other, IUniqueIdentifiable))
        End Function

    End Class

    Public Interface IMappeableLogin
        Sub CompleteEntity(ProveedoresEntity As Objects.ProveedoresObject)
        
        Function IsProveedoresEntityNull() As Boolean
        
        Sub SetFKValuesForChilds(entity As Login )
    End Interface

    Public Partial Class LoginList
        Inherits ObjectList(Of Login)    
    End Class
End Namespace

Namespace Views
    Partial Public Class LoginListView
        Inherits ObjectListView(Of Entities.Login)

        Sub New(ByVal list As Entities.LoginList)
            MyBase.New(list)
        End Sub
    End Class
End NameSpace


