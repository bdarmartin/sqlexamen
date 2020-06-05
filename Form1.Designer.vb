<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxnombre = New System.Windows.Forms.TextBox()
        Me.TextBoxfechanac = New System.Windows.Forms.TextBox()
        Me.TextBoxcarnet = New System.Windows.Forms.TextBox()
        Me.TextBoxtel = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.RegistroAlumnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Examen_FinalDataSet = New WindowsApplication1.Examen_FinalDataSet()
        Me.Registro_AlumnosTableAdapter = New WindowsApplication1.Examen_FinalDataSetTableAdapters.Registro_AlumnosTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaNacimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarnetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegistroAlumnosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Examen_FinalDataSet1 = New WindowsApplication1.Examen_FinalDataSet1()
        Me.Registro_AlumnosTableAdapter1 = New WindowsApplication1.Examen_FinalDataSet1TableAdapters.Registro_AlumnosTableAdapter()
        CType(Me.RegistroAlumnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Examen_FinalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistroAlumnosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Examen_FinalDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha de Nacimiento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Carnet:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Telefono:"
        '
        'TextBoxnombre
        '
        Me.TextBoxnombre.Location = New System.Drawing.Point(224, 41)
        Me.TextBoxnombre.Name = "TextBoxnombre"
        Me.TextBoxnombre.Size = New System.Drawing.Size(137, 20)
        Me.TextBoxnombre.TabIndex = 4
        '
        'TextBoxfechanac
        '
        Me.TextBoxfechanac.Location = New System.Drawing.Point(224, 83)
        Me.TextBoxfechanac.Name = "TextBoxfechanac"
        Me.TextBoxfechanac.Size = New System.Drawing.Size(137, 20)
        Me.TextBoxfechanac.TabIndex = 5
        '
        'TextBoxcarnet
        '
        Me.TextBoxcarnet.Location = New System.Drawing.Point(224, 124)
        Me.TextBoxcarnet.Name = "TextBoxcarnet"
        Me.TextBoxcarnet.Size = New System.Drawing.Size(137, 20)
        Me.TextBoxcarnet.TabIndex = 6
        '
        'TextBoxtel
        '
        Me.TextBoxtel.Location = New System.Drawing.Point(224, 164)
        Me.TextBoxtel.Name = "TextBoxtel"
        Me.TextBoxtel.Size = New System.Drawing.Size(137, 20)
        Me.TextBoxtel.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(32, 246)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(160, 246)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Quitar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(286, 246)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Modificar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'RegistroAlumnosBindingSource
        '
        Me.RegistroAlumnosBindingSource.DataMember = "Registro Alumnos"
        Me.RegistroAlumnosBindingSource.DataSource = Me.Examen_FinalDataSet
        '
        'Examen_FinalDataSet
        '
        Me.Examen_FinalDataSet.DataSetName = "Examen_FinalDataSet"
        Me.Examen_FinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Registro_AlumnosTableAdapter
        '
        Me.Registro_AlumnosTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreDataGridViewTextBoxColumn, Me.FechaNacimientoDataGridViewTextBoxColumn, Me.CarnetDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RegistroAlumnosBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 323)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(446, 170)
        Me.DataGridView1.TabIndex = 11
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'FechaNacimientoDataGridViewTextBoxColumn
        '
        Me.FechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "Fecha Nacimiento"
        Me.FechaNacimientoDataGridViewTextBoxColumn.HeaderText = "Fecha Nacimiento"
        Me.FechaNacimientoDataGridViewTextBoxColumn.Name = "FechaNacimientoDataGridViewTextBoxColumn"
        '
        'CarnetDataGridViewTextBoxColumn
        '
        Me.CarnetDataGridViewTextBoxColumn.DataPropertyName = "Carnet"
        Me.CarnetDataGridViewTextBoxColumn.HeaderText = "Carnet"
        Me.CarnetDataGridViewTextBoxColumn.Name = "CarnetDataGridViewTextBoxColumn"
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        '
        'RegistroAlumnosBindingSource1
        '
        Me.RegistroAlumnosBindingSource1.DataMember = "Registro Alumnos"
        Me.RegistroAlumnosBindingSource1.DataSource = Me.Examen_FinalDataSet1
        '
        'Examen_FinalDataSet1
        '
        Me.Examen_FinalDataSet1.DataSetName = "Examen_FinalDataSet1"
        Me.Examen_FinalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Registro_AlumnosTableAdapter1
        '
        Me.Registro_AlumnosTableAdapter1.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 505)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxtel)
        Me.Controls.Add(Me.TextBoxcarnet)
        Me.Controls.Add(Me.TextBoxfechanac)
        Me.Controls.Add(Me.TextBoxnombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = " CONTROL ESTUDIANTES"
        CType(Me.RegistroAlumnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Examen_FinalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistroAlumnosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Examen_FinalDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxnombre As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxfechanac As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxcarnet As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxtel As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Examen_FinalDataSet As WindowsApplication1.Examen_FinalDataSet
    Friend WithEvents RegistroAlumnosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Registro_AlumnosTableAdapter As WindowsApplication1.Examen_FinalDataSetTableAdapters.Registro_AlumnosTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Examen_FinalDataSet1 As WindowsApplication1.Examen_FinalDataSet1
    Friend WithEvents RegistroAlumnosBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Registro_AlumnosTableAdapter1 As WindowsApplication1.Examen_FinalDataSet1TableAdapters.Registro_AlumnosTableAdapter
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaNacimientoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CarnetDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
