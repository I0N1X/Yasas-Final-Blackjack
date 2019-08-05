Public Class frmStartScreen
    Private Sub BtnNameConfirm_Click(sender As Object, e As EventArgs) Handles btnNameConfirm.Click
        If txtName.Text = Nothing Then
            MsgBox("Please Enter a Player Name", vbInformation And vbOK, Title:="Name Warning")
        Else
            playerName = txtName.Text
            gameForm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub FrmStartScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class