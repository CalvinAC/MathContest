<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MathContest
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
        Me.ButtonsGroupBox = New System.Windows.Forms.GroupBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.Grade_Label = New System.Windows.Forms.Label()
        Me.Age_Label = New System.Windows.Forms.Label()
        Me.Name_Label = New System.Windows.Forms.Label()
        Me.GradeTextbox = New System.Windows.Forms.TextBox()
        Me.AgeTextbox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.MathValuesGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AnswerTextbox = New System.Windows.Forms.TextBox()
        Me.SecondNumTextbox = New System.Windows.Forms.TextBox()
        Me.FirstNumTextbox = New System.Windows.Forms.TextBox()
        Me.MathSelectGroupBox = New System.Windows.Forms.GroupBox()
        Me.DivideRadioButton = New System.Windows.Forms.RadioButton()
        Me.MultiplyRadioButton = New System.Windows.Forms.RadioButton()
        Me.SubtractRadioButton = New System.Windows.Forms.RadioButton()
        Me.AddRadioButton = New System.Windows.Forms.RadioButton()
        Me.StudentInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.AgeBox = New System.Windows.Forms.TextBox()
        Me.GradeBox = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ButtonsGroupBox.SuspendLayout()
        Me.MathValuesGroupBox.SuspendLayout()
        Me.MathSelectGroupBox.SuspendLayout()
        Me.StudentInfoGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonsGroupBox
        '
        Me.ButtonsGroupBox.Controls.Add(Me.ClearButton)
        Me.ButtonsGroupBox.Controls.Add(Me.ExitButton)
        Me.ButtonsGroupBox.Controls.Add(Me.SummaryButton)
        Me.ButtonsGroupBox.Controls.Add(Me.SubmitButton)
        Me.ButtonsGroupBox.Location = New System.Drawing.Point(840, 29)
        Me.ButtonsGroupBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonsGroupBox.Name = "ButtonsGroupBox"
        Me.ButtonsGroupBox.Padding = New System.Windows.Forms.Padding(4)
        Me.ButtonsGroupBox.Size = New System.Drawing.Size(314, 479)
        Me.ButtonsGroupBox.TabIndex = 0
        Me.ButtonsGroupBox.TabStop = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Red
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(32, 369)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(262, 104)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "&Exit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Click or hit Esc kay to end program")
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'SummaryButton
        '
        Me.SummaryButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SummaryButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SummaryButton.Location = New System.Drawing.Point(32, 260)
        Me.SummaryButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(262, 104)
        Me.SummaryButton.TabIndex = 2
        Me.SummaryButton.Text = "Summary"
        Me.ToolTip1.SetToolTip(Me.SummaryButton, "Click to see user info and number of correct attempts to attempts")
        Me.SummaryButton.UseVisualStyleBackColor = False
        '
        'SubmitButton
        '
        Me.SubmitButton.BackColor = System.Drawing.Color.Lime
        Me.SubmitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.SubmitButton.Location = New System.Drawing.Point(32, 31)
        Me.SubmitButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(262, 113)
        Me.SubmitButton.TabIndex = 0
        Me.SubmitButton.Text = "Submit"
        Me.ToolTip1.SetToolTip(Me.SubmitButton, "Click to enter answers once you are determined eleigable")
        Me.SubmitButton.UseVisualStyleBackColor = False
        '
        'Grade_Label
        '
        Me.Grade_Label.AutoSize = True
        Me.Grade_Label.Location = New System.Drawing.Point(248, 28)
        Me.Grade_Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Grade_Label.Name = "Grade_Label"
        Me.Grade_Label.Size = New System.Drawing.Size(36, 13)
        Me.Grade_Label.TabIndex = 5
        Me.Grade_Label.Text = "Grade"
        '
        'Age_Label
        '
        Me.Age_Label.AutoSize = True
        Me.Age_Label.Location = New System.Drawing.Point(198, 28)
        Me.Age_Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Age_Label.Name = "Age_Label"
        Me.Age_Label.Size = New System.Drawing.Size(26, 13)
        Me.Age_Label.TabIndex = 4
        Me.Age_Label.Text = "Age"
        '
        'Name_Label
        '
        Me.Name_Label.AutoSize = True
        Me.Name_Label.Location = New System.Drawing.Point(8, 29)
        Me.Name_Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Name_Label.Name = "Name_Label"
        Me.Name_Label.Size = New System.Drawing.Size(35, 13)
        Me.Name_Label.TabIndex = 3
        Me.Name_Label.Text = "Name"
        '
        'GradeTextbox
        '
        Me.GradeTextbox.BackColor = System.Drawing.Color.MistyRose
        Me.GradeTextbox.Location = New System.Drawing.Point(250, 43)
        Me.GradeTextbox.Margin = New System.Windows.Forms.Padding(2)
        Me.GradeTextbox.Multiline = True
        Me.GradeTextbox.Name = "GradeTextbox"
        Me.GradeTextbox.Size = New System.Drawing.Size(28, 18)
        Me.GradeTextbox.TabIndex = 2
        '
        'AgeTextbox
        '
        Me.AgeTextbox.BackColor = System.Drawing.Color.MistyRose
        Me.AgeTextbox.Location = New System.Drawing.Point(200, 43)
        Me.AgeTextbox.Margin = New System.Windows.Forms.Padding(2)
        Me.AgeTextbox.Multiline = True
        Me.AgeTextbox.Name = "AgeTextbox"
        Me.AgeTextbox.Size = New System.Drawing.Size(31, 18)
        Me.AgeTextbox.TabIndex = 1
        '
        'NameTextBox
        '
        Me.NameTextBox.BackColor = System.Drawing.Color.MistyRose
        Me.NameTextBox.Location = New System.Drawing.Point(8, 43)
        Me.NameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.NameTextBox.Multiline = True
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(162, 18)
        Me.NameTextBox.TabIndex = 0
        '
        'MathValuesGroupBox
        '
        Me.MathValuesGroupBox.Controls.Add(Me.Label3)
        Me.MathValuesGroupBox.Controls.Add(Me.Label2)
        Me.MathValuesGroupBox.Controls.Add(Me.Label1)
        Me.MathValuesGroupBox.Controls.Add(Me.AnswerTextbox)
        Me.MathValuesGroupBox.Controls.Add(Me.SecondNumTextbox)
        Me.MathValuesGroupBox.Controls.Add(Me.FirstNumTextbox)
        Me.MathValuesGroupBox.Location = New System.Drawing.Point(24, 256)
        Me.MathValuesGroupBox.Margin = New System.Windows.Forms.Padding(4)
        Me.MathValuesGroupBox.Name = "MathValuesGroupBox"
        Me.MathValuesGroupBox.Padding = New System.Windows.Forms.Padding(4)
        Me.MathValuesGroupBox.Size = New System.Drawing.Size(302, 396)
        Me.MathValuesGroupBox.TabIndex = 2
        Me.MathValuesGroupBox.TabStop = False
        Me.MathValuesGroupBox.Text = "Current Math Problem"
        Me.ToolTip1.SetToolTip(Me.MathValuesGroupBox, "Perform the math operation selected for numbers 1 and 2, then submit to see if it" &
        " is correct")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 250)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Student Answer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 152)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "2nd Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 56)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "1st Number"
        '
        'AnswerTextbox
        '
        Me.AnswerTextbox.BackColor = System.Drawing.Color.MistyRose
        Me.AnswerTextbox.Location = New System.Drawing.Point(22, 279)
        Me.AnswerTextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.AnswerTextbox.Multiline = True
        Me.AnswerTextbox.Name = "AnswerTextbox"
        Me.AnswerTextbox.Size = New System.Drawing.Size(248, 31)
        Me.AnswerTextbox.TabIndex = 2
        '
        'SecondNumTextbox
        '
        Me.SecondNumTextbox.BackColor = System.Drawing.Color.MistyRose
        Me.SecondNumTextbox.Location = New System.Drawing.Point(22, 181)
        Me.SecondNumTextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.SecondNumTextbox.Multiline = True
        Me.SecondNumTextbox.Name = "SecondNumTextbox"
        Me.SecondNumTextbox.Size = New System.Drawing.Size(248, 31)
        Me.SecondNumTextbox.TabIndex = 1
        '
        'FirstNumTextbox
        '
        Me.FirstNumTextbox.BackColor = System.Drawing.Color.MistyRose
        Me.FirstNumTextbox.Location = New System.Drawing.Point(22, 85)
        Me.FirstNumTextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.FirstNumTextbox.Multiline = True
        Me.FirstNumTextbox.Name = "FirstNumTextbox"
        Me.FirstNumTextbox.Size = New System.Drawing.Size(248, 31)
        Me.FirstNumTextbox.TabIndex = 0
        '
        'MathSelectGroupBox
        '
        Me.MathSelectGroupBox.Controls.Add(Me.DivideRadioButton)
        Me.MathSelectGroupBox.Controls.Add(Me.MultiplyRadioButton)
        Me.MathSelectGroupBox.Controls.Add(Me.SubtractRadioButton)
        Me.MathSelectGroupBox.Controls.Add(Me.AddRadioButton)
        Me.MathSelectGroupBox.Location = New System.Drawing.Point(424, 256)
        Me.MathSelectGroupBox.Margin = New System.Windows.Forms.Padding(4)
        Me.MathSelectGroupBox.Name = "MathSelectGroupBox"
        Me.MathSelectGroupBox.Padding = New System.Windows.Forms.Padding(4)
        Me.MathSelectGroupBox.Size = New System.Drawing.Size(376, 396)
        Me.MathSelectGroupBox.TabIndex = 3
        Me.MathSelectGroupBox.TabStop = False
        Me.MathSelectGroupBox.Text = "Math Problem Type"
        Me.ToolTip1.SetToolTip(Me.MathSelectGroupBox, "Select a math function to perform")
        '
        'DivideRadioButton
        '
        Me.DivideRadioButton.AutoSize = True
        Me.DivideRadioButton.Location = New System.Drawing.Point(30, 279)
        Me.DivideRadioButton.Margin = New System.Windows.Forms.Padding(4)
        Me.DivideRadioButton.Name = "DivideRadioButton"
        Me.DivideRadioButton.Size = New System.Drawing.Size(103, 29)
        Me.DivideRadioButton.TabIndex = 3
        Me.DivideRadioButton.TabStop = True
        Me.DivideRadioButton.Text = "Divide"
        Me.DivideRadioButton.UseVisualStyleBackColor = True
        '
        'MultiplyRadioButton
        '
        Me.MultiplyRadioButton.AutoSize = True
        Me.MultiplyRadioButton.Location = New System.Drawing.Point(30, 202)
        Me.MultiplyRadioButton.Margin = New System.Windows.Forms.Padding(4)
        Me.MultiplyRadioButton.Name = "MultiplyRadioButton"
        Me.MultiplyRadioButton.Size = New System.Drawing.Size(117, 29)
        Me.MultiplyRadioButton.TabIndex = 2
        Me.MultiplyRadioButton.TabStop = True
        Me.MultiplyRadioButton.Text = "Multiply"
        Me.MultiplyRadioButton.UseVisualStyleBackColor = True
        '
        'SubtractRadioButton
        '
        Me.SubtractRadioButton.AutoSize = True
        Me.SubtractRadioButton.Location = New System.Drawing.Point(30, 127)
        Me.SubtractRadioButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SubtractRadioButton.Name = "SubtractRadioButton"
        Me.SubtractRadioButton.Size = New System.Drawing.Size(123, 29)
        Me.SubtractRadioButton.TabIndex = 1
        Me.SubtractRadioButton.TabStop = True
        Me.SubtractRadioButton.Text = "Subtract"
        Me.SubtractRadioButton.UseVisualStyleBackColor = True
        '
        'AddRadioButton
        '
        Me.AddRadioButton.AutoSize = True
        Me.AddRadioButton.Location = New System.Drawing.Point(30, 52)
        Me.AddRadioButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AddRadioButton.Name = "AddRadioButton"
        Me.AddRadioButton.Size = New System.Drawing.Size(81, 29)
        Me.AddRadioButton.TabIndex = 0
        Me.AddRadioButton.TabStop = True
        Me.AddRadioButton.Text = "Add"
        Me.AddRadioButton.UseVisualStyleBackColor = True
        '
        'StudentInfoGroupBox
        '
        Me.StudentInfoGroupBox.Controls.Add(Me.Label6)
        Me.StudentInfoGroupBox.Controls.Add(Me.Label5)
        Me.StudentInfoGroupBox.Controls.Add(Me.Label4)
        Me.StudentInfoGroupBox.Controls.Add(Me.NameBox)
        Me.StudentInfoGroupBox.Controls.Add(Me.AgeBox)
        Me.StudentInfoGroupBox.Controls.Add(Me.GradeBox)
        Me.StudentInfoGroupBox.Location = New System.Drawing.Point(24, 29)
        Me.StudentInfoGroupBox.Name = "StudentInfoGroupBox"
        Me.StudentInfoGroupBox.Size = New System.Drawing.Size(776, 198)
        Me.StudentInfoGroupBox.TabIndex = 4
        Me.StudentInfoGroupBox.TabStop = False
        Me.StudentInfoGroupBox.Text = "Student Information"
        Me.ToolTip1.SetToolTip(Me.StudentInfoGroupBox, "Name, age, and grade go here")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(516, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 25)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Grade"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(383, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Age"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Name"
        '
        'NameBox
        '
        Me.NameBox.BackColor = System.Drawing.Color.MistyRose
        Me.NameBox.Location = New System.Drawing.Point(21, 93)
        Me.NameBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NameBox.Multiline = True
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(290, 31)
        Me.NameBox.TabIndex = 5
        '
        'AgeBox
        '
        Me.AgeBox.BackColor = System.Drawing.Color.MistyRose
        Me.AgeBox.Location = New System.Drawing.Point(388, 93)
        Me.AgeBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AgeBox.Multiline = True
        Me.AgeBox.Name = "AgeBox"
        Me.AgeBox.Size = New System.Drawing.Size(90, 31)
        Me.AgeBox.TabIndex = 5
        '
        'GradeBox
        '
        Me.GradeBox.BackColor = System.Drawing.Color.MistyRose
        Me.GradeBox.Location = New System.Drawing.Point(521, 93)
        Me.GradeBox.Margin = New System.Windows.Forms.Padding(4)
        Me.GradeBox.Multiline = True
        Me.GradeBox.Name = "GradeBox"
        Me.GradeBox.Size = New System.Drawing.Size(88, 31)
        Me.GradeBox.TabIndex = 6
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(32, 151)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(262, 100)
        Me.ClearButton.TabIndex = 5
        Me.ClearButton.Text = "&Clear"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Click to reset the form")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'MathContest
        '
        Me.AcceptButton = Me.SubmitButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(1204, 704)
        Me.Controls.Add(Me.StudentInfoGroupBox)
        Me.Controls.Add(Me.MathSelectGroupBox)
        Me.Controls.Add(Me.MathValuesGroupBox)
        Me.Controls.Add(Me.ButtonsGroupBox)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MathContest"
        Me.Text = "Math Contest"
        Me.ButtonsGroupBox.ResumeLayout(False)
        Me.MathValuesGroupBox.ResumeLayout(False)
        Me.MathValuesGroupBox.PerformLayout()
        Me.MathSelectGroupBox.ResumeLayout(False)
        Me.MathSelectGroupBox.PerformLayout()
        Me.StudentInfoGroupBox.ResumeLayout(False)
        Me.StudentInfoGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonsGroupBox As GroupBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents SummaryButton As Button
    Friend WithEvents SubmitButton As Button
    'Friend WithEvents StudentInfoGroupBox As GroupBox
    Friend WithEvents MathValuesGroupBox As GroupBox
    Friend WithEvents MathSelectGroupBox As GroupBox
    Friend WithEvents DivideRadioButton As RadioButton
    Friend WithEvents MultiplyRadioButton As RadioButton
    Friend WithEvents SubtractRadioButton As RadioButton
    Friend WithEvents AddRadioButton As RadioButton
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents FirstNumTextbox As TextBox
    Friend WithEvents AnswerTextbox As TextBox
    Friend WithEvents SecondNumTextbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GradeTextbox As TextBox
    Friend WithEvents AgeTextbox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Grade_Label As Label
    Friend WithEvents Age_Label As Label
    Friend WithEvents Name_Label As Label
    Friend WithEvents StudentInfoGroupBox As GroupBox
    Friend WithEvents NameBox As TextBox
    Friend WithEvents AgeBox As TextBox
    Friend WithEvents GradeBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ClearButton As Button
End Class
