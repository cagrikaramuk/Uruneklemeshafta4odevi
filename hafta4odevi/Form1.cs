namespace hafta4odevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> listenvanter = new List<string>();
        List<string> listno = new List<string>();
        List<string> listurun = new List<string>();


        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                listenvanter.Add(textBox1.Text);
                listno.Add(textBox2.Text);
                listurun.Add(textBox3.Text);
                if (comboBox1.Items.Contains(textBox1.Text))
                {

                }
                else
                {
                    comboBox1.Items.Add(textBox1.Text);
                }
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i<listenvanter.Count; i++)
                       {
                if (comboBox1.SelectedItem.ToString() == listenvanter[i])
                {
                    listBox1.Items.Add(listno[i] + " " + listurun[i]);
                }
            }
        }
    }
}
