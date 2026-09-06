Imports System

Module Ex2
    Sub isPolidromeChechk()
        Dim text As String = Console.ReadLine()
        Dim isPolidrome As Boolean = True

        For i As Integer = 0 To text.Length \ 2 - 1
            If text(i) <> text(text.Length - 1 - i) Then
                isPolidrome = False
                Exit For
            End If
        Next 

        Console.WriteLine(isPolidrome)
    End Sub
End Module

