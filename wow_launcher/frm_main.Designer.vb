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
    Dim selser As String

    Dim listaindice As Integer, gamedir As String, gamelang As String, langdir As String

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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Molten-Wow", "United States", "logon.molten-wow.com", "Selected"}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Retail Wow [US]", "United States", "us.logon.worldofwarcraft.com", "No Selected"}, -1)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Retail Wow [EU]", "Europe", "eu.logon.worldofwarcraft.com", "No Selected"}, -1)
        Me.notifymenu = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.lbl_wowdir = New System.Windows.Forms.Label()
        Me.lbl_lang = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.list_servers = New System.Windows.Forms.ListView()
        Me.clm_server = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clm_location = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clm_realmlist = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clm_status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_options = New System.Windows.Forms.Button()
        Me.btn_selserver = New System.Windows.Forms.Button()
        Me.btn_playwow = New System.Windows.Forms.Button()
        Me.btn_clearcache = New System.Windows.Forms.Button()
        Me.btn_server_remove = New System.Windows.Forms.Button()
        Me.btn_server_add = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
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
        'lbl_wowdir
        '
        Me.lbl_wowdir.BackColor = System.Drawing.Color.Black
        Me.lbl_wowdir.ForeColor = System.Drawing.Color.White
        Me.lbl_wowdir.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lbl_wowdir.Location = New System.Drawing.Point(74, 381)
        Me.lbl_wowdir.Name = "lbl_wowdir"
        Me.lbl_wowdir.Size = New System.Drawing.Size(283, 16)
        Me.lbl_wowdir.TabIndex = 3
        Me.lbl_wowdir.Text = "Game Dir: (No dir selected)"
        '
        'lbl_lang
        '
        Me.lbl_lang.BackColor = System.Drawing.Color.Black
        Me.lbl_lang.ForeColor = System.Drawing.Color.White
        Me.lbl_lang.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lbl_lang.Location = New System.Drawing.Point(357, 381)
        Me.lbl_lang.Name = "lbl_lang"
        Me.lbl_lang.Size = New System.Drawing.Size(201, 16)
        Me.lbl_lang.TabIndex = 4
        Me.lbl_lang.Text = "Language: (English-Great Britain)"
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
        Me.list_servers.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3})
        Me.list_servers.LabelWrap = False
        Me.list_servers.Location = New System.Drawing.Point(77, 123)
        Me.list_servers.MultiSelect = False
        Me.list_servers.Name = "list_servers"
        Me.list_servers.ShowItemToolTips = True
        Me.list_servers.Size = New System.Drawing.Size(605, 150)
        Me.list_servers.TabIndex = 6
        Me.list_servers.TabStop = False
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
        'btn_options
        '
        Me.btn_options.AutoSize = True
        Me.btn_options.BackColor = System.Drawing.Color.Black
        Me.btn_options.BackgroundImage = CType(resources.GetObject("btn_options.BackgroundImage"), System.Drawing.Image)
        Me.btn_options.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_options.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btn_options.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btn_options.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_options.ForeColor = System.Drawing.Color.White
        Me.btn_options.Image = Global.wow_launcher.My.Resources.Resources.options1
        Me.btn_options.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_options.Location = New System.Drawing.Point(78, 346)
        Me.btn_options.Name = "btn_options"
        Me.btn_options.Size = New System.Drawing.Size(85, 27)
        Me.btn_options.TabIndex = 13
        Me.btn_options.TabStop = False
        Me.btn_options.Text = "Options"
        Me.btn_options.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_options.UseVisualStyleBackColor = False
        '
        'btn_selserver
        '
        Me.btn_selserver.AutoSize = True
        Me.btn_selserver.BackColor = System.Drawing.Color.Black
        Me.btn_selserver.BackgroundImage = CType(resources.GetObject("btn_selserver.BackgroundImage"), System.Drawing.Image)
        Me.btn_selserver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_selserver.Enabled = False
        Me.btn_selserver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btn_selserver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btn_selserver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_selserver.ForeColor = System.Drawing.Color.White
        Me.btn_selserver.Image = Global.wow_launcher.My.Resources.Resources.selicon
        Me.btn_selserver.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_selserver.Location = New System.Drawing.Point(484, 278)
        Me.btn_selserver.Name = "btn_selserver"
        Me.btn_selserver.Size = New System.Drawing.Size(97, 27)
        Me.btn_selserver.TabIndex = 12
        Me.btn_selserver.TabStop = False
        Me.btn_selserver.Text = "Set Realmlist"
        Me.btn_selserver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_selserver.UseVisualStyleBackColor = False
        '
        'btn_playwow
        '
        Me.btn_playwow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_playwow.BackColor = System.Drawing.Color.Black
        Me.btn_playwow.BackgroundImage = CType(resources.GetObject("btn_playwow.BackgroundImage"), System.Drawing.Image)
        Me.btn_playwow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_playwow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btn_playwow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btn_playwow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_playwow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_playwow.ForeColor = System.Drawing.Color.White
        Me.btn_playwow.Image = Global.wow_launcher.My.Resources.Resources.icon_neutral
        Me.btn_playwow.Location = New System.Drawing.Point(484, 311)
        Me.btn_playwow.Name = "btn_playwow"
        Me.btn_playwow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_playwow.Size = New System.Drawing.Size(198, 60)
        Me.btn_playwow.TabIndex = 11
        Me.btn_playwow.TabStop = False
        Me.btn_playwow.Text = "Play World of Warcraft"
        Me.btn_playwow.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_playwow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_playwow.UseVisualStyleBackColor = False
        '
        'btn_clearcache
        '
        Me.btn_clearcache.AutoSize = True
        Me.btn_clearcache.BackColor = System.Drawing.Color.Black
        Me.btn_clearcache.BackgroundImage = CType(resources.GetObject("btn_clearcache.BackgroundImage"), System.Drawing.Image)
        Me.btn_clearcache.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_clearcache.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btn_clearcache.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btn_clearcache.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clearcache.ForeColor = System.Drawing.Color.White
        Me.btn_clearcache.Image = Global.wow_launcher.My.Resources.Resources.clear
        Me.btn_clearcache.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_clearcache.Location = New System.Drawing.Point(587, 278)
        Me.btn_clearcache.Name = "btn_clearcache"
        Me.btn_clearcache.Size = New System.Drawing.Size(95, 27)
        Me.btn_clearcache.TabIndex = 10
        Me.btn_clearcache.TabStop = False
        Me.btn_clearcache.Text = "Clear Cache"
        Me.btn_clearcache.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_clearcache.UseVisualStyleBackColor = False
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
        Me.btn_server_remove.TabStop = False
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
        Me.btn_server_add.TabStop = False
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
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SaddleBrown
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(761, 405)
        Me.Controls.Add(Me.btn_options)
        Me.Controls.Add(Me.btn_selserver)
        Me.Controls.Add(Me.btn_playwow)
        Me.Controls.Add(Me.btn_clearcache)
        Me.Controls.Add(Me.btn_server_remove)
        Me.Controls.Add(Me.btn_server_add)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.list_servers)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_lang)
        Me.Controls.Add(Me.lbl_wowdir)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Molten wow Game Launcher"
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
        'move the main form 
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
    Friend WithEvents lbl_wowdir As System.Windows.Forms.Label
    Friend WithEvents lbl_lang As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'ping settings
        res = eco.Send(selser)
        Label3.Text = "Latency: " & res.RoundtripTime & "ms"
        If res.RoundtripTime = 0 Then
            Timer1.Enabled = False
            Label3.Text = "Latency: No Response"
        End If
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
        'check if some item is selected in list view, if is not select server and delete server buttoms are dissabled
        If list_servers.SelectedItems.Count = 0 Then
            btn_server_remove.Enabled = False
            btn_selserver.Enabled = False
        Else
            btn_server_remove.Enabled = True
            btn_selserver.Enabled = True
        End If

        'if some item in listview is selected, get the item index
        If list_servers.Items.Count > 0 Then
            Dim i As Integer
            For Each i In list_servers.SelectedIndices
                listaindice = list_servers.Items(i).Index
            Next
        End If
    End Sub

    Private Sub form_main_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        save_data()
    End Sub 'Form_Closing

    Private Sub frm_main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        read_data()
        read_config()

    End Sub
    Friend WithEvents btn_playwow As System.Windows.Forms.Button
    Friend WithEvents btn_clearcache As System.Windows.Forms.Button
    Friend WithEvents btn_selserver As System.Windows.Forms.Button
    Friend WithEvents btn_options As System.Windows.Forms.Button

    Private Sub btn_server_remove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_server_remove.Click
        Dim nombre As String, i As Integer, lista_contador As Integer, total As Integer
        nombre = My.Application.Info.ProductName
        lista_contador = GetSetting(nombre, "realms", "total", 0)
        total = lista_contador - 1
        If total <> 0 Then
            For i = 0 To total
                DeleteSetting(nombre, "realm", i)
                DeleteSetting(nombre, "server", i)
                DeleteSetting(nombre, "region", i)
                DeleteSetting(nombre, "status", i)
            Next i
            list_servers.Items.Item(listaindice).Remove()
            SaveSetting(nombre, "realms", "total", 0) 'save settings to prevent an infinite loop
        End If
    End Sub

    Private Sub btn_server_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_server_add.Click
        Me.Hide()
        frm_addserver.Show()
        ShowToolStripMenuItem.Visible = False
        HideToolStripMenuItem.Visible = False
        ToolStripSeparator1.Visible = False
    End Sub
    Public Function read_data()
        'read the servers list data, if is empty save by default molten, and retail servers
        Dim lista_contador As String, nombre As String
        nombre = My.Application.Info.ProductName
        lista_contador = GetSetting(nombre, "realms", "total", "0")
        If lista_contador <> 0 Then
            list_servers.Items.Clear()
            Dim i As Integer, realm As String, server As String, region As String, status As String
            For i = 0 To lista_contador - 1
                realm = GetSetting(nombre, "realm", i, "")
                server = GetSetting(nombre, "server", i, "")
                region = GetSetting(nombre, "region", i, "")
                status = GetSetting(nombre, "status", i, "")
                Dim contador As Integer
                contador = list_servers.Items.Count - 1
                list_servers.Items.Add(server)
                list_servers.Items(i).SubItems.Add(region)
                list_servers.Items(i).SubItems.Add(realm)
                list_servers.Items(i).SubItems.Add(status)
            Next i
        ElseIf lista_contador = 0 Then
            save_data()
        End If
        Return 0
    End Function

    Public Function save_data()
        'this function saves the data from listview into windows reg
        Dim lista_contador As String, nombre As String
        nombre = My.Application.Info.ProductName
        lista_contador = list_servers.Items.Count - 1
        SaveSetting(nombre, "realms", "total", list_servers.Items.Count)
        If lista_contador <> 0 Then
            Dim i As Integer, x As Integer
            For i = 0 To lista_contador
                SaveSetting(nombre, "server", i, list_servers.Items(i).Text)
                For x = 0 To list_servers.Items(i).SubItems.Count - 1
                    SaveSetting(nombre, "region", i, list_servers.Items(i).SubItems(1).Text)
                    SaveSetting(nombre, "realm", i, list_servers.Items(i).SubItems(2).Text)
                    SaveSetting(nombre, "status", i, list_servers.Items(i).SubItems(3).Text)
                Next x
            Next i
        End If
        Return 0
    End Function

    Private Sub btn_selserver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_selserver.Click
        Dim i As Integer, lista_contador As Integer, nombre As String
        nombre = My.Application.Info.ProductName
        lista_contador = list_servers.Items.Count
        For i = 0 To lista_contador - 1
            Dim contador As Integer
            contador = list_servers.Items.Count - 1
            list_servers.Items(i).SubItems(3).Text = "No Selected"
        Next i
        list_servers.Items(listaindice).SubItems(3).Text = "Selected"
        SaveSetting(nombre, "realms", "selectedrealm", list_servers.Items(listaindice).SubItems(2).Text)
        selser = list_servers.Items(listaindice).SubItems(2).Text
        If Timer1.Enabled = False Then
            Timer1.Enabled = True
        End If
    End Sub

    Public Function read_config()
        selser = GetSetting(My.Application.Info.ProductName, "realms", "selectedrealm", "logon.molten-wow.com")
        gamedir = GetSetting(My.Application.Info.ProductName, "realms", "gamedir", "(No dir selected)")
        gamelang = GetSetting(My.Application.Info.ProductName, "realms", "gamelang", "English United States")
        lbl_wowdir.Text = "Game Dir: " & gamedir
        lbl_lang.Text = "Language: " & gamelang
        'check the game language for game data
        If gamelang = "English United States" Then
            langdir = "enUS"
        ElseIf gamelang = "English Great Britain" Then
            langdir = "enGB"
        ElseIf gamelang = "German" Then
            langdir = "deDE"
        ElseIf gamelang = "French" Then
            langdir = "frFR"
        ElseIf gamelang = "Spanish Spain" Then
            langdir = "esES"
        ElseIf gamelang = "Spanish Mexico" Then
            langdir = "esMX"
        ElseIf gamelang = "Russian" Then
            langdir = "ruRU"
        End If
        'end check
        Return 0
    End Function

    Private Sub btn_options_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_options.Click
        Me.Hide()
        frm_options.Show()
        ShowToolStripMenuItem.Visible = False
        HideToolStripMenuItem.Visible = False
        ToolStripSeparator1.Visible = False
    End Sub

    Private Sub btn_clearcache_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clearcache.Click
        Try
            Dim midirectorio As String = gamedir & "cache\wdb"
            If gamedir = "(No dir selected)" Then
                MsgBox("The game's path is invalid. Please check your game directory and try again", 16, "Clear Cache")
            Else
                'check if file wow.exe exist into the selected folder, if exist save the changes, if is not exist then send a msgbox
                Dim cachedir As String
                cachedir = gamedir & "CACHE\WDB"
                If System.IO.Directory.Exists(cachedir) = True Then
                    My.Computer.FileSystem.DeleteDirectory(midirectorio, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.DoNothing)
                    MsgBox("The GAME CACHE was deleted successfully", 64, "Clear Cache")
                Else
                    MsgBox("The GAME CACHE was not deleted." & vbCrLf & "Check the files aren't in read only mode or exist.", 48, "Clear Cache")
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub


End Class
