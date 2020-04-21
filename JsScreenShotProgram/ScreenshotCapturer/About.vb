Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms
Public Class About

    ' Token: 0x06000036 RID: 54 RVA: 0x00004040 File Offset: 0x00002240
    Public Sub New()
        InitializeComponent()
        Text = String.Format("About {0} {0}", Me.AssemblyTitle)
        labelProductName.Text = Me.AssemblyProduct
        labelVersion.Text = String.Format("Version {0} {0}", Me.AssemblyVersion)
        labelCopyright.Text = Me.AssemblyCopyright
        labelCompanyName.Text = Me.AssemblyCompany
        textBoxDescription.Text = Me.AssemblyDescription
    End Sub

    ' Token: 0x17000004 RID: 4
    ' (get) Token: 0x06000037 RID: 55 RVA: 0x000040E0 File Offset: 0x000022E0
    Public ReadOnly Property AssemblyTitle As String
        Get
            Dim customAttributes As Object() = Assembly.GetExecutingAssembly().GetCustomAttributes(GetType(AssemblyTitleAttribute), False)
            If customAttributes.Length > 0 Then
                Dim assemblyTitleAttribute As AssemblyTitleAttribute = CType(customAttributes(0), AssemblyTitleAttribute)
                If assemblyTitleAttribute.Title <> "" Then
                    Return assemblyTitleAttribute.Title
                End If
            End If
            Return Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase)
        End Get
    End Property

    ' Token: 0x17000005 RID: 5
    ' (get) Token: 0x06000038 RID: 56 RVA: 0x00004150 File Offset: 0x00002350
    Public ReadOnly Property AssemblyVersion As String
        Get
            Return Assembly.GetExecutingAssembly().GetName().Version.ToString()
        End Get
    End Property

    ' Token: 0x17000006 RID: 6
    ' (get) Token: 0x06000039 RID: 57 RVA: 0x00004178 File Offset: 0x00002378
    Public ReadOnly Property AssemblyDescription As String
        Get
            Dim customAttributes As Object() = Assembly.GetExecutingAssembly().GetCustomAttributes(GetType(AssemblyDescriptionAttribute), False)
            Dim result As String
            If customAttributes.Length = 0 Then
                result = ""
            Else
                result = CType(customAttributes(0), AssemblyDescriptionAttribute).Description
            End If
            Return result
        End Get
    End Property

    ' Token: 0x17000007 RID: 7
    ' (get) Token: 0x0600003A RID: 58 RVA: 0x000041C4 File Offset: 0x000023C4
    Public ReadOnly Property AssemblyProduct As String
        Get
            Dim customAttributes As Object() = Assembly.GetExecutingAssembly().GetCustomAttributes(GetType(AssemblyProductAttribute), False)
            Dim result As String
            If customAttributes.Length = 0 Then
                result = ""
            Else
                result = CType(customAttributes(0), AssemblyProductAttribute).Product
            End If
            Return result
        End Get
    End Property

    ' Token: 0x17000008 RID: 8
    ' (get) Token: 0x0600003B RID: 59 RVA: 0x00004210 File Offset: 0x00002410
    Public ReadOnly Property AssemblyCopyright As String
        Get
            Dim customAttributes As Object() = Assembly.GetExecutingAssembly().GetCustomAttributes(GetType(AssemblyCopyrightAttribute), False)
            Dim result As String
            If customAttributes.Length = 0 Then
                result = ""
            Else
                result = CType(customAttributes(0), AssemblyCopyrightAttribute).Copyright
            End If
            Return result
        End Get
    End Property

    ' Token: 0x17000009 RID: 9
    ' (get) Token: 0x0600003C RID: 60 RVA: 0x0000425C File Offset: 0x0000245C
    Public ReadOnly Property AssemblyCompany As String
        Get
            Dim customAttributes As Object() = Assembly.GetExecutingAssembly().GetCustomAttributes(GetType(AssemblyCompanyAttribute), False)
            Dim result As String
            If customAttributes.Length = 0 Then
                result = ""
            Else
                result = CType(customAttributes(0), AssemblyCompanyAttribute).Company
            End If
            Return result
        End Get
    End Property
End Class
