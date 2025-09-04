<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Confirmation_ReturnItem_
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
        txtDateTime = New TextBox()
        Label9 = New Label()
        txtUserID = New TextBox()
        Label8 = New Label()
        txtBorrowedID = New TextBox()
        Label7 = New Label()
        btnExit = New Button()
        Label2 = New Label()
        Label10 = New Label()
        txtItemID = New TextBox()
        Label6 = New Label()
        txtRemarks = New TextBox()
        btnConfirm = New Button()
        Label4 = New Label()
        txtQuantity = New TextBox()
        Label5 = New Label()
        txtDescription = New TextBox()
        Label3 = New Label()
        txtItemName = New TextBox()
        Label1 = New Label()
        txtCategory = New TextBox()
        Panel1 = New Panel()
        Label11 = New Label()
        txtReturnedID = New TextBox()
        lbBorrowedQty = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtDateTime
        ' 
        txtDateTime.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtDateTime.Location = New Point(606, 288)
        txtDateTime.Name = "txtDateTime"
        txtDateTime.ReadOnly = True
        txtDateTime.Size = New Size(269, 27)
        txtDateTime.TabIndex = 173
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label9.Location = New Point(52, 16)
        Label9.Name = "Label9"
        Label9.Size = New Size(66, 23)
        Label9.TabIndex = 172
        Label9.Text = "User ID"
        Label9.Visible = False
        ' 
        ' txtUserID
        ' 
        txtUserID.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtUserID.Location = New Point(124, 15)
        txtUserID.Name = "txtUserID"
        txtUserID.ReadOnly = True
        txtUserID.Size = New Size(104, 27)
        txtUserID.TabIndex = 171
        txtUserID.Visible = False
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label8.Location = New Point(484, 20)
        Label8.Name = "Label8"
        Label8.Size = New Size(106, 23)
        Label8.TabIndex = 170
        Label8.Text = "Borrowed ID"
        Label8.Visible = False
        ' 
        ' txtBorrowedID
        ' 
        txtBorrowedID.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtBorrowedID.Location = New Point(596, 16)
        txtBorrowedID.Name = "txtBorrowedID"
        txtBorrowedID.ReadOnly = True
        txtBorrowedID.Size = New Size(101, 27)
        txtBorrowedID.TabIndex = 169
        txtBorrowedID.Visible = False
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label7.Location = New Point(707, 21)
        Label7.Name = "Label7"
        Label7.Size = New Size(67, 23)
        Label7.TabIndex = 168
        Label7.Text = "Item ID"
        Label7.Visible = False
        ' 
        ' btnExit
        ' 
        btnExit.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Image = My.Resources.Resources._exit
        btnExit.Location = New Point(893, 12)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(39, 31)
        btnExit.TabIndex = 16
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(368, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(224, 54)
        Label2.TabIndex = 100
        Label2.Text = "Confirmation"
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label10.Location = New Point(469, 292)
        Label10.Name = "Label10"
        Label10.Size = New Size(122, 23)
        Label10.TabIndex = 174
        Label10.Text = "Date and Time"
        ' 
        ' txtItemID
        ' 
        txtItemID.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtItemID.Location = New Point(783, 20)
        txtItemID.Name = "txtItemID"
        txtItemID.ReadOnly = True
        txtItemID.Size = New Size(101, 27)
        txtItemID.TabIndex = 167
        txtItemID.Visible = False
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label6.Location = New Point(514, 231)
        Label6.Name = "Label6"
        Label6.Size = New Size(76, 23)
        Label6.TabIndex = 165
        Label6.Text = "Remarks"
        ' 
        ' txtRemarks
        ' 
        txtRemarks.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtRemarks.Location = New Point(606, 230)
        txtRemarks.Name = "txtRemarks"
        txtRemarks.ReadOnly = True
        txtRemarks.Size = New Size(269, 27)
        txtRemarks.TabIndex = 164
        ' 
        ' btnConfirm
        ' 
        btnConfirm.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnConfirm.BackColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        btnConfirm.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnConfirm.ForeColor = Color.White
        btnConfirm.Location = New Point(368, 390)
        btnConfirm.Name = "btnConfirm"
        btnConfirm.Size = New Size(212, 57)
        btnConfirm.TabIndex = 154
        btnConfirm.Text = "Confirm"
        btnConfirm.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label4.Location = New Point(514, 176)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 23)
        Label4.TabIndex = 163
        Label4.Text = "Quantity"
        ' 
        ' txtQuantity
        ' 
        txtQuantity.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtQuantity.Location = New Point(606, 172)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.ReadOnly = True
        txtQuantity.Size = New Size(269, 27)
        txtQuantity.TabIndex = 162
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label5.Location = New Point(63, 270)
        Label5.Name = "Label5"
        Label5.Size = New Size(96, 23)
        Label5.TabIndex = 161
        Label5.Text = "Description"
        ' 
        ' txtDescription
        ' 
        txtDescription.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtDescription.Location = New Point(175, 269)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.ReadOnly = True
        txtDescription.Size = New Size(272, 65)
        txtDescription.TabIndex = 160
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label3.Location = New Point(63, 213)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 23)
        Label3.TabIndex = 159
        Label3.Text = "Item Name"
        ' 
        ' txtItemName
        ' 
        txtItemName.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtItemName.Location = New Point(175, 212)
        txtItemName.Name = "txtItemName"
        txtItemName.ReadOnly = True
        txtItemName.Size = New Size(272, 27)
        txtItemName.TabIndex = 158
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label1.Location = New Point(78, 162)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 23)
        Label1.TabIndex = 157
        Label1.Text = "Category"
        ' 
        ' txtCategory
        ' 
        txtCategory.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtCategory.Location = New Point(175, 158)
        txtCategory.Name = "txtCategory"
        txtCategory.ReadOnly = True
        txtCategory.Size = New Size(272, 27)
        txtCategory.TabIndex = 156
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(btnExit)
        Panel1.Controls.Add(txtReturnedID)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtBorrowedID)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(txtItemID)
        Panel1.Controls.Add(txtUserID)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label8)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(944, 107)
        Panel1.TabIndex = 155
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label11.Location = New Point(253, 20)
        Label11.Name = "Label11"
        Label11.Size = New Size(103, 23)
        Label11.TabIndex = 176
        Label11.Text = "Returned ID"
        Label11.Visible = False
        ' 
        ' txtReturnedID
        ' 
        txtReturnedID.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtReturnedID.Location = New Point(362, 16)
        txtReturnedID.Name = "txtReturnedID"
        txtReturnedID.ReadOnly = True
        txtReturnedID.Size = New Size(104, 27)
        txtReturnedID.TabIndex = 175
        txtReturnedID.Visible = False
        ' 
        ' lbBorrowedQty
        ' 
        lbBorrowedQty.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        lbBorrowedQty.AutoSize = True
        lbBorrowedQty.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbBorrowedQty.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        lbBorrowedQty.Location = New Point(659, 130)
        lbBorrowedQty.Name = "lbBorrowedQty"
        lbBorrowedQty.Size = New Size(156, 23)
        lbBorrowedQty.TabIndex = 177
        lbBorrowedQty.Text = "Borrowed Quantity"
        lbBorrowedQty.Visible = False
        ' 
        ' Confirmation_ReturnItem_
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(944, 475)
        ControlBox = False
        Controls.Add(lbBorrowedQty)
        Controls.Add(txtDateTime)
        Controls.Add(Label10)
        Controls.Add(Label6)
        Controls.Add(txtRemarks)
        Controls.Add(btnConfirm)
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
        Name = "Confirmation_ReturnItem_"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Confirmation_ReturnItem_"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtDateTime As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtBorrowedID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtItemID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents txtReturnedID As TextBox
    Friend WithEvents lbBorrowedQty As Label
End Class
