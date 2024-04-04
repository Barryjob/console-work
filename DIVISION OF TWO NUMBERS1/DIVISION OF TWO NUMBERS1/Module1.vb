Module Module1

    Sub Main()

        Dim First_number As Double
        Dim Second_number As Double
        Dim Result As Double

        Console.WriteLine(" THIS PROGRAM IS DESIGNED TO DIVIDE TWO NUMBERS")
        Console.WriteLine("=========================================================")
        Console.WriteLine()

        Console.WriteLine("Enter the value of first number")
        First_number = Console.ReadLine()
        Console.WriteLine("=========================================================")
        Console.WriteLine()


        Console.WriteLine("Enter the value of Second number")
        Second_number = Console.ReadLine()
        Console.WriteLine("=========================================================")
        Console.WriteLine()


        Result = First_number / Second_number
        'Console.WriteLine("the sum of the numberis " + Result.ToString)
        Console.WriteLine("The Result of dividing " + First_number.ToString + " and " + Second_number.ToString + " is " + Result.ToString)

        Console.ReadLine()

    End Sub

End Module
