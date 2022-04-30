Imports MySql.Data.MySqlClient
Public Class cookieOrderForm
    Private Sub Insert_Click(sender As Object, e As EventArgs) Handles insert.Click
        Dim confirmMsg = MessageBox.Show("Are you sure you want to insert?", "Insert", MessageBoxButtons.YesNo)
        If confirmMsg = DialogResult.Yes Then

            Dim orderDate As String = DateTimePicker1.Text
            Dim orderQuantity As Integer = orderTB.Text
            Dim pickupQuantity As Integer = pickupTB.Text
            Dim returnQuantity As Integer = returnTB.Text

            If orderTB.Text = "" Then
                orderTB.Text = "0"
            End If
            If pickupTB.Text = "" Then
                pickupTB.Text = "0"
            End If
            If returnTB.Text = "" Then
                returnTB.Text = "0"
            End If

            Dim note As String = noteTE.Text

            Dim conn As New myConnection()
            Dim command As New MySqlCommand("INSERT INTO `userCookie`(`date`, `orderQuantity`, `pickupQuantity`, `returnQuantity`, `note`) VALUES (@orderDate, @orderQuantity, @pickupQuantity, @returnQuantity, @note)", conn.getConnection())
            command.Parameters.Add("@date", MySqlDbType.VarChar).Value = orderDate
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

    'Private Sub Update_Click(sender As Object, e As EventArgs) Handles update.Click
    '    If orderIDTE.Text = "" Then
    '        MsgBox("Cannot update without valid ID")

    '    Else
    '        Dim confirmMsg = MessageBox.Show("Are you sure you want to update?", "Update", MessageBoxButtons.YesNo)
    '        If confirmMsg = DialogResult.Yes Then

    '            Dim userCookieID As Integer = orderLB.Text
    '            Dim warehouseID As Integer = warehouseCB.Text
    '            Dim yearCookieID As Integer = cookieCB.Text
    '            Dim dateC As String = DateTimePicker1.Text
    '            Dim orderQuantity As Integer = orderTB.Text
    '            Dim pickupQuantity As Integer = pickupTB.Text
    '            Dim returnQuantity As Integer = returnTB.Text

    '            If orderTB.Text = "" Then
    '                orderTB.Text = "0"
    '            End If
    '            If pickupTB.Text = "" Then
    '                pickupTB.Text = "0"
    '            End If
    '            If returnTB.Text = "" Then
    '                returnTB.Text = "0"
    '            End If

    '            Dim note As String = noteTE.Text

    '            Dim conn As New myConnection()
    '            Dim command As New MySqlCommand("UPDATE `userCookie` SET userID = @userID, inventoryID = @inventoryID, yearCookieID = @yearCookieID, date = @date, orderQuantity = @orderQuantity, pickupQuantity = @pickupQuantity, returnQuantity = @returnQuantity, note = @note WHERE userCookieID = @userCookieID", conn.getConnection())

    '            command.Parameters.Add("@userCookieID", MySqlDbType.Int16).Value = userCookieID
    '            command.Parameters.Add("@yearCookieID", MySqlDbType.Int16).Value = yearCookieID
    '            command.Parameters.Add("@date", MySqlDbType.VarChar).Value = dateC
    '            command.Parameters.Add("@orderQuantity", MySqlDbType.Int16).Value = orderQuantity
    '            command.Parameters.Add("@pickupQuantity", MySqlDbType.Int16).Value = pickupQuantity
    '            command.Parameters.Add("@returnQuantity", MySqlDbType.Int16).Value = returnQuantity
    '            command.Parameters.Add("@note", MySqlDbType.VarChar).Value = note


    '            conn.openConnection()

    '            If command.ExecuteNonQuery() = 1 Then
    '                MsgBox("ORDER UPDATED")
    '                conn.closeConnection()
    '            Else
    '                MsgBox("ORDER NOT UPDATED")
    '                conn.closeConnection()
    '            End If
    '        End If
    '    End If
    'End Sub

    'Private Sub Delete_Click(sender As Object, e As EventArgs) Handles delete.Click
    '    If orderTB.Text = "" Then
    '        MsgBox("Cannot delete without valid ID")

    '    Else
    '        Dim confirmMsg = MessageBox.Show("Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo)
    '        If confirmMsg = DialogResult.Yes Then

    '            Dim userCookieID As Integer = orderTB.Text

    '            Dim conn As New myConnection()
    '            Dim command As New MySqlCommand("DELETE FROM `userCookie` WHERE userCookieID = @userCookieID", conn.getConnection())

    '            command.Parameters.Add("@userCookieID", MySqlDbType.VarChar).Value = userCookieID

    '            conn.openConnection()

    '            If command.ExecuteNonQuery() = 1 Then
    '                MsgBox("ORDER DELETED")
    '                conn.closeConnection()
    '            Else
    '                MsgBox("ORDER NOT DELETED")
    '                conn.closeConnection()
    '            End If
    '        End If
    '    End If
    'End Sub

    'Private Sub cookieOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'End Sub
End Class