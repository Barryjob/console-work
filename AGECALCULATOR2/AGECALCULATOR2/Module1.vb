Module Module1

    Sub Main()
        Console.WriteLine("AGE CALCULATOR")
        Console.WriteLine("================")


        Dim today, toyear, tomonth, x As Integer
        Dim birthday, birthmonth, birthyear As Integer
        Dim resultday, resultmonth, resultyear, DaysInMonth As Integer
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
            If (birthyear < 1) Or (birthyear > Date.Now.Year) Then
                Console.WriteLine("Invalid Input")
                Console.WriteLine("============================")
                Console.ReadLine()
                Console.WriteLine("")

                Console.WriteLine("Press X to stop")
                instruction = Console.ReadLine()
                End
            End If

            DaysInMonth = System.DateTime.DaysInMonth(birthyear, birthmonth)


            If (birthmonth = 2) And (birthday > DaysInMonth) Then
                Console.WriteLine("invalid input")
                Console.WriteLine("============================")
                Console.ReadLine()
                Console.WriteLine("")

                Console.WriteLine("Press X to stop")
                instruction = Console.ReadLine()

            Else

                If (today > birthday) Then
                    resultday = today - birthday
                ElseIf (today = birthday) Then
                    resultday = today - birthday

                ElseIf (birthday > today) Then
                    resultday = DaysInMonth + today - birthday
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
        Console.ReadLine()


    End Sub

End Module
