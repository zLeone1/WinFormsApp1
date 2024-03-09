using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string txtmotherlastnamre;
        string txtLastName;
        string txtname;

        int grade;

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
                while (true)
                {
                    try
                    {
                        grade = Convert.ToInt32(nup.Value);
                        break;
                    }

                    catch (FormatException)
                    {
                        txtbox.Text = "Please enter a right Grade";
                    }
                }


                NamePerson n1 = new NamePerson(txtbox1.Text, txtbox2.Text, txtbox3.Text);


                DateTime dt = dt1.Value;

                estudient n3 = new estudient(txtbox1.Text, txtbox2.Text, txtbox3.Text, dt, txtbox4.Text, txtbox5.Text, grade);

                txtbox.Text = Convert.ToString(n3.Birthdate);
                txtbox.Text = Convert.ToString(n3.Grade);

                txtbox.Text = n3.ToString();
            }




        }



        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dt1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnd_Click(object sender, EventArgs e)
        {
            
          txtbox1.Clear();
        txtbox2.Clear();
        txtbox3.Clear();
         txtbox4.Clear();
            txtbox5.Clear();
         txtbox.Clear();
            nup.Value = 0;
    }
    }
}