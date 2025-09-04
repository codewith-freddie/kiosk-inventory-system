<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditItems
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
        lbItemID = New Label()
        txtItemID = New TextBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnExit
        ' 
        btnExit.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Image = My.Resources.Resources._exit
        btnExit.Location = New Point(496, 12)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(39, 30)
        btnExit.TabIndex = 16
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(199, 27)
        Label2.Name = "Label2"
        Label2.Size = New Size(180, 54)
        Label2.TabIndex = 100
        Label2.Text = "Edit Items"
        ' 
        ' btnClear
        ' 
        btnClear.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnClear.BackColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        btnClear.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(57, 493)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(169, 57)
        btnClear.TabIndex = 130
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label6.Location = New Point(57, 413)
        Label6.Name = "Label6"
        Label6.Size = New Size(76, 23)
        Label6.TabIndex = 129
        Label6.Text = "Remarks"
        ' 
        ' txtRemarks
        ' 
        txtRemarks.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtRemarks.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtRemarks.Location = New Point(169, 412)
        txtRemarks.Name = "txtRemarks"
        txtRemarks.Size = New Size(318, 27)
        txtRemarks.TabIndex = 128
        ' 
        ' Submit
        ' 
        Submit.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Submit.BackColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        Submit.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Submit.ForeColor = Color.White
        Submit.Location = New Point(318, 493)
        Submit.Name = "Submit"
        Submit.Size = New Size(169, 57)
        Submit.TabIndex = 118
        Submit.Text = "Submit"
        Submit.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label4.Location = New Point(57, 355)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 23)
        Label4.TabIndex = 127
        Label4.Text = "Quantity"
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtQuantity.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtQuantity.Location = New Point(169, 354)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(318, 27)
        txtQuantity.TabIndex = 126
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label5.Location = New Point(57, 260)
        Label5.Name = "Label5"
        Label5.Size = New Size(96, 23)
        Label5.TabIndex = 125
        Label5.Text = "Description"
        ' 
        ' txtDescription
        ' 
        txtDescription.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtDescription.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtDescription.Location = New Point(169, 259)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(318, 65)
        txtDescription.TabIndex = 124
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label3.Location = New Point(57, 203)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 23)
        Label3.TabIndex = 123
        Label3.Text = "Item Name"
        ' 
        ' txtItemName
        ' 
        txtItemName.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtItemName.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtItemName.Location = New Point(169, 202)
        txtItemName.Name = "txtItemName"
        txtItemName.Size = New Size(318, 27)
        txtItemName.TabIndex = 122
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label1.Location = New Point(57, 149)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 23)
        Label1.TabIndex = 121
        Label1.Text = "Category"
        ' 
        ' txtCategory
        ' 
        txtCategory.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtCategory.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtCategory.Location = New Point(169, 148)
        txtCategory.Name = "txtCategory"
        txtCategory.Size = New Size(318, 27)
        txtCategory.TabIndex = 120
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        Panel1.Controls.Add(btnExit)
        Panel1.Controls.Add(Label2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(547, 107)
        Panel1.TabIndex = 119
        ' 
        ' lbItemID
        ' 
        lbItemID.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        lbItemID.AutoSize = True
        lbItemID.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbItemID.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        lbItemID.Location = New Point(210, 120)
        lbItemID.Name = "lbItemID"
        lbItemID.Size = New Size(67, 23)
        lbItemID.TabIndex = 132
        lbItemID.Text = "Item ID"
        lbItemID.Visible = False
        ' 
        ' txtItemID
        ' 
        txtItemID.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtItemID.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtItemID.Location = New Point(299, 113)
        txtItemID.Name = "txtItemID"
        txtItemID.ReadOnly = True
        txtItemID.Size = New Size(104, 27)
        txtItemID.TabIndex = 131
        txtItemID.Visible = False
        ' 
        ' EditItems
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(547, 582)
        Controls.Add(lbItemID)
        Controls.Add(btnClear)
        Controls.Add(Label6)
        Controls.Add(txtItemID)
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
        Name = "EditItems"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EditItemsvb"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents Label2 As Label
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
    Friend WithEvents lbItemID As Label
    Friend WithEvents txtItemID As TextBox
End Class
