using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstWindowProgram
{
    public partial class Form1 : Form
    {
        private int Str = 0;
        private int Abi = 0;
        private int Dex = 0;

        public Form1()
        {
            InitializeComponent();

            lblStr.Text = Str.ToString();
            lblAbi.Text = Abi.ToString();
            lblDex.Text = Dex.ToString();
        }

        private void brnStr_Click(object sender, EventArgs e)
        {
            Str++;
            lblStr.Text = Str.ToString();
        }

        private void btnAbi_Click(object sender, EventArgs e)
        {
            Abi++;
            lblAbi.Text = Abi.ToString();
        }

        private void btnDex_Click(object sender, EventArgs e)
        {
            Dex++;
            lblDex.Text = Dex.ToString();
        }

    }
}
