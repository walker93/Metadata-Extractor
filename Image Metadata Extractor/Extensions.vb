Imports System.Runtime.CompilerServices

Module Extensions
    Public headers() As String = {"Name", "Path"}
    Public selectedColumns() As String
    <Extension()>
    Public Sub Add(Of T)(ByRef arr As T(), item As T)
        If arr IsNot Nothing Then
            Array.Resize(arr, arr.Length + 1)
            arr(arr.Length - 1) = item
        Else
            ReDim arr(0)
            arr(0) = item
        End If
    End Sub

    Function isSupportedFile(f As IO.FileInfo) As Boolean
        Dim stream = f.Open(IO.FileMode.Open)
        Dim Identified = MetadataExtractor.Util.FileTypeDetector.DetectFileType(stream)
        stream.Close()
        Dim r = [Enum].IsDefined(GetType(MetadataExtractor.Util.FileType), Identified)
        If r = True AndAlso Identified <> MetadataExtractor.Util.FileType.Unknown Then Return True
        Return False
    End Function



End Module
