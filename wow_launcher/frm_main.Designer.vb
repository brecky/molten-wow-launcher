Imports System.Net
Imports System.Net.NetworkInformation

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
    Inherits System.Windows.Forms.Form

    'variables para hacer ping'
    Dim i As Integer
    Dim eco As New System.Net.NetworkInformation.Ping
    Dim res As System.Net.NetworkInformation.PingReply
    Dim ip As IPAddress


    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HTCAPTION As Integer = &H2
    Declare Function ReleaseCapture Lib "user32.dll" () As Int32
    Declare Function SendMessage Lib "user32.dll" Alias "SendMessageA" (ByVal hwnd As IntPtr, ByVal wMsg As Int32, ByVal wParam As Int32, ByVal lParam As Int32) As Int32

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_main))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"algo", "otra cosa", "donde esya", "estado"}, -1)
        Me.notifymenu = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.list_servers = New System.Windows.Forms.ListView()
        Me.clm_server = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clm_location = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clm_realmlist = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clm_status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_server_remove = New System.Windows.Forms.Button()
        Me.btn_server_add = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'notifymenu
        '
        Me.notifymenu.ContextMenuStrip = Me.ContextMenuStrip1
        Me.notifymenu.Icon = CType(resources.GetObject("notifymenu.Icon"), System.Drawing.Icon)
        Me.notifymenu.Text = "Molten Wow Game Launcher"
        Me.notifymenu.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowToolStripMenuItem, Me.HideToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(104, 76)
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ShowToolStripMenuItem.Text = "Show"
        Me.ShowToolStripMenuItem.Visible = False
        '
        'HideToolStripMenuItem
        '
        Me.HideToolStripMenuItem.Name = "HideToolStripMenuItem"
        Me.HideToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.HideToolStripMenuItem.Text = "Hide"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(100, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(761, 405)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label1.Location = New System.Drawing.Point(74, 381)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Game Dir: (No dir selected)"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label2.Location = New System.Drawing.Point(357, 381)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Language: (English-Great Britain)"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label3.Location = New System.Drawing.Point(554, 381)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Latency:  0000ms"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'list_servers
        '
        Me.list_servers.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.list_servers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.list_servers.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.list_servers.BackgroundImageTiled = True
        Me.list_servers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clm_server, Me.clm_location, Me.clm_realmlist, Me.clm_status})
        Me.list_servers.ForeColor = System.Drawing.SystemColors.InfoText
        Me.list_servers.FullRowSelect = True
        Me.list_servers.GridLines = True
        Me.list_servers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.list_servers.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.list_servers.LabelWrap = False
        Me.list_servers.Location = New System.Drawing.Point(77, 131)
        Me.list_servers.MultiSelect = False
        Me.list_servers.Name = "list_servers"
        Me.list_servers.ShowItemToolTips = True
        Me.list_servers.Size = New System.Drawing.Size(605, 142)
        Me.list_servers.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.list_servers.TabIndex = 6
        Me.list_servers.UseCompatibleStateImageBehavior = False
        Me.list_servers.View = System.Windows.Forms.View.Details
        '
        'clm_server
        '
        Me.clm_server.Text = "Server"
        Me.clm_server.Width = 151
        '
        'clm_location
        '
        Me.clm_location.Text = "Location"
        Me.clm_location.Width = 147
        '
        'clm_realmlist
        '
        Me.clm_realmlist.Text = "Realmlist"
        Me.clm_realmlist.Width = 197
        '
        'clm_status
        '
        Me.clm_status.Text = "Status"
        Me.clm_status.Width = 104
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(75, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(234, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Chose the server from the list and clic connect..."
        '
        'Button4
        '
        Me.Button4.AutoSize = True
        Me.Button4.BackColor = System.Drawing.Color.Black
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Enabled = False
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = Global.wow_launcher.My.Resources.Resources.remove
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button4.Location = New System.Drawing.Point(169, 311)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(107, 27)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Remove server"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.AutoSize = True
        Me.Button5.BackColor = System.Drawing.Color.Black
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Image = Global.wow_launcher.My.Resources.Resources.options1
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button5.Location = New System.Drawing.Point(77, 311)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(86, 27)
        Me.Button5.TabIndex = 13
        Me.Button5.Text = "Add server"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.BackColor = System.Drawing.Color.Black
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = Global.wow_launcher.My.Resources.Resources._Select
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button3.Location = New System.Drawing.Point(484, 278)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 27)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Select server"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.wow_launcher.My.Resources.Resources.icon_neutral
        Me.Button1.Location = New System.Drawing.Point(484, 311)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button1.Size = New System.Drawing.Size(195, 67)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Play World of Warcraft"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.wow_launcher.My.Resources.Resources.gtk_clear
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button2.Location = New System.Drawing.Point(587, 278)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 27)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Clear Cache"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btn_server_remove
        '
        Me.btn_server_remove.AutoSize = True
        Me.btn_server_remove.BackColor = System.Drawing.Color.Black
        Me.btn_server_remove.BackgroundImage = CType(resources.GetObject("btn_server_remove.BackgroundImage"), System.Drawing.Image)
        Me.btn_server_remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_server_remove.Enabled = False
        Me.btn_server_remove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btn_server_remove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btn_server_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_server_remove.ForeColor = System.Drawing.Color.White
        Me.btn_server_remove.Image = Global.wow_launcher.My.Resources.Resources.remove
        Me.btn_server_remove.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_server_remove.Location = New System.Drawing.Point(169, 278)
        Me.btn_server_remove.Name = "btn_server_remove"
        Me.btn_server_remove.Size = New System.Drawing.Size(107, 27)
        Me.btn_server_remove.TabIndex = 9
        Me.btn_server_remove.Text = "Remove server"
        Me.btn_server_remove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_server_remove.UseVisualStyleBackColor = False
        '
        'btn_server_add
        '
        Me.btn_server_add.AutoSize = True
        Me.btn_server_add.BackColor = System.Drawing.Color.Black
        Me.btn_server_add.BackgroundImage = CType(resources.GetObject("btn_server_add.BackgroundImage"), System.Drawing.Image)
        Me.btn_server_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_server_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btn_server_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btn_server_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_server_add.ForeColor = System.Drawing.Color.White
        Me.btn_server_add.Image = Global.wow_launcher.My.Resources.Resources.add_content
        Me.btn_server_add.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_server_add.Location = New System.Drawing.Point(77, 278)
        Me.btn_server_add.Name = "btn_server_add"
        Me.btn_server_add.Size = New System.Drawing.Size(86, 27)
        Me.btn_server_add.TabIndex = 8
        Me.btn_server_add.Text = "Add server"
        Me.btn_server_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_server_add.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.wow_launcher.My.Resources.Resources.close_02
        Me.PictureBox2.Location = New System.Drawing.Point(652, 39)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(27, 19)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.wow_launcher.My.Resources.Resources.nav_main_top1
        Me.PictureBox1.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(759, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.Black
        Me.RectangleShape1.BackgroundImage = Global.wow_launcher.My.Resources.Resources.bg
        Me.RectangleShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RectangleShape1.BorderColor = System.Drawing.Color.Black
        Me.RectangleShape1.CornerRadius = 15
        Me.RectangleShape1.Location = New System.Drawing.Point(64, 95)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(629, 303)
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SaddleBrown
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(761, 405)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_server_remove)
        Me.Controls.Add(Me.btn_server_add)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.list_servers)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_main"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.SaddleBrown
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents notifymenu As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem


    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Friend WithEvents ShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator

    Private Sub ShowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolStripMenuItem.Click
        Me.Show()
        ShowToolStripMenuItem.Visible = False
        HideToolStripMenuItem.Visible = True
    End Sub

    Private Sub HideToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HideToolStripMenuItem.Click
        Me.Hide()
        ShowToolStripMenuItem.Visible = True
        HideToolStripMenuItem.Visible = False
    End Sub

    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.Image = wow_launcher.My.Resources.Resources.close_01
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Image = wow_launcher.My.Resources.Resources.close_02
    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        res = eco.Send("logon.molten-wow.com")
        Label3.Text = "Latency: " & res.RoundtripTime & "ms"
    End Sub
    Friend WithEvents list_servers As System.Windows.Forms.ListView
    Friend WithEvents clm_server As System.Windows.Forms.ColumnHeader
    Friend WithEvents clm_location As System.Windows.Forms.ColumnHeader
    Friend WithEvents clm_realmlist As System.Windows.Forms.ColumnHeader
    Friend WithEvents clm_status As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_server_add As System.Windows.Forms.Button
    Friend WithEvents btn_server_remove As System.Windows.Forms.Button

    Private Sub list_servers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles list_servers.SelectedIndexChanged
        If list_servers.SelectedItems.Count = 0 Then
            btn_server_remove.Enabled = False
        Else
            btn_server_remove.Enabled = True
        End If
    End Sub

    Private Sub frm_main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
