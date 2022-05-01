Imports MySql.Data.MySqlClient

Public Class mainMenu
    Private Sub mainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New myConnection()

        Dim Utable As New DataTable()
        Dim Uadapter As New MySqlDataAdapter("SELECT * FROM user", conn.getConnection())
        Uadapter.Fill(Utable)
        userDGV.DataSource = Utable
        totalGirlsLB.Text = userDGV.Rows.Count - 1

        Dim userFilterTable As New DataTable()
        Dim userFilterAdapter As New MySqlDataAdapter("select Column_name from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='user'", conn.getConnection())
        userFilterAdapter.Fill(userFilterTable)
        userFilterCB.DataSource = userFilterTable
        userFilterCB.DisplayMember = "Column_name"
        userFilterCB.ValueMember = "Column_name"

        Dim UCtable As New DataTable()
        Dim UCadapter As New MySqlDataAdapter("SELECT * FROM userCookie", conn.getConnection())
        UCadapter.Fill(UCtable)
        orderDGV.DataSource = UCtable

        Dim Ctable As New DataTable()
        Dim Cadapter As New MySqlDataAdapter("SELECT * FROM cookie", conn.getConnection())
        Cadapter.Fill(Ctable)
        cookieDGV.DataSource = Ctable

        Dim YCtable As New DataTable()
        Dim year = cookieYearPicker.Text
        Dim YCcommand As New MySqlCommand("SELECT yearCookieID, cookie.Name, price FROM yearCookie INNER JOIN cookie ON cookie.cookieID = yearCookieID WHERE year = @year", conn.getConnection())
        YCcommand.Parameters.Add("@year", MySqlDbType.Int16).Value = year
        Dim YCadapter As New MySqlDataAdapter(YCcommand)
        YCadapter.Fill(YCtable)
        yearCookieDGV.DataSource = YCtable

        Dim TransactionViewTable As New DataTable()
        Dim TransactionViewCommand As New MySqlCommand("SELECT year, firstName, lastName, Total_Payment,
                                          CASE
                                                WHEN ISNULL(Received_Payment) = 1 THEN 0
                                                ELSE Received_Payment
                                          END AS Received_Payment,
                                          CASE
                                                WHEN ISNULL(Received_Payment) = 1 THEN Total_Payment
                                                ELSE Total_Payment - Received_Payment
                                          END AS Remaining_Balance
                                          FROM (SELECT year, firstName, lastName, sum(orderQuantity * price) AS Total_Payment,
                                          (SELECT sum(receiveAmount) FROM userBalance WHERE salesTypeID <> 3 AND userBalance.year = @year AND userBalance.userID = user.userID) AS Received_Payment
                                          FROM userCookie INNER JOIN user ON user.userID = userCookie.userID
                                          INNER JOIN inventory ON inventory.inventoryID = userCookie.inventoryID
                                          INNER JOIN yearCookie ON inventory.yearCookieID = yearCookie.yearCookieID
                                          WHERE year = @year
                                          GROUP BY user.userID) as main", conn.getConnection())
        TransactionViewCommand.Parameters.Add("@year", MySqlDbType.Int16).Value = year
        Dim TransactionViewAdapter As New MySqlDataAdapter(TransactionViewCommand)
        TransactionViewAdapter.Fill(TransactionViewTable)
        transactionDGV.DataSource = TransactionViewTable
    End Sub
    Private Sub userDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles userDGV.CellContentClick
        If e.RowIndex = -1 Then
            Return
        End If
        Dim selectedRow As DataGridViewRow
        selectedRow = userDGV.Rows(e.RowIndex)
        Dim myForm As New userForm
        myForm.userIDText.Text = selectedRow.Cells(0).Value
        myForm.firstNameTB.Text = selectedRow.Cells(1).Value
        myForm.lastNameTB.Text = selectedRow.Cells(2).Value
        myForm.addressTB.Text = selectedRow.Cells(3).Value
        myForm.emailTB.Text = selectedRow.Cells(4).Value
        myForm.phoneTB.Text = selectedRow.Cells(5).Value
        myForm.gradeTB.Text = selectedRow.Cells(6).Value
        myForm.noteTE.Text = selectedRow.Cells(7).Value
        myForm.insert.Visible = False
        myForm.Show()
        mainMenu_Load(e, e)
    End Sub
    Private Sub orderDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles orderDGV.CellContentClick
        If e.RowIndex = -1 Then
            Return
        End If
        Dim selectedRow As DataGridViewRow
        selectedRow = orderDGV.Rows(e.RowIndex)
        Dim myForm As New cookieOrderForm
        myForm.Show()
        mainMenu_Load(e, e)
    End Sub
    Private Sub cookieDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles cookieDGV.CellContentClick
        If e.RowIndex = -1 Then
            Return
        End If
        Dim selectedRow As DataGridViewRow
        selectedRow = cookieDGV.Rows(e.RowIndex)
        Dim myForm As New cookieForm
        myForm.cookieIDText.Text = selectedRow.Cells(0).Value
        myForm.cookieNameTB.Text = selectedRow.Cells(1).Value
        myForm.insert.Visible = False
        myForm.Show()
        mainMenu_Load(e, e)
    End Sub
    Private Sub userForm_Click(sender As Object, e As EventArgs) Handles userForm.Click
        Dim myForm As New userForm
        myForm.update.Visible = False
        myForm.delete.Visible = False
        myForm.Show()
    End Sub
    Private Sub cookieForm_Click(sender As Object, e As EventArgs) Handles cookieForm.Click
        Dim myForm As New cookieForm
        myForm.update.Visible = False
        myForm.delete.Visible = False
        myForm.Show()
    End Sub
    Private Sub yearCookieForm_Click(sender As Object, e As EventArgs) Handles yearCookieForm.Click
        Dim myForm As New yearCookieForm
        myForm.yearLB.Text = cookieYearPicker.Text
        myForm.update.Visible = False
        myForm.delete.Visible = False
        myForm.Show()
    End Sub
    Private Sub cookieOrderForm_Click(sender As Object, e As EventArgs) Handles cookieOrderForm.Click
        Dim myForm As New cookieOrderForm
        myForm.yearLB.Text = cookieYearPicker.Text
        myForm.update.Visible = False
        myForm.delete.Visible = False
        myForm.Show()
    End Sub
    Private Sub warehouseForm_Click(sender As Object, e As EventArgs) Handles warehouseForm.Click
        Dim myForm As New warehouseform
        myForm.Update.Visible = False
        myForm.Delete.Visible = False
        myForm.Show()
    End Sub
    Private Sub inventoryForm_Click(sender As Object, e As EventArgs) Handles inventoryForm.Click
        Dim myForm As New inventoryForm
        'myForm.Update.Visible = False
        'myForm.Delete.Visible = False
        myForm.Show()
    End Sub
    Private Sub salesTypeForm_Click(sender As Object, e As EventArgs) Handles salesTypeForm.Click
        Dim myForm As New salesTypeForm
        myForm.Update.Visible = False
        myForm.Delete.Visible = False
        myForm.Show()
    End Sub
    Private Sub paymentForm_Click(sender As Object, e As EventArgs) Handles paymentForm.Click
        Dim myForm As New paymentForm
        myForm.yearLB.Text = cookieYearPicker.Text
        myForm.update.Visible = False
        myForm.delete.Visible = False
        myForm.Show()
    End Sub
    Private Sub load_Click(sender As Object, e As EventArgs) Handles load.Click
        mainMenu_Load(e, e)
    End Sub
    Private Sub load2_Click(sender As Object, e As EventArgs) Handles load2.Click
        mainMenu_Load(e, e)
    End Sub
    Private Sub load3_Click(sender As Object, e As EventArgs) Handles load3.Click
        mainMenu_Load(e, e)
    End Sub
    Private Sub load4_Click(sender As Object, e As EventArgs) Handles load4.Click
        mainMenu_Load(e, e)
    End Sub
    Private Sub load5_Click(sender As Object, e As EventArgs) Handles load5.Click
        mainMenu_Load(e, e)
    End Sub
    Private Sub load6_Click(sender As Object, e As EventArgs) Handles load6.Click
        mainMenu_Load(e, e)
    End Sub
    Private Sub load7_Click(sender As Object, e As EventArgs) Handles load7.Click
        mainMenu_Load(e, e)
    End Sub
    Private Sub filter_Click(sender As Object, e As EventArgs) Handles filter.Click
        If userFilterTB.Text = "" Then
            mainMenu_Load(e, e)
        Else
            Dim conn As New myConnection()
            Dim table As New DataTable()
            Dim column = userFilterCB.SelectedValue

            Dim input = ""
            If userFilterTB.Text = "userID" Then
                input = userFilterTB.Text
            Else
                input = "%" & userFilterTB.Text & "%"
            End If

            Dim command As New MySqlCommand("SELECT * FROM `user` WHERE " & column & " LIKE @input", conn.getConnection())
            command.Parameters.Add("@input", MySqlDbType.VarChar).Value = input
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(table)
            userDGV.DataSource = table
            totalGirlsLB.Text = userDGV.Rows.Count - 1
        End If
    End Sub
End Class