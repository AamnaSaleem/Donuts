Module Module1

    Sub Main()

        Dim Count As Integer

        Console.Write("Enter number of donuts: ")
        Count = Console.ReadLine

        If Count >= 10 Then
            Console.WriteLine("Number of donuts:many ")
        Else
            Console.WriteLine("Number of donuts: " & Count)
        End If


        Console.ReadKey()


    End Sub

End Module
