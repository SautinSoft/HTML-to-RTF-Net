Imports System
Imports System.IO
Imports SautinSoft
Imports SautinSoft.HtmlToRtf

Namespace Sample
	Friend Class Test

		Shared Sub Main(ByVal args() As String)
			' Get your free key here:   
            ' https://sautinsoft.com/start-for-free/
	
			' Convert HTML file to RTF file.
			' If you need more information about "HTML to RTF .Net" 
			' Email us at: support@sautinsoft.com.
			ConvertHtmlToRtfFile()
		End Sub

		Public Shared Sub ConvertHtmlToRtfFile()
			Dim h As New SautinSoft.HtmlToRtf()
			Dim opt As New HtmlConvertOptions()
			opt.OutputFormat = HtmlToRtf.OutputFormat.Rtf

			Dim inpFile As String = "..\..\..\Sample.html"
			Dim outFile As String = "Result.rtf"

			If h.Convert(inpFile, outFile, opt) Then
				' Open the result for demonstration purposes.
				System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(outFile) With {.UseShellExecute = True})
			End If
		End Sub
	End Class
End Namespace
