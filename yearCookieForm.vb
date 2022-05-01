Imports MySql.Data.MySqlClient
Public Class yearCookieForm
    Public Sub load_cookieCB()
        Dim conn As New myConnection()
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM `cookie` ORDER BY name ASC", conn.getConnection())
        adapter.Fill(table)
        cookieCB.DataSource = table
        cookieCB.DisplayMember = "name"
        cookieCB.ValueMember = "cookieID"
    End Sub


    Private Sub insert_Click(sender As Object, e As EventArgs) Handles insert.Click
        Dim confirmMsg = MessageBox.Show("Are you sure you want to insert?", "Insert", MessageBoxButtons.YesNo)
        If confirmMsg = DialogResult.Yes Then
            Dim cookieID As Integer = cookieCB.SelectedValue
            Dim year As Integer = yearLB.Text
            Dim price As Decimal = priceTB.Text
            Dim conn As New myConnection()
            Dim command As New MySqlCommand("INSERT INTO `yearCookie`(`cookieID`, `year`, `price`) VALUES (@cookieID, @year, @price)", conn.getConnection())
            command.Parameters.Add("@cookieID", MySqlDbType.Int16).Value = cookieID
            command.Parameters.Add("@year", MySqlDbType.Int16).Value = year
            command.Parameters.Add("@price", MySqlDbType.Decimal).Value = price
            conn.openConnection()
            If command.ExecuteNonQuery() = 1 Then
                MsgBox("PRICE INSERTED")
                conn.closeConnection()
            Else
                MsgBox("PRICE NOT INSERTED")
                conn.closeConnection()
            End If
        End If
    End Sub
    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        If yearCookieLB.Text = "" Then
            MsgBox("Cannot update without valid Year Cookie ID")
        Else
            Dim confirmMsg = MessageBox.Show("Are you sure you want to update?", "Update", MessageBoxButtons.YesNo)
            If confirmMsg = DialogResult.Yes Then

                Dim yearCookieID As Integer = yearCookieLB.Text
                Dim cookieID As Integer = cookieCB.Text
                Dim year As Integer = yearLB.Text
                Dim price As Decimal = priceTB.Text

                Dim conn As New myConnection()
                Dim command As New MySqlCommand("UPDATE `yearCookie` SET cookieID = @cookieID ,year = @year, price = @price WHERE yearCookieID = @yearCookieID", conn.getConnection())

                command.Parameters.Add("@yearCookieID", MySqlDbType.Int16).Value = yearCookieID
                command.Parameters.Add("@cookieID", MySqlDbType.Int16).Value = cookieID
                command.Parameters.Add("@year", MySqlDbType.Int16).Value = year
                command.Parameters.Add("@price", MySqlDbType.Decimal).Value = price

                conn.openConnection()

                If command.ExecuteNonQuery() = 1 Then
                    MsgBox("PRICE UPDATED")
                    conn.closeConnection()
                    Me.Close()
                Else
                    MsgBox("PRICE NOT UPDATED")
                    conn.closeConnection()
                End If
            End If
        End If
    End Sub
    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        If yearCookieLB.Text = "" Then
            MsgBox("Cannot update without valid Year Cookie ID")
        Else
            Dim confirmMsg = MessageBox.Show("Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo)
            If confirmMsg = DialogResult.Yes Then

                Dim yearCookieID As Integer = yearCookieLB.Text

                Dim conn As New myConnection()
                ' Command a query DELETE a row FROM the user table WHERE the userID is.
                Dim command As New MySqlCommand("DELETE FROM `yearCookie` WHERE yearCookieIDID = @yearCookieID", conn.getConnection())

                command.Parameters.Add("@yearCookieID", MySqlDbType.Int16).Value = yearCookieID

                conn.openConnection()

                If command.ExecuteNonQuery() = 1 Then
                    MsgBox("PRICE DELETED")
                    conn.closeConnection()
                    Me.Close()
                Else
                    MsgBox("PRICE NOT DELETED")
                    conn.closeConnection()
                End If
            End If
        End If
    End Sub
End Class