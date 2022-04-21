Imports MySql.Data.MySqlClient
Public Class cookieOrder
    Private Sub InsertC_Click(sender As Object, e As EventArgs) Handles insertC.Click
        Dim confirmMsg = MessageBox.Show("Are you sure you want to insert?", "Insert", MessageBoxButtons.YesNo)
        If confirmMsg = DialogResult.Yes Then

            Dim dateInfo As String = DateTimePicker1.Text
            Dim orderQ As Integer = orderQTB.Text
            Dim pickupQ As Integer = pickupQTB.Text
            Dim returnQ As Integer = returnQTB.Text

            If orderQTB.Text = "" Then
                orderQTB.Text = "0"
            End If
            If pickupQTB.Text = "" Then
                pickupQTB.Text = "0"
            End If
            If returnQTB.Text = "" Then
                returnQTB.Text = "0"
            End If

            Dim cookienote As String = cookieNTB.Text

            Dim conn As New myConnection()
            Dim command As New MySqlCommand("INSERT INTO `order`(`date`, `orderQ`, `pickupQ`, `returnQ`, `cookienote`) VALUES (@orderQ, @pickupQ, @returnQ, @cookienote)", conn.getConnection())
            command.Parameters.Add("@date", MySqlDbType.VarChar).Value = dateInfo
            command.Parameters.Add("@orderQ", MySqlDbType.Int16).Value = orderQ
            command.Parameters.Add("@pickupQ", MySqlDbType.Int16).Value = pickupQ
            command.Parameters.Add("@returnQ", MySqlDbType.Int16).Value = returnQ
            command.Parameters.Add("@cookienote", MySqlDbType.VarChar).Value = cookienote

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

                Dim orderID As Integer = orderIDTE.Text
                Dim userID As Integer = userIDTE.Text
                Dim inventoryID As Integer = inventoryIDTE.Text
                Dim yearCookieID As Integer = yearCookieIDTE.Text
                Dim dateInfo As String = DateTimePicker1.Text
                Dim orderQ As Integer = orderQTB.Text
                Dim pickupQ As Integer = pickupQTB.Text
                Dim returnQ As Integer = returnQTB.Text

                If orderQTB.Text = "" Then
                    orderQTB.Text = "0"
                End If
                If pickupQTB.Text = "" Then
                    pickupQTB.Text = "0"
                End If
                If returnQTB.Text = "" Then
                    returnQTB.Text = "0"
                End If

                Dim cookienote As String = cookieNTB.Text

                Dim conn As New myConnection()
                Dim command As New MySqlCommand("UPDATE `order` SET userID = @userID, inventoryID = @inventoryID, yearCookieID = @yearCookieID, dateInfo = @date, orderQ = @orderQ, pickupQ = @pickupQ, returnQ = @returnQ, cookienote = @cookienote WHERE orderID = @orderID", conn.getConnection())

                command.Parameters.Add("@orderID", MySqlDbType.Int16).Value = orderID
                command.Parameters.Add("@userID", MySqlDbType.VarChar).Value = userID
                command.Parameters.Add("@inventoryID", MySqlDbType.Int16).Value = inventoryID
                command.Parameters.Add("@yearCookieID", MySqlDbType.Int16).Value = yearCookieID
                command.Parameters.Add("@date", MySqlDbType.VarChar).Value = dateInfo
                command.Parameters.Add("@orderQ", MySqlDbType.Int16).Value = orderQ
                command.Parameters.Add("@pickupQ", MySqlDbType.Int16).Value = pickupQ
                command.Parameters.Add("@returnQ", MySqlDbType.Int16).Value = returnQ
                command.Parameters.Add("@cookienote", MySqlDbType.VarChar).Value = cookienote


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

                Dim orderID As Integer = orderIDTE.Text

                Dim conn As New myConnection()
                Dim command As New MySqlCommand("DELETE FROM `order` WHERE orderID = @orderID", conn.getConnection())

                command.Parameters.Add("@orderID", MySqlDbType.VarChar).Value = orderID

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