<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainMenu
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.add = New System.Windows.Forms.Button()
        Me.load = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cookieForm = New System.Windows.Forms.Button()
        Me.load3 = New System.Windows.Forms.Button()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.yearCookieForm = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, -1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1327, 753)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 33)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1319, 716)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Home"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(624, 330)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Home"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.add)
        Me.TabPage2.Controls.Add(Me.load)
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 33)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1319, 716)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Girls"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'add
        '
        Me.add.Location = New System.Drawing.Point(92, 7)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(129, 39)
        Me.add.TabIndex = 4
        Me.add.Text = "Add New Girl"
        Me.add.UseVisualStyleBackColor = True
        '
        'load
        '
        Me.load.Location = New System.Drawing.Point(8, 7)
        Me.load.Name = "load"
        Me.load.Size = New System.Drawing.Size(78, 39)
        Me.load.TabIndex = 3
        Me.load.Text = "Load"
        Me.load.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(8, 52)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1305, 627)
        Me.DataGridView1.TabIndex = 2
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DataGridView2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 33)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1319, 716)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Cookie Order"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(3, 0)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(1308, 696)
        Me.DataGridView2.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.yearCookieForm)
        Me.TabPage4.Controls.Add(Me.Label2)
        Me.TabPage4.Controls.Add(Me.DateTimePicker1)
        Me.TabPage4.Controls.Add(Me.cookieForm)
        Me.TabPage4.Controls.Add(Me.load3)
        Me.TabPage4.Controls.Add(Me.DataGridView3)
        Me.TabPage4.Location = New System.Drawing.Point(4, 33)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1319, 716)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Settings"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1105, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 21)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Cookie Year"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(1207, 9)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowUpDown = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(80, 29)
        Me.DateTimePicker1.TabIndex = 7
        '
        'cookieForm
        '
        Me.cookieForm.Location = New System.Drawing.Point(111, 6)
        Me.cookieForm.Name = "cookieForm"
        Me.cookieForm.Size = New System.Drawing.Size(146, 32)
        Me.cookieForm.TabIndex = 5
        Me.cookieForm.Text = "Add New Cookie"
        Me.cookieForm.UseVisualStyleBackColor = True
        '
        'load3
        '
        Me.load3.Location = New System.Drawing.Point(8, 6)
        Me.load3.Name = "load3"
        Me.load3.Size = New System.Drawing.Size(97, 32)
        Me.load3.TabIndex = 4
        Me.load3.Text = "Load"
        Me.load3.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(8, 44)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(279, 381)
        Me.DataGridView3.TabIndex = 3
        '
        'yearCookieForm
        '
        Me.yearCookieForm.Location = New System.Drawing.Point(534, 12)
        Me.yearCookieForm.Name = "yearCookieForm"
        Me.yearCookieForm.Size = New System.Drawing.Size(166, 32)
        Me.yearCookieForm.TabIndex = 9
        Me.yearCookieForm.Text = "Add Price of Cookie"
        Me.yearCookieForm.UseVisualStyleBackColor = True
        '
        'mainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1327, 752)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "mainMenu"
        Me.Text = "Troop 1521 Cookie Inventory"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents add As Button
    Friend WithEvents load As Button
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents cookieForm As Button
    Friend WithEvents load3 As Button
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents yearCookieForm As Button
End Class
