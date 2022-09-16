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
    public partial class DetailsPage : Form
    {
        public DetailsPage(string dob, string dor, string phone )
        {
            InitializeComponent();
            label1.Text = dob;
            label2.Text = dor;
            label3.Text = phone;
        }
    }
}
