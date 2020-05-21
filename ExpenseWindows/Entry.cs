using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ExpenseLib;

namespace ExpenseWindows
{
    public partial class EntryForm : Form
    {
        private enum Operator { None, Plus, Minus}

        internal Record r;
        private bool taxed = false, discApp = false, dot = false;
        private decimal tmp = 0m;
        //temporary number for calculations
        private Operator op = Operator.None;
        private int opp = -1;
        //the position of the operator
        private string defaultText;

        public EntryForm(Record r, bool edit)
        {
            InitializeComponent();

            defaultText = Text = (edit ? "Edit" : "Create") + Text;

            this.r = r;
            tmp = r.Amount;

            lblAmt.Text = r.Amount.ToString("G29");
            dot = (r.Amount != Convert.ToInt32(r.Amount));

            (r.Exp ? radExpenses : radIncome).Checked = true;

            UpdateForm();
            cboCat.SelectedIndex = r.Category + 1;

            dtpRec.Value = r.Date;

            txtMemo.Text = r.Memo;

            txtQty.Text = r.Qty.ToString();

            cboUnit.Items.AddRange(Program.frmMain.units.ToArray());
            cboUnit.SelectedIndex = r.Unit + 1;
        }

        private void UpdateForm()
        {
            cboCat.Items.Clear();
            cboCat.Items.AddRange(new object[] { "Uncategorized" });
            cboCat.SelectedIndex = 0;
            taxed = discApp = false;
            if (radExpenses.Checked)
            {
                cboCat.Items.AddRange(Program.frmMain.expCat.ToArray());
                btnTax.Enabled = true;
                btnDisct.Enabled = true;
            }
            else
            {
                cboCat.Items.AddRange(Program.frmMain.inCat.ToArray());
                btnTax.Enabled = false;
                btnDisct.Enabled = false;
            }
        }

        private void radExpenses_CheckedChanged(object sender, EventArgs e)
        {
            UpdateForm();
            cboCat.SelectedIndex = 0;
            Text = defaultText;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Text = defaultText;
            lblAmt.Text = String.Empty;
            dot = taxed = discApp = false;
            tmp = 0m;
            op = Operator.None;
            opp = -1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Text = defaultText;
            if (lblAmt.Text == String.Empty) return;
            switch (lblAmt.Text[^1])
            {
                case '.':
                    dot = false;
                    break;
                case '+':
                case '-':
                    op = Operator.None;
                    opp = -1;
                    dot = (tmp != Convert.ToInt32(tmp));
                    break;
            }
            lblAmt.Text = lblAmt.Text[0..^1];
            if (lblAmt.Text == String.Empty || lblAmt.Text == ".")
            {
                tmp = 0m;
            }
            else if (op == Operator.None) try
                {
                    tmp = Convert.ToDecimal(lblAmt.Text);
                }
                catch (FormatException)
                {
                    Text = "Please ensure the amount is correct.";
                }
            taxed = discApp = false;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            Text = defaultText;
            if (dot) return;
            else
            {
                lblAmt.Text += ".";
                dot = true;
                taxed = discApp = false;
            }
        }

        private void Calculate(decimal n2)
        {
            switch (op)
            {
                case Operator.Plus:
                    tmp += n2;
                    break;
                case Operator.Minus:
                    tmp -= n2;
                    break;
            }
            op = Operator.None;
            opp = -1;
            dot = (tmp != Convert.ToInt32(tmp));
            taxed = discApp = false;
            lblAmt.Text = tmp.ToString("G29");
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            Text = defaultText;
            if (lblAmt.Text == String.Empty) lblAmt.Text = "0";
            char opt = ((Button)sender).Text[1];  //operator
            if (new[] { '+', '-' }.Contains(lblAmt.Text[^1]))
                lblAmt.Text = lblAmt.Text[0..^1];
            else try
                {
                    if (op == Operator.None)
                        tmp = Convert.ToDecimal(lblAmt.Text);
                    else
                        Calculate(Convert.ToDecimal(lblAmt.Text.Substring(opp + 1)));
                }
                catch (FormatException)
                {
                    Text = "Please ensure the amount is correct.";
                }
            switch (opt)
            {
                case '+':
                    op = Operator.Plus;
                    break;
                case '-':
                    op = Operator.Minus;
                    break;
            }
            opp = lblAmt.Text.Length;
            lblAmt.Text += opt;
            dot = taxed = discApp = false;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Text = defaultText;
            if (lblAmt.Text == String.Empty) return;
            if (new[] { '+', '-' }.Contains(lblAmt.Text[^1]) || op == Operator.None)
            {
                lblAmt.Text = tmp.ToString("G29");
                op = Operator.None;
                opp = -1;
                dot = taxed = discApp = false;
            }
            else try
                {
                    Calculate(Convert.ToDecimal(lblAmt.Text.Substring(opp + 1)));
                }
                catch (FormatException)
                {
                    Text = "Please ensure the amount is correct.";
                }
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            Text = defaultText;
            lblAmt.Text += ((Button)sender).Text[1];
            if (op == Operator.None)
                tmp = Convert.ToDecimal(lblAmt.Text);
            taxed = discApp = false;
        }

        private void btnTax_Click(object sender, EventArgs e)
        {
            Text = defaultText;
            if (taxed)
            {
                Text = "Tax already applied.";
                return;
            }
            try
            {
                lblAmt.Text = (Convert.ToDecimal(lblAmt.Text) * Program.frmMain.tax).ToString("G29");
                tmp = Convert.ToDecimal(lblAmt.Text);
                dot = (tmp != Convert.ToInt32(tmp));
                taxed = true;
            }
            catch (FormatException)
            {
                Text = "Please ensure the amount is correct.";
            }
        }

        private void btnDisct_Click(object sender, EventArgs e)
        {
            Text = defaultText;
            if (discApp)
            {
                Text = "Discount already applied.";
                return;
            }
            try
            {
                lblAmt.Text = (Convert.ToDecimal(lblAmt.Text) * Program.frmMain.discount).ToString("G29");
                dot = (tmp != Convert.ToInt32(tmp));
                discApp = true;
            }
            catch (FormatException)
            {
                Text = "Please ensure the amount is correct.";
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (
                lblAmt.Text != r.Amount.ToString("G29") ||
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

        private void ForAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
                btnDelete_Click(btnDelete, new EventArgs());
        }
    }
}
