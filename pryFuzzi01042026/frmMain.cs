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
      
       //declaración de variables globales 
        
        
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblRegistroDebug.Text = txtName.Text + " " + txtCode.Text + " " + txtPrice.Text + " " + txtStock.Text + " " + txtDesc.Text;
        }

        private void gpbMain_Enter(object sender, EventArgs e)
        {

        }
    }
}
