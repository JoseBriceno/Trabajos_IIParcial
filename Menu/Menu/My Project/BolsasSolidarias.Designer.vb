<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BolsasSolidarias
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
        Me.TxtNOMBRE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtIdentidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtIntegrantes = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboEstado = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.BTNIngresar = New System.Windows.Forms.Button()
        Me.BTNSalir = New System.Windows.Forms.Button()
        Me.BTNLimpiar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtNOMBRE
        '
        Me.TxtNOMBRE.Location = New System.Drawing.Point(152, 28)
        Me.TxtNOMBRE.Name = "TxtNOMBRE"
        Me.TxtNOMBRE.Size = New System.Drawing.Size(211, 20)
        Me.TxtNOMBRE.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NOMBRE COMPLETO"
        '
        'TxtIdentidad
        '
        Me.TxtIdentidad.Location = New System.Drawing.Point(152, 75)
        Me.TxtIdentidad.MaxLength = 13
        Me.TxtIdentidad.Name = "TxtIdentidad"
        Me.TxtIdentidad.Size = New System.Drawing.Size(211, 20)
        Me.TxtIdentidad.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "IDENTIDAD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(213, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "NUMERO INTEGRANTES EN LA FAMILIA"
        '
        'TxtIntegrantes
        '
        Me.TxtIntegrantes.Location = New System.Drawing.Point(303, 118)
        Me.TxtIntegrantes.Name = "TxtIntegrantes"
        Me.TxtIntegrantes.Size = New System.Drawing.Size(60, 20)
        Me.TxtIntegrantes.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ESTADO"
        '
        'ComboEstado
        '
        Me.ComboEstado.FormattingEnabled = True
        Me.ComboEstado.Items.AddRange(New Object() {"POBREZA", "POBREZA EXTREMA", "CLASE MEDIA", "PARTIDO NACIONAL"})
        Me.ComboEstado.Location = New System.Drawing.Point(152, 171)
        Me.ComboEstado.Name = "ComboEstado"
        Me.ComboEstado.Size = New System.Drawing.Size(121, 21)
        Me.ComboEstado.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "DIRECCION"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(152, 222)
        Me.TxtDireccion.Multiline = True
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(211, 64)
        Me.TxtDireccion.TabIndex = 9
        '
        'BTNIngresar
        '
        Me.BTNIngresar.Location = New System.Drawing.Point(96, 338)
        Me.BTNIngresar.Name = "BTNIngresar"
        Me.BTNIngresar.Size = New System.Drawing.Size(75, 20)
        Me.BTNIngresar.TabIndex = 10
        Me.BTNIngresar.Text = "INGRESAR"
        Me.BTNIngresar.UseVisualStyleBackColor = True
        '
        'BTNSalir
        '
        Me.BTNSalir.Location = New System.Drawing.Point(258, 338)
        Me.BTNSalir.Name = "BTNSalir"
        Me.BTNSalir.Size = New System.Drawing.Size(75, 20)
        Me.BTNSalir.TabIndex = 11
        Me.BTNSalir.Text = "SALIR"
        Me.BTNSalir.UseVisualStyleBackColor = True
        '
        'BTNLimpiar
        '
        Me.BTNLimpiar.Location = New System.Drawing.Point(177, 338)
        Me.BTNLimpiar.Name = "BTNLimpiar"
        Me.BTNLimpiar.Size = New System.Drawing.Size(75, 20)
        Me.BTNLimpiar.TabIndex = 12
        Me.BTNLimpiar.Text = "LIMPIAR"
        Me.BTNLimpiar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(369, 28)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(419, 330)
        Me.DataGridView1.TabIndex = 13
        '
        'BolsasSolidarias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BTNLimpiar)
        Me.Controls.Add(Me.BTNSalir)
        Me.Controls.Add(Me.BTNIngresar)
        Me.Controls.Add(Me.TxtDireccion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboEstado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtIntegrantes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtIdentidad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNOMBRE)
        Me.Name = "BolsasSolidarias"
        Me.Text = "BolsasSolidarias"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNOMBRE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtIdentidad As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtIntegrantes As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboEstado As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents BTNIngresar As Button
    Friend WithEvents BTNSalir As Button
    Friend WithEvents BTNLimpiar As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
