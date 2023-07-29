Imports System.Drawing.Text
Imports System.IO
Imports System.Reflection
Imports VB_Repl
Imports VB_Repl.Controls
Imports VB_Repl.TabControls
Imports VB_Repl.TabControls.MasterTabControl
Public Class FormCompiler
    Dim Assemblys As List(Of String)
    Dim EmbeddedFiles As List(Of String)
    Private LoadedTypes As New List(Of Type)

    Private Syntax As New List(Of String)

    Private Sub FormCompiler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFonts()
        LoadAssemblys()
        LoadDir(Application.StartupPath)
        RemoveSDKTabs()
        RemoveNonProjectTabs()

    End Sub

    Public Sub RemoveNonProjectTabs()
        TabControlFileBrowsers.TabPages.Remove(TabPageInteractiveReplScript)

    End Sub

    Public Sub RemoveSDKTabs()
        TabControlFileBrowsers.TabPages.Remove(TabPageDevices)
        DevicesToolStripMenuItem.Checked = False
        TabControlFileBrowsers.TabPages.Remove(TabPageUpdates)
        UpdatesToolStripMenuItem1.Checked = False
        TabControlFileBrowsers.TabPages.Remove(TabPagePlugins)
        PluginsToolStripMenuItem1.Checked = False
        TabControlFileBrowsers.TabPages.Remove(TabPageAvatars)
        AvatarsToolStripMenuItem1.Checked = False
    End Sub

    Public Sub LoadDir(ByRef FolderNme As String)
        Dim FilePaths As String() = Directory.GetFiles(FolderNme)
        Dim Lst As New List(Of String)
        For Each item In FilePaths
            Dim file As New FileInfo(item)
            Lst.Add(file.Name)
        Next
        ListBoxFileDirectory.Items.Clear()
        For Each item In Lst
            ListBoxFileDirectory.Items.Add(item)
        Next

    End Sub

    Private Sub DevicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevicesToolStripMenuItem.Click
        If DevicesToolStripMenuItem.Checked = False Then

            TabControlFileBrowsers.TabPages.Add(TabPageDevices)
            DevicesToolStripMenuItem.Checked = True
        Else

            TabControlFileBrowsers.TabPages.Remove(TabPageDevices)
            DevicesToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub AvatarsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AvatarsToolStripMenuItem1.Click

        If AvatarsToolStripMenuItem1.Checked = False Then

            TabControlFileBrowsers.TabPages.Add(TabPageAvatars)
            AvatarsToolStripMenuItem1.Checked = True
        Else

            TabControlFileBrowsers.TabPages.Remove(TabPageAvatars)
            AvatarsToolStripMenuItem1.Checked = False
        End If
    End Sub

    Private Sub InteractiveREPLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InteractiveREPLToolStripMenuItem.Click

        If InteractiveREPLToolStripMenuItem.Checked = False Then

            TabControlFileBrowsers.TabPages.Add(TabPageInteractiveReplScript)
            InteractiveREPLToolStripMenuItem.Checked = True
        Else

            TabControlFileBrowsers.TabPages.Remove(TabPageInteractiveReplScript)
            InteractiveREPLToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub UpdatesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UpdatesToolStripMenuItem1.Click

        If UpdatesToolStripMenuItem1.Checked = False Then

            TabControlFileBrowsers.TabPages.Add(TabPageUpdates)
            UpdatesToolStripMenuItem1.Checked = True
        Else

            TabControlFileBrowsers.TabPages.Remove(TabPageUpdates)
            UpdatesToolStripMenuItem1.Checked = False
        End If
    End Sub

    Private Sub PluginsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PluginsToolStripMenuItem1.Click
        If PluginsToolStripMenuItem1.Checked = False Then

            TabControlFileBrowsers.TabPages.Add(TabPagePlugins)
            PluginsToolStripMenuItem1.Checked = True
        Else

            TabControlFileBrowsers.TabPages.Remove(TabPagePlugins)
            PluginsToolStripMenuItem1.Checked = False
        End If

    End Sub

    Private Sub ToolStripButtonMainCloseTab_Click(sender As Object, e As EventArgs)
        If SpydazWebTabcontrolScripts.SelectedTab IsNot TabPageScript Then
            RemoveTab(SpydazWebTabcontrolScripts, SpydazWebTabcontrolScripts.TabCount)
        End If

    End Sub

#Region "ObjectBrowser"

    Public Structure MethodItem
        Public TypeMethod As String
        Public TypeMethodInfo As MethodInfo
        Public TypeName As String
    End Structure

    Public Sub UpdateSyntax()
        REPL_SCRIPT.MySyntax.AddRange(Syntax)

        For Each item In SpydazWebTabcontrolScripts.TabPages

            If SpydazWebTabcontrol.GetSyntaxTextBox(item) IsNot Nothing Then
                SpydazWebTabcontrol.GetSyntaxTextBox(item).MySyntax.AddRange(Syntax)
                SpydazWebTabcontrol.GetSyntaxTextBox(item).HighlightInternalSyntax
            Else
                SpydazWebTabcontrol.GetCurrentTabRichTextBox(item).HighlightInternalSyntax
            End If
        Next
    End Sub

    Public Sub UpdateTreeViewControl(ByRef TrContol As TreeView, Types As List(Of Type))

        Dim nTypes As List(Of MethodItem) = GetMethodsList(Types)

        Dim Lst As New List(Of String)
        For Each mtype As MethodItem In nTypes

            If Lst.Contains(mtype.TypeName) Then
            Else
                Lst.Add(mtype.TypeName)
            End If
        Next

        For Each str As String In Lst

            Dim node As New System.Windows.Forms.TreeNode
            node.Text = str
            For Each mytype As MethodItem In nTypes
                If mytype.TypeName = str Then
                    node.Nodes.Add("<" & mytype.TypeMethod & ">" & " Syntax:  " & vbNewLine & mytype.TypeMethodInfo.ToString & " #")

                End If
            Next
            TrContol.Nodes.Add(node)
        Next

    End Sub

    Private Sub TreeViewObjectSyntax_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeViewObjectSyntax.AfterSelect
        Dim Str As String = ""
        Str = TreeViewObjectSyntax.SelectedNode.ToString & vbNewLine
        RichTextBoxCompilerInfo.Text = If(Str.Contains("Syntax: ") = True, Str.ExtractStringBetween("Syntax: ", " #").Replace("Syntax:", ""), Str.Replace("TreeNode:", ""))

    End Sub

#End Region

#Region "COMPILER"

    Public Sub LoadAssemblys()


        AddAssembly(Application.StartupPath & "\System.dll")
        AddAssembly(Application.StartupPath & "\System.Speech.dll")
        AddAssembly(Application.StartupPath & "\System.Web.Extensions.dll")
        AddAssembly(Application.StartupPath & "\System.Windows.Forms.dll")
        AddAssembly(Application.StartupPath & "\Microsoft.VisualBasic.dll")

        'AddAssembly(Application.StartupPath & "\AI_AGENT.dll")
        'AddAssembly(Application.StartupPath & "\AI_SDK.dll")
        '

    End Sub

    ''' <summary>
    ''' Adds Assembly to combo
    ''' </summary>
    ''' <param name="Path"></param>
    Public Sub AddAssembly(ByRef Path As String)
        On Error Resume Next
        Dim Found As Boolean = False
        For Each item In Assemblys
            If item = Path = True Then
                Found = True
            Else

            End If
        Next
        If Found = False Then
            Dim ass As Assembly = Assembly.LoadFrom(Path)

            '  TrContol.ForeColor

            If ass IsNot Nothing Then

                Assemblys.Add(Path)
                CheckedListBoxAssemblys.Items.Add(Path)
                Dim typ() As Type = ass.GetTypes()
                For Each t In typ
                    LoadedTypes.Add(t)
                    Syntax.Add(t.Name)
                Next
                TreeViewObjectSyntax.Nodes.Clear()
                UpdateTreeViewControl(TreeViewObjectSyntax, LoadedTypes)

            End If
        Else
        End If

        UpdateSyntax()
    End Sub

    Public Sub AddEmbeddedResource(ByRef Path As String)
        On Error Resume Next
        Dim Found As Boolean = False
        For Each item In EmbeddedFiles
            If item = Path = True Then
                Found = True
            Else

            End If
        Next
        If Found = False Then

            EmbeddedFiles.Add(Path)
            CheckedListBoxEmbeddedFiles.Items.Add(Path)
        Else
        End If
    End Sub

    Public Function GetMethodsList(ByRef Types As List(Of Type)) As List(Of MethodItem)
        Dim Lst As New List(Of MethodItem)
        'Dim Types As List(Of Type) = TypeReader.Addtypes
        For Each MyType As Type In Types
            Dim NewItem As New MethodItem
            ' Get the public methods.
            Dim myArrayMethodInfo As MethodInfo() = MyType.GetMethods((BindingFlags.Public Or
                                                                      BindingFlags.Instance Or
                                                                      BindingFlags.DeclaredOnly Or
                                                                    BindingFlags.Static))

            Dim i As Integer
            For i = 0 To myArrayMethodInfo.Length - 1
                Dim myMethodInfo As MethodInfo = myArrayMethodInfo(i)
                NewItem.TypeName = MyType.FullName
                NewItem.TypeMethod = myMethodInfo.Name
                NewItem.TypeMethodInfo = myMethodInfo
                Lst.Add(NewItem)
            Next i
        Next
        Return Lst
    End Function

    Private Sub AddAssemblyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddAssemblyToolStripMenuItem.Click
        'CheckedListBoxAssemblys
        If Assemblys Is Nothing Then
            Assemblys = New List(Of String)
        Else
        End If
        Dim Scriptfile As String = ""
        Dim Ofile As New OpenFileDialog
        With Ofile
            .Filter = "DLL Assembly files (*.DLL)|*.dll"
            If (.ShowDialog() = DialogResult.OK) Then
                Scriptfile = .FileName
            End If
        End With
        AddAssembly(Scriptfile)
    End Sub

    Private Sub RemoveAssemblyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveAssemblyToolStripMenuItem.Click
        If CheckedListBoxAssemblys.CheckedItems IsNot Nothing Then
            If Assemblys Is Nothing Then
            Else
                For Each item In CheckedListBoxAssemblys.CheckedItems
                    Assemblys.Remove(item)
                Next

            End If
        End If
    End Sub

    Private Sub RemoveEmbeddedFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveEmbeddedFileToolStripMenuItem.Click
        If CheckedListBoxEmbeddedFiles.CheckedItems IsNot Nothing Then
            If EmbeddedFiles Is Nothing Then
            Else
                For Each item In CheckedListBoxEmbeddedFiles.CheckedItems
                    EmbeddedFiles.Remove(item)
                Next
            End If
        End If
    End Sub

    Private Sub AddEmbededFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddEmbededFileToolStripMenuItem.Click
        If EmbeddedFiles Is Nothing Then
            EmbeddedFiles = New List(Of String)
        Else
            'CheckedListBoxEmbeddedFiles
        End If
        Dim Scriptfile As String = ""
        Dim Ofile As New OpenFileDialog
        With Ofile
            .Filter = "Resource files (*.*)|*.*"

            If (.ShowDialog() = DialogResult.OK) Then
                Scriptfile = .FileName
            End If
        End With

        AddEmbeddedResource(Scriptfile)
    End Sub

    Private Sub ClearAssemblyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAssemblyToolStripMenuItem.Click
        If Assemblys Is Nothing Then
        Else
            Assemblys = Nothing
            CheckedListBoxAssemblys.Items.Clear()
        End If
    End Sub

    Private Sub ClearFilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearFilesToolStripMenuItem.Click
        If EmbeddedFiles Is Nothing Then
        Else
            EmbeddedFiles = Nothing
            CheckedListBoxEmbeddedFiles.Items.Clear()
        End If
    End Sub

    ''' <summary>
    ''' Compiles Code from Text TabControl
    ''' </summary>
    ''' <param name="Sender">Tabcontrol Is used to return error Result </param>
    ''' <param name="CodeBlock">Text To be Compiled</param>
    ''' <param name="iClassName">ClassName Required For Executing Code in Memory</param>
    ''' <param name="iMethodName">Required for executing Code in Memory</param>
    ''' <param name="Assemblies">Referenced Assemblies</param>
    ''' <param name="EmbededFiles">Referenced Embedded Files</param>
    ''' <param name="CompileType">EXE/MEM/DLL</param>
    Public Shared Sub VB_Tab_CodeCompiler(ByRef Sender As TabControl, CodeBlock As String,
                                          Optional ByRef CompileType As String = "DLL",
                                          Optional ByRef iClassName As String = "MainClass",
                                          Optional iMethodName As String = "Execute",
                                          Optional Assemblies As List(Of String) = Nothing,
                                          Optional ByRef EmbededFiles As List(Of String) = Nothing)

        Const Lang As String = "VisualBasic"
        Speaker.Speak("Compiler Started")
        'The CreateProvider method returns a CodeDomProvider instance for the specified language name.
        'This instance is later used when we have finished specifying the parameter values.
        Dim Compiler As CodeDom.Compiler.CodeDomProvider = CodeDom.Compiler.CodeDomProvider.CreateProvider(Lang)
        'Optionally, this could be called Parameters.
        'Think of parameters as settings or specific values passed to a method (later passed to CompileAssemblyFromSource method).
        Dim Settings As New CodeDom.Compiler.CompilerParameters
        'The CompileAssemblyFromSource method returns a CompilerResult that will be stored in this variable.
        Dim Result As CodeDom.Compiler.CompilerResults = Nothing
        Dim ExecuteableName As String = ""
        If EmbededFiles Is Nothing Then EmbededFiles = New List(Of String)

        Try
            Speaker.Speak("Adding Embedded resources")
            'handle Embedded Resources
            If EmbededFiles IsNot Nothing And EmbededFiles.Count > 0 Then
                For Each str As String In EmbededFiles
                    Settings.EmbeddedResources.Add(str)
                Next
            End If
        Catch ex As Exception
            Speaker.Speak("There is a problem with a resource")
        End Try

        Try
            Speaker.Speak("Adding Assemblys")
            If Assemblies IsNot Nothing And Assemblies.Count > 0 Then
                For Each str As String In Assemblies
                    Settings.ReferencedAssemblies.Add(str)
                Next
            End If
        Catch ex As Exception
            Speaker.Speak("There is a problem with an reference assembly")
        End Try
        'Must Always be added
        Settings.ReferencedAssemblies.Add("System.Windows.Forms.dll")
        Settings.ReferencedAssemblies.Add("Microsoft.VisualBasic.dll")
        Settings.ReferencedAssemblies.Add("System.dll")

#Region "COMPILER"

        Select Case CompileType
            Case "EXE"
                Speaker.Speak("Compile EXE")
                Dim S As New SaveFileDialog
                With S

                    .Filter = "Executable (*.exe)|*.exe"
                    If (.ShowDialog() = DialogResult.OK) Then
                        ExecuteableName = .FileName
                    End If
                End With
                'Library type options : /target:library, /target:win, /target:winexe
                'Generates an executable instead of a class library.
                'Compiles in memory.
                Settings.GenerateInMemory = True
                Settings.GenerateExecutable = True
                Settings.CompilerOptions = " /target:winexe"
                'Set the assembly file name / path
                Settings.OutputAssembly = ExecuteableName
                'Read the documentation for the result again variable.
                'Calls the CompileAssemblyFromSource that will compile the specified source code using the parameters specified in the settings variable.
                Result = Compiler.CompileAssemblyFromSource(Settings, CodeBlock)
            Case "MEM"
                Speaker.Speak("Executing")
                'Compiles in memory.
                Settings.GenerateInMemory = True
                'Read the documentation for the result again variable.
                'Calls the CompileAssemblyFromSource that will compile the specified source code using the parameters specified in the settings variable.
                Result = Compiler.CompileAssemblyFromSource(Settings, CodeBlock)

                'If Assembly error = true then
                'Return Errors
                'Else
                If Result.Errors.HasErrors = True Then

                    Speaker.Speak("There are some issues to be handled")

                    For Each ITEM In Result.Errors
                        SpydazWebTabcontrol.AddPopulatedTextTab(Sender, Sender.TabPages.Count, ITEM.ERRORTEXT, "ERROR")
                    Next
                Else
                    'Creates assembly
                    Dim objAssembly As System.Reflection.Assembly = Result.CompiledAssembly
                    'Creates instance
                    Dim objTheClass As Object = objAssembly.CreateInstance(iClassName)
                    'CheckInstance
                    If objTheClass Is Nothing Then
                        '     MsgBox("Can't load class...MainClass")
                        Speaker.Speak("Error i Can't load class, " & iClassName)
                        SpydazWebTabcontrol.AddPopulatedTextTab(Sender, Sender.TabPages.Count, "Can't load class..." & iClassName, "ERROR")
                        Exit Sub
                    End If
                    'Trys to execute
                    Try
                        objTheClass.GetType.InvokeMember(iMethodName,
                            System.Reflection.BindingFlags.InvokeMethod, Nothing, objTheClass, Nothing)
                    Catch ex As Exception
                        '  MsgBox("Error:" & ex.Message)
                        Speaker.Speak("Error i Can't load Main Function, " & iMethodName)
                        SpydazWebTabcontrol.AddPopulatedTextTab(Sender, Sender.TabPages.Count, "Error:" & ex.Message, "ERROR")
                        Speaker.Speak("Woops")
                    End Try
                End If

            Case "DLL"
                Speaker.Speak("Create Library")
                Dim S As New SaveFileDialog
                With S
                    .Filter = "Executable (*.Dll)|*.Dll"
                    If (.ShowDialog() = DialogResult.OK) Then
                        ExecuteableName = .FileName
                    End If
                End With
                'Library type options : /target:library, /target:win, /target:winexe
                'Generates an executable instead of a class library.
                'Compiles in memory.
                Settings.GenerateInMemory = False
                Settings.GenerateExecutable = False
                Settings.CompilerOptions = " /target:library"
                'Set the assembly file name / path
                Settings.OutputAssembly = ExecuteableName
                'Read the documentation for the result again variable.
                'Calls the CompileAssemblyFromSource that will compile the specified source code using the parameters specified in the settings variable.
                Result = Compiler.CompileAssemblyFromSource(Settings, CodeBlock)
        End Select

#End Region

#Region "Errors"

        'Determines if we have any errors when compiling if so loops through all of the CompileErrors in the Reults variable and displays their ErrorText property.
        If (Result.Errors.Count <> 0) Then
            Speaker.Speak("Error Exception")
            SpydazWebTabcontrol.AddPopulatedTextTab(Sender, Sender.TabPages.Count, vbNewLine & "Exception Occured!", "ERROR")

            '  MessageBox.Show("Exception Occured!", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            For Each E As CodeDom.Compiler.CompilerError In Result.Errors

                SpydazWebTabcontrol.AddPopulatedTextTab(Sender, Sender.TabPages.Count, vbNewLine & E.ErrorText, "ERROR")

            Next
        ElseIf (Result.Errors.Count = 0) And CompileType = "EXE" Or CompileType = "DLL" Then
            Speaker.Speak("file saved " & ExecuteableName)
            SpydazWebTabcontrol.AddPopulatedTextTab(Sender, Sender.TabPages.Count, vbNewLine & "file saved at " & ExecuteableName, "ERROR")

        End If

#End Region

    End Sub

    Private Shared Speaker As New Speech.Synthesis.SpeechSynthesizer

    Public Shared Async Sub VB_Tab_CodeCompilerAsync(ByVal Sender As TabControl, CodeBlock As String,
                                          Optional ByVal CompileType As String = "DLL",
                                          Optional ByVal iClassName As String = "MainClass",
                                          Optional iMethodName As String = "Execute",
                                          Optional Assemblies As List(Of String) = Nothing,
                                         Optional ByVal EmbededFiles As List(Of String) = Nothing)
        Try
            Speaker.Speak("Compiling")
            Await Task.Run(Sub() VB_Tab_CodeCompiler(Sender, CodeBlock, CompileType, iClassName, iMethodName, Assemblies, EmbededFiles))
        Catch ex As Exception
        End Try
    End Sub

    Public Sub RunInteractive()
        Try
            Dim Code As String = ""
            Code = InteractiveReplScript.Text
            VB_Tab_CodeCompilerAsync(TabControlFileBrowsers, Code, "MEM", ToolStripTextBoxClassNameInteractive.Text, ToolStripTextBoxFunctionNameInteractive.Text)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub DLLToolStripMenuItemScript_Click(sender As Object, e As EventArgs) Handles DLLToolStripMenuItem.Click
        Dim AssemblysII As New List(Of String)
        For Each item In CheckedListBoxAssemblys.SelectedItems
            AssemblysII.Add(item)
        Next
        'AssemblysII.Add("AI_AGENT.dll")
        'AssemblysII.Add("AI_SDK.dll")

        Dim EmbeddedII As New List(Of String)
        For Each item In CheckedListBoxEmbeddedFiles.SelectedItems
            EmbeddedII.Add(item)
        Next
        If SpydazWebTabcontrolScripts.SelectedTab IsNot Nothing Then
            If SpydazWebTabcontrol.GetCurrentTabRichTextBox(SpydazWebTabcontrolScripts) IsNot Nothing Then
                VB_Tab_CodeCompiler(SpydazWebTabcontrolScripts, SpydazWebTabcontrol.GetCurrentTabRichTextBox(SpydazWebTabcontrolScripts).Text, "DLL", ToolStripTextBoxMainClassName.Text, ToolStripTextBoxFunctionName.Text, AssemblysII, EmbeddedII)
            Else
                If SpydazWebTabcontrol.GetCurrentTabSyntaxTextBox(SpydazWebTabcontrolScripts) IsNot Nothing Then
                    VB_Tab_CodeCompiler(SpydazWebTabcontrolScripts, SpydazWebTabcontrol.GetCurrentTabSyntaxTextBox(SpydazWebTabcontrolScripts).Text, "DLL", ToolStripTextBoxMainClassName.Text, ToolStripTextBoxFunctionName.Text, AssemblysII, EmbeddedII)
                Else

                End If
            End If
        Else
            If SpydazWebTabcontrolScripts.SelectedTab IsNot Nothing Then
                If SpydazWebTabcontrol.GetCurrentTabRichTextBox(SpydazWebTabcontrolScripts) IsNot Nothing Then
                    VB_Tab_CodeCompiler(SpydazWebTabcontrolScripts, SpydazWebTabcontrol.GetCurrentTabRichTextBox(SpydazWebTabcontrolScripts).Text, "DLL", ToolStripTextBoxMainClassName.Text, ToolStripTextBoxFunctionName.Text, AssemblysII, EmbeddedII)
                Else
                    If SpydazWebTabcontrol.GetCurrentTabSyntaxTextBox(SpydazWebTabcontrolScripts) IsNot Nothing Then
                        VB_Tab_CodeCompiler(SpydazWebTabcontrolScripts, SpydazWebTabcontrol.GetCurrentTabSyntaxTextBox(SpydazWebTabcontrolScripts).Text, "DLL", ToolStripTextBoxMainClassName.Text, ToolStripTextBoxFunctionName.Text, AssemblysII, EmbeddedII)
                    Else

                    End If
                End If
            Else
            End If
        End If
    End Sub

    Private Sub ExeToolStripMenuItemScript_Click(sender As Object, e As EventArgs) Handles ExeToolStripMenuItem.Click
        Dim AssemblysII As New List(Of String)
        For Each item In CheckedListBoxAssemblys.SelectedItems
            AssemblysII.Add(item)
        Next
        'AssemblysII.Add("AI_AGENT.dll")
        'AssemblysII.Add("AI_SDK.dll")

        Dim EmbeddedII As New List(Of String)
        For Each item In CheckedListBoxEmbeddedFiles.SelectedItems
            EmbeddedII.Add(item)
        Next
        If SpydazWebTabcontrolScripts.SelectedTab IsNot Nothing Then
            If SpydazWebTabcontrol.GetCurrentTabRichTextBox(SpydazWebTabcontrolScripts) IsNot Nothing Then
                VB_Tab_CodeCompiler(SpydazWebTabcontrolScripts, SpydazWebTabcontrol.GetCurrentTabRichTextBox(SpydazWebTabcontrolScripts).Text, "EXE", ToolStripTextBoxMainClassName.Text, ToolStripTextBoxFunctionName.Text, AssemblysII, EmbeddedII)
            Else
                If SpydazWebTabcontrol.GetCurrentTabSyntaxTextBox(SpydazWebTabcontrolScripts) IsNot Nothing Then
                    VB_Tab_CodeCompiler(SpydazWebTabcontrolScripts, SpydazWebTabcontrol.GetCurrentTabSyntaxTextBox(SpydazWebTabcontrolScripts).Text, "EXE", ToolStripTextBoxMainClassName.Text, ToolStripTextBoxFunctionName.Text, AssemblysII, EmbeddedII)
                Else

                End If
            End If
        Else
            If SpydazWebTabcontrolScripts.SelectedTab IsNot Nothing Then
                If SpydazWebTabcontrol.GetCurrentTabRichTextBox(SpydazWebTabcontrolScripts) IsNot Nothing Then
                    VB_Tab_CodeCompiler(SpydazWebTabcontrolScripts, SpydazWebTabcontrol.GetCurrentTabRichTextBox(SpydazWebTabcontrolScripts).Text, "EXE", ToolStripTextBoxMainClassName.Text, ToolStripTextBoxFunctionName.Text, AssemblysII, EmbeddedII)
                Else
                    If SpydazWebTabcontrol.GetCurrentTabSyntaxTextBox(SpydazWebTabcontrolScripts) IsNot Nothing Then
                        VB_Tab_CodeCompiler(SpydazWebTabcontrolScripts, SpydazWebTabcontrol.GetCurrentTabSyntaxTextBox(SpydazWebTabcontrolScripts).Text, "EXE", ToolStripTextBoxMainClassName.Text, ToolStripTextBoxFunctionName.Text, AssemblysII, EmbeddedII)
                    Else

                    End If
                End If
            Else
            End If
        End If
    End Sub

    Private Sub ExecuteToolStripREPL_Click(sender As Object, e As EventArgs) Handles ExecuteToolStripREPL.Click
        VB_Tab_CodeCompiler(SpydazWebTabcontrolScripts, REPL_SCRIPT.Text, "MEM", ToolStripTextBoxMainClassName.Text, ToolStripTextBoxFunctionName.Text, Assemblys, EmbeddedFiles)
    End Sub

    Private Sub ToolStripButtonExecuteInteractive_Click(sender As Object, e As EventArgs) Handles ToolStripButtonExecuteInteractive.Click
        RunInteractive()
    End Sub

    Private Sub ToolStripButtonClearInteractive_Click(sender As Object, e As EventArgs) Handles ToolStripButtonClearInteractive.Click
        InteractiveReplScript.Clear()
    End Sub

#End Region

#Region "Text_toolbar"

#Region "Fonts"

    Public Shared Sub ChangeFontSize(ByRef Sender As TabControl, ByRef FntSize As Integer)
        If SpydazWebTabcontrol.GetCurrentTabRichTextBox(Sender) IsNot Nothing Then
            If Sender.TabPages.Count > 0 Then
                If SpydazWebTabcontrol.GetCurrentTabRichTextBox(Sender) IsNot Nothing Then
                    SpydazWebTabcontrol.GetCurrentTabRichTextBox(Sender).SelectionFont = New Font(FntSize.ToString, FntSize, SpydazWebTabcontrol.GetCurrentTabRichTextBox(Sender).SelectionFont.Style)
                End If
            End If
        Else
            If Sender.TabPages.Count > 0 Then
                If SpydazWebTabcontrol.GetCurrentTabSyntaxTextBox(Sender) IsNot Nothing Then
                    SpydazWebTabcontrol.GetCurrentTabSyntaxTextBox(Sender).SelectionFont = New Font(FntSize.ToString, FntSize, SpydazWebTabcontrol.GetCurrentTabSyntaxTextBox(Sender).SelectionFont.Style)
                End If
            End If
        End If
    End Sub

    Public Shared Sub ChangeFont(ByRef Sender As TabControl, ByRef SenderFontFamily As String)
        Dim ComboFonts As System.Drawing.Font
        If SpydazWebTabcontrol.GetCurrentTabRichTextBox(Sender) IsNot Nothing Then
            Try
                ComboFonts = SpydazWebTabcontrol.GetCurrentTabRichTextBox(Sender).SelectionFont
                SpydazWebTabcontrol.GetCurrentTabRichTextBox(Sender).SelectionFont = New System.Drawing.Font(SenderFontFamily, SpydazWebTabcontrol.GetCurrentTabRichTextBox(Sender).SelectionFont.Size, SpydazWebTabcontrol.GetCurrentTabRichTextBox(Sender).SelectionFont.Style)
            Catch ex As Exception
                '   MsgBox(ex.Message)
            End Try
        Else
            If SpydazWebTabcontrol.GetCurrentTabSyntaxTextBox(Sender) IsNot Nothing Then
                Try
                    ComboFonts = SpydazWebTabcontrol.GetCurrentTabSyntaxTextBox(Sender).SelectionFont
                    SpydazWebTabcontrol.GetCurrentTabSyntaxTextBox(Sender).SelectionFont = New System.Drawing.Font(SenderFontFamily, SpydazWebTabcontrol.GetCurrentTabSyntaxTextBox(Sender).SelectionFont.Size, SpydazWebTabcontrol.GetCurrentTabSyntaxTextBox(Sender).SelectionFont.Style)
                Catch ex As Exception
                    '   MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub ToolStripComboBoxFONT_SIZE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolStripComboBoxFONT_SIZE.SelectedIndexChanged
        If SpydazWebTabcontrolScripts.SelectedTab IsNot Nothing Then
            ChangeFontSize(SpydazWebTabcontrolScripts, ToolStripComboBoxFONT_SIZE)
        Else
            If SpydazWebTabcontrolScripts.SelectedTab IsNot Nothing Then
                ChangeFontSize(SpydazWebTabcontrolScripts, ToolStripComboBoxFONT_SIZE)
            End If
        End If
    End Sub

    Private Sub ToolStripComboBoxFONTFAMILY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolStripComboBoxFONTFAMILY.SelectedIndexChanged
        If SpydazWebTabcontrolScripts.SelectedTab IsNot Nothing Then
            ChangeFont(SpydazWebTabcontrolScripts, ToolStripComboBoxFONTFAMILY)
        Else
            If SpydazWebTabcontrolScripts.SelectedTab IsNot Nothing Then
                ChangeFont(SpydazWebTabcontrolScripts, ToolStripComboBoxFONTFAMILY)
            End If
        End If
    End Sub

    Public Sub ChangeFont(ByRef Sender As TabControl, ByRef CmboSender As ToolStripComboBox)
        Dim ComboFonts As System.Drawing.Font
        If GetCurrentTabRichTextBox(Sender) IsNot Nothing Then
            Try
                ComboFonts = GetCurrentTabRichTextBox(Sender).SelectionFont
                GetCurrentTabRichTextBox(Sender).SelectionFont = New System.Drawing.Font(CmboSender.Text, GetCurrentTabRichTextBox(Sender).SelectionFont.Size, GetCurrentTabRichTextBox(Sender).SelectionFont.Style)
            Catch ex As Exception
                '   MsgBox(ex.Message)
            End Try
        Else
            If GetCurrentTabSyntaxTextBox(Sender) IsNot Nothing Then
                Try
                    ComboFonts = GetCurrentTabSyntaxTextBox(Sender).SelectionFont
                    GetCurrentTabSyntaxTextBox(Sender).SelectionFont = New System.Drawing.Font(CmboSender.Text, GetCurrentTabSyntaxTextBox(Sender).SelectionFont.Size, GetCurrentTabSyntaxTextBox(Sender).SelectionFont.Style)
                Catch ex As Exception
                    '   MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Public Sub LoadFonts()
        For fntSize = 10 To 75
            ToolStripComboBoxFONT_SIZE.Items.Add(fntSize)
        Next
        Dim fonts As New InstalledFontCollection()
        For fntFamily As Integer = 0 To fonts.Families.Length - 1

            ToolStripComboBoxFONTFAMILY.Items.Add(fonts.Families(fntFamily).Name)
        Next
    End Sub

    Public Sub ChangeFontSize(ByRef Sender As TabControl, ByRef CmboSender As ToolStripComboBox)
        If GetCurrentTabRichTextBox(Sender) IsNot Nothing Then
            If Sender.TabPages.Count > 0 Then
                If GetCurrentTabRichTextBox(Sender) IsNot Nothing Then
                    GetCurrentTabRichTextBox(Sender).SelectionFont = New Font(CmboSender.SelectedItem.ToString, CInt(CmboSender.SelectedItem.ToString), GetCurrentTabRichTextBox(Sender).SelectionFont.Style)
                End If
            End If
        Else
            If GetCurrentTabSyntaxTextBox(Sender) IsNot Nothing Then
                If Sender.TabPages.Count > 0 Then
                    If GetCurrentTabSyntaxTextBox(Sender) IsNot Nothing Then
                        GetCurrentTabSyntaxTextBox(Sender).SelectionFont = New Font(CmboSender.SelectedItem.ToString, CInt(CmboSender.SelectedItem.ToString), GetCurrentTabSyntaxTextBox(Sender).SelectionFont.Style)
                    End If
                End If
            End If
        End If
    End Sub

#End Region

#Region "Cut/Copy/Paste/Redo/Undo/SelectAll"

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevUndoToolStripButton.Click
        If SpydazWebTabcontrolScripts.SelectedTab IsNot Nothing Then
            Undo(SpydazWebTabcontrolScripts)
        Else
            If SpydazWebTabcontrolScripts.SelectedTab IsNot Nothing Then
                Undo(SpydazWebTabcontrolScripts)
            End If
        End If
    End Sub

    Private Sub CopyToolStripButton_Click(sender As Object, e As EventArgs) Handles DevCopyToolStripButton.Click
        If SpydazWebTabcontrolScripts.SelectedTab IsNot Nothing Then
            Copy(SpydazWebTabcontrolScripts)
        Else
            If SpydazWebTabcontrolScripts.SelectedTab IsNot Nothing Then
                Copy(SpydazWebTabcontrolScripts)
            End If
        End If
    End Sub

    Private Sub CutToolStripButton_Click(sender As Object, e As EventArgs) Handles DevCutToolStripButton.Click
        If SpydazWebTabcontrolScripts.SelectedTab IsNot Nothing Then
            Cut(SpydazWebTabcontrolScripts)
        Else
            If SpydazWebTabcontrolScripts.SelectedTab IsNot Nothing Then
                Cut(SpydazWebTabcontrolScripts)
            End If
        End If
    End Sub

    Private Sub PasteToolStripButton_Click(sender As Object, e As EventArgs) Handles DevPasteToolStripButton.Click
        If SpydazWebTabcontrolScripts.SelectedTab IsNot Nothing Then
            Paste(SpydazWebTabcontrolScripts)
        Else
            If SpydazWebTabcontrolScripts.SelectedTab IsNot Nothing Then
                Paste(SpydazWebTabcontrolScripts)
            End If
        End If
    End Sub

    Private Sub PrintToolStripButton_Click(sender As Object, e As EventArgs) Handles DevPrintToolStripButton.Click

    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevRedoToolStripButton.Click
        If SpydazWebTabcontrolScripts.SelectedTab IsNot Nothing Then
            Redo(SpydazWebTabcontrolScripts)
        Else
            If SpydazWebTabcontrolScripts.SelectedTab IsNot Nothing Then
                Redo(SpydazWebTabcontrolScripts)
            End If
        End If
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click

    End Sub

#End Region

    Private Sub ToolStripButton_TEXT_BOLD_Click(sender As Object, e As EventArgs)
        If SpydazWebTabcontrolScripts.SelectedTab IsNot Nothing Then
            BOld(SpydazWebTabcontrolScripts)
        Else
            If SpydazWebTabcontrolScripts.SelectedTab IsNot Nothing Then
                BOld(SpydazWebTabcontrolScripts)
            End If
        End If
    End Sub

    Private Sub ToolStripButton_TEXT_ITALIC_Click(sender As Object, e As EventArgs)
        If SpydazWebTabcontrolScripts.SelectedTab IsNot Nothing Then
            Italic(SpydazWebTabcontrolScripts)
        Else
            If SpydazWebTabcontrolScripts.SelectedTab IsNot Nothing Then
                Italic(SpydazWebTabcontrolScripts)
            End If
        End If
    End Sub

    Private Sub ToolStripButton_TEXT_UNDERLINE_Click(sender As Object, e As EventArgs)
        If SpydazWebTabcontrolScripts.SelectedTab IsNot Nothing Then
            UnderLine(SpydazWebTabcontrolScripts)
        Else
            If SpydazWebTabcontrolScripts.SelectedTab IsNot Nothing Then
                UnderLine(SpydazWebTabcontrolScripts)
            End If
        End If
    End Sub

#Region "Alignment"

    Private Sub RIGHT_ALLIGN_TEXT_Click(sender As Object, e As EventArgs)
        If SpydazWebTabcontrolScripts.SelectedTab IsNot Nothing Then
            RightAlignment(SpydazWebTabcontrolScripts)
        Else
            If SpydazWebTabcontrolScripts.SelectedTab IsNot Nothing Then
                RightAlignment(SpydazWebTabcontrolScripts)
            End If
        End If
    End Sub

    Private Sub CENTER_ALLIGN_TEXT_Click(sender As Object, e As EventArgs)
        If SpydazWebTabcontrolScripts.SelectedTab IsNot Nothing Then
            CenterAlignment(SpydazWebTabcontrolScripts)
        Else
            If SpydazWebTabcontrolScripts.SelectedTab IsNot Nothing Then
                CenterAlignment(SpydazWebTabcontrolScripts)
            End If
        End If
    End Sub

    Private Sub LEFT_ALLIGN_TEXT_Click(sender As Object, e As EventArgs)

        If SpydazWebTabcontrolScripts.SelectedTab IsNot Nothing Then
            LeftAlignment(SpydazWebTabcontrolScripts)
        Else
            If SpydazWebTabcontrolScripts.SelectedTab IsNot Nothing Then
                LeftAlignment(SpydazWebTabcontrolScripts)
            End If
        End If
    End Sub

#End Region

    Private Sub ScriptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScriptToolStripMenuItem.Click
        If CheckTab(SpydazWebTabcontrolScripts.TabPages, "Scripting") = False Then
            AddEmptySyntaxTextTab(SpydazWebTabcontrolScripts)
        End If
    End Sub

    Private Sub DevOpenToolStripButton_Click(sender As Object, e As EventArgs) Handles DevOpenToolStripButton.Click
        If CheckTab(SpydazWebTabcontrolScripts.TabPages, "Scripting") = False Then
            LoadFile(SpydazWebTabcontrolScripts, "All")
        End If
    End Sub

#End Region

#Region "PROJECT"

    Private Sub LosdProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LosdProjectToolStripMenuItem.Click
        Dim jfolder As String = ""
        Dim flderbrwser As New FolderBrowserDialog
        If flderbrwser.ShowDialog = DialogResult.OK Then
            jfolder = flderbrwser.SelectedPath

            LoadDir(jfolder)
            Dim Proj As New Project
            Proj.LoadProject(jfolder)
            LoadProject(Proj)
        Else
        End If

    End Sub

    ''' <summary>
    ''' used to load project into interface
    ''' </summary>
    ''' <param name="Proj"></param>
    Public Sub LoadProject(ByRef Proj As Project)
        ToolStripTextBoxProjectName.Text = Proj.ProjectName
        ToolStripTextBoxMainClassName.Text = Proj.ClassName
        ToolStripTextBoxFunctionName.Text = Proj.FunctionName
        ToolStripComboBoxProgLang.SelectedItem = Proj.ProgrammingLanguage
        CheckedListBoxAssemblys.Items.Clear()
        CheckedListBoxEmbeddedFiles.Items.Clear()
        For Each item In Proj.EmbeddedFiles
            AddEmbeddedResource(item)
        Next
        CheckedListBoxAssemblys.Items.Clear()
        For Each item In Proj.Assemblys
            AddAssembly(item)

        Next
        REPL_SCRIPT.Text = Proj.ReplScript.Script
        For Each item In Proj.ScriptPages
            AddPopulatedSyntaxTextTab(SpydazWebTabcontrolScripts, SpydazWebTabcontrolScripts.TabCount, item.Script, "Script")
        Next
    End Sub

    Private Sub ButtonOpenDir_Click(sender As Object, e As EventArgs) Handles ButtonOpenDir.Click
        Dim jfolder As String = ""
        Dim flderbrwser As New FolderBrowserDialog
        If flderbrwser.ShowDialog = DialogResult.OK Then
            jfolder = flderbrwser.SelectedPath

            LoadDir(jfolder)
        End If
    End Sub

    Private Sub ToolStripScriptDevlopment_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStripScriptDevlopment.ItemClicked
        AddPopulatedSyntaxTextTab(SpydazWebTabcontrolScripts, SpydazWebTabcontrolScripts.TabCount, "", "Script")
    End Sub

    Private Sub ButtonCloseScriptTab_Click(sender As Object, e As EventArgs) Handles ButtonCloseScriptTab.Click

        If SpydazWebTabcontrolScripts.SelectedTab IsNot TabPageScript Then
            RemoveTab(SpydazWebTabcontrolScripts, SpydazWebTabcontrolScripts.TabCount)
        End If
    End Sub

    Private Sub FormCompiler_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Me.Close()
    End Sub

#End Region

End Class
