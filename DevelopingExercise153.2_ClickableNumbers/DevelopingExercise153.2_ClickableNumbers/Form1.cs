namespace DevelopingExercise153._2_ClickableNumbers
{
    public partial class clickableNumbers : Form
    {
        public clickableNumbers()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            responseLabel.Text = "One";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            responseLabel.Text = "Two";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            responseLabel.Text = "Three";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            responseLabel.Text = "Four";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            responseLabel.Text = "Five";
        }
    }
}
