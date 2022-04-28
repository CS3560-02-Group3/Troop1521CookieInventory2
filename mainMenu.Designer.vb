<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.add = New System.Windows.Forms.Button()
        Me.load = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.load2 = New System.Windows.Forms.Button()
        Me.cookieOrderForm = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.load5 = New System.Windows.Forms.Button()
        Me.warehouseForm = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.load3 = New System.Windows.Forms.Button()
        Me.cookieForm = New System.Windows.Forms.Button()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.load4 = New System.Windows.Forms.Button()
        Me.yearCookieForm = New System.Windows.Forms.Button()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cookieYearPicker = New System.Windows.Forms.NumericUpDown()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.DataGridView6 = New System.Windows.Forms.DataGridView()
        Me.paymentForm = New System.Windows.Forms.Button()
        Me.load6 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.totalGirlsLB = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cookieYearPicker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.TabPage1.Controls.Add(Me.DataGridView5)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 33)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1319, 716)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Home"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Troop All Sales Information"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.totalGirlsLB)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.add)
        Me.TabPage2.Controls.Add(Me.load)
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 33)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1319, 716)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Girls"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'add
        '
        Me.add.Location = New System.Drawing.Point(92, 7)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(129, 39)
        Me.add.TabIndex = 4
        Me.add.Text = "Add New Girl"
        Me.add.UseVisualStyleBackColor = True
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
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(8, 52)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1305, 556)
        Me.DataGridView1.TabIndex = 2
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.load2)
        Me.TabPage3.Controls.Add(Me.cookieOrderForm)
        Me.TabPage3.Controls.Add(Me.DataGridView2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 33)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1319, 716)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Cookie Orders"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'load2
        '
        Me.load2.Location = New System.Drawing.Point(8, 21)
        Me.load2.Name = "load2"
        Me.load2.Size = New System.Drawing.Size(78, 28)
        Me.load2.TabIndex = 4
        Me.load2.Text = "Load"
        Me.load2.UseVisualStyleBackColor = True
        '
        'cookieOrderForm
        '
        Me.cookieOrderForm.Location = New System.Drawing.Point(92, 21)
        Me.cookieOrderForm.Name = "cookieOrderForm"
        Me.cookieOrderForm.Size = New System.Drawing.Size(194, 28)
        Me.cookieOrderForm.TabIndex = 1
        Me.cookieOrderForm.Text = "Add New Cookie Order"
        Me.cookieOrderForm.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(3, 55)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(1308, 500)
        Me.DataGridView2.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.DataGridView6)
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
        'load5
        '
        Me.load5.Location = New System.Drawing.Point(8, 6)
        Me.load5.Name = "load5"
        Me.load5.Size = New System.Drawing.Size(78, 28)
        Me.load5.TabIndex = 5
        Me.load5.Text = "Load"
        Me.load5.UseVisualStyleBackColor = True
        '
        'warehouseForm
        '
        Me.warehouseForm.Location = New System.Drawing.Point(92, 6)
        Me.warehouseForm.Name = "warehouseForm"
        Me.warehouseForm.Size = New System.Drawing.Size(194, 28)
        Me.warehouseForm.TabIndex = 0
        Me.warehouseForm.Text = "Add Troop Warehouse"
        Me.warehouseForm.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
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
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.cookieYearPicker)
        Me.TabPage7.Controls.Add(Me.Label2)
        Me.TabPage7.Controls.Add(Me.DataGridView4)
        Me.TabPage7.Controls.Add(Me.yearCookieForm)
        Me.TabPage7.Controls.Add(Me.load4)
        Me.TabPage7.Controls.Add(Me.DataGridView3)
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
        'load3
        '
        Me.load3.Location = New System.Drawing.Point(8, 6)
        Me.load3.Name = "load3"
        Me.load3.Size = New System.Drawing.Size(97, 32)
        Me.load3.TabIndex = 5
        Me.load3.Text = "Load"
        Me.load3.UseVisualStyleBackColor = True
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
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(8, 44)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(279, 381)
        Me.DataGridView3.TabIndex = 7
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
        'yearCookieForm
        '
        Me.yearCookieForm.Location = New System.Drawing.Point(410, 6)
        Me.yearCookieForm.Name = "yearCookieForm"
        Me.yearCookieForm.Size = New System.Drawing.Size(166, 32)
        Me.yearCookieForm.TabIndex = 13
        Me.yearCookieForm.Text = "Add Price of Cookie"
        Me.yearCookieForm.UseVisualStyleBackColor = True
        '
        'DataGridView4
        '
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Location = New System.Drawing.Point(307, 44)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.Size = New System.Drawing.Size(490, 381)
        Me.DataGridView4.TabIndex = 14
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
        'cookieYearPicker
        '
        Me.cookieYearPicker.Location = New System.Drawing.Point(1240, 15)
        Me.cookieYearPicker.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.cookieYearPicker.Name = "cookieYearPicker"
        Me.cookieYearPicker.Size = New System.Drawing.Size(68, 29)
        Me.cookieYearPicker.TabIndex = 16
        Me.cookieYearPicker.Value = New Decimal(New Integer() {2022, 0, 0, 0})
        '
        'DataGridView5
        '
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Location = New System.Drawing.Point(32, 54)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.Size = New System.Drawing.Size(938, 359)
        Me.DataGridView5.TabIndex = 1
        '
        'DataGridView6
        '
        Me.DataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView6.Location = New System.Drawing.Point(8, 40)
        Me.DataGridView6.Name = "DataGridView6"
        Me.DataGridView6.Size = New System.Drawing.Size(422, 407)
        Me.DataGridView6.TabIndex = 6
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
        'load6
        '
        Me.load6.Location = New System.Drawing.Point(11, 6)
        Me.load6.Name = "load6"
        Me.load6.Size = New System.Drawing.Size(78, 28)
        Me.load6.TabIndex = 6
        Me.load6.Text = "Load"
        Me.load6.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 620)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Total Girls:"
        '
        'totalGirlsLB
        '
        Me.totalGirlsLB.AutoSize = True
        Me.totalGirlsLB.Location = New System.Drawing.Point(99, 620)
        Me.totalGirlsLB.Name = "totalGirlsLB"
        Me.totalGirlsLB.Size = New System.Drawing.Size(0, 21)
        Me.totalGirlsLB.TabIndex = 6
        '
        'mainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1327, 752)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "mainMenu"
        Me.Text = "Troop 1521 Cookie Inventory"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cookieYearPicker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents add As Button
    Friend WithEvents load As Button
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents warehouseForm As Button
    Friend WithEvents load2 As Button
    Friend WithEvents cookieOrderForm As Button
    Friend WithEvents load5 As Button
    Friend WithEvents DataGridView5 As DataGridView
    Friend WithEvents DataGridView6 As DataGridView
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents load6 As Button
    Friend WithEvents paymentForm As Button
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents cookieYearPicker As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents yearCookieForm As Button
    Friend WithEvents load4 As Button
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents cookieForm As Button
    Friend WithEvents load3 As Button
    Friend WithEvents totalGirlsLB As Label
    Friend WithEvents Label3 As Label
End Class
