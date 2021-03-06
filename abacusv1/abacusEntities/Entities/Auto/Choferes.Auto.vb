
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 20/08/2013 - 01:49 p.m.
' This is a partial class file. The other one is ChoferesEntity.cs
' You should not modifiy this file, please edit the other partial class file.
'------------------------------------------------------------------------------

Imports abacusRules.Objects


Imports Cooperator.Framework.Core
Imports Cooperator.Framework.Core.LazyLoad
Imports System

Namespace Entities

    Public Partial Class Choferes
        Inherits Objects.ChoferesObject
        Implements IMappeableChoferes
        Implements IEquatable(Of Choferes)
        Implements ICloneable

        #Region "Ctor"

        Public Sub New()
            MyBase.New()
            
        End Sub

        
        Public Sub New (ByVal IdChofer As System.Int32)
            MyBase.New()

			_IdChofer = IdChofer

            
            Call Initialized()
        End Sub
        

        
        Public Sub New(ByVal IdChofer As System.Int32, _
			ByVal Nombres As System.String, _
			ByVal Apellidos As System.String, _
			ByVal DNI As System.String, _
			ByVal Brevete As System.String, _
			ByVal FecNacimiento As System.Nullable(Of System.DateTime), _
			ByVal IdTransportista As System.Nullable(Of System.Int32), _
			ByVal TransportistaString As System.String)
            MyBase.New()

			_IdChofer = IdChofer
			_Nombres = Nombres
			_Apellidos = Apellidos
			_DNI = DNI
			_Brevete = Brevete
			_FecNacimiento = FecNacimiento
			_IdTransportista = IdTransportista
			_TransportistaString = TransportistaString

            
            Call Initialized()
        End Sub
        
        #End Region

        #Region "Fields"

        Protected  _TransportistaEntity As Objects.TransportistaObject

        #End Region

        #Region "Properties"
        
Dim _TransportistaEntityFetched As Boolean
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property TransportistaEntity As Objects.TransportistaObject
            Get
                If _TransportistaEntity Is Nothing  AndAlso Me.IdTransportista.HasValue AndAlso Not _TransportistaEntityFetched  Then
_TransportistaEntityFetched = True
Dim _TransportistaEntityTemp As Objects.TransportistaObject = New Objects.TransportistaObject(Me.IdTransportista.Value) 
Dim lazyProvider As ILazyProvider = LazyProviderFactory.Get(GetType(Objects.TransportistaObject))
 _TransportistaEntity = CType(lazyProvider.GetEntity(GetType(Objects.TransportistaObject), _TransportistaEntityTemp), Objects.TransportistaObject)
End If

                Return _TransportistaEntity
            End Get
            Set (value As Objects.TransportistaObject)
                MyBase.PropertyModified()
                _TransportistaEntity = value
                If value IsNot Nothing Then
   _IdTransportista = value.IdTransportista
If value.RUC IsNot Nothing Then 
_TransportistaString = value.RUC.ToString() 
Else
    _TransportistaString = "" 
End If

Else 
   _IdTransportista = Nothing
_TransportistaString = ""
End If

                            CorrectDescriptionField(value)


            End Set
        End Property
        
        #End Region

        ''' <summary>
        ''' Returns de original value of entity since was created or restored. 
        ''' </summary>
        Public Shadows Function OriginalValue() As Choferes 
                Return CType(MyBase.OriginalValue, Choferes)
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Protected Overrides Function Clone() As Object 
            Dim newObject As Choferes 
            

            newObject = CType(Me.MemberwiseClone(), Choferes)
            ' Entities
                         
            If Me._TransportistaEntity IsNot Nothing Then
                newObject._TransportistaEntity = CType(CType(Me._TransportistaEntity, ICloneable).Clone(),Objects.TransportistaObject)
            End If
            
            ' Colections
            
            ' OriginalValue
            Dim newOriginalValue As Choferes
            If MyBase.InternalOriginalValue IsNot Nothing Then
                newOriginalValue = CType(Me.OriginalValue().MemberwiseClone(), Choferes)
                ' Entities
                             
                If Me.OriginalValue()._TransportistaEntity IsNot Nothing Then
                    newOriginalValue._TransportistaEntity = CType(CType(Me.OriginalValue()._TransportistaEntity, ICloneable).Clone(), Objects.TransportistaObject)
                End If
                
                ' Colections
                            
                newObject.InternalOriginalValue = newOriginalValue

            End If
            Return newObject
        End Function



        Private Sub CompleteEntity(TransportistaEntity As Objects.TransportistaObject) Implements IMappeableChoferes.CompleteEntity
        _TransportistaEntity = TransportistaEntity
        End Sub

        
        Private Function IsTransportistaEntityNull() As Boolean Implements IMappeableChoferes.IsTransportistaEntityNull
            Return IsNothing(_TransportistaEntity)
        End Function
        

        Private Sub SetFKValuesForChilds(entity As Choferes) Implements IMappeableChoferes.SetFKValuesForChilds
                
        End Sub

        Public Overloads Function Equals(other As Choferes) As Boolean Implements IEquatable(Of Choferes).Equals
            Return UniqueIdentifierHelper.IsSameObject(CType(Me, IUniqueIdentifiable), CType(other, IUniqueIdentifiable))
        End Function

    End Class

    Public Interface IMappeableChoferes
        Sub CompleteEntity(TransportistaEntity As Objects.TransportistaObject)
        
        Function IsTransportistaEntityNull() As Boolean
        
        Sub SetFKValuesForChilds(entity As Choferes )
    End Interface

    Public Partial Class ChoferesList
        Inherits ObjectList(Of Choferes)    
    End Class
End Namespace

Namespace Views
    Partial Public Class ChoferesListView
        Inherits ObjectListView(Of Entities.Choferes)

        Sub New(ByVal list As Entities.ChoferesList)
            MyBase.New(list)
        End Sub
    End Class
End NameSpace


