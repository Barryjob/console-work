Module Module1

    Sub Main()


        Dim radius_of_circle As Decimal
        Dim area_of_circle As Decimal

        Console.WriteLine("THIS PROGRAM IS DESIGNED TO CALCULATE AN AREA OF A CIRCLE")
        Console.WriteLine("===================================================================")
        Console.WriteLine()

        Console.WriteLine("Taking pi to be 3.142")
        Console.WriteLine("===================================================================")
        Console.WriteLine()

        Console.WriteLine("Enter the value of radius in meter")
        radius_of_circle = Console.ReadLine()
        Console.WriteLine("===================================================================")
        Console.WriteLine()

        area_of_circle = 3.142 * radius_of_circle * radius_of_circle
        'Console.WriteLine("The Area of circle is" + pie.ToString + " and " + radius_of_circle.ToString + "and" + radius_of_circle.ToString + "is" + area_of_circle.ToString)
        Console.WriteLine("The Area of the circle is " + area_of_circle.ToString + "m^2")

        Console.ReadLine()

    End Sub

End Module
