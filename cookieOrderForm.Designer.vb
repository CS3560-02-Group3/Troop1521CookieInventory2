<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cookieOrderForm
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
        Me.update = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.orderTB = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.returnTB = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pickupTB = New System.Windows.Forms.TextBox()
        Me.insert = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.orderIDTE = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.noteTE = New System.Windows.Forms.RichTextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.userCB = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'update
        '
        Me.update.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update.Location = New System.Drawing.Point(545, 535)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(95, 32)
        Me.update.TabIndex = 1
        Me.update.Text = "Update"
        Me.update.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(301, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 45)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cookie Order"
        '
        'orderTB
        '
        Me.orderTB.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orderTB.Location = New System.Drawing.Point(734, 240)
        Me.orderTB.Name = "orderTB"
        Me.orderTB.Size = New System.Drawing.Size(100, 25)
        Me.orderTB.TabIndex = 4
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(734, 187)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(203, 22)
        Me.DateTimePicker1.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(618, 240)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 17)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Order Quantity"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(615, 331)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 17)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Pickup Quantity"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(615, 292)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 17)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Return Quantity"
        '
        'returnTB
        '
        Me.returnTB.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.returnTB.Location = New System.Drawing.Point(734, 284)
        Me.returnTB.Name = "returnTB"
        Me.returnTB.Size = New System.Drawing.Size(100, 25)
        Me.returnTB.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(615, 399)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 17)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Note"
        '
        'pickupTB
        '
        Me.pickupTB.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pickupTB.Location = New System.Drawing.Point(734, 328)
        Me.pickupTB.Name = "pickupTB"
        Me.pickupTB.Size = New System.Drawing.Size(100, 25)
        Me.pickupTB.TabIndex = 16
        '
        'insert
        '
        Me.insert.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insert.Location = New System.Drawing.Point(107, 535)
        Me.insert.Name = "insert"
        Me.insert.Size = New System.Drawing.Size(95, 32)
        Me.insert.TabIndex = 17
        Me.insert.Text = "Insert"
        Me.insert.UseVisualStyleBackColor = True
        '
        'delete
        '
        Me.delete.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete.Location = New System.Drawing.Point(1009, 535)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(94, 32)
        Me.delete.TabIndex = 18
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = True
        '
        'orderIDTE
        '
        Me.orderIDTE.AutoSize = True
        Me.orderIDTE.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orderIDTE.Location = New System.Drawing.Point(133, 113)
        Me.orderIDTE.Name = "orderIDTE"
        Me.orderIDTE.Size = New System.Drawing.Size(0, 17)
        Me.orderIDTE.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(617, 187)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 19)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Date:"
        '
        'noteTE
        '
        Me.noteTE.Location = New System.Drawing.Point(710, 399)
        Me.noteTE.Name = "noteTE"
        Me.noteTE.Size = New System.Drawing.Size(418, 96)
        Me.noteTE.TabIndex = 29
        Me.noteTE.Text = ""
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(38, 133)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(544, 362)
        Me.DataGridView1.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 17)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Girl"
        '
        'userCB
        '
        Me.userCB.FormattingEnabled = True
        Me.userCB.Location = New System.Drawing.Point(82, 82)
        Me.userCB.Name = "userCB"
        Me.userCB.Size = New System.Drawing.Size(121, 21)
        Me.userCB.TabIndex = 32
        '
        'cookieOrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1202, 607)
        Me.Controls.Add(Me.userCB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.noteTE)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.orderIDTE)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.insert)
        Me.Controls.Add(Me.pickupTB)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.returnTB)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.orderTB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.update)
        Me.Name = "cookieOrderForm"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents update As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents orderTB As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents returnTB As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents pickupTB As TextBox
    Friend WithEvents insert As Button
    Friend WithEvents delete As Button
    Friend WithEvents orderIDTE As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents noteTE As RichTextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents userCB As ComboBox
End Class
