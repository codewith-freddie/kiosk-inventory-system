<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserDashboard
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(UserDashboard))
        btnLogout = New Button()
        Panel3 = New Panel()
        PictureBox1 = New PictureBox()
        btnUsers = New Button()
        btnItems = New Button()
        btnBorrowed = New Button()
        SplitCon = New SplitContainer()
        Label3 = New Label()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        lbUserID = New Label()
        lbRoleID = New Label()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(SplitCon, ComponentModel.ISupportInitialize).BeginInit()
        SplitCon.Panel1.SuspendLayout()
        SplitCon.Panel2.SuspendLayout()
        SplitCon.SuspendLayout()
        SuspendLayout()
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
        btnLogout.Location = New Point(1, 948)
        btnLogout.Name = "btnLogout"
        btnLogout.Padding = New Padding(15, 0, 0, 0)
        btnLogout.Size = New Size(324, 85)
        btnLogout.TabIndex = 19
        btnLogout.Text = "      Logout"
        btnLogout.TextAlign = ContentAlignment.MiddleLeft
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel3.BackgroundImageLayout = ImageLayout.Zoom
        Panel3.Controls.Add(PictureBox1)
        Panel3.Location = New Point(1, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(324, 204)
        Panel3.TabIndex = 15
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.Image = My.Resources.Resources.logo_debestmscat
        PictureBox1.Location = New Point(31, 29)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(261, 139)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' btnUsers
        ' 
        btnUsers.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnUsers.FlatAppearance.BorderSize = 0
        btnUsers.FlatStyle = FlatStyle.Flat
        btnUsers.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnUsers.ForeColor = Color.White
        btnUsers.Image = My.Resources.Resources.username
        btnUsers.ImageAlign = ContentAlignment.MiddleLeft
        btnUsers.Location = New Point(1, 204)
        btnUsers.Name = "btnUsers"
        btnUsers.Padding = New Padding(15, 0, 0, 0)
        btnUsers.Size = New Size(324, 85)
        btnUsers.TabIndex = 16
        btnUsers.Text = "      Profile"
        btnUsers.TextAlign = ContentAlignment.MiddleLeft
        btnUsers.UseVisualStyleBackColor = True
        ' 
        ' btnItems
        ' 
        btnItems.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnItems.FlatAppearance.BorderSize = 0
        btnItems.FlatStyle = FlatStyle.Flat
        btnItems.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnItems.ForeColor = Color.White
        btnItems.Image = My.Resources.Resources.items
        btnItems.ImageAlign = ContentAlignment.MiddleLeft
        btnItems.Location = New Point(1, 289)
        btnItems.Name = "btnItems"
        btnItems.Padding = New Padding(15, 0, 0, 0)
        btnItems.Size = New Size(324, 85)
        btnItems.TabIndex = 17
        btnItems.Text = "      Inventory"
        btnItems.TextAlign = ContentAlignment.MiddleLeft
        btnItems.UseVisualStyleBackColor = True
        ' 
        ' btnBorrowed
        ' 
        btnBorrowed.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnBorrowed.FlatAppearance.BorderSize = 0
        btnBorrowed.FlatStyle = FlatStyle.Flat
        btnBorrowed.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnBorrowed.ForeColor = Color.White
        btnBorrowed.Image = My.Resources.Resources.borrowed
        btnBorrowed.ImageAlign = ContentAlignment.MiddleLeft
        btnBorrowed.Location = New Point(1, 374)
        btnBorrowed.Name = "btnBorrowed"
        btnBorrowed.Padding = New Padding(15, 0, 0, 0)
        btnBorrowed.Size = New Size(324, 85)
        btnBorrowed.TabIndex = 18
        btnBorrowed.Text = "      Borrowed"
        btnBorrowed.TextAlign = ContentAlignment.MiddleLeft
        btnBorrowed.UseVisualStyleBackColor = True
        ' 
        ' SplitCon
        ' 
        SplitCon.Dock = DockStyle.Fill
        SplitCon.Location = New Point(0, 0)
        SplitCon.Name = "SplitCon"
        ' 
        ' SplitCon.Panel1
        ' 
        SplitCon.Panel1.BackColor = Color.FromArgb(CByte(7), CByte(68), CByte(56))
        SplitCon.Panel1.Controls.Add(btnBorrowed)
        SplitCon.Panel1.Controls.Add(btnItems)
        SplitCon.Panel1.Controls.Add(btnUsers)
        SplitCon.Panel1.Controls.Add(Panel3)
        SplitCon.Panel1.Controls.Add(btnLogout)
        ' 
        ' SplitCon.Panel2
        ' 
        SplitCon.Panel2.Controls.Add(Label3)
        SplitCon.Panel2.Controls.Add(Label1)
        SplitCon.Panel2.Controls.Add(TextBox1)
        SplitCon.Panel2.Controls.Add(Label2)
        SplitCon.Panel2.Controls.Add(lbUserID)
        SplitCon.Panel2.Controls.Add(lbRoleID)
        SplitCon.Size = New Size(1902, 1033)
        SplitCon.SplitterDistance = 327
        SplitCon.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe Script", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        Label3.Location = New Point(1326, 966)
        Label3.Name = "Label3"
        Label3.Size = New Size(220, 32)
        Label3.TabIndex = 127
        Label3.Text = "Freddie G. Alicante"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        Label1.Location = New Point(1183, 938)
        Label1.Name = "Label1"
        Label1.Size = New Size(137, 28)
        Label1.TabIndex = 126
        Label1.Text = "Developed By:"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.Control
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        TextBox1.Location = New Point(248, 298)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(1127, 480)
        TextBox1.TabIndex = 125
        TextBox1.Text = resources.GetString("TextBox1.Text")
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe Print", 28.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        Label2.Location = New Point(410, 186)
        Label2.Name = "Label2"
        Label2.Size = New Size(824, 84)
        Label2.TabIndex = 124
        Label2.Text = "Keeper Hub Management System"
        ' 
        ' lbUserID
        ' 
        lbUserID.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        lbUserID.AutoSize = True
        lbUserID.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbUserID.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        lbUserID.Location = New Point(124, 20)
        lbUserID.Margin = New Padding(4, 0, 4, 0)
        lbUserID.Name = "lbUserID"
        lbUserID.Size = New Size(66, 23)
        lbUserID.TabIndex = 123
        lbUserID.Text = "User ID"
        lbUserID.Visible = False
        ' 
        ' lbRoleID
        ' 
        lbRoleID.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        lbRoleID.AutoSize = True
        lbRoleID.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbRoleID.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        lbRoleID.Location = New Point(30, 20)
        lbRoleID.Margin = New Padding(4, 0, 4, 0)
        lbRoleID.Name = "lbRoleID"
        lbRoleID.Size = New Size(86, 23)
        lbRoleID.TabIndex = 122
        lbRoleID.Text = "Faculty ID"
        lbRoleID.Visible = False
        ' 
        ' UserDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1902, 1033)
        ControlBox = False
        Controls.Add(SplitCon)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "UserDashboard"
        WindowState = FormWindowState.Maximized
        Panel3.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        SplitCon.Panel1.ResumeLayout(False)
        SplitCon.Panel2.ResumeLayout(False)
        SplitCon.Panel2.PerformLayout()
        CType(SplitCon, ComponentModel.ISupportInitialize).EndInit()
        SplitCon.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnLogout As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnUsers As Button
    Friend WithEvents btnItems As Button
    Friend WithEvents btnBorrowed As Button
    Friend WithEvents SplitCon As SplitContainer
    Friend WithEvents lbRoleID As Label
    Friend WithEvents lbUserID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
End Class
