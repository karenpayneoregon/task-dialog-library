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
            this.Question1Button = new System.Windows.Forms.Button();
            this.Question2Button = new System.Windows.Forms.Button();
            this.Question3Button = new System.Windows.Forms.Button();
            this.AutoCloseButton = new System.Windows.Forms.Button();
            this.SecondsUpDown = new TaskDialogFrontEndApp.Classes.SpecialNumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.SecondsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Question1Button
            // 
            this.Question1Button.Location = new System.Drawing.Point(28, 22);
            this.Question1Button.Name = "Question1Button";
            this.Question1Button.Size = new System.Drawing.Size(230, 23);
            this.Question1Button.TabIndex = 0;
            this.Question1Button.Text = "Question 1 - center on form";
            this.Question1Button.UseVisualStyleBackColor = true;
            this.Question1Button.Click += new System.EventHandler(this.Question1Button_Click);
            // 
            // Question2Button
            // 
            this.Question2Button.Location = new System.Drawing.Point(28, 64);
            this.Question2Button.Name = "Question2Button";
            this.Question2Button.Size = new System.Drawing.Size(230, 23);
            this.Question2Button.TabIndex = 1;
            this.Question2Button.Text = "Question 2 - center this button";
            this.Question2Button.UseVisualStyleBackColor = true;
            this.Question2Button.Click += new System.EventHandler(this.Question2Button_Click);
            // 
            // Question3Button
            // 
            this.Question3Button.Location = new System.Drawing.Point(28, 105);
            this.Question3Button.Name = "Question3Button";
            this.Question3Button.Size = new System.Drawing.Size(230, 23);
            this.Question3Button.TabIndex = 2;
            this.Question3Button.Text = "Question 3 - with verify";
            this.Question3Button.UseVisualStyleBackColor = true;
            this.Question3Button.Click += new System.EventHandler(this.Question3Button_Click);
            // 
            // AutoCloseButton
            // 
            this.AutoCloseButton.Location = new System.Drawing.Point(28, 147);
            this.AutoCloseButton.Name = "AutoCloseButton";
            this.AutoCloseButton.Size = new System.Drawing.Size(230, 23);
            this.AutoCloseButton.TabIndex = 3;
            this.AutoCloseButton.Text = "Auto-close";
            this.AutoCloseButton.UseVisualStyleBackColor = true;
            this.AutoCloseButton.Click += new System.EventHandler(this.AutoCloseButton_Click);
            // 
            // SecondsUpDown
            // 
            this.SecondsUpDown.Location = new System.Drawing.Point(264, 147);
            this.SecondsUpDown.Name = "SecondsUpDown";
            this.SecondsUpDown.Size = new System.Drawing.Size(39, 23);
            this.SecondsUpDown.TabIndex = 4;
            this.SecondsUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SecondsUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 190);
            this.Controls.Add(this.SecondsUpDown);
            this.Controls.Add(this.AutoCloseButton);
            this.Controls.Add(this.Question3Button);
            this.Controls.Add(this.Question2Button);
            this.Controls.Add(this.Question1Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dialog examples";
            ((System.ComponentModel.ISupportInitialize)(this.SecondsUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button Question1Button;
        private Button Question2Button;
        private Button Question3Button;
        private Button AutoCloseButton;
        private Classes.SpecialNumericUpDown SecondsUpDown;
    }
}