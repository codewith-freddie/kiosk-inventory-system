<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowItemAdmin
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
        btnExit = New Button()
        Label2 = New Label()
        Panel1 = New Panel()
        btnClear = New Button()
        Submit = New Button()
        Label7 = New Label()
        txtItemID = New TextBox()
        cmbItemName = New ComboBox()
        cmbCategory = New ComboBox()
        Label6 = New Label()
        txtRemarks = New TextBox()
        Label4 = New Label()
        txtQuantity = New TextBox()
        Label5 = New Label()
        txtDescription = New TextBox()
        Label3 = New Label()
        Label1 = New Label()
        Label8 = New Label()
        txtUserID = New TextBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnExit
        ' 
        btnExit.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Image = My.Resources.Resources._exit
        btnExit.Location = New Point(526, 12)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(39, 35)
        btnExit.TabIndex = 16
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(193, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(216, 54)
        Label2.TabIndex = 100
        Label2.Text = "Borrow Item"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(btnExit)
        Panel1.Controls.Add(txtUserID)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(txtItemID)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(577, 107)
        Panel1.TabIndex = 119
        ' 
        ' btnClear
        ' 
        btnClear.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnClear.BackColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        btnClear.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(81, 491)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(162, 60)
        btnClear.TabIndex = 142
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' Submit
        ' 
        Submit.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Submit.BackColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        Submit.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Submit.ForeColor = Color.White
        Submit.Location = New Point(349, 491)
        Submit.Name = "Submit"
        Submit.Size = New Size(162, 60)
        Submit.TabIndex = 141
        Submit.Text = "Submit"
        Submit.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label7.Location = New Point(276, 13)
        Label7.Name = "Label7"
        Label7.Size = New Size(67, 23)
        Label7.TabIndex = 168
        Label7.Text = "Item ID"
        Label7.Visible = False
        ' 
        ' txtItemID
        ' 
        txtItemID.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtItemID.BackColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtItemID.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtItemID.Location = New Point(349, 12)
        txtItemID.Name = "txtItemID"
        txtItemID.Size = New Size(143, 27)
        txtItemID.TabIndex = 167
        txtItemID.Visible = False
        ' 
        ' cmbItemName
        ' 
        cmbItemName.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        cmbItemName.FormattingEnabled = True
        cmbItemName.Items.AddRange(New Object() {""})
        cmbItemName.Location = New Point(193, 205)
        cmbItemName.Name = "cmbItemName"
        cmbItemName.Size = New Size(318, 28)
        cmbItemName.TabIndex = 166
        ' 
        ' cmbCategory
        ' 
        cmbCategory.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        cmbCategory.FormattingEnabled = True
        cmbCategory.Items.AddRange(New Object() {""})
        cmbCategory.Location = New Point(193, 151)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(318, 28)
        cmbCategory.TabIndex = 165
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label6.Location = New Point(81, 416)
        Label6.Name = "Label6"
        Label6.Size = New Size(76, 23)
        Label6.TabIndex = 164
        Label6.Text = "Remarks"
        ' 
        ' txtRemarks
        ' 
        txtRemarks.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtRemarks.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtRemarks.Location = New Point(193, 415)
        txtRemarks.Name = "txtRemarks"
        txtRemarks.ReadOnly = True
        txtRemarks.Size = New Size(318, 27)
        txtRemarks.TabIndex = 163
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label4.Location = New Point(81, 358)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 23)
        Label4.TabIndex = 162
        Label4.Text = "Quantity"
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtQuantity.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtQuantity.Location = New Point(193, 357)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(318, 27)
        txtQuantity.TabIndex = 161
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label5.Location = New Point(81, 263)
        Label5.Name = "Label5"
        Label5.Size = New Size(96, 23)
        Label5.TabIndex = 160
        Label5.Text = "Description"
        ' 
        ' txtDescription
        ' 
        txtDescription.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtDescription.Location = New Point(193, 262)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.ReadOnly = True
        txtDescription.Size = New Size(318, 58)
        txtDescription.TabIndex = 159
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label3.Location = New Point(81, 206)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 23)
        Label3.TabIndex = 158
        Label3.Text = "Item Name"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label1.Location = New Point(81, 152)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 23)
        Label1.TabIndex = 157
        Label1.Text = "Category"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label8.Location = New Point(62, 13)
        Label8.Name = "Label8"
        Label8.Size = New Size(66, 23)
        Label8.TabIndex = 170
        Label8.Text = "User ID"
        Label8.Visible = False
        ' 
        ' txtUserID
        ' 
        txtUserID.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtUserID.BackColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtUserID.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtUserID.Location = New Point(135, 12)
        txtUserID.Name = "txtUserID"
        txtUserID.Size = New Size(135, 27)
        txtUserID.TabIndex = 169
        txtUserID.Visible = False
        ' 
        ' BorrowItemAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(577, 591)
        Controls.Add(cmbItemName)
        Controls.Add(cmbCategory)
        Controls.Add(Label6)
        Controls.Add(txtRemarks)
        Controls.Add(Label4)
        Controls.Add(txtQuantity)
        Controls.Add(Label5)
        Controls.Add(txtDescription)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(btnClear)
        Controls.Add(Submit)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "BorrowItemAdmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BorrowItem"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClear As Button
    Friend WithEvents Submit As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtItemID As TextBox
    Friend WithEvents cmbItemName As ComboBox
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtUserID As TextBox
End Class
