Imports MySql.Data.MySqlClient
Public Class cookieOrderForm
    Private Sub cookieOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New myConnection()
        Dim year As Integer = yearLB.Text
        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT inventory.inventoryID AS InventoryID, warehouse.name AS Warehouse, cookie.name AS Cookie,
                                            CASE
                                                WHEN ISNULL((SELECT sum(orderQuantity - returnQuantity) FROM userCookie WHERE userCookie.inventoryID = inventory.inventoryID)) = 1 THEN inventory.inQuantity
                                                ELSE inventory.inQuantity - (SELECT sum(orderQuantity - returnQuantity) FROM userCookie WHERE userCookie.inventoryID = inventory.inventoryID)
                                            END AS Remaining_Quantity
                                            FROM inventory INNER JOIN warehouse ON inventory.warehouseID = warehouse.warehouseID
                                            INNER JOIN yearCookie ON inventory.yearCookieID = yearCookie.yearCookieID
                                            INNER JOIN cookie ON cookie.cookieID = yearCookie.cookieID
                                            WHERE yearCookie.year = @year", conn.getConnection())
        command.Parameters.Add("@year", MySqlDbType.Int16).Value = year
        Dim adapter As New MySqlDataAdapter(command)
        adapter.Fill(table)
        DataGridView1.DataSource = table

        Dim table2 As New DataTable()
        Dim adapter2 As New MySqlDataAdapter("SELECT * FROM `user` ORDER BY firstName ASC", conn.getConnection())
        adapter2.Fill(table2)
        userCB.DataSource = table2
        table2.Columns.Add("full_name", Type.GetType("System.String"), "firstName + ' ' + lastName")
        userCB.DisplayMember = "full_name"
        userCB.ValueMember = "userID"
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex = -1 Then
            Return
        End If
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(e.RowIndex)
        inventoryLB.Text = selectedRow.Cells(0).Value
        warehouseLB.Text = selectedRow.Cells(1).Value
        cookieLB.Text = selectedRow.Cells(2).Value
        remainingLB.Text = selectedRow.Cells(3).Value
    End Sub
    Private Sub Insert_Click(sender As Object, e As EventArgs) Handles insert.Click
        Dim confirmMsg = MessageBox.Show("Are you sure you want to insert?", "Insert", MessageBoxButtons.YesNo)
        If confirmMsg = DialogResult.Yes Then
            Dim userID As Integer = userCB.SelectedValue
            Dim inventoryID As Integer = inventoryLB.Text
            Dim orderDate As String = DateTimePicker1.Text
            If orderTB.Text = "" Then
                orderTB.Text = "0"
            End If
            If pickupTB.Text = "" Then
                pickupTB.Text = "0"
            End If
            If returnTB.Text = "" Then
                returnTB.Text = "0"
            End If
            Dim orderQuantity As Integer = orderTB.Text
            If orderQuantity > remainingLB.Text Then
                Dim errorMsg = MessageBox.Show("Order quantity cannot be greater than remaining quantity")
                Exit Sub
            End If
            Dim pickupQuantity As Integer = pickupTB.Text
            If pickupQuantity > orderQuantity Then
                Dim errorMsg2 = MessageBox.Show("Pickup quantity cannot be greater than order quantity")
                Exit Sub
            End If
            Dim returnQuantity As Integer = returnTB.Text
            If returnQuantity > pickupQuantity Then
                Dim errorMsg3 = MessageBox.Show("Return quantity cannot be greater than pickup quantity")
                Exit Sub
            End If
            Dim note As String = noteTE.Text

            Dim conn As New myConnection()
            Dim command As New MySqlCommand("INSERT INTO `userCookie`(`userID`, `inventoryID`, `date`, `orderQuantity`, `pickupQuantity`, `returnQuantity`, `note`) VALUES (@userID, @inventoryID, @date, @orderQuantity, @pickupQuantity, @returnQuantity, @note)", conn.getConnection())
            command.Parameters.Add("@userID", MySqlDbType.Int16).Value = userID
            command.Parameters.Add("@inventoryID", MySqlDbType.Int16).Value = inventoryID
            command.Parameters.Add("@date", MySqlDbType.Date).Value = Date.Parse(orderDate).ToString("yyyy-MM-dd")
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
    Private Sub Update_Click(sender As Object, e As EventArgs) Handles update.Click
        If cookieOrderLB.Text = "" Then
            MsgBox("Cannot update without valid ID")

        Else
            Dim confirmMsg = MessageBox.Show("Are you sure you want to update?", "Update", MessageBoxButtons.YesNo)
            If confirmMsg = DialogResult.Yes Then

                Dim userCookieID As Integer = cookieOrderLB.Text
                Dim userID As Integer = userCB.SelectedValue
                Dim inventoryID As Integer = inventoryLB.Text
                Dim orderDate As String = DateTimePicker1.Text

                If orderTB.Text = "" Then
                    orderTB.Text = "0"
                End If
                If pickupTB.Text = "" Then
                    pickupTB.Text = "0"
                End If
                If returnTB.Text = "" Then
                    returnTB.Text = "0"
                End If

                Dim orderQuantity As Integer = orderTB.Text
                If orderQuantity > remainingLB.Text Then
                    Dim errorMsg = MessageBox.Show("Order quantity cannot be greater than remaining quantity")
                    Exit Sub
                End If
                Dim pickupQuantity As Integer = pickupTB.Text
                If pickupQuantity > orderQuantity Then
                    Dim errorMsg2 = MessageBox.Show("Pickup quantity cannot be greater than order quantity")
                    Exit Sub
                End If
                Dim returnQuantity As Integer = returnTB.Text
                If returnQuantity > pickupQuantity Then
                    Dim errorMsg3 = MessageBox.Show("Return quantity cannot be greater than pickup quantity")
                    Exit Sub
                End If

                Dim note As String = noteTE.Text

                Dim conn As New myConnection()
                Dim command As New MySqlCommand("UPDATE `userCookie` SET userCookieID = @userCookieID, userID = @userID, inventoryID = @inventoryID, date = @date, orderQuantity = @orderQuantity, pickupQuantity = @pickupQuantity, returnQuantity = @returnQuantity, note = @note WHERE userCookieID = @userCookieID", conn.getConnection())

                command.Parameters.Add("@userCookieID", MySqlDbType.Int16).Value = userCookieID
                command.Parameters.Add("@userID", MySqlDbType.Int16).Value = userID
                command.Parameters.Add("@inventoryID", MySqlDbType.Int16).Value = inventoryID
                command.Parameters.Add("@date", MySqlDbType.Date).Value = Date.Parse(orderDate).ToString("yyyy-MM-dd")
                command.Parameters.Add("@orderQuantity", MySqlDbType.Int16).Value = orderQuantity
                command.Parameters.Add("@pickupQuantity", MySqlDbType.Int16).Value = pickupQuantity
                command.Parameters.Add("@returnQuantity", MySqlDbType.Int16).Value = returnQuantity
                command.Parameters.Add("@note", MySqlDbType.VarChar).Value = note


                conn.openConnection()

                If command.ExecuteNonQuery() = 1 Then
                    MsgBox("ORDER UPDATED")
                    conn.closeConnection()
                    Me.Close()
                Else
                    MsgBox("ORDER NOT UPDATED")
                    conn.closeConnection()
                End If
            End If
        End If
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        If cookieOrderLB.Text = "" Then
            MsgBox("Cannot delete without valid ID")

        Else
            Dim confirmMsg = MessageBox.Show("Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo)
            If confirmMsg = DialogResult.Yes Then

                Dim userCookieID As Integer = cookieOrderLB.Text

                Dim conn As New myConnection()
                Dim command As New MySqlCommand("DELETE FROM `userCookie` WHERE userCookieID = @userCookieID", conn.getConnection())

                command.Parameters.Add("@userCookieID", MySqlDbType.VarChar).Value = userCookieID

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
End Class