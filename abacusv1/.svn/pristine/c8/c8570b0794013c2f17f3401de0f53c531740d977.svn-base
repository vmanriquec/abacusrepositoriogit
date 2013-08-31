Public Class micapadatos

    Public Shared Function capturaridgeneralregresa_siempreid(ByVal campo As String, ByVal tabla As String, ByVal donde As String, ByVal igual As String) As Integer
        Using cn As New SqlClient.SqlConnection(cox)
            Dim cad As String = "SELECT " & campo & " FROM " & tabla & " WHERE " & donde & "='" & igual & "'"
            Dim cmd2 As New SqlClient.SqlCommand(cad, cn)

            Dim drConsulta1 As SqlClient.SqlDataReader
            cn.Open()
            drConsulta1 = cmd2.ExecuteReader()
            While drConsulta1.Read
                siempreid = CInt((CStr((drConsulta1(0)))))
            End While
            drConsulta1.NextResult()
            drConsulta1.Close()
            cn.Close()
            Return siempreid
        End Using
    End Function

End Class
