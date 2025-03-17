namespace WinFormsApp20255
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            checkedListBox = new CheckedListBox();
            listBox = new ListBox();
            Addbutton = new Button();
            ClearAllbutton = new Button();
            Deletebutton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(224, 224, 224);
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 9);
            label1.Name = "label1";
            label1.Size = new Size(275, 20);
            label1.TabIndex = 0;
            label1.Text = "SIMPLE FAVORITE MOVIE PICKER APP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(224, 224, 224);
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(60, 60);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 1;
            label2.Text = "Movie/Series list";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(224, 224, 224);
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(222, 60);
            label3.Name = "label3";
            label3.Size = new Size(198, 20);
            label3.TabIndex = 2;
            label3.Text = "My Programming language";
            label3.Click += label3_Click;
            // 
            // checkedListBox
            // 
            checkedListBox.BackColor = Color.FromArgb(224, 224, 224);
            checkedListBox.FormattingEnabled = true;
            checkedListBox.Location = new Point(38, 91);
            checkedListBox.Name = "checkedListBox";
            checkedListBox.Size = new Size(162, 166);
            checkedListBox.TabIndex = 3;
            checkedListBox.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // listBox
            // 
            listBox.BackColor = Color.FromArgb(224, 224, 224);
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(245, 91);
            listBox.Name = "listBox";
            listBox.Size = new Size(145, 169);
            listBox.TabIndex = 4;
            listBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Addbutton
            // 
            Addbutton.BackColor = Color.FromArgb(192, 255, 192);
            Addbutton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Addbutton.Location = new Point(73, 263);
            Addbutton.Name = "Addbutton";
            Addbutton.Size = new Size(85, 36);
            Addbutton.TabIndex = 5;
            Addbutton.Text = "Add";
            Addbutton.UseVisualStyleBackColor = false;
            Addbutton.Click += Addbutton_Click;
            // 
            // ClearAllbutton
            // 
            ClearAllbutton.BackColor = Color.FromArgb(192, 255, 192);
            ClearAllbutton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearAllbutton.Location = new Point(419, 191);
            ClearAllbutton.Name = "ClearAllbutton";
            ClearAllbutton.Size = new Size(85, 36);
            ClearAllbutton.TabIndex = 6;
            ClearAllbutton.Text = "Clear All";
            ClearAllbutton.UseVisualStyleBackColor = false;
            ClearAllbutton.Click += ClearAllbutton_Click;
            // 
            // Deletebutton
            // 
            Deletebutton.BackColor = Color.FromArgb(192, 255, 192);
            Deletebutton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Deletebutton.Location = new Point(419, 106);
            Deletebutton.Name = "Deletebutton";
            Deletebutton.Size = new Size(85, 36);
            Deletebutton.TabIndex = 7;
            Deletebutton.Text = "Delete";
            Deletebutton.UseVisualStyleBackColor = false;
            Deletebutton.Click += Deletebutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(541, 340);
            Controls.Add(Deletebutton);
            Controls.Add(ClearAllbutton);
            Controls.Add(Addbutton);
            Controls.Add(listBox);
            Controls.Add(checkedListBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private CheckedListBox checkedListBox;
        private ListBox listBox;
        private Button Addbutton;
        private Button ClearAllbutton;
        private Button Deletebutton;
    }
}
