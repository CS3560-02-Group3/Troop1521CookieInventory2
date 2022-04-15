Imports MySql.Data.MySqlClient

Public Class userBalance
    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        Dim year As Integer = yearTB.Text
        Dim receiveDate As Integer = receiveDateTB.Text
        Dim receiveAmount As Integer = receiveAmountTB.Text
        Dim note As String = noteTB.Text

        Dim conn As New myConnection()
        Dim command As New MySqlCommand("INSERT INTO `userBalance`(`year`, `receiveDate`, `receiveAmount`, `note`) VALUES (@year, @receiveDate, @receiveAmount, @note)", conn.getConnection())

        command.Parameters.Add("@year", MySqlDbType.Int16).Value = year
        command.Parameters.Add("@receiveDate", MySqlDbType.Int16).Value = receiveDate
        command.Parameters.Add("@receiveAmount", MySqlDbType.Int16).Value = receiveAmount
        command.Parameters.Add("@note", MySqlDbType.VarChar).Value = note

        conn.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            MsgBox("USER INSERTED")
            conn.closeConnection()
        Else
            MsgBox("USER NOT INSERTED")
            conn.closeConnection()
        End If
    End Sub

End Class