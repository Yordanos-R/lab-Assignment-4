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
    public partial class ProductCard : UserControl
    {
        private string _First;

        public string First
        {
            get { return _First; }
            set { _First = value; label1.Text = value; }
        }
        private string _Middle;

        public string Middle
        {
            get { return _Middle; }
            set { _Middle = value; label2.Text = value; }
        }
        private string _Last;

        public string Last
        {
            get { return _Last; }
            set { _Last = value; label3.Text = value; }
        }

        public ProductCard()
        {
            InitializeComponent();
        }

        private void ProductCard_Load(object sender, EventArgs e)
        {

        }
    }
}
