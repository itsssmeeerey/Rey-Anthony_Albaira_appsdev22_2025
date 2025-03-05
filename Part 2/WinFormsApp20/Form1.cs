using System.Diagnostics.Eventing.Reader;

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

            DialogResult = MessageBox.Show("Are you sure you want to submit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (DialogResult == DialogResult.Yes)
            {

                MessageBox.Show($"Hello World {fNameValue} {lNameValue}", "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Aight", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
        }
    }
}
