Imports System.IO
Imports System.Drawing.Imaging

Public Class convertimage

    Public Shared Function ByteArrayToImage(ByVal byteArrayIn As Byte()) As Image

        Dim ms As New MemoryStream(byteArrayIn)

        Return Image.FromStream(ms)

    End Function

    Public Shared Function ImageToByteArray(ByVal imageIn As Image) As Byte()

        Dim ms As New MemoryStream()

        imageIn.Save(ms, ImageFormat.Jpeg)

        Return ms.ToArray()

    End Function
End Class
