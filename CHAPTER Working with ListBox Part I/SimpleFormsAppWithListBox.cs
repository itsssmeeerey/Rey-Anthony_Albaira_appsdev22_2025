namespace WinFormsApp2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBox.Text) && !listBox.Items.Contains(txtBox.Text))
            {
                listBox.Items.Add(txtBox.Text);
            }
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            listBox.Items.Remove(txtBox.Text);
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

    }

}

