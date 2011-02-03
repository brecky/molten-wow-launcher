<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_options
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_options))
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_acept = New System.Windows.Forms.Button()
        Me.btn_apply = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.Black
        Me.btn_cancel.BackgroundImage = Global.wow_launcher.My.Resources.Resources.molt_btn_bgrond
        Me.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_cancel.FlatAppearance.BorderSize = 2
        Me.btn_cancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.btn_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_cancel.Image = Global.wow_launcher.My.Resources.Resources.remove
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancel.Location = New System.Drawing.Point(306, 133)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(77, 28)
        Me.btn_cancel.TabIndex = 12
        Me.btn_cancel.TabStop = False
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btn_acept
        '
        Me.btn_acept.BackColor = System.Drawing.Color.Black
        Me.btn_acept.BackgroundImage = Global.wow_launcher.My.Resources.Resources.molt_btn_bgrond
        Me.btn_acept.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_acept.FlatAppearance.BorderSize = 2
        Me.btn_acept.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.btn_acept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btn_acept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_acept.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_acept.ForeColor = System.Drawing.Color.White
        Me.btn_acept.Image = Global.wow_launcher.My.Resources.Resources._Select
        Me.btn_acept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_acept.Location = New System.Drawing.Point(226, 133)
        Me.btn_acept.Name = "btn_acept"
        Me.btn_acept.Size = New System.Drawing.Size(77, 28)
        Me.btn_acept.TabIndex = 11
        Me.btn_acept.TabStop = False
        Me.btn_acept.Text = "Accept"
        Me.btn_acept.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_acept.UseVisualStyleBackColor = False
        '
        'btn_apply
        '
        Me.btn_apply.BackColor = System.Drawing.Color.Black
        Me.btn_apply.BackgroundImage = Global.wow_launcher.My.Resources.Resources.molt_btn_bgrond
        Me.btn_apply.Enabled = False
        Me.btn_apply.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_apply.FlatAppearance.BorderSize = 2
        Me.btn_apply.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.btn_apply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btn_apply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_apply.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_apply.ForeColor = System.Drawing.Color.White
        Me.btn_apply.Image = Global.wow_launcher.My.Resources.Resources.add_content
        Me.btn_apply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_apply.Location = New System.Drawing.Point(120, 133)
        Me.btn_apply.Name = "btn_apply"
        Me.btn_apply.Size = New System.Drawing.Size(104, 28)
        Me.btn_apply.TabIndex = 13
        Me.btn_apply.TabStop = False
        Me.btn_apply.Text = "Apply Changes"
        Me.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_apply.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.wow_launcher.My.Resources.Resources.molt_btn_bgrond
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(-7, 132)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(408, 53)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Game Dir:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(62, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(238, 20)
        Me.TextBox1.TabIndex = 16
        Me.TextBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.wow_launcher.My.Resources.Resources.search
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(302, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 21)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Select Dir."
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frm_options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.wow_launcher.My.Resources.Resources.hunterbeastmastery
        Me.ClientSize = New System.Drawing.Size(393, 165)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_apply)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_acept)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_options"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game Launcher Options"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_acept As System.Windows.Forms.Button
    Friend WithEvents btn_apply As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
