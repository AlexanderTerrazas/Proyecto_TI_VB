<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnAcceder = New Button()
        btnCancelar = New Button()
        txtbUsuario = New TextBox()
        txtbPassword = New TextBox()
        lbUsuario = New Label()
        lbPassword = New Label()
        SuspendLayout()
        ' 
        ' btnAcceder
        ' 
        btnAcceder.Location = New Point(219, 180)
        btnAcceder.Name = "btnAcceder"
        btnAcceder.Size = New Size(153, 47)
        btnAcceder.TabIndex = 0
        btnAcceder.Text = "Acceder"
        btnAcceder.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(409, 180)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(153, 47)
        btnCancelar.TabIndex = 1
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' txtbUsuario
        ' 
        txtbUsuario.Location = New Point(318, 61)
        txtbUsuario.Name = "txtbUsuario"
        txtbUsuario.Size = New Size(244, 27)
        txtbUsuario.TabIndex = 2
        ' 
        ' txtbPassword
        ' 
        txtbPassword.Location = New Point(318, 123)
        txtbPassword.Name = "txtbPassword"
        txtbPassword.PasswordChar = "*"c
        txtbPassword.Size = New Size(244, 27)
        txtbPassword.TabIndex = 3
        ' 
        ' lbUsuario
        ' 
        lbUsuario.AutoSize = True
        lbUsuario.Location = New Point(230, 68)
        lbUsuario.Name = "lbUsuario"
        lbUsuario.Size = New Size(59, 20)
        lbUsuario.TabIndex = 4
        lbUsuario.Text = "Usuario"
        ' 
        ' lbPassword
        ' 
        lbPassword.AutoSize = True
        lbPassword.Location = New Point(219, 126)
        lbPassword.Name = "lbPassword"
        lbPassword.Size = New Size(70, 20)
        lbPassword.TabIndex = 5
        lbPassword.Text = "Password"
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(611, 272)
        Controls.Add(lbPassword)
        Controls.Add(lbUsuario)
        Controls.Add(txtbPassword)
        Controls.Add(txtbUsuario)
        Controls.Add(btnCancelar)
        Controls.Add(btnAcceder)
        Name = "LoginForm"
        Text = "SESION"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAcceder As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtbUsuario As TextBox
    Friend WithEvents txtbPassword As TextBox
    Friend WithEvents lbUsuario As Label
    Friend WithEvents lbPassword As Label
End Class
