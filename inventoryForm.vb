Imports MySql.Data.MySqlClient


Public Class inventoryForm
    Private Sub insert_Click(sender As Object, e As EventArgs) Handles insert.Click
        Dim confirmMsg = MessageBox.Show("Are you sure you want to submit?", "Submit", MessageBoxButtons.YesNo)
        If confirmMsg = DialogResult.Yes Then

            Dim dateID As Integer = DateTimePicker1.Text
            Dim inQuantity As Integer = inQuantityTB.Text
            Dim note As String = noteTE.Text

            Dim conn As New myConnection()
            Dim command As New MySqlCommand("INSERT INTO `inventory`(`dateID`, `inQuantity`, `note`) VALUES (@dateID, @inQuantity, @note)", conn.getConnection())

            command.Parameters.Add("@dateID", MySqlDbType.VarChar).Value = dateID
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
                    MsgBox("COOKIE/S DELETED")
                    conn.closeConnection()
                    Me.Close()
                Else
                    MsgBox("COOKIE/S NOT DELETED")
                    conn.closeConnection()
                End If
            End If
        End If
    End Sub
    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        If inventoryIDLB.Text = "" Then
            MsgBox("Cannot update without valid ID")

        Else
            Dim confirmMsg = MessageBox.Show("Are you sure you want to update?", "Update", MessageBoxButtons.YesNo)
            If confirmMsg = DialogResult.Yes Then

                Dim dateID As Integer = DateTimePicker1.Text
                Dim inQuantity As Integer = inQuantityTB.Text
                Dim note As String = noteTE.Text

                Dim conn As New myConnection()

                Dim command As New MySqlCommand("UPDATE `inventory` SET dateID = @dateID, inQuantity = @inQuantity, note = @note WHERE inventoryID = @inventoryID", conn.getConnection())

                command.Parameters.Add("@dateID", MySqlDbType.VarChar).Value = dateID
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        If e.RowIndex = -1 Then
            Return
        End If
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(e.RowIndex)
        warehouseCB.Text = selectedRow.Cells(0).Value
        yearCookieCB.Text = selectedRow.Cells(1).Value
        inQuantityTB.Text = selectedRow.Cells(2).Value
        DateTimePicker1.Text = selectedRow.Cells(3).Value
        noteTE.Text = selectedRow.Cells(4).Value

    End Sub

    Public Sub inventory_Load()
        Dim conn As New myConnection()
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM `inventory` ORDER BY name ASC", conn.getConnection())
        adapter.Fill(table)
        warehouseCB.DataSource = table
        warehouseCB.DisplayMember = "name"
        warehouseCB.ValueMember = "warehouseID"
        yearCookieCB.DataSource = table
        yearCookieCB.DisplayMember = "name"
        yearCookieCB.ValueMember = "yearCookieID"
    End Sub

    Private Sub inventoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class