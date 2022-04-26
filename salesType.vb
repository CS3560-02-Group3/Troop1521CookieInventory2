Imports MySql.Data.MySqlClient

Public Class salesType

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        If salesTypes.Text = "" Then
            MsgBox("Cannot submit without valid Sales Type")
        Else
            ' Show this message below in a message box with the yes and no options 
            Dim confirmMsg = MessageBox.Show("Are you sure you want to submit?", "Submit", MessageBoxButtons.YesNo)
            ' If no is clicked, do nothing
            ' I yes is clicked, do the following
            If confirmMsg = DialogResult.Yes Then
                ' text in the textboxes are assigned to each variable
                ' if no text, then submit empty string
                Dim salesType As String = salesTypes.Text
                ' Assign the connection to the Sql Database to a variable
                Dim conn As New myConnection()
                ' Command an INSERT query INTO the user table
                ' followed by getting the connection to the Sql Database
                Dim command As New MySqlCommand("INSERT INTO `salesType`(`name`) VALUES (@salesType)", conn.getConnection())
                ' replace the placeholder variables with the textbox variables
                ' the variable type should match what is in the Sql Database
                command.Parameters.Add("@salesType", MySqlDbType.VarChar).Value = salesType
                ' opening a connection to the Sql Database to execute the command INSERT query
                conn.openConnection()
                ' Show a confirmation message that the query was correctly executed
                If command.ExecuteNonQuery() = 1 Then
                    MsgBox("SALES TYPE INSERTED")
                    ' close the connection to the Sql Database
                    conn.closeConnection()
                Else
                    ' Show an error message that the query was not executed
                    MsgBox("SALES TYPE NOT INSERTED")
                    ' close the connection to the Sql Database
                    conn.closeConnection()
                End If
            End If
        End If
    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        ' error handling when the query WHERE is not given a Sales Type ID
        If salesTypeIDTB.Text = "" Then
            MsgBox("Cannot update without valid Sales Type ID")

        Else
            Dim confirmMsg = MessageBox.Show("Are you sure you want to update?", "Update", MessageBoxButtons.YesNo)
            If confirmMsg = DialogResult.Yes Then

                Dim salesTypeID As Integer = salesTypeIDTB.Text
                Dim salesType As String = salesTypes.Text

                Dim conn As New myConnection()
                ' Command a query UPDATE a row in the user table. SET the variables to values WHERE the salesTypeID is.
                Dim command As New MySqlCommand("UPDATE `salesType` SET name = @salesType WHERE salesTypeID = @salesTypeID", conn.getConnection())

                command.Parameters.Add("@salesTypeID", MySqlDbType.Int16).Value = salesTypeID
                command.Parameters.Add("@salesType", MySqlDbType.VarChar).Value = salesType

                conn.openConnection()

                If command.ExecuteNonQuery() = 1 Then
                    MsgBox("SALES TYPE UPDATED")
                    conn.closeConnection()
                Else
                    MsgBox("SALES TYPE NOT NOT UPDATED")
                    conn.closeConnection()
                End If
            End If
        End If
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        ' error handling when the query WHERE is not given a salesTypeID
        If salesTypeIDTB.Text = "" Then
            MsgBox("Cannot delete without valid Sales Type ID")

        Else
            Dim confirmMsg = MessageBox.Show("Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo)
            If confirmMsg = DialogResult.Yes Then

                Dim salesTypeID As Integer = salesTypeIDTB.Text

                Dim conn As New myConnection()
                ' Command a query DELETE a row FROM the user table WHERE the salesTypeID is.
                Dim command As New MySqlCommand("DELETE FROM `salesType` WHERE salesTypeID = @salesTypeID", conn.getConnection())

                command.Parameters.Add("@salesTypeID", MySqlDbType.Int16).Value = salesTypeID

                conn.openConnection()

                If command.ExecuteNonQuery() = 1 Then
                    MsgBox("SALES TYPE DELETED")
                    conn.closeConnection()
                Else
                    MsgBox("SALES TYPE NOT DELETED")
                    conn.closeConnection()
                End If
            End If
        End If
    End Sub

End Class