<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnAlumno = New Button()
        btnMaestro = New Button()
        btnSalir = New Button()
        btnEliminarA = New Button()
        btnEliminarM = New Button()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' btnAlumno
        ' 
        btnAlumno.Location = New Point(11, 15)
        btnAlumno.Name = "btnAlumno"
        btnAlumno.Size = New Size(228, 112)
        btnAlumno.TabIndex = 0
        btnAlumno.Text = "REGISTRAR ALUMNO"
        btnAlumno.UseVisualStyleBackColor = True
        ' 
        ' btnMaestro
        ' 
        btnMaestro.Location = New Point(11, 133)
        btnMaestro.Name = "btnMaestro"
        btnMaestro.Size = New Size(228, 112)
        btnMaestro.TabIndex = 1
        btnMaestro.Text = "REGISTRAR MAESTRO"
        btnMaestro.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(518, 251)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(228, 112)
        btnSalir.TabIndex = 2
        btnSalir.Text = "SALIR"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarA
        ' 
        btnEliminarA.Location = New Point(262, 15)
        btnEliminarA.Name = "btnEliminarA"
        btnEliminarA.Size = New Size(228, 112)
        btnEliminarA.TabIndex = 3
        btnEliminarA.Text = "ELIMINAR ALUMNO"
        btnEliminarA.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarM
        ' 
        btnEliminarM.Location = New Point(262, 133)
        btnEliminarM.Name = "btnEliminarM"
        btnEliminarM.Size = New Size(228, 112)
        btnEliminarM.TabIndex = 4
        btnEliminarM.Text = "ELIMINAR MAESTRO"
        btnEliminarM.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(11, 251)
        Button1.Name = "Button1"
        Button1.Size = New Size(228, 112)
        Button1.TabIndex = 5
        Button1.Text = "REGISTRO DE CLASES"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(262, 251)
        Button2.Name = "Button2"
        Button2.Size = New Size(228, 112)
        Button2.TabIndex = 6
        Button2.Text = "INSCRIPCION A CLASES"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(518, 15)
        Button3.Name = "Button3"
        Button3.Size = New Size(228, 112)
        Button3.TabIndex = 7
        Button3.Text = "NOTAS"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Inicio
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(758, 379)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(btnEliminarM)
        Controls.Add(btnEliminarA)
        Controls.Add(btnSalir)
        Controls.Add(btnMaestro)
        Controls.Add(btnAlumno)
        Name = "Inicio"
        Text = "INICIO"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnAlumno As Button
    Friend WithEvents btnMaestro As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnEliminarA As Button
    Friend WithEvents btnEliminarM As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
