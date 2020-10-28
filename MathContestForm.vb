'Calvin Coxen
'RCET 0265
'Fall 2020
'Math Contest
'https://github.com/CalvinAC/MathContest

Option Strict On
Option Explicit On


Public Class Math_Contest
    Dim attempts As Integer
    Dim correctAttempts As Integer

    Private Sub Math_Contest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Add.Checked = True
        ChecktextBoxes()

        Add.Enabled = False
        Subtract.Enabled = False
        Multiply.Enabled = False
        Divide.Enabled = False

    End Sub

    Public Sub ChecktextBoxes() Handles AgeTextbox.Click, GradeTextbox.Click

        If NameTextBox.Text <> "" And AgeTextbox.Text <> "" And AnswerTextbox.Text <> "" And GradeTextbox.Text <> "" Then
            Submit_Button.Enabled = True
            Summary_Button.Enabled = True
        Else
            Submit_Button.Enabled = False
            Summary_Button.Enabled = False
        End If
    End Sub

    Function RandomizeQuestions() As Action
        Randomize()
        FirstNumTextbox.Text = CStr(Int((100 - 0 + 1) * Rnd() + 0))
        SecondNumTextbox.Text = CStr(Int((100 - 0 + 1) * Rnd() + 0))

    End Function

    Private Sub StudentInfoGroupBox_Leave() Handles StudentInfoGroupBox.Leave
        Dim ageCheck As Integer

        ageCheck = CShort(CInt(AgeTextbox.Text))

        Select Case ageCheck
            Case 1 To 6
                MsgBox("Student not eligible to compete")
                Add.Enabled = False
                Subtract.Enabled = False
                Multiply.Enabled = False
                Divide.Enabled = False
            Case 7 To 11
                Add.Enabled = True
                Subtract.Enabled = True
                Multiply.Enabled = True
                Divide.Enabled = True
            Case >= 12
                MsgBox("If you're reading this you're too old")
                Add.Enabled = False
                Subtract.Enabled = False
                Multiply.Enabled = False
                Divide.Enabled = False
        End Select


    End Sub

    Private Sub Submit_Button_Click(sender As Object, e As EventArgs) Handles Submit_Button.Click
        Dim correctAnswer As Integer
        Dim studentAnswer As Integer


        attempts = +1


        If correctAnswer = studentAnswer Then
            correctAttempts = +1

            MsgBox("Congrats that is the correct answer")
            AnswerTextbox.ResetText()
        Else MsgBox("Incorrect. The right answer is" & CStr(correctAnswer))
            AnswerTextbox.ResetText()
        End If


    End Sub

    Private Sub Clear_Button_Click(sender As Object, e As EventArgs) Handles Clear_Button.Click

        NameTextBox.Clear()
        AgeTextbox.Clear()
        GradeTextbox.Clear()
        FirstNumTextbox.Clear()
        SecondNumTextbox.Clear()
        AnswerTextbox.Clear()
        ChecktextBoxes()
        StudentInfoGroupBox_Leave()
        attempts = 0
        correctAttempts = 0



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
    Private Sub GradeTextbox_TextChanged(sender As Object, e As EventArgs) Handles GradeTextbox.TextChanged
        If Me.GradeTextbox.Text <> String.Empty Then
            Submit_Button.Enabled = True
        Else
            Submit_Button.Enabled = False
        End If
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

    Private Sub MathValues_Enter_1(sender As Object, e As EventArgs) Handles MathValues.Enter
        RandomizeQuestions()
    End Sub
    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub


End Class
