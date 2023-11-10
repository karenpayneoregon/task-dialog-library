using System.Diagnostics;
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
            var message = "Verify you understand the terms presented.";
            
            // better placed in a file or resource
            var expandText = 
                "Terms of agreement are a set of legal conditions " +
                "used to ensure that all parties involved in a contract or " +
                "transaction understand the responsibilities and obligations " +
                "of each party. They can be found in any type of business document, " +
                "including service contracts, purchase orders, and sales " +
                "agreements. Having a thorough understanding of terms of " +
                "agreement is essential for any business owner or " +
                "professional who wishes to make sure their rights " +
                "and interests are protected. In this blog post, let’s " +
                "explore what terms of agreement actually mean and why it’s " +
                "so important to get them right every time.";

            var (answer, verification) = Dialogs.Question(
                this, message, "Action required", expandText,true, DialogResult.No);

            if (answer && verification)
            {
                Dialogs.Information(this,"Verified");
            }
            else if (answer && !verification)
            {
                Dialogs.Information(this,"Not verified");
            }
            else if (!answer && !verification)
            {
                Dialogs.Information(this,"Declined");
            }
            else
            {
                Dialogs.Information(this,"Abort");
            }

        }

        private void AutoCloseButton_Click(object sender, EventArgs e)
        {
            Dialogs.AutoCloseDialog(this, $"Select Yes or no or auto continue in {SecondsUpDown.AsInteger} seconds", "Waiting...", Properties.Resources.Timer_16x, SecondsUpDown.AsInteger);
        }

        public void DataOperations()
        {
            // do data operations
        }
        public void Terminate()
        {
            // here we are in the main form so Close terminates the app
            Close();
        }
        private void ActionQuestionButton_Click(object sender, EventArgs e)
        {
            Dialogs.Question(this, "Continue backing database or terminate?", DataOperations, Terminate);
        }
    }
}