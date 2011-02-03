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

    End Sub

    Private Sub btn_acept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_acept.Click
        If btn_apply.Enabled = True Then
            '
        End If
        Me.Close()
    End Sub
End Class