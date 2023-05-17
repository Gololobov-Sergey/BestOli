using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOli
{
    public partial class Form_changes : Form
    {
        public decimal Price
        {
            get { return Convert.ToDecimal(tBox_price.Text); }
            set { tBox_price.Text = value.ToString(); }
        }

        public string Name
        {
            get { return tBox_Name.Text; }
            set { tBox_Name.Text = value; }
        }
        public Form_changes()
        {
            InitializeComponent();
            tBox_Name.Text = Name;
            tBox_price.Text = Price.ToString();
        }
    }
}
