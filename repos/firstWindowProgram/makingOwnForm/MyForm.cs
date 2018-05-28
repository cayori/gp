using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace makingOwnForm
{
    class MyForm : Form
    {
        public MyForm()
        {
            this.Visible = true;
        }

        protected override void OnClick(EventArgs e)
        {
            MessageBox.Show("안뇽?");
        }
    }
}
