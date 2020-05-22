using System;
using System.Windows.Forms;

namespace ExpenseWindows
{
    public partial class TaxDisc : Form
    {
        private bool isTax;
        private decimal oldRate;
        public TaxDisc(bool isTax)
        {
            InitializeComponent();
            this.isTax = isTax;
            Text += (isTax ? "Tax" : "Discount") + " Rate";
            oldRate = isTax ? (Program.frmMain.tax - 1m) : (Program.frmMain.discount);
            txtRate.Text = (oldRate * 100m).ToString("G29");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (isTax)
            {
                Program.frmMain.tax = (Convert.ToInt32(txtRate.Text) + 100m) / 100m;
                if (Program.frmMain.Text[0] != '*' && oldRate != Program.frmMain.tax)
                    Program.frmMain.Text = "*" + Program.frmMain.Text;
            }
            else
            {
                decimal d = Decimal.Truncate(Decimal.Parse(txtRate.Text));
                if (d <= 0m || d > 100m)
                {
                    Text = "Check the input";
                    return;
                }
                Program.frmMain.discount = d / 100m;
                if (Program.frmMain.Text[0] != '*' && oldRate != Program.frmMain.discount)
                    Program.frmMain.Text = "*" + Program.frmMain.Text;
            }
            Close();
        }

        private void Esc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
