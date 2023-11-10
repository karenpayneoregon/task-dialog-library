using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace TaskDialogLibrary;
public partial class Dialogs
{
    // WIP - for showing error text and long error text
    public static void ShowErrorMessage(Control owner, string errorTitle, string instruction, string errorMessage)
    {
        // TODO - finish up

        TaskDialogButton okayButton = new("Okay");
        TaskDialogButtonCollection buttons = new();
        
        TaskDialogPage page = new()
        {
            Caption = "caption",
            SizeToContent = true,
            Heading = errorTitle,
            Expander = new TaskDialogExpander(errorMessage),
            Icon = new TaskDialogIcon(Properties.Resources.agreement),
            Buttons = new TaskDialogButtonCollection() { okayButton },
            AllowCancel = true
        };

        var result = TaskDialog.ShowDialog(owner, page);

    }
}
