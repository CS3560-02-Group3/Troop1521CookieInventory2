﻿Imports MySql.Data.MySqlClient

Public Class mainMenu
    Private Sub mainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New myConnection()
        Dim year = cookieYearPicker.Text

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
        Dim UCcommand As New MySqlCommand("SELECT userCookieID AS OrderID, CONCAT(user.firstName, ' ', user.lastName) AS Name, cookie.name AS Cookie, userCookie.date AS Date,
                                           orderQuantity AS Order_Quantity, pickupQuantity AS Pickup_Quantity, returnQuantity AS Return_Quantity, userCookie.note AS Note, 
                                           userCookie.userID, userCookie.inventoryID, warehouse.name,
                                           CASE
                                               WHEN ISNULL((SELECT sum(orderQuantity - returnQuantity) FROM userCookie WHERE userCookie.inventoryID = inventory.inventoryID)) = 1 THEN inventory.inQuantity
                                               ELSE inventory.inQuantity - (SELECT sum(orderQuantity - returnQuantity) FROM userCookie WHERE userCookie.inventoryID = inventory.inventoryID)
                                           END AS Remaining_Quantity
                                           FROM userCookie INNER JOIN inventory ON inventory.inventoryID = userCookie.inventoryID
                                           INNER JOIN warehouse ON warehouse.warehouseID = inventory.warehouseID
                                           INNER JOIN user ON user.userID = userCookie.userID
                                           INNER JOIN yearCookie ON yearCookie.yearCookieID = inventory.yearCookieID
                                           INNER JOIN cookie ON cookie.cookieID = yearCookie.cookieID
                                           WHERE yearCookie.year = @year", conn.getConnection())
        UCcommand.Parameters.Add("@year", MySqlDbType.Int16).Value = year
        Dim UCadapter As New MySqlDataAdapter(UCcommand)

        UCadapter.Fill(UCtable)
        orderDGV.DataSource = UCtable
        orderDGV.Columns(8).Visible = False
        orderDGV.Columns(9).Visible = False
        orderDGV.Columns(10).Visible = False
        orderDGV.Columns(11).Visible = False

        totalUserCookie.Text = orderDGV.Rows.Count - 1

        Dim orderTotal As Double
        For index As Integer = 0 To (orderDGV.RowCount - 1)
            orderTotal += Convert.ToDouble(orderDGV.Rows(index).Cells(4).Value)
        Next
        sumOfTotalOQ.Text = orderTotal

        Dim pickupTotal As Double
        For index As Integer = 0 To (orderDGV.RowCount - 1)
            pickupTotal += Convert.ToDouble(orderDGV.Rows(index).Cells(5).Value)
        Next
        sumOfTotalPQ.Text = pickupTotal

        Dim returnTotal As Double
        For index As Integer = 0 To (orderDGV.RowCount - 1)
            returnTotal += Convert.ToDouble(orderDGV.Rows(index).Cells(6).Value)
        Next
        sumOfTotalRQ.Text = returnTotal


        orderFilterCB.DisplayMember = "Text"
        orderFilterCB.ValueMember = "Value"
        Dim tb As New DataTable
        tb.Columns.Add("Text", GetType(String))
        tb.Columns.Add("Value", GetType(String))
        tb.Rows.Add("firstName", "firstName")
        tb.Rows.Add("lastName", "lastName")
        tb.Rows.Add("date", "userCookie.date")
        orderFilterCB.DataSource = tb

        Dim Ctable As New DataTable()
        Dim Cadapter As New MySqlDataAdapter("SELECT * FROM cookie", conn.getConnection())
        Cadapter.Fill(Ctable)
        cookieDGV.DataSource = Ctable

        Dim YCtable As New DataTable()
        Dim YCcommand As New MySqlCommand("SELECT yearCookieID, cookie.Name, price, cookie.cookieID FROM yearCookie INNER JOIN cookie ON cookie.cookieID = yearCookieID WHERE year = @year", conn.getConnection())
        YCcommand.Parameters.Add("@year", MySqlDbType.Int16).Value = year
        Dim YCadapter As New MySqlDataAdapter(YCcommand)
        YCadapter.Fill(YCtable)
        yearCookieDGV.DataSource = YCtable
        yearCookieDGV.Columns(3).Visible = False


        Dim TransactionViewTable As New DataTable()
        Dim TransactionViewCommand As New MySqlCommand("SELECT year, CONCAT(firstName, ' ', lastName) AS full_name, Total_Payment,
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

        Dim total As Double
        For index As Integer = 0 To (transactionDGV.RowCount - 1)
            total += Convert.ToDouble(transactionDGV.Rows(index).Cells(2).Value)
        Next
        sumOfTotalPayments.Text = total

        Dim total2 As Double
        For index As Integer = 0 To (transactionDGV.RowCount - 1)
            total2 += Convert.ToDouble(transactionDGV.Rows(index).Cells(3).Value)
        Next
        sumOfReceivedPayments.Text = total2

        Dim total3 As Double
        For index As Integer = 0 To (transactionDGV.RowCount - 1)
            total3 += Convert.ToDouble(transactionDGV.Rows(index).Cells(4).Value)
        Next
        sumOfRemainingBalance.Text = total3

        Dim TransactionFullFieldsTable As New DataTable()
        Dim TransactionFullFieldsCommand As New MySqlCommand("SELECT userBalanceID, full_name, salesType, year, receiveDate, receiveAmount, note, main.userID, salesTypeID,
                                                CASE
                                                        WHEN ISNULL(Received_Payment) = 1 THEN Total_Payment
                                                        ELSE Total_Payment - Received_Payment
                                                END AS Remaining_Balance
                                                FROM (SELECT userBalanceID, CONCAT(user.firstName, ' ', user.lastName) AS full_name, salesType.name AS salesType, 
                                                        year, receiveDate, receiveAmount, userBalance.note, user.userID, salesType.salesTypeID
                                                        FROM userBalance
                                                        INNER JOIN salesType ON salesType.salesTypeID = userBalance.salesTypeID
                                                        INNER JOIN user ON user.userID = userBalance.userID
                                                        WHERE year = @year) as main inner join
                                               (SELECT sum(orderQuantity * price) AS Total_Payment,
                                               (SELECT sum(receiveAmount) FROM userBalance WHERE salesTypeID <> 3 AND userBalance.year = @year 
                                                        AND userBalance.userID = user.userID) AS Received_Payment, user.userID
                                                        FROM userCookie INNER JOIN user ON user.userID = userCookie.userID
                                                        INNER JOIN inventory ON inventory.inventoryID = userCookie.inventoryID
                                                        INNER JOIN yearCookie ON inventory.yearCookieID = yearCookie.yearCookieID
                                                        WHERE year = @year
                                               GROUP BY user.userID) as main2 on main.userID = main2.userID", conn.getConnection())

        TransactionFullFieldsCommand.Parameters.Add("@year", MySqlDbType.Int16).Value = year
        Dim TransactionFullFieldsAdapter As New MySqlDataAdapter(TransactionFullFieldsCommand)
        TransactionFullFieldsAdapter.Fill(TransactionFullFieldsTable)
        transactionFullFieldsDGV.DataSource = TransactionFullFieldsTable
        transactionFullFieldsDGV.Columns(7).Visible = False
        transactionFullFieldsDGV.Columns(8).Visible = False
        transactionFullFieldsDGV.Columns(9).Visible = False

        Dim TransactionFilterTable As New DataTable()
        Dim transactionFilterAdapter As New MySqlDataAdapter("SELECT userID, firstName, lastName FROM user ORDER BY firstName ASC", conn.getConnection())
        transactionFilterAdapter.Fill(TransactionFilterTable)
        Dim row As DataRow = TransactionFilterTable.NewRow()
        row(0) = 0
        row(1) = ""
        TransactionFilterTable.Rows.InsertAt(row, 0)
        userTCB.DataSource = TransactionFilterTable
        TransactionFilterTable.Columns.Add("full_name", Type.GetType("System.String"), "firstName + ' ' + lastName")
        userTCB.DisplayMember = "full_name"
        userTCB.ValueMember = "userID"

        Dim SalesTypeTable As New DataTable()
        Dim SalesTypeAdapter As New MySqlDataAdapter("SELECT * FROM salesType", conn.getConnection())
        SalesTypeAdapter.Fill(SalesTypeTable)
        salesTypeDGV.DataSource = SalesTypeTable

        Dim inventoryTable As New DataTable()
        Dim inventoryCommand As New MySqlCommand("SELECT inventoryID, warehouse.name AS Warehouse, cookie.name AS Cookie, inventory.date, inventory.inQuantity, inventory.note
                                                        , warehouse.warehouseID, yearCookie.yearCookieID FROM inventory 
                                                        INNER JOIN warehouse ON inventory.warehouseID = warehouse.warehouseID
                                                        INNER JOIN yearCookie ON inventory.yearCookieID = yearCookie.yearCookieID
                                                        INNER JOIN cookie ON yearCookie.cookieID = cookie.cookieID
                                                        WHERE year = @year", conn.getConnection())
        inventoryCommand.Parameters.Add("@year", MySqlDbType.Int16).Value = year
        Dim inventoryAdapter As New MySqlDataAdapter(inventoryCommand)
        inventoryAdapter.Fill(inventoryTable)
        inventoryDGV.DataSource = inventoryTable
        inventoryDGV.Columns(6).Visible = False
        inventoryDGV.Columns(7).Visible = False

        inventoryFilterCB.DisplayMember = "Text"
        inventoryFilterCB.ValueMember = "Value"
        Dim tb2 As New DataTable
        tb2.Columns.Add("Text", GetType(String))
        tb2.Columns.Add("Value", GetType(String))
        tb2.Rows.Add("cookie", "cookie.name")
        tb2.Rows.Add("date", "inventory.date")
        inventoryFilterCB.DataSource = tb2

        Dim inventoryTotal As Double
        For index As Integer = 0 To (inventoryDGV.RowCount - 1)
            inventoryTotal += Convert.ToDouble(inventoryDGV.Rows(index).Cells(4).Value)
        Next
        sumOfIQ.Text = inventoryTotal

        Dim warehouseTable As New DataTable()
        Dim warehouseAdapter As New MySqlDataAdapter("SELECT * FROM warehouse", conn.getConnection())
        warehouseAdapter.Fill(warehouseTable)
        warehouseDGV.DataSource = warehouseTable
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
        Dim year = cookieYearPicker.Text
        Dim myForm As New cookieOrderForm
        myForm.userCB_Load()
        myForm.cookieOrderLB.Text = selectedRow.Cells(0).Value
        myForm.yearLB.Text = year
        myForm.userCB.SelectedValue = selectedRow.Cells(8).Value
        myForm.DateTimePicker1.Text = selectedRow.Cells(3).Value
        myForm.orderTB.Text = selectedRow.Cells(4).Value
        myForm.pickupTB.Text = selectedRow.Cells(5).Value
        myForm.returnTB.Text = selectedRow.Cells(6).Value
        myForm.noteTE.Text = selectedRow.Cells(7).Value
        myForm.inventoryLB.Text = selectedRow.Cells(9).Value
        myForm.warehouseLB.Text = selectedRow.Cells(10).Value
        myForm.cookieLB.Text = selectedRow.Cells(2).Value
        myForm.remainingLB.Text = selectedRow.Cells(11).Value + selectedRow.Cells(4).Value
        myForm.DataGridView1.Enabled = False
        myForm.userCB.Enabled = False
        myForm.insert.Visible = False
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
    Private Sub yearCookieDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles yearCookieDGV.CellContentClick
        If e.RowIndex = -1 Then
            Return
        End If
        Dim selectedRow As DataGridViewRow
        selectedRow = yearCookieDGV.Rows(e.RowIndex)
        Dim myForm As New yearCookieForm
        myForm.load_cookieCB()
        myForm.yearCookieLB.Text = selectedRow.Cells(0).Value
        myForm.yearLB.Text = cookieYearPicker.Text
        myForm.cookieCB.SelectedValue = selectedRow.Cells(3).Value
        myForm.priceTB.Text = selectedRow.Cells(2).Value
        myForm.insert.Visible = False
        myForm.Show()
        mainMenu_Load(e, e)
    End Sub
    Private Sub transactionFullFieldsDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles transactionFullFieldsDGV.CellContentClick
        If e.RowIndex = -1 Then
            Return
        End If
        Dim selectedRow As DataGridViewRow
        selectedRow = transactionFullFieldsDGV.Rows(e.RowIndex)
        Dim myForm As New paymentForm
        myForm.paymentCB_Load()
        myForm.userBalanceLB.Text = selectedRow.Cells(0).Value
        myForm.userCB.SelectedValue = selectedRow.Cells(7).Value
        myForm.salesTypeCB.SelectedValue = selectedRow.Cells(8).Value
        myForm.yearLB.Text = cookieYearPicker.Text
        myForm.receiveDatePicker.Text = selectedRow.Cells(4).Value
        myForm.receiveAmountTB.Text = selectedRow.Cells(5).Value
        myForm.noteTE.Text = selectedRow.Cells(6).Value
        If selectedRow.Cells(8).Value <> 3 Then
            myForm.remainingBalanceLB.Text = selectedRow.Cells(9).Value + selectedRow.Cells(5).Value
        Else
            myForm.remainingBalanceLB.Text = selectedRow.Cells(9).Value
        End If
        myForm.userCB.Enabled = False
        myForm.submit.Visible = False
        myForm.Show()
        mainMenu_Load(e, e)
    End Sub
    Private Sub salesTypeDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles salesTypeDGV.CellContentClick
        If e.RowIndex = -1 Then
            Return
        End If
        Dim selectedRow As DataGridViewRow
        selectedRow = salesTypeDGV.Rows(e.RowIndex)
        Dim myForm As New salesTypeForm
        myForm.salesTypeLB.Text = selectedRow.Cells(0).Value
        myForm.salesTypesTB.Text = selectedRow.Cells(1).Value
        myForm.insert.Visible = False
        myForm.Show()
        mainMenu_Load(e, e)
    End Sub

    Private Sub inventoryDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles inventoryDGV.CellContentClick
        If e.RowIndex = -1 Then
            Return
        End If
        Dim selectedRow As DataGridViewRow
        selectedRow = inventoryDGV.Rows(e.RowIndex)
        Dim myForm As New inventoryForm
        myForm.yearLB.Text = cookieYearPicker.Text
        myForm.inventoryIDLB.Text = selectedRow.Cells(0).Value
        myForm.warehouseCB.SelectedValue = selectedRow.Cells(6).Value
        myForm.yearCookieCB.SelectedValue = selectedRow.Cells(7).Value
        myForm.inQuantityTB.Text = selectedRow.Cells(4).Value
        myForm.DateTimePicker1.Text = selectedRow.Cells(3).Value
        myForm.noteTE.Text = selectedRow.Cells(5).Value
        myForm.insert.Visible = False
        myForm.Show()
        mainMenu_Load(e, e)
    End Sub

    Private Sub warehouseDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles warehouseDGV.CellContentClick
        If e.RowIndex = -1 Then
            Return
        End If
        Dim selectedRow As DataGridViewRow
        selectedRow = warehouseDGV.Rows(e.RowIndex)
        Dim myForm As New warehouseform
        myForm.warehouseLB.Text = selectedRow.Cells(0).Value
        myForm.nameTB.Text = selectedRow.Cells(1).Value
        myForm.AddressTB.Text = selectedRow.Cells(2).Value
        myForm.PhoneTB.Text = selectedRow.Cells(3).Value
        myForm.noteTE.Text = selectedRow.Cells(4).Value
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
        myForm.load_cookieCB()
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
        myForm.userCB_Load()
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
        myForm.yearLB.Text = cookieYearPicker.Text
        myForm.update.Visible = False
        myForm.delete.Visible = False
        myForm.Show()
    End Sub
    Private Sub salesTypeForm_Click(sender As Object, e As EventArgs) Handles salesTypeForm.Click
        Dim myForm As New salesTypeForm
        myForm.update.Visible = False
        myForm.delete.Visible = False
        myForm.Show()
    End Sub
    Private Sub paymentForm_Click(sender As Object, e As EventArgs) Handles paymentForm.Click
        Dim myForm As New paymentForm
        myForm.paymentCB_Load()
        myForm.yearLB.Text = cookieYearPicker.Text
        myForm.update.Visible = False
        myForm.delete.Visible = False
        myForm.bLoaded = True
        myForm.setRemainingBalanceLabel()
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
    Private Sub load8_Click(sender As Object, e As EventArgs) Handles load8.Click
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

    Private Sub transactionFilter_Click(sender As Object, e As EventArgs) Handles transactionFilter.Click
        Dim conn As New myConnection()
        Dim table As New DataTable()
        Dim column = inventoryFilterCB.SelectedValue
        Dim year = cookieYearPicker.Text
        Dim table2 As New DataTable()
        Dim input As Integer = userTCB.SelectedValue
        If input = 0 Then
            mainMenu_Load(e, e)
        Else
            Dim command As New MySqlCommand("SELECT userBalanceID, full_name, salesType, year, receiveDate, receiveAmount, note, main.userID, salesTypeID,
                                                CASE
                                                        WHEN ISNULL(Received_Payment) = 1 THEN Total_Payment
                                                        ELSE Total_Payment - Received_Payment
                                                END AS Remaining_Balance
                                                FROM (SELECT userBalanceID, CONCAT(user.firstName, ' ', user.lastName) AS full_name, salesType.name AS salesType, 
                                                        year, receiveDate, receiveAmount, userBalance.note, user.userID, salesType.salesTypeID
                                                        FROM userBalance
                                                        INNER JOIN salesType ON salesType.salesTypeID = userBalance.salesTypeID
                                                        INNER JOIN user ON user.userID = userBalance.userID
                                                        WHERE year = @year AND userBalance.userID = @input) as main inner join
                                               (SELECT sum(orderQuantity * price) AS Total_Payment,
                                               (SELECT sum(receiveAmount) FROM userBalance WHERE salesTypeID <> 3 AND userBalance.year = @year 
                                                        AND userBalance.userID = user.userID) AS Received_Payment, user.userID
                                                        FROM userCookie INNER JOIN user ON user.userID = userCookie.userID
                                                        INNER JOIN inventory ON inventory.inventoryID = userCookie.inventoryID
                                                        INNER JOIN yearCookie ON inventory.yearCookieID = yearCookie.yearCookieID
                                                        WHERE year = @year 
                                               GROUP BY user.userID) as main2 on main.userID = main2.userID", conn.getConnection())
            command.Parameters.Add("@year", MySqlDbType.Int16).Value = year
            command.Parameters.Add("@input", MySqlDbType.Int16).Value = input
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(table)
            transactionFullFieldsDGV.DataSource = table

            Dim command2 As New MySqlCommand("SELECT year, CONCAT(firstName, ' ', lastName) AS full_name, Total_Payment,
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
                                          WHERE year = @year AND user.userID = @input
                                          GROUP BY user.userID) as main", conn.getConnection())
            command2.Parameters.Add("@year", MySqlDbType.Int16).Value = year
            command2.Parameters.Add("@input", MySqlDbType.Int16).Value = input
            Dim adapter2 As New MySqlDataAdapter(command2)
            adapter2.Fill(table2)
            transactionDGV.DataSource = table2

            Dim total As Double
            For index As Integer = 0 To (transactionDGV.RowCount - 1)
                total += Convert.ToDouble(transactionDGV.Rows(index).Cells(2).Value)
            Next
            sumOfTotalPayments.Text = total

            Dim total2 As Double
            For index As Integer = 0 To (transactionDGV.RowCount - 1)
                total2 += Convert.ToDouble(transactionDGV.Rows(index).Cells(3).Value)
            Next
            sumOfReceivedPayments.Text = total2

            Dim total3 As Double
            For index As Integer = 0 To (transactionDGV.RowCount - 1)
                total3 += Convert.ToDouble(transactionDGV.Rows(index).Cells(4).Value)
            Next
            sumOfRemainingBalance.Text = total3
        End If

    End Sub
    Private Sub orderFilter_Click(sender As Object, e As EventArgs) Handles orderFilter.Click
        Dim conn As New myConnection()
        Dim table As New DataTable()
        Dim column = orderFilterCB.SelectedValue
        Dim input = ""
        If orderFilterTB.Text = "orderID" Then
            input = orderFilterTB.Text
        Else
            input = "%" & orderFilterTB.Text & "%"
        End If
        Dim year = cookieYearPicker.Text
        Dim command As New MySqlCommand("SELECT userCookieID AS OrderID, CONCAT(user.firstName, ' ', user.lastName) AS Name, cookie.name AS Cookie, userCookie.date AS Date,
                                           orderQuantity AS Order_Quantity, pickupQuantity AS Pickup_Quantity, returnQuantity AS Return_Quantity, userCookie.note AS Note, 
                                           userCookie.userID, userCookie.inventoryID, warehouse.name,
                                           CASE
                                               WHEN ISNULL((SELECT sum(orderQuantity - returnQuantity) FROM userCookie WHERE userCookie.inventoryID = inventory.inventoryID)) = 1 THEN inventory.inQuantity
                                               ELSE inventory.inQuantity - (SELECT sum(orderQuantity - returnQuantity) FROM userCookie WHERE userCookie.inventoryID = inventory.inventoryID)
                                           END AS Remaining_Quantity
                                           FROM userCookie INNER JOIN inventory ON inventory.inventoryID = userCookie.inventoryID
                                           INNER JOIN warehouse ON warehouse.warehouseID = inventory.warehouseID
                                           INNER JOIN user ON user.userID = userCookie.userID
                                           INNER JOIN yearCookie ON yearCookie.yearCookieID = inventory.yearCookieID
                                           INNER JOIN cookie ON cookie.cookieID = yearCookie.cookieID
                                           WHERE yearCookie.year = @year AND " & column & " LIKE @input", conn.getConnection())
        command.Parameters.Add("@input", MySqlDbType.VarChar).Value = input
        command.Parameters.Add("@year", MySqlDbType.Int16).Value = year
        Dim adapter As New MySqlDataAdapter(command)
        adapter.Fill(table)
        orderDGV.DataSource = table

        totalUserCookie.Text = orderDGV.Rows.Count - 1

        Dim orderTotal As Double
        For index As Integer = 0 To (orderDGV.RowCount - 1)
            orderTotal += Convert.ToDouble(orderDGV.Rows(index).Cells(4).Value)
        Next
        sumOfTotalOQ.Text = orderTotal

        Dim pickupTotal As Double
        For index As Integer = 0 To (orderDGV.RowCount - 1)
            pickupTotal += Convert.ToDouble(orderDGV.Rows(index).Cells(5).Value)
        Next
        sumOfTotalPQ.Text = pickupTotal

        Dim returnTotal As Double
        For index As Integer = 0 To (orderDGV.RowCount - 1)
            returnTotal += Convert.ToDouble(orderDGV.Rows(index).Cells(6).Value)
        Next
        sumOfTotalRQ.Text = returnTotal
    End Sub

    Private Sub inventoryFilter_Click(sender As Object, e As EventArgs) Handles inventoryFilter.Click
        Dim conn As New myConnection()
        Dim table As New DataTable()
        Dim column = inventoryFilterCB.SelectedValue
        Dim input = ""
        If inventoryFilterTB.Text = "inventoryID" Then
            input = inventoryFilterTB.Text
        Else
            input = "%" & inventoryFilterTB.Text & "%"
        End If
        Dim year = cookieYearPicker.Text
        Dim command As New MySqlCommand("SELECT inventoryID, warehouse.name AS Warehouse, cookie.name AS Cookie, inventory.date, inventory.inQuantity, inventory.note
                                                        , warehouse.warehouseID, yearCookie.yearCookieID FROM inventory 
                                                        INNER JOIN warehouse ON inventory.warehouseID = warehouse.warehouseID
                                                        INNER JOIN yearCookie ON inventory.yearCookieID = yearCookie.yearCookieID
                                                        INNER JOIN cookie ON yearCookie.cookieID = cookie.cookieID WHERE year = @year AND " & column & " LIKE @input", conn.getConnection())
        command.Parameters.Add("@input", MySqlDbType.VarChar).Value = input
        command.Parameters.Add("@year", MySqlDbType.Int16).Value = year
        Dim adapter As New MySqlDataAdapter(command)
        adapter.Fill(table)
        inventoryDGV.DataSource = table

        Dim inventoryTotal As Double
        For index As Integer = 0 To (inventoryDGV.RowCount - 1)
            inventoryTotal += Convert.ToDouble(inventoryDGV.Rows(index).Cells(4).Value)
        Next
        sumOfIQ.Text = inventoryTotal
    End Sub
End Class