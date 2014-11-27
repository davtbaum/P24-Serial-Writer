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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.LoadButton = New System.Windows.Forms.Button()
        Me.BrowseButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FileText = New System.Windows.Forms.TextBox()
        Me.ResponseLabel = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.COMComboBox = New System.Windows.Forms.ComboBox()
        Me.ConnectButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BaudComboBox = New System.Windows.Forms.ComboBox()
        Me.ResponseRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Serial = New System.IO.Ports.SerialPort(Me.components)
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'LoadButton
        '
        Me.LoadButton.Enabled = False
        Me.LoadButton.Location = New System.Drawing.Point(12, 237)
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(75, 23)
        Me.LoadButton.TabIndex = 0
        Me.LoadButton.Text = "Send File"
        Me.LoadButton.UseVisualStyleBackColor = True
        '
        'BrowseButton
        '
        Me.BrowseButton.Location = New System.Drawing.Point(12, 208)
        Me.BrowseButton.Name = "BrowseButton"
        Me.BrowseButton.Size = New System.Drawing.Size(75, 23)
        Me.BrowseButton.TabIndex = 1
        Me.BrowseButton.Text = "Browse File"
        Me.BrowseButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 168)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "ACK P24"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FileText
        '
        Me.FileText.Location = New System.Drawing.Point(102, 210)
        Me.FileText.Name = "FileText"
        Me.FileText.Size = New System.Drawing.Size(318, 20)
        Me.FileText.TabIndex = 3
        '
        'ResponseLabel
        '
        Me.ResponseLabel.AutoSize = True
        Me.ResponseLabel.Location = New System.Drawing.Point(317, 79)
        Me.ResponseLabel.Name = "ResponseLabel"
        Me.ResponseLabel.Size = New System.Drawing.Size(77, 13)
        Me.ResponseLabel.TabIndex = 5
        Me.ResponseLabel.Text = "P24 Response"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(102, 168)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "P24 Up"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(194, 168)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "P24 Down"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'COMComboBox
        '
        Me.COMComboBox.FormattingEnabled = True
        Me.COMComboBox.Location = New System.Drawing.Point(12, 41)
        Me.COMComboBox.Name = "COMComboBox"
        Me.COMComboBox.Size = New System.Drawing.Size(75, 21)
        Me.COMComboBox.TabIndex = 8
        '
        'ConnectButton
        '
        Me.ConnectButton.Location = New System.Drawing.Point(194, 39)
        Me.ConnectButton.Name = "ConnectButton"
        Me.ConnectButton.Size = New System.Drawing.Size(107, 23)
        Me.ConnectButton.TabIndex = 9
        Me.ConnectButton.Text = "Connect P24"
        Me.ConnectButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "COM Port"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(122, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Baud"
        '
        'BaudComboBox
        '
        Me.BaudComboBox.FormattingEnabled = True
        Me.BaudComboBox.Items.AddRange(New Object() {"9600"})
        Me.BaudComboBox.Location = New System.Drawing.Point(102, 41)
        Me.BaudComboBox.Name = "BaudComboBox"
        Me.BaudComboBox.Size = New System.Drawing.Size(75, 21)
        Me.BaudComboBox.TabIndex = 12
        '
        'ResponseRichTextBox
        '
        Me.ResponseRichTextBox.Location = New System.Drawing.Point(306, 95)
        Me.ResponseRichTextBox.Name = "ResponseRichTextBox"
        Me.ResponseRichTextBox.Size = New System.Drawing.Size(100, 96)
        Me.ResponseRichTextBox.TabIndex = 13
        Me.ResponseRichTextBox.Text = ""
        '
        'Serial
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 271)
        Me.Controls.Add(Me.ResponseRichTextBox)
        Me.Controls.Add(Me.BaudComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ConnectButton)
        Me.Controls.Add(Me.COMComboBox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ResponseLabel)
        Me.Controls.Add(Me.FileText)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BrowseButton)
        Me.Controls.Add(Me.LoadButton)
        Me.Name = "Form1"
        Me.Text = "ENEE440 File Loader Thing"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LoadButton As System.Windows.Forms.Button
    Friend WithEvents BrowseButton As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents FileText As System.Windows.Forms.TextBox
    Friend WithEvents ResponseLabel As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents COMComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ConnectButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BaudComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ResponseRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Serial As System.IO.Ports.SerialPort

End Class
