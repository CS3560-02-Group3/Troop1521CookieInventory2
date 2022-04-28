<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class warehouseform
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
        Me.Insert = New System.Windows.Forms.Button()
        Me.Update = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.noteTE = New System.Windows.Forms.RichTextBox()
        Me.warehouseID = New System.Windows.Forms.Label()
        Me.NameLB = New System.Windows.Forms.Label()
        Me.PhoneLB = New System.Windows.Forms.Label()
        Me.AddressLB = New System.Windows.Forms.Label()
        Me.nameTB = New System.Windows.Forms.TextBox()
        Me.AddressTB = New System.Windows.Forms.TextBox()
        Me.PhoneTB = New System.Windows.Forms.TextBox()
        Me.NoteLB = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Insert
        '
        Me.Insert.Location = New System.Drawing.Point(64, 365)
        Me.Insert.Name = "Insert"
        Me.Insert.Size = New System.Drawing.Size(105, 41)
        Me.Insert.TabIndex = 0
        Me.Insert.Text = "Insert"
        Me.Insert.UseVisualStyleBackColor = True
        '
        'Update
        '
        Me.Update.Location = New System.Drawing.Point(345, 365)
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(105, 41)
        Me.Update.TabIndex = 1
        Me.Update.Text = "Update"
        Me.Update.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Location = New System.Drawing.Point(612, 365)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(105, 41)
        Me.Delete.TabIndex = 2
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label1.Location = New System.Drawing.Point(281, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 39)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Warehouse"
        '
        'noteTE
        '
        Me.noteTE.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noteTE.Location = New System.Drawing.Point(211, 253)
        Me.noteTE.Name = "noteTE"
        Me.noteTE.Size = New System.Drawing.Size(380, 96)
        Me.noteTE.TabIndex = 15
        Me.noteTE.Text = ""
        '
        'warehouseID
        '
        Me.warehouseID.AutoSize = True
        Me.warehouseID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.warehouseID.Location = New System.Drawing.Point(53, 53)
        Me.warehouseID.Name = "warehouseID"
        Me.warehouseID.Size = New System.Drawing.Size(25, 21)
        Me.warehouseID.TabIndex = 19
        Me.warehouseID.Text = "ID"
        '
        'NameLB
        '
        Me.NameLB.AutoSize = True
        Me.NameLB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLB.Location = New System.Drawing.Point(51, 93)
        Me.NameLB.Name = "NameLB"
        Me.NameLB.Size = New System.Drawing.Size(56, 21)
        Me.NameLB.TabIndex = 20
        Me.NameLB.Text = " Name"
        '
        'PhoneLB
        '
        Me.PhoneLB.AutoSize = True
        Me.PhoneLB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneLB.Location = New System.Drawing.Point(53, 203)
        Me.PhoneLB.Name = "PhoneLB"
        Me.PhoneLB.Size = New System.Drawing.Size(54, 21)
        Me.PhoneLB.TabIndex = 21
        Me.PhoneLB.Text = "Phone"
        '
        'AddressLB
        '
        Me.AddressLB.AutoSize = True
        Me.AddressLB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressLB.Location = New System.Drawing.Point(51, 147)
        Me.AddressLB.Name = "AddressLB"
        Me.AddressLB.Size = New System.Drawing.Size(66, 21)
        Me.AddressLB.TabIndex = 22
        Me.AddressLB.Text = "Address"
        '
        'nameTB
        '
        Me.nameTB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameTB.Location = New System.Drawing.Point(247, 90)
        Me.nameTB.Name = "nameTB"
        Me.nameTB.Size = New System.Drawing.Size(237, 29)
        Me.nameTB.TabIndex = 23
        '
        'AddressTB
        '
        Me.AddressTB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTB.Location = New System.Drawing.Point(247, 139)
        Me.AddressTB.Name = "AddressTB"
        Me.AddressTB.Size = New System.Drawing.Size(237, 29)
        Me.AddressTB.TabIndex = 24
        '
        'PhoneTB
        '
        Me.PhoneTB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneTB.Location = New System.Drawing.Point(247, 200)
        Me.PhoneTB.Name = "PhoneTB"
        Me.PhoneTB.Size = New System.Drawing.Size(237, 29)
        Me.PhoneTB.TabIndex = 25
        '
        'NoteLB
        '
        Me.NoteLB.AutoSize = True
        Me.NoteLB.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoteLB.Location = New System.Drawing.Point(53, 256)
        Me.NoteLB.Name = "NoteLB"
        Me.NoteLB.Size = New System.Drawing.Size(44, 21)
        Me.NoteLB.TabIndex = 26
        Me.NoteLB.Text = "Note"
        '
        'warehouseform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.NoteLB)
        Me.Controls.Add(Me.PhoneTB)
        Me.Controls.Add(Me.AddressTB)
        Me.Controls.Add(Me.nameTB)
        Me.Controls.Add(Me.AddressLB)
        Me.Controls.Add(Me.PhoneLB)
        Me.Controls.Add(Me.NameLB)
        Me.Controls.Add(Me.warehouseID)
        Me.Controls.Add(Me.noteTE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Update)
        Me.Controls.Add(Me.Insert)
        Me.Name = "warehouseform"
        Me.Text = "Warehouse"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Insert As Button
    Friend WithEvents Update As Button
    Friend WithEvents Delete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents noteTE As RichTextBox
    Friend WithEvents warehouseID As Label
    Friend WithEvents NameLB As Label
    Friend WithEvents PhoneLB As Label
    Friend WithEvents AddressLB As Label
    Friend WithEvents nameTB As TextBox
    Friend WithEvents AddressTB As TextBox
    Friend WithEvents PhoneTB As TextBox
    Friend WithEvents NoteLB As Label
End Class
