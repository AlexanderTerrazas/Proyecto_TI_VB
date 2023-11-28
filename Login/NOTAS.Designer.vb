<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NOTAS
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
        txtBusqueda = New TextBox()
        btnBuscar = New Button()
        DataGridView1 = New DataGridView()
        btnLimpiar = New Button()
        btnRegresar = New Button()
        btnAgregar = New Button()
        Label4 = New Label()
        btnActualizar = New Button()
        DataGridView2 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtBusqueda
        ' 
        txtBusqueda.Location = New Point(140, 31)
        txtBusqueda.Name = "txtBusqueda"
        txtBusqueda.Size = New Size(442, 27)
        txtBusqueda.TabIndex = 0
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(10, 17)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(117, 54)
        btnBuscar.TabIndex = 1
        btnBuscar.Text = "BUSCAR"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(137, 87)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(890, 182)
        DataGridView1.TabIndex = 2
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(494, 579)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(159, 45)
        btnLimpiar.TabIndex = 25
        btnLimpiar.Text = "LIMPIAR"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnRegresar
        ' 
        btnRegresar.Location = New Point(139, 579)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(159, 45)
        btnRegresar.TabIndex = 24
        btnRegresar.Text = "REGRESAR"
        btnRegresar.UseVisualStyleBackColor = True
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Location = New Point(870, 579)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(159, 45)
        btnAgregar.TabIndex = 23
        btnAgregar.Text = "AGREGAR"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(196, 559)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 20)
        Label4.TabIndex = 22
        ' 
        ' btnActualizar
        ' 
        btnActualizar.Location = New Point(25, 285)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(106, 52)
        btnActualizar.TabIndex = 21
        btnActualizar.Text = "ACTUALIZAR" & vbCrLf & "TABLA"
        btnActualizar.UseVisualStyleBackColor = True
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AllowUserToAddRows = False
        DataGridView2.AllowUserToDeleteRows = False
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(137, 285)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.ReadOnly = True
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.RowTemplate.Height = 29
        DataGridView2.Size = New Size(890, 271)
        DataGridView2.TabIndex = 20
        ' 
        ' NOTAS
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1055, 655)
        Controls.Add(btnLimpiar)
        Controls.Add(btnRegresar)
        Controls.Add(btnAgregar)
        Controls.Add(Label4)
        Controls.Add(btnActualizar)
        Controls.Add(DataGridView2)
        Controls.Add(DataGridView1)
        Controls.Add(btnBuscar)
        Controls.Add(txtBusqueda)
        Name = "NOTAS"
        Text = "REGISTRO DE NOTAS"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnActualizar As Button
    Friend WithEvents DataGridView2 As DataGridView
End Class
