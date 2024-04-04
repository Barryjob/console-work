Module Module1

    Sub Main()

        Dim displacement As Decimal
        Dim time As Decimal
        Dim velocity As Decimal

        Console.WriteLine("VELOCITY CALCULATOR")
        Console.WriteLine("=========================================================")
        Console.WriteLine()

        Console.WriteLine("Enter Value of Displacement in meter")
        displacement = Console.ReadLine()
        Console.WriteLine("=========================================================")
        Console.WriteLine()
        If displacement Then


        End If
        Console.WriteLine("Enter Value of Time taken in seconds")
        time = Console.ReadLine()
        Console.WriteLine("=========================================================")
        Console.WriteLine()

        velocity = displacement / time
        Console.WriteLine("The velocity is " + velocity.ToString + "m/s")

        Console.ReadLine()

    End Sub

End Module
