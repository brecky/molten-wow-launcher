﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.txt_gamedir = New System.Windows.Forms.TextBox()
        Me.btn_seldir = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbx_gamelang = New System.Windows.Forms.ComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbx_gllang = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbx_playwow = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.btn_cancel.Location = New System.Drawing.Point(243, 188)
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
        Me.btn_acept.Image = Global.wow_launcher.My.Resources.Resources.selicon
        Me.btn_acept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_acept.Location = New System.Drawing.Point(163, 188)
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
        Me.btn_apply.Location = New System.Drawing.Point(57, 188)
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
        Me.PictureBox1.Location = New System.Drawing.Point(-7, 187)
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
        'txt_gamedir
        '
        Me.txt_gamedir.Location = New System.Drawing.Point(67, 21)
        Me.txt_gamedir.Name = "txt_gamedir"
        Me.txt_gamedir.ReadOnly = True
        Me.txt_gamedir.Size = New System.Drawing.Size(163, 20)
        Me.txt_gamedir.TabIndex = 16
        Me.txt_gamedir.TabStop = False
        '
        'btn_seldir
        '
        Me.btn_seldir.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_seldir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_seldir.ForeColor = System.Drawing.Color.White
        Me.btn_seldir.Image = Global.wow_launcher.My.Resources.Resources.search
        Me.btn_seldir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_seldir.Location = New System.Drawing.Point(236, 21)
        Me.btn_seldir.Name = "btn_seldir"
        Me.btn_seldir.Size = New System.Drawing.Size(81, 21)
        Me.btn_seldir.TabIndex = 17
        Me.btn_seldir.Text = "Select Dir."
        Me.btn_seldir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_seldir.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(7, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Game Client Language:"
        '
        'cbx_gamelang
        '
        Me.cbx_gamelang.BackColor = System.Drawing.Color.Black
        Me.cbx_gamelang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_gamelang.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbx_gamelang.ForeColor = System.Drawing.Color.White
        Me.cbx_gamelang.FormattingEnabled = True
        Me.cbx_gamelang.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbx_gamelang.IntegralHeight = False
        Me.cbx_gamelang.Items.AddRange(New Object() {"English (United States)", "English (Great Britain)", "German", "French", "Spanish (Spain)", "Spanish (Mexico)", "Russian"})
        Me.cbx_gamelang.Location = New System.Drawing.Point(144, 47)
        Me.cbx_gamelang.Name = "cbx_gamelang"
        Me.cbx_gamelang.Size = New System.Drawing.Size(172, 21)
        Me.cbx_gamelang.TabIndex = 19
        Me.cbx_gamelang.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label6
        '
        Me.Label6.AutoEllipsis = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.ForeColor = System.Drawing.Color.Snow
        Me.Label6.Location = New System.Drawing.Point(7, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(310, 53)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = resources.GetString("Label6.Text")
        '
        'cbx_gllang
        '
        Me.cbx_gllang.BackColor = System.Drawing.Color.Black
        Me.cbx_gllang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_gllang.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbx_gllang.ForeColor = System.Drawing.Color.White
        Me.cbx_gllang.FormattingEnabled = True
        Me.cbx_gllang.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbx_gllang.IntegralHeight = False
        Me.cbx_gllang.Items.AddRange(New Object() {"English", "Español"})
        Me.cbx_gllang.Location = New System.Drawing.Point(144, 74)
        Me.cbx_gllang.Name = "cbx_gllang"
        Me.cbx_gllang.Size = New System.Drawing.Size(172, 21)
        Me.cbx_gllang.TabIndex = 22
        Me.cbx_gllang.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(6, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Game launcher Language:"
        '
        'cbx_playwow
        '
        Me.cbx_playwow.BackColor = System.Drawing.Color.Black
        Me.cbx_playwow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_playwow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbx_playwow.ForeColor = System.Drawing.Color.White
        Me.cbx_playwow.FormattingEnabled = True
        Me.cbx_playwow.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbx_playwow.IntegralHeight = False
        Me.cbx_playwow.Items.AddRange(New Object() {"Hide Game launcher", "Close Game launcher", "Do Nothing"})
        Me.cbx_playwow.Location = New System.Drawing.Point(144, 101)
        Me.cbx_playwow.Name = "cbx_playwow"
        Me.cbx_playwow.Size = New System.Drawing.Size(172, 21)
        Me.cbx_playwow.TabIndex = 24
        Me.cbx_playwow.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(7, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "When play world of warcraft"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(114, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "msg sel Game Dir"
        Me.Label5.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(210, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "msg Game Dir"
        Me.Label7.Visible = False
        '
        'frm_options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.wow_launcher.My.Resources.Resources.hunterbeastmastery
        Me.ClientSize = New System.Drawing.Size(324, 219)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbx_playwow)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbx_gllang)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbx_gamelang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_seldir)
        Me.Controls.Add(Me.txt_gamedir)
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
    Friend WithEvents txt_gamedir As System.Windows.Forms.TextBox
    Friend WithEvents btn_seldir As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbx_gamelang As System.Windows.Forms.ComboBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbx_gllang As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbx_playwow As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
