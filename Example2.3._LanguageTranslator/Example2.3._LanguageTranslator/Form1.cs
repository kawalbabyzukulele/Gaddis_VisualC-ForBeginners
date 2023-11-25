namespace Example2._3._LanguageTranslator
{
    public partial class instructionLabel : Form
    {
        public instructionLabel()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void italianButton_Click(object sender, EventArgs e)
        {
            greetingLabel.Text = "Buongiorno";
        }

        private void spanishButton_Click(object sender, EventArgs e)
        {
            greetingLabel.Text = "Buenos dias";
        }

        private void germanButton_Click(object sender, EventArgs e)
        {
            greetingLabel.Text = "Guten Morgen";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
