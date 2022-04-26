Imports MySql.Data.MySqlClient

Public Class userBalance
    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        If userIDTB.Text = "" Then
            MsgBox("Cannot submit without valid User ID")
        ElseIf salesTypeIDTB.Text = "" Then
            MsgBox("Cannot submit without valid Sales Type ID")
        Else
            ' Show this message below in a message box with the yes and no options 
            Dim confirmMsg = MessageBox.Show("Are you sure you want to Submit?", "Submit", MessageBoxButtons.YesNo)
            ' If no is clicked, do nothing
            ' I yes is clicked, do the following
            If confirmMsg = DialogResult.Yes Then
                ' text in the textboxes are assigned to each variable
                ' if no text, then submit empty string
                Dim userID As Integer = userIDTB.Text
                Dim salesTypeID As Integer = salesTypeIDTB.Text
                Dim receiveDate As Date = receiveDatePicker.Text
                ' error handling for inability to convert empty string to Integer
                If yearTB.Text = "" Then
                    yearTB.Text = "0"
                End If
                If receiveAmountTB.Text = "" Then
                    receiveAmountTB.Text = "0"
                End If
                ' error handling for incorrect Integer input will not be implemented due to perfect world setting
                Dim year As Integer = yearTB.Text
                Dim receiveAmount As Double = receiveAmountTB.Text
                Dim note As String = noteTB.Text
                ' Assign the connection to the Sql Database to a variable
                Dim conn As New myConnection()
                ' Command an INSERT query INTO the user table
                ' followed by getting the connection to the Sql Database
                Dim command As New MySqlCommand("INSERT INTO `userBalance`(`userID`, `salesTypeID`, `year`, `receiveDate`, `receiveAmount`, `note`) VALUES (@userID, @salesTypeID, @year, @receiveDate, @receiveAmount, @note)", conn.getConnection())
                ' replace the placeholder variables with the textbox variables
                ' the variable type should match what is in the Sql Database
                command.Parameters.Add("@userID", MySqlDbType.Int16).Value = userID
                command.Parameters.Add("@salesTypeID", MySqlDbType.Int16).Value = salesTypeID
                command.Parameters.Add("@year", MySqlDbType.Int16).Value = year
                command.Parameters.Add("@receiveDate", MySqlDbType.Date).Value = receiveDate
                command.Parameters.Add("@receiveAmount", MySqlDbType.Double).Value = receiveAmount
                command.Parameters.Add("@note", MySqlDbType.VarChar).Value = note
                ' opening a connection to the Sql Database to execute the command INSERT query
                conn.openConnection()
                ' Show a confirmation message that the query was correctly executed
                If command.ExecuteNonQuery() = 1 Then
                    MsgBox("USER BALANCE INSERTED")
                    ' close the connection to the Sql Database
                    conn.closeConnection()
                Else
                    ' Show an error message that the query was not executed
                    MsgBox("USER BALANCE NOT INSERTED")
                    ' close the connection to the Sql Database
                    conn.closeConnection()
                End If
            End If
        End If

    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        ' error handling when the query WHERE is not given a User Balance ID, User ID, or Sales Type ID
        If userBalanceIDTB.Text = "" Then
            MsgBox("Cannot update without valid User Balance ID")
        ElseIf userIDTB.Text = "" Then
            MsgBox("Cannot update without valid User ID")
        ElseIf salesTypeIDTB.Text = "" Then
            MsgBox("Cannot update without valid Sales Type ID")
        Else
            Dim confirmMsg = MessageBox.Show("Are you sure you want to update?", "Update", MessageBoxButtons.YesNo)
            If confirmMsg = DialogResult.Yes Then
                Dim userBalanceID As Integer = userBalanceIDTB.Text
                Dim userID As Integer = userIDTB.Text
                Dim salesTypeID As Integer = salesTypeIDTB.Text
                Dim receiveDate As Date = receiveDatePicker.Text
                ' error handling for inability to convert empty string to Integer
                If yearTB.Text = "" Then
                    yearTB.Text = "0"
                End If
                If receiveAmountTB.Text = "" Then
                    receiveAmountTB.Text = "0"
                End If
                ' error handling for incorrect Integer input will not be implemented due to perfect world setting
                Dim year As Integer = yearTB.Text
                Dim receiveAmount As Double = receiveAmountTB.Text
                Dim note As String = noteTB.Text
                Dim conn As New myConnection()
                ' Command a query UPDATE a row in the user table. SET the variables to values WHERE the userBalance, userID, and salesTypeID is.
                Dim command As New MySqlCommand("UPDATE `userBalance` SET year = @year, receiveDate = @receiveDate, receiveAmount = @receiveAmount, note = @note WHERE userBalanceID = @userBalanceID AND userID = @userID AND salesTypeID = @salesTypeID", conn.getConnection())
                command.Parameters.Add("@userBalanceID", MySqlDbType.Int16).Value = userBalanceID
                command.Parameters.Add("@userID", MySqlDbType.Int16).Value = userID
                command.Parameters.Add("@salesTypeID", MySqlDbType.Int16).Value = salesTypeID
                command.Parameters.Add("@year", MySqlDbType.Int16).Value = year
                command.Parameters.Add("@receiveDate", MySqlDbType.Date).Value = receiveDate
                command.Parameters.Add("@receiveAmount", MySqlDbType.Double).Value = receiveAmount
                command.Parameters.Add("@note", MySqlDbType.VarChar).Value = note

                conn.openConnection()

                If command.ExecuteNonQuery() = 1 Then
                    MsgBox("USER BALANCE UPDATED")
                    conn.closeConnection()
                Else
                    MsgBox("USER BALANCE NOT NOT UPDATED")
                    conn.closeConnection()
                End If
            End If
        End If
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        ' error handling when the query WHERE is not given a User Balance ID, userID, or Sales Type ID
        If userBalanceIDTB.Text = "" Then
            MsgBox("Cannot update without valid User Balance ID")
        ElseIf userIDTB.Text = "" Then
            MsgBox("Cannot update without valid User ID")
        ElseIf salesTypeIDTB.Text = "" Then
            MsgBox("Cannot update without valid Sales Type ID")
        Else
            Dim confirmMsg = MessageBox.Show("Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo)
            If confirmMsg = DialogResult.Yes Then

                Dim userBalanceID As Integer = userBalanceIDTB.Text
                Dim userID As Integer = userIDTB.Text
                Dim salesTypeID As Integer = salesTypeIDTB.Text

                Dim conn As New myConnection()
                ' Command a query DELETE a row FROM the user table WHERE the userBalance, userID, and salesTypeID is.
                Dim command As New MySqlCommand("DELETE FROM `userBalance` WHERE userBalanceID = @userBalanceID AND userID = @userID AND salesTypeID = @salesTypeID", conn.getConnection())

                command.Parameters.Add("@userBalanceID", MySqlDbType.Int16).Value = userBalanceID
                command.Parameters.Add("@userID", MySqlDbType.Int16).Value = userID
                command.Parameters.Add("@salesTypeID", MySqlDbType.Int16).Value = salesTypeID

                conn.openConnection()

                If command.ExecuteNonQuery() = 1 Then
                    MsgBox("USER BALANCE DELETED")
                    conn.closeConnection()
                Else
                    MsgBox("USER BALANCE NOT DELETED")
                    conn.closeConnection()
                End If
            End If
        End If
    End Sub
End Class