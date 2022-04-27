Imports MySql.Data.MySqlClient

Public Class mainMenu
    Private Sub mainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New myConnection()

        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM `user`", conn.getConnection())
        adapter.Fill(table)
        DataGridView1.DataSource = table

        Dim table2 As New DataTable()
        Dim adapter2 As New MySqlDataAdapter("SELECT * FROM `userCookie`", conn.getConnection())
        adapter2.Fill(table2)
        DataGridView2.DataSource = table2

        Dim table3 As New DataTable()
        Dim adapter3 As New MySqlDataAdapter("SELECT * FROM `cookie`", conn.getConnection())
        adapter3.Fill(table3)
        DataGridView3.DataSource = table3
    End Sub
    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        Dim myForm As New userForm
        myForm.Show()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex = -1 Then
            Return
        End If
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(e.RowIndex)
        Dim myForm As New userForm
        myForm.userIDText.Text = selectedRow.Cells(0).Value
        myForm.firstNameTB.Text = selectedRow.Cells(1).Value
        myForm.lastNameTB.Text = selectedRow.Cells(2).Value
        myForm.addressTB.Text = selectedRow.Cells(3).Value
        myForm.emailTB.Text = selectedRow.Cells(4).Value
        myForm.phoneTB.Text = selectedRow.Cells(5).Value
        myForm.gradeTB.Text = selectedRow.Cells(6).Value
        myForm.noteTE.Text = selectedRow.Cells(7).Value
        myForm.Show()
        mainMenu_Load(e, e)

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        If e.RowIndex = -1 Then
            Return
        End If
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView2.Rows(e.RowIndex)
        Dim myForm As New cookieOrder
        myForm.orderIDTE.Text = selectedRow.Cells(0).Value
        myForm.userIDTE.Text = selectedRow.Cells(0).Value
        myForm.inventoryIDTE.Text = selectedRow.Cells(1).Value
        myForm.yearCookieIDTE.Text = selectedRow.Cells(2).Value
        myForm.DateTimePicker1.Text = selectedRow.Cells(3).Value
        myForm.orderQTB.Text = selectedRow.Cells(4).Value
        myForm.pickupQTB.Text = selectedRow.Cells(5).Value
        myForm.returnQTB.Text = selectedRow.Cells(6).Value
        myForm.cookieNTB.Text = selectedRow.Cells(7).Value
        myForm.Show()
        mainMenu_Load(e, e)
    End Sub

    Private Sub cookieForm_Click(sender As Object, e As EventArgs)
        Dim myForm As New cookieForm
        myForm.Show()
    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex = -1 Then
            Return
        End If
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView3.Rows(e.RowIndex)
        Dim myForm As New cookieForm
        myForm.cookieIDText.Text = selectedRow.Cells(0).Value
        myForm.cookieNameTB.Text = selectedRow.Cells(1).Value
        myForm.Show()
        mainMenu_Load(e, e)
    End Sub
    Private Sub load_Click(sender As Object, e As EventArgs) Handles load.Click
        mainMenu_Load(e, e)
    End Sub
    Private Sub load3_Click(sender As Object, e As EventArgs)
        mainMenu_Load(e, e)
    End Sub
    Private Sub yearCookieForm_Click(sender As Object, e As EventArgs) Handles yearCookieForm.Click
        Dim myForm As New yearCookieForm
        myForm.Show()
    End Sub
End Class