Imports BasicUserControls.Controls
Imports SpydazWebAI_ControlLibrary
Imports SpydazWebAI_ControlLibrary.Controls
Imports VB_IDE.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCompiler
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCompiler))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.ToolStripMainFileControl = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator24 = New System.Windows.Forms.ToolStripSeparator()
        Me.ButtonProject = New System.Windows.Forms.ToolStripDropDownButton()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LosdProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ButtonBuild = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ExecuteToolStripREPL = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DLLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton5 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ProjectNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBoxProjectName = New System.Windows.Forms.ToolStripTextBox()
        Me.MainClassNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBoxMainClassName = New System.Windows.Forms.ToolStripTextBox()
        Me.ExecuteFunctionNAmeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBoxFunctionName = New System.Windows.Forms.ToolStripTextBox()
        Me.SetProgrammingLanguageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBoxProgLang = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator25 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.SpydazWebTabcontrolScripts = New SpydazWebTabcontrol()
        Me.TabPageScript = New System.Windows.Forms.TabPage()
        Me.REPL_SCRIPT = New SpydazWebTextBox()
        Me.SpydazWebLineNumbering1 = New SpydazWebLineNumbering()
        Me.MenuStripScriptTabsEditor = New System.Windows.Forms.MenuStrip()
        Me.ButtonCloseScriptTab = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewConsoleScriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButtonExtensions = New System.Windows.Forms.ToolStripDropDownButton()
        Me.PluginsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvatarsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputDevicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutputDevicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertDesignPatternToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertSnipetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XmlSerializerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XmlDeserializerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BinaryReaderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BinaryWriterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextReaderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextWriterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QueueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HashToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TreeviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OLEDBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileStreamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MDIFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReadURLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModalFormMovementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShareSouceCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator32 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator33 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripScriptDevlopment = New System.Windows.Forms.ToolStrip()
        Me.DevNewToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsoleScriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComponentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PluginToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeviceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputDeviceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsoleAppToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutputDeviceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevOpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DevSaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DevSaveAsToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripButton()
        Me.DevCutToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DevCopyToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DevPasteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DevRedoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DevUndoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.DevPrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DevHelpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DevCutToolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripComboBoxFONTFAMILY = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripComboBoxFONT_SIZE = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.TabControlFileBrowsers = New System.Windows.Forms.TabControl()
        Me.TabPageInteractiveReplScript = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.InteractiveReplScript = New SpydazWebTextBox()
        Me.SpydazWebLineNumbering2 = New SpydazWebLineNumbering()
        Me.ToolStripInteractiveRepl = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonExecuteInteractive = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonClearInteractive = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripTextBoxClassNameInteractive = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripTextBoxFunctionNameInteractive = New System.Windows.Forms.ToolStripTextBox()
        Me.TabPageObjectBrowser = New System.Windows.Forms.TabPage()
        Me.GroupBox38 = New System.Windows.Forms.GroupBox()
        Me.RichTextBoxCompilerInfo = New System.Windows.Forms.RichTextBox()
        Me.GroupBox39 = New System.Windows.Forms.GroupBox()
        Me.TreeViewObjectSyntax = New System.Windows.Forms.TreeView()
        Me.TabPageFileList = New System.Windows.Forms.TabPage()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.ButtonOpenDir = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.ListBoxFileDirectory = New System.Windows.Forms.ListBox()
        Me.TabPageEmbeddedFiles = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckedListBoxEmbeddedFiles = New System.Windows.Forms.CheckedListBox()
        Me.ToolStripEmbeddedFiles = New System.Windows.Forms.ToolStrip()
        Me.AddEmbededFileToolStripMenuItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.RemoveEmbeddedFileToolStripMenuItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearFilesToolStripMenuItem = New System.Windows.Forms.ToolStripButton()
        Me.TabPageAssemblies = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckedListBoxAssemblys = New System.Windows.Forms.CheckedListBox()
        Me.ToolStripAssemblies = New System.Windows.Forms.ToolStrip()
        Me.AddAssemblyToolStripMenuItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.RemoveAssemblyToolStripMenuItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearAssemblyToolStripMenuItem = New System.Windows.Forms.ToolStripButton()
        Me.TabPagePlugins = New System.Windows.Forms.TabPage()
        Me.GroupBox30 = New System.Windows.Forms.GroupBox()
        Me.CheckedListLoadedPlugins = New System.Windows.Forms.CheckedListBox()
        Me.TabPageUpdates = New System.Windows.Forms.TabPage()
        Me.GroupBox32 = New System.Windows.Forms.GroupBox()
        Me.CheckedUpdates = New System.Windows.Forms.CheckedListBox()
        Me.TabPageDevices = New System.Windows.Forms.TabPage()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox34 = New System.Windows.Forms.GroupBox()
        Me.ListBoxInputDevices = New System.Windows.Forms.ListBox()
        Me.GroupBox35 = New System.Windows.Forms.GroupBox()
        Me.ListBoxOutputDevices = New System.Windows.Forms.ListBox()
        Me.TabPageAvatars = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.ListBoxAvatars = New System.Windows.Forms.ListBox()
        Me.TabPanelControlBar = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButtonTabControl = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SDKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PluginsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdatesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvatarsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssemblysToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmbededFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InteractiveREPLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.ToolStripMainFileControl.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SpydazWebTabcontrolScripts.SuspendLayout()
        Me.TabPageScript.SuspendLayout()
        Me.MenuStripScriptTabsEditor.SuspendLayout()
        Me.ToolStripScriptDevlopment.SuspendLayout()
        Me.TabControlFileBrowsers.SuspendLayout()
        Me.TabPageInteractiveReplScript.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.ToolStripInteractiveRepl.SuspendLayout()
        Me.TabPageObjectBrowser.SuspendLayout()
        Me.GroupBox38.SuspendLayout()
        Me.GroupBox39.SuspendLayout()
        Me.TabPageFileList.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TabPageEmbeddedFiles.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStripEmbeddedFiles.SuspendLayout()
        Me.TabPageAssemblies.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStripAssemblies.SuspendLayout()
        Me.TabPagePlugins.SuspendLayout()
        Me.GroupBox30.SuspendLayout()
        Me.TabPageUpdates.SuspendLayout()
        Me.GroupBox32.SuspendLayout()
        Me.TabPageDevices.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.GroupBox34.SuspendLayout()
        Me.GroupBox35.SuspendLayout()
        Me.TabPageAvatars.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabPanelControlBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackgroundImage = Global.VB_IDE.My.Resources.Resources.App_Texturex16
        Me.SplitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControlFileBrowsers)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabPanelControlBar)
        Me.SplitContainer1.Size = New System.Drawing.Size(1782, 656)
        Me.SplitContainer1.SplitterDistance = 1117
        Me.SplitContainer1.SplitterWidth = 6
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.BackgroundImage = Global.VB_IDE.My.Resources.Resources.BackGround_BluPrint
        Me.SplitContainer2.Panel1.Controls.Add(Me.ToolStripMainFileControl)
        Me.SplitContainer2.Panel1.Font = New System.Drawing.Font("Berkeley Oldstyle", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox3)
        Me.SplitContainer2.Size = New System.Drawing.Size(1117, 656)
        Me.SplitContainer2.SplitterDistance = 99
        Me.SplitContainer2.SplitterWidth = 5
        Me.SplitContainer2.TabIndex = 0
        '
        'ToolStripMainFileControl
        '
        Me.ToolStripMainFileControl.BackColor = System.Drawing.Color.Silver
        Me.ToolStripMainFileControl.BackgroundImage = Global.VB_IDE.My.Resources.Resources.App_Texturex15
        Me.ToolStripMainFileControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripMainFileControl.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStripMainFileControl.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator24, Me.ButtonProject, Me.ToolStripSeparator2, Me.ButtonBuild, Me.ToolStripSeparator1, Me.ToolStripDropDownButton5, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripSeparator25})
        Me.ToolStripMainFileControl.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripMainFileControl.Name = "ToolStripMainFileControl"
        Me.ToolStripMainFileControl.Size = New System.Drawing.Size(1117, 39)
        Me.ToolStripMainFileControl.Stretch = True
        Me.ToolStripMainFileControl.TabIndex = 11
        Me.ToolStripMainFileControl.Text = "Application"
        '
        'ToolStripSeparator24
        '
        Me.ToolStripSeparator24.Name = "ToolStripSeparator24"
        Me.ToolStripSeparator24.Size = New System.Drawing.Size(6, 39)
        '
        'ButtonProject
        '
        Me.ButtonProject.BackgroundImage = Global.VB_IDE.My.Resources.Resources.App_Texturex17
        Me.ButtonProject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonProject.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.LosdProjectToolStripMenuItem, Me.SaveProjectToolStripMenuItem})
        Me.ButtonProject.ForeColor = System.Drawing.Color.Black
        Me.ButtonProject.Image = Global.VB_IDE.My.Resources.Resources.App_Group
        Me.ButtonProject.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonProject.Name = "ButtonProject"
        Me.ButtonProject.Size = New System.Drawing.Size(89, 36)
        Me.ButtonProject.Text = "Project"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.BackgroundImage = CType(resources.GetObject("NewToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.NewToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NewToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.NewToolStripMenuItem.Image = Global.VB_IDE.My.Resources.Resources.APP_icon_filenew
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(156, 38)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'LosdProjectToolStripMenuItem
        '
        Me.LosdProjectToolStripMenuItem.BackgroundImage = CType(resources.GetObject("LosdProjectToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.LosdProjectToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LosdProjectToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.LosdProjectToolStripMenuItem.Image = Global.VB_IDE.My.Resources.Resources.APP_icon_fileopen
        Me.LosdProjectToolStripMenuItem.Name = "LosdProjectToolStripMenuItem"
        Me.LosdProjectToolStripMenuItem.Size = New System.Drawing.Size(156, 38)
        Me.LosdProjectToolStripMenuItem.Text = "Load Project"
        '
        'SaveProjectToolStripMenuItem
        '
        Me.SaveProjectToolStripMenuItem.BackgroundImage = CType(resources.GetObject("SaveProjectToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.SaveProjectToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SaveProjectToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SaveProjectToolStripMenuItem.Image = Global.VB_IDE.My.Resources.Resources.APP_icon_filesave
        Me.SaveProjectToolStripMenuItem.Name = "SaveProjectToolStripMenuItem"
        Me.SaveProjectToolStripMenuItem.Size = New System.Drawing.Size(156, 38)
        Me.SaveProjectToolStripMenuItem.Text = "Save Project"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'ButtonBuild
        '
        Me.ButtonBuild.BackColor = System.Drawing.Color.Transparent
        Me.ButtonBuild.BackgroundImage = Global.VB_IDE.My.Resources.Resources.App_Texturex17
        Me.ButtonBuild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonBuild.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExecuteToolStripREPL, Me.ToolStripMenuItem2})
        Me.ButtonBuild.ForeColor = System.Drawing.Color.Black
        Me.ButtonBuild.Image = Global.VB_IDE.My.Resources.Resources.App_Compile
        Me.ButtonBuild.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonBuild.Name = "ButtonBuild"
        Me.ButtonBuild.Size = New System.Drawing.Size(79, 36)
        Me.ButtonBuild.Text = "Build"
        '
        'ExecuteToolStripREPL
        '
        Me.ExecuteToolStripREPL.BackgroundImage = CType(resources.GetObject("ExecuteToolStripREPL.BackgroundImage"), System.Drawing.Image)
        Me.ExecuteToolStripREPL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ExecuteToolStripREPL.ForeColor = System.Drawing.Color.White
        Me.ExecuteToolStripREPL.Image = Global.VB_IDE.My.Resources.Resources.APP_icon_Run
        Me.ExecuteToolStripREPL.Name = "ExecuteToolStripREPL"
        Me.ExecuteToolStripREPL.Size = New System.Drawing.Size(175, 38)
        Me.ExecuteToolStripREPL.Text = "Run Project"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.BackgroundImage = CType(resources.GetObject("ToolStripMenuItem2.BackgroundImage"), System.Drawing.Image)
        Me.ToolStripMenuItem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExeToolStripMenuItem, Me.DLLToolStripMenuItem})
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem2.Image = Global.VB_IDE.My.Resources.Resources.APP_icon_Complie
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(175, 38)
        Me.ToolStripMenuItem2.Text = "Compile Project"
        '
        'ExeToolStripMenuItem
        '
        Me.ExeToolStripMenuItem.Image = Global.VB_IDE.My.Resources.Resources.APP_icon_SucessBuild
        Me.ExeToolStripMenuItem.Name = "ExeToolStripMenuItem"
        Me.ExeToolStripMenuItem.Size = New System.Drawing.Size(110, 38)
        Me.ExeToolStripMenuItem.Text = "EXE"
        '
        'DLLToolStripMenuItem
        '
        Me.DLLToolStripMenuItem.Image = Global.VB_IDE.My.Resources.Resources.APP_icon_UnsucessBuild
        Me.DLLToolStripMenuItem.Name = "DLLToolStripMenuItem"
        Me.DLLToolStripMenuItem.Size = New System.Drawing.Size(110, 38)
        Me.DLLToolStripMenuItem.Text = "DLL"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripDropDownButton5
        '
        Me.ToolStripDropDownButton5.BackColor = System.Drawing.Color.Silver
        Me.ToolStripDropDownButton5.BackgroundImage = Global.VB_IDE.My.Resources.Resources.App_Texturex17
        Me.ToolStripDropDownButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripDropDownButton5.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProjectNameToolStripMenuItem, Me.MainClassNameToolStripMenuItem, Me.ExecuteFunctionNAmeToolStripMenuItem, Me.SetProgrammingLanguageToolStripMenuItem})
        Me.ToolStripDropDownButton5.Image = Global.VB_IDE.My.Resources.Resources.APP_Tools
        Me.ToolStripDropDownButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton5.Name = "ToolStripDropDownButton5"
        Me.ToolStripDropDownButton5.Size = New System.Drawing.Size(134, 36)
        Me.ToolStripDropDownButton5.Text = "Project Settings"
        '
        'ProjectNameToolStripMenuItem
        '
        Me.ProjectNameToolStripMenuItem.BackgroundImage = CType(resources.GetObject("ProjectNameToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.ProjectNameToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ProjectNameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBoxProjectName})
        Me.ProjectNameToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ProjectNameToolStripMenuItem.Image = Global.VB_IDE.My.Resources.Resources.fileIconTextEdit
        Me.ProjectNameToolStripMenuItem.Name = "ProjectNameToolStripMenuItem"
        Me.ProjectNameToolStripMenuItem.Size = New System.Drawing.Size(238, 38)
        Me.ProjectNameToolStripMenuItem.Text = "Project Name"
        '
        'ToolStripTextBoxProjectName
        '
        Me.ToolStripTextBoxProjectName.BackColor = System.Drawing.Color.LavenderBlush
        Me.ToolStripTextBoxProjectName.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBoxProjectName.Name = "ToolStripTextBoxProjectName"
        Me.ToolStripTextBoxProjectName.Size = New System.Drawing.Size(300, 28)
        '
        'MainClassNameToolStripMenuItem
        '
        Me.MainClassNameToolStripMenuItem.BackgroundImage = CType(resources.GetObject("MainClassNameToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.MainClassNameToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainClassNameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBoxMainClassName})
        Me.MainClassNameToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MainClassNameToolStripMenuItem.Image = Global.VB_IDE.My.Resources.Resources.fileIconTextEdit
        Me.MainClassNameToolStripMenuItem.Name = "MainClassNameToolStripMenuItem"
        Me.MainClassNameToolStripMenuItem.Size = New System.Drawing.Size(238, 38)
        Me.MainClassNameToolStripMenuItem.Text = "Main ClassName"
        '
        'ToolStripTextBoxMainClassName
        '
        Me.ToolStripTextBoxMainClassName.BackColor = System.Drawing.Color.LavenderBlush
        Me.ToolStripTextBoxMainClassName.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBoxMainClassName.Name = "ToolStripTextBoxMainClassName"
        Me.ToolStripTextBoxMainClassName.Size = New System.Drawing.Size(200, 28)
        Me.ToolStripTextBoxMainClassName.Text = "Test"
        '
        'ExecuteFunctionNAmeToolStripMenuItem
        '
        Me.ExecuteFunctionNAmeToolStripMenuItem.BackgroundImage = CType(resources.GetObject("ExecuteFunctionNAmeToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.ExecuteFunctionNAmeToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ExecuteFunctionNAmeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBoxFunctionName})
        Me.ExecuteFunctionNAmeToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ExecuteFunctionNAmeToolStripMenuItem.Image = Global.VB_IDE.My.Resources.Resources.fileIconTextEdit
        Me.ExecuteFunctionNAmeToolStripMenuItem.Name = "ExecuteFunctionNAmeToolStripMenuItem"
        Me.ExecuteFunctionNAmeToolStripMenuItem.Size = New System.Drawing.Size(238, 38)
        Me.ExecuteFunctionNAmeToolStripMenuItem.Text = "Execute FunctionName"
        '
        'ToolStripTextBoxFunctionName
        '
        Me.ToolStripTextBoxFunctionName.BackColor = System.Drawing.Color.LavenderBlush
        Me.ToolStripTextBoxFunctionName.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBoxFunctionName.Name = "ToolStripTextBoxFunctionName"
        Me.ToolStripTextBoxFunctionName.Size = New System.Drawing.Size(200, 28)
        Me.ToolStripTextBoxFunctionName.Text = "ExecuteCode"
        '
        'SetProgrammingLanguageToolStripMenuItem
        '
        Me.SetProgrammingLanguageToolStripMenuItem.BackgroundImage = CType(resources.GetObject("SetProgrammingLanguageToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.SetProgrammingLanguageToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SetProgrammingLanguageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBoxProgLang})
        Me.SetProgrammingLanguageToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SetProgrammingLanguageToolStripMenuItem.Image = Global.VB_IDE.My.Resources.Resources.fileIconTextEdit
        Me.SetProgrammingLanguageToolStripMenuItem.Name = "SetProgrammingLanguageToolStripMenuItem"
        Me.SetProgrammingLanguageToolStripMenuItem.Size = New System.Drawing.Size(238, 38)
        Me.SetProgrammingLanguageToolStripMenuItem.Text = "Set Programming Language"
        '
        'ToolStripComboBoxProgLang
        '
        Me.ToolStripComboBoxProgLang.AutoCompleteCustomSource.AddRange(New String() {"VisualBasic"})
        Me.ToolStripComboBoxProgLang.BackColor = System.Drawing.Color.LavenderBlush
        Me.ToolStripComboBoxProgLang.Items.AddRange(New Object() {"Visual Basic", "C#"})
        Me.ToolStripComboBoxProgLang.Name = "ToolStripComboBoxProgLang"
        Me.ToolStripComboBoxProgLang.Size = New System.Drawing.Size(200, 23)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.BackgroundImage = Global.VB_IDE.My.Resources.Resources.App_Texturex17
        Me.ToolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripButton1.Image = Global.VB_IDE.My.Resources.Resources.App_Info
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(68, 36)
        Me.ToolStripButton1.Text = "Help"
        '
        'ToolStripSeparator25
        '
        Me.ToolStripSeparator25.Name = "ToolStripSeparator25"
        Me.ToolStripSeparator25.Size = New System.Drawing.Size(6, 39)
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Silver
        Me.GroupBox3.BackgroundImage = Global.VB_IDE.My.Resources.Resources.App_Texturex16
        Me.GroupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox3.Controls.Add(Me.SpydazWebTabcontrolScripts)
        Me.GroupBox3.Controls.Add(Me.MenuStripScriptTabsEditor)
        Me.GroupBox3.Controls.Add(Me.ToolStripScriptDevlopment)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Linen
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Size = New System.Drawing.Size(1117, 552)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Loaded Project"
        '
        'SpydazWebTabcontrolScripts
        '
        Me.SpydazWebTabcontrolScripts.Controls.Add(Me.TabPageScript)
        Me.SpydazWebTabcontrolScripts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SpydazWebTabcontrolScripts.Location = New System.Drawing.Point(4, 90)
        Me.SpydazWebTabcontrolScripts.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SpydazWebTabcontrolScripts.Name = "SpydazWebTabcontrolScripts"
        Me.SpydazWebTabcontrolScripts.SelectedIndex = 0
        Me.SpydazWebTabcontrolScripts.Size = New System.Drawing.Size(1109, 459)
        Me.SpydazWebTabcontrolScripts.TabIndex = 18
        '
        'TabPageScript
        '
        Me.TabPageScript.Controls.Add(Me.REPL_SCRIPT)
        Me.TabPageScript.Controls.Add(Me.SpydazWebLineNumbering1)
        Me.TabPageScript.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageScript.Location = New System.Drawing.Point(4, 28)
        Me.TabPageScript.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPageScript.Name = "TabPageScript"
        Me.TabPageScript.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPageScript.Size = New System.Drawing.Size(1101, 427)
        Me.TabPageScript.TabIndex = 0
        Me.TabPageScript.Text = "REPL"
        Me.TabPageScript.UseVisualStyleBackColor = True
        '
        'REPL_SCRIPT
        '
        Me.REPL_SCRIPT.BackColor = System.Drawing.Color.Ivory
        Me.REPL_SCRIPT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.REPL_SCRIPT.Font = New System.Drawing.Font("Courier", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REPL_SCRIPT.Location = New System.Drawing.Point(48, 3)
        Me.REPL_SCRIPT.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.REPL_SCRIPT.MySyntax = CType(resources.GetObject("REPL_SCRIPT.MySyntax"), System.Collections.Generic.List(Of String))
        Me.REPL_SCRIPT.Name = "REPL_SCRIPT"
        Me.REPL_SCRIPT.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.REPL_SCRIPT.Size = New System.Drawing.Size(1049, 421)
        Me.REPL_SCRIPT.TabIndex = 2
        Me.REPL_SCRIPT.Text = "Imports System" & Global.Microsoft.VisualBasic.ChrW(10) & "Imports system.windows.forms" & Global.Microsoft.VisualBasic.ChrW(10) & "Public Class Test" & Global.Microsoft.VisualBasic.ChrW(10) & "   Public Function " &
    "ExecuteCode()" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Console.WriteLine(""Hello"")" & Global.Microsoft.VisualBasic.ChrW(10) & "MessageBox.Show(""Welcome"")" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "    End Fu" &
    "nction" & Global.Microsoft.VisualBasic.ChrW(10) & "End Class" & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SpydazWebLineNumbering1
        '
        Me.SpydazWebLineNumbering1._SeeThroughMode_ = False
        Me.SpydazWebLineNumbering1.AutoSizing = True
        Me.SpydazWebLineNumbering1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SpydazWebLineNumbering1.BackgroundGradient_AlphaColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SpydazWebLineNumbering1.BackgroundGradient_BetaColor = System.Drawing.Color.Black
        Me.SpydazWebLineNumbering1.BackgroundGradient_Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.SpydazWebLineNumbering1.BorderLines_Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SpydazWebLineNumbering1.BorderLines_Style = System.Drawing.Drawing2D.DashStyle.Dot
        Me.SpydazWebLineNumbering1.BorderLines_Thickness = 1.0!
        Me.SpydazWebLineNumbering1.Dock = System.Windows.Forms.DockStyle.Left
        Me.SpydazWebLineNumbering1.DockSide = SpydazWebLineNumbering.LineNumberDockSide.Left
        Me.SpydazWebLineNumbering1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SpydazWebLineNumbering1.GridLines_Color = System.Drawing.Color.Black
        Me.SpydazWebLineNumbering1.GridLines_Style = System.Drawing.Drawing2D.DashStyle.Solid
        Me.SpydazWebLineNumbering1.GridLines_Thickness = 1.0!
        Me.SpydazWebLineNumbering1.LineNrs_Alignment = System.Drawing.ContentAlignment.TopRight
        Me.SpydazWebLineNumbering1.LineNrs_AntiAlias = True
        Me.SpydazWebLineNumbering1.LineNrs_AsHexadecimal = False
        Me.SpydazWebLineNumbering1.LineNrs_ClippedByItemRectangle = True
        Me.SpydazWebLineNumbering1.LineNrs_LeadingZeroes = True
        Me.SpydazWebLineNumbering1.LineNrs_Offset = New System.Drawing.Size(0, 0)
        Me.SpydazWebLineNumbering1.Location = New System.Drawing.Point(4, 3)
        Me.SpydazWebLineNumbering1.Margin = New System.Windows.Forms.Padding(0)
        Me.SpydazWebLineNumbering1.MarginLines_Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SpydazWebLineNumbering1.MarginLines_Side = SpydazWebLineNumbering.LineNumberDockSide.Right
        Me.SpydazWebLineNumbering1.MarginLines_Style = System.Drawing.Drawing2D.DashStyle.Solid
        Me.SpydazWebLineNumbering1.MarginLines_Thickness = 1.0!
        Me.SpydazWebLineNumbering1.Name = "SpydazWebLineNumbering1"
        Me.SpydazWebLineNumbering1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.SpydazWebLineNumbering1.ParentRichTextBox = Me.REPL_SCRIPT
        Me.SpydazWebLineNumbering1.Show_BackgroundGradient = True
        Me.SpydazWebLineNumbering1.Show_BorderLines = True
        Me.SpydazWebLineNumbering1.Show_GridLines = True
        Me.SpydazWebLineNumbering1.Show_LineNrs = True
        Me.SpydazWebLineNumbering1.Show_MarginLines = True
        Me.SpydazWebLineNumbering1.Size = New System.Drawing.Size(44, 421)
        Me.SpydazWebLineNumbering1.TabIndex = 1
        '
        'MenuStripScriptTabsEditor
        '
        Me.MenuStripScriptTabsEditor.BackColor = System.Drawing.Color.Black
        Me.MenuStripScriptTabsEditor.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStripScriptTabsEditor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ButtonCloseScriptTab, Me.CreateFileToolStripMenuItem, Me.InsertDesignPatternToolStripMenuItem})
        Me.MenuStripScriptTabsEditor.Location = New System.Drawing.Point(4, 61)
        Me.MenuStripScriptTabsEditor.Name = "MenuStripScriptTabsEditor"
        Me.MenuStripScriptTabsEditor.Size = New System.Drawing.Size(1109, 29)
        Me.MenuStripScriptTabsEditor.TabIndex = 17
        Me.MenuStripScriptTabsEditor.Text = "MenuStrip1"
        '
        'ButtonCloseScriptTab
        '
        Me.ButtonCloseScriptTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonCloseScriptTab.BackgroundImage = Global.VB_IDE.My.Resources.Resources.App_Texturex17
        Me.ButtonCloseScriptTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonCloseScriptTab.ForeColor = System.Drawing.Color.Black
        Me.ButtonCloseScriptTab.Image = Global.VB_IDE.My.Resources.Resources.App_Close
        Me.ButtonCloseScriptTab.Name = "ButtonCloseScriptTab"
        Me.ButtonCloseScriptTab.Size = New System.Drawing.Size(89, 25)
        Me.ButtonCloseScriptTab.Text = "Close Tab"
        '
        'CreateFileToolStripMenuItem
        '
        Me.CreateFileToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.CreateFileToolStripMenuItem.BackgroundImage = Global.VB_IDE.My.Resources.Resources.App_Texturex17
        Me.CreateFileToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CreateFileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewConsoleScriptToolStripMenuItem, Me.ToolStripButtonExtensions})
        Me.CreateFileToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.CreateFileToolStripMenuItem.Image = Global.VB_IDE.My.Resources.Resources.FileIcon_Generic_Document
        Me.CreateFileToolStripMenuItem.Name = "CreateFileToolStripMenuItem"
        Me.CreateFileToolStripMenuItem.Size = New System.Drawing.Size(94, 25)
        Me.CreateFileToolStripMenuItem.Text = "Create File"
        '
        'NewConsoleScriptToolStripMenuItem
        '
        Me.NewConsoleScriptToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.NewConsoleScriptToolStripMenuItem.BackgroundImage = CType(resources.GetObject("NewConsoleScriptToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.NewConsoleScriptToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NewConsoleScriptToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.NewConsoleScriptToolStripMenuItem.Image = Global.VB_IDE.My.Resources.Resources.FileIcon_Generic_Document
        Me.NewConsoleScriptToolStripMenuItem.Name = "NewConsoleScriptToolStripMenuItem"
        Me.NewConsoleScriptToolStripMenuItem.ShowShortcutKeys = False
        Me.NewConsoleScriptToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
        Me.NewConsoleScriptToolStripMenuItem.Text = "New Console Script"
        '
        'ToolStripButtonExtensions
        '
        Me.ToolStripButtonExtensions.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ToolStripButtonExtensions.BackgroundImage = CType(resources.GetObject("ToolStripButtonExtensions.BackgroundImage"), System.Drawing.Image)
        Me.ToolStripButtonExtensions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripButtonExtensions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PluginsToolStripMenuItem, Me.UpdatesToolStripMenuItem, Me.AvatarsToolStripMenuItem, Me.InputDevicesToolStripMenuItem, Me.OutputDevicesToolStripMenuItem, Me.ToolStripMenuItem3})
        Me.ToolStripButtonExtensions.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButtonExtensions.ForeColor = System.Drawing.Color.White
        Me.ToolStripButtonExtensions.Image = Global.VB_IDE.My.Resources.Resources.FileIcon_siri
        Me.ToolStripButtonExtensions.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonExtensions.Name = "ToolStripButtonExtensions"
        Me.ToolStripButtonExtensions.Size = New System.Drawing.Size(137, 25)
        Me.ToolStripButtonExtensions.Text = "AI Extension"
        Me.ToolStripButtonExtensions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PluginsToolStripMenuItem
        '
        Me.PluginsToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.PluginsToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow
        Me.PluginsToolStripMenuItem.Image = CType(resources.GetObject("PluginsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PluginsToolStripMenuItem.Name = "PluginsToolStripMenuItem"
        Me.PluginsToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.PluginsToolStripMenuItem.Text = "Plugins"
        '
        'UpdatesToolStripMenuItem
        '
        Me.UpdatesToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.UpdatesToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow
        Me.UpdatesToolStripMenuItem.Image = CType(resources.GetObject("UpdatesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UpdatesToolStripMenuItem.Name = "UpdatesToolStripMenuItem"
        Me.UpdatesToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.UpdatesToolStripMenuItem.Text = "Updates"
        '
        'AvatarsToolStripMenuItem
        '
        Me.AvatarsToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.AvatarsToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow
        Me.AvatarsToolStripMenuItem.Image = CType(resources.GetObject("AvatarsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AvatarsToolStripMenuItem.Name = "AvatarsToolStripMenuItem"
        Me.AvatarsToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.AvatarsToolStripMenuItem.Text = "Avatars"
        '
        'InputDevicesToolStripMenuItem
        '
        Me.InputDevicesToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.InputDevicesToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow
        Me.InputDevicesToolStripMenuItem.Image = CType(resources.GetObject("InputDevicesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.InputDevicesToolStripMenuItem.Name = "InputDevicesToolStripMenuItem"
        Me.InputDevicesToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.InputDevicesToolStripMenuItem.Text = "Input Devices"
        '
        'OutputDevicesToolStripMenuItem
        '
        Me.OutputDevicesToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.OutputDevicesToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow
        Me.OutputDevicesToolStripMenuItem.Image = CType(resources.GetObject("OutputDevicesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OutputDevicesToolStripMenuItem.Name = "OutputDevicesToolStripMenuItem"
        Me.OutputDevicesToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.OutputDevicesToolStripMenuItem.Text = "Output Devices"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.BackColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem3.ForeColor = System.Drawing.Color.Yellow
        Me.ToolStripMenuItem3.Image = CType(resources.GetObject("ToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(190, 26)
        Me.ToolStripMenuItem3.Text = "Test"
        '
        'InsertDesignPatternToolStripMenuItem
        '
        Me.InsertDesignPatternToolStripMenuItem.BackgroundImage = CType(resources.GetObject("InsertDesignPatternToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.InsertDesignPatternToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.InsertDesignPatternToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertSnipetToolStripMenuItem, Me.ToolStripMenuItem4})
        Me.InsertDesignPatternToolStripMenuItem.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InsertDesignPatternToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.InsertDesignPatternToolStripMenuItem.Image = CType(resources.GetObject("InsertDesignPatternToolStripMenuItem.Image"), System.Drawing.Image)
        Me.InsertDesignPatternToolStripMenuItem.Name = "InsertDesignPatternToolStripMenuItem"
        Me.InsertDesignPatternToolStripMenuItem.Size = New System.Drawing.Size(128, 25)
        Me.InsertDesignPatternToolStripMenuItem.Text = "Insert Code"
        '
        'InsertSnipetToolStripMenuItem
        '
        Me.InsertSnipetToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.InsertSnipetToolStripMenuItem.BackgroundImage = CType(resources.GetObject("InsertSnipetToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.InsertSnipetToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.InsertSnipetToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.XmlSerializerToolStripMenuItem, Me.XmlDeserializerToolStripMenuItem, Me.BinaryReaderToolStripMenuItem, Me.BinaryWriterToolStripMenuItem, Me.TextReaderToolStripMenuItem, Me.TextWriterToolStripMenuItem, Me.QueueToolStripMenuItem, Me.HashToolStripMenuItem, Me.StackToolStripMenuItem, Me.TreeviewToolStripMenuItem, Me.OLEDBToolStripMenuItem, Me.FileStreamToolStripMenuItem, Me.MDIFormToolStripMenuItem, Me.ReadURLToolStripMenuItem, Me.ModalFormMovementToolStripMenuItem, Me.ShareSouceCodeToolStripMenuItem})
        Me.InsertSnipetToolStripMenuItem.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InsertSnipetToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.InsertSnipetToolStripMenuItem.Image = CType(resources.GetObject("InsertSnipetToolStripMenuItem.Image"), System.Drawing.Image)
        Me.InsertSnipetToolStripMenuItem.Name = "InsertSnipetToolStripMenuItem"
        Me.InsertSnipetToolStripMenuItem.Size = New System.Drawing.Size(202, 26)
        Me.InsertSnipetToolStripMenuItem.Text = "Insert Snipit"
        '
        'XmlSerializerToolStripMenuItem
        '
        Me.XmlSerializerToolStripMenuItem.BackgroundImage = CType(resources.GetObject("XmlSerializerToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.XmlSerializerToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGray
        Me.XmlSerializerToolStripMenuItem.Image = CType(resources.GetObject("XmlSerializerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.XmlSerializerToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.XmlSerializerToolStripMenuItem.Name = "XmlSerializerToolStripMenuItem"
        Me.XmlSerializerToolStripMenuItem.Size = New System.Drawing.Size(243, 26)
        Me.XmlSerializerToolStripMenuItem.Text = "XmlSerializer"
        '
        'XmlDeserializerToolStripMenuItem
        '
        Me.XmlDeserializerToolStripMenuItem.BackgroundImage = CType(resources.GetObject("XmlDeserializerToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.XmlDeserializerToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGray
        Me.XmlDeserializerToolStripMenuItem.Image = CType(resources.GetObject("XmlDeserializerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.XmlDeserializerToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.XmlDeserializerToolStripMenuItem.Name = "XmlDeserializerToolStripMenuItem"
        Me.XmlDeserializerToolStripMenuItem.Size = New System.Drawing.Size(243, 26)
        Me.XmlDeserializerToolStripMenuItem.Text = "XmlDeserializer"
        '
        'BinaryReaderToolStripMenuItem
        '
        Me.BinaryReaderToolStripMenuItem.BackgroundImage = CType(resources.GetObject("BinaryReaderToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.BinaryReaderToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGray
        Me.BinaryReaderToolStripMenuItem.Image = CType(resources.GetObject("BinaryReaderToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BinaryReaderToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BinaryReaderToolStripMenuItem.Name = "BinaryReaderToolStripMenuItem"
        Me.BinaryReaderToolStripMenuItem.Size = New System.Drawing.Size(243, 26)
        Me.BinaryReaderToolStripMenuItem.Text = "BinaryReader"
        '
        'BinaryWriterToolStripMenuItem
        '
        Me.BinaryWriterToolStripMenuItem.BackgroundImage = CType(resources.GetObject("BinaryWriterToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.BinaryWriterToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGray
        Me.BinaryWriterToolStripMenuItem.Image = CType(resources.GetObject("BinaryWriterToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BinaryWriterToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BinaryWriterToolStripMenuItem.Name = "BinaryWriterToolStripMenuItem"
        Me.BinaryWriterToolStripMenuItem.Size = New System.Drawing.Size(243, 26)
        Me.BinaryWriterToolStripMenuItem.Text = "BinaryWriter"
        '
        'TextReaderToolStripMenuItem
        '
        Me.TextReaderToolStripMenuItem.BackgroundImage = CType(resources.GetObject("TextReaderToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.TextReaderToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGray
        Me.TextReaderToolStripMenuItem.Image = CType(resources.GetObject("TextReaderToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TextReaderToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TextReaderToolStripMenuItem.Name = "TextReaderToolStripMenuItem"
        Me.TextReaderToolStripMenuItem.Size = New System.Drawing.Size(243, 26)
        Me.TextReaderToolStripMenuItem.Text = "TextReader"
        '
        'TextWriterToolStripMenuItem
        '
        Me.TextWriterToolStripMenuItem.BackgroundImage = CType(resources.GetObject("TextWriterToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.TextWriterToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGray
        Me.TextWriterToolStripMenuItem.Image = CType(resources.GetObject("TextWriterToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TextWriterToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TextWriterToolStripMenuItem.Name = "TextWriterToolStripMenuItem"
        Me.TextWriterToolStripMenuItem.Size = New System.Drawing.Size(243, 26)
        Me.TextWriterToolStripMenuItem.Text = "TextWriter"
        '
        'QueueToolStripMenuItem
        '
        Me.QueueToolStripMenuItem.BackgroundImage = CType(resources.GetObject("QueueToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.QueueToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGray
        Me.QueueToolStripMenuItem.Image = CType(resources.GetObject("QueueToolStripMenuItem.Image"), System.Drawing.Image)
        Me.QueueToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.QueueToolStripMenuItem.Name = "QueueToolStripMenuItem"
        Me.QueueToolStripMenuItem.Size = New System.Drawing.Size(243, 26)
        Me.QueueToolStripMenuItem.Text = "Queue"
        '
        'HashToolStripMenuItem
        '
        Me.HashToolStripMenuItem.BackgroundImage = CType(resources.GetObject("HashToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.HashToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGray
        Me.HashToolStripMenuItem.Image = CType(resources.GetObject("HashToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HashToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HashToolStripMenuItem.Name = "HashToolStripMenuItem"
        Me.HashToolStripMenuItem.Size = New System.Drawing.Size(243, 26)
        Me.HashToolStripMenuItem.Text = "HashTable"
        '
        'StackToolStripMenuItem
        '
        Me.StackToolStripMenuItem.BackgroundImage = CType(resources.GetObject("StackToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.StackToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGray
        Me.StackToolStripMenuItem.Image = CType(resources.GetObject("StackToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StackToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.StackToolStripMenuItem.Name = "StackToolStripMenuItem"
        Me.StackToolStripMenuItem.Size = New System.Drawing.Size(243, 26)
        Me.StackToolStripMenuItem.Text = "Stack"
        '
        'TreeviewToolStripMenuItem
        '
        Me.TreeviewToolStripMenuItem.BackgroundImage = CType(resources.GetObject("TreeviewToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.TreeviewToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGray
        Me.TreeviewToolStripMenuItem.Image = CType(resources.GetObject("TreeviewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TreeviewToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TreeviewToolStripMenuItem.Name = "TreeviewToolStripMenuItem"
        Me.TreeviewToolStripMenuItem.Size = New System.Drawing.Size(243, 26)
        Me.TreeviewToolStripMenuItem.Text = "Treeview"
        '
        'OLEDBToolStripMenuItem
        '
        Me.OLEDBToolStripMenuItem.BackgroundImage = CType(resources.GetObject("OLEDBToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.OLEDBToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGray
        Me.OLEDBToolStripMenuItem.Image = CType(resources.GetObject("OLEDBToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OLEDBToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OLEDBToolStripMenuItem.Name = "OLEDBToolStripMenuItem"
        Me.OLEDBToolStripMenuItem.Size = New System.Drawing.Size(243, 26)
        Me.OLEDBToolStripMenuItem.Text = "OLE.DB"
        '
        'FileStreamToolStripMenuItem
        '
        Me.FileStreamToolStripMenuItem.BackgroundImage = CType(resources.GetObject("FileStreamToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.FileStreamToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGray
        Me.FileStreamToolStripMenuItem.Image = CType(resources.GetObject("FileStreamToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FileStreamToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FileStreamToolStripMenuItem.Name = "FileStreamToolStripMenuItem"
        Me.FileStreamToolStripMenuItem.Size = New System.Drawing.Size(243, 26)
        Me.FileStreamToolStripMenuItem.Text = "FileStream"
        '
        'MDIFormToolStripMenuItem
        '
        Me.MDIFormToolStripMenuItem.BackgroundImage = CType(resources.GetObject("MDIFormToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.MDIFormToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGray
        Me.MDIFormToolStripMenuItem.Image = CType(resources.GetObject("MDIFormToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MDIFormToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MDIFormToolStripMenuItem.Name = "MDIFormToolStripMenuItem"
        Me.MDIFormToolStripMenuItem.Size = New System.Drawing.Size(243, 26)
        Me.MDIFormToolStripMenuItem.Text = "MDIForm"
        '
        'ReadURLToolStripMenuItem
        '
        Me.ReadURLToolStripMenuItem.BackgroundImage = CType(resources.GetObject("ReadURLToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.ReadURLToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGray
        Me.ReadURLToolStripMenuItem.Image = CType(resources.GetObject("ReadURLToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReadURLToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ReadURLToolStripMenuItem.Name = "ReadURLToolStripMenuItem"
        Me.ReadURLToolStripMenuItem.Size = New System.Drawing.Size(243, 26)
        Me.ReadURLToolStripMenuItem.Text = "ReadURL"
        '
        'ModalFormMovementToolStripMenuItem
        '
        Me.ModalFormMovementToolStripMenuItem.BackgroundImage = CType(resources.GetObject("ModalFormMovementToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.ModalFormMovementToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGray
        Me.ModalFormMovementToolStripMenuItem.Image = CType(resources.GetObject("ModalFormMovementToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ModalFormMovementToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ModalFormMovementToolStripMenuItem.Name = "ModalFormMovementToolStripMenuItem"
        Me.ModalFormMovementToolStripMenuItem.Size = New System.Drawing.Size(243, 26)
        Me.ModalFormMovementToolStripMenuItem.Text = "Modal Form Movement"
        '
        'ShareSouceCodeToolStripMenuItem
        '
        Me.ShareSouceCodeToolStripMenuItem.BackgroundImage = CType(resources.GetObject("ShareSouceCodeToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.ShareSouceCodeToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGray
        Me.ShareSouceCodeToolStripMenuItem.Image = CType(resources.GetObject("ShareSouceCodeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ShareSouceCodeToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ShareSouceCodeToolStripMenuItem.Name = "ShareSouceCodeToolStripMenuItem"
        Me.ShareSouceCodeToolStripMenuItem.Size = New System.Drawing.Size(243, 26)
        Me.ShareSouceCodeToolStripMenuItem.Text = "Share SouceCode"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.BackgroundImage = CType(resources.GetObject("ToolStripMenuItem4.BackgroundImage"), System.Drawing.Image)
        Me.ToolStripMenuItem4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem7, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6, Me.ToolStripMenuItem8, Me.ToolStripSeparator32, Me.ToolStripMenuItem9, Me.ToolStripMenuItem10, Me.ToolStripMenuItem11, Me.ToolStripSeparator33})
        Me.ToolStripMenuItem4.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem4.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem4.Image = Global.VB_IDE.My.Resources.Resources.fileIconTextEdit
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(202, 26)
        Me.ToolStripMenuItem4.Text = "Insert Structure"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ToolStripMenuItem7.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(170, 6)
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ToolStripMenuItem5.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem5.Image = CType(resources.GetObject("ToolStripMenuItem5.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(173, 26)
        Me.ToolStripMenuItem5.Text = "Class"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ToolStripMenuItem6.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem6.Image = CType(resources.GetObject("ToolStripMenuItem6.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(173, 26)
        Me.ToolStripMenuItem6.Text = "Sub"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ToolStripMenuItem8.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem8.Image = CType(resources.GetObject("ToolStripMenuItem8.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(173, 26)
        Me.ToolStripMenuItem8.Text = "Function"
        '
        'ToolStripSeparator32
        '
        Me.ToolStripSeparator32.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ToolStripSeparator32.ForeColor = System.Drawing.Color.White
        Me.ToolStripSeparator32.Name = "ToolStripSeparator32"
        Me.ToolStripSeparator32.Size = New System.Drawing.Size(170, 6)
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ToolStripMenuItem9.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem9.Image = CType(resources.GetObject("ToolStripMenuItem9.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(173, 26)
        Me.ToolStripMenuItem9.Text = "Property"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ToolStripMenuItem10.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem10.Image = CType(resources.GetObject("ToolStripMenuItem10.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(173, 26)
        Me.ToolStripMenuItem10.Text = "If Then Else"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ToolStripMenuItem11.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem11.Image = CType(resources.GetObject("ToolStripMenuItem11.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(173, 26)
        Me.ToolStripMenuItem11.Text = "Select Case"
        '
        'ToolStripSeparator33
        '
        Me.ToolStripSeparator33.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ToolStripSeparator33.ForeColor = System.Drawing.Color.White
        Me.ToolStripSeparator33.Name = "ToolStripSeparator33"
        Me.ToolStripSeparator33.Size = New System.Drawing.Size(170, 6)
        '
        'ToolStripScriptDevlopment
        '
        Me.ToolStripScriptDevlopment.BackgroundImage = Global.VB_IDE.My.Resources.Resources.App_Texturex15
        Me.ToolStripScriptDevlopment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripScriptDevlopment.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStripScriptDevlopment.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DevNewToolStripMenuItem3, Me.DevOpenToolStripButton, Me.DevSaveToolStripButton, Me.DevSaveAsToolStripButton, Me.ToolStripSeparator8, Me.SelectAllToolStripMenuItem, Me.DevCutToolStripButton, Me.DevCopyToolStripButton, Me.DevPasteToolStripButton, Me.DevRedoToolStripButton, Me.DevUndoToolStripButton, Me.ToolStripSeparator9, Me.DevPrintToolStripButton, Me.DevHelpToolStripButton, Me.DevCutToolStripSeparator, Me.ToolStripComboBoxFONTFAMILY, Me.ToolStripSeparator11, Me.ToolStripComboBoxFONT_SIZE, Me.ToolStripSeparator10})
        Me.ToolStripScriptDevlopment.Location = New System.Drawing.Point(4, 22)
        Me.ToolStripScriptDevlopment.Name = "ToolStripScriptDevlopment"
        Me.ToolStripScriptDevlopment.Size = New System.Drawing.Size(1109, 39)
        Me.ToolStripScriptDevlopment.TabIndex = 16
        Me.ToolStripScriptDevlopment.Text = "Application"
        '
        'DevNewToolStripMenuItem3
        '
        Me.DevNewToolStripMenuItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DevNewToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem12})
        Me.DevNewToolStripMenuItem3.Image = Global.VB_IDE.My.Resources.Resources.APP_icon_filenew
        Me.DevNewToolStripMenuItem3.Name = "DevNewToolStripMenuItem3"
        Me.DevNewToolStripMenuItem3.Size = New System.Drawing.Size(44, 39)
        Me.DevNewToolStripMenuItem3.Text = "Create Component"
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScriptToolStripMenuItem, Me.ConsoleScriptToolStripMenuItem, Me.ComponentToolStripMenuItem, Me.DeviceToolStripMenuItem})
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem12.Text = "New"
        '
        'ScriptToolStripMenuItem
        '
        Me.ScriptToolStripMenuItem.Name = "ScriptToolStripMenuItem"
        Me.ScriptToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ScriptToolStripMenuItem.Text = "Script"
        '
        'ConsoleScriptToolStripMenuItem
        '
        Me.ConsoleScriptToolStripMenuItem.Name = "ConsoleScriptToolStripMenuItem"
        Me.ConsoleScriptToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ConsoleScriptToolStripMenuItem.Text = "Console Script"
        '
        'ComponentToolStripMenuItem
        '
        Me.ComponentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PluginToolStripMenuItem1, Me.UpdateToolStripMenuItem, Me.TestToolStripMenuItem})
        Me.ComponentToolStripMenuItem.Name = "ComponentToolStripMenuItem"
        Me.ComponentToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ComponentToolStripMenuItem.Text = "Component"
        '
        'PluginToolStripMenuItem1
        '
        Me.PluginToolStripMenuItem1.Name = "PluginToolStripMenuItem1"
        Me.PluginToolStripMenuItem1.Size = New System.Drawing.Size(112, 22)
        Me.PluginToolStripMenuItem1.Text = "Plugin"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.TestToolStripMenuItem.Text = "Test"
        '
        'DeviceToolStripMenuItem
        '
        Me.DeviceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputDeviceToolStripMenuItem, Me.OutputDeviceToolStripMenuItem})
        Me.DeviceToolStripMenuItem.Name = "DeviceToolStripMenuItem"
        Me.DeviceToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.DeviceToolStripMenuItem.Text = "Device"
        '
        'InputDeviceToolStripMenuItem
        '
        Me.InputDeviceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsoleAppToolStripMenuItem})
        Me.InputDeviceToolStripMenuItem.Name = "InputDeviceToolStripMenuItem"
        Me.InputDeviceToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.InputDeviceToolStripMenuItem.Text = "Input Device"
        '
        'ConsoleAppToolStripMenuItem
        '
        Me.ConsoleAppToolStripMenuItem.Name = "ConsoleAppToolStripMenuItem"
        Me.ConsoleAppToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ConsoleAppToolStripMenuItem.Text = "Console App"
        '
        'OutputDeviceToolStripMenuItem
        '
        Me.OutputDeviceToolStripMenuItem.Name = "OutputDeviceToolStripMenuItem"
        Me.OutputDeviceToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.OutputDeviceToolStripMenuItem.Text = "Output Device"
        '
        'DevOpenToolStripButton
        '
        Me.DevOpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DevOpenToolStripButton.Image = Global.VB_IDE.My.Resources.Resources.APP_icon_fileopen
        Me.DevOpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DevOpenToolStripButton.Name = "DevOpenToolStripButton"
        Me.DevOpenToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.DevOpenToolStripButton.Text = "&Open"
        '
        'DevSaveToolStripButton
        '
        Me.DevSaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DevSaveToolStripButton.Image = Global.VB_IDE.My.Resources.Resources.APP_icon_filesave
        Me.DevSaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DevSaveToolStripButton.Name = "DevSaveToolStripButton"
        Me.DevSaveToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.DevSaveToolStripButton.Text = "&Save"
        '
        'DevSaveAsToolStripButton
        '
        Me.DevSaveAsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DevSaveAsToolStripButton.Image = Global.VB_IDE.My.Resources.Resources.APP_icon_filesaveas
        Me.DevSaveAsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DevSaveAsToolStripButton.Name = "DevSaveAsToolStripButton"
        Me.DevSaveAsToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.DevSaveAsToolStripButton.Text = "SaveAs"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 39)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SelectAllToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SelectAllToolStripMenuItem.Image = Global.VB_IDE.My.Resources.Resources.FileIcon_launchpad
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(36, 36)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'DevCutToolStripButton
        '
        Me.DevCutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DevCutToolStripButton.Image = Global.VB_IDE.My.Resources.Resources.APP_icon_editcut
        Me.DevCutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DevCutToolStripButton.Name = "DevCutToolStripButton"
        Me.DevCutToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.DevCutToolStripButton.Text = "C&ut"
        '
        'DevCopyToolStripButton
        '
        Me.DevCopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DevCopyToolStripButton.Image = Global.VB_IDE.My.Resources.Resources.APP_icon_editcopy
        Me.DevCopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DevCopyToolStripButton.Name = "DevCopyToolStripButton"
        Me.DevCopyToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.DevCopyToolStripButton.Text = "&Copy"
        '
        'DevPasteToolStripButton
        '
        Me.DevPasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DevPasteToolStripButton.Image = Global.VB_IDE.My.Resources.Resources.APP_icon_editpaste
        Me.DevPasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DevPasteToolStripButton.Name = "DevPasteToolStripButton"
        Me.DevPasteToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.DevPasteToolStripButton.Text = "&Paste"
        '
        'DevRedoToolStripButton
        '
        Me.DevRedoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DevRedoToolStripButton.Image = Global.VB_IDE.My.Resources.Resources.APP_icon_editredo
        Me.DevRedoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DevRedoToolStripButton.Name = "DevRedoToolStripButton"
        Me.DevRedoToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.DevRedoToolStripButton.Text = "Redo"
        Me.DevRedoToolStripButton.ToolTipText = "Redo"
        '
        'DevUndoToolStripButton
        '
        Me.DevUndoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DevUndoToolStripButton.Image = Global.VB_IDE.My.Resources.Resources.APP_icon_editundo
        Me.DevUndoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DevUndoToolStripButton.Name = "DevUndoToolStripButton"
        Me.DevUndoToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.DevUndoToolStripButton.Text = "Undo"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 39)
        '
        'DevPrintToolStripButton
        '
        Me.DevPrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DevPrintToolStripButton.Image = CType(resources.GetObject("DevPrintToolStripButton.Image"), System.Drawing.Image)
        Me.DevPrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DevPrintToolStripButton.Name = "DevPrintToolStripButton"
        Me.DevPrintToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.DevPrintToolStripButton.Text = "&Print"
        '
        'DevHelpToolStripButton
        '
        Me.DevHelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DevHelpToolStripButton.Image = Global.VB_IDE.My.Resources.Resources.APP_icon_information
        Me.DevHelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DevHelpToolStripButton.Name = "DevHelpToolStripButton"
        Me.DevHelpToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.DevHelpToolStripButton.Text = "He&lp"
        '
        'DevCutToolStripSeparator
        '
        Me.DevCutToolStripSeparator.Name = "DevCutToolStripSeparator"
        Me.DevCutToolStripSeparator.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripComboBoxFONTFAMILY
        '
        Me.ToolStripComboBoxFONTFAMILY.DropDownWidth = 363
        Me.ToolStripComboBoxFONTFAMILY.Name = "ToolStripComboBoxFONTFAMILY"
        Me.ToolStripComboBoxFONTFAMILY.Size = New System.Drawing.Size(266, 39)
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripComboBoxFONT_SIZE
        '
        Me.ToolStripComboBoxFONT_SIZE.DropDownWidth = 100
        Me.ToolStripComboBoxFONT_SIZE.Name = "ToolStripComboBoxFONT_SIZE"
        Me.ToolStripComboBoxFONT_SIZE.Size = New System.Drawing.Size(178, 39)
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 39)
        '
        'TabControlFileBrowsers
        '
        Me.TabControlFileBrowsers.Controls.Add(Me.TabPageInteractiveReplScript)
        Me.TabControlFileBrowsers.Controls.Add(Me.TabPageObjectBrowser)
        Me.TabControlFileBrowsers.Controls.Add(Me.TabPageFileList)
        Me.TabControlFileBrowsers.Controls.Add(Me.TabPageEmbeddedFiles)
        Me.TabControlFileBrowsers.Controls.Add(Me.TabPageAssemblies)
        Me.TabControlFileBrowsers.Controls.Add(Me.TabPagePlugins)
        Me.TabControlFileBrowsers.Controls.Add(Me.TabPageUpdates)
        Me.TabControlFileBrowsers.Controls.Add(Me.TabPageDevices)
        Me.TabControlFileBrowsers.Controls.Add(Me.TabPageAvatars)
        Me.TabControlFileBrowsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlFileBrowsers.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlFileBrowsers.Location = New System.Drawing.Point(0, 39)
        Me.TabControlFileBrowsers.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabControlFileBrowsers.Name = "TabControlFileBrowsers"
        Me.TabControlFileBrowsers.SelectedIndex = 0
        Me.TabControlFileBrowsers.Size = New System.Drawing.Size(659, 617)
        Me.TabControlFileBrowsers.TabIndex = 5
        '
        'TabPageInteractiveReplScript
        '
        Me.TabPageInteractiveReplScript.Controls.Add(Me.GroupBox4)
        Me.TabPageInteractiveReplScript.Location = New System.Drawing.Point(4, 29)
        Me.TabPageInteractiveReplScript.Name = "TabPageInteractiveReplScript"
        Me.TabPageInteractiveReplScript.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageInteractiveReplScript.Size = New System.Drawing.Size(651, 584)
        Me.TabPageInteractiveReplScript.TabIndex = 4
        Me.TabPageInteractiveReplScript.Text = "Interactive REPL"
        Me.TabPageInteractiveReplScript.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Black
        Me.GroupBox4.BackgroundImage = Global.VB_IDE.My.Resources.Resources.App_Texturex15
        Me.GroupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox4.Controls.Add(Me.InteractiveReplScript)
        Me.GroupBox4.Controls.Add(Me.SpydazWebLineNumbering2)
        Me.GroupBox4.Controls.Add(Me.ToolStripInteractiveRepl)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(8, 5, 8, 5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(8, 5, 8, 5)
        Me.GroupBox4.Size = New System.Drawing.Size(645, 578)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Interactive VB Repl"
        '
        'InteractiveReplScript
        '
        Me.InteractiveReplScript.BackColor = System.Drawing.Color.Ivory
        Me.InteractiveReplScript.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InteractiveReplScript.Font = New System.Drawing.Font("Courier-Oblique", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InteractiveReplScript.Location = New System.Drawing.Point(58, 65)
        Me.InteractiveReplScript.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.InteractiveReplScript.MySyntax = CType(resources.GetObject("InteractiveReplScript.MySyntax"), System.Collections.Generic.List(Of String))
        Me.InteractiveReplScript.Name = "InteractiveReplScript"
        Me.InteractiveReplScript.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.InteractiveReplScript.Size = New System.Drawing.Size(579, 508)
        Me.InteractiveReplScript.TabIndex = 13
        Me.InteractiveReplScript.Text = "Imports System" & Global.Microsoft.VisualBasic.ChrW(10) & "Imports system.windows.forms" & Global.Microsoft.VisualBasic.ChrW(10) & "Public Class Test" & Global.Microsoft.VisualBasic.ChrW(10) & "   Public Function " &
    "ExecuteCode()" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Console.WriteLine(""Hello"")" & Global.Microsoft.VisualBasic.ChrW(10) & "MessageBox.Show(""Welcome"")" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "    End Fu" &
    "nction" & Global.Microsoft.VisualBasic.ChrW(10) & "End Class" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'SpydazWebLineNumbering2
        '
        Me.SpydazWebLineNumbering2._SeeThroughMode_ = False
        Me.SpydazWebLineNumbering2.AutoSizing = True
        Me.SpydazWebLineNumbering2.BackgroundGradient_AlphaColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SpydazWebLineNumbering2.BackgroundGradient_BetaColor = System.Drawing.Color.LightSteelBlue
        Me.SpydazWebLineNumbering2.BackgroundGradient_Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.SpydazWebLineNumbering2.BorderLines_Color = System.Drawing.Color.SlateGray
        Me.SpydazWebLineNumbering2.BorderLines_Style = System.Drawing.Drawing2D.DashStyle.Dot
        Me.SpydazWebLineNumbering2.BorderLines_Thickness = 1.0!
        Me.SpydazWebLineNumbering2.Dock = System.Windows.Forms.DockStyle.Left
        Me.SpydazWebLineNumbering2.DockSide = SpydazWebLineNumbering.LineNumberDockSide.Left
        Me.SpydazWebLineNumbering2.GridLines_Color = System.Drawing.Color.SlateGray
        Me.SpydazWebLineNumbering2.GridLines_Style = System.Drawing.Drawing2D.DashStyle.Dot
        Me.SpydazWebLineNumbering2.GridLines_Thickness = 1.0!
        Me.SpydazWebLineNumbering2.LineNrs_Alignment = System.Drawing.ContentAlignment.TopRight
        Me.SpydazWebLineNumbering2.LineNrs_AntiAlias = True
        Me.SpydazWebLineNumbering2.LineNrs_AsHexadecimal = False
        Me.SpydazWebLineNumbering2.LineNrs_ClippedByItemRectangle = True
        Me.SpydazWebLineNumbering2.LineNrs_LeadingZeroes = True
        Me.SpydazWebLineNumbering2.LineNrs_Offset = New System.Drawing.Size(0, 0)
        Me.SpydazWebLineNumbering2.Location = New System.Drawing.Point(8, 65)
        Me.SpydazWebLineNumbering2.Margin = New System.Windows.Forms.Padding(0)
        Me.SpydazWebLineNumbering2.MarginLines_Color = System.Drawing.Color.SlateGray
        Me.SpydazWebLineNumbering2.MarginLines_Side = SpydazWebLineNumbering.LineNumberDockSide.Right
        Me.SpydazWebLineNumbering2.MarginLines_Style = System.Drawing.Drawing2D.DashStyle.Solid
        Me.SpydazWebLineNumbering2.MarginLines_Thickness = 1.0!
        Me.SpydazWebLineNumbering2.Name = "SpydazWebLineNumbering2"
        Me.SpydazWebLineNumbering2.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.SpydazWebLineNumbering2.ParentRichTextBox = Me.InteractiveReplScript
        Me.SpydazWebLineNumbering2.Show_BackgroundGradient = True
        Me.SpydazWebLineNumbering2.Show_BorderLines = True
        Me.SpydazWebLineNumbering2.Show_GridLines = True
        Me.SpydazWebLineNumbering2.Show_LineNrs = True
        Me.SpydazWebLineNumbering2.Show_MarginLines = True
        Me.SpydazWebLineNumbering2.Size = New System.Drawing.Size(50, 508)
        Me.SpydazWebLineNumbering2.TabIndex = 12
        '
        'ToolStripInteractiveRepl
        '
        Me.ToolStripInteractiveRepl.BackColor = System.Drawing.Color.Black
        Me.ToolStripInteractiveRepl.BackgroundImage = Global.VB_IDE.My.Resources.Resources.App_Texturex15
        Me.ToolStripInteractiveRepl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripInteractiveRepl.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStripInteractiveRepl.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator12, Me.ToolStripButtonExecuteInteractive, Me.ToolStripSeparator13, Me.ToolStripButtonClearInteractive, Me.ToolStripTextBoxClassNameInteractive, Me.ToolStripTextBoxFunctionNameInteractive})
        Me.ToolStripInteractiveRepl.Location = New System.Drawing.Point(8, 26)
        Me.ToolStripInteractiveRepl.Name = "ToolStripInteractiveRepl"
        Me.ToolStripInteractiveRepl.Size = New System.Drawing.Size(629, 39)
        Me.ToolStripInteractiveRepl.TabIndex = 10
        Me.ToolStripInteractiveRepl.Text = "Application"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripButtonExecuteInteractive
        '
        Me.ToolStripButtonExecuteInteractive.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonExecuteInteractive.Image = Global.VB_IDE.My.Resources.Resources.APP_icon_Complie
        Me.ToolStripButtonExecuteInteractive.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonExecuteInteractive.Name = "ToolStripButtonExecuteInteractive"
        Me.ToolStripButtonExecuteInteractive.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButtonExecuteInteractive.Text = "&Execute"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripButtonClearInteractive
        '
        Me.ToolStripButtonClearInteractive.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonClearInteractive.Image = Global.VB_IDE.My.Resources.Resources.App_Refresh
        Me.ToolStripButtonClearInteractive.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonClearInteractive.Name = "ToolStripButtonClearInteractive"
        Me.ToolStripButtonClearInteractive.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButtonClearInteractive.Text = "Clear"
        '
        'ToolStripTextBoxClassNameInteractive
        '
        Me.ToolStripTextBoxClassNameInteractive.BackColor = System.Drawing.Color.LavenderBlush
        Me.ToolStripTextBoxClassNameInteractive.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBoxClassNameInteractive.Name = "ToolStripTextBoxClassNameInteractive"
        Me.ToolStripTextBoxClassNameInteractive.Size = New System.Drawing.Size(200, 39)
        Me.ToolStripTextBoxClassNameInteractive.Tag = "ClassName"
        Me.ToolStripTextBoxClassNameInteractive.Text = "Test"
        '
        'ToolStripTextBoxFunctionNameInteractive
        '
        Me.ToolStripTextBoxFunctionNameInteractive.BackColor = System.Drawing.Color.LavenderBlush
        Me.ToolStripTextBoxFunctionNameInteractive.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBoxFunctionNameInteractive.Name = "ToolStripTextBoxFunctionNameInteractive"
        Me.ToolStripTextBoxFunctionNameInteractive.Size = New System.Drawing.Size(200, 39)
        Me.ToolStripTextBoxFunctionNameInteractive.Text = "ExecuteCode"
        '
        'TabPageObjectBrowser
        '
        Me.TabPageObjectBrowser.Controls.Add(Me.GroupBox38)
        Me.TabPageObjectBrowser.Controls.Add(Me.GroupBox39)
        Me.TabPageObjectBrowser.Location = New System.Drawing.Point(4, 29)
        Me.TabPageObjectBrowser.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPageObjectBrowser.Name = "TabPageObjectBrowser"
        Me.TabPageObjectBrowser.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPageObjectBrowser.Size = New System.Drawing.Size(651, 584)
        Me.TabPageObjectBrowser.TabIndex = 2
        Me.TabPageObjectBrowser.Text = "ObjectBrowser"
        Me.TabPageObjectBrowser.UseVisualStyleBackColor = True
        '
        'GroupBox38
        '
        Me.GroupBox38.BackColor = System.Drawing.Color.Black
        Me.GroupBox38.BackgroundImage = Global.VB_IDE.My.Resources.Resources.App_Texturex15
        Me.GroupBox38.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox38.Controls.Add(Me.RichTextBoxCompilerInfo)
        Me.GroupBox38.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox38.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox38.ForeColor = System.Drawing.Color.White
        Me.GroupBox38.Location = New System.Drawing.Point(4, 3)
        Me.GroupBox38.Margin = New System.Windows.Forms.Padding(8, 5, 8, 5)
        Me.GroupBox38.Name = "GroupBox38"
        Me.GroupBox38.Padding = New System.Windows.Forms.Padding(8, 5, 8, 5)
        Me.GroupBox38.Size = New System.Drawing.Size(643, 255)
        Me.GroupBox38.TabIndex = 3
        Me.GroupBox38.TabStop = False
        Me.GroupBox38.Text = "Info"
        '
        'RichTextBoxCompilerInfo
        '
        Me.RichTextBoxCompilerInfo.BackColor = System.Drawing.SystemColors.Info
        Me.RichTextBoxCompilerInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBoxCompilerInfo.Cursor = System.Windows.Forms.Cursors.Default
        Me.RichTextBoxCompilerInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBoxCompilerInfo.EnableAutoDragDrop = True
        Me.RichTextBoxCompilerInfo.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxCompilerInfo.Location = New System.Drawing.Point(8, 26)
        Me.RichTextBoxCompilerInfo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.RichTextBoxCompilerInfo.Name = "RichTextBoxCompilerInfo"
        Me.RichTextBoxCompilerInfo.Size = New System.Drawing.Size(627, 224)
        Me.RichTextBoxCompilerInfo.TabIndex = 0
        Me.RichTextBoxCompilerInfo.Text = ""
        Me.RichTextBoxCompilerInfo.ZoomFactor = 2.0!
        '
        'GroupBox39
        '
        Me.GroupBox39.BackColor = System.Drawing.Color.Black
        Me.GroupBox39.BackgroundImage = Global.VB_IDE.My.Resources.Resources.App_Texturex15
        Me.GroupBox39.Controls.Add(Me.TreeViewObjectSyntax)
        Me.GroupBox39.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox39.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox39.ForeColor = System.Drawing.Color.White
        Me.GroupBox39.Location = New System.Drawing.Point(4, 258)
        Me.GroupBox39.Margin = New System.Windows.Forms.Padding(8, 5, 8, 5)
        Me.GroupBox39.Name = "GroupBox39"
        Me.GroupBox39.Padding = New System.Windows.Forms.Padding(8, 5, 8, 5)
        Me.GroupBox39.Size = New System.Drawing.Size(643, 323)
        Me.GroupBox39.TabIndex = 2
        Me.GroupBox39.TabStop = False
        Me.GroupBox39.Text = "Loaded Objects"
        '
        'TreeViewObjectSyntax
        '
        Me.TreeViewObjectSyntax.BackColor = System.Drawing.Color.White
        Me.TreeViewObjectSyntax.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeViewObjectSyntax.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeViewObjectSyntax.Location = New System.Drawing.Point(8, 26)
        Me.TreeViewObjectSyntax.Margin = New System.Windows.Forms.Padding(8, 5, 8, 5)
        Me.TreeViewObjectSyntax.Name = "TreeViewObjectSyntax"
        Me.TreeViewObjectSyntax.Size = New System.Drawing.Size(627, 292)
        Me.TreeViewObjectSyntax.TabIndex = 0
        '
        'TabPageFileList
        '
        Me.TabPageFileList.Controls.Add(Me.SplitContainer4)
        Me.TabPageFileList.Location = New System.Drawing.Point(4, 29)
        Me.TabPageFileList.Name = "TabPageFileList"
        Me.TabPageFileList.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageFileList.Size = New System.Drawing.Size(651, 584)
        Me.TabPageFileList.TabIndex = 9
        Me.TabPageFileList.Text = "Folder"
        Me.TabPageFileList.UseVisualStyleBackColor = True
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer4.Name = "SplitContainer4"
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.GroupBox7)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.GroupBox6)
        Me.SplitContainer4.Size = New System.Drawing.Size(645, 578)
        Me.SplitContainer4.SplitterDistance = 122
        Me.SplitContainer4.TabIndex = 0
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Black
        Me.GroupBox7.Controls.Add(Me.ButtonOpenDir)
        Me.GroupBox7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox7.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(122, 578)
        Me.GroupBox7.TabIndex = 1
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Options"
        '
        'ButtonOpenDir
        '
        Me.ButtonOpenDir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonOpenDir.BackgroundImage = Global.VB_IDE.My.Resources.Resources.FileIcon_bootcamp
        Me.ButtonOpenDir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonOpenDir.ForeColor = System.Drawing.Color.Black
        Me.ButtonOpenDir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonOpenDir.Location = New System.Drawing.Point(11, 37)
        Me.ButtonOpenDir.Name = "ButtonOpenDir"
        Me.ButtonOpenDir.Size = New System.Drawing.Size(86, 74)
        Me.ButtonOpenDir.TabIndex = 0
        Me.ButtonOpenDir.Tag = "Open Dir"
        Me.ButtonOpenDir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonOpenDir.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Black
        Me.GroupBox6.Controls.Add(Me.ListBoxFileDirectory)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox6.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(519, 578)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Folder"
        '
        'ListBoxFileDirectory
        '
        Me.ListBoxFileDirectory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBoxFileDirectory.FormattingEnabled = True
        Me.ListBoxFileDirectory.ItemHeight = 20
        Me.ListBoxFileDirectory.Location = New System.Drawing.Point(3, 22)
        Me.ListBoxFileDirectory.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBoxFileDirectory.Name = "ListBoxFileDirectory"
        Me.ListBoxFileDirectory.Size = New System.Drawing.Size(513, 553)
        Me.ListBoxFileDirectory.TabIndex = 2
        '
        'TabPageEmbeddedFiles
        '
        Me.TabPageEmbeddedFiles.Controls.Add(Me.GroupBox2)
        Me.TabPageEmbeddedFiles.Location = New System.Drawing.Point(4, 29)
        Me.TabPageEmbeddedFiles.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPageEmbeddedFiles.Name = "TabPageEmbeddedFiles"
        Me.TabPageEmbeddedFiles.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPageEmbeddedFiles.Size = New System.Drawing.Size(651, 584)
        Me.TabPageEmbeddedFiles.TabIndex = 0
        Me.TabPageEmbeddedFiles.Text = "EmbeddedFiles"
        Me.TabPageEmbeddedFiles.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Black
        Me.GroupBox2.BackgroundImage = Global.VB_IDE.My.Resources.Resources.App_Texturex15
        Me.GroupBox2.Controls.Add(Me.CheckedListBoxEmbeddedFiles)
        Me.GroupBox2.Controls.Add(Me.ToolStripEmbeddedFiles)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(4, 3)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(643, 578)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Embeded Resources"
        '
        'CheckedListBoxEmbeddedFiles
        '
        Me.CheckedListBoxEmbeddedFiles.BackColor = System.Drawing.SystemColors.Info
        Me.CheckedListBoxEmbeddedFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CheckedListBoxEmbeddedFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckedListBoxEmbeddedFiles.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListBoxEmbeddedFiles.FormattingEnabled = True
        Me.CheckedListBoxEmbeddedFiles.HorizontalScrollbar = True
        Me.CheckedListBoxEmbeddedFiles.Location = New System.Drawing.Point(4, 63)
        Me.CheckedListBoxEmbeddedFiles.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CheckedListBoxEmbeddedFiles.Name = "CheckedListBoxEmbeddedFiles"
        Me.CheckedListBoxEmbeddedFiles.ScrollAlwaysVisible = True
        Me.CheckedListBoxEmbeddedFiles.Size = New System.Drawing.Size(635, 512)
        Me.CheckedListBoxEmbeddedFiles.TabIndex = 10
        '
        'ToolStripEmbeddedFiles
        '
        Me.ToolStripEmbeddedFiles.BackColor = System.Drawing.Color.Black
        Me.ToolStripEmbeddedFiles.BackgroundImage = Global.VB_IDE.My.Resources.Resources.App_Texturex15
        Me.ToolStripEmbeddedFiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripEmbeddedFiles.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStripEmbeddedFiles.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddEmbededFileToolStripMenuItem, Me.ToolStripSeparator6, Me.RemoveEmbeddedFileToolStripMenuItem, Me.ToolStripSeparator7, Me.ClearFilesToolStripMenuItem})
        Me.ToolStripEmbeddedFiles.Location = New System.Drawing.Point(4, 24)
        Me.ToolStripEmbeddedFiles.Name = "ToolStripEmbeddedFiles"
        Me.ToolStripEmbeddedFiles.Size = New System.Drawing.Size(635, 39)
        Me.ToolStripEmbeddedFiles.TabIndex = 9
        Me.ToolStripEmbeddedFiles.Text = "Application"
        '
        'AddEmbededFileToolStripMenuItem
        '
        Me.AddEmbededFileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddEmbededFileToolStripMenuItem.Image = Global.VB_IDE.My.Resources.Resources.APP_icon_fileopen
        Me.AddEmbededFileToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddEmbededFileToolStripMenuItem.Name = "AddEmbededFileToolStripMenuItem"
        Me.AddEmbededFileToolStripMenuItem.Size = New System.Drawing.Size(36, 36)
        Me.AddEmbededFileToolStripMenuItem.Text = "&Open"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 39)
        '
        'RemoveEmbeddedFileToolStripMenuItem
        '
        Me.RemoveEmbeddedFileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RemoveEmbeddedFileToolStripMenuItem.Image = Global.VB_IDE.My.Resources.Resources.APP_icon_error
        Me.RemoveEmbeddedFileToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RemoveEmbeddedFileToolStripMenuItem.Name = "RemoveEmbeddedFileToolStripMenuItem"
        Me.RemoveEmbeddedFileToolStripMenuItem.Size = New System.Drawing.Size(36, 36)
        Me.RemoveEmbeddedFileToolStripMenuItem.Text = "&Removed Selected"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 39)
        '
        'ClearFilesToolStripMenuItem
        '
        Me.ClearFilesToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClearFilesToolStripMenuItem.Image = Global.VB_IDE.My.Resources.Resources.App_Refresh
        Me.ClearFilesToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ClearFilesToolStripMenuItem.Name = "ClearFilesToolStripMenuItem"
        Me.ClearFilesToolStripMenuItem.Size = New System.Drawing.Size(36, 36)
        Me.ClearFilesToolStripMenuItem.Text = "Clear"
        '
        'TabPageAssemblies
        '
        Me.TabPageAssemblies.Controls.Add(Me.GroupBox1)
        Me.TabPageAssemblies.Location = New System.Drawing.Point(4, 29)
        Me.TabPageAssemblies.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPageAssemblies.Name = "TabPageAssemblies"
        Me.TabPageAssemblies.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPageAssemblies.Size = New System.Drawing.Size(651, 584)
        Me.TabPageAssemblies.TabIndex = 1
        Me.TabPageAssemblies.Text = "Assemblies Files"
        Me.TabPageAssemblies.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.BackgroundImage = Global.VB_IDE.My.Resources.Resources.App_Texturex15
        Me.GroupBox1.Controls.Add(Me.CheckedListBoxAssemblys)
        Me.GroupBox1.Controls.Add(Me.ToolStripAssemblies)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(4, 3)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(643, 578)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Assemblies"
        '
        'CheckedListBoxAssemblys
        '
        Me.CheckedListBoxAssemblys.BackColor = System.Drawing.SystemColors.Info
        Me.CheckedListBoxAssemblys.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CheckedListBoxAssemblys.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckedListBoxAssemblys.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListBoxAssemblys.FormattingEnabled = True
        Me.CheckedListBoxAssemblys.HorizontalScrollbar = True
        Me.CheckedListBoxAssemblys.Location = New System.Drawing.Point(4, 63)
        Me.CheckedListBoxAssemblys.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CheckedListBoxAssemblys.Name = "CheckedListBoxAssemblys"
        Me.CheckedListBoxAssemblys.ScrollAlwaysVisible = True
        Me.CheckedListBoxAssemblys.Size = New System.Drawing.Size(635, 512)
        Me.CheckedListBoxAssemblys.TabIndex = 10
        '
        'ToolStripAssemblies
        '
        Me.ToolStripAssemblies.BackColor = System.Drawing.Color.Black
        Me.ToolStripAssemblies.BackgroundImage = Global.VB_IDE.My.Resources.Resources.App_Texturex15
        Me.ToolStripAssemblies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripAssemblies.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStripAssemblies.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddAssemblyToolStripMenuItem, Me.ToolStripSeparator4, Me.RemoveAssemblyToolStripMenuItem, Me.ToolStripSeparator5, Me.ClearAssemblyToolStripMenuItem})
        Me.ToolStripAssemblies.Location = New System.Drawing.Point(4, 24)
        Me.ToolStripAssemblies.Name = "ToolStripAssemblies"
        Me.ToolStripAssemblies.Size = New System.Drawing.Size(635, 39)
        Me.ToolStripAssemblies.TabIndex = 9
        Me.ToolStripAssemblies.Text = "Application"
        '
        'AddAssemblyToolStripMenuItem
        '
        Me.AddAssemblyToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddAssemblyToolStripMenuItem.Image = Global.VB_IDE.My.Resources.Resources.APP_icon_fileopen
        Me.AddAssemblyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddAssemblyToolStripMenuItem.Name = "AddAssemblyToolStripMenuItem"
        Me.AddAssemblyToolStripMenuItem.Size = New System.Drawing.Size(36, 36)
        Me.AddAssemblyToolStripMenuItem.Text = "&Open"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)
        '
        'RemoveAssemblyToolStripMenuItem
        '
        Me.RemoveAssemblyToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RemoveAssemblyToolStripMenuItem.Image = Global.VB_IDE.My.Resources.Resources.APP_icon_error
        Me.RemoveAssemblyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RemoveAssemblyToolStripMenuItem.Name = "RemoveAssemblyToolStripMenuItem"
        Me.RemoveAssemblyToolStripMenuItem.Size = New System.Drawing.Size(36, 36)
        Me.RemoveAssemblyToolStripMenuItem.Text = "&Remove Selected"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 39)
        '
        'ClearAssemblyToolStripMenuItem
        '
        Me.ClearAssemblyToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClearAssemblyToolStripMenuItem.Image = Global.VB_IDE.My.Resources.Resources.App_Refresh
        Me.ClearAssemblyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ClearAssemblyToolStripMenuItem.Name = "ClearAssemblyToolStripMenuItem"
        Me.ClearAssemblyToolStripMenuItem.Size = New System.Drawing.Size(36, 36)
        Me.ClearAssemblyToolStripMenuItem.Text = "Clear"
        '
        'TabPagePlugins
        '
        Me.TabPagePlugins.Controls.Add(Me.GroupBox30)
        Me.TabPagePlugins.Location = New System.Drawing.Point(4, 29)
        Me.TabPagePlugins.Name = "TabPagePlugins"
        Me.TabPagePlugins.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagePlugins.Size = New System.Drawing.Size(651, 584)
        Me.TabPagePlugins.TabIndex = 5
        Me.TabPagePlugins.Text = "Plugins"
        Me.TabPagePlugins.UseVisualStyleBackColor = True
        '
        'GroupBox30
        '
        Me.GroupBox30.BackColor = System.Drawing.Color.Black
        Me.GroupBox30.Controls.Add(Me.CheckedListLoadedPlugins)
        Me.GroupBox30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox30.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox30.ForeColor = System.Drawing.Color.Cyan
        Me.GroupBox30.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox30.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.GroupBox30.Name = "GroupBox30"
        Me.GroupBox30.Padding = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.GroupBox30.Size = New System.Drawing.Size(645, 578)
        Me.GroupBox30.TabIndex = 1
        Me.GroupBox30.TabStop = False
        Me.GroupBox30.Text = "LoadedPlugins"
        '
        'CheckedListLoadedPlugins
        '
        Me.CheckedListLoadedPlugins.BackColor = System.Drawing.Color.Moccasin
        Me.CheckedListLoadedPlugins.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckedListLoadedPlugins.FormattingEnabled = True
        Me.CheckedListLoadedPlugins.Location = New System.Drawing.Point(6, 23)
        Me.CheckedListLoadedPlugins.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.CheckedListLoadedPlugins.Name = "CheckedListLoadedPlugins"
        Me.CheckedListLoadedPlugins.Size = New System.Drawing.Size(633, 551)
        Me.CheckedListLoadedPlugins.TabIndex = 0
        '
        'TabPageUpdates
        '
        Me.TabPageUpdates.Controls.Add(Me.GroupBox32)
        Me.TabPageUpdates.Location = New System.Drawing.Point(4, 29)
        Me.TabPageUpdates.Name = "TabPageUpdates"
        Me.TabPageUpdates.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageUpdates.Size = New System.Drawing.Size(651, 584)
        Me.TabPageUpdates.TabIndex = 6
        Me.TabPageUpdates.Text = "Updates"
        Me.TabPageUpdates.UseVisualStyleBackColor = True
        '
        'GroupBox32
        '
        Me.GroupBox32.BackColor = System.Drawing.Color.Black
        Me.GroupBox32.Controls.Add(Me.CheckedUpdates)
        Me.GroupBox32.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox32.ForeColor = System.Drawing.Color.Cyan
        Me.GroupBox32.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox32.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.GroupBox32.Name = "GroupBox32"
        Me.GroupBox32.Padding = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.GroupBox32.Size = New System.Drawing.Size(645, 578)
        Me.GroupBox32.TabIndex = 1
        Me.GroupBox32.TabStop = False
        Me.GroupBox32.Text = "Loaded Updates"
        '
        'CheckedUpdates
        '
        Me.CheckedUpdates.BackColor = System.Drawing.Color.Moccasin
        Me.CheckedUpdates.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckedUpdates.FormattingEnabled = True
        Me.CheckedUpdates.Location = New System.Drawing.Point(6, 23)
        Me.CheckedUpdates.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.CheckedUpdates.Name = "CheckedUpdates"
        Me.CheckedUpdates.Size = New System.Drawing.Size(633, 551)
        Me.CheckedUpdates.TabIndex = 0
        '
        'TabPageDevices
        '
        Me.TabPageDevices.Controls.Add(Me.SplitContainer3)
        Me.TabPageDevices.Location = New System.Drawing.Point(4, 29)
        Me.TabPageDevices.Name = "TabPageDevices"
        Me.TabPageDevices.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDevices.Size = New System.Drawing.Size(651, 584)
        Me.TabPageDevices.TabIndex = 7
        Me.TabPageDevices.Text = "Devices"
        Me.TabPageDevices.UseVisualStyleBackColor = True
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.GroupBox34)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.GroupBox35)
        Me.SplitContainer3.Size = New System.Drawing.Size(645, 578)
        Me.SplitContainer3.SplitterDistance = 267
        Me.SplitContainer3.TabIndex = 0
        '
        'GroupBox34
        '
        Me.GroupBox34.BackColor = System.Drawing.Color.Black
        Me.GroupBox34.Controls.Add(Me.ListBoxInputDevices)
        Me.GroupBox34.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox34.ForeColor = System.Drawing.Color.Cyan
        Me.GroupBox34.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox34.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.GroupBox34.Name = "GroupBox34"
        Me.GroupBox34.Padding = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.GroupBox34.Size = New System.Drawing.Size(645, 267)
        Me.GroupBox34.TabIndex = 1
        Me.GroupBox34.TabStop = False
        Me.GroupBox34.Text = "Loaded Input Devices"
        '
        'ListBoxInputDevices
        '
        Me.ListBoxInputDevices.BackColor = System.Drawing.Color.Moccasin
        Me.ListBoxInputDevices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBoxInputDevices.FormattingEnabled = True
        Me.ListBoxInputDevices.ItemHeight = 20
        Me.ListBoxInputDevices.Location = New System.Drawing.Point(6, 23)
        Me.ListBoxInputDevices.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.ListBoxInputDevices.Name = "ListBoxInputDevices"
        Me.ListBoxInputDevices.Size = New System.Drawing.Size(633, 240)
        Me.ListBoxInputDevices.TabIndex = 0
        '
        'GroupBox35
        '
        Me.GroupBox35.BackColor = System.Drawing.Color.Black
        Me.GroupBox35.Controls.Add(Me.ListBoxOutputDevices)
        Me.GroupBox35.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox35.ForeColor = System.Drawing.Color.Cyan
        Me.GroupBox35.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox35.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.GroupBox35.Name = "GroupBox35"
        Me.GroupBox35.Padding = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.GroupBox35.Size = New System.Drawing.Size(645, 307)
        Me.GroupBox35.TabIndex = 2
        Me.GroupBox35.TabStop = False
        Me.GroupBox35.Text = "Loaded Output Devices"
        '
        'ListBoxOutputDevices
        '
        Me.ListBoxOutputDevices.BackColor = System.Drawing.Color.Moccasin
        Me.ListBoxOutputDevices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBoxOutputDevices.FormattingEnabled = True
        Me.ListBoxOutputDevices.ItemHeight = 20
        Me.ListBoxOutputDevices.Location = New System.Drawing.Point(6, 23)
        Me.ListBoxOutputDevices.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.ListBoxOutputDevices.Name = "ListBoxOutputDevices"
        Me.ListBoxOutputDevices.Size = New System.Drawing.Size(633, 280)
        Me.ListBoxOutputDevices.TabIndex = 0
        '
        'TabPageAvatars
        '
        Me.TabPageAvatars.Controls.Add(Me.GroupBox5)
        Me.TabPageAvatars.Location = New System.Drawing.Point(4, 29)
        Me.TabPageAvatars.Name = "TabPageAvatars"
        Me.TabPageAvatars.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageAvatars.Size = New System.Drawing.Size(651, 584)
        Me.TabPageAvatars.TabIndex = 8
        Me.TabPageAvatars.Text = "Avatars"
        Me.TabPageAvatars.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Black
        Me.GroupBox5.BackgroundImage = CType(resources.GetObject("GroupBox5.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox5.Controls.Add(Me.ListBoxAvatars)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.ForeColor = System.Drawing.Color.Aqua
        Me.GroupBox5.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(645, 578)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Avatars"
        '
        'ListBoxAvatars
        '
        Me.ListBoxAvatars.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBoxAvatars.FormattingEnabled = True
        Me.ListBoxAvatars.ItemHeight = 20
        Me.ListBoxAvatars.Location = New System.Drawing.Point(4, 23)
        Me.ListBoxAvatars.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBoxAvatars.Name = "ListBoxAvatars"
        Me.ListBoxAvatars.Size = New System.Drawing.Size(637, 551)
        Me.ListBoxAvatars.TabIndex = 0
        '
        'TabPanelControlBar
        '
        Me.TabPanelControlBar.BackgroundImage = Global.VB_IDE.My.Resources.Resources.App_Texturex16
        Me.TabPanelControlBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPanelControlBar.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.TabPanelControlBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButtonTabControl})
        Me.TabPanelControlBar.Location = New System.Drawing.Point(0, 0)
        Me.TabPanelControlBar.Name = "TabPanelControlBar"
        Me.TabPanelControlBar.Size = New System.Drawing.Size(659, 39)
        Me.TabPanelControlBar.TabIndex = 7
        Me.TabPanelControlBar.Text = "ToolStrip2"
        '
        'ToolStripDropDownButtonTabControl
        '
        Me.ToolStripDropDownButtonTabControl.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ToolStripDropDownButtonTabControl.BackgroundImage = Global.VB_IDE.My.Resources.Resources.App_Texturex17
        Me.ToolStripDropDownButtonTabControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripDropDownButtonTabControl.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SDKToolStripMenuItem, Me.ProjectToolStripMenuItem, Me.InteractiveREPLToolStripMenuItem})
        Me.ToolStripDropDownButtonTabControl.Image = Global.VB_IDE.My.Resources.Resources.App_Close
        Me.ToolStripDropDownButtonTabControl.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButtonTabControl.Name = "ToolStripDropDownButtonTabControl"
        Me.ToolStripDropDownButtonTabControl.Size = New System.Drawing.Size(75, 36)
        Me.ToolStripDropDownButtonTabControl.Text = "Tabs"
        '
        'SDKToolStripMenuItem
        '
        Me.SDKToolStripMenuItem.BackgroundImage = CType(resources.GetObject("SDKToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.SDKToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SDKToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PluginsToolStripMenuItem1, Me.UpdatesToolStripMenuItem1, Me.DevicesToolStripMenuItem, Me.AvatarsToolStripMenuItem1})
        Me.SDKToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SDKToolStripMenuItem.Name = "SDKToolStripMenuItem"
        Me.SDKToolStripMenuItem.Size = New System.Drawing.Size(174, 38)
        Me.SDKToolStripMenuItem.Text = "SDK"
        '
        'PluginsToolStripMenuItem1
        '
        Me.PluginsToolStripMenuItem1.BackgroundImage = CType(resources.GetObject("PluginsToolStripMenuItem1.BackgroundImage"), System.Drawing.Image)
        Me.PluginsToolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PluginsToolStripMenuItem1.ForeColor = System.Drawing.Color.Yellow
        Me.PluginsToolStripMenuItem1.Image = Global.VB_IDE.My.Resources.Resources.FileIcon_Extensions
        Me.PluginsToolStripMenuItem1.Name = "PluginsToolStripMenuItem1"
        Me.PluginsToolStripMenuItem1.Size = New System.Drawing.Size(133, 38)
        Me.PluginsToolStripMenuItem1.Text = "Plugins"
        '
        'UpdatesToolStripMenuItem1
        '
        Me.UpdatesToolStripMenuItem1.BackgroundImage = CType(resources.GetObject("UpdatesToolStripMenuItem1.BackgroundImage"), System.Drawing.Image)
        Me.UpdatesToolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UpdatesToolStripMenuItem1.ForeColor = System.Drawing.Color.Yellow
        Me.UpdatesToolStripMenuItem1.Image = Global.VB_IDE.My.Resources.Resources.FileIcon_Extensions
        Me.UpdatesToolStripMenuItem1.Name = "UpdatesToolStripMenuItem1"
        Me.UpdatesToolStripMenuItem1.Size = New System.Drawing.Size(133, 38)
        Me.UpdatesToolStripMenuItem1.Text = "Updates"
        '
        'DevicesToolStripMenuItem
        '
        Me.DevicesToolStripMenuItem.BackgroundImage = CType(resources.GetObject("DevicesToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.DevicesToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DevicesToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow
        Me.DevicesToolStripMenuItem.Image = Global.VB_IDE.My.Resources.Resources.FileIcon_Extensions
        Me.DevicesToolStripMenuItem.Name = "DevicesToolStripMenuItem"
        Me.DevicesToolStripMenuItem.Size = New System.Drawing.Size(133, 38)
        Me.DevicesToolStripMenuItem.Text = "Devices"
        '
        'AvatarsToolStripMenuItem1
        '
        Me.AvatarsToolStripMenuItem1.BackgroundImage = CType(resources.GetObject("AvatarsToolStripMenuItem1.BackgroundImage"), System.Drawing.Image)
        Me.AvatarsToolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AvatarsToolStripMenuItem1.ForeColor = System.Drawing.Color.Yellow
        Me.AvatarsToolStripMenuItem1.Image = Global.VB_IDE.My.Resources.Resources.FileIcon_Extensions
        Me.AvatarsToolStripMenuItem1.Name = "AvatarsToolStripMenuItem1"
        Me.AvatarsToolStripMenuItem1.Size = New System.Drawing.Size(133, 38)
        Me.AvatarsToolStripMenuItem1.Text = "Avatars"
        '
        'ProjectToolStripMenuItem
        '
        Me.ProjectToolStripMenuItem.BackgroundImage = CType(resources.GetObject("ProjectToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.ProjectToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ProjectToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AssemblysToolStripMenuItem, Me.EmbededFilesToolStripMenuItem, Me.FilesToolStripMenuItem})
        Me.ProjectToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProjectToolStripMenuItem.Image = Global.VB_IDE.My.Resources.Resources.App_Group
        Me.ProjectToolStripMenuItem.Name = "ProjectToolStripMenuItem"
        Me.ProjectToolStripMenuItem.Size = New System.Drawing.Size(174, 38)
        Me.ProjectToolStripMenuItem.Text = "Project"
        '
        'AssemblysToolStripMenuItem
        '
        Me.AssemblysToolStripMenuItem.BackColor = System.Drawing.Color.Cyan
        Me.AssemblysToolStripMenuItem.BackgroundImage = CType(resources.GetObject("AssemblysToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.AssemblysToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AssemblysToolStripMenuItem.ForeColor = System.Drawing.Color.Cyan
        Me.AssemblysToolStripMenuItem.Image = Global.VB_IDE.My.Resources.Resources.App_Floder
        Me.AssemblysToolStripMenuItem.Name = "AssemblysToolStripMenuItem"
        Me.AssemblysToolStripMenuItem.Size = New System.Drawing.Size(166, 38)
        Me.AssemblysToolStripMenuItem.Text = "Assemblys"
        '
        'EmbededFilesToolStripMenuItem
        '
        Me.EmbededFilesToolStripMenuItem.BackColor = System.Drawing.Color.Cyan
        Me.EmbededFilesToolStripMenuItem.BackgroundImage = CType(resources.GetObject("EmbededFilesToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.EmbededFilesToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EmbededFilesToolStripMenuItem.ForeColor = System.Drawing.Color.Cyan
        Me.EmbededFilesToolStripMenuItem.Image = Global.VB_IDE.My.Resources.Resources.App_Floder
        Me.EmbededFilesToolStripMenuItem.Name = "EmbededFilesToolStripMenuItem"
        Me.EmbededFilesToolStripMenuItem.Size = New System.Drawing.Size(166, 38)
        Me.EmbededFilesToolStripMenuItem.Text = "Embeded Files"
        '
        'FilesToolStripMenuItem
        '
        Me.FilesToolStripMenuItem.BackColor = System.Drawing.Color.Cyan
        Me.FilesToolStripMenuItem.BackgroundImage = CType(resources.GetObject("FilesToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.FilesToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FilesToolStripMenuItem.ForeColor = System.Drawing.Color.Cyan
        Me.FilesToolStripMenuItem.Image = Global.VB_IDE.My.Resources.Resources.App_Floder
        Me.FilesToolStripMenuItem.Name = "FilesToolStripMenuItem"
        Me.FilesToolStripMenuItem.Size = New System.Drawing.Size(166, 38)
        Me.FilesToolStripMenuItem.Text = "Files"
        '
        'InteractiveREPLToolStripMenuItem
        '
        Me.InteractiveREPLToolStripMenuItem.BackgroundImage = CType(resources.GetObject("InteractiveREPLToolStripMenuItem.BackgroundImage"), System.Drawing.Image)
        Me.InteractiveREPLToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.InteractiveREPLToolStripMenuItem.Checked = True
        Me.InteractiveREPLToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.InteractiveREPLToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.InteractiveREPLToolStripMenuItem.Image = Global.VB_IDE.My.Resources.Resources.APP_icon_Terminal
        Me.InteractiveREPLToolStripMenuItem.Name = "InteractiveREPLToolStripMenuItem"
        Me.InteractiveREPLToolStripMenuItem.Size = New System.Drawing.Size(174, 38)
        Me.InteractiveREPLToolStripMenuItem.Text = "Interactive REPL"
        '
        'FormCompiler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1782, 656)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Berkeley Oldstyle", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FormCompiler"
        Me.Text = "WorkSpace"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ToolStripMainFileControl.ResumeLayout(False)
        Me.ToolStripMainFileControl.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.SpydazWebTabcontrolScripts.ResumeLayout(False)
        Me.TabPageScript.ResumeLayout(False)
        Me.MenuStripScriptTabsEditor.ResumeLayout(False)
        Me.MenuStripScriptTabsEditor.PerformLayout()
        Me.ToolStripScriptDevlopment.ResumeLayout(False)
        Me.ToolStripScriptDevlopment.PerformLayout()
        Me.TabControlFileBrowsers.ResumeLayout(False)
        Me.TabPageInteractiveReplScript.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ToolStripInteractiveRepl.ResumeLayout(False)
        Me.ToolStripInteractiveRepl.PerformLayout()
        Me.TabPageObjectBrowser.ResumeLayout(False)
        Me.GroupBox38.ResumeLayout(False)
        Me.GroupBox39.ResumeLayout(False)
        Me.TabPageFileList.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.TabPageEmbeddedFiles.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStripEmbeddedFiles.ResumeLayout(False)
        Me.ToolStripEmbeddedFiles.PerformLayout()
        Me.TabPageAssemblies.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStripAssemblies.ResumeLayout(False)
        Me.ToolStripAssemblies.PerformLayout()
        Me.TabPagePlugins.ResumeLayout(False)
        Me.GroupBox30.ResumeLayout(False)
        Me.TabPageUpdates.ResumeLayout(False)
        Me.GroupBox32.ResumeLayout(False)
        Me.TabPageDevices.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.GroupBox34.ResumeLayout(False)
        Me.GroupBox35.ResumeLayout(False)
        Me.TabPageAvatars.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.TabPanelControlBar.ResumeLayout(False)
        Me.TabPanelControlBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents ToolStripMainFileControl As ToolStrip
    Friend WithEvents ToolStripSeparator24 As ToolStripSeparator
    Friend WithEvents ButtonProject As ToolStripDropDownButton
    Friend WithEvents LosdProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator25 As ToolStripSeparator
    Friend WithEvents ButtonBuild As ToolStripDropDownButton
    Friend WithEvents ExecuteToolStripREPL As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ExeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DLLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton5 As ToolStripDropDownButton
    Friend WithEvents ProjectNameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripTextBoxProjectName As ToolStripTextBox
    Friend WithEvents MainClassNameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripTextBoxMainClassName As ToolStripTextBox
    Friend WithEvents ExecuteFunctionNAmeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripTextBoxFunctionName As ToolStripTextBox
    Friend WithEvents SetProgrammingLanguageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripComboBoxProgLang As ToolStripComboBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents MenuStripScriptTabsEditor As MenuStrip
    Friend WithEvents InsertDesignPatternToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripScriptDevlopment As ToolStrip
    Friend WithEvents DevNewToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem12 As ToolStripMenuItem
    Friend WithEvents ConsoleScriptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComponentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PluginToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeviceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InputDeviceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsoleAppToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OutputDeviceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DevOpenToolStripButton As ToolStripButton
    Friend WithEvents DevSaveToolStripButton As ToolStripButton
    Friend WithEvents DevSaveAsToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents DevCutToolStripSeparator As ToolStripSeparator
    Friend WithEvents DevCutToolStripButton As ToolStripButton
    Friend WithEvents DevCopyToolStripButton As ToolStripButton
    Friend WithEvents DevPasteToolStripButton As ToolStripButton
    Friend WithEvents DevRedoToolStripButton As ToolStripButton
    Friend WithEvents DevUndoToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents DevPrintToolStripButton As ToolStripButton
    Friend WithEvents DevHelpToolStripButton As ToolStripButton
    Friend WithEvents SpydazWebTabcontrolScripts As SpydazWebTabcontrol
    Friend WithEvents TabPageScript As TabPage
    Friend WithEvents SpydazWebLineNumbering1 As SpydazWebLineNumbering
    Friend WithEvents ToolStripComboBoxFONTFAMILY As ToolStripComboBox
    Friend WithEvents ToolStripComboBoxFONT_SIZE As ToolStripComboBox
    Friend WithEvents TabControlFileBrowsers As TabControl
    Friend WithEvents TabPageEmbeddedFiles As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckedListBoxEmbeddedFiles As CheckedListBox
    Friend WithEvents ToolStripEmbeddedFiles As ToolStrip
    Friend WithEvents AddEmbededFileToolStripMenuItem As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents RemoveEmbeddedFileToolStripMenuItem As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents TabPageAssemblies As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckedListBoxAssemblys As CheckedListBox
    Friend WithEvents ToolStripAssemblies As ToolStrip
    Friend WithEvents AddAssemblyToolStripMenuItem As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents RemoveAssemblyToolStripMenuItem As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents TabPageObjectBrowser As TabPage
    Friend WithEvents GroupBox39 As GroupBox
    Friend WithEvents TreeViewObjectSyntax As TreeView
    Friend WithEvents CreateFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButtonExtensions As ToolStripDropDownButton
    Friend WithEvents PluginsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AvatarsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InputDevicesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OutputDevicesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents InsertSnipetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XmlSerializerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XmlDeserializerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BinaryReaderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BinaryWriterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextReaderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextWriterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QueueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HashToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TreeviewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OLEDBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileStreamToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MDIFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReadURLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModalFormMovementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShareSouceCodeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator32 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem9 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator33 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents REPL_SCRIPT As SpydazWebTextBox
    Friend WithEvents NewConsoleScriptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearFilesToolStripMenuItem As ToolStripButton
    Friend WithEvents ClearAssemblyToolStripMenuItem As ToolStripButton
    Friend WithEvents TabPageInteractiveReplScript As TabPage
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents InteractiveReplScript As SpydazWebTextBox
    Friend WithEvents SpydazWebLineNumbering2 As SpydazWebLineNumbering
    Friend WithEvents ToolStripInteractiveRepl As ToolStrip
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents ToolStripButtonExecuteInteractive As ToolStripButton
    Friend WithEvents ToolStripSeparator13 As ToolStripSeparator
    Friend WithEvents ToolStripButtonClearInteractive As ToolStripButton
    Friend WithEvents ToolStripTextBoxClassNameInteractive As ToolStripTextBox
    Friend WithEvents ToolStripTextBoxFunctionNameInteractive As ToolStripTextBox
    Friend WithEvents GroupBox38 As GroupBox
    Friend WithEvents RichTextBoxCompilerInfo As RichTextBox
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripButton
    Friend WithEvents ScriptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabPagePlugins As TabPage
    Friend WithEvents GroupBox30 As GroupBox
    Friend WithEvents CheckedListLoadedPlugins As CheckedListBox
    Friend WithEvents TabPageUpdates As TabPage
    Friend WithEvents GroupBox32 As GroupBox
    Friend WithEvents CheckedUpdates As CheckedListBox
    Friend WithEvents TabPageDevices As TabPage
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents GroupBox34 As GroupBox
    Friend WithEvents ListBoxInputDevices As ListBox
    Friend WithEvents GroupBox35 As GroupBox
    Friend WithEvents ListBoxOutputDevices As ListBox
    Friend WithEvents TabPageAvatars As TabPage
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents ListBoxAvatars As ListBox
    Friend WithEvents TabPageFileList As TabPage
    Friend WithEvents SplitContainer4 As SplitContainer
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents ListBoxFileDirectory As ListBox
    Friend WithEvents TabPanelControlBar As ToolStrip
    Friend WithEvents ToolStripDropDownButtonTabControl As ToolStripDropDownButton
    Friend WithEvents SDKToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PluginsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UpdatesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DevicesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AvatarsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AssemblysToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmbededFilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InteractiveREPLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonOpenDir As Button
    Friend WithEvents ButtonCloseScriptTab As ToolStripMenuItem
End Class
