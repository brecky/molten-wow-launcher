Public Class frm_addserver

    Private Sub frm_addserver_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        frm_main.ShowToolStripMenuItem.Visible = False
        frm_main.HideToolStripMenuItem.Visible = True
        frm_main.ToolStripSeparator1.Visible = True
        frm_main.Show()
    End Sub 'Form_Closing

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'chek if all items have data
        If cbx_region.SelectedItem = "" Then
            btn_addserver.Enabled = False
        ElseIf txt_realm.Text = "" Then
            btn_addserver.Enabled = False
        ElseIf txt_server.Text = "" Then
            btn_addserver.Enabled = False
        Else
            btn_addserver.Enabled = True
        End If
    End Sub

    Private Sub btn_addserver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_addserver.Click
        Dim contador As Integer
        frm_main.list_servers.Items.Add(txt_server.Text)
        contador = frm_main.list_servers.Items.Count - 1
        frm_main.list_servers.Items(contador).SubItems.Add(cbx_region.SelectedItem)
        frm_main.list_servers.Items(contador).SubItems.Add(txt_realm.Text)
        frm_main.list_servers.Items(contador).SubItems.Add("No Selected")
        'Dim lista_contador As String, nombre As String
        'nombre = My.Application.Info.ProductName
        'lista_contador = frm_main.list_servers.Items.Count
        'SaveSetting(nombre, "realms", "total", frm_main.list_servers.Items.Count + 1)
        'x = list_servers.Items(i).SubItems.Count - 1
        'SaveSetting(nombre, "server", lista_contador, txt_server.Text)
        'SaveSetting(nombre, "region", lista_contador, cbx_region.SelectedItem)
        'SaveSetting(nombre, "realm", lista_contador, txt_realm.Text)
        'SaveSetting(nombre, "status", lista_contador, "No Selected")
        'frm_main.read_data()
            Me.Close()
    End Sub


    Private Sub frm_addserver_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim gllang As String
        gllang = GetSetting(My.Application.Info.ProductName, "realms", "gllang", "English")
        If gllang = "English" Then
            mod_lang.addlang_en()
        ElseIf gllang = "Español" Then
            mod_lang.addlang_es()
        End If
    End Sub
End Class