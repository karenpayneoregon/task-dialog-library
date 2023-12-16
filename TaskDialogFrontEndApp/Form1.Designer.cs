namespace TaskDialogFrontEndApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Question1Button = new Button();
            Question2Button = new Button();
            Question3Button = new Button();
            AutoCloseButton = new Button();
            SecondsUpDown = new Classes.SpecialNumericUpDown();
            ActionQuestionButton = new Button();
            ((System.ComponentModel.ISupportInitialize)SecondsUpDown).BeginInit();
            SuspendLayout();
            // 
            // Question1Button
            // 
            Question1Button.Location = new Point(32, 29);
            Question1Button.Margin = new Padding(3, 4, 3, 4);
            Question1Button.Name = "Question1Button";
            Question1Button.Size = new Size(263, 31);
            Question1Button.TabIndex = 0;
            Question1Button.Text = "Question 1 - center on form";
            Question1Button.UseVisualStyleBackColor = true;
            Question1Button.Click += Question1Button_Click;
            // 
            // Question2Button
            // 
            Question2Button.Location = new Point(508, 86);
            Question2Button.Margin = new Padding(3, 4, 3, 4);
            Question2Button.Name = "Question2Button";
            Question2Button.Size = new Size(263, 31);
            Question2Button.TabIndex = 1;
            Question2Button.Text = "Question 2 - center this button";
            Question2Button.UseVisualStyleBackColor = true;
            Question2Button.Click += Question2Button_Click;
            // 
            // Question3Button
            // 
            Question3Button.Location = new Point(32, 140);
            Question3Button.Margin = new Padding(3, 4, 3, 4);
            Question3Button.Name = "Question3Button";
            Question3Button.Size = new Size(263, 31);
            Question3Button.TabIndex = 2;
            Question3Button.Text = "Question 3 - with verify";
            Question3Button.UseVisualStyleBackColor = true;
            Question3Button.Click += Question3Button_Click;
            // 
            // AutoCloseButton
            // 
            AutoCloseButton.Location = new Point(32, 196);
            AutoCloseButton.Margin = new Padding(3, 4, 3, 4);
            AutoCloseButton.Name = "AutoCloseButton";
            AutoCloseButton.Size = new Size(263, 31);
            AutoCloseButton.TabIndex = 3;
            AutoCloseButton.Text = "Auto-close";
            AutoCloseButton.UseVisualStyleBackColor = true;
            AutoCloseButton.Click += AutoCloseButton_Click;
            // 
            // SecondsUpDown
            // 
            SecondsUpDown.Location = new Point(302, 196);
            SecondsUpDown.Margin = new Padding(3, 4, 3, 4);
            SecondsUpDown.Name = "SecondsUpDown";
            SecondsUpDown.Size = new Size(45, 27);
            SecondsUpDown.TabIndex = 4;
            SecondsUpDown.TextAlign = HorizontalAlignment.Right;
            SecondsUpDown.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // ActionQuestionButton
            // 
            ActionQuestionButton.Location = new Point(32, 249);
            ActionQuestionButton.Margin = new Padding(3, 4, 3, 4);
            ActionQuestionButton.Name = "ActionQuestionButton";
            ActionQuestionButton.Size = new Size(263, 31);
            ActionQuestionButton.TabIndex = 5;
            ActionQuestionButton.Text = "Actions";
            ActionQuestionButton.UseVisualStyleBackColor = true;
            ActionQuestionButton.Click += ActionQuestionButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 293);
            Controls.Add(ActionQuestionButton);
            Controls.Add(SecondsUpDown);
            Controls.Add(AutoCloseButton);
            Controls.Add(Question3Button);
            Controls.Add(Question2Button);
            Controls.Add(Question1Button);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dialog examples";
            ((System.ComponentModel.ISupportInitialize)SecondsUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Question1Button;
        private Button Question2Button;
        private Button Question3Button;
        private Button AutoCloseButton;
        private Classes.SpecialNumericUpDown SecondsUpDown;
        private Button ActionQuestionButton;
    }
}