Module Module1

    Sub Main()

        Dim first_number As Integer
        Dim second_number As Integer

        Console.WriteLine("THIS PROGRAM IS DESIGNED TO CALCULATE DIFFERENCE OF TWO NUMBERS")
        Console.WriteLine("=================================================================")

        Console.WriteLine("First Number")
        first_number = Console.ReadLine()
        Console.WriteLine("=================================================================")

        Console.WriteLine("Second Number")
        second_number = Console.ReadLine()
        Console.WriteLine("=================================================================")

        If (first_number > second_number) Then
            Console.WriteLine("The higher number Is " + first_number.ToString)
        ElseIf (second_number > first_number) Then
            Console.WriteLine("The higher number is " + second_number.ToString)




        End If

        Console.ReadLine()

    End Sub

End Module
