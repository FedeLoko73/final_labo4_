Public Class Tramites
    Inherits CladPadre
    Public Function RecuperaTramitePorEstado(ByVal dtstramites As DataSet) As Integer
        Dim strsql As String
        Dim intresultado As Integer

        strsql = "select nro_tramite, (rtrim(apellido) + ' ' + rtrim(nombre)) as 'Apellido y Nombre', plan_actual as 'Plan Actual',plan_nuevo as 'Plan Solicitado',tramites_cambio_plan.estado as 'Estado' from tramites_cambio_plan, socios where(tramites_cambio_plan.nro_socio = socios.nro_socio)and (tramites_cambio_plan.estado = 'PEN' or datediff(day,fecha_resolucion,getdate())< 35)"
        intresultado = Me.RecuperaDataSet(dtstramites, strsql, "estado")
        Return intresultado
    End Function

End Class
