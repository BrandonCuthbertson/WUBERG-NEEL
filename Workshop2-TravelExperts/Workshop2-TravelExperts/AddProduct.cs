using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop2_TravelExperts
{
    public partial class frmAddProduct : Form
    {
        Products prod;
        List<Products> products;
        public frmAddProduct()
        {
            InitializeComponent();
            ErrorBox.Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtName, "Product Name") == true)
            {
                prod = new Products();
                this.PutProducts(prod);
                try
                {
                    prod.ProductId = TravelExpertsDB.AddProduct(prod);
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
                Application.Restart();
            }
            else
            {
                ErrorBox.Visible = true;
                lblError.Text = "Please insert a valid Product Name";
            }

        }

        private void PutProducts(Products products)
        {
            products.ProdName = txtName.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            SQLAdapter.SQLAdapter.GetFromDB(out products, new TravelExpertsDBCon());
            this.FillData();
        }
        private void FillData()
        {
            try
            {
                dgvProds.DataSource = products;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString()); ;
            }
        }
    }
}
