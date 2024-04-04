Module Module1

    Sub Main()
        Dim SPDT101, MAD102, SDA103, WAD104, NS105, AGDT106, p1, p2, p3, p4, p5, p6, Tp, gp, cgpa As Decimal

        Console.WriteLine("AFOOTECH GP CALCULATOR")
        Console.WriteLine("")
        Console.WriteLine("THIS PROGRAM IS DESIGNED TO CALCULATE CGPA FOR AFOOTECH STUDENTS")
        Console.WriteLine("=================================================================")
        Console.WriteLine("")
       

        Console.WriteLine("`.........4 Unit")
        SPDT101 = Console.ReadLine()
        If (SPDT101 < 0 Or SPDT101 > 100) Then
            Console.WriteLine("Invalid Input!")
        ElseIf (SPDT101 >= 80 Or SPDT101 <= 100) Then
            p1 = 4 * 4
        ElseIf (SPDT101 <= 79.9 And SPDT101 >= 70) Then
            p1 = 3.5 * 4
        ElseIf (SPDT101 <= 69.9 And SPDT101 >= 60) Then
            p1 = 3 * 4
        ElseIf (SPDT101 <= 59.9 And SPDT101 >= 50) Then
            p1 = 2.5 * 4
        ElseIf (SPDT101 <= 49.9 And SPDT101 >= 40) Then
            p1 = 2 * 4
        ElseIf (SPDT101 <= 39.9) And (SPDT101 >= 0) Then
            p1 = 0 * 4

        Else
            Console.WriteLine("invalid input")
           
        End If
        Console.WriteLine()
        Console.ReadLine()
        End

        Console.WriteLine("=================================================================")
        Console.WriteLine("Enter Score For Mobile Application Development(MAD102)....................3 Unit")
        MAD102 = Console.ReadLine()
        If (MAD102 >= 80 And MAD102 <= 100) Then
            p2 = 4 * 4
        ElseIf (MAD102 >= 70) Then
            p2 = 3.5 * 4
        ElseIf (MAD102 >= 60) Then
            p2 = 3 * 4
        ElseIf (MAD102 >= 50) Then
            p2 = 2.5 * 4
        ElseIf (MAD102 >= 40) Then
            p2 = 2 * 4
        ElseIf (MAD102 <= 39.9) And (MAD102 >= 0) Then
            p2 = 0 * 4
        Else
            Console.WriteLine("invalid input")

        End If
        Console.WriteLine()
        Console.ReadLine()
        End




        Console.WriteLine("=================================================================")

        Console.WriteLine("Enter Score For System & Data Analysis(SDA103)............................3 Unit")
        SDA103 = Console.ReadLine()
        If (SDA103 >= 80 And SDA103 <= 100) Then
            p3 = 4 * 4
        ElseIf (SDA103 >= 70) Then
            p3 = 3.5 * 4
        ElseIf (SDA103 >= 60) Then
            p3 = 3 * 4
        ElseIf (SDA103 >= 50) Then
            p3 = 2.5 * 4
        ElseIf (SDA103 >= 40) Then
            p3 = 2 * 4
        ElseIf (SDA103 <= 39.9) And (SDA103 >= 0) Then
            p3 = 0 * 4
        Else
            Console.WriteLine("invalid input")

        End If
        Console.WriteLine()
        Console.ReadLine()
        End

        Console.WriteLine("=================================================================")

        Console.WriteLine("Enter Score For Website/Web Apps Develop(WAD104)..........................4 Unit")
        WAD104 = Console.ReadLine()
        If (WAD104 >= 80 And WAD104 <= 100) Then
            p4 = 4 * 4
        ElseIf (WAD104 >= 70) Then
            p4 = 3.5 * 4
        ElseIf (WAD104 >= 60) Then
            p4 = 3 * 4
        ElseIf (WAD104 >= 50) Then
            p4 = 2.5 * 4
        ElseIf (WAD104 >= 40) Then
            p4 = 2 * 4
        ElseIf (WAD104 <= 39.9) And (WAD104 >= 0) Then
            p4 = 0 * 4
        Else
            Console.WriteLine("invalid input")

        End If
        Console.WriteLine()
        Console.ReadLine()
        End

        Console.WriteLine("=================================================================")

        Console.WriteLine("Enter Score For Networking & Security(NS105)..............................3 Unit")
        NS105 = Console.ReadLine()
        If (NS105 >= 80 And NS105 <= 100) Then
            p5 = 4 * 4
        ElseIf (NS105 >= 70) Then
            p5 = 3.5 * 4
        ElseIf (NS105 >= 60) Then
            p5 = 3 * 4
        ElseIf (NS105 >= 50) Then
            p5 = 2.5 * 4
        ElseIf (NS105 >= 40) Then
            p5 = 2 * 4
        ElseIf (NS105 <= 39.9) And (NS105 >= 0) Then
            p5 = 0 * 4
        Else
            Console.WriteLine("invalid input")

        End If
        Console.WriteLine()
        Console.ReadLine()
        End

        Console.WriteLine("=================================================================")

        Console.WriteLine("Enter Score For Advanced Graphics Design Training(AGDT106)................3 Unit")
        AGDT106 = Console.ReadLine()
        If (AGDT106 >= 80 Or AGDT106 <= 100) Then
            p6 = 4 * 4
        ElseIf (AGDT106 >= 70) Then
            p6 = 3.5 * 4
        ElseIf (AGDT106 >= 60) Then
            p6 = 3 * 4
        ElseIf (AGDT106 >= 50) Then
            p6 = 2.5 * 4
        ElseIf (AGDT106 >= 40) Then
            p6 = 2 * 4
        ElseIf (AGDT106 <= 39.9) And (AGDT106 >= 0) Then
            p6 = 0 * 4
        Else
            Console.WriteLine("invalid input")

        End If
        Console.WriteLine()
        Console.ReadLine()
        End


        Console.WriteLine("=================================================================")


        Tp = p1 + p2 + p3 + p4 + p5 + p6





        gp = Tp / 20
        cgpa = gp
        Console.WriteLine("Your CGPA is " + cgpa.ToString)

        Console.WriteLine("=================================================================")
        If (cgpa >= 3.5 Or cgpa = 4) Then
            Console.WriteLine("Your Grade Is First Class")

        ElseIf (cgpa <= 3.49 Or cgpa = 3.0) Then
            Console.WriteLine("Your Grade Is Seconds Class Upper")

        ElseIf (cgpa <= 2.99 Or cgpa >= 2.5) Then
            Console.WriteLine("Your Grade Is Second Class Lower")

        ElseIf (cgpa <= 2.49 Or cgpa = 2.0) Then
            Console.WriteLine("Your Grade Is Pass")

        ElseIf cgpa = 0 Or cgpa < 2.0 Then
            Console.WriteLine("Your Grade Is Fair")

        Else
            Console.WriteLine("Invalid")

        End If




        Console.ReadLine()


    End Sub

End Module
