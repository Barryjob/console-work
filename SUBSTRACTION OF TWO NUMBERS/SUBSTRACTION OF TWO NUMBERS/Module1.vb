Module Module1

    Sub Main()
        Dim First_number As Decimal
        Dim Second_number As Decimal
        Dim Result As Decimal


        Console.WriteLine("THIS PROGRAM IS DESIGNED TO SUBTRACT TWO NUMBERS")
        Console.WriteLine("=========================================================")
        Console.WriteLine()

        Console.WriteLine("Enter the first number")
        First_number = Console.ReadLine()
        Console.WriteLine("=========================================================")
        Console.WriteLine()

        Console.WriteLine("Enter the second number")
        Second_number = Console.ReadLine()
        Console.WriteLine("=========================================================")
        Console.WriteLine()

        Result = First_number - Second_number
        Console.WriteLine("The Result of subtracting " + First_number.ToString + " from " + Second_number.ToString + " is " + Result.ToString)
        Console.ReadLine()

    End Sub

End Module
