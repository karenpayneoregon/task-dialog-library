using ErrorExampleApp.Classes;

namespace ErrorExampleApp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        Top = 100;
        Left = 300;
    }

    private void BadReadFileButton_Click(object sender, EventArgs e)
    {
        Dialogs.Information(BadReadFileButton, "Next up, developer error.");
        try
        {
            var text = File.ReadAllText("C:\\Files\\Payne.txt");
        }
        catch (Exception exception)
        {
            Dialogs.ErrorBox(this,exception);
        }
    }
}
