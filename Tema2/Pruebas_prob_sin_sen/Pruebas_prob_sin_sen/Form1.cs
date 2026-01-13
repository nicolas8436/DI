namespace Pruebas_prob_sin_sen
{
    public partial class Form1 : Form
    {
        public List<String> listaCosas;
        public Form1()
        {
            InitializeComponent();
            listaCosas = new List<String>();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            Form2 f2 = new Form2(textBox1.Text);

            f2.Show();//No modal

            //f2.ShowDialog();//Modal
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(this);
            f3.Show();
            this.Hide();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listaCosas.Add(textBox1.Text);

            listBox1.DataSource = null;
            comboBox1.DataSource = null;

            listBox1.DataSource = listaCosas;
            comboBox1.DataSource = listaCosas;



        }



    }
}
