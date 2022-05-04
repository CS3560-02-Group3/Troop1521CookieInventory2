<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cookieForm
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
        Me.update = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.insert = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cookieNameTB = New System.Windows.Forms.TextBox()
        Me.cookieIDText = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(143, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add Cookie"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cookie ID"
        '
        'update
        '
        Me.update.Location = New System.Drawing.Point(229, 327)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(86, 34)
        Me.update.TabIndex = 3
        Me.update.Text = "Update"
        Me.update.UseVisualStyleBackColor = True
        '
        'delete
        '
        Me.delete.AccessibleDescription = "delete"
        Me.delete.Location = New System.Drawing.Point(432, 327)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(86, 37)
        Me.delete.TabIndex = 5
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = True
        '
        'insert
        '
        Me.insert.AccessibleDescription = "insert"
        Me.insert.AccessibleName = "insert"
        Me.insert.Location = New System.Drawing.Point(229, 329)
        Me.insert.Name = "insert"
        Me.insert.Size = New System.Drawing.Size(93, 33)
        Me.insert.TabIndex = 6
        Me.insert.Text = "Insert"
        Me.insert.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Name of Cookie"
        '
        'cookieNameTB
        '
        Me.cookieNameTB.Location = New System.Drawing.Point(189, 143)
        Me.cookieNameTB.Name = "cookieNameTB"
        Me.cookieNameTB.Size = New System.Drawing.Size(188, 29)
        Me.cookieNameTB.TabIndex = 2
        '
        'cookieIDText
        '
        Me.cookieIDText.AutoSize = True
        Me.cookieIDText.Location = New System.Drawing.Point(147, 102)
        Me.cookieIDText.Name = "cookieIDText"
        Me.cookieIDText.Size = New System.Drawing.Size(0, 21)
        Me.cookieIDText.TabIndex = 8
        '
        'cookieForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 413)
        Me.Controls.Add(Me.cookieIDText)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.insert)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.update)
        Me.Controls.Add(Me.cookieNameTB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "cookieForm"
        Me.Text = "Add Cookie"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents update As Button
    Friend WithEvents delete As Button
    Friend WithEvents insert As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cookieNameTB As TextBox
    Friend WithEvents cookieIDText As Label
End Class
