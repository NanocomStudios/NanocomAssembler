Module NASM_C
    Dim lablen(1000) As String
    Dim lablec(1000) As Double
    Function converter(ByVal words() As String) As String

        Dim cline As String = ""
        Dim i As Integer = 0
        Dim ccnt As Integer = 0
        Dim lcnt As Integer = 0
        '----- Select ----------------------------------------------------------------------------------

        Do Until i >= words.Length

            Select Case words(i)
                Case "lbl"
                    i += 1
                    lablen(lcnt) = words(i)
                    lablec(lcnt) = ccnt + 32768
                    lcnt += 1
                    'showarray(lablec)

                Case "lda"
                    i += 1
                    If words(i) = "$" Then

                        i += 1
                        If Convert.ToInt32(words(i), 16) <= 255 Then
                            cline = cline & "1,"
                            cline = cline & Convert.ToInt32(words(i), 16) & ","
                            ccnt += 2
                        Else
                            cline = cline & "2,"
                            cline = cline & portconv(Convert.ToInt32(words(i), 16)) & ","
                            ccnt += 3
                        End If


                    Else
                        i += 1

                        cline = cline & "3," & Val(words(i)) & ","
                        ccnt += 2

                    End If


                Case "sta"
                    i += 1
                    If Convert.ToInt32(words(i), 16) <= 255 Then
                        cline = cline & "4,"
                        cline = cline & Convert.ToInt32(words(i), 16) & ","
                        ccnt += 2
                    Else
                        cline = cline & "5,"
                        cline = cline & portconv(Convert.ToInt32(words(i), 16)) & ","
                        ccnt += 3
                    End If

                Case "ldx"
                    i += 1
                    If words(i) = "$" Then

                        i += 1
                        If Convert.ToInt32(words(i), 16) <= 255 Then
                            cline = cline & "6,"
                            cline = cline & Convert.ToInt32(words(i), 16) & ","
                            ccnt += 2
                        Else
                            cline = cline & "7,"
                            cline = cline & portconv(Convert.ToInt32(words(i), 16)) & ","
                            ccnt += 3
                        End If


                    Else
                        i += 1

                        cline = cline & "8," & Val(words(i)) & ","
                        ccnt += 2

                    End If


                Case "stx"
                    i += 1
                    If Convert.ToInt32(words(i), 16) <= 255 Then
                        cline = cline & "9,"
                        cline = cline & Convert.ToInt32(words(i), 16) & ","
                        ccnt += 2
                    Else
                        cline = cline & "10,"
                        cline = cline & portconv(Convert.ToInt32(words(i), 16)) & ","
                        ccnt += 3
                    End If

                Case "ldy"
                    i += 1
                    If words(i) = "$" Then

                        i += 1
                        If Convert.ToInt32(words(i), 16) <= 255 Then
                            cline = cline & "11,"
                            cline = cline & Convert.ToInt32(words(i), 16) & ","
                            ccnt += 2
                        Else
                            cline = cline & "12,"
                            cline = cline & portconv(Convert.ToInt32(words(i), 16)) & ","
                            ccnt += 3
                        End If


                    Else
                        i += 1

                        cline = cline & "13," & Val(words(i)) & ","
                        ccnt += 2

                    End If


                Case "sty"
                    i += 1
                    If Convert.ToInt32(words(i), 16) <= 255 Then
                        cline = cline & "14,"
                        cline = cline & Convert.ToInt32(words(i), 16) & ","
                        ccnt += 2
                    Else
                        cline = cline & "15,"
                        cline = cline & portconv(Convert.ToInt32(words(i), 16)) & ","
                        ccnt += 3
                    End If

                Case "tax"
                    cline = cline & "16,"
                    ccnt += 1

                Case "tay"
                    cline = cline & "17,"
                    ccnt += 1

                Case "txa"
                    cline = cline & "18,"
                    ccnt += 1

                Case "txy"
                    cline = cline & "19,"
                    ccnt += 1

                Case "tya"
                    cline = cline & "20,"
                    ccnt += 1

                Case "tyx"
                    cline = cline & "21,"
                    ccnt += 1

                Case "ldt"
                    cline = cline & "22,"
                    ccnt += 1

                Case "stz"
                    i += 1
                    If Convert.ToInt32(words(i), 16) <= 255 Then
                        cline = cline & "23,"
                        cline = cline & Convert.ToInt32(words(i), 16) & ","
                        ccnt += 2
                    Else
                        cline = cline & "24,"
                        cline = cline & portconv(Convert.ToInt32(words(i), 16)) & ","
                        ccnt += 3
                    End If

                Case "tsx"
                    cline = cline & "25,"
                    ccnt += 1

                Case "txs"
                    cline = cline & "26,"
                    ccnt += 1

                Case "pha"
                    cline = cline & "27,"
                    ccnt += 1

                Case "phx"
                    cline = cline & "28,"
                    ccnt += 1

                Case "phy"
                    cline = cline & "29,"
                    ccnt += 1

                Case "pla"
                    cline = cline & "30,"
                    ccnt += 1

                Case "plx"
                    cline = cline & "31,"
                    ccnt += 1

                Case "ply"
                    cline = cline & "32,"
                    ccnt += 1

                Case "rmb"
                    cline = cline & "33,"
                    ccnt += 1

                Case "sec"
                    cline = cline & "34,"
                    ccnt += 1

                Case "clc"
                    cline = cline & "35,"
                    ccnt += 1

                Case "and"
                    i += 1
                    If Convert.ToInt32(words(i), 16) <= 255 Then
                        cline = cline & "36,"
                        cline = cline & Convert.ToInt32(words(i), 16) & ","
                        ccnt += 2
                    Else
                        cline = cline & "37,"
                        cline = cline & portconv(Convert.ToInt32(words(i), 16)) & ","
                        ccnt += 3
                    End If

                Case "ora"
                    i += 1
                    If Convert.ToInt32(words(i), 16) <= 255 Then
                        cline = cline & "38,"
                        cline = cline & Convert.ToInt32(words(i), 16) & ","
                        ccnt += 2
                    Else
                        cline = cline & "39,"
                        cline = cline & portconv(Convert.ToInt32(words(i), 16)) & ","
                        ccnt += 3
                    End If

                Case "eor"
                    i += 1
                    If Convert.ToInt32(words(i), 16) <= 255 Then
                        cline = cline & "40,"
                        cline = cline & Convert.ToInt32(words(i), 16) & ","
                        ccnt += 2
                    Else
                        cline = cline & "41,"
                        cline = cline & portconv(Convert.ToInt32(words(i), 16)) & ","
                        ccnt += 3
                    End If

                Case "adc"
                    cline = cline & "42,"
                    ccnt += 1

                Case "sbc"
                    cline = cline & "43,"
                    ccnt += 1

                Case "cmp"
                    i += 1
                    If Convert.ToInt32(words(i), 16) <= 255 Then
                        cline = cline & "44,"
                        cline = cline & Convert.ToInt32(words(i), 16) & ","
                        ccnt += 2
                    Else
                        cline = cline & "45,"
                        cline = cline & portconv(Convert.ToInt32(words(i), 16)) & ","
                        ccnt += 3
                    End If

                Case "cpx"
                    i += 1
                    If Convert.ToInt32(words(i), 16) <= 255 Then
                        cline = cline & "46,"
                        cline = cline & Convert.ToInt32(words(i), 16) & ","
                        ccnt += 2
                    Else
                        cline = cline & "47,"
                        cline = cline & portconv(Convert.ToInt32(words(i), 16)) & ","
                        ccnt += 3
                    End If

                Case "cpy"
                    i += 1
                    If Convert.ToInt32(words(i), 16) <= 255 Then
                        cline = cline & "48,"
                        cline = cline & Convert.ToInt32(words(i), 16) & ","
                        ccnt += 2
                    Else
                        cline = cline & "49,"
                        cline = cline & portconv(Convert.ToInt32(words(i), 16)) & ","
                        ccnt += 3
                    End If

                Case "bcc"
                    i += 1
                    cline = cline & "50,"
                    If words(i) = "l" Then
                        i += 1

                        cline = cline & words(i) & ","

                    Else
                        cline = cline & portconv(Convert.ToInt32(words(i), 16)) & ","
                    End If
                    ccnt += 3

                Case "bcs"
                    i += 1
                    cline = cline & "51,"
                    If words(i) = "l" Then
                        i += 1

                        cline = cline & words(i) & ","

                    Else
                        cline = cline & portconv(Convert.ToInt32(words(i), 16)) & ","
                    End If
                    ccnt += 3

                Case "beq"
                    i += 1
                    cline = cline & "52,"
                    If words(i) = "l" Then
                        i += 1

                        cline = cline & words(i) & ","

                    Else
                        cline = cline & portconv(Convert.ToInt32(words(i), 16)) & ","
                    End If
                    ccnt += 3

                Case "bne"
                    i += 1
                    cline = cline & "53,"
                    If words(i) = "l" Then
                        i += 1

                        cline = cline & words(i) & ","

                    Else
                        cline = cline & portconv(Convert.ToInt32(words(i), 16)) & ","
                    End If
                    ccnt += 3

                Case "jmp"
                    i += 1
                    cline = cline & "54,"
                    If words(i) = "l" Then
                        i += 1

                        cline = cline & words(i) & ","


                    Else
                        cline = cline & portconv(Convert.ToInt32(words(i), 16)) & ","
                    End If
                    ccnt += 3

                Case "jsr"
                    i += 1
                    cline = cline & "55,"
                    If words(i) = "l" Then
                        i += 1

                        cline = cline & words(i) & ","

                    Else
                        cline = cline & portconv(Convert.ToInt32(words(i), 16)) & ","
                    End If
                    ccnt += 3

                Case "rts"
                    cline = cline & "56,"
                    ccnt += 1

                Case "rti"
                    cline = cline & "57,"
                    ccnt += 1

                Case "asl"
                    cline = cline & "58,"
                    ccnt += 1

                Case "lsr"
                    cline = cline & "59,"
                    ccnt += 1

                Case "rol"
                    cline = cline & "60,"
                    ccnt += 1

                Case "ror"
                    cline = cline & "61,"
                    ccnt += 1

                Case "stp"
                    cline = cline & "62,"
                    ccnt += 1

                Case Else

            End Select
            i += 1
        Loop





        Return lblcode(cline)

    End Function


    Sub showarray(ByVal inp() As Double)

        Dim i As Integer
        Do Until i = inp.Length
            Console.WriteLine(inp(i))
            'Console.Write(" , ")
            i += 1
        Loop

    End Sub

    Function portconv(ByVal port As Integer) As String
        Dim out As String = ""
        Dim hextemp As String = ""

        hextemp = Hex(port)
        If hextemp.Length = 3 Then
            Dim hexdec() As Char
            hexdec = hextemp.ToCharArray

            out = Convert.ToInt32(hexdec(1) & hexdec(2), 16) & "," & Convert.ToInt32(hexdec(0), 16)


        ElseIf hextemp.Length = 4 Then
            Dim hexdec() As Char
            hexdec = hextemp.ToCharArray
            out = Convert.ToInt32(hexdec(2) & hexdec(3), 16) & "," & Convert.ToInt32(hexdec(0) & hexdec(1), 16)

        Else
            out = Convert.ToInt32(hextemp, 16).ToString & "0,"
        End If

        Return out
    End Function

    Function lblcode(ByVal inp As String) As String
        Dim cline As String = ""
        Dim i As Integer = 0
        Dim c As Integer = 0
        Dim lbl() As Char
        lbl = inp.ToCharArray

        Do Until i = inp.Length
            If lbl(i) = "," Then
                c += 1
            End If
            i += 1
        Loop

        Dim words(c - 1) As String
        i = 0
        c = 0
        Dim temp As String = ""

        Do Until i = inp.Length
            If lbl(i) = "," Then
                words(c) = temp
                c += 1
                temp = ""
            Else
                temp = temp & lbl(i)
            End If
            i += 1
        Loop

        i = 0
        c = 0

        Do Until i = words.Length
            If Val(words(i)) = 0 Then
                If words(i) = "0" Then
                    cline = cline & words(i) & ","
                Else
                    Do Until c = 1000
                        If lablen(c) = words(i) Then
                            cline = cline & portconv(lablec(c)) & ","
                            c = 1000
                        Else
                            c += 1
                        End If
                    Loop
                End If
            Else
                cline = cline & words(i) & ","
            End If
            c = 0
            i += 1
        Loop


        Return cline
    End Function
End Module
