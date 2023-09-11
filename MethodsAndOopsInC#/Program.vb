Imports System

Namespace MethodsAndOopsInC_
    Friend Class Program

        Private Shared Sub Greet()
            Console.WriteLine("Good Morning ")
        End Sub

        Private Shared Sub Main(ByVal args As String())
            Call Greet()
            Call Greet()
            Call Greet()

            Console.ReadLine()

        End Sub


    End Class
End Namespace
