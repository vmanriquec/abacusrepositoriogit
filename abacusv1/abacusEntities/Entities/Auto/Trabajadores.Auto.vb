
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 20/08/2013 - 01:49 p.m.
' This is a partial class file. The other one is TrabajadoresEntity.cs
' You should not modifiy this file, please edit the other partial class file.
'------------------------------------------------------------------------------

Imports abacusRules.Objects


Imports Cooperator.Framework.Core
Imports Cooperator.Framework.Core.LazyLoad
Imports System

Namespace Entities

    Public Partial Class Trabajadores
        Inherits Objects.TrabajadoresObject
        Implements IMappeableTrabajadores
        Implements IEquatable(Of Trabajadores)
        Implements ICloneable

        #Region "Ctor"

        Public Sub New()
            MyBase.New()
            
        End Sub

        
        Public Sub New (ByVal IdTrabjador As System.Int32)
            MyBase.New()

			_IdTrabjador = IdTrabjador

            
            Call Initialized()
        End Sub
        

        
        Public Sub New(ByVal IdTrabjador As System.Int32, _
			ByVal idcargopersonal As System.Nullable(Of System.Int32), _
			ByVal Nombres As System.String, _
			ByVal Apellidos As System.String, _
			ByVal DNI As System.String, _
			ByVal Cargo As System.String, _
			ByVal FecNacimiento As System.Nullable(Of System.DateTime), _
			ByVal FecRegistro As System.Nullable(Of System.DateTime), _
			ByVal fecRetiro As System.Nullable(Of System.DateTime), _
			ByVal estado As System.String, _
			ByVal cargopersonalString As System.String)
            MyBase.New()

			_IdTrabjador = IdTrabjador
			_idcargopersonal = idcargopersonal
			_Nombres = Nombres
			_Apellidos = Apellidos
			_DNI = DNI
			_Cargo = Cargo
			_FecNacimiento = FecNacimiento
			_FecRegistro = FecRegistro
			_fecRetiro = fecRetiro
			_estado = estado
			_cargopersonalString = cargopersonalString

            
            Call Initialized()
        End Sub
        
        #End Region

        #Region "Fields"

        Protected  _cargopersonalEntity As Objects.cargopersonalObject

        #End Region

        #Region "Properties"
        
Dim _cargopersonalEntityFetched As Boolean
        ''' <summary>
        ''' 
        ''' </summary>
        Public Overridable Property cargopersonalEntity As Objects.cargopersonalObject
            Get
                If _cargopersonalEntity Is Nothing  AndAlso Me.idcargopersonal.HasValue AndAlso Not _cargopersonalEntityFetched  Then
_cargopersonalEntityFetched = True
Dim _cargopersonalEntityTemp As Objects.cargopersonalObject = New Objects.cargopersonalObject(Me.idcargopersonal.Value) 
Dim lazyProvider As ILazyProvider = LazyProviderFactory.Get(GetType(Objects.cargopersonalObject))
 _cargopersonalEntity = CType(lazyProvider.GetEntity(GetType(Objects.cargopersonalObject), _cargopersonalEntityTemp), Objects.cargopersonalObject)
End If

                Return _cargopersonalEntity
            End Get
            Set (value As Objects.cargopersonalObject)
                MyBase.PropertyModified()
                _cargopersonalEntity = value
                If value IsNot Nothing Then
   _idcargopersonal = value.idcargopersonal
If value.nombre IsNot Nothing Then 
_cargopersonalString = value.nombre.ToString() 
Else
    _cargopersonalString = "" 
End If

Else 
   _idcargopersonal = Nothing
_cargopersonalString = ""
End If

                            CorrectDescriptionField(value)


            End Set
        End Property
        
        #End Region

        ''' <summary>
        ''' Returns de original value of entity since was created or restored. 
        ''' </summary>
        Public Shadows Function OriginalValue() As Trabajadores 
                Return CType(MyBase.OriginalValue, Trabajadores)
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        Protected Overrides Function Clone() As Object 
            Dim newObject As Trabajadores 
            

            newObject = CType(Me.MemberwiseClone(), Trabajadores)
            ' Entities
                         
            If Me._cargopersonalEntity IsNot Nothing Then
                newObject._cargopersonalEntity = CType(CType(Me._cargopersonalEntity, ICloneable).Clone(),Objects.cargopersonalObject)
            End If
            
            ' Colections
            
            ' OriginalValue
            Dim newOriginalValue As Trabajadores
            If MyBase.InternalOriginalValue IsNot Nothing Then
                newOriginalValue = CType(Me.OriginalValue().MemberwiseClone(), Trabajadores)
                ' Entities
                             
                If Me.OriginalValue()._cargopersonalEntity IsNot Nothing Then
                    newOriginalValue._cargopersonalEntity = CType(CType(Me.OriginalValue()._cargopersonalEntity, ICloneable).Clone(), Objects.cargopersonalObject)
                End If
                
                ' Colections
                            
                newObject.InternalOriginalValue = newOriginalValue

            End If
            Return newObject
        End Function



        Private Sub CompleteEntity(cargopersonalEntity As Objects.cargopersonalObject) Implements IMappeableTrabajadores.CompleteEntity
        _cargopersonalEntity = cargopersonalEntity
        End Sub

        
        Private Function IscargopersonalEntityNull() As Boolean Implements IMappeableTrabajadores.IscargopersonalEntityNull
            Return IsNothing(_cargopersonalEntity)
        End Function
        

        Private Sub SetFKValuesForChilds(entity As Trabajadores) Implements IMappeableTrabajadores.SetFKValuesForChilds
                
        End Sub

        Public Overloads Function Equals(other As Trabajadores) As Boolean Implements IEquatable(Of Trabajadores).Equals
            Return UniqueIdentifierHelper.IsSameObject(CType(Me, IUniqueIdentifiable), CType(other, IUniqueIdentifiable))
        End Function

    End Class

    Public Interface IMappeableTrabajadores
        Sub CompleteEntity(cargopersonalEntity As Objects.cargopersonalObject)
        
        Function IscargopersonalEntityNull() As Boolean
        
        Sub SetFKValuesForChilds(entity As Trabajadores )
    End Interface

    Public Partial Class TrabajadoresList
        Inherits ObjectList(Of Trabajadores)    
    End Class
End Namespace

Namespace Views
    Partial Public Class TrabajadoresListView
        Inherits ObjectListView(Of Entities.Trabajadores)

        Sub New(ByVal list As Entities.TrabajadoresList)
            MyBase.New(list)
        End Sub
    End Class
End NameSpace

