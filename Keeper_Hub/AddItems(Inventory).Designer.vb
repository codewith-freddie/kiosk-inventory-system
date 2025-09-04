<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddItems
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
        Submit = New Button()
        Panel1 = New Panel()
        txtCategory = New TextBox()
        Label1 = New Label()
        Label3 = New Label()
        txtItemName = New TextBox()
        Label4 = New Label()
        txtQuantity = New TextBox()
        Label5 = New Label()
        txtDescription = New TextBox()
        Label6 = New Label()
        txtRemarks = New TextBox()
        btnClear = New Button()
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
        btnExit.Size = New Size(39, 36)
        btnExit.TabIndex = 16
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(191, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(180, 54)
        Label2.TabIndex = 100
        Label2.Text = "Add Items"
        ' 
        ' Submit
        ' 
        Submit.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Submit.BackColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        Submit.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Submit.ForeColor = Color.White
        Submit.Location = New Point(313, 493)
        Submit.Name = "Submit"
        Submit.Size = New Size(169, 57)
        Submit.TabIndex = 104
        Submit.Text = "Submit"
        Submit.UseVisualStyleBackColor = False
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
        Panel1.TabIndex = 105
        ' 
        ' txtCategory
        ' 
        txtCategory.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtCategory.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtCategory.Location = New Point(164, 149)
        txtCategory.Name = "txtCategory"
        txtCategory.Size = New Size(318, 27)
        txtCategory.TabIndex = 106
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label1.Location = New Point(52, 150)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 23)
        Label1.TabIndex = 108
        Label1.Text = "Category"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label3.Location = New Point(52, 204)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 23)
        Label3.TabIndex = 110
        Label3.Text = "Item Name"
        ' 
        ' txtItemName
        ' 
        txtItemName.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtItemName.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtItemName.Location = New Point(164, 203)
        txtItemName.Name = "txtItemName"
        txtItemName.Size = New Size(318, 27)
        txtItemName.TabIndex = 109
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label4.Location = New Point(52, 356)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 23)
        Label4.TabIndex = 114
        Label4.Text = "Quantity"
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtQuantity.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtQuantity.Location = New Point(164, 355)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(318, 27)
        txtQuantity.TabIndex = 113
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label5.Location = New Point(52, 261)
        Label5.Name = "Label5"
        Label5.Size = New Size(96, 23)
        Label5.TabIndex = 112
        Label5.Text = "Description"
        ' 
        ' txtDescription
        ' 
        txtDescription.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtDescription.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtDescription.Location = New Point(164, 260)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(318, 65)
        txtDescription.TabIndex = 111
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        Label6.Location = New Point(52, 414)
        Label6.Name = "Label6"
        Label6.Size = New Size(76, 23)
        Label6.TabIndex = 116
        Label6.Text = "Remarks"
        ' 
        ' txtRemarks
        ' 
        txtRemarks.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtRemarks.ForeColor = Color.FromArgb(CByte(9), CByte(96), CByte(78))
        txtRemarks.Location = New Point(164, 413)
        txtRemarks.Name = "txtRemarks"
        txtRemarks.Size = New Size(318, 27)
        txtRemarks.TabIndex = 115
        ' 
        ' btnClear
        ' 
        btnClear.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnClear.BackColor = Color.FromArgb(CByte(9), CByte(96), CByte(79))
        btnClear.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(52, 493)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(169, 57)
        btnClear.TabIndex = 117
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' AddItems
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(547, 582)
        ControlBox = False
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
        Name = "AddItems"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Submit As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents btnClear As Button
End Class
