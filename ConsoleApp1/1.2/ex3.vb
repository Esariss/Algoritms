Imports System
Module Ex3
    Sub PlusCountInArr()
        Dim arr() As Integer = Console.ReadLine().Split(" "c).Select(Function(x) Integer.Parse(x)).ToArray()
        Dim count as Integer = 0
        for Each el as Integer In arr
            if el > 0 Then
                count += 1
            End If
        Next
        Console.WriteLine(count)
    End Sub
End Module