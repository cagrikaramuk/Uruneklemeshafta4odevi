namespace hafta4odevi
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
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            button3 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(273, 156);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ekleme";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(119, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(136, 23);
            textBox1.TabIndex = 13;
            // 
            // button3
            // 
            button3.Location = new Point(180, 120);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 12;
            button3.Text = "Aktar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(119, 91);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(136, 23);
            textBox3.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 94);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 7;
            label3.Text = "Urun Ismi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 65);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 6;
            label2.Text = "Urun Numarasi";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(119, 62);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(136, 23);
            textBox2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 3;
            label1.Text = "Envanter Numarasi";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(listBox1);
            groupBox2.Location = new Point(291, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(344, 357);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Arama";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 19);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 13;
            label5.Text = "Envanter Numarasi";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(219, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(6, 66);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(331, 199);
            listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(643, 374);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private TextBox textBox3;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private Button button3;
        private Label label5;
        private TextBox textBox1;
    }
}
