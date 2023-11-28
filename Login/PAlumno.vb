Imports System.Data.SqlClient

Public Class PAlumno
    ' Cadena de conexión a la base de datos SQL Server
    Dim conn As String = "Data Source=SPIDEY31;Initial Catalog=CargaMaterias;Integrated Security=True"
    Private Sub btnRegistroA_Click(sender As Object, e As EventArgs) Handles btnRegistroA.Click

        Dim nuevoIDA As Integer = NuevoIDEstudiante()
        If InsertarEstudiante(nuevoIDA) Then
            ' Si la inserción en la tabla Estudiantes fue exitosa, insertar en Matricula
            Dim nuevoIDM As Integer = NuevoIDMatricula()
            If nuevoIDM > 0 Then
                InsertarMatricula(nuevoIDA, nuevoIDM)
            Else
                MessageBox.Show("No se pudo obtener un nuevo ID para Matricula.")
            End If
        Else
            MessageBox.Show("La inserción en la tabla Estudiantes falló.")
        End If
    End Sub
    Private Sub LimpiarCampos()
        ' Limpiar los TextBox
        txtbNombreA.Text = ""
        txtbApellidoA.Text = ""
        txtbCorreo.Text = ""

        ' Limpiar las selecciones de los ListBox
        ListBoxCurso.ClearSelected()
        ListBoxPeriodo.ClearSelected()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos()
    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub


    ' Función para obtener el nuevo ID incrementado
    Private Function NuevoIDEstudiante() As Integer
        Dim nuevoIDAlumn As Integer = 0

        ' Consulta SQL para obtener el último EstudianteID
        Dim consulta As String = "SELECT MAX(EstudianteID) FROM Estudiantes"

        ' Crear la conexión y el comando SQL
        Using conexion As New SqlConnection(conn)
            Using comando As New SqlCommand(consulta, conexion)
                conexion.Open()

                ' Ejecutar la consulta y obtener el último EstudianteID
                Dim resultado = comando.ExecuteScalar()
                If resultado IsNot DBNull.Value Then
                    nuevoIDAlumn = Convert.ToInt32(resultado) + 1
                Else
                    nuevoIDAlumn = 1 ' Si no hay registros, comenzar desde 1
                End If
            End Using
        End Using

        Return nuevoIDAlumn
    End Function
    ' Función para obtener el nuevo ID incrementado para la matrícula
    Private Function NuevoIDMatricula() As Integer
        Dim nuevoID As Integer = 0

        ' Consulta SQL para obtener el último MatriculaID
        Dim consulta As String = "SELECT MAX(MatriculaID) FROM Matricula"

        ' Crear la conexión y el comando SQL
        Using conexion As New SqlConnection(conn)
            Using comando As New SqlCommand(consulta, conexion)
                conexion.Open()

                ' Ejecutar la consulta y obtener el último MatriculaID
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

    ' Función para insertar datos en la tabla Estudiantes
    Private Function InsertarEstudiante(ByVal nuevoIDA As Integer) As Boolean
        ' Consulta SQL para insertar datos en la tabla Estudiantes
        Dim consulta As String = "INSERT INTO Estudiantes (EstudianteID, Nombre, Apellido, FechaNacimiento, CorreoElectronico) VALUES (@EstudianteID, @Nombre, @Apellido, @FechaNacimiento, @CorreoElectronico)"

        ' Crear la conexión y el comando SQL
        Using conexion As New SqlConnection(conn)
            Using comando As New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@EstudianteID", nuevoIDA)
                comando.Parameters.AddWithValue("@Nombre", txtbNombreA.Text)
                comando.Parameters.AddWithValue("@Apellido", txtbApellidoA.Text)
                comando.Parameters.AddWithValue("@FechaNacimiento", dtpFechaNacimiento.Value)
                comando.Parameters.AddWithValue("@CorreoElectronico", txtbCorreo.Text)
                conexion.Open()

                ' Ejecutar la consulta para insertar los datos
                comando.ExecuteNonQuery()
                MessageBox.Show("Datos insertados correctamente.")
            End Using
        End Using
        Return True
    End Function
    ' Función para insertar datos en la tabla Matricula
    Private Sub InsertarMatricula(ByVal nuevoIDA As Integer, ByVal nuevoIDM As Integer)
        ' Obtener los valores seleccionados de los ListBox
        Dim curso As String = ListBoxCurso.SelectedItem.ToString()
        If ListBoxCurso.SelectedItem IsNot Nothing Then
            ' Resto de tu lógica aquí...
        Else
            MessageBox.Show("Debes seleccionar un Curso.")
        End If
        Dim periodo As String = ListBoxPeriodo.SelectedItem.ToString()
        If ListBoxPeriodo.SelectedItem IsNot Nothing Then
            ' Resto de tu lógica aquí...
        Else
            MessageBox.Show("Debes seleccionar un período.")
        End If


        ' Consulta SQL para insertar datos en la tabla Matricula
        Dim consulta As String = "INSERT INTO Matricula (MatriculaID, EstudianteID, CursoID, PeriodoID) VALUES (@MatriculaID, @EstudianteID, @Curso, @Periodo)"

        ' Crear la conexión y el comando SQL
        Using conexion As New SqlConnection(conn)
            Using comando As New SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@MatriculaID", nuevoIDM)
                comando.Parameters.AddWithValue("@EstudianteID", nuevoIDA)
                comando.Parameters.AddWithValue("@Periodo", periodo)
                comando.Parameters.AddWithValue("@Curso", curso)
                conexion.Open()

                ' Ejecutar la consulta para insertar los datos
                comando.ExecuteNonQuery()
                MessageBox.Show("Datos insertados correctamente en Matricula.")
            End Using
        End Using
    End Sub

    Private Sub PAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
