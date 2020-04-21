Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
' Token: 0x02000007 RID: 7
Public Module ImageExtension
    ' Token: 0x0600002D RID: 45 RVA: 0x00003B70 File Offset: 0x00001D70
    <System.Runtime.CompilerServices.ExtensionAttribute()>
    Public Function Crop(ByVal image As Image, ByVal selection As Rectangle) As Image
        Dim bitmap As Bitmap = TryCast(image, Bitmap)
        If bitmap Is Nothing Then
            Throw New ArgumentException("Kein gültiges Bild (Bitmap)")
        End If
        Dim result As Bitmap = bitmap.Clone(selection, bitmap.PixelFormat)
        image.Dispose()
        Return result
    End Function

    ' Token: 0x0600002E RID: 46 RVA: 0x00003BB8 File Offset: 0x00001DB8
    <System.Runtime.CompilerServices.ExtensionAttribute()>
    Public Function Fit2PictureBox(ByVal image As Image, ByVal picBox As PictureBox) As Image
        Dim num As Double = CDbl(image.Width) / CDbl(picBox.Width)
        Dim num2 As Double = CDbl(image.Height) / CDbl(picBox.Height)
        Dim num3 As Double = If((num < num2), num2, num)
        Dim bitmap As Bitmap = New Bitmap(CInt((CDbl(image.Width) / num3)), CInt((CDbl(image.Height) / num3)))
        bitmap.SetResolution(image.HorizontalResolution, image.VerticalResolution)
        Dim graphics As Graphics = graphics.FromImage(bitmap)
        graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
        graphics.DrawImage(image, New Rectangle(0, 0, bitmap.Width, bitmap.Height), New Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel)
        graphics.Dispose()
        image.Dispose()
        Return bitmap
    End Function
End Module
