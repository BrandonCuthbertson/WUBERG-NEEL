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
    public partial class frmAdding_New_Suppliers : Form
    {
        Suppliers supp;
        public frmAdding_New_Suppliers()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
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

        private void PutSuppliers(Suppliers suppliers)
        {
            suppliers.SupName = txtSup.Text;       
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSup.Text = "";
        }
    }
}
