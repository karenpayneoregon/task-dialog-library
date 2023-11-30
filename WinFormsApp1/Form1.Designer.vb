<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        QuestionButton = New Button()
        StandardQuestionButton = New Button()
        SuspendLayout()
        ' 
        ' QuestionButton
        ' 
        QuestionButton.Location = New Point(307, 129)
        QuestionButton.Name = "QuestionButton"
        QuestionButton.Size = New Size(183, 29)
        QuestionButton.TabIndex = 0
        QuestionButton.Text = "Question with action"
        QuestionButton.UseVisualStyleBackColor = True
        ' 
        ' StandardQuestionButton
        ' 
        StandardQuestionButton.Location = New Point(307, 186)
        StandardQuestionButton.Name = "StandardQuestionButton"
        StandardQuestionButton.Size = New Size(183, 29)
        StandardQuestionButton.TabIndex = 1
        StandardQuestionButton.Text = "Question standard"
        StandardQuestionButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(StandardQuestionButton)
        Controls.Add(QuestionButton)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents QuestionButton As Button
    Friend WithEvents StandardQuestionButton As Button

End Class
