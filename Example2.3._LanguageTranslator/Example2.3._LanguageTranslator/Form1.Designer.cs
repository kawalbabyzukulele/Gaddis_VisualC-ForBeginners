namespace Example2._3._LanguageTranslator
{
    partial class instructionLabel
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
            label1 = new Label();
            greetingLabel = new Label();
            italianButton = new Button();
            spanishButton = new Button();
            germanButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 32);
            label1.Name = "label1";
            label1.Size = new Size(285, 20);
            label1.TabIndex = 0;
            label1.Text = "Choose language to get the greeting in it.";
            // 
            // greetingLabel
            // 
            greetingLabel.BorderStyle = BorderStyle.FixedSingle;
            greetingLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            greetingLabel.Location = new Point(114, 92);
            greetingLabel.Name = "greetingLabel";
            greetingLabel.Size = new Size(365, 22);
            greetingLabel.TabIndex = 1;
            greetingLabel.TextAlign = ContentAlignment.MiddleCenter;
            greetingLabel.Click += label2_Click;
            // 
            // italianButton
            // 
            italianButton.Location = new Point(70, 187);
            italianButton.Name = "italianButton";
            italianButton.Size = new Size(94, 29);
            italianButton.TabIndex = 2;
            italianButton.Text = "Italian";
            italianButton.UseVisualStyleBackColor = true;
            italianButton.Click += italianButton_Click;
            // 
            // spanishButton
            // 
            spanishButton.Location = new Point(251, 187);
            spanishButton.Name = "spanishButton";
            spanishButton.Size = new Size(94, 29);
            spanishButton.TabIndex = 3;
            spanishButton.Text = "Spanish";
            spanishButton.UseVisualStyleBackColor = true;
            spanishButton.Click += spanishButton_Click;
            // 
            // germanButton
            // 
            germanButton.Location = new Point(436, 187);
            germanButton.Name = "germanButton";
            germanButton.Size = new Size(94, 29);
            germanButton.TabIndex = 4;
            germanButton.Text = "German";
            germanButton.UseVisualStyleBackColor = true;
            germanButton.Click += germanButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(419, 264);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(94, 29);
            exitButton.TabIndex = 5;
            exitButton.Text = "Exit App";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // instructionLabel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 323);
            Controls.Add(exitButton);
            Controls.Add(germanButton);
            Controls.Add(spanishButton);
            Controls.Add(italianButton);
            Controls.Add(greetingLabel);
            Controls.Add(label1);
            Name = "instructionLabel";
            Text = "Language Translator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label greetingLabel;
        private Button italianButton;
        private Button spanishButton;
        private Button germanButton;
        private Button exitButton;
    }
}
