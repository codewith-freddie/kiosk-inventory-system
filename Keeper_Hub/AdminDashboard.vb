Imports MySql.Data.MySqlClient
Imports System.IO

Public Class AdminDashboard
    Public Shared AdminMain As String
    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        Dim us As New Accounts()
        us.TopLevel = False
        SplitCon.Panel2.Controls.Add(us)
        us.BringToFront()
        us.Show()
    End Sub

    Private Sub btnItems_Click(sender As Object, e As EventArgs) Handles btnItems.Click
        Dim invent As New InventorySubform()
        invent.TopLevel = False
        SplitCon.Panel2.Controls.Add(invent)
        invent.BringToFront()
        invent.Show()
    End Sub

    Private Sub btnBorrowed_Click(sender As Object, e As EventArgs) Handles btnBorrowed.Click
        Dim bh As New BorrowedHistory
        bh.TopLevel = False
        SplitCon.Panel2.Controls.Add(bh)
        bh.BringToFront()
        bh.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ri As New ReturnedItem
        ri.TopLevel = False
        SplitCon.Panel2.Controls.Add(ri)
        ri.BringToFront()
        ri.Show()
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        Dim costumize As New Settings
        Settings.sets = txtUsername.Text
        costumize.TopLevel = False
        SplitCon.Panel2.Controls.Add(costumize)
        costumize.BringToFront()
        costumize.Show()
    End Sub

    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Text = AdminMain
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        LoginDashboard.Show()
    End Sub
End Class