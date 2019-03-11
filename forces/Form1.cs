using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            return (Math.Sin(x * Math.PI / 180.0));
        }
        Double asin(double x)
        {
            return (Math.Asin(x * 180.0 /Math.PI));
        }
        Double cos(double x)
        {
            return (Math.Cos(x * Math.PI / 180.0));
        }
        Double acos(double x)
        {
            return (Math.acos(x) * 180.0 / Math.PI);
        }
    }

}
 {