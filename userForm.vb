Imports MySql.Data.MySqlClient
Public Class userForm
    ' When the insert button is clicked
    Private Sub insert_Click(sender As Object, e As EventArgs) Handles insert.Click
        ' Show this message below in a message box with the yes and no options 
        Dim confirmMsg = MessageBox.Show("Are you sure you want to insert?", "Insert", MessageBoxButtons.YesNo)
        ' If no is clicked, do nothing
        ' I yes is clicked, do the following
        If confirmMsg = DialogResult.Yes Then
            ' text in the textboxes are assigned to each variable
            ' if no text, then submit empty string
            Dim firstName As String = firstNameTB.Text
            Dim lastName As String = lastNameTB.Text
            Dim address As String = addressTB.Text
            Dim email As String = emailTB.Text
            Dim phone As String = phoneTB.Text
            ' error handling for inability to convert empty string to Integer
            If gradeTB.Text = "" Then
                gradeTB.Text = "0"
            End If
            ' error handling for incorrect Integer input will not be implemented due to perfect world setting
            Dim grade As Integer = gradeTB.Text
            Dim note As String = noteTE.Text
            ' Assign the connection to the Sql Database to a variable
            Dim conn As New myConnection()
            ' Command an INSERT query INTO the user table
            ' followed by getting the connection to the Sql Database
            Dim command As New MySqlCommand("INSERT INTO `user`(`firstName`, `lastName`, `address`, `email`, `phone`, `grade`, `note`) VALUES (@firstName, @lastName, @address, @email, @phone, @grade, @note)", conn.getConnection())
            ' replace the placeholder variables with the textbox variables
            ' the variable type should match what is in the Sql Database
            command.Parameters.Add("@firstName", MySqlDbType.VarChar).Value = firstName
            command.Parameters.Add("@lastName", MySqlDbType.VarChar).Value = lastName
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = address
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone
            command.Parameters.Add("@grade", MySqlDbType.Int16).Value = grade
            command.Parameters.Add("@note", MySqlDbType.VarChar).Value = note
            ' opening a connection to the Sql Database to execute the command INSERT query
            conn.openConnection()
            ' Show a confirmation message that the query was correctly executed
            If command.ExecuteNonQuery() = 1 Then
                MsgBox("USER INSERTED")
                ' close the connection to the Sql Database
                conn.closeConnection()
            Else
                ' Show an error message that the query was not executed
                MsgBox("USER NOT INSERTED")
                ' close the connection to the Sql Database
                conn.closeConnection()
            End If
        End If
    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        ' error handling when the query WHERE is not given a userID
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
                ' Command a query UPDATE a row in the user table. SET the variables to values WHERE the userID is.
                Dim command As New MySqlCommand("UPDATE `user` SET firstName = @firstName, lastName = @lastName, address = @address, email = @email, phone = @phone, grade = @grade, note = @note WHERE userID = @userID", conn.getConnection())

                command.Parameters.Add("@userID", MySqlDbType.Int16).Value = userID
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
                    Dim parent = CType(Owner, mainMenu)
                    Me.Close()
                Else
                    MsgBox("USER NOT UPDATED")
                    conn.closeConnection()
                End If
            End If
        End If
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        ' error handling when the query WHERE is not given a userID
        If userIDText.Text = "" Then
            MsgBox("Cannot delete without valid ID")

        Else
            Dim confirmMsg = MessageBox.Show("Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo)
            If confirmMsg = DialogResult.Yes Then

                Dim userID As Integer = userIDText.Text

                Dim conn As New myConnection()
                ' Command a query DELETE a row FROM the user table WHERE the userID is.
                Dim command As New MySqlCommand("DELETE FROM `user` WHERE userID = @userID", conn.getConnection())

                command.Parameters.Add("@userID", MySqlDbType.Int16).Value = userID

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

    Private Sub userForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class