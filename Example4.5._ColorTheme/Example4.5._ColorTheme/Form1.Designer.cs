namespace Example4._5._ColorTheme
{
    partial class formColorTheme
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
            colorGroupBox = new GroupBox();
            normalRadioButton = new RadioButton();
            whiteRadioButton = new RadioButton();
            redRadioButton = new RadioButton();
            yellowRadioButton = new RadioButton();
            exitButton = new Button();
            colorGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // colorGroupBox
            // 
            colorGroupBox.Controls.Add(normalRadioButton);
            colorGroupBox.Controls.Add(whiteRadioButton);
            colorGroupBox.Controls.Add(redRadioButton);
            colorGroupBox.Controls.Add(yellowRadioButton);
            colorGroupBox.Location = new Point(85, 49);
            colorGroupBox.Name = "colorGroupBox";
            colorGroupBox.Size = new Size(250, 173);
            colorGroupBox.TabIndex = 0;
            colorGroupBox.TabStop = false;
            colorGroupBox.Text = "Choose background color";
            // 
            // normalRadioButton
            // 
            normalRadioButton.AutoSize = true;
            normalRadioButton.Checked = true;
            normalRadioButton.Location = new Point(42, 127);
            normalRadioButton.Name = "normalRadioButton";
            normalRadioButton.Size = new Size(79, 24);
            normalRadioButton.TabIndex = 3;
            normalRadioButton.TabStop = true;
            normalRadioButton.Text = "Default";
            normalRadioButton.UseVisualStyleBackColor = true;
            normalRadioButton.CheckedChanged += normalRadioButton_CheckedChanged;
            // 
            // whiteRadioButton
            // 
            whiteRadioButton.AutoSize = true;
            whiteRadioButton.Location = new Point(43, 93);
            whiteRadioButton.Name = "whiteRadioButton";
            whiteRadioButton.Size = new Size(69, 24);
            whiteRadioButton.TabIndex = 2;
            whiteRadioButton.Text = "White";
            whiteRadioButton.UseVisualStyleBackColor = true;
            whiteRadioButton.CheckedChanged += whiteRadioButton_CheckedChanged;
            // 
            // redRadioButton
            // 
            redRadioButton.AutoSize = true;
            redRadioButton.Location = new Point(44, 60);
            redRadioButton.Name = "redRadioButton";
            redRadioButton.Size = new Size(56, 24);
            redRadioButton.TabIndex = 1;
            redRadioButton.Text = "Red";
            redRadioButton.UseVisualStyleBackColor = true;
            redRadioButton.CheckedChanged += redRadioButton_CheckedChanged;
            // 
            // yellowRadioButton
            // 
            yellowRadioButton.AutoSize = true;
            yellowRadioButton.Location = new Point(43, 30);
            yellowRadioButton.Name = "yellowRadioButton";
            yellowRadioButton.Size = new Size(73, 24);
            yellowRadioButton.TabIndex = 0;
            yellowRadioButton.Text = "Yellow";
            yellowRadioButton.UseVisualStyleBackColor = true;
            yellowRadioButton.CheckedChanged += yellowRadioButton_CheckedChanged;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(158, 246);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(94, 29);
            exitButton.TabIndex = 1;
            exitButton.Text = "Close App";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // formColorTheme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(415, 297);
            Controls.Add(exitButton);
            Controls.Add(colorGroupBox);
            Name = "formColorTheme";
            Text = "Color Theme";
            colorGroupBox.ResumeLayout(false);
            colorGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox colorGroupBox;
        private RadioButton normalRadioButton;
        private RadioButton whiteRadioButton;
        private RadioButton redRadioButton;
        private RadioButton yellowRadioButton;
        private Button exitButton;
    }
}
