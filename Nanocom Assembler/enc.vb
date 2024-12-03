Module enc

    Sub encode(ByVal l As String, ByVal inp As String)

        Dim length As Integer
        length = inp.Length
        Dim inparray() As Char
        inparray = inp.ToCharArray

        Console.WriteLine(inp)
        'Console.WriteLine(length)
        Dim i As Integer = 0
        Dim bytecnt As Integer

        Do Until i = length
            If inparray(i) = "," Then
                bytecnt += 1
            End If
            i += 1
        Loop

        Dim byt(bytecnt - 1) As Byte
        i = 0
        bytecnt = 0
        Dim temp As String = Nothing

        Do Until i = length

            If inparray(i) = "," Then
                'Console.WriteLine(temp)
                byt(bytecnt) = Val(temp)
                temp = ""
                bytecnt += 1
            Else
                temp += inparray(i)
            End If
            i += 1
        Loop

        i = 0
        Dim slashcnt As Integer = 0
        Dim larray() As Char
        larray = l.ToCharArray
        Do Until i = l.Length
            If larray(i) = "\" Then
                slashcnt += 1
            End If
            i += 1
        Loop

        i = 0
        Dim slcnttemp As Integer = 0
        Dim newslash As String = Nothing

        Do Until slcnttemp = slashcnt
            If larray(i) = "\" Then
                slcnttemp += 1
            End If
            newslash += larray(i)
            i += 1
        Loop
        Dim file_name As String = Nothing
        Do Until i = l.Length
            file_name += larray(i)
            i += 1
        Loop

        i = 0
        Dim dotcnt As Integer = 0
        Dim fileNarray() As Char
        fileNarray = file_name.ToCharArray
        Do Until i = file_name.Length
            If fileNarray(i) = "." Then
                dotcnt += 1
            End If
            i += 1
        Loop

        i = 0
        Dim dtcnt As Integer = 0
        Do Until dtcnt = dotcnt
            If fileNarray(i) = "." Then
                dtcnt += 1
            End If
            newslash += fileNarray(i)
            i += 1
        Loop
        l = newslash & "bin"

        If My.Computer.FileSystem.FileExists(l) = True Then
            My.Computer.FileSystem.DeleteFile(l)
        End If

        My.Computer.FileSystem.WriteAllBytes(l, byt, 1)

        'Console.WriteLine(l)
        'Console.WriteLine(dotcnt)
        'Console.WriteLine(file_name)
        'Console.WriteLine(bytecnt)
        'Console.ReadLine()
    End Sub


    

End Module
