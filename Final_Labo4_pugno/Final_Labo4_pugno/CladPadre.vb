Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient

Public Class CladPadre
    Public Function Conectar(ByRef objConexion As SqlConnection) As Integer
        Dim strConexion As String
        strConexion = "Data Source=DESKTOP-T1Q1K9P\SQLEXPRESS;Initial Catalog=Final_labo4_Pugno;Persist Security Info=True;User ID=sa;Password=caterina"
        'strConexion = "Data Source=USER-PC\SQLEXPRESS;Initial Catalog=ServiciosFluviales;Integrated Security=True;Pooling=False"
        ' "Data Source=localhost\SQLEXPRESS;Initial Catalog= CPAC;Integrated Security=True"

        objConexion.ConnectionString = strConexion
        objConexion.Open()
    End Function

    Public Function RecuperaDataSet(ByRef dtsDatos As DataSet, ByVal strSqltext As String, ByVal strTabla As String) As Integer
        Dim objConexion As New SqlConnection
        Dim intRetorno As Integer
        Me.Conectar(objConexion)
        Dim objCommand As New SqlCommand(strSqltext, objConexion)
        Dim objAdapter As New SqlDataAdapter
        objAdapter.SelectCommand = objCommand
        intRetorno = objAdapter.Fill(dtsDatos, strTabla)
        objConexion.Close()
        Return intRetorno
    End Function
    Public Function Ejecutar(ByVal strSqlText As String) As Integer
        Dim objConexion As New SqlConnection
        Dim intRetorno As Integer
        Me.Conectar(objConexion)
        '"Asynchronous Processing=true"
        'objConexion.
        Dim objCommand As New SqlCommand(strSqlText, objConexion)
        intRetorno = objCommand.ExecuteNonQuery()

        Return intRetorno
    End Function
End Class
