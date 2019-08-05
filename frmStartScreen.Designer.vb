<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStartScreen
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnNameConfirm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(24, 142)
        Me.lblName.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(80, 25)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name: "
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(118, 137)
        Me.txtName.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(196, 31)
        Me.txtName.TabIndex = 1
        '
        'btnNameConfirm
        '
        Me.btnNameConfirm.Location = New System.Drawing.Point(114, 233)
        Me.btnNameConfirm.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnNameConfirm.Name = "btnNameConfirm"
        Me.btnNameConfirm.Size = New System.Drawing.Size(150, 44)
        Me.btnNameConfirm.TabIndex = 2
        Me.btnNameConfirm.Text = "Ok"
        Me.btnNameConfirm.UseVisualStyleBackColor = True
        '
        'frmStartScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 300)
        Me.Controls.Add(Me.btnNameConfirm)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "frmStartScreen"
        Me.Text = "Enter Your Name"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnNameConfirm As Button
End Class
