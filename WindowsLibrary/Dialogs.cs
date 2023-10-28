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

}
