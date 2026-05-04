<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        rtbOutput = New RichTextBox()
        btnWritePunishment = New Button()
        btnDoLoopPunishment = New Button()
        btnDoLoopBottles = New Button()
        btnForLoopBottles = New Button()
        btnExit = New Button()
        SuspendLayout()
        '
        'rtbOutput
        '
        rtbOutput.Location = New Point(12, 12)
        rtbOutput.Name = "rtbOutput"
        rtbOutput.ScrollBars = RichTextBoxScrollBars.Vertical
        rtbOutput.Size = New Size(300, 262)
        rtbOutput.TabIndex = 1
        rtbOutput.Text = ""
        '
        'btnWritePunishment
        '
        btnWritePunishment.Location = New Point(325, 12)
        btnWritePunishment.Name = "btnWritePunishment"
        btnWritePunishment.Size = New Size(130, 45)
        btnWritePunishment.TabIndex = 2
        btnWritePunishment.Text = "Write" & vbLf & "Punishment"
        btnWritePunishment.UseCompatibleTextRendering = True
        btnWritePunishment.UseVisualStyleBackColor = True
        '
        'btnDoLoopPunishment
        '
        btnDoLoopPunishment.Location = New Point(325, 65)
        btnDoLoopPunishment.Name = "btnDoLoopPunishment"
        btnDoLoopPunishment.Size = New Size(130, 45)
        btnDoLoopPunishment.TabIndex = 3
        btnDoLoopPunishment.Text = "Do Loop" & vbLf & "Punishment"
        btnDoLoopPunishment.UseCompatibleTextRendering = True
        btnDoLoopPunishment.UseVisualStyleBackColor = True
        '
        'btnDoLoopBottles
        '
        btnDoLoopBottles.Location = New Point(325, 118)
        btnDoLoopBottles.Name = "btnDoLoopBottles"
        btnDoLoopBottles.Size = New Size(130, 45)
        btnDoLoopBottles.TabIndex = 4
        btnDoLoopBottles.Text = "Do Loop 99" & vbLf & "Bottles"
        btnDoLoopBottles.UseCompatibleTextRendering = True
        btnDoLoopBottles.UseVisualStyleBackColor = True
        '
        'btnForLoopBottles
        '
        btnForLoopBottles.Location = New Point(325, 171)
        btnForLoopBottles.Name = "btnForLoopBottles"
        btnForLoopBottles.Size = New Size(130, 45)
        btnForLoopBottles.TabIndex = 5
        btnForLoopBottles.Text = "For Loop 99" & vbLf & "Bottles"
        btnForLoopBottles.UseCompatibleTextRendering = True
        btnForLoopBottles.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        btnExit.Location = New Point(325, 244)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(130, 30)
        btnExit.TabIndex = 6
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New Size(475, 286)
        Controls.Add(btnExit)
        Controls.Add(btnForLoopBottles)
        Controls.Add(btnDoLoopBottles)
        Controls.Add(btnDoLoopPunishment)
        Controls.Add(btnWritePunishment)
        Controls.Add(rtbOutput)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        
        Name = "Form1"
        Text = "Fun with Looping"
        ResumeLayout(False)
    End Sub

    Friend WithEvents rtbOutput As RichTextBox
    Friend WithEvents btnWritePunishment As Button
    Friend WithEvents btnDoLoopPunishment As Button
    Friend WithEvents btnDoLoopBottles As Button
    Friend WithEvents btnForLoopBottles As Button
    Friend WithEvents btnExit As Button

End Class
