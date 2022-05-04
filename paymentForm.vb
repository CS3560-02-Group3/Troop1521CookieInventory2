Imports MySql.Data.MySqlClient

Public Class paymentForm

    Public bLoaded As Boolean = False
    Public Sub paymentCB_Load()
        Dim conn As New myConnection()
        Dim table2 As New DataTable()
        Dim adapter2 As New MySqlDataAdapter("SELECT userID, firstName, lastName FROM user ORDER BY firstName ASC", conn.getConnection())
        adapter2.Fill(table2)
        userCB.DataSource = table2
        table2.Columns.Add("full_name", Type.GetType("System.String"), "firstName + ' ' + lastName")
        userCB.DisplayMember = "full_name"
        userCB.ValueMember = "userID"

        Dim STtable As New DataTable()
        Dim STadapter As New MySqlDataAdapter("SELECT * FROM salesType", conn.getConnection())
        STadapter.Fill(STtable)
        salesTypeCB.DataSource = STtable
        salesTypeCB.DisplayMember = "name"
        salesTypeCB.ValueMember = "salesTypeID"
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        If userCB.Text = "" Then
            MsgBox("Cannot submit without valid User ID")
        ElseIf salesTypeCB.Text = "" Then
            MsgBox("Cannot submit without valid Sales Type ID")
        ElseIf receiveAmountTB.Text = "" Then
            MsgBox("Please enter a value for the Receive Amount")
        ElseIf receiveAmountTB.Text < 0 Then
            MsgBox("Please enter a value greater than 0 for the Receive Amount")
        Else
            ' Show this message below in a message box with the yes and no options 
            Dim confirmMsg = MessageBox.Show("Are you sure you want to Submit?", "Submit", MessageBoxButtons.YesNo)
            ' If no is clicked, do nothing
            ' I yes is clicked, do the following
            If confirmMsg = DialogResult.Yes Then
                ' text in the textboxes are assigned to each variable
                ' if no text, then submit empty string
                Dim userID As Integer = userCB.SelectedValue
                Dim salesTypeID As Integer = salesTypeCB.SelectedValue
                Dim receiveDate As Date = receiveDatePicker.Text
                ' error handling for inability to convert empty string to Integer
                If yearLB.Text = "" Then
                    yearLB.Text = "0"
                End If
                If receiveAmountTB.Text = "" Then
                    receiveAmountTB.Text = "0"
                End If
                ' error handling for incorrect Integer input will not be implemented due to perfect world setting
                Dim year As Integer = yearLB.Text
                Dim remainingBalance As Double = remainingBalanceLB.Text
                Dim receiveAmount As Double = receiveAmountTB.Text
                If salesTypeID <> 3 And (receiveAmount > remainingBalance) Then
                    Dim errorMsg = MessageBox.Show("Receive amount cannot be greater than the remaining balance")
                    Exit Sub
                End If
                Dim note As String = noteTE.Text
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
        If userBalanceLB.Text = "" Then
            MsgBox("Cannot update without valid User Balance ID")
        ElseIf userCB.Text = "" Then
            MsgBox("Cannot update without valid User ID")
        ElseIf salesTypeCB.Text = "" Then
            MsgBox("Cannot update without valid Sales Type ID")
        ElseIf receiveAmountTB.Text = "" Then
            MsgBox("Please enter a value for the Receive Amount")
        ElseIf receiveAmountTB.Text < 0 Then
            MsgBox("Please enter a value greater than 0 for the Receive Amount")
        Else
            Dim confirmMsg = MessageBox.Show("Are you sure you want to update?", "Update", MessageBoxButtons.YesNo)
            If confirmMsg = DialogResult.Yes Then
                Dim userBalanceID As Integer = userBalanceLB.Text
                Dim userID As Integer = userCB.SelectedValue
                Dim salesTypeID As Integer = salesTypeCB.SelectedValue
                Dim receiveDate As Date = receiveDatePicker.Text
                ' error handling for inability to convert empty string to Integer
                If yearLB.Text = "" Then
                    yearLB.Text = "0"
                End If
                If receiveAmountTB.Text = "" Then
                    receiveAmountTB.Text = "0"
                End If
                ' error handling for incorrect Integer input will not be implemented due to perfect world setting
                Dim year As Integer = yearLB.Text
                Dim remainingBalance As Double = remainingBalanceLB.Text
                Dim receiveAmount As Double = receiveAmountTB.Text
                If salesTypeID <> 3 And (receiveAmount > remainingBalance) Then
                    Dim errorMsg = MessageBox.Show("Receive amount cannot be greater than the remaining balance")
                    Exit Sub
                End If
                Dim note As String = noteTE.Text
                Dim conn As New myConnection()
                ' Command a query UPDATE a row in the user table. SET the variables to values WHERE the userBalance, userID, and salesTypeID is.
                Dim command As New MySqlCommand("UPDATE `userBalance` SET userID = @userID, salesTypeID = @salesTypeID, year = @year, receiveDate = @receiveDate, receiveAmount = @receiveAmount, note = @note WHERE userBalanceID = @userBalanceID", conn.getConnection())
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
                    Me.Close()
                Else
                    MsgBox("USER BALANCE NOT UPDATED")
                    conn.closeConnection()
                End If
            End If
        End If
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        ' error handling when the query WHERE is not given a User Balance ID, userID, or Sales Type ID
        If userBalanceLB.Text = "" Then
            MsgBox("Cannot update without valid User Balance ID")
        ElseIf userCB.Text = "" Then
            MsgBox("Cannot update without valid User ID")
        ElseIf salesTypeCB.Text = "" Then
            MsgBox("Cannot update without valid Sales Type ID")
        Else
            Dim confirmMsg = MessageBox.Show("Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo)
            If confirmMsg = DialogResult.Yes Then

                Dim userBalanceID As Integer = userBalanceLB.Text
                Dim userID As Integer = userCB.SelectedValue
                Dim salesTypeID As Integer = salesTypeCB.SelectedValue

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
                    Me.Close()
                Else
                    MsgBox("USER BALANCE NOT DELETED")
                    conn.closeConnection()
                End If
            End If
        End If
    End Sub
    Private Sub userCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles userCB.SelectedIndexChanged
        If bLoaded Then
            setRemainingBalanceLabel()
        End If
    End Sub
    Public Sub setRemainingBalanceLabel()
        Dim conn As New myConnection()
        Dim remainingBalanceTable As New DataTable()
        Dim year = yearLB.Text
        Dim userID = userCB.SelectedValue
        Dim remainingBalanceCommand As New MySqlCommand("SELECT CASE
                                                            WHEN ISNULL(Received_Payment) = 1 THEN Total_Payment
                                                            ELSE Total_Payment - Received_Payment
                                                        END AS Remaining_Balance FROM(
                                                        SELECT sum(orderQuantity * price) AS Total_Payment,
                                                        (SELECT sum(receiveAmount) FROM userBalance WHERE salesTypeID <> 3 AND userBalance.year = @year AND userBalance.userID = user.userID) AS Received_Payment
                                                        FROM userCookie INNER JOIN user ON user.userID = userCookie.userID
                                                        INNER JOIN inventory ON inventory.inventoryID = userCookie.inventoryID
                                                        INNER JOIN yearCookie ON inventory.yearCookieID = yearCookie.yearCookieID
                                                        WHERE year = @year and user.userID = @userID
                                               GROUP BY user.userID) as main", conn.getConnection())
        remainingBalanceCommand.Parameters.Add("@userID", MySqlDbType.Int16).Value = userID
        remainingBalanceCommand.Parameters.Add("@year", MySqlDbType.Int16).Value = year
        Dim remainingBalanceAdapter As New MySqlDataAdapter(remainingBalanceCommand)
        remainingBalanceAdapter.Fill(remainingBalanceTable)
        remainingBalanceLB.Text = remainingBalanceTable.Rows(0).Item(0)

    End Sub
End Class