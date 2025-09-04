<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(AdminDashboard))
        SplitCon = New SplitContainer()
        btnSettings = New Button()
        Button1 = New Button()
        btnLogout = New Button()
        btnBorrowed = New Button()
        btnItems = New Button()
        btnUsers = New Button()
        Panel3 = New Panel()
        pbLogo = New PictureBox()
        Label3 = New Label()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        txtUsername = New Label()
        CType(SplitCon, ComponentModel.ISupportInitialize).BeginInit()
        SplitCon.Panel1.SuspendLayout()
        SplitCon.Panel2.SuspendLayout()
        SplitCon.SuspendLayout()
        Panel3.SuspendLayout()
        CType(pbLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SplitCon
        ' 
        SplitCon.Dock = DockStyle.Fill
        SplitCon.Location = New Point(0, 0)
        SplitCon.Name = "SplitCon"
        ' 
        ' SplitCon.Panel1
        ' 
        SplitCon.Panel1.BackColor = Color.FromArgb(7, 68, 56)
        SplitCon.Panel1.Controls.Add(btnSettings)
        SplitCon.Panel1.Controls.Add(txtUsername)
        SplitCon.Panel1.Controls.Add(Button1)
        SplitCon.Panel1.Controls.Add(btnLogout)
        SplitCon.Panel1.Controls.Add(btnBorrowed)
        SplitCon.Panel1.Controls.Add(btnItems)
        SplitCon.Panel1.Controls.Add(btnUsers)
        SplitCon.Panel1.Controls.Add(Panel3)
        ' 
        ' SplitCon.Panel2
        ' 
        SplitCon.Panel2.Controls.Add(Label3)
        SplitCon.Panel2.Controls.Add(Label1)
        SplitCon.Panel2.Controls.Add(TextBox1)
        SplitCon.Panel2.Controls.Add(Label2)
        SplitCon.Size = New Size(1902, 1033)
        SplitCon.SplitterDistance = 322
        SplitCon.TabIndex = 2
        ' 
        ' btnSettings
        ' 
        btnSettings.Dock = DockStyle.Top
        btnSettings.FlatAppearance.BorderSize = 0
        btnSettings.FlatStyle = FlatStyle.Flat
        btnSettings.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnSettings.ForeColor = Color.White
        btnSettings.Image = My.Resources.Resources.setting
        btnSettings.ImageAlign = ContentAlignment.MiddleLeft
        btnSettings.Location = New Point(0, 544)
        btnSettings.Name = "btnSettings"
        btnSettings.Padding = New Padding(15, 0, 0, 0)
        btnSettings.Size = New Size(322, 85)
        btnSettings.TabIndex = 17
        btnSettings.Text = "      Settings"
        btnSettings.TextAlign = ContentAlignment.MiddleLeft
        btnSettings.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Dock = DockStyle.Top
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Image = My.Resources.Resources._return
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(0, 459)
        Button1.Name = "Button1"
        Button1.Padding = New Padding(15, 0, 0, 0)
        Button1.Size = New Size(322, 85)
        Button1.TabIndex = 15
        Button1.Text = "      Returned"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnLogout.ForeColor = Color.White
        btnLogout.Image = My.Resources.Resources.logout
        btnLogout.ImageAlign = ContentAlignment.MiddleLeft
        btnLogout.Location = New Point(0, 948)
        btnLogout.Name = "btnLogout"
        btnLogout.Padding = New Padding(15, 0, 0, 0)
        btnLogout.Size = New Size(320, 85)
        btnLogout.TabIndex = 14
        btnLogout.Text = "      Logout"
        btnLogout.TextAlign = ContentAlignment.MiddleLeft
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnBorrowed
        ' 
        btnBorrowed.Dock = DockStyle.Top
        btnBorrowed.FlatAppearance.BorderSize = 0
        btnBorrowed.FlatStyle = FlatStyle.Flat
        btnBorrowed.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnBorrowed.ForeColor = Color.White
        btnBorrowed.Image = My.Resources.Resources.borrowed
        btnBorrowed.ImageAlign = ContentAlignment.MiddleLeft
        btnBorrowed.Location = New Point(0, 374)
        btnBorrowed.Name = "btnBorrowed"
        btnBorrowed.Padding = New Padding(15, 0, 0, 0)
        btnBorrowed.Size = New Size(322, 85)
        btnBorrowed.TabIndex = 13
        btnBorrowed.Text = "      Borrowed "
        btnBorrowed.TextAlign = ContentAlignment.MiddleLeft
        btnBorrowed.UseVisualStyleBackColor = True
        ' 
        ' btnItems
        ' 
        btnItems.Dock = DockStyle.Top
        btnItems.FlatAppearance.BorderSize = 0
        btnItems.FlatStyle = FlatStyle.Flat
        btnItems.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnItems.ForeColor = Color.White
        btnItems.Image = My.Resources.Resources.items
        btnItems.ImageAlign = ContentAlignment.MiddleLeft
        btnItems.Location = New Point(0, 289)
        btnItems.Name = "btnItems"
        btnItems.Padding = New Padding(15, 0, 0, 0)
        btnItems.Size = New Size(322, 85)
        btnItems.TabIndex = 12
        btnItems.Text = "      Inventory"
        btnItems.TextAlign = ContentAlignment.MiddleLeft
        btnItems.UseVisualStyleBackColor = True
        ' 
        ' btnUsers
        ' 
        btnUsers.Dock = DockStyle.Top
        btnUsers.FlatAppearance.BorderSize = 0
        btnUsers.FlatStyle = FlatStyle.Flat
        btnUsers.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnUsers.ForeColor = Color.White
        btnUsers.Image = My.Resources.Resources.username
        btnUsers.ImageAlign = ContentAlignment.MiddleLeft
        btnUsers.Location = New Point(0, 204)
        btnUsers.Name = "btnUsers"
        btnUsers.Padding = New Padding(15, 0, 0, 0)
        btnUsers.Size = New Size(322, 85)
        btnUsers.TabIndex = 11
        btnUsers.Text = "      Users"
        btnUsers.TextAlign = ContentAlignment.MiddleLeft
        btnUsers.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.BackgroundImageLayout = ImageLayout.Zoom
        Panel3.Controls.Add(pbLogo)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(322, 204)
        Panel3.TabIndex = 10
        ' 
        ' pbLogo
        ' 
        pbLogo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pbLogo.Image = My.Resources.Resources.logo_debestmscat
        pbLogo.Location = New Point(31, 29)
        pbLogo.Name = "pbLogo"
        pbLogo.Size = New Size(264, 139)
        pbLogo.SizeMode = PictureBoxSizeMode.Zoom
        pbLogo.TabIndex = 0
        pbLogo.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe Script", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(9, 96, 79)
        Label3.Location = New Point(1333, 977)
        Label3.Name = "Label3"
        Label3.Size = New Size(220, 32)
        Label3.TabIndex = 11
        Label3.Text = "Freddie G. Alicante"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(9, 96, 79)
        Label1.Location = New Point(1190, 949)
        Label1.Name = "Label1"
        Label1.Size = New Size(137, 28)
        Label1.TabIndex = 10
        Label1.Text = "Developed By:"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.Control
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.ForeColor = Color.FromArgb(9, 96, 79)
        TextBox1.Location = New Point(249, 298)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(1127, 421)
        TextBox1.TabIndex = 9
        TextBox1.Text = resources.GetString("TextBox1.Text")
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe Print", 28.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(9, 96, 79)
        Label2.Location = New Point(410, 186)
        Label2.Name = "Label2"
        Label2.Size = New Size(824, 84)
        Label2.TabIndex = 8
        Label2.Text = "Keeper Hub Management System"
        ' 
        ' txtUsername
        ' 
        txtUsername.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        txtUsername.AutoSize = True
        txtUsername.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtUsername.ForeColor = Color.FromArgb(9, 96, 79)
        txtUsername.Location = New Point(22, 835)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(74, 28)
        txtUsername.TabIndex = 10
        txtUsername.Text = "Role ID"
        txtUsername.Visible = False
        ' 
        ' AdminDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1902, 1033)
        ControlBox = False
        Controls.Add(SplitCon)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "AdminDashboard"
        WindowState = FormWindowState.Maximized
        SplitCon.Panel1.ResumeLayout(False)
        SplitCon.Panel1.PerformLayout()
        SplitCon.Panel2.ResumeLayout(False)
        SplitCon.Panel2.PerformLayout()
        CType(SplitCon, ComponentModel.ISupportInitialize).EndInit()
        SplitCon.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        CType(pbLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents SplitCon As SplitContainer
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnBorrowed As Button
    Friend WithEvents btnItems As Button
    Friend WithEvents btnUsers As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents btnSettings As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsername As Label
End Class
