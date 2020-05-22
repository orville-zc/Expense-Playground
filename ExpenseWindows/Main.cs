using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpenseLib;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ExpenseWindows
{
    public partial class MainForm : Form
    {
        public readonly Dictionary<string, string> monthString =
            new Dictionary<string, string> {
                { "a", "January" },
                { "b", "February" },
                { "c", "March" },
                { "d", "April" },
                { "e", "May" },
                { "f", "June" },
                { "g", "July" },
                { "h", "August" },
                { "i", "September" },
                { "j", "October" },
                { "k", "November" },
                { "l", "December" }
        };
        internal List<string> inCat, expCat, units;
        internal Dictionary<string, Dictionary<string, List<Record>>> rec;

        internal string path, year, month;
        internal bool refresh = false;
        internal decimal tax, discount;
        internal TreeNode selected;

        private DataGridViewTextBoxColumn tbcType, tbcCat, tbcAmt, tbcDate, tbcMemo, tbcPrice, tbcID;

        public MainForm()
        {
            InitializeComponent();
            sslDate.Text = DateTime.Today.ToShortDateString();

            tbcAmt = new DataGridViewTextBoxColumn();
            tbcCat = new DataGridViewTextBoxColumn();
            tbcDate = new DataGridViewTextBoxColumn();
            tbcMemo = new DataGridViewTextBoxColumn();
            tbcType = new DataGridViewTextBoxColumn();
            tbcPrice = new DataGridViewTextBoxColumn();
            tbcID = new DataGridViewTextBoxColumn();
            gvRecord.Columns.AddRange(new DataGridViewColumn[] {
                tbcType,
                tbcCat,
                tbcAmt,
                tbcDate,
                tbcMemo,
                tbcPrice,
                tbcID
            });

            tbcType.HeaderText = "Type";
            tbcType.Name = "tbcType";

            tbcCat.HeaderText = "Category";
            tbcCat.Name = "tbcCat";

            tbcAmt.HeaderText = "Amount";
            tbcAmt.Name = "tbcAmt";

            tbcDate.HeaderText = "Date";
            tbcDate.Name = "tbcDate";

            tbcMemo.HeaderText = "Memo";
            tbcMemo.Name = "tbcMemo";

            tbcPrice.HeaderText = "Price";
            tbcPrice.Name = "tbcPrice";

            tbcID.HeaderText = "ID";
            tbcID.Name = "tbcID";
            tbcID.Visible = false;

            if (File.Exists("path.ini"))
            {
                string conf = File.ReadAllText("path.ini");
                path = conf.Substring(5);
                if (conf.StartsWith("PATH=") && File.Exists(path))
                    FileOpened(JObject.Parse(File.ReadAllText(path)));
            }
        }

        private void FileOpened(JObject json)
        {
            Text = path + " - Expense";
            sslMsg.Text = "Ready.";

            File.WriteAllText("path.ini", "PATH=" + path);

            inCat = Data.ReadCategory(json, true);
            expCat = Data.ReadCategory(json, false);
            units = Data.ReadUnit(json);
            rec = Data.ReadRecords(json);
            tax = Data.ReadTax(json);
            discount = Data.ReadDisct(json);

            RefreshTv();
        }

        private void ChangeMade()
        {
            RefreshGv();
            RefreshTv();
            if (Text[0] != '*') Text = "*" + Text;
            refresh = false;
        }

        private void RefreshTv()
        {
            tvByMonth.Nodes.Clear();

            foreach (string year in rec.Keys.OrderByDescending(i => i))
            {
                TreeNode ynode = new TreeNode();
                ynode.Name = ynode.Text = year;
                tvByMonth.Nodes.Add(ynode);
                ynode.Nodes.Clear();
                foreach (string month in rec[year].Keys.OrderByDescending(i => i))
                {
                    TreeNode mnode = new TreeNode(monthString[month]);
                    mnode.Name = month;
                    ynode.Nodes.Add(mnode);
                    if (selected != null &&
                            selected.Parent != null &&
                            ynode.Text == selected.Parent.Text &&
                            mnode.Text == selected.Text)
                        tvByMonth.SelectedNode = selected = mnode;
                }
            }
            tvByMonth.ExpandAll();
        }

        private void tvByMonth_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            e.Cancel = true;
        }
        private void tvByMonth_AfterSelect(object sender, TreeViewEventArgs e)
        {
            selected = tvByMonth.SelectedNode;
            if (selected.Parent != null)
                year = selected.Parent.Name;
            if (selected != null)
                month = selected.Name;
            RefreshGv();
        }
        private void RefreshGv()
        {
            gvRecord.Rows.Clear();
            if (selected == null || selected.Parent == null) return;
            //if not selecting a month, just clear the grid view
            int n = 0;
            //declare a counter
            foreach (Record r in rec[year][month])
            {
                string cate = (r.Category == -1) ?
                                "Uncategorized" :
                                (r.Exp ? expCat[r.Category] : inCat[r.Category]),
                    price = (r.Qty == 0m) ? "N/A" : (r.Amount / r.Qty).ToString("C2");
                if (r.Unit != -1) price += "/" + units[r.Unit];

                gvRecord.Rows.Add(
                    r.Exp ? "Expense" : "Income",
                    cate,
                    r.Amount.ToString("C2"),
                    r.Date.ToShortDateString(),
                    r.Memo,
                    price,
                    n
                );

                n++;
                if (gvRecord.SortedColumn == null)
                    gvRecord.Sort(tbcDate, ListSortDirection.Descending);
                else
                    gvRecord.Sort(gvRecord.SortedColumn, (ListSortDirection)(gvRecord.SortOrder - 1));
            }
        }

        private void gvRecord_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int id = Convert.ToInt32(gvRecord.Rows[e.RowIndex].Cells[6].Value);
            new EntryForm(rec[year][month][id], false).ShowDialog();
            if (refresh) ChangeMade();
            foreach (DataGridViewRow row in gvRecord.Rows)
                row.Selected = (Convert.ToInt32(row.Cells[6].Value) == id) ? true : false;
        }

        private void gvRecord_SelectionChanged(object sender, EventArgs e)
        {
            tsmiDelete.Enabled = (gvRecord.SelectedRows.Count != 0 && !tsmiDelete.Enabled);
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            if (Text[0] != '*') return;
            File.WriteAllText(path, Data.WriteJson(inCat, expCat, rec, units, tax, discount));
            Text = path + " - Expense";
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void tsmiAdd_Click(object sender, EventArgs e)
        {
            new EntryForm(
                    new Record(1m, null, null, null, String.Empty, null, null),
                true).ShowDialog();
            ChangeMade();
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gvRecord.SelectedRows)
                rec[year][month].RemoveAt((int)row.Cells[6].Value);

            if (rec[year][month].Count == 0)
            {
                rec[year].Remove(month);
                selected = null;
            }
            if (rec[year].Count == 0)
                rec.Remove(year);

            ChangeMade();
        }

        private void TaxDisc_Click(object sender, EventArgs e)
        {
            new TaxDisc(((ToolStripMenuItem)sender).Name == "tsmiTax").ShowDialog();
        }
    }
}
