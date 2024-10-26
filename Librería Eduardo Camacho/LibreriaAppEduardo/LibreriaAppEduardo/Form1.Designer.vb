<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        btnVerificar = New Button()
        btnDevolver = New Button()
        TextBox1 = New TextBox()
        lblEstado = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' btnVerificar
        ' 
        btnVerificar.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        btnVerificar.Font = New Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnVerificar.Location = New Point(120, 253)
        btnVerificar.Name = "btnVerificar"
        btnVerificar.Size = New Size(133, 49)
        btnVerificar.TabIndex = 0
        btnVerificar.Text = "Verificar"
        btnVerificar.UseVisualStyleBackColor = False
        ' 
        ' btnDevolver
        ' 
        btnDevolver.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        btnDevolver.Font = New Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDevolver.Location = New Point(503, 253)
        btnDevolver.Name = "btnDevolver"
        btnDevolver.Size = New Size(146, 51)
        btnDevolver.TabIndex = 1
        btnDevolver.Text = "Devolver"
        btnDevolver.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Tempus Sans ITC", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(244, 112)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(307, 43)
        TextBox1.TabIndex = 2
        TextBox1.Text = "Ingresa el Libro que deseas"
        ' 
        ' lblEstado
        ' 
        lblEstado.AutoSize = True
        lblEstado.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEstado.Location = New Point(284, 347)
        lblEstado.Name = "lblEstado"
        lblEstado.Size = New Size(200, 33)
        lblEstado.TabIndex = 3
        lblEstado.Text = "Estado del Libro"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(79, 195)
        Label2.Name = "Label2"
        Label2.Size = New Size(213, 34)
        Label2.TabIndex = 4
        Label2.Text = "Está Disponible?"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(474, 195)
        Label1.Name = "Label1"
        Label1.Size = New Size(224, 34)
        Label1.TabIndex = 5
        Label1.Text = "Devolver el Libro"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BorderStyle = BorderStyle.Fixed3D
        Label3.Font = New Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(217, 46)
        Label3.Name = "Label3"
        Label3.Size = New Size(367, 45)
        Label3.TabIndex = 6
        Label3.Text = "Biblioteca Virtual"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(lblEstado)
        Controls.Add(TextBox1)
        Controls.Add(btnDevolver)
        Controls.Add(btnVerificar)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnVerificar As Button
    Friend WithEvents btnDevolver As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblEstado As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label

End Class
