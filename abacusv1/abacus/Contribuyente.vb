'  Contribuyente.cs : Clase para consultar informacion de un contribuyente a partir de su RUC
'
'  Author:
'       .::IT::. <elmaildeit@gmail.com>
'  
'  Copyright (c) 2013

Imports System.Collections.Generic
Imports System.Data.Linq
Imports System.Text
Imports System.Net
Imports System.Web
Imports System.IO
Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports LibSunat
Public Class Contribuyente
#Region "Private"

    Private Const urlinforuc As String = "http://www.sunat.gob.pe/w/wapS01Alias?ruc="

    Private _WebRequest As HttpWebRequest
    Private _WebResponse As HttpWebResponse
    Private _WebSource As String
    Private _Info As Info
    Private _ok As Boolean
    Private _error As String

    Private Function LoadWebSource(ByVal url As String) As Boolean
        _WebRequest = DirectCast(WebRequest.Create(url), HttpWebRequest)
        _WebRequest.Proxy = Nothing

        Try
            _WebResponse = DirectCast(_WebRequest.GetResponse(), HttpWebResponse)
        Catch
            _ok = False
            _error = "Error al consultar con Sunat"
            Return False
        End Try

        Dim _Stream As Stream = _WebResponse.GetResponseStream()

        Dim encode As Encoding = System.Text.Encoding.GetEncoding("utf-8")


        Dim _StreamReader As New StreamReader(_Stream, encode)
        ''''
        ''''''''''''''''''_WebSource = HttpUtility.HtmlDecode(_StreamReader.ReadToEnd())
        ''''''''''''''''''''''''''

        Return True
    End Function

    Private Function ParseInfoContribuyente(ByVal _resul As List(Of String), ByVal ruc As String) As Boolean
        Try
            _Info = New Info()
            _Info.Ruc = ruc

            For i As Integer = 0 To _resul.Count - 1
                Select Case _resul(i)
                    Case "Número Ruc."
                        _Info.RazonSocial = _resul(i + 2).Substring(14)
                        Exit Select
                    Case "Antiguo Ruc."
                        _Info.AntiguoRuc = _resul(i + 5)
                        Exit Select
                    Case "Estado."
                        _Info.Estado = _resul(i + 2)
                        Exit Select
                    Case "Agente Retención IGV."
                        _Info.EsAgenteRetencion = _resul(i + 3)
                        Exit Select
                    Case "Nombre Comercial."
                        _Info.NombreComercial = _resul(i + 3)
                        Exit Select
                    Case "Dirección."
                        _Info.Direccion = _resul(i + 3)
                        Exit Select
                    Case "Teléfono(s)."
                        _Info.Telefono = _resul(i + 3)
                        Exit Select
                    Case "Dependencia."
                        _Info.Dependencia = _resul(i + 3)
                        Exit Select
                    Case "Tipo."
                        _Info.Tipo = _resul(i + 3)
                        Exit Select
                End Select
            Next

            Return True
        Catch
            _ok = False
            _error = "Error al procesar informacion de sunat(Funcion ParseInfo)"
        End Try
        Return False
    End Function

    Private Sub LoadInfoContribuyente(ByVal ruc As String)
        If LoadWebSource([String].Format("{0}{1}", urlinforuc, ruc)) Then

            Dim _split As String() = _WebSource.Split(New Char() {"<"c, ">"c})
            Dim _resul As New List(Of String)()

            'quitamos todos los caracteres nulos y convertirmos todo  utf8
            For i As Integer = 0 To _split.Length - 1
                If Not String.IsNullOrEmpty(_split(i).Trim()) Then
                    _resul.Add(_split(i).Trim())
                End If
            Next

            Dim _car As String() = Nothing

            If _resul.Count = 34 Then
                'no es valido o algo salio mal
                _ok = False
                _error = _resul(15)
            Else
                _car = _resul(14).Split(New Char() {""""c})

                If _car(1) = "Resultado" Then
                    _ok = True
                Else
                    _ok = False
                    _error = "El servidor de Sunat no devolvio una respuesta conocida(Funcion LoadInfo)"
                End If
            End If

            ParseInfoContribuyente(_resul, ruc)
        End If
    End Sub

#End Region

#Region "Constructor"

    Public Sub New(ByVal ruc As String)
        LoadInfoContribuyente(ruc)
    End Sub

#End Region

#Region "Public"

    Public ReadOnly Property [Error]() As String
        Get
            If _ok Then
                Return String.Empty
            Else
                Return _error
            End If
        End Get
    End Property

    Public ReadOnly Property GetInfo() As Info
        Get
            If _ok Then
                Return _Info
            Else
                Return Nothing
            End If
        End Get
    End Property


#End Region
End Class
