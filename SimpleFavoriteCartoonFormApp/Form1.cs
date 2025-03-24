namespace Chapter_1_Working_with_PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] characters = { "spongebob", "patrick", "gary", };
            comboBox1.Items.AddRange(characters);

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {

                MessageBox.Show("please select a cartoon list first.");
                return;

            }

            string SelectedItem = comboBox1.SelectedItem.ToString();
            
            string imagePath = string.Empty;

            switch (SelectedItem)
            {
                case "spongebob":
                    imagePath = (@"C:\Users\Rey Anthony\OneDrive\Desktop\New folder\spongebob.jpg");
                    break;

                case "patrick":
                    imagePath = (@"C:\Users\Rey Anthony\OneDrive\Desktop\New folder\patrick.jpg"); 
                    break;

                case "gary":
                    imagePath = (@"C:\Users\Rey Anthony\OneDrive\Desktop\New folder\Stoner-Gary-Spongebob-SVG.jpg");
                    break;

                default:
                    pictureBox1.Image = null;
                    return;
            }

            try
            {
                if (File.Exists(imagePath))
                {
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
                else
                {
                    MessageBox.Show($"Image not found: {imagePath}");
                    pictureBox1.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}");
                pictureBox1.Image = null;
            }


        }


        private void button2_Click(object sender, EventArgs e)
        {
            
            pictureBox1.Image = null;
        }

    }
}
