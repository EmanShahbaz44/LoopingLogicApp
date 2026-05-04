Imports System.Runtime.InteropServices

Public Class Form1

	<DllImport("dwmapi.dll", PreserveSig:=True)>
	Private Shared Function DwmSetWindowAttribute(hwnd As IntPtr, attr As Integer, ByRef attrValue As Integer, attrSize As Integer) As Integer
	End Function

	Private Const DWMWA_CAPTION_COLOR As Integer = 35

	Protected Overrides Sub OnHandleCreated(e As EventArgs)
		MyBase.OnHandleCreated(e)
		' Blue (0, 120, 215) in COLORREF BGR format
		Dim captionColor As Integer = (215 << 16) Or (120 << 8) Or 0
		DwmSetWindowAttribute(Handle, DWMWA_CAPTION_COLOR, captionColor, 4)
	End Sub

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		ShowBottlesWithForLoop()
	End Sub

	Private Sub btnWritePunishment_Click(sender As Object, e As EventArgs) Handles btnWritePunishment.Click
		rtbOutput.Clear()
		rtbOutput.AppendText("This was created without a loop." & Environment.NewLine & Environment.NewLine)
		rtbOutput.AppendText("I will complete my assignments on time." & Environment.NewLine)
	End Sub

	Private Sub btnDoLoopPunishment_Click(sender As Object, e As EventArgs) Handles btnDoLoopPunishment.Click
		rtbOutput.Clear()
		rtbOutput.AppendText("This was created with a Do loop." & Environment.NewLine & Environment.NewLine)

		Dim lineNumber As Integer = 1
		Do While lineNumber <= 25
			rtbOutput.AppendText(lineNumber.ToString() & ". I will complete my assignments on time." & Environment.NewLine)
			lineNumber += 1
		Loop
	End Sub

	Private Sub btnDoLoopBottles_Click(sender As Object, e As EventArgs) Handles btnDoLoopBottles.Click
		ShowBottlesWithDoLoop()
	End Sub

	Private Sub btnForLoopBottles_Click(sender As Object, e As EventArgs) Handles btnForLoopBottles.Click
		ShowBottlesWithForLoop()
	End Sub

	Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
		Close()
	End Sub

	Private Sub ShowBottlesWithDoLoop()
		rtbOutput.Clear()
		rtbOutput.AppendText("This was created with a Do loop." & Environment.NewLine & Environment.NewLine)

		Dim count As Integer = 99
		Do While count >= 1
			AppendBottleVerse(count)
			count -= 1
		Loop
	End Sub

	Private Sub ShowBottlesWithForLoop()
		rtbOutput.Clear()
		rtbOutput.AppendText("This was created with a For loop." & Environment.NewLine & Environment.NewLine)

		For count As Integer = 99 To 1 Step -1
			AppendBottleVerse(count)
		Next
	End Sub

	Private Sub AppendBottleVerse(count As Integer)
		rtbOutput.AppendText(GetBottleText(count) & " on the wall," & Environment.NewLine)
		rtbOutput.AppendText(GetBottleText(count) & "." & Environment.NewLine)
		rtbOutput.AppendText("Take one down, pass it around," & Environment.NewLine)
		rtbOutput.AppendText(GetBottleText(count - 1) & " on the wall." & Environment.NewLine & Environment.NewLine)
	End Sub

	Private Function GetBottleText(count As Integer) As String
		If count <= 0 Then
			Return "No more bottles of root beer"
		End If

		If count = 1 Then
			Return "1 bottle of root beer"
		End If

		Return count.ToString() & " bottles of root beer"
	End Function
End Class
