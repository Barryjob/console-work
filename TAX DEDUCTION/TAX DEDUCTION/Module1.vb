Module Module1

    Sub Main()

        Dim staff_salary As Double
        Dim tax_deducted, tax_rate As Double
        Dim take_home_salary As Double

        Console.WriteLine("TAX DEDUCTION CALCULATOR")
        Console.WriteLine("===================================================================")
        Console.WriteLine()


        Console.WriteLine("Enter staff salary")
        staff_salary = Console.ReadLine()
        Console.WriteLine("===================================================================")
        Console.WriteLine()


        Console.WriteLine(" Enter Tax rate in % ")
        tax_rate = Console.ReadLine()
        Console.WriteLine("===================================================================")
        Console.WriteLine()


        tax_deducted = tax_rate / 100 * staff_salary
        take_home_salary = staff_salary - tax_deducted

        Console.WriteLine("Amount Deducted from Salary is #" + tax_deducted.ToString("N2"), ("F2"))
        Console.WriteLine("Salary After deduction of tax is #" + take_home_salary.ToString("N2"), ("F2"))

        Console.ReadLine()

    End Sub

End Module
