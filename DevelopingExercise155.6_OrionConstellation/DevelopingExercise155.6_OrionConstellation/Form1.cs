namespace DevelopingExercise155._6_OrionConstellation
{
    public partial class orionConstellation : Form
    {
        public orionConstellation()
        {
            InitializeComponent();
        }

        private void showStarsButton_Click(object sender, EventArgs e)
        {
            betelgeuseLabel.Visible = true;
            alnilamLabel.Visible = true;
            alnitakLabel.Visible = true;
            saiphLabel.Visible = true;
            meissaLabel.Visible = true;
            mintakaLabel.Visible = true;
            rigelLabel.Visible = true;
        }

        private void hideStarsButton_Click(object sender, EventArgs e)
        {
            betelgeuseLabel.Visible = false;
            alnilamLabel.Visible = false;
            alnitakLabel.Visible = false;
            saiphLabel.Visible = false;
            meissaLabel.Visible = false;
            mintakaLabel.Visible = false;
            rigelLabel.Visible = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
