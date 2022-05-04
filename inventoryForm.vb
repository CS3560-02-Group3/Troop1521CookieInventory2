Imports MySql.Data.MySqlClient
Public Class inventoryForm
    Private Sub inventoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New myConnection()
        Dim year As Integer = yearLB.Text
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT warehouseID, name FROM warehouse", conn.getConnection())
        adapter.Fill(table)
        warehouseCB.DataSource = table
        warehouseCB.DisplayMember = "name"
        warehouseCB.ValueMember = "warehouseID"

        Dim table2 As New DataTable()
        Dim command2 As New MySqlCommand("SELECT yearCookieID, cookie.name FROM yearCookie INNER JOIN cookie ON yearCookie.cookieID = cookie.cookieID WHERE year = @year", conn.getConnection())
        command2.Parameters.Add("@year", MySqlDbType.Int16).Value = year
        Dim adapter2 As New MySqlDataAdapter(command2)
        adapter2.Fill(table2)
        yearCookieCB.DataSource = table2
        yearCookieCB.DisplayMember = "name"
        yearCookieCB.ValueMember = "yearCookieID"
    End Sub
    Private Sub insert_Click(sender As Object, e As EventArgs) Handles insert.Click
        Dim confirmMsg = MessageBox.Show("Are you sure you want to submit?", "Submit", MessageBoxButtons.YesNo)
        If confirmMsg = DialogResult.Yes Then

            Dim warehouseID As Integer = warehouseCB.SelectedValue
            Dim yearCookieID As Integer = yearCookieCB.SelectedValue
            Dim dateID As String = DateTimePicker1.Text
            Dim inQuantity As Integer = inQuantityTB.Text
            Dim note As String = noteTE.Text

            Dim conn As New myConnection()
            Dim command As New MySqlCommand("INSERT INTO inventory(warehouseID, yearCookieID, date, inQuantity, note) VALUES (@warehouseID, @yearCookieID, @dateID, @inQuantity, @note)", conn.getConnection())

            command.Parameters.Add("@warehouseID", MySqlDbType.Int16).Value = warehouseID
            command.Parameters.Add("@yearCookieID", MySqlDbType.Int16).Value = yearCookieID
            command.Parameters.Add("@dateID", MySqlDbType.Date).Value = Date.Parse(dateID).ToString("yyyy-MM-dd")
            command.Parameters.Add("@inQuantity", MySqlDbType.Int16).Value = inQuantity
            command.Parameters.Add("@note", MySqlDbType.VarChar).Value = note

            conn.openConnection()

            If command.ExecuteNonQuery() = 1 Then
                MsgBox("COOKIE INSERTED INTO WAREHOUSE'S INVENTORY ")
                conn.closeConnection()
            Else
                MsgBox("COOKIE NOT INSERTED INTO WAREHOUSE'S INVENTORY ")
                conn.closeConnection()
            End If
        End If

    End Sub
    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        If inventoryIDLB.Text = "" Then
            MsgBox("Cannot update without valid ID")

        Else
            Dim confirmMsg = MessageBox.Show("Are you sure you want to update?", "Update", MessageBoxButtons.YesNo)
            If confirmMsg = DialogResult.Yes Then

                Dim inventoryID As Integer = inventoryIDLB.Text
                Dim warehouseID As Integer = warehouseCB.SelectedValue
                Dim yearCookieID As Integer = yearCookieCB.SelectedValue
                Dim dateID As String = DateTimePicker1.Text
                Dim inQuantity As Integer = inQuantityTB.Text
                Dim note As String = noteTE.Text

                Dim conn As New myConnection()

                Dim command As New MySqlCommand("UPDATE `inventory` SET warehouseID = @warehouseID, yearCookieID = @yearCookieID, date = @dateID, inQuantity = @inQuantity, note = @note WHERE inventoryID = @inventoryID", conn.getConnection())

                command.Parameters.Add("@inventoryID", MySqlDbType.Int16).Value = inventoryID
                command.Parameters.Add("@warehouseID", MySqlDbType.Int16).Value = warehouseID
                command.Parameters.Add("@yearCookieID", MySqlDbType.Int16).Value = yearCookieID
                command.Parameters.Add("@dateID", MySqlDbType.Date).Value = Date.Parse(dateID).ToString("yyyy-MM-dd")
                command.Parameters.Add("@inQuantity", MySqlDbType.Int16).Value = inQuantity
                command.Parameters.Add("@note", MySqlDbType.VarChar).Value = note

                conn.openConnection()

                If command.ExecuteNonQuery() = 1 Then
                    MsgBox("INVENTORY UPDATED")
                    conn.closeConnection()
                    Me.Close()
                Else
                    MsgBox("INVENTORY NOT UPDATED")
                    conn.closeConnection()
                End If
            End If
        End If
    End Sub
    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        If inventoryIDLB.Text = "" Then
            MsgBox("Cannot delete without valid ID")

        Else
            Dim confirmMsg = MessageBox.Show("Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo)
            If confirmMsg = DialogResult.Yes Then

                Dim inventoryID As Integer = inventoryIDLB.Text

                Dim conn As New myConnection()
                Dim command As New MySqlCommand("DELETE FROM `inventory` WHERE inventoryID = @inventoryID", conn.getConnection())

                command.Parameters.Add("@inventoryID", MySqlDbType.VarChar).Value = inventoryID

                conn.openConnection()

                If command.ExecuteNonQuery() = 1 Then
                    MsgBox("COOKIES DELETED")
                    conn.closeConnection()
                    Me.Close()
                Else
                    MsgBox("COOKIES NOT DELETED")
                    conn.closeConnection()
                End If
            End If
        End If
    End Sub
End Class