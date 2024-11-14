Imports System.Collections.Specialized.BitVector32
Imports LLama
Imports LLama.Common

Public Class Form1
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim modelPath As String = "C:\Users\admin\Downloads\llama-2-7b-chat.Q2_K.gguf"

        Dim parameters = New ModelParams(modelPath) With {
            .ContextSize = 1024,
            .GpuLayerCount = 5
        }

        Dim model = LLamaWeights.LoadFromFile(parameters)
        Dim context = model.CreateContext(parameters)
        Dim executor = New InteractiveExecutor(context)

        Dim session = New ChatSession(executor, New ChatHistory())

        Dim inferenceParams = New InferenceParams() With {
            .MaxTokens = 256,
            .AntiPrompts = New List(Of String) From {"User:"}
        }

        Dim userInput As String = TextBox1.Text
        TextBox1.Clear()

        TextBox2.AppendText($"User: {userInput}{vbCrLf}Assistant: ")

        Dim response = Await session.ChatAsync(New ChatHistory.Message(AuthorRole.User, userInput),
                                               inferenceParams).ConfigureAwait(False)

        For Each Text In response
            TextBox2.AppendText(Text)
            Application.DoEvents()
        Next

        TextBox2.AppendText(vbCrLf & vbCrLf)
    End Sub
End Class