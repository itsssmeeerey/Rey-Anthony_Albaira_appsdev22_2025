using System.Diagnostics.Eventing.Reader;

namespace SimpleFormsAppWithComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] cuisinenationality = { "Filipino", "Chinese", "Japanese", "German" };
            comboBox1.Items.AddRange(cuisinenationality);

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;

            checkedListBox1.CheckOnClick = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] filipinoCuisineList = { "adobo", "longganisa", "soup", "spaghetti" };
            string[] chineseCuisineList = { "ramen", "piggy", "peeking duck", "kung pao chicken" };
            string[] japaneseCuisineList = { "sushi", "tempura", "kaieski", "miso soup" };
            string[] germanCuisineList = { "pretzels", "apple strudel", "german potato salad", "black forest cake" };

            checkedListBox1.Items.Clear();
            if (comboBox1.SelectedItem.ToString().Contains("Filipino"))
            {
                checkedListBox1.Items.AddRange(filipinoCuisineList);
            }
            else if
                (comboBox1.SelectedItem.ToString().Contains("Chinese"))
            {
                checkedListBox1.Items.AddRange(chineseCuisineList);
            }

            else if
                (comboBox1.SelectedItem.ToString().Contains("Japanese"))
            {
                checkedListBox1.Items.AddRange(japaneseCuisineList);
            }
            else if
                (comboBox1.SelectedItem.ToString().Contains("German"))
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var food in checkedListBox1.Items)
            {
                bool isSelected = checkedListBox1.GetItemChecked(checkedListBox1.Items.IndexOf(food));
                if (isSelected && !listBox1.Items.Contains(food))
                {
                    listBox1.Items.Add(food);
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count >= 1)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
