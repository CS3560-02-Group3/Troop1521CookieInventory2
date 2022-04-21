Imports MySql.Data.MySqlClient
Public Class cookieOrder
    Private Sub InsertC_Click(sender As Object, e As EventArgs) Handles insertC.Click
        Dim confirmMsg = MessageBox.Show("Are you sure you want to insert?", "Insert", MessageBoxButtons.YesNo)
        If confirmMsg = DialogResult.Yes Then

            Dim dateC As String = DateTimePicker1.Text
            Dim orderQuantity As Integer = orderQTB.Text
            Dim pickupQuantity As Integer = pickupQTB.Text
            Dim returnQuantity As Integer = returnQTB.Text

            If orderQTB.Text = "" Then
                orderQTB.Text = "0"
            End If
            If pickupQTB.Text = "" Then
                pickupQTB.Text = "0"
            End If
            If returnQTB.Text = "" Then
                returnQTB.Text = "0"
            End If

            Dim note As String = cookieNTB.Text

            Dim conn As New myConnection()
            Dim command As New MySqlCommand("INSERT INTO `userCookie`(`dateC`, `orderQuantity`, `pickupQuantity`, `returnQuantity`, `note`) VALUES (@dateC, @orderQuantity, @pickupQuantity, @returnQuantity, @note)", conn.getConnection())
            command.Parameters.Add("@dateC", MySqlDbType.VarChar).Value = dateC
            command.Parameters.Add("@orderQuantity", MySqlDbType.Int16).Value = orderQuantity
            command.Parameters.Add("@pickupQuantity", MySqlDbType.Int16).Value = pickupQuantity
            command.Parameters.Add("@returnQuantity", MySqlDbType.Int16).Value = returnQuantity
            command.Parameters.Add("@note", MySqlDbType.VarChar).Value = note

            conn.openConnection()

            If command.ExecuteNonQuery() = 1 Then
                MsgBox("ORDER INSERTED")
                conn.closeConnection()
            Else
                MsgBox("ORDER NOT INSERTED")
                conn.closeConnection()
            End If
        End If
    End Sub

    Private Sub UpdateC_Click(sender As Object, e As EventArgs) Handles updateC.Click
        If orderIDTE.Text = "" Then
            MsgBox("Cannot update without valid ID")

        Else
            Dim confirmMsg = MessageBox.Show("Are you sure you want to update?", "Update", MessageBoxButtons.YesNo)
            If confirmMsg = DialogResult.Yes Then

                Dim userCookieID As Integer = userCookieIDTE.Text
                Dim userID As Integer = userIDTE.Text
                Dim inventoryID As Integer = inventoryIDTE.Text
                Dim yearCookieID As Integer = yearCookieIDTE.Text
                Dim dateC As String = DateTimePicker1.Text
                Dim orderQuantity As Integer = orderQTB.Text
                Dim pickupQuantity As Integer = pickupQTB.Text
                Dim returnQuantity As Integer = returnQTB.Text

                If orderQTB.Text = "" Then
                    orderQTB.Text = "0"
                End If
                If pickupQTB.Text = "" Then
                    pickupQTB.Text = "0"
                End If
                If returnQTB.Text = "" Then
                    returnQTB.Text = "0"
                End If

                Dim note As String = cookieNTB.Text

                Dim conn As New myConnection()
                Dim command As New MySqlCommand("UPDATE `userCookie` SET userID = @userID, inventoryID = @inventoryID, yearCookieID = @yearCookieID, dateC = @dateC, orderQuantity = @orderQuantity, pickupQuantity = @pickupQuantity, returnQuantity = @returnQuantity, note = @note WHERE userCookieID = @userCookieID", conn.getConnection())

                command.Parameters.Add("@userCookieID", MySqlDbType.Int16).Value = userCookieID
                command.Parameters.Add("@userID", MySqlDbType.VarChar).Value = userID
                command.Parameters.Add("@inventoryID", MySqlDbType.Int16).Value = inventoryID
                command.Parameters.Add("@yearCookieID", MySqlDbType.Int16).Value = yearCookieID
                command.Parameters.Add("@dateC", MySqlDbType.VarChar).Value = dateC
                command.Parameters.Add("@orderQuantity", MySqlDbType.Int16).Value = orderQuantity
                command.Parameters.Add("@pickupQuantity", MySqlDbType.Int16).Value = pickupQuantity
                command.Parameters.Add("@returnQuantity", MySqlDbType.Int16).Value = returnQuantity
                command.Parameters.Add("@note", MySqlDbType.VarChar).Value = note


                conn.openConnection()

                If command.ExecuteNonQuery() = 1 Then
                    MsgBox("ORDER UPDATED")
                    conn.closeConnection()
                Else
                    MsgBox("ORDER NOT UPDATED")
                    conn.closeConnection()
                End If
            End If
        End If
    End Sub

    Private Sub DeleteC_Click(sender As Object, e As EventArgs) Handles deleteC.Click
        If orderIDTE.Text = "" Then
            MsgBox("Cannot delete without valid ID")

        Else
            Dim confirmMsg = MessageBox.Show("Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo)
            If confirmMsg = DialogResult.Yes Then

                Dim userCookieID As Integer = orderIDTE.Text

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
End Class