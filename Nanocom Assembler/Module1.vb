Imports Nanocom_Assembler.NASM_C
Imports Nanocom_Assembler.enc
Module Module1
    Dim path As String
    Dim asm_type As String
    Dim binC As String
    Sub Main()
        asm_type = "bin"
        Try
            path = My.Application.CommandLineArgs.Item(0)
            'Console.WriteLine(path)

            Try
                If My.Application.CommandLineArgs.Item(1) = "-t" Then
                    asm_type = My.Application.CommandLineArgs.Item(2)
                End If
            Catch ex As Exception

            End Try

            If asm_type = "bin" Then

                Nrom_ASM()

            End If

        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try
        Console.ReadLine()
    End Sub

    Sub Nrom_ASM()
        '--------- Start -----------------------------------------------------------------------------

        Dim word As String = ""
        Dim text() As Char

        If My.Computer.FileSystem.FileExists(path) = True Then
            text = My.Computer.FileSystem.ReadAllText(path)

            '----- Get Line Count --------------------------------------------------------------------

            Dim i As Integer = 0
            Dim lcnt As Integer = 0

            Do Until i = text.Length

                If text(i) = ";" Or text(i) = " " Then
                    lcnt += 1
                End If
                i += 1
            Loop
            lcnt += 1
            'Console.WriteLine(lcnt)

            '----- Read Line By Line -----------------------------------------------------------------

            Dim words(lcnt) As String
            lcnt = 0
            i = 0

            Do Until i >= text.Length

                If text(i) = ";" Then
                    words(lcnt) = word
                    word = ""
                    lcnt += 1
                    i += 2
                ElseIf text(i) = " " Then
                    words(lcnt) = word
                    word = ""
                    lcnt += 1
                Else
                    word = word & text(i)
                End If
                i += 1

            Loop
            'showarray(words)
            Dim code As String

            code = converter(words)
            'Console.WriteLine(code)

            encode(path, code)
            Console.ForegroundColor = ConsoleColor.DarkGreen
            Console.WriteLine()
            Console.WriteLine("Code Has Compiled Succesfully")

        End If
    End Sub

    Sub help()
        Console.BackgroundColor = ConsoleColor.Blue
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("Help Testing")
        Console.BackgroundColor = ConsoleColor.Black
    End Sub


    Sub showarray(ByVal inp() As String)

        Dim i As Integer
        Do Until i = inp.Length
            Console.WriteLine(inp(i))
            'Console.Write(" , ")
            i += 1
        Loop

    End Sub


End Module
