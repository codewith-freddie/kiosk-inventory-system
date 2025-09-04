<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowedHistoryUser
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
        Label1 = New Label()
        dgvInventory = New DataGridView()
        Panel1 = New Panel()
        lbUserID = New Label()
        btnRefresh = New Button()
        btnAdd = New Button()
        Label2 = New Label()
        txtSearch = New TextBox()
        btnReturn = New Button()
        dgvReturnItems = New DataGridView()
        Label3 = New Label()
        CType(dgvInventory, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(dgvReturnItems, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(382, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(265, 54)
        Label1.TabIndex = 100
        Label1.Text = "Borrowed Items"
        ' 
        ' dgvInventory
        ' 
        dgvInventory.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvInventory.Location = New Point(34, 159)
        dgvInventory.Name = "dgvInventory"
        dgvInventory.ReadOnly = True
        dgvInventory.RowHeadersWidth = 51
        dgvInventory.RowTemplate.Height = 29
        dgvInventory.Size = New Size(953, 99)
        dgvInventory.TabIndex = 128
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        Panel1.Controls.Add(lbUserID)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1016, 81)
        Panel1.TabIndex = 127
        ' 
        ' lbUserID
        ' 
        lbUserID.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        lbUserID.AutoSize = True
        lbUserID.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbUserID.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        lbUserID.Location = New Point(34, 30)
        lbUserID.Name = "lbUserID"
        lbUserID.Size = New Size(66, 23)
        lbUserID.TabIndex = 133
        lbUserID.Text = "User ID"
        lbUserID.Visible = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Image = My.Resources.Resources.updates
        btnRefresh.Location = New Point(887, 114)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(39, 29)
        btnRefresh.TabIndex = 130
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAdd.FlatAppearance.BorderSize = 0
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Image = My.Resources.Resources.add
        btnAdd.Location = New Point(932, 114)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(39, 29)
        btnAdd.TabIndex = 129
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label2.Location = New Point(32, 114)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 23)
        Label2.TabIndex = 132
        Label2.Text = "Search"
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtSearch.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtSearch.Location = New Point(99, 113)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(318, 27)
        txtSearch.TabIndex = 131
        ' 
        ' btnReturn
        ' 
        btnReturn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnReturn.BackColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        btnReturn.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnReturn.ForeColor = Color.White
        btnReturn.Location = New Point(851, 280)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(120, 57)
        btnReturn.TabIndex = 133
        btnReturn.Text = "Return"
        btnReturn.UseVisualStyleBackColor = False
        ' 
        ' dgvReturnItems
        ' 
        dgvReturnItems.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvReturnItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvReturnItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReturnItems.Location = New Point(32, 357)
        dgvReturnItems.Name = "dgvReturnItems"
        dgvReturnItems.ReadOnly = True
        dgvReturnItems.RowHeadersWidth = 51
        dgvReturnItems.RowTemplate.Height = 29
        dgvReturnItems.Size = New Size(953, 163)
        dgvReturnItems.TabIndex = 134
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label3.Location = New Point(32, 317)
        Label3.Name = "Label3"
        Label3.Size = New Size(128, 23)
        Label3.TabIndex = 135
        Label3.Text = "Returned Items"
        ' 
        ' BorrowedHistoryUser
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1016, 580)
        Controls.Add(Label3)
        Controls.Add(dgvReturnItems)
        Controls.Add(btnReturn)
        Controls.Add(Label2)
        Controls.Add(txtSearch)
        Controls.Add(btnRefresh)
        Controls.Add(btnAdd)
        Controls.Add(dgvInventory)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "BorrowedHistoryUser"
        Text = "BorrowedHistory"
        WindowState = FormWindowState.Maximized
        CType(dgvInventory, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvReturnItems, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lbUserID As Label
    Friend WithEvents btnReturn As Button
    Friend WithEvents dgvReturnItems As DataGridView
    Friend WithEvents Label3 As Label
End Class
