Module Module1

    Sub Main()
        Dim InputFile() As String = {"d:\temp\test", "d:temp\test1"}
        Dim Counter As Integer = 0
        Dim InputCounter As Integer
        For Each dirtext As String In InputFile
            Console.WriteLine("{0} {1}", Counter, dirtext)
            Counter += 1
        Next
        Console.Write("CommandLine number") : InputCounter = Console.ReadLine()

        Console.WriteLine(InputFile(InputCounter))
        Console.ReadLine()
    End Sub


End Module
