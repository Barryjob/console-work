Module Module1

    Sub Main()
        Dim count As Integer
        Dim x As String
        Dim repeat As Char
        Console.WriteLine("MULTIPLICATION TABLE CALCULATOR")
        Console.WriteLine("=================================")
        Console.WriteLine()
        Console.WriteLine("THIS PROGRAM IS TO CALCULATE MULTIPLICATION TABLE FROM 1 TO 10")
        Console.WriteLine("==============================================================")
        Console.WriteLine()
        Console.WriteLine("Press 1 to 10")
        x = Console.ReadLine()
        Do Until repeat = "m"
            If x = "1" Then
                For count = 1 To 12
                    Console.WriteLine("1 X " & count & "=" & count * 1)
                Next

            ElseIf x = "2" Then
                For count = 1 To 12
                    Console.WriteLine("2 X " & count & "=" & count * 2)
                Next

            ElseIf x = "3" Then
                For count = 1 To 12
                    Console.WriteLine("3 X " & count & "=" & count * 3)
                Next

            ElseIf x = "4" Then
                For count = 1 To 12
                    Console.WriteLine("4 X " & count & "=" & count * 4)
                Next

            ElseIf x = "5" Then
                For count = 1 To 12
                    Console.WriteLine("5 X " & count & "=" & count * 5)
                Next

            ElseIf x = "6" Then
                For count = 1 To 12
                    Console.WriteLine("6 X " & count & "=" & count * 6)
                Next

            ElseIf x = "7" Then
                For count = 1 To 12
                    Console.WriteLine("7 X " & count & "=" & count * 7)
                Next

            ElseIf x = "8" Then
                For count = 1 To 12
                    Console.WriteLine("8 X " & count & "=" & count * 8)
                Next

            ElseIf x = "9" Then
                For count = 1 To 12
                    Console.WriteLine("9 X " & count & "=" & count * 9)
                Next

            ElseIf x = "10" Then
                For count = 1 To 12
                    Console.WriteLine("10 X " & count & "=" & count * 10)
                Next

            Else
                Console.WriteLine("Invalid Input")
            End If

            Console.WriteLine("===============================================================================================")

            For i As Integer = 1 To 12
                For j As Integer = 1 To 10
                    Console.Write(i * j & vbTab)
                Next
                Console.WriteLine()
            Next
            Console.WriteLine("Press any letter to continue")
            Console.WriteLine("press m to exit")
            repeat = Console.ReadLine()
        Loop


        Console.ReadLine()
    End Sub

End Module
