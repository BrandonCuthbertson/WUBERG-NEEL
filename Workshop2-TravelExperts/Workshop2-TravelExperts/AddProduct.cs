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
        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
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

        private void PutProducts(Products products)
        {
            products.ProdName = txtName.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
        }
    }
}
