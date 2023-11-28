namespace Example2._5._CardFlip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            cardBack = new PictureBox();
            cardFront = new PictureBox();
            showFrontButton = new Button();
            showBackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)cardBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cardFront).BeginInit();
            SuspendLayout();
            // 
            // cardBack
            // 
            cardBack.Image = (Image)resources.GetObject("cardBack.Image");
            cardBack.Location = new Point(128, 94);
            cardBack.Name = "cardBack";
            cardBack.Size = new Size(132, 186);
            cardBack.SizeMode = PictureBoxSizeMode.Zoom;
            cardBack.TabIndex = 0;
            cardBack.TabStop = false;
            // 
            // cardFront
            // 
            cardFront.Image = (Image)resources.GetObject("cardFront.Image");
            cardFront.Location = new Point(429, 94);
            cardFront.Name = "cardFront";
            cardFront.Size = new Size(132, 186);
            cardFront.SizeMode = PictureBoxSizeMode.Zoom;
            cardFront.TabIndex = 1;
            cardFront.TabStop = false;
            cardFront.Visible = false;
            // 
            // showFrontButton
            // 
            showFrontButton.Location = new Point(408, 328);
            showFrontButton.Name = "showFrontButton";
            showFrontButton.Size = new Size(172, 64);
            showFrontButton.TabIndex = 2;
            showFrontButton.Text = "Show card's front";
            showFrontButton.UseVisualStyleBackColor = true;
            showFrontButton.Click += showFrontButton_Click;
            // 
            // showBackButton
            // 
            showBackButton.Location = new Point(111, 328);
            showBackButton.Name = "showBackButton";
            showBackButton.Size = new Size(172, 64);
            showBackButton.TabIndex = 3;
            showBackButton.Text = "Show card's back";
            showBackButton.UseVisualStyleBackColor = true;
            showBackButton.Click += showBackButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 470);
            Controls.Add(showBackButton);
            Controls.Add(showFrontButton);
            Controls.Add(cardFront);
            Controls.Add(cardBack);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)cardBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)cardFront).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox cardBack;
        private PictureBox cardFront;
        private Button showFrontButton;
        private Button showBackButton;
    }
}
