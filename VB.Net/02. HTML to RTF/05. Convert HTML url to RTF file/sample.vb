Imports System
Imports System.IO
Imports SautinSoft
Imports SautinSoft.HtmlToRtf

Namespace Sample
	Friend Class Test

		Shared Sub Main(ByVal args() As String)
			' Get your free key here:   
            ' https://sautinsoft.com/start-for-free/
	
			' Convert HTML url to RTF file.
			' If you need more information about "HTML to RTF .Net" 
			' Email us at: support@sautinsoft.com.
			ConvertHtmlUrlToRtfFile()
		End Sub

		Public Shared Sub ConvertHtmlUrlToRtfFile()
			Dim h As New SautinSoft.HtmlToRtf()

			Dim inpFile As String = "https://www.sautinsoft.com/samples/Sample.html"
			Dim outFile As String = "Result.rtf"

			' Specify the 'BaseURL' property that component can find the full path to images, like a: <img src="..\pict.png" and
			' to external css, like a:  <link rel="stylesheet" href="/css/style.css">.
			Dim opt As New HtmlConvertOptions()
			opt.BaseURL = "https://www.sautinsoft.com/samples/"

			If h.Convert(inpFile, outFile, opt) Then
				' Open the result for demonstration purposes.
				System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(outFile) With {.UseShellExecute = True})
			End If
		End Sub
	End Class
End Namespace
