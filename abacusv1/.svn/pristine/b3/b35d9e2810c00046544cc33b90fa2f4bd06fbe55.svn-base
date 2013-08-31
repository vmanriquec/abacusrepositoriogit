Imports System.Data
Imports System.Data.SqlClient
Public Class ImageClass
#Region "Set Class Variables …"

    Private clsobj As ImageClass
    Private lstobj As List(Of ImageClass)

    Private sqlcon As SqlConnection
    Private sqlcom As SqlCommand
    Private sqlrdr As SqlDataReader

    Private sqlstr As String = "Data Source=MYPC;Initial Catalog=imagen;Integrated Security=True"

#End Region

#Region "Set Property Data …"
    Private _productoid As Integer
    Public Property ProductoID() As Integer
        Get
            Return _productoid
        End Get
        Set(ByVal value As Integer)
            _productoid = value
        End Set
    End Property

    Private _descripcion As String
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    Private _precio As Double
    Public Property Precio() As String
        Get
            Return CStr(_precio)
        End Get
        Set(ByVal value As String)
            _precio = CDbl(value)
        End Set
    End Property

    Private _imagen() As Byte

    Public Property Imagen() As Byte()
        Get
            Return _imagen
        End Get
        Set(ByVal value() As Byte)
            _imagen = value
        End Set
    End Property
#End Region

    Public Function ObtenerImagenes() As List(Of ImageClass)

        lstobj = New List(Of ImageClass)
        lstobj.Clear()

        sqlcon = New SqlConnection(sqlstr)
        sqlcon.Open()

        sqlcom = New SqlCommand()

        With sqlcom
            .Connection = sqlcon
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM Producto order by IdProducto"
            sqlrdr = .ExecuteReader()
        End With

        Do While sqlrdr.Read()


            clsobj = New ImageClass()

            clsobj.ProductoID = Convert.ToInt32(sqlrdr.GetValue(0))
            clsobj.Descripcion = Convert.ToString(sqlrdr.GetValue(1))
            clsobj.Precio = Convert.ToString(sqlrdr.GetValue(2))
            clsobj.Imagen = CType(sqlrdr.GetValue(3), Byte())

            lstobj.Add(clsobj)
            clsobj = Nothing
        Loop

        sqlrdr.Close()
        sqlcom.Cancel() : sqlcom.Dispose()
        sqlcon.Close() : sqlcon.Dispose()

        Return lstobj

    End Function

End Class
