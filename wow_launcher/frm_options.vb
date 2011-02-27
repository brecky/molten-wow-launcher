Imports System.Collections
Public Class frm_options


    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub frm_options_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        frm_main.ShowToolStripMenuItem.Visible = False
        frm_main.HideToolStripMenuItem.Visible = True
        frm_main.ToolStripSeparator1.Visible = True
        frm_main.Show()
    End Sub 'Form_Closing

    Private Sub frm_options_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'get the settings from windows reg
        Dim gllang As String
        gllang = GetSetting(My.Application.Info.ProductName, "realms", "gllang", "English")
        If gllang = "0" Then
            mod_lang.optionslang_en()
        ElseIf gllang = "1" Then
            mod_lang.optionslang_es()
        End If
        txt_gamedir.Text = GetSetting(My.Application.Info.ProductName, "realms", "gamedir", "(No dir selected)")
        cbx_gamelang.SelectedIndex = GetSetting(My.Application.Info.ProductName, "realms", "gamelang", "0")
        cbx_gllang.SelectedIndex = GetSetting(My.Application.Info.ProductName, "realms", "gllang", "0")
        cbx_playwow.SelectedIndex = GetSetting(My.Application.Info.ProductName, "realms", "playwow", "0")
    End Sub

    Private Sub btn_acept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_acept.Click
        If btn_apply.Enabled = True Then
            apply()
        End If
        Me.Close()
    End Sub

    Private Sub btn_seldir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_seldir.Click
        seldir()
    End Sub

    Private Function fileexist()
        'check if file wow.exe exist into the selected folder, if exist save the changes, if is not exist then send a msgbox
        Dim wow As String
        wow = txt_gamedir.Text & "wow.exe"
        If System.IO.File.Exists(wow) = False Then
            MsgBox(Label5.Text & txt_gamedir.Text & Label7.Text, 64, "Wow Path")
            seldir()
        Else
            btn_cancel.Enabled = True
            btn_apply.Enabled = True
        End If
        Return 0
    End Function

    Private Function seldir()
        On Error Resume Next
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            txt_gamedir.Text = FolderBrowserDialog1.SelectedPath & "\"
            fileexist()
            btn_cancel.Enabled = True
            btn_apply.Enabled = True
        ElseIf FolderBrowserDialog1.ShowDialog() = DialogResult.Cancel Then
            txt_gamedir.Text = GetSetting(My.Application.Info.ProductName, "realms", "gamedir", "(No dir selected)")
        End If
        Return 0
    End Function

    Private Sub btn_apply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_apply.Click
        apply()
    End Sub

    Private Function apply()
        btn_cancel.Enabled = False
        btn_apply.Enabled = False
        SaveSetting(My.Application.Info.ProductName, "realms", "gamedir", txt_gamedir.Text)
        SaveSetting(My.Application.Info.ProductName, "realms", "gllang", cbx_gllang.SelectedIndex)
        SaveSetting(My.Application.Info.ProductName, "realms", "playwow", cbx_playwow.SelectedIndex)
        SaveSetting(My.Application.Info.ProductName, "realms", "gllangtxt", cbx_gllang.SelectedItem)
        SaveSetting(My.Application.Info.ProductName, "realms", "playwowtxt", cbx_playwow.SelectedItem)
        If cbx_gamelang.SelectedItem <> "" Then
            SaveSetting(My.Application.Info.ProductName, "realms", "gamelang", cbx_gamelang.SelectedIndex)
            SaveSetting(My.Application.Info.ProductName, "realms", "gamelangtxt", cbx_gamelang.SelectedItem)
        End If
        frm_main.read_config()
        Return 0
    End Function

    Private Sub cbx_gamelang_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_gamelang.SelectedIndexChanged
        btn_cancel.Enabled = True
        btn_apply.Enabled = True
    End Sub

End Class