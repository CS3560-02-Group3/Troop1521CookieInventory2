<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class salesType
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
        Me.salesTypeIDTB = New System.Windows.Forms.TextBox()
        Me.submit = New System.Windows.Forms.Button()
        Me.salesTypes = New System.Windows.Forms.ComboBox()
        Me.update = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(116, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Choose a Sales Type:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(116, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Sales Type ID:"
        '
        'salesTypeIDTB
        '
        Me.salesTypeIDTB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salesTypeIDTB.Location = New System.Drawing.Point(237, 100)
        Me.salesTypeIDTB.Name = "salesTypeIDTB"
        Me.salesTypeIDTB.Size = New System.Drawing.Size(100, 29)
        Me.salesTypeIDTB.TabIndex = 3
        '
        'submit
        '
        Me.submit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit.Location = New System.Drawing.Point(359, 276)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(96, 33)
        Me.submit.TabIndex = 16
        Me.submit.Text = "Submit"
        Me.submit.UseVisualStyleBackColor = True
        '
        'salesTypes
        '
        Me.salesTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.salesTypes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salesTypes.FormattingEnabled = True
        Me.salesTypes.Items.AddRange(New Object() {"Girl Delivery", "Online Order"})
        Me.salesTypes.Location = New System.Drawing.Point(275, 144)
        Me.salesTypes.Name = "salesTypes"
        Me.salesTypes.Size = New System.Drawing.Size(121, 29)
        Me.salesTypes.TabIndex = 17
        '
        'update
        '
        Me.update.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update.Location = New System.Drawing.Point(237, 276)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(96, 33)
        Me.update.TabIndex = 19
        Me.update.Text = "Update"
        Me.update.UseVisualStyleBackColor = True
        '
        'delete
        '
        Me.delete.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete.Location = New System.Drawing.Point(120, 276)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(96, 33)
        Me.delete.TabIndex = 20
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(100, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(523, 84)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Instructions:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "To submit: choose a Sales Type, leave the ID blank, and press Subm" &
    "it" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "To update: type the ID and select the updated Sales Type, and press Update" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    "To delete: type the ID and press Delete"
        '
        'salesType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.update)
        Me.Controls.Add(Me.salesTypes)
        Me.Controls.Add(Me.submit)
        Me.Controls.Add(Me.salesTypeIDTB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "salesType"
        Me.Text = "Sales Type"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents salesTypeIDTB As TextBox
    Friend WithEvents submit As Button
    Friend WithEvents salesTypes As ComboBox
    Friend WithEvents update As Button
    Friend WithEvents delete As Button
    Friend WithEvents Label3 As Label
End Class
