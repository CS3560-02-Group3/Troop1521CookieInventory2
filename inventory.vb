Option Explicit On
Option Strict On
Imports MySql.Data.MySqlClient
Imports System
Public Class inventory
    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        Dim inventyID As Integer = inventoryIDTB.Text
        Dim warehouseID As Integer = warehouseIDTB.Text
        Dim yearCookieID As Integer = yearCookieIDTB.Text
        Dim date As Integer = dateTB.Text
        Dim inQuantity As Integer = inQuantityB.Text
        Dim note As String = noteTB.Text

        Dim conn As New myConnection()
        Dim command As New MySqlCommand("INSERT INTO `user`(`inventoryID`, `warehouseID`, `yearCookieID`, `data`, `inQuantity`, `note`) VALUES (@inventoryID, @warehouseID, @yearCookieID, @date, @inQuantity, @note)", conn.getConnection())

        command.Parameters.Add("@inventoryID", MySqlDbType.VarChar).Value = inventoryID
        command.Parameters.Add("@warehouseID", MySqlDbType.VarChar).Value = warehouseID
        command.Parameters.Add("@yearCookieID", MySqlDbType.VarChar).Value = yearCookieID
        command.Parameters.Add("@data", MySqlDbType.VarChar).Value = Data
        command.Parameters.Add("@inQuantity", MySqlDbType.VarChar).Value = inQuantity
        command.Parameters.Add("@note", MySqlDbType.VarChar).Value = note

        conn.openConnection()

        If command.ExecuteNonQuery() = 1 Then
            MsgBox("COOKIE INSERTED INTO WAREHOUSE'S INVENTORY")
            conn.closeConnection()
        Else
            MsgBox("COOKIE NOT INSERTED INTO WAREHOUSE'S INVENTORY")
            conn.closeConnection()
        End If
    End Sub
End Class
