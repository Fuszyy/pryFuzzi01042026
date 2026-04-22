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
            if (txtName.Text != "")
            {
                txtCode.Enabled = true;
            }
            else
            {
                txtCode.Clear();
                txtCode.Enabled = false;    
            }
        }

        private void txtCode_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            if (txtDesc.Text != "")
            {
                txtPrice.Enabled = true;
            }
            else
            {
                txtPrice.Clear();
                txtPrice.Enabled = false;
            }
        }

        private void txtPrice_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void txtStock_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        //de interfaz
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtName.Text == "")
            {
                MessageBox.Show("Complete el nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtCode.Text == "")
                {
                    MessageBox.Show("Complete el código.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtDesc.Text == "")
                    {
                        MessageBox.Show("Complete la descripción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (txtPrice.Text == "")
                        {
                            MessageBox.Show("Complete el precio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (txtStock.Text == "")
                            {
                                MessageBox.Show("Complete el stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                if (cbxCateg.Text == "")
                                {
                                    MessageBox.Show("Complete la categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    varPrice = int.Parse(txtPrice.Text);
                                    varStock = int.Parse(txtStock.Text);
                                    varCode = txtCode.Text;
                                    varName = txtName.Text;
                                    varDesc = txtDesc.Text;
                                    varCategory = cbxCateg.Text;

                                    MessageBox.Show("Datos cargados correctamente.", "Operación exitosa.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    txtName.Text = string.Empty;
                                    txtCode.Text = string.Empty;
                                    txtDesc.Text = string.Empty;
                                    txtStock.Text = string.Empty;
                                    txtPrice.Text = string.Empty;
                                    cbxCateg.Text = string.Empty;
                                    cbxCateg.SelectedItem = null;

                                    dgvData.Rows.Add(varName, varCode, varDesc, varPrice, varStock, varCategory);

                                    txtCode.Enabled = false;
                                    txtDesc.Enabled = false;
                                    txtStock.Enabled = false;
                                    txtPrice.Enabled = false;
                                    cbxCateg.Enabled = false;
                                }
                            }
                        }
                    }
                }
            }
        }
            

        private void gpbMain_Enter(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {

        }

        private void cbxCateg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void lblDebug_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {            
            dgvData.Rows.Remove(dgvData.CurrentRow);
            MessageBox.Show("Datos eliminados exitosamente.", "Proceso Finalizado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            if (txtCode.Text != "")
            {
                txtDesc.Enabled = true;
            }
            else
            {
                txtDesc.Clear();
                txtDesc.Enabled = false;
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtPrice.Text != "")
            {
                txtStock.Enabled = true;
            }
            else
            {
                txtStock.Clear();
                txtStock.Enabled = false;
            }
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {
            if (txtStock.Text != "")
            {
                cbxCateg.Enabled = true;
            }
            else
            {
                cbxCateg.SelectedItem = null;
                cbxCateg.Enabled = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBox.Show("¿Editar los datos de este contacto?", "Editar contacto.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result2 == DialogResult.Yes)
            {
                if (dgvData.CurrentRow == null)
                {
                    MessageBox.Show("No hay un producto seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtName.Text == "" || txtCode.Text == "" || txtDesc.Text == "" || txtPrice.Text == "" || cbxCateg.Text == "")
                    {
                        MessageBox.Show("Complete los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dgvData.CurrentRow.Cells[0].Value = txtName.Text;
                        dgvData.CurrentRow.Cells[1].Value = txtCode.Text;
                        dgvData.CurrentRow.Cells[2].Value = txtDesc.Text;
                        dgvData.CurrentRow.Cells[3].Value = txtPrice.Text;
                        dgvData.CurrentRow.Cells[4].Value = txtStock.Text;
                        dgvData.CurrentRow.Cells[5].Value = cbxCateg.Text;
                        MessageBox.Show("Producto editado correctamente.", "Proceso finalizado.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtName.Text = string.Empty;
                        txtCode.Text = string.Empty;
                        txtDesc.Text = string.Empty;
                        txtPrice.Text = string.Empty;
                        txtStock.Text = string.Empty;
                        cbxCateg.SelectedItem = null;

                        txtCode.Enabled = false;
                        txtDesc.Enabled = false;
                        txtPrice.Enabled = false;
                        txtStock.Enabled = false;
                        cbxCateg.Enabled = false;
                    }

                }
            }
        }
    }
}
