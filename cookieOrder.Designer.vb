<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cookieOrder
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.updateC = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.orderID = New System.Windows.Forms.Label()
        Me.orderQTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.returnQTB = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cookieNTB = New System.Windows.Forms.TextBox()
        Me.pickupQTB = New System.Windows.Forms.TextBox()
        Me.insertC = New System.Windows.Forms.Button()
        Me.deleteC = New System.Windows.Forms.Button()
        Me.orderIDTE = New System.Windows.Forms.Label()
        Me.userIDTE = New System.Windows.Forms.Label()
        Me.inventoryIDTE = New System.Windows.Forms.Label()
        Me.yearCookieIDTE = New System.Windows.Forms.Label()
        Me.userCookieIDTE = New System.Windows.Forms.Label()
        Me.dateC = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(480, 57)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 0
        '
        'updateC
        '
        Me.updateC.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateC.Location = New System.Drawing.Point(484, 459)
        Me.updateC.Margin = New System.Windows.Forms.Padding(4)
        Me.updateC.Name = "updateC"
        Me.updateC.Size = New System.Drawing.Size(127, 39)
        Me.updateC.TabIndex = 1
        Me.updateC.Text = "Update"
        Me.updateC.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(379, 57)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(271, 54)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cookie Order"
        '
        'orderID
        '
        Me.orderID.AutoSize = True
        Me.orderID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orderID.Location = New System.Drawing.Point(117, 139)
        Me.orderID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.orderID.Name = "orderID"
        Me.orderID.Size = New System.Drawing.Size(27, 23)
        Me.orderID.TabIndex = 3
        Me.orderID.Text = "ID"
        '
        'orderQTB
        '
        Me.orderQTB.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orderQTB.Location = New System.Drawing.Point(296, 271)
        Me.orderQTB.Margin = New System.Windows.Forms.Padding(4)
        Me.orderQTB.Name = "orderQTB"
        Me.orderQTB.Size = New System.Drawing.Size(132, 29)
        Me.orderQTB.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(480, 139)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 23)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "User ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(847, 139)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 23)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Inventory ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(112, 201)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 23)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Year Cookie ID"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(583, 198)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(265, 26)
        Me.DateTimePicker1.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(112, 281)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 23)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Order Quantity"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(480, 281)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 23)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Pickup Quantity"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(117, 356)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 23)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Return Quantity"
        '
        'returnQTB
        '
        Me.returnQTB.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.returnQTB.Location = New System.Drawing.Point(296, 356)
        Me.returnQTB.Margin = New System.Windows.Forms.Padding(4)
        Me.returnQTB.Name = "returnQTB"
        Me.returnQTB.Size = New System.Drawing.Size(132, 29)
        Me.returnQTB.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(480, 356)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 23)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Note"
        '
        'cookieNTB
        '
        Me.cookieNTB.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cookieNTB.Location = New System.Drawing.Point(700, 356)
        Me.cookieNTB.Margin = New System.Windows.Forms.Padding(4)
        Me.cookieNTB.Name = "cookieNTB"
        Me.cookieNTB.Size = New System.Drawing.Size(248, 29)
        Me.cookieNTB.TabIndex = 15
        '
        'pickupQTB
        '
        Me.pickupQTB.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pickupQTB.Location = New System.Drawing.Point(700, 271)
        Me.pickupQTB.Margin = New System.Windows.Forms.Padding(4)
        Me.pickupQTB.Name = "pickupQTB"
        Me.pickupQTB.Size = New System.Drawing.Size(132, 29)
        Me.pickupQTB.TabIndex = 16
        '
        'insertC
        '
        Me.insertC.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insertC.Location = New System.Drawing.Point(121, 459)
        Me.insertC.Margin = New System.Windows.Forms.Padding(4)
        Me.insertC.Name = "insertC"
        Me.insertC.Size = New System.Drawing.Size(127, 39)
        Me.insertC.TabIndex = 17
        Me.insertC.Text = "Insert"
        Me.insertC.UseVisualStyleBackColor = True
        '
        'deleteC
        '
        Me.deleteC.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteC.Location = New System.Drawing.Point(851, 459)
        Me.deleteC.Margin = New System.Windows.Forms.Padding(4)
        Me.deleteC.Name = "deleteC"
        Me.deleteC.Size = New System.Drawing.Size(125, 39)
        Me.deleteC.TabIndex = 18
        Me.deleteC.Text = "Delete"
        Me.deleteC.UseVisualStyleBackColor = True
        '
        'orderIDTE
        '
        Me.orderIDTE.AutoSize = True
        Me.orderIDTE.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orderIDTE.Location = New System.Drawing.Point(177, 139)
        Me.orderIDTE.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.orderIDTE.Name = "orderIDTE"
        Me.orderIDTE.Size = New System.Drawing.Size(0, 23)
        Me.orderIDTE.TabIndex = 19
        '
        'userIDTE
        '
        Me.userIDTE.AutoSize = True
        Me.userIDTE.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userIDTE.Location = New System.Drawing.Point(579, 139)
        Me.userIDTE.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.userIDTE.Name = "userIDTE"
        Me.userIDTE.Size = New System.Drawing.Size(0, 23)
        Me.userIDTE.TabIndex = 20
        '
        'inventoryIDTE
        '
        Me.inventoryIDTE.AutoSize = True
        Me.inventoryIDTE.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inventoryIDTE.Location = New System.Drawing.Point(957, 139)
        Me.inventoryIDTE.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.inventoryIDTE.Name = "inventoryIDTE"
        Me.inventoryIDTE.Size = New System.Drawing.Size(0, 23)
        Me.inventoryIDTE.TabIndex = 21
        '
        'yearCookieIDTE
        '
        Me.yearCookieIDTE.AutoSize = True
        Me.yearCookieIDTE.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yearCookieIDTE.Location = New System.Drawing.Point(271, 204)
        Me.yearCookieIDTE.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.yearCookieIDTE.Name = "yearCookieIDTE"
        Me.yearCookieIDTE.Size = New System.Drawing.Size(0, 23)
        Me.yearCookieIDTE.TabIndex = 22
        '
        'userCookieIDTE
        '
        Me.userCookieIDTE.AutoSize = True
        Me.userCookieIDTE.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userCookieIDTE.Location = New System.Drawing.Point(190, 139)
        Me.userCookieIDTE.Name = "userCookieIDTE"
        Me.userCookieIDTE.Size = New System.Drawing.Size(0, 23)
        Me.userCookieIDTE.TabIndex = 24
        '
        'dateC
        '
        Me.dateC.AutoSize = True
        Me.dateC.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateC.Location = New System.Drawing.Point(480, 200)
        Me.dateC.Name = "dateC"
        Me.dateC.Size = New System.Drawing.Size(50, 23)
        Me.dateC.TabIndex = 25
        Me.dateC.Text = "Date:"
        '
        'cookieOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.dateC)
        Me.Controls.Add(Me.userCookieIDTE)
        Me.Controls.Add(Me.yearCookieIDTE)
        Me.Controls.Add(Me.inventoryIDTE)
        Me.Controls.Add(Me.userIDTE)
        Me.Controls.Add(Me.orderIDTE)
        Me.Controls.Add(Me.deleteC)
        Me.Controls.Add(Me.insertC)
        Me.Controls.Add(Me.pickupQTB)
        Me.Controls.Add(Me.cookieNTB)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.returnQTB)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.orderQTB)
        Me.Controls.Add(Me.orderID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.updateC)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "cookieOrder"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents updateC As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents orderID As Label
    Friend WithEvents orderQTB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents returnQTB As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cookieNTB As TextBox
    Friend WithEvents pickupQTB As TextBox
    Friend WithEvents insertC As Button
    Friend WithEvents deleteC As Button
    Friend WithEvents orderIDTE As Label
    Friend WithEvents userIDTE As Label
    Friend WithEvents inventoryIDTE As Label
    Friend WithEvents yearCookieIDTE As Label
    Friend WithEvents userCookieIDTE As Label
    Friend WithEvents dateC As Label
End Class
