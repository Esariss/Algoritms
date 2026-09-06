Imports System

Module Ex
    Sub MaxInThreeNumbers()
        Dim a As Integer = Integer.Parse(Console.ReadLine())
        Dim b As Integer = Integer.Parse(Console.ReadLine())
        Dim c As Integer = Integer.Parse(Console.ReadLine())

        Dim max As Integer = a

        If b > max Then
            max = b
        End If

        If c > max Then
            max = c
        End If

        Console.WriteLine(max)
    End Sub
End Module

