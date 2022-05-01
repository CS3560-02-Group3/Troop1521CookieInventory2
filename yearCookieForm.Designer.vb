<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class yearCookieForm
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
        Me.cookieCB = New System.Windows.Forms.ComboBox()
        Me.priceTB = New System.Windows.Forms.TextBox()
        Me.yearCookieLB = New System.Windows.Forms.Label()
        Me.yearLB = New System.Windows.Forms.Label()
        Me.insert = New System.Windows.Forms.Button()
        Me.update = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(115, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Price of Cookie"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Year Cookie ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(105, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cookie"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(123, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Year"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(119, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Price"
        '
        'cookieCB
        '
        Me.cookieCB.FormattingEnabled = True
        Me.cookieCB.Location = New System.Drawing.Point(186, 168)
        Me.cookieCB.Name = "cookieCB"
        Me.cookieCB.Size = New System.Drawing.Size(150, 21)
        Me.cookieCB.TabIndex = 8
        '
        'priceTB
        '
        Me.priceTB.Location = New System.Drawing.Point(186, 217)
        Me.priceTB.Name = "priceTB"
        Me.priceTB.Size = New System.Drawing.Size(84, 20)
        Me.priceTB.TabIndex = 9
        '
        'yearCookieLB
        '
        Me.yearCookieLB.AutoSize = True
        Me.yearCookieLB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yearCookieLB.Location = New System.Drawing.Point(183, 83)
        Me.yearCookieLB.Name = "yearCookieLB"
        Me.yearCookieLB.Size = New System.Drawing.Size(0, 21)
        Me.yearCookieLB.TabIndex = 5
        '
        'yearLB
        '
        Me.yearLB.AutoSize = True
        Me.yearLB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yearLB.Location = New System.Drawing.Point(183, 128)
        Me.yearLB.Name = "yearLB"
        Me.yearLB.Size = New System.Drawing.Size(0, 21)
        Me.yearLB.TabIndex = 7
        '
        'insert
        '
        Me.insert.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insert.Location = New System.Drawing.Point(186, 291)
        Me.insert.Name = "insert"
        Me.insert.Size = New System.Drawing.Size(79, 35)
        Me.insert.TabIndex = 10
        Me.insert.Text = "Insert"
        Me.insert.UseVisualStyleBackColor = True
        '
        'update
        '
        Me.update.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update.Location = New System.Drawing.Point(187, 291)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(83, 35)
        Me.update.TabIndex = 11
        Me.update.Text = "Update"
        Me.update.UseVisualStyleBackColor = True
        '
        'delete
        '
        Me.delete.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete.Location = New System.Drawing.Point(334, 291)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(76, 35)
        Me.delete.TabIndex = 12
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = True
        '
        'yearCookieForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 388)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.update)
        Me.Controls.Add(Me.insert)
        Me.Controls.Add(Me.priceTB)
        Me.Controls.Add(Me.cookieCB)
        Me.Controls.Add(Me.yearLB)
        Me.Controls.Add(Me.yearCookieLB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "yearCookieForm"
        Me.Text = "Add Cookie Price"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cookieCB As ComboBox
    Friend WithEvents priceTB As TextBox
    Friend WithEvents yearCookieLB As Label
    Friend WithEvents yearLB As Label
    Friend WithEvents insert As Button
    Friend WithEvents update As Button
    Friend WithEvents delete As Button
End Class
