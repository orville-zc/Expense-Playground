using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ExpenseLib;

namespace ExpenseWindows
{
    public partial class EntryForm : Form
    {
        internal Record r;
        public EntryForm(Record r, bool edit)
        {
            InitializeComponent();

            Text = (edit ? "Edit" : "Create") + Text;

            this.r = r;

            lblAmt.Text = r.Amount.ToString("N2");
            (r.Exp ? radExpenses : radIncome).Checked = true;

            InitCat();
            cboCat.SelectedIndex = r.Category + 1;

            dtpRec.Value = r.Date;

            txtMemo.Text = r.Memo;

            txtQty.Text = r.Qty.ToString();

            cboUnit.Items.AddRange(Program.frmMain.units.ToArray());
            cboUnit.SelectedIndex = r.Unit + 1;
        }

        private void InitCat()
        {
            cboCat.Items.Clear();
            cboCat.Items.AddRange(new object[] { "Uncategorized" });
            cboCat.SelectedIndex = 0;
            if (radExpenses.Checked)
                cboCat.Items.AddRange(Program.frmMain.expCat.ToArray());
            else
                cboCat.Items.AddRange(Program.frmMain.inCat.ToArray());
        }

        private void radExpenses_CheckedChanged(object sender, EventArgs e)
        {
            InitCat();
            cboCat.SelectedIndex = 0;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (
                lblAmt.Text != r.Amount.ToString("N2") ||
                r.Exp != radExpenses.Checked ||
                cboCat.SelectedIndex != r.Category + 1 ||
                dtpRec.Value != r.Date ||
                txtMemo.Text != r.Memo ||
                txtQty.Text != r.Qty.ToString() ||
                cboUnit.SelectedIndex != r.Unit + 1
                )
                try
                {
                    decimal amt = Convert.ToDecimal(lblAmt.Text),
                        qty = Convert.ToDecimal(txtQty.Text);
                    r.Amount = amt;
                    r.Exp = radExpenses.Checked;
                    r.Category = cboCat.SelectedIndex - 1;
                    r.Date = dtpRec.Value;
                    r.Memo = txtMemo.Text;
                    r.Qty = qty;
                    r.Unit = cboUnit.SelectedIndex - 1;
                    Program.frmMain.refresh = true;
                    Close();
                }
                catch (FormatException)
                {
                    Text = "Please enter correct amount and quantity.";
                }
            else
                Close();
        }
    }
}
