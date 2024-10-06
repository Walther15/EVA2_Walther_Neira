Imports MySql.Data.MySqlClient

Public Class Form1

    ' Cadena de conexión para MySQL
    Dim connectionString As String = "Server=localhost;Database=registropersonas;User ID='root';Password='';"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Llenar el ComboBox con comunas desde la base de datos
        CargarComunas()
    End Sub

    Private Sub CargarComunas()
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim sql As String = "SELECT NombreComuna FROM comuna" ' Asegurarse de que la tabla se llama 'comuna'

                Using cmd As New MySqlCommand(sql, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        cboComuna.Items.Clear() ' Limpiar items existentes
                        While reader.Read()
                            cboComuna.Items.Add(reader("NombreComuna").ToString())
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al cargar las comunas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim rut As String = txtRut.Text
        Dim nombre As String = txtNombre.Text
        Dim apellido As String = txtApellido.Text
        Dim sexo As String

        ' Validar la selección del sexo
        If rbtnMasculino.Checked Then
            sexo = "Masculino"
        ElseIf rbtnFemenino.Checked Then
            sexo = "Femenino"
        ElseIf rbtnNoEspecifica.Checked Then
            sexo = "No especifica"
        Else
            MessageBox.Show("Por favor, seleccionar sexo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Obtener otros campos
        Dim comuna As String = cboComuna.SelectedItem?.ToString()
        Dim ciudad As String = txtCiudad.Text
        Dim observacion As String = txtObservacion.Text

        ' Validar campos obligatorios
        If String.IsNullOrWhiteSpace(rut) Or String.IsNullOrWhiteSpace(nombre) Or String.IsNullOrWhiteSpace(apellido) Or String.IsNullOrWhiteSpace(comuna) Then
            MessageBox.Show("Por favor, complete todos los campos obligatorios (RUT, Nombre, Apellido y Comuna).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Guardar los datos en la base de datos
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                Dim sql As String = "INSERT INTO personas (RUT, Nombre, Apellido, Sexo, Comuna, Ciudad, Observacion) " &
                                    "VALUES (@rut, @nombre, @apellido, @sexo, @comuna, @ciudad, @observacion)"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@rut", rut)
                    cmd.Parameters.AddWithValue("@nombre", nombre)
                    cmd.Parameters.AddWithValue("@apellido", apellido)
                    cmd.Parameters.AddWithValue("@sexo", sexo)
                    cmd.Parameters.AddWithValue("@comuna", comuna)
                    cmd.Parameters.AddWithValue("@ciudad", ciudad)
                    cmd.Parameters.AddWithValue("@observacion", observacion)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Datos guardados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Limpiar el formulario después de guardar
                    LimpiarFormulario()
                End Using

            Catch ex As Exception
                MessageBox.Show("Error al guardar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
    ' Método para limpiar el formulario
    Private Sub LimpiarFormulario()
        txtRut.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtCiudad.Clear()
        txtObservacion.Clear()
        rbtnMasculino.Checked = False
        rbtnFemenino.Checked = False
        rbtnNoEspecifica.Checked = False
        cboComuna.SelectedIndex = -1
        txtRut.Focus() ' Colocar el foco en el campo RUT
    End Sub
    Private Sub LimpiarFormularios()
        txtNombre.Clear()
        txtApellido.Clear()
        txtCiudad.Clear()
        txtObservacion.Clear()
        rbtnMasculino.Checked = False
        rbtnFemenino.Checked = False
        rbtnNoEspecifica.Checked = False
        cboComuna.SelectedIndex = -1
        txtRut.Focus() ' Colocar el foco en el campo RUT
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim rut As String = txtRut.Text

        ' Validar que el campo RUT no esté vacío
        If String.IsNullOrWhiteSpace(rut) Then
            MessageBox.Show("Por favor, ingrese el RUT.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Buscar el registro en la base de datos por RUT
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                Dim sql As String = "SELECT * FROM personas WHERE RUT = @rut"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@rut", rut)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Si se encuentra el registro, rellenar los campos
                            txtNombre.Text = reader("Nombre").ToString()
                            txtApellido.Text = reader("Apellido").ToString()
                            Dim sexo As String = reader("Sexo").ToString()

                            ' Seleccionar el radio button según el valor del sexo
                            Select Case sexo
                                Case "Masculino"
                                    rbtnMasculino.Checked = True
                                Case "Femenino"
                                    rbtnFemenino.Checked = True
                                Case "No especifica"
                                    rbtnNoEspecifica.Checked = True
                            End Select

                            cboComuna.SelectedItem = reader("Comuna").ToString()
                            txtCiudad.Text = reader("Ciudad").ToString()
                            txtObservacion.Text = reader("Observacion").ToString()

                            MessageBox.Show("Registro encontrado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            'Si no se encuentra el RUT, preguntar si desea agregarlo
                            MessageBox.Show("No se encontró ningún registro con el RUT. ¿Desea ingresar un nuevo usuario?.", "Usuario no encontrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                            ' Limpiar el formulario si no se encuentra el registro
                            LimpiarFormularios()

                            ' Habilitar todos los campos menos el de búsqueda
                            txtNombre.Enabled = True
                            txtApellido.Enabled = True
                            rbtnMasculino.Enabled = True
                            rbtnFemenino.Enabled = True
                            rbtnNoEspecifica.Enabled = True
                            cboComuna.Enabled = True
                            txtCiudad.Enabled = True
                            txtObservacion.Enabled = True

                            ' Habilitar el botón Guardar
                            btnGuardar.Enabled = True

                            ' Deshabilitar el botón de búsqueda
                            btnBuscar.Enabled = True
                            txtRut.Focus()
                        End If
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error al buscar el registro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        'Verficar que el RUT esté completo, ya que es el identificador unico
        If String.IsNullOrWhiteSpace(txtRut.Text) Then
            MessageBox.Show("Por favor, ingresar el RUT de la persona que desea actualizar.")
            Exit Sub
        End If

        'Capturar los datos del formulario
        Dim rut As String = txtRut.Text
        Dim nombre As String = txtNombre.Text
        Dim apellido As String = txtApellido.Text
        Dim sexo As String = If(rbtnMasculino.Checked, "Masculino", If(rbtnFemenino.Checked, "Femeino", "No especifica"))
        Dim comuna As String = cboComuna.SelectedItem.ToString()
        Dim ciudad As String = txtCiudad.Text
        Dim observacion As String = txtObservacion.Text

        'Consulta SQL para actualizar los datos en la tabla Personas
        Dim consulta As String = "UPDATE Personas SET Nombre = @nombre, Apellido = @apellido, Sexo = @sexo, Comuna = @comuna, Ciudad = @ciudad, Observacion = @observacion WHERE RUT = @rut"

        'Conexión a la base de datos y ejecución de la consulta
        Try
            Using conn As New MySqlConnection(connectionString)
                Using cmd As New MySqlCommand(consulta, conn)
                    'Añadir los parámetros
                    cmd.Parameters.AddWithValue("@rut", rut)
                    cmd.Parameters.AddWithValue("@nombre", nombre)
                    cmd.Parameters.AddWithValue("@apellido", apellido)
                    cmd.Parameters.AddWithValue("@sexo", sexo)
                    cmd.Parameters.AddWithValue("@comuna", comuna)
                    cmd.Parameters.AddWithValue("@ciudad", ciudad)
                    cmd.Parameters.AddWithValue("@observacion", observacion)

                    'Abrir conexión y ejecutar la consulta de actualización
                    conn.Open()
                    Dim filasActualizadas As Integer = cmd.ExecuteNonQuery()

                    'Verificar si se actualizó alguna fila
                    If filasActualizadas > 0 Then
                        MessageBox.Show("Datos actualizados correctamente.")
                    Else
                        MessageBox.Show("No se encontró ninguna persona con el RUT proporcionado.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al actualizar los datos: " & ex.Message)
        End Try

        'Codigo de actualizacion
        LimpiarFormulario()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim rut As String = txtRut.Text

        If String.IsNullOrWhiteSpace(rut) Then
            MessageBox.Show("Por favor, ingrese el RUT para eliminar un usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Confirmación antes de eliminar el registro
        Dim confirmResult As DialogResult = MessageBox.Show("¿Está seguro que desea eliminar el registro con RUT: " & rut & "?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If confirmResult = DialogResult.Yes Then
            Using conn As New MySqlConnection(connectionString)
                Try
                    conn.Open()

                    ' Consulta para eliminar el registro
                    Dim sql As String = "DELETE FROM personas WHERE RUT = @rut"

                    Using cmd As New MySqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@rut", rut)

                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            LimpiarFormulario() ' Limpiar el formulario después de eliminar
                        Else
                            MessageBox.Show("No se encontró ningún registro con el RUT ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using

                Catch ex As Exception
                    MessageBox.Show("Error al eliminar el registro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End If
    End Sub
    Private Sub btnVerDatos_Click(sender As Object, e As EventArgs) Handles btnVerDatos.Click
        'Consulta SQL para obtener los RUT, Nombre y Apellido de la tabla Personas
        Dim consulta As String = "SELECT RUT, Nombre, Apellido FROM Personas"

        'Conexión a la base de datos y ejecución de la consulta
        Try
            Using conn As New MySqlConnection(connectionString)
                Using cmd As New MySqlCommand(consulta, conn)
                    conn.Open()

                    Dim lector As MySqlDataReader = cmd.ExecuteReader()

                    'Verificar si hay registros
                    If lector.HasRows Then
                        Dim listaUsuarios As String = "Lista de usuarios: " & vbCrLf & vbCrLf

                        'Recorrer cada registro y agregarlo a la lista de usuarios
                        While lector.Read()
                            Dim rut As String = lector("RUT").ToString()
                            Dim nombre As String = lector("Nombre").ToString()
                            Dim apellido As String = lector("Apellido").ToString()

                            listaUsuarios &= "RUT: " & rut & " - Nombre: " & nombre & " " & apellido & vbCrLf
                        End While

                        'Mostrar la lista en un MessageBox
                        MessageBox.Show(listaUsuarios, "Usuarios Registrados")
                    Else
                        MessageBox.Show("No se encontraron usuarios.", "Usuarios")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener la lista de usuarios: " & ex.Message)
        End Try
    End Sub
End Class
