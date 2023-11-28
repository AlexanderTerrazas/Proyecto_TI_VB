Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class PEALUMNO

    ' Cadena de conexión a la base de datos SQL Server
    Dim conn As String = "Data Source=SPIDEY31;Initial Catalog=CargaMaterias;Integrated Security=True"
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Dim busqueda As String = txtbBusqueda.Text.Trim()

        If Not String.IsNullOrEmpty(busqueda) Then
            BuscarEnBD(busqueda)
        Else
            MessageBox.Show("Ingresa un término de búsqueda.")
        End If
    End Sub

    Private Sub BuscarEnBD(ByVal terminoBusqueda As String)
        ' Consulta SQL para buscar en la tabla Estudiantes por el nombre
        Dim consulta As String = "SELECT * FROM Estudiantes WHERE Nombre LIKE @Nombre"

        ' Crear la conexión y el comando SQL
        Using conexion As New SqlConnection(conn)
            Using comando As New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@Nombre", "%" & terminoBusqueda & "%")
                Dim tablaResultados As New DataTable()

                Try
                    conexion.Open()
                    Dim adaptador As New SqlDataAdapter(comando)
                    adaptador.Fill(tablaResultados)

                    ' Mostrar los resultados en el DataGridView
                    Resultados.DataSource = tablaResultados
                Catch ex As Exception
                    MessageBox.Show("Error al buscar en la base de datos: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ' Verificar si hay una fila seleccionada en el DataGridView
        If Resultados.SelectedRows.Count > 0 Then
            ' Obtener el valor de EstudianteID de la fila seleccionada
            Dim estudianteID As Integer = Convert.ToInt32(Resultados.SelectedRows(0).Cells("EstudianteID").Value)

            ' Eliminar la fila correspondiente en la tabla Matricula
            EliminarMatricula(estudianteID)

            ' Eliminar la fila de la tabla Estudiantes
            EliminarEstudiante(estudianteID)
        Else
            MessageBox.Show("Selecciona una fila para eliminar.")
        End If
    End Sub

    Private Sub EliminarMatricula(ByVal estudianteID As Integer)
        ' Consulta SQL para eliminar la fila correspondiente en Matricula
        Dim consulta As String = "DELETE FROM Matricula WHERE EstudianteID = @EstudianteID"

        ' Crear la conexión y el comando SQL
        Using conexion As New SqlConnection(conn)
            Using comando As New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@EstudianteID", estudianteID)

                Try
                    conexion.Open()
                    comando.ExecuteNonQuery()
                    MessageBox.Show("Fila eliminada de Matricula.")
                Catch ex As Exception
                    MessageBox.Show("Error al eliminar de Matricula: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub EliminarEstudiante(ByVal estudianteID As Integer)
        ' Consulta SQL para eliminar la fila correspondiente en Estudiantes
        Dim consulta As String = "DELETE FROM Estudiantes WHERE EstudianteID = @EstudianteID"

        ' Crear la conexión y el comando SQL
        Using conexion As New SqlConnection(conn)
            Using comando As New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@EstudianteID", estudianteID)

                Try
                    conexion.Open()
                    comando.ExecuteNonQuery()
                    MessageBox.Show("Fila eliminada de Estudiantes.")
                Catch ex As Exception
                    MessageBox.Show("Error al eliminar de Estudiantes: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
    End Sub

    Private Sub LimpiarDatos()
        ' Limpiar el contenido del TextBox
        txtbBusqueda.Text = String.Empty

        ' Limpiar el contenido del DataGridView
        Resultados.DataSource = Nothing
        Resultados.Rows.Clear()
        Resultados.Columns.Clear()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarDatos()
    End Sub
End Class