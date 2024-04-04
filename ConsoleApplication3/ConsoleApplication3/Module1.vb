Module Module1

    Sub Main()

        Dim a, b, P1, P2, V1, V2 As Double
        Dim x As String

        Console.WriteLine("BOYLE'S LAW CALCULATOR")
        Console.WriteLine("THIS PROGRAM IS OPERATED ON BOYLE'S LAW")
        Console.WriteLine("=================================================================")

        
        Console.WriteLine("Press 1 to Find Intial Pressure(P1)")
        Console.WriteLine("Press 2 to Find Intial Volume(V1)")
        Console.WriteLine("Press 3 to Find Final Pressure(P2)")
        Console.WriteLine("Press 4 to Find Final Volume(V2)")
        Console.WriteLine("=================================================================")

        x = Console.ReadLine()
        Console.WriteLine("=================================================================")

      


        If (x = "1") Then
            Console.WriteLine("Enter The Value Of V1")
            V1 = Console.ReadLine()
            Console.WriteLine()
            Console.WriteLine("Enter The Value Of P2")
            P2 = Console.ReadLine()
            Console.WriteLine()
            Console.WriteLine("Enter The Value Of V2")
            V2 = Console.ReadLine()
            Console.WriteLine()
            a = P2 * V2
            P1 = a / V1
            If (V1 = "0") Then
                Console.WriteLine("can't be divided")


            Else
                Console.WriteLine("Intial Presure(P1) is = " + P1.ToString)
                Console.WriteLine("=================================================================")
            End If

        ElseIf (x = "2") Then
            Console.WriteLine("Enter The Value Of P1")
            P1 = Console.ReadLine()
            Console.WriteLine()
            Console.WriteLine("Enter The Value Of P2")
            P2 = Console.ReadLine()
            Console.WriteLine()
            Console.WriteLine("Enter The Value Of V2")
            V2 = Console.ReadLine()
            Console.WriteLine()
            a = P2 * V2
            V1 = a / P1
            Console.WriteLine("Intial Volume(V1) is = " + V1.ToString)
            Console.WriteLine("=================================================================")

        ElseIf (x = "3") Then
            Console.WriteLine("Enter The Value Of P1")
            P1 = Console.ReadLine()
            Console.WriteLine()
            Console.WriteLine("Enter The Value Of V1")
            V1 = Console.ReadLine()
            Console.WriteLine()
            Console.WriteLine("Enter The Value Of V2")
            V2 = Console.ReadLine()
            Console.WriteLine()
            b = P1 * V1
            P2 = b / V2
            Console.WriteLine("The Final Pressure(P2) is = " + P2.ToString)
            Console.WriteLine("=================================================================")

        ElseIf (x = "4") Then
            Console.WriteLine("Enter The Value Of P1")
            P1 = Console.ReadLine()
            Console.WriteLine()
            Console.WriteLine("Enter The Value Of V1")
            V1 = Console.ReadLine()
            Console.WriteLine()
            Console.WriteLine("Enter The Value Of P2")
            P2 = Console.ReadLine()
            Console.WriteLine()
            b = P1 * V1
            V2 = b / P2
            Console.WriteLine("The Final Volume(V2) is = " + V2.ToString)
            Console.WriteLine("=================================================================")
        Else
            Console.WriteLine("Invalid Input!")


        End If


            Console.ReadLine()
    End Sub

End Module
