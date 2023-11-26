namespace Example2._4._Flags
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
            instructionLabel = new Label();
            finlandPictureBox = new PictureBox();
            francePictureBox = new PictureBox();
            germanPictureBox = new PictureBox();
            countryLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)finlandPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)francePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)germanPictureBox).BeginInit();
            SuspendLayout();
            // 
            // instructionLabel
            // 
            instructionLabel.AutoSize = true;
            instructionLabel.Location = new Point(193, 41);
            instructionLabel.Name = "instructionLabel";
            instructionLabel.Size = new Size(410, 20);
            instructionLabel.TabIndex = 0;
            instructionLabel.Text = "Click a flag and get to know which country does it belong to.";
            // 
            // finlandPictureBox
            // 
            finlandPictureBox.Image = Properties.Resources.Flag_of_Finland;
            finlandPictureBox.Location = new Point(104, 146);
            finlandPictureBox.Name = "finlandPictureBox";
            finlandPictureBox.Size = new Size(146, 93);
            finlandPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            finlandPictureBox.TabIndex = 1;
            finlandPictureBox.TabStop = false;
            finlandPictureBox.Click += pictureBox1_Click;
            // 
            // francePictureBox
            // 
            francePictureBox.Image = Properties.Resources.Flag_of_France;
            francePictureBox.Location = new Point(340, 146);
            francePictureBox.Name = "francePictureBox";
            francePictureBox.Size = new Size(146, 93);
            francePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            francePictureBox.TabIndex = 2;
            francePictureBox.TabStop = false;
            francePictureBox.Click += pictureBox2_Click;
            // 
            // germanPictureBox
            // 
            germanPictureBox.Image = Properties.Resources.Flag_of_Germany_as_seen_in_Tagesschau;
            germanPictureBox.Location = new Point(574, 146);
            germanPictureBox.Name = "germanPictureBox";
            germanPictureBox.Size = new Size(146, 93);
            germanPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            germanPictureBox.TabIndex = 3;
            germanPictureBox.TabStop = false;
            germanPictureBox.Click += pictureBox3_Click;
            // 
            // countryLabel
            // 
            countryLabel.BorderStyle = BorderStyle.FixedSingle;
            countryLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            countryLabel.Location = new Point(261, 322);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(300, 30);
            countryLabel.TabIndex = 4;
            countryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(countryLabel);
            Controls.Add(germanPictureBox);
            Controls.Add(francePictureBox);
            Controls.Add(finlandPictureBox);
            Controls.Add(instructionLabel);
            Name = "Form1";
            Text = "Flags App";
            ((System.ComponentModel.ISupportInitialize)finlandPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)francePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)germanPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label instructionLabel;
        private PictureBox finlandPictureBox;
        private PictureBox francePictureBox;
        private PictureBox germanPictureBox;
        private Label countryLabel;
    }
}
