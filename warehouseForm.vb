﻿Imports MySql.Data.MySqlClient
Public Class warehouseform
    Private Sub Insert_Click(sender As Object, e As EventArgs) Handles Insert.Click
        Dim confirmMsg = MessageBox.Show("Are you sure you want to insert?", "Insert", MessageBoxButtons.YesNo)

        If confirmMsg = DialogResult.Yes Then

            Dim name As String = nameTB.Text
            Dim address As String = AddressTB.Text
            Dim phone As String = PhoneTB.Text
            Dim note As String = noteTE.Text

            Dim conn As New myConnection()

            'fix SQL query below
            Dim command As New MySqlCommand("INSERT INTO `warehouse`(`name`, `address`,  `phone`, `note`) VALUES (@name,  @address, @phone, @note)", conn.getConnection())

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = address
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone
            command.Parameters.Add("@note", MySqlDbType.VarChar).Value = note

            conn.openConnection()

            If command.ExecuteNonQuery() = 1 Then
                MsgBox("Warehouse INSERTED")

                conn.closeConnection()
            Else

                MsgBox("Warehouse NOT INSERTED")

                conn.closeConnection()
            End If
        End If


    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        If warehouseLB.Text = "" Then
            MsgBox("Cannot update without valid ID")

        Else
            Dim confirmMsg = MessageBox.Show("Are you sure you want to update?", "Update", MessageBoxButtons.YesNo)
            If confirmMsg = DialogResult.Yes Then

                Dim warehouseID As Integer = warehouseLB.Text
                Dim Name As String = nameTB.Text
                Dim address As String = AddressTB.Text
                Dim phone As Integer = PhoneTB.Text
                Dim note As String = noteTE.Text

                Dim conn As New myConnection()
                ' fix SQL query below
                Dim command As New MySqlCommand("UPDATE `warehouse` SET Name = @Name, address = @address, phone = @phone,  note = @note WHERE warehouseID = @warehouseID", conn.getConnection())

                command.Parameters.Add("@warehouseID", MySqlDbType.Int16).Value = warehouseID
                command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = Name
                command.Parameters.Add("@address", MySqlDbType.VarChar).Value = address
                command.Parameters.Add("@phone", MySqlDbType.Int16).Value = phone
                command.Parameters.Add("@note", MySqlDbType.VarChar).Value = note

                conn.openConnection()

                If command.ExecuteNonQuery() = 1 Then
                    MsgBox("WarehouseUPDATED")
                    conn.closeConnection()
                    Me.Close()
                Else
                    MsgBox("Warehouse not UPDATED")
                    conn.closeConnection()
                End If
            End If
        End If
    End Sub
    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        ' error handling when the query WHERE is not given a userID
        If warehouseLB.Text = "" Then
            MsgBox("Cannot delete without valid ID")

        Else
            Dim confirmMsg = MessageBox.Show("Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo)
            If confirmMsg = DialogResult.Yes Then

                Dim warehouseID As Integer = warehouseLB.Text

                Dim conn As New myConnection()
                ' Command a query DELETE a row FROM the user table WHERE the userID is.
                Dim command As New MySqlCommand("DELETE FROM `warehouse` WHERE warehouseID = @warehouseID", conn.getConnection())

                command.Parameters.Add("@warehouseID", MySqlDbType.Int16).Value = warehouseID

                conn.openConnection()

                If command.ExecuteNonQuery() = 1 Then
                    MsgBox("WAREHOUSE DELETED")
                    conn.closeConnection()
                    Me.Close()
                Else
                    MsgBox("WAREHOUSE NOT DELETED")
                    conn.closeConnection()
                End If
            End If
        End If
    End Sub
End Class