'Calvin Coxen
'RCET 0265
'Fall 2020
'Math Contest
'https://github.com/CalvinAC/MathContest



Public Class Math_Contest
    Dim firstNum As Integer
    Dim secondNum As Integer
    Dim answer As Integer
    Dim attempts As Integer
    Dim correctAttempts As Integer


    Private Sub Math_Contest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Add.Checked = True

    End Sub


    Private Sub Submit_Button_Click(sender As Object, e As EventArgs) Handles Submit_Button.Click
        Dim correctAnswer As Integer
        Dim studentAnswer As Integer

        Try
            studentAnswer = CInt(AnswerTextbox.Text)
        Catch ex As Exception
            AnswerTextbox.ResetText()
            MsgBox("Enter a number value")
            Exit Sub
        End Try
        Summary_Button.Enabled = True

        attempts = +1

        If NameTextBox.Text = Nothing Then
            MsgBox("Please fill out your name")
        ElseIf AgeTextbox.Text = Nothing Then
            MsgBox("Please enter your age")
        ElseIf GradeTextbox.Text = Nothing Then
            MsgBox("Please enter your grade")
        ElseIf FirstNumTextbox.Text = Nothing Then
            MsgBox("Please enter the first value")
        ElseIf SecondNumTextbox.Text = Nothing Then
            MsgBox("Please enter the second value")
        ElseIf AnswerTextbox.Text = answer Then
            MsgBox("correct")
        End If

        If Add.Checked = True Then
            answer = CInt(firstNum) + CInt(secondNum)
        ElseIf Subtract.Checked = True Then
            answer = CInt(firstNum) - CInt(secondNum)
        ElseIf Multiply.Checked = True Then
            answer = CInt(firstNum) * CInt(secondNum)
        ElseIf Divide.Checked = True Then
            answer = CInt(firstNum) / CInt(secondNum)

        End If

        If correctAnswer = studentAnswer Then
            correctAttempts = +1

            MsgBox("Congrats that is the correct answer")
            AnswerTextbox.ResetText()
        Else msgBox("Incorrect. The right answer is" & CStr(correctAnswer))
            AnswerTextbox.ResetText()
        End If


    End Sub

    Private Sub Clear_Button_Click(sender As Object, e As EventArgs) Handles Clear_Button.Click

        NameTextBox.Text = ""
        AgeTextbox.Text = ""
        GradeTextbox.Text = ""
        FirstNumTextbox.Text = ""
        SecondNumTextbox.Text = ""

    End Sub

    Private Sub Summary_Button_Click(sender As Object, e As EventArgs) Handles Summary_Button.Click

        MsgBox("Name: " & NameTextBox.Text & vbNewLine &
               "Age: " & AgeTextbox.Text & vbNewLine &
               "Grade: " & GradeTextbox.Text & vbNewLine &
               "1st Number: " & FirstNumTextbox.Text & vbNewLine &
               "2nd Number: " & SecondNumTextbox.Text & vbNewLine &
               "Answer: " & AnswerTextbox.Text & vbNewLine &
               NameTextBox.Text & " got " & correctAttempts & " out of " & attempts & " correct")


    End Sub



    Private Sub FirstNumTextbox_TextChanged(sender As Object, e As EventArgs) Handles FirstNumTextbox.TextChanged

    End Sub

    Private Sub SecondNumTextbox_TextChanged(sender As Object, e As EventArgs) Handles SecondNumTextbox.TextChanged


    End Sub

    Private Sub GradeTextbox_TextChanged(sender As Object, e As EventArgs) Handles GradeTextbox.TextChanged
        If Me.GradeTextbox.Text <> String.Empty Then
            Submit_Button.Enabled = True
        Else
            Submit_Button.Enabled = False
        End If
    End Sub
    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub

    Private Sub MathValues_Enter(sender As Object, e As EventArgs) Handles FirstNumTextbox.TextChanged,
        SecondNumTextbox.TextChanged, AnswerTextbox.TextChanged
        Dim userMessage As String = ""
        Dim answer As Boolean
        answer = False

        If AnswerTextbox.Text <> "" Then
            Try
                answer = True
            Catch ex As Exception
                MsgBox("Please Enter")
            End Try
        End If
        If userMessage <> "" Then
            MsgBox(userMessage)
        End If
    End Sub
End Class
