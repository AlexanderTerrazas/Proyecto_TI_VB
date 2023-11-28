<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class INSCRIPCION
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
        btnBuscarA = New Button()
        txtBusqueda = New TextBox()
        DataGridView1 = New DataGridView()
        DataGridView2 = New DataGridView()
        btnActualizar = New Button()
        btnLimpiar = New Button()
        btnRegresar = New Button()
        btnAgregar = New Button()
        Label4 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnBuscarA
        ' 
        btnBuscarA.Location = New Point(24, 17)
        btnBuscarA.Name = "btnBuscarA"
        btnBuscarA.Size = New Size(103, 52)
        btnBuscarA.TabIndex = 0
        btnBuscarA.Text = "BUSCAR " & vbCrLf & "ALUMNO"
        btnBuscarA.UseVisualStyleBackColor = True
        ' 
        ' txtBusqueda
        ' 
        txtBusqueda.Location = New Point(136, 30)
        txtBusqueda.Name = "txtBusqueda"
        txtBusqueda.Size = New Size(344, 27)
        txtBusqueda.TabIndex = 1
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(133, 67)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(890, 140)
        DataGridView1.TabIndex = 2
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AllowUserToAddRows = False
        DataGridView2.AllowUserToDeleteRows = False
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(133, 213)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.ReadOnly = True
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.RowTemplate.Height = 29
        DataGridView2.Size = New Size(890, 140)
        DataGridView2.TabIndex = 3
        ' 
        ' btnActualizar
        ' 
        btnActualizar.Location = New Point(21, 213)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(106, 52)
        btnActualizar.TabIndex = 4
        btnActualizar.Text = "ACTUALIZAR" & vbCrLf & "TABLA"
        btnActualizar.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(488, 383)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(159, 45)
        btnLimpiar.TabIndex = 19
        btnLimpiar.Text = "LIMPIAR"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnRegresar
        ' 
        btnRegresar.Location = New Point(133, 383)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(159, 45)
        btnRegresar.TabIndex = 18
        btnRegresar.Text = "REGRESAR"
        btnRegresar.UseVisualStyleBackColor = True
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Location = New Point(864, 383)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(159, 45)
        btnAgregar.TabIndex = 17
        btnAgregar.Text = "AGREGAR"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(190, 363)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 20)
        Label4.TabIndex = 16
        ' 
        ' INSCRIPCION
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1061, 450)
        Controls.Add(btnLimpiar)
        Controls.Add(btnRegresar)
        Controls.Add(btnAgregar)
        Controls.Add(Label4)
        Controls.Add(btnActualizar)
        Controls.Add(DataGridView2)
        Controls.Add(DataGridView1)
        Controls.Add(txtBusqueda)
        Controls.Add(btnBuscarA)
        Name = "INSCRIPCION"
        Text = "CARGA DE MATERIAS"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBuscarA As Button
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label4 As Label
End Class
