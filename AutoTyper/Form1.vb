Imports System.Runtime.InteropServices

Public Class Form1

    Dim CurrentLine As String
    Dim KeyQueued As Boolean
    <DllImport("user32.dll")> Public Shared Function GetAsyncKeyState(ByVal vKey As Int32) As Short
    End Function
    Dim DKeys(9) As Int32
    Sub saveS()
        My.Settings.Reload()
        My.Settings.Lines = ""
        For Each Stri As String In StrBox.Items
            If My.Settings.Lines <> "" Then
                My.Settings.Lines = My.Settings.Lines + vbCrLf + Stri
            Else
                My.Settings.Lines = Stri
            End If

        Next
        My.Settings.Timers = NumericUpDown1.Value
        My.Settings.Save()
    End Sub
    Sub LoadS()
        My.Settings.Reload()
        Dim temp = Split(My.Settings.Lines, vbCrLf)
        For Each t As String In temp
            StrBox.Items.Add(t)
        Next
        If My.Settings.Timers > 99 Then NumericUpDown1.Value = My.Settings.Timers
        Dim c
        For c = 0 To StrBox.Items.Count - 1
            NumBox.Items.Add(c)
        Next
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MaximumSize = Me.Size
        Me.MinimumSize = Me.Size
        DKeys(0) = Keys.D0
        DKeys(1) = Keys.D1
        DKeys(2) = Keys.D2
        DKeys(3) = Keys.D3
        DKeys(4) = Keys.D4
        DKeys(5) = Keys.D5
        DKeys(6) = Keys.D6
        DKeys(7) = Keys.D7
        DKeys(8) = Keys.D8
        DKeys(9) = Keys.D9
        LoadS()
    End Sub
    Sub TypeCurLine()

        My.Computer.Keyboard.SendKeys(CurrentLine)

    End Sub
    Private Sub StrBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StrBox.SelectedIndexChanged
        If StrBox.SelectedIndex <> -1 Then
            delB.Enabled = True
        Else
            delB.Enabled = False
        End If
        NumBox.SelectedIndex = StrBox.SelectedIndex
    End Sub

    Private Sub NumBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumBox.SelectedIndexChanged
        If NumBox.SelectedIndex <> -1 Then
            delB.Enabled = True
        Else
            delB.Enabled = False
        End If
        StrBox.SelectedIndex = NumBox.SelectedIndex
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Visible = Not Me.Visible
        saveS()
    End Sub

    Private Sub addB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addB.Click
        If StrBox.Items.Count >= 9 Then addB.Enabled = False Else addB.Enabled = True
        StrBox.Items.Add(InputBox("New String:"))
        NumBox.Items.Add(StrBox.Items.Count - 1)
        saveS()
    End Sub

    Private Sub delB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delB.Click
        If StrBox.Items.Count >= 9 Then addB.Enabled = False Else addB.Enabled = True

        StrBox.Items.RemoveAt(StrBox.SelectedIndex)
        NumBox.Items.Clear()
        Dim temp
        For temp = 0 To StrBox.Items.Count - 1
            NumBox.Items.Add(temp)
        Next
        saveS()
    End Sub

    Private Sub ScanTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScanTimer.Tick
        If CheckBox1.Checked Then
            Dim GotKey As Integer
            GotKey = 255
            While My.Computer.Keyboard.CtrlKeyDown And My.Computer.Keyboard.AltKeyDown
                For i As Integer = 0 To 9
                    Dim iskey As Boolean
                    iskey = GetAsyncKeyState(DKeys(i))
                    If iskey Then GotKey = i
                Next
                If GotKey < 255 Then

                    'MsgBox("Got key")
                    CurrentLine = StrBox.Items.Item(GotKey)


                    If My.Computer.Keyboard.ShiftKeyDown Then
                        RepTimer.Interval = NumericUpDown1.Value
                        RepTimer.Enabled = True
                    Else
                        KeyQueued = True
                        RepTimer.Enabled = False
                    End If
                End If
            End While


        End If
    End Sub

    Private Sub RepTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepTimer.Tick
        TypeCurLine()
    End Sub

    Private Sub QTmr_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QTmr.Tick
        If KeyQueued Then
            KeyQueued = False
            TypeCurLine()

        End If
    End Sub
End Class
