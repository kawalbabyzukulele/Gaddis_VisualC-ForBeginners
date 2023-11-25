namespace Example2._1._HelloWorld
{
    public partial class messageButton : Form
    {
        public messageButton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Witaj Œwiecie");
        }
    }
}
