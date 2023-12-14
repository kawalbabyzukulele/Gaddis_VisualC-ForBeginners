namespace Example4._5._ColorTheme
{
    public partial class formColorTheme : Form
    {
        public formColorTheme()
        {
            InitializeComponent();
        }

        private void yellowRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void redRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void whiteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void normalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
