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
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }

        private void Display_Load(object sender, EventArgs e)
        {
            foreach(var item in Class1.getall())
            {
                ProductCard p = new ProductCard();
                p.First = item.fName;
                p.Middle = item.mName;
                p.Last = item.lName;
                p.Click += (object o, EventArgs e2) =>
                {
                    DetailsPage d = new DetailsPage(item.dob, item.dor, item.phone);
                    d.Show();
                };
                flowLayoutPanel1.Controls.Add(p);
            }
            
        }
    }
}
