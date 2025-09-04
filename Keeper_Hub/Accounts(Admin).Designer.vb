<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accounts
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
        dgvAccounts = New DataGridView()
        btnDelete = New Button()
        btnAdd = New Button()
        btnRefresh = New Button()
        Panel1 = New Panel()
        btnExit = New Button()
        Label1 = New Label()
        Label2 = New Label()
        txtSearch = New TextBox()
        CType(dgvAccounts, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvAccounts
        ' 
        dgvAccounts.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvAccounts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAccounts.Location = New Point(26, 160)
        dgvAccounts.Name = "dgvAccounts"
        dgvAccounts.ReadOnly = True
        dgvAccounts.RowHeadersWidth = 51
        dgvAccounts.RowTemplate.Height = 29
        dgvAccounts.Size = New Size(941, 263)
        dgvAccounts.TabIndex = 8
        ' 
        ' btnDelete
        ' 
        btnDelete.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Image = My.Resources.Resources.delete
        btnDelete.Location = New Point(923, 109)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(39, 29)
        btnDelete.TabIndex = 13
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAdd.FlatAppearance.BorderSize = 0
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Image = My.Resources.Resources.add
        btnAdd.Location = New Point(878, 109)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(39, 29)
        btnAdd.TabIndex = 15
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Image = My.Resources.Resources.updates
        btnRefresh.Location = New Point(833, 109)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(39, 29)
        btnRefresh.TabIndex = 16
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        Panel1.Controls.Add(btnExit)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(993, 81)
        Panel1.TabIndex = 105
        ' 
        ' btnExit
        ' 
        btnExit.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Image = My.Resources.Resources._exit
        btnExit.Location = New Point(2386, 12)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(39, 0)
        btnExit.TabIndex = 16
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(401, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(237, 54)
        Label1.TabIndex = 100
        Label1.Text = "Users Account"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label2.Location = New Point(30, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 23)
        Label2.TabIndex = 136
        Label2.Text = "Search"
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtSearch.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtSearch.Location = New Point(97, 111)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(318, 27)
        txtSearch.TabIndex = 135
        ' 
        ' Accounts
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(993, 450)
        ControlBox = False
        Controls.Add(Label2)
        Controls.Add(txtSearch)
        Controls.Add(Panel1)
        Controls.Add(btnRefresh)
        Controls.Add(btnAdd)
        Controls.Add(btnDelete)
        Controls.Add(dgvAccounts)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Accounts"
        WindowState = FormWindowState.Maximized
        CType(dgvAccounts, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents dgvAccounts As DataGridView
    Friend WithEvents addBtn As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearch As TextBox
End Class
