Public Class Columns
    Private Sub Columns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each h In headers
            Dim item As New ListViewItem(h)
            If Not IsNothing(selectedColumns) Then
                item.Checked = selectedColumns.Contains(h)
            Else
                item.Checked = True
            End If
            ListView1.Items.Add(item)
        Next
    End Sub

    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        selectedColumns = {}
        For Each i As ListViewItem In ListView1.CheckedItems
            selectedColumns.Add(i.Text)
        Next
        Close()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles AnnullaButton.Click
        Close()
    End Sub

    Private Sub SpuntaTuttiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpuntaTuttiToolStripMenuItem.Click
        For Each i As ListViewItem In ListView1.Items
            i.Checked = True
        Next
    End Sub

    Private Sub DespuntaTuttiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DespuntaTuttiToolStripMenuItem.Click
        For Each i As ListViewItem In ListView1.Items
            i.Checked = False
        Next
    End Sub

    Private Sub SpuntaSelezionatiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpuntaSelezionatiToolStripMenuItem.Click
        For Each i As ListViewItem In ListView1.SelectedItems
            i.Checked = True
        Next
    End Sub

    Private Sub DespuntaSelezionatiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DespuntaSelezionatiToolStripMenuItem.Click
        For Each i As ListViewItem In ListView1.SelectedItems
            i.Checked = False
        Next
    End Sub

    Private Sub InvertiSpunteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvertiSpunteToolStripMenuItem.Click
        For Each i As ListViewItem In ListView1.Items
            i.Checked = Not i.Checked
        Next
    End Sub
End Class