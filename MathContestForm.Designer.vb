<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Math_Contest
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.Summary_Button = New System.Windows.Forms.Button()
        Me.Clear_Button = New System.Windows.Forms.Button()
        Me.Submit_Button = New System.Windows.Forms.Button()
        Me.StudentInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.Grade_Label = New System.Windows.Forms.Label()
        Me.Age_Label = New System.Windows.Forms.Label()
        Me.Name_Label = New System.Windows.Forms.Label()
        Me.GradeTextbox = New System.Windows.Forms.TextBox()
        Me.AgeTextbox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.MathValues = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AnswerTextbox = New System.Windows.Forms.TextBox()
        Me.SecondNumTextbox = New System.Windows.Forms.TextBox()
        Me.FirstNumTextbox = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Divide = New System.Windows.Forms.RadioButton()
        Me.Multiply = New System.Windows.Forms.RadioButton()
        Me.Subtract = New System.Windows.Forms.RadioButton()
        Me.Add = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.StudentInfoGroupBox.SuspendLayout()
        Me.MathValues.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Exit_Button)
        Me.GroupBox1.Controls.Add(Me.Summary_Button)
        Me.GroupBox1.Controls.Add(Me.Clear_Button)
        Me.GroupBox1.Controls.Add(Me.Submit_Button)
        Me.GroupBox1.Location = New System.Drawing.Point(420, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(157, 249)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Exit_Button
        '
        Me.Exit_Button.BackColor = System.Drawing.Color.Red
        Me.Exit_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_Button.Location = New System.Drawing.Point(16, 192)
        Me.Exit_Button.Margin = New System.Windows.Forms.Padding(2)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(131, 54)
        Me.Exit_Button.TabIndex = 3
        Me.Exit_Button.Text = "Exit"
        Me.Exit_Button.UseVisualStyleBackColor = False
        '
        'Summary_Button
        '
        Me.Summary_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Summary_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Summary_Button.Location = New System.Drawing.Point(16, 135)
        Me.Summary_Button.Margin = New System.Windows.Forms.Padding(2)
        Me.Summary_Button.Name = "Summary_Button"
        Me.Summary_Button.Size = New System.Drawing.Size(131, 54)
        Me.Summary_Button.TabIndex = 2
        Me.Summary_Button.Text = "Summary"
        Me.Summary_Button.UseVisualStyleBackColor = False
        '
        'Clear_Button
        '
        Me.Clear_Button.BackColor = System.Drawing.Color.White
        Me.Clear_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Clear_Button.Location = New System.Drawing.Point(16, 77)
        Me.Clear_Button.Margin = New System.Windows.Forms.Padding(2)
        Me.Clear_Button.Name = "Clear_Button"
        Me.Clear_Button.Size = New System.Drawing.Size(131, 54)
        Me.Clear_Button.TabIndex = 1
        Me.Clear_Button.Text = "Clear"
        Me.Clear_Button.UseVisualStyleBackColor = False
        Me.Clear_Button.UseWaitCursor = True
        '
        'Submit_Button
        '
        Me.Submit_Button.BackColor = System.Drawing.Color.Lime
        Me.Submit_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Submit_Button.Location = New System.Drawing.Point(16, 16)
        Me.Submit_Button.Margin = New System.Windows.Forms.Padding(2)
        Me.Submit_Button.Name = "Submit_Button"
        Me.Submit_Button.Size = New System.Drawing.Size(131, 59)
        Me.Submit_Button.TabIndex = 0
        Me.Submit_Button.Text = "Submit"
        Me.Submit_Button.UseVisualStyleBackColor = False
        '
        'StudentInfoGroupBox
        '
        Me.StudentInfoGroupBox.Controls.Add(Me.Grade_Label)
        Me.StudentInfoGroupBox.Controls.Add(Me.Age_Label)
        Me.StudentInfoGroupBox.Controls.Add(Me.Name_Label)
        Me.StudentInfoGroupBox.Controls.Add(Me.GradeTextbox)
        Me.StudentInfoGroupBox.Controls.Add(Me.AgeTextbox)
        Me.StudentInfoGroupBox.Controls.Add(Me.NameTextBox)
        Me.StudentInfoGroupBox.Location = New System.Drawing.Point(12, 15)
        Me.StudentInfoGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.StudentInfoGroupBox.Name = "StudentInfoGroupBox"
        Me.StudentInfoGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.StudentInfoGroupBox.Size = New System.Drawing.Size(388, 93)
        Me.StudentInfoGroupBox.TabIndex = 1
        Me.StudentInfoGroupBox.TabStop = False
        Me.StudentInfoGroupBox.Text = "Student Information"
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
        'MathValues
        '
        Me.MathValues.Controls.Add(Me.Label3)
        Me.MathValues.Controls.Add(Me.Label2)
        Me.MathValues.Controls.Add(Me.Label1)
        Me.MathValues.Controls.Add(Me.AnswerTextbox)
        Me.MathValues.Controls.Add(Me.SecondNumTextbox)
        Me.MathValues.Controls.Add(Me.FirstNumTextbox)
        Me.MathValues.Location = New System.Drawing.Point(12, 133)
        Me.MathValues.Margin = New System.Windows.Forms.Padding(2)
        Me.MathValues.Name = "MathValues"
        Me.MathValues.Padding = New System.Windows.Forms.Padding(2)
        Me.MathValues.Size = New System.Drawing.Size(151, 206)
        Me.MathValues.TabIndex = 2
        Me.MathValues.TabStop = False
        Me.MathValues.Text = "Current Math Problem"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 130)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Student Answer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 79)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "2nd Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "1st Number"
        '
        'AnswerTextbox
        '
        Me.AnswerTextbox.BackColor = System.Drawing.Color.MistyRose
        Me.AnswerTextbox.Location = New System.Drawing.Point(11, 145)
        Me.AnswerTextbox.Margin = New System.Windows.Forms.Padding(2)
        Me.AnswerTextbox.Multiline = True
        Me.AnswerTextbox.Name = "AnswerTextbox"
        Me.AnswerTextbox.Size = New System.Drawing.Size(126, 18)
        Me.AnswerTextbox.TabIndex = 2
        '
        'SecondNumTextbox
        '
        Me.SecondNumTextbox.BackColor = System.Drawing.Color.MistyRose
        Me.SecondNumTextbox.Location = New System.Drawing.Point(11, 94)
        Me.SecondNumTextbox.Margin = New System.Windows.Forms.Padding(2)
        Me.SecondNumTextbox.Multiline = True
        Me.SecondNumTextbox.Name = "SecondNumTextbox"
        Me.SecondNumTextbox.Size = New System.Drawing.Size(126, 18)
        Me.SecondNumTextbox.TabIndex = 1
        '
        'FirstNumTextbox
        '
        Me.FirstNumTextbox.BackColor = System.Drawing.Color.MistyRose
        Me.FirstNumTextbox.Location = New System.Drawing.Point(11, 44)
        Me.FirstNumTextbox.Margin = New System.Windows.Forms.Padding(2)
        Me.FirstNumTextbox.Multiline = True
        Me.FirstNumTextbox.Name = "FirstNumTextbox"
        Me.FirstNumTextbox.Size = New System.Drawing.Size(126, 18)
        Me.FirstNumTextbox.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Divide)
        Me.GroupBox4.Controls.Add(Me.Multiply)
        Me.GroupBox4.Controls.Add(Me.Subtract)
        Me.GroupBox4.Controls.Add(Me.Add)
        Me.GroupBox4.Location = New System.Drawing.Point(212, 133)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(188, 206)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Math Problem Type"
        '
        'Divide
        '
        Me.Divide.AutoSize = True
        Me.Divide.Location = New System.Drawing.Point(15, 145)
        Me.Divide.Margin = New System.Windows.Forms.Padding(2)
        Me.Divide.Name = "Divide"
        Me.Divide.Size = New System.Drawing.Size(55, 17)
        Me.Divide.TabIndex = 3
        Me.Divide.TabStop = True
        Me.Divide.Text = "Divide"
        Me.Divide.UseVisualStyleBackColor = True
        '
        'Multiply
        '
        Me.Multiply.AutoSize = True
        Me.Multiply.Location = New System.Drawing.Point(15, 105)
        Me.Multiply.Margin = New System.Windows.Forms.Padding(2)
        Me.Multiply.Name = "Multiply"
        Me.Multiply.Size = New System.Drawing.Size(60, 17)
        Me.Multiply.TabIndex = 2
        Me.Multiply.TabStop = True
        Me.Multiply.Text = "Multiply"
        Me.Multiply.UseVisualStyleBackColor = True
        '
        'Subtract
        '
        Me.Subtract.AutoSize = True
        Me.Subtract.Location = New System.Drawing.Point(15, 66)
        Me.Subtract.Margin = New System.Windows.Forms.Padding(2)
        Me.Subtract.Name = "Subtract"
        Me.Subtract.Size = New System.Drawing.Size(65, 17)
        Me.Subtract.TabIndex = 1
        Me.Subtract.TabStop = True
        Me.Subtract.Text = "Subtract"
        Me.Subtract.UseVisualStyleBackColor = True
        '
        'Add
        '
        Me.Add.AutoSize = True
        Me.Add.Location = New System.Drawing.Point(15, 27)
        Me.Add.Margin = New System.Windows.Forms.Padding(2)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(44, 17)
        Me.Add.TabIndex = 0
        Me.Add.TabStop = True
        Me.Add.Text = "Add"
        Me.Add.UseVisualStyleBackColor = True
        '
        'Math_Contest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(602, 366)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.MathValues)
        Me.Controls.Add(Me.StudentInfoGroupBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Math_Contest"
        Me.Text = "Math Contest"
        Me.GroupBox1.ResumeLayout(False)
        Me.StudentInfoGroupBox.ResumeLayout(False)
        Me.StudentInfoGroupBox.PerformLayout()
        Me.MathValues.ResumeLayout(False)
        Me.MathValues.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Exit_Button As Button
    Friend WithEvents Summary_Button As Button
    Friend WithEvents Clear_Button As Button
    Friend WithEvents Submit_Button As Button
    Friend WithEvents StudentInfoGroupBox As GroupBox
    Friend WithEvents MathValues As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Divide As RadioButton
    Friend WithEvents Multiply As RadioButton
    Friend WithEvents Subtract As RadioButton
    Friend WithEvents Add As RadioButton
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
End Class
