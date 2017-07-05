<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Columns
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.OkButton = New System.Windows.Forms.Button()
        Me.AnnullaButton = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SpuntaSelezionatiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DespuntaSelezionatiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpuntaTuttiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DespuntaTuttiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvertiSpunteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OkButton
        '
        Me.OkButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OkButton.Location = New System.Drawing.Point(402, 13)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(75, 23)
        Me.OkButton.TabIndex = 1
        Me.OkButton.Text = "&Ok"
        Me.OkButton.UseVisualStyleBackColor = True
        '
        'AnnullaButton
        '
        Me.AnnullaButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AnnullaButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.AnnullaButton.Location = New System.Drawing.Point(402, 42)
        Me.AnnullaButton.Name = "AnnullaButton"
        Me.AnnullaButton.Size = New System.Drawing.Size(75, 23)
        Me.AnnullaButton.TabIndex = 1
        Me.AnnullaButton.Text = "&Annulla"
        Me.AnnullaButton.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.CheckBoxes = True
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.ListView1.Location = New System.Drawing.Point(12, 12)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(384, 262)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.List
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SpuntaSelezionatiToolStripMenuItem, Me.DespuntaSelezionatiToolStripMenuItem, Me.SpuntaTuttiToolStripMenuItem, Me.DespuntaTuttiToolStripMenuItem, Me.InvertiSpunteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(183, 114)
        '
        'SpuntaSelezionatiToolStripMenuItem
        '
        Me.SpuntaSelezionatiToolStripMenuItem.Name = "SpuntaSelezionatiToolStripMenuItem"
        Me.SpuntaSelezionatiToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.SpuntaSelezionatiToolStripMenuItem.Text = "Spunta selezionati"
        '
        'DespuntaSelezionatiToolStripMenuItem
        '
        Me.DespuntaSelezionatiToolStripMenuItem.Name = "DespuntaSelezionatiToolStripMenuItem"
        Me.DespuntaSelezionatiToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.DespuntaSelezionatiToolStripMenuItem.Text = "Despunta selezionati"
        '
        'SpuntaTuttiToolStripMenuItem
        '
        Me.SpuntaTuttiToolStripMenuItem.Name = "SpuntaTuttiToolStripMenuItem"
        Me.SpuntaTuttiToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.SpuntaTuttiToolStripMenuItem.Text = "Spunta tutti"
        '
        'DespuntaTuttiToolStripMenuItem
        '
        Me.DespuntaTuttiToolStripMenuItem.Name = "DespuntaTuttiToolStripMenuItem"
        Me.DespuntaTuttiToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.DespuntaTuttiToolStripMenuItem.Text = "Despunta tutti"
        '
        'InvertiSpunteToolStripMenuItem
        '
        Me.InvertiSpunteToolStripMenuItem.Name = "InvertiSpunteToolStripMenuItem"
        Me.InvertiSpunteToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.InvertiSpunteToolStripMenuItem.Text = "Inverti spunte"
        '
        'Columns
        '
        Me.AcceptButton = Me.OkButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.AnnullaButton
        Me.ClientSize = New System.Drawing.Size(489, 286)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.AnnullaButton)
        Me.Controls.Add(Me.OkButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Columns"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Columns"
        Me.TopMost = True
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OkButton As Button
    Friend WithEvents AnnullaButton As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents SpuntaSelezionatiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DespuntaSelezionatiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SpuntaTuttiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DespuntaTuttiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InvertiSpunteToolStripMenuItem As ToolStripMenuItem
End Class
