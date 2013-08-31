
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 15/08/2013 - 05:51 p.m.
' This is a partial class file. The other one is ClieContactosGateway.vb
' You should not modifiy this file, please edit the other partial class file.
'------------------------------------------------------------------------------

Imports System
Imports abacusRules.Objects
Imports Cooperator.Framework.Data
Imports Cooperator.Framework.Data.Exceptions
Imports Cooperator.Framework.Core
Imports System.Data.Common
Imports System.Reflection
Imports System.Web

Namespace Gateways
        
    Public Partial Class ClieContactosGateway 
        Inherits BaseGateway(Of ClieContactosObject, ClieContactosObjectList)
        Implements IGenericGateway

#Region "Singleton"

        Private Shared _instance As ClieContactosGateway

        Private Sub New()
        End Sub

        Public Shared Function Instance() As ClieContactosGateway
            If _instance Is Nothing Then
                If HttpContext.Current Is Nothing Then
                    _instance = New ClieContactosGateway()
                Else
                    Dim inst As ClieContactosGateway = TryCast(HttpContext.Current.Items("abacusRules.ClieContactosGatewaySingleton"), ClieContactosGateway)
                    If inst Is Nothing Then
                        inst = New ClieContactosGateway()
                        HttpContext.Current.Items.Add("abacusRules.ClieContactosGatewaySingleton", inst)
                    End If
                    Return inst
                End If
            End If
            Return _instance
        End Function

#End Region

        ''' <summary>
        ''' Return the mapped table name
        ''' </summary>
        Protected Overrides ReadOnly Property TableName() As String
            Get
                Return "ClieContactos"
            End Get
        End Property

        ''' <summary>
        ''' Return the ClieContactosGateway type FullName
        ''' </summary>
        Protected Overrides ReadOnly Property RuleName() As String
            Get
                Return GetType(ClieContactosGateway ).FullName
            End Get
        End Property


        

        


        ''' <summary>
        ''' Assign properties values based on DataReader
        ''' </summary>
        Protected Overrides Sub HydrateFields(ByVal reader As DbDataReader, ByVal entity As ClieContactosObject )
            Dim _Nombre As String
If reader.IsDBNull(1) Then 
	 _Nombre = ""
Else
	 _Nombre = reader.GetString(1)
End If
Dim _Anexo As String
If reader.IsDBNull(2) Then 
	 _Anexo = ""
Else
	 _Anexo = reader.GetString(2)
End If
Dim _TipMovil1 As String
If reader.IsDBNull(3) Then 
	 _TipMovil1 = ""
Else
	 _TipMovil1 = reader.GetString(3)
End If
Dim _Movil1 As String
If reader.IsDBNull(4) Then 
	 _Movil1 = ""
Else
	 _Movil1 = reader.GetString(4)
End If
Dim _Email1 As String
If reader.IsDBNull(5) Then 
	 _Email1 = ""
Else
	 _Email1 = reader.GetString(5)
End If
Dim _TipMovil2 As String
If reader.IsDBNull(6) Then 
	 _TipMovil2 = ""
Else
	 _TipMovil2 = reader.GetString(6)
End If
Dim _Movil2 As String
If reader.IsDBNull(7) Then 
	 _Movil2 = ""
Else
	 _Movil2 = reader.GetString(7)
End If
Dim _Email2 As String
If reader.IsDBNull(8) Then 
	 _Email2 = ""
Else
	 _Email2 = reader.GetString(8)
End If
Dim _IdCliente As System.Nullable(Of System.Int32) 
If reader.IsDBNull(9) Then 
	 _IdCliente = New System.Nullable(Of System.Int32)
Else
	 _IdCliente = reader.GetInt32(9)
End If
Dim _Trato As String
If reader.IsDBNull(10) Then 
	 _Trato = ""
Else
	 _Trato = reader.GetString(10)
End If

            Dim ClieContactos As IMappeableClieContactosObject  = CType(entity, IMappeableClieContactosObject)
            ClieContactos.HydrateFields(reader.GetInt32(0), _
_Nombre, _
_Anexo, _
_TipMovil1, _
_Movil1, _
_Email1, _
_TipMovil2, _
_Movil2, _
_Email2, _
_IdCliente, _
_Trato)
            CType(entity, IObject).State = ObjectState.Restored
        End Sub

        ''' <summary>
        ''' Get field values to call insertion stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForInsert(ByVal entity As ClieContactosObject) As Object()
            Dim ClieContactos As IMappeableClieContactosObject = CType(entity, IMappeableClieContactosObject)
            Return ClieContactos.GetFieldsForInsert()
        End Function

        ''' <summary>
        ''' Get field values to call update stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForUpdate(ByVal entity As ClieContactosObject) As Object()
            Dim ClieContactos As IMappeableClieContactosObject = CType(entity, IMappeableClieContactosObject)
            Return ClieContactos.GetFieldsForUpdate()
        End Function

        ''' <summary>
        ''' Get field values to call deletion stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForDelete(ByVal entity As ClieContactosObject) As Object()
            Dim ClieContactos As IMappeableClieContactosObject = CType(entity, IMappeableClieContactosObject)
            Return ClieContactos.GetFieldsForDelete()
        End Function

        ''' <summary>
        ''' Raised after insert and update. Update properties from Output parameters
        ''' </summary>
        Protected Overrides Sub UpdateObjectFromOutputParams(ByVal row As ClieContactosObject, parameters As Object())
            ' Update properties from Output parameters
            CType(row, IMappeableClieContactosObject).UpdateObjectFromOutputParams(parameters)
            CType(row, IObject).State = ObjectState.Restored
        End Sub

        ''' <summary>
        ''' StoredProceduresPrefix, for example: coop_
        ''' </summary>
        Protected Overrides Function StoredProceduresPrefix() As String
            Return "coop_"
        End Function


        ''' <summary>
        ''' Get a ClieContactosObject by execute a SQL Query Text
        ''' </summary>
        Public Function GetOneBySQLQuery(sqlQueryText As String) As ClieContactosObject 
            Return MyBase.GetObjectBySQLText(sqlQueryText)
        End Function

        ''' <summary>
        ''' Get a ClieContactosObjectList by execute a SQL Query Text
        ''' </summary>
        Public Function GetBySQLQuery(sqlQueryText As String) As ClieContactosObjectList 
            Return MyBase.GetObjectListBySQLText(sqlQueryText)
        End Function



        ''' <summary>
        ''' Get a ClieContactosObject by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetOne(ByVal IdClicontactos As System.Int32) As ClieContactosObject         
            Return MyBase.GetOne(New ClieContactosObject(IdClicontactos))
        End Function

            


        


        

        
        ''' <summary>
        ''' Delete ClieContactos 
        ''' </summary>
        Public Overloads Sub Delete(ByVal IdClicontactos As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ClieContactos_Delete", IdClicontactos)
        End Sub

        ''' <summary>
        ''' Delete ClieContactos
        ''' </summary>
        Public Overloads Sub Delete(transaction As DbTransaction , ByVal IdClicontactos As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ClieContactos_Delete", IdClicontactos)
        End Sub

            



        

    

    

    

    

    

    

    

    

    

    

    


        'Database Queries 
        



        #Region "IGenericGateway"

        Private Function GetOne2(identifier As IUniqueIdentifiable) As Object Implements IGenericGateway.GetOne
            Return MyBase.GetOne(identifier)
        End Function

        Private Function GetAll2() As Object Implements IGenericGateway.GetAll
            Return MyBase.GetAll()
        End Function

        Private Function GeyByParent2(parentEntity As IUniqueIdentifiable) As Object Implements IGenericGateway.GetByParent
            Return MyBase.GetByParent(parentEntity)
        End Function

        #End Region

    End Class
End Namespace




