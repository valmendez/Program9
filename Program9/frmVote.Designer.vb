<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVote
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
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblSSN = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtSSNO = New System.Windows.Forms.TextBox()
        Me.grbRegistration = New System.Windows.Forms.GroupBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblRegistration = New System.Windows.Forms.Label()
        Me.grbLookup = New System.Windows.Forms.GroupBox()
        Me.btnLookupOk = New System.Windows.Forms.Button()
        Me.lblForgotToken = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtSSNO2 = New System.Windows.Forms.TextBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblSSNO2 = New System.Windows.Forms.Label()
        Me.grbEnterToken = New System.Windows.Forms.GroupBox()
        Me.btnForgot = New System.Windows.Forms.Button()
        Me.btnTokenOk = New System.Windows.Forms.Button()
        Me.txtEnterToken = New System.Windows.Forms.TextBox()
        Me.lblEnterToken = New System.Windows.Forms.Label()
        Me.grbVote = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnVoteOk = New System.Windows.Forms.Button()
        Me.lblVote1 = New System.Windows.Forms.Label()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.grbRegistration.SuspendLayout()
        Me.grbLookup.SuspendLayout()
        Me.grbEnterToken.SuspendLayout()
        Me.grbVote.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(14, 117)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(144, 27)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First Name :"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(14, 146)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(140, 27)
        Me.lblLastName.TabIndex = 1
        Me.lblLastName.Text = "Last Name :"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(14, 181)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(249, 27)
        Me.lblAddress.TabIndex = 2
        Me.lblAddress.Text = "Address (City, State):"
        '
        'lblSSN
        '
        Me.lblSSN.AutoSize = True
        Me.lblSSN.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSSN.Location = New System.Drawing.Point(14, 213)
        Me.lblSSN.Name = "lblSSN"
        Me.lblSSN.Size = New System.Drawing.Size(235, 27)
        Me.lblSSN.TabIndex = 3
        Me.lblSSN.Text = "SSNO(900*******) :"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(262, 120)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 26)
        Me.txtFirstName.TabIndex = 4
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(262, 152)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 26)
        Me.txtLastName.TabIndex = 5
        '
        'txtSSNO
        '
        Me.txtSSNO.Location = New System.Drawing.Point(262, 216)
        Me.txtSSNO.Name = "txtSSNO"
        Me.txtSSNO.Size = New System.Drawing.Size(100, 26)
        Me.txtSSNO.TabIndex = 7
        '
        'grbRegistration
        '
        Me.grbRegistration.BackColor = System.Drawing.Color.Honeydew
        Me.grbRegistration.Controls.Add(Me.txtAddress)
        Me.grbRegistration.Controls.Add(Me.btnOK)
        Me.grbRegistration.Controls.Add(Me.lblRegistration)
        Me.grbRegistration.Controls.Add(Me.txtSSNO)
        Me.grbRegistration.Controls.Add(Me.lblFirstName)
        Me.grbRegistration.Controls.Add(Me.lblLastName)
        Me.grbRegistration.Controls.Add(Me.txtLastName)
        Me.grbRegistration.Controls.Add(Me.lblAddress)
        Me.grbRegistration.Controls.Add(Me.txtFirstName)
        Me.grbRegistration.Controls.Add(Me.lblSSN)
        Me.grbRegistration.Location = New System.Drawing.Point(12, 12)
        Me.grbRegistration.Name = "grbRegistration"
        Me.grbRegistration.Size = New System.Drawing.Size(449, 346)
        Me.grbRegistration.TabIndex = 8
        Me.grbRegistration.TabStop = False
        Me.grbRegistration.Text = "grbRegistration"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(262, 184)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(99, 26)
        Me.txtAddress.TabIndex = 13
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.ForestGreen
        Me.btnOK.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnOK.Location = New System.Drawing.Point(354, 300)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(89, 40)
        Me.btnOK.TabIndex = 9
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'lblRegistration
        '
        Me.lblRegistration.AutoSize = True
        Me.lblRegistration.Font = New System.Drawing.Font("Lucida Calligraphy", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistration.Location = New System.Drawing.Point(9, 44)
        Me.lblRegistration.Name = "lblRegistration"
        Me.lblRegistration.Size = New System.Drawing.Size(398, 47)
        Me.lblRegistration.TabIndex = 8
        Me.lblRegistration.Text = "Voter Registration"
        '
        'grbLookup
        '
        Me.grbLookup.BackColor = System.Drawing.Color.Turquoise
        Me.grbLookup.Controls.Add(Me.btnLookupOk)
        Me.grbLookup.Controls.Add(Me.lblForgotToken)
        Me.grbLookup.Controls.Add(Me.txtCity)
        Me.grbLookup.Controls.Add(Me.txtSSNO2)
        Me.grbLookup.Controls.Add(Me.lblCity)
        Me.grbLookup.Controls.Add(Me.lblSSNO2)
        Me.grbLookup.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbLookup.Location = New System.Drawing.Point(5, 358)
        Me.grbLookup.Name = "grbLookup"
        Me.grbLookup.Size = New System.Drawing.Size(456, 228)
        Me.grbLookup.TabIndex = 9
        Me.grbLookup.TabStop = False
        Me.grbLookup.Text = "  "
        Me.grbLookup.Visible = False
        '
        'btnLookupOk
        '
        Me.btnLookupOk.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnLookupOk.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLookupOk.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLookupOk.Location = New System.Drawing.Point(361, 182)
        Me.btnLookupOk.Name = "btnLookupOk"
        Me.btnLookupOk.Size = New System.Drawing.Size(89, 40)
        Me.btnLookupOk.TabIndex = 10
        Me.btnLookupOk.Text = "OK"
        Me.btnLookupOk.UseVisualStyleBackColor = False
        '
        'lblForgotToken
        '
        Me.lblForgotToken.AutoSize = True
        Me.lblForgotToken.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForgotToken.Location = New System.Drawing.Point(6, 34)
        Me.lblForgotToken.Name = "lblForgotToken"
        Me.lblForgotToken.Size = New System.Drawing.Size(317, 29)
        Me.lblForgotToken.TabIndex = 9
        Me.lblForgotToken.Text = "Registration Code Lookup"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(99, 106)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(100, 36)
        Me.txtCity.TabIndex = 7
        '
        'txtSSNO2
        '
        Me.txtSSNO2.Location = New System.Drawing.Point(99, 66)
        Me.txtSSNO2.Name = "txtSSNO2"
        Me.txtSSNO2.Size = New System.Drawing.Size(100, 36)
        Me.txtSSNO2.TabIndex = 6
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.Location = New System.Drawing.Point(6, 106)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(77, 27)
        Me.lblCity.TabIndex = 5
        Me.lblCity.Text = "City  :"
        '
        'lblSSNO2
        '
        Me.lblSSNO2.AutoSize = True
        Me.lblSSNO2.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSSNO2.Location = New System.Drawing.Point(6, 71)
        Me.lblSSNO2.Name = "lblSSNO2"
        Me.lblSSNO2.Size = New System.Drawing.Size(87, 27)
        Me.lblSSNO2.TabIndex = 4
        Me.lblSSNO2.Text = "SSNO :"
        '
        'grbEnterToken
        '
        Me.grbEnterToken.BackColor = System.Drawing.Color.Pink
        Me.grbEnterToken.Controls.Add(Me.btnForgot)
        Me.grbEnterToken.Controls.Add(Me.btnTokenOk)
        Me.grbEnterToken.Controls.Add(Me.txtEnterToken)
        Me.grbEnterToken.Controls.Add(Me.lblEnterToken)
        Me.grbEnterToken.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grbEnterToken.Location = New System.Drawing.Point(467, 12)
        Me.grbEnterToken.Name = "grbEnterToken"
        Me.grbEnterToken.Size = New System.Drawing.Size(555, 150)
        Me.grbEnterToken.TabIndex = 10
        Me.grbEnterToken.TabStop = False
        Me.grbEnterToken.Text = "grbEnterToken"
        Me.grbEnterToken.Visible = False
        '
        'btnForgot
        '
        Me.btnForgot.BackColor = System.Drawing.Color.LavenderBlush
        Me.btnForgot.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnForgot.Location = New System.Drawing.Point(6, 93)
        Me.btnForgot.Name = "btnForgot"
        Me.btnForgot.Size = New System.Drawing.Size(179, 40)
        Me.btnForgot.TabIndex = 12
        Me.btnForgot.Text = "Forgot your code?"
        Me.btnForgot.UseVisualStyleBackColor = False
        '
        'btnTokenOk
        '
        Me.btnTokenOk.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnTokenOk.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTokenOk.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnTokenOk.Location = New System.Drawing.Point(460, 93)
        Me.btnTokenOk.Name = "btnTokenOk"
        Me.btnTokenOk.Size = New System.Drawing.Size(89, 40)
        Me.btnTokenOk.TabIndex = 10
        Me.btnTokenOk.Text = "OK"
        Me.btnTokenOk.UseVisualStyleBackColor = False
        '
        'txtEnterToken
        '
        Me.txtEnterToken.Location = New System.Drawing.Point(397, 37)
        Me.txtEnterToken.Name = "txtEnterToken"
        Me.txtEnterToken.Size = New System.Drawing.Size(100, 26)
        Me.txtEnterToken.TabIndex = 5
        '
        'lblEnterToken
        '
        Me.lblEnterToken.AutoSize = True
        Me.lblEnterToken.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterToken.Location = New System.Drawing.Point(6, 33)
        Me.lblEnterToken.Name = "lblEnterToken"
        Me.lblEnterToken.Size = New System.Drawing.Size(385, 29)
        Me.lblEnterToken.TabIndex = 1
        Me.lblEnterToken.Text = "To vote,  enter your unique Token :"
        '
        'grbVote
        '
        Me.grbVote.BackColor = System.Drawing.Color.Thistle
        Me.grbVote.Controls.Add(Me.Label1)
        Me.grbVote.Controls.Add(Me.btnVoteOk)
        Me.grbVote.Controls.Add(Me.lblVote1)
        Me.grbVote.Controls.Add(Me.RadioButton3)
        Me.grbVote.Controls.Add(Me.RadioButton2)
        Me.grbVote.Controls.Add(Me.RadioButton1)
        Me.grbVote.Location = New System.Drawing.Point(467, 168)
        Me.grbVote.Name = "grbVote"
        Me.grbVote.Size = New System.Drawing.Size(555, 418)
        Me.grbVote.TabIndex = 11
        Me.grbVote.TabStop = False
        Me.grbVote.Text = "grbVote"
        Me.grbVote.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(322, 27)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Vote for one of the following:"
        '
        'btnVoteOk
        '
        Me.btnVoteOk.BackColor = System.Drawing.Color.Maroon
        Me.btnVoteOk.Font = New System.Drawing.Font("Rockwell", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoteOk.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnVoteOk.Location = New System.Drawing.Point(460, 372)
        Me.btnVoteOk.Name = "btnVoteOk"
        Me.btnVoteOk.Size = New System.Drawing.Size(89, 40)
        Me.btnVoteOk.TabIndex = 11
        Me.btnVoteOk.Text = "OK"
        Me.btnVoteOk.UseVisualStyleBackColor = False
        '
        'lblVote1
        '
        Me.lblVote1.AutoSize = True
        Me.lblVote1.Font = New System.Drawing.Font("Matura MT Script Capitals", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVote1.Location = New System.Drawing.Point(6, 65)
        Me.lblVote1.Name = "lblVote1"
        Me.lblVote1.Size = New System.Drawing.Size(226, 32)
        Me.lblVote1.TabIndex = 6
        Me.lblVote1.Text = "1. Class President :"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Lucida Sans Typewriter", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(34, 160)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(180, 29)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Ahmad Jones"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Lucida Sans Typewriter", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(34, 127)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(219, 29)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Chloe Michelle"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Lucida Sans Typewriter", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(34, 97)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(193, 29)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Sarah Harris"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'frmVote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 589)
        Me.Controls.Add(Me.grbVote)
        Me.Controls.Add(Me.grbEnterToken)
        Me.Controls.Add(Me.grbLookup)
        Me.Controls.Add(Me.grbRegistration)
        Me.Name = "frmVote"
        Me.Text = "Vote"
        Me.grbRegistration.ResumeLayout(False)
        Me.grbRegistration.PerformLayout()
        Me.grbLookup.ResumeLayout(False)
        Me.grbLookup.PerformLayout()
        Me.grbEnterToken.ResumeLayout(False)
        Me.grbEnterToken.PerformLayout()
        Me.grbVote.ResumeLayout(False)
        Me.grbVote.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblSSN As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtSSNO As TextBox
    Friend WithEvents grbRegistration As GroupBox
    Friend WithEvents btnOK As Button
    Friend WithEvents lblRegistration As Label
    Friend WithEvents grbLookup As GroupBox
    Friend WithEvents lblForgotToken As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtSSNO2 As TextBox
    Friend WithEvents lblCity As Label
    Friend WithEvents lblSSNO2 As Label
    Friend WithEvents grbEnterToken As GroupBox
    Friend WithEvents btnTokenOk As Button
    Friend WithEvents txtEnterToken As TextBox
    Friend WithEvents lblEnterToken As Label
    Friend WithEvents grbVote As GroupBox
    Friend WithEvents lblVote1 As Label
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents btnLookupOk As Button
    Friend WithEvents btnVoteOk As Button
    Friend WithEvents btnForgot As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAddress As TextBox
End Class
