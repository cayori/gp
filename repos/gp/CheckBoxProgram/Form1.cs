using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckThis(object sender, EventArgs e)
        {
            CheckBox chBox = (CheckBox)sender;
            txtChecked.Text = chBox.Checked ? "True" : "False";

            switch (chBox.CheckState)
            {
                case CheckState.Checked:
                    txtCheckState.Text = "Checked";
                    break;
                case CheckState.Unchecked:
                    txtCheckState.Text = "UnChecked";
                    break;
                case CheckState.Indeterminate:
                    txtCheckState.Text = "Indeterminate";
                    break;
            }
        }

        private void checkBox1_MouseEnter(object sender, EventArgs e)
        {
            CheckThis(sender, e);
        }

        private void checkBox2_MouseEnter(object sender, EventArgs e)
        {
            CheckThis(sender, e);
        }
        private void checkBox3_MouseEnter(object sender, EventArgs e)
        {
            CheckThis(sender, e);
        }
        private void checkBox3_Click(object sender, EventArgs e)
        {
            CheckThis(sender, e);
        }
        private void checkBox2_Click(object sender, EventArgs e)
        {
            CheckThis(sender, e);
        }
        private void checkBox1_Click(object sender, EventArgs e)
        {
            CheckThis(sender, e);
        }
    }
}
