namespace DevelopingExercise153._1_LatinDictionary
{
    public partial class latinDictionary : Form
    {
        public latinDictionary()
        {
            InitializeComponent();
        }

        private void sinisterButton_Click(object sender, EventArgs e)
        {
            sinisterLabel.Text = "lewy";
        }

        private void dexterButton_Click(object sender, EventArgs e)
        {
            dexterLabel.Text = "prawy";
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            mediumLabel.Text = "œredni";
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            sinisterLabel.Text = "";
            dexterLabel.Text = "";
            mediumLabel.Text = "";
        }
    }
}
