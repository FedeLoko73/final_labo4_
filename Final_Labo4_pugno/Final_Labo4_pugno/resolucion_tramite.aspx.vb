Public Partial Class resolucion_tramite
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack = True Then
            Dim objtramites As New Tramites
            Dim dtsTramites As New DataSet

            objtramites.RecuperaTramitePorEstado(dtsTramites)

            gv_res_tramite.DataSource = dtsTramites.Tables("estado")
            gv_res_tramite.DataBind()
        End If
    End Sub

    Protected Sub chk_aplicar_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)

    End Sub
End Class