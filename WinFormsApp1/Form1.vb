Imports WinFormsApp1.Modules

Public Class Form1
    Private Sub QuestionButton_Click(sender As Object, e As EventArgs) Handles QuestionButton.Click
        Question(Me, "Head", AddressOf YesAction, AddressOf NoAction)
    End Sub
    Public Sub YesAction()
        Text = "Yes"
    End Sub
    Public Sub NoAction()
        Text = "No"
    End Sub

    Private Sub StandardQuestionButton_Click(sender As Object, e As EventArgs) Handles StandardQuestionButton.Click

        If Question(Me, "Question", "Favorite drink", "Coffee", "Tea", DialogResult.No) Then
            Text = "Coffee for me"
        Else
            Text = "I love Tea"
        End If

    End Sub
End Class
