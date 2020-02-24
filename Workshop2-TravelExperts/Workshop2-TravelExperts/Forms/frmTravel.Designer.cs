namespace Workshop2_TravelExperts {
    partial class FrmTravel {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTravel));
            this.cmbPackages = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPackID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCommision = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddingProd = new System.Windows.Forms.Button();
            this.btnAddSup = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPackages = new System.Windows.Forms.TabPage();
            this.TabSupp = new System.Windows.Forms.TabPage();
            this.dgvProds = new System.Windows.Forms.DataGridView();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.btnAddProdtoSup = new System.Windows.Forms.Button();
            this.lblProduct = new System.Windows.Forms.Label();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.txtSuppliers = new System.Windows.Forms.Label();
            this.cboSuppliers = new System.Windows.Forms.ComboBox();
            this.tabMain.SuspendLayout();
            this.tabPackages.SuspendLayout();
            this.TabSupp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProds)).BeginInit();
            this.pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbPackages
            // 
            this.cmbPackages.BackColor = System.Drawing.Color.Black;
            this.cmbPackages.ForeColor = System.Drawing.SystemColors.Window;
            this.cmbPackages.FormattingEnabled = true;
            this.cmbPackages.Location = new System.Drawing.Point(184, 6);
            this.cmbPackages.Name = "cmbPackages";
            this.cmbPackages.Size = new System.Drawing.Size(323, 32);
            this.cmbPackages.TabIndex = 0;
            this.cmbPackages.SelectedValueChanged += new System.EventHandler(this.cmbPackages_SelectedValueChanged_1);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Package Name: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(46, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Package ID: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPackID
            // 
            this.lblPackID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPackID.Location = new System.Drawing.Point(185, 59);
            this.lblPackID.Name = "lblPackID";
            this.lblPackID.Size = new System.Drawing.Size(192, 24);
            this.lblPackID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(52, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Start Date: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(60, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "End Date: ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(37, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "Description: ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDesc
            // 
            this.lblDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDesc.Location = new System.Drawing.Point(185, 281);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(469, 58);
            this.lblDesc.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(48, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 24);
            this.label10.TabIndex = 11;
            this.label10.Text = "Base Price: ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPrice.Location = new System.Drawing.Point(184, 198);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(193, 24);
            this.lblPrice.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(43, 243);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 24);
            this.label12.TabIndex = 13;
            this.label12.Text = "Commision: ";
            // 
            // lblCommision
            // 
            this.lblCommision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCommision.Location = new System.Drawing.Point(184, 243);
            this.lblCommision.Name = "lblCommision";
            this.lblCommision.Size = new System.Drawing.Size(193, 24);
            this.lblCommision.TabIndex = 14;
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.DimGray;
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Location = new System.Drawing.Point(401, 140);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(251, 33);
            this.btnAddNew.TabIndex = 15;
            this.btnAddNew.Text = "Add &New Package";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DimGray;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(401, 59);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(253, 33);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "&Edit Package";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.DimGray;
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Location = new System.Drawing.Point(405, 411);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(253, 30);
            this.btnQuit.TabIndex = 17;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // dtpStart
            // 
            this.dtpStart.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtpStart.CalendarMonthBackground = System.Drawing.SystemColors.MenuText;
            this.dtpStart.Enabled = false;
            this.dtpStart.Location = new System.Drawing.Point(518, 3);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(18, 32);
            this.dtpStart.TabIndex = 17;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Enabled = false;
            this.dtpEnd.Location = new System.Drawing.Point(542, 3);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(20, 32);
            this.dtpEnd.TabIndex = 18;
            // 
            // lblStart
            // 
            this.lblStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStart.Location = new System.Drawing.Point(185, 102);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(192, 24);
            this.lblStart.TabIndex = 19;
            // 
            // lblEnd
            // 
            this.lblEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEnd.Location = new System.Drawing.Point(185, 149);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(192, 24);
            this.lblEnd.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(401, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 33);
            this.button1.TabIndex = 21;
            this.button1.Text = "&Add Product to Package";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddingProd
            // 
            this.btnAddingProd.BackColor = System.Drawing.Color.DimGray;
            this.btnAddingProd.Location = new System.Drawing.Point(401, 65);
            this.btnAddingProd.Name = "btnAddingProd";
            this.btnAddingProd.Size = new System.Drawing.Size(251, 35);
            this.btnAddingProd.TabIndex = 22;
            this.btnAddingProd.Text = "Adding New &Product";
            this.btnAddingProd.UseVisualStyleBackColor = false;
            this.btnAddingProd.Click += new System.EventHandler(this.btnAddingProd_Click_1);
            // 
            // btnAddSup
            // 
            this.btnAddSup.BackColor = System.Drawing.Color.DimGray;
            this.btnAddSup.Location = new System.Drawing.Point(401, 15);
            this.btnAddSup.Name = "btnAddSup";
            this.btnAddSup.Size = new System.Drawing.Size(253, 35);
            this.btnAddSup.TabIndex = 23;
            this.btnAddSup.Text = "Add &Suppliers";
            this.btnAddSup.UseVisualStyleBackColor = false;
            this.btnAddSup.Click += new System.EventHandler(this.btnAddSup_Click_1);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPackages);
            this.tabMain.Controls.Add(this.TabSupp);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(674, 394);
            this.tabMain.TabIndex = 24;
            // 
            // tabPackages
            // 
            this.tabPackages.BackgroundImage = global::Workshop2_TravelExperts.Properties.Resources.Background;
            this.tabPackages.Controls.Add(this.button1);
            this.tabPackages.Controls.Add(this.lblDesc);
            this.tabPackages.Controls.Add(this.cmbPackages);
            this.tabPackages.Controls.Add(this.dtpEnd);
            this.tabPackages.Controls.Add(this.label6);
            this.tabPackages.Controls.Add(this.label8);
            this.tabPackages.Controls.Add(this.label4);
            this.tabPackages.Controls.Add(this.dtpStart);
            this.tabPackages.Controls.Add(this.lblCommision);
            this.tabPackages.Controls.Add(this.lblStart);
            this.tabPackages.Controls.Add(this.label1);
            this.tabPackages.Controls.Add(this.label10);
            this.tabPackages.Controls.Add(this.label12);
            this.tabPackages.Controls.Add(this.lblPackID);
            this.tabPackages.Controls.Add(this.btnEdit);
            this.tabPackages.Controls.Add(this.btnAddNew);
            this.tabPackages.Controls.Add(this.lblEnd);
            this.tabPackages.Controls.Add(this.label2);
            this.tabPackages.Controls.Add(this.lblPrice);
            this.tabPackages.ForeColor = System.Drawing.Color.Transparent;
            this.tabPackages.Location = new System.Drawing.Point(4, 33);
            this.tabPackages.Name = "tabPackages";
            this.tabPackages.Padding = new System.Windows.Forms.Padding(3);
            this.tabPackages.Size = new System.Drawing.Size(666, 357);
            this.tabPackages.TabIndex = 0;
            this.tabPackages.Text = "Packages";
            this.tabPackages.UseVisualStyleBackColor = true;
            // 
            // TabSupp
            // 
            this.TabSupp.BackgroundImage = global::Workshop2_TravelExperts.Properties.Resources.Background;
            this.TabSupp.Controls.Add(this.dgvProds);
            this.TabSupp.Controls.Add(this.pnl1);
            this.TabSupp.Controls.Add(this.btnAddSup);
            this.TabSupp.Controls.Add(this.btnAddingProd);
            this.TabSupp.ForeColor = System.Drawing.Color.Transparent;
            this.TabSupp.Location = new System.Drawing.Point(4, 33);
            this.TabSupp.Name = "TabSupp";
            this.TabSupp.Padding = new System.Windows.Forms.Padding(3);
            this.TabSupp.Size = new System.Drawing.Size(666, 357);
            this.TabSupp.TabIndex = 1;
            this.TabSupp.Text = "Suppliers";
            this.TabSupp.UseVisualStyleBackColor = true;
            // 
            // dgvProds
            // 
            this.dgvProds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProds.Location = new System.Drawing.Point(8, 198);
            this.dgvProds.Name = "dgvProds";
            this.dgvProds.RowHeadersWidth = 51;
            this.dgvProds.RowTemplate.Height = 24;
            this.dgvProds.Size = new System.Drawing.Size(383, 153);
            this.dgvProds.TabIndex = 31;
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.btnAddProdtoSup);
            this.pnl1.Controls.Add(this.lblProduct);
            this.pnl1.Controls.Add(this.cmbProducts);
            this.pnl1.Controls.Add(this.txtSuppliers);
            this.pnl1.Controls.Add(this.cboSuppliers);
            this.pnl1.Location = new System.Drawing.Point(8, 6);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(383, 186);
            this.pnl1.TabIndex = 26;
            // 
            // btnAddProdtoSup
            // 
            this.btnAddProdtoSup.BackColor = System.Drawing.Color.DimGray;
            this.btnAddProdtoSup.ForeColor = System.Drawing.Color.White;
            this.btnAddProdtoSup.Location = new System.Drawing.Point(118, 137);
            this.btnAddProdtoSup.Name = "btnAddProdtoSup";
            this.btnAddProdtoSup.Size = new System.Drawing.Size(251, 30);
            this.btnAddProdtoSup.TabIndex = 25;
            this.btnAddProdtoSup.Text = "Add &Product to Supplier";
            this.btnAddProdtoSup.UseVisualStyleBackColor = false;
            // 
            // lblProduct
            // 
            this.lblProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblProduct.Location = new System.Drawing.Point(3, 80);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(149, 31);
            this.lblProduct.TabIndex = 26;
            this.lblProduct.Text = "Product: ";
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbProducts
            // 
            this.cmbProducts.BackColor = System.Drawing.Color.Black;
            this.cmbProducts.ForeColor = System.Drawing.SystemColors.Window;
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(158, 79);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(211, 32);
            this.cmbProducts.TabIndex = 25;
            // 
            // txtSuppliers
            // 
            this.txtSuppliers.BackColor = System.Drawing.Color.Transparent;
            this.txtSuppliers.Location = new System.Drawing.Point(3, 24);
            this.txtSuppliers.Name = "txtSuppliers";
            this.txtSuppliers.Size = new System.Drawing.Size(149, 31);
            this.txtSuppliers.TabIndex = 25;
            this.txtSuppliers.Text = "Suppliers:  ";
            this.txtSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboSuppliers
            // 
            this.cboSuppliers.BackColor = System.Drawing.Color.Black;
            this.cboSuppliers.ForeColor = System.Drawing.SystemColors.Window;
            this.cboSuppliers.FormattingEnabled = true;
            this.cboSuppliers.Location = new System.Drawing.Point(158, 24);
            this.cboSuppliers.Name = "cboSuppliers";
            this.cboSuppliers.Size = new System.Drawing.Size(211, 32);
            this.cboSuppliers.TabIndex = 24;
            this.cboSuppliers.SelectedValueChanged += new System.EventHandler(this.cboSuppliers_SelectedValueChanged);
            // 
            // FrmTravel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Workshop2_TravelExperts.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 453);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.btnQuit);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmTravel";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Travel Experts";
            this.Load += new System.EventHandler(this.FrmTravel_Load);
            this.tabMain.ResumeLayout(false);
            this.tabPackages.ResumeLayout(false);
            this.tabPackages.PerformLayout();
            this.TabSupp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProds)).EndInit();
            this.pnl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPackages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPackID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCommision;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnEdit;

        private System.Windows.Forms.Button btnQuit;

        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddingProd;
        private System.Windows.Forms.Button btnAddSup;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPackages;
        private System.Windows.Forms.TabPage TabSupp;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.ComboBox cboSuppliers;
        private System.Windows.Forms.Label txtSuppliers;
        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Button btnAddProdtoSup;
        private System.Windows.Forms.DataGridView dgvProds;
    }
}

