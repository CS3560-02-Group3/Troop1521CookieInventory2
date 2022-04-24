Imports MySql.Data.MySqlClient


Public Class inventoryForm
    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles submit.Click
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
                MsgBox("COOKIE INSERTED INTO WAREHOUSE'S INVENTORY")
                conn.closeConnection()
            Else
                MsgBox("COOKIE NOT INSERTED INTO WAREHOUSE'S INVENTORY")
                conn.closeConnection()
            End If
        End If

    End Sub

End Class