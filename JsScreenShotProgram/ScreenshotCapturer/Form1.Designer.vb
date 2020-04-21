Imports System.Windows.Forms
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form1
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

    ' Token: 0x06000008 RID: 8 RVA: 0x000023B4 File Offset: 0x000005B4
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.saveScreenshot = New System.Windows.Forms.SaveFileDialog()
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.notifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.contextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.captureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStrip1.SuspendLayout()
        Me.contextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'saveScreenshot
        '
        Me.saveScreenshot.Filter = "PNG File|*.png"
        '
        'toolStrip1
        '
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton1})
        Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(177, 25)
        Me.toolStrip1.TabIndex = 0
        Me.toolStrip1.Text = "toolStrip1"
        '
        'toolStripButton1
        '
        Me.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton1.Name = "toolStripButton1"
        Me.toolStripButton1.Size = New System.Drawing.Size(53, 22)
        Me.toolStripButton1.Text = "Capture"
        '
        'notifyIcon1
        '
        Me.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.notifyIcon1.ContextMenuStrip = Me.contextMenuStrip1
        Me.notifyIcon1.Icon = CType(resources.GetObject("notifyIcon1.Icon"), System.Drawing.Icon)
        Me.notifyIcon1.Text = "J's Snipping Tool - Ready"
        Me.notifyIcon1.Visible = True
        '
        'contextMenuStrip1
        '
        Me.contextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.captureToolStripMenuItem, Me.toolStripMenuItem2, Me.toolStripMenuItem1, Me.exitToolStripMenuItem})
        Me.contextMenuStrip1.Name = "contextMenuStrip1"
        Me.contextMenuStrip1.Size = New System.Drawing.Size(120, 76)
        '
        'captureToolStripMenuItem
        '
        Me.captureToolStripMenuItem.Name = "captureToolStripMenuItem"
        Me.captureToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.captureToolStripMenuItem.Text = "Capture "
        '
        'toolStripMenuItem2
        '
        Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
        Me.toolStripMenuItem2.Size = New System.Drawing.Size(119, 22)
        Me.toolStripMenuItem2.Text = "About"
        '
        'toolStripMenuItem1
        '
        Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
        Me.toolStripMenuItem1.Size = New System.Drawing.Size(116, 6)
        '
        'exitToolStripMenuItem
        '
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.exitToolStripMenuItem.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(177, 25)
        Me.Controls.Add(Me.toolStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.Text = "Windows XP Snipping Tool"
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        Me.contextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    ' Token: 0x04000005 RID: 5
    Private components As Global.System.ComponentModel.IContainer = Nothing
    Friend WithEvents toolStrip1 As toolStrip
    Friend WithEvents toolStripButton1 As toolStripButton
    Friend WithEvents notifyIcon1 As notifyIcon
    Friend WithEvents contextMenuStrip1 As contextMenuStrip
    Friend WithEvents toolStripMenuItem2 As toolStripMenuItem
    Friend WithEvents toolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents saveScreenshot As SaveFileDialog
    Friend WithEvents captureToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents exitToolStripMenuItem As ToolStripMenuItem
End Class
