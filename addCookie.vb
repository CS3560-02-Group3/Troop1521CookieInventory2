Imports MySql.Data.MySqlClient
Public Class addCookie
    Private Sub insert_Click(sender As Object, e As EventArgs) Handles insert.Click
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
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        If cookieNameTB.Text = "" Then
            MsgBox("Cannot delete without valid ID")

        Else
            Dim confirmMsg = MessageBox.Show("Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo)
            If confirmMsg = DialogResult.Yes Then

                Dim userCookieID As Integer = cookieNameTB.Text

                Dim conn As New myConnection()
                Dim command As New MySqlCommand("DELETE FROM `userCookie` WHERE userCookieID = @userCookieID", conn.getConnection())

                command.Parameters.Add("@userCookieID", MySqlDbType.VarChar).Value = userCookieID

                conn.openConnection()

                If command.ExecuteNonQuery() = 1 Then
                    MsgBox("ORDER DELETED")
                    conn.closeConnection()
                Else
                    MsgBox("ORDER NOT DELETED")
                    conn.closeConnection()
                End If
            End If
        End If
    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        If cookieNameTB.Text = "" Then
            MsgBox("Cannot update without valid ID")

        Else
            Dim confirmMsg = MessageBox.Show("Are you sure you want to update?", "Update", MessageBoxButtons.YesNo)
            If confirmMsg = DialogResult.Yes Then

                Dim cookieName As String = cookieNameTB.Text

                If cookieNameTB.Text = "" Then
                    cookieNameTB.Text = "0"
                End If


                Dim conn As New myConnection()
                Dim command As New MySqlCommand("UPDATE `user` SET cookieName = @cookieName, note = @note WHERE userID = @cookieID", conn.getConnection())


                conn.openConnection()

                If command.ExecuteNonQuery() = 1 Then
                    MsgBox("USER UPDATED")
                    conn.closeConnection()
                Else
                    MsgBox("USER NOT UPDATED")
                    conn.closeConnection()
                End If
            End If
        End If
    End Sub


End Class