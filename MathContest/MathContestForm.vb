'Xavier Hoskins
'RCET 0265
'Fall 2022
'Math Contest
'https://www.github.com/hoskxavi/MathContest

Imports System.Reflection.Metadata.Ecma335
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class MathContestForm
    'Global variables for the score and number of questions; can be manipulated by anything in the class
    Dim score As Integer
    Dim numberOfQuestions As Integer


    'Load form with add button selected and random numbers generated
    Private Sub MathContestForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddRadioButton.Checked = True
        NumberChange()
    End Sub

    'End program with the exit button
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        MsgBox("Have a nice day!")
        Me.Close()
    End Sub

    Private Sub AcceptButton_Click(sender As Object, e As EventArgs) Handles AcceptButton.Click
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim result As Integer
        Dim correctAnswer As Integer
        Dim studentName As String
        Dim grade As Integer
        Dim age As Integer

        firstNumber = FirstNumberTextBox.Text
        secondNumber = SecondNumberTextBox.Text
        studentName = NameTextBox.Text



        'Case select to confirm the correct value of the selected math operation
        Select Case True
            Case AddRadioButton.Checked
                correctAnswer = firstNumber + secondNumber
            Case SubtractRadioButton.Checked
                correctAnswer = firstNumber - secondNumber
            Case MultiplyRadioButton.Checked
                correctAnswer = firstNumber * secondNumber
            Case DivideRadioButton.Checked
                correctAnswer = firstNumber / secondNumber
        End Select

        'If and try statements to confirm all fields are filled in correctly
        If studentName = "" Then
            ErrorHandler(4)
            Exit Sub
        Else
            NameTextBox.BackColor = Color.White

            Try
                grade = CInt(GradeTextBox.Text)
                GradeTextBox.BackColor = Color.White
            Catch ex As Exception
                ErrorHandler(1)
                Exit Sub
            End Try

            Try
                age = CInt(AgeTextBox.Text)
                GradeTextBox.BackColor = Color.White
            Catch ex As Exception
                ErrorHandler(2)
                Exit Sub
            End Try


            'Check eligibility of the student and compare the given answer to the correct one
            If EligibilityCheck(age, grade) = True Then


                Try
                    result = CInt(ResultTextBox.Text)
                    ResultTextBox.BackColor = Color.White
                Catch ex As Exception
                    ErrorHandler(3)
                    Exit Sub
                End Try

                If result = correctAnswer Then
                    MsgBox("That is correct!")

                    score += 1
                Else
                    MsgBox("I'm sorry, but that is not the correct answer." + vbCrLf + "The correct answer is " + CStr(correctAnswer))
                End If

                numberOfQuestions += 1
                NumberChange()

            Else
                ErrorHandler(5)
                Exit Sub
            End If

        End If




    End Sub


    'Clear all text boxes and generate new random numbers; sets add button as default
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        AddRadioButton.Checked = True
        score = 0
        numberOfQuestions = 0
        FirstNumberTextBox.Text = ""
        SecondNumberTextBox.Text = ""
        ResultTextBox.Text = ""
        NameTextBox.Text = ""
        GradeTextBox.Text = ""
        AgeTextBox.Text = ""
        NumberChange()
    End Sub

    'Compare the students age and grade to verify if they are elibible to compete, returns TRUE or FALSE
    Function EligibilityCheck(studentAge As String, studentGrade As String) As Boolean
        If studentAge < 12 And studentAge > 6 And studentGrade < 5 And studentGrade > 0 Then
            Return True
        Else
            Return False
        End If
    End Function


    'Generate two random numbers from 1 to 9 and populate to appropriate text boxes
    Sub NumberChange()
        Dim _first As Integer
        Dim _second As Integer

        Randomize()

        _first = CInt(Int((9 * Rnd() + 1)))
        _second = CInt(Int((9 * Rnd() + 1)))
        FirstNumberTextBox.Text = _first
        SecondNumberTextBox.Text = _second
    End Sub


    'If an error occurs, the passed in errorLocation variable diplays the appropriate response
    Sub ErrorHandler(errorLocation As Integer)
        Select Case errorLocation
            Case 1
                MsgBox("Error! All boxes must be filled in to continue.")
                GradeTextBox.ResetText()
                GradeTextBox.BackColor = Color.Red
            Case 2
                MsgBox("Error! All boxes must be filled in to continue.")
                AgeTextBox.ResetText()
                AgeTextBox.BackColor = Color.Red
            Case 3
                MsgBox("Error! All boxes must be filled in to continue.")
                ResultTextBox.ResetText()
                ResultTextBox.BackColor = Color.Red
            Case 4
                MsgBox("Error! All boxes must be filled in to continue.")
                NameTextBox.ResetText()
                NameTextBox.BackColor = Color.Red
            Case 5
                MsgBox("Student not eligible to compete.")
        End Select
    End Sub

    'Summary provides a comparison of correct responses to total questions before information is cleared
    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        MsgBox("Number of correct responses: " + CStr(score) + " out of " + CStr(numberOfQuestions))
    End Sub


    'The next four subs generate new random numbers if the math operation selection changes
    Private Sub SubtractRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles SubtractRadioButton.CheckedChanged
        NumberChange()
    End Sub

    Private Sub MultiplyRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MultiplyRadioButton.CheckedChanged
        NumberChange()
    End Sub

    Private Sub DivideRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles DivideRadioButton.CheckedChanged
        NumberChange()
    End Sub

    Private Sub AddRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AddRadioButton.CheckedChanged
        NumberChange()
    End Sub

End Class
