Public Class socios
    Inherits CladPadre
    Public Function recuperasociosporapynomb(ByRef dts As DataSet, ByVal strapellido As String, ByVal strnombre As String)
        Dim strsql As String
        Dim intresultado As Integer
        Dim strbusquedapornombre As String
        If strnombre = "" Then
            strbusquedapornombre = ""
        Else
            strbusquedapornombre = " and socios.nombre like '" + strnombre + "%'"
        End If

        strsql = "select socios.nro_socio, socios.apellido + ' ' + socios.nombre as 'Apellido y nombre', socios.parentezco, socios.plan_os from socios where socios.apellido like '" + strapellido + "%'" + strbusquedapornombre
        intresultado = Me.RecuperaDataSet(dts, strsql, "socios")
        Return intresultado
    End Function
End Class
