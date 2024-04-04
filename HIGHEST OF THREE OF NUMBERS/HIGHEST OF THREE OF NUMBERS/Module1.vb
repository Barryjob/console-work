Module Module1

    Sub Main()

        Dim first_number As Double
        Dim second_number As Double
        Dim third_number As Double

        Console.WriteLine("THIS PROGRAM IS DESIGNED TO SELECT THE HIGHEST NUMBER OUT THREE NUMBERS ")
        Console.WriteLine("=================================================================")
        Console.WriteLine()

        Console.WriteLine("Kindly Enter The First Number")
        first_number = Console.ReadLine()
        Console.WriteLine("=================================================================")

        Console.WriteLine("Kindly Enter The Second Number")
        second_number = Console.ReadLine()
        Console.WriteLine("=================================================================")

        Console.WriteLine("Kindly Enter The Third Number")
        third_number = Console.ReadLine()
        Console.WriteLine("=================================================================")

        If (first_number > second_number And first_number > third_number) Then
            Console.WriteLine("The highest number is " + first_number.ToString)
            Console.WriteLine("=================================================================")

        ElseIf (second_number > first_number And second_number > third_number) Then
            Console.WriteLine("The highest number is " + second_number.ToString)
            Console.WriteLine("=================================================================")

        ElseIf (third_number > first_number And third_number > second_number) Then
            Console.WriteLine("The higest number is " + third_number.ToString)


        End If
        Console.ReadLine()

    End Sub

End Module
