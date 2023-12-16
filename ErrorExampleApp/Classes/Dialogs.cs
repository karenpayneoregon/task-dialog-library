namespace ErrorExampleApp.Classes;
internal class Dialogs
{
    public static void ErrorBox(Form owner, Exception exception, string buttonText = "Dang")
    {

        TaskDialogButton singleButton = new(buttonText);

        var text = $"Encountered the following{Environment.NewLine}{exception.Message}";

        Serilog.Log.Error(exception, "");

        TaskDialogPage page = new()
        {
            Caption = "Information",
            SizeToContent = true,
            Heading = text,
            Icon = TaskDialogIcon.Error,
            Buttons = [singleButton]
        };

        TaskDialog.ShowDialog(owner, page);

    }

    public static void Information(Control owner, string heading, string buttonText = "Ok")
    {

        TaskDialogButton okayButton = new(buttonText);

        TaskDialogPage page = new()
        {
            Caption = "Information",
            SizeToContent = true,
            Heading = heading,
            Icon = new TaskDialogIcon(Properties.Resources.exclamation24),
            Buttons = [okayButton]
        };

        TaskDialog.ShowDialog(owner, page);

    }
}
