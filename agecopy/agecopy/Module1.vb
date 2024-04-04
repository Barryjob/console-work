Module Module1

    Sub Main()
        If (birthday < 1) Or (birthday > 31) Then

            Console.WriteLine("================")

            Console.WriteLine("Invalid Input")
            Console.ReadLine()
            Console.WriteLine("Press Y to continue")
            Console.WriteLine("Press X to stop")
            instruction = Console.ReadLine
            Console.WriteLine("Enter the day of birth")
            birthday = Console.ReadLine()
            End
        End If




        If (birthmonth < 1) Or (birthmonth > 13) Then
            Console.WriteLine("================")
            Console.WriteLine("Invalid Input")
            Console.WriteLine("================")
            Console.ReadLine()
            Console.WriteLine("Press Y to continue")
            Console.WriteLine("Press X to stop")
            instruction = Console.ReadLine
            Console.WriteLine("Enter the day of birth")
            birthmonth = Console.ReadLine()
            End
        End If

        If (birthyear < 0) Or (birthday > Date.Now.Year) Then
            Console.WriteLine("================")
            Console.WriteLine("Invalid Input")
            Console.ReadLine()
            Console.WriteLine("Press Y to continue")
            Console.WriteLine("Press X to stop")
            instruction = Console.ReadLine
            Console.WriteLine("Enter the day of birth")
            birthyear = Console.ReadLine()
            End
        End If


        Dim ageYear As Integer
        Dim ageMonth As Integer
        Dim ageDay As Integer


        ageYear = currentDate.Year - birthyear - 1
        ageMonth = currentDate.Month - birthmonth
        ageDay = currentDate.Day - birthday


        If ageMonth < 0 Then
            ageYear = ageYear - "1"
            ageMonth = ageMonth + "12"
        End If



        If ageDay > 0 Then
            ageMonth = ageMonth - "1"


            Dim daysInPreviousMonth As Integer

            daysInPreviousMonth = Date.DaysInMonth(currentDate.Year, currentDate.Month - "1")
            ageDay = ageDay + daysInPreviousMonth



        End If

        Console.WriteLine("=======================")


        Console.WriteLine("==========================")
















        Console.ReadLine()
    End Sub

End Module
