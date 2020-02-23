using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop2_TravelExperts
{
    public partial class frmAdding_New_Suppliers : Form
    {
        Suppliers supp;
        List<Suppliers> suppliers;
        public frmAdding_New_Suppliers()
        {
            InitializeComponent();
            ErrorBoxSup.Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(Validator.IsPresent(txtSup, "Suppliers")==true) //neels code
            {
                supp = new Suppliers();
            this.PutSuppliers(supp);
            try
            {
                supp.SupplierId = TravelExpertsDB.AddSuppliers(supp);
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
                ErrorBoxSup.Visible = true;
                lblError.Text = "Please insert a Supplier Name";
            }
            
        }

        private void PutSuppliers(Suppliers suppliers)
        {
            suppliers.SupName = txtSup.Text;       
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSup.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAdding_New_Suppliers_Load(object sender, EventArgs e)
        {
            SQLAdapter.SQLAdapter.GetFromDB(out suppliers, new TravelExpertsDBCon());
            this.FillData();
        }
        private void FillData()
        {
            try
            {
                dgvSupp.DataSource = suppliers;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString()); ;
            }
        }
    }
}
