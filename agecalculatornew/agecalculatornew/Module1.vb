Module Module1

    Sub Main()
        Dim today, toyear, tomonth As Integer
        Dim instruction As Char
        Console.WriteLine("AGE CALCULATOR")
        Console.WriteLine("========================")

        today = Date.Now.Day
        toyear = Date.Now.Year
        tomonth = Date.Now.Month


        Console.WriteLine("Today's Date = " + today.ToString + " / " + tomonth.ToString + " / " + toyear.ToString)


        Dim ageDay As Integer
        Dim ageMonth As Integer
        Dim birthyear As Integer
        Dim currentDate As Date
        Dim DaysInMonth As Integer



        currentDate = DateTime.Now.Date
        Console.WriteLine("============================")
        Console.WriteLine("")
        
        Do Until instruction = "x"


            Console.WriteLine("Enter The Day Of Birth")
            ageDay = Console.ReadLine()
            Console.WriteLine("============================")
            If (ageDay < 1) Or (ageDay > 31) Then
                Console.WriteLine("Invalid Input")
                Console.ReadLine()

                End
            End If



            Console.WriteLine("Enter The Month Of Birth")
            ageMonth = Console.ReadLine()
            Console.WriteLine("============================")
            If (ageMonth < 1) Or (ageMonth > 13) Then
                Console.WriteLine("Invalid Input")
                Console.WriteLine("========================")
                Console.ReadLine()

                End
            End If



            Console.WriteLine("Enter The Year Of Birth")
            birthyear = Console.ReadLine()
            Console.WriteLine("============================")
            If (birthyear < 0) Or (ageDay > Date.Now.Year) Then
                Console.WriteLine("Invalid Input")
                Console.WriteLine("============================")
                Console.ReadLine()

                End
            End If




            Dim ageYear As Integer = currentDate.Year - birthyear
            ageMonth = currentDate.Month - ageMonth
            ageDay = currentDate.Day - ageDay

            DaysInMonth = System.DateTime.DaysInMonth(birthyear, ageMonth)
            If (ageMonth = 2) And (ageMonth > DaysInMonth) Then
                Console.WriteLine("invalid input")

            Else


                If ageDay < 0 Then
                    ageDay += System.DateTime.DaysInMonth(currentDate.Year, currentDate.Month)
                    ageMonth -= 1
                    ageDay -= 2
                End If
                If ageMonth < 0 Then
                    ageMonth = System.DateTime.DaysInMonth(currentDate.Year, currentDate.Month)
                    ageYear -= 1
                End If

               

                End If


                Console.WriteLine("Your age is = " + ageYear.ToString + " years " + ageMonth.ToString + " months " + ageDay.ToString + " days ")


                Console.WriteLine("Press Y to continue")
                Console.WriteLine("Press X to stop")
                instruction = Console.ReadLine





        Loop


       















        Console.ReadLine()
    End Sub

End Module
