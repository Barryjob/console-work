﻿Module Module1

    Sub Main()
        Console.WriteLine("MULTI-FUNTION CALCULATOR")
        Console.WriteLine()

        'variable for sum of two number
        Dim First_number As Decimal
        Dim Second_number As Decimal
        Dim Result As Decimal
        Dim x As String
        Dim pan As Char

        'variable for fraction of two
        Dim a As Double
        Dim b As Double
        Dim c As Double

        'variable for diffrence of two numbers
        Dim First_numbers As Decimal
        Dim Second_numbers As Decimal
        Dim Results As Decimal

        'variable for products of two numbers
        Dim First_numberb As Decimal
        Dim Second_numberb As Decimal
        Dim Resultb As Decimal

        'variable for area of circle
        Dim radius_of_circleX As Decimal
        Dim area_of_circle As Decimal

        'variable for circumference of circle
        Dim radius_of_circle As Double
        Dim circumference_of_circle As Double

        'variable for boyle's law
        Dim an, bn, P1, P2, V1, V2, xn As Double

        'variable for highest of two numbers
        Dim first_numberJ As Integer
        Dim second_numberJ As Integer

        'variable for highest of three numbers
        Dim first_numberh As Double
        Dim second_numberh As Double
        Dim third_numberh As Double

        'variable for quadratic equation
        Dim ai, bi, ci, y, w, p, z, d, k, v, x1, x2 As Decimal

        'variable for velocity
        Dim displacement As Decimal
        Dim time As Decimal
        Dim velocity As Decimal

        'variable for tax deductio
        Dim staff_salary As Double
        Dim tax_deducted As Double
        Dim take_home_salary As Double

        'variable for afootech gp calculator
        Dim SPDT101, MAD102, SDA103, WAD104, NS105, AGDT106, pM, pN, p3, p4, p5, p6, Tp, gp, cgpa As Decimal

        'variable for noun gp calculator
        Dim gpi, cgpai, P1i, P2i, P3i, P4i, P5i, P6i, P7, P8, P9, P10, P11, P12, P13, GST103, GST101, GST107, BIO101, CHM101,
           CHM103, CIT143, MTH101, MTH103, PHY192, BIO191, CHM191, PHY191, PHY101, GST102, GST104, CHM102, CIT102, CIT104,
           STT102, MTH102, BIO102, BIO192, CHM192, PHY102, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C12, C11, gp2, cgpa2,
        GST201, GST203, CIT211, CIT215, CIT237, MTH211, MTH213, MTH281, K1, K2, K3, K4, K5, K6, K7, K8, gp3, cgpa3,
        GST202, GST204, CIT212, CIT236, CIT292, CIT208, MTH212, MTH232, MTH282, PHY208, A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, gp4, cgpa4,
        CIT303, CIT305, CIT309, CIT311, CIT341, CIT371, CIT381, CIT389, gp5, cgpa5, B1, B2, B3, B4, B5, B6, B7, B8,
        GST302, CIT322, CIT342, CIT344, CIT392, DAM301, DAM364, DAM344, DAM382, R1, R3, R2, R4, R5, R6, R7, R8, R9, gp6, cgpa6,
        CIT403, CIT411, CIT415, CIT427, CIT445, CIT461, CIT463, CIT465, Y1, Y2, Y3, Y4, Y5, Y6, Y7, Y8, gp7, cgpa7,
       CIT425, CIT474, CIT478, CIT484, CIT499, DAM461, Q1, Q2, Q3, Q4, Q5, Q6, gp8, cgpa8 As Double
        Dim xu, yu, Ku, J, m, L, U As String


        Dim again As Char

        Do Until again = "1"


            Console.WriteLine("PRESS 1 TO CALCULATE THE SUM OF TWO NUMBERS")
            Console.WriteLine("PRESS 2 TO CALCULATE THE DIFFERENCE OF TWO NUMBERS")
            Console.WriteLine("PRESS 3 TO CALCULATE THE PROCUCT OF TWO NUMBERS")
            Console.WriteLine("PRESS 4 TO CALCULATE THE FRACTION OF TWO NUMBERS")
            Console.WriteLine("PRESS 5 TO CALCULATE AREA OF A CIRCLE")
            Console.WriteLine("PRESS 6 TO CALCULATE CIRCUMFERENCE OF A CIRCLE")
            Console.WriteLine("PRESS 7 TO CALCULATE BOYLE'S LAW")
            Console.WriteLine("PRESS 8 TO CALCULATE HIGHEST OF TWO NUMBERS")
            Console.WriteLine("PRESS 9 TO CALCULATE HIGHES OF THEEE NUMBERS")
            Console.WriteLine("PRESS 10 TO CALCULATE QUADRIC EQUATION")
            Console.WriteLine("PRESS 11 TO CALCULATE VELOCITY OF A BODY")
            Console.WriteLine("PRESS 12 TO CALCULATE TAX DEDUCTION")
            Console.WriteLine("PRESS 13 TO CALCULATE AFOOTECH GP")
            Console.WriteLine("PRESS 14 TO CALCULATE NATIONAL OPEN UNIVERSITY GP")
            Console.WriteLine("PRESS 15 TO CALCULATE YOUR AGE")
            Console.WriteLine("   ")
            Console.WriteLine("=========================================================")
            x = Console.ReadLine()


            If (x = "1") Then
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



            ElseIf (x = "2") Then
                Console.WriteLine(" THIS PROGRAM IS DESIGNED TO DIVIDE TWO NUMBERS")
                Console.WriteLine("=========================================================")
                Console.WriteLine()

                Console.WriteLine("Enter the value of first number")
                a = Console.ReadLine()
                Console.WriteLine("=========================================================")
                Console.WriteLine()


                Console.WriteLine("Enter the value of Second number")
                b = Console.ReadLine()
                Console.WriteLine("=========================================================")
                Console.WriteLine()


                c = a / b
                'Console.WriteLine("the sum of the numberis " + Result.ToString)
                Console.WriteLine("The Result of dividing " + a.ToString + " and " + b.ToString + " is " + c.ToString)


            ElseIf (x = "3") Then
                Console.WriteLine("THIS PROGRAM IS DESIGNED TO SUBTRACT TWO NUMBERS")
                Console.WriteLine("=========================================================")
                Console.WriteLine()

                Console.WriteLine("Enter the first number")
                First_numbers = Console.ReadLine()
                Console.WriteLine("=========================================================")
                Console.WriteLine()

                Console.WriteLine("Enter the second number")
                Second_numbers = Console.ReadLine()
                Console.WriteLine("=========================================================")
                Console.WriteLine()

                Results = First_numbers - Second_numbers
                Console.WriteLine("The Result of subtracting " + First_numbers.ToString + " from " + Second_numbers.ToString + " is " + Results.ToString)





            ElseIf (x = "4") Then
                Console.WriteLine(" THIS PROGRAM IS DESIGNED TO MULTIPLY TWO NUMBERS")
                Console.WriteLine("=========================================================")
                Console.WriteLine()

                Console.WriteLine("Enter the first number")
                First_numberb = Console.ReadLine()
                Console.WriteLine("=========================================================")
                Console.WriteLine()


                Console.WriteLine("Enter the Second number")
                Second_numberb = Console.ReadLine()
                Console.WriteLine("=========================================================")
                Console.WriteLine()


                Resultb = First_numberb * Second_numberb
                'Console.WriteLine("the sum of the numberis " + Result.ToString)
                Console.WriteLine("The Result of multiplying " + First_numberb.ToString + " and " + Second_numberb.ToString + " is " + Resultb.ToString)



            ElseIf (x = "5") Then

                Console.WriteLine("THIS PROGRAM IS DESIGNED TO CALCULATE AN AREA OF A CIRCLE")
                Console.WriteLine("===================================================================")
                Console.WriteLine()

                Console.WriteLine("Taking pi to be 3.142")
                Console.WriteLine("===================================================================")
                Console.WriteLine()

                Console.WriteLine("Enter the value of radius in meter")
                radius_of_circleX = Console.ReadLine()
                Console.WriteLine("===================================================================")
                Console.WriteLine()

                area_of_circle = 3.142 * radius_of_circleX * radius_of_circleX
                'Console.WriteLine("The Area of circle is" + pie.ToString + " and " + radius_of_circle.ToString + "and" + radius_of_circle.ToString + "is" + area_of_circle.ToString)
                Console.WriteLine("The Area of the circle is " + area_of_circle.ToString + "m^2")


            ElseIf (x = "6") Then

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


            ElseIf (x = "7") Then

                Dim ag As Char
                Do Until ag = "x"
                    Console.WriteLine("BOYLE'S LAW CALCULATOR")
                    Console.WriteLine("THIS PROGRAM IS OPERATED ON BOYLE'S LAW")
                    Console.WriteLine("=================================================================")


                    Console.WriteLine("Press 1 to Find Intial Pressure(P1)")
                    Console.WriteLine("Press 2 to Find Intial Volume(V1)")
                    Console.WriteLine("Press 3 to Find Final Pressure(P2)")
                    Console.WriteLine("Press 4 to Find Final Volume(V2)")
                    Console.WriteLine("=================================================================")

                    xn = Console.ReadLine()
                    Console.WriteLine("=================================================================")


                    If (xn = "1") Then
                        Console.WriteLine("Enter The Value Of V1")
                        V1 = Console.ReadLine()
                        Console.WriteLine()
                        Console.WriteLine("Enter The Value Of P2")
                        P2 = Console.ReadLine()
                        Console.WriteLine()
                        Console.WriteLine("Enter The Value Of V2")
                        V2 = Console.ReadLine()
                        Console.WriteLine()
                        an = P2 * V2
                        P1 = an / V1
                        If (V1 = "0") Then
                            Console.WriteLine("can't be divided by zero")
                        Else
                            Console.WriteLine("Intial Presure(P1) is = " + P1.ToString)
                            Console.WriteLine("=================================================================")
                        End If

                    ElseIf (xn = "2") Then
                        Console.WriteLine("Enter The Value Of P1")
                        P1 = Console.ReadLine()
                        Console.WriteLine()
                        Console.WriteLine("Enter The Value Of P2")
                        P2 = Console.ReadLine()
                        Console.WriteLine()
                        Console.WriteLine("Enter The Value Of V2")
                        V2 = Console.ReadLine()
                        Console.WriteLine()
                        an = P2 * V2
                        V1 = an / P1
                        If (P1 = "0") Then
                            Console.WriteLine("can't be divided by zero")
                        Else
                            Console.WriteLine("Intial Volume(V1) is = " + V1.ToString)
                            Console.WriteLine("=================================================================")
                        End If

                    ElseIf (xn = "3") Then
                        Console.WriteLine("Enter The Value Of P1")
                        P1 = Console.ReadLine()
                        Console.WriteLine()
                        Console.WriteLine("Enter The Value Of V1")
                        V1 = Console.ReadLine()
                        Console.WriteLine()
                        Console.WriteLine("Enter The Value Of V2")
                        V2 = Console.ReadLine()
                        Console.WriteLine()
                        bn = P1 * V1
                        P2 = bn / V2
                        If (V2 = "0") Then
                            Console.WriteLine("can't be divided by zero")
                        Else
                            Console.WriteLine("Final Presure(P2) is = " + P2.ToString)
                            Console.WriteLine("=================================================================")
                        End If

                    ElseIf (xn = "4") Then
                        Console.WriteLine("Enter The Value Of P1")
                        P1 = Console.ReadLine()
                        Console.WriteLine()
                        Console.WriteLine("Enter The Value Of V1")
                        V1 = Console.ReadLine()
                        Console.WriteLine()
                        Console.WriteLine("Enter The Value Of P2")
                        P2 = Console.ReadLine()
                        Console.WriteLine()
                        bn = P1 * V1
                        V2 = bn / P2
                        If (P2 = "0") Then
                            Console.WriteLine("can't be divided by zero")
                        Else
                            Console.WriteLine("Final Volume (V2) is = " + V2.ToString)
                            Console.WriteLine("=================================================================")
                        End If
                    Else
                        Console.WriteLine("Invalid Input!")


                    End If
                    Console.WriteLine("To Continue Press Y")
                    Console.WriteLine("To Stop Press X")
                    ag = Console.ReadLine()
                Loop



            ElseIf (x = "8") Then
                Console.WriteLine("THIS PROGRAM IS DESIGNED TO CALCULATE HIGHEST OF TWO NUMBERS")
                Console.WriteLine("=================================================================")

                Console.WriteLine("First Number")
                first_numberJ = Console.ReadLine()
                Console.WriteLine("=================================================================")

                Console.WriteLine("Second Number")
                second_numberJ = Console.ReadLine()
                Console.WriteLine("=================================================================")

                If (first_numberJ > second_numberJ) Then
                    Console.WriteLine("The higher number Is " + first_numberJ.ToString)
                ElseIf (second_numberJ > first_numberJ) Then
                    Console.WriteLine("The higher number is " + second_numberJ.ToString)

                End If



            ElseIf (x = "9") Then

                Console.WriteLine("THIS PROGRAM IS DESIGNED TO SELECT THE HIGHEST NUMBER OUT THREE NUMBERS ")
                Console.WriteLine("=================================================================")
                Console.WriteLine()

                Console.WriteLine("Kindly Enter The First Number")
                first_numberh = Console.ReadLine()
                Console.WriteLine("=================================================================")

                Console.WriteLine("Kindly Enter The Second Number")
                second_numberh = Console.ReadLine()
                Console.WriteLine("=================================================================")

                Console.WriteLine("Kindly Enter The Third Number")
                third_numberh = Console.ReadLine()
                Console.WriteLine("=================================================================")

                If (first_numberh > second_numberh And first_numberh > third_numberh) Then
                    Console.WriteLine("The highest number is " + First_number.ToString)
                    Console.WriteLine("=================================================================")

                ElseIf (second_numberh > first_numberh And second_numberh > third_numberh) Then
                    Console.WriteLine("The highest number is " + Second_number.ToString)
                    Console.WriteLine("=================================================================")

                ElseIf (third_numberh > first_numberh And third_numberh > second_numberh) Then
                    Console.WriteLine("The higest number is " + third_numberh.ToString)


                End If






            ElseIf (x = "10") Then
                Console.WriteLine("THIS PROGRAM CALCULATE QUADRATIC EQUATION")
                Console.WriteLine(" USING GENERAL FORMULA")
                Console.WriteLine()

                Console.WriteLine("=========================================================")
                Console.WriteLine("Enter the coefficient of a")
                ai = Console.ReadLine()
                Console.WriteLine()
                Console.WriteLine("=========================================================")

                Console.WriteLine("Enter the coefficient of b")
                bi = Console.ReadLine()
                Console.WriteLine()
                Console.WriteLine("=========================================================")

                Console.WriteLine("Enter the coefficient of c")
                ci = Console.ReadLine()
                Console.WriteLine()


                y = bi * bi
                w = 4 * ai * ci
                p = y - w
                d = Math.Sqrt(p)
                v = -bi + d
                k = -bi - d
                z = 2 * ai

                x1 = v / z
                x2 = k / z
                Console.WriteLine("=========================================================")
                Console.WriteLine("The roots of the equation are " + x1.ToString + " and " + x2.ToString)





            ElseIf (x = "11") Then
                Console.WriteLine("VELOCITY CALCULATOR")
                Console.WriteLine("=========================================================")
                Console.WriteLine()

                Console.WriteLine("Enter Value of Displacement in meter")
                displacement = Console.ReadLine()
                Console.WriteLine("=========================================================")
                Console.WriteLine()

                Console.WriteLine("Enter Value of Time taken in seconds")
                time = Console.ReadLine()
                Console.WriteLine("=========================================================")
                Console.WriteLine()

                velocity = displacement / time
                Console.WriteLine("The velocity is " + velocity.ToString + "m/s")




            ElseIf (x = "12") Then
                Console.WriteLine("TAX DEDUCTION CALCULATOR")
                Console.WriteLine("===================================================================")
                Console.WriteLine()


                Console.WriteLine("Enter staff salary")
                staff_salary = Console.ReadLine()
                Console.WriteLine("===================================================================")
                Console.WriteLine()


                Console.WriteLine("Tax rate in % ")
                tax_deducted = Console.ReadLine()
                Console.WriteLine("===================================================================")
                Console.WriteLine()


                tax_deducted = 5 / 100 * staff_salary
                take_home_salary = staff_salary - tax_deducted

                Console.WriteLine("Salary After deduction of tax is #" + take_home_salary.ToString("N2"), ("F2"))





            ElseIf (x = "13") Then
                Console.WriteLine("AFOOTECH GP CALCULATOR")
                Console.WriteLine("")
                Console.WriteLine("THIS PROGRAM IS DESIGNED TO CALCULATE CGPA FOR AFOOTECH STUDENTS")
                Console.WriteLine("=================================================================")
                Console.WriteLine("")


                Console.WriteLine("Enter Score For System Project  Development & Training (SPDT101).........4 Unit")
                SPDT101 = Console.ReadLine()
                If (SPDT101 < 0 Or SPDT101 > 100) Then
                    Console.WriteLine("Invalid Input!")
                ElseIf (SPDT101 >= 80 Or SPDT101 <= 100) Then
                    pM = 4 * 4
                ElseIf (SPDT101 <= 79.9 And SPDT101 >= 70) Then
                    pM = 3.5 * 4
                ElseIf (SPDT101 <= 69.9 And SPDT101 >= 60) Then
                    pM = 3 * 4
                ElseIf (SPDT101 <= 59.9 And SPDT101 >= 50) Then
                    pM = 2.5 * 4
                ElseIf (SPDT101 <= 49.9 And SPDT101 >= 40) Then
                    pM = 2 * 4
                ElseIf (SPDT101 <= 39.9) And (SPDT101 >= 0) Then
                    p6 = 0 * 4
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
                    pN = 4 * 4
                ElseIf (MAD102 >= 70) Then
                    pN = 3.5 * 4
                ElseIf (MAD102 >= 60) Then
                    pN = 3 * 4
                ElseIf (MAD102 >= 50) Then
                    pN = 2.5 * 4
                ElseIf (MAD102 >= 40) Then
                    pN = 2 * 4
                ElseIf (MAD102 <= 39.9) And (MAD102 >= 0) Then
                    p6 = 0 * 4
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
                    p6 = 0 * 4
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
                    p6 = 0 * 4
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
                    p6 = 0 * 4
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


                Tp = P1 + P2 + p3 + p4 + p5 + p6





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





            ElseIf (x = "14") Then

                Console.WriteLine("CGPA CALCULATOR FOR NOUN STUDENT ")
                Console.WriteLine("==============================================")
                Console.WriteLine()
                Do Until pan = "x"
                    Console.WriteLine("Press 1 For 100Level")
                    Console.WriteLine("Press 2 For 200Level")
                    Console.WriteLine("Press 3 For 300Level")
                    Console.WriteLine("Press 4 For 400Level")
                    Console.WriteLine("==============================================")
                    xu = Console.ReadLine()



                    If (xu = "1") Then
                        Console.WriteLine("100Level")
                        Console.WriteLine("==============================================")
                        Console.WriteLine("Press 1 For 1st Semester 100Level")
                        Console.WriteLine("Press 2 For 2nd Semester 100Level")
                        Console.WriteLine("==============================================")
                        yu = Console.ReadLine()


                        If (yu = "1") Then
                            Console.WriteLine("First Semester; 100Level.")
                            Console.WriteLine("==============================================")

                            Console.WriteLine("Enter Score For Use Of English And Communication (GST101)...........2 Unit")
                            GST101 = Console.ReadLine()
                            If (GST101 >= 70) And (GST101 <= 100) Then
                                P1i = 5 * 2
                            ElseIf (GST101 >= 60) And (GST101 <= 69) Then
                                P1i = 4 * 2
                            ElseIf (GST101 >= 50) And (GST101 <= 59) Then
                                P1i = 3 * 2
                            ElseIf (GST101 >= 45) And (GST101 <= 49) Then
                                P1i = 2 * 2
                            ElseIf (GST101 >= 40) And (GST101 <= 44) Then
                                P1i = 1 * 2
                            ElseIf (GST101 >= 0) And (GST101 <= 39) Then
                                P1i = 0 * 2
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End



                                Console.WriteLine()


                            End If
                            Console.WriteLine("Enter Score For Computer Fundamentals (GST103)...............2 Unit")
                            GST103 = Console.ReadLine()
                            If (GST103 >= 70) And (GST103 <= 100) Then
                                P2i = 5 * 2
                            ElseIf (GST103 >= 60) And (GST103 <= 69) Then
                                P2i = 4 * 2
                            ElseIf (GST103 >= 50) And (GST103 <= 59) Then
                                P2i = 3 * 2
                            ElseIf (GST103 >= 45) And (GST103 <= 49) Then
                                P2i = 2 * 2
                            ElseIf (GST103 >= 40) And (GST103 <= 44) Then
                                P2i = 1 * 2
                            ElseIf (GST103 >= 0) And (GST103 <= 39) Then
                                P2i = 0 * 2
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                                Console.WriteLine()

                            End If
                            Console.WriteLine("Enter Score For The Study Guide For The Distance Learner (GST107).....2 Unit")
                            GST107 = Console.ReadLine()
                            If (GST107 >= 70) And (GST107 <= 100) Then
                                P3i = 5 * 2
                            ElseIf (GST107 >= 60) And (GST107 <= 69) Then
                                P3i = 4 * 2
                            ElseIf (GST101 >= 50) And (GST101 <= 59) Then
                                P3i = 3 * 2
                            ElseIf (GST107 >= 45) And (GST107 <= 49) Then
                                P3i = 2 * 2
                            ElseIf (GST107 >= 40) And GST107 <= 44 Then
                                P3i = 1 * 2
                            ElseIf (GST107 >= 0) And (GST107 <= 39) Then
                                P3i = 0 * 2
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                                Console.WriteLine()


                            End If
                            Console.WriteLine("Enter Score For General Biology I (BIO101).......................2 Unit")
                            BIO101 = Console.ReadLine()
                            If (BIO101 >= 70) And (BIO101 <= 100) Then
                                P4i = 5 * 2
                            ElseIf (BIO101 >= 60) And (BIO101 <= 69) Then
                                P4i = 4 * 2
                            ElseIf (BIO101 >= 50) And (BIO101 <= 59) Then
                                P4i = 3 * 2
                            ElseIf (BIO101 >= 45) And (BIO101 <= 49) Then
                                P4i = 2 * 2
                            ElseIf (BIO101 >= 40) And (BIO101 <= 44) Then
                                P4i = 1 * 2
                            ElseIf (BIO101 >= 0) And (BIO101 <= 39) Then
                                P4i = 0 * 2
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                                Console.WriteLine()


                            End If
                            Console.WriteLine("Enter Score For Introductory Inorganic Chemistry (CHM101)...............2 Unit")
                            CHM101 = Console.ReadLine()
                            If (CHM101 >= 70) And (CHM101 <= 100) Then
                                P5i = 5 * 2
                            ElseIf (CHM101 >= 60) And (CHM101 <= 69) Then
                                P5i = 4 * 2
                            ElseIf (CHM101 >= 50) And (CHM101 <= 59) Then
                                P5i = 3 * 2
                            ElseIf (CHM101 >= 45) And (CHM101 <= 49) Then
                                P5i = 2 * 2
                            ElseIf (CHM101 >= 40) And (CHM101 <= 44) Then
                                P5i = 1 * 2
                            ElseIf (CHM101 >= 0) And (CHM101 <= 39) Then
                                P5i = 0 * 2
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                                Console.WriteLine()

                            End If
                            Console.WriteLine("Enter Score For Introductory Physical Chemistry (CHM103)...............2 Unit")
                            CHM103 = Console.ReadLine()
                            If (CHM103 >= 70) And (CHM103 <= 100) Then
                                P6i = 5 * 2
                            ElseIf (CHM103 >= 60) And (CHM103 <= 69) Then
                                P6i = 4 * 2
                            ElseIf (CHM103 >= 50) And (CHM103 <= 59) Then
                                P6i = 3 * 2
                            ElseIf (CHM103 >= 45) And (CHM103 <= 49) Then
                                P6i = 2 * 2
                            ElseIf (CHM103 >= 40) And (CHM103 <= 44) Then
                                P6i = 1 * 2
                            ElseIf (CHM103 >= 0) And (CHM103 <= 39) Then
                                P6i = 0 * 2
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                                Console.WriteLine()


                            End If
                            Console.WriteLine("Enter Score For Inroductory Data Organisation and Management (CIT143)......2 Unit")
                            CIT143 = Console.ReadLine()
                            If (CIT143 >= 70) And (CIT143 <= 100) Then
                                P7 = 5 * 2
                            ElseIf (CIT143 >= 60) And (CIT143 <= 69) Then
                                P7 = 4 * 2
                            ElseIf (CIT143 >= 50) And (CIT143 <= 59) Then
                                P7 = 3 * 2
                            ElseIf (CIT143 >= 45) And (CIT143 <= 49) Then
                                P7 = 2 * 2
                            ElseIf (CIT143 >= 40) And (CIT143 <= 44) Then
                                P7 = 1 * 2
                            ElseIf (CIT143 >= 0) And (CIT143 <= 39) Then
                                P7 = 0 * 2
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                                Console.WriteLine()


                            End If
                            Console.WriteLine("Enter Score For Elementary Mathematics I (MTH101).....................3 Unit")
                            MTH101 = Console.ReadLine()
                            If (MTH101 >= 70) And (MTH101 <= 100) Then
                                P8 = 5 * 3
                            ElseIf (MTH101 >= 60) And (MTH101 <= 69) Then
                                P8 = 4 * 3
                            ElseIf (MTH101 >= 50) And (MTH101 <= 59) Then
                                P8 = 3 * 3
                            ElseIf (MTH101 >= 45) And (MTH101 <= 49) Then
                                P8 = 2 * 3
                            ElseIf (MTH101 >= 40) And (MTH101 <= 44) Then
                                P8 = 1 * 3
                            ElseIf (MTH101 >= 0) And (MTH101 <= 39) Then
                                P8 = 0 * 3
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                                Console.WriteLine()

                            End If
                            Console.WriteLine("Enter Score For Elementary Mathematics III (MTH103)..................3 Unit")
                            MTH103 = Console.ReadLine()
                            If (MTH103 >= 70) And (MTH103 <= 100) Then
                                P9 = 5 * 3
                            ElseIf (MTH103 >= 60) And (MTH103 <= 69) Then
                                P9 = 4 * 3
                            ElseIf (MTH103 >= 50) And (MTH103 <= 59) Then
                                P9 = 3 * 3
                            ElseIf (MTH103 >= 45) And (MTH103 <= 49) Then
                                P9 = 2 * 3
                            ElseIf (MTH103 >= 40) And (MTH103 <= 44) Then
                                P9 = 1 * 3
                            ElseIf (MTH103 >= 0) And (MTH103 <= 39) Then
                                P9 = 0 * 3
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                                Console.WriteLine()


                            End If
                            Console.WriteLine("Enter Score For Elementary Mechanics, Heat And Properties Of Matter (PHY101).....2 Unit")
                            PHY101 = Console.ReadLine()
                            If PHY101 >= 70 And PHY101 <= 100 Then
                                P10 = 5 * 2
                            ElseIf PHY101 >= 60 And PHY101 <= 69 Then
                                P10 = 4 * 2
                            ElseIf PHY101 >= 50 And PHY101 <= 59 Then
                                P10 = 3 * 2
                            ElseIf PHY101 >= 45 And PHY101 <= 49 Then
                                P10 = 2 * 2
                            ElseIf PHY101 >= 40 And PHY101 <= 44 Then
                                P10 = 1 * 2
                            ElseIf (PHY101 >= 0) And (PHY101 <= 39) Then
                                P10 = 0 * 2
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                                Console.WriteLine()

                            End If
                            Console.WriteLine("Enter Score For General Practical Biology I (BIO191)................1 Unit")
                            BIO191 = Console.ReadLine()
                            If BIO191 >= 70 And BIO191 <= 100 Then
                                P11 = 5 * 1
                            ElseIf BIO191 >= 60 And BIO191 <= 69 Then
                                P11 = 4 * 1
                            ElseIf BIO191 >= 50 And BIO191 <= 59 Then
                                P11 = 3 * 1
                            ElseIf BIO191 >= 45 And BIO191 <= 49 Then
                                P11 = 2 * 1
                            ElseIf BIO191 >= 40 And BIO191 <= 44 Then
                                P11 = 1 * 1
                            ElseIf (BIO191 >= 0) And (BIO191 <= 39) Then
                                P7 = 0 * 1
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                                Console.WriteLine()

                            End If
                            Console.WriteLine("Enter Score For Introductory Practical Physics I (CHM191)................1 Unit")
                            CHM191 = Console.ReadLine()
                            If CHM191 >= 70 And CHM191 <= 100 Then
                                P12 = 5 * 1
                            ElseIf CHM191 >= 60 And CHM191 <= 69 Then
                                P12 = 4 * 1
                            ElseIf CHM191 >= 50 And CHM191 <= 59 Then
                                P12 = 3 * 1
                            ElseIf CHM191 >= 45 And CHM191 <= 49 Then
                                P12 = 2 * 1
                            ElseIf CHM191 >= 40 And CHM191 <= 44 Then
                                P12 = 1 * 1
                            ElseIf (CHM191 >= 0) And (CHM191 <= 39) Then
                                P12 = 0 * 1
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                                Console.WriteLine()


                            End If
                            Console.WriteLine("Enter Score For Introductory Practical Chemistry I (PHY191)...............1 Unit")
                            PHY191 = Console.ReadLine()
                            If PHY191 >= 70 And PHY191 <= 100 Then
                                P13 = 5 * 1
                            ElseIf PHY191 >= 60 And PHY191 <= 69 Then
                                P13 = 4 * 1
                            ElseIf PHY191 >= 50 And PHY191 <= 59 Then
                                P13 = 3 * 1
                            ElseIf PHY191 >= 45 And PHY191 <= 49 Then
                                P13 = 2 * 1
                            ElseIf PHY191 >= 40 And PHY191 <= 44 Then
                                P13 = 1 * 1
                            ElseIf (PHY191 >= 0) And (PHY191 <= 39) Then
                                P13 = 0 * 1
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                                Console.WriteLine()


                            End If


                            gpi = P1i + P2i + p3 + P4i + P5i + p6 + P7 + P8 + P9 + P10 + P11 + P12 + P13
                            cgpai = gpi / 25

                            Console.WriteLine(" Your CGPA For First semester 100Level Is " + cgpai.ToString("N2"))

                            If (cgpai >= 3.6) And (cgpai <= 5.0) Then
                                Console.WriteLine("First Class")

                            ElseIf (cgpai >= 3.0) And (cgpai <= 3.5) Then
                                Console.WriteLine("Seconds Class Upper")

                            ElseIf (cgpai >= 2.5) And (cgpai <= 2.99) Then
                                Console.WriteLine("Second Class Lower")

                            ElseIf (cgpai >= 2.0) And (cgpai <= 2.49) Then
                                Console.WriteLine("Pass")

                            Else
                                Console.WriteLine("Fair")
                            End If
                            Console.WriteLine()

                            Console.WriteLine("Do you want to calculate any other semester")
                            Console.WriteLine("If YES Press 1 OR If NO Press 2")
                            U = Console.ReadLine()
                            If U = 1 Then
                                xu = Console.ReadLine()
                            Else
                                U = 2
                            End If

                        ElseIf (yu = "2") Then

                            Console.WriteLine("Second Semester - 100Level.")
                            Console.WriteLine("==============================================")

                            Console.WriteLine("Enter Score For Use Of English And Communication Skill II (GST102)............2 Unit")
                            GST102 = Console.ReadLine()
                            If GST102 >= 70 And GST102 <= 100 Then
                                C1 = 5 * 2
                            ElseIf GST102 >= 60 And GST102 <= 69 Then
                                C1 = 4 * 2
                            ElseIf GST102 >= 50 And GST102 <= 59 Then
                                C1 = 3 * 2
                            ElseIf GST102 >= 45 And GST102 <= 49 Then
                                C1 = 2 * 2
                            ElseIf GST102 >= 40 And GST102 <= 44 Then
                                C1 = 1 * 2
                            ElseIf (GST102 >= 0) And (GST102 <= 39) Then
                                C1 = 0 * 2
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                                Console.WriteLine()
                            End If

                            Console.WriteLine("Enter Score For Use Of Library (GST104)..............................2 Unit")
                            GST104 = Console.ReadLine()
                            If GST104 >= 70 And GST104 <= 100 Then
                                C2 = 5 * 2
                            ElseIf GST104 >= 60 And GST104 <= 69 Then
                                C2 = 4 * 2
                            ElseIf GST104 >= 50 And GST104 <= 59 Then
                                C2 = 3 * 2
                            ElseIf GST104 >= 45 And GST104 <= 49 Then
                                C2 = 2 * 2
                            ElseIf GST104 >= 40 And GST104 <= 44 Then
                                C2 = 1 * 2
                            ElseIf (GST104 >= 0) And (GST104 <= 39) Then
                                C2 = 0 * 2
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                                Console.WriteLine()
                            End If

                            Console.WriteLine("Enter Score For Introductory Organic Chemistry (CHM102)..................2 Unit")
                            CHM102 = Console.ReadLine()
                            If CHM102 >= 70 And CHM102 <= 100 Then
                                C3 = 5 * 2
                            ElseIf CHM102 >= 60 And CHM102 <= 69 Then
                                C3 = 4 * 2
                            ElseIf CHM102 >= 50 And CHM102 <= 59 Then
                                C3 = 3 * 2
                            ElseIf CHM102 >= 45 And CHM102 <= 49 Then
                                C3 = 2 * 2
                            ElseIf CHM102 >= 40 And CHM102 <= 44 Then
                                C3 = 1 * 2
                            ElseIf (CHM102 >= 0) And (CHM102 <= 39) Then
                                C3 = 0 * 2
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                                Console.WriteLine()

                            End If
                            Console.WriteLine("Enter Score For Software Application Skills (CIT102)....................2 Unit")
                            CIT102 = Console.ReadLine()
                            If CIT102 >= 70 And CIT102 <= 100 Then
                                C4 = 5 * 2
                            ElseIf CIT102 >= 60 And CIT102 <= 69 Then
                                C4 = 4 * 2
                            ElseIf CIT102 >= 50 And CIT102 <= 59 Then
                                C4 = 3 * 2
                            ElseIf CIT102 >= 45 And CIT102 <= 49 Then
                                C4 = 2 * 2
                            ElseIf CIT102 >= 40 And CIT102 <= 44 Then
                                C4 = 1 * 2
                            ElseIf (CIT102 >= 0) And (CIT102 <= 39) Then
                                C4 = 0 * 2
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                                Console.WriteLine()
                            End If

                            Console.WriteLine("Enter Score For Introduction To Computer Science (CIT104).................2 Unit")
                            CIT104 = Console.ReadLine()
                            If CIT104 >= 70 And CIT104 <= 100 Then
                                C5 = 5 * 2
                            ElseIf CIT104 >= 60 And CIT104 <= 69 Then
                                C5 = 4 * 2
                            ElseIf CIT104 >= 50 And CIT104 <= 59 Then
                                C5 = 3 * 2
                            ElseIf CIT104 >= 45 And CIT104 <= 49 Then
                                C5 = 2 * 2
                            ElseIf CIT104 >= 40 And CIT104 <= 44 Then
                                C5 = 1 * 2
                            ElseIf (CIT104 >= 0) And (CIT104 <= 39) Then
                                C5 = 0 * 2
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End

                            End If
                            Console.WriteLine()


                            Console.WriteLine("Enter Score For Introduction Statistics (STT102).....................2 Unit")
                            STT102 = Console.ReadLine()
                            If STT102 >= 70 And STT102 <= 100 Then
                                P1 = 5 * 2
                            ElseIf STT102 >= 60 And STT102 <= 69 Then
                                C6 = 4 * 2
                            ElseIf STT102 >= 50 And STT102 <= 59 Then
                                C6 = 3 * 2
                            ElseIf STT102 >= 45 And STT102 <= 49 Then
                                C6 = 2 * 2
                            ElseIf STT102 >= 40 And STT102 <= 44 Then
                                C6 = 1 * 2
                            ElseIf (STT102 >= 0) And (STT102 <= 39) Then
                                C6 = 0 * 2
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End

                            End If
                            Console.WriteLine()


                            Console.WriteLine("Enter Score For Elementary Mathematics II (MTH102)......................2 Unit")
                            MTH102 = Console.ReadLine()
                            If MTH102 >= 70 And MTH102 <= 100 Then
                                C7 = 5 * 2
                            ElseIf MTH102 >= 60 And MTH102 <= 69 Then
                                C7 = 4 * 2
                            ElseIf MTH102 >= 50 And MTH102 <= 59 Then
                                C7 = 3 * 2
                            ElseIf MTH102 >= 45 And MTH102 <= 49 Then
                                C7 = 2 * 2
                            ElseIf MTH102 >= 40 And MTH102 <= 44 Then
                                C7 = 1 * 2
                            ElseIf (MTH102 >= 0) And (MTH102 <= 39) Then
                                C7 = 0 * 2
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End

                            End If
                            Console.WriteLine()


                            Console.WriteLine("Enter Score For General Biology II (BIO102)..............................2 Unit")
                            BIO102 = Console.ReadLine()
                            If BIO102 >= 70 And BIO102 <= 100 Then
                                C8 = 5 * 2
                            ElseIf BIO102 >= 60 And BIO102 <= 69 Then
                                C8 = 4 * 2
                            ElseIf BIO102 >= 50 And BIO102 <= 59 Then
                                C8 = 3 * 2
                            ElseIf BIO102 >= 45 And BIO102 <= 49 Then
                                C8 = 2 * 2
                            ElseIf BIO102 >= 40 And GST101 <= 44 Then
                                C8 = 1 * 2
                            ElseIf (BIO102 >= 0) And (BIO102 <= 39) Then
                                C8 = 0 * 2
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End

                            End If
                            Console.WriteLine()


                            Console.WriteLine("Enter Score For General Biology Practicl II (BIO192)..........................1 Unit")
                            BIO191 = Console.ReadLine()
                            If BIO192 >= 70 And BIO192 <= 100 Then
                                C9 = 5 * 1
                            ElseIf BIO192 >= 60 And BIO192 <= 69 Then
                                C9 = 4 * 1
                            ElseIf BIO192 >= 50 And BIO192 <= 59 Then
                                C9 = 3 * 1
                            ElseIf BIO192 >= 45 And BIO192 <= 49 Then
                                C9 = 2 * 1
                            ElseIf BIO192 >= 40 And BIO192 <= 44 Then
                                C9 = 1 * 1
                            ElseIf (BIO192 >= 0) And (BIO192 <= 39) Then
                                C9 = 0 * 1
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End

                            End If
                            Console.WriteLine()


                            Console.WriteLine("Enter Score For Introdction Practical ChemistryII (CHM192)..................1 Unit")
                            CHM192 = Console.ReadLine()
                            If CHM192 >= 70 And CHM192 <= 100 Then
                                C10 = 5 * 1
                            ElseIf CHM192 >= 60 And CHM192 <= 69 Then
                                C10 = 4 * 1
                            ElseIf CHM192 >= 50 And CHM192 <= 59 Then
                                C10 = 3 * 1
                            ElseIf CHM192 >= 45 And CHM192 <= 49 Then
                                C10 = 2 * 1
                            ElseIf CHM192 >= 40 And CHM192 <= 44 Then
                                C10 = 1 * 1
                            ElseIf (CHM192 >= 0) And (CHM192 <= 39) Then
                                C10 = 0 * 1
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End

                            End If
                            Console.WriteLine()


                            Console.WriteLine("Enter Score For Introductory Practical Physics II (PHY192)...................1 Unit")
                            PHY192 = Console.ReadLine()
                            If PHY192 >= 70 And PHY192 <= 100 Then
                                C11 = 5 * 1
                            ElseIf PHY192 >= 60 And PHY192 <= 69 Then
                                C11 = 4 * 1
                            ElseIf PHY192 >= 50 And PHY192 <= 59 Then
                                C11 = 3 * 1
                            ElseIf PHY192 >= 45 And PHY192 <= 49 Then
                                C11 = 2 * 1
                            ElseIf PHY192 >= 40 And PHY192 <= 44 Then
                                C11 = 1 * 1
                            ElseIf (PHY192 >= 0) And (PHY192 <= 39) Then
                                C11 = 0 * 1
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End

                            End If
                            Console.WriteLine()


                            Console.WriteLine("Enter Score For Electricty, Magnetism And Modern Physic (PHY102)............3 Unit")
                            PHY102 = Console.ReadLine()
                            If PHY102 >= 70 And PHY102 <= 100 Then
                                C12 = 5 * 3
                            ElseIf PHY102 >= 60 And PHY102 <= 69 Then
                                C12 = 4 * 3
                            ElseIf PHY102 >= 50 And PHY102 <= 59 Then
                                C12 = 3 * 3
                            ElseIf PHY102 >= 45 And PHY102 <= 49 Then
                                C12 = 2 * 3
                            ElseIf PHY102 >= 40 And PHY102 <= 44 Then
                                C12 = 1 * 3
                            ElseIf (PHY102 >= 0) And (PHY102 <= 39) Then
                                C12 = 0 * 3
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End

                            End If

                            Console.WriteLine("==============================================")

                            gp2 = C1 + C1 + C3 + C4 + C5 + C6 + C7 + C8 + C9 + C10 + C11 + C12
                            cgpa2 = gp2 / 22

                            Console.WriteLine("CGPA For Second Semester is " + cgpa2.ToString("N2"))
                            Console.WriteLine()

                            If (cgpa2 >= 3.6) And (cgpa2 <= 5.0) Then
                                Console.WriteLine("First Class")

                            ElseIf (cgpa2 >= 3.0) And (cgpa2 <= 3.5) Then
                                Console.WriteLine("Seconds Class Upper")

                            ElseIf (cgpa2 >= 2.5) And (cgpa2 <= 2.99) Then
                                Console.WriteLine("Second Class Lower")

                            ElseIf (cgpa2 >= 2.0) And (cgpa2 <= 2.49) Then
                                Console.WriteLine("Pass")

                            Else
                                Console.WriteLine("Fair")
                            End If
                        Else
                            Console.WriteLine("invalid input")
                        End If


                    ElseIf (xu = "2") Then

                        Console.WriteLine("200Level")
                        Console.WriteLine("==============================================")
                        Console.WriteLine("Press 1 For First Semester")
                        Console.WriteLine("Press 2 For First Semester")
                        Console.WriteLine("==============================================")
                        Ku = Console.ReadLine()


                        If (Ku = "1") Then


                            Console.WriteLine("200l 1st semester")
                            Console.WriteLine("==============================================")

                            Console.WriteLine("Enter Score For Nigerian People And Culture(GST201)......................2 Unit")
                            GST201 = Console.ReadLine()
                            If GST201 >= 70 And GST201 <= 100 Then
                                K1 = 5 * 2
                            ElseIf GST201 >= 60 And GST201 <= 69 Then
                                K1 = 4 * 2
                            ElseIf GST201 >= 50 And GST201 <= 59 Then
                                K1 = 3 * 2
                            ElseIf GST201 >= 45 And GST201 <= 49 Then
                                K1 = 2 * 2
                            ElseIf GST201 >= 40 And GST201 <= 44 Then
                                K1 = 1 * 2
                            ElseIf (GST201 >= 0) And (GST201 <= 39) Then
                                K1 = 0 * 2
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()


                            Console.WriteLine("Enter Score For Introduction To Philosophy And Logic(GST203)............2 Unit")
                            GST203 = Console.ReadLine()
                            If GST203 >= 70 And GST203 <= 100 Then
                                K2 = 5 * 2
                            ElseIf GST203 >= 60 And GST203 <= 69 Then
                                K2 = 4 * 2
                            ElseIf GST203 >= 50 And GST203 <= 59 Then
                                K2 = 3 * 2
                            ElseIf GST203 >= 45 And GST203 <= 49 Then
                                K2 = 2 * 2
                            ElseIf GST203 >= 40 And GST203 <= 44 Then
                                K2 = 1 * 2
                            ElseIf (GST203 >= 0) And (GST203 <= 39) Then
                                K2 = 0 * 2
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()


                            Console.WriteLine("Enter Score For Introduction To Operation Systems(CIT211).................3 Unit")
                            CIT211 = Console.ReadLine()
                            If CIT211 >= 70 And CIT211 <= 100 Then
                                K3 = 5 * 3
                            ElseIf CIT211 >= 60 And CIT211 <= 69 Then
                                K3 = 4 * 3
                            ElseIf CIT211 >= 50 And CIT211 <= 59 Then
                                K3 = 3 * 3
                            ElseIf CIT211 >= 45 And CIT211 <= 49 Then
                                K3 = 2 * 3
                            ElseIf CIT211 >= 40 And CIT211 <= 44 Then
                                K3 = 1 * 3
                            ElseIf (CIT211 >= 0) And (CIT211 <= 39) Then
                                K3 = 0 * 3
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()


                            Console.WriteLine("Enter Score For Introduction To Programming Languages(CIT215).............3 Unit")
                            CIT215 = Console.ReadLine()
                            If CIT215 >= 70 And CIT215 <= 100 Then
                                K4 = 5 * 3
                            ElseIf CIT215 >= 60 And CIT215 <= 69 Then
                                K4 = 4 * 3
                            ElseIf CIT215 >= 50 And CIT215 <= 59 Then
                                K4 = 3 * 3
                            ElseIf CIT215 >= 45 And CIT215 <= 49 Then
                                K4 = 2 * 3
                            ElseIf CIT215 >= 40 And CIT215 <= 44 Then
                                K4 = 1 * 3
                            ElseIf (CIT215 >= 0) And (CIT215 <= 39) Then
                                K4 = 0 * 3
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()


                            Console.WriteLine("Enter Score For Programming $ Algorithms(CIT237).........................3 Unit")
                            CIT237 = Console.ReadLine()
                            If CIT237 >= 70 And CIT237 <= 100 Then
                                K5 = 5 * 3
                            ElseIf CIT237 >= 60 And CIT237 <= 69 Then
                                K5 = 4 * 3
                            ElseIf CIT237 >= 50 And CIT237 <= 59 Then
                                K5 = 3 * 3
                            ElseIf CIT237 >= 45 And CIT237 <= 49 Then
                                K5 = 2 * 3
                            ElseIf CIT237 >= 40 And CIT237 <= 44 Then
                                K5 = 1 * 3
                            ElseIf (CIT237 >= 0) And (CIT237 <= 39) Then
                                K5 = 0 * 3
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()


                            Console.WriteLine("Enter Score For Introduction To Set Theory And Abstract Algebra(MTH211)......3 Unit")
                            MTH211 = Console.ReadLine()
                            If MTH211 >= 70 And MTH211 <= 100 Then
                                K6 = 5 * 3
                            ElseIf MTH211 >= 60 And MTH211 <= 69 Then
                                K6 = 4 * 3
                            ElseIf MTH211 >= 50 And MTH211 <= 59 Then
                                K6 = 3 * 3
                            ElseIf MTH211 >= 45 And MTH211 <= 49 Then
                                K6 = 2 * 3
                            ElseIf MTH211 >= 40 And MTH211 <= 44 Then
                                K6 = 1 * 3
                            ElseIf (MTH211 >= 0) And (MTH211 <= 39) Then
                                K6 = 0 * 3
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()


                            Console.WriteLine("Enter Score For Numerical Analysis I(MTH213).................................3 Unit")
                            MTH213 = Console.ReadLine()
                            If MTH213 >= 70 And MTH213 <= 100 Then
                                K7 = 5 * 3
                            ElseIf MTH213 >= 60 And MTH213 <= 69 Then
                                K7 = 4 * 3
                            ElseIf MTH213 >= 50 And MTH213 <= 59 Then
                                K7 = 3 * 3
                            ElseIf MTH213 >= 45 And MTH213 <= 49 Then
                                K7 = 2 * 3
                            ElseIf MTH213 >= 40 And MTH213 <= 44 Then
                                K7 = 1 * 3
                            ElseIf (MTH213 >= 0) And (MTH213 <= 39) Then
                                K7 = 0 * 3
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()


                            Console.WriteLine("Enter Score For Mathematical Methods I(MTH281)............................3 Unit")
                            MTH281 = Console.ReadLine()
                            If MTH281 >= 70 And MTH281 <= 100 Then
                                K8 = 5 * 3
                            ElseIf MTH281 >= 60 And MTH281 <= 69 Then
                                K8 = 4 * 3
                            ElseIf MTH281 >= 50 And MTH281 <= 59 Then
                                K8 = 3 * 3
                            ElseIf MTH281 >= 45 And MTH281 <= 49 Then
                                K8 = 2 * 3
                            ElseIf MTH281 >= 40 And MTH281 <= 44 Then
                                K8 = 1 * 3
                            ElseIf (MTH281 >= 0) And (MTH281 <= 39) Then
                                K8 = 0 * 3
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            gp3 = K1 + K2 + K3 + K4 + K5 + K6 + K7 + K8
                            cgpa3 = gp3 / 22

                            Console.WriteLine("Your 1st semester 200Level CGPA " + cgpa3.ToString("N2"))
                            Console.WriteLine()
                            If (cgpa3 >= 3.6) And (cgpa3 <= 5.0) Then
                                Console.WriteLine("First Class")

                            ElseIf (cgpa3 >= 3.0) And (cgpa3 <= 3.5) Then
                                Console.WriteLine("Seconds Class Upper")

                            ElseIf (cgpa3 >= 2.5) And (cgpa3 <= 2.99) Then
                                Console.WriteLine("Second Class Lower")

                            ElseIf (cgpa3 >= 2.0) And (cgpa3 <= 2.49) Then
                                Console.WriteLine("Pass")

                            Else
                                Console.WriteLine("Fair")
                            End If

                            Console.WriteLine()



                        ElseIf (Ku = "2") Then

                            Console.WriteLine("2nd semester 200level")
                            Console.WriteLine("==============================================")

                            Console.WriteLine("Enter Score For Fundamentals Of Peace Studies And Conflict Resolution(GST202).....3 Unit")
                            GST202 = Console.ReadLine()
                            If GST202 >= 70 And GST202 <= 100 Then
                                A1 = 5 * 3
                            ElseIf GST202 >= 60 And GST202 <= 69 Then
                                A1 = 4 * 3
                            ElseIf GST202 >= 50 And GST202 <= 59 Then
                                A1 = 3 * 3
                            ElseIf GST202 >= 45 And GST202 <= 49 Then
                                A1 = 2 * 3
                            ElseIf GST202 >= 40 And GST202 <= 44 Then
                                A1 = 1 * 3
                            ElseIf (GST202 >= 0) And (GST202 <= 39) Then
                                A1 = 0 * 3
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            Console.WriteLine("Enter Score For Entrepreneurship And Innovation(GST204)..................3 Unit")
                            GST204 = Console.ReadLine()
                            If GST204 >= 70 And GST204 <= 100 Then
                                A2 = 5 * 3
                            ElseIf GST204 >= 60 And GST204 <= 69 Then
                                A2 = 4 * 3
                            ElseIf GST204 >= 50 And GST204 <= 59 Then
                                A2 = 3 * 3
                            ElseIf GST204 >= 45 And GST204 <= 49 Then
                                A2 = 2 * 3
                            ElseIf GST204 >= 40 And GST204 <= 44 Then
                                A2 = 1 * 3
                            ElseIf (GST204 >= 0) And (GST204 <= 39) Then
                                A2 = 0 * 3
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            Console.WriteLine("Enter Score For Information Systems(CIT208)................................3 Unit")
                            CIT208 = Console.ReadLine()
                            If CIT208 >= 70 And CIT208 <= 100 Then
                                A3 = 5 * 3
                            ElseIf CIT208 >= 60 And CIT208 <= 69 Then
                                A3 = 4 * 3
                            ElseIf CIT208 >= 50 And CIT208 <= 59 Then
                                A3 = 3 * 3
                            ElseIf CIT208 >= 45 And CIT208 <= 49 Then
                                A3 = 2 * 3
                            ElseIf CIT208 >= 40 And CIT208 <= 44 Then
                                A3 = 1 * 3
                            ElseIf (CIT208 >= 0) And (CIT208 <= 39) Then
                                A3 = 0 * 3
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            Console.WriteLine("Enter Score For Systems Analysis And Design(CIT212)....................3 Unit")
                            CIT212 = Console.ReadLine()
                            If CIT212 >= 70 And CIT212 <= 100 Then
                                A4 = 5 * 3
                            ElseIf CIT212 >= 60 And CIT212 <= 69 Then
                                A4 = 4 * 3
                            ElseIf CIT212 >= 50 And CIT212 <= 59 Then
                                A4 = 3 * 3
                            ElseIf CIT212 >= 45 And CIT212 <= 49 Then
                                A4 = 2 * 3
                            ElseIf CIT212 >= 40 And CIT212 <= 44 Then
                                A4 = 1 * 3
                            ElseIf (CIT212 >= 0) And (CIT212 <= 39) Then
                                A4 = 0 * 3
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            Console.WriteLine("Enter Score For Analog And Digital Electronics(CIT236)..................3")
                            CIT236 = Console.ReadLine()
                            If CIT236 >= 70 And CIT236 <= 100 Then
                                A5 = 5 * 3
                            ElseIf CIT236 >= 60 And CIT236 <= 69 Then
                                A5 = 4 * 3
                            ElseIf CIT236 >= 50 And CIT236 <= 59 Then
                                A5 = 3 * 3
                            ElseIf CIT236 >= 45 And CIT236 <= 49 Then
                                A5 = 2 * 3
                            ElseIf CIT236 >= 40 And CIT236 <= 44 Then
                                A5 = 1 * 3
                            ElseIf (CIT236 >= 0) And (CIT236 <= 39) Then
                                A5 = 0 * 3
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            Console.WriteLine("Enter Score For Computer Laboratory I(CIT292)..............................3 Unit")
                            CIT292 = Console.ReadLine()
                            If CIT292 >= 70 And CIT292 <= 100 Then
                                A6 = 5 * 3
                            ElseIf CIT292 >= 60 And CIT292 <= 69 Then
                                A6 = 4 * 3
                            ElseIf CIT292 >= 50 And CIT292 <= 59 Then
                                A6 = 3 * 3
                            ElseIf CIT292 >= 45 And CIT292 <= 49 Then
                                A6 = 2 * 3
                            ElseIf CIT292 >= 40 And CIT292 <= 44 Then
                                A6 = 1 * 3
                            ElseIf (CIT292 >= 0) And (CIT292 <= 39) Then
                                A6 = 0 * 3
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            Console.WriteLine("Enter Score For Linear Algebra II(MTH212)..................................3 Unit")
                            MTH212 = Console.ReadLine()
                            If MTH212 >= 70 And MTH212 <= 100 Then
                                A7 = 5 * 3
                            ElseIf MTH212 >= 60 And MTH212 <= 69 Then
                                A7 = 4 * 3
                            ElseIf MTH212 >= 50 And MTH212 <= 59 Then
                                A7 = 3 * 3
                            ElseIf MTH212 >= 45 And MTH212 <= 49 Then
                                A7 = 2 * 3
                            ElseIf MTH212 >= 40 And MTH212 <= 44 Then
                                A7 = 1 * 3
                            ElseIf (MTH212 >= 0) And (MTH212 <= 39) Then
                                A7 = 0 * 3
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            Console.WriteLine("Enter Score For Elementary Differential Equations(MTH232)...................3 Unit")
                            MTH232 = Console.ReadLine()
                            If MTH232 >= 70 And MTH232 <= 100 Then
                                A10 = 5 * 3
                            ElseIf MTH232 >= 60 And MTH232 <= 69 Then
                                A10 = 4 * 3
                            ElseIf MTH232 >= 50 And MTH232 <= 59 Then
                                A10 = 3 * 3
                            ElseIf MTH232 >= 45 And MTH232 <= 49 Then
                                A10 = 2 * 3
                            ElseIf MTH232 >= 40 And MTH232 <= 44 Then
                                A10 = 1 * 3
                            ElseIf (MTH232 >= 0) And (MTH232 <= 39) Then
                                A10 = 0 * 3
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            Console.WriteLine("Enter Score For Mathematical Methods II(MTH282).............................3 Unit")
                            MTH282 = Console.ReadLine()
                            If MTH282 >= 70 And MTH282 <= 100 Then
                                A8 = 5 * 3
                            ElseIf MTH282 >= 60 And MTH282 <= 69 Then
                                A8 = 4 * 3
                            ElseIf MTH282 >= 50 And MTH282 <= 59 Then
                                A8 = 3 * 3
                            ElseIf MTH282 >= 45 And MTH282 <= 49 Then
                                A8 = 2 * 3
                            ElseIf MTH282 >= 40 And MTH282 <= 44 Then
                                A8 = 1 * 3
                            ElseIf (MTH282 >= 0) And (MTH282 <= 39) Then
                                A8 = 0 * 3
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            Console.WriteLine("Enter Score For Network Analysis And Devices(PHY208)....................3 Unit")
                            PHY208 = Console.ReadLine()
                            If PHY208 >= 70 And PHY208 <= 100 Then
                                A9 = 5 * 3
                            ElseIf PHY208 >= 60 And PHY208 <= 69 Then
                                A9 = 4 * 3
                            ElseIf PHY208 >= 50 And PHY208 <= 59 Then
                                A9 = 3 * 3
                            ElseIf PHY208 >= 45 And PHY208 <= 49 Then
                                A9 = 2 * 3
                            ElseIf PHY208 >= 40 And PHY208 <= 44 Then
                                A9 = 1 * 3
                            ElseIf (PHY208 >= 0) And (PHY208 <= 39) Then
                                A9 = 0 * 3
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            gp4 = A1 + A2 + A3 + A4 + A5 + A6 + A7 + A8 + A9 + A10
                            cgpa4 = gp4 / 24

                            Console.WriteLine("Your 2nd Semester CGPA For 200Level" + cgpa4.ToString("N2"))
                            Console.WriteLine()
                            If (cgpa4 >= 3.6) And (cgpa4 <= 5.0) Then
                                Console.WriteLine("First Class")

                            ElseIf (cgpa4 >= 3.0) And (cgpa4 <= 3.5) Then
                                Console.WriteLine("Seconds Class Upper")

                            ElseIf (cgpa4 >= 2.5) And (cgpa4 <= 2.99) Then
                                Console.WriteLine("Second Class Lower")

                            ElseIf (cgpa4 >= 2.0) And (cgpa4 <= 2.49) Then
                                Console.WriteLine("Pass")

                            Else
                                Console.WriteLine("Fair")
                            End If
                        Else
                            Console.WriteLine("invalid input")
                        End If






                    ElseIf (xu = "3") Then

                        Console.WriteLine("300Level")
                        Console.WriteLine("==============================================")

                        Console.WriteLine("Press 1 For First Semester")
                        Console.WriteLine("Press 2 For First Semester")
                        Console.WriteLine("==============================================")
                        J = Console.ReadLine()

                        If (J = "1") Then


                            Console.WriteLine("1st Semester")
                            Console.WriteLine("==============================================")

                            Console.WriteLine("Enter Score For Principle Of Communicaton Technology(CIT303).................3 Unit")
                            CIT303 = Console.ReadLine()
                            If CIT303 >= 70 And CIT303 <= 100 Then
                                B1 = 5 * 3
                            ElseIf CIT303 >= 60 And CIT303 <= 69 Then
                                B1 = 4 * 3
                            ElseIf CIT303 >= 50 And CIT303 <= 59 Then
                                B1 = 3 * 3
                            ElseIf CIT303 >= 45 And CIT303 <= 49 Then
                                B1 = 2 * 3
                            ElseIf CIT303 >= 40 And CIT303 <= 44 Then
                                B1 = 1 * 3
                            ElseIf (CIT303 >= 0) And (CIT303 <= 39) Then
                                B1 = 0 * 3
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            Console.WriteLine("Enter Score For Networking And Communication Technology(CIT305)...........3 Unit")
                            CIT305 = Console.ReadLine()
                            If CIT305 >= 70 And CIT305 <= 100 Then
                                B2 = 5 * 3
                            ElseIf CIT305 >= 60 And CIT305 <= 69 Then
                                B2 = 4 * 3
                            ElseIf CIT305 >= 50 And CIT305 <= 59 Then
                                B2 = 3 * 3
                            ElseIf CIT305 >= 45 And CIT305 <= 49 Then
                                B2 = 2 * 3
                            ElseIf CIT305 >= 40 And CIT305 <= 44 Then
                                B2 = 1 * 3
                            ElseIf (CIT305 >= 0) And (CIT305 <= 39) Then
                                B2 = 0 * 3
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            Console.WriteLine("Enter Score For Computer Architecture(CIT309)..............................3 Unit")
                            CIT309 = Console.ReadLine()
                            If CIT309 >= 70 And CIT309 <= 100 Then
                                B3 = 5 * 3
                            ElseIf CIT309 >= 60 And CIT309 <= 69 Then
                                B3 = 4 * 3
                            ElseIf CIT309 >= 50 And CIT309 <= 59 Then
                                B3 = 3 * 3
                            ElseIf CIT309 >= 45 And CIT309 <= 49 Then
                                B3 = 2 * 3
                            ElseIf CIT309 >= 40 And CIT309 <= 44 Then
                                B3 = 1 * 3
                            ElseIf (CIT309 >= 0) And (CIT309 <= 39) Then
                                B3 = 0 * 3
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            Console.WriteLine("Enter Score For Computer Network(CIT311)...................................3 Unit")
                            CIT311 = Console.ReadLine()
                            If CIT311 >= 70 And CIT311 <= 100 Then
                                B4 = 5 * 3
                            ElseIf CIT311 >= 60 And CIT311 <= 69 Then
                                B4 = 4 * 3
                            ElseIf CIT311 >= 50 And CIT311 <= 59 Then
                                B4 = 3 * 3
                            ElseIf CIT311 >= 45 And CIT311 <= 49 Then
                                B4 = 2 * 3
                            ElseIf CIT311 >= 40 And CIT311 <= 44 Then
                                B4 = 1 * 3
                            ElseIf (CIT311 >= 0) And (CIT311 <= 39) Then
                                B4 = 0 * 3
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            Console.WriteLine("Enter Score For Data Structure(CIT341)......................................3 Unit")
                            CIT341 = Console.ReadLine()
                            If CIT341 >= 70 And CIT341 <= 100 Then
                                B5 = 5 * 3
                            ElseIf CIT341 >= 60 And CIT341 <= 69 Then
                                B5 = 4 * 3
                            ElseIf CIT341 >= 50 And CIT341 <= 59 Then
                                B5 = 3 * 3
                            ElseIf CIT341 >= 45 And CIT341 <= 49 Then
                                B5 = 2 * 3
                            ElseIf CIT341 >= 40 And CIT341 <= 44 Then
                                B5 = 1 * 3
                            ElseIf (CIT341 >= 0) And (CIT341 <= 39) Then
                                B5 = 0 * 3
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            Console.WriteLine("Enter Score For Introduction To Computer Graphics And Animation(CIT371)......3 Unit")
                            CIT371 = Console.ReadLine()
                            If CIT371 >= 70 And CIT371 <= 100 Then
                                B6 = 5 * 3
                            ElseIf CIT371 >= 60 And CIT371 <= 69 Then
                                B6 = 4 * 3
                            ElseIf CIT371 >= 50 And CIT371 <= 59 Then
                                B6 = 3 * 3
                            ElseIf CIT371 >= 45 And CIT371 <= 49 Then
                                B6 = 2 * 3
                            ElseIf CIT371 >= 40 And CIT371 <= 44 Then
                                B6 = 1 * 3
                            ElseIf (CIT371 >= 0) And (CIT371 <= 39) Then
                                B6 = 0 * 3
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            Console.WriteLine("Enter Score For File Processing And Management(CIT381)......................3 Unit")
                            CIT381 = Console.ReadLine()
                            If CIT381 >= 70 And CIT381 <= 100 Then
                                B7 = 5 * 3
                            ElseIf CIT381 >= 60 And CIT381 <= 69 Then
                                B7 = 4 * 3
                            ElseIf CIT381 >= 50 And CIT381 <= 59 Then
                                B7 = 3 * 3
                            ElseIf CIT381 >= 45 And CIT381 <= 49 Then
                                B7 = 2 * 3
                            ElseIf CIT381 >= 40 And CIT381 <= 44 Then
                                B7 = 1 * 3
                            ElseIf (CIT381 >= 0) And (CIT381 <= 39) Then
                                B7 = 0 * 3
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            Console.WriteLine("Enter Score For Industrial Training/SIWES(CIT389)............................6 Unit")
                            CIT389 = Console.ReadLine()
                            If CIT389 >= 70 And CIT389 <= 100 Then
                                B8 = 5 * 6
                            ElseIf CIT389 >= 60 And CIT389 <= 69 Then
                                B8 = 4 * 6
                            ElseIf CIT389 >= 50 And CIT389 <= 59 Then
                                B8 = 3 * 6
                            ElseIf CIT389 >= 45 And CIT389 <= 49 Then
                                B8 = 2 * 6
                            ElseIf CIT389 >= 40 And CIT389 <= 44 Then
                                B8 = 1 * 6
                            ElseIf (CIT389 >= 0) And (CIT389 <= 39) Then
                                B8 = 0 * 6
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            gp5 = B1 + B2 + B3 + B4 + B5 + B6 + B7 + B8
                            cgpa5 = gp5 / 27

                            Console.WriteLine("Your 1st Semester CGPA For 300Level Is = " + cgpa5.ToString("N2"))
                            Console.WriteLine()

                            If (cgpa5 >= 3.6) And (cgpa5 <= 5.0) Then
                                Console.WriteLine("First Class")

                            ElseIf (cgpa5 >= 3.0) And (cgpa5 <= 3.5) Then
                                Console.WriteLine("Seconds Class Upper")

                            ElseIf (cgpa5 >= 2.5) And (cgpa5 <= 2.99) Then
                                Console.WriteLine("Second Class Lower")

                            ElseIf (cgpa5 >= 2.0) And (cgpa5 <= 2.49) Then
                                Console.WriteLine("Pass")

                            Else
                                Console.WriteLine("Fair")
                            End If

                            Console.WriteLine()




                        ElseIf (J = "2") Then

                            Console.WriteLine("2nd Semester; 300Level")
                            Console.WriteLine("==============================================")

                            Console.WriteLine("Enter Score For Business Creation And Growth(GST302).....................2 Unit")
                            GST302 = Console.ReadLine()
                            If GST302 >= 70 And GST302 <= 100 Then
                                R1 = 5 * 2
                            ElseIf GST302 >= 60 And GST302 <= 69 Then
                                R1 = 4 * 2
                            ElseIf GST302 >= 50 And GST302 <= 59 Then
                                R1 = 3 * 2
                            ElseIf GST302 >= 45 And GST302 <= 49 Then
                                R1 = 2 * 2
                            ElseIf GST302 >= 40 And GST302 <= 44 Then
                                R1 = 1 * 2
                            ElseIf (GST302 >= 0) And (GST302 <= 39) Then
                                R1 = 0 * 2
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            Console.WriteLine("Enter Score For Introduction To Internet Programming(CIT322).............3 Unit")
                            CIT322 = Console.ReadLine()
                            If CIT322 >= 70 And CIT322 <= 100 Then
                                R2 = 5 * 3
                            ElseIf CIT322 >= 60 And CIT322 <= 69 Then
                                R2 = 4 * 3
                            ElseIf CIT322 >= 50 And CIT322 <= 59 Then
                                R2 = 3 * 3
                            ElseIf CIT322 >= 45 And CIT322 <= 49 Then
                                R2 = 2 * 3
                            ElseIf CIT322 >= 40 And CIT322 <= 44 Then
                                R2 = 1 * 3
                            ElseIf (CIT322 >= 0) And (CIT322 <= 39) Then
                                R2 = 0 * 3
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            Console.WriteLine("Enter Score For Formal Languages & Automata Theory(CIT342).................3 Unit")
                            CIT342 = Console.ReadLine()
                            If CIT342 >= 70 And CIT342 <= 100 Then
                                R3 = 5 * 3
                            ElseIf CIT371 >= 60 And CIT342 <= 69 Then
                                R3 = 4 * 3
                            ElseIf CIT342 >= 50 And CIT342 <= 59 Then
                                R3 = 3 * 3
                            ElseIf CIT342 >= 45 And CIT342 <= 49 Then
                                R3 = 2 * 3
                            ElseIf CIT342 >= 40 And CIT342 <= 44 Then
                                R3 = 1 * 3
                            ElseIf (CIT342 >= 0) And (CIT342 <= 39) Then
                                R3 = 0 * 3
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            Console.WriteLine("Enter Score For Introduction To Computer Design(CIT344)......................3 Unit")
                            CIT344 = Console.ReadLine()
                            If CIT344 >= 70 And CIT344 <= 100 Then
                                R4 = 5 * 3
                            ElseIf CIT344 >= 60 And CIT344 <= 69 Then
                                R4 = 4 * 3
                            ElseIf CIT344 >= 50 And CIT344 <= 59 Then
                                R4 = 3 * 3
                            ElseIf CIT344 >= 45 And CIT344 <= 49 Then
                                R4 = 2 * 3
                            ElseIf CIT344 >= 40 And CIT344 <= 44 Then
                                R4 = 1 * 3
                            ElseIf (CIT344 >= 0) And (CIT344 <= 39) Then
                                R4 = 0 * 3
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            Console.WriteLine("Enter Score For Computer LaboratoryII(CIT392)..............................2 Unit")
                            CIT392 = Console.ReadLine()
                            If CIT392 >= 70 And CIT392 <= 100 Then
                                R5 = 5 * 2
                            ElseIf CIT392 >= 60 And CIT392 <= 69 Then
                                R5 = 4 * 2
                            ElseIf CIT392 >= 50 And CIT392 <= 59 Then
                                R5 = 3 * 2
                            ElseIf CIT392 >= 45 And CIT392 <= 49 Then
                                R5 = 2 * 2
                            ElseIf CIT392 >= 40 And CIT392 <= 44 Then
                                R5 = 1 * 2
                            ElseIf (CIT392 >= 0) And (CIT392 <= 39) Then
                                R5 = 0 * 2
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            Console.WriteLine("Enter Score For Data Mining And Data Housing(DAM301)......................3 Unit")
                            DAM301 = Console.ReadLine()
                            If DAM301 >= 70 And DAM301 <= 100 Then
                                R6 = 5 * 3
                            ElseIf DAM301 >= 60 And DAM301 <= 69 Then
                                R6 = 4 * 3
                            ElseIf DAM301 >= 50 And DAM301 <= 59 Then
                                R6 = 3 * 3
                            ElseIf DAM301 >= 45 And DAM301 <= 49 Then
                                R6 = 2 * 3
                            ElseIf DAM301 >= 40 And DAM301 <= 44 Then
                                R6 = 1 * 3
                            ElseIf (DAM301 >= 0) And (DAM301 <= 39) Then
                                R6 = 0 * 3
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            Console.WriteLine("Enter Score For Semantic Data Modelling(DAM344)............................2 Unit")
                            DAM344 = Console.ReadLine()
                            If DAM344 >= 70 And DAM344 <= 100 Then
                                R7 = 5 * 2
                            ElseIf DAM344 >= 60 And DAM344 <= 69 Then
                                R7 = 4 * 2
                            ElseIf DAM344 >= 50 And DAM344 <= 59 Then
                                R7 = 3 * 2
                            ElseIf DAM344 >= 45 And DAM344 <= 49 Then
                                R7 = 2 * 2
                            ElseIf DAM344 >= 40 And DAM344 <= 44 Then
                                R7 = 1 * 2
                            ElseIf (DAM344 >= 0) And (DAM344 <= 39) Then
                                R7 = 0 * 2
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            Console.WriteLine("Enter Score For Management Information Systems (MIS)(DAM364)..............2 Unit")
                            DAM364 = Console.ReadLine()
                            If DAM364 >= 70 And DAM364 <= 100 Then
                                R8 = 5 * 2
                            ElseIf DAM364 >= 60 And DAM364 <= 69 Then
                                R8 = 4 * 2
                            ElseIf DAM364 >= 50 And DAM364 <= 59 Then
                                R8 = 3 * 2
                            ElseIf DAM364 >= 45 And DAM364 <= 49 Then
                                R8 = 2 * 2
                            ElseIf DAM364 >= 40 And DAM364 <= 44 Then
                                R8 = 1 * 2
                            ElseIf (DAM364 >= 0) And (DAM364 <= 39) Then
                                R8 = 0 * 2
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            Console.WriteLine("Enter Score For Information Systems Management(DAM382)....................3 Unit")
                            DAM382 = Console.ReadLine()
                            If DAM382 >= 70 And DAM382 <= 100 Then
                                R9 = 5 * 3
                            ElseIf DAM382 >= 60 And DAM382 <= 69 Then
                                R9 = 4 * 3
                            ElseIf DAM382 >= 50 And DAM382 <= 59 Then
                                R9 = 3 * 3
                            ElseIf DAM382 >= 45 And DAM382 <= 49 Then
                                R9 = 2 * 3
                            ElseIf DAM382 >= 40 And DAM382 <= 44 Then
                                R9 = 1 * 3
                            ElseIf (DAM382 >= 0) And (DAM382 <= 39) Then
                                R9 = 0 * 3
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            gp6 = R1 + R2 + R3 + R4 + R5 + R6 + R7 + R8 + R9
                            cgpa6 = gp6 / 23
                            Console.WriteLine("Your CGPA For 2nd Semester 300Level is " + cgpa6.ToString("N2"))
                            Console.WriteLine("==============================================")
                            If (cgpa6 >= 3.6) And (cgpa6 <= 5.0) Then
                                Console.WriteLine("First Class")

                            ElseIf (cgpa6 >= 3.0) And (cgpa6 <= 3.5) Then
                                Console.WriteLine("Seconds Class Upper")

                            ElseIf (cgpa6 >= 2.5) And (cgpa6 <= 2.99) Then
                                Console.WriteLine("Second Class Lower")

                            ElseIf (cgpa6 >= 2.0) And (cgpa6 <= 2.49) Then
                                Console.WriteLine("Pass")

                            Else
                                Console.WriteLine("Fair")
                            End If

                            Console.WriteLine()
                        Else
                            Console.WriteLine("invalid input")
                        End If



                    ElseIf (xu = "4") Then

                        Console.WriteLine("400Level")
                        Console.WriteLine("==============================================")
                        Console.WriteLine()

                        Console.WriteLine("Press 1 For First Semester")
                        Console.WriteLine("Press 2 For First Semester")
                        Console.WriteLine("==============================================")
                        L = Console.ReadLine()

                        If (L = "1") Then


                            Console.WriteLine("1st Semester")
                            Console.WriteLine("==============================================")

                            Console.WriteLine("Enter Score For Seminar On Emerging Technologies(CIT403)...................3 Unit")
                            CIT403 = Console.ReadLine()
                            If CIT403 >= 70 And CIT403 <= 100 Then
                                Y1 = 5 * 3
                            ElseIf CIT403 >= 60 And CIT403 <= 69 Then
                                Y1 = 4 * 3
                            ElseIf CIT403 >= 50 And CIT403 <= 59 Then
                                Y1 = 3 * 3
                            ElseIf CIT403 >= 45 And CIT403 <= 49 Then
                                Y1 = 2 * 3
                            ElseIf CIT403 >= 40 And CIT403 <= 44 Then
                                Y1 = 1 * 3
                            ElseIf (CIT403 >= 0) And (CIT403 <= 39) Then
                                Y1 = 0 * 3
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            Console.WriteLine("Enter Score For Microcomputers & Microprecessors(CIT411).......................2 Unit")
                            CIT411 = Console.ReadLine()
                            If CIT411 >= 70 And CIT411 <= 100 Then
                                Y2 = 5 * 2
                            ElseIf CIT411 >= 60 And CIT411 <= 69 Then
                                Y2 = 4 * 2
                            ElseIf CIT411 >= 50 And CIT411 <= 59 Then
                                Y2 = 3 * 2
                            ElseIf CIT411 >= 45 And CIT411 <= 49 Then
                                Y2 = 2 * 2
                            ElseIf CIT411 >= 40 And CIT411 <= 44 Then
                                Y2 = 1 * 2
                            ElseIf (CIT411 >= 0) And (CIT411 <= 39) Then
                                Y2 = 0 * 2
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            Console.WriteLine("Enter Score For Introduction To E-commerce(CIT415)......................3 Unit")
                            CIT415 = Console.ReadLine()
                            If CIT415 >= 70 And CIT415 <= 100 Then
                                Y3 = 5 * 3
                            ElseIf CIT415 >= 60 And CIT415 <= 69 Then
                                Y3 = 4 * 3
                            ElseIf CIT415 >= 50 And CIT415 <= 59 Then
                                Y3 = 3 * 3
                            ElseIf CIT415 >= 45 And CIT415 <= 49 Then
                                Y3 = 2 * 3
                            ElseIf CIT415 >= 40 And CIT415 <= 44 Then
                                Y3 = 1 * 3
                            ElseIf (CIT415 >= 0) And (CIT415 <= 39) Then
                                Y3 = 0 * 3
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            Console.WriteLine("Enter Score For Database Systems & Management(CIT427)......................3 Unit")
                            CIT427 = Console.ReadLine()
                            If CIT427 >= 70 And CIT427 <= 100 Then
                                Y4 = 5 * 3
                            ElseIf CIT427 >= 60 And CIT427 <= 69 Then
                                Y4 = 4 * 3
                            ElseIf CIT427 >= 50 And CIT427 <= 59 Then
                                Y4 = 3 * 3
                            ElseIf CIT427 >= 45 And CIT427 <= 49 Then
                                Y4 = 2 * 3
                            ElseIf CIT427 >= 40 And CIT427 <= 44 Then
                                Y4 = 1 * 3
                            ElseIf (CIT427 >= 0) And (CIT427 <= 39) Then
                                Y4 = 0 * 3
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            Console.WriteLine("Enter Score For Principles & Techniques Of Compilers(CIT445)..............3 Unit")
                            CIT445 = Console.ReadLine()
                            If CIT445 >= 70 And CIT445 <= 100 Then
                                Y5 = 5 * 3
                            ElseIf CIT445 >= 60 And CIT445 <= 69 Then
                                Y5 = 4 * 3
                            ElseIf CIT445 >= 50 And CIT445 <= 59 Then
                                Y5 = 3 * 3
                            ElseIf CIT445 >= 45 And CIT445 <= 49 Then
                                Y5 = 2 * 3
                            ElseIf CIT445 >= 40 And CIT445 <= 44 Then
                                Y5 = 1 * 3
                            ElseIf (CIT445 >= 0) And (CIT445 <= 39) Then
                                Y5 = 0 * 3
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            Console.WriteLine("Enter Score For Internet Architecture & Communication(CIT461)...................3 Unit")
                            CIT461 = Console.ReadLine()
                            If CIT461 >= 70 And CIT461 <= 100 Then
                                Y6 = 5 * 3
                            ElseIf DAM382 >= 60 And CIT461 <= 69 Then
                                Y6 = 4 * 3
                            ElseIf CIT461 >= 50 And CIT461 <= 59 Then
                                Y6 = 3 * 3
                            ElseIf CIT461 >= 45 And CIT461 <= 49 Then
                                Y6 = 2 * 3
                            ElseIf CIT461 >= 40 And CIT461 <= 44 Then
                                Y6 = 1 * 3
                            ElseIf (CIT461 >= 0) And (CIT461 <= 39) Then
                                Y6 = 0 * 3
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            Console.WriteLine("Enter Score For Introduction To Multimedia Technology(CIT463)..............3 Unit")
                            CIT463 = Console.ReadLine()
                            If CIT463 >= 70 And CIT463 <= 100 Then
                                Y8 = 5 * 3
                            ElseIf CIT463 >= 60 And CIT463 <= 69 Then
                                Y8 = 4 * 3
                            ElseIf CIT463 >= 50 And CIT463 <= 59 Then
                                Y8 = 3 * 3
                            ElseIf CIT463 >= 45 And CIT463 <= 49 Then
                                Y8 = 2 * 3
                            ElseIf CIT463 >= 40 And CIT463 <= 44 Then
                                Y8 = 1 * 3
                            ElseIf (CIT463 >= 0) And (CIT463 <= 39) Then
                                Y8 = 0 * 3
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            Console.WriteLine("Enter Score For Network Administration(CIT465)...........................2 Unit")
                            CIT465 = Console.ReadLine()
                            If CIT465 >= 70 And CIT465 <= 100 Then
                                Y7 = 5 * 2
                            ElseIf CIT465 >= 60 And CIT465 <= 69 Then
                                Y7 = 4 * 2
                            ElseIf CIT465 >= 50 And CIT465 <= 59 Then
                                Y7 = 3 * 2
                            ElseIf CIT465 >= 45 And CIT465 <= 49 Then
                                Y7 = 2 * 2
                            ElseIf CIT465 >= 40 And CIT465 <= 44 Then
                                Y7 = 1 * 2
                            ElseIf (CIT465 >= 0) And (CIT465 <= 39) Then
                                Y7 = 0 * 2
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            gp7 = Y1 + Y2 + Y3 + Y4 + Y5 + Y6 + Y7 + Y8
                            cgpa7 = gp7 / 22
                            Console.WriteLine("Your CGPA For 1st Semester 400Level Is" + cgpa7.ToString("N2"))
                            Console.WriteLine("==============================================")
                            If (cgpa7 >= 3.6) And (cgpa7 <= 5.0) Then
                                Console.WriteLine("First Class")

                            ElseIf (cgpa7 >= 3.0) And (cgpa7 <= 3.5) Then
                                Console.WriteLine("Seconds Class Upper")

                            ElseIf (cgpa7 >= 2.5) And (cgpa7 <= 2.99) Then
                                Console.WriteLine("Second Class Lower")

                            ElseIf (cgpa7 >= 2.0) And (cgpa7 <= 2.49) Then
                                Console.WriteLine("Pass")

                            Else
                                Console.WriteLine("Fair")
                            End If

                            Console.WriteLine()


                        ElseIf (L = "2") Then

                            Console.WriteLine("2nd Semester; 400Level.")
                            Console.WriteLine("==============================================")

                            Console.WriteLine("Enter Score For Operations Research(CIT425)...........................3 Unit")
                            CIT425 = Console.ReadLine()
                            If CIT425 >= 70 And CIT425 <= 100 Then
                                Q1 = 5 * 3
                            ElseIf CIT425 >= 60 And CIT425 <= 69 Then
                                Q1 = 4 * 3
                            ElseIf CIT425 >= 50 And CIT425 <= 59 Then
                                Q1 = 3 * 3
                            ElseIf CIT425 >= 45 And CIT425 <= 49 Then
                                Q1 = 2 * 3
                            ElseIf CIT425 >= 40 And CIT425 <= 44 Then
                                Q1 = 1 * 3
                            ElseIf (CIT425 >= 0) And (CIT425 <= 39) Then
                                Q1 = 0 * 3
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            Console.WriteLine("Enter Score For Introduction To Expert Systems(CIT474)......................2 Unit")
                            CIT474 = Console.ReadLine()
                            If CIT474 >= 70 And CIT474 <= 100 Then
                                Q2 = 5 * 2
                            ElseIf CIT474 >= 60 And CIT474 <= 69 Then
                                Q2 = 4 * 2
                            ElseIf CIT474 >= 50 And CIT474 <= 59 Then
                                Q2 = 3 * 2
                            ElseIf CIT474 >= 45 And CIT474 <= 49 Then
                                Q2 = 2 * 2
                            ElseIf CIT474 >= 40 And CIT474 <= 44 Then
                                Q2 = 1 * 2
                            ElseIf (CIT474 >= 0) And (CIT474 <= 39) Then
                                Q2 = 0 * 2
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            Console.WriteLine("Enter Score For Artificial Intelligence(CIT478).........................2 Unit")
                            CIT478 = Console.ReadLine()
                            If CIT478 >= 70 And CIT478 <= 100 Then
                                Q3 = 5 * 2
                            ElseIf CIT478 >= 60 And CIT478 <= 69 Then
                                Q3 = 4 * 2
                            ElseIf CIT478 >= 50 And CIT478 <= 59 Then
                                Q3 = 3 * 2
                            ElseIf CIT478 >= 45 And CIT478 <= 49 Then
                                Q3 = 2 * 2
                            ElseIf CIT478 >= 40 And CIT478 <= 44 Then
                                Q3 = 1 * 2
                            ElseIf (CIT478 >= 0) And (CIT478 <= 39) Then
                                Q3 = 0 * 2
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            Console.WriteLine("Enter Score For Website Design & Programming(CIT484)....................3 Unit")
                            CIT484 = Console.ReadLine()
                            If CIT484 >= 70 And CIT484 <= 100 Then
                                Q4 = 5 * 3
                            ElseIf CIT484 >= 60 And CIT484 <= 69 Then
                                Q4 = 4 * 3
                            ElseIf CIT484 >= 50 And CIT484 <= 59 Then
                                Q4 = 3 * 3
                            ElseIf CIT484 >= 45 And CIT484 <= 49 Then
                                Q4 = 2 * 3
                            ElseIf CIT484 >= 40 And CIT484 <= 44 Then
                                Q4 = 1 * 3
                            ElseIf (CIT484 >= 0) And (CIT484 <= 39) Then
                                Q4 = 0 * 3
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            Console.WriteLine("Enter Score For Project(CIT499).............................................6 Unit")
                            CIT499 = Console.ReadLine()
                            If CIT499 >= 70 And CIT499 <= 100 Then
                                Q5 = 5 * 6
                            ElseIf CIT499 >= 60 And CIT499 <= 69 Then
                                Q5 = 4 * 6
                            ElseIf CIT499 >= 50 And CIT499 <= 59 Then
                                Q5 = 3 * 6
                            ElseIf CIT499 >= 45 And CIT499 <= 49 Then
                                Q5 = 2 * 6
                            ElseIf CIT499 >= 40 And CIT499 <= 44 Then
                                Q5 = 1 * 6
                            ElseIf (CIT499 >= 0) And (CIT499 <= 39) Then
                                Q5 = 0 * 6
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            Console.WriteLine("Enter Score For Statistical Database System(DAM461)........................3 Unit")
                            DAM461 = Console.ReadLine()
                            If DAM461 >= 70 And DAM461 <= 100 Then
                                Q6 = 5 * 3
                            ElseIf DAM461 >= 60 And DAM461 <= 69 Then
                                Q6 = 4 * 3
                            ElseIf DAM461 >= 50 And DAM461 <= 59 Then
                                Q6 = 3 * 3
                            ElseIf DAM461 >= 45 And DAM461 <= 49 Then
                                Q6 = 2 * 3
                            ElseIf DAM461 >= 40 And DAM461 <= 44 Then
                                Q6 = 1 * 3
                            ElseIf (DAM461 >= 0) And (DAM461 <= 39) Then
                                Q6 = 0 * 3
                            Else
                                Console.WriteLine("Input correct score")
                                Console.WriteLine()
                                Console.ReadLine()
                                End
                            End If
                            Console.WriteLine()

                            gp8 = Q1 + Q2 + Q3 + Q4 + Q5 + Q6
                            cgpa8 = gp8 / 19
                            Console.WriteLine("Your CGPA For 2nd Semester 400Level Is " + cgpa8.ToString("N2"))

                            If (cgpa8 >= 3.6) And (cgpa8 <= 5.0) Then
                                Console.WriteLine("First Class")

                            ElseIf (cgpa8 >= 3.0) And (cgpa8 <= 3.5) Then
                                Console.WriteLine("Seconds Class Upper")

                            ElseIf (cgpa8 >= 2.5) And (cgpa8 <= 2.99) Then
                                Console.WriteLine("Second Class Lower")

                            ElseIf (cgpa8 >= 2.0) And (cgpa8 <= 2.49) Then
                                Console.WriteLine("Pass")

                            Else
                                Console.WriteLine("Fair")
                            End If

                        Else
                            Console.WriteLine("invalid input")
                        End If

                    Else
                        Console.WriteLine("invalid input")
                    End If
                    Console.WriteLine("Press y to continue")
                    Console.WriteLine("Press x to stop")
                    pan = Console.ReadLine()
                Loop



            ElseIf (x = "15") Then
                Console.WriteLine("AGE CALCULATOR")
                Console.WriteLine("================")


                Dim today, toyear, tomonth As Integer
                Dim birthday, birthmonth, birthyear As String
                Dim resultday, resultmonth, monthInYear, DaysInMonth, year, resultyear As Integer
                Dim instruction As Char

                Do Until instruction = "x"

                    today = Date.Now.Day
                    toyear = Date.Now.Year
                    tomonth = Date.Now.Month



                    Console.WriteLine("Today's Date = " + today.ToString + " / " + tomonth.ToString + " / " + toyear.ToString)
                    Console.WriteLine("========================")
                    Console.WriteLine("")

                    Console.WriteLine("Enter Your Birthday")
                    birthday = Console.ReadLine()
                    Console.WriteLine("========================")
                    If (birthday >= 1) And (birthday <= 31) Then
                        Console.ReadLine()
                    Else
                        Console.WriteLine("Invalid Input")

                        Console.WriteLine("Press X to stop")
                        instruction = Console.ReadLine
                        End
                    End If

                    Console.WriteLine("Enter Your Birthmonth")
                    birthmonth = Console.ReadLine()
                    Console.WriteLine("========================")
                    If (birthmonth < 1) Or (birthmonth > 12) Then
                        Console.WriteLine("Invalid Input")
                        Console.WriteLine("========================")
                        Console.ReadLine()
                        Console.WriteLine("")

                        Console.WriteLine("Press X to stop")
                        instruction = Console.ReadLine
                        End
                    End If

                    Console.WriteLine("Enter Your Birthyear")
                    birthyear = Console.ReadLine()
                    Console.WriteLine("========================")
                    If (birthyear < 0) Or (birthyear > Date.Now.Year) Then
                        Console.WriteLine("Invalid Input")
                        Console.WriteLine("============================")
                        Console.ReadLine()
                        Console.WriteLine("")

                        Console.WriteLine("Press X to stop")
                        instruction = Console.ReadLine()
                        End
                    End If


                    DaysInMonth = System.DateTime.DaysInMonth(birthyear, birthday)
                    monthInYear = System.DateTime.DaysInMonth(birthyear, birthmonth)
                    year = System.DateTime.DaysInMonth(birthmonth, birthday)
                    If (birthday = 2) And (birthmonth > DaysInMonth) Then
                        Console.WriteLine("invalid input")
                        Console.WriteLine("")

                        Console.WriteLine("Press X to stop")
                        instruction = Console.ReadLine()

                    Else

                        If (today > birthday) Then
                            resultday = today - birthday
                        ElseIf (today = birthday) Then
                            resultday = today - birthday

                        ElseIf (birthday > today) Then
                            resultday = 30 + today - birthday
                        Else
                            Console.WriteLine("Invalid Input")

                        End If


                        If (tomonth > birthmonth) And (today > birthday) Then
                            resultmonth = tomonth - birthmonth
                        ElseIf (tomonth > birthmonth) And (today = birthday) Then
                            resultmonth = tomonth - birthmonth

                        ElseIf (tomonth > birthmonth) And (today < birthday) Then
                            resultmonth = tomonth - 1 - birthmonth


                        ElseIf (tomonth = birthmonth) And (birthday > today) Then
                            resultmonth = 11

                        ElseIf (today > birthday) And (tomonth < birthmonth) Then
                            resultmonth = 12 + tomonth - birthmonth

                        ElseIf (today = birthday) And (tomonth < birthmonth) Then
                            resultmonth = 12 + tomonth - birthmonth

                        ElseIf (today < birthday) And (tomonth < birthmonth) Then
                            resultmonth = 11 + tomonth - birthmonth
                        Else
                            Console.WriteLine("Invalid Input")

                        End If



                        If (today > birthday) And (tomonth > birthmonth) Then
                            resultyear = toyear - birthyear
                        ElseIf (today = birthday) And (tomonth > birthmonth) Then
                            resultyear = toyear - birthyear
                        ElseIf (today < birthday) And (tomonth > birthmonth) Then
                            resultyear = toyear - birthyear

                        ElseIf (today > birthday) And (tomonth = birthmonth) Then
                            resultyear = toyear - birthyear
                        ElseIf (today = birthday) And (tomonth = birthmonth) Then
                            resultyear = toyear - birthyear
                        ElseIf (tomonth = birthmonth) And (today < birthday) Then
                            resultyear = toyear - 1 - birthyear
                        ElseIf (today > birthday) And (tomonth < birthmonth) Then
                            resultyear = toyear - 1 - birthyear
                        ElseIf (today = birthday) And (tomonth < birthmonth) Then
                            resultyear = toyear - 1 - birthyear
                        ElseIf (today < birthday) And (tomonth < birthmonth) Then
                            resultyear = toyear - 1 - birthyear
                        Else
                            Console.WriteLine("Invalid Input")

                        End If
                    End If
                    Console.WriteLine("")





                    Console.WriteLine("YourAge is = " + resultyear.ToString + "Years, " + resultmonth.ToString + "Months, " + resultday.ToString + "Days,")

                    Console.WriteLine("")
                    Console.WriteLine("========================")
                    Console.WriteLine("Press any letter to continue")
                    Console.WriteLine("Press X to stop")
                    instruction = Console.ReadLine()




                Loop


            Else
                Console.WriteLine("invalid input")
            End If

            Console.WriteLine("Press any letter to continue")
            Console.WriteLine("Press 1 to stop")
            again = Console.ReadLine()
        Loop
        Console.ReadLine()
    End Sub

End Module
