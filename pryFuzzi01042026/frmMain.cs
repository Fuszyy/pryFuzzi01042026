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

        string varCode = "";
        string varName = "";
        string varDesc = "";
        int varStock = 0;
        int varPrice = 0;
        string varCategory = "";



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

        //de interfaz
        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblRegistroDebug.Text = txtName.Text + " " + txtCode.Text + " " + txtPrice.Text + " " + txtStock.Text + " " + txtDesc.Text;
            varCode = txtCode.Text;
            varName = txtName.Text;
            varDesc = txtDesc.Text;
            varPrice = Convert.ToInt16(txtPrice.Text);
            varStock = int.Parse(txtStock.Text);
            varCategory = cbxCateg.Text;

            lblDebug.Text = varCode + " " + varName + " " + varDesc + " " + varPrice + " " + varStock + " " + varCategory;
            string MsgBox = varCode + " " + varName + " " + varDesc + " " + varPrice + " " + varStock + " " + varCategory;
            MessageBox.Show(MsgBox);

            txtName.Text = string.Empty;
            txtCode.Text = string.Empty;
            txtDesc.Text = string.Empty;
            txtStock.Text = string.Empty;
            txtPrice.Text = string.Empty;
            cbxCateg.Text = string.Empty;
        }

        private void gpbMain_Enter(object sender, EventArgs e)
        {

        }
    }
}
