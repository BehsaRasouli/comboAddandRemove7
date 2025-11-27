namespace comboAddandRemove
{
    public partial class Form1 : Form
    {
        int a = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("item" + a);
            a += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int r= comboBox1.SelectedIndex;
            comboBox1.Items.RemoveAt(r);
        }
    }
}
