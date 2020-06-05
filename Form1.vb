Public Class Form1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Examen_FinalDataSet1.Registro_Alumnos' table. You can move, or remove it, as needed.
        Me.Registro_AlumnosTableAdapter1.Fill(Me.Examen_FinalDataSet1.Registro_Alumnos)
        'TODO: This line of code loads data into the 'Examen_FinalDataSet.Registro_Alumnos' table. You can move, or remove it, as needed.
        Me.Registro_AlumnosTableAdapter.Fill(Me.Examen_FinalDataSet.Registro_Alumnos)

    End Sub
    'Aqui lo que hacemos es programar el boton que nos va a permitir agregar un nuevo alumno a la tabla
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Registro_AlumnosTableAdapter.Insert(TextBoxnombre.Text, TextBoxfechanac.Text, TextBoxcarnet.Text, TextBoxtel.Text)
        Me.Registro_AlumnosTableAdapter.Fill(Me.Examen_FinalDataSet.Registro_Alumnos)


    End Sub
    'Aqui lo que hacemos es programar el boton que nos va a permitir modificar un nuevo alumno a la tabla
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Registro_AlumnosTableAdapter.(TextBoxnombre.Text, TextBoxfechanac.Text, TextBoxcarnet.Text, TextBoxtel.Text)
        Me.Registro_AlumnosTableAdapter.Fill(Me.Examen_FinalDataSet.Registro_Alumnos)

    End Sub
    'Aqui lo que hacemos es programar el boton que nos va a permitir eliminar un nuevo alumno a la tabla
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Registro_AlumnosTableAdapter.(TextBoxnombre.Text, TextBoxfechanac.Text, TextBoxcarnet.Text)
        Me.Registro_AlumnosTableAdapter.Fill(Me.Examen_FinalDataSet.Registro_Alumnos)
    End Sub
End Class
