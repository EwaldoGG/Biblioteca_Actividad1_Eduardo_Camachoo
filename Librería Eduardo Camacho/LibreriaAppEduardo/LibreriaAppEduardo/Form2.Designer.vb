<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        btnCerrar = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.Font = New Font("Tempus Sans ITC", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(210, 130)
        Label1.Name = "Label1"
        Label1.Size = New Size(352, 47)
        Label1.TabIndex = 0
        Label1.Text = "¡Gracias por Visitarnos!"
        ' 
        ' btnCerrar
        ' 
        btnCerrar.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        btnCerrar.Font = New Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCerrar.Location = New Point(307, 233)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(154, 54)
        btnCerrar.TabIndex = 1
        btnCerrar.Text = "Volver"
        btnCerrar.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._475523955ce4ccc10029e9955420dd40
        PictureBox1.Location = New Point(565, 267)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(197, 171)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(btnCerrar)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
