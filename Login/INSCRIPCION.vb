Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class INSCRIPCION
    ' Cadena de conexión a la base de datos SQL Server
    Dim conn As String = "Data Source=SPIDEY31;Initial Catalog=CargaMaterias;Integrated Security=True"

    Public Sub New()
        InitializeComponent()
        AddHandler btnBuscarA.Click, AddressOf btnBuscarA_Click
        AddHandler btnActualizar.Click, AddressOf btnActualizar_Click
    End Sub
    Private Sub btnBuscarA_Click(sender As Object, e As EventArgs)
        Dim searchTerm As String = txtBusqueda.Text.Trim()

        If Not String.IsNullOrEmpty(searchTerm) Then
            Dim estudianteID As Integer = ObtenerEstudianteID(searchTerm)

            If estudianteID <> -1 Then
                Dim query As String = "SELECT Estudiantes.EstudianteID, Estudiantes.Nombre, Estudiantes.Apellido, Matricula.CursoID " &
                                      "FROM Estudiantes INNER JOIN Matricula ON Estudiantes.EstudianteID = Matricula.EstudianteID " &
                                      "WHERE Estudiantes.EstudianteID = @estudianteID"

                Dim dt As New DataTable()

                Using connection As New SqlConnection(conn)
                    Using cmd As New SqlCommand(query, connection)
                        cmd.Parameters.AddWithValue("@estudianteID", estudianteID)

                        Try
                            connection.Open()
                            Dim adapter As New SqlDataAdapter(cmd)
                            adapter.Fill(dt)

                            If dt.Rows.Count > 0 Then
                                DataGridView1.DataSource = dt
                            Else
                                MessageBox.Show("No se encontraron resultados en la tabla Matricula.")
                            End If
                        Catch ex As Exception
                            MessageBox.Show("Error al buscar en la base de datos: " & ex.Message)
                        End Try
                    End Using
                End Using
            Else
                MessageBox.Show("No se encontró el estudiante en la tabla Estudiantes.")
            End If
        Else
            MessageBox.Show("Por favor, ingresa un término de búsqueda.")
        End If
    End Sub

    Private Function ObtenerEstudianteID(searchTerm As String) As Integer
        Dim estudianteID As Integer = -1
        Dim query As String = "SELECT EstudianteID FROM Estudiantes WHERE Nombre = @searchTerm"

        Using connection As New SqlConnection(conn)
            Using cmd As New SqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@searchTerm", searchTerm)

                Try
                    connection.Open()
                    Dim result As Object = cmd.ExecuteScalar()

                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        estudianteID = Convert.ToInt32(result)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error al obtener el ID del estudiante: " & ex.Message)
                End Try
            End Using
        End Using

        Return estudianteID
    End Function
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs)
        ' Verifica si hay una fila seleccionada en el DataGridView1
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Obtiene el valor seleccionado de la columna CursoID en el DataGridView1
            Dim cursoID As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("CursoID").Value)

            ' Realiza la consulta para obtener los datos de Clases, Profesores y Materias
            Dim query As String = "SELECT Clases.ClaseID, Clases.CursoID, Profesores.Nombre, Materias.NombreMateria " &
                                  "FROM Clases " &
                                  "INNER JOIN Profesores ON Clases.ProfesorID = Profesores.ProfesorID " &
                                  "INNER JOIN Materias ON Clases.MateriaID = Materias.MateriaID " &
                                  "WHERE Clases.CursoID = @cursoID"

            ' Crea un DataTable para almacenar los resultados
            Dim dt As New DataTable()

            ' Conecta con la base de datos y ejecuta la consulta
            Using connection As New SqlConnection(conn)
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@cursoID", cursoID)

                    Try
                        connection.Open()
                        Dim adapter As New SqlDataAdapter(cmd)
                        adapter.Fill(dt)

                        ' Verifica si se encontraron resultados
                        If dt.Rows.Count > 0 Then
                            DataGridView2.DataSource = dt
                        Else
                            MessageBox.Show("No se encontraron resultados para el CursoID seleccionado en la tabla Clases.")
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Error al obtener datos de la base de datos: " & ex.Message)
                    End Try
                End Using
            End Using
        Else
            MessageBox.Show("Por favor, selecciona una fila en el DataGridView1.")
        End If
    End Sub

    Private Function ObtenerUltimoIDIns() As Integer
        Dim ultimoID As Integer = 0
        Dim consulta As String = "SELECT MAX(ClaseID) FROM Inscripciones"

        Using conexion As New SqlConnection(conn)
            Using comando As New SqlCommand(consulta, conexion)
                Try
                    conexion.Open()
                    Dim resultado = comando.ExecuteScalar()

                    If resultado IsNot DBNull.Value Then
                        ultimoID = Convert.ToInt32(resultado) + 1
                    Else
                        ultimoID = 1
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error al obtener el último ID de Inscripciones: " & ex.Message)
                End Try
            End Using
        End Using

        Return ultimoID
    End Function

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        ' Verifica si hay una fila seleccionada en el DataGridView1 y DataGridView2
        If DataGridView1.SelectedRows.Count > 0 AndAlso DataGridView2.SelectedRows.Count > 0 Then
            ' Obtiene el valor seleccionado de las columnas EstudianteID y ClaseID
            Dim estudianteID As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("EstudianteID").Value)
            Dim claseID As Integer = Convert.ToInt32(DataGridView2.SelectedRows(0).Cells("ClaseID").Value)

            ' Obtiene el último ID de Inscripciones
            Dim ultimoID As Integer = ObtenerUltimoIDIns()

            ' Realiza la inserción en la tabla Inscripciones con el último ID
            InsertarInscripcion(estudianteID, claseID, ultimoID)
        Else
            MessageBox.Show("Por favor, selecciona una fila en ambos DataGridViews.")
        End If
    End Sub

    Private Sub InsertarInscripcion(estudianteID As Integer, claseID As Integer, ultimoID As Integer)
        ' Consulta SQL para insertar datos en la tabla Inscripciones
        Dim consulta As String = "INSERT INTO Inscripciones (InscripcionID, EstudianteID, ClaseID) VALUES (@InscripcionID, @EstudianteID, @ClaseID)"

        ' Crear la conexión y el comando SQL
        Using conexion As New SqlConnection(conn)
            Using comando As New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@InscripcionID", ultimoID)
                comando.Parameters.AddWithValue("@EstudianteID", estudianteID)
                comando.Parameters.AddWithValue("@ClaseID", claseID)

                Try
                    conexion.Open()
                    comando.ExecuteNonQuery()
                    MessageBox.Show("Inscripción agregada correctamente.")
                Catch ex As Exception
                    MessageBox.Show("Error al insertar en la tabla Inscripciones: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
    Private Sub LimpiarControles()
        ' Limpiar el contenido de los DataGridView
        DataGridView1.DataSource = Nothing
        DataGridView2.DataSource = Nothing


    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarControles()
    End Sub
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
    End Sub
End Class