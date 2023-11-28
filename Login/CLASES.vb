Imports System.Data.SqlClient

Public Class CLASES
    ' Cadena de conexión a la base de datos SQL Server
    Dim conn As String = "Data Source=SPIDEY31;Initial Catalog=CargaMaterias;Integrated Security=True"


    Private Sub TuFormulario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub


    Private Sub MostrarMaestros()
        Dim consulta As String = "SELECT ProfesorID, Nombre, Apellido FROM Profesores"

        Using conexion As New SqlConnection(conn)
            Using adaptador As New SqlDataAdapter(consulta, conexion)
                Dim tablaMaestros As New DataTable()

                Try
                    conexion.Open()
                    adaptador.Fill(tablaMaestros)
                    ResultadosP.DataSource = tablaMaestros
                Catch ex As Exception
                    MessageBox.Show("Error al mostrar maestros: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnMaestros_Click(sender As Object, e As EventArgs) Handles btnMaestros.Click
        MostrarMaestros()
    End Sub
    Private Sub MostrarMaterias()
        Dim consulta As String = "SELECT MateriaID, NombreMateria FROM Materias"

        Using conexion As New SqlConnection(conn)
            Using adaptador As New SqlDataAdapter(consulta, conexion)
                Dim tablaMaterias As New DataTable()

                Try
                    conexion.Open()
                    adaptador.Fill(tablaMaterias)
                    ResultadosM.DataSource = tablaMaterias
                Catch ex As Exception
                    MessageBox.Show("Error al mostrar materias: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnMaterias_Click(sender As Object, e As EventArgs) Handles btnMaterias.Click
        MostrarMaterias()
    End Sub

    Private Function ObtenerUltimoIDClase() As Integer
        Dim ultimoID As Integer = 0
        Dim consulta As String = "SELECT MAX(ClaseID) FROM Clases"

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
                    MessageBox.Show("Error al obtener el último ID de clase: " & ex.Message)
                End Try
            End Using
        End Using

        Return ultimoID
    End Function

    Private Function InsertarClase(ByVal ultimoID As Integer) As Boolean
        Dim profesorID As Integer = Convert.ToInt32(ResultadosP.CurrentRow.Cells("ProfesorID").Value)
        Dim materiaID As Integer = Convert.ToInt32(ResultadosM.CurrentRow.Cells("MateriaID").Value)
        Dim Curso As String = ComboBox1.SelectedItem.ToString()

        Dim consulta As String = "INSERT INTO Clases (ClaseID, CursoID, ProfesorID, MateriaID) VALUES (@ClaseID, @curso, @ProfesorID, @MateriaID)"

        Using conexion As New SqlConnection(conn)
            Using comando As New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@ClaseID", ultimoID)
                comando.Parameters.AddWithValue("@ProfesorID", profesorID)
                comando.Parameters.AddWithValue("@MateriaID", materiaID)
                comando.Parameters.AddWithValue("@curso", Curso)

                Try
                    conexion.Open()
                    comando.ExecuteNonQuery()
                    MessageBox.Show("Clase agregada correctamente.")
                Catch ex As Exception
                    MessageBox.Show("Error al agregar la clase: " & ex.Message)
                End Try
            End Using
        End Using

        Return False
    End Function

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim ultimoIDClase As Integer = ObtenerUltimoIDClase()

        If ResultadosP.CurrentRow IsNot Nothing AndAlso ResultadosM.CurrentRow IsNot Nothing AndAlso ComboBox1.SelectedItem IsNot Nothing Then
            InsertarClase(ultimoIDClase)
        Else
            MessageBox.Show("Por favor, seleccione un profesor, una materia y un curso.")
        End If
    End Sub
    Private Sub LimpiarControles()
        ' Limpiar el contenido de los DataGridView
        ResultadosP.DataSource = Nothing
        ResultadosM.DataSource = Nothing

        ' Limpiar la selección del ComboBox y establecer el índice en -1
        ComboBox1.SelectedIndex = -1
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarControles()
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class