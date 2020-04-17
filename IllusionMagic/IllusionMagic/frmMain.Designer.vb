<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.msMain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenRecentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbPackControl = New System.Windows.Forms.GroupBox()
        Me.gbColorOpacity = New System.Windows.Forms.GroupBox()
        Me.gbMER = New System.Windows.Forms.GroupBox()
        Me.gbNormalsHeight = New System.Windows.Forms.GroupBox()
        Me.lblSelectedBlock = New System.Windows.Forms.Label()
        Me.cbBlock = New System.Windows.Forms.ComboBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtBlockSearch = New System.Windows.Forms.TextBox()
        Me.ManifestCreationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msMain.SuspendLayout()
        Me.gbPackControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'msMain
        '
        Me.msMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.msMain.Location = New System.Drawing.Point(0, 0)
        Me.msMain.Name = "msMain"
        Me.msMain.Size = New System.Drawing.Size(2030, 24)
        Me.msMain.TabIndex = 1
        Me.msMain.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.ToolStripSeparator1, Me.OpenToolStripMenuItem, Me.OpenRecentToolStripMenuItem, Me.ReloadToolStripMenuItem, Me.ToolStripSeparator2, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ToolStripSeparator3, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(139, 6)
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'OpenRecentToolStripMenuItem
        '
        Me.OpenRecentToolStripMenuItem.Name = "OpenRecentToolStripMenuItem"
        Me.OpenRecentToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.OpenRecentToolStripMenuItem.Text = "Open Recent"
        '
        'ReloadToolStripMenuItem
        '
        Me.ReloadToolStripMenuItem.Name = "ReloadToolStripMenuItem"
        Me.ReloadToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ReloadToolStripMenuItem.Text = "Reload"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(139, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(139, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RedoToolStripMenuItem.Text = "Redo"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManifestCreationToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpManualToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'HelpManualToolStripMenuItem
        '
        Me.HelpManualToolStripMenuItem.Name = "HelpManualToolStripMenuItem"
        Me.HelpManualToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.HelpManualToolStripMenuItem.Text = "Help Manual"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'gbPackControl
        '
        Me.gbPackControl.Controls.Add(Me.txtBlockSearch)
        Me.gbPackControl.Controls.Add(Me.lblSearch)
        Me.gbPackControl.Controls.Add(Me.cbBlock)
        Me.gbPackControl.Controls.Add(Me.lblSelectedBlock)
        Me.gbPackControl.Location = New System.Drawing.Point(12, 27)
        Me.gbPackControl.Name = "gbPackControl"
        Me.gbPackControl.Size = New System.Drawing.Size(1000, 500)
        Me.gbPackControl.TabIndex = 2
        Me.gbPackControl.TabStop = False
        Me.gbPackControl.Text = "Pack Control"
        '
        'gbColorOpacity
        '
        Me.gbColorOpacity.Location = New System.Drawing.Point(1018, 27)
        Me.gbColorOpacity.Name = "gbColorOpacity"
        Me.gbColorOpacity.Size = New System.Drawing.Size(1000, 500)
        Me.gbColorOpacity.TabIndex = 3
        Me.gbColorOpacity.TabStop = False
        Me.gbColorOpacity.Text = "Color and Opacity Maps"
        '
        'gbMER
        '
        Me.gbMER.Location = New System.Drawing.Point(12, 533)
        Me.gbMER.Name = "gbMER"
        Me.gbMER.Size = New System.Drawing.Size(1000, 500)
        Me.gbMER.TabIndex = 3
        Me.gbMER.TabStop = False
        Me.gbMER.Text = "Metallic, Emissive and Roughness Maps"
        '
        'gbNormalsHeight
        '
        Me.gbNormalsHeight.Location = New System.Drawing.Point(1018, 533)
        Me.gbNormalsHeight.Name = "gbNormalsHeight"
        Me.gbNormalsHeight.Size = New System.Drawing.Size(1000, 500)
        Me.gbNormalsHeight.TabIndex = 4
        Me.gbNormalsHeight.TabStop = False
        Me.gbNormalsHeight.Text = "Normals/Height Map"
        '
        'lblSelectedBlock
        '
        Me.lblSelectedBlock.AutoSize = True
        Me.lblSelectedBlock.Location = New System.Drawing.Point(6, 39)
        Me.lblSelectedBlock.Name = "lblSelectedBlock"
        Me.lblSelectedBlock.Size = New System.Drawing.Size(85, 13)
        Me.lblSelectedBlock.TabIndex = 0
        Me.lblSelectedBlock.Text = "Selected Block -"
        '
        'cbBlock
        '
        Me.cbBlock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBlock.FormattingEnabled = True
        Me.cbBlock.Items.AddRange(New Object() {"Stone [1_0]", "Granite [1_1]", "Polished Granite [1_2]", "Diorite [1_3]", "Polished Diorite [1_4]", "Andesite [1_5]", "Polished Andesite [1_6]", "Grass Block [2]", "Dirt [3_0]", "Coarse Dirt [3_1]", "Podzol [3_2]", "Cobblestone [4]", "Oak Wood Planks [5_0]", "Spruce Wood Planks [5_1]", "Birch Wood Planks [5_2]", "Jungle Wood Planks [5_3]", "Acacia Wood Planks [5_4]", "Dark Oak Wood Planks [5_5]", "Oak Sapling [6_0]", "Spruce Sapling [6_1]", "Birch Sapling [6_2]", "Jungle Sapling [6_3]", "Acacia Sapling [6_4]", "Dark Oak Sapling [6_5]", "Bedrock [7]", "Water [8]", "Water Source [9]", "Lava [10]", "Lava Source [11]", "Sand [12]", "Gravel [13]"})
        Me.cbBlock.Location = New System.Drawing.Point(6, 64)
        Me.cbBlock.Name = "cbBlock"
        Me.cbBlock.Size = New System.Drawing.Size(192, 21)
        Me.cbBlock.TabIndex = 1
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(222, 39)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(47, 13)
        Me.lblSearch.TabIndex = 2
        Me.lblSearch.Text = "Search -"
        '
        'txtBlockSearch
        '
        Me.txtBlockSearch.Location = New System.Drawing.Point(225, 65)
        Me.txtBlockSearch.Name = "txtBlockSearch"
        Me.txtBlockSearch.Size = New System.Drawing.Size(195, 20)
        Me.txtBlockSearch.TabIndex = 3
        '
        'ManifestCreationToolStripMenuItem
        '
        Me.ManifestCreationToolStripMenuItem.Name = "ManifestCreationToolStripMenuItem"
        Me.ManifestCreationToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ManifestCreationToolStripMenuItem.Text = "Manifest Creation"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2030, 1045)
        Me.Controls.Add(Me.gbNormalsHeight)
        Me.Controls.Add(Me.gbMER)
        Me.Controls.Add(Me.gbColorOpacity)
        Me.Controls.Add(Me.gbPackControl)
        Me.Controls.Add(Me.msMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.msMain
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Illusion Magic"
        Me.msMain.ResumeLayout(False)
        Me.msMain.PerformLayout()
        Me.gbPackControl.ResumeLayout(False)
        Me.gbPackControl.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents msMain As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents gbPackControl As GroupBox
    Friend WithEvents gbColorOpacity As GroupBox
    Friend WithEvents gbMER As GroupBox
    Friend WithEvents gbNormalsHeight As GroupBox
    Friend WithEvents HelpManualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenRecentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReloadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblSelectedBlock As Label
    Friend WithEvents cbBlock As ComboBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtBlockSearch As TextBox
    Friend WithEvents ManifestCreationToolStripMenuItem As ToolStripMenuItem
End Class
