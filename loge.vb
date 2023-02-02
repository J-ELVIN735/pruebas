Imports System.Data.SqlClient

Public Class loge

    Public fallos As Integer
    Public vision As Integer = 1

    Public nombre As String
    Public apellido As String
    Public usuario As String
    Public contraseña As String
    Public correo As String
    Public rol As String

    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click

        If user.Text = "" And pass.Text = "" Then
            MsgBox("Los campos de usuario y contraseña no pueden estar en blanco y la contraseña debe tener 8 dijitos o mas y el usuario 3 dijitos o mas")

        Else
            logeo()
        End If


    End Sub

    Private Sub logeo()

        login.Visible = False

        Dim connectionString As String = "Data Source=EXMI;Initial Catalog=Tiker_exmi_studios;User ID=joel;Password=JOEL1234;"
        Dim connection As New SqlConnection(connectionString)





        Dim inicio_seccion_sql As String = "SELECT * FROM USUARIOS WHERE usuario = '" & user.Text & "'"


        Dim cmd As New SqlCommand(inicio_seccion_sql, connection)

        Dim dr As SqlDataReader


        connection.Open()

        Dim datos As DataTable = New DataTable()

        Dim adactador As SqlDataAdapter = New SqlDataAdapter(cmd)

        adactador.Fill(datos)





        dr = cmd.ExecuteReader

        If dr.Read = True Then

            If dr("password").ToString = pass.Text Then

                nombre = dr("nombre").ToString
                apellido = dr("apellido").ToString
                usuario = dr("usuario").ToString
                contraseña = dr("password").ToString
                correo = dr("email").ToString
                rol = dr("rol").ToString

                MsgBox("bien " & "Su nombre es: " & dr("nombre").ToString)

                user.Text = ""
                pass.Text = ""

                Me.Hide()
                inicio.Show()

            Else


                fallos = fallos + 1
                MsgBox("La contraseña es incorrecta")

                info.Text = "Intentos Restantes:" & 3 - fallos

            End If



        Else

            fallos = fallos + 1
            MsgBox("El usuario no existe")

            info.Text = "Intentos Restantes:" & 3 - fallos


        End If

        If fallos > 2 Then
            MsgBox("demaciados intentos fallidos")
            End

        Else

            login.Visible = True
        End If

        connection.Close()

    End Sub

    Private Sub carga_Tick(sender As Object, e As EventArgs) Handles carga.Tick
        Dim tiempo As Integer

        tiempo = tiempo + 1

        If tiempo = 1 Then
            loandin.Text = "Verificando Datos."
        End If

        If tiempo = 2 Then
            loandin.Text = "Verificando Datos.."
        End If

        If tiempo = 3 Then
            loandin.Text = "Verificando Datos..."
        End If

        If tiempo = 4 Then
            loandin.Text = "Verificando Datos...."
        End If

        If tiempo = 5 Then
            loandin.Text = "Verificando Datos....."
        End If

        If tiempo = 6 Then
            loandin.Text = "Verificando Datos......"
        End If

        If tiempo = 7 Then
            loandin.Text = "Verificando Datos......."
        End If

        If tiempo = 8 Then
            tiempo = 0
        End If

    End Sub

    Private Sub showpass_Click(sender As Object, e As EventArgs) Handles showpass.Click
        If vision = 1 Then
            showpass.Image = pruevaSQL.My.Resources.Resources.show
            pass.PasswordChar = ""
            vision = 2

        Else
            showpass.Image = pruevaSQL.My.Resources.Resources.esconder
            pass.PasswordChar = "*"
            vision = 1
        End If

    End Sub

End Class
