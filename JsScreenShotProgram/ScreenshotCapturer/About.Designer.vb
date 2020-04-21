Imports System.Windows.Forms
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class About
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

    ' Token: 0x0600003E RID: 62 RVA: 0x000042E0 File Offset: 0x000024E0
    Private Sub InitializeComponent()
        Me.tableLayoutPanel = New Global.System.Windows.Forms.TableLayoutPanel()
        Me.labelProductName = New Global.System.Windows.Forms.Label()
        Me.labelVersion = New Global.System.Windows.Forms.Label()
        Me.labelCopyright = New Global.System.Windows.Forms.Label()
        Me.labelCompanyName = New Global.System.Windows.Forms.Label()
        Me.textBoxDescription = New Global.System.Windows.Forms.TextBox()
        Me.tableLayoutPanel.SuspendLayout()
        MyBase.SuspendLayout()
        Me.tableLayoutPanel.ColumnCount = 2
        Me.tableLayoutPanel.ColumnStyles.Add(New Global.System.Windows.Forms.ColumnStyle(Global.System.Windows.Forms.SizeType.Percent, 1.900238F))
        Me.tableLayoutPanel.ColumnStyles.Add(New Global.System.Windows.Forms.ColumnStyle(Global.System.Windows.Forms.SizeType.Percent, 98.09976F))
        Me.tableLayoutPanel.Controls.Add(Me.labelProductName, 1, 0)
        Me.tableLayoutPanel.Controls.Add(Me.labelVersion, 1, 1)
        Me.tableLayoutPanel.Controls.Add(Me.labelCopyright, 1, 2)
        Me.tableLayoutPanel.Controls.Add(Me.labelCompanyName, 1, 3)
        Me.tableLayoutPanel.Controls.Add(Me.textBoxDescription, 1, 4)
        Me.tableLayoutPanel.Dock = Global.System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel.Location = New Global.System.Drawing.Point(9, 9)
        Me.tableLayoutPanel.Name = "tableLayoutPanel"
        Me.tableLayoutPanel.RowCount = 6
        Me.tableLayoutPanel.RowStyles.Add(New Global.System.Windows.Forms.RowStyle(Global.System.Windows.Forms.SizeType.Percent, 10.0F))
        Me.tableLayoutPanel.RowStyles.Add(New Global.System.Windows.Forms.RowStyle(Global.System.Windows.Forms.SizeType.Percent, 10.0F))
        Me.tableLayoutPanel.RowStyles.Add(New Global.System.Windows.Forms.RowStyle(Global.System.Windows.Forms.SizeType.Percent, 10.0F))
        Me.tableLayoutPanel.RowStyles.Add(New Global.System.Windows.Forms.RowStyle(Global.System.Windows.Forms.SizeType.Percent, 10.0F))
        Me.tableLayoutPanel.RowStyles.Add(New Global.System.Windows.Forms.RowStyle(Global.System.Windows.Forms.SizeType.Percent, 50.0F))
        Me.tableLayoutPanel.RowStyles.Add(New Global.System.Windows.Forms.RowStyle(Global.System.Windows.Forms.SizeType.Percent, 10.0F))
        Me.tableLayoutPanel.Size = New Global.System.Drawing.Size(350, 161)
        Me.tableLayoutPanel.TabIndex = 0
        Me.labelProductName.Dock = Global.System.Windows.Forms.DockStyle.Fill
        Me.labelProductName.Location = New Global.System.Drawing.Point(12, 0)
        Me.labelProductName.Margin = New Global.System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.labelProductName.MaximumSize = New Global.System.Drawing.Size(0, 17)
        Me.labelProductName.Name = "labelProductName"
        Me.labelProductName.Size = New Global.System.Drawing.Size(335, 16)
        Me.labelProductName.TabIndex = 19
        Me.labelProductName.Text = "Product Name"
        Me.labelProductName.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
        Me.labelVersion.Dock = Global.System.Windows.Forms.DockStyle.Fill
        Me.labelVersion.Location = New Global.System.Drawing.Point(12, 16)
        Me.labelVersion.Margin = New Global.System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.labelVersion.MaximumSize = New Global.System.Drawing.Size(0, 17)
        Me.labelVersion.Name = "labelVersion"
        Me.labelVersion.Size = New Global.System.Drawing.Size(335, 16)
        Me.labelVersion.TabIndex = 0
        Me.labelVersion.Text = "Version"
        Me.labelVersion.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
        Me.labelCopyright.Dock = Global.System.Windows.Forms.DockStyle.Fill
        Me.labelCopyright.Location = New Global.System.Drawing.Point(12, 32)
        Me.labelCopyright.Margin = New Global.System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.labelCopyright.MaximumSize = New Global.System.Drawing.Size(0, 17)
        Me.labelCopyright.Name = "labelCopyright"
        Me.labelCopyright.Size = New Global.System.Drawing.Size(335, 16)
        Me.labelCopyright.TabIndex = 21
        Me.labelCopyright.Text = "Copyright"
        Me.labelCopyright.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
        Me.labelCompanyName.Dock = Global.System.Windows.Forms.DockStyle.Fill
        Me.labelCompanyName.Location = New Global.System.Drawing.Point(12, 48)
        Me.labelCompanyName.Margin = New Global.System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.labelCompanyName.MaximumSize = New Global.System.Drawing.Size(0, 17)
        Me.labelCompanyName.Name = "labelCompanyName"
        Me.labelCompanyName.Size = New Global.System.Drawing.Size(335, 16)
        Me.labelCompanyName.TabIndex = 22
        Me.labelCompanyName.Text = "Company Name"
        Me.labelCompanyName.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
        Me.textBoxDescription.Dock = Global.System.Windows.Forms.DockStyle.Fill
        Me.textBoxDescription.Location = New Global.System.Drawing.Point(12, 67)
        Me.textBoxDescription.Margin = New Global.System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.textBoxDescription.Multiline = True
        Me.textBoxDescription.Name = "textBoxDescription"
        Me.textBoxDescription.[ReadOnly] = True
        Me.textBoxDescription.ScrollBars = Global.System.Windows.Forms.ScrollBars.Both
        Me.textBoxDescription.Size = New Global.System.Drawing.Size(335, 74)
        Me.textBoxDescription.TabIndex = 23
        Me.textBoxDescription.TabStop = False
        Me.textBoxDescription.Text = "Description"
        MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6.0F, 13.0F)
        MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
        MyBase.ClientSize = New Global.System.Drawing.Size(368, 179)
        MyBase.Controls.Add(Me.tableLayoutPanel)
        MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
        MyBase.MaximizeBox = False
        MyBase.MinimizeBox = False
        MyBase.Name = "About"
        MyBase.Padding = New Global.System.Windows.Forms.Padding(9)
        MyBase.ShowIcon = False
        MyBase.ShowInTaskbar = False
        MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        Me.tableLayoutPanel.ResumeLayout(False)
        Me.tableLayoutPanel.PerformLayout()
        MyBase.ResumeLayout(False)
    End Sub

    ' Token: 0x0400002E RID: 46
    Private components As Global.System.ComponentModel.IContainer = Nothing
    Friend WithEvents labelProductName As Label
    Friend WithEvents labelVersion As Label
    Friend WithEvents labelCopyright As Label
    Friend WithEvents labelCompanyName As Label
    Friend WithEvents tableLayoutPanel As TableLayoutPanel
    Friend WithEvents textBoxDescription As TextBox

End Class