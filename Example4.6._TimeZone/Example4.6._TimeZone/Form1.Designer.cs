namespace Example4._6._TimeZone
{
    partial class formTimeZone
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
            promptLabel = new Label();
            cityListBox = new ListBox();
            outputDescriptionLabel = new Label();
            timeZoneLabel = new Label();
            okButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // promptLabel
            // 
            promptLabel.AutoSize = true;
            promptLabel.Location = new Point(61, 39);
            promptLabel.Name = "promptLabel";
            promptLabel.Size = new Size(233, 20);
            promptLabel.TabIndex = 0;
            promptLabel.Text = "Choose a city to get its time zone.";
            // 
            // cityListBox
            // 
            cityListBox.FormattingEnabled = true;
            cityListBox.Items.AddRange(new object[] { "Denver", "Honolulu", "Minneapolis", "New York", "San Francisco" });
            cityListBox.Location = new Point(115, 96);
            cityListBox.Name = "cityListBox";
            cityListBox.Size = new Size(193, 104);
            cityListBox.TabIndex = 1;
            // 
            // outputDescriptionLabel
            // 
            outputDescriptionLabel.AutoSize = true;
            outputDescriptionLabel.Location = new Point(61, 216);
            outputDescriptionLabel.Name = "outputDescriptionLabel";
            outputDescriptionLabel.Size = new Size(80, 20);
            outputDescriptionLabel.TabIndex = 2;
            outputDescriptionLabel.Text = "Time Zone";
            // 
            // timeZoneLabel
            // 
            timeZoneLabel.BorderStyle = BorderStyle.FixedSingle;
            timeZoneLabel.Location = new Point(227, 215);
            timeZoneLabel.Name = "timeZoneLabel";
            timeZoneLabel.Size = new Size(140, 22);
            timeZoneLabel.TabIndex = 3;
            // 
            // okButton
            // 
            okButton.Location = new Point(75, 284);
            okButton.Name = "okButton";
            okButton.Size = new Size(94, 29);
            okButton.TabIndex = 4;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(253, 284);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(94, 29);
            exitButton.TabIndex = 5;
            exitButton.Text = "Close App";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // formTimeZone
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 338);
            Controls.Add(exitButton);
            Controls.Add(okButton);
            Controls.Add(timeZoneLabel);
            Controls.Add(outputDescriptionLabel);
            Controls.Add(cityListBox);
            Controls.Add(promptLabel);
            Name = "formTimeZone";
            Text = "Time Zone";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label promptLabel;
        private ListBox cityListBox;
        private Label outputDescriptionLabel;
        private Label timeZoneLabel;
        private Button okButton;
        private Button exitButton;
    }
}
