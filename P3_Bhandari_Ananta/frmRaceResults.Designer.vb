<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRaceResults
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.gbxRaceResults = New System.Windows.Forms.GroupBox()
        Me.lbl3rdPlace = New System.Windows.Forms.TextBox()
        Me.lbl2ndPlace = New System.Windows.Forms.TextBox()
        Me.lbl1stPlace = New System.Windows.Forms.TextBox()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.btnCalculateResults = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtRunner3Time = New System.Windows.Forms.TextBox()
        Me.txtRunner2Time = New System.Windows.Forms.TextBox()
        Me.txtRunner1Time = New System.Windows.Forms.TextBox()
        Me.txtRunner3 = New System.Windows.Forms.TextBox()
        Me.txtRunner2 = New System.Windows.Forms.TextBox()
        Me.txtRunner1 = New System.Windows.Forms.TextBox()
        Me.Run3 = New System.Windows.Forms.Label()
        Me.Run2 = New System.Windows.Forms.Label()
        Me.Run1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbxRaceResults.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(320, 442)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 41)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'gbxRaceResults
        '
        Me.gbxRaceResults.Controls.Add(Me.lbl3rdPlace)
        Me.gbxRaceResults.Controls.Add(Me.lbl2ndPlace)
        Me.gbxRaceResults.Controls.Add(Me.lbl1stPlace)
        Me.gbxRaceResults.Controls.Add(Me.lbl3)
        Me.gbxRaceResults.Controls.Add(Me.lbl2)
        Me.gbxRaceResults.Controls.Add(Me.lbl1)
        Me.gbxRaceResults.Location = New System.Drawing.Point(36, 230)
        Me.gbxRaceResults.Name = "gbxRaceResults"
        Me.gbxRaceResults.Size = New System.Drawing.Size(338, 192)
        Me.gbxRaceResults.TabIndex = 44
        Me.gbxRaceResults.TabStop = False
        Me.gbxRaceResults.Text = "Race Results"
        '
        'lbl3rdPlace
        '
        Me.lbl3rdPlace.BackColor = System.Drawing.SystemColors.Control
        Me.lbl3rdPlace.Location = New System.Drawing.Point(139, 129)
        Me.lbl3rdPlace.Name = "lbl3rdPlace"
        Me.lbl3rdPlace.Size = New System.Drawing.Size(100, 20)
        Me.lbl3rdPlace.TabIndex = 2
        '
        'lbl2ndPlace
        '
        Me.lbl2ndPlace.BackColor = System.Drawing.SystemColors.Control
        Me.lbl2ndPlace.Location = New System.Drawing.Point(139, 81)
        Me.lbl2ndPlace.Name = "lbl2ndPlace"
        Me.lbl2ndPlace.Size = New System.Drawing.Size(100, 20)
        Me.lbl2ndPlace.TabIndex = 1
        '
        'lbl1stPlace
        '
        Me.lbl1stPlace.BackColor = System.Drawing.SystemColors.Control
        Me.lbl1stPlace.Location = New System.Drawing.Point(139, 37)
        Me.lbl1stPlace.Name = "lbl1stPlace"
        Me.lbl1stPlace.Size = New System.Drawing.Size(100, 20)
        Me.lbl1stPlace.TabIndex = 0
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(74, 132)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(55, 13)
        Me.lbl3.TabIndex = 2
        Me.lbl3.Text = "3rd Place:"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(74, 84)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(58, 13)
        Me.lbl2.TabIndex = 1
        Me.lbl2.Text = "2nd Place:"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(74, 40)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(54, 13)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "1st Place:"
        '
        'btnCalculateResults
        '
        Me.btnCalculateResults.Location = New System.Drawing.Point(57, 442)
        Me.btnCalculateResults.Name = "btnCalculateResults"
        Me.btnCalculateResults.Size = New System.Drawing.Size(75, 41)
        Me.btnCalculateResults.TabIndex = 6
        Me.btnCalculateResults.Text = "Calculate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Results"
        Me.btnCalculateResults.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(196, 442)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 41)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtRunner3Time
        '
        Me.txtRunner3Time.Location = New System.Drawing.Point(276, 194)
        Me.txtRunner3Time.Name = "txtRunner3Time"
        Me.txtRunner3Time.Size = New System.Drawing.Size(71, 20)
        Me.txtRunner3Time.TabIndex = 5
        '
        'txtRunner2Time
        '
        Me.txtRunner2Time.Location = New System.Drawing.Point(276, 154)
        Me.txtRunner2Time.Name = "txtRunner2Time"
        Me.txtRunner2Time.Size = New System.Drawing.Size(71, 20)
        Me.txtRunner2Time.TabIndex = 4
        '
        'txtRunner1Time
        '
        Me.txtRunner1Time.Location = New System.Drawing.Point(276, 117)
        Me.txtRunner1Time.Name = "txtRunner1Time"
        Me.txtRunner1Time.Size = New System.Drawing.Size(71, 20)
        Me.txtRunner1Time.TabIndex = 3
        '
        'txtRunner3
        '
        Me.txtRunner3.Location = New System.Drawing.Point(107, 194)
        Me.txtRunner3.Name = "txtRunner3"
        Me.txtRunner3.Size = New System.Drawing.Size(131, 20)
        Me.txtRunner3.TabIndex = 2
        '
        'txtRunner2
        '
        Me.txtRunner2.Location = New System.Drawing.Point(107, 154)
        Me.txtRunner2.Name = "txtRunner2"
        Me.txtRunner2.Size = New System.Drawing.Size(131, 20)
        Me.txtRunner2.TabIndex = 1
        '
        'txtRunner1
        '
        Me.txtRunner1.Location = New System.Drawing.Point(107, 117)
        Me.txtRunner1.Name = "txtRunner1"
        Me.txtRunner1.Size = New System.Drawing.Size(131, 20)
        Me.txtRunner1.TabIndex = 0
        '
        'Run3
        '
        Me.Run3.AutoSize = True
        Me.Run3.Location = New System.Drawing.Point(33, 194)
        Me.Run3.Name = "Run3"
        Me.Run3.Size = New System.Drawing.Size(54, 13)
        Me.Run3.TabIndex = 37
        Me.Run3.Text = "Runner 3:"
        '
        'Run2
        '
        Me.Run2.AutoSize = True
        Me.Run2.Location = New System.Drawing.Point(33, 154)
        Me.Run2.Name = "Run2"
        Me.Run2.Size = New System.Drawing.Size(54, 13)
        Me.Run2.TabIndex = 36
        Me.Run2.Text = "Runner 2:"
        '
        'Run1
        '
        Me.Run1.AutoSize = True
        Me.Run1.Location = New System.Drawing.Point(33, 117)
        Me.Run1.Name = "Run1"
        Me.Run1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Run1.Size = New System.Drawing.Size(54, 13)
        Me.Run1.TabIndex = 35
        Me.Run1.Text = "Runner 1:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(273, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 26)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Finishing Time" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(in seconds)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(131, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 40)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Enter the three runners' names and " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                   finishing times"
        '
        'frmRaceResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 508)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.gbxRaceResults)
        Me.Controls.Add(Me.btnCalculateResults)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtRunner3Time)
        Me.Controls.Add(Me.txtRunner2Time)
        Me.Controls.Add(Me.txtRunner1Time)
        Me.Controls.Add(Me.txtRunner3)
        Me.Controls.Add(Me.txtRunner2)
        Me.Controls.Add(Me.txtRunner1)
        Me.Controls.Add(Me.Run3)
        Me.Controls.Add(Me.Run2)
        Me.Controls.Add(Me.Run1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRaceResults"
        Me.Text = "Race Results by (c) Ananta  Bhandari July 16 2014 "
        Me.gbxRaceResults.ResumeLayout(False)
        Me.gbxRaceResults.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents gbxRaceResults As System.Windows.Forms.GroupBox
    Friend WithEvents lbl3rdPlace As System.Windows.Forms.TextBox
    Friend WithEvents lbl2ndPlace As System.Windows.Forms.TextBox
    Friend WithEvents lbl1stPlace As System.Windows.Forms.TextBox
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents btnCalculateResults As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtRunner3Time As System.Windows.Forms.TextBox
    Friend WithEvents txtRunner2Time As System.Windows.Forms.TextBox
    Friend WithEvents txtRunner1Time As System.Windows.Forms.TextBox
    Friend WithEvents txtRunner3 As System.Windows.Forms.TextBox
    Friend WithEvents txtRunner2 As System.Windows.Forms.TextBox
    Friend WithEvents txtRunner1 As System.Windows.Forms.TextBox
    Private WithEvents Run3 As System.Windows.Forms.Label
    Private WithEvents Run2 As System.Windows.Forms.Label
    Private WithEvents Run1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
