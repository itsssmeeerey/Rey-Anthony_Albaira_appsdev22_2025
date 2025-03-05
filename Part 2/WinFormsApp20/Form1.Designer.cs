namespace WinFormsApp33
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            FirstName = new TextBox();
            MiddleName = new TextBox();
            LastName = new TextBox();
            Suffix = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(112, 9);
            label1.Name = "label1";
            label1.Size = new Size(206, 23);
            label1.TabIndex = 0;
            label1.Text = "Simple form application";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(75, 70);
            label2.Name = "label2";
            label2.Size = new Size(97, 23);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(75, 136);
            label3.Name = "label3";
            label3.Size = new Size(119, 23);
            label3.TabIndex = 2;
            label3.Text = "Middle Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(75, 208);
            label4.Name = "label4";
            label4.Size = new Size(94, 23);
            label4.TabIndex = 3;
            label4.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(75, 272);
            label5.Name = "label5";
            label5.Size = new Size(58, 23);
            label5.TabIndex = 4;
            label5.Text = "Suffix";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(75, 346);
            button1.Name = "button1";
            button1.Size = new Size(258, 52);
            button1.TabIndex = 5;
            button1.Text = " Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FirstName
            // 
            FirstName.Location = new Point(75, 96);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(258, 27);
            FirstName.TabIndex = 6;
            // 
            // MiddleName
            // 
            MiddleName.Location = new Point(75, 162);
            MiddleName.Name = "MiddleName";
            MiddleName.Size = new Size(258, 27);
            MiddleName.TabIndex = 7;
            // 
            // LastName
            // 
            LastName.Location = new Point(75, 234);
            LastName.Name = "LastName";
            LastName.Size = new Size(258, 27);
            LastName.TabIndex = 8;
            // 
            // Suffix
            // 
            Suffix.Location = new Point(75, 298);
            Suffix.Name = "Suffix";
            Suffix.Size = new Size(257, 27);
            Suffix.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(406, 470);
            Controls.Add(Suffix);
            Controls.Add(LastName);
            Controls.Add(MiddleName);
            Controls.Add(FirstName);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
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
        private Label label4;
        private Label label5;
        private Button button1;
        private TextBox FirstName;
        private TextBox MiddleName;
        private TextBox LastName;
        private TextBox Suffix;
    }
}
