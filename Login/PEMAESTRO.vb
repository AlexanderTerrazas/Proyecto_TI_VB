Imports System.Data.SqlClient

Public Class PEMAESTRO

    ' Cadena de conexión a la base de datos SQL Server
    Dim conn As String = "Data Source=SPIDEY31;Initial Catalog=CargaMaterias;Integrated Security=True"
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim textoBusqueda As String = txtbBusqueda.Text.Trim()

        ' Consulta SQL para buscar en la tabla Profesores
        Dim consulta As String = "SELECT * FROM Profesores WHERE Nombre LIKE '%' + @textoBusqueda + '%'"

        ' Crear la conexión y el adaptador de datos
        Using conexion As New SqlConnection(conn)
            Using comando As New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@textoBusqueda", textoBusqueda)
                Using adaptador As New SqlDataAdapter(comando)
                    Dim tablaResultados As New DataTable()
                    adaptador.Fill(tablaResultados)

                    ' Mostrar los resultados en el DataGridView
                    Resultados.DataSource = tablaResultados
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If Resultados.SelectedRows.Count > 0 Then
            ' Obtener el valor de ProfesorID de la fila seleccionada
            Dim profesorID As Integer = Convert.ToInt32(Resultados.SelectedRows(0).Cells("ProfesorID").Value)

            ' Eliminar la fila correspondiente en la tabla Profesores
            EliminarProfesor(profesorID)
        Else
            MessageBox.Show("Selecciona una fila para eliminar.")
        End If
    End Sub

    Private Sub EliminarProfesor(ByVal profesorID As Integer)
        ' Consulta SQL para eliminar la fila correspondiente en Profesores
        Dim consulta As String = "DELETE FROM Profesores WHERE ProfesorID = @ProfesorID"

        ' Crear la conexión y el comando SQL
        Using conexion As New SqlConnection(conn)
            Using comando As New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@ProfesorID", profesorID)

                Try
                    conexion.Open()
                    comando.ExecuteNonQuery()
                    MessageBox.Show("Fila eliminada de Profesores.")
                Catch ex As Exception
                    MessageBox.Show("Error al eliminar de Profesores: " & ex.Message)
                End Try
            End Using
        End Using
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

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
    End Sub
End Class