Imports MySql.Data.MySqlClient
Public Class userForm
    Private Sub Insert_Click(sender As Object, e As EventArgs) Handles insert.Click
        Dim firstName As String = firstNameTB.Text
        Dim lastName As String = lastNameTB.Text
        Dim address As String = addressTB.Text
        Dim email As String = emailTB.Text
        Dim phone As String = phoneTB.Text
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
    End Sub
End Class