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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           var result = Class1.findOne(textBox1.Text);
            if (result == null)
                MessageBox.Show("Not found");
            else
                MessageBox.Show("Found");
        }
    }
}
