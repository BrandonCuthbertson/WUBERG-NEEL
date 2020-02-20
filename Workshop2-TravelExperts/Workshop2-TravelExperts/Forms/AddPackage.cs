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
    public partial class AddPackage : Form
    {
        public AddPackage()
        {
            InitializeComponent();
        }
        public Packages package;
        //to add new packages to the database
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtName, "Package Name") == true &&
                dtpStart.Value < dtpEnd.Value &&
                dtpStart.Value != dtpEnd.Value &&
                Validator.IsPresent(txtDesc, "Description") == true &&
                Validator.IsDecimal(txtBase, "Base Price") == true && Validator.IsNonNegativeDecimal(txtBase, "Base Price") == true &&
                Validator.IsDecimal(txtCommission, "Agency Commission") == true && Validator.IsNonNegativeDecimal(txtCommission, "Agency Commission") == true &&
                Convert.ToDecimal(txtBase.Text) > Convert.ToDecimal(txtCommission.Text)){ //Everything is valid
//Neels Code
                package = new Packages();
                this.PutPackage(package);
                try
                {
                    package.PackageId = TravelExpertsDB.AddPackage(package);
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
                Application.Restart();//You have to reload the form when you submit
            }
            else //Brandons Code
            {

                if (Validator.IsPresent(txtName, "Package Name") == false)//Package Name Error
                {
                    lblErrorName.Text = "Package Name is Required";
                    ErrorBoxPackageName.Visible = true;
                }
                else
                {
                    ErrorBoxPackageName.Visible = false;
                    lblErrorName.Text= "";
                }

                if (dtpStart.Value > dtpEnd.Value) //Date Error Start is > End
                {
                    lblErrorDate.Text = "Start Date must be after End Date";
                    ErrorBoxStart.Visible = true;
                    ErrorBoxEnd.Visible = true;
                }
                else if (dtpStart.Value == dtpEnd.Value)//Date Error Start is = End
                {
                    lblErrorDate.Text = "Start Date cannot be on End Date";
                    ErrorBoxStart.Visible = true;
                    ErrorBoxEnd.Visible = true;
                }
                else
                {
                    lblErrorDate.Text = "";
                    ErrorBoxStart.Visible = false;
                    ErrorBoxEnd.Visible = false;
                }

                if (Validator.IsPresent(txtDesc, "Description") == false)//Description Error
                {
                    lblErrorDesc.Text = "Please insert a description";
                    ErrorBoxDescription.Visible = true;
                }
                else
                {
                    lblErrorDesc.Text = "";
                    ErrorBoxDescription.Visible = false;
                }

                if (Validator.IsDecimal(txtBase, "Base Price") == false) //Base Price Error
                {
                    ErrorBoxBasePrice.Visible = true;
                    lblErrorBasePrice.Text = "Please insert a number that is greater than zero";
                }
                else if (Validator.IsDecimal(txtBase, "Base Price") == true && Validator.IsNonNegativeDecimal(txtBase, "Base Price") == false)
                {
                    ErrorBoxBasePrice.Visible = true;
                    lblErrorBasePrice.Text = "Number inserted must be greater than zero";
                }
                else
                {
                    ErrorBoxBasePrice.Visible = false;
                    lblErrorBasePrice.Text = "";
                }

                if (Validator.IsDecimal(txtCommission, "Agency Commission") == false)//commison error
                {
                    ErrorBoxAgency.Visible = true;
                    lblErrorAgency.Text = "Please insert a number that is greater than zero ";
                }
                else if (Validator.IsDecimal(txtCommission, "Agency Commission") == true && Validator.IsNonNegativeDecimal(txtCommission, "Agency Commission") == false)
                {
                    ErrorBoxAgency.Visible = true;
                    lblErrorAgency.Text = "Number inserted must be greater than zero";
                }
                else if (Validator.IsDecimal(txtCommission, "Agency Commission") == true &&
                    Validator.IsDecimal(txtBase, "Base Price") == true &&
                    Convert.ToDecimal(txtBase.Text) <= Convert.ToDecimal(txtCommission.Text))
                {
                    ErrorBoxAgency.Visible = true;
                    ErrorBoxBasePrice.Visible = true;
                    lblErrorAgency.Text = "Agency Commission cannot be greater than or equal to the Base price";
                }
                else
                {
                    ErrorBoxAgency.Visible = false;

                    lblErrorAgency.Text = "";
                }





            }
            
                /*
                
                */
        }

        public void PutPackage(Packages package)
        {
            package.PkgName = txtName.Text;
            package.PkgStartDate = dtpStart.Value;
            package.PkgEndDate = dtpEnd.Value;
            package.PkgDesc = txtDesc.Text;
            package.PkgBasePrice =Convert.ToDecimal(txtBase.Text);
            package.PkgAgencyCommission =Convert.ToDecimal(txtCommission.Text);
        }
       //to clear the text added before
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            dtpStart.Text = "";
            dtpEnd.Text = "";
            txtDesc.Text = "";
            txtBase.Text = "";
            txtCommission.Text = "";
            dtpStart.Value = DateTime.Today;
            dtpEnd.Value = DateTime.Today;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void AddPackage_Load(object sender, EventArgs e)
        { //Sets all Error Boxes to invisable --Brandon
            ErrorBoxPackageName.Visible = false;
            ErrorBoxStart.Visible = false;
            ErrorBoxEnd.Visible = false;
            ErrorBoxDescription.Visible = false;
            ErrorBoxBasePrice.Visible = false;
            ErrorBoxAgency.Visible = false;
            //lblErrorName.Text = "";
            //lblErrorDate.Text = "";
            //lblErrorDesc.Text = "";
            //lblErrorBasePrice.Text = "";
            //lblErrorAgency.Text = "";
        }
    }
}
