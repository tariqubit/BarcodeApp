Imports ZXing

Public Class Form1
    Private Sub Btnencode_Click(sender As Object, e As EventArgs) Handles btnencode.Click
        Dim writer As New BarcodeWriter
        writer.Format = BarcodeFormat.CODE_128
        pic.Image = writer.Write(txtencoder.Text)




    End Sub

    Private Sub Btndecode_Click(sender As Object, e As EventArgs) Handles btndecode.Click
        Dim reader As New BarcodeReader
        Dim result = reader.Decode(CType(pic.Image, Bitmap))
        If result IsNot Nothing Then
            txtdecoder.Text = result.Text
        End If



    End Sub
End Class
