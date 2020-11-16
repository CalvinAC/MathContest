'Calvin Coxen
'RCET 0265
'Fall 2020
'Math Contest
'https://github.com/CalvinAC/MathContest

Option Strict On
Option Explicit On


Public Class MathContest
    Dim attempts As Integer
    Dim correctAttempts As Double

    Private Sub Math_Contest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Loads preset conditions
        AddRadioButton.Checked = True
        SubmitButton.Enabled = False
        SummaryButton.Enabled = False
        AddRadioButton.Enabled = False
        SubtractRadioButton.Enabled = False
        MultiplyRadioButton.Enabled = False
        DivideRadioButton.Enabled = False

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
            If NameBox.Text = "" Then
                MsgBox("Name is empty")
                Exit Function
            ElseIf AgeBox.Text = "" Then
                MsgBox("Age is empty")
                Exit Function
            ElseIf GradeBox.Text = "" Then
                MsgBox("Grade is empty")
                Exit Function
            Else

            End If

            ' Verifies that contestant is of the proper age group
            ageCheck = CInt(AgeBox.Text)
            Select Case ageCheck
                Case <= 6
                    goodGrade = False
                Case >= 12
                    goodGrade = False
                Case Else
                    goodGrade = True
            End Select

            ' Verifies that contestant is of the proper grade group
            gradeCheck = CInt(GradeBox.Text)
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
    Private Sub StudentInfo_Leave(sender As Object, e As EventArgs) Handles StudentInfoGroupBox.Leave

        'Compares name, grade, and age entry to allow the user to continue
        If NameBox.Text <> "" And AgeGradeGood() Then
            AddRadioButton.Enabled = True
            SubtractRadioButton.Enabled = True
            MultiplyRadioButton.Enabled = True
            DivideRadioButton.Enabled = True
            SubmitButton.Enabled = True
            SummaryButton.Enabled = True
            RandomizeQuestions()
        Else
            MsgBox("Student not eligible to compete")
        End If

    End Sub

    Private Sub Submit_Button_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
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
            If AddRadioButton.Checked = True Then
                correctAnswer = firstNum + secondNum
            ElseIf SubtractRadioButton.Checked = True Then
                correctAnswer = firstNum - secondNum
            ElseIf MultiplyRadioButton.Checked = True Then
                correctAnswer = firstNum * secondNum
            ElseIf DivideRadioButton.Checked = True Then
                correctAnswer = firstNum / secondNum
            End If

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

        Catch ex As Exception
            MsgBox("The answer must be a numeric value")
            AnswerTextbox.Clear()
        End Try

        attempts = attempts + 1

    End Sub
    Private Sub Clear_Button_Click(sender As Object, e As EventArgs)

        'Resets all data entered
        NameBox.Clear()
        AgeBox.Clear()
        GradeBox.Clear()
        FirstNumTextbox.Clear()
        SecondNumTextbox.Clear()
        AnswerTextbox.Clear()
        SubmitButton.Enabled = False
        SummaryButton.Enabled = False
        attempts = 0
        correctAttempts = 0

        AddRadioButton.Enabled = True
        SubtractRadioButton.Enabled = False
        MultiplyRadioButton.Enabled = False
        DivideRadioButton.Enabled = False

    End Sub

    Private Sub Summary_Button_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click

        'Displays a message box with the values below for the user
        MsgBox("Name: " & NameBox.Text & vbNewLine &
               "Age: " & AgeBox.Text & vbNewLine &
               "Grade: " & GradeBox.Text & vbNewLine &
               "1st Number: " & FirstNumTextbox.Text & vbNewLine &
               "2nd Number: " & SecondNumTextbox.Text & vbNewLine &
               NameBox.Text & " got " & correctAttempts & " out of " & attempts & " correct")


    End Sub

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub


End Class
