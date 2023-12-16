namespace DoNotShowAgainApp;

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
        DoNotShowAgainButton = new Button();
        ShowAgainCheckBox = new CheckBox();
        ResultsTextBox = new TextBox();
        SuspendLayout();
        // 
        // DoNotShowAgainButton
        // 
        DoNotShowAgainButton.Location = new Point(74, 46);
        DoNotShowAgainButton.Name = "DoNotShowAgainButton";
        DoNotShowAgainButton.Size = new Size(139, 29);
        DoNotShowAgainButton.TabIndex = 0;
        DoNotShowAgainButton.Text = "Click me";
        DoNotShowAgainButton.UseVisualStyleBackColor = true;
        DoNotShowAgainButton.Click += DoNotShowAgainButton_Click;
        // 
        // ShowAgainCheckBox
        // 
        ShowAgainCheckBox.AutoSize = true;
        ShowAgainCheckBox.Location = new Point(219, 49);
        ShowAgainCheckBox.Name = "ShowAgainCheckBox";
        ShowAgainCheckBox.Size = new Size(156, 24);
        ShowAgainCheckBox.TabIndex = 1;
        ShowAgainCheckBox.Text = "Toggle show again";
        ShowAgainCheckBox.UseVisualStyleBackColor = true;
        // 
        // ResultsTextBox
        // 
        ResultsTextBox.Location = new Point(74, 92);
        ResultsTextBox.Name = "ResultsTextBox";
        ResultsTextBox.PlaceholderText = "results";
        ResultsTextBox.Size = new Size(301, 27);
        ResultsTextBox.TabIndex = 2;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(ResultsTextBox);
        Controls.Add(ShowAgainCheckBox);
        Controls.Add(DoNotShowAgainButton);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button DoNotShowAgainButton;
    private CheckBox ShowAgainCheckBox;
    private TextBox ResultsTextBox;
}
