namespace pryFuzzi01042026
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.gpbMain = new System.Windows.Forms.GroupBox();
            this.lblDebug = new System.Windows.Forms.Label();
            this.lblRegistroDebug = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbxCateg = new System.Windows.Forms.ComboBox();
            this.txtStock = new System.Windows.Forms.MaskedTextBox();
            this.txtPrice = new System.Windows.Forms.MaskedTextBox();
            this.txtCode = new System.Windows.Forms.MaskedTextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbMain
            // 
            this.gpbMain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gpbMain.Controls.Add(this.lblDebug);
            this.gpbMain.Controls.Add(this.lblRegistroDebug);
            this.gpbMain.Controls.Add(this.lblTitle);
            this.gpbMain.Controls.Add(this.btnDelete);
            this.gpbMain.Controls.Add(this.btnAdd);
            this.gpbMain.Controls.Add(this.txtDesc);
            this.gpbMain.Controls.Add(this.txtName);
            this.gpbMain.Controls.Add(this.cbxCateg);
            this.gpbMain.Controls.Add(this.txtStock);
            this.gpbMain.Controls.Add(this.txtPrice);
            this.gpbMain.Controls.Add(this.txtCode);
            this.gpbMain.Controls.Add(this.lblCategory);
            this.gpbMain.Controls.Add(this.lblStock);
            this.gpbMain.Controls.Add(this.lblPrice);
            this.gpbMain.Controls.Add(this.lblDesc);
            this.gpbMain.Controls.Add(this.lblCode);
            this.gpbMain.Controls.Add(this.lblName);
            this.gpbMain.Location = new System.Drawing.Point(57, 12);
            this.gpbMain.Name = "gpbMain";
            this.gpbMain.Size = new System.Drawing.Size(680, 289);
            this.gpbMain.TabIndex = 0;
            this.gpbMain.TabStop = false;
            this.gpbMain.Enter += new System.EventHandler(this.gpbMain_Enter);
            // 
            // lblDebug
            // 
            this.lblDebug.AutoSize = true;
            this.lblDebug.Location = new System.Drawing.Point(416, 216);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(125, 13);
            this.lblDebug.TabIndex = 12;
            this.lblDebug.Text = " TEXTO DE EJEMPLO 2";
            // 
            // lblRegistroDebug
            // 
            this.lblRegistroDebug.AutoSize = true;
            this.lblRegistroDebug.Location = new System.Drawing.Point(416, 194);
            this.lblRegistroDebug.Name = "lblRegistroDebug";
            this.lblRegistroDebug.Size = new System.Drawing.Size(116, 13);
            this.lblRegistroDebug.TabIndex = 11;
            this.lblRegistroDebug.Text = " TEXTO DE EJEMPLO";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(189, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(293, 31);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Gestión de Inventario";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(581, 255);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(500, 255);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Agregar..";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Enabled = false;
            this.txtDesc.Location = new System.Drawing.Point(158, 170);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(191, 84);
            this.txtDesc.TabIndex = 3;
            this.txtDesc.TextChanged += new System.EventHandler(this.txtDesc_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(158, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(129, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // cbxCateg
            // 
            this.cbxCateg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCateg.Enabled = false;
            this.cbxCateg.FormattingEnabled = true;
            this.cbxCateg.Items.AddRange(new object[] {
            "Alimentos",
            "Limpieza",
            "Herramientas",
            "Higiene",
            "Juguetes",
            "Cocina",
            "Electrónicos",
            "Vestimenta",
            "Otros"});
            this.cbxCateg.Location = new System.Drawing.Point(418, 170);
            this.cbxCateg.Name = "cbxCateg";
            this.cbxCateg.Size = new System.Drawing.Size(137, 21);
            this.cbxCateg.TabIndex = 6;
            this.cbxCateg.SelectedIndexChanged += new System.EventHandler(this.cbxCateg_SelectedIndexChanged);
            // 
            // txtStock
            // 
            this.txtStock.Enabled = false;
            this.txtStock.Location = new System.Drawing.Point(418, 117);
            this.txtStock.Mask = "99999";
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(65, 20);
            this.txtStock.TabIndex = 5;
            this.txtStock.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtStock_MaskInputRejected);
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(418, 63);
            this.txtPrice.Mask = "99999";
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(65, 20);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtPrice_MaskInputRejected);
            // 
            // txtCode
            // 
            this.txtCode.Enabled = false;
            this.txtCode.Location = new System.Drawing.Point(158, 117);
            this.txtCode.Mask = "99999";
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(71, 20);
            this.txtCode.TabIndex = 2;
            this.txtCode.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCode_MaskInputRejected);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(355, 173);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(57, 13);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "Categoría:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(360, 120);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(52, 13);
            this.lblStock.TabIndex = 4;
            this.lblStock.Text = "Cantidad:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(372, 66);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 13);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Precio:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(86, 173);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(66, 13);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Descripción:";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(109, 120);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(43, 13);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "Código:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(105, 66);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre:";
            // 
            // dgvData
            // 
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnName,
            this.ColumnCode,
            this.ColumnDescription,
            this.ColumnPrice,
            this.ColumnStock,
            this.ColumnCategory});
            this.dgvData.Location = new System.Drawing.Point(83, 318);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(630, 167);
            this.dgvData.TabIndex = 1;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // columnName
            // 
            this.columnName.HeaderText = "Nombre del Producto";
            this.columnName.Name = "columnName";
            // 
            // ColumnCode
            // 
            this.ColumnCode.HeaderText = "Código";
            this.ColumnCode.Name = "ColumnCode";
            // 
            // ColumnDescription
            // 
            this.ColumnDescription.HeaderText = "Descripción";
            this.ColumnDescription.Name = "ColumnDescription";
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.HeaderText = "Precio";
            this.ColumnPrice.Name = "ColumnPrice";
            // 
            // ColumnStock
            // 
            this.ColumnStock.HeaderText = "Stock o cantidad";
            this.ColumnStock.Name = "ColumnStock";
            // 
            // ColumnCategory
            // 
            this.ColumnCategory.HeaderText = "Categoría";
            this.ColumnCategory.Name = "ColumnCategory";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::pryFuzzi01042026.Properties.Resources.GettyImages_142227958_optimized;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.gpbMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Inventario";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gpbMain.ResumeLayout(false);
            this.gpbMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbMain;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.MaskedTextBox txtPrice;
        private System.Windows.Forms.MaskedTextBox txtCode;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbxCateg;
        private System.Windows.Forms.MaskedTextBox txtStock;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRegistroDebug;
        private System.Windows.Forms.Label lblDebug;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategory;
    }
}

