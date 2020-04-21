Imports System
Imports System.ComponentModel
Imports System.Configuration
Imports System.Drawing
Imports System.Windows.Forms

' Token: 0x02000002 RID: 2
Public Class GNU

    ' Token: 0x06000004 RID: 4 RVA: 0x000022EC File Offset: 0x000004EC
    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        If MessageBox.Show("Please remove this software from your machine if you do not agree to the terms of use. Are you sure you wish to continue?", "Are you sure?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Application.[Exit]()
        End If
    End Sub

    ' Token: 0x06000005 RID: 5 RVA: 0x0000231C File Offset: 0x0000051C
    Private Sub GNU_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        richTextBox1.Text = ConfigurationManager.AppSettings("GNUGPL").ToString()
    End Sub

    ' Token: 0x06000006 RID: 6 RVA: 0x00002340 File Offset: 0x00000540
    Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
        Config.editConfig("FTR", "1")
        Form1.Show()
        Owner = Form1
        Hide()
    End Sub
End Class
