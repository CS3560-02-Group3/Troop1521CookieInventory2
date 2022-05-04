<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainMenu))
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.salesTypeForm = New System.Windows.Forms.Button()
        Me.load8 = New System.Windows.Forms.Button()
        Me.salesTypeDGV = New System.Windows.Forms.DataGridView()
        Me.cookieYearPicker = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.yearCookieDGV = New System.Windows.Forms.DataGridView()
        Me.yearCookieForm = New System.Windows.Forms.Button()
        Me.load4 = New System.Windows.Forms.Button()
        Me.cookieDGV = New System.Windows.Forms.DataGridView()
        Me.cookieForm = New System.Windows.Forms.Button()
        Me.load3 = New System.Windows.Forms.Button()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.transactionFilter = New System.Windows.Forms.Button()
        Me.sumOfReceivedPayments = New System.Windows.Forms.Label()
        Me.sumOfRemainingBalance = New System.Windows.Forms.Label()
        Me.sumOfTotalPayments = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.transactionFullFieldsDGV = New System.Windows.Forms.DataGridView()
        Me.userTCB = New System.Windows.Forms.ComboBox()
        Me.transactionDGV = New System.Windows.Forms.DataGridView()
        Me.load6 = New System.Windows.Forms.Button()
        Me.paymentForm = New System.Windows.Forms.Button()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.inventoryFilter = New System.Windows.Forms.Button()
        Me.inventoryFilterTB = New System.Windows.Forms.TextBox()
        Me.inventoryFilterCB = New System.Windows.Forms.ComboBox()
        Me.inventoryDGV = New System.Windows.Forms.DataGridView()
        Me.inventoryForm = New System.Windows.Forms.Button()
        Me.load7 = New System.Windows.Forms.Button()
        Me.warehouseDGV = New System.Windows.Forms.DataGridView()
        Me.load5 = New System.Windows.Forms.Button()
        Me.warehouseForm = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.sumOfTotalRQ = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.sumOfTotalPQ = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.sumOfTotalOQ = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.orderFilter = New System.Windows.Forms.Button()
        Me.orderFilterTB = New System.Windows.Forms.TextBox()
        Me.orderFilterCB = New System.Windows.Forms.ComboBox()
        Me.totalUserCookie = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.load2 = New System.Windows.Forms.Button()
        Me.cookieOrderForm = New System.Windows.Forms.Button()
        Me.orderDGV = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.userFilterTB = New System.Windows.Forms.TextBox()
        Me.filter = New System.Windows.Forms.Button()
        Me.userFilterCB = New System.Windows.Forms.ComboBox()
        Me.totalGirlsLB = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.userForm = New System.Windows.Forms.Button()
        Me.load = New System.Windows.Forms.Button()
        Me.userDGV = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.sumOfIQ = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPage7.SuspendLayout()
        CType(Me.salesTypeDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cookieYearPicker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.yearCookieDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cookieDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.transactionFullFieldsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.transactionDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.inventoryDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.warehouseDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.orderDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.userDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.salesTypeForm)
        Me.TabPage7.Controls.Add(Me.load8)
        Me.TabPage7.Controls.Add(Me.salesTypeDGV)
        Me.TabPage7.Controls.Add(Me.cookieYearPicker)
        Me.TabPage7.Controls.Add(Me.Label2)
        Me.TabPage7.Controls.Add(Me.yearCookieDGV)
        Me.TabPage7.Controls.Add(Me.yearCookieForm)
        Me.TabPage7.Controls.Add(Me.load4)
        Me.TabPage7.Controls.Add(Me.cookieDGV)
        Me.TabPage7.Controls.Add(Me.cookieForm)
        Me.TabPage7.Controls.Add(Me.load3)
        Me.TabPage7.Location = New System.Drawing.Point(4, 33)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(1319, 716)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Settings"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'salesTypeForm
        '
        Me.salesTypeForm.Location = New System.Drawing.Point(927, 6)
        Me.salesTypeForm.Name = "salesTypeForm"
        Me.salesTypeForm.Size = New System.Drawing.Size(166, 32)
        Me.salesTypeForm.TabIndex = 19
        Me.salesTypeForm.Text = "Add Sales Type"
        Me.salesTypeForm.UseVisualStyleBackColor = True
        '
        'load8
        '
        Me.load8.Location = New System.Drawing.Point(825, 6)
        Me.load8.Name = "load8"
        Me.load8.Size = New System.Drawing.Size(97, 32)
        Me.load8.TabIndex = 18
        Me.load8.Text = "Load"
        Me.load8.UseVisualStyleBackColor = True
        '
        'salesTypeDGV
        '
        Me.salesTypeDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.salesTypeDGV.BackgroundColor = System.Drawing.Color.PaleGoldenrod
        Me.salesTypeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.salesTypeDGV.Location = New System.Drawing.Point(825, 44)
        Me.salesTypeDGV.Name = "salesTypeDGV"
        Me.salesTypeDGV.RowHeadersWidth = 51
        Me.salesTypeDGV.Size = New System.Drawing.Size(296, 381)
        Me.salesTypeDGV.TabIndex = 17
        '
        'cookieYearPicker
        '
        Me.cookieYearPicker.Location = New System.Drawing.Point(1240, 15)
        Me.cookieYearPicker.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.cookieYearPicker.Name = "cookieYearPicker"
        Me.cookieYearPicker.Size = New System.Drawing.Size(68, 29)
        Me.cookieYearPicker.TabIndex = 16
        Me.cookieYearPicker.Value = New Decimal(New Integer() {2022, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1138, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 21)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Cookie Year"
        '
        'yearCookieDGV
        '
        Me.yearCookieDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.yearCookieDGV.BackgroundColor = System.Drawing.Color.PaleGoldenrod
        Me.yearCookieDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.yearCookieDGV.Location = New System.Drawing.Point(307, 44)
        Me.yearCookieDGV.Name = "yearCookieDGV"
        Me.yearCookieDGV.RowHeadersWidth = 51
        Me.yearCookieDGV.Size = New System.Drawing.Size(490, 381)
        Me.yearCookieDGV.TabIndex = 14
        '
        'yearCookieForm
        '
        Me.yearCookieForm.Location = New System.Drawing.Point(410, 6)
        Me.yearCookieForm.Name = "yearCookieForm"
        Me.yearCookieForm.Size = New System.Drawing.Size(166, 32)
        Me.yearCookieForm.TabIndex = 13
        Me.yearCookieForm.Text = "Add Price of Cookie"
        Me.yearCookieForm.UseVisualStyleBackColor = True
        '
        'load4
        '
        Me.load4.Location = New System.Drawing.Point(307, 6)
        Me.load4.Name = "load4"
        Me.load4.Size = New System.Drawing.Size(97, 32)
        Me.load4.TabIndex = 12
        Me.load4.Text = "Load"
        Me.load4.UseVisualStyleBackColor = True
        '
        'cookieDGV
        '
        Me.cookieDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.cookieDGV.BackgroundColor = System.Drawing.Color.PaleGoldenrod
        Me.cookieDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.cookieDGV.Location = New System.Drawing.Point(8, 44)
        Me.cookieDGV.Name = "cookieDGV"
        Me.cookieDGV.RowHeadersWidth = 51
        Me.cookieDGV.Size = New System.Drawing.Size(279, 381)
        Me.cookieDGV.TabIndex = 7
        '
        'cookieForm
        '
        Me.cookieForm.Location = New System.Drawing.Point(111, 6)
        Me.cookieForm.Name = "cookieForm"
        Me.cookieForm.Size = New System.Drawing.Size(146, 32)
        Me.cookieForm.TabIndex = 6
        Me.cookieForm.Text = "Add New Cookie"
        Me.cookieForm.UseVisualStyleBackColor = True
        '
        'load3
        '
        Me.load3.Location = New System.Drawing.Point(8, 6)
        Me.load3.Name = "load3"
        Me.load3.Size = New System.Drawing.Size(97, 32)
        Me.load3.TabIndex = 5
        Me.load3.Text = "Load"
        Me.load3.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.Label8)
        Me.TabPage6.Controls.Add(Me.Label7)
        Me.TabPage6.Controls.Add(Me.transactionFilter)
        Me.TabPage6.Controls.Add(Me.sumOfReceivedPayments)
        Me.TabPage6.Controls.Add(Me.sumOfRemainingBalance)
        Me.TabPage6.Controls.Add(Me.sumOfTotalPayments)
        Me.TabPage6.Controls.Add(Me.Label6)
        Me.TabPage6.Controls.Add(Me.transactionFullFieldsDGV)
        Me.TabPage6.Controls.Add(Me.userTCB)
        Me.TabPage6.Controls.Add(Me.transactionDGV)
        Me.TabPage6.Controls.Add(Me.load6)
        Me.TabPage6.Controls.Add(Me.paymentForm)
        Me.TabPage6.Location = New System.Drawing.Point(4, 33)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(1319, 716)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Transactions"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(627, 408)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(209, 21)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Sum Of Remaining Balance:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(326, 408)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(213, 21)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Sum Of Received Payments:"
        '
        'transactionFilter
        '
        Me.transactionFilter.Location = New System.Drawing.Point(452, 7)
        Me.transactionFilter.Name = "transactionFilter"
        Me.transactionFilter.Size = New System.Drawing.Size(75, 29)
        Me.transactionFilter.TabIndex = 15
        Me.transactionFilter.Text = "Filter"
        Me.transactionFilter.UseVisualStyleBackColor = True
        '
        'sumOfReceivedPayments
        '
        Me.sumOfReceivedPayments.AutoSize = True
        Me.sumOfReceivedPayments.Location = New System.Drawing.Point(545, 408)
        Me.sumOfReceivedPayments.Name = "sumOfReceivedPayments"
        Me.sumOfReceivedPayments.Size = New System.Drawing.Size(76, 21)
        Me.sumOfReceivedPayments.TabIndex = 14
        Me.sumOfReceivedPayments.Text = "text here"
        '
        'sumOfRemainingBalance
        '
        Me.sumOfRemainingBalance.AutoSize = True
        Me.sumOfRemainingBalance.Location = New System.Drawing.Point(842, 408)
        Me.sumOfRemainingBalance.Name = "sumOfRemainingBalance"
        Me.sumOfRemainingBalance.Size = New System.Drawing.Size(76, 21)
        Me.sumOfRemainingBalance.TabIndex = 13
        Me.sumOfRemainingBalance.Text = "text here"
        '
        'sumOfTotalPayments
        '
        Me.sumOfTotalPayments.AutoSize = True
        Me.sumOfTotalPayments.Location = New System.Drawing.Point(244, 408)
        Me.sumOfTotalPayments.Name = "sumOfTotalPayments"
        Me.sumOfTotalPayments.Size = New System.Drawing.Size(76, 21)
        Me.sumOfTotalPayments.TabIndex = 12
        Me.sumOfTotalPayments.Text = "text here"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(57, 408)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(181, 21)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Sum Of Total Payments:"
        '
        'transactionFullFieldsDGV
        '
        Me.transactionFullFieldsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.transactionFullFieldsDGV.BackgroundColor = System.Drawing.Color.PaleGoldenrod
        Me.transactionFullFieldsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.transactionFullFieldsDGV.Location = New System.Drawing.Point(11, 453)
        Me.transactionFullFieldsDGV.Name = "transactionFullFieldsDGV"
        Me.transactionFullFieldsDGV.RowHeadersWidth = 51
        Me.transactionFullFieldsDGV.Size = New System.Drawing.Size(1284, 221)
        Me.transactionFullFieldsDGV.TabIndex = 10
        '
        'userTCB
        '
        Me.userTCB.FormattingEnabled = True
        Me.userTCB.Location = New System.Drawing.Point(236, 6)
        Me.userTCB.Name = "userTCB"
        Me.userTCB.Size = New System.Drawing.Size(210, 29)
        Me.userTCB.TabIndex = 9
        '
        'transactionDGV
        '
        Me.transactionDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.transactionDGV.BackgroundColor = System.Drawing.Color.PaleGoldenrod
        Me.transactionDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.transactionDGV.Location = New System.Drawing.Point(11, 42)
        Me.transactionDGV.Name = "transactionDGV"
        Me.transactionDGV.RowHeadersWidth = 51
        Me.transactionDGV.Size = New System.Drawing.Size(1284, 337)
        Me.transactionDGV.TabIndex = 7
        '
        'load6
        '
        Me.load6.Location = New System.Drawing.Point(11, 6)
        Me.load6.Name = "load6"
        Me.load6.Size = New System.Drawing.Size(78, 28)
        Me.load6.TabIndex = 6
        Me.load6.Text = "Load"
        Me.load6.UseVisualStyleBackColor = True
        '
        'paymentForm
        '
        Me.paymentForm.Location = New System.Drawing.Point(95, 6)
        Me.paymentForm.Name = "paymentForm"
        Me.paymentForm.Size = New System.Drawing.Size(135, 28)
        Me.paymentForm.TabIndex = 1
        Me.paymentForm.Text = "Add Payment"
        Me.paymentForm.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.sumOfIQ)
        Me.TabPage5.Controls.Add(Me.Label11)
        Me.TabPage5.Controls.Add(Me.inventoryFilter)
        Me.TabPage5.Controls.Add(Me.inventoryFilterTB)
        Me.TabPage5.Controls.Add(Me.inventoryFilterCB)
        Me.TabPage5.Controls.Add(Me.inventoryDGV)
        Me.TabPage5.Controls.Add(Me.inventoryForm)
        Me.TabPage5.Controls.Add(Me.load7)
        Me.TabPage5.Controls.Add(Me.warehouseDGV)
        Me.TabPage5.Controls.Add(Me.load5)
        Me.TabPage5.Controls.Add(Me.warehouseForm)
        Me.TabPage5.Location = New System.Drawing.Point(4, 33)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1319, 716)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Inventory"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'inventoryFilter
        '
        Me.inventoryFilter.Location = New System.Drawing.Point(573, 6)
        Me.inventoryFilter.Name = "inventoryFilter"
        Me.inventoryFilter.Size = New System.Drawing.Size(78, 29)
        Me.inventoryFilter.TabIndex = 15
        Me.inventoryFilter.Text = "Filter"
        Me.inventoryFilter.UseVisualStyleBackColor = True
        '
        'inventoryFilterTB
        '
        Me.inventoryFilterTB.Location = New System.Drawing.Point(434, 6)
        Me.inventoryFilterTB.Name = "inventoryFilterTB"
        Me.inventoryFilterTB.Size = New System.Drawing.Size(133, 29)
        Me.inventoryFilterTB.TabIndex = 14
        '
        'inventoryFilterCB
        '
        Me.inventoryFilterCB.FormattingEnabled = True
        Me.inventoryFilterCB.Location = New System.Drawing.Point(307, 6)
        Me.inventoryFilterCB.Name = "inventoryFilterCB"
        Me.inventoryFilterCB.Size = New System.Drawing.Size(121, 29)
        Me.inventoryFilterCB.TabIndex = 13
        '
        'inventoryDGV
        '
        Me.inventoryDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.inventoryDGV.BackgroundColor = System.Drawing.Color.PaleGoldenrod
        Me.inventoryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.inventoryDGV.Location = New System.Drawing.Point(3, 40)
        Me.inventoryDGV.Name = "inventoryDGV"
        Me.inventoryDGV.RowHeadersWidth = 51
        Me.inventoryDGV.Size = New System.Drawing.Size(1319, 354)
        Me.inventoryDGV.TabIndex = 9
        '
        'inventoryForm
        '
        Me.inventoryForm.Location = New System.Drawing.Point(90, 6)
        Me.inventoryForm.Name = "inventoryForm"
        Me.inventoryForm.Size = New System.Drawing.Size(211, 28)
        Me.inventoryForm.TabIndex = 8
        Me.inventoryForm.Text = "Add Warehouse Inventory"
        Me.inventoryForm.UseVisualStyleBackColor = True
        '
        'load7
        '
        Me.load7.Location = New System.Drawing.Point(6, 6)
        Me.load7.Name = "load7"
        Me.load7.Size = New System.Drawing.Size(78, 28)
        Me.load7.TabIndex = 7
        Me.load7.Text = "Load"
        Me.load7.UseVisualStyleBackColor = True
        '
        'warehouseDGV
        '
        Me.warehouseDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.warehouseDGV.BackgroundColor = System.Drawing.Color.PaleGoldenrod
        Me.warehouseDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.warehouseDGV.Location = New System.Drawing.Point(4, 491)
        Me.warehouseDGV.Name = "warehouseDGV"
        Me.warehouseDGV.RowHeadersWidth = 51
        Me.warehouseDGV.Size = New System.Drawing.Size(1319, 206)
        Me.warehouseDGV.TabIndex = 6
        '
        'load5
        '
        Me.load5.Location = New System.Drawing.Point(8, 430)
        Me.load5.Name = "load5"
        Me.load5.Size = New System.Drawing.Size(87, 49)
        Me.load5.TabIndex = 5
        Me.load5.Text = "Load"
        Me.load5.UseVisualStyleBackColor = True
        '
        'warehouseForm
        '
        Me.warehouseForm.Location = New System.Drawing.Point(118, 430)
        Me.warehouseForm.Name = "warehouseForm"
        Me.warehouseForm.Size = New System.Drawing.Size(194, 49)
        Me.warehouseForm.TabIndex = 0
        Me.warehouseForm.Text = "Add Troop Warehouse"
        Me.warehouseForm.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.sumOfTotalRQ)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.sumOfTotalPQ)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.sumOfTotalOQ)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.orderFilter)
        Me.TabPage3.Controls.Add(Me.orderFilterTB)
        Me.TabPage3.Controls.Add(Me.orderFilterCB)
        Me.TabPage3.Controls.Add(Me.totalUserCookie)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.load2)
        Me.TabPage3.Controls.Add(Me.cookieOrderForm)
        Me.TabPage3.Controls.Add(Me.orderDGV)
        Me.TabPage3.Location = New System.Drawing.Point(4, 33)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1319, 716)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Cookie Orders"
        '
        'sumOfTotalRQ
        '
        Me.sumOfTotalRQ.AutoSize = True
        Me.sumOfTotalRQ.Location = New System.Drawing.Point(1015, 680)
        Me.sumOfTotalRQ.Name = "sumOfTotalRQ"
        Me.sumOfTotalRQ.Size = New System.Drawing.Size(17, 21)
        Me.sumOfTotalRQ.TabIndex = 20
        Me.sumOfTotalRQ.Text = "_"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(847, 680)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(168, 21)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Total Return Quantity:"
        '
        'sumOfTotalPQ
        '
        Me.sumOfTotalPQ.AutoSize = True
        Me.sumOfTotalPQ.Location = New System.Drawing.Point(800, 680)
        Me.sumOfTotalPQ.Name = "sumOfTotalPQ"
        Me.sumOfTotalPQ.Size = New System.Drawing.Size(17, 21)
        Me.sumOfTotalPQ.TabIndex = 18
        Me.sumOfTotalPQ.Text = "_"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(631, 680)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(167, 21)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Total Pickup Quantity:"
        '
        'sumOfTotalOQ
        '
        Me.sumOfTotalOQ.AutoSize = True
        Me.sumOfTotalOQ.Location = New System.Drawing.Point(580, 680)
        Me.sumOfTotalOQ.Name = "sumOfTotalOQ"
        Me.sumOfTotalOQ.Size = New System.Drawing.Size(17, 21)
        Me.sumOfTotalOQ.TabIndex = 16
        Me.sumOfTotalOQ.Text = "_"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(415, 680)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 21)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Total Order Quantity:"
        '
        'orderFilter
        '
        Me.orderFilter.Location = New System.Drawing.Point(558, 6)
        Me.orderFilter.Name = "orderFilter"
        Me.orderFilter.Size = New System.Drawing.Size(78, 29)
        Me.orderFilter.TabIndex = 14
        Me.orderFilter.Text = "Filter"
        Me.orderFilter.UseVisualStyleBackColor = True
        '
        'orderFilterTB
        '
        Me.orderFilterTB.Location = New System.Drawing.Point(419, 6)
        Me.orderFilterTB.Name = "orderFilterTB"
        Me.orderFilterTB.Size = New System.Drawing.Size(133, 29)
        Me.orderFilterTB.TabIndex = 13
        '
        'orderFilterCB
        '
        Me.orderFilterCB.FormattingEnabled = True
        Me.orderFilterCB.Location = New System.Drawing.Point(292, 7)
        Me.orderFilterCB.Name = "orderFilterCB"
        Me.orderFilterCB.Size = New System.Drawing.Size(121, 29)
        Me.orderFilterCB.TabIndex = 12
        '
        'totalUserCookie
        '
        Me.totalUserCookie.AutoSize = True
        Me.totalUserCookie.Location = New System.Drawing.Point(184, 680)
        Me.totalUserCookie.Name = "totalUserCookie"
        Me.totalUserCookie.Size = New System.Drawing.Size(0, 21)
        Me.totalUserCookie.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 680)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 21)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Total Cookie Orders:"
        '
        'load2
        '
        Me.load2.Location = New System.Drawing.Point(8, 6)
        Me.load2.Name = "load2"
        Me.load2.Size = New System.Drawing.Size(78, 28)
        Me.load2.TabIndex = 4
        Me.load2.Text = "Load"
        Me.load2.UseVisualStyleBackColor = True
        '
        'cookieOrderForm
        '
        Me.cookieOrderForm.Location = New System.Drawing.Point(92, 6)
        Me.cookieOrderForm.Name = "cookieOrderForm"
        Me.cookieOrderForm.Size = New System.Drawing.Size(194, 28)
        Me.cookieOrderForm.TabIndex = 1
        Me.cookieOrderForm.Text = "Add New Cookie Order"
        Me.cookieOrderForm.UseVisualStyleBackColor = True
        '
        'orderDGV
        '
        Me.orderDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.orderDGV.BackgroundColor = System.Drawing.Color.PaleGoldenrod
        Me.orderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.orderDGV.Location = New System.Drawing.Point(8, 40)
        Me.orderDGV.Name = "orderDGV"
        Me.orderDGV.RowHeadersWidth = 51
        Me.orderDGV.Size = New System.Drawing.Size(1303, 626)
        Me.orderDGV.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.userFilterTB)
        Me.TabPage2.Controls.Add(Me.filter)
        Me.TabPage2.Controls.Add(Me.userFilterCB)
        Me.TabPage2.Controls.Add(Me.totalGirlsLB)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.userForm)
        Me.TabPage2.Controls.Add(Me.load)
        Me.TabPage2.Controls.Add(Me.userDGV)
        Me.TabPage2.Location = New System.Drawing.Point(4, 33)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1319, 716)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Girls"
        '
        'userFilterTB
        '
        Me.userFilterTB.Location = New System.Drawing.Point(354, 13)
        Me.userFilterTB.Name = "userFilterTB"
        Me.userFilterTB.Size = New System.Drawing.Size(133, 29)
        Me.userFilterTB.TabIndex = 9
        '
        'filter
        '
        Me.filter.Location = New System.Drawing.Point(493, 13)
        Me.filter.Name = "filter"
        Me.filter.Size = New System.Drawing.Size(78, 29)
        Me.filter.TabIndex = 8
        Me.filter.Text = "Filter"
        Me.filter.UseVisualStyleBackColor = True
        '
        'userFilterCB
        '
        Me.userFilterCB.FormattingEnabled = True
        Me.userFilterCB.Location = New System.Drawing.Point(227, 13)
        Me.userFilterCB.Name = "userFilterCB"
        Me.userFilterCB.Size = New System.Drawing.Size(121, 29)
        Me.userFilterCB.TabIndex = 7
        '
        'totalGirlsLB
        '
        Me.totalGirlsLB.AutoSize = True
        Me.totalGirlsLB.Location = New System.Drawing.Point(109, 678)
        Me.totalGirlsLB.Name = "totalGirlsLB"
        Me.totalGirlsLB.Size = New System.Drawing.Size(0, 21)
        Me.totalGirlsLB.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 678)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Total Girls:"
        '
        'userForm
        '
        Me.userForm.Location = New System.Drawing.Point(92, 7)
        Me.userForm.Name = "userForm"
        Me.userForm.Size = New System.Drawing.Size(129, 39)
        Me.userForm.TabIndex = 4
        Me.userForm.Text = "Add New Girl"
        Me.userForm.UseVisualStyleBackColor = True
        '
        'load
        '
        Me.load.Location = New System.Drawing.Point(8, 7)
        Me.load.Name = "load"
        Me.load.Size = New System.Drawing.Size(78, 39)
        Me.load.TabIndex = 3
        Me.load.Text = "Load"
        Me.load.UseVisualStyleBackColor = True
        '
        'userDGV
        '
        Me.userDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.userDGV.BackgroundColor = System.Drawing.Color.PaleGoldenrod
        Me.userDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.userDGV.Location = New System.Drawing.Point(8, 52)
        Me.userDGV.Name = "userDGV"
        Me.userDGV.RowHeadersWidth = 51
        Me.userDGV.Size = New System.Drawing.Size(1305, 611)
        Me.userDGV.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, -1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1327, 753)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.PictureBox3)
        Me.TabPage1.Controls.Add(Me.PictureBox2)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 33)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1319, 716)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Home"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(91, 332)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1143, 65)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Welcome to Troop 1521 Cookie Inventory System"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(1059, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(257, 241)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox2.Image = Global.Troop1521CookieInventory2.My.Resources.Resources.cookiesBottom
        Me.PictureBox2.Location = New System.Drawing.Point(3, 480)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1313, 233)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.Troop1521CookieInventory2.My.Resources.Resources.cookiesTop
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1313, 241)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'sumOfIQ
        '
        Me.sumOfIQ.AutoSize = True
        Me.sumOfIQ.Location = New System.Drawing.Point(569, 415)
        Me.sumOfIQ.Name = "sumOfIQ"
        Me.sumOfIQ.Size = New System.Drawing.Size(17, 21)
        Me.sumOfIQ.TabIndex = 22
        Me.sumOfIQ.Text = "_"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(439, 415)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(128, 21)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Total inQuantity:"
        '
        'mainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1327, 752)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "mainMenu"
        Me.Text = "Troop 1521 Cookie Inventory"
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        CType(Me.salesTypeDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cookieYearPicker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.yearCookieDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cookieDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.transactionFullFieldsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.transactionDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.inventoryDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.warehouseDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.orderDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.userDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents cookieYearPicker As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents yearCookieDGV As DataGridView
    Friend WithEvents yearCookieForm As Button
    Friend WithEvents load4 As Button
    Friend WithEvents cookieDGV As DataGridView
    Friend WithEvents cookieForm As Button
    Friend WithEvents load3 As Button
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents userTCB As ComboBox
    Friend WithEvents transactionDGV As DataGridView
    Friend WithEvents load6 As Button
    Friend WithEvents paymentForm As Button
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents warehouseDGV As DataGridView
    Friend WithEvents load5 As Button
    Friend WithEvents warehouseForm As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents load2 As Button
    Friend WithEvents cookieOrderForm As Button
    Friend WithEvents orderDGV As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents userFilterTB As TextBox
    Friend WithEvents filter As Button
    Friend WithEvents userFilterCB As ComboBox
    Friend WithEvents totalGirlsLB As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents userForm As Button
    Friend WithEvents load As Button
    Friend WithEvents userDGV As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents inventoryForm As Button
    Friend WithEvents load7 As Button
    Friend WithEvents inventoryDGV As DataGridView
    Friend WithEvents salesTypeForm As Button
    Friend WithEvents load8 As Button
    Friend WithEvents salesTypeDGV As DataGridView
    Friend WithEvents transactionFullFieldsDGV As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents totalUserCookie As Label
    Friend WithEvents sumOfTotalPayments As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents sumOfReceivedPayments As Label
    Friend WithEvents sumOfRemainingBalance As Label
    Friend WithEvents transactionFilter As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents orderFilter As Button
    Friend WithEvents orderFilterTB As TextBox
    Friend WithEvents orderFilterCB As ComboBox
    Friend WithEvents inventoryFilter As Button
    Friend WithEvents inventoryFilterTB As TextBox
    Friend WithEvents inventoryFilterCB As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents sumOfTotalOQ As Label
    Friend WithEvents sumOfTotalRQ As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents sumOfTotalPQ As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents sumOfIQ As Label
    Friend WithEvents Label11 As Label
End Class
