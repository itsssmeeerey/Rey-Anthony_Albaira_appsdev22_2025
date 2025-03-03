namespace WinFormsApp33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fNameValue = FirstName.Text;
            string lNameValue = LastName.Text;
            MessageBox.Show($"Hello World {fNameValue} {lNameValue}", "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
