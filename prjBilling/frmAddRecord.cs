﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjBilling
{
    public partial class frmAddRecord : Form
    {
        public Int64 branchId { get; set; }
        public bool addTransaction { get; set; }
        public Int64 billingId { get; set; }
        
        public frmAddRecord()
        {
            InitializeComponent();
        }

        private void frmAddRecord_Load(object sender, EventArgs e)
        {
            LoadDetails();
            if(addTransaction == false)
            {
                txtAddress.ReadOnly = false;
                GetBillingById();
            }

        }
        private void GetBillingById()
        {
            try
            {
                clsBilling b = new clsBilling();
                b.BillingId = billingId;
                clsCustomer c = new clsCustomer();
                txtAddress.Text = c.customeraddress;
                clsBillingDV dv = new clsBillingDV();
                dv.GetBillingById(b);
                comboBoxCustomer.SelectedValue = b.CustomerId;
                txtBilledTo.Text = b.BilledTo;
                txtTIN.Text = b.TIN;
                editDate.Value = Convert.ToDateTime(b.BillingDate);
                txtTerms.Text = b.Terms;
                txtStyle.Text = b.BusinessStyle;
                clsCustomerDV cv = new clsCustomerDV();
                c.customerid = b.CustomerId;
                cv.GetCustomerAddress(c);
                txtAddress.Text = c.customeraddress;
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message, "Billing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDetails()
        {
            try
            {
                clsCustomerDV dv = new clsCustomerDV();
                comboBoxCustomer.DataSource = dv.GetCustomerID().AsDataView();
                comboBoxCustomer.DisplayMember = "customername";
                comboBoxCustomer.ValueMember = "customerid";
                editDate.Value = DateTime.Now;
                clsCustomer cts = new clsCustomer();
                cts.customerid = Convert.ToInt64(comboBoxCustomer.SelectedValue.ToString());
                clsCustomerDV bil = new clsCustomerDV();
                bil.GetCustomerAddress(cts);
                txtAddress.Text = cts.customeraddress;
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message, "Billing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void comboBoxCustomer_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            try
            {
                clsCustomer cts = new clsCustomer();
                cts.customerid = Convert.ToInt64(comboBoxCustomer.SelectedValue.ToString());
                clsCustomerDV bil = new clsCustomerDV();
                bil.GetCustomerAddress(cts);
                txtAddress.Text = cts.customeraddress;
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message, "Billing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(addTransaction == true)
            {
                clsBilling cbil = new clsBilling();
                cbil.CustomerId = Convert.ToInt64(comboBoxCustomer.SelectedValue);
                cbil.BilledTo = txtBilledTo.Text;
                cbil.TIN = txtTIN.Text;
                cbil.BranchId = branchId;
                cbil.BillingRefNum = txtBillRef.Text;
                cbil.BillingDate = Convert.ToDateTime(editDate.Value);
                cbil.Terms = txtTerms.Text;
                cbil.BusinessStyle = txtStyle.Text;
                clsBillingDV dv = new clsBillingDV();
                dv.AddRecord(cbil);
                txtBillNo.Text = dv.GetBillNumChar();
                lblID.Text = cbil.BillingId.ToString();

            }else
            {
                clsBilling cbil = new clsBilling();
                cbil.CustomerId = Convert.ToInt64(comboBoxCustomer.SelectedValue);
                cbil.BilledTo = txtBilledTo.Text;
                cbil.TIN = txtTIN.Text;
                cbil.BranchId = branchId;
                cbil.BillingDate = Convert.ToDateTime(editDate.Value);
                cbil.Terms = txtTerms.Text;
                cbil.BusinessStyle = txtStyle.Text;
                cbil.BillingId = billingId;
                clsBillingDV dv = new clsBillingDV();
                dv.UpdateRecord(cbil);

                frmBillingList frm = new frmBillingList();
                frm.Show();
                this.Hide();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
