namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string txtmotherlastnamre;
        string txtLastName;
        string txtname;



        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtname = txtbox1.Text;


        }

        private void txtbox2_TextChanged(object sender, EventArgs e)
        {
            txtLastName = txtbox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            txtmotherlastnamre = txtbox3.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {

            if (txtbox1 != null && txtbox1 != null && txtbox1 != null)
            {
                NamePerson n1 = new NamePerson(txtbox1.Text, txtbox2.Text, txtbox3.Text);
                textBox1.Text = n1.Name;


                Person n2 = new Person(n1, dt1);

                estudient n3 = new estudient(n1, dt1, txtbox4.Text, txtbox5.Text, Convert.ToInt32(nup));

            }




        }
    }
}