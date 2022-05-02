Imports MySql.Data.MySqlClient


Public Class inventoryForm
    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles insert.Click
        Dim confirmMsg = MessageBox.Show("Are you sure you want to submit?", "Submit", MessageBoxButtons.YesNo)
        If confirmMsg = DialogResult.Yes Then

            Dim dateID As Integer = DateTimePicker1.Text
            Dim inQuantity As Integer = inQuantityTB.Text
            Dim note As String = noteTE.Text

            Dim conn As New myConnection()
            Dim command As New MySqlCommand("INSERT INTO `user`(`dateID`, `inQuantity`, `note`) VALUES (@dateID, @inQuantity, @note)", conn.getConnection())

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
    ' Private Sub Delete_Click(sender As Object, e As EventArgs) Handles delete.Click
    'If inventoryIDLB.Text = "" Then
    '       MsgBox("Cannot delete without valid ID")

    'Else
    'Dim confirmMsg = MessageBox.Show("Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo)
    'If confirmMsg = DialogResult.Yes Then
    '
    'Dim inventoryID As Integer = inventoryIDLB.Text

    'Dim conn As New myConnection()
    'Dim command As New MySqlCommand("DELETE FROM `inventory` WHERE inventoryID = @inventoryID", conn.getConnection())

    '           command.Parameters.Add("@inventoryID", MySqlDbType.VarChar).Value = inventoryID

    '          conn.openConnection()

    'If command.ExecuteNonQuery() = 1 Then
    '               MsgBox("COOKIE/S DELETED")
    '              conn.closeConnection()
    'Me.Close()
    'Else
    '               MsgBox("COOKIE/S NOT DELETED")
    '              conn.closeConnection()
    'End If
    'End If
    'End If
    'End Sub
    'Private Sub Update_Click(sender As Object, e As EventArgs) Handles update.Click
    'If inventoryIDLB.Text = "" Then
    '       MsgBox("Cannot update without valid ID")
    '
    'Else
    'Dim confirmMsg = MessageBox.Show("Are you sure you want to update?", "Update", MessageBoxButtons.YesNo)
    'If confirmMsg = DialogResult.Yes Then

    'Dim dateID As Integer = DateTimePicker1.Text
    'Dim inQuantity As Integer = inQuantityTB.Text
    'Dim note As String = noteTE.Text

    'Dim conn As New myConnection()

    'Dim command As New MySqlCommand("UPDATE `user` SET dateID = @dateID, inQuantity = @inQuantity, note = @note WHERE inventoryID = @inventoryID", conn.getConnection())

    '           command.Parameters.Add("@dateID", MySqlDbType.VarChar).Value = dateID
    '          command.Parameters.Add("@inQuantity", MySqlDbType.Int16).Value = inQuantity
    '         command.Parameters.Add("@note", MySqlDbType.VarChar).Value = note

    '        conn.openConnection()

    'If command.ExecuteNonQuery() = 1 Then
    '               MsgBox("INVENTORY UPDATED")
    '              conn.closeConnection()
    'Me.Close()
    'Else
    '               MsgBox("INVENTORY NOT UPDATED")
    '              conn.closeConnection()
    'End If
    'End If
    'End If
    'End Sub


End Class