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
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = Class1.getall();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        try{
               Class1 c = new Class1
                    {
                        fName = txtName.Text,
                        mName = txtMName.Text,
                        lName = txtLName.Text,
                        dob = dateTimePicker2.Text,
                        dor = dateTimePicker1.Text,
                        phone = txtPhone.Text,
                        email = txtEmail.Text
                    };
                    c.save();
                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = Class1.getall();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}

