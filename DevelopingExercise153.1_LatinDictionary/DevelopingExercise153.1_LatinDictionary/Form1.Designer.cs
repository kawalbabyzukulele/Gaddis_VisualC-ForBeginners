namespace DevelopingExercise153._1_LatinDictionary
{
    partial class latinDictionary
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
            titleLabel = new Label();
            instructionLabel = new Label();
            sinisterButton = new Button();
            dexterButton = new Button();
            mediumButton = new Button();
            resetButton = new Button();
            sinisterLabel = new Label();
            dexterLabel = new Label();
            mediumLabel = new Label();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            titleLabel.Location = new Point(258, 38);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(195, 31);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Latin Dictionary";
            // 
            // instructionLabel
            // 
            instructionLabel.AutoSize = true;
            instructionLabel.Location = new Point(179, 101);
            instructionLabel.Name = "instructionLabel";
            instructionLabel.Size = new Size(323, 20);
            instructionLabel.TabIndex = 1;
            instructionLabel.Text = "Click a word in latin to get it's polish translation";
            // 
            // sinisterButton
            // 
            sinisterButton.Location = new Point(152, 152);
            sinisterButton.Name = "sinisterButton";
            sinisterButton.Size = new Size(94, 29);
            sinisterButton.TabIndex = 2;
            sinisterButton.Text = "sinister";
            sinisterButton.UseVisualStyleBackColor = true;
            sinisterButton.Click += sinisterButton_Click;
            // 
            // dexterButton
            // 
            dexterButton.Location = new Point(152, 210);
            dexterButton.Name = "dexterButton";
            dexterButton.Size = new Size(94, 29);
            dexterButton.TabIndex = 3;
            dexterButton.Text = "dexter";
            dexterButton.UseVisualStyleBackColor = true;
            dexterButton.Click += dexterButton_Click;
            // 
            // mediumButton
            // 
            mediumButton.Location = new Point(152, 271);
            mediumButton.Name = "mediumButton";
            mediumButton.Size = new Size(94, 29);
            mediumButton.TabIndex = 4;
            mediumButton.Text = "medium";
            mediumButton.UseVisualStyleBackColor = true;
            mediumButton.Click += mediumButton_Click;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(310, 340);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(94, 29);
            resetButton.TabIndex = 5;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // sinisterLabel
            // 
            sinisterLabel.BorderStyle = BorderStyle.FixedSingle;
            sinisterLabel.Location = new Point(461, 152);
            sinisterLabel.Name = "sinisterLabel";
            sinisterLabel.Size = new Size(94, 29);
            sinisterLabel.TabIndex = 6;
            sinisterLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dexterLabel
            // 
            dexterLabel.BorderStyle = BorderStyle.FixedSingle;
            dexterLabel.Location = new Point(461, 210);
            dexterLabel.Name = "dexterLabel";
            dexterLabel.Size = new Size(94, 29);
            dexterLabel.TabIndex = 7;
            dexterLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mediumLabel
            // 
            mediumLabel.BorderStyle = BorderStyle.FixedSingle;
            mediumLabel.Location = new Point(461, 271);
            mediumLabel.Name = "mediumLabel";
            mediumLabel.Size = new Size(94, 29);
            mediumLabel.TabIndex = 8;
            mediumLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // latinDictionary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 426);
            Controls.Add(mediumLabel);
            Controls.Add(dexterLabel);
            Controls.Add(sinisterLabel);
            Controls.Add(resetButton);
            Controls.Add(mediumButton);
            Controls.Add(dexterButton);
            Controls.Add(sinisterButton);
            Controls.Add(instructionLabel);
            Controls.Add(titleLabel);
            Name = "latinDictionary";
            Text = "Latin Dictionary";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label instructionLabel;
        private Button sinisterButton;
        private Button dexterButton;
        private Button mediumButton;
        private Button resetButton;
        private Label sinisterLabel;
        private Label dexterLabel;
        private Label mediumLabel;
    }
}
