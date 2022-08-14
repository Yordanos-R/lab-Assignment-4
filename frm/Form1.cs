using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace frm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 c = new Class1();
            c.fName = txtName.Text;
            c.lName = txtMName.Text;
            c.lName = txtLName.Text;
            c.phone = txtPhone.Text;
            Regex r = new Regex(@"^[a-z]+-@-[a-z]+-.[a-z]{3}$");
            if (r.IsMatch(txtEmail.Text))
            {
                //c.save();
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(txtEmail, "Invalid input");
                //MessageBox.Show("Invalid input");
            }
            // c.save();
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Name is required!");
            }
            else if (string.IsNullOrEmpty(txtLName.Text))
            {
                MessageBox.Show("Last name is required!");
            }

                try
                {
                    int a = int.Parse(txtPhone.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("INVALID INPUT");
                }

                       c.save();
                       dataGridView2.DataSource = null;
                       dataGridView2.DataSource = Class1.getall();


            //MessageBox.Show("Student successfully added!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
