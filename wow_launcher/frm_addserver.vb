Public Class frm_addserver

    Private Sub form_addserver_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        frm_main.ContextMenuStrip1.Visible = True
        frm_main.ShowToolStripMenuItem.Visible = False
        frm_main.HideToolStripMenuItem.Visible = True
        frm_main.ToolStripSeparator1.Visible = True
        frm_main.Show()
    End Sub 'Form1_Closing

End Class