Imports System.Windows.Forms
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class GNU
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

    ' Token: 0x06000002 RID: 2 RVA: 0x00002088 File Offset: 0x00000288
    Private Sub InitializeComponent()
        Me.button1 = New Global.System.Windows.Forms.Button()
        Me.button2 = New Global.System.Windows.Forms.Button()
        Me.richTextBox1 = New Global.System.Windows.Forms.RichTextBox()
        MyBase.SuspendLayout()
        Me.button1.Location = New Global.System.Drawing.Point(330, 331)
        Me.button1.Name = "button1"
        Me.button1.Size = New Global.System.Drawing.Size(103, 23)
        Me.button1.TabIndex = 0
        Me.button1.Text = "I Do Not Agree"
        Me.button1.UseVisualStyleBackColor = True
        AddHandler Me.button1.Click, AddressOf Me.button1_Click
        Me.button2.Location = New Global.System.Drawing.Point(439, 331)
        Me.button2.Name = "button2"
        Me.button2.Size = New Global.System.Drawing.Size(75, 23)
        Me.button2.TabIndex = 1
        Me.button2.Text = "I Agree"
        Me.button2.UseVisualStyleBackColor = True
        AddHandler Me.button2.Click, AddressOf Me.button2_Click
        Me.richTextBox1.Location = New Global.System.Drawing.Point(12, 12)
        Me.richTextBox1.Name = "richTextBox1"
        Me.richTextBox1.Size = New Global.System.Drawing.Size(502, 313)
        Me.richTextBox1.TabIndex = 2
        Me.richTextBox1.Text = ""
        MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6.0F, 13.0F)
        MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
        MyBase.ClientSize = New Global.System.Drawing.Size(522, 359)
        MyBase.Controls.Add(Me.richTextBox1)
        MyBase.Controls.Add(Me.button2)
        MyBase.Controls.Add(Me.button1)
        MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedToolWindow
        MyBase.Name = "GNU"
        MyBase.ShowIcon = False
        Me.Text = "GNU GPL V3"
        AddHandler MyBase.Load, AddressOf Me.GNU_Load
        MyBase.ResumeLayout(False)
    End Sub

    ' Token: 0x04000001 RID: 1
    Private components As Global.System.ComponentModel.IContainer = Nothing
    Friend WithEvents button1 As Button
    Friend WithEvents button2 As Button
    Friend WithEvents richTextBox1 As RichTextBox
End Class
