namespace WindowsLibrary;

public class Dialogs
{
    public static void Question(Control owner, string heading, Action yesAction, Action noAction)
    {

        TaskDialogButton yesButton = new("Yes") { Tag = DialogResult.Yes };
        TaskDialogButton noButton = new("No") { Tag = DialogResult.No };

        var buttons = new TaskDialogButtonCollection
        {
            yesButton,
            noButton
        };


        TaskDialogPage page = new()
        {
            Caption = "Question",
            SizeToContent = true,
            Heading = heading,
            Icon = new TaskDialogIcon(Properties.Resources.QuestionBlue),
            Buttons = buttons
        };

        var result = TaskDialog.ShowDialog(owner, page);

        if ((DialogResult)result.Tag! == DialogResult.Yes)
        {
            yesAction?.Invoke();
        }
        else
        {
            noAction?.Invoke();
        }

    }

    public static void OpenSolutionQuestion(Control owner)
    {
        TaskDialogPage page = new()
        {
            Caption = "Open solution",
            SizeToContent = true,
            Heading = "Open the solution in",
            Text = "New instance or Current instance of Visual Studio?",
            Icon = new TaskDialogIcon(Properties.Resources.question32),
            Expander = new TaskDialogExpander("expandedText"),

            Buttons =
            [
                new TaskDialogButton("Current Instance") { Tag = DialogResult.OK },
                new TaskDialogButton("New Instance") { Tag = DialogResult.OK },
                new TaskDialogButton("Cancel") { Tag = DialogResult.OK }
            ]
        };

        TaskDialogVerificationCheckBox verifyCheckBox = new("Remember");
        page.Verification = verifyCheckBox;

        TaskDialog.ShowDialog(owner, page);
    }

}
