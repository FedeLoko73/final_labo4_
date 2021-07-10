Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Private Sub recuperaporapellidoynombre()
        Dim objsocio As New socios
        Dim dtssocios As New DataSet
        Dim intresultado As Integer
        Dim strnombre As String
        Dim strapellido As String

        strnombre = Me.txt_nombre.Text.ToString
        strapellido = Me.txt_apellido.Text.ToString
        intresultado = objsocio.recuperasociosporapynomb(dtssocios, strapellido, strnombre)

        If intresultado > 0 Then

            Me.gv_busqueda.DataSource = dtssocios.Tables("socios")
            Me.gv_busqueda.DataBind()

        End If

    End Sub
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        gv_busqueda.Visible = True
        recuperaporapellidoynombre()
    End Sub

    Protected Sub txt_nombre_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txt_nombre.TextChanged

    End Sub

   
End Class