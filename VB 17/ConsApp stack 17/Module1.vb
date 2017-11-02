Module Module1

    Sub Main()

        'stack list in is first out like plates

        Dim papers As Stack = New Stack

        papers.Push("resume")
        papers.Push("TPS report")
        papers.Push("to do list")

        Console.WriteLine(papers.Pop)
        Console.WriteLine(papers.Pop)
        Console.WriteLine(papers.Pop)
        Console.WriteLine(papers.Count)

        Console.ReadLine()



    End Sub

End Module
