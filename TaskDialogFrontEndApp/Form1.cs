using TaskDialogLibrary;

namespace TaskDialogFrontEndApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Question1Button_Click(object sender, EventArgs e)
        {
            // center on this form
            if (Dialogs.Question(this, "Do you like coffee?"))
            {
                MessageBox.Show("Yes");
            }
            else
            {
                MessageBox.Show("No");
            }
        }

        private void Question2Button_Click(object sender, EventArgs e)
        {
            // center on this form
            if (Dialogs.Question(Question2Button, "Do you like coffee?"))
            {
                MessageBox.Show("Yes");
            }
            else
            {
                MessageBox.Show("No");
            }
        }

        private void Question3Button_Click(object sender, EventArgs e)
        {
            var message = "To continue check verify and click the Yes button";
            var (answer, verification) = Dialogs.Question(this, message, true, DialogResult.No);
            if (answer && verification)
            {
                Dialogs.Information("Verified");
            }else if (answer && !verification)
            {
                Dialogs.Information("Not verified");
            }else if (!answer && !verification)
            {
                Dialogs.Information("Declined");
            }
            else
            {
                Dialogs.Information("Abort");
            }

        }

        private void AutoCloseButton_Click(object sender, EventArgs e)
        {
            Dialogs.AutoCloseDialog(this, $"Select Yes or no or auto contine in {SecondsUpDown.AsInteger} seconds", "Waiting...",Properties.Resources.Timer_16x, SecondsUpDown.AsInteger);
        }
    }
}