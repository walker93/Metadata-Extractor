Imports System.ComponentModel
Imports MetadataExtractor
Public Class Form1

    Dim info As New List(Of File)

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim about As New About
        about.Show()
    End Sub

    Private Sub ApriFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApriFileToolStripMenuItem.Click
        Dim dialog = OpenFileDialog1.ShowDialog
        If dialog = DialogResult.OK Then
            Notify.Text = "Caricamento..."
            Dim file_path() = OpenFileDialog1.FileNames
            AddFiles(file_path)
            Notify.Text = "Completato"
        End If
    End Sub

    Public Sub AddFiles(path As String)
        Dim file = New System.IO.FileInfo(path)
        If isSupportedFile(file) Then
            Dim col() = {file.Name, file.DirectoryName}
            Dim item As New ListViewItem(col)
            Dim file_directoris = ImageMetadataReader.ReadMetadata(file.FullName)
            Dim fileMetadata = New File(file.Name, file.FullName, file_directoris)
            ListView1.Items.Add(item)
            'paths.Add(file.FullName)
            info.Add(fileMetadata)
            For Each t In fileMetadata.metadataDic
                If Not headers.Contains(t.Key.Name) Then headers.Add(t.Key.Name)
            Next
            updateItemCount()
            Application.DoEvents()
        Else
            Console.WriteLine("Not supported: " + file.FullName)
        End If
    End Sub
    Public Sub AddFiles(paths As String())
        For Each p In paths
            AddFiles(p)
        Next
    End Sub
    Public Sub AddDirectory(path As String, Optional recursive As Boolean = True)
        If recursive Then
            Dim directories = System.IO.Directory.GetDirectories(path)
            For Each dire In directories
                AddDirectory(dire, recursive)
            Next
        End If
        Dim files = System.IO.Directory.GetFiles(path)
        AddFiles(files)
    End Sub

    Private Sub ApriCartellaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApriCartellaToolStripMenuItem.Click
        Dim dialog = FolderBrowserDialog1.ShowDialog
        If dialog = DialogResult.OK Then
            Notify.Text = "Caricamento..."
            AddDirectory(FolderBrowserDialog1.SelectedPath)
            Notify.Text = "Completato"
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim counter As Integer = 0
        Dim builder As New Text.StringBuilder
        Try
            Dim arg As KeyValuePair(Of String, IEnumerable(Of File)) = e.Argument
            counter = 0
            For Each f In arg.Value
                If BackgroundWorker1.CancellationPending Then Exit Sub
                If IsNothing(selectedColumns) Then selectedColumns = headers
                If selectedColumns.Contains("Name") Then builder.Append(f.name + ";")
                If selectedColumns.Contains("Path") Then builder.Append(f.path + ";")

                For i = 2 To selectedColumns.Length - 1
                    builder.Append(f.getMetadataInfo(selectedColumns(i)) + ";")
                Next
                BackgroundWorker1.ReportProgress(100 * counter / info.Count)
                counter += 1
                builder.AppendLine()
            Next
            System.IO.File.WriteAllText(arg.Key, String.Join(";", selectedColumns) & vbNewLine)
            System.IO.File.AppendAllText(arg.Key, builder.ToString)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EstraiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstraiToolStripMenuItem.Click
        Dim dialog = SaveFileDialog1.ShowDialog
        If dialog = DialogResult.OK Then
            Notify.Text = "Elaboro..."

            BackgroundWorker1.RunWorkerAsync(New KeyValuePair(Of String, IEnumerable(Of File))(SaveFileDialog1.FileName, info))
        End If
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ToolStripProgressBar1.Value = e.ProgressPercentage
        Notify.Text = e.ProgressPercentage.ToString & "%"
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        'MessageBox.Show("Estrazione completata", "Completato", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Notify.Text = "Completato"
        ToolStripProgressBar1.Value = 0
    End Sub

    Private Sub RimuoviSelezionatiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RimuoviSelezionatiToolStripMenuItem.Click
        For Each it As ListViewItem In ListView1.SelectedItems
            ListView1.Items.Remove(it)
        Next
        updateItemCount()
    End Sub

    Private Sub EstraiSelezionatiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstraiSelezionatiToolStripMenuItem.Click
        Dim dialog = SaveFileDialog1.ShowDialog
        If dialog = DialogResult.OK Then
            Notify.Text = "Elaboro..."
            Dim subset As New List(Of File)
            For Each i As ListViewItem In ListView1.SelectedItems
                subset.Add(info(i.Index))
            Next
            BackgroundWorker1.RunWorkerAsync(New KeyValuePair(Of String, IEnumerable(Of File))(SaveFileDialog1.FileName, subset))
        End If
    End Sub

    Private Sub SelezionaTuttoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelezionaTuttoToolStripMenuItem.Click
        For Each i As ListViewItem In ListView1.Items
            i.Selected = True
        Next
    End Sub

    Private Sub DeselezionaTuttoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeselezionaTuttoToolStripMenuItem.Click
        For Each i As ListViewItem In ListView1.Items
            i.Selected = False
        Next
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        updateItemCount()
    End Sub

    Sub updateItemCount()
        elem_num.Text = ListView1.SelectedItems.Count.ToString & "/" & ListView1.Items.Count.ToString
    End Sub

    Private Sub ScegliColonneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScegliColonneToolStripMenuItem.Click
        Dim f As New Columns
        f.Show()
    End Sub

    Private Sub ChiudiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChiudiToolStripMenuItem.Click
        Close()
    End Sub
End Class
