Module Module1

    Sub Main()
        Dim a, b, c As Integer
        Console.WriteLine("Addditon of two numbers")
        Console.WriteLine("==============================")
        Console.WriteLine("Enter the value for first number")
        a = Console.ReadLine()
        Console.WriteLine("")
        Console.WriteLine("Enter the value for second number")
        b = Console.ReadLine()
        c = a + b
        Console.WriteLine("==============================")
        Console.WriteLine("The Sum of the two numbers is " + c.ToString)
        Console.WriteLine("==============================")
        'Console.WriteLine("The Sum of " + a.ToString + " and " + b.ToString + " is " + c.ToString)


        Console.ReadLine()
    End Sub

End Module
