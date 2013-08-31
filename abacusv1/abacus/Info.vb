Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Public Class Info
	Public Property Ruc() As String
		Get
			Return m_Ruc
		End Get
		Set
			m_Ruc = Value
		End Set
	End Property
	Private m_Ruc As String

	Public Property RazonSocial() As String
		Get
			Return m_RazonSocial
		End Get
		Set
			m_RazonSocial = Value
		End Set
	End Property
	Private m_RazonSocial As String

	Public Property AntiguoRuc() As String
		Get
			Return m_AntiguoRuc
		End Get
		Set
			m_AntiguoRuc = Value
		End Set
	End Property
	Private m_AntiguoRuc As String

	Public Property Estado() As String
		Get
			Return m_Estado
		End Get
		Set
			m_Estado = Value
		End Set
	End Property
	Private m_Estado As String

	Public Property EsAgenteRetencion() As String
		Get
			Return m_EsAgenteRetencion
		End Get
		Set
			m_EsAgenteRetencion = Value
		End Set
	End Property
	Private m_EsAgenteRetencion As String

	Public Property NombreComercial() As String
		Get
			Return m_NombreComercial
		End Get
		Set
			m_NombreComercial = Value
		End Set
	End Property
	Private m_NombreComercial As String

	Public Property Direccion() As String
		Get
			Return m_Direccion
		End Get
		Set
			m_Direccion = Value
		End Set
	End Property
	Private m_Direccion As String

	Public Property Telefono() As String
		Get
			Return m_Telefono
		End Get
		Set
			m_Telefono = Value
		End Set
	End Property
	Private m_Telefono As String

	Public Property Dependencia() As String
		Get
			Return m_Dependencia
		End Get
		Set
			m_Dependencia = Value
		End Set
	End Property
	Private m_Dependencia As String

	Public Property Tipo() As String
		Get
			Return m_Tipo
		End Get
		Set
			m_Tipo = Value
		End Set
	End Property
	Private m_Tipo As String

End Class
