<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PEMAESTRO
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
        btnLimpiar = New Button()
        btnRegresar = New Button()
        btnEliminar = New Button()
        Resultados = New DataGridView()
        txtbBusqueda = New TextBox()
        btnBuscar = New Button()
        CType(Resultados, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(207, 268)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(159, 45)
        btnLimpiar.TabIndex = 11
        btnLimpiar.Text = "LIMPIAR"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnRegresar
        ' 
        btnRegresar.Location = New Point(12, 268)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(159, 45)
        btnRegresar.TabIndex = 10
        btnRegresar.Text = "REGRESAR"
        btnRegresar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(401, 268)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(159, 45)
        btnEliminar.TabIndex = 9
        btnEliminar.Text = "ELIMINAR"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' Resultados
        ' 
        Resultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Resultados.Location = New Point(12, 61)
        Resultados.Name = "Resultados"
        Resultados.RowHeadersWidth = 51
        Resultados.RowTemplate.Height = 29
        Resultados.Size = New Size(548, 189)
        Resultados.TabIndex = 8
        ' 
        ' txtbBusqueda
        ' 
        txtbBusqueda.Location = New Point(193, 19)
        txtbBusqueda.Name = "txtbBusqueda"
        txtbBusqueda.Size = New Size(367, 27)
        txtbBusqueda.TabIndex = 7
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(12, 10)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(159, 45)
        btnBuscar.TabIndex = 6
        btnBuscar.Text = "BUSCAR"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' PEMAESTRO
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(571, 323)
        Controls.Add(btnLimpiar)
        Controls.Add(btnRegresar)
        Controls.Add(btnEliminar)
        Controls.Add(Resultados)
        Controls.Add(txtbBusqueda)
        Controls.Add(btnBuscar)
        Name = "PEMAESTRO"
        Text = "ELIMINACION DE MAESTROS"
        CType(Resultados, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Resultados As DataGridView
    Friend WithEvents txtbBusqueda As TextBox
    Friend WithEvents btnBuscar As Button
End Class
