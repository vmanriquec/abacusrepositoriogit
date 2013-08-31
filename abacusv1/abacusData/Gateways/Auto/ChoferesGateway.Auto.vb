
'------------------------------------------------------------------------------
' This file was generated by Cooperator Modeler, version 1.3.3.0
' Created: 20/08/2013 - 01:48 p.m.
' This is a partial class file. The other one is ChoferesGateway.vb
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
        
    Public Partial Class ChoferesGateway 
        Inherits BaseGateway(Of ChoferesObject, ChoferesObjectList)
        Implements IGenericGateway

#Region "Singleton"

        Private Shared _instance As ChoferesGateway

        Private Sub New()
        End Sub

        Public Shared Function Instance() As ChoferesGateway
            If _instance Is Nothing Then
                If HttpContext.Current Is Nothing Then
                    _instance = New ChoferesGateway()
                Else
                    Dim inst As ChoferesGateway = TryCast(HttpContext.Current.Items("abacusRules.ChoferesGatewaySingleton"), ChoferesGateway)
                    If inst Is Nothing Then
                        inst = New ChoferesGateway()
                        HttpContext.Current.Items.Add("abacusRules.ChoferesGatewaySingleton", inst)
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
                Return "Choferes"
            End Get
        End Property

        ''' <summary>
        ''' Return the ChoferesGateway type FullName
        ''' </summary>
        Protected Overrides ReadOnly Property RuleName() As String
            Get
                Return GetType(ChoferesGateway ).FullName
            End Get
        End Property


        

        


        ''' <summary>
        ''' Assign properties values based on DataReader
        ''' </summary>
        Protected Overrides Sub HydrateFields(ByVal reader As DbDataReader, ByVal entity As ChoferesObject )
            Dim _Nombres As String
If reader.IsDBNull(1) Then 
	 _Nombres = ""
Else
	 _Nombres = reader.GetString(1)
End If
Dim _Apellidos As String
If reader.IsDBNull(2) Then 
	 _Apellidos = ""
Else
	 _Apellidos = reader.GetString(2)
End If
Dim _DNI As String
If reader.IsDBNull(3) Then 
	 _DNI = ""
Else
	 _DNI = reader.GetString(3)
End If
Dim _Brevete As String
If reader.IsDBNull(4) Then 
	 _Brevete = ""
Else
	 _Brevete = reader.GetString(4)
End If
Dim _FecNacimiento As System.Nullable(Of System.DateTime) 
If reader.IsDBNull(5) Then 
	 _FecNacimiento = New System.Nullable(Of System.DateTime)
Else
	 _FecNacimiento = reader.GetDateTime(5)
End If
Dim _IdTransportista As System.Nullable(Of System.Int32) 
If reader.IsDBNull(6) Then 
	 _IdTransportista = New System.Nullable(Of System.Int32)
Else
	 _IdTransportista = reader.GetInt32(6)
End If
Dim _TransportistaString As String
If reader.IsDBNull(7) Then 
	 _TransportistaString = ""
Else
	 _TransportistaString = reader.GetString(7)
End If

            Dim Choferes As IMappeableChoferesObject  = CType(entity, IMappeableChoferesObject)
            Choferes.HydrateFields(reader.GetInt32(0), _
_Nombres, _
_Apellidos, _
_DNI, _
_Brevete, _
_FecNacimiento, _
_IdTransportista, _
_TransportistaString)
            CType(entity, IObject).State = ObjectState.Restored
        End Sub

        ''' <summary>
        ''' Get field values to call insertion stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForInsert(ByVal entity As ChoferesObject) As Object()
            Dim Choferes As IMappeableChoferesObject = CType(entity, IMappeableChoferesObject)
            Return Choferes.GetFieldsForInsert()
        End Function

        ''' <summary>
        ''' Get field values to call update stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForUpdate(ByVal entity As ChoferesObject) As Object()
            Dim Choferes As IMappeableChoferesObject = CType(entity, IMappeableChoferesObject)
            Return Choferes.GetFieldsForUpdate()
        End Function

        ''' <summary>
        ''' Get field values to call deletion stored procedure
        ''' </summary>
        Protected Overrides Function GetFieldsForDelete(ByVal entity As ChoferesObject) As Object()
            Dim Choferes As IMappeableChoferesObject = CType(entity, IMappeableChoferesObject)
            Return Choferes.GetFieldsForDelete()
        End Function

        ''' <summary>
        ''' Raised after insert and update. Update properties from Output parameters
        ''' </summary>
        Protected Overrides Sub UpdateObjectFromOutputParams(ByVal row As ChoferesObject, parameters As Object())
            ' Update properties from Output parameters
            CType(row, IMappeableChoferesObject).UpdateObjectFromOutputParams(parameters)
            CType(row, IObject).State = ObjectState.Restored
        End Sub

        ''' <summary>
        ''' StoredProceduresPrefix, for example: coop_
        ''' </summary>
        Protected Overrides Function StoredProceduresPrefix() As String
            Return "coop_"
        End Function


        ''' <summary>
        ''' Get a ChoferesObject by execute a SQL Query Text
        ''' </summary>
        Public Function GetOneBySQLQuery(sqlQueryText As String) As ChoferesObject 
            Return MyBase.GetObjectBySQLText(sqlQueryText)
        End Function

        ''' <summary>
        ''' Get a ChoferesObjectList by execute a SQL Query Text
        ''' </summary>
        Public Function GetBySQLQuery(sqlQueryText As String) As ChoferesObjectList 
            Return MyBase.GetObjectListBySQLText(sqlQueryText)
        End Function



        ''' <summary>
        ''' Get a ChoferesObject by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetOne(ByVal IdChofer As System.Int32) As ChoferesObject         
            Return MyBase.GetOne(New ChoferesObject(IdChofer))
        End Function

            


        
        ''' <summary>
        ''' Get a ChoferesObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByTransportista(ByVal transaction As DbTransaction, ByVal IdTransportista As System.Int32) As ChoferesObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Choferes_GetByTransportista", IdTransportista)
        End Function

        ''' <summary>
        ''' Get a ChoferesObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByTransportista(ByVal transaction As DbTransaction, Transportista As IUniqueIdentifiable) As ChoferesObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Choferes_GetByTransportista", Transportista.Identifier())
        End Function
    


        
        ''' <summary>
        ''' Get a ChoferesObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByTransportista(ByVal IdTransportista As System.Int32) As ChoferesObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Choferes_GetByTransportista", IdTransportista)
        End Function

        ''' <summary>
        ''' Get a ChoferesObjectList by calling a Stored Procedure
        ''' </summary>
        Public Overloads Function GetByTransportista(Transportista As IUniqueIdentifiable) As ChoferesObjectList 
            Return MyBase.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Choferes_GetByTransportista", Transportista.Identifier())
        End Function
    

        
        ''' <summary>
        ''' Delete Choferes 
        ''' </summary>
        Public Overloads Sub Delete(ByVal IdChofer As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Choferes_Delete", IdChofer)
        End Sub

        ''' <summary>
        ''' Delete Choferes
        ''' </summary>
        Public Overloads Sub Delete(transaction As DbTransaction , ByVal IdChofer As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Choferes_Delete", IdChofer)
        End Sub

            



        

    

    

    

    

    

    

    

    

        ''' <summary>
        ''' Delete Choferes By Transportista
        ''' </summary>
        Public Overloads Sub DeleteByTransportista(ByVal IdTransportista As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Choferes_DeleteByTransportista", IdTransportista)
        End Sub

        ''' <summary>
        ''' Delete Choferes By Transportista
        ''' </summary>
        Public Overloads Sub DeleteByTransportista(ByVal transaction As DbTransaction , ByVal IdTransportista As System.Int32)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Choferes_DeleteByTransportista", IdTransportista)
        End Sub

        ''' <summary>
        ''' Delete Choferes By Transportista
        ''' </summary>
        Public Overloads Sub DeleteByTransportista(ByVal Transportista As IUniqueIdentifiable )
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Choferes_DeleteByTransportista", Transportista.Identifier())
        End Sub

        ''' <summary>
        ''' Delete Choferes By Transportista
        ''' </summary>
        Public Overloads Sub DeleteByTransportista(ByVal transaction As DbTransaction , ByVal Transportista As IUniqueIdentifiable)
            MyBase.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Choferes_DeleteByTransportista", Transportista.Identifier())
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




