Imports MySql.Data.MySqlClient
Public Class userForm
    Private Sub Insert_Click(sender As Object, e As EventArgs) Handles insert.Click
        Dim confirmMsg = MessageBox.Show("Are you sure you want to insert?", "Insert", MessageBoxButtons.YesNo)
        If confirmMsg = DialogResult.Yes Then

            Dim firstName As String = firstNameTB.Text
            Dim lastName As String = lastNameTB.Text
            Dim address As String = addressTB.Text
            Dim email As String = emailTB.Text
            Dim phone As String = phoneTB.Text
            If gradeTB.Text = "" Then
                gradeTB.Text = "0"
            End If
            Dim grade As Integer = gradeTB.Text
            Dim note As String = noteTE.Text

            Dim conn As New myConnection()
            Dim command As New MySqlCommand("INSERT INTO `user`(`firstName`, `lastName`, `address`, `email`, `phone`, `grade`, `note`) VALUES (@firstName, @lastName, @address, @email, @phone, @grade, @note)", conn.getConnection())
            command.Parameters.Add("@firstName", MySqlDbType.VarChar).Value = firstName
            command.Parameters.Add("@lastName", MySqlDbType.VarChar).Value = lastName
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = address
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone
            command.Parameters.Add("@grade", MySqlDbType.Int16).Value = grade
            command.Parameters.Add("@note", MySqlDbType.VarChar).Value = note

            conn.openConnection()

            If command.ExecuteNonQuery() = 1 Then
                MsgBox("USER INSERTED")
                conn.closeConnection()
            Else
                MsgBox("USER NOT INSERTED")
                conn.closeConnection()
            End If
        End If
    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        If userIDText.Text = "" Then
            MsgBox("Cannot update without valid ID")

        Else
            Dim confirmMsg = MessageBox.Show("Are you sure you want to update?", "Update", MessageBoxButtons.YesNo)
            If confirmMsg = DialogResult.Yes Then

                Dim userID As Integer = userIDText.Text
                Dim firstName As String = firstNameTB.Text
                Dim lastName As String = lastNameTB.Text
                Dim address As String = addressTB.Text
                Dim email As String = emailTB.Text
                Dim phone As String = phoneTB.Text
                If gradeTB.Text = "" Then
                    gradeTB.Text = "0"
                End If
                Dim grade As Integer = gradeTB.Text
                Dim note As String = noteTE.Text

                Dim conn As New myConnection()
                Dim command As New MySqlCommand("UPDATE `user` SET firstName = @firstName, lastName = @lastName, address = @address, email = @email, phone = @phone, grade = @grade, note = @note WHERE userID = @userID", conn.getConnection())

                command.Parameters.Add("@userID", MySqlDbType.VarChar).Value = userID
                command.Parameters.Add("@firstName", MySqlDbType.VarChar).Value = firstName
                command.Parameters.Add("@lastName", MySqlDbType.VarChar).Value = lastName
                command.Parameters.Add("@address", MySqlDbType.VarChar).Value = address
                command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email
                command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone
                command.Parameters.Add("@grade", MySqlDbType.Int16).Value = grade
                command.Parameters.Add("@note", MySqlDbType.VarChar).Value = note

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

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        If userIDText.Text = "" Then
            MsgBox("Cannot delete without valid ID")

        Else
            Dim confirmMsg = MessageBox.Show("Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo)
            If confirmMsg = DialogResult.Yes Then

                Dim userID As Integer = userIDText.Text

                Dim conn As New myConnection()
                Dim command As New MySqlCommand("DELETE FROM `user` WHERE userID = @userID", conn.getConnection())

                command.Parameters.Add("@userID", MySqlDbType.VarChar).Value = userID

                conn.openConnection()

                If command.ExecuteNonQuery() = 1 Then
                    MsgBox("USER DELETED")
                    conn.closeConnection()
                Else
                    MsgBox("USER NOT DELETED")
                    conn.closeConnection()
                End If
            End If
        End If
    End Sub
End Class