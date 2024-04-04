Module Module1

    Sub Main()

        Dim First_number As Decimal
        Dim Second_number As Decimal
        Dim Result As Decimal

        Console.WriteLine(" THIS PROGRAM IS DESIGNED TO MULTIPLY TWO NUMBERS")
        Console.WriteLine("=========================================================")
        Console.WriteLine()

        Console.WriteLine("Enter the first number")
        First_number = Console.ReadLine()
        Console.WriteLine("=========================================================")
        Console.WriteLine()


        Console.WriteLine("Enter the Second number")
        Second_number = Console.ReadLine()
        Console.WriteLine("=========================================================")
        Console.WriteLine()


        Result = First_number * Second_number
        'Console.WriteLine("the sum of the numberis " + Result.ToString)
        Console.WriteLine("The Result of multiplying " + First_number.ToString + " and " + Second_number.ToString + " is " + Result.ToString)

        Console.ReadLine()

    End Sub

End Module
