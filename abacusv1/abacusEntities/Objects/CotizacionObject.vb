
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 15/08/2013 - 05:50 p.m.
' This is a partial class file. The other one is CotizacionObject.Auto.vb
' You can edit this file as your wish.
'------------------------------------------------------------------------------

Imports System
Imports Cooperator.Framework.Core
Imports Cooperator.Framework.Core.Exceptions

Namespace Objects
    ''' <summary>
    ''' This class represents a Object of Cotizacion table.
    ''' </summary>
    <Serializable()> _
    Public Partial Class CotizacionObject        
        ' Implements IValidable

        ''' <summary>
        ''' Called from class constructor.
        ''' </summary>
        Protected Overrides Sub Initialize()
        End Sub

        ' ''' <summary>
        ' ''' Called after class constructor.
        ' ''' </summary>
        ' Protected Overrides Sub Initialized()
        ' 'Warnging: This method is only called by parameterized contructors.
        ' End Sub

        ' ''' <summary>
        ' ''' When IValidable is implemented, this method is invoked by Gateway before Insert or Update to validate Object.
        ' ''' </summary>
        ' Public Sub Validate() Implements IValidable.Validate
        '     Dim msgRequired As String = "{0} can not be null"
        '     Dim msgOutOfRange As String = "{0} incorrect value"

        
        ' End Sub       
    End Class

    ''' <summary>
    ''' This class represents a record set of Cotizacion table.
    ''' </summary>
    Public Partial Class CotizacionObjectList
         ' ''' <summary>
         ' ''' Returns a typed Dataset based on its content.
         ' ''' </summary>
         'Public Overrides Function ToDataSet() As System.Data.DataSet
         '    Dim MyDataSet As YOUR_TYPED_DATASET = New YOUR_TYPED_DATASET()
         '    Dim Exporter As ObjectListHelper(Of CotizacionObject, CotizacionObjectList) = New ObjectListHelper(Of CotizacionObject, CotizacionObjectList)()
         '    Exporter.FillDataSet(MyDataSet, Me)
         '    Return MyDataSet
         'End Function
    End Class

End NameSpace

Namespace Views
    ''' <summary>
    ''' This class represents a view of an collection of CotizacionObjects.
    ''' </summary>
    Partial Public Class CotizacionObjectListView
    End Class
End NameSpace


