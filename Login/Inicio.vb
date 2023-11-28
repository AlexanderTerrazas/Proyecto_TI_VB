Public Class Inicio
    Private Sub btnAlumno_Click(sender As Object, e As EventArgs) Handles btnAlumno.Click
        ' Verifica si el formulario ya está abierto
        For Each form As Form In Application.OpenForms
            If TypeOf form Is PAlumno Then
                form.BringToFront() ' Muestra el formulario si está abierto
                Exit Sub ' Sale del procedimiento si ya está abierto
            End If
        Next

        ' Si el formulario no está abierto, crea una nueva instancia y lo muestra
        Dim formularioPAlumno As New PAlumno()
        formularioPAlumno.Show()
    End Sub

    Private Sub btnMaestro_Click(sender As Object, e As EventArgs) Handles btnMaestro.Click
        ' Verifica si el formulario ya está abierto
        For Each form As Form In Application.OpenForms
            If TypeOf form Is PMaestro Then
                form.BringToFront() ' Muestra el formulario si está abierto
                Exit Sub ' Sale del procedimiento si ya está abierto
            End If
        Next

        ' Si el formulario no está abierto, crea una nueva instancia y lo muestra
        Dim formularioPMaestro As New PMaestro()
        formularioPMaestro.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        ' Crear una lista para almacenar las formas a cerrar
        Dim formsACerrar As New List(Of Form)

        ' Agregar las formas a la lista
        For Each form As Form In Application.OpenForms
            formsACerrar.Add(form)
        Next

        ' Cerrar las formas después de haberlas añadido a la lista
        For Each form As Form In formsACerrar
            form.Close()
        Next

        ' Crear una nueva instancia del formulario de inicio si no existe
        Dim formularioInicio As LoginForm
        For Each form As Form In Application.OpenForms
            If TypeOf form Is LoginForm Then
                formularioInicio = CType(form, LoginForm)
                Exit For
            End If
        Next

        If LoginForm Is Nothing Then
        End If

        ' Mostrar el formulario de inicio
        LoginForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEliminarA.Click
        ' Verifica si el formulario ya está abierto
        For Each form As Form In Application.OpenForms
            If TypeOf form Is PEALUMNO Then
                form.BringToFront() ' Muestra el formulario si está abierto
                Exit Sub ' Sale del procedimiento si ya está abierto
            End If
        Next

        ' Si el formulario no está abierto, crea una nueva instancia y lo muestra
        Dim formularioPEALUMNO As New PEALUMNO()
        formularioPEALUMNO.Show()
    End Sub

    Private Sub btnEliminarM_Click(sender As Object, e As EventArgs) Handles btnEliminarM.Click
        ' Verifica si el formulario ya está abierto
        For Each form As Form In Application.OpenForms
            If TypeOf form Is PEMAESTRO Then
                form.BringToFront() ' Muestra el formulario si está abierto
                Exit Sub ' Sale del procedimiento si ya está abierto
            End If
        Next

        ' Si el formulario no está abierto, crea una nueva instancia y lo muestra
        Dim formularioPEMAESTRO As New PEMAESTRO()
        formularioPEMAESTRO.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ' Verifica si el formulario ya está abierto
        For Each form As Form In Application.OpenForms
            If TypeOf form Is CLASES Then
                form.BringToFront() ' Muestra el formulario si está abierto
                Exit Sub ' Sale del procedimiento si ya está abierto
            End If
        Next

        ' Si el formulario no está abierto, crea una nueva instancia y lo muestra
        Dim formularioclases As New CLASES()
        formularioclases.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Verifica si el formulario ya está abierto
        For Each form As Form In Application.OpenForms
            If TypeOf form Is INSCRIPCION Then
                form.BringToFront() ' Muestra el formulario si está abierto
                Exit Sub ' Sale del procedimiento si ya está abierto
            End If
        Next

        ' Si el formulario no está abierto, crea una nueva instancia y lo muestra
        Dim formularioins As New INSCRIPCION()
        formularioins.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Verifica si el formulario ya está abierto
        For Each form As Form In Application.OpenForms
            If TypeOf form Is NOTAS Then
                form.BringToFront() ' Muestra el formulario si está abierto
                Exit Sub ' Sale del procedimiento si ya está abierto
            End If
        Next

        ' Si el formulario no está abierto, crea una nueva instancia y lo muestra
        Dim formularioNOT As New NOTAS()
        formularioNOT.Show()
    End Sub
End Class