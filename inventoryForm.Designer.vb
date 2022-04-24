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
        Me.submit = New System.Windows.Forms.Button()
        Me.noteTE = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(414, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 65)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Inventory"
        '
        'inventoryID
        '
        Me.inventoryID.AutoSize = True
        Me.inventoryID.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.inventoryID.Location = New System.Drawing.Point(68, 143)
        Me.inventoryID.Name = "inventoryID"
        Me.inventoryID.Size = New System.Drawing.Size(146, 32)
        Me.inventoryID.TabIndex = 2
        Me.inventoryID.Text = "Inventory ID"
        '
        'warehouseID
        '
        Me.warehouseID.AutoSize = True
        Me.warehouseID.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.warehouseID.Location = New System.Drawing.Point(437, 143)
        Me.warehouseID.Name = "warehouseID"
        Me.warehouseID.Size = New System.Drawing.Size(164, 32)
        Me.warehouseID.TabIndex = 3
        Me.warehouseID.Text = "Warehouse ID"
        '
        'yearCookieID
        '
        Me.yearCookieID.AutoSize = True
        Me.yearCookieID.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.yearCookieID.Location = New System.Drawing.Point(819, 143)
        Me.yearCookieID.Name = "yearCookieID"
        Me.yearCookieID.Size = New System.Drawing.Size(170, 32)
        Me.yearCookieID.TabIndex = 5
        Me.yearCookieID.Text = "Year Cookie ID"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(696, 291)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(389, 39)
        Me.DateTimePicker1.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(536, 291)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 32)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(68, 291)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 32)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Quantity"
        '
        'inQuantityTB
        '
        Me.inQuantityTB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inQuantityTB.Location = New System.Drawing.Point(246, 291)
        Me.inQuantityTB.Name = "inQuantityTB"
        Me.inQuantityTB.Size = New System.Drawing.Size(117, 39)
        Me.inQuantityTB.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(68, 430)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 32)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Note"
        '
        'submit
        '
        Me.submit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit.Location = New System.Drawing.Point(919, 598)
        Me.submit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(144, 51)
        Me.submit.TabIndex = 17
        Me.submit.Text = "Submit"
        Me.submit.UseVisualStyleBackColor = True
        '
        'noteTE
        '
        Me.noteTE.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noteTE.Location = New System.Drawing.Point(178, 430)
        Me.noteTE.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.noteTE.Name = "noteTE"
        Me.noteTE.Size = New System.Drawing.Size(568, 146)
        Me.noteTE.TabIndex = 18
        Me.noteTE.Text = ""
        '
        'inventoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1144, 693)
        Me.Controls.Add(Me.noteTE)
        Me.Controls.Add(Me.submit)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.inQuantityTB)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.yearCookieID)
        Me.Controls.Add(Me.warehouseID)
        Me.Controls.Add(Me.inventoryID)
        Me.Controls.Add(Me.Label2)
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
    Friend WithEvents submit As Button
    Friend WithEvents noteTE As RichTextBox
End Class
