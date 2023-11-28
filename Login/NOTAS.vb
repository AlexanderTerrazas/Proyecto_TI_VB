Imports System.Data.SqlClient

Public Class NOTAS
    ' Cadena de conexión a la base de datos SQL Server
    Dim conn As String = "Data Source=SPIDEY31;Initial Catalog=CargaMaterias;Integrated Security=True"
    Public Sub New()
        InitializeComponent()
        AddHandler btnBuscar.Click, AddressOf btnBuscar_Click
        AddHandler btnActualizar.Click, AddressOf btnActualizar_Click
    End Sub
    Private Sub BuscarEnBaseDeDatos(ByVal searchTerm As String)
        Dim query As String = "SELECT * FROM Materias WHERE NombreMateria LIKE @searchTerm"

        Dim dt As New DataTable()

        Using connection As New SqlConnection(conn)
            Using cmd As New SqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@searchTerm", "%" & searchTerm & "%") ' Usamos '%' para buscar coincidencias parciales

                Try
                    connection.Open()
                    Dim adapter As New SqlDataAdapter(cmd)
                    adapter.Fill(dt)

                    If dt.Rows.Count > 0 Then
                        DataGridView1.DataSource = dt
                    Else
                        MessageBox.Show("No se encontraron resultados para el término de búsqueda.")
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error al buscar en la base de datos: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)
        Dim searchTerm As String = txtBusqueda.Text.Trim()

        If Not String.IsNullOrEmpty(searchTerm) Then
            BuscarEnBaseDeDatos(searchTerm)
        Else
            MessageBox.Show("Por favor, ingresa un término de búsqueda.")
        End If
    End Sub
    Private Sub InitializeDataGridView2()
        ' Define las columnas manualmente
        DataGridView2.AutoGenerateColumns = False

        ' Agrega las columnas necesarias (ClaseID, EstudianteID, Nombre, Apellido, Valor)
        ' Ajusta los nombres de las columnas y los tipos de datos según tu estructura
        DataGridView2.Columns.Add("ClaseID", "ClaseID")
        DataGridView2.Columns.Add("EstudianteID", "EstudianteID")
        DataGridView2.Columns.Add("Nombre", "Nombre")
        DataGridView2.Columns.Add("Apellido", "Apellido")

        ' Columna VALOR editable
        Dim valorColumn As New DataGridViewTextBoxColumn()
        valorColumn.DataPropertyName = "VALOR" ' Asigna el nombre de la columna en tu DataTable
        valorColumn.HeaderText = "VALOR"
        DataGridView2.Columns.Add(valorColumn)

        ' Establece la columna VALOR como editable
        DataGridView2.Columns("VALOR").ReadOnly = False
    End Sub
    Private Sub ActualizarDataGridView2(ByVal materiaID As Integer)
        ' Obtener los valores de ClaseID relacionados con el MateriaID
        Dim clasesIDs As New List(Of Integer)()

        ' Consulta para obtener los ClaseID relacionados con el MateriaID en la tabla Clases
        Dim queryClases As String = "SELECT ClaseID FROM Clases WHERE MateriaID = @materiaID"

        Using connection As New SqlConnection(conn)
            Using cmdClases As New SqlCommand(queryClases, connection)
                cmdClases.Parameters.AddWithValue("@materiaID", materiaID)

                Try
                    connection.Open()
                    Using reader As SqlDataReader = cmdClases.ExecuteReader()
                        While reader.Read()
                            clasesIDs.Add(Convert.ToInt32(reader("ClaseID")))
                        End While
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error al obtener los ClaseID: " & ex.Message)
                End Try
            End Using
        End Using

        ' Obtener los EstudianteID relacionados con los ClaseID en la tabla Inscripciones
        Dim estudiantesIDs As New List(Of Integer)()

        For Each claseID As Integer In clasesIDs
            Dim queryInscripciones As String = "SELECT EstudianteID FROM Inscripciones WHERE ClaseID = @claseID"

            Using connection As New SqlConnection(conn)
                Using cmdInscripciones As New SqlCommand(queryInscripciones, connection)
                    cmdInscripciones.Parameters.AddWithValue("@claseID", claseID)

                    Try
                        connection.Open()
                        Using reader As SqlDataReader = cmdInscripciones.ExecuteReader()
                            While reader.Read()
                                estudiantesIDs.Add(Convert.ToInt32(reader("EstudianteID")))
                            End While
                        End Using
                    Catch ex As Exception
                        MessageBox.Show("Error al obtener los EstudianteID: " & ex.Message)
                    End Try
                End Using
            End Using
        Next

        ' Obtener los datos de Estudiantes relacionados con los EstudianteID
        Dim dt As New DataTable()

        ' Agregar las columnas ClaseID y EstudianteID al DataTable
        dt.Columns.Add("ClaseID", GetType(Integer))
        dt.Columns.Add("EstudianteID", GetType(Integer))
        dt.Columns.Add("Nombre", GetType(String)) ' Supongamos que obtienes la columna Nombre
        dt.Columns.Add("Apellido", GetType(String)) ' Supongamos que obtienes la columna Apellido

        If estudiantesIDs.Count > 0 Then
            Dim queryEstudiantes As String = "SELECT Estudiantes.Nombre, Estudiantes.Apellido FROM Estudiantes WHERE EstudianteID IN (" & String.Join(",", estudiantesIDs) & ")"

            Using connection As New SqlConnection(conn)
                Using cmdEstudiantes As New SqlCommand(queryEstudiantes, connection)
                    Try
                        connection.Open()
                        Dim adapter As New SqlDataAdapter(cmdEstudiantes)
                        adapter.Fill(dt)

                        ' Agregar columna 'VALOR'
                        dt.Columns.Add("VALOR", GetType(String))

                        If dt.Rows.Count > 0 Then
                            DataGridView2.AutoGenerateColumns = True
                            DataGridView2.DataSource = dt

                            ' Establecer la columna VALOR como editable
                            DataGridView2.Columns("VALOR").ReadOnly = False

                            ' Asignar valores a las columnas ClaseID, EstudianteID, Nombre, Apellido
                            For Each row As DataGridViewRow In DataGridView2.Rows
                                If Not row.IsNewRow Then
                                    ' Obtener los valores del DataRow actual
                                    Dim claseID As Integer = Convert.ToInt32(row.Cells("ClaseID").Value)
                                    Dim estudianteID As Integer = Convert.ToInt32(row.Cells("EstudianteID").Value)
                                    Dim nombre As String = row.Cells("Nombre").Value.ToString()
                                    Dim apellido As String = row.Cells("Apellido").Value.ToString()

                                    ' Asignar los valores a las columnas correspondientes
                                    row.Cells("ClaseID").Value = claseID
                                    row.Cells("EstudianteID").Value = estudianteID
                                    row.Cells("Nombre").Value = nombre
                                    row.Cells("Apellido").Value = apellido
                                End If
                            Next

                            ' Permitir la edición de las celdas en la columna "VALOR"
                            Dim valorColumnIndex As Integer = DataGridView2.Columns("VALOR").Index

                            If valorColumnIndex <> -1 Then
                                For Each row As DataGridViewRow In DataGridView2.Rows
                                    If Not row.IsNewRow Then
                                        row.Cells(valorColumnIndex).ReadOnly = False
                                    End If
                                Next
                            End If
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Error al obtener datos de la base de datos: " & ex.Message)
                    End Try
                End Using
            End Using
        Else
            MessageBox.Show("No hay EstudianteID relacionados con los ClaseID encontrados.")
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim materiaID As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("MateriaID").Value)
            ActualizarDataGridView2(materiaID)
        Else
            MessageBox.Show("Por favor, selecciona una fila en el DataGridView1.")
        End If
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
    End Sub
    Private Sub LimpiarControles()
        ' Limpiar el contenido de los DataGridView
        DataGridView1.DataSource = Nothing
        DataGridView2.DataSource = Nothing

        txtBusqueda.Text = String.Empty


    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarControles()
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        ' Recorrer el DataGridView2 para obtener los valores a insertar en la tabla Notas
        For Each row As DataGridViewRow In DataGridView2.Rows
            ' Verifica si la fila no es la fila de nuevo ingreso y si tiene valores en las celdas requeridas
            If Not row.IsNewRow AndAlso Not row.Cells("ClaseIDColumn").Value Is Nothing AndAlso Not row.Cells("EstudianteIDColumn").Value Is Nothing AndAlso Not row.Cells("VALOR").Value Is Nothing Then
                Dim claseID As Integer = Convert.ToInt32(row.Cells("ClaseIDColumn").Value)
                Dim estudianteID As Integer = Convert.ToInt32(row.Cells("EstudianteIDColumn").Value)
                Dim valorNota As String = row.Cells("VALOR").Value.ToString()

                Dim ultimoID As Integer = ObtenerUltimoIDNot()
                ' Aquí realizas la inserción en la tabla Notas usando los valores obtenidos
                InsertarNota(claseID, estudianteID, valorNota, ultimoID)
            End If
        Next
        MessageBox.Show("Datos agregados a la tabla Notas correctamente.")
    End Sub

    Private Sub InsertarNota(claseID As Integer, estudianteID As Integer, valorNota As String, ultimoID As Integer)
        Dim query As String = "INSERT INTO Notas (NotaID, ClaseID, EstudianteID, Valor) VALUES (♦notaid@ClaseID, @EstudianteID, @Valor)"

        Using connection As New SqlConnection(conn)
            Using cmd As New SqlCommand(query, connection)

                cmd.Parameters.AddWithValue("@notaid", ultimoID)
                cmd.Parameters.AddWithValue("@ClaseID", claseID)
                cmd.Parameters.AddWithValue("@EstudianteID", estudianteID)
                cmd.Parameters.AddWithValue("@Valor", valorNota)

                Try
                    connection.Open()
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("Error al insertar la nueva nota: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
    Private Function ObtenerUltimoIDNot() As Integer
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
End Class