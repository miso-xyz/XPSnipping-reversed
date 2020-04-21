Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Windows.Forms
Public Class Form1

    ' Token: 0x06000009 RID: 9 RVA: 0x0000286F File Offset: 0x00000A6F
    Public Sub New()
        Me.InitializeComponent()
        MyBase.Hide()
    End Sub

    ' Token: 0x0600000B RID: 11 RVA: 0x0000289C File Offset: 0x00000A9C
    Private Shared Function cropImage(ByVal img As Image, ByVal cropArea As Rectangle) As Image
        Dim bitmap As Bitmap = New Bitmap(img)
        Return bitmap.Clone(cropArea, bitmap.PixelFormat)
    End Function

    ' Token: 0x0600000C RID: 12 RVA: 0x000028C4 File Offset: 0x00000AC4
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        notifyIcon1.BalloonTipTitle = "Did You Know?"
        notifyIcon1.BalloonTipText = "You can capture a screen by right clicking me or by using the capture window. To capture a secondary monitor, drag the capture window to that screen and click capture."
        notifyIcon1.ShowBalloonTip(3000)
        Hide()
    End Sub

    ' Token: 0x0600000D RID: 13 RVA: 0x00002904 File Offset: 0x00000B04
    Private Sub toolStripButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripMenuItem1.Click, toolStripButton1.Click
        Hide()
        Dim form As Form = New Form()
        For Each obj As Object In Application.OpenForms
            Dim form2 As Form = CType(obj, Form)
            If TypeOf form2 Is ShotCropper Then
                form = form2
            End If
        Next
        Try
            CType(form, ShotCropper).Close()
        Catch
        End Try
        bmpScreenshot = New Bitmap(Screen.FromControl(Me).Bounds.Width, Screen.FromControl(Me).Bounds.Height, PixelFormat.Format32bppArgb)
        gfxScreenshot = Graphics.FromImage(bmpScreenshot)
        gfxScreenshot.CopyFromScreen(Screen.FromControl(Me).Bounds.X, Screen.FromControl(Me).Bounds.Y, 0, 0, Screen.FromControl(Me).Bounds.Size, CopyPixelOperation.SourceCopy)
        bmpScreenshot.Save("temp.png", ImageFormat.Png)
        Dim shotCropper As ShotCropper = New ShotCropper()
        shotCropper.Show()
        shotCropper.WindowState = FormWindowState.Maximized
        MyBase.Show()
        MyBase.TopMost = True
    End Sub

    ' Token: 0x0600000E RID: 14 RVA: 0x00002A7C File Offset: 0x00000C7C
    Private Sub captureToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles captureToolStripMenuItem.Click
        Me.toolStripButton1.PerformClick()
    End Sub

    ' Token: 0x0600000F RID: 15 RVA: 0x00002A8C File Offset: 0x00000C8C
    Private Sub exitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles exitToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you would like to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.closeme = True
            MyBase.Close()
        End If
    End Sub

    ' Token: 0x06000010 RID: 16 RVA: 0x00002AC8 File Offset: 0x00000CC8
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If closeme Then
            End
        Else
            Hide()
            e.Cancel = True
        End If
    End Sub

    ' Token: 0x06000011 RID: 17 RVA: 0x00002AFE File Offset: 0x00000CFE
    Private Sub notifyIcon1_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles notifyIcon1.DoubleClick
        Show()
    End Sub

    ' Token: 0x06000012 RID: 18 RVA: 0x00002B08 File Offset: 0x00000D08
    Private Sub toolStripMenuItem2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripMenuItem2.Click
        Dim about As About = New About()
        about.Show()
    End Sub
    Dim bmpScreenshot As Bitmap
    Dim gfxScreenshot As Graphics
    Dim closeme As Boolean = False
End Class
