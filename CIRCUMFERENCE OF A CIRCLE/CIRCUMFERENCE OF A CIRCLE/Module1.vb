Module Module1

    Sub Main()

        Dim pi As Double
        Dim radius_of_circle As Double
        Dim circumference_of_circle As Double

        Console.WriteLine("THIS PROGRAM IS DESIGNED TO CALCULATE THE CIRCUMFERENCE OF A CIRCLE")
        Console.WriteLine("===================================================================")
        Console.WriteLine()

        Console.WriteLine("Taking pi to be 3.142")
        Console.WriteLine("===================================================================")
        Console.WriteLine()

        Console.WriteLine("Enter the value of radius of the circle in meter")
        radius_of_circle = Console.ReadLine()
        Console.WriteLine("===================================================================")
        Console.WriteLine()

        circumference_of_circle = 2 * 3.142 * radius_of_circle
        Console.WriteLine("Circumference of the circle is " + circumference_of_circle.ToString + "m")

        Console.ReadLine()

    End Sub

End Module
