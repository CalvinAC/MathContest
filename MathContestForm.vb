'Calvin Coxen
'RCET 0265
'Fall 2020
'Math Contest
'https://github.com/CalvinAC/MathContest

Option Strict On
Option Explicit On


Public Class Math_Contest
    Dim attempts As Integer
    Dim correctAttempts As Double

    Private Sub Math_Contest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Loads preset conditions
        Add.Checked = True
        Submit_Button.Enabled = False
        Summary_Button.Enabled = False
        Add.Enabled = False
        Subtract.Enabled = False
        Multiply.Enabled = False
        Divide.Enabled = False

    End Sub

    ' Randomizes numbers for the math equation
    Function RandomizeQuestions() As Action
        Randomize()
        FirstNumTextbox.Text = CStr(Int((25 - 0 + 1) * Rnd() + 0))
        SecondNumTextbox.Text = CStr(Int((25 - 0 + 1) * Rnd() + 0))

    End Function

    Function AgeGradeGood() As Boolean
        Dim goodGrade As Boolean
        Dim goodAge As Boolean
        Dim ageCheck As Integer
        Dim gradeCheck As Integer

        Try
            ageCheck = CInt(AgeBox.Text)

            ' Verifies that contestant is of the proper age group
            Select Case ageCheck
                Case <= 6
                    goodGrade = False
                Case >= 12
                    goodGrade = False
                Case Else
                    goodGrade = True
            End Select

            gradeCheck = CInt(GradeBox.Text)

            ' Verifies that contestant is of the proper grade group
            Select Case gradeCheck
                Case <= 0
                    goodGrade = False
                Case >= 5
                    goodGrade = False
                Case Else
                    goodAge = True
            End Select

        Catch ex As Exception

        End Try

        Return goodAge And goodGrade
    End Function
    Private Sub StudentInfo_Leave(sender As Object, e As EventArgs) Handles StudentInfo.Leave

        'Compares name, grade, and age entry to allow the user to continue
        If NameBox.Text <> "" And AgeGradeGood() Then
            Add.Enabled = True
            Subtract.Enabled = True
            Multiply.Enabled = True
            Divide.Enabled = True
            Submit_Button.Enabled = True
            Summary_Button.Enabled = True
            RandomizeQuestions()
        Else
            MsgBox("Student not eligible to compete")
        End If

    End Sub

    Private Sub Submit_Button_Click(sender As Object, e As EventArgs) Handles Submit_Button.Click
        MathOperations()
    End Sub
    Sub MathOperations()
        Dim firstNum As Integer
        Dim secondNum As Integer
        Dim correctAnswer As Double
        Dim studentAnswer As Integer

        Try
            firstNum = CInt(FirstNumTextbox.Text)
            secondNum = CInt(SecondNumTextbox.Text)
            studentAnswer = CInt(AnswerTextbox.Text)

            'Performs the math function based on which operator is checked
            If Add.Checked = True Then
                correctAnswer = firstNum + secondNum
            ElseIf Subtract.Checked = True Then
                correctAnswer = firstNum - secondNum
            ElseIf Multiply.Checked = True Then
                correctAnswer = firstNum * secondNum
            ElseIf Divide.Checked = True Then
                correctAnswer = firstNum / secondNum
            End If
        Catch ex As Exception

        End Try

        'Verfies user answered, and keeps a tally of correct answers to attempts
        If AnswerTextbox.Text = "" Then
            MsgBox("Please fill out your answer")
        ElseIf correctAnswer = studentAnswer Then
            correctAttempts = correctAttempts + 1
            MsgBox("Congrats! That is the correct answer")
            AnswerTextbox.Clear()
        Else MsgBox("Incorrect. The right answer is: " & CStr(correctAnswer))
            AnswerTextbox.Clear()
        End If

        attempts = attempts + 1

    End Sub
    Private Sub Clear_Button_Click(sender As Object, e As EventArgs) Handles Clear_Button.Click

        'Resets all data entered
        NameBox.Clear()
        AgeBox.Clear()
        GradeBox.Clear()
        FirstNumTextbox.Clear()
        SecondNumTextbox.Clear()
        AnswerTextbox.Clear()
        Submit_Button.Enabled = False
        Summary_Button.Enabled = False
        attempts = 0
        correctAttempts = 0

        Add.Enabled = True
        Subtract.Enabled = False
        Multiply.Enabled = False
        Divide.Enabled = False

    End Sub

    Private Sub Summary_Button_Click(sender As Object, e As EventArgs) Handles Summary_Button.Click

        'Displays a message box with the values below for the user
        MsgBox("Name: " & NameBox.Text & vbNewLine &
               "Age: " & AgeBox.Text & vbNewLine &
               "Grade: " & GradeBox.Text & vbNewLine &
               "1st Number: " & FirstNumTextbox.Text & vbNewLine &
               "2nd Number: " & SecondNumTextbox.Text & vbNewLine &
               NameBox.Text & " got " & correctAttempts & " out of " & attempts & " correct")


    End Sub

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub


End Class
