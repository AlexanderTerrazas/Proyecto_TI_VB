Imports System.Data.SqlClient

Public Class PMaestro
    ' Cadena de conexión a la base de datos SQL Server
    Dim conn As String = "Data Source=SPIDEY31;Initial Catalog=CargaMaterias;Integrated Security=True"
    Private Sub btnRegistroM_Click(sender As Object, e As EventArgs) Handles btnRegistroM.Click



        Dim nombre As String = txtbNombreM.Text
        Dim apellido As String = txtbApellidoM.Text
        Dim correo As String = txtbCorreoM.Text

        ' Variable para almacenar el nuevo ID
        Dim nuevoID As Integer = ObtenerNuevoID()

        ' Insertar los datos en la tabla Profesores
        InsertarDatos(nuevoID, nombre, apellido, correo)
    End Sub

    ' Función para obtener el nuevo ID incrementado
    Private Function ObtenerNuevoID() As Integer
        Dim nuevoID As Integer = 0

        ' Consulta SQL para obtener el último ProfesorID
        Dim consulta As String = "SELECT MAX(ProfesorID) FROM Profesores"

        ' Crear la conexión y el comando SQL
        Using conexion As New SqlConnection(conn)
            Using comando As New SqlCommand(consulta, conexion)
                conexion.Open()

                ' Ejecutar la consulta y obtener el último ProfesorID
                Dim resultado = comando.ExecuteScalar()
                If resultado IsNot DBNull.Value Then
                    nuevoID = Convert.ToInt32(resultado) + 1
                Else
                    nuevoID = 1 ' Si no hay registros, comenzar desde 1
                End If
            End Using
        End Using

        Return nuevoID
    End Function

    ' Función para insertar datos en la tabla Profesores
    Private Sub InsertarDatos(id As Integer, nombre As String, apellido As String, correo As String)
        ' Consulta SQL para insertar datos en la tabla Profesores
        Dim consulta As String = "INSERT INTO Profesores (ProfesorID, Nombre, Apellido, CorreoElectronico) VALUES (@ProfesorID, @Nombre, @Apellido, @Correo)"

        ' Crear la conexión y el comando SQL
        Using conexion As New SqlConnection(conn)
            Using comando As New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@ProfesorID", id)
                comando.Parameters.AddWithValue("@Nombre", nombre)
                comando.Parameters.AddWithValue("@Apellido", apellido)
                comando.Parameters.AddWithValue("@Correo", correo)
                conexion.Open()

                ' Ejecutar la consulta para insertar los datos
                comando.ExecuteNonQuery()
                MessageBox.Show("Datos insertados correctamente.")
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
