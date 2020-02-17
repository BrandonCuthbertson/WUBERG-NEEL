namespace Workshop2_TravelExperts
{
    partial class EditPackage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPackage));
            this.PackageId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPkgName = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtAgency = new System.Windows.Forms.TextBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblErrorPackageName = new System.Windows.Forms.Label();
            this.lblErrorStart = new System.Windows.Forms.Label();
            this.lblErrorEnd = new System.Windows.Forms.Label();
            this.lblErrorPackageDesc = new System.Windows.Forms.Label();
            this.lblErrorBasePrice = new System.Windows.Forms.Label();
            this.lblErrorAgencyCommission = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblErrorNameMassage = new System.Windows.Forms.Label();
            this.lblDateError = new System.Windows.Forms.Label();
            this.lblDescError = new System.Windows.Forms.Label();
            this.lblBaseError = new System.Windows.Forms.Label();
            this.lblAgencyError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PackageId
            // 
            this.PackageId.AutoSize = true;
            this.PackageId.BackColor = System.Drawing.Color.Transparent;
            this.PackageId.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PackageId.Location = new System.Drawing.Point(93, 36);
            this.PackageId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PackageId.Name = "PackageId";
            this.PackageId.Size = new System.Drawing.Size(107, 24);
            this.PackageId.TabIndex = 0;
            this.PackageId.Text = "PackageID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(57, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Package Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(20, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Package Start Date: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(28, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Package End Date: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(8, 268);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Package Description: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(21, 327);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Package Base Price: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(40, 365);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(142, 48);
            this.label7.TabIndex = 6;
            this.label7.Text = "Package Agency\r\n  Commission: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPkgName
            // 
            this.txtPkgName.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtPkgName.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPkgName.Location = new System.Drawing.Point(224, 84);
            this.txtPkgName.Name = "txtPkgName";
            this.txtPkgName.Size = new System.Drawing.Size(378, 32);
            this.txtPkgName.TabIndex = 7;
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtDesc.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDesc.Location = new System.Drawing.Point(222, 260);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(378, 32);
            this.txtDesc.TabIndex = 9;
            // 
            // txtBase
            // 
            this.txtBase.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtBase.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBase.Location = new System.Drawing.Point(224, 319);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(378, 32);
            this.txtBase.TabIndex = 10;
            // 
            // txtAgency
            // 
            this.txtAgency.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtAgency.ForeColor = System.Drawing.SystemColors.Window;
            this.txtAgency.Location = new System.Drawing.Point(224, 381);
            this.txtAgency.Name = "txtAgency";
            this.txtAgency.Size = new System.Drawing.Size(378, 32);
            this.txtAgency.TabIndex = 11;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(223, 142);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(378, 32);
            this.dtpStart.TabIndex = 12;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(223, 202);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(378, 32);
            this.dtpEnd.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(224, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 37);
            this.label1.TabIndex = 14;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DimGray;
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSubmit.Location = new System.Drawing.Point(424, 479);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(182, 31);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DimGray;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(48, 479);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(182, 31);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "<&Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DimGray;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(236, 479);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(182, 31);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblErrorPackageName
            // 
            this.lblErrorPackageName.BackColor = System.Drawing.Color.Red;
            this.lblErrorPackageName.Location = new System.Drawing.Point(219, 80);
            this.lblErrorPackageName.Name = "lblErrorPackageName";
            this.lblErrorPackageName.Size = new System.Drawing.Size(388, 36);
            this.lblErrorPackageName.TabIndex = 20;
            // 
            // lblErrorStart
            // 
            this.lblErrorStart.BackColor = System.Drawing.Color.Red;
            this.lblErrorStart.Location = new System.Drawing.Point(218, 138);
            this.lblErrorStart.Name = "lblErrorStart";
            this.lblErrorStart.Size = new System.Drawing.Size(388, 36);
            this.lblErrorStart.TabIndex = 21;
            // 
            // lblErrorEnd
            // 
            this.lblErrorEnd.BackColor = System.Drawing.Color.Red;
            this.lblErrorEnd.Location = new System.Drawing.Point(218, 198);
            this.lblErrorEnd.Name = "lblErrorEnd";
            this.lblErrorEnd.Size = new System.Drawing.Size(388, 36);
            this.lblErrorEnd.TabIndex = 22;
            // 
            // lblErrorPackageDesc
            // 
            this.lblErrorPackageDesc.BackColor = System.Drawing.Color.Red;
            this.lblErrorPackageDesc.Location = new System.Drawing.Point(217, 256);
            this.lblErrorPackageDesc.Name = "lblErrorPackageDesc";
            this.lblErrorPackageDesc.Size = new System.Drawing.Size(388, 36);
            this.lblErrorPackageDesc.TabIndex = 23;
            // 
            // lblErrorBasePrice
            // 
            this.lblErrorBasePrice.BackColor = System.Drawing.Color.Red;
            this.lblErrorBasePrice.Location = new System.Drawing.Point(219, 315);
            this.lblErrorBasePrice.Name = "lblErrorBasePrice";
            this.lblErrorBasePrice.Size = new System.Drawing.Size(388, 36);
            this.lblErrorBasePrice.TabIndex = 24;
            // 
            // lblErrorAgencyCommission
            // 
            this.lblErrorAgencyCommission.BackColor = System.Drawing.Color.Red;
            this.lblErrorAgencyCommission.Location = new System.Drawing.Point(219, 377);
            this.lblErrorAgencyCommission.Name = "lblErrorAgencyCommission";
            this.lblErrorAgencyCommission.Size = new System.Drawing.Size(388, 36);
            this.lblErrorAgencyCommission.TabIndex = 25;
            // 
            // lblError
            // 
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(44, 513);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(577, 24);
            this.lblError.TabIndex = 19;
            // 
            // lblErrorNameMassage
            // 
            this.lblErrorNameMassage.AutoSize = true;
            this.lblErrorNameMassage.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorNameMassage.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorNameMassage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNameMassage.Location = new System.Drawing.Point(223, 118);
            this.lblErrorNameMassage.Name = "lblErrorNameMassage";
            this.lblErrorNameMassage.Size = new System.Drawing.Size(0, 21);
            this.lblErrorNameMassage.TabIndex = 26;
            // 
            // lblDateError
            // 
            this.lblDateError.AutoSize = true;
            this.lblDateError.BackColor = System.Drawing.Color.Transparent;
            this.lblDateError.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateError.ForeColor = System.Drawing.Color.Red;
            this.lblDateError.Location = new System.Drawing.Point(221, 236);
            this.lblDateError.Name = "lblDateError";
            this.lblDateError.Size = new System.Drawing.Size(0, 21);
            this.lblDateError.TabIndex = 27;
            // 
            // lblDescError
            // 
            this.lblDescError.AutoSize = true;
            this.lblDescError.BackColor = System.Drawing.Color.Transparent;
            this.lblDescError.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescError.ForeColor = System.Drawing.Color.Red;
            this.lblDescError.Location = new System.Drawing.Point(223, 293);
            this.lblDescError.Name = "lblDescError";
            this.lblDescError.Size = new System.Drawing.Size(0, 21);
            this.lblDescError.TabIndex = 28;
            // 
            // lblBaseError
            // 
            this.lblBaseError.AutoSize = true;
            this.lblBaseError.BackColor = System.Drawing.Color.Transparent;
            this.lblBaseError.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseError.ForeColor = System.Drawing.Color.Red;
            this.lblBaseError.Location = new System.Drawing.Point(223, 352);
            this.lblBaseError.Name = "lblBaseError";
            this.lblBaseError.Size = new System.Drawing.Size(0, 21);
            this.lblBaseError.TabIndex = 29;
            // 
            // lblAgencyError
            // 
            this.lblAgencyError.AutoSize = true;
            this.lblAgencyError.BackColor = System.Drawing.Color.Transparent;
            this.lblAgencyError.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgencyError.ForeColor = System.Drawing.Color.Red;
            this.lblAgencyError.Location = new System.Drawing.Point(223, 416);
            this.lblAgencyError.Name = "lblAgencyError";
            this.lblAgencyError.Size = new System.Drawing.Size(0, 21);
            this.lblAgencyError.TabIndex = 30;
            // 
            // EditPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Workshop2_TravelExperts.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(671, 606);
            this.Controls.Add(this.lblAgencyError);
            this.Controls.Add(this.lblBaseError);
            this.Controls.Add(this.lblDescError);
            this.Controls.Add(this.lblDateError);
            this.Controls.Add(this.lblErrorNameMassage);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.txtAgency);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtPkgName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PackageId);
            this.Controls.Add(this.lblErrorPackageName);
            this.Controls.Add(this.lblErrorStart);
            this.Controls.Add(this.lblErrorEnd);
            this.Controls.Add(this.lblErrorPackageDesc);
            this.Controls.Add(this.lblErrorBasePrice);
            this.Controls.Add(this.lblErrorAgencyCommission);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditPackage";
            this.Text = "EditPackage";
            this.Load += new System.EventHandler(this.EditPackage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PackageId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPkgName;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtAgency;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblErrorPackageName;
        private System.Windows.Forms.Label lblErrorStart;
        private System.Windows.Forms.Label lblErrorEnd;
        private System.Windows.Forms.Label lblErrorPackageDesc;
        private System.Windows.Forms.Label lblErrorBasePrice;
        private System.Windows.Forms.Label lblErrorAgencyCommission;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblErrorNameMassage;
        private System.Windows.Forms.Label lblDateError;
        private System.Windows.Forms.Label lblDescError;
        private System.Windows.Forms.Label lblBaseError;
        private System.Windows.Forms.Label lblAgencyError;
    }
}