<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
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
        Label2 = New Label()
        btnSubmit = New Button()
        GroupBox1 = New GroupBox()
        lbGender = New Label()
        cmbGender = New ComboBox()
        cbConfirmPass = New CheckBox()
        txtRoleID = New TextBox()
        txtFullName = New TextBox()
        txtConfirmPassword = New TextBox()
        txtDepart = New TextBox()
        lbRoleID = New Label()
        cbPassword = New CheckBox()
        lbStatus = New Label()
        txtPassword = New TextBox()
        lbFullName = New Label()
        lbConfirmPassword = New Label()
        lbPassword = New Label()
        Panel1 = New Panel()
        Label5 = New Label()
        cmbStatus = New ComboBox()
        lbExit = New Label()
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(363, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(142, 54)
        Label2.TabIndex = 100
        Label2.Text = "Sign Up"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnSubmit.BackColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        btnSubmit.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnSubmit.ForeColor = Color.White
        btnSubmit.Location = New Point(558, 596)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(267, 58)
        btnSubmit.TabIndex = 9
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        GroupBox1.Controls.Add(lbGender)
        GroupBox1.Controls.Add(cmbGender)
        GroupBox1.Controls.Add(cbConfirmPass)
        GroupBox1.Controls.Add(txtRoleID)
        GroupBox1.Controls.Add(txtFullName)
        GroupBox1.Controls.Add(txtConfirmPassword)
        GroupBox1.Controls.Add(txtDepart)
        GroupBox1.Controls.Add(lbRoleID)
        GroupBox1.Controls.Add(cbPassword)
        GroupBox1.Controls.Add(lbStatus)
        GroupBox1.Controls.Add(txtPassword)
        GroupBox1.Controls.Add(lbFullName)
        GroupBox1.Controls.Add(lbConfirmPassword)
        GroupBox1.Controls.Add(lbPassword)
        GroupBox1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        GroupBox1.Location = New Point(24, 221)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(801, 354)
        GroupBox1.TabIndex = 104
        GroupBox1.TabStop = False
        GroupBox1.Text = "Personal Information"
        ' 
        ' lbGender
        ' 
        lbGender.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        lbGender.AutoSize = True
        lbGender.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbGender.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        lbGender.Location = New Point(32, 171)
        lbGender.Name = "lbGender"
        lbGender.Size = New Size(66, 23)
        lbGender.TabIndex = 116
        lbGender.Text = "Gender"
        ' 
        ' cmbGender
        ' 
        cmbGender.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        cmbGender.AutoCompleteMode = AutoCompleteMode.Append
        cmbGender.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbGender.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        cmbGender.FormattingEnabled = True
        cmbGender.Items.AddRange(New Object() {"Male", "Female", "Others"})
        cmbGender.Location = New Point(153, 168)
        cmbGender.Name = "cmbGender"
        cmbGender.Size = New Size(213, 31)
        cmbGender.TabIndex = 3
        ' 
        ' cbConfirmPass
        ' 
        cbConfirmPass.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        cbConfirmPass.Appearance = Appearance.Button
        cbConfirmPass.AutoSize = True
        cbConfirmPass.BackColor = Color.White
        cbConfirmPass.BackgroundImage = My.Resources.Resources.unhide
        cbConfirmPass.BackgroundImageLayout = ImageLayout.Zoom
        cbConfirmPass.FlatAppearance.BorderSize = 0
        cbConfirmPass.FlatStyle = FlatStyle.Flat
        cbConfirmPass.Font = New Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point)
        cbConfirmPass.Location = New Point(718, 119)
        cbConfirmPass.Name = "cbConfirmPass"
        cbConfirmPass.Size = New Size(29, 25)
        cbConfirmPass.TabIndex = 8
        cbConfirmPass.Text = "    "
        cbConfirmPass.UseVisualStyleBackColor = False
        ' 
        ' txtRoleID
        ' 
        txtRoleID.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtRoleID.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtRoleID.Location = New Point(152, 62)
        txtRoleID.Name = "txtRoleID"
        txtRoleID.Size = New Size(214, 30)
        txtRoleID.TabIndex = 1
        ' 
        ' txtFullName
        ' 
        txtFullName.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtFullName.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtFullName.Location = New Point(152, 112)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(214, 30)
        txtFullName.TabIndex = 2
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        txtConfirmPassword.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        txtConfirmPassword.Location = New Point(558, 115)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(193, 30)
        txtConfirmPassword.TabIndex = 7
        ' 
        ' txtDepart
        ' 
        txtDepart.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtDepart.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtDepart.Location = New Point(153, 223)
        txtDepart.Name = "txtDepart"
        txtDepart.Size = New Size(214, 30)
        txtDepart.TabIndex = 4
        ' 
        ' lbRoleID
        ' 
        lbRoleID.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        lbRoleID.AutoSize = True
        lbRoleID.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbRoleID.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        lbRoleID.Location = New Point(33, 65)
        lbRoleID.Name = "lbRoleID"
        lbRoleID.Size = New Size(86, 23)
        lbRoleID.TabIndex = 105
        lbRoleID.Text = "Faculty ID"
        ' 
        ' cbPassword
        ' 
        cbPassword.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        cbPassword.Appearance = Appearance.Button
        cbPassword.AutoSize = True
        cbPassword.BackColor = Color.White
        cbPassword.BackgroundImage = My.Resources.Resources.unhide
        cbPassword.BackgroundImageLayout = ImageLayout.Zoom
        cbPassword.FlatAppearance.BorderSize = 0
        cbPassword.FlatStyle = FlatStyle.Flat
        cbPassword.Font = New Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point)
        cbPassword.Location = New Point(718, 66)
        cbPassword.Name = "cbPassword"
        cbPassword.Size = New Size(29, 25)
        cbPassword.TabIndex = 6
        cbPassword.Text = "    "
        cbPassword.UseVisualStyleBackColor = False
        ' 
        ' lbStatus
        ' 
        lbStatus.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        lbStatus.AutoSize = True
        lbStatus.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbStatus.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        lbStatus.Location = New Point(33, 226)
        lbStatus.Name = "lbStatus"
        lbStatus.Size = New Size(102, 23)
        lbStatus.TabIndex = 107
        lbStatus.Text = "Department"
        ' 
        ' txtPassword
        ' 
        txtPassword.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        txtPassword.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        txtPassword.Location = New Point(558, 63)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(193, 30)
        txtPassword.TabIndex = 5
        ' 
        ' lbFullName
        ' 
        lbFullName.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        lbFullName.AutoSize = True
        lbFullName.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbFullName.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        lbFullName.Location = New Point(33, 115)
        lbFullName.Name = "lbFullName"
        lbFullName.Size = New Size(88, 23)
        lbFullName.TabIndex = 106
        lbFullName.Text = "Full Name"
        ' 
        ' lbConfirmPassword
        ' 
        lbConfirmPassword.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        lbConfirmPassword.AutoSize = True
        lbConfirmPassword.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbConfirmPassword.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        lbConfirmPassword.Location = New Point(400, 119)
        lbConfirmPassword.Name = "lbConfirmPassword"
        lbConfirmPassword.Size = New Size(149, 23)
        lbConfirmPassword.TabIndex = 111
        lbConfirmPassword.Text = "Confirm Password"
        ' 
        ' lbPassword
        ' 
        lbPassword.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        lbPassword.AutoSize = True
        lbPassword.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbPassword.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        lbPassword.Location = New Point(461, 68)
        lbPassword.Name = "lbPassword"
        lbPassword.Size = New Size(82, 23)
        lbPassword.TabIndex = 109
        lbPassword.Text = "Password"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        Panel1.Controls.Add(Label2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(851, 107)
        Panel1.TabIndex = 103
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        Label5.Location = New Point(29, 148)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 23)
        Label5.TabIndex = 102
        Label5.Text = "Status"
        ' 
        ' cmbStatus
        ' 
        cmbStatus.AutoCompleteMode = AutoCompleteMode.Append
        cmbStatus.AutoCompleteSource = AutoCompleteSource.ListItems
        cmbStatus.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        cmbStatus.FormattingEnabled = True
        cmbStatus.Items.AddRange(New Object() {"Faculty", "Student"})
        cmbStatus.Location = New Point(103, 143)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(146, 28)
        cmbStatus.TabIndex = 0
        ' 
        ' lbExit
        ' 
        lbExit.AutoSize = True
        lbExit.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        lbExit.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        lbExit.Location = New Point(29, 607)
        lbExit.Name = "lbExit"
        lbExit.Size = New Size(208, 23)
        lbExit.TabIndex = 106
        lbExit.Text = "I have already an account"
        ' 
        ' SignUp
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(851, 701)
        Controls.Add(lbExit)
        Controls.Add(btnSubmit)
        Controls.Add(GroupBox1)
        Controls.Add(Panel1)
        Controls.Add(Label5)
        Controls.Add(cmbStatus)
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(1057, 801)
        MinimumSize = New Size(851, 701)
        Name = "SignUp"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AddUser"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbRoleID As Label
    Friend WithEvents lbStatus As Label
    Friend WithEvents lbFullName As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents lbPassword As Label
    Friend WithEvents txtRoleID As TextBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtDepart As TextBox
    Friend WithEvents lbConfirmPassword As Label
    Friend WithEvents cbConfirmPass As CheckBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents cbPassword As CheckBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents lbGender As Label
    Friend WithEvents lbExit As Label
End Class
