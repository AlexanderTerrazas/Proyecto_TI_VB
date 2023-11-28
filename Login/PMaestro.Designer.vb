<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PMaestro
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
        txtbNombreM = New TextBox()
        txtbApellidoM = New TextBox()
        txtbCorreoM = New TextBox()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Button1 = New Button()
        btnRegistroM = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' txtbNombreM
        ' 
        txtbNombreM.Location = New Point(174, 12)
        txtbNombreM.Name = "txtbNombreM"
        txtbNombreM.Size = New Size(332, 27)
        txtbNombreM.TabIndex = 18
        ' 
        ' txtbApellidoM
        ' 
        txtbApellidoM.Location = New Point(174, 54)
        txtbApellidoM.Name = "txtbApellidoM"
        txtbApellidoM.Size = New Size(332, 27)
        txtbApellidoM.TabIndex = 17
        ' 
        ' txtbCorreoM
        ' 
        txtbCorreoM.Location = New Point(174, 101)
        txtbCorreoM.Name = "txtbCorreoM"
        txtbCorreoM.Size = New Size(332, 27)
        txtbCorreoM.TabIndex = 16
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(105, 104)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 20)
        Label4.TabIndex = 15
        Label4.Text = "E-mail"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(10, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(149, 20)
        Label2.TabIndex = 13
        Label2.Text = "Apellido del Maestro"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(10, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(147, 20)
        Label1.TabIndex = 12
        Label1.Text = "Nombre del Maestro"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(10, 149)
        Button1.Name = "Button1"
        Button1.Size = New Size(245, 62)
        Button1.TabIndex = 19
        Button1.Text = "REGRESAR"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnRegistroM
        ' 
        btnRegistroM.Location = New Point(261, 149)
        btnRegistroM.Name = "btnRegistroM"
        btnRegistroM.Size = New Size(245, 62)
        btnRegistroM.TabIndex = 20
        btnRegistroM.Text = "REGISTRAR MAESTRO"
        btnRegistroM.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(483, 269)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 21
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' PMaestro
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(519, 227)
        Controls.Add(Button3)
        Controls.Add(btnRegistroM)
        Controls.Add(Button1)
        Controls.Add(txtbNombreM)
        Controls.Add(txtbApellidoM)
        Controls.Add(txtbCorreoM)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "PMaestro"
        Text = "REGISTRO DE MAESTROS"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtbNombreM As TextBox
    Friend WithEvents txtbApellidoM As TextBox
    Friend WithEvents txtbCorreoM As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnRegistroM As Button
    Friend WithEvents Button3 As Button
End Class
