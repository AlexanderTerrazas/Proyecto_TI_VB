<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PAlumno
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtbCorreo = New TextBox()
        txtbApellidoA = New TextBox()
        txtbNombreA = New TextBox()
        dtpFechaNacimiento = New DateTimePicker()
        btnRegistroA = New Button()
        ListBoxCurso = New ListBox()
        ListBoxPeriodo = New ListBox()
        btnLimpiar = New Button()
        btnCerrar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(19, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(145, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nombre del Alumno"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(19, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(147, 20)
        Label2.TabIndex = 1
        Label2.Text = "Apellido del Alumno"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(19, 124)
        Label3.Name = "Label3"
        Label3.Size = New Size(149, 20)
        Label3.TabIndex = 2
        Label3.Text = "Fecha de Nacimiento"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(19, 165)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 20)
        Label4.TabIndex = 3
        Label4.Text = "E-mail"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(19, 202)
        Label5.Name = "Label5"
        Label5.Size = New Size(139, 20)
        Label5.TabIndex = 4
        Label5.Text = "Periodo Academico"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(301, 202)
        Label6.Name = "Label6"
        Label6.Size = New Size(46, 20)
        Label6.TabIndex = 5
        Label6.Text = "Curso"
        ' 
        ' txtbCorreo
        ' 
        txtbCorreo.Location = New Point(183, 158)
        txtbCorreo.Name = "txtbCorreo"
        txtbCorreo.Size = New Size(332, 27)
        txtbCorreo.TabIndex = 8
        ' 
        ' txtbApellidoA
        ' 
        txtbApellidoA.Location = New Point(183, 73)
        txtbApellidoA.Name = "txtbApellidoA"
        txtbApellidoA.Size = New Size(332, 27)
        txtbApellidoA.TabIndex = 9
        ' 
        ' txtbNombreA
        ' 
        txtbNombreA.Location = New Point(183, 31)
        txtbNombreA.Name = "txtbNombreA"
        txtbNombreA.Size = New Size(332, 27)
        txtbNombreA.TabIndex = 10
        ' 
        ' dtpFechaNacimiento
        ' 
        dtpFechaNacimiento.Location = New Point(183, 117)
        dtpFechaNacimiento.MaxDate = New Date(2005, 12, 31, 0, 0, 0, 0)
        dtpFechaNacimiento.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        dtpFechaNacimiento.Size = New Size(332, 27)
        dtpFechaNacimiento.TabIndex = 11
        dtpFechaNacimiento.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        ' 
        ' btnRegistroA
        ' 
        btnRegistroA.Location = New Point(183, 248)
        btnRegistroA.Name = "btnRegistroA"
        btnRegistroA.Size = New Size(332, 52)
        btnRegistroA.TabIndex = 12
        btnRegistroA.Text = "REGISTRAR ALUMNO"
        btnRegistroA.UseVisualStyleBackColor = True
        ' 
        ' ListBoxCurso
        ' 
        ListBoxCurso.FormattingEnabled = True
        ListBoxCurso.ItemHeight = 20
        ListBoxCurso.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        ListBoxCurso.Location = New Point(373, 198)
        ListBoxCurso.Name = "ListBoxCurso"
        ListBoxCurso.Size = New Size(142, 24)
        ListBoxCurso.TabIndex = 7
        ' 
        ' ListBoxPeriodo
        ' 
        ListBoxPeriodo.FormattingEnabled = True
        ListBoxPeriodo.ItemHeight = 20
        ListBoxPeriodo.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        ListBoxPeriodo.Location = New Point(183, 198)
        ListBoxPeriodo.Name = "ListBoxPeriodo"
        ListBoxPeriodo.Size = New Size(89, 24)
        ListBoxPeriodo.TabIndex = 6
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(19, 248)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(158, 52)
        btnLimpiar.TabIndex = 13
        btnLimpiar.Text = "LIMPIAR"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Location = New Point(189, 334)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(158, 31)
        btnCerrar.TabIndex = 14
        btnCerrar.Text = "CERRAR"
        btnCerrar.UseVisualStyleBackColor = True
        ' 
        ' PAlumno
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(531, 377)
        Controls.Add(btnCerrar)
        Controls.Add(btnLimpiar)
        Controls.Add(btnRegistroA)
        Controls.Add(dtpFechaNacimiento)
        Controls.Add(txtbNombreA)
        Controls.Add(txtbApellidoA)
        Controls.Add(txtbCorreo)
        Controls.Add(ListBoxCurso)
        Controls.Add(ListBoxPeriodo)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "PAlumno"
        Text = "REGISTRO DE ALUMNOS"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Private txtbCorreo As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents dtpFechaNacimiento As DateTimePicker
    Friend WithEvents btnRegistroA As Button
    Friend WithEvents ListBoxCurso As ListBox
    Friend WithEvents ListBoxPeriodo As ListBox
    Private txtbApellidoA As TextBox
    Private txtbNombreA As TextBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnCerrar As Button
End Class
