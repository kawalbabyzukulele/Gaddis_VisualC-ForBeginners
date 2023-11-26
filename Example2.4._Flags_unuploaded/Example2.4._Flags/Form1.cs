namespace Example2._4._Flags
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "Finland";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "France";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "Germany";
        }
    }
}
