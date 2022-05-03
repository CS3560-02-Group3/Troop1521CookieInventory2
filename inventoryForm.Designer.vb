<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inventoryForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.inventoryID = New System.Windows.Forms.Label()
        Me.warehouseID = New System.Windows.Forms.Label()
        Me.yearCookieID = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.inQuantityTB = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.insert = New System.Windows.Forms.Button()
        Me.noteTE = New System.Windows.Forms.RichTextBox()
        Me.update = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inventoryIDLB = New System.Windows.Forms.Label()
        Me.yearCookieCB = New System.Windows.Forms.ComboBox()
        Me.warehouseCB = New System.Windows.Forms.ComboBox()
        Me.filter = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(276, 19)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 65)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Inventory"
        '
        'inventoryID
        '
        Me.inventoryID.AutoSize = True
        Me.inventoryID.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.inventoryID.Location = New System.Drawing.Point(33, 111)
        Me.inventoryID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.inventoryID.Name = "inventoryID"
        Me.inventoryID.Size = New System.Drawing.Size(146, 32)
        Me.inventoryID.TabIndex = 2
        Me.inventoryID.Text = "Inventory ID"
        '
        'warehouseID
        '
        Me.warehouseID.AutoSize = True
        Me.warehouseID.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.warehouseID.Location = New System.Drawing.Point(33, 159)
        Me.warehouseID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.warehouseID.Name = "warehouseID"
        Me.warehouseID.Size = New System.Drawing.Size(164, 32)
        Me.warehouseID.TabIndex = 3
        Me.warehouseID.Text = "Warehouse ID"
        '
        'yearCookieID
        '
        Me.yearCookieID.AutoSize = True
        Me.yearCookieID.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.yearCookieID.Location = New System.Drawing.Point(33, 213)
        Me.yearCookieID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.yearCookieID.Name = "yearCookieID"
        Me.yearCookieID.Size = New System.Drawing.Size(170, 32)
        Me.yearCookieID.TabIndex = 5
        Me.yearCookieID.Text = "Year Cookie ID"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(216, 321)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(401, 39)
        Me.DateTimePicker1.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(33, 326)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 32)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(33, 268)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 32)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Quantity"
        '
        'inQuantityTB
        '
        Me.inQuantityTB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inQuantityTB.Location = New System.Drawing.Point(216, 265)
        Me.inQuantityTB.Margin = New System.Windows.Forms.Padding(2)
        Me.inQuantityTB.Name = "inQuantityTB"
        Me.inQuantityTB.Size = New System.Drawing.Size(110, 39)
        Me.inQuantityTB.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(30, 390)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 32)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Note"
        '
        'insert
        '
        Me.insert.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insert.Location = New System.Drawing.Point(44, 549)
        Me.insert.Name = "insert"
        Me.insert.Size = New System.Drawing.Size(107, 41)
        Me.insert.TabIndex = 17
        Me.insert.Text = "Insert"
        Me.insert.UseVisualStyleBackColor = True
        '
        'noteTE
        '
        Me.noteTE.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noteTE.Location = New System.Drawing.Point(216, 390)
        Me.noteTE.Name = "noteTE"
        Me.noteTE.Size = New System.Drawing.Size(380, 96)
        Me.noteTE.TabIndex = 18
        Me.noteTE.Text = ""
        '
        'update
        '
        Me.update.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update.Location = New System.Drawing.Point(216, 549)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(100, 41)
        Me.update.TabIndex = 19
        Me.update.Text = "Update"
        Me.update.UseVisualStyleBackColor = True
        '
        'delete
        '
        Me.delete.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete.Location = New System.Drawing.Point(403, 549)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(96, 41)
        Me.delete.TabIndex = 20
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridView1.Location = New System.Drawing.Point(718, 58)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(506, 443)
        Me.DataGridView1.TabIndex = 21
        '
        'Column1
        '
        Me.Column1.HeaderText = "Warehouse ID"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 112
        '
        'Column2
        '
        Me.Column2.HeaderText = "Year Cookie ID"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 115
        '
        'Column3
        '
        Me.Column3.HeaderText = "Quantity"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 82
        '
        'Column4
        '
        Me.Column4.HeaderText = "Date"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 66
        '
        'Column5
        '
        Me.Column5.HeaderText = "Note"
        Me.Column5.MinimumWidth = 8
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 66
        '
        'inventoryIDLB
        '
        Me.inventoryIDLB.AutoSize = True
        Me.inventoryIDLB.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.inventoryIDLB.Location = New System.Drawing.Point(219, 111)
        Me.inventoryIDLB.Name = "inventoryIDLB"
        Me.inventoryIDLB.Size = New System.Drawing.Size(0, 32)
        Me.inventoryIDLB.TabIndex = 22
        '
        'yearCookieCB
        '
        Me.yearCookieCB.FormattingEnabled = True
        Me.yearCookieCB.Location = New System.Drawing.Point(216, 223)
        Me.yearCookieCB.Name = "yearCookieCB"
        Me.yearCookieCB.Size = New System.Drawing.Size(200, 21)
        Me.yearCookieCB.TabIndex = 23
        '
        'warehouseCB
        '
        Me.warehouseCB.FormattingEnabled = True
        Me.warehouseCB.Location = New System.Drawing.Point(216, 170)
        Me.warehouseCB.Name = "warehouseCB"
        Me.warehouseCB.Size = New System.Drawing.Size(200, 21)
        Me.warehouseCB.TabIndex = 24
        '
        'filter
        '
        Me.filter.Location = New System.Drawing.Point(504, 265)
        Me.filter.Name = "filter"
        Me.filter.Size = New System.Drawing.Size(78, 39)
        Me.filter.TabIndex = 25
        Me.filter.Text = "Filter"
        Me.filter.UseVisualStyleBackColor = True
        '
        'inventoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1380, 707)
        Me.Controls.Add(Me.filter)
        Me.Controls.Add(Me.warehouseCB)
        Me.Controls.Add(Me.yearCookieCB)
        Me.Controls.Add(Me.inventoryIDLB)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.update)
        Me.Controls.Add(Me.noteTE)
        Me.Controls.Add(Me.insert)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.inQuantityTB)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.yearCookieID)
        Me.Controls.Add(Me.warehouseID)
        Me.Controls.Add(Me.inventoryID)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "inventoryForm"
        Me.Text = "Inventory Form"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents inventoryID As Label
    Friend WithEvents warehouseID As Label
    Friend WithEvents yearCookieID As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents inQuantityTB As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents insert As Button
    Friend WithEvents noteTE As RichTextBox
    Friend WithEvents update As Button
    Friend WithEvents delete As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents inventoryIDLB As Label
    Friend WithEvents yearCookieCB As ComboBox
    Friend WithEvents warehouseCB As ComboBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents filter As Button
End Class
