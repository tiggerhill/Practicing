using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicing
{
    public partial class frmCupSwapping : Form
    {
        public frmCupSwapping()
        {
            InitializeComponent();
        }

        private void btnCodeCups_Click(object sender, EventArgs e)
        {
            frmCodeCups frm = new frmCodeCups();
            frm.ShowDialog();
        }
    }
}
