namespace Example2._5._CardFlip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showFrontButton_Click(object sender, EventArgs e)
        {
            cardBack.Visible = false;
            cardFront.Visible = true;
        }

        private void showBackButton_Click(object sender, EventArgs e)
        {
            cardBack.Visible = true;
            cardFront.Visible = false;
        }
    }
}
