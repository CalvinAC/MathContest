<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Math_Contest
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.Summary_Button = New System.Windows.Forms.Button()
        Me.Clear_Button = New System.Windows.Forms.Button()
        Me.Submit_Button = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Divide = New System.Windows.Forms.RadioButton()
        Me.Multiply = New System.Windows.Forms.RadioButton()
        Me.Subtract = New System.Windows.Forms.RadioButton()
        Me.Add = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Name_Label = New System.Windows.Forms.Label()
        Me.Age_Label = New System.Windows.Forms.Label()
        Me.Grade_Label = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Exit_Button)
        Me.GroupBox1.Controls.Add(Me.Summary_Button)
        Me.GroupBox1.Controls.Add(Me.Clear_Button)
        Me.GroupBox1.Controls.Add(Me.Submit_Button)
        Me.GroupBox1.Location = New System.Drawing.Point(840, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(314, 479)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Exit_Button
        '
        Me.Exit_Button.BackColor = System.Drawing.Color.Red
        Me.Exit_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_Button.Location = New System.Drawing.Point(33, 369)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(262, 104)
        Me.Exit_Button.TabIndex = 3
        Me.Exit_Button.Text = "Exit"
        Me.Exit_Button.UseVisualStyleBackColor = False
        '
        'Summary_Button
        '
        Me.Summary_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Summary_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Summary_Button.Location = New System.Drawing.Point(33, 259)
        Me.Summary_Button.Name = "Summary_Button"
        Me.Summary_Button.Size = New System.Drawing.Size(262, 104)
        Me.Summary_Button.TabIndex = 2
        Me.Summary_Button.Text = "Summary"
        Me.Summary_Button.UseVisualStyleBackColor = False
        '
        'Clear_Button
        '
        Me.Clear_Button.BackColor = System.Drawing.Color.White
        Me.Clear_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Clear_Button.Location = New System.Drawing.Point(33, 149)
        Me.Clear_Button.Name = "Clear_Button"
        Me.Clear_Button.Size = New System.Drawing.Size(262, 104)
        Me.Clear_Button.TabIndex = 1
        Me.Clear_Button.Text = "Clear"
        Me.Clear_Button.UseVisualStyleBackColor = False
        Me.Clear_Button.UseWaitCursor = True
        '
        'Submit_Button
        '
        Me.Submit_Button.BackColor = System.Drawing.Color.Lime
        Me.Submit_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Submit_Button.Location = New System.Drawing.Point(33, 30)
        Me.Submit_Button.Name = "Submit_Button"
        Me.Submit_Button.Size = New System.Drawing.Size(262, 113)
        Me.Submit_Button.TabIndex = 0
        Me.Submit_Button.Text = "Submit"
        Me.Submit_Button.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Grade_Label)
        Me.GroupBox2.Controls.Add(Me.Age_Label)
        Me.GroupBox2.Controls.Add(Me.Name_Label)
        Me.GroupBox2.Controls.Add(Me.TextBox6)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(777, 179)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Student Information"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.MistyRose
        Me.TextBox1.Location = New System.Drawing.Point(17, 83)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(321, 31)
        Me.TextBox1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.TextBox4)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Location = New System.Drawing.Point(24, 255)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(302, 396)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Current Math Problem"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "2nd Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "1st Number"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.MistyRose
        Me.TextBox4.Location = New System.Drawing.Point(22, 278)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(249, 30)
        Me.TextBox4.TabIndex = 2
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.MistyRose
        Me.TextBox3.Location = New System.Drawing.Point(22, 181)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(249, 30)
        Me.TextBox3.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.MistyRose
        Me.TextBox2.Location = New System.Drawing.Point(22, 84)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(249, 30)
        Me.TextBox2.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Divide)
        Me.GroupBox4.Controls.Add(Me.Multiply)
        Me.GroupBox4.Controls.Add(Me.Subtract)
        Me.GroupBox4.Controls.Add(Me.Add)
        Me.GroupBox4.Location = New System.Drawing.Point(425, 255)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(376, 396)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Math Problem Type"
        '
        'Divide
        '
        Me.Divide.AutoSize = True
        Me.Divide.Location = New System.Drawing.Point(30, 278)
        Me.Divide.Name = "Divide"
        Me.Divide.Size = New System.Drawing.Size(103, 29)
        Me.Divide.TabIndex = 3
        Me.Divide.TabStop = True
        Me.Divide.Text = "Divide"
        Me.Divide.UseVisualStyleBackColor = True
        '
        'Multiply
        '
        Me.Multiply.AutoSize = True
        Me.Multiply.Location = New System.Drawing.Point(30, 202)
        Me.Multiply.Name = "Multiply"
        Me.Multiply.Size = New System.Drawing.Size(117, 29)
        Me.Multiply.TabIndex = 2
        Me.Multiply.TabStop = True
        Me.Multiply.Text = "Multiply"
        Me.Multiply.UseVisualStyleBackColor = True
        '
        'Subtract
        '
        Me.Subtract.AutoSize = True
        Me.Subtract.Location = New System.Drawing.Point(30, 126)
        Me.Subtract.Name = "Subtract"
        Me.Subtract.Size = New System.Drawing.Size(123, 29)
        Me.Subtract.TabIndex = 1
        Me.Subtract.TabStop = True
        Me.Subtract.Text = "Subtract"
        Me.Subtract.UseVisualStyleBackColor = True
        '
        'Add
        '
        Me.Add.AutoSize = True
        Me.Add.Location = New System.Drawing.Point(30, 51)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(81, 29)
        Me.Add.TabIndex = 0
        Me.Add.TabStop = True
        Me.Add.Text = "Add"
        Me.Add.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Student Answer"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.MistyRose
        Me.TextBox5.Location = New System.Drawing.Point(401, 82)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(58, 31)
        Me.TextBox5.TabIndex = 1
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.MistyRose
        Me.TextBox6.Location = New System.Drawing.Point(501, 82)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(51, 31)
        Me.TextBox6.TabIndex = 2
        '
        'Name_Label
        '
        Me.Name_Label.AutoSize = True
        Me.Name_Label.Location = New System.Drawing.Point(17, 55)
        Me.Name_Label.Name = "Name_Label"
        Me.Name_Label.Size = New System.Drawing.Size(68, 25)
        Me.Name_Label.TabIndex = 3
        Me.Name_Label.Text = "Name"
        '
        'Age_Label
        '
        Me.Age_Label.AutoSize = True
        Me.Age_Label.Location = New System.Drawing.Point(396, 54)
        Me.Age_Label.Name = "Age_Label"
        Me.Age_Label.Size = New System.Drawing.Size(50, 25)
        Me.Age_Label.TabIndex = 4
        Me.Age_Label.Text = "Age"
        '
        'Grade_Label
        '
        Me.Grade_Label.AutoSize = True
        Me.Grade_Label.Location = New System.Drawing.Point(496, 54)
        Me.Grade_Label.Name = "Grade_Label"
        Me.Grade_Label.Size = New System.Drawing.Size(71, 25)
        Me.Grade_Label.TabIndex = 5
        Me.Grade_Label.Text = "Grade"
        '
        'Math_Contest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1204, 703)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Math_Contest"
        Me.Text = "Math Contest"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Exit_Button As Button
    Friend WithEvents Summary_Button As Button
    Friend WithEvents Clear_Button As Button
    Friend WithEvents Submit_Button As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Divide As RadioButton
    Friend WithEvents Multiply As RadioButton
    Friend WithEvents Subtract As RadioButton
    Friend WithEvents Add As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Grade_Label As Label
    Friend WithEvents Age_Label As Label
    Friend WithEvents Name_Label As Label
End Class
