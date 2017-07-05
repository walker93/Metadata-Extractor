Imports System.ComponentModel
Imports MetadataExtractor
Public Class Form1
    Dim paths As String()
    Dim info As New List(Of KeyValuePair(Of String, IEnumerable(Of Directory)))
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ApriFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApriFileToolStripMenuItem.Click
        Dim dialog = OpenFileDialog1.ShowDialog
        If dialog = DialogResult.OK Then
            Dim file_path() = OpenFileDialog1.FileNames
            For Each p In file_path
                Dim file = New System.IO.FileInfo(p)
                Dim col() = {file.Name, file.DirectoryName}
                Dim item As New ListViewItem(col)
                ListView1.Items.Add(item)
                paths.Add(p)
                Application.DoEvents()
            Next
        End If
    End Sub

    Private Sub ApriCartellaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApriCartellaToolStripMenuItem.Click

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim counter As Integer = 1
        For Each f In paths
            Try
                If BackgroundWorker1.CancellationPending Then Exit Sub
                Dim file_directoris = ImageMetadataReader.ReadMetadata(f)
                info.Add(New KeyValuePair(Of String, IEnumerable(Of Directory))(f, file_directoris))
                BackgroundWorker1.ReportProgress(paths.Length * 100 / counter)
            Catch ex As ImageProcessingException
                Console.WriteLine(ex.Message)
            End Try
        Next
    End Sub

    Private Sub EstraiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstraiToolStripMenuItem.Click
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ToolStripProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        MessageBox.Show("Estrazione completata per {0}", "Completato", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
