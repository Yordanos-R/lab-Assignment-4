using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            c.save();
            MessageBox.Show("Student successfully added!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
