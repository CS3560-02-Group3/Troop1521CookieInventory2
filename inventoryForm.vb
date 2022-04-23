'Imports MySql.Data.MySqlClient
'Imports System


Public Class inventoryForm

    '    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles submit.Click
    '            Dim inventyID As Integer = inventoryIDTB.Text
    '            Dim warehouseID As Integer = warehouseIDTB.Text
    '            Dim yearCookieID As Integer = yearCookieIDTB.Text
    '        Dim dateID As Integer = dateIDTB.Text
    '        Dim inQuantity As Integer = inQuantityTB.Text
    '        Dim note As String = noteTB.Text

    '            Dim conn As New myConnection()
    '            Dim command As New MySqlCommand("INSERT INTO `user`(`inventoryID`, `warehouseID`, `yearCookieID`, `data`, `inQuantity`, `note`) VALUES (@inventoryID, @warehouseID, @yearCookieID, @date, @inQuantity, @note)", conn.getConnection())

    '            command.Parameters.Add("@inventoryID", MySqlDbType.VarChar).Value = inventoryID
    '            command.Parameters.Add("@warehouseID", MySqlDbType.VarChar).Value = warehouseID
    '            command.Parameters.Add("@yearCookieID", MySqlDbType.VarChar).Value = yearCookieID
    '        command.Parameters.Add("@dateID", MySqlDbType.VarChar).Value = dateID
    '        command.Parameters.Add("@inQuantity", MySqlDbType.VarChar).Value = inQuantity
    '        command.Parameters.Add("@note", MySqlDbType.VarChar).Value = note

    '            conn.openConnection()

    '            If command.ExecuteNonQuery() = 1 Then
    '                MsgBox("COOKIE INSERTED INTO WAREHOUSE'S INVENTORY")
    '                conn.closeConnection()
    '            Else
    '                MsgBox("COOKIE NOT INSERTED INTO WAREHOUSE'S INVENTORY")
    '                conn.closeConnection()
    '            End If
    '        End Sub

    '    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    '    End Sub

    '    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    '    End Sub

    '    Private Sub inventoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    '    End Sub
End Class