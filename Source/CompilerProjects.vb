Imports System.Web.Script.Serialization

Public Module CompilerProjects

    ''' <summary>
    ''' Used to Assemble Project from file
    ''' </summary>
    Public Class Project

        ''' <summary>
        ''' USed to hold Scripts
        ''' </summary>
        Public Class Script

            ''' <summary>
            ''' ScriptDocument Code
            ''' </summary>
            Public Script As String

        End Class

        ''' <summary>
        ''' PROG LANG SETTING
        ''' </summary>
        Public Enum ProgrammingLanguageType
            VisualBasic
            C#
        End Enum

        ''' <summary>
        ''' COMILER SETTING
        ''' </summary>
        Public Enum CompileType
            EXE
            DLL
        End Enum

        'Project Settings
        ''' <summary>
        ''' Name Of Project
        ''' </summary>
        Public ProjectName As String

        ''' <summary>
        ''' Compiler Setting -Main ClassName
        ''' </summary>
        Public ClassName As String

        ''' <summary>
        ''' Compiler Setting -MainFunction (Executed on Compile/Run
        ''' </summary>
        Public FunctionName As String

        ''' <summary>
        ''' MainExecutable Script
        ''' </summary>
        Public ReplScript As New Script

        'Compiler Settings
        ''' <summary>
        ''' Compiler - Programming Language VB.NET / C#
        ''' </summary>
        Public ProgrammingLanguage As ProgrammingLanguageType = ProgrammingLanguageType.VisualBasic

        ''' <summary>
        ''' Compiler Setting - EXE/DLL
        ''' </summary>
        Public CompileRType As CompileType = CompileType.EXE

        ''' <summary>
        ''' List of Workspace files (Not Executed or Compiled)
        ''' </summary>
        Public ScriptPages As New List(Of Script)

        'Compiler files
        ''' <summary>
        ''' Referenced Assemblies (Pathnames)
        ''' </summary>
        Public Assemblys As New List(Of String)

        ''' <summary>
        ''' Embedded files and resources (To be Embedded inside file)
        ''' </summary>
        Public EmbeddedFiles As New List(Of String)

        ''' <summary>
        ''' Loads Project object from file
        ''' </summary>
        ''' <param name="jfile"></param>
        ''' <returns></returns>
        Public Shared Function LoadJson(ByRef jfile As String) As Project
            Dim DeSerJson As New JavaScriptSerializer
            Dim proj As New Project
            Dim JsonStr As String = System.IO.File.ReadAllText(jfile)
            proj = DeSerJson.Deserialize(Of Project)(JsonStr)
            Return proj
        End Function

        ''' <summary>
        ''' Saves Project Object to File
        ''' </summary>
        ''' <param name="jfile"></param>
        Public Sub SaveJson(ByRef jfile As String)
            Dim SerJson As New JavaScriptSerializer
            Dim proj As Project = Me
            Dim JsonStr As String = SerJson.Serialize(proj)
            System.IO.File.WriteAllText(jfile, JsonStr)

        End Sub

        ''' <summary>
        ''' gets json from Project
        ''' </summary>
        ''' <returns></returns>
        Public Function GetJson() As String
            Dim SerJson As New JavaScriptSerializer
            Dim proj As Project = Me
            Dim JsonStr As String = SerJson.Serialize(proj)
            'System.IO.File.WriteAllText(jfile, JsonStr)
            Return JsonStr
        End Function

        ''' <summary>
        ''' Saves Project Based on Project Name the project is saved in the same folder name as the project name
        ''' 2 files (Repl Script + Project Settings)
        ''' ReplScript is saved Separate for outside Editing, And is reloaded into the project Each time
        ''' </summary>
        Public Sub SaveProject()
            Dim SerJson As New JavaScriptSerializer
            Dim proj As Project = Me
            Dim FileName As String = proj.ProjectName
            Dim FolderName As String = proj.ProjectName
            'ProjectFileText
            Dim JsonStr As String = SerJson.Serialize(proj)

            System.IO.File.WriteAllText(Application.StartupPath & "\Projects\" & FolderName & "\" & FileName & ".Prj", JsonStr)

            'ScriptFileText
            Dim MainCode As String = proj.ReplScript.Script

            System.IO.File.WriteAllText(Application.StartupPath & "\Projects\" & FolderName & "\" & FileName & ".VB", MainCode)
            For Each item In proj.Assemblys
                My.Computer.FileSystem.CopyDirectory(item, Application.StartupPath & "\Projects\References\" & FolderName & "\")
            Next
            For Each item In proj.EmbeddedFiles
                My.Computer.FileSystem.CopyDirectory(item, Application.StartupPath & "\Projects\Resources\" & FolderName & "\")
            Next
        End Sub

        ''' <summary>
        ''' Project Name And Folder name Must Be The Same
        ''' 2  Files Are loaded from Folder;
        ''' Project.Prj (settings)  Project.vb (script)
        ''' </summary>
        ''' <returns></returns>
        Public Function LoadProject() As Project
            Dim jfolder As String = ""
            Dim flderbrwser As New FolderBrowserDialog
            If flderbrwser.ShowDialog = DialogResult.OK Then
                jfolder = flderbrwser.SelectedPath
                Dim proj As Project = LoadJson(jfolder & "\Jfolder.Prj")
                proj.ReplScript.Script = System.IO.File.ReadAllText(jfolder & "\Jfolder.VB")

                Return proj
            Else
            End If
            Return Nothing
        End Function

        Public Function LoadProject(ByRef jfolder As String) As Project

            Dim proj As Project = LoadJson(jfolder & "\Jfolder.Prj")
            proj.ReplScript.Script = System.IO.File.ReadAllText(jfolder & "\Jfolder.VB")

            Return proj

        End Function

    End Class

End Module