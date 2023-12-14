namespace Example4._6._TimeZone
{
    public partial class formTimeZone : Form
    {
        public formTimeZone()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string city;

            if (cityListBox.SelectedItem != String.Empty)
            {
                city= cityListBox.SelectedItem.ToString();

                switch(city)
                {
                    case "Honolulu":
                        timeZoneLabel.Text = "hawajsko-aleucka";
                        break;
                    case "San Francisco":
                        timeZoneLabel.Text = "pacyficzna";
                        break;
                    case "Denver":
                        timeZoneLabel.Text = "górska";
                        break;
                    case "Minneapolis":
                        timeZoneLabel.Text = "centralna";
                        break;
                    case "New York":
                        timeZoneLabel.Text = "wschodnia";
                        break;

                }
            }
            else { MessageBox.Show("Choose a town."); }
        }
    }
}
