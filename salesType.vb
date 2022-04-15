Imports MySql.Data.MySqlClient

Public Class salesType

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        Dim salesTypeID As Integer = salesTypeIDTB.Text
        Dim salesType As String = salesTypes.Text

        Dim conn As New myConnection()
        Dim command As New MySqlCommand("INSERT INTO `salesType`(`salesTypeID`, `name`) VALUES (@salesTypeID, @salesType)", conn.getConnection())

        command.Parameters.Add("@salesTypeID", MySqlDbType.Int16).Value = salesTypeID
        command.Parameters.Add("@salesType", MySqlDbType.VarChar).Value = salesType

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