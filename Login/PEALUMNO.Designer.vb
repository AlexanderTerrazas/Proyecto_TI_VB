<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PEALUMNO
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
        btnBuscar = New Button()
        txtbBusqueda = New TextBox()
        Resultados = New DataGridView()
        btnEliminar = New Button()
        btnRegresar = New Button()
        btnLimpiar = New Button()
        CType(Resultados, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(12, 15)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(159, 45)
        btnBuscar.TabIndex = 0
        btnBuscar.Text = "BUSCAR"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' txtbBusqueda
        ' 
        txtbBusqueda.Location = New Point(193, 24)
        txtbBusqueda.Name = "txtbBusqueda"
        txtbBusqueda.Size = New Size(367, 27)
        txtbBusqueda.TabIndex = 1
        ' 
        ' Resultados
        ' 
        Resultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Resultados.Location = New Point(12, 66)
        Resultados.Name = "Resultados"
        Resultados.RowHeadersWidth = 51
        Resultados.RowTemplate.Height = 29
        Resultados.Size = New Size(548, 189)
        Resultados.TabIndex = 2
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(401, 273)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(159, 45)
        btnEliminar.TabIndex = 3
        btnEliminar.Text = "ELIMINAR"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnRegresar
        ' 
        btnRegresar.Location = New Point(12, 273)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(159, 45)
        btnRegresar.TabIndex = 4
        btnRegresar.Text = "REGRESAR"
        btnRegresar.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(207, 273)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(159, 45)
        btnLimpiar.TabIndex = 5
        btnLimpiar.Text = "LIMPIAR"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' PEALUMNO
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(575, 339)
        Controls.Add(btnLimpiar)
        Controls.Add(btnRegresar)
        Controls.Add(btnEliminar)
        Controls.Add(Resultados)
        Controls.Add(txtbBusqueda)
        Controls.Add(btnBuscar)
        Name = "PEALUMNO"
        Text = "ELIMINACION DE ALUMNOS"
        CType(Resultados, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtbBusqueda As TextBox
    Friend WithEvents Resultados As DataGridView
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnLimpiar As Button
End Class
