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
        Me.inventoryIDLB = New System.Windows.Forms.Label()
        Me.yearCookieCB = New System.Windows.Forms.ComboBox()
        Me.warehouseCB = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.yearLB = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(276, 19)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 45)
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
        Me.inventoryID.Size = New System.Drawing.Size(95, 21)
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
        Me.warehouseID.Size = New System.Drawing.Size(107, 21)
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
        Me.yearCookieID.Size = New System.Drawing.Size(111, 21)
        Me.yearCookieID.TabIndex = 5
        Me.yearCookieID.Text = "Year Cookie ID"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(216, 321)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(401, 29)
        Me.DateTimePicker1.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(40, 327)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 21)
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
        Me.Label8.Size = New System.Drawing.Size(70, 21)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Quantity"
        '
        'inQuantityTB
        '
        Me.inQuantityTB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inQuantityTB.Location = New System.Drawing.Point(216, 265)
        Me.inQuantityTB.Margin = New System.Windows.Forms.Padding(2)
        Me.inQuantityTB.Name = "inQuantityTB"
        Me.inQuantityTB.Size = New System.Drawing.Size(110, 29)
        Me.inQuantityTB.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(40, 390)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 21)
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
        Me.update.Location = New System.Drawing.Point(316, 549)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(100, 41)
        Me.update.TabIndex = 19
        Me.update.Text = "Update"
        Me.update.UseVisualStyleBackColor = True
        '
        'delete
        '
        Me.delete.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete.Location = New System.Drawing.Point(574, 549)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(96, 41)
        Me.delete.TabIndex = 20
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = True
        '
        'inventoryIDLB
        '
        Me.inventoryIDLB.AutoSize = True
        Me.inventoryIDLB.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.inventoryIDLB.Location = New System.Drawing.Point(219, 111)
        Me.inventoryIDLB.Name = "inventoryIDLB"
        Me.inventoryIDLB.Size = New System.Drawing.Size(0, 21)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(454, 111)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 21)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Year"
        '
        'yearLB
        '
        Me.yearLB.AutoSize = True
        Me.yearLB.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.yearLB.Location = New System.Drawing.Point(498, 111)
        Me.yearLB.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.yearLB.Name = "yearLB"
        Me.yearLB.Size = New System.Drawing.Size(0, 21)
        Me.yearLB.TabIndex = 26
        '
        'inventoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 707)
        Me.Controls.Add(Me.yearLB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.warehouseCB)
        Me.Controls.Add(Me.yearCookieCB)
        Me.Controls.Add(Me.inventoryIDLB)
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
    Friend WithEvents inventoryIDLB As Label
    Friend WithEvents yearCookieCB As ComboBox
    Friend WithEvents warehouseCB As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents yearLB As Label
End Class
