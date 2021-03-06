﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop2_TravelExperts {
    public partial class EditPackage : Form {
        public Packages package;
        public EditPackage(Packages pack) {
            InitializeComponent();
            package = pack;
        }
        private void EditPackage_Load(object sender, EventArgs e) {
            this.DisplayPackage();

            //hides error bboxes -- BC
            lblErrorPackageName.Visible = false;
            lblErrorStart.Visible = false;
            lblErrorEnd.Visible = false;
            lblErrorPackageDesc.Visible = false;
            lblErrorBasePrice.Visible = false;
            lblErrorAgencyCommission.Visible = false;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {   //brandons validations
            if (Validator.IsPresent(txtPkgName, "Package Name") == true &&
                dtpStart.Value < dtpEnd.Value &&
                dtpStart.Value != dtpEnd.Value &&
                Validator.IsPresent(txtDesc, "Description") == true &&
                Validator.IsDecimal(txtBase, "Base Price") == true && Validator.IsNonNegativeDecimal(txtBase, "Base Price") == true &&
                Validator.IsDecimal(txtAgency, "Agency Commission") == true && Validator.IsNonNegativeDecimal(txtAgency, "Agency Commission") ==true &&
                Convert.ToDecimal(txtBase.Text) > Convert.ToDecimal(txtAgency.Text)
                )//Everything is valid
            {
                //Neels Code
                Packages newPack = new Packages();
                newPack.PackageId = package.PackageId;
                this.PutPackageData(newPack);
                try
                {
                    if (!TravelExpertsDB.UpdatePackage(package, newPack))
                    {
                        MessageBox.Show("Another user has updated or " +
                            "deleted that customer.", "Database Error");
                        this.DialogResult = DialogResult.Retry;
                    }
                    else // success
                    {
                        package = newPack;
                        this.DialogResult = DialogResult.OK;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
               

                Application.Restart();//You have to reload the form when you submit
            }
            else //go threw each box and tell its not valid by BRANDON
            {
                if (Validator.IsPresent(txtPkgName, "Package Name") == false)//Package Name Error
                {
                    lblErrorNameMassage.Text = "Package Name is Required";
                    lblErrorPackageName.Visible = true;
                }
                else
                {
                    lblErrorPackageName.Visible = false;
                    lblErrorNameMassage.Text = "";
                }
                ////////////////////////////////////////////////////////////////
                if (dtpStart.Value > dtpEnd.Value) //Date Error Start is > End
                {
                    lblDateError.Text = "Start Date must be after End Date";
                    lblErrorStart.Visible = true;
                    lblErrorEnd.Visible = true;
                }
                else if (dtpStart.Value == dtpEnd.Value)//Date Error Start is = End
                {
                    lblDateError.Text = "Start Date cannot be on End Date";
                    lblErrorStart.Visible = true;
                    lblErrorEnd.Visible = true;
                }
                else
                {
                    lblDateError.Text = "";
                    lblErrorStart.Visible = false;
                    lblErrorEnd.Visible = false;
                }
                ////////////////////////////////////////////////////////////////
                if (Validator.IsPresent(txtDesc, "Description") == false)//Description Error
                {
                    lblDescError.Text = "Please insert a description";
                    lblErrorPackageDesc.Visible = true;
                }
                else
                {
                    lblDescError.Text = "";
                    lblErrorPackageDesc.Visible = false;
                }
                ////////////////////////////////////////////////////////////////
                if (Validator.IsDecimal(txtBase, "Base Price") == false) //Base Price Error
                {
                    lblErrorBasePrice.Visible = true;
                    lblBaseError.Text = "Please insert a number that is greater than zero";
                }
                else if (Validator.IsDecimal(txtBase, "Base Price") == true && Validator.IsNonNegativeDecimal(txtBase, "Base Price") == false)
                {
                    lblErrorBasePrice.Visible = true;
                    lblBaseError.Text = "Number inserted must be greater than zero";
                }
                else
                {
                    lblErrorBasePrice.Visible = false;
                    lblBaseError.Text = "";
                }
                ////////////////////////////////////////////////////////////////
                if (Validator.IsDecimal(txtAgency, "Agency Commission") == false )//commison error
                {
                    lblErrorAgencyCommission.Visible = true;
                    lblAgencyError.Text = "Please insert a number that is greater than zero ";
                }
                else if (Validator.IsDecimal(txtAgency, "Agency Commission") == true && Validator.IsNonNegativeDecimal(txtAgency, "Agency Commission") == false)
                {
                    lblErrorAgencyCommission.Visible = true;
                    lblAgencyError.Text = "Number inserted must be greater than zero";
                }
                else if (Validator.IsDecimal(txtAgency, "Agency Commission") == true &&
                    Validator.IsDecimal(txtBase, "Base Price") == true && 
                    Convert.ToDecimal(txtBase.Text) <= Convert.ToDecimal(txtAgency.Text))
                {
                    lblErrorAgencyCommission.Visible = true;
                    lblErrorBasePrice.Visible = true;
                    lblAgencyError.Text = "Agency Commission cannot be greater than or equal to the Base price";
                }
                else
                {
                    lblErrorAgencyCommission.Visible = false;
                    
                    lblAgencyError.Text = "";
                }
                ////////////////////////////////////////////////////////////////
            }
            /* */
        }
        private void DisplayPackage() {
            label1.Text = Convert.ToString(package.PackageId);
            txtPkgName.Text = package.PkgName;
            dtpStart.Text = Convert.ToString(package.PkgStartDate);
            dtpEnd.Text = Convert.ToString(package.PkgEndDate);
            txtDesc.Text = package.PkgDesc;
            txtBase.Text = (package.PkgBasePrice).ToString("#,0.00");
          
            txtAgency.Text = (package.PkgAgencyCommission).ToString("#,0.00");
        }
        private void btnBack_Click(object sender, EventArgs e) { //Added by BC
            this.Close();
            
        }
        private void PutPackageData(Packages package) {
            package.PkgName = txtPkgName.Text;
            package.PkgStartDate = dtpStart.Value;
            package.PkgEndDate = dtpEnd.Value;
            package.PkgDesc = txtDesc.Text;
            package.PkgBasePrice = Convert.ToDecimal(txtBase.Text);
            package.PkgAgencyCommission = Convert.ToDecimal(txtAgency.Text);
        }
        private void btnClear_Click(object sender, EventArgs e) {
            txtPkgName.Text = "";
            dtpStart.Text = "";
            dtpEnd.Text = "";
            txtBase.Text = "";
            txtDesc.Text = "";
            txtAgency.Text = "";
            dtpStart.Value = DateTime.Today;
            dtpEnd.Value = DateTime.Today;
        }
    }
}
