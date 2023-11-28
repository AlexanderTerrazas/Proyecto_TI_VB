<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CLASES
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
        ResultadosP = New DataGridView()
        btnMaestros = New Button()
        btnMaterias = New Button()
        ResultadosM = New DataGridView()
        Label4 = New Label()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        btnLimpiar = New Button()
        btnRegresar = New Button()
        btnAgregar = New Button()
        CType(ResultadosP, ComponentModel.ISupportInitialize).BeginInit()
        CType(ResultadosM, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ResultadosP
        ' 
        ResultadosP.AllowUserToAddRows = False
        ResultadosP.AllowUserToDeleteRows = False
        ResultadosP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ResultadosP.Location = New Point(163, 38)
        ResultadosP.Name = "ResultadosP"
        ResultadosP.ReadOnly = True
        ResultadosP.RowHeadersWidth = 51
        ResultadosP.RowTemplate.Height = 29
        ResultadosP.Size = New Size(304, 114)
        ResultadosP.TabIndex = 6
        ' 
        ' btnMaestros
        ' 
        btnMaestros.Location = New Point(33, 38)
        btnMaestros.Name = "btnMaestros"
        btnMaestros.Size = New Size(124, 44)
        btnMaestros.TabIndex = 7
        btnMaestros.Text = "MAESTROS"
        btnMaestros.UseVisualStyleBackColor = True
        ' 
        ' btnMaterias
        ' 
        btnMaterias.Location = New Point(33, 158)
        btnMaterias.Name = "btnMaterias"
        btnMaterias.Size = New Size(124, 44)
        btnMaterias.TabIndex = 8
        btnMaterias.Text = "MATERIAS"
        btnMaterias.UseVisualStyleBackColor = True
        ' 
        ' ResultadosM
        ' 
        ResultadosM.AllowUserToAddRows = False
        ResultadosM.AllowUserToDeleteRows = False
        ResultadosM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ResultadosM.Location = New Point(163, 158)
        ResultadosM.Name = "ResultadosM"
        ResultadosM.ReadOnly = True
        ResultadosM.RowHeadersWidth = 51
        ResultadosM.RowTemplate.Height = 29
        ResultadosM.Size = New Size(304, 112)
        ResultadosM.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(68, 309)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 20)
        Label4.TabIndex = 10
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        ComboBox1.Location = New Point(163, 276)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(130, 28)
        ComboBox1.TabIndex = 11
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(33, 276)
        Button1.Name = "Button1"
        Button1.Size = New Size(124, 30)
        Button1.TabIndex = 12
        Button1.Text = "CURSO"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(206, 329)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(159, 45)
        btnLimpiar.TabIndex = 15
        btnLimpiar.Text = "LIMPIAR"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnRegresar
        ' 
        btnRegresar.Location = New Point(11, 329)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(159, 45)
        btnRegresar.TabIndex = 14
        btnRegresar.Text = "REGRESAR"
        btnRegresar.UseVisualStyleBackColor = True
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Location = New Point(400, 329)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(159, 45)
        btnAgregar.TabIndex = 13
        btnAgregar.Text = "AGREGAR"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' CLASES
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(569, 389)
        Controls.Add(btnLimpiar)
        Controls.Add(btnRegresar)
        Controls.Add(btnAgregar)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Controls.Add(Label4)
        Controls.Add(ResultadosM)
        Controls.Add(btnMaterias)
        Controls.Add(btnMaestros)
        Controls.Add(ResultadosP)
        Name = "CLASES"
        Text = "ASIGNACION DE CLASES"
        CType(ResultadosP, ComponentModel.ISupportInitialize).EndInit()
        CType(ResultadosM, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ResultadosP As DataGridView
    Friend WithEvents btnMaestros As Button
    Friend WithEvents btnMaterias As Button
    Friend WithEvents ResultadosM As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnAgregar As Button
End Class
