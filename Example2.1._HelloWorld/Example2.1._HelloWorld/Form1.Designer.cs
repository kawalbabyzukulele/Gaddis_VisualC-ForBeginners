namespace Example2._1._HelloWorld
{
    partial class messageButton
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
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(120, 72);
            button1.Name = "button1";
            button1.Size = new Size(119, 48);
            button1.TabIndex = 0;
            button1.Text = "Show Message";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // messageButton
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 211);
            Controls.Add(button1);
            Name = "messageButton";
            Text = "My first programme";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}
