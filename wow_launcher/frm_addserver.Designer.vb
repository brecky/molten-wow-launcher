<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_addserver
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_addserver))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbx_region = New System.Windows.Forms.ComboBox()
        Me.txt_server = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_realm = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_addserver = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(12, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Server Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.ForeColor = System.Drawing.Color.Snow
        Me.Label2.Location = New System.Drawing.Point(155, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Server Region"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.ForeColor = System.Drawing.Color.Snow
        Me.Label3.Location = New System.Drawing.Point(12, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Server Realmlist"
        '
        'cbx_region
        '
        Me.cbx_region.BackColor = System.Drawing.Color.Black
        Me.cbx_region.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_region.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbx_region.ForeColor = System.Drawing.Color.White
        Me.cbx_region.FormattingEnabled = True
        Me.cbx_region.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbx_region.IntegralHeight = False
        Me.cbx_region.Items.AddRange(New Object() {"Development", "Europe", "Latin America", "Oceanic", "Russian", "Spanish", "Taiwan", "United States"})
        Me.cbx_region.Location = New System.Drawing.Point(158, 22)
        Me.cbx_region.Name = "cbx_region"
        Me.cbx_region.Size = New System.Drawing.Size(106, 21)
        Me.cbx_region.TabIndex = 3
        Me.cbx_region.TabStop = False
        '
        'txt_server
        '
        Me.txt_server.BackColor = System.Drawing.SystemColors.WindowText
        Me.txt_server.ForeColor = System.Drawing.Color.White
        Me.txt_server.Location = New System.Drawing.Point(15, 23)
        Me.txt_server.Name = "txt_server"
        Me.txt_server.Size = New System.Drawing.Size(127, 20)
        Me.txt_server.TabIndex = 4
        Me.txt_server.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.ForeColor = System.Drawing.Color.Snow
        Me.Label4.Location = New System.Drawing.Point(12, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "set realmlist:"
        '
        'txt_realm
        '
        Me.txt_realm.BackColor = System.Drawing.Color.Black
        Me.txt_realm.ForeColor = System.Drawing.Color.White
        Me.txt_realm.Location = New System.Drawing.Point(82, 81)
        Me.txt_realm.Name = "txt_realm"
        Me.txt_realm.Size = New System.Drawing.Size(182, 20)
        Me.txt_realm.TabIndex = 6
        Me.txt_realm.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.ForeColor = System.Drawing.Color.Snow
        Me.Label5.Location = New System.Drawing.Point(95, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "(Example: logon.molten-wow.com)"
        '
        'Label6
        '
        Me.Label6.AutoEllipsis = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.ForeColor = System.Drawing.Color.Snow
        Me.Label6.Location = New System.Drawing.Point(12, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(252, 53)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Note: Write only the url in Server Realmlist. You need exclude the ""Set Realmlist" & _
            """. If you write ""Set Realmlist"" in Server realm the launcher can't connect to se" & _
            "rver."
        '
        'btn_addserver
        '
        Me.btn_addserver.BackColor = System.Drawing.Color.Black
        Me.btn_addserver.Enabled = False
        Me.btn_addserver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addserver.ForeColor = System.Drawing.Color.White
        Me.btn_addserver.Image = Global.wow_launcher.My.Resources.Resources.add_content
        Me.btn_addserver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_addserver.Location = New System.Drawing.Point(15, 172)
        Me.btn_addserver.Name = "btn_addserver"
        Me.btn_addserver.Size = New System.Drawing.Size(117, 32)
        Me.btn_addserver.TabIndex = 9
        Me.btn_addserver.TabStop = False
        Me.btn_addserver.Text = "Add Server to list"
        Me.btn_addserver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_addserver.UseVisualStyleBackColor = False
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.Black
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_cancel.Image = Global.wow_launcher.My.Resources.Resources.remove
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancel.Location = New System.Drawing.Point(187, 172)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(77, 32)
        Me.btn_cancel.TabIndex = 10
        Me.btn_cancel.TabStop = False
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'frm_addserver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.wow_launcher.My.Resources.Resources.hunterbeastmastery
        Me.ClientSize = New System.Drawing.Size(274, 207)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_addserver)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_realm)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_server)
        Me.Controls.Add(Me.cbx_region)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_addserver"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Server"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbx_region As System.Windows.Forms.ComboBox
    Friend WithEvents txt_server As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_realm As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_addserver As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
