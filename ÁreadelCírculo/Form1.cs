using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÁreadelCírculo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double radio,area;
            area = double.Parse(txtradio.Text) *double.Parse(txtradio.Text) * Math.PI;
            lblresultado.Text = Convert.ToString(area);
            label3.Visible = true;
            lblresultado.Visible = true;
            btnborrar.Visible = true;
            txtradio.Focus();

        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtradio.Text = String.Empty;
            lblresultado.Text = String.Empty;
            txtradio.Focus();
        }
    }
}
