<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBlackjackGame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim lblDealerHandValue As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBlackjackGame))
        Me.lblWins = New System.Windows.Forms.Label()
        Me.lblLosses = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.picPlayer1 = New System.Windows.Forms.PictureBox()
        Me.picPlayer5 = New System.Windows.Forms.PictureBox()
        Me.picPlayer4 = New System.Windows.Forms.PictureBox()
        Me.picPlayer3 = New System.Windows.Forms.PictureBox()
        Me.picPlayer2 = New System.Windows.Forms.PictureBox()
        Me.picDealer2 = New System.Windows.Forms.PictureBox()
        Me.picDealer3 = New System.Windows.Forms.PictureBox()
        Me.picDealer4 = New System.Windows.Forms.PictureBox()
        Me.picDealer5 = New System.Windows.Forms.PictureBox()
        Me.picDealer1 = New System.Windows.Forms.PictureBox()
        Me.picDeck = New System.Windows.Forms.PictureBox()
        Me.btnHit = New System.Windows.Forms.Button()
        Me.btnDeal = New System.Windows.Forms.Button()
        Me.btnStand = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblBet = New System.Windows.Forms.Label()
        Me.txtBet = New System.Windows.Forms.TextBox()
        Me.lblPlayerHandCount = New System.Windows.Forms.Label()
        Me.lblDealerHandCount = New System.Windows.Forms.Label()
        lblDealerHandValue = New System.Windows.Forms.Label()
        CType(Me.picPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDealer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDealer3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDealer4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDealer5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDealer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDeck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDealerHandValue
        '
        lblDealerHandValue.AutoSize = True
        lblDealerHandValue.Location = New System.Drawing.Point(1324, 394)
        lblDealerHandValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblDealerHandValue.Name = "lblDealerHandValue"
        lblDealerHandValue.Size = New System.Drawing.Size(0, 25)
        lblDealerHandValue.TabIndex = 23
        '
        'lblWins
        '
        Me.lblWins.AutoSize = True
        Me.lblWins.Location = New System.Drawing.Point(68, 56)
        Me.lblWins.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblWins.Name = "lblWins"
        Me.lblWins.Size = New System.Drawing.Size(66, 25)
        Me.lblWins.TabIndex = 0
        Me.lblWins.Text = "Wins:"
        '
        'lblLosses
        '
        Me.lblLosses.AutoSize = True
        Me.lblLosses.Location = New System.Drawing.Point(454, 56)
        Me.lblLosses.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblLosses.Name = "lblLosses"
        Me.lblLosses.Size = New System.Drawing.Size(87, 25)
        Me.lblLosses.TabIndex = 1
        Me.lblLosses.Text = "Losses:"
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Location = New System.Drawing.Point(68, 1090)
        Me.lblBalance.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(102, 25)
        Me.lblBalance.TabIndex = 2
        Me.lblBalance.Text = "Balance: "
        '
        'picPlayer1
        '
        Me.picPlayer1.Image = CType(resources.GetObject("picPlayer1.Image"), System.Drawing.Image)
        Me.picPlayer1.Location = New System.Drawing.Point(74, 694)
        Me.picPlayer1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.picPlayer1.Name = "picPlayer1"
        Me.picPlayer1.Size = New System.Drawing.Size(228, 346)
        Me.picPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPlayer1.TabIndex = 6
        Me.picPlayer1.TabStop = False
        '
        'picPlayer5
        '
        Me.picPlayer5.Image = CType(resources.GetObject("picPlayer5.Image"), System.Drawing.Image)
        Me.picPlayer5.InitialImage = Global.Yasas_Blackjack.My.Resources.Resources.card_back_purple
        Me.picPlayer5.Location = New System.Drawing.Point(1042, 694)
        Me.picPlayer5.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.picPlayer5.Name = "picPlayer5"
        Me.picPlayer5.Size = New System.Drawing.Size(228, 346)
        Me.picPlayer5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPlayer5.TabIndex = 7
        Me.picPlayer5.TabStop = False
        '
        'picPlayer4
        '
        Me.picPlayer4.Image = CType(resources.GetObject("picPlayer4.Image"), System.Drawing.Image)
        Me.picPlayer4.Location = New System.Drawing.Point(802, 694)
        Me.picPlayer4.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.picPlayer4.Name = "picPlayer4"
        Me.picPlayer4.Size = New System.Drawing.Size(228, 346)
        Me.picPlayer4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPlayer4.TabIndex = 8
        Me.picPlayer4.TabStop = False
        '
        'picPlayer3
        '
        Me.picPlayer3.Image = CType(resources.GetObject("picPlayer3.Image"), System.Drawing.Image)
        Me.picPlayer3.Location = New System.Drawing.Point(554, 694)
        Me.picPlayer3.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.picPlayer3.Name = "picPlayer3"
        Me.picPlayer3.Size = New System.Drawing.Size(228, 346)
        Me.picPlayer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPlayer3.TabIndex = 9
        Me.picPlayer3.TabStop = False
        '
        'picPlayer2
        '
        Me.picPlayer2.Image = CType(resources.GetObject("picPlayer2.Image"), System.Drawing.Image)
        Me.picPlayer2.Location = New System.Drawing.Point(314, 694)
        Me.picPlayer2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.picPlayer2.Name = "picPlayer2"
        Me.picPlayer2.Size = New System.Drawing.Size(228, 346)
        Me.picPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPlayer2.TabIndex = 10
        Me.picPlayer2.TabStop = False
        '
        'picDealer2
        '
        Me.picDealer2.Image = CType(resources.GetObject("picDealer2.Image"), System.Drawing.Image)
        Me.picDealer2.Location = New System.Drawing.Point(314, 233)
        Me.picDealer2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.picDealer2.Name = "picDealer2"
        Me.picDealer2.Size = New System.Drawing.Size(228, 346)
        Me.picDealer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDealer2.TabIndex = 15
        Me.picDealer2.TabStop = False
        '
        'picDealer3
        '
        Me.picDealer3.Image = CType(resources.GetObject("picDealer3.Image"), System.Drawing.Image)
        Me.picDealer3.Location = New System.Drawing.Point(554, 233)
        Me.picDealer3.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.picDealer3.Name = "picDealer3"
        Me.picDealer3.Size = New System.Drawing.Size(228, 346)
        Me.picDealer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDealer3.TabIndex = 14
        Me.picDealer3.TabStop = False
        '
        'picDealer4
        '
        Me.picDealer4.Image = CType(resources.GetObject("picDealer4.Image"), System.Drawing.Image)
        Me.picDealer4.Location = New System.Drawing.Point(802, 233)
        Me.picDealer4.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.picDealer4.Name = "picDealer4"
        Me.picDealer4.Size = New System.Drawing.Size(228, 346)
        Me.picDealer4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDealer4.TabIndex = 13
        Me.picDealer4.TabStop = False
        '
        'picDealer5
        '
        Me.picDealer5.Image = CType(resources.GetObject("picDealer5.Image"), System.Drawing.Image)
        Me.picDealer5.Location = New System.Drawing.Point(1042, 233)
        Me.picDealer5.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.picDealer5.Name = "picDealer5"
        Me.picDealer5.Size = New System.Drawing.Size(228, 346)
        Me.picDealer5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDealer5.TabIndex = 12
        Me.picDealer5.TabStop = False
        '
        'picDealer1
        '
        Me.picDealer1.Image = CType(resources.GetObject("picDealer1.Image"), System.Drawing.Image)
        Me.picDealer1.Location = New System.Drawing.Point(74, 233)
        Me.picDealer1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.picDealer1.Name = "picDealer1"
        Me.picDealer1.Size = New System.Drawing.Size(228, 346)
        Me.picDealer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDealer1.TabIndex = 11
        Me.picDealer1.TabStop = False
        '
        'picDeck
        '
        Me.picDeck.Image = Global.Yasas_Blackjack.My.Resources.Resources.card_back_purple
        Me.picDeck.Location = New System.Drawing.Point(1432, 477)
        Me.picDeck.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.picDeck.Name = "picDeck"
        Me.picDeck.Size = New System.Drawing.Size(228, 346)
        Me.picDeck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDeck.TabIndex = 16
        Me.picDeck.TabStop = False
        '
        'btnHit
        '
        Me.btnHit.Location = New System.Drawing.Point(460, 1079)
        Me.btnHit.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnHit.Name = "btnHit"
        Me.btnHit.Size = New System.Drawing.Size(150, 44)
        Me.btnHit.TabIndex = 17
        Me.btnHit.Text = "Hit"
        Me.btnHit.UseVisualStyleBackColor = True
        '
        'btnDeal
        '
        Me.btnDeal.Location = New System.Drawing.Point(802, 1081)
        Me.btnDeal.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnDeal.Name = "btnDeal"
        Me.btnDeal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnDeal.Size = New System.Drawing.Size(150, 44)
        Me.btnDeal.TabIndex = 18
        Me.btnDeal.Text = "Deal"
        Me.btnDeal.UseVisualStyleBackColor = True
        '
        'btnStand
        '
        Me.btnStand.Location = New System.Drawing.Point(632, 1079)
        Me.btnStand.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnStand.Name = "btnStand"
        Me.btnStand.Size = New System.Drawing.Size(150, 44)
        Me.btnStand.TabIndex = 19
        Me.btnStand.Text = "Stand"
        Me.btnStand.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(1510, 56)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(150, 44)
        Me.btnExit.TabIndex = 20
        Me.btnExit.TabStop = False
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblBet
        '
        Me.lblBet.AutoSize = True
        Me.lblBet.Location = New System.Drawing.Point(1426, 898)
        Me.lblBet.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblBet.Name = "lblBet"
        Me.lblBet.Size = New System.Drawing.Size(135, 25)
        Me.lblBet.TabIndex = 21
        Me.lblBet.Text = "Bet Amount: "
        '
        'txtBet
        '
        Me.txtBet.Location = New System.Drawing.Point(1574, 892)
        Me.txtBet.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtBet.Name = "txtBet"
        Me.txtBet.Size = New System.Drawing.Size(110, 31)
        Me.txtBet.TabIndex = 22
        '
        'lblPlayerHandCount
        '
        Me.lblPlayerHandCount.AutoSize = True
        Me.lblPlayerHandCount.Location = New System.Drawing.Point(1280, 858)
        Me.lblPlayerHandCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlayerHandCount.Name = "lblPlayerHandCount"
        Me.lblPlayerHandCount.Size = New System.Drawing.Size(24, 25)
        Me.lblPlayerHandCount.TabIndex = 24
        Me.lblPlayerHandCount.Text = "0"
        '
        'lblDealerHandCount
        '
        Me.lblDealerHandCount.AutoSize = True
        Me.lblDealerHandCount.Location = New System.Drawing.Point(1280, 394)
        Me.lblDealerHandCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDealerHandCount.Name = "lblDealerHandCount"
        Me.lblDealerHandCount.Size = New System.Drawing.Size(24, 25)
        Me.lblDealerHandCount.TabIndex = 25
        Me.lblDealerHandCount.Text = "0"
        '
        'frmBlackjackGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1740, 1127)
        Me.Controls.Add(Me.lblDealerHandCount)
        Me.Controls.Add(Me.lblPlayerHandCount)
        Me.Controls.Add(lblDealerHandValue)
        Me.Controls.Add(Me.txtBet)
        Me.Controls.Add(Me.lblBet)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnStand)
        Me.Controls.Add(Me.btnDeal)
        Me.Controls.Add(Me.btnHit)
        Me.Controls.Add(Me.picDeck)
        Me.Controls.Add(Me.picDealer2)
        Me.Controls.Add(Me.picDealer3)
        Me.Controls.Add(Me.picDealer4)
        Me.Controls.Add(Me.picDealer5)
        Me.Controls.Add(Me.picDealer1)
        Me.Controls.Add(Me.picPlayer2)
        Me.Controls.Add(Me.picPlayer3)
        Me.Controls.Add(Me.picPlayer4)
        Me.Controls.Add(Me.picPlayer5)
        Me.Controls.Add(Me.picPlayer1)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.lblLosses)
        Me.Controls.Add(Me.lblWins)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.MaximumSize = New System.Drawing.Size(1766, 1198)
        Me.MinimumSize = New System.Drawing.Size(1766, 1048)
        Me.Name = "frmBlackjackGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Blackjack!"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDealer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDealer3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDealer4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDealer5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDealer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDeck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWins As Label
    Friend WithEvents lblLosses As Label
    Friend WithEvents lblBalance As Label
    Friend WithEvents picPlayer1 As PictureBox
    Friend WithEvents picPlayer5 As PictureBox
    Friend WithEvents picPlayer4 As PictureBox
    Friend WithEvents picPlayer3 As PictureBox
    Friend WithEvents picPlayer2 As PictureBox
    Friend WithEvents picDealer2 As PictureBox
    Friend WithEvents picDealer3 As PictureBox
    Friend WithEvents picDealer4 As PictureBox
    Friend WithEvents picDealer5 As PictureBox
    Friend WithEvents picDealer1 As PictureBox
    Friend WithEvents picDeck As PictureBox
    Friend WithEvents btnHit As Button
    Friend WithEvents btnDeal As Button
    Friend WithEvents btnStand As Button
    Friend WithEvents lblBet As Label
    Friend WithEvents txtBet As TextBox
    Friend WithEvents lblPlayerHandCount As Label
    Friend WithEvents lblDealerHandCount As Label
    Friend WithEvents btnExit As Button
End Class
