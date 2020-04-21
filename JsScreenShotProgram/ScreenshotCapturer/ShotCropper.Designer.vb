Imports System.Windows.Forms
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ShotCropper
    Inherits Form

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

    ' Token: 0x0600002C RID: 44 RVA: 0x00003038 File Offset: 0x00001238
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ShotCropper))
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.contextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cropToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.autoSizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.saveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.copyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.originalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripButton6 = New System.Windows.Forms.ToolStripButton()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.contextMenuStrip1.SuspendLayout()
        Me.toolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pictureBox1
        '
        Me.pictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBox1.ContextMenuStrip = Me.contextMenuStrip1
        Me.pictureBox1.Location = New System.Drawing.Point(0, 25)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(568, 370)
        Me.pictureBox1.TabIndex = 0
        Me.pictureBox1.TabStop = False
        '
        'contextMenuStrip1
        '
        Me.contextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cropToolStripMenuItem, Me.autoSizeToolStripMenuItem, Me.saveToolStripMenuItem, Me.copyToolStripMenuItem, Me.originalToolStripMenuItem, Me.toolStripMenuItem1, Me.aboutToolStripMenuItem})
        Me.contextMenuStrip1.Name = "contextMenuStrip1"
        Me.contextMenuStrip1.Size = New System.Drawing.Size(124, 142)
        '
        'cropToolStripMenuItem
        '
        Me.cropToolStripMenuItem.Name = "cropToolStripMenuItem"
        Me.cropToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.cropToolStripMenuItem.Text = "Crop"
        '
        'autoSizeToolStripMenuItem
        '
        Me.autoSizeToolStripMenuItem.Name = "autoSizeToolStripMenuItem"
        Me.autoSizeToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.autoSizeToolStripMenuItem.Text = "Auto Size"
        '
        'saveToolStripMenuItem
        '
        Me.saveToolStripMenuItem.Name = "saveToolStripMenuItem"
        Me.saveToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.saveToolStripMenuItem.Text = "Save"
        '
        'copyToolStripMenuItem
        '
        Me.copyToolStripMenuItem.Name = "copyToolStripMenuItem"
        Me.copyToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.copyToolStripMenuItem.Text = "Copy"
        '
        'originalToolStripMenuItem
        '
        Me.originalToolStripMenuItem.Name = "originalToolStripMenuItem"
        Me.originalToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.originalToolStripMenuItem.Text = "Original"
        '
        'toolStripMenuItem1
        '
        Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
        Me.toolStripMenuItem1.Size = New System.Drawing.Size(120, 6)
        '
        'aboutToolStripMenuItem
        '
        Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
        Me.aboutToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.aboutToolStripMenuItem.Text = "About"
        '
        'toolStrip1
        '
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton2, Me.toolStripSeparator1, Me.toolStripButton4, Me.toolStripSeparator4, Me.toolStripButton1, Me.toolStripSeparator2, Me.toolStripButton3, Me.toolStripSeparator3, Me.toolStripButton5, Me.toolStripSeparator5, Me.toolStripButton6})
        Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(568, 25)
        Me.toolStrip1.TabIndex = 1
        Me.toolStrip1.Text = "toolStrip1"
        '
        'toolStripButton2
        '
        Me.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripButton2.Image = CType(resources.GetObject("toolStripButton2.Image"), System.Drawing.Image)
        Me.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton2.Name = "toolStripButton2"
        Me.toolStripButton2.Size = New System.Drawing.Size(37, 22)
        Me.toolStripButton2.Text = "Crop"
        Me.toolStripButton2.ToolTipText = "Crop the selected region."
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'toolStripButton4
        '
        Me.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripButton4.Image = CType(resources.GetObject("toolStripButton4.Image"), System.Drawing.Image)
        Me.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton4.Name = "toolStripButton4"
        Me.toolStripButton4.Size = New System.Drawing.Size(60, 22)
        Me.toolStripButton4.Text = "Auto Size"
        Me.toolStripButton4.ToolTipText = "Enlarge cropped region."
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'toolStripButton1
        '
        Me.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripButton1.Image = CType(resources.GetObject("toolStripButton1.Image"), System.Drawing.Image)
        Me.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton1.Name = "toolStripButton1"
        Me.toolStripButton1.Size = New System.Drawing.Size(35, 22)
        Me.toolStripButton1.Text = "Save"
        Me.toolStripButton1.ToolTipText = "Save image to disk."
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'toolStripButton3
        '
        Me.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripButton3.Image = CType(resources.GetObject("toolStripButton3.Image"), System.Drawing.Image)
        Me.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton3.Name = "toolStripButton3"
        Me.toolStripButton3.Size = New System.Drawing.Size(39, 22)
        Me.toolStripButton3.Text = "Copy"
        Me.toolStripButton3.ToolTipText = "Copy the image to your clipboard so that you can paste into emails and such."
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'toolStripButton5
        '
        Me.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripButton5.Image = CType(resources.GetObject("toolStripButton5.Image"), System.Drawing.Image)
        Me.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton5.Name = "toolStripButton5"
        Me.toolStripButton5.Size = New System.Drawing.Size(44, 22)
        Me.toolStripButton5.Text = "Revert"
        Me.toolStripButton5.ToolTipText = "Revert to last edit of image"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'toolStripButton6
        '
        Me.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripButton6.Image = CType(resources.GetObject("toolStripButton6.Image"), System.Drawing.Image)
        Me.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton6.Name = "toolStripButton6"
        Me.toolStripButton6.Size = New System.Drawing.Size(40, 22)
        Me.toolStripButton6.Text = "Close"
        Me.toolStripButton6.ToolTipText = "Close the capture window"
        '
        'ShotCropper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(50, 50)
        Me.AutoScrollMinSize = New System.Drawing.Size(100, 100)
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(568, 394)
        Me.Controls.Add(Me.toolStrip1)
        Me.Controls.Add(Me.pictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ShotCropper"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Screen Shot Editor"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.contextMenuStrip1.ResumeLayout(False)
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    ' Token: 0x04000016 RID: 22
    Private components As Global.System.ComponentModel.IContainer = Nothing
    Friend WithEvents toolStrip1 As toolStrip
    Friend WithEvents toolStripButton2 As ToolStripButton
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents toolStripButton4 As ToolStripButton
    Friend WithEvents toolStripSeparator4 As ToolStripSeparator
    Friend WithEvents toolStripButton1 As ToolStripButton
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents toolStripButton3 As ToolStripButton
    Friend WithEvents toolStripSeparator3 As ToolStripSeparator
    Friend WithEvents toolStripButton5 As ToolStripButton
    Friend WithEvents toolStripSeparator5 As ToolStripSeparator
    Friend WithEvents toolStripButton6 As ToolStripButton
    Friend WithEvents toolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents cropToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents autoSizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents saveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents copyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents originalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents contextMenuStrip1 As ContextMenuStrip
    Friend WithEvents pictureBox1 As PictureBox
    Friend WithEvents aboutToolStripMenuItem As ToolStripMenuItem

End Class