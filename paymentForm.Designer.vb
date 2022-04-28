<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class paymentForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.receiveAmountTB = New System.Windows.Forms.TextBox()
        Me.submit = New System.Windows.Forms.Button()
        Me.receiveDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.update = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.noteTB = New System.Windows.Forms.RichTextBox()
        Me.userBalanceIDTB = New System.Windows.Forms.Label()
        Me.yearTB = New System.Windows.Forms.Label()
        Me.userIDTB = New System.Windows.Forms.ComboBox()
        Me.salesTypeIDTB = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(118, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Balance ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(118, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "User ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(118, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sales Type ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(122, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Year"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(120, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Receive Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(122, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Receive Amount"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(122, 269)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 21)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Note"
        '
        'receiveAmountTB
        '
        Me.receiveAmountTB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.receiveAmountTB.Location = New System.Drawing.Point(279, 225)
        Me.receiveAmountTB.Name = "receiveAmountTB"
        Me.receiveAmountTB.Size = New System.Drawing.Size(100, 29)
        Me.receiveAmountTB.TabIndex = 13
        '
        'submit
        '
        Me.submit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit.Location = New System.Drawing.Point(122, 395)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(96, 33)
        Me.submit.TabIndex = 16
        Me.submit.Text = "Insert"
        Me.submit.UseVisualStyleBackColor = True
        '
        'receiveDatePicker
        '
        Me.receiveDatePicker.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.receiveDatePicker.Location = New System.Drawing.Point(279, 199)
        Me.receiveDatePicker.Name = "receiveDatePicker"
        Me.receiveDatePicker.Size = New System.Drawing.Size(200, 20)
        Me.receiveDatePicker.TabIndex = 17
        '
        'update
        '
        Me.update.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update.Location = New System.Drawing.Point(383, 395)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(96, 33)
        Me.update.TabIndex = 20
        Me.update.Text = "Update"
        Me.update.UseVisualStyleBackColor = True
        '
        'delete
        '
        Me.delete.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete.Location = New System.Drawing.Point(646, 395)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(96, 33)
        Me.delete.TabIndex = 21
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = True
        '
        'noteTB
        '
        Me.noteTB.Location = New System.Drawing.Point(279, 272)
        Me.noteTB.Name = "noteTB"
        Me.noteTB.Size = New System.Drawing.Size(395, 96)
        Me.noteTB.TabIndex = 22
        Me.noteTB.Text = ""
        '
        'userBalanceIDTB
        '
        Me.userBalanceIDTB.AutoSize = True
        Me.userBalanceIDTB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userBalanceIDTB.Location = New System.Drawing.Point(275, 62)
        Me.userBalanceIDTB.Name = "userBalanceIDTB"
        Me.userBalanceIDTB.Size = New System.Drawing.Size(0, 21)
        Me.userBalanceIDTB.TabIndex = 23
        '
        'yearTB
        '
        Me.yearTB.AutoSize = True
        Me.yearTB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yearTB.Location = New System.Drawing.Point(275, 168)
        Me.yearTB.Name = "yearTB"
        Me.yearTB.Size = New System.Drawing.Size(0, 21)
        Me.yearTB.TabIndex = 26
        '
        'userIDTB
        '
        Me.userIDTB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userIDTB.FormattingEnabled = True
        Me.userIDTB.Location = New System.Drawing.Point(279, 89)
        Me.userIDTB.Name = "userIDTB"
        Me.userIDTB.Size = New System.Drawing.Size(121, 29)
        Me.userIDTB.TabIndex = 27
        '
        'salesTypeIDTB
        '
        Me.salesTypeIDTB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salesTypeIDTB.FormattingEnabled = True
        Me.salesTypeIDTB.Location = New System.Drawing.Point(279, 126)
        Me.salesTypeIDTB.Name = "salesTypeIDTB"
        Me.salesTypeIDTB.Size = New System.Drawing.Size(121, 29)
        Me.salesTypeIDTB.TabIndex = 28
        '
        'paymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 450)
        Me.Controls.Add(Me.salesTypeIDTB)
        Me.Controls.Add(Me.userIDTB)
        Me.Controls.Add(Me.yearTB)
        Me.Controls.Add(Me.userBalanceIDTB)
        Me.Controls.Add(Me.noteTB)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.update)
        Me.Controls.Add(Me.receiveDatePicker)
        Me.Controls.Add(Me.submit)
        Me.Controls.Add(Me.receiveAmountTB)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "paymentForm"
        Me.Text = "User Balance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents receiveAmountTB As TextBox
    Friend WithEvents submit As Button
    Friend WithEvents receiveDatePicker As DateTimePicker
    Friend WithEvents update As Button
    Friend WithEvents delete As Button
    Friend WithEvents noteTB As RichTextBox
    Friend WithEvents userBalanceIDTB As Label
    Friend WithEvents yearTB As Label
    Friend WithEvents userIDTB As ComboBox
    Friend WithEvents salesTypeIDTB As ComboBox
End Class
