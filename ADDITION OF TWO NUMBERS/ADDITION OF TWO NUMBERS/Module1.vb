Module Module1

    Sub Main()
            Dim First_number As Decimal
            Dim Second_number As Decimal
            Dim Result As Decimal

            Console.WriteLine(" ADD TWO NUMBERS")
            Console.WriteLine()

            Console.WriteLine("Enter the first number")
            First_number = Console.ReadLine()
            Console.WriteLine()


            Console.WriteLine("Enter the Second number")
            Second_number = Console.ReadLine()
            Console.WriteLine()


            Result = First_number + Second_number
            'Console.WriteLine("the sum of the numberis " + Result.ToString)
            Console.WriteLine("The Addition of  " + First_number.ToString + " and " + Second_number.ToString + " is " + Result.ToString)

            Console.ReadLine()


        End Sub

   
End Module
