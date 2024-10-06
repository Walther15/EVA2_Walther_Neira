<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRut = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rbtnMasculino = New System.Windows.Forms.RadioButton()
        Me.rbtnFemenino = New System.Windows.Forms.RadioButton()
        Me.rbtnNoEspecifica = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboComuna = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnVerDatos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RUT"
        '
        'txtRut
        '
        Me.txtRut.Location = New System.Drawing.Point(103, 40)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(135, 22)
        Me.txtRut.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(103, 82)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(227, 22)
        Me.txtNombre.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Apellido"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(103, 126)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(227, 22)
        Me.txtApellido.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Sexo:"
        '
        'rbtnMasculino
        '
        Me.rbtnMasculino.AutoSize = True
        Me.rbtnMasculino.Location = New System.Drawing.Point(44, 220)
        Me.rbtnMasculino.Name = "rbtnMasculino"
        Me.rbtnMasculino.Size = New System.Drawing.Size(92, 21)
        Me.rbtnMasculino.TabIndex = 7
        Me.rbtnMasculino.TabStop = True
        Me.rbtnMasculino.Text = "Masculino"
        Me.rbtnMasculino.UseVisualStyleBackColor = True
        '
        'rbtnFemenino
        '
        Me.rbtnFemenino.AutoSize = True
        Me.rbtnFemenino.Location = New System.Drawing.Point(143, 220)
        Me.rbtnFemenino.Name = "rbtnFemenino"
        Me.rbtnFemenino.Size = New System.Drawing.Size(91, 21)
        Me.rbtnFemenino.TabIndex = 8
        Me.rbtnFemenino.TabStop = True
        Me.rbtnFemenino.Text = "Femenino"
        Me.rbtnFemenino.UseVisualStyleBackColor = True
        '
        'rbtnNoEspecifica
        '
        Me.rbtnNoEspecifica.AutoSize = True
        Me.rbtnNoEspecifica.Location = New System.Drawing.Point(241, 220)
        Me.rbtnNoEspecifica.Name = "rbtnNoEspecifica"
        Me.rbtnNoEspecifica.Size = New System.Drawing.Size(114, 21)
        Me.rbtnNoEspecifica.TabIndex = 9
        Me.rbtnNoEspecifica.TabStop = True
        Me.rbtnNoEspecifica.Text = "No especifica"
        Me.rbtnNoEspecifica.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 278)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Comuna"
        '
        'cboComuna
        '
        Me.cboComuna.FormattingEnabled = True
        Me.cboComuna.Location = New System.Drawing.Point(100, 278)
        Me.cboComuna.Name = "cboComuna"
        Me.cboComuna.Size = New System.Drawing.Size(227, 24)
        Me.cboComuna.TabIndex = 11
        Me.cboComuna.Text = "Seleccione"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 320)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Ciudad"
        '
        'txtCiudad
        '
        Me.txtCiudad.Location = New System.Drawing.Point(100, 320)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(227, 22)
        Me.txtCiudad.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(34, 371)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Observación"
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(128, 368)
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(199, 22)
        Me.txtObservacion.TabIndex = 15
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(255, 40)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 16
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(37, 410)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(99, 28)
        Me.btnGuardar.TabIndex = 17
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(100, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 17)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Ejemplo: 123456789"
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(191, 413)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(90, 25)
        Me.btnActualizar.TabIndex = 19
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(37, 458)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(99, 27)
        Me.btnEliminar.TabIndex = 20
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnVerDatos
        '
        Me.btnVerDatos.Location = New System.Drawing.Point(181, 458)
        Me.btnVerDatos.Name = "btnVerDatos"
        Me.btnVerDatos.Size = New System.Drawing.Size(136, 23)
        Me.btnVerDatos.TabIndex = 21
        Me.btnVerDatos.Text = "Ver Datos BD"
        Me.btnVerDatos.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 511)
        Me.Controls.Add(Me.btnVerDatos)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtObservacion)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCiudad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboComuna)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.rbtnNoEspecifica)
        Me.Controls.Add(Me.rbtnFemenino)
        Me.Controls.Add(Me.rbtnMasculino)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRut)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtRut As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents rbtnMasculino As RadioButton
    Friend WithEvents rbtnFemenino As RadioButton
    Friend WithEvents rbtnNoEspecifica As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents cboComuna As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtObservacion As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnVerDatos As Button
End Class
