<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginDashboard
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
        SplitContainer1 = New SplitContainer()
        pbLogo = New PictureBox()
        lbAvailableItems = New Label()
        Label2 = New Label()
        btnSignUp = New Button()
        cbHide = New CheckBox()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        lbExit = New Label()
        btnLogin = New Button()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(pbLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(pbLogo)
        SplitContainer1.Panel1.Controls.Add(lbAvailableItems)
        SplitContainer1.Panel1.Controls.Add(Label2)
        SplitContainer1.Panel1.Controls.Add(btnSignUp)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.BackColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        SplitContainer1.Panel2.Controls.Add(cbHide)
        SplitContainer1.Panel2.Controls.Add(PictureBox2)
        SplitContainer1.Panel2.Controls.Add(PictureBox1)
        SplitContainer1.Panel2.Controls.Add(lbExit)
        SplitContainer1.Panel2.Controls.Add(btnLogin)
        SplitContainer1.Panel2.Controls.Add(txtPassword)
        SplitContainer1.Panel2.Controls.Add(txtUsername)
        SplitContainer1.Size = New Size(1094, 493)
        SplitContainer1.SplitterDistance = 676
        SplitContainer1.TabIndex = 0
        ' 
        ' pbLogo
        ' 
        pbLogo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pbLogo.Image = My.Resources.Resources.logo_debestmscat
        pbLogo.Location = New Point(256, 29)
        pbLogo.Name = "pbLogo"
        pbLogo.Size = New Size(157, 139)
        pbLogo.SizeMode = PictureBoxSizeMode.Zoom
        pbLogo.TabIndex = 1
        pbLogo.TabStop = False
        ' 
        ' lbAvailableItems
        ' 
        lbAvailableItems.AutoSize = True
        lbAvailableItems.Font = New Font("Segoe UI", 10.2F, FontStyle.Underline, GraphicsUnit.Point)
        lbAvailableItems.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        lbAvailableItems.Location = New Point(276, 381)
        lbAvailableItems.Name = "lbAvailableItems"
        lbAvailableItems.Size = New Size(125, 23)
        lbAvailableItems.TabIndex = 13
        lbAvailableItems.Text = "Available Items"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        Label2.Location = New Point(69, 185)
        Label2.Name = "Label2"
        Label2.Size = New Size(529, 54)
        Label2.TabIndex = 7
        Label2.Text = "Keeper Hub Management System"
        ' 
        ' btnSignUp
        ' 
        btnSignUp.BackColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        btnSignUp.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnSignUp.ForeColor = Color.White
        btnSignUp.Location = New Point(256, 333)
        btnSignUp.Name = "btnSignUp"
        btnSignUp.Size = New Size(157, 45)
        btnSignUp.TabIndex = 4
        btnSignUp.Text = "Sign Up"
        btnSignUp.UseVisualStyleBackColor = False
        ' 
        ' cbHide
        ' 
        cbHide.Appearance = Appearance.Button
        cbHide.AutoSize = True
        cbHide.BackColor = Color.White
        cbHide.BackgroundImage = My.Resources.Resources.unhide
        cbHide.BackgroundImageLayout = ImageLayout.Zoom
        cbHide.FlatAppearance.BorderSize = 0
        cbHide.FlatStyle = FlatStyle.Flat
        cbHide.Font = New Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point)
        cbHide.Location = New Point(351, 228)
        cbHide.Name = "cbHide"
        cbHide.Size = New Size(29, 25)
        cbHide.TabIndex = 2
        cbHide.Text = "    "
        cbHide.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.password
        PictureBox2.Location = New Point(36, 227)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(36, 27)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 12
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.username
        PictureBox1.Location = New Point(36, 171)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(36, 27)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' lbExit
        ' 
        lbExit.AutoSize = True
        lbExit.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lbExit.ForeColor = Color.White
        lbExit.Location = New Point(206, 409)
        lbExit.Name = "lbExit"
        lbExit.Size = New Size(37, 23)
        lbExit.TabIndex = 5
        lbExit.Text = "Exit"
        ' 
        ' btnLogin
        ' 
        btnLogin.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnLogin.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        btnLogin.Location = New Point(145, 346)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(157, 45)
        btnLogin.TabIndex = 3
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' txtPassword
        ' 
        txtPassword.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        txtPassword.Location = New Point(78, 227)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(303, 27)
        txtPassword.TabIndex = 1
        ' 
        ' txtUsername
        ' 
        txtUsername.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        txtUsername.Location = New Point(78, 171)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(303, 27)
        txtUsername.TabIndex = 0
        ' 
        ' LoginDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1094, 493)
        Controls.Add(SplitContainer1)
        FormBorderStyle = FormBorderStyle.None
        Name = "LoginDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoginDashboard"
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.PerformLayout()
        SplitContainer1.Panel2.ResumeLayout(False)
        SplitContainer1.Panel2.PerformLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        CType(pbLogo, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSignUp As Button
    Friend WithEvents cbHide As CheckBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbExit As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lbAvailableItems As Label
    Friend WithEvents pbLogo As PictureBox
End Class
