Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel

Public Class Form1
    Dim ports As Array

    Delegate Sub SetTextCallback(ByVal [text] As String) 'Added to prevent threading errors during receiveing of data

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    '------------------------------------------------
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ports = IO.Ports.SerialPort.GetPortNames()
        COMComboBox.Items.AddRange(ports)

    End Sub

    Private Sub BrowseButton_Click(sender As Object, e As EventArgs) Handles BrowseButton.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            FileText.Text = fd.FileName
            LoadButton.Enabled = True
        End If
    End Sub

    Private Sub FileText_TextChanged(sender As Object, e As EventArgs) Handles FileText.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Serial_DataReceived(sender As System.Object, e As System.IO.Ports.SerialDataReceivedEventArgs) Handles Serial.DataReceived
        ReceivedText(Serial.ReadExisting())
    End Sub

    Private Sub ReceivedText(ByVal [text] As String) 'input from ReadExisting
        If Me.ResponseRichTextBox.InvokeRequired Then
            Dim x As New SetTextCallback(AddressOf ReceivedText)
            Me.Invoke(x, New Object() {(text)})
        Else
            Me.ResponseRichTextBox.Text &= [text] 'append text
        End If
    End Sub

    Private Sub ConnectButton_Click(sender As Object, e As EventArgs) Handles ConnectButton.Click
        If COMComboBox.Text <> "" And BaudComboBox.Text <> "" Then
            Serial.PortName = COMComboBox.Text
            Serial.BaudRate = BaudComboBox.Text
            Serial.Open()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Serial.Write("ACK")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Serial.Write("UP")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Serial.Write("DOWN")
    End Sub

    Private Sub LoadButton_Click(sender As Object, e As EventArgs) Handles LoadButton.Click
        Dim fileReader As New System.IO.StreamReader(FileText.Text) 'Open the file
        Dim data As String = fileReader.ReadToEnd()

        Serial.Write(data)
        fileReader.Close()
    End Sub
End Class
