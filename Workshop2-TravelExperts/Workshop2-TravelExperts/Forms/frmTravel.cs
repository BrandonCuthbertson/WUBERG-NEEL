﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workshop2_TravelExperts.Database_Objects;

namespace Workshop2_TravelExperts
{
    /// Program Jobs: 
    ///     Neel:
    ///         -Add/Edit Packages
    ///         -Adding Products,Suppliers
    ///  Brandon:
    ///         -Validation
    ///         -Gui layout
    ///    Sarah:
    ///         -Database Integration
    public partial class FrmTravel : Form
    {
        List<Packages> packages;
        List<Suppliers> suppliers;
        List<Products> products;
        public Packages Package;


        public FrmTravel()
        {
            InitializeComponent();
        }
        private void FrmTravel_Load(object sender, EventArgs e)
        {
            SQLAdapter.SQLAdapter.GetFromDB(out packages, new TravelExpertsDBCon());
            SQLAdapter.SQLAdapter.GetFromDB(out suppliers, new TravelExpertsDBCon());
            SQLAdapter.SQLAdapter.GetFromDB(out products, new TravelExpertsDBCon());
            this.LoadComboBox();
            dtpEnd.Visible = false;
            dtpStart.Visible = false;
            string querier = "Select Products_Suppliers.ProductSupplierId, Suppliers.SupName, Products.ProdName " +
                                "From Products_Suppliers, Products, Suppliers " +
                                "where Products_Suppliers.ProductId = Products.ProductId and " +
                                "Products_Suppliers.SupplierId = Suppliers.SupplierId " +
                                "Order by Suppliers.SupName  ";
            SQLAdapter.SQLAdapter.GetFromDB(out List<ProductSupplierProduct> psp, new TravelExpertsDBCon(), querier);
            dgvProds.DataSource = psp;
        }



        private void LoadComboBox()
        {
            try
            {
                cmbPackages.DataSource = packages;
                cmbPackages.DisplayMember = "PkgName";
                cmbPackages.ValueMember = "PackageId";

                cboSuppliers.DataSource = suppliers;
                cboSuppliers.DisplayMember = "SupName";
                cboSuppliers.ValueMember = "SupplierId";
                cmbProducts.DataSource = products;
                cmbProducts.DisplayMember = "ProdName";
                cmbProducts.ValueMember = "ProductId";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString()); ;
            }
        }
        private void DisplayPacks()
        {
            Packages pack = new Packages();
            int packIndex = cmbPackages.SelectedIndex;
            pack = packages[packIndex];
            lblPackID.Text = Convert.ToString(pack.PackageId);
            dtpStart.Value = Convert.ToDateTime(pack.PkgStartDate);
            dtpEnd.Text = Convert.ToString(pack.PkgEndDate);
            lblStart.Text = (pack.PkgStartDate).ToString("MMMM dd, yyyy");
            lblEnd.Text = (pack.PkgEndDate).ToString("MMMM dd, yyyy");
            lblDesc.Text = pack.PkgDesc;
            decimal price = decimal.Round(pack.PkgBasePrice, 2, MidpointRounding.AwayFromZero);//Rounds to the nearest Decimal Value
            lblPrice.Text = price.ToString("c");//Converts to currenct
            decimal Commision = decimal.Round(pack.PkgAgencyCommission, 2, MidpointRounding.AwayFromZero);
            lblCommision.Text = Commision.ToString("c");
        }
        private void DisplaySupplier()
        {
            Suppliers sup = new Suppliers();
            int SupIndex = cboSuppliers.SelectedIndex;

        }
        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            AddPackage addPackageform = new AddPackage();
            // addPackage.addPackage = true;
            DialogResult result = addPackageform.ShowDialog();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Packages pack = packages[cmbPackages.SelectedIndex];
            EditPackage editpackform = new EditPackage(pack);
            DialogResult result = editpackform.ShowDialog();

            editpackform.package = Package;

            if (result == DialogResult.OK)
            {
                Package = editpackform.package;

                //this.DisplayPacks(p);
            }
            else if (result == DialogResult.Retry)
            {
                //this.GetPack(Package.PackageId);
                if (Package != null)
                {
                    this.DisplayPacks();
                }
                else
                {
                    //this.ClearControls();
                }
            }
        }
        private void cmbPackages_SelectedValueChanged(object sender, EventArgs e)
        {//Removed Search Button for a removed index changed
            string val;

            val = Convert.ToString(cmbPackages.SelectedItem);
            if (val != null)
            {
                this.DisplayPacks();
            }
            else
            {
                MessageBox.Show("Error\n Selected Value Error: VALUE NULL", "ERROR");
            }
        }
        private void btnQuit_Click(object sender, EventArgs e)
        {//added by bc
            Close();
        }
        private void cmbPackages_SelectedValueChanged_1(object sender, EventArgs e)
        {
            string val;
            val = Convert.ToString(cmbPackages.SelectedItem);
            if (val != null)
            {
                this.DisplayPacks();
            }
            else
            {
                MessageBox.Show("Error\n Selected Value Error: VALUE NULL", "ERROR");
                // Roll over and crash
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Packages pack = packages[cmbPackages.SelectedIndex];
            ToAddProduct addProduct = new ToAddProduct(pack);
            DialogResult result = addProduct.ShowDialog();

            addProduct.packages = Package;
            if (result == DialogResult.OK)
            {
                Package = addProduct.packages;
                //this.DisplayPacks(p);
            }
            else if (result == DialogResult.Retry)
            {
                //this.GetPack(Package.PackageId);
                if (Package != null)
                {
                    this.DisplayPacks();
                }
                else
                {
                    //this.ClearControls();
                }
            }
        }
        private void btnAddingProd_Click(object sender, EventArgs e)
        {
            frmAddProduct addProduct = new frmAddProduct();
            DialogResult result = addProduct.ShowDialog();
        }
        private void btnAddSup_Click(object sender, EventArgs e)
        {
            frmAdding_New_Suppliers new_Suppliers = new frmAdding_New_Suppliers();
            DialogResult result = new_Suppliers.ShowDialog();
        }
        private void btnAddSup_Click_1(object sender, EventArgs e)
        {
            frmAdding_New_Suppliers new_Suppliers = new frmAdding_New_Suppliers();
            DialogResult result = new_Suppliers.ShowDialog();
        }
        private void btnAddingProd_Click_1(object sender, EventArgs e)
        {
            frmAddProduct addProduct = new frmAddProduct();
            DialogResult result = addProduct.ShowDialog();
        }

        private void cboSuppliers_SelectedValueChanged(object sender, EventArgs e) // display Suppliers
        {
            string val;
            val = Convert.ToString(cboSuppliers.SelectedItem);
            if (val != null)
            {
                this.DisplaySupplier();
            }
            else
            {
                MessageBox.Show("Error\n Selected Value Error: VALUE NULL", "ERROR");
                // Roll over and crash
            }
        }

        private void DisplaySuppluer()
        {
            Suppliers sup = new Suppliers();
            int SupIndex = cboSuppliers.SelectedIndex;
            sup = suppliers[SupIndex];
            dgvProds.DataSource = sup;
        }


        private void btnAddProdtoSup_Click(object sender, EventArgs e)
        {
            
          
            Products_Suppliers ps = new Products_Suppliers();
            ps.ProductId = products[cmbProducts.SelectedIndex].ProductId; 
            ps.ProductSupplierId = suppliers[cboSuppliers.SelectedIndex].SupplierId;
            SQLAdapter.SQLAdapter.InsertToDB<Products_Suppliers>(ps, new TravelExpertsDBCon());
            Application.Restart();
        }
    }
}
