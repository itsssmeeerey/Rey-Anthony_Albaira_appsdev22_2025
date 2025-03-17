namespace WinFormsApp20255
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] movies = { "lone survivor", "zombie", "hello love goodbye" };
            checkedListBox.Items.AddRange(movies);

            checkedListBox.CheckOnClick = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            foreach (var movies in checkedListBox.Items)
            {
                bool isSelected = checkedListBox.GetItemChecked(checkedListBox.Items.IndexOf(movies));
                if (isSelected && !listBox.Items.Contains(movies))
                    listBox.Items.Add(movies);

            }
        }


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Count >= 1)
            {
                listBox.Items.Remove(listBox.SelectedItem);
            }
        }

        private void ClearAllbutton_Click(object sender, EventArgs e)
        {
           listBox.Items.Clear();
        }
    }
}



