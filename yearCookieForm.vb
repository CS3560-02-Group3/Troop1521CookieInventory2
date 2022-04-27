Imports MySql.Data.MySqlClient
Public Class yearCookieForm
    Private Sub yearCookieForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New myConnection()
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM `cookie` ORDER BY name ASC", conn.getConnection())
        adapter.Fill(table)
        cookieCB.DataSource = table
        table.Columns.Add("cookieID_name", Type.GetType("System.String"), "name + '   ' + cookieID")
        cookieCB.DisplayMember = "cookieID_name"
        cookieCB.ValueMember = "cookieID"

    End Sub
End Class