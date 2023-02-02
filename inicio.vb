Imports System.Data.SqlClient

Public Class inicio

    Private Sub inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        username.Text = loge.nombre & " " & loge.apellido

        User.Visible = False






        Dim connectionString As String = "Data Source=EXMI;Initial Catalog=Tiker_exmi_studios;User ID=joel;Password=JOEL1234;"
        Dim connection As New SqlConnection(connectionString)


        Dim buscarroles As String = "SELECT * FROM DESTINOS"


        Dim cmd As New SqlCommand(buscarroles, connection)

        Dim dr As SqlDataReader


        connection.Open()

        Dim datos As DataSet = New DataSet()

        Dim adactador As SqlDataAdapter = New SqlDataAdapter(cmd)

        adactador.Fill(datos)

        roles.DataSource = datos.Tables(0)
        roles.DisplayMember = "namerol"
        roles.ValueMember = "id"

        dr = cmd.ExecuteReader








    End Sub

    Private Sub btnBuscarUser_Click(sender As Object, e As EventArgs) Handles btnBuscarUser.Click
        Dim connectionString As String = "Data Source=EXMI;Initial Catalog=Tiker_exmi_studios;User ID=joel;Password=JOEL1234;"
        Dim connection As New SqlConnection(connectionString)


        Dim buscarUsuario As String = "SELECT * FROM USUARIOS WHERE usuario = '" & buscarUser.Text & "'"


        Dim cmd As New SqlCommand(buscarUsuario, connection)

        Dim dr As SqlDataReader


        connection.Open()

        Dim datos As DataTable = New DataTable()

        Dim adactador As SqlDataAdapter = New SqlDataAdapter(cmd)

        adactador.Fill(datos)

        dr = cmd.ExecuteReader

        If dr.Read = True Then
            userID.Text = dr("id").ToString
            userNombre.Text = dr("nombre").ToString
            userApellido.Text = dr("apellido").ToString
            userUser.Text = dr("usuario").ToString
            userPass.Text = dr("password").ToString
            userEmail.Text = dr("email").ToString
            userRol.Text = dr("rol").ToString

        Else
            MsgBox("Error Al buscar los datos. Compruebe que el nombre de usuario es correcto.", vbCritical, "Datos no encontrados")
        End If


        connection.Close()
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        User.Visible = True
    End Sub

    Private Sub btnUpedate_Click(sender As Object, e As EventArgs)
        Dim connectionString As String = "Data Source=EXMI;Initial Catalog=Tiker_exmi_studios;User ID=joel;Password=JOEL1234;"
        Dim connection As New SqlConnection(connectionString)


        Dim buscarUsuario As String = "UPDATE usuarios SET nombre = '" & userNombre.Text & "', apellido = '" & userApellido.Text & "', usuario = '" & userUser.Text & "', password = '" & userPass.Text & "', email = '" & userEmail.Text & "', rol ='" & userRol.Text & "' WHERE id = '" & userID.Text & "';
"


        Dim cmd As New SqlCommand(buscarUsuario, connection)

        Dim dr As SqlDataReader


        connection.Open()

        dr = cmd.ExecuteReader

        connection.Close()
    End Sub


End Class