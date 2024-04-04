Module Module1

    Sub Main()

        Dim First_number As Integer
        Dim Second_number As Integer
        Dim Result As Integer
        Dim pl As Char

        Do Until pl = "2"
            Console.WriteLine(" SUBTRACTION OF TWO NUMBER")
            Console.WriteLine()

            Console.WriteLine("Enter the value of the first number")
            First_number = Console.ReadLine()
            Console.WriteLine()


            Console.WriteLine("Enter the value of the Second number")
            Second_number = Console.ReadLine()
            Console.WriteLine()


            Result = First_number - Second_number
            'Console.WriteLine("the sum of the numberis " + Result.ToString)
            Console.WriteLine("The result is " + First_number.ToString + " and " + Second_number.ToString + " is " + Result.ToString)


            Console.WriteLine("Press 1 to continue")
            Console.WriteLine("Press 2 stop ")
            pl = Console.ReadLine()

        Loop

        Console.ReadLine()


    End Sub

End Module
