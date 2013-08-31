
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 15/08/2013 - 05:51 p.m.
' This is a partial class file. The other one is LoginEntity.Auto.cs
' You can edit this file as your wish.
'------------------------------------------------------------------------------

Imports System
Imports Cooperator.Framework.Core.Exceptions

Namespace Entities
    ''' <summary>
    ''' This class represents the Login entity.
    ''' </summary>
    ''' <remarks></remarks>
    <Serializable> _
    Public Partial Class Login
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
    ''' This class represents a collection of Login entity.
    ''' </summary>
    Public Partial Class LoginList
         ' ''' <summary>
         ' ''' Returns a typed Dataset based on its content.
         ' ''' </summary>
         'Public Overrides Function ToDataSet() As System.Data.DataSet
         '    YOUR_TYPED_DATASET MyDataSet = new YOUR_TYPED_DATASET();
         '    ObjectListHelper<Login, LoginList> Exporter = new ObjectListHelper<Login, LoginList>();
         '    Exporter.FillDataSet(MyDataSet, this)
         '    Return MyDataSet
         'End Function
    End Class


End Namespace

Namespace Views
    ''' <summary>
    ''' This class represents a view of an collection of Login entities.
    ''' </summary>
    Partial Public Class LoginListView
    End Class
End Namespace


