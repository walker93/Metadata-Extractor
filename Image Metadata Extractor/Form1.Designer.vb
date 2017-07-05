<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApriCartellaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApriFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChiudiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstraiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.FileName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Path = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SelezionaTuttoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeselezionaTuttoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstraiSelezionatiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RimuoviSelezionatiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.Notify = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.elem_num = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScegliColonneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.ShowNewFolderButton = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Multiselect = True
        Me.OpenFileDialog1.ReadOnlyChecked = True
        Me.OpenFileDialog1.RestoreDirectory = True
        Me.OpenFileDialog1.ShowReadOnly = True
        Me.OpenFileDialog1.SupportMultiDottedExtensions = True
        Me.OpenFileDialog1.Title = "Scegli file"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolStripMenuItem1, Me.EstraiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(712, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApriCartellaToolStripMenuItem, Me.ApriFileToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ChiudiToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ApriCartellaToolStripMenuItem
        '
        Me.ApriCartellaToolStripMenuItem.Name = "ApriCartellaToolStripMenuItem"
        Me.ApriCartellaToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ApriCartellaToolStripMenuItem.Text = "Apri &Cartella"
        '
        'ApriFileToolStripMenuItem
        '
        Me.ApriFileToolStripMenuItem.Name = "ApriFileToolStripMenuItem"
        Me.ApriFileToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ApriFileToolStripMenuItem.Text = "Apri &File"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.AboutToolStripMenuItem.Text = "A&bout"
        '
        'ChiudiToolStripMenuItem
        '
        Me.ChiudiToolStripMenuItem.Name = "ChiudiToolStripMenuItem"
        Me.ChiudiToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ChiudiToolStripMenuItem.Text = "&Esci"
        '
        'EstraiToolStripMenuItem
        '
        Me.EstraiToolStripMenuItem.Name = "EstraiToolStripMenuItem"
        Me.EstraiToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.EstraiToolStripMenuItem.Text = "&Estrai"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'ListView1
        '
        Me.ListView1.AllowDrop = True
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.FileName, Me.Path})
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(0, 24)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(712, 342)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'FileName
        '
        Me.FileName.Text = "Nome File"
        Me.FileName.Width = 200
        '
        'Path
        '
        Me.Path.Text = "Percorso"
        Me.Path.Width = 500
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelezionaTuttoToolStripMenuItem, Me.DeselezionaTuttoToolStripMenuItem, Me.EstraiSelezionatiToolStripMenuItem, Me.RimuoviSelezionatiToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(177, 92)
        '
        'SelezionaTuttoToolStripMenuItem
        '
        Me.SelezionaTuttoToolStripMenuItem.Name = "SelezionaTuttoToolStripMenuItem"
        Me.SelezionaTuttoToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.SelezionaTuttoToolStripMenuItem.Text = "Seleziona tutto"
        '
        'DeselezionaTuttoToolStripMenuItem
        '
        Me.DeselezionaTuttoToolStripMenuItem.Name = "DeselezionaTuttoToolStripMenuItem"
        Me.DeselezionaTuttoToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.DeselezionaTuttoToolStripMenuItem.Text = "Deseleziona tutto"
        '
        'EstraiSelezionatiToolStripMenuItem
        '
        Me.EstraiSelezionatiToolStripMenuItem.Name = "EstraiSelezionatiToolStripMenuItem"
        Me.EstraiSelezionatiToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.EstraiSelezionatiToolStripMenuItem.Text = "Estrai selezionati"
        '
        'RimuoviSelezionatiToolStripMenuItem
        '
        Me.RimuoviSelezionatiToolStripMenuItem.Name = "RimuoviSelezionatiToolStripMenuItem"
        Me.RimuoviSelezionatiToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.RimuoviSelezionatiToolStripMenuItem.Text = "Rimuovi selezionati"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1, Me.Notify, Me.ToolStripStatusLabel1, Me.elem_num})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 369)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(712, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'Notify
        '
        Me.Notify.Name = "Notify"
        Me.Notify.Size = New System.Drawing.Size(70, 17)
        Me.Notify.Text = "Completato"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(56, 17)
        Me.ToolStripStatusLabel1.Text = "Elementi:"
        '
        'elem_num
        '
        Me.elem_num.Name = "elem_num"
        Me.elem_num.Size = New System.Drawing.Size(13, 17)
        Me.elem_num.Text = "0"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "csv"
        Me.SaveFileDialog1.FileName = "report.csv"
        Me.SaveFileDialog1.Filter = "Comma Separated Values|*.csv|Tutti i file|*.*"
        Me.SaveFileDialog1.RestoreDirectory = True
        Me.SaveFileDialog1.Title = "Salva report"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScegliColonneToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(87, 20)
        Me.ToolStripMenuItem1.Text = "&Impostazioni"
        '
        'ScegliColonneToolStripMenuItem
        '
        Me.ScegliColonneToolStripMenuItem.Name = "ScegliColonneToolStripMenuItem"
        Me.ScegliColonneToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ScegliColonneToolStripMenuItem.Text = "&Scegli colonne"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 391)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Metadata Extractor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApriCartellaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApriFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChiudiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ListView1 As ListView
    Friend WithEvents FileName As ColumnHeader
    Friend WithEvents Path As ColumnHeader
    Friend WithEvents EstraiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EstraiSelezionatiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RimuoviSelezionatiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Notify As ToolStripStatusLabel
    Friend WithEvents SelezionaTuttoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeselezionaTuttoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents elem_num As ToolStripStatusLabel
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ScegliColonneToolStripMenuItem As ToolStripMenuItem
End Class
