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
        Me.inventoryID.Location = New System.Drawing.Point(45, 93)
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
        Me.warehouseID.Location = New System.Drawing.Point(291, 93)
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
        Me.yearCookieID.Location = New System.Drawing.Point(546, 93)
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
        Me.DateTimePicker1.Location = New System.Drawing.Point(464, 189)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(261, 29)
        Me.DateTimePicker1.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(357, 189)
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
        Me.Label8.Location = New System.Drawing.Point(45, 189)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 21)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Quantity"
        '
        'inQuantityTB
        '
        Me.inQuantityTB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inQuantityTB.Location = New System.Drawing.Point(164, 189)
        Me.inQuantityTB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.inQuantityTB.Name = "inQuantityTB"
        Me.inQuantityTB.Size = New System.Drawing.Size(79, 29)
        Me.inQuantityTB.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(45, 279)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 21)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Note"
        '
        'insert
        '
        Me.insert.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insert.Location = New System.Drawing.Point(345, 405)
        Me.insert.Name = "insert"
        Me.insert.Size = New System.Drawing.Size(96, 33)
        Me.insert.TabIndex = 17
        Me.insert.Text = "Insert"
        Me.insert.UseVisualStyleBackColor = True
        '
        'noteTE
        '
        Me.noteTE.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noteTE.Location = New System.Drawing.Point(119, 279)
        Me.noteTE.Name = "noteTE"
        Me.noteTE.Size = New System.Drawing.Size(380, 96)
        Me.noteTE.TabIndex = 18
        Me.noteTE.Text = ""
        '
        'update
        '
        Me.update.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update.Location = New System.Drawing.Point(383, 405)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(96, 33)
        Me.update.TabIndex = 19
        Me.update.Text = "Update"
        Me.update.UseVisualStyleBackColor = True
        '
        'delete
        '
        Me.delete.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete.Location = New System.Drawing.Point(629, 405)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(96, 33)
        Me.delete.TabIndex = 20
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = True
        '
        'inventoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 450)
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
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
End Class
