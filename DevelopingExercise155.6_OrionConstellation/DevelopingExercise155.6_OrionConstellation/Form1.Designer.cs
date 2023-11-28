namespace DevelopingExercise155._6_OrionConstellation
{
    partial class orionConstellation
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
            skyMap = new PictureBox();
            alnitakLabel = new Label();
            betelgeuseLabel = new Label();
            alnilamLabel = new Label();
            mintakaLabel = new Label();
            meissaLabel = new Label();
            saiphLabel = new Label();
            rigelLabel = new Label();
            showStarsButton = new Button();
            exitButton = new Button();
            hideStarsButton = new Button();
            ((System.ComponentModel.ISupportInitialize)skyMap).BeginInit();
            SuspendLayout();
            // 
            // skyMap
            // 
            skyMap.BorderStyle = BorderStyle.FixedSingle;
            skyMap.Image = Properties.Resources.Orion;
            skyMap.Location = new Point(69, 40);
            skyMap.Name = "skyMap";
            skyMap.Size = new Size(456, 536);
            skyMap.SizeMode = PictureBoxSizeMode.Zoom;
            skyMap.TabIndex = 0;
            skyMap.TabStop = false;
            // 
            // alnitakLabel
            // 
            alnitakLabel.AutoSize = true;
            alnitakLabel.Location = new Point(140, 309);
            alnitakLabel.Name = "alnitakLabel";
            alnitakLabel.Size = new Size(55, 20);
            alnitakLabel.TabIndex = 2;
            alnitakLabel.Text = "Alnitak";
            alnitakLabel.Visible = false;
            // 
            // betelgeuseLabel
            // 
            betelgeuseLabel.AutoSize = true;
            betelgeuseLabel.Location = new Point(119, 67);
            betelgeuseLabel.Name = "betelgeuseLabel";
            betelgeuseLabel.Size = new Size(82, 20);
            betelgeuseLabel.TabIndex = 3;
            betelgeuseLabel.Text = "Betelgeuse";
            betelgeuseLabel.Visible = false;
            // 
            // alnilamLabel
            // 
            alnilamLabel.AutoSize = true;
            alnilamLabel.Location = new Point(233, 259);
            alnilamLabel.Name = "alnilamLabel";
            alnilamLabel.Size = new Size(60, 20);
            alnilamLabel.TabIndex = 4;
            alnilamLabel.Text = "Alnilam";
            alnilamLabel.Visible = false;
            // 
            // mintakaLabel
            // 
            mintakaLabel.AutoSize = true;
            mintakaLabel.Location = new Point(341, 266);
            mintakaLabel.Name = "mintakaLabel";
            mintakaLabel.Size = new Size(62, 20);
            mintakaLabel.TabIndex = 5;
            mintakaLabel.Text = "Mintaka";
            mintakaLabel.Visible = false;
            // 
            // meissaLabel
            // 
            meissaLabel.AutoSize = true;
            meissaLabel.Location = new Point(395, 118);
            meissaLabel.Name = "meissaLabel";
            meissaLabel.Size = new Size(54, 20);
            meissaLabel.TabIndex = 6;
            meissaLabel.Text = "Meissa";
            meissaLabel.Visible = false;
            // 
            // saiphLabel
            // 
            saiphLabel.AutoSize = true;
            saiphLabel.Location = new Point(134, 481);
            saiphLabel.Name = "saiphLabel";
            saiphLabel.Size = new Size(46, 20);
            saiphLabel.TabIndex = 7;
            saiphLabel.Text = "Saiph";
            saiphLabel.Visible = false;
            // 
            // rigelLabel
            // 
            rigelLabel.AutoSize = true;
            rigelLabel.Location = new Point(394, 449);
            rigelLabel.Name = "rigelLabel";
            rigelLabel.Size = new Size(43, 20);
            rigelLabel.TabIndex = 8;
            rigelLabel.Text = "Rigel";
            rigelLabel.Visible = false;
            // 
            // showStarsButton
            // 
            showStarsButton.Location = new Point(44, 604);
            showStarsButton.Name = "showStarsButton";
            showStarsButton.Size = new Size(112, 52);
            showStarsButton.TabIndex = 9;
            showStarsButton.Text = "Show all stars' names";
            showStarsButton.UseVisualStyleBackColor = true;
            showStarsButton.Click += showStarsButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(432, 606);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(112, 52);
            exitButton.TabIndex = 11;
            exitButton.Text = "Close App";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // hideStarsButton
            // 
            hideStarsButton.Location = new Point(242, 606);
            hideStarsButton.Name = "hideStarsButton";
            hideStarsButton.Size = new Size(112, 52);
            hideStarsButton.TabIndex = 12;
            hideStarsButton.Text = "Hide all stars' names";
            hideStarsButton.UseVisualStyleBackColor = true;
            hideStarsButton.Click += hideStarsButton_Click;
            // 
            // orionConstellation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 689);
            Controls.Add(hideStarsButton);
            Controls.Add(exitButton);
            Controls.Add(showStarsButton);
            Controls.Add(rigelLabel);
            Controls.Add(saiphLabel);
            Controls.Add(meissaLabel);
            Controls.Add(mintakaLabel);
            Controls.Add(alnilamLabel);
            Controls.Add(betelgeuseLabel);
            Controls.Add(alnitakLabel);
            Controls.Add(skyMap);
            Name = "orionConstellation";
            Text = "Orion Constellation";
            ((System.ComponentModel.ISupportInitialize)skyMap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox skyMap;
        private Label alnitakLabel;
        private Label betelgeuseLabel;
        private Label alnilamLabel;
        private Label mintakaLabel;
        private Label meissaLabel;
        private Label saiphLabel;
        private Label rigelLabel;
        private Button showStarsButton;
        private Button exitButton;
        private Button hideStarsButton;
    }
}
