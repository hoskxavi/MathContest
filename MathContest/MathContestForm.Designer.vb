<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MathContestForm
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
        Me.components = New System.ComponentModel.Container()
        Me.InputGroupBox = New System.Windows.Forms.GroupBox()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.GradeLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.GradeTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.OutputGroupBox = New System.Windows.Forms.GroupBox()
        Me.ResultLabel = New System.Windows.Forms.Label()
        Me.SecondNumberLabel = New System.Windows.Forms.Label()
        Me.FirstNumberLabel = New System.Windows.Forms.Label()
        Me.ResultTextBox = New System.Windows.Forms.TextBox()
        Me.SecondNumberTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNumberTextBox = New System.Windows.Forms.TextBox()
        Me.AcceptButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.OperationGroupBox = New System.Windows.Forms.GroupBox()
        Me.DivideRadioButton = New System.Windows.Forms.RadioButton()
        Me.MultiplyRadioButton = New System.Windows.Forms.RadioButton()
        Me.SubtractRadioButton = New System.Windows.Forms.RadioButton()
        Me.AddRadioButton = New System.Windows.Forms.RadioButton()
        Me.MathContestToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.InputGroupBox.SuspendLayout()
        Me.OutputGroupBox.SuspendLayout()
        Me.OperationGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'InputGroupBox
        '
        Me.InputGroupBox.Controls.Add(Me.AgeLabel)
        Me.InputGroupBox.Controls.Add(Me.GradeLabel)
        Me.InputGroupBox.Controls.Add(Me.NameLabel)
        Me.InputGroupBox.Controls.Add(Me.AgeTextBox)
        Me.InputGroupBox.Controls.Add(Me.GradeTextBox)
        Me.InputGroupBox.Controls.Add(Me.NameTextBox)
        Me.InputGroupBox.Location = New System.Drawing.Point(30, 24)
        Me.InputGroupBox.Name = "InputGroupBox"
        Me.InputGroupBox.Size = New System.Drawing.Size(549, 125)
        Me.InputGroupBox.TabIndex = 0
        Me.InputGroupBox.TabStop = False
        Me.InputGroupBox.Text = "GroupBox1"
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Location = New System.Drawing.Point(411, 34)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(36, 20)
        Me.AgeLabel.TabIndex = 5
        Me.AgeLabel.Text = "Age"
        '
        'GradeLabel
        '
        Me.GradeLabel.AutoSize = True
        Me.GradeLabel.Location = New System.Drawing.Point(334, 33)
        Me.GradeLabel.Name = "GradeLabel"
        Me.GradeLabel.Size = New System.Drawing.Size(49, 20)
        Me.GradeLabel.TabIndex = 4
        Me.GradeLabel.Text = "Grade"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(13, 33)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(104, 20)
        Me.NameLabel.TabIndex = 3
        Me.NameLabel.Text = "Student Name"
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Location = New System.Drawing.Point(411, 60)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(39, 27)
        Me.AgeTextBox.TabIndex = 2
        Me.MathContestToolTip.SetToolTip(Me.AgeTextBox, "Input student age.")
        '
        'GradeTextBox
        '
        Me.GradeTextBox.Location = New System.Drawing.Point(338, 62)
        Me.GradeTextBox.Name = "GradeTextBox"
        Me.GradeTextBox.Size = New System.Drawing.Size(34, 27)
        Me.GradeTextBox.TabIndex = 1
        Me.MathContestToolTip.SetToolTip(Me.GradeTextBox, "Input student grade.")
        '
        'NameTextBox
        '
        Me.NameTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.NameTextBox.Location = New System.Drawing.Point(13, 60)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(277, 27)
        Me.NameTextBox.TabIndex = 0
        Me.MathContestToolTip.SetToolTip(Me.NameTextBox, "Input student name here.")
        '
        'OutputGroupBox
        '
        Me.OutputGroupBox.Controls.Add(Me.ResultLabel)
        Me.OutputGroupBox.Controls.Add(Me.SecondNumberLabel)
        Me.OutputGroupBox.Controls.Add(Me.FirstNumberLabel)
        Me.OutputGroupBox.Controls.Add(Me.ResultTextBox)
        Me.OutputGroupBox.Controls.Add(Me.SecondNumberTextBox)
        Me.OutputGroupBox.Controls.Add(Me.FirstNumberTextBox)
        Me.OutputGroupBox.Location = New System.Drawing.Point(43, 186)
        Me.OutputGroupBox.Name = "OutputGroupBox"
        Me.OutputGroupBox.Size = New System.Drawing.Size(296, 242)
        Me.OutputGroupBox.TabIndex = 1
        Me.OutputGroupBox.TabStop = False
        Me.OutputGroupBox.Text = "Math Input"
        '
        'ResultLabel
        '
        Me.ResultLabel.AutoSize = True
        Me.ResultLabel.Location = New System.Drawing.Point(29, 165)
        Me.ResultLabel.Name = "ResultLabel"
        Me.ResultLabel.Size = New System.Drawing.Size(123, 20)
        Me.ResultLabel.TabIndex = 5
        Me.ResultLabel.Text = "Input Result Here"
        '
        'SecondNumberLabel
        '
        Me.SecondNumberLabel.AutoSize = True
        Me.SecondNumberLabel.Location = New System.Drawing.Point(27, 102)
        Me.SecondNumberLabel.Name = "SecondNumberLabel"
        Me.SecondNumberLabel.Size = New System.Drawing.Size(116, 20)
        Me.SecondNumberLabel.TabIndex = 4
        Me.SecondNumberLabel.Text = "Second Number"
        '
        'FirstNumberLabel
        '
        Me.FirstNumberLabel.AutoSize = True
        Me.FirstNumberLabel.Location = New System.Drawing.Point(29, 36)
        Me.FirstNumberLabel.Name = "FirstNumberLabel"
        Me.FirstNumberLabel.Size = New System.Drawing.Size(94, 20)
        Me.FirstNumberLabel.TabIndex = 3
        Me.FirstNumberLabel.Text = "First Number"
        '
        'ResultTextBox
        '
        Me.ResultTextBox.Location = New System.Drawing.Point(30, 191)
        Me.ResultTextBox.Name = "ResultTextBox"
        Me.ResultTextBox.Size = New System.Drawing.Size(125, 27)
        Me.ResultTextBox.TabIndex = 3
        Me.MathContestToolTip.SetToolTip(Me.ResultTextBox, "Input the answer to the math operation here.")
        '
        'SecondNumberTextBox
        '
        Me.SecondNumberTextBox.Location = New System.Drawing.Point(27, 129)
        Me.SecondNumberTextBox.Name = "SecondNumberTextBox"
        Me.SecondNumberTextBox.ReadOnly = True
        Me.SecondNumberTextBox.Size = New System.Drawing.Size(125, 27)
        Me.SecondNumberTextBox.TabIndex = 1
        Me.SecondNumberTextBox.TabStop = False
        '
        'FirstNumberTextBox
        '
        Me.FirstNumberTextBox.Location = New System.Drawing.Point(26, 62)
        Me.FirstNumberTextBox.Name = "FirstNumberTextBox"
        Me.FirstNumberTextBox.ReadOnly = True
        Me.FirstNumberTextBox.Size = New System.Drawing.Size(125, 27)
        Me.FirstNumberTextBox.TabIndex = 0
        Me.FirstNumberTextBox.TabStop = False
        '
        'AcceptButton
        '
        Me.AcceptButton.Location = New System.Drawing.Point(640, 58)
        Me.AcceptButton.Name = "AcceptButton"
        Me.AcceptButton.Size = New System.Drawing.Size(94, 29)
        Me.AcceptButton.TabIndex = 2
        Me.AcceptButton.TabStop = False
        Me.AcceptButton.Text = "&Submit"
        Me.MathContestToolTip.SetToolTip(Me.AcceptButton, "Submit answer. Alt + S")
        Me.AcceptButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(640, 111)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(94, 29)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.TabStop = False
        Me.ClearButton.Text = "&Clear"
        Me.MathContestToolTip.SetToolTip(Me.ClearButton, "Clear all fields. Alt + C")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SummaryButton
        '
        Me.SummaryButton.Location = New System.Drawing.Point(640, 160)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(94, 29)
        Me.SummaryButton.TabIndex = 4
        Me.SummaryButton.TabStop = False
        Me.SummaryButton.Text = "Summa&ry"
        Me.MathContestToolTip.SetToolTip(Me.SummaryButton, "View results. Alt + R")
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(640, 207)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(94, 29)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.TabStop = False
        Me.ExitButton.Text = "&Exit"
        Me.MathContestToolTip.SetToolTip(Me.ExitButton, "Exit program. Alt + E")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'OperationGroupBox
        '
        Me.OperationGroupBox.Controls.Add(Me.DivideRadioButton)
        Me.OperationGroupBox.Controls.Add(Me.MultiplyRadioButton)
        Me.OperationGroupBox.Controls.Add(Me.SubtractRadioButton)
        Me.OperationGroupBox.Controls.Add(Me.AddRadioButton)
        Me.OperationGroupBox.Location = New System.Drawing.Point(364, 195)
        Me.OperationGroupBox.Name = "OperationGroupBox"
        Me.OperationGroupBox.Size = New System.Drawing.Size(161, 233)
        Me.OperationGroupBox.TabIndex = 6
        Me.OperationGroupBox.TabStop = False
        Me.OperationGroupBox.Text = "Math Options"
        '
        'DivideRadioButton
        '
        Me.DivideRadioButton.AutoSize = True
        Me.DivideRadioButton.Location = New System.Drawing.Point(29, 155)
        Me.DivideRadioButton.Name = "DivideRadioButton"
        Me.DivideRadioButton.Size = New System.Drawing.Size(73, 24)
        Me.DivideRadioButton.TabIndex = 3
        Me.DivideRadioButton.Text = "Divide"
        Me.MathContestToolTip.SetToolTip(Me.DivideRadioButton, "Division Operation.")
        Me.DivideRadioButton.UseVisualStyleBackColor = True
        '
        'MultiplyRadioButton
        '
        Me.MultiplyRadioButton.AutoSize = True
        Me.MultiplyRadioButton.Location = New System.Drawing.Point(31, 124)
        Me.MultiplyRadioButton.Name = "MultiplyRadioButton"
        Me.MultiplyRadioButton.Size = New System.Drawing.Size(84, 24)
        Me.MultiplyRadioButton.TabIndex = 2
        Me.MultiplyRadioButton.Text = "Multiply"
        Me.MathContestToolTip.SetToolTip(Me.MultiplyRadioButton, "Multiplication Operation.")
        Me.MultiplyRadioButton.UseVisualStyleBackColor = True
        '
        'SubtractRadioButton
        '
        Me.SubtractRadioButton.AutoSize = True
        Me.SubtractRadioButton.Location = New System.Drawing.Point(30, 85)
        Me.SubtractRadioButton.Name = "SubtractRadioButton"
        Me.SubtractRadioButton.Size = New System.Drawing.Size(85, 24)
        Me.SubtractRadioButton.TabIndex = 1
        Me.SubtractRadioButton.Text = "Subtract"
        Me.MathContestToolTip.SetToolTip(Me.SubtractRadioButton, "Subtraction operation.")
        Me.SubtractRadioButton.UseVisualStyleBackColor = True
        '
        'AddRadioButton
        '
        Me.AddRadioButton.AutoSize = True
        Me.AddRadioButton.Location = New System.Drawing.Point(31, 47)
        Me.AddRadioButton.Name = "AddRadioButton"
        Me.AddRadioButton.Size = New System.Drawing.Size(58, 24)
        Me.AddRadioButton.TabIndex = 0
        Me.AddRadioButton.Text = "Add"
        Me.MathContestToolTip.SetToolTip(Me.AddRadioButton, "Addition operation.")
        Me.AddRadioButton.UseVisualStyleBackColor = True
        '
        'MathContestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.OperationGroupBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SummaryButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.AcceptButton)
        Me.Controls.Add(Me.OutputGroupBox)
        Me.Controls.Add(Me.InputGroupBox)
        Me.Name = "MathContestForm"
        Me.Text = "Math Contest"
        Me.InputGroupBox.ResumeLayout(False)
        Me.InputGroupBox.PerformLayout()
        Me.OutputGroupBox.ResumeLayout(False)
        Me.OutputGroupBox.PerformLayout()
        Me.OperationGroupBox.ResumeLayout(False)
        Me.OperationGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents InputGroupBox As GroupBox
    Friend WithEvents OutputGroupBox As GroupBox
    Friend WithEvents AgeLabel As Label
    Friend WithEvents GradeLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents GradeTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AcceptButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SummaryButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ResultLabel As Label
    Friend WithEvents SecondNumberLabel As Label
    Friend WithEvents FirstNumberLabel As Label
    Friend WithEvents ResultTextBox As TextBox
    Friend WithEvents SecondNumberTextBox As TextBox
    Friend WithEvents FirstNumberTextBox As TextBox
    Friend WithEvents OperationGroupBox As GroupBox
    Friend WithEvents DivideRadioButton As RadioButton
    Friend WithEvents MultiplyRadioButton As RadioButton
    Friend WithEvents SubtractRadioButton As RadioButton
    Friend WithEvents AddRadioButton As RadioButton
    Friend WithEvents MathContestToolTip As ToolTip
End Class
