Module Module1
    ' this is my big ass list of global variables
    Dim textColor As ConsoleColor = ConsoleColor.White
    Dim backGroundColor As ConsoleColor = ConsoleColor.Black

    Dim companyname As String
    Dim ownername As String
    Dim contactnumber As Integer
    Dim address As String
    Dim hourlyrate As Double
    Dim completedhours As Single
    Dim totalincome As Double
    Dim FirstTimeOpen As Boolean = True
    Dim normalcolor As Boolean = False
    Dim CompanyChange As Boolean = False
    Dim welcomeText As String


    ' Dim BookingId As Integer = 0

    ' how many bookings there are
    Dim Bookings As New List(Of BookingDetails)

    ' coment stuff
    Dim BookingNumber As Integer = 0

    Class BookingDetails
        Public ClientName As String
        Public ClientAddress As String
        Public ClientsPhoneNumber As String
        Public DateOfBooking As Date
        Public TimeOfBooking As Date
        Public complete As Boolean = False
    End Class


    ' store the bookings
    ' Dim Bookings As New List(Of BookingDetails)

    ' all the complte bookings


    Dim BookingID As New List(Of Integer)
    'Sub MowerPic()
    '    Console.Clear()
    '    MowerText = IO.File.ReadAllText("MowerImage.txt")


    '    Console.WriteLine(MowerText)
    '    Console.ReadKey()
    'End Sub
    Sub LoadWelcomePic()

        welcomeText = IO.File.ReadAllText("WelcomePic.txt")



    End Sub
    Sub MakeColor()
        Console.Clear()

        Console.WriteLine("You have not selected a text color")

        Console.WriteLine("")

        Console.WriteLine()

        Console.WriteLine("Please select a text color")

        Console.WriteLine("")
        Console.WriteLine("     (A) Black             (H) Red")
        Console.WriteLine("     (B) Blue              (I) Magenta")
        Console.WriteLine("     (C) Cyan              (J) Green")
        Console.WriteLine("     (D) Dark Blue         (K) Grey")
        Console.WriteLine("     (E) Dark Cyan         (L) Dark yellow")
        Console.WriteLine("     (F) Yellow            (M) Dark Red")
        Console.WriteLine("     (G) White             (N) Dark Magenta")
        Console.WriteLine("     (O) Dark Green")


        Select Case Console.ReadKey(True).KeyChar.ToString.ToUpper
            Case "A"
                textColor = ConsoleColor.Black
            Case "B"
                textColor = ConsoleColor.Blue
            Case "C"
                textColor = ConsoleColor.Cyan
            Case "D"
                textColor = ConsoleColor.DarkBlue
            Case "E"
                textColor = ConsoleColor.DarkCyan
            Case "F"
                textColor = ConsoleColor.Yellow
            Case "G"
                textColor = ConsoleColor.White
            Case "H"
                textColor = ConsoleColor.Red
            Case "I"
                textColor = ConsoleColor.Magenta
            Case "J"
                textColor = ConsoleColor.Green
            Case "K"
                textColor = ConsoleColor.Gray
            Case "L"
                textColor = ConsoleColor.DarkYellow
            Case "M"
                textColor = ConsoleColor.DarkRed
            Case "N"
                textColor = ConsoleColor.DarkMagenta
            Case "O"
                textColor = ConsoleColor.DarkGreen
            Case Else
                Console.WriteLine("Invald Key")
                Console.WriteLine("")
                Console.WriteLine("Press any key")
                Console.WriteLine()
                Console.ReadKey()
                MakeColor()


        End Select
        Console.WriteLine("     Done!")
        Console.WriteLine("     Press any key")
        Console.ReadKey()



        Console.Clear()

        Console.WriteLine("You have not selected a background color")
        Console.WriteLine("")

        Console.WriteLine("Please select a background color")
        Console.WriteLine("")
        Console.WriteLine("     (A) Black             (H) Red")
        Console.WriteLine("     (B) Blue              (I) Magenta")
        Console.WriteLine("     (C) Cyan              (J) Green")
        Console.WriteLine("     (D) Dark Blue         (K) Grey")
        Console.WriteLine("     (E) Dark Cyan         (L) Dark yellow")
        Console.WriteLine("     (F) Yellow            (M) Dark Red")
        Console.WriteLine("     (G) White             (N) Dark Magenta")
        Console.WriteLine("     (O) Dark Green")

        Select Case Console.ReadKey(True).KeyChar.ToString.ToUpper
            Case "A"
                backGroundColor = ConsoleColor.Black
            Case "B"
                backGroundColor = ConsoleColor.Blue
            Case "C"
                backGroundColor = ConsoleColor.Cyan
            Case "D"
                backGroundColor = ConsoleColor.DarkBlue
            Case "E"
                backGroundColor = ConsoleColor.DarkCyan
            Case "F"
                backGroundColor = ConsoleColor.Yellow
            Case "G"
                backGroundColor = ConsoleColor.White
            Case "H"
                backGroundColor = ConsoleColor.Red
            Case "I"
                backGroundColor = ConsoleColor.Magenta
            Case "J"
                backGroundColor = ConsoleColor.Green
            Case "K"
                backGroundColor = ConsoleColor.Gray
            Case "L"
                backGroundColor = ConsoleColor.DarkYellow
            Case "M"
                backGroundColor = ConsoleColor.DarkRed
            Case "N"
                backGroundColor = ConsoleColor.DarkMagenta
            Case "O"
                backGroundColor = ConsoleColor.DarkGreen


            Case Else
                Console.WriteLine("     Invald Key")
                Console.WriteLine("")
                Console.WriteLine("     Press any key")
                Console.WriteLine()
                Console.ReadKey()
                MakeColor()

        End Select
        Console.WriteLine("     Done!")

        Console.WriteLine()
        Console.WriteLine("     Press any key to continue...")
        Console.ReadKey()
        saveColor()

        If textColor = backGroundColor Then
            Console.Clear()

            Console.WriteLine("You have selected the same background color as text color. I have changed the text and background color to the default color's")
            textColor = ConsoleColor.White
            backGroundColor = ConsoleColor.Black
            Console.WriteLine("Press any key to continue...")
            Console.ReadLine()

        End If
        Console.BackgroundColor = backGroundColor
        Console.ForegroundColor = textColor

    End Sub

    Sub LoadColor()
        FileOpen(1, "Color.txt", OpenMode.Input)
        textColor = LineInput(1)
        backGroundColor = LineInput(1)
        FileClose(1)
    End Sub

    Sub saveColor()

        FileOpen(1, "Color.txt", OpenMode.Output)
        PrintLine(1, textColor)
        PrintLine(1, backGroundColor)
        FileClose(1)

    End Sub

    Sub Main()
        LoadWelcomePic()

        Console.ForegroundColor = textColor



        Console.BackgroundColor = backGroundColor
        Console.Clear()

    



        If Not IO.File.Exists("Color.txt") Then
            'welcome user to fun with lawns
            Console.SetCursorPosition(23, 0)

            Console.WriteLine(welcomeText)


            'Console.WriteLine("Welcome to Fun With Lawns v0.1")


            'Console.SetCursorPosition(18, 1)
            'Console.WriteLine("Your all in one lawn management system.")


            Console.SetCursorPosition(0, 23)
            Console.WriteLine("Press any key to continue...")
            Console.ReadKey()


            Console.ForegroundColor = ConsoleColor.White
            Console.BackgroundColor = ConsoleColor.Black
            '  MowerPic()
            MakeColor()
        Else

            'welcome user to fun with lawns
            Console.SetCursorPosition(23, 0)

            Console.WriteLine(welcomeText)


            'Console.WriteLine("Welcome to Fun With Lawns v0.1")


            'Console.SetCursorPosition(18, 1)
            'Console.WriteLine("Your all in one lawn management system.")


            Console.SetCursorPosition(0, 23)
            Console.WriteLine("Press any key to continue...")
            Console.ReadKey()


            Console.ForegroundColor = ConsoleColor.White
            Console.BackgroundColor = ConsoleColor.Black
            LoadColor()

        End If

        Console.ForegroundColor = textColor

        Console.BackgroundColor = backGroundColor
        Console.Clear()
        'Console.ForegroundColor = textColor
        'Console.BackgroundColor = backGroundColor
        Console.Clear()
        'cheack if there is a profile and send the user to the right place accourding to this infomation

        ' Fixed bug (03/02/2013) Added .txt to fix reading issue
        If IO.File.Exists("User Bussiness Information.txt") Then
            menu()
        ElseIf Not IO.File.Exists("User Bussiness Information.txt") Then
            MakeCompanyInfo()
        End If
        'Console.ReadKey()




    End Sub

    Sub menu()




        'If IO.File.Exists("Color.txt") Then


        '    Console.ForegroundColor = textColor
        '    Console.BackgroundColor = backGroundColor

        'End If
        Dim MenuOption As Char
        'Console.ForegroundColor = ConsoleColor.Green

        'Console.BackgroundColor = ConsoleColor.DarkMagenta
        'Console.Clear()


        'If FirstTimeOpen = True Then

        openBussnessInfo()


        LoadBookings()

        loadTotalIncome()
        LoadCompleteHours()
        '  FirstTimeOpen = False
        'End If

        While MenuOption <> "X" Or MenuOption <> "x"
            Console.Clear()
            'While True
            '    Console.ForegroundColor = 

            '    Console.WriteLine("Fun With Lawns")

            '    Console.Clear()
            'End While
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            'If Not IO.File.Exists("Color.txt") Then
            '    MakeColor()
            'Else
            '    LoadColor()
            'End If
            'Console.ForegroundColor = textColor
            'Console.BackgroundColor = backGroundColor
            'Console.Clear()
            'clear the screen



            'Welcomeing the user
            Console.WriteLine("Welcome " & ownername)
            Console.WriteLine("-------------------------------------------------------")

            'dissplay the current completed hours and the total income
            Console.WriteLine("Total completed hours: " & completedhours)
            Console.WriteLine("Total income:         $" & totalincome)
            Console.WriteLine("-------------------------------------------------------")
            Console.WriteLine("")

            'display menu options
            Console.WriteLine("Select from one of the following menu options:")
            Console.WriteLine("")

            Console.WriteLine(" <A> Add a booking")
            Console.WriteLine(" <B> Veiw all incomplete booking's")
            Console.WriteLine(" <C> Veiw all complete bookings")
            Console.WriteLine(" <D> Cheack incomplete booking's for next 7 days")
            Console.WriteLine("")
            Console.WriteLine(" <E> View incomplete booking's details")
            Console.WriteLine(" <F> Edit incomplete booking details")
            Console.WriteLine("")
            Console.WriteLine(" <G> Remove a booking")
            Console.WriteLine(" <H> Complete a booking")
            Console.WriteLine("")
            Console.WriteLine(" <I> View Bussiness card")
            Console.WriteLine("")

            Console.WriteLine(" <J> Options")
            Console.WriteLine(" <X> Exit")

            'Get the users choice
            MenuOption = Console.ReadKey.KeyChar.ToString.ToUpper

            Select Case MenuOption
                Case "A"

                    AddBooking()
                Case "B"

                    InCompleteBookings()
                Case "C"

                    CompleteBookings()
                Case "D"

                    InCompleteBookingsForSevenDays()
                Case "E"

                    InCompleteBookingDetails()
                Case "F"

                    EditIncompleteBookings()
                Case "G"

                    RemoveBooking()
                Case "H"

                    CompleteABooking()
                Case "I"

                    BusinessCard()
                Case "J"
                    options()
                Case "X"
                    Close()
            End Select

        End While

    End Sub

    Sub MakeCompanyInfo()

        If CompanyChange = False Then
            Console.Clear()
            Console.WriteLine("No company information found. We'll setup a profile befor we begin")
            Console.WriteLine()
            Console.WriteLine("Press any key to continue...")
            Console.ReadKey()
        End If
        'clear the screen
        Console.Clear()


        'create the users information
        Console.WriteLine("Here you need to enter the details for your new company profile.")
        Console.WriteLine("")

        Console.Write("Company name: ")
        companyname = Console.ReadLine

        Console.Write("Company owner's name: ")
        ownername = Console.ReadLine
        Try
            Console.Write("Company contact number: ")
            contactnumber = Console.ReadLine
        Catch ex As Exception

        End Try


        Console.Write("Company Address: ")
        address = Console.ReadLine


        Try
            Console.Write("Company Hourly rate: $")
            hourlyrate = Console.ReadLine
        Catch ex As Exception

        End Try


        ' inform the user of successfull completion
        Console.WriteLine("")
        Console.WriteLine("Set up is complete!")
        Console.WriteLine("")
        Console.WriteLine("Press any key to continue...")
        Console.ReadKey()
        SaveBussnessDetails()
        menu()





    End Sub

    Sub AddBooking()

        Dim NewBooking As New BookingDetails

        Console.Clear()
        Dim selection As Char
        ' take the clients details
        Console.WriteLine("Adding a new booking, enter the details below:")
        Console.WriteLine()

        Console.Write("Client's name: ")

        NewBooking.ClientName = Console.ReadLine

        Console.Write("Client's Address: ")
        NewBooking.ClientAddress = Console.ReadLine

        'error handle the phone number incase the user enters charaters
        Try
            Console.Write("Client's phone number: ")
            NewBooking.ClientsPhoneNumber = Console.ReadLine
            Console.Write("Date of booking <dd/mm/yy: >")
            NewBooking.DateOfBooking = Console.ReadLine
        Catch ex As Exception

        End Try


        Console.Write("Time of booking <hh:mm am/pm>: ")
        Try

            NewBooking.TimeOfBooking = Console.ReadLine
        Catch ex As Exception

        End Try

        Console.Clear()

        ' display the details of the booking

        Console.WriteLine("Booking details are as followed: ")
        Console.WriteLine("        Name: " & NewBooking.ClientName)
        Console.WriteLine("        Address: " & NewBooking.ClientAddress)

        Try
            Console.WriteLine("        Phone number: " & NewBooking.ClientsPhoneNumber)
        Catch ex As Exception

        End Try

        Console.WriteLine("        Date: " & NewBooking.DateOfBooking)
        Console.WriteLine("        Time: " & NewBooking.TimeOfBooking)

        Console.WriteLine("")
        ' ask if details are correct 
        Console.Write("Are these details correct: <y/n>? ")

        selection = Console.ReadKey.KeyChar

        ' if statment to decide if to save details of booking or to cancel
        Try
            If selection = "y" Or selection = "Y" Then
                ' add bokking to bookings
                Bookings.Add(NewBooking)
                ' tell the user they added a bookinmg


                Console.WriteLine()
                Console.WriteLine("Booking added!")
                Console.WriteLine("")
                Console.WriteLine("Press any key to continue!")
                Console.ReadKey()

                BookingNumber += 1
                SaveBookings()
            ElseIf selection = "n" Or "N" Then
                Console.WriteLine()
                Console.WriteLine("Booking canclled.")
                Console.WriteLine("")
                Console.WriteLine("Press any key to continue")
                Console.ReadKey()
                menu()

            End If
        Catch ex As Exception

        End Try


    End Sub

    Sub InCompleteBookings()

        Console.Clear()

        Console.WriteLine("Veiwing incomplate jobs")
        Console.WriteLine("")

        viewBookings(False)

        Console.WriteLine("Press any key to cointnue")



        Console.ReadKey()



    End Sub


    Sub CompleteBookings()

        Console.Clear()
        Console.WriteLine("Vewing all complete Jobs")



        Console.WriteLine("")

        viewBookings(True)





        Console.WriteLine("Press any key to continue")
        Console.ReadKey()

    End Sub

    Sub InCompleteBookingsForSevenDays()
        Dim timeNow As Date = Now
        Console.Clear()
        Console.WriteLine("Vewing all incomplete jobs from today until " & Now.AddDays(7))



        Console.WriteLine("")

        BookingsFor7days(False)





        Console.WriteLine("Press anykey to continue")

        Console.ReadKey()


    End Sub

    Sub InCompleteBookingDetails()

        Console.Clear()
        Console.WriteLine("Vewing incomplete jobs.")



        Console.WriteLine("")

        viewBookings(False)

        Dim index As String = GetBooking()


        If index <> "" Then


            Console.Clear()

            Console.WriteLine("Booking details:")
            Try
                Console.WriteLine("     ")
                Console.WriteLine("     Name: " & Bookings(index).ClientName)
                Console.WriteLine("     Address: " & Bookings(index).ClientAddress)
                Console.WriteLine("     Date: " & Bookings(index).DateOfBooking)
                Console.WriteLine("     Time: " & Bookings(index).TimeOfBooking)
            Catch ex As Exception

            End Try



            Console.WriteLine()

            Console.WriteLine("Press any key to continue!")
            Console.ReadKey()



        End If



    End Sub

    Sub EditIncompleteBookings()
        Console.Clear()
        Console.WriteLine("Vewing incomplete jobs.")

        Console.WriteLine("")

        viewBookings(False)

        Dim index As Integer = GetBooking()

        If index <> "" Then
            Console.Clear()

            Console.WriteLine("Booking details:")

            Console.WriteLine("     ")
            Console.WriteLine("     Name: " & Bookings(index).ClientName)
            Console.WriteLine("     Address: " & Bookings(index).ClientAddress)
            Console.WriteLine("     Date: " & Bookings(index).DateOfBooking)
            Console.WriteLine("     Time: " & Bookings(index).TimeOfBooking)
            Console.WriteLine()

            Console.Write("Are you sure you want to edit this booking <y/n>: ")

            Select Case Console.ReadKey.KeyChar.ToString.ToUpper
                Case "Y"
                    Console.Clear()
                    Console.WriteLine()
                    Console.WriteLine()
                    Console.Write("     Client Name: ")
                    Try

                        Bookings(index).ClientName = Console.ReadLine
                    Catch ex As Exception

                    End Try


                    Console.Write("     Client Address: ")
                    Try

                        Bookings(index).ClientAddress = Console.ReadLine
                    Catch ex As Exception

                    End Try


                    Console.Write("     Date of booking <dd/mm/yyyy>: ")
                    Try

                        Bookings(index).DateOfBooking = Console.ReadLine
                    Catch ex As Exception

                    End Try


                    Console.Write("     Time of booking <hh:mm am/pm>: ")
                    Try

                        Bookings(index).TimeOfBooking = Console.ReadLine
                    Catch ex As Exception

                    End Try
                    Console.WriteLine("Done!")
                    Console.WriteLine()
                    Console.WriteLine("Pressany key to continue...")
                    Console.ReadKey()

                    SaveBookings()

                Case "N"
                    Console.Clear()
                    Console.WriteLine("Cancelled ")
                    Console.WriteLine()
                    Console.WriteLine("Press any key to cotinue...")
                    Console.ReadKey()
                Case Else
                    Console.WriteLine("Invald Key")
                    Console.WriteLine()
                    Console.WriteLine("Press any key to continue")
                    Console.ReadKey()
            End Select
        ElseIf index = "" Then
            Console.Clear()
            Console.WriteLine("Canceled")
            Console.WriteLine("Press any key to continue... ")
            Console.ReadKey()
        End If


    End Sub

    Sub RemoveBooking()

        Console.Clear()
        Console.WriteLine("Vewing incomplete jobs.")



        Console.WriteLine("")


        viewBookings(False)





        Dim index As Integer = GetBooking()

        Select Case Console.ReadLine
            Case ""
                Console.WriteLine("Canceled!")
                Console.WriteLine()

                Console.WriteLine("Press anykey to continue")
                Console.ReadKey()

            Case Else
                Bookings.RemoveAt(index)

        End Select


    End Sub

    Sub CompleteABooking()


        '   Dim Bookings As New List(Of BookingDetails)

        Console.Clear()
        Console.WriteLine("Viewing incomplete jobs for completion.")



        Console.WriteLine("")


        viewBookings(False)

        Dim index As Integer = GetBooking()

        If index <> -1 Then


            Console.Clear()

            Console.WriteLine("Booking details:")



            Console.WriteLine("     ")
            Try
                Console.WriteLine("     Name: " & Bookings(index).ClientName)
            Catch ex As Exception

            End Try
            Try

                Console.WriteLine("     Address: " & Bookings(index).ClientAddress)
            Catch ex As Exception

            End Try
            Try
                Console.WriteLine("     Date: " & Bookings(index).DateOfBooking)
            Catch ex As Exception

            End Try
            Try

                Console.WriteLine("     Time: " & Bookings(index).TimeOfBooking)
            Catch ex As Exception

            End Try
            Console.WriteLine()





            Console.Write("Are you sure you want to complate this booking <y/n>: ")
            Dim answer As Char = Console.ReadKey.KeyChar.ToString.ToUpper



            Dim hours As Single

            If answer = "Y" Then
                Try
                    Bookings(index).complete = True


                Catch ex As Exception

                End Try




                Console.Clear()
                Console.Write("How many hours did the booking take: ")
                Try

                    hours = Console.ReadLine
                Catch ex As Exception

                End Try

                Console.WriteLine("You have mad $" & hourlyrate * hours)
                Console.WriteLine()



                completedhours = completedhours + hours

                saveCompleteHours()

                AddToTotalMonyMade(index, hours)

                Console.WriteLine()

                Console.WriteLine("Job marked as complete, hours have been added to your total")


                Console.WriteLine("Press anykey to continue....")
                Console.ReadKey()



            ElseIf answer <> "Y" Or answer <> "N" Then

                Console.WriteLine("Invalad key")


            ElseIf answer = "N" Then

                Console.Clear()

                Console.WriteLine("Canceled")
                Console.WriteLine("Press any key to continue")
                Console.ReadKey()


                '   Console.WriteLine("you entered an invalad key")






            End If


        ElseIf index = -1 Then

        End If

        '     End If
    End Sub

    Sub BusinessCard()

        Console.Clear()

        Console.SetCursorPosition(15, 7)
        Console.WriteLine("/===========================================\")
        Console.WriteLine("               :  " & companyname)

        Console.SetCursorPosition(59, 8)
        Console.WriteLine(":")

        Console.WriteLine("               :  ")

        Console.WriteLine("               :  Owner: " & ownername)
        Console.SetCursorPosition(59, 10)
        Console.WriteLine(":")
        Console.SetCursorPosition(59, 9)
        Console.WriteLine(":")
        Console.SetCursorPosition(59, 10)

        Console.WriteLine()
        Console.WriteLine("               :                                           : ")

        Console.WriteLine("               :                                           : ")

        Console.WriteLine("               :  Phone Number: " & contactnumber)


        Console.SetCursorPosition(59, 13)
        Console.WriteLine(":")
        Console.SetCursorPosition(59, 14)
        Console.WriteLine(":")
        Console.SetCursorPosition(59, 15)
        Console.WriteLine(":")
        Console.SetCursorPosition(15, 15)

        Console.WriteLine(":  Address: " & address)

        Console.SetCursorPosition(15, 14)
        Console.WriteLine(":")









        Console.SetCursorPosition(15, 16)
        Console.WriteLine("\===========================================/")

        Console.ReadKey()
        menu()

    End Sub

    Sub Close()
        Environment.Exit(0)

    End Sub

    Sub SaveBussnessDetails()
        'open file
        FileOpen(1, "User Bussiness Information.txt", OpenMode.Output)

        ' print the user infomation in the file


        PrintLine(1, companyname)
        PrintLine(1, ownername)
        PrintLine(1, contactnumber)
        PrintLine(1, address)
        PrintLine(1, hourlyrate)
        PrintLine(1, completedhours)
        PrintLine(1, totalincome)





        'close file
        FileClose(1)
        ' go to menu
        '    menu()


    End Sub

    Sub SaveBookings()

        FileOpen(1, "Bookings.txt", OpenMode.Output)

        For Each Booking In Bookings
            PrintLine(1, Booking.ClientAddress)
            PrintLine(1, Booking.ClientName)
            PrintLine(1, Booking.ClientsPhoneNumber)
            PrintLine(1, Booking.DateOfBooking)
            PrintLine(1, Booking.TimeOfBooking)
        Next

        FileClose(1)




    End Sub

    Sub LoadBookings()





        If IO.File.Exists("Bookings.txt") Then
            FileOpen(2, "Bookings.txt", OpenMode.Input)



            While Not EOF(2)

                Dim NewBooking As New BookingDetails

                NewBooking.ClientAddress = LineInput(2)
                NewBooking.ClientName = LineInput(2)
                NewBooking.ClientsPhoneNumber = LineInput(2)
                NewBooking.DateOfBooking = LineInput(2)
                Try

                    NewBooking.TimeOfBooking = LineInput(2)
                Catch ex As Exception

                End Try

                Bookings.Add(NewBooking)

            End While



            FileClose(2)
        End If






    End Sub


    Sub SaveTotalIncome()

        '        If IO.File.Exists("TotalIncome.txt") Then


        FileOpen(1, "TotalIncome.txt", OpenMode.Output)

        PrintLine(1, totalincome)
        FileClose(1)

        'ElseIf Not IO.File.Exists("TotalIncome.txt") Then
        '    FileOpen(1, "TotalIncome.txt", OpenMode.Output)

        '    PrintLine(1, totalincome)
        '    FileClose(1)

        '   End If


    End Sub

    Sub loadTotalIncome()

        If IO.File.Exists("TotalIncome.txt") Then

            FileOpen(1, "TotalIncome.txt", OpenMode.Input)

            totalincome = LineInput(1)

            FileClose(1)

        End If
    End Sub

    Sub openBussnessInfo()


        'open the user bssnes info file 

        FileOpen(1, "User Bussiness Information.txt", OpenMode.Input)

        companyname = LineInput(1)
        ownername = LineInput(1)
        contactnumber = LineInput(1)
        address = LineInput(1)
        hourlyrate = LineInput(1)
        completedhours = LineInput(1)
        totalincome = LineInput(1)

        FileClose(1)
    End Sub

    Sub saveCompleteHours()


        FileOpen(1, "CompleteHours.txt", OpenMode.Append)

        PrintLine(1, completedhours)

        FileClose(1)



    End Sub

    Sub LoadCompleteHours()


        If IO.File.Exists("CompleteHours.txt") Then

            FileOpen(1, "CompleteHours.txt", OpenMode.Input)

            completedhours = LineInput(1)

            FileClose(1)

        End If

    End Sub

    Sub AddToTotalMonyMade(index As Integer, hours As Double)

        Dim totalmoneymadethisbooking As Double

        totalmoneymadethisbooking = hourlyrate * hours

        totalincome = totalmoneymadethisbooking + totalincome
        SaveTotalIncome()
        '   SaveCompleteBookingDetails(index)
    End Sub

    Sub viewBookings(complete As Boolean)

        Console.WriteLine("ID   Client's name                   Date                   Time")
        Console.WriteLine("--------------------------------------------------------------------------------")

        For i = 0 To Bookings.Count - 1

            If Bookings(i).complete = complete Then
                Console.WriteLine("{0,-5} {1,-30} {2,-20} {3,-40}", i, Bookings(i).ClientName, Bookings(i).DateOfBooking.ToString("dd/MM/yyyy"), Bookings(i).TimeOfBooking.ToString("hh/mm/s"))
            End If

        Next


    End Sub

    Function GetBooking() As Integer

        Dim index As Integer = 0

        Console.Write("Enter the index of the booking <type -1 to cancel>: ")
        Try
            index = Console.ReadLine()
        Catch ex As Exception

        End Try


        Return index

    End Function


    Sub BookingsFor7days(complete As Boolean)
        Dim timeInSevenDays As Date = Now.AddDays(7)

        Console.WriteLine("ID   Client's name                   Date                   Time")
        Console.WriteLine("--------------------------------------------------------------------------------")

        For i = 0 To Bookings.Count - 1

            If Bookings(i).DateOfBooking < timeInSevenDays Then
                If Bookings(i).complete = complete Then
                    Console.WriteLine("{0,-5} {1,-30} {2,-20} {3,-40}", i, Bookings(i).ClientName, Bookings(i).DateOfBooking.ToString("dd/MM/yyyy"), Bookings(i).TimeOfBooking.ToString("hh/mm/s"))
                End If
            End If

        Next
    End Sub

    Sub options()
        Dim selection As Char
        While selection <> "X"
            Console.Clear()

            Console.WriteLine("Options")
            Console.WriteLine("")
            Console.WriteLine(" (A) Change Color Scheme")
            Console.WriteLine(" (B) Change company infomation")

            Console.SetCursorPosition(0, 22)
            Console.WriteLine(" (X) Qit")

            selection = Console.ReadKey.KeyChar.ToString.ToUpper()



            Select Case selection
                Case "A"
                    MakeColor()
                Case "B"
                    CompanyChange = True
                    MakeCompanyInfo()
                Case "X"

                Case Else
                    Console.WriteLine("Invalad Key")


            End Select

        End While


    End Sub

End Module
