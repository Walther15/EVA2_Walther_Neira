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
                            MessageBox.Show("No se encontró ningún registro con el RUT ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                            ' Limpiar el formulario si no se encuentra el registro
                            LimpiarFormulario()

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
                        End If
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error al buscar el registro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

End Class
