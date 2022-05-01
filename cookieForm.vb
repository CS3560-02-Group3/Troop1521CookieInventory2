Imports MySql.Data.MySqlClient
Public Class cookieForm
    Private Sub insert_Click(sender As Object, e As EventArgs) Handles insert.Click
        If cookieNameTB.Text = "" Then
            MsgBox("Please enter a valid cookie name")

        Else
            Dim confirmMsg = MessageBox.Show("Are you sure you want to insert?", "Insert", MessageBoxButtons.YesNo)
            If confirmMsg = DialogResult.Yes Then
                Dim cookieName As String = cookieNameTB.Text
                Dim conn As New myConnection()
                Dim command As New MySqlCommand("INSERT INTO `cookie`(`name`) VALUES (@cookieName)", conn.getConnection())
                command.Parameters.Add("@cookieName", MySqlDbType.VarChar).Value = cookieName
                conn.openConnection()

                If command.ExecuteNonQuery() = 1 Then
                    MsgBox("COOKIE INSERTED")
                    conn.closeConnection()
                Else
                    MsgBox("COOKIE NOT INSERTED")
                    conn.closeConnection()
                End If
            End If
        End If
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        If cookieIDText.Text = "" Then
            MsgBox("Cannot delete without valid ID")

        Else
            Dim confirmMsg = MessageBox.Show("Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo)
            If confirmMsg = DialogResult.Yes Then

                Dim cookieName As String = cookieNameTB.Text
                Dim cookieID As Integer = cookieIDText.Text

                Dim conn As New myConnection()
                Dim command As New MySqlCommand("DELETE FROM `userCookie` WHERE userCookieID = @cookieID", conn.getConnection())

                command.Parameters.Add("@cookieName", MySqlDbType.VarChar).Value = cookieName
                command.Parameters.Add("@cookieID", MySqlDbType.VarChar).Value = cookieID

                conn.openConnection()

                If command.ExecuteNonQuery() = 1 Then
                    MsgBox("ORDER DELETED")
                    conn.closeConnection()
                    Me.Close()
                Else
                    MsgBox("ORDER NOT DELETED")
                    conn.closeConnection()
                End If
            End If
        End If
    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        If cookieIDText.Text = "" Then
            MsgBox("Cannot update without valid ID")

        Else
            Dim confirmMsg = MessageBox.Show("Are you sure you want to update?", "Update", MessageBoxButtons.YesNo)
            If confirmMsg = DialogResult.Yes Then

                Dim cookieName As String = cookieNameTB.Text
                Dim cookieID As Integer = cookieIDText.Text

                Dim conn As New myConnection()
                Dim command As New MySqlCommand("UPDATE `user` SET cookieName = @cookieName, note = @note WHERE userID = @cookieID", conn.getConnection())

                command.Parameters.Add("@cookieName", MySqlDbType.VarChar).Value = cookieName
                command.Parameters.Add("@cookieID", MySqlDbType.VarChar).Value = cookieID

                conn.openConnection()

                If command.ExecuteNonQuery() = 1 Then
                    MsgBox("USER UPDATED")
                    conn.closeConnection()
                    Me.Close()
                Else
                    MsgBox("USER NOT UPDATED")
                    conn.closeConnection()
                End If
            End If
        End If
    End Sub


End Class