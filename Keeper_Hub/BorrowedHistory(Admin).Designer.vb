<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowedHistory
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
        Label2 = New Label()
        txtSearch = New TextBox()
        btnRefresh = New Button()
        CType(dgvInventory, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(389, 9)
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
        dgvInventory.Size = New Size(953, 388)
        dgvInventory.TabIndex = 128
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1016, 81)
        Panel1.TabIndex = 127
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
        ' btnRefresh
        ' 
        btnRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Image = My.Resources.Resources.updates
        btnRefresh.Location = New Point(933, 114)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(39, 29)
        btnRefresh.TabIndex = 136
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' BorrowedHistory
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1016, 580)
        Controls.Add(btnRefresh)
        Controls.Add(Label2)
        Controls.Add(txtSearch)
        Controls.Add(dgvInventory)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "BorrowedHistory"
        Text = "BorrowedHistory"
        WindowState = FormWindowState.Maximized
        CType(dgvInventory, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnRefresh As Button
End Class
