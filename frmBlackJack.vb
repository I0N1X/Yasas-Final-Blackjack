Public Class frmBlackjackGame
    Dim cardArray(52) As Integer
    Dim index As Integer
    Dim playerBalance As Integer = 1000
    Dim playerHandValue, dealerHandValue As Integer
    Dim winType As String
    Dim winTypeText As String
    Dim numberOfWins As Integer = 0
    Dim numberOfLosses As Integer = 0
    Dim dealerDealCount As Integer = 0
    Dim playerDealCount As Integer = 0
    Dim tempBetAmount = 0
    Dim aceInPlayerHand As Boolean = False
    Dim playerAceCount As Integer = 0
    Dim aceInDealerHand As Boolean = False
    Dim dealerAceCount As Integer = 0



    Private Sub shuffleDeck()
        Dim i, j, temp As Integer
        For i = 0 To 52
            cardArray(i) = i
        Next

        For j = 52 To 1 Step -1
            i = (Rnd() * j - 0.5) + 1
            temp = cardArray(j)
            cardArray(j) = cardArray(i)
            cardArray(i) = temp
        Next
        index = 1
    End Sub



    Private Function value(ByVal cardValue As Integer) As Integer
        Select Case cardValue
            Case 1 To 4
                value = 11
            Case 5 To 8
                value = 2
            Case 9 To 12
                value = 3
            Case 13 To 16
                value = 4
            Case 17 To 20
                value = 5
            Case 21 To 24
                value = 6
            Case 25 To 28
                value = 7
            Case 29 To 32
                value = 8
            Case 33 To 36
                value = 9
            Case 37 To 39
                value = 10
            Case Else
                value = 10
        End Select
    End Function



    Private Sub blackjack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        path = Application.StartupPath
        Me.Text = playerName + " is playing!"
        lblBalance.Text = "Balance: " + CStr(playerBalance)
        lblWins.Text = "Wins: " + CStr(numberOfWins)
        lblLosses.Text = "Losses: " + CStr(numberOfLosses)
        lblPlayerHandCount.Text = playerHandValue
        lblDealerHandCount.Text = dealerHandValue
        Randomize()
        shuffleDeck()
        txtBet.Text = playerBalance / 10
        btnHit.Enabled = False
        btnStand.Enabled = False
        btnDeal.Focus()
    End Sub

    Private Sub firstDeal()
        dealerHandValue = 0
        picDealer1.Image = Image.FromFile(path + "\cards\" + CStr(cardArray(index)) + ".png")
        dealerHandValue = dealerHandValue + value(cardArray(index))
        If value(cardArray(index)) = 11 Then
            aceInDealerHand = True
            dealerAceCount = dealerAceCount + 1
        End If
        lblDealerHandCount.Text = dealerHandValue
        index = index + 1
        dealerDealCount = dealerDealCount + 1
        playerHandValue = 0
        picPlayer1.Image = Image.FromFile(path + "\cards\" + CStr(cardArray(index)) + ".png")
        playerHandValue = playerHandValue + value(cardArray(index))
        If value(cardArray(index)) = 11 Then
            aceInPlayerHand = True
            playerAceCount = playerAceCount + 1
        End If
        lblPlayerHandCount.Text = playerHandValue
        index = index + 1
        playerDealCount = playerDealCount + 1
        picPlayer2.Image = Image.FromFile(path + "\cards\" + CStr(cardArray(index)) + ".png")
        playerHandValue = playerHandValue + value(cardArray(index))
        If value(cardArray(index)) = 11 Then
            aceInPlayerHand = True
            playerAceCount = playerAceCount + 1
        End If
        lblPlayerHandCount.Text = playerHandValue
        index = index + 1
        playerDealCount = playerDealCount + 1

        aceCheck()
        lblPlayerHandCount.Text = playerHandValue

        If playerHandValue = 21 Then
            winType = "blackjack"
            winTypeText = "Well Done!!, you hit Blackjack!"
            numberOfWins = numberOfWins + 1
            playerBalance = playerBalance + (2 * tempBetAmount)
            lblBalance.Text = "Balance: " + CStr(playerBalance)
            displayWins()
            btnDeal.Enabled = True
        End If


    End Sub


    Private Sub displayWins()
        Select Case winType
            Case "playerWin"
                lblWins.Text = "Wins: " + CStr(numberOfWins)
                Dim response = MsgBox(winTypeText, vbOK And vbInformation, Title:="You Win")
                If response = vbOK Then
                    prepareForNewRound()
                    btnDeal.Enabled = True
                End If
            Case "Charlie"
                lblWins.Text = "Wins: " + CStr(numberOfWins)
                Dim response = MsgBox(winTypeText, vbOK And vbInformation, Title:="You Win")
                If response = vbOK Then
                    prepareForNewRound()
                    btnDeal.Enabled = True
                End If
            Case "blackjack"
                lblWins.Text = "Wins: " + CStr(numberOfWins)
                Dim response = MsgBox(winTypeText, vbOK And vbInformation, Title:="You Win")
                If response = vbOK Then
                    prepareForNewRound()
                    btnDeal.Enabled = True
                End If
            Case "dealerBlackjack"
                lblLosses.Text = "Losses: " + CStr(numberOfLosses)
                Dim response = MsgBox(winTypeText, vbOK And vbInformation, Title:="You Lose")
                If response = vbOK Then
                    prepareForNewRound()
                    btnDeal.Enabled = True
                End If
            Case "bust"
                lblLosses.Text = "Losses: " + CStr(numberOfLosses)
                Dim response = MsgBox(winTypeText, vbOK And vbInformation, Title:="You Lose")
                If response = vbOK Then
                    prepareForNewRound()
                    btnDeal.Enabled = True
                End If
            Case "dealerBust"
                lblWins.Text = "Wins: " + CStr(numberOfWins)
                Dim response = MsgBox(winTypeText, vbOK And vbInformation, Title:="You Win")
                If response = vbOK Then
                    prepareForNewRound()
                    btnDeal.Enabled = True
                End If
            Case "dealerWin"
                lblLosses.Text = "Losses: " + CStr(numberOfLosses)
                Dim response = MsgBox(winTypeText, vbOK And vbInformation, Title:="You Lose")
                If response = vbOK Then
                    prepareForNewRound()
                    btnDeal.Enabled = True
                End If
            Case "tie"
                Dim response = MsgBox(winTypeText, vbOK And vbInformation, Title:="Tie")
                If response = vbOK Then
                    prepareForNewRound()
                    btnDeal.Enabled = True
                End If
        End Select
    End Sub

    Private Sub checkForWin()
        If playerDealCount = 5 And playerHandValue < 21 Then
            winType = "Charlie"
            winTypeText = "Well done, you won with a 5 card hand "
            numberOfWins = numberOfWins + 1
            displayWins()
        End If
        If playerHandValue > 21 Then
            winType = "bust"
            winTypeText = "Unlucky, you are bust."
            numberOfLosses = numberOfLosses + 1
            displayWins()
            playerBalanceCheck()
        End If
        If dealerHandValue > 21 Then
            winType = "dealerBust"
            winTypeText = "The Dealer went bust. You Win!!"
            numberOfWins = numberOfWins + 1
            playerBalance = playerBalance + (2 * tempBetAmount)
            lblBalance.Text = "Balance: " + CStr(playerBalance)
            displayWins()
        End If
        If playerHandValue = 21 Then
            winType = "blackjack"
            winTypeText = "Well Done!!, you hit 21!"
            numberOfWins = numberOfWins + 1
            playerBalance = playerBalance + (2 * tempBetAmount)
            lblBalance.Text = "Balance: " + CStr(playerBalance)
            displayWins()
        End If
        If dealerHandValue = 21 Then
            winType = "dealerBlackjack"
            winTypeText = "Unlucky! The dealer hit 21!"
            numberOfLosses = numberOfLosses + 1
            displayWins()
            playerBalanceCheck()
        End If
    End Sub

    Private Sub checkForWinDealer()
        If playerHandValue < dealerHandValue And dealerHandValue < 22 Then
            winType = "dealerWin"
            winTypeText = "The dealer beat you! Unlucky!"
            numberOfLosses = numberOfLosses + 1
            displayWins()
            playerBalanceCheck()

        ElseIf playerHandValue = dealerHandValue Then
            winType = "tie"
            winTypeText = "Neither of you win!"
            playerBalance = playerBalance + tempBetAmount
            lblBalance.Text = "Balance: " + CStr(playerBalance)
            displayWins()

        ElseIf playerHandValue > dealerHandValue And playerHandValue < 22 Then
            winType = "playerWin"
            winTypeText = "Good Job! You Win!!"
            numberOfWins = numberOfWins + 1
            playerBalance = playerBalance + (2 * tempBetAmount)
            lblBalance.Text = "Balance: " + CStr(playerBalance)
            displayWins()
        End If
    End Sub


    Private Sub aceCheck()
        If dealerHandValue > 21 And aceInDealerHand = True Then
            For i = 0 To dealerAceCount - 1
                aceInDealerHand = False
                dealerAceCount = 0
                dealerHandValue = dealerHandValue - 10
                lblDealerHandCount.Text = dealerHandValue
            Next
        ElseIf playerHandValue > 21 And aceInPlayerHand = True Then
            For i = 0 To playerAceCount - 1
                aceInPlayerHand = False
                playerAceCount = 0
                playerHandValue = playerHandValue - 10
                lblPlayerHandCount.Text = playerHandValue
            Next
        End If
    End Sub

    Private Sub dealPlayerCard()

        If playerDealCount = 2 Then
            picPlayer3.Image = Image.FromFile(path + "\cards\" + CStr(cardArray(index)) + ".png")
            playerHandValue = playerHandValue + value(cardArray(index))
            If value(cardArray(index)) = 11 Then
                aceInPlayerHand = True
                playerAceCount = playerAceCount + 1
            End If
            lblPlayerHandCount.Text = playerHandValue
            index = index + 1
            playerDealCount = playerDealCount + 1
        ElseIf playerDealCount = 3 Then
            picPlayer4.Image = Image.FromFile(path + "\cards\" + CStr(cardArray(index)) + ".png")
            playerHandValue = playerHandValue + value(cardArray(index))
            If value(cardArray(index)) = 11 Then
                aceInPlayerHand = True
                playerAceCount = playerAceCount + 1
            End If
            lblPlayerHandCount.Text = playerHandValue
            index = index + 1
            playerDealCount = playerDealCount + 1
        ElseIf playerDealCount = 4 Then
            picPlayer5.Image = Image.FromFile(path + "\cards\" + CStr(cardArray(index)) + ".png")
            playerHandValue = playerHandValue + value(cardArray(index))
            If value(cardArray(index)) = 11 Then
                aceInPlayerHand = True
                playerAceCount = playerAceCount + 1
            End If
            lblPlayerHandCount.Text = playerHandValue
            index = index + 1
            playerDealCount = playerDealCount + 1
        End If
    End Sub

    Private Sub dealDealerCard()
        If dealerDealCount = 1 Then
            picDealer2.Image = Image.FromFile(path + "\cards\" + CStr(cardArray(index)) + ".png")
            dealerHandValue = dealerHandValue + value(cardArray(index))
            If value(cardArray(index)) = 11 Then
                aceInDealerHand = True
                dealerAceCount = dealerAceCount + 1
            End If
            lblDealerHandCount.Text = dealerHandValue
            index = index + 1
            dealerDealCount = dealerDealCount + 1
        ElseIf dealerDealCount = 2 Then
            picDealer3.Image = Image.FromFile(path + "\cards\" + CStr(cardArray(index)) + ".png")
            dealerHandValue = dealerHandValue + value(cardArray(index))
            If value(cardArray(index)) = 11 Then
                aceInDealerHand = True
                dealerAceCount = dealerAceCount + 1
            End If
            lblDealerHandCount.Text = dealerHandValue
            index = index + 1
            dealerDealCount = dealerDealCount + 1
        ElseIf dealerDealCount = 3 Then
            picDealer4.Image = Image.FromFile(path + "\cards\" + CStr(cardArray(index)) + ".png")
            dealerHandValue = dealerHandValue + value(cardArray(index))
            If value(cardArray(index)) = 11 Then
                aceInDealerHand = True
                dealerAceCount = dealerAceCount + 1
            End If
            lblDealerHandCount.Text = dealerHandValue
            index = index + 1
            dealerDealCount = dealerDealCount + 1
        ElseIf playerDealCount = 4 Then
            picDealer5.Image = Image.FromFile(path + "\cards\" + CStr(cardArray(index)) + ".png")
            dealerHandValue = dealerHandValue + value(cardArray(index))
            If value(cardArray(index)) = 11 Then
                aceInDealerHand = True
                dealerAceCount = dealerAceCount + 1
            End If
            lblDealerHandCount.Text = dealerHandValue
            index = index + 1
            dealerDealCount = dealerDealCount + 1
        End If
    End Sub

    Private Sub BtnDeal_Click(sender As Object, e As EventArgs) Handles btnDeal.Click

        If IsNumeric(txtBet.Text) <> True Then
            MsgBox("Please Enter a valid bet", vbExclamation, Title:="Bet Warning")
        ElseIf txtBet.Text = Nothing Then
            MsgBox("Please Enter a valid bet", vbExclamation, Title:="Bet Warning")
        ElseIf CInt(txtBet.Text) = 0 Then
            MsgBox("Please Enter a bet greater than 0.", vbExclamation, Title:="Bet Warning")
        ElseIf CInt(txtBet.Text) < 0 Then
            MsgBox("Please Enter a bet greater than 0.", vbExclamation, Title:="Bet Warning")
        ElseIf CInt(txtBet.Text) > playerBalance Then
            MsgBox("Please Enter a bet lower than your current balance.", vbExclamation, Title:="Bet Warning")
        Else
            btnDeal.Enabled = False
            btnHit.Enabled = True
            btnStand.Enabled = True
            btnHit.Focus()
            firstDeal()


            playerBalance = playerBalance - CInt(txtBet.Text)
            tempBetAmount = CInt(txtBet.Text)
            lblBalance.Text = "Balance: " + CStr(playerBalance)
        End If
    End Sub

    Private Sub BtnHit_Click(sender As Object, e As EventArgs) Handles btnHit.Click
        dealPlayerCard()
        aceCheck()
        checkForWin()
    End Sub

    Private Sub BtnStand_Click(sender As Object, e As EventArgs) Handles btnStand.Click
        Do Until dealerHandValue > 17 Or dealerHandValue = 0
            dealDealerCard()
            aceCheck()
        Loop
        checkForWinDealer()
        checkForWin()
    End Sub

    Private Sub playerBalanceCheck()
        Dim response
        If playerBalance <= 0 Then
            response = MsgBox("You are out of funds, you lose!", vbOK, Title:="Game Over")
            If response = vbOK Then
                Application.Restart()
            End If
        End If
    End Sub


    Private Sub prepareForNewRound()
        picPlayer1.Image = Image.FromFile(path + "\cards\" + CStr(0) + ".png")
        picPlayer2.Image = Image.FromFile(path + "\cards\" + CStr(0) + ".png")
        picPlayer3.Image = Image.FromFile(path + "\cards\" + CStr(0) + ".png")
        picPlayer4.Image = Image.FromFile(path + "\cards\" + CStr(0) + ".png")
        picPlayer5.Image = Image.FromFile(path + "\cards\" + CStr(0) + ".png")

        picDealer1.Image = Image.FromFile(path + "\cards\" + CStr(0) + ".png")
        picDealer2.Image = Image.FromFile(path + "\cards\" + CStr(0) + ".png")
        picDealer3.Image = Image.FromFile(path + "\cards\" + CStr(0) + ".png")
        picDealer4.Image = Image.FromFile(path + "\cards\" + CStr(0) + ".png")
        picDealer5.Image = Image.FromFile(path + "\cards\" + CStr(0) + ".png")

        index = 1
        dealerDealCount = 0
        dealerHandValue = 0
        lblDealerHandCount.Text = dealerHandValue
        playerDealCount = 0
        playerHandValue = 0
        lblPlayerHandCount.Text = playerHandValue
        winType = Nothing
        winTypeText = Nothing
        tempBetAmount = 0
        btnDeal.Enabled = True
        btnHit.Enabled = False
        btnStand.Enabled = False
        btnDeal.Focus()
        shuffleDeck()
        aceInPlayerHand = False
        aceInDealerHand = False
        playerAceCount = 0
        dealerAceCount = 0
    End Sub



    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

End Class
