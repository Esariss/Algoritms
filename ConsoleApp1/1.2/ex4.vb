Imports System

Module Ex4
    sub IntType()
        Dim a as Integer = Integer.Parse(Console.ReadLine())
        If a = 0 Then
            Console.WriteLine("a is 0")
        Else If a < 0 Then
            Console.WriteLine("a is minus")
        Else 
            Console.WriteLine("a is plus")
        End If
        
    End sub
End Module