Imports System.IO
Module Module1

    Sub Main()
        Dim str As String = "0x0200080010002000800056aa03910efe0c54020100100dee0c4014020c44160402700c5114020f110c440f10160b02c00c400de000100f100c4414020c400ef1"
        Dim data As String = str.Substring(2)
        Dim bytes As Byte() = New Byte(data.Length / 2 - 1) {}
        For i As Integer = 0 To bytes.Length - 1
            bytes(i) = Convert.ToByte(data.Substring(i * 2, 2), 16)
        Next
        Dim fs As New FileStream(Directory.GetCurrentDirectory() & "\p1.jpg", FileMode.Create)
        fs.Write(bytes, 0, bytes.Length)
        fs.Close()
        Console.WriteLine("Success")
        Console.ReadLine()
    End Sub

End Module
