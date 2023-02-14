Imports System
Imports System.IO
Imports System.Text

Module Module1
    Sub Main(ByVal args() As String)
        ' Convert multiple HTML to Text files.
        ' If you need more information about "HTML to RTF .Net" 
        ' Email us at: support@sautinsoft.com.
        ConvertMultipleHtmlToText()
    End Sub

    Public Sub ConvertMultipleHtmlToText()
        Dim h As New SautinSoft.HtmlToRtf()

        ' After purchasing the license, please insert your serial number here to activate the component.
        ' h.Serial = "XXXXXXXXX"

        Dim inpFolder As String = "..\..\..\Testing HTMLs\"
        Dim outFolder As String = (New DirectoryInfo(Directory.GetCurrentDirectory())).CreateSubdirectory("Text").FullName
        Dim inpFiles() As String = Directory.GetFiles(inpFolder, "*.htm*")

        Dim total As Integer = inpFiles.Length
        Dim currCount As Integer = 1
        Dim successCount As Integer = 0

        For Each inpFile As String In inpFiles
            Dim fileName As String = Path.GetFileName(inpFile)
            Console.Write("{0:D2} of {1} ... {2}", currCount, total, fileName)
            currCount += 1

            Dim ok As Boolean = True

            If h.OpenHtml(inpFile) Then
                Dim outFile As String = Path.Combine(outFolder, Path.ChangeExtension(fileName, ".txt"))

                If h.ToText(outFile) Then
                    successCount += 1
                Else
                    ok = False
                End If
            Else
                ok = False
            End If

            Console.WriteLine(" ({0})", ok)
        Next inpFile
        Console.WriteLine("{0} of {1} HTML(s) converted successfully!", successCount, total)
        Console.WriteLine("Press any key ...")
        Console.ReadKey()

        ' Open the result for demonstration purposes.
        System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(outFolder) With {.UseShellExecute = True})

    End Sub
End Module
