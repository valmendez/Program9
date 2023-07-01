Imports System.IO
Imports System.Text

Public Class frmVote

    'variables
    Dim FirstName As String
    Dim LastName As String
    Dim Address As String
    Dim SSNO As Double
    Dim randomNum As New Random()
    Dim Token As Double 'was integer

    Dim line As String = "" ' for (lineInput) reading each line in the file
    Dim fileNum As Integer = FreeFile() 'use this instead of file number

    'file for SSNO, City, and Token
    Dim VoterFile As String = "SSNO.txt" 'name of file

    'file for people who voted
    Dim VotedFile As String = "AlreadyVoted.txt"

    Dim SSNOMatch As Boolean = False 'Flag to indicate if a match is found
    Dim TokenMatch As Boolean = False
    Dim SSNOCityMatch As Boolean = False
    Dim AlreadyVotedMatch As Boolean = False

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        'user input
        FirstName = CStr(txtFirstName.Text)
        LastName = CStr(txtLastName.Text)
        Address = CStr(txtAddress.Text)
        SSNO = CDbl(txtSSNO.Text)

        Dim AddressArr() As String = Address.Split(","c) 'split the input into an array of 2 strings (city, state) using a comma as a separator
        If AddressArr.Length = 2 Then 'Make sure there are exactly two strings in the array
            Dim city As String = AddressArr(0).Trim 'Get the first string
            Dim state As String = AddressArr(1).Trim  'Get the second string


            'SSNO must have 9 digits!
            If SSNO >= 900000000 And SSNO <= 900999999 Then 'the user entered a valid SSNO

                'First, check if voter has already voted...
                FileOpen(fileNum, VotedFile, OpenMode.Input)

                While Not EOF(fileNum)
                    line = LineInput(fileNum)
                    If line.Contains(txtSSNO.Text) Then
                        AlreadyVotedMatch = True
                        Exit While
                    End If
                End While
                FileClose(fileNum)

                If AlreadyVotedMatch Then
                    MessageBox.Show("Oops, looks like you already voted before. You can only vote once!")
                Else



                    'random token is generated(6 digits)
                    Token = randomNum.Next(100000, 1000000) 'random token will be 100000 to 900000





                    'check if ONLY ssno is found in the file
                    FileOpen(fileNum, VoterFile, OpenMode.Input)
                    Dim SSNOMatch As Boolean = False
                    Do While Not EOF(fileNum) And Not SSNOMatch
                        Dim line As String = LineInput(fileNum)
                        Dim parts() As String = line.Split(" "c)
                        Dim fileSSNO As String = CStr(parts(0))
                        If fileSSNO = CStr(txtSSNO.Text) Then
                            SSNOMatch = True
                        End If
                    Loop


                    FileClose(fileNum)

                    If SSNOMatch Then
                        Console.WriteLine("The SSNO is found in the file.")
                    Else
                        Console.WriteLine("The SSNO is not found in the file.")
                    End If

                    'if SSNO is not already in the file, give them a token and save their information
                    If SSNOMatch Then

                        MessageBox.Show("You are already registered!")

                    Else
                        MessageBox.Show("Your token is: " & Token, "TOKEN")

                        FileOpen(fileNum, VoterFile, OpenMode.Append)
                        'save city, ssno, and token in the file
                        PrintLine(fileNum, SSNO & " " & city & " " & Token)
                        'close file
                        FileClose(fileNum)

                        'Display second groupbox
                        grbRegistration.Visible = False
                        grbEnterToken.Visible = True

                    End If

                End If



            Else
                MessageBox.Show("SSNO must be 9 digits long. Try again.")
            End If

        Else
            MessageBox.Show("Please enter the city and state separated by a comma.")
        End If

    End Sub

    Private Sub btnTokenOk_Click(sender As Object, e As EventArgs) Handles btnTokenOk.Click
        'variables
        Dim tokenInput As Double

        'user input
        tokenInput = CDbl(txtEnterToken.Text)

        'If user types the correct token, they will be able to vote! 
        FileOpen(fileNum, VoterFile, OpenMode.Input)

        While Not EOF(fileNum)
            line = LineInput(fileNum)
            If line.Contains(txtEnterToken.Text) Then
                TokenMatch = True
                Exit While
            End If
        End While
        FileClose(fileNum)

        If TokenMatch Then
            MessageBox.Show("The Token was found. You may vote now :)")
            grbEnterToken.Visible = False
            grbVote.Visible = True
        Else
            MessageBox.Show("The Token is not correct.")
        End If
    End Sub

    Private Sub btnForgot_Click(sender As Object, e As EventArgs) Handles btnForgot.Click

        grbEnterToken.Visible = False
        grbLookup.Visible = True

    End Sub

    Private Sub btnLookupOk_Click(sender As Object, e As EventArgs) Handles btnLookupOk.Click

        'variables
        Dim userSSNO As String
        Dim userCity As String

        'input
        userSSNO = CStr(txtSSNO2.Text)
        userCity = CStr(txtCity.Text)

        'The user has forgotten their Token. They can look it up by typing the correct SSNO and their City
        FileOpen(fileNum, VoterFile, OpenMode.Input)

        Do While Not EOF(fileNum) And Not SSNOCityMatch
            Dim line As String = LineInput(fileNum)
            Dim parts() As String = line.Split(" "c)
            Dim fileSSNO As String = CStr(parts(0))
            Dim fileCity As String = CStr(parts(1))
            If fileSSNO = CStr(txtSSNO2.Text) And fileCity = CStr(txtCity.Text) Then
                SSNOCityMatch = True
                Token = parts(2)
            End If
        Loop

        FileClose(fileNum) 'Close the file'

        If SSNOCityMatch Then
            MessageBox.Show("Your Token is : " & Token)
            grbLookup.Visible = False
            grbEnterToken.Visible = True
        Else
            MessageBox.Show("No match was found. Try again.")
        End If

    End Sub

    Private Sub btnVoteOk_Click(sender As Object, e As EventArgs) Handles btnVoteOk.Click
        'user votes

        'save their ssno in a seperate text file when they vote
        FileOpen(fileNum, VotedFile, OpenMode.Append)
        'save ssno in the file
        PrintLine(fileNum, SSNO)
        'close file
        FileClose(fileNum)

        MessageBox.Show("Congratulations!! you have voted")

        Close() 'exit 

    End Sub
End Class
