Module Module1
    
    ' The VB calc...
    Class Calc
        Public Function Add(ByVal x As Integer, ByVal y As Integer) As Integer
            Return x + y
        End Function
    End Class
    
    
    Sub Main()
        Dim ans As Integer
        Dim c As New Calc()
        ans = c.Add(10, 84)
        Console.WriteLine("10 + 84 is: {0}.", ans)
    End Sub
    
End Module
