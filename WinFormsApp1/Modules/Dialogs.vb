Namespace Modules

    Public Module Dialogs
        Public Sub Question(owner As Control, heading As String, yesAction As Action, noAction As Action)

            Dim yesButton As New TaskDialogButton("Yes") With {.Tag = DialogResult.Yes}

            Dim noButton As New TaskDialogButton("No") With {.Tag = DialogResult.No}


            Dim buttons = New TaskDialogButtonCollection From {yesButton, noButton}

            Dim page As New TaskDialogPage() With {
                    .Caption = "Question",
                    .SizeToContent = True,
                    .Heading = heading,
                    .Buttons = buttons}

            Dim result As TaskDialogButton = TaskDialog.ShowDialog(owner, page)

            If CType(result.Tag, DialogResult) = DialogResult.Yes Then
                yesAction?.Invoke()
            Else
                noAction?.Invoke()
            End If
        End Sub
        Public Function Question(owner As Control, text As String, defaultButton As DialogResult)

            Dim yesButton As New TaskDialogButton("Yes") With {.Tag = DialogResult.Yes}
            Dim noButton As New TaskDialogButton("No") With {.Tag = DialogResult.No}


            Dim buttons = New TaskDialogButtonCollection From {yesButton, noButton}

            Dim page As New TaskDialogPage() With {
                    .Caption = "Question",
                    .SizeToContent = True,
                    .Heading = text,
                    .Buttons = buttons}

            Dim result As TaskDialogButton = TaskDialog.ShowDialog(owner, page)
            Return CType(result.Tag, DialogResult) = DialogResult.Yes
        End Function
        Public Function Question(owner As Control, caption As String, heading As String, yesText As String, noText As String, defaultButton As DialogResult) As Boolean

            Dim yesButton = New TaskDialogButton(yesText) With {.Tag = DialogResult.Yes}
            Dim noButton = New TaskDialogButton(noText) With {.Tag = DialogResult.No}

            Dim buttons = New TaskDialogButtonCollection

            If defaultButton = DialogResult.Yes Then
                buttons.Add(yesButton)
                buttons.Add(noButton)
            Else
                buttons.Add(noButton)
                buttons.Add(yesButton)
            End If


            Dim page = New TaskDialogPage() With {
                    .Caption = caption,
                    .SizeToContent = True,
                    .Heading = heading,
                    .Buttons = buttons
                    }


            Dim result = TaskDialog.ShowDialog(owner, page)

            Return CType(result.Tag, DialogResult) = DialogResult.Yes

        End Function
    End Module

End Namespace