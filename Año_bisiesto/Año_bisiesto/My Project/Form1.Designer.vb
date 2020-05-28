<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAño
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblUseryear = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.lblGracias = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblMaria = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(252, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenido "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(350, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 20)
        Me.Label2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(159, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(281, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "¿Quieres saber que año es bisiesto?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ink Free", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(192, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 14)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ingresa el año aqui:"
        '
        'txtAño
        '
        Me.txtAño.Location = New System.Drawing.Point(319, 137)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(100, 20)
        Me.txtAño.TabIndex = 4
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(249, 182)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(101, 27)
        Me.btnAceptar.TabIndex = 5
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lblUseryear
        '
        Me.lblUseryear.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.lblUseryear.AutoEllipsis = True
        Me.lblUseryear.AutoSize = True
        Me.lblUseryear.Font = New System.Drawing.Font("Ink Free", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUseryear.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblUseryear.Location = New System.Drawing.Point(205, 245)
        Me.lblUseryear.Name = "lblUseryear"
        Me.lblUseryear.Size = New System.Drawing.Size(188, 20)
        Me.lblUseryear.TabIndex = 7
        Me.lblUseryear.Text = "El año 2000 es bisiesto"
        Me.lblUseryear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(510, 379)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(89, 27)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnInicio
        '
        Me.btnInicio.Location = New System.Drawing.Point(12, 381)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(89, 25)
        Me.btnInicio.TabIndex = 10
        Me.btnInicio.Text = "volver al inicio"
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'lblGracias
        '
        Me.lblGracias.AutoSize = True
        Me.lblGracias.Font = New System.Drawing.Font("Ink Free", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGracias.Location = New System.Drawing.Point(204, 277)
        Me.lblGracias.Name = "lblGracias"
        Me.lblGracias.Size = New System.Drawing.Size(190, 15)
        Me.lblGracias.TabIndex = 11
        Me.lblGracias.Text = "¡Gracias por usar mi programa!"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Ink Free", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Purple
        Me.lblName.Location = New System.Drawing.Point(227, 308)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(144, 15)
        Me.lblName.TabIndex = 12
        Me.lblName.Text = "Mi nombre es Leonardo"
        '
        'lblMaria
        '
        Me.lblMaria.AutoSize = True
        Me.lblMaria.Font = New System.Drawing.Font("Ink Free", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaria.Location = New System.Drawing.Point(91, 344)
        Me.lblMaria.Name = "lblMaria"
        Me.lblMaria.Size = New System.Drawing.Size(416, 15)
        Me.lblMaria.TabIndex = 13
        Me.lblMaria.Text = "Soy alumno de 3ro EMT de la Escuela Tecnica Maria Espinola Espinola"
        '
        'frmAño
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 418)
        Me.Controls.Add(Me.lblMaria)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblGracias)
        Me.Controls.Add(Me.btnInicio)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblUseryear)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtAño)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(627, 457)
        Me.MinimumSize = New System.Drawing.Size(627, 457)
        Me.Name = "frmAño"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Año Bisiesto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAño As TextBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents lblUseryear As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnInicio As Button
    Friend WithEvents lblGracias As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblMaria As Label
End Class
