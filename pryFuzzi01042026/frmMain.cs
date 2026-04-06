using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryFuzzi01042026
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtCode.Enabled = true;
        }

        private void txtCode_MaskInputRejected(object sender,MaskInputRejectedEventArgs e)
        {
            txtDesc.Enabled = true;
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            txtPrice.Enabled = true;
        }

        private void txtPrice_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            txtStock.Enabled = true;
        }

        private void txtStock_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            cbxCateg.Enabled = true;
        }
    }
}
