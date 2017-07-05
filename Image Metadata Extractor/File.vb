Public Class File

    Public name As String
    Public path As String
    Public metadataDic As New Dictionary(Of MetadataExtractor.Tag, String)

    Public Sub New(name As String, path As String, metadata As IReadOnlyList(Of MetadataExtractor.Directory))
        Me.name = name
        Me.path = path
        loadMetadata(metadata)
    End Sub

    Public Sub New(name As String, path As String)
        Me.name = name
        Me.path = path
    End Sub

    Public Sub loadMetadata(metadata As IReadOnlyList(Of MetadataExtractor.Directory))
        For Each d In metadata
            For Each i In d.Tags
                metadataDic.Add(i, i.Description)
            Next
        Next

    End Sub

    Public Function getMetadataInfo(tagName As String) As String
        For Each t In metadataDic
            If t.Key.Name = tagName Then
                Return t.Value.Replace(vbLf, "").Replace(vbCrLf, "")
            End If
        Next
        Return ""
    End Function


    Public Function hasTag(tagName As String) As Boolean
        For Each t In metadataDic
            If t.Key.Name = tagName Then Return True
        Next
        Return False
    End Function
End Class
