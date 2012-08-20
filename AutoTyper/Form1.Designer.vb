<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NumBox = New System.Windows.Forms.ListBox()
        Me.StrBox = New System.Windows.Forms.ListBox()
        Me.addB = New System.Windows.Forms.Button()
        Me.delB = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ScanTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RepTimer = New System.Windows.Forms.Timer(Me.components)
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.QTmr = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NumBox)
        Me.GroupBox1.Controls.Add(Me.StrBox)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(316, 237)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Text lines"
        '
        'NumBox
        '
        Me.NumBox.FormattingEnabled = True
        Me.NumBox.ItemHeight = 12
        Me.NumBox.Location = New System.Drawing.Point(245, 19)
        Me.NumBox.Name = "NumBox"
        Me.NumBox.Size = New System.Drawing.Size(59, 208)
        Me.NumBox.TabIndex = 1
        '
        'StrBox
        '
        Me.StrBox.FormattingEnabled = True
        Me.StrBox.ItemHeight = 12
        Me.StrBox.Location = New System.Drawing.Point(7, 19)
        Me.StrBox.Name = "StrBox"
        Me.StrBox.Size = New System.Drawing.Size(232, 208)
        Me.StrBox.TabIndex = 0
        '
        'addB
        '
        Me.addB.Location = New System.Drawing.Point(20, 256)
        Me.addB.Name = "addB"
        Me.addB.Size = New System.Drawing.Size(75, 23)
        Me.addB.TabIndex = 1
        Me.addB.Text = "Add"
        Me.addB.UseVisualStyleBackColor = True
        '
        'delB
        '
        Me.delB.Enabled = False
        Me.delB.Location = New System.Drawing.Point(102, 255)
        Me.delB.Name = "delB"
        Me.delB.Size = New System.Drawing.Size(75, 23)
        Me.delB.TabIndex = 2
        Me.delB.Text = "Delete"
        Me.delB.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(271, 258)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(58, 16)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Enable"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "AutoTyper"
        Me.NotifyIcon1.Visible = True
        '
        'ScanTimer
        '
        Me.ScanTimer.Enabled = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 285)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 12)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Usage: Press Ctrl+Alt+(Shift for repeat)+(Key)"
        '
        'RepTimer
        '
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(183, 257)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(82, 19)
        Me.NumericUpDown1.TabIndex = 5
        Me.NumericUpDown1.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'QTmr
        '
        Me.QTmr.Enabled = True
        Me.QTmr.Interval = 1000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(101, 301)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "By vladkorotnev, 2012" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "vladkorotnev.github.com"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 326)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.delB)
        Me.Controls.Add(Me.addB)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "AutoTyper"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents NumBox As System.Windows.Forms.ListBox
    Friend WithEvents StrBox As System.Windows.Forms.ListBox
    Friend WithEvents addB As System.Windows.Forms.Button
    Friend WithEvents delB As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ScanTimer As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RepTimer As System.Windows.Forms.Timer
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents QTmr As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
