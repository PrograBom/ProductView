namespace ProductViewUI
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void ukonËiùToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void oAplik·ciiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Martin Baranek");
        }

        private void goToCatalogButton_Click(object sender, EventArgs e)
        {
            ProductViewForm catalogForm = new ProductViewForm();

            catalogForm.Show();
        }

        private void WelcomeForm_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void katalÛgToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductViewForm catalogForm = new ProductViewForm();

            catalogForm.Show();
        }
    }
}
