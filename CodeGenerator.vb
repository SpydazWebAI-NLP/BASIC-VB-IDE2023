Imports System.IO
Imports Newtonsoft.Json.Linq
Imports VB_Repl.UserInputHelper


Public Class UserInputHelper
    Public Shared Function GetInput(prompt As String, title As String, inputType As UserInputType) As String
        Dim userInput As String = ""

        Select Case inputType
            Case UserInputType.StringInput
                userInput = InputBox(prompt, title)
            Case UserInputType.IntegerInput
                Dim intInput As Integer
                Dim inputValid As Boolean = False
                Do Until inputValid
                    Dim userInputStr = InputBox(prompt, title)
                    If Integer.TryParse(userInputStr, intInput) Then
                        userInput = intInput.ToString()
                        inputValid = True
                    Else
                        MessageBox.Show("Invalid input. Please enter a valid integer.")
                    End If
                Loop
            Case UserInputType.DoubleInput
                Dim doubleInput As Double
                Dim inputValid As Boolean = False
                Do Until inputValid
                    Dim userInputStr = InputBox(prompt, title)
                    If Double.TryParse(userInputStr, doubleInput) Then
                        userInput = doubleInput.ToString()
                        inputValid = True
                    Else
                        MessageBox.Show("Invalid input. Please enter a valid number.")
                    End If
                Loop
            Case UserInputType.CommaSeparatedList
                userInput = InputBox(prompt, title)
        End Select

        Return userInput
    End Function
    ' Enums
    Public Enum UserInputType
        StringInput
        IntegerInput
        DoubleInput
        CommaSeparatedList
        CodeSnippet
    End Enum

    Public Enum ListType
        StringList
        IntegerList
        DoubleList
    End Enum

    Public Shared Function GetCodeSnippet(prompt As String, title As String) As String
        Dim codeSnippet As String = InputBox(prompt, title)
        Return codeSnippet
    End Function

    Public Shared Function getCommaSeparatedList(input As String, listType As ListType) As List(Of Object)
        Dim parsedList As New List(Of Object)

        Dim items = input.Split(","c)
        For Each item In items
            Select Case listType
                Case ListType.StringList
                    parsedList.Add(item)
                Case ListType.IntegerList
                    Dim intValue As Integer
                    If Integer.TryParse(item, intValue) Then
                        parsedList.Add(intValue)
                    End If
                Case ListType.DoubleList
                    Dim doubleValue As Double
                    If Double.TryParse(item, doubleValue) Then
                        parsedList.Add(doubleValue)
                    End If
            End Select
        Next

        Return parsedList
    End Function

End Class
Public Class CodeGenerator
    Private Shared ReadOnly Indentation As String = "    " ' Adjust the indentation as needed

    Public Enum ControlFlowType
        IfThen
        DoWhile
        SelectCase
    End Enum

    Public Shared Function GetControlFlowCode(controlFlowType As ControlFlowType) As String
        Dim codeSnippet As String = ""

        Select Case controlFlowType
            Case ControlFlowType.IfThen
                Dim condition = InputBox("Enter the condition:", "If-Then Condition")
                Dim action = UserInputHelper.GetCodeSnippet("Enter the action for the 'Then' block:", "Then Action")
                codeSnippet = $"If {condition} Then{vbCrLf}{Indentation}{action}{vbCrLf}End If"
            Case ControlFlowType.DoWhile
                Dim condition = InputBox("Enter the condition:", "Do-While Condition")
                Dim action = UserInputHelper.GetCodeSnippet("Enter the action:", "Do-While Action")
                codeSnippet = $"Do While {condition}{vbCrLf}{Indentation}{action}{vbCrLf}Loop"
            Case ControlFlowType.SelectCase
                Dim selector = InputBox("Enter the selector:", "Select Case Selector")
                Dim caseConditions = UserInputHelper.GetCodeSnippet("Enter the case conditions:", "case Conditions")
                Dim caseActions = UserInputHelper.GetCodeSnippet("Enter the actions for each case:", "case actions")
                codeSnippet = $"Select Case {selector}{vbCrLf}{GenerateCaseBlock(caseConditions, caseActions)}{Indentation}Case Else{vbCrLf}{Indentation}{Indentation}' Add default action here{vbCrLf}{Indentation}End Select"
        End Select

        Return codeSnippet
    End Function

    Public Shared Function GenerateCaseBlock(caseConditions As String, caseActions As String) As String
        Dim caseBlocks As New List(Of String)
        Dim caseBlock = $"{Indentation}Case {caseConditions}{vbCrLf}{Indentation}{Indentation}{caseActions}{vbCrLf}"
        caseBlocks.Add(caseBlock)

        Return String.Join("", caseBlocks)
    End Function

    Public Shared Function GenerateNamespace(namespaceName As String, className As String, classContent As String) As String
        Dim namespaceTemplate As String = $"{Indentation}Namespace {namespaceName}{vbCrLf}" &
                                          $"{Indentation}{"Public Class"} {className}{vbCrLf}" &
                                          $"{classContent}{vbCrLf}" &
                                          $"{Indentation}{"End Class"}{vbCrLf}" &
                                          $"{Indentation}End Namespace"
        Return namespaceTemplate
    End Function

    Public Shared Function GenerateFunction(functionName As String, returnType As String, parameters As Dictionary(Of String, String)) As String
        Dim paramList As String = String.Join(", ", parameters.Select(Function(param) $"{param.Value} {param.Key}"))
        Dim functionTemplate As String = $"{Indentation}Public Function {functionName}({paramList}) As {returnType}{vbCrLf}" &
                                        $"{Indentation}    ' Add function logic here" & vbCrLf &
                                        $"{Indentation}End Function"
        Return functionTemplate
    End Function

    Public Shared Function GenerateSub(subName As String, parameters As Dictionary(Of String, String)) As String
        Dim paramList As String = String.Join(", ", parameters.Select(Function(param) $"{param.Value} {param.Key}"))
        Dim subTemplate As String = $"{Indentation}Public Sub {subName}({paramList}){vbCrLf}" &
                                    $"{Indentation}    ' Add sub logic here" & vbCrLf &
                                    $"{Indentation}End Sub"
        Return subTemplate
    End Function

    Public Shared Function RenameFunction(originalFunction As String, newFunctionName As String) As String
        Return originalFunction.Replace($"Function {originalFunction}", $"Function {newFunctionName}")
    End Function

    Public Shared Function RenameSub(originalSub As String, newSubName As String) As String
        Return originalSub.Replace($"Sub {originalSub}", $"Sub {newSubName}")
    End Function

    Public Shared Function RenameClass(originalClass As String, newClassName As String) As String
        Return originalClass.Replace($"Public Class {originalClass}", $"Public Class {newClassName}")
    End Function
    Public Shared Function GenerateCreateMethod(className As String, createParameters As Dictionary(Of String, String)) As String
        Dim paramList As String = String.Join(", ", createParameters.Select(Function(param) $"{param.Value} {param.Key}"))
        Dim createMethodTemplate As String = $"{Indentation}Public Sub Create{className}({paramList}){vbCrLf}" &
                                             $"{Indentation}    ' Add create logic here" & vbCrLf &
                                             $"{Indentation}End Sub"
        Return createMethodTemplate
    End Function

    Public Shared Function GenerateReadMethod(className As String, readParameters As Dictionary(Of String, String)) As String
        Dim paramList As String = String.Join(", ", readParameters.Select(Function(param) $"{param.Value} {param.Key}"))
        Dim readMethodTemplate As String = $"{Indentation}Public Function Read{className}({paramList}) As {className}{vbCrLf}" &
                                           $"{Indentation}    ' Add read logic here" & vbCrLf &
                                           $"{Indentation}End Function"
        Return readMethodTemplate
    End Function

    Public Shared Function GenerateUpdateMethod(className As String, updateParameters As Dictionary(Of String, String)) As String
        Dim paramList As String = String.Join(", ", updateParameters.Select(Function(param) $"{param.Value} {param.Key}"))
        Dim updateMethodTemplate As String = $"{Indentation}Public Sub Update{className}({paramList}){vbCrLf}" &
                                             $"{Indentation}    ' Add update logic here" & vbCrLf &
                                             $"{Indentation}End Sub"
        Return updateMethodTemplate
    End Function

    Public Shared Function GenerateDeleteMethod(className As String, deleteParameters As Dictionary(Of String, String)) As String
        Dim paramList As String = String.Join(", ", deleteParameters.Select(Function(param) $"{param.Value} {param.Key}"))
        Dim deleteMethodTemplate As String = $"{Indentation}Public Sub Delete{className}({paramList}){vbCrLf}" &
                                             $"{Indentation}    ' Add delete logic here" & vbCrLf &
                                             $"{Indentation}End Sub"
        Return deleteMethodTemplate
    End Function
End Class
Public Class IntentDetector
    Sub Main()
        IntentDetector.HandleInteraction()
    End Sub
    Public Shared Function DetectIntent(userInput As String) As String
        ' Implement your intent detection logic here
        ' Example logic:
        If userInput.Contains("create") Then
            Return "create"
        ElseIf userInput.Contains("read") Then
            Return "read"
        ElseIf userInput.Contains("update") Then
            Return "update"
        ElseIf userInput.Contains("delete") Then
            Return "delete"
        Else
            Return "unknown"
        End If
    End Function
    Public Shared Sub FillSlots(intent As String, slots As Dictionary(Of String, String))
        Select Case intent
            Case "create"
                Dim className = UserInputHelper.GetInput("Enter the name of the class:", "Create Class", UserInputType.StringInput)
                slots.Add("className", className)
            Case "read"
                Dim className = UserInputHelper.GetInput("Enter the name of the class:", "Read Class", UserInputType.StringInput)
                slots.Add("className", className)
            Case "update"
                Dim className = UserInputHelper.GetInput("Enter the name of the class:", "Update Class", UserInputType.StringInput)
                slots.Add("className", className)
            Case "delete"
                Dim className = UserInputHelper.GetInput("Enter the name of the class:", "Delete Class", UserInputType.StringInput)
                slots.Add("className", className)
        End Select
    End Sub
    Public Shared Sub HandleInteraction()
        Dim userInput = InputBox("Enter your request:", "User Input")

        Dim detectedIntent = IntentDetector.DetectIntent(userInput)
        If detectedIntent = "unknown" Then
            MessageBox.Show("Sorry, I didn't understand your request.")
            Return
        End If

        Dim confirmed = IntentDetector.ConfirmIntent(detectedIntent)
        If Not confirmed Then
            MessageBox.Show("Intent not confirmed. Aborting.")
            Return
        End If

        Dim slots As New Dictionary(Of String, String)
        FillSlots(detectedIntent, slots)

        Dim objectOrientedModelSnippet = SnippetDatabase.GetObjectOrientedModelSnippet(SnippetDatabase.ObjectOrientedModelType._Class)
        Dim nlpProjectSnippet = SnippetDatabase.GetNLPProjectSnippet(SnippetDatabase.NLPProjectType.POSTagging)

        ' Display generated snippets or integrate into code generation process
        MessageBox.Show($"Generated Object-Oriented Model: {objectOrientedModelSnippet}{vbCrLf}" &
                        $"Generated NLP Project Snippet: {nlpProjectSnippet}")
    End Sub
    Public Shared Function ConfirmIntent(intent As String) As Boolean
        Dim confirmation = MessageBox.Show($"Detected intent: {intent}. Is this correct?", "Confirm Intent", MessageBoxButtons.YesNo)
        Return (confirmation = DialogResult.Yes)
    End Function
End Class
Public Class SnippetDatabase
    Public Enum ObjectOrientedModelType
        _Class
        _Interface
        _AbstractClass
        _Inheritance
        _Polymorphism
    End Enum

    Public Enum NLPProjectType
        POSTagging
        NamedEntityRecognition
        SentimentDetection
        Tokenization
        Similarity
        NeuralNetworkGeneration
        BasicLanguageModeling
    End Enum
    Private Shared ReadOnly SnippetFilePath As String = "snippets.json"

    Public Shared Function GetObjectOrientedModelSnippets(modelType As ObjectOrientedModelType) As String
        Dim json = File.ReadAllText(SnippetFilePath)
        Dim snippets = JObject.Parse(json)("objectOrientedModels")
        Return snippets(modelType.ToString()).ToString()
    End Function

    Public Shared Function GetNLPProjectSnippets(projectType As NLPProjectType) As String
        Dim json = File.ReadAllText(SnippetFilePath)
        Dim snippets = JObject.Parse(json)("nlpProjects")
        Return snippets(projectType.ToString()).ToString()
    End Function

    Public Shared Function GetObjectOrientedModelSnippet(modelType As ObjectOrientedModelType) As String
        Select Case modelType
            Case ObjectOrientedModelType._Class
                Return "Public Class MyClass" & vbCrLf & "End Class"
            Case ObjectOrientedModelType._Interface
                Return "Public Interface MyInterface" & vbCrLf & "End Interface"
            Case ObjectOrientedModelType._AbstractClass
                Return "Public MustInherit Class MyAbstractClass" & vbCrLf & "End Class"
            Case ObjectOrientedModelType._Inheritance
                Return "Public Class ChildClass" & vbCrLf & "    Inherits ParentClass" & vbCrLf & "End Class"
            Case ObjectOrientedModelType._Polymorphism
                Return "Public Class Dog" & vbCrLf & "    Public Overrides Sub MakeSound()" & vbCrLf & "        Console.WriteLine(""Bark!"")" & vbCrLf & "    End Sub" & vbCrLf & "End Class"
            Case Else
                Return ""
        End Select
    End Function

    Public Shared Function GetNLPProjectSnippet(projectType As NLPProjectType) As String
        Select Case projectType
            Case NLPProjectType.POSTagging
                Return "Dim taggedWords = POSTagger.TagWords(sentence)"
            Case NLPProjectType.NamedEntityRecognition
                Return "Dim entities = NER.RecognizeEntities(text)"
            Case NLPProjectType.SentimentDetection
                Return "Dim sentiment = SentimentAnalyzer.AnalyzeSentiment(text)"
            Case NLPProjectType.Tokenization
                Return "Dim tokens = Tokenizer.Tokenize(text)"
            Case NLPProjectType.Similarity
                Return "Dim similarityScore = SimilarityCalculator.CalculateSimilarity(text1, text2)"
            Case NLPProjectType.NeuralNetworkGeneration
                Return "Dim neuralNetwork = NeuralNetworkBuilder.BuildNetwork(layers)"
            Case NLPProjectType.BasicLanguageModeling
                Return "Dim languageModel = LanguageModelBuilder.BuildModel(corpus)"
            Case Else
                Return ""
        End Select
    End Function
End Class

