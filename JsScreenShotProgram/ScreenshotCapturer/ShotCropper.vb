Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Windows.Forms

Public Class ShotCropper

    ' Token: 0x06000017 RID: 23 RVA: 0x00002BB4 File Offset: 0x00000DB4
    Public Sub New()
        Me.InitializeComponent()
        Try
            Me.pictureBox1.ImageLocation = "temp.png"
        Catch
        End Try
    End Sub

    ' Token: 0x0600001A RID: 26 RVA: 0x00002C0C File Offset: 0x00000E0C
    Private Sub ShotCropper_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
        Try
            Me.pictureBox1.Location = New Point(0, 25)
        Catch
        End Try
    End Sub

    ' Token: 0x0600001B RID: 27 RVA: 0x00002C48 File Offset: 0x00000E48
    Private Sub pictureBox1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pictureBox1.MouseMove
        Try
            If _selecting Then
                _selection.Width = e.X - Me._selection.X
                _selection.Height = e.Y - Me._selection.Y
                pictureBox1.Refresh()
            End If
        Catch
        End Try
    End Sub

    ' Token: 0x0600001C RID: 28 RVA: 0x00002CC8 File Offset: 0x00000EC8
    Private Sub pictureBox1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pictureBox1.MouseUp
        Try
            If e.Button = MouseButtons.Left AndAlso _selecting Then
                _selecting = False
            End If
        Catch
        End Try
    End Sub

    ' Token: 0x0600001D RID: 29 RVA: 0x00002D18 File Offset: 0x00000F18
    Private Sub pictureBox1_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles pictureBox1.Paint
        Try
            If _selecting Then
                e.Graphics.DrawRectangle(Pens.Red, _selection)
            End If
        Catch
        End Try
    End Sub

    ' Token: 0x0600001E RID: 30 RVA: 0x00002D68 File Offset: 0x00000F68
    Private Sub pictureBox1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pictureBox1.MouseDown
        Try
            _originalImage = TryCast(pictureBox1.Image.Clone(), Image)
            If e.Button = MouseButtons.Left Then
                _selecting = True
                _selection = New Rectangle(New Point(e.X, e.Y), Nothing)
            End If
        Catch
        End Try
    End Sub

    ' Token: 0x0600001F RID: 31 RVA: 0x00002DF0 File Offset: 0x00000FF0
    Private Sub toolStripButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton2.Click
        Try
            Me.pictureBox1.Image = pictureBox1.Image.Crop(_selection)
        Catch
        End Try
    End Sub

    ' Token: 0x06000020 RID: 32 RVA: 0x00002E3C File Offset: 0x0000103C
    Private Sub toolStripButton4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton4.Click
        Try
            Me.pictureBox1.Image = pictureBox1.Image.Fit2PictureBox(pictureBox1)
        Catch
        End Try
    End Sub

    ' Token: 0x06000021 RID: 33 RVA: 0x00002E88 File Offset: 0x00001088
    Private Sub toolStripButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton1.Click
        Try
            Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
            saveFileDialog.Filter = "JPEG | *.jpg"
            saveFileDialog.ShowDialog()
            pictureBox1.Image.Save(saveFileDialog.FileName, ImageFormat.Jpeg)
        Catch
        End Try
    End Sub

    ' Token: 0x06000022 RID: 34 RVA: 0x00002EEC File Offset: 0x000010EC
    Private Sub toolStripButton5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton5.Click
        Try
            Me.pictureBox1.Image = TryCast(_originalImage.Clone(), Image)
        Catch
        End Try
    End Sub

    ' Token: 0x06000023 RID: 35 RVA: 0x00002F34 File Offset: 0x00001134
    Private Sub toolStripButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton3.Click
        Try
            Clipboard.SetImage(pictureBox1.Image)
        Catch
        End Try
    End Sub

    ' Token: 0x06000024 RID: 36 RVA: 0x00002F70 File Offset: 0x00001170
    Private Sub cropToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cropToolStripMenuItem.Click
        toolStripButton2.PerformClick()
    End Sub

    ' Token: 0x06000025 RID: 37 RVA: 0x00002F7F File Offset: 0x0000117F
    Private Sub autoSizeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles autoSizeToolStripMenuItem.Click
        toolStripButton4.PerformClick()
    End Sub

    ' Token: 0x06000026 RID: 38 RVA: 0x00002F8E File Offset: 0x0000118E
    Private Sub saveToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles saveToolStripMenuItem.Click
        toolStripButton1.PerformClick()
    End Sub

    ' Token: 0x06000027 RID: 39 RVA: 0x00002F9D File Offset: 0x0000119D
    Private Sub copyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles copyToolStripMenuItem.Click
        toolStripButton3.PerformClick()
    End Sub

    ' Token: 0x06000028 RID: 40 RVA: 0x00002FAC File Offset: 0x000011AC
    Private Sub originalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles originalToolStripMenuItem.Click
        toolStripButton5.PerformClick()
    End Sub

    ' Token: 0x06000029 RID: 41 RVA: 0x00002FBC File Offset: 0x000011BC
    Private Sub aboutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles aboutToolStripMenuItem.Click
        Try
            Dim about As About = New About()
            about.Show()
        Catch
        End Try
    End Sub

    ' Token: 0x0600002A RID: 42 RVA: 0x00002FF4 File Offset: 0x000011F4
    Private Sub toolStripButton6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton6.Click
        Close()
    End Sub

    ' Token: 0x04000013 RID: 19
    Dim _originalImage As Image

    ' Token: 0x04000014 RID: 20
    Dim _selecting As Boolean

    ' Token: 0x04000015 RID: 21
    Dim _selection As Rectangle
End Class
