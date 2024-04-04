Module Module1

    Sub Main()
        'loan calculation variables
        Dim Principal As Integer
        Dim InterestRate As Integer
        Dim loanTerm As Integer
        Dim monthlyPayment As Integer


        'Getting user input
        Console.WriteLine("Enter The Loan Amount")
        Principal = Decimal.Parse(Console.ReadLine())

        Console.WriteLine("Enter The Intrest Rate In Percentage")
        InterestRate = Decimal.Parse(Console.ReadLine()) / 100

        Console.WriteLine("Enter The Loan Term In Months")
        loanTerm = Integer.Parse(Console.ReadLine())

        'calculate monthly payment
        Dim monthlyIntrestRate As Decimal
        monthlyIntrestRate = InterestRate / 10
        monthlyPayment = Principal * (monthlyIntrestRate * (1 + monthlyIntrestRate) ^ loanTerm) / ((1 + monthlyIntrestRate) ^ loanTerm - 1)

        'display the result
        Console.WriteLine("Your monthly payment is:" & monthlyPayment.ToString("c"))

    End Sub

End Module
