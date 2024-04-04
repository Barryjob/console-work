Module Module1

    Sub Main()

        Dim a, b, c, y, w, p, z, d, k, v, x1, x2 As Decimal

        Console.WriteLine("THIS PROGRAM CALCULATE QUADRATIC EQUATION")
        Console.WriteLine(" USING GENERAL FORMULA")
        Console.WriteLine()

        Console.WriteLine("=========================================================")
        Console.WriteLine("Enter the coefficient of a")
        a = Console.ReadLine()
        Console.WriteLine()
        Console.WriteLine("=========================================================")

        Console.WriteLine("Enter the coefficient of b")
        b = Console.ReadLine()
        Console.WriteLine()
        Console.WriteLine("=========================================================")

        Console.WriteLine("Enter the coefficient of c")
        c = Console.ReadLine()
        Console.WriteLine()


        y = b * b
        w = 4 * a * c
        p = y - w
        d = Math.Sqrt(p)
        v = -b + d
        k = -b - d
        z = 2 * a

        x1 = v / z
        x2 = k / z
        Console.WriteLine("=========================================================")
        Console.WriteLine("The roots of the equation are " + x1.ToString + " and " + x2.ToString)

        Console.ReadLine()
    End Sub

End Module
