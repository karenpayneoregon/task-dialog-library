using DoNotShowAgainApp.Properties;
using Newtonsoft.Json;
using TaskDialogLibrary;
using TaskDialogLibrary.Classes;
using TaskDialogLibrary.Models;

namespace DoNotShowAgainApp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        ShowAgainCheckBox.CheckedChanged += ShowAgainCheckBoxOnCheckedChanged;

        MainSettings settings = new MainSettings()
        {
            ConnectionStrings = new ConnectionString() { MainConnection = "Data Source=(localdb)\\\\MSSQLLocalDB;Initial Catalog=MockupApplication;Integrated Security=True" },
            Logging = new Logging() {LogLevel = new Loglevel() {Default = "Information" } }
        };
        var json = JsonConvert.SerializeObject(settings, Formatting.Indented);
    }

    private void ShowAgainCheckBoxOnCheckedChanged(object? sender, EventArgs e)
    {
        var settings = SettingOperations.GetSetting();
        settings.ShowAgain = ShowAgainCheckBox.Checked;
        SettingOperations.SaveChanges(settings);
    }

    private void DoNotShowAgainButton_Click(object sender, EventArgs e)
    {
        ApplicationSettings settings = SettingOperations.GetSetting();

        if (!settings.ShowAgain)
        {
            return;
        }

        ShowAgainOptions options = new()
        {
            Heading = settings.Heading,
            Text = settings.Text,
            Caption = settings.Caption,
            Icon = Resources.agent1,
            VerificationText = settings.VerificationText,
            Owner = this
        };

        (NoShowResult DialogResult, bool ShowAgain) result = Dialogs.DoNotShowAgain(this, options);

        ShowAgainCheckBox.Checked = result.ShowAgain;
        ResultsTextBox.Text = result.ToString();
    }
}
