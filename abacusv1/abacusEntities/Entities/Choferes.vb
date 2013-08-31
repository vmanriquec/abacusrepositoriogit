
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 15/08/2013 - 05:51 p.m.
' This is a partial class file. The other one is ChoferesEntity.Auto.cs
' You can edit this file as your wish.
'------------------------------------------------------------------------------

Imports System
Imports Cooperator.Framework.Core.Exceptions

Namespace Entities
    ''' <summary>
    ''' This class represents the Choferes entity.
    ''' </summary>
    ''' <remarks></remarks>
    <Serializable> _
    Public Partial Class Choferes
        ' Implements IValidable

        ' ''' <summary>
        ' ''' When IValidable is implemented, this method is invoked by Gateway before Insert or Update to validate Object.
        ' ''' </summary>
        ' ''' <remarks></remarks>
        ' Public Sub Validate()
        '     'Example:
        '     If String.IsNullOrEmpty(me.Name) Then Throw New RuleValidationException("Name can't be null")
        ' End Sub
    End Class

    ''' <summary>
    ''' This class represents a collection of Choferes entity.
    ''' </summary>
    Public Partial Class ChoferesList
         ' ''' <summary>
         ' ''' Returns a typed Dataset based on its content.
         ' ''' </summary>
         'Public Overrides Function ToDataSet() As System.Data.DataSet
         '    YOUR_TYPED_DATASET MyDataSet = new YOUR_TYPED_DATASET();
         '    ObjectListHelper<Choferes, ChoferesList> Exporter = new ObjectListHelper<Choferes, ChoferesList>();
         '    Exporter.FillDataSet(MyDataSet, this)
         '    Return MyDataSet
         'End Function
    End Class


End Namespace

Namespace Views
    ''' <summary>
    ''' This class represents a view of an collection of Choferes entities.
    ''' </summary>
    Partial Public Class ChoferesListView
    End Class
End Namespace


