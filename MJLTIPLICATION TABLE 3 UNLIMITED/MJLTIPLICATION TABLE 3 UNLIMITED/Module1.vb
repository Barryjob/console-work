Module Module1

    Sub Main()
        Dim count, result As Integer
        Dim x, u As String

        Console.WriteLine("MULTIPLICATION TABLE CALCULATOR")

        Console.WriteLine("enter the number")
        x = Console.ReadLine()

        Console.WriteLine("enter the length on the table")
        u = Console.ReadLine()


        For count = 1 To u
            Console.WriteLine(x + " X " & count & "=" & count * x)
        Next

        Console.WriteLine("===============================================================================================")
        Console.WriteLine()
        For i As Integer = 1 To u
            For j As Integer = 1 To x
                ' Console.WriteLine(x + " X " & count & "=" & count * x)
                'Console.Write(i * j & vbTab)
                result = 1 * j
                Console.WriteLine(i.ToString & " X " & x.ToString & "=" & result & vbTab)
            Next
            Console.WriteLine()
        Next

        Console.ReadLine()
    End Sub

End Module
