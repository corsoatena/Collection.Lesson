Imports System.Collections.Generic
Module Program ' ->  dichiarazione della Liberia
    Sub Main()

        Dim customer As Person = New Person("Bruno", 40)
        Dim Lt As List(Of Integer) = New List(Of Integer)()
        Dim i As Integer
        'Dim j As String  
        Console.WriteLine(" Added elements in List1")
        ' Use of Add() function  
        Lt.Add(50)
        Lt.Add(55)
        Lt.Add(10)
        'Lt.Add(70)  

        Dim Lt2 As List(Of String) = New List(Of String)()
        Lt2.Add("Welcome")
        Lt2.Add("to")
        Lt2.Add("Corso Atena")


        'Access all element of List1  
        For Each i In Lt
            Console.WriteLine("{0}", i)
        Next i
        Console.WriteLine("Total elements in list1: {0}", Lt.Count)
        Console.WriteLine("Number of elements can be placed in list1: {0}", Lt.Capacity)
        Console.WriteLine()

        'Access all element of list2  
        Console.WriteLine(" Added elements in List2")


    End Sub ' -> Sub  -> function OR Method
End Module ' -> Module  
Public Class Person  '-> Classes
    Dim _nome As String
    Dim _age As Integer


    'Costruttore
    Sub New(ByVal Name As String, ByVal Age As Integer)
        Me._nome = Name
        Me._age = Age

    End Sub



End Class
