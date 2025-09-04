<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profile
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
        Panel1 = New Panel()
        Label2 = New Label()
        btnChangePass = New Button()
        txtRoleID = New TextBox()
        lbRoleID = New Label()
        cbCP3 = New CheckBox()
        txtConfirmPass = New TextBox()
        cbNP2 = New CheckBox()
        txtNewPass = New TextBox()
        lbConfirmPassword = New Label()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        Label3 = New Label()
        cbCP1 = New CheckBox()
        txtCurrentPass = New TextBox()
        lbStatus = New Label()
        lbFullName = New Label()
        lbDepart = New Label()
        txtDepart = New TextBox()
        txtFullName = New TextBox()
        lbGender = New Label()
        txtGender = New TextBox()
        txtStatus = New TextBox()
        lbPassword = New Label()
        txtPassword = New TextBox()
        GroupBox1 = New GroupBox()
        Panel1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        Panel1.Controls.Add(Label2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1387, 123)
        Panel1.TabIndex = 108
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(625, 30)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 54)
        Label2.TabIndex = 100
        Label2.Text = "Profile"
        ' 
        ' btnChangePass
        ' 
        btnChangePass.BackColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        btnChangePass.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnChangePass.ForeColor = Color.White
        btnChangePass.Location = New Point(351, 257)
        btnChangePass.Margin = New Padding(4, 3, 4, 3)
        btnChangePass.Name = "btnChangePass"
        btnChangePass.Size = New Size(238, 55)
        btnChangePass.TabIndex = 6
        btnChangePass.Text = "Change Password"
        btnChangePass.UseVisualStyleBackColor = False
        ' 
        ' txtRoleID
        ' 
        txtRoleID.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtRoleID.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        txtRoleID.ForeColor = Color.FromArgb(CByte(7), CByte(68), CByte(56))
        txtRoleID.Location = New Point(192, 179)
        txtRoleID.Margin = New Padding(4, 3, 4, 3)
        txtRoleID.Name = "txtRoleID"
        txtRoleID.ReadOnly = True
        txtRoleID.Size = New Size(166, 30)
        txtRoleID.TabIndex = 117
        ' 
        ' lbRoleID
        ' 
        lbRoleID.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        lbRoleID.AutoSize = True
        lbRoleID.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbRoleID.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        lbRoleID.Location = New Point(42, 183)
        lbRoleID.Margin = New Padding(4, 0, 4, 0)
        lbRoleID.Name = "lbRoleID"
        lbRoleID.Size = New Size(86, 23)
        lbRoleID.TabIndex = 121
        lbRoleID.Text = "Faculty ID"
        ' 
        ' cbCP3
        ' 
        cbCP3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        cbCP3.Appearance = Appearance.Button
        cbCP3.AutoSize = True
        cbCP3.BackColor = Color.White
        cbCP3.BackgroundImage = My.Resources.Resources.unhide
        cbCP3.BackgroundImageLayout = ImageLayout.Zoom
        cbCP3.FlatAppearance.BorderSize = 0
        cbCP3.FlatStyle = FlatStyle.Flat
        cbCP3.Font = New Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point)
        cbCP3.Location = New Point(517, 186)
        cbCP3.Name = "cbCP3"
        cbCP3.Size = New Size(29, 25)
        cbCP3.TabIndex = 5
        cbCP3.Text = "    "
        cbCP3.UseVisualStyleBackColor = False
        ' 
        ' txtConfirmPass
        ' 
        txtConfirmPass.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        txtConfirmPass.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        txtConfirmPass.ForeColor = Color.FromArgb(CByte(7), CByte(68), CByte(56))
        txtConfirmPass.Location = New Point(229, 183)
        txtConfirmPass.Name = "txtConfirmPass"
        txtConfirmPass.Size = New Size(322, 30)
        txtConfirmPass.TabIndex = 4
        ' 
        ' cbNP2
        ' 
        cbNP2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        cbNP2.Appearance = Appearance.Button
        cbNP2.AutoSize = True
        cbNP2.BackColor = Color.White
        cbNP2.BackgroundImage = My.Resources.Resources.unhide
        cbNP2.BackgroundImageLayout = ImageLayout.Zoom
        cbNP2.FlatAppearance.BorderSize = 0
        cbNP2.FlatStyle = FlatStyle.Flat
        cbNP2.Font = New Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point)
        cbNP2.Location = New Point(517, 135)
        cbNP2.Name = "cbNP2"
        cbNP2.Size = New Size(29, 25)
        cbNP2.TabIndex = 3
        cbNP2.Text = "    "
        cbNP2.UseVisualStyleBackColor = False
        ' 
        ' txtNewPass
        ' 
        txtNewPass.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        txtNewPass.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        txtNewPass.ForeColor = Color.FromArgb(CByte(7), CByte(68), CByte(56))
        txtNewPass.Location = New Point(229, 132)
        txtNewPass.Name = "txtNewPass"
        txtNewPass.Size = New Size(322, 30)
        txtNewPass.TabIndex = 2
        ' 
        ' lbConfirmPassword
        ' 
        lbConfirmPassword.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        lbConfirmPassword.AutoSize = True
        lbConfirmPassword.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbConfirmPassword.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        lbConfirmPassword.Location = New Point(48, 186)
        lbConfirmPassword.Name = "lbConfirmPassword"
        lbConfirmPassword.Size = New Size(149, 23)
        lbConfirmPassword.TabIndex = 133
        lbConfirmPassword.Text = "Confirm Password"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label1.Location = New Point(75, 135)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 23)
        Label1.TabIndex = 132
        Label1.Text = "New Password"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(cbCP1)
        GroupBox2.Controls.Add(txtCurrentPass)
        GroupBox2.Controls.Add(cbCP3)
        GroupBox2.Controls.Add(txtConfirmPass)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(cbNP2)
        GroupBox2.Controls.Add(lbConfirmPassword)
        GroupBox2.Controls.Add(btnChangePass)
        GroupBox2.Controls.Add(txtNewPass)
        GroupBox2.ForeColor = Color.FromArgb(CByte(7), CByte(68), CByte(56))
        GroupBox2.Location = New Point(844, 268)
        GroupBox2.Margin = New Padding(4, 3, 4, 3)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(4, 3, 4, 3)
        GroupBox2.Size = New Size(628, 389)
        GroupBox2.TabIndex = 131
        GroupBox2.TabStop = False
        GroupBox2.Text = "Change Password"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label3.Location = New Point(52, 81)
        Label3.Name = "Label3"
        Label3.Size = New Size(145, 23)
        Label3.TabIndex = 136
        Label3.Text = "Current Password"
        ' 
        ' cbCP1
        ' 
        cbCP1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        cbCP1.Appearance = Appearance.Button
        cbCP1.AutoSize = True
        cbCP1.BackColor = Color.White
        cbCP1.BackgroundImage = My.Resources.Resources.unhide
        cbCP1.BackgroundImageLayout = ImageLayout.Zoom
        cbCP1.FlatAppearance.BorderSize = 0
        cbCP1.FlatStyle = FlatStyle.Flat
        cbCP1.Font = New Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point)
        cbCP1.Location = New Point(517, 81)
        cbCP1.Name = "cbCP1"
        cbCP1.Size = New Size(29, 25)
        cbCP1.TabIndex = 1
        cbCP1.Text = "    "
        cbCP1.UseVisualStyleBackColor = False
        ' 
        ' txtCurrentPass
        ' 
        txtCurrentPass.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        txtCurrentPass.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        txtCurrentPass.ForeColor = Color.FromArgb(CByte(7), CByte(68), CByte(56))
        txtCurrentPass.Location = New Point(229, 78)
        txtCurrentPass.Name = "txtCurrentPass"
        txtCurrentPass.Size = New Size(322, 30)
        txtCurrentPass.TabIndex = 0
        ' 
        ' lbStatus
        ' 
        lbStatus.AutoSize = True
        lbStatus.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbStatus.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        lbStatus.Location = New Point(79, 112)
        lbStatus.Margin = New Padding(4, 0, 4, 0)
        lbStatus.Name = "lbStatus"
        lbStatus.Size = New Size(57, 23)
        lbStatus.TabIndex = 107
        lbStatus.Text = "Status"
        ' 
        ' lbFullName
        ' 
        lbFullName.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        lbFullName.AutoSize = True
        lbFullName.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbFullName.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        lbFullName.Location = New Point(79, 54)
        lbFullName.Margin = New Padding(4, 0, 4, 0)
        lbFullName.Name = "lbFullName"
        lbFullName.Size = New Size(88, 23)
        lbFullName.TabIndex = 122
        lbFullName.Text = "Full Name"
        ' 
        ' lbDepart
        ' 
        lbDepart.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        lbDepart.AutoSize = True
        lbDepart.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbDepart.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        lbDepart.Location = New Point(79, 239)
        lbDepart.Margin = New Padding(4, 0, 4, 0)
        lbDepart.Name = "lbDepart"
        lbDepart.Size = New Size(102, 23)
        lbDepart.TabIndex = 123
        lbDepart.Text = "Department"
        ' 
        ' txtDepart
        ' 
        txtDepart.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtDepart.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        txtDepart.ForeColor = Color.FromArgb(CByte(7), CByte(68), CByte(56))
        txtDepart.Location = New Point(229, 236)
        txtDepart.Margin = New Padding(4, 3, 4, 3)
        txtDepart.Name = "txtDepart"
        txtDepart.ReadOnly = True
        txtDepart.Size = New Size(322, 30)
        txtDepart.TabIndex = 121
        ' 
        ' txtFullName
        ' 
        txtFullName.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtFullName.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        txtFullName.ForeColor = Color.FromArgb(CByte(7), CByte(68), CByte(56))
        txtFullName.Location = New Point(229, 51)
        txtFullName.Margin = New Padding(4, 3, 4, 3)
        txtFullName.Name = "txtFullName"
        txtFullName.ReadOnly = True
        txtFullName.Size = New Size(322, 30)
        txtFullName.TabIndex = 118
        ' 
        ' lbGender
        ' 
        lbGender.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        lbGender.AutoSize = True
        lbGender.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbGender.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        lbGender.Location = New Point(78, 176)
        lbGender.Margin = New Padding(4, 0, 4, 0)
        lbGender.Name = "lbGender"
        lbGender.Size = New Size(66, 23)
        lbGender.TabIndex = 124
        lbGender.Text = "Gender"
        ' 
        ' txtGender
        ' 
        txtGender.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtGender.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        txtGender.ForeColor = Color.FromArgb(CByte(7), CByte(68), CByte(56))
        txtGender.Location = New Point(229, 176)
        txtGender.Margin = New Padding(4, 3, 4, 3)
        txtGender.Name = "txtGender"
        txtGender.ReadOnly = True
        txtGender.Size = New Size(322, 30)
        txtGender.TabIndex = 120
        ' 
        ' txtStatus
        ' 
        txtStatus.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtStatus.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        txtStatus.ForeColor = Color.FromArgb(CByte(7), CByte(68), CByte(56))
        txtStatus.Location = New Point(229, 112)
        txtStatus.Margin = New Padding(4, 3, 4, 3)
        txtStatus.Name = "txtStatus"
        txtStatus.ReadOnly = True
        txtStatus.Size = New Size(322, 30)
        txtStatus.TabIndex = 119
        ' 
        ' lbPassword
        ' 
        lbPassword.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        lbPassword.AutoSize = True
        lbPassword.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbPassword.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        lbPassword.Location = New Point(78, 299)
        lbPassword.Margin = New Padding(4, 0, 4, 0)
        lbPassword.Name = "lbPassword"
        lbPassword.Size = New Size(82, 23)
        lbPassword.TabIndex = 129
        lbPassword.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtPassword.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        txtPassword.ForeColor = Color.FromArgb(CByte(7), CByte(68), CByte(56))
        txtPassword.Location = New Point(229, 299)
        txtPassword.Margin = New Padding(4, 3, 4, 3)
        txtPassword.Name = "txtPassword"
        txtPassword.ReadOnly = True
        txtPassword.Size = New Size(322, 30)
        txtPassword.TabIndex = 130
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtPassword)
        GroupBox1.Controls.Add(lbPassword)
        GroupBox1.Controls.Add(txtStatus)
        GroupBox1.Controls.Add(txtGender)
        GroupBox1.Controls.Add(lbGender)
        GroupBox1.Controls.Add(txtFullName)
        GroupBox1.Controls.Add(txtDepart)
        GroupBox1.Controls.Add(lbDepart)
        GroupBox1.Controls.Add(lbFullName)
        GroupBox1.Controls.Add(lbStatus)
        GroupBox1.ForeColor = Color.FromArgb(CByte(7), CByte(68), CByte(56))
        GroupBox1.Location = New Point(42, 268)
        GroupBox1.Margin = New Padding(4, 3, 4, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 3, 4, 3)
        GroupBox1.Size = New Size(628, 389)
        GroupBox1.TabIndex = 127
        GroupBox1.TabStop = False
        GroupBox1.Text = "Personal Information"
        ' 
        ' Profile
        ' 
        AutoScaleDimensions = New SizeF(10F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1387, 1084)
        ControlBox = False
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Panel1)
        Controls.Add(txtRoleID)
        Controls.Add(lbRoleID)
        Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        ForeColor = Color.FromArgb(CByte(7), CByte(68), CByte(56))
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4, 3, 4, 3)
        Name = "Profile"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnChangePass As Button
    Friend WithEvents txtRoleID As TextBox
    Friend WithEvents lbRoleID As Label
    Friend WithEvents cbCP3 As CheckBox
    Friend WithEvents txtConfirmPass As TextBox
    Friend WithEvents cbNP2 As CheckBox
    Friend WithEvents txtNewPass As TextBox
    Friend WithEvents lbConfirmPassword As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbCP1 As CheckBox
    Friend WithEvents txtCurrentPass As TextBox
    Friend WithEvents lbStatus As Label
    Friend WithEvents lbFullName As Label
    Friend WithEvents lbDepart As Label
    Friend WithEvents txtDepart As TextBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents lbGender As Label
    Friend WithEvents txtGender As TextBox
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents lbPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
