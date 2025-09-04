<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnedItems
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
        txtItemID = New TextBox()
        btnClear = New Button()
        Label6 = New Label()
        txtRemarks = New TextBox()
        Submit = New Button()
        Label4 = New Label()
        txtQuantity = New TextBox()
        Label5 = New Label()
        txtDescription = New TextBox()
        Label3 = New Label()
        txtItemName = New TextBox()
        Label1 = New Label()
        txtCategory = New TextBox()
        Panel1 = New Panel()
        btnExit = New Button()
        Label2 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        txtBorrowedID = New TextBox()
        Label9 = New Label()
        txtUserID = New TextBox()
        Label10 = New Label()
        txtDateTime = New TextBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtItemID
        ' 
        txtItemID.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtItemID.Location = New Point(384, 62)
        txtItemID.Name = "txtItemID"
        txtItemID.ReadOnly = True
        txtItemID.Size = New Size(104, 27)
        txtItemID.TabIndex = 146
        txtItemID.Visible = False
        ' 
        ' btnClear
        ' 
        btnClear.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnClear.BackColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        btnClear.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(57, 539)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(169, 57)
        btnClear.TabIndex = 145
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label6.Location = New Point(58, 414)
        Label6.Name = "Label6"
        Label6.Size = New Size(76, 23)
        Label6.TabIndex = 144
        Label6.Text = "Remarks"
        ' 
        ' txtRemarks
        ' 
        txtRemarks.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtRemarks.Location = New Point(170, 413)
        txtRemarks.Name = "txtRemarks"
        txtRemarks.ReadOnly = True
        txtRemarks.Size = New Size(318, 27)
        txtRemarks.TabIndex = 143
        ' 
        ' Submit
        ' 
        Submit.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Submit.BackColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        Submit.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Submit.ForeColor = Color.White
        Submit.Location = New Point(318, 539)
        Submit.Name = "Submit"
        Submit.Size = New Size(169, 57)
        Submit.TabIndex = 133
        Submit.Text = "Submit"
        Submit.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label4.Location = New Point(58, 356)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 23)
        Label4.TabIndex = 142
        Label4.Text = "Quantity"
        ' 
        ' txtQuantity
        ' 
        txtQuantity.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtQuantity.Location = New Point(170, 355)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(318, 27)
        txtQuantity.TabIndex = 141
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label5.Location = New Point(58, 261)
        Label5.Name = "Label5"
        Label5.Size = New Size(96, 23)
        Label5.TabIndex = 140
        Label5.Text = "Description"
        ' 
        ' txtDescription
        ' 
        txtDescription.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtDescription.Location = New Point(170, 260)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.ReadOnly = True
        txtDescription.Size = New Size(318, 65)
        txtDescription.TabIndex = 139
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label3.Location = New Point(58, 204)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 23)
        Label3.TabIndex = 138
        Label3.Text = "Item Name"
        ' 
        ' txtItemName
        ' 
        txtItemName.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtItemName.Location = New Point(170, 203)
        txtItemName.Name = "txtItemName"
        txtItemName.ReadOnly = True
        txtItemName.Size = New Size(318, 27)
        txtItemName.TabIndex = 137
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label1.Location = New Point(58, 150)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 23)
        Label1.TabIndex = 136
        Label1.Text = "Category"
        ' 
        ' txtCategory
        ' 
        txtCategory.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtCategory.Location = New Point(170, 149)
        txtCategory.Name = "txtCategory"
        txtCategory.ReadOnly = True
        txtCategory.Size = New Size(318, 27)
        txtCategory.TabIndex = 135
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        Panel1.Controls.Add(btnExit)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(txtUserID)
        Panel1.Controls.Add(txtItemID)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(txtBorrowedID)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(547, 107)
        Panel1.TabIndex = 134
        ' 
        ' btnExit
        ' 
        btnExit.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Image = My.Resources.Resources._exit
        btnExit.Location = New Point(496, 12)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(39, 37)
        btnExit.TabIndex = 16
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(169, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(209, 54)
        Label2.TabIndex = 100
        Label2.Text = "Return Item"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label7.Location = New Point(311, 63)
        Label7.Name = "Label7"
        Label7.Size = New Size(67, 23)
        Label7.TabIndex = 147
        Label7.Text = "Item ID"
        Label7.Visible = False
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label8.Location = New Point(33, 63)
        Label8.Name = "Label8"
        Label8.Size = New Size(106, 23)
        Label8.TabIndex = 149
        Label8.Text = "Borrowed ID"
        Label8.Visible = False
        ' 
        ' txtBorrowedID
        ' 
        txtBorrowedID.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtBorrowedID.Location = New Point(170, 62)
        txtBorrowedID.Name = "txtBorrowedID"
        txtBorrowedID.ReadOnly = True
        txtBorrowedID.Size = New Size(134, 27)
        txtBorrowedID.TabIndex = 148
        txtBorrowedID.Visible = False
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label9.Location = New Point(68, 24)
        Label9.Name = "Label9"
        Label9.Size = New Size(66, 23)
        Label9.TabIndex = 151
        Label9.Text = "User ID"
        Label9.Visible = False
        ' 
        ' txtUserID
        ' 
        txtUserID.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtUserID.Location = New Point(170, 20)
        txtUserID.Name = "txtUserID"
        txtUserID.ReadOnly = True
        txtUserID.Size = New Size(80, 27)
        txtUserID.TabIndex = 150
        txtUserID.Visible = False
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label10.Location = New Point(33, 475)
        Label10.Name = "Label10"
        Label10.Size = New Size(122, 23)
        Label10.TabIndex = 153
        Label10.Text = "Date and Time"
        ' 
        ' txtDateTime
        ' 
        txtDateTime.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtDateTime.Location = New Point(170, 471)
        txtDateTime.Name = "txtDateTime"
        txtDateTime.ReadOnly = True
        txtDateTime.Size = New Size(318, 27)
        txtDateTime.TabIndex = 152
        ' 
        ' ReturnedItems
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(547, 612)
        Controls.Add(Label10)
        Controls.Add(txtDateTime)
        Controls.Add(btnClear)
        Controls.Add(Label6)
        Controls.Add(txtRemarks)
        Controls.Add(Submit)
        Controls.Add(Label4)
        Controls.Add(txtQuantity)
        Controls.Add(Label5)
        Controls.Add(txtDescription)
        Controls.Add(Label3)
        Controls.Add(txtItemName)
        Controls.Add(Label1)
        Controls.Add(txtCategory)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "ReturnedItems"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ReturnedItems"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtItemID As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents Submit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtBorrowedID As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDateTime As TextBox
End Class
