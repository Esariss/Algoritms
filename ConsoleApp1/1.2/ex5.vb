Imports System



Module Ex5
    
    Function FactorialReqursive(n as Integer) as Integer
        If n = 0 or n = 1 Then
            Return 1        
        End If  
        Return n * FactorialReqursive(n - 1)
    End Function
    
    Function FactorialCicle(n as Integer) as Integer
        Dim result as Integer = 1
        
        For i as Integer = 1 to n
            result *= i
        Next
        return result
        
    End Function

    
    Sub Main()
        Dim n as Integer = Integer.Parse(Console.ReadLine())
        Dim f as String = Console.ReadLine()
        
        if f = "r" Then
           Console.WriteLine(FactorialReqursive(n))
        Else
            Console.WriteLine(FactorialCicle(n))
        End If
        
        
    End Sub
End Module