<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventorySubform
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
        btnEdit = New Button()
        btnAdd = New Button()
        btnDelete = New Button()
        dgvInventory = New DataGridView()
        btnRefresh = New Button()
        Label1 = New Label()
        btnExit = New Button()
        Panel1 = New Panel()
        Label2 = New Label()
        txtSearch = New TextBox()
        CType(dgvInventory, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnEdit
        ' 
        btnEdit.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnEdit.FlatAppearance.BorderSize = 0
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.Image = My.Resources.Resources.edit
        btnEdit.Location = New Point(838, 102)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(39, 29)
        btnEdit.TabIndex = 21
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAdd.FlatAppearance.BorderSize = 0
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Image = My.Resources.Resources.add
        btnAdd.Location = New Point(883, 102)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(39, 29)
        btnAdd.TabIndex = 20
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Image = My.Resources.Resources.delete
        btnDelete.Location = New Point(928, 102)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(39, 29)
        btnDelete.TabIndex = 19
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' dgvInventory
        ' 
        dgvInventory.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvInventory.Location = New Point(26, 150)
        dgvInventory.Name = "dgvInventory"
        dgvInventory.ReadOnly = True
        dgvInventory.RowHeadersWidth = 51
        dgvInventory.RowTemplate.Height = 29
        dgvInventory.Size = New Size(941, 266)
        dgvInventory.TabIndex = 17
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Image = My.Resources.Resources.updates
        btnRefresh.Location = New Point(793, 102)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(39, 29)
        btnRefresh.TabIndex = 22
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(435, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(168, 54)
        Label1.TabIndex = 100
        Label1.Text = "Inventory"
        ' 
        ' btnExit
        ' 
        btnExit.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Image = My.Resources.Resources._exit
        btnExit.Location = New Point(1593, 66)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(22, 10)
        btnExit.TabIndex = 16
        btnExit.UseVisualStyleBackColor = True
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
        Panel1.TabIndex = 104
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label2.Location = New Point(28, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 23)
        Label2.TabIndex = 136
        Label2.Text = "Search"
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtSearch.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtSearch.Location = New Point(95, 104)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(318, 27)
        txtSearch.TabIndex = 135
        ' 
        ' InventorySubform
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(993, 444)
        ControlBox = False
        Controls.Add(Label2)
        Controls.Add(txtSearch)
        Controls.Add(Panel1)
        Controls.Add(btnRefresh)
        Controls.Add(btnEdit)
        Controls.Add(btnAdd)
        Controls.Add(btnDelete)
        Controls.Add(dgvInventory)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "InventorySubform"
        WindowState = FormWindowState.Maximized
        CType(dgvInventory, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearch As TextBox
End Class
