Public Class mapas

    Private Sub grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grabar.Click
       Dim urlMaps As String
        'Concatenamos la dirección con el Textbox añadimos la última sentencia para indicar que sólo se muestre el mapa
        urlMaps = "http://maps.google.es/maps?q=" & txtdireccion.Text & "&output=embed" 'Creamos una variable direccion para que el WebBrowser lo pueda abrir puesto que no puede abrir directamente un string
        Dim direccion As New Uri(urlMaps)
        'ASignamos como URL la direccion
        WebBrowser1.Url = direccion
    End Sub

    Private Sub txtdireccion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdireccion.TextChanged
        'Creamos variable para almacenar la url
        'Dim urlMaps As String
        ''Concatenamos la dirección con el Textbox añadimos la última sentencia para indicar que sólo se muestre el mapa
        'urlMaps = "http://maps.google.es/maps?q=" & txtdireccion.Text & "&output=embed"
        ''Creamos una variable direccion para que el WebBrowser lo pueda abrir puesto que no puede abrir directamente un string
        'Dim direccion As New Uri(urlMaps)
        ''ASignamos como URL la direccion
        'WebBrowser1.Url = direccion
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        'WebBrowser1.ShowPrintDialog()
        WebBrowser1.ShowPrintPreviewDialog()

    End Sub
End Class