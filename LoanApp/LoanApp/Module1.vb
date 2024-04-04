Module Module1

    Sub Main()
        Console.WriteLine("LOAN CALCULATOR")
        Console.WriteLine("-------------------------------------")

        Dim principal, loan_amount, duration, interest, i, amount, Repayment, total_interest, total_repayment As Double
        Dim calculateAgain As Char

        Do Until calculateAgain = "x"


            Console.WriteLine("Enter Loan Amount")
            loan_amount = Console.ReadLine()
            Console.WriteLine("-------------------------------------")

            If loan_amount < "0" Then
                Console.WriteLine("invalid input")
                Console.ReadLine()
              
                End
            End If
            Console.WriteLine("Enter the Duration")
            duration = Console.ReadLine()
            Console.WriteLine("-------------------------------------")
            If duration < "1" Or duration > "10" Then
                Console.WriteLine("invalid input")
                Console.ReadLine()
            Else
                amount = loan_amount / duration
                Console.WriteLine("")

                Console.WriteLine("DURATION" + "       " + "AMOUNT" + "           " + "INTEREST" + "       " + " REPAYMENT")

                For i = 1 To duration


                    interest = 0.015 * loan_amount
                    Repayment = amount + interest
                    loan_amount = loan_amount - amount

                    total_interest = total_interest + interest
                    total_repayment = total_repayment + Repayment

                    Console.WriteLine("" + i.ToString + "              " + amount.ToString + "            " + interest.ToString + "           " + Repayment.ToString)









                Next
                Console.WriteLine("  ")
                Console.WriteLine("-------------------------------------------------------------")
                Console.WriteLine("TOTAL INTEREST = " + total_interest.ToString("N2"), ("F2"))
                Console.WriteLine("-------------------------------------------------------------")
                Console.WriteLine("TOTAL REPAYMENT = " + total_repayment.ToString("N2"), ("F2"))
                Console.WriteLine("  ")
                Console.WriteLine("-------------------------------------------------------------")
                Console.WriteLine("Press Y to continue")
                Console.WriteLine("Press X to stop")
                calculateAgain = Console.ReadLine()
            End If
        Loop





        Console.ReadLine()

        Console.WriteLine("" + duration.ToString + i.ToString, vbCrLf)
        Console.WriteLine("" + amount.ToString + amount.ToString, vbCrLf)
        Console.WriteLine("" + principal.ToString + principal.ToString, vbCrLf)
        Console.WriteLine("" + interest.ToString + interest.ToString, vbCrLf)
        Console.WriteLine("" + Repayment.ToString + Repayment.ToString)
    End Sub

End Module
