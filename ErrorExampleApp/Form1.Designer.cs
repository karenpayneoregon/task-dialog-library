namespace ErrorExampleApp;

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
        BadReadFileButton = new Button();
        SuspendLayout();
        // 
        // BadReadFileButton
        // 
        BadReadFileButton.Location = new Point(686, 289);
        BadReadFileButton.Name = "BadReadFileButton";
        BadReadFileButton.Size = new Size(198, 29);
        BadReadFileButton.TabIndex = 0;
        BadReadFileButton.Text = "Read non existing file";
        BadReadFileButton.UseVisualStyleBackColor = true;
        BadReadFileButton.Click += BadReadFileButton_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(939, 440);
        Controls.Add(BadReadFileButton);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "Form1";
        StartPosition = FormStartPosition.Manual;
        Text = "Ooops";
        ResumeLayout(false);
    }

    #endregion

    private Button BadReadFileButton;
}
