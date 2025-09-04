Imports MySql.Data.MySqlClient

Public Class UserDashboard
    Public Shared UserMain
    Dim con As New MySqlConnection
    Dim connectionStr As String = "Server=localhost;Database=keeper_hub;User ID=root;Password=;"

    Private Sub UserDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbRoleID.Text = UserMain
        con.ConnectionString = connectionStr
        displayData()
    End Sub

    Private Sub homeDisplay()
        Dim pu As New Profile()
        pu.TopLevel = False
        SplitCon.Panel2.Controls.Add(pu)
        pu.BringToFront()
        pu.Show()
    End Sub
    Sub displayData()
        Try
            con.Open()
            Dim query As New MySqlCommand("SELECT * FROM accounts WHERE roleID=@roleID", con)
            query.Parameters.AddWithValue("roleID", lbRoleID.Text)

            Dim reader As MySqlDataReader = query.ExecuteReader()

            If reader.HasRows Then
                While reader.Read()
                    lbUserID.Text = reader("UserID").ToString()
                End While
            End If

        Catch ex As Exception
            ' Handle the exception, e.g., display an error message
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnItems_Click(sender As Object, e As EventArgs) Handles btnItems.Click
        Dim ui As New UserInventory()
        UserInventory.ui = lbUserID.Text
        ui.TopLevel = False
        SplitCon.Panel2.Controls.Add(ui)
        ui.BringToFront()
        ui.Show()
    End Sub

    Private Sub btnBorrowed_Click(sender As Object, e As EventArgs) Handles btnBorrowed.Click
        Dim bh As New BorrowedHistoryUser()
        BorrowedHistoryUser.bh = lbUserID.Text
        bh.TopLevel = False
        SplitCon.Panel2.Controls.Add(bh)
        bh.BringToFront()
        bh.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        LoginDashboard.Show()
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        Dim pu As New Profile()
        Profile.pu = lbRoleID.Text
        pu.TopLevel = False
        SplitCon.Panel2.Controls.Add(pu)
        pu.BringToFront()
        pu.Show()
    End Sub
End Class